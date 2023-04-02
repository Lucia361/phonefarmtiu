// Decompiled with JetBrains decompiler
// Type: GClass9
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

public class GClass9
{
  private string string_0 = "";
  private string string_1 = "";
  private string string_2 = "";
  private List<GClass10> list_0;

  public GClass9(string string_3)
  {
    this.string_2 = string_3;
    this.list_0 = new List<GClass10>();
  }

  public string method_0() => this.string_2;

  public void method_1(GClass10 gclass10_0)
  {
    this.string_0 = gclass10_0.method_7();
    this.string_1 = gclass10_0.method_8();
    this.list_0.Add(gclass10_0);
  }

  public List<GClass10> method_2() => this.list_0;

  public List<GClass10> method_3()
  {
    List<GClass10> gclass10List = new List<GClass10>();
    for (int index = 0; index < this.list_0.Count; ++index)
    {
      GClass10 gclass10 = this.list_0[index];
      if (gclass10.bool_0 && gclass10.int_2 < gclass10.int_3)
        gclass10List.Add(gclass10);
    }
    return gclass10List;
  }

  public bool method_4()
  {
    bool flag = false;
    try
    {
      int tickCount = Environment.TickCount;
      string json = new GClass24("", "", "", 0).method_0(this.string_0.TrimEnd('/') + "/reset?proxy=" + this.string_1 + "&type=deep");
      JObject jobject = JObject.Parse(json);
      if (jobject.ContainsKey("msg") && (JObject.Parse(json)["msg"].ToString() == "command_sent" || JObject.Parse(json)["msg"].ToString() == "OK" || JObject.Parse(json)["msg"].ToString().ToLower() == "ok"))
        flag = true;
      else if (jobject.ContainsKey("error_code") && JObject.Parse(json)["error_code"].ToString().ToLower() == "0")
        flag = true;
    }
    catch
    {
    }
    foreach (GClass10 gclass10 in this.list_0)
      gclass10.int_2 = 0;
    return flag;
  }

  public bool method_5()
  {
    int index = 0;
    while (true)
    {
      if (index < this.list_0.Count)
      {
        GClass10 gclass10 = this.list_0[index];
        if (!gclass10.bool_0 || gclass10.int_2 == gclass10.int_3 && gclass10.int_1 == 0)
          ++index;
        else
          goto label_5;
      }
      else
        break;
    }
    return true;
label_5:
    return false;
  }

  public static Dictionary<string, List<string>> smethod_0(string string_3)
  {
    Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
    try
    {
      string_3 = string_3.TrimEnd('/') + "/api/v1/dongles/all";
      foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse("{data:" + new GClass24("", "", "", 0).method_0(string_3) + "}")["data"])
      {
        string key = jtoken[(object) "rootId"].ToString();
        string str = jtoken[(object) "httpPortV6"].ToString();
        if (!dictionary.ContainsKey(key))
          dictionary.Add(key, new List<string>());
        dictionary[key].Add(str);
      }
    }
    catch (Exception ex)
    {
    }
    return dictionary;
  }

  public static GClass9 smethod_1(List<GClass9> list_1, string string_3)
  {
    GClass9 gclass9 = (GClass9) null;
    for (int index = 0; index < list_1.Count; ++index)
    {
      if (list_1[index].method_0() == string_3)
      {
        gclass9 = list_1[index];
        break;
      }
    }
    return gclass9;
  }
}
