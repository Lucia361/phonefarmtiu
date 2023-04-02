// Decompiled with JetBrains decompiler
// Type: Class11
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

internal class Class11
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

  public Class11(string string_3, string string_4, int int_4, int int_5)
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
      Class11.smethod_0("https://apiv2-public.vitechcheap.com/v1/public/rotate", this.string_0, "{\"proxy\": \"" + this.string_1 + "\"}");
      return flag;
    }
    catch
    {
      return false;
    }
  }

  private static string smethod_0(string string_3, string string_4, string string_5)
  {
    try
    {
      HttpClient httpClient = new HttpClient();
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
      httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", string_4);
      HttpContent httpContent_0 = (HttpContent) new StringContent(string_5, Encoding.UTF8, "application/json");
      Task<string> task = Task.Run<string>((Func<Task<string>>) (() => Class11.smethod_1(new Uri(string_3), httpContent_0)));
      task.Wait();
      return task.Result;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Request Post");
      return "";
    }
  }

  private static async Task<string> smethod_1(Uri uri_0, HttpContent httpContent_0)
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
    bool flag1 = false;
    try
    {
      return flag1;
    }
    catch
    {
      bool flag2;
      return flag2;
    }
  }
}
