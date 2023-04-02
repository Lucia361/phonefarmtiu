// Decompiled with JetBrains decompiler
// Type: GClass31
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

public class GClass31
{
  public static List<GClass32> smethod_0(string string_0)
  {
    List<GClass32> gclass32List = new List<GClass32>();
    try
    {
      string json = new GClass24("", "", "", 0).method_0("https://tool.baostar.pro/api/jobs?fb_id=" + string_0);
      if (JObject.Parse(json)["success"].ToString().ToLower() == "true")
        gclass32List = JsonConvert.DeserializeObject<List<GClass32>>(JObject.Parse(json)["data"].ToString());
    }
    catch
    {
    }
    return gclass32List;
  }

  public static void smethod_1(string string_0, GClass32 gclass32_0, bool bool_0, string string_1 = "")
  {
    try
    {
      if (gclass32_0.Int32_0 == 0)
        return;
      new GClass24("", "", "", 0).method_1("https://tool.baostar.pro/api/complete", "{\"fb_id\":\"" + string_0 + "\", \"job_id\":" + gclass32_0.Int32_0.ToString() + ", \"success\":" + bool_0.ToString().ToLower() + ", \"message\":\"" + string_1 + "\"}", "application/json");
    }
    catch
    {
    }
  }
}
