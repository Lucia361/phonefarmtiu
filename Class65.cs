// Decompiled with JetBrains decompiler
// Type: Class65
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System.Runtime.InteropServices;

internal class Class65
{
  [DllImport("wininet.dll")]
  private static extern bool InternetGetConnectedState(out int int_0, int int_1);

  public static bool smethod_0() => Class65.InternetGetConnectedState(out int _, 0);
}
