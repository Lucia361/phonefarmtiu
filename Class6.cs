// Decompiled with JetBrains decompiler
// Type: Class6
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Threading;

internal class Class6
{
  private object object_0 = new object();
  private object object_1 = new object();
  public int int_0;
  private string string_0;
  public string string_1;
  public string string_2 = "";
  public int int_1 = 0;
  public int int_2 = 0;
  public int int_3 = 3;

  public Class6(string string_3, string string_4, int int_4, int int_5)
  {
    this.string_0 = string_3;
    this.string_1 = string_4;
    this.int_3 = int_5;
    this.string_2 = "";
    this.int_0 = int_4;
  }

  public bool method_0()
  {
    bool flag = false;
    try
    {
      if (JObject.Parse(new GClass24("", "", "", 0).method_1("https://api.proxyv6.net/api/reset-ip-manual?api_key=" + this.string_0, "{\"host\": \"" + this.string_1.Split(':')[0] + "\", \"port\": " + this.string_1.Split(':')[1] + "}", "application/json"))["message"].ToString() == "SUCCESS")
      {
        for (int index = 0; index < 120; ++index)
        {
          if (!this.method_2())
          {
            Thread.Sleep(1000);
          }
          else
          {
            Thread.Sleep(1000);
            return true;
          }
        }
      }
    }
    catch
    {
      flag = false;
    }
    return flag;
  }

  public void method_1()
  {
    lock (this.object_0)
    {
      --this.int_1;
      if (this.int_1 != 0 || this.int_2 != this.int_3)
        return;
      this.int_2 = 0;
    }
  }

  public bool method_2()
  {
    bool flag = false;
    try
    {
      string json = new GClass24("", "", "", 0).method_1("https://api.proxyv6.net/api/check-list-proxy?api_key=" + this.string_0, "{\"proxies\": [\"" + (this.string_1.Split(':')[2] + ":" + this.string_1.Split(':')[3] + "@" + this.string_1.Split(':')[0] + ":" + this.string_1.Split(':')[1]) + "\"]}", "application/json");
      return Convert.ToBoolean(JObject.Parse(json)["message"].ToString() == "SUCCESS" && JObject.Parse(json)["data"][(object) "ip"].ToString() != "");
    }
    catch
    {
      return flag;
    }
  }
}
