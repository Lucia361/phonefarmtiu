// Decompiled with JetBrains decompiler
// Type: GClass36
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Threading;

public static class GClass36
{
  private static bool bool_0;

  public static void smethod_0()
  {
    if (GClass36.bool_0)
      return;
    GClass36.bool_0 = true;
    new Thread((ThreadStart) (() =>
    {
      while (GClass36.bool_0)
      {
        try
        {
          if (!GClass7.smethod_1("adb devices", 5).Split('|')[0].Trim().Contains("List of devices attached"))
          {
            GClass7.smethod_3();
            GClass7.smethod_4();
          }
        }
        catch (Exception ex)
        {
        }
        if (!GClass36.bool_0)
          break;
        GClass19.smethod_64(60.0);
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  public static void smethod_1() => GClass36.bool_0 = false;
}
