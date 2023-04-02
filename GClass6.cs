// Decompiled with JetBrains decompiler
// Type: GClass6
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Threading;

public class GClass6
{
  private Thread Thread_0 { get; set; }

  private int Int32_0 { get; set; } = 0;

  private int Int32_1 { get; set; }

  public GClass6(Thread thread_1, int int_2 = -1)
  {
    this.Thread_0 = thread_1;
    this.Int32_1 = int_2;
  }

  public void method_0()
  {
    this.Int32_0 = Environment.TickCount;
    if (this.Int32_1 <= 0)
      return;
    new Thread((ThreadStart) (() =>
    {
      try
      {
        while (Environment.TickCount - this.Int32_0 < this.Int32_1 * 1000 && this.Thread_0.IsAlive)
          Thread.Sleep(1000);
        this.Thread_0.Abort();
        while (this.Thread_0.IsAlive)
          Thread.Sleep(1000);
      }
      catch (Exception ex)
      {
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  public string method_1() => this.Int32_0 == 0 ? "0" : GClass19.smethod_23((Environment.TickCount - this.Int32_0) / 1000);
}
