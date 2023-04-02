// Decompiled with JetBrains decompiler
// Type: Class47
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal class Class47
{
  private Random random_0 = new Random();
  private object object_0 = new object();
  private object object_1 = new object();
  public int int_4 = 0;
  public int int_5 = 0;
  public int int_6 = 3;

  public string String_0 { get; set; }

  public string String_1 { get; set; }

  public int Int32_0 { get; set; }

  public string String_2 { get; set; }

  public int Int32_1 { get; set; }

  public int Int32_2 { get; set; }

  public int Int32_3 { get; set; }

  public Class47(string string_3, int int_7, int int_8)
  {
    this.String_0 = string_3;
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_2 = 0;
    this.Int32_3 = 0;
    this.Int32_0 = int_7;
    this.int_6 = int_8;
    this.int_4 = 0;
    this.int_5 = 0;
  }

  public static bool smethod_0(string string_3)
  {
    string json = Class47.smethod_1("https://tmproxy.com/api/proxy/stats", "{\"api_key\": \"" + string_3 + "\"}");
    if (json != "")
    {
      try
      {
        if (DateTime.Compare(GClass19.smethod_84(JObject.Parse(json)["data"][(object) "expired_at"].ToString(), "HH:mm:ss dd/MM/yyyy"), DateTime.Now) > 0)
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
      if (this.int_4 == 0)
      {
        if (this.int_5 > 0 && this.int_5 < this.int_6)
        {
          if (this.method_1() < 30 && !this.method_4())
            return "0";
        }
        else if (!this.method_4())
          return "0";
      }
      else
      {
        if (this.int_5 >= this.int_6)
          return "2";
        if (this.method_1() < 30 && !this.method_4())
          return "0";
      }
      ++this.int_5;
      ++this.int_4;
      return "1";
    }
  }

  public int method_1()
  {
    this.method_6();
    return this.Int32_1;
  }

  public void method_2()
  {
    lock (this.object_1)
    {
      --this.int_4;
      if (this.int_4 != 0 || this.int_5 != this.int_6)
        return;
      this.int_5 = 0;
    }
  }

  public string method_3(string string_3)
  {
    byte[] hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(string_3));
    StringBuilder stringBuilder = new StringBuilder();
    for (int index = 0; index < hash.Length; ++index)
      stringBuilder.Append(hash[index].ToString("x2"));
    return stringBuilder.ToString();
  }

  public bool method_4()
  {
    this.Int32_3 = 0;
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_2 = 0;
    string str1 = "abccd9f3bf38f38414cb87e36f76c8e4";
    int num1 = 8989;
    string str2 = this.method_5("https://tmproxy.com/api/proxy/current-time");
    long num2;
    try
    {
      num2 = Convert.ToInt64(str2);
    }
    catch
    {
      num2 = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }
    long num3 = Convert.ToInt64(num2 / 60L) + (long) num1;
    string json = Class47.smethod_1("https://tmproxy.com/api/proxy/get-new-proxy", "{\"api_key\": \"" + this.String_0 + "\",\"sign\": \"" + this.method_3(string.Format("{0}{1}{2}", (object) str1, (object) this.String_0, (object) num3)) + "\"}");
    if (json != "")
    {
      try
      {
        JObject jobject = JObject.Parse(json);
        string s = Regex.Match(JObject.Parse(json)["message"].ToString(), "\\d+").Value;
        this.Int32_3 = !(s == "") ? int.Parse(s) : 0;
        if (this.Int32_3 == 0)
        {
          if (this.Int32_0 == 0)
          {
            this.String_1 = jobject["data"][(object) "https"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_2 = int.Parse(strArray[1]);
          }
          else
          {
            this.String_1 = jobject["data"][(object) "socks5"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_2 = int.Parse(strArray[1]);
          }
          return true;
        }
      }
      catch
      {
      }
    }
    return false;
  }

  private string method_5(string string_3)
  {
    string str = "";
    try
    {
      str = new GClass23().method_0(string_3);
      if (string.IsNullOrEmpty(str))
        str = "";
    }
    catch
    {
    }
    return str;
  }

  public bool method_6()
  {
    this.Int32_3 = 0;
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_2 = 0;
    this.Int32_1 = 0;
    string json = Class47.smethod_1("https://tmproxy.com/api/proxy/get-current-proxy", "{\"api_key\": \"" + this.String_0 + "\"}");
    if (json != "")
    {
      try
      {
        JObject jobject = JObject.Parse(json);
        if (jobject["code"].ToString() == "0")
        {
          this.Int32_3 = Convert.ToInt32(jobject["data"][(object) "next_request"].ToString());
          this.Int32_1 = Convert.ToInt32(jobject["data"][(object) "timeout"].ToString());
          if (this.Int32_0 == 0)
          {
            this.String_1 = jobject["data"][(object) "https"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_2 = int.Parse(strArray[1]);
          }
          else
          {
            this.String_1 = jobject["data"][(object) "socks5"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_2 = int.Parse(strArray[1]);
          }
          return true;
        }
      }
      catch
      {
      }
    }
    return false;
  }

  public string method_7()
  {
    do
      ;
    while (!this.method_6());
    return this.String_1;
  }

  private static string smethod_1(string string_3, string string_4)
  {
    try
    {
      HttpClient httpClient = new HttpClient();
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
      HttpContent httpContent_0 = (HttpContent) new StringContent(string_4, Encoding.UTF8, "application/json");
      Task<string> task = Task.Run<string>((Func<Task<string>>) (() => Class47.smethod_3(new Uri(string_3), httpContent_0)));
      task.Wait();
      return task.Result;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Request Post");
      return "";
    }
  }

  public static string smethod_2(string string_3)
  {
    try
    {
      HttpClient httpClient = new HttpClient();
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
      Task<string> task = Task.Run<string>((Func<Task<string>>) (() => Class47.smethod_4(new Uri(string_3))));
      task.Wait();
      return task.Result;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Request get");
      return "";
    }
  }

  private static async Task<string> smethod_3(Uri uri_0, HttpContent httpContent_0)
  {
    string result = string.Empty;
    using (HttpClient httpClient = new HttpClient())
    {
      HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(uri_0, httpContent_0);
      if (httpResponseMessage.IsSuccessStatusCode)
        result = await httpResponseMessage.Content.ReadAsStringAsync();
      httpResponseMessage = (HttpResponseMessage) null;
    }
    string str = result;
    result = (string) null;
    return str;
  }

  private static async Task<string> smethod_4(Uri uri_0)
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
