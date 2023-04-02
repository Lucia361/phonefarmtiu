// Decompiled with JetBrains decompiler
// Type: Class7
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

internal class Class7
{
  private Random random_0 = new Random();
  private object object_0 = new object();
  public int int_2 = 0;
  public int int_3 = 0;
  public int int_4 = 3;

  public string String_0 { get; set; }

  public string String_1 { get; set; }

  public int Int32_0 { get; set; }

  public string String_2 { get; set; }

  public int Int32_1 { get; set; }

  public Class7(string string_3, int int_5, int int_6)
  {
    this.String_0 = string_3;
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_1 = 0;
    this.Int32_0 = int_5;
    this.int_4 = int_6;
    this.int_2 = 0;
    this.int_3 = 0;
  }

  public void method_0()
  {
    lock (this.object_0)
    {
      --this.int_2;
      if (this.int_2 != 0 || this.int_3 != this.int_4)
        return;
      this.int_3 = 0;
    }
  }

  public bool method_1()
  {
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_1 = 0;
    string json = Class7.smethod_1("http://proxy.shoplike.vn/Api/getNewProxy?access_token=" + this.String_0);
    if (json != "")
    {
      try
      {
        JObject jobject = JObject.Parse(json);
        if (jobject["status"].ToString() == "success")
        {
          if (this.Int32_0 == 0)
          {
            this.String_1 = jobject["data"][(object) "proxy"].ToString();
            string[] strArray = this.String_1.Split(':');
            this.String_2 = strArray[0];
            this.Int32_1 = int.Parse(strArray[1]);
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

  public bool method_2()
  {
    this.String_1 = "";
    this.String_2 = "";
    this.Int32_1 = 0;
    string json = Class7.smethod_1("http://proxy.shoplike.vn/Api/getCurrentProxy?access_token=" + this.String_0);
    if (json != "")
    {
      try
      {
        JObject jobject = JObject.Parse(json);
        if (jobject["status"].ToString() == "success")
        {
          this.String_1 = jobject["data"][(object) "proxy"].ToString();
          string[] strArray = this.String_1.Split(':');
          this.String_2 = strArray[0];
          this.Int32_1 = int.Parse(strArray[1]);
          return true;
        }
      }
      catch
      {
      }
    }
    return false;
  }

  public string method_3()
  {
    do
      ;
    while (!this.method_2());
    return this.String_1;
  }

  private static string smethod_0(string string_3, string string_4)
  {
    try
    {
      HttpClient httpClient = new HttpClient();
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
      HttpContent httpContent_0 = (HttpContent) new StringContent(string_4, Encoding.UTF8, "application/json");
      Task<string> task = Task.Run<string>((Func<Task<string>>) (() => Class7.smethod_2(new Uri(string_3), httpContent_0)));
      task.Wait();
      return task.Result;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Request Post");
      return "";
    }
  }

  public static string smethod_1(string string_3)
  {
    try
    {
      HttpClient httpClient = new HttpClient();
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
      Task<string> task = Task.Run<string>((Func<Task<string>>) (() => Class7.smethod_3(new Uri(string_3))));
      task.Wait();
      return task.Result;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Request get");
      return "";
    }
  }

  private static async Task<string> smethod_2(Uri uri_0, HttpContent httpContent_0)
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

  private static async Task<string> smethod_3(Uri uri_0)
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
