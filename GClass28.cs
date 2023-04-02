// Decompiled with JetBrains decompiler
// Type: GClass28
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class GClass28
{
  private string string_0 = "";
  public string string_1 = "";
  private string string_2 = "";

  public GClass28()
  {
  }

  public GClass28(string string_3)
  {
    this.string_0 = string_3;
    this.string_1 = this.string_0.Split('@')[1];
    this.string_2 = this.string_0.Split('@')[0];
  }

  public string method_0(int int_0, int int_1)
  {
    if (this.string_0.Split('@').Length < 2)
      return "";
    GClass24 gclass24 = new GClass24("", "", "", 0);
    int tickCount = Environment.TickCount;
    do
    {
      List<string> stringList = new List<string>();
      string str1 = gclass24.method_0("https://generator.email/" + this.string_1 + "/" + this.string_2);
      foreach (Match match in Regex.Matches(str1, "href=\"(/" + this.string_1 + "/" + this.string_2 + "/.*?)\""))
        stringList.Add(match.Groups[1].Value);
      string str2;
      while (true)
      {
        string input = Class23.smethod_2(str1, int_0);
        if (input != "")
        {
          str2 = Regex.Match(input, "c=(\\d+)&").Value;
          if (str2 != "")
            break;
        }
        if (stringList.Count != 0)
        {
          str1 = gclass24.method_0("https://generator.email/" + stringList[0]);
          stringList.RemoveAt(0);
        }
        else
          goto label_15;
      }
      return str2;
label_15:
      GClass19.smethod_64(3.0);
    }
    while (Environment.TickCount - tickCount < int_1 * 1000);
    return "";
  }

  public string method_1()
  {
    if (this.string_1 == "")
      return "";
    this.string_2 = GClass19.smethod_62(Class44.smethod_3().OrderBy<string, Guid>((Func<string, Guid>) (string_0 => Guid.NewGuid())).First<string>() + Class44.smethod_5().OrderBy<string, Guid>((Func<string, Guid>) (string_0 => Guid.NewGuid())).First<string>()).Replace(" ", "").ToLower() + GClass19.smethod_61(6);
    return this.method_2();
  }

  public string method_2() => this.string_2 + "@" + this.string_1;
}
