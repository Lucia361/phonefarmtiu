// Decompiled with JetBrains decompiler
// Type: GClass26
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System.Collections.Generic;

public class GClass26
{
  public List<GClass27> list_0;
  private List<GClass27> list_1;

  public GClass26(List<string> list_2)
  {
    this.list_0 = new List<GClass27>();
    this.list_1 = new List<GClass27>();
    foreach (string string_11 in list_2)
      this.list_0.Add(new GClass27(string_11));
    fMain.fMain_0.method_2(this.method_0());
  }

  public int method_0() => this.list_0.Count;

  public void method_1(GClass27 gclass27_0)
  {
    lock (this.list_0)
    {
      this.list_0.Remove(gclass27_0);
      this.list_1.Add(gclass27_0);
    }
    fMain.fMain_0.method_2(this.method_0());
  }

  public GClass27 method_2()
  {
    lock (this.list_0)
    {
      while (true)
      {
        foreach (GClass27 gclass27_0 in this.list_0)
        {
          if (!gclass27_0.bool_0)
          {
            this.method_3(gclass27_0, true);
            return gclass27_0;
          }
        }
        if (this.list_1.Count > 0)
        {
          List<string> stringList = GClass7.smethod_0();
          bool flag = false;
          for (int index = 0; index < this.list_1.Count; ++index)
          {
            if (stringList.Contains(this.list_1[index].String_2))
            {
              flag = true;
              this.list_0.Add(this.list_1[index]);
              this.method_3(this.list_1[index], false);
              this.list_1[index].bool_1 = false;
              this.list_1.Remove(this.list_1[index--]);
            }
          }
          if (flag)
            fMain.fMain_0.method_2(this.method_0());
          else
            break;
        }
        else
          break;
      }
    }
    return (GClass27) null;
  }

  public void method_3(GClass27 gclass27_0, bool bool_0)
  {
    if (gclass27_0 == null)
      return;
    gclass27_0.bool_0 = bool_0;
  }
}
