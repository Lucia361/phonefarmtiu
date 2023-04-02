// Decompiled with JetBrains decompiler
// Type: GClass25
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading;

public class GClass25
{
  public int int_0;
  private string string_0;
  public string string_1;
  public string string_2 = "";
  public bool bool_0 = true;
  public int int_1 = 0;
  public int int_2 = 0;
  public int int_3 = 3;

  public GClass25(string string_3, string string_4, int int_4, int int_5)
  {
    this.string_0 = string_3;
    this.string_1 = string_4;
    this.int_3 = int_5;
    this.string_2 = "";
    this.int_0 = int_4;
  }

  private void method_0(string string_3)
  {
    try
    {
      File.AppendAllText("GetProxy.txt", string_3 + "\r\n");
    }
    catch
    {
    }
  }

  public int method_1()
  {
    bool flag = false;
    try
    {
      int tickCount = Environment.TickCount;
      this.string_0 = this.string_0.TrimEnd('/');
      string string_0 = this.string_0 + "/reset?proxy=" + this.string_1;
      string json = new GClass24("", "", "", 0).method_0(string_0);
      if (json.Contains("reset_too_much"))
      {
        Thread.Sleep(10000);
        return 2;
      }
      JObject jobject = JObject.Parse(json);
      if (jobject.ContainsKey("msg") && (JObject.Parse(json)["msg"].ToString() == "command_sent" || JObject.Parse(json)["msg"].ToString() == "OK" || JObject.Parse(json)["msg"].ToString().ToLower() == "ok"))
        flag = true;
      else if (jobject.ContainsKey("error_code") && JObject.Parse(json)["error_code"].ToString().ToLower() == "0")
        flag = true;
      else
        this.method_0(string_0 + ": " + json);
    }
    catch
    {
    }
    return flag ? 1 : 0;
  }

  public int method_2()
  {
    try
    {
      int num = 0;
      for (int index = 0; index < 5; ++index)
      {
        num = this.method_1();
        if (num == 1)
          num = this.method_4() ? 1 : 0;
        if (num == 1)
          break;
      }
      return num;
    }
    catch
    {
    }
    return 0;
  }

  public void method_3(int int_4)
  {
    --this.int_1;
    if (int_4 != 0 || this.int_1 != 0 || this.int_2 != this.int_3)
      return;
    this.int_2 = 0;
  }

  public bool method_4(int int_4 = 300)
  {
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
        try
        {
          if (!(flag = Convert.ToBoolean(JObject.Parse(json)["status"].ToString())))
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
          try
          {
            flag = JObject.Parse(json)["error_code"].ToString() == "0";
          }
          catch
          {
          }
        }
        if (!flag)
          Thread.Sleep(1000);
        else
          goto label_14;
      }
      while (Environment.TickCount - tickCount < int_4 * 1000);
      goto label_15;
label_14:
      return flag;
label_15:
      return flag;
    }
    catch
    {
      return flag;
    }
  }
}
