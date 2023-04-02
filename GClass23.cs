// Decompiled with JetBrains decompiler
// Type: GClass23
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using HttpRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

public class GClass23
{
  public RequestHTTP requestHTTP_0;
  private string string_0;
  private string string_1;

  public GClass23(string string_2 = "", string string_3 = "", string string_4 = "", int int_0 = 0)
  {
    this.string_0 = !(string_3 == "") ? string_3 : "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
    this.requestHTTP_0 = new RequestHTTP();
    this.requestHTTP_0.SetSSL((SecurityProtocolType) 3072);
    this.requestHTTP_0.SetKeepAlive(true);
    this.requestHTTP_0.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: " + this.string_0
    });
    if (string_2 != "")
      this.method_2(string_2);
    this.string_1 = string_4;
  }

  public string method_0(string string_2)
  {
    try
    {
      if (!(this.string_1 != ""))
        return this.requestHTTP_0.Request(Url: string_2).ToString();
      if (!this.string_1.Contains(":"))
        return this.requestHTTP_0.Request(Url: string_2, proxy: new WebProxy("127.0.0.1", Convert.ToInt32(this.string_1))).ToString();
      return this.requestHTTP_0.Request(Url: string_2, proxy: new WebProxy(this.string_1.Split(':')[0], Convert.ToInt32(this.string_1.Split(':')[1]))).ToString();
    }
    catch (Exception ex)
    {
    }
    return "";
  }

  public string method_1(string string_2, string string_3 = "")
  {
    if (!(this.string_1 != ""))
      return this.requestHTTP_0.Request("POST", string_2, Data: Encoding.ASCII.GetBytes(string_3)).ToString();
    if (!this.string_1.Contains(":"))
      return this.requestHTTP_0.Request("POST", string_2, Data: Encoding.ASCII.GetBytes(string_3), proxy: new WebProxy("127.0.0.1", Convert.ToInt32(this.string_1))).ToString();
    return this.requestHTTP_0.Request("POST", string_2, Data: Encoding.ASCII.GetBytes(string_3), proxy: new WebProxy(this.string_1.Split(':')[0], Convert.ToInt32(this.string_1.Split(':')[1]))).ToString();
  }

  public void method_2(string string_2)
  {
    string[] strArray = string_2.Split(';');
    string str1 = "";
    foreach (string str2 in strArray)
    {
      char[] chArray = new char[1]{ '=' };
      string[] source = str2.Split(chArray);
      if (((IEnumerable<string>) source).Count<string>() > 1)
      {
        try
        {
          str1 = str1 + source[0] + "=" + source[1] + ";";
        }
        catch
        {
        }
      }
    }
    this.requestHTTP_0.SetDefaultHeaders(new string[3]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8;charset=UTF-8",
      "user-agent: " + this.string_0,
      "cookie: " + str1
    });
  }

  public string method_3() => this.requestHTTP_0.GetCookiesString();
}
