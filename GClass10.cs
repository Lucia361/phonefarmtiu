// Decompiled with JetBrains decompiler
// Type: GClass10
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Threading;

public class GClass10
{
  public int int_0;
  private string string_0;
  public string string_1;
  public string string_2 = "";
  public bool bool_0 = true;
  public int int_1 = 0;
  public int int_2 = 0;
  public int int_3 = 3;
  private string string_3 = "";

  public GClass10(string string_4, string string_5, int int_4, int int_5, string string_6)
  {
    this.string_0 = string_4;
    this.string_1 = string_5;
    this.int_3 = int_5;
    this.string_2 = "";
    this.int_0 = int_4;
    this.method_6(string_6);
  }

  private void method_0(string string_4)
  {
  }

  public bool method_1()
  {
    bool flag = false;
    try
    {
      int tickCount = Environment.TickCount;
      this.string_0 = this.string_0.TrimEnd('/');
      string string_0 = this.string_0 + "/reset?proxy=" + this.string_1;
      string json = new GClass24("", "", "", 0).method_0(string_0);
      this.method_0(string_0 + ": " + json);
      JObject jobject = JObject.Parse(json);
      return jobject.ContainsKey("msg") && (JObject.Parse(json)["msg"].ToString() == "command_sent" || JObject.Parse(json)["msg"].ToString() == "OK" || JObject.Parse(json)["msg"].ToString().ToLower() == "ok") || jobject.ContainsKey("error_code") && JObject.Parse(json)["error_code"].ToString().ToLower() == "0" || flag;
    }
    catch
    {
      return flag;
    }
  }

  public bool method_2()
  {
    bool flag1 = false;
    try
    {
      int tickCount = Environment.TickCount;
      this.string_0 = this.string_0.TrimEnd('/');
      string string_0 = this.string_0 + "/reset?proxy=" + this.string_1;
      string json = new GClass24("", "", "", 0).method_0(string_0);
      this.method_0(string_0 + ": " + json);
      JObject jobject = JObject.Parse(json);
      bool flag2 = false;
      if (jobject.ContainsKey("msg") && (JObject.Parse(json)["msg"].ToString() == "command_sent" || JObject.Parse(json)["msg"].ToString() == "OK" || JObject.Parse(json)["msg"].ToString().ToLower() == "ok"))
        flag2 = true;
      else if (jobject.ContainsKey("error_code") && JObject.Parse(json)["error_code"].ToString().ToLower() == "0")
        flag2 = true;
      if (flag2)
        return this.method_4();
    }
    catch
    {
      flag1 = false;
    }
    return flag1;
  }

  public void method_3(int int_4 = 1)
  {
    --this.int_1;
    if (int_4 != 0 || this.int_1 != 0 || this.int_2 != this.int_3)
      return;
    this.int_2 = 0;
  }

  public bool method_4(int int_4 = -1)
  {
    if (int_4 == -1)
      int_4 = GClass33.smethod_0("configGeneral").method_3("nudDelayCheckIPObcProxy", 5) * 60;
    int tickCount = Environment.TickCount;
    bool flag = false;
    try
    {
      this.string_0 = this.string_0.TrimEnd('/');
      string string_0 = this.string_0 + "/status?proxy=" + this.string_1;
      GClass24 gclass24 = new GClass24("", "", "", 0);
      do
      {
        string json = gclass24.method_0(string_0);
        this.method_0(string_0 + ": " + json);
        try
        {
          if (!json.Contains("public_ip_v6") && !json.Contains("public_ip"))
          {
            flag = Convert.ToBoolean(JObject.Parse(json)["status"].ToString());
          }
          else
          {
            string str = this.string_1.Split(':')[1];
            if (str.StartsWith("4") || str.StartsWith("5"))
              flag = JObject.Parse(json)["public_ip"].ToString() != "" && JObject.Parse(json)["public_ip"].ToString() != "CONNECT_INTERNET_ERROR";
            else if (str.StartsWith("6") || str.StartsWith("7"))
              flag = JObject.Parse(json)["public_ip_v6"].ToString() != "" && JObject.Parse(json)["public_ip_v6"].ToString() != "CONNECT_INTERNET_ERROR";
          }
        }
        catch
        {
          flag = JObject.Parse(json)["error_code"].ToString() == "0";
        }
        Thread.Sleep(1000);
      }
      while (!flag && Environment.TickCount - tickCount < int_4 * 1000);
      return flag;
    }
    catch
    {
      return flag;
    }
  }

  public string method_5() => this.string_3;

  public void method_6(string string_4) => this.string_3 = string_4;

  public string method_7() => this.string_0;

  public string method_8() => this.string_1.Split(':')[1];
}
