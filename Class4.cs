// Decompiled with JetBrains decompiler
// Type: Class4
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal class Class4
{
  private Random random_0 = new Random();
  private object object_0 = new object();
  private object object_1 = new object();
  private int int_5 = 0;
  public int int_6 = 0;
  public int int_7 = 0;
  public int int_8 = 3;
  public bool bool_0 = true;

  public int Int32_0 { get; set; }

  public string String_0 { get; set; }

  public string String_1 { get; set; }

  public int Int32_1 { get; set; }

  public string String_2 { get; set; }

  public int Int32_2 { get; set; }

  public int Int32_3 { get; set; }

  public int Int32_4 { get; set; }

  public string String_3 { get; set; }

  public string String_4 { get; set; }

  public Class4(int int_9, string string_5, int int_10, int int_11)
  {
    this.Int32_0 = int_9;
    this.String_0 = string_5;
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_3 = 0;
    this.Int32_4 = 0;
    this.Int32_1 = int_10;
    this.int_8 = int_11;
    this.int_5 = 0;
    this.int_6 = 0;
    this.int_7 = 0;
    this.String_3 = "";
    this.String_4 = "";
  }

  public static bool smethod_0(int int_9, string string_5)
  {
    string json = int_9 != 0 ? Class4.smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-status?api_key=" + string_5) : Class4.smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy/get-status?api_key=" + string_5);
    if (json != "")
    {
      try
      {
        if (JObject.Parse(json)["code"].ToString() == "1")
          return true;
      }
      catch
      {
      }
    }
    return false;
  }

  public string method_0()
  {
    lock (this.object_0)
    {
      if (this.int_6 == 0)
      {
        if (this.int_7 > 0 && this.int_7 < this.int_8)
        {
          if (this.method_1() < 30 && this.method_3() != 1)
            return "0";
        }
        else if (this.method_3() != 1)
          return "0";
      }
      else
      {
        if (this.int_7 >= this.int_8)
          return "2";
        if (this.method_1() < 30 && this.method_3() != 1)
          return "0";
      }
      ++this.int_7;
      ++this.int_6;
      return "1";
    }
  }

  public int method_1()
  {
    this.method_4();
    return this.Int32_2;
  }

  public void method_2()
  {
    lock (this.object_1)
    {
      --this.int_6;
      if (this.int_6 != 0 || this.int_7 != this.int_8)
        return;
      this.bool_0 = true;
      this.int_7 = 0;
    }
  }

  public int method_3()
  {
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_3 = 0;
    string json = this.Int32_0 != 0 ? Class4.smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-new-proxy?api_key=" + this.String_0) : Class4.smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy/get-new-proxy?api_key=" + this.String_0);
    if (json != "")
    {
      if (json.Contains("api expired"))
        return -1;
      if (json.Contains("api wrong") || json.Contains("error"))
        return -2;
      try
      {
        JObject jobject = JObject.Parse(json);
        string s = Regex.Match(jobject["data"][(object) "next_request"].ToString(), "\\d+").Value;
        this.Int32_4 = !(s == "") ? int.Parse(s) : 0;
        if (jobject["code"].ToString() == "2")
        {
          this.String_3 = jobject["data"][(object) "ip_allow"].ToString();
          this.String_4 = jobject["data"][(object) "your_ip"].ToString();
          if (this.Int32_0 == 0)
          {
            this.String_1 = jobject["data"][(object) "http_proxy"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_3 = int.Parse(strArray[1]);
            return 1;
          }
          if (this.Int32_0 == 1)
          {
            if (this.Int32_1 == 0)
            {
              this.String_1 = jobject["data"][(object) "http_proxy_ipv4"].ToString();
              string[] strArray = this.String_1.Split(':');
              this.String_2 = strArray[0];
              this.Int32_3 = int.Parse(strArray[1]);
            }
            else if (this.Int32_1 == 1)
            {
              this.String_1 = jobject["data"][(object) "http_proxy_ipv6"].ToString();
              string[] strArray = this.String_1.Split(':');
              this.String_2 = strArray[0];
              this.Int32_3 = int.Parse(strArray[1]);
            }
            else if (this.Int32_1 == 2)
            {
              this.String_1 = jobject["data"][(object) "sock_proxy_ipv4"].ToString();
              string[] strArray = this.String_1.Split(':');
              this.String_2 = strArray[0];
              this.Int32_3 = int.Parse(strArray[1]);
            }
            else
            {
              this.String_1 = jobject["data"][(object) "sock_proxy_ipv6"].ToString();
              string[] strArray = this.String_1.Split(':');
              this.String_2 = strArray[0];
              this.Int32_3 = int.Parse(strArray[1]);
            }
            return 1;
          }
        }
        return 0;
      }
      catch
      {
      }
    }
    this.Int32_4 = 0;
    return 0;
  }

  public bool method_4()
  {
    this.Int32_4 = 0;
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_3 = 0;
    this.Int32_2 = 0;
    string json = this.Int32_0 != 0 ? Class4.smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-current-proxy?api_key=" + this.String_0) : Class4.smethod_1("http://dash.minproxy.vn/api/rotating/v1/proxy/get-current-proxy?api_key=" + this.String_0);
    if (json != "")
    {
      try
      {
        JObject jobject = JObject.Parse(json);
        if (jobject["code"].ToString() == "1")
        {
          this.Int32_4 = Convert.ToInt32(jobject["data"][(object) "next_request"].ToString());
          this.Int32_2 = Convert.ToInt32(jobject["data"][(object) "timeout"].ToString());
          this.String_3 = jobject["data"][(object) "ip_allow"].ToString();
          this.String_4 = jobject["data"][(object) "your_ip"].ToString();
          if (this.Int32_0 == 0)
          {
            this.String_1 = jobject["data"][(object) "http_proxy"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_3 = int.Parse(strArray[1]);
            return true;
          }
          if (this.Int32_0 == 1)
          {
            if (this.Int32_1 == 0)
            {
              this.String_1 = jobject["data"][(object) "http_proxy_ipv4"].ToString();
              string[] strArray = this.String_1.Split(':');
              this.String_2 = strArray[0];
              this.Int32_3 = int.Parse(strArray[1]);
            }
            else if (this.Int32_1 == 1)
            {
              this.String_1 = jobject["data"][(object) "http_proxy_ipv6"].ToString();
              string[] strArray = this.String_1.Split(':');
              this.String_2 = strArray[0];
              this.Int32_3 = int.Parse(strArray[1]);
            }
            else if (this.Int32_1 == 2)
            {
              this.String_1 = jobject["data"][(object) "sock_proxy_ipv4"].ToString();
              string[] strArray = this.String_1.Split(':');
              this.String_2 = strArray[0];
              this.Int32_3 = int.Parse(strArray[1]);
            }
            else
            {
              this.String_1 = jobject["data"][(object) "sock_proxy_ipv6"].ToString();
              string[] strArray = this.String_1.Split(':');
              this.String_2 = strArray[0];
              this.Int32_3 = int.Parse(strArray[1]);
            }
            return true;
          }
        }
      }
      catch
      {
      }
    }
    return false;
  }

  public string method_5()
  {
    do
      ;
    while (!this.method_4());
    return this.String_1;
  }

  public static string smethod_1(string string_5)
  {
    try
    {
      HttpClient httpClient = new HttpClient();
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
      Task<string> task = Task.Run<string>((Func<Task<string>>) (() => Class4.smethod_2(new Uri(string_5))));
      task.Wait();
      return task.Result;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Request get");
      return "";
    }
  }

  private static async Task<string> smethod_2(Uri uri_0)
  {
    string result = string.Empty;
    using (HttpClient httpClient = new HttpClient())
    {
      HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(uri_0);
      if (httpResponseMessage.IsSuccessStatusCode)
        result = await httpResponseMessage.Content.ReadAsStringAsync();
      httpResponseMessage = (HttpResponseMessage) null;
    }
    string str = result;
    result = (string) null;
    return str;
  }
}
