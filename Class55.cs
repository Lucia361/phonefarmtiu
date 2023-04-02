// Decompiled with JetBrains decompiler
// Type: Class55
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using ManagedWinapi.Windows;
using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

internal class Class55
{
  private const int int_0 = 16;
  private const int int_1 = 245;
  private const int int_2 = 513;
  private const int int_3 = 514;
  private static Hashtable hashtable_0 = new Hashtable();
  public static int int_4 = 30;
  private static int int_5 = 1079;

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  public static extern int SendMessage(int int_6, int int_7, int int_8, IntPtr intptr_0);

  public static int smethod_0()
  {
    ++Class55.int_5;
    if (Class55.int_5 >= 1280)
      Class55.int_5 = 1079;
    Process process = new Process();
    try
    {
      Class55.hashtable_0.Add((object) Class55.int_5, (object) process);
    }
    catch
    {
    }
    return Class55.int_5;
  }

  public static bool smethod_1(string string_0, string string_1, string string_2, int int_6)
  {
    bool flag = false;
    Process process = Process.Start(new ProcessStartInfo()
    {
      FileName = AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient\\BvSsh.exe",
      WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient",
      Arguments = "-profile=\"" + AppDomain.CurrentDomain.BaseDirectory + "BitviseSSHClient\\" + int_6.ToString() + ".bscp\" -host=" + string_0 + " -user=" + string_1 + " -password=" + string_2 + " -loginOnStartup -hide=main,trayIcon,banner,auth,popups,trayLog,trayWRC,trayTerm,traySFTP,trayRDP,trayPopups"
    });
    Class55.hashtable_0[(object) int_6] = (object) process;
    Thread.Sleep(2000);
    for (int index = 0; index < Class55.int_4; ++index)
    {
      SystemWindow[] systemWindowArray1 = SystemWindow.FilterToplevelWindows((Predicate<SystemWindow>) (systemWindow_0 => systemWindow_0.Title == "Host Key Verification"));
      if (systemWindowArray1.Length != 0)
      {
        SystemWindow[] systemWindowArray2 = systemWindowArray1[0].FilterDescendantWindows(false, (Predicate<SystemWindow>) (systemWindow_0 => systemWindow_0.Title == "&Accept for This Session"));
        if (systemWindowArray2.Length != 0)
        {
          Class55.SendMessage((int) systemWindowArray2[0].HWnd, 513, 0, IntPtr.Zero);
          Thread.Sleep(10);
          Class55.SendMessage((int) systemWindowArray2[0].HWnd, 514, 0, IntPtr.Zero);
          Class55.SendMessage((int) systemWindowArray2[0].HWnd, 513, 0, IntPtr.Zero);
          Thread.Sleep(10);
          Class55.SendMessage((int) systemWindowArray2[0].HWnd, 514, 0, IntPtr.Zero);
        }
      }
      if (SystemWindow.FilterToplevelWindows((Predicate<SystemWindow>) (systemWindow_0 => systemWindow_0.Title == "Bitvise SSH Client - " + int_6.ToString() + ".bscp - " + string_0 + ":22")).Length == 0)
      {
        Thread.Sleep(1000);
      }
      else
      {
        flag = true;
        break;
      }
    }
    if (flag)
      return flag;
    try
    {
      process.Kill();
      process.Dispose();
      return flag;
    }
    catch
    {
      return flag;
    }
  }

  public static void smethod_2(int int_6)
  {
    if (Class55.hashtable_0[(object) int_6] == null)
      return;
    try
    {
      Process process = Class55.hashtable_0[(object) int_6] as Process;
      process.Kill();
      process.Dispose();
    }
    catch
    {
    }
  }

  private static bool smethod_3(string string_0, int int_6) => true;

  public static void smethod_4()
  {
    foreach (Process process in Process.GetProcesses())
    {
      if (process.ProcessName == "BvSsh")
        process.Kill();
    }
  }

  public static Process smethod_5(IntPtr intptr_0)
  {
    Process[] processes = Process.GetProcesses();
    int index = 0;
    Process process;
    while (true)
    {
      if (index < processes.Length)
      {
        process = processes[index];
        if (!(process.Handle == intptr_0))
          ++index;
        else
          goto label_5;
      }
      else
        break;
    }
    return (Process) null;
label_5:
    return process;
  }
}
