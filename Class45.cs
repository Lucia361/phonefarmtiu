// Decompiled with JetBrains decompiler
// Type: Class45
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;

internal class Class45
{
  public string string_3 = "";
  private string string_4 = "http://proxy.tinsoftsv.com";
  private int int_4 = 0;

  public string String_0 { get; set; }

  public string String_1 { get; set; }

  public string String_2 { get; set; }

  public int Int32_0 { get; set; }

  public int Int32_1 { get; set; }

  public int Int32_2 { get; set; }

  public int Int32_3 { get; set; }

  public int Int32_4 { get; set; }

  public int Int32_5 { get; set; }

  public Class45(string string_5, int int_7 = 0)
  {
    this.String_0 = string_5;
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_0 = 0;
    this.Int32_1 = 0;
    this.Int32_2 = 0;
    this.Int32_3 = int_7;
  }

  public bool method_0()
  {
    if (this.method_3())
    {
      this.string_3 = "";
      this.Int32_2 = 0;
      this.String_1 = "";
      this.String_2 = "";
      this.Int32_0 = 0;
      this.Int32_1 = 0;
      string json = this.method_4(this.string_4 + "/api/changeProxy.php?key=" + this.String_0 + "&location=" + this.Int32_3.ToString());
      if (json != "")
      {
        try
        {
          JObject jobject = JObject.Parse(json);
          if (bool.Parse(jobject["success"].ToString()))
          {
            this.String_1 = jobject["proxy"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_0 = int.Parse(strArray[1]);
            this.Int32_1 = int.Parse(jobject["timeout"].ToString());
            this.Int32_2 = int.Parse(jobject["next_change"].ToString());
            this.string_3 = "";
            return true;
          }
          this.string_3 = jobject["description"].ToString();
        }
        catch
        {
        }
      }
      else
        this.string_3 = "request server timeout!";
    }
    else
      this.string_3 = "Request so fast!";
    return false;
  }

  public void method_1()
  {
    this.string_3 = "";
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_0 = 0;
    this.Int32_1 = 0;
    if (!(this.String_0 != ""))
      return;
    this.method_4(this.string_4 + "/api/stopProxy.php?key=" + this.String_0);
  }

  public bool method_2()
  {
    if (this.method_3())
    {
      this.string_3 = "";
      this.String_1 = "";
      this.String_2 = "";
      this.Int32_0 = 0;
      this.Int32_1 = 0;
      string json = this.method_4(this.string_4 + "/api/getProxy.php?key=" + this.String_0);
      if (json != "")
      {
        try
        {
          JObject jobject = JObject.Parse(json);
          if (bool.Parse(jobject["success"].ToString()))
          {
            this.String_1 = jobject["proxy"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_0 = int.Parse(strArray[1]);
            this.Int32_1 = int.Parse(jobject["timeout"].ToString());
            this.Int32_2 = int.Parse(jobject["next_change"].ToString());
            this.string_3 = "";
            return true;
          }
          this.string_3 = jobject["description"].ToString();
        }
        catch
        {
        }
      }
    }
    else
      this.string_3 = "Request so fast!";
    return false;
  }

  private bool method_3()
  {
    try
    {
      int totalSeconds = (int) new TimeSpan(DateTime.Now.Ticks - new DateTime(2001, 1, 1).Ticks).TotalSeconds;
      if (totalSeconds - this.int_4 >= 10)
      {
        this.int_4 = totalSeconds;
        return true;
      }
    }
    catch
    {
    }
    return false;
  }

  private string method_4(string string_5)
  {
    Console.WriteLine(string_5);
    string str = "";
    try
    {
      using (WebClient webClient = new WebClient())
      {
        webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
        str = webClient.DownloadString(string_5);
      }
      if (string.IsNullOrEmpty(str))
        str = "";
    }
    catch
    {
      str = "";
    }
    return str;
  }

  public static List<string> smethod_0(string string_5)
  {
    List<string> stringList = new List<string>();
    try
    {
      foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(new GClass24("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0).method_0("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + string_5))["data"])
      {
        if (Convert.ToBoolean(jtoken[(object) "success"].ToString()))
          stringList.Add(jtoken[(object) "key"].ToString());
      }
    }
    catch
    {
    }
    return stringList;
  }
}
