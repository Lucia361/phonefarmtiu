// Decompiled with JetBrains decompiler
// Type: GClass16
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class GClass16
{
  [DllImport("user32.dll", SetLastError = true)]
  private static extern IntPtr FindWindow(string string_0, string string_1);

  [DllImport("User32.dll")]
  public static extern bool EnumChildWindows(
    IntPtr intptr_0,
    GClass16.GDelegate0 gdelegate0_0,
    IntPtr intptr_1);

  [DllImport("User32.dll")]
  public static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

  [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
  private static extern IntPtr FindWindow_1(IntPtr intptr_0, string string_0);

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  private static extern IntPtr SendMessage(
    IntPtr intptr_0,
    uint uint_0,
    IntPtr intptr_1,
    IntPtr intptr_2);

  [DllImport("user32.dll", EntryPoint = "SendMessage")]
  private static extern IntPtr SendMessage_1(
    IntPtr intptr_0,
    int int_0,
    int int_1,
    IntPtr intptr_1);

  [DllImport("user32.dll", EntryPoint = "SendMessage")]
  private static extern IntPtr SendMessage_2(
    IntPtr intptr_0,
    int int_0,
    IntPtr intptr_1,
    IntPtr intptr_2);

  [DllImport("user32.dll", EntryPoint = "SendMessage")]
  private static extern IntPtr SendMessage_3(
    IntPtr intptr_0,
    int int_0,
    IntPtr intptr_1,
    string string_0);

  [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Unicode)]
  public static extern int SendMessage_4(IntPtr intptr_0, int int_0, int int_1, string string_0);

  [DllImport("user32.dll")]
  private static extern IntPtr GetDlgItem(IntPtr intptr_0, int int_0);

  [DllImport("user32.dll")]
  private static extern bool SetDlgItemTextA(IntPtr intptr_0, int int_0, string string_0);

  [DllImport("user32.dll", CharSet = CharSet.Unicode)]
  private static extern IntPtr FindWindowEx(
    IntPtr intptr_0,
    IntPtr intptr_1,
    string string_0,
    string string_1);

  [DllImport("user32.dll")]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static extern bool PostMessage(
    IntPtr intptr_0,
    int int_0,
    IntPtr intptr_1,
    IntPtr intptr_2);

  [DllImport("user32.dll", EntryPoint = "PostMessage")]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static extern bool PostMessage_1(
    IntPtr intptr_0,
    int int_0,
    IntPtr intptr_1,
    string string_0);

  [DllImport("user32.dll")]
  private static extern bool SetForegroundWindow(IntPtr intptr_0);

  [DllImport("user32.dll", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static extern bool GetWindowRect(IntPtr intptr_0, ref GStruct1 gstruct1_0);

  [DllImport("user32", EntryPoint = "EnumChildWindows")]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static extern bool EnumChildWindows_1(
    IntPtr intptr_0,
    GClass16.Delegate0 delegate0_0,
    IntPtr intptr_1);

  [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
  public static extern void mouse_event(
    uint uint_0,
    int int_0,
    int int_1,
    int int_2,
    UIntPtr uintptr_0);

  [DllImport("user32.dll", SetLastError = true)]
  public static extern bool MoveWindow(
    IntPtr intptr_0,
    int int_0,
    int int_1,
    int int_2,
    int int_3,
    bool bool_0);

  [DllImport("user32.dll", SetLastError = true)]
  private static extern uint SendInput(uint uint_0, GStruct2[] gstruct2_0, int int_0);

  [DllImport("user32.dll")]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static extern bool IsWindowVisible(IntPtr intptr_0);

  public static IntPtr smethod_0(string string_0, string string_1 = null)
  {
    IntPtr window = GClass16.FindWindow(string_0, string_1);
    GClass16.SetForegroundWindow(window);
    return window;
  }

  public static IntPtr smethod_1(IntPtr intptr_0)
  {
    GClass16.SetForegroundWindow(intptr_0);
    return intptr_0;
  }

  public static bool smethod_2(IntPtr intptr_0) => GClass16.IsWindowVisible(intptr_0);

  public static IntPtr smethod_3(string string_0, string string_1) => GClass16.FindWindow(string_0, string_1);

  public static List<IntPtr> smethod_4(string string_0, string string_1, int int_0 = 1)
  {
    Process[] processes = Process.GetProcesses();
    List<IntPtr> numList = new List<IntPtr>();
    int num = 0;
    foreach (Process process in ((IEnumerable<Process>) processes).Where<Process>((Func<Process, bool>) (process_0 => process_0.MainWindowHandle != IntPtr.Zero)))
    {
      IntPtr mainWindowHandle = process.MainWindowHandle;
      string str1 = GClass16.smethod_46(mainWindowHandle);
      string str2 = GClass16.smethod_45(mainWindowHandle);
      if (str1 == string_0 || str2 == string_1)
      {
        numList.Add(mainWindowHandle);
        if (num < int_0)
          ++num;
        else
          break;
      }
    }
    return numList;
  }

  public static IntPtr smethod_5(string string_0, string string_1)
  {
    Process[] processes = Process.GetProcesses();
    IntPtr num = IntPtr.Zero;
    foreach (Process process in ((IEnumerable<Process>) processes).Where<Process>((Func<Process, bool>) (process_0 => process_0.MainWindowHandle != IntPtr.Zero)))
    {
      IntPtr mainWindowHandle = process.MainWindowHandle;
      string str1 = GClass16.smethod_46(mainWindowHandle);
      string str2 = GClass16.smethod_45(mainWindowHandle);
      if (str1 == string_0 || str2 == string_1)
      {
        num = mainWindowHandle;
        break;
      }
    }
    return num;
  }

  public static IntPtr smethod_6(IntPtr intptr_0, string string_0, string string_1) => GClass16.FindWindowEx(intptr_0, IntPtr.Zero, string_1, string_0);

  private static IntPtr smethod_7(IntPtr intptr_0, int int_0)
  {
    if (int_0 == 0)
      return intptr_0;
    int num = 0;
    IntPtr intptr_1 = IntPtr.Zero;
    do
    {
      intptr_1 = GClass16.FindWindowEx(intptr_0, intptr_1, "Button", (string) null);
      if (intptr_1 != IntPtr.Zero)
        ++num;
    }
    while (num < int_0 && intptr_1 != IntPtr.Zero);
    return intptr_1;
  }

  public static IntPtr smethod_8(IntPtr intptr_0, int int_0) => GClass16.GetDlgItem(intptr_0, int_0);

  public static List<IntPtr> smethod_9(IntPtr intptr_0_1)
  {
    List<IntPtr> numList = new List<IntPtr>();
    GCHandle gcHandle1 = GCHandle.Alloc((object) numList);
    IntPtr intPtr = GCHandle.ToIntPtr(gcHandle1);
    try
    {
      GClass16.Delegate0 delegate0_0 = (GClass16.Delegate0) ((intptr_0_2, intptr_1) =>
      {
        GCHandle gcHandle2 = GCHandle.FromIntPtr(intptr_1);
        if (gcHandle2.Target == null)
          return false;
        (gcHandle2.Target as List<IntPtr>).Add(intptr_0_2);
        return true;
      });
      GClass16.EnumChildWindows_1(intptr_0_1, delegate0_0, intPtr);
    }
    finally
    {
      gcHandle1.Free();
    }
    return numList;
  }

  public static IntPtr smethod_10(List<IntPtr> list_0, string string_0, string string_1) => list_0.Find((Predicate<IntPtr>) (intptr_0 =>
  {
    string str1 = GClass16.smethod_46(intptr_0);
    string str2 = GClass16.smethod_45(intptr_0);
    return str1 == string_0 || str2 == string_1;
  }));

  public static List<IntPtr> smethod_11(List<IntPtr> list_0, string string_0, string string_1)
  {
    List<IntPtr> numList = new List<IntPtr>();
    return list_0.Where<IntPtr>((Func<IntPtr, bool>) (intptr_0 =>
    {
      string str1 = GClass16.smethod_46(intptr_0);
      string str2 = GClass16.smethod_45(intptr_0);
      return str1 == string_0 || str2 == string_1;
    })).ToList<IntPtr>();
  }

  public static IntPtr smethod_12(IntPtr intptr_0, string string_0, string string_1) => GClass16.smethod_10(GClass16.smethod_9(intptr_0), string_0, string_1);

  public static List<IntPtr> smethod_13(IntPtr intptr_0, string string_0, string string_1) => GClass16.smethod_11(GClass16.smethod_9(intptr_0), string_0, string_1);

  public static bool smethod_14(IntPtr intptr_0, IntPtr intptr_1)
  {
    string str1 = GClass16.smethod_45(intptr_0);
    string str2 = GClass16.smethod_46(intptr_0);
    if (!(str1 == "&Options >>") || !str2.StartsWith("ToolbarWindow32"))
      return true;
    GClass16.SendMessage_2(intptr_0, 0, IntPtr.Zero, IntPtr.Zero);
    return false;
  }

  public static void smethod_15(IntPtr intptr_0, int int_0)
  {
    IntPtr dlgItem = GClass16.GetDlgItem(intptr_0, int_0);
    int int_1 = 0 | int_0 & (int) ushort.MaxValue;
    GClass16.SendMessage_1(intptr_0, 273, int_1, dlgItem);
  }

  public static void smethod_16(IntPtr intptr_0)
  {
    GClass16.SendMessage_2(intptr_0, 513, IntPtr.Zero, IntPtr.Zero);
    GClass16.SendMessage_2(intptr_0, 514, IntPtr.Zero, IntPtr.Zero);
  }

  public static void smethod_17(
    IntPtr intptr_0,
    int int_0,
    int int_1,
    GEnum8 genum8_0 = GEnum8.const_0,
    int int_2 = 1)
  {
    int int_0_1 = 0;
    int int_0_2 = 0;
    if (genum8_0 == GEnum8.const_0)
    {
      int_0_1 = 513;
      int_0_2 = 514;
    }
    if (genum8_0 == GEnum8.const_1)
    {
      int_0_1 = 516;
      int_0_2 = 517;
    }
    IntPtr intptr_2 = GClass16.smethod_48(int_0, int_1);
    if (genum8_0 == GEnum8.const_0 || genum8_0 == GEnum8.const_1)
    {
      for (int index = 0; index < int_2; ++index)
      {
        GClass16.PostMessage(intptr_0, 6, new IntPtr(1), intptr_2);
        GClass16.PostMessage(intptr_0, int_0_1, new IntPtr(1), intptr_2);
        GClass16.PostMessage(intptr_0, int_0_2, new IntPtr(0), intptr_2);
      }
    }
    else
    {
      if (genum8_0 == GEnum8.const_2)
      {
        int_0_1 = 515;
        int_0_2 = 514;
      }
      if (genum8_0 == GEnum8.const_3)
      {
        int_0_1 = 518;
        int_0_2 = 517;
      }
      GClass16.PostMessage(intptr_0, int_0_1, new IntPtr(1), intptr_2);
      GClass16.PostMessage(intptr_0, int_0_2, new IntPtr(0), intptr_2);
    }
  }

  public static void smethod_18(
    IntPtr intptr_0,
    int int_0,
    int int_1,
    int int_2,
    int int_3,
    int int_4 = 10,
    int int_5 = 10,
    double double_0 = 0.05)
  {
    int int_0_1 = 513;
    int int_0_2 = 514;
    IntPtr intptr_2_1 = GClass16.smethod_48(int_0, int_1);
    IntPtr intptr_2_2 = GClass16.smethod_48(int_2, int_3);
    if (int_2 < int_0)
      int_4 *= -1;
    if (int_3 < int_1)
      int_5 *= -1;
    GClass16.PostMessage(intptr_0, 6, new IntPtr(1), intptr_2_1);
    GClass16.PostMessage(intptr_0, int_0_1, new IntPtr(1), intptr_2_1);
    bool flag1 = false;
    bool flag2 = false;
    while (true)
    {
      GClass16.PostMessage(intptr_0, 512, new IntPtr(1), GClass16.smethod_48(int_0, int_1));
      if (int_4 <= 0)
      {
        if (int_0 > int_2)
          int_0 += int_4;
        else
          flag1 = true;
      }
      else if (int_0 < int_2)
        int_0 += int_4;
      else
        flag1 = true;
      if (int_5 > 0)
      {
        if (int_1 < int_3)
          int_1 += int_5;
        else
          flag2 = true;
      }
      else if (int_1 > int_3)
        int_1 += int_5;
      else
        flag2 = true;
      if (!(flag1 & flag2))
        Thread.Sleep(TimeSpan.FromSeconds(double_0));
      else
        break;
    }
    GClass16.PostMessage(intptr_0, int_0_2, new IntPtr(0), intptr_2_2);
  }

  public static void smethod_19(
    IntPtr intptr_0,
    int int_0,
    int int_1,
    GEnum8 genum8_0 = GEnum8.const_0,
    int int_2 = 1)
  {
    int int_0_1 = 0;
    if (genum8_0 == GEnum8.const_0)
      int_0_1 = 513;
    if (genum8_0 == GEnum8.const_1)
      int_0_1 = 516;
    IntPtr intptr_2 = GClass16.smethod_48(int_0, int_1);
    for (int index = 0; index < int_2; ++index)
    {
      GClass16.PostMessage(intptr_0, 6, new IntPtr(1), intptr_2);
      GClass16.PostMessage(intptr_0, int_0_1, new IntPtr(1), intptr_2);
    }
  }

  public static void smethod_20(
    IntPtr intptr_0,
    int int_0,
    int int_1,
    GEnum8 genum8_0 = GEnum8.const_0,
    int int_2 = 1)
  {
    int int_0_1 = 0;
    if (genum8_0 == GEnum8.const_0)
      int_0_1 = 514;
    if (genum8_0 == GEnum8.const_1)
      int_0_1 = 517;
    IntPtr intptr_2 = GClass16.smethod_48(int_0, int_1);
    for (int index = 0; index < int_2; ++index)
    {
      GClass16.PostMessage(intptr_0, 6, new IntPtr(1), intptr_2);
      GClass16.SendMessage_2(intptr_0, int_0_1, new IntPtr(0), intptr_2);
    }
  }

  public static void smethod_21(IntPtr intptr_0, string string_0) => GClass16.SendMessage_4(intptr_0, 12, 0, string_0);

  public static void smethod_22(IntPtr intptr_0, GEnum7 genum7_0)
  {
    GClass16.PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
    GClass16.PostMessage(intptr_0, 256, new IntPtr((int) genum7_0), new IntPtr(1));
    GClass16.PostMessage(intptr_0, 257, new IntPtr((int) genum7_0), new IntPtr(0));
  }

  public static void smethod_23(IntPtr intptr_0, string string_0, float float_0 = 0.1f)
  {
    foreach (char ch in string_0.ToLower())
    {
      GEnum7 genum7_0 = GEnum7.const_31;
      switch (ch)
      {
        case '0':
          genum7_0 = GEnum7.const_31;
          break;
        case '1':
          genum7_0 = GEnum7.const_32;
          break;
        case '2':
          genum7_0 = GEnum7.const_33;
          break;
        case '3':
          genum7_0 = GEnum7.const_34;
          break;
        case '4':
          genum7_0 = GEnum7.const_35;
          break;
        case '5':
          genum7_0 = GEnum7.const_36;
          break;
        case '6':
          genum7_0 = GEnum7.const_37;
          break;
        case '7':
          genum7_0 = GEnum7.const_38;
          break;
        case '8':
          genum7_0 = GEnum7.const_39;
          break;
        case '9':
          genum7_0 = GEnum7.const_40;
          break;
        case 'a':
          genum7_0 = GEnum7.const_41;
          break;
        case 'b':
          genum7_0 = GEnum7.const_42;
          break;
        case 'c':
          genum7_0 = GEnum7.const_62;
          break;
        case 'd':
          genum7_0 = GEnum7.const_44;
          break;
        case 'e':
          genum7_0 = GEnum7.const_45;
          break;
        case 'f':
          genum7_0 = GEnum7.const_46;
          break;
        case 'g':
          genum7_0 = GEnum7.const_47;
          break;
        case 'h':
          genum7_0 = GEnum7.const_48;
          break;
        case 'i':
          genum7_0 = GEnum7.const_49;
          break;
        case 'j':
          genum7_0 = GEnum7.const_50;
          break;
        case 'k':
          genum7_0 = GEnum7.const_51;
          break;
        case 'l':
          genum7_0 = GEnum7.const_52;
          break;
        case 'm':
          genum7_0 = GEnum7.const_53;
          break;
        case 'n':
          genum7_0 = GEnum7.const_54;
          break;
        case 'o':
          genum7_0 = GEnum7.const_55;
          break;
        case 'p':
          genum7_0 = GEnum7.const_56;
          break;
        case 'q':
          genum7_0 = GEnum7.const_57;
          break;
        case 'r':
          genum7_0 = GEnum7.const_58;
          break;
        case 's':
          genum7_0 = GEnum7.const_59;
          break;
        case 't':
          genum7_0 = GEnum7.const_60;
          break;
        case 'u':
          genum7_0 = GEnum7.const_61;
          break;
        case 'v':
          genum7_0 = GEnum7.const_62;
          break;
        case 'w':
          genum7_0 = GEnum7.const_63;
          break;
        case 'x':
          genum7_0 = GEnum7.const_64;
          break;
        case 'y':
          genum7_0 = GEnum7.const_65;
          break;
        case 'z':
          genum7_0 = GEnum7.const_66;
          break;
      }
      GClass16.smethod_22(intptr_0, genum7_0);
      Thread.Sleep(TimeSpan.FromSeconds((double) float_0));
    }
  }

  public static void smethod_24(IntPtr intptr_0, GEnum7 genum7_0)
  {
    GClass16.PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
    GClass16.PostMessage(intptr_0, 257, new IntPtr((int) genum7_0), new IntPtr(0));
  }

  public static void smethod_25(IntPtr intptr_0, GEnum7 genum7_0)
  {
    GClass16.PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
    GClass16.PostMessage(intptr_0, 258, new IntPtr((int) genum7_0), new IntPtr(0));
  }

  public static void smethod_26(IntPtr intptr_0, int int_0)
  {
    GClass16.PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
    GClass16.PostMessage(intptr_0, 258, new IntPtr(int_0), new IntPtr(0));
  }

  public static void smethod_27(IntPtr intptr_0, GEnum7 genum7_0)
  {
    GClass16.PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
    GClass16.PostMessage(intptr_0, 256, new IntPtr((int) genum7_0), new IntPtr(0));
  }

  public static void smethod_28(IntPtr intptr_0, string string_0, float float_0 = 0.1f)
  {
    foreach (char int_0 in string_0.ToLower())
      GClass16.smethod_26(intptr_0, (int) int_0);
  }

  public static void smethod_29(GEnum6 genum6_0) => GClass16.smethod_32(genum6_0);

  public static void smethod_30(GEnum6[] genum6_0)
  {
    foreach (GEnum6 genum6_0_1 in genum6_0)
      GClass16.smethod_34(genum6_0_1);
    foreach (GEnum6 genum6_0_2 in genum6_0)
      GClass16.smethod_35(genum6_0_2);
  }

  public static void smethod_31(string string_0)
  {
    Clipboard.SetText(string_0);
    GClass16.smethod_30(new GEnum6[2]
    {
      GEnum6.const_107,
      GEnum6.const_94
    });
  }

  public static void smethod_32(GEnum6 genum6_0)
  {
    GStruct2 gstruct2_1 = new GStruct2() { uint_0 = 1 };
    gstruct2_1.gstruct3_0.gstruct6_0 = new GStruct6()
    {
      ushort_0 = (ushort) genum6_0,
      ushort_1 = (ushort) 0,
      uint_0 = 0U,
      uint_1 = 0U,
      intptr_0 = IntPtr.Zero
    };
    GStruct2 gstruct2_2 = new GStruct2() { uint_0 = 1 };
    gstruct2_2.gstruct3_0.gstruct6_0 = new GStruct6()
    {
      ushort_0 = (ushort) genum6_0,
      ushort_1 = (ushort) 0,
      uint_0 = 2U,
      uint_1 = 0U,
      intptr_0 = IntPtr.Zero
    };
    if (GClass16.SendInput(2U, new GStruct2[2]
    {
      gstruct2_1,
      gstruct2_2
    }, Marshal.SizeOf(typeof (GStruct2))) == 0U)
      throw new Exception();
  }

  public static void smethod_33(string string_0, double double_0 = 0.5)
  {
    for (int index = 0; index < string_0.Length; ++index)
    {
      switch (string_0[index])
      {
        case '0':
          GClass16.smethod_32(GEnum6.const_63);
          break;
        case '1':
          GClass16.smethod_32(GEnum6.const_64);
          break;
        case '2':
          GClass16.smethod_32(GEnum6.const_65);
          break;
        case '3':
          GClass16.smethod_32(GEnum6.const_66);
          break;
        case '4':
          GClass16.smethod_32(GEnum6.const_67);
          break;
        case '5':
          GClass16.smethod_32(GEnum6.const_68);
          break;
        case '6':
          GClass16.smethod_32(GEnum6.const_69);
          break;
        case '7':
          GClass16.smethod_32(GEnum6.const_70);
          break;
        case '8':
          GClass16.smethod_32(GEnum6.const_71);
          break;
        case '9':
          GClass16.smethod_32(GEnum6.const_72);
          break;
      }
      Thread.Sleep(TimeSpan.FromSeconds(double_0));
    }
  }

  public static void smethod_34(GEnum6 genum6_0)
  {
    GStruct2 gstruct2 = new GStruct2() { uint_0 = 1 };
    gstruct2.gstruct3_0.gstruct6_0 = new GStruct6();
    gstruct2.gstruct3_0.gstruct6_0.ushort_0 = (ushort) genum6_0;
    gstruct2.gstruct3_0.gstruct6_0.ushort_1 = (ushort) 0;
    gstruct2.gstruct3_0.gstruct6_0.uint_0 = 0U;
    gstruct2.gstruct3_0.gstruct6_0.uint_1 = 0U;
    gstruct2.gstruct3_0.gstruct6_0.intptr_0 = IntPtr.Zero;
    if (GClass16.SendInput(1U, new GStruct2[1]{ gstruct2 }, Marshal.SizeOf(typeof (GStruct2))) == 0U)
      throw new Exception();
  }

  public static void smethod_35(GEnum6 genum6_0)
  {
    GStruct2 gstruct2 = new GStruct2() { uint_0 = 1 };
    gstruct2.gstruct3_0.gstruct6_0 = new GStruct6();
    gstruct2.gstruct3_0.gstruct6_0.ushort_0 = (ushort) genum6_0;
    gstruct2.gstruct3_0.gstruct6_0.ushort_1 = (ushort) 0;
    gstruct2.gstruct3_0.gstruct6_0.uint_0 = 2U;
    gstruct2.gstruct3_0.gstruct6_0.uint_1 = 0U;
    gstruct2.gstruct3_0.gstruct6_0.intptr_0 = IntPtr.Zero;
    if (GClass16.SendInput(1U, new GStruct2[1]{ gstruct2 }, Marshal.SizeOf(typeof (GStruct2))) == 0U)
      throw new Exception();
  }

  public static void smethod_36(int int_0, int int_1, GEnum8 genum8_0 = GEnum8.const_0)
  {
    Cursor.Position = new Point(int_0, int_1);
    GClass16.smethod_41(genum8_0);
  }

  public static void smethod_37(Point point_0, int int_0, bool bool_0 = false)
  {
    Cursor.Position = point_0;
    GClass16.mouse_event(2U, 0, 0, 0, UIntPtr.Zero);
    for (int index = 0; index < int_0; ++index)
    {
      if (!bool_0)
        GClass16.mouse_event(1U, 1, 0, 0, UIntPtr.Zero);
      else
        GClass16.mouse_event(1U, -1, 0, 0, UIntPtr.Zero);
    }
    GClass16.mouse_event(32772U, 0, 0, 0, UIntPtr.Zero);
  }

  public static void smethod_38(Point point_0, int int_0, bool bool_0 = false)
  {
    Cursor.Position = point_0;
    GClass16.mouse_event(2U, 0, 0, 0, UIntPtr.Zero);
    for (int index = 0; index < int_0; ++index)
    {
      if (!bool_0)
        GClass16.mouse_event(1U, 0, 1, 0, UIntPtr.Zero);
      else
        GClass16.mouse_event(1U, 0, -1, 0, UIntPtr.Zero);
    }
    GClass16.mouse_event(32772U, 0, 0, 0, UIntPtr.Zero);
  }

  public static void smethod_39(Point point_0, int int_0, bool bool_0 = false)
  {
    Cursor.Position = point_0;
    GClass16.mouse_event(2048U, 0, 0, int_0, UIntPtr.Zero);
  }

  public static void smethod_40(Point point_0, GEnum8 genum8_0 = GEnum8.const_0)
  {
    Cursor.Position = point_0;
    GClass16.smethod_41(genum8_0);
  }

  public static void smethod_41(GEnum8 genum8_0 = GEnum8.const_0)
  {
    switch (genum8_0)
    {
      case GEnum8.const_0:
        GClass16.mouse_event(32774U, 0, 0, 0, UIntPtr.Zero);
        break;
      case GEnum8.const_1:
        GClass16.mouse_event(32792U, 0, 0, 0, UIntPtr.Zero);
        break;
      case GEnum8.const_2:
        GClass16.mouse_event(32774U, 0, 0, 0, UIntPtr.Zero);
        GClass16.mouse_event(32774U, 0, 0, 0, UIntPtr.Zero);
        break;
      case GEnum8.const_3:
        GClass16.mouse_event(32792U, 0, 0, 0, UIntPtr.Zero);
        GClass16.mouse_event(32792U, 0, 0, 0, UIntPtr.Zero);
        break;
    }
  }

  public static GStruct1 smethod_42(IntPtr intptr_0)
  {
    GStruct1 gstruct1_0 = new GStruct1();
    GClass16.GetWindowRect(intptr_0, ref gstruct1_0);
    return gstruct1_0;
  }

  public static Point smethod_43(IntPtr intptr_0, Point? nullable_0 = null)
  {
    Point point = new Point();
    GStruct1 gstruct1 = GClass16.smethod_42(intptr_0);
    if (!nullable_0.HasValue)
      nullable_0 = new Point?(new Point());
    point.X = nullable_0.Value.X + gstruct1.int_0;
    point.Y = nullable_0.Value.Y + gstruct1.int_1;
    return point;
  }

  public static Point smethod_44(IntPtr intptr_0, int int_0 = 0, int int_1 = 0)
  {
    Point point = new Point();
    GStruct1 gstruct1 = GClass16.smethod_42(intptr_0);
    point.X = int_0 + gstruct1.int_0;
    point.Y = int_1 + gstruct1.int_1;
    return point;
  }

  public static string smethod_45(IntPtr intptr_0)
  {
    StringBuilder stringBuilder_0 = new StringBuilder(256);
    GClass16.GetWindowText(intptr_0, stringBuilder_0, 256);
    return stringBuilder_0.ToString().Trim();
  }

  public static string smethod_46(IntPtr intptr_0)
  {
    StringBuilder stringBuilder_0 = new StringBuilder(256);
    GClass16.GetClassName(intptr_0, stringBuilder_0, 256);
    return stringBuilder_0.ToString().Trim();
  }

  public static IntPtr smethod_47(int int_0, int int_1) => (IntPtr) (int_1 << 16 | int_0 & (int) ushort.MaxValue);

  public static IntPtr smethod_48(int int_0, int int_1) => (IntPtr) (int_1 << 16 | int_0);

  public delegate bool GDelegate0(IntPtr intptr_0, IntPtr intptr_1);

  private delegate bool Delegate0(IntPtr intptr_0, IntPtr intptr_1);

  [Flags]
  public enum GEnum9 : uint
  {
    flag_0 = 2,
    flag_1 = 4,
    flag_2 = 32, // 0x00000020
    flag_3 = 64, // 0x00000040
    flag_4 = 1,
    flag_5 = 32768, // 0x00008000
    flag_6 = 8,
    flag_7 = 16, // 0x00000010
    flag_8 = 2048, // 0x00000800
    flag_9 = 128, // 0x00000080
    flag_10 = 256, // 0x00000100
    flag_11 = flag_4, // 0x00000001
    flag_12 = flag_0, // 0x00000002
  }
}
