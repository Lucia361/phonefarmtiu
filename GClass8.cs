// Decompiled with JetBrains decompiler
// Type: GClass8
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using OpenCvSharp;
using System;
using System.Runtime.InteropServices;

public class GClass8
{
  [DllImport("user32.dll", SetLastError = true)]
  public static extern long SetParent(IntPtr intptr_0, IntPtr intptr_1);

  [DllImport("user32.dll", SetLastError = true)]
  public static extern bool MoveWindow(
    IntPtr intptr_0,
    int int_0,
    int int_1,
    int int_2,
    int int_3,
    bool bool_0);

  [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
  public static extern bool SetForegroundWindow(IntPtr intptr_0);

  [DllImport("user32.dll")]
  public static extern bool GetWindowRect(IntPtr intptr_0, ref Rect rect_0);

  [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
  public static extern IntPtr FindWindow(string string_0, string string_1);
}
