// Decompiled with JetBrains decompiler
// Type: GClass24
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Linq;
using xNet;

public class GClass24
{
  public HttpRequest httpRequest_0;

  public GClass24(string string_0, string string_1, string string_2, int int_0)
  {
    if (string_1 == "")
      string_1 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
    this.httpRequest_0 = new HttpRequest()
    {
      KeepAlive = true,
      AllowAutoRedirect = true,
      Cookies = new CookieDictionary(),
      UserAgent = string_1
    };
    this.httpRequest_0.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
    this.httpRequest_0.AddHeader("Accept-Language", "en-US,en;q=0.9");
    if (string_0 != "")
      this.method_4(string_0);
    if (!(string_2 != ""))
      return;
    switch (((IEnumerable<string>) string_2.Split(':')).Count<string>())
    {
      case 1:
        if (int_0 == 0)
        {
          this.httpRequest_0.Proxy = (ProxyClient) HttpProxyClient.Parse("127.0.0.1:" + string_2);
          break;
        }
        this.httpRequest_0.Proxy = (ProxyClient) Socks5ProxyClient.Parse("127.0.0.1:" + string_2);
        break;
      case 2:
        if (int_0 == 0)
        {
          this.httpRequest_0.Proxy = (ProxyClient) HttpProxyClient.Parse(string_2);
          break;
        }
        this.httpRequest_0.Proxy = (ProxyClient) Socks5ProxyClient.Parse(string_2);
        break;
      case 4:
        if (int_0 == 0)
        {
          this.httpRequest_0.Proxy = (ProxyClient) new HttpProxyClient(string_2.Split(':')[0], Convert.ToInt32(string_2.Split(':')[1]), string_2.Split(':')[2], string_2.Split(':')[3]);
          break;
        }
        this.httpRequest_0.Proxy = (ProxyClient) new Socks5ProxyClient(string_2.Split(':')[0], Convert.ToInt32(string_2.Split(':')[1]), string_2.Split(':')[2], string_2.Split(':')[3]);
        break;
    }
  }

  public string method_0(string string_0)
  {
    try
    {
      this.httpRequest_0.AddHeader("Cache-Control", "no-cache");
      return this.httpRequest_0.Get(string_0).ToString();
    }
    catch (Exception ex)
    {
      return this.method_2(ex);
    }
  }

  public string method_1(string string_0, string string_1 = "", string string_2 = "application/x-www-form-urlencoded")
  {
    try
    {
      this.httpRequest_0.AddHeader("Cache-Control", "no-cache");
      return string_1 == "" || string_2 == "" ? this.httpRequest_0.Post(string_0).ToString() : this.httpRequest_0.Post(string_0, string_1, string_2).ToString();
    }
    catch (Exception ex)
    {
      return this.method_2(ex);
    }
  }

  public string method_2(Exception exception_0)
  {
    if (exception_0.ToString().Contains("Thread was being aborted."))
      return "";
    return exception_0.ToString().Contains("Не удалось соединиться с HTTP-сервером") ? "cannot_connect" : this.httpRequest_0.Response.ToString();
  }

  public byte[] method_3(string string_0) => this.httpRequest_0.Get(string_0).ToBytes();

  public void method_4(string string_0)
  {
    string str1 = string_0;
    char[] chArray = new char[1]{ ';' };
    foreach (string str2 in str1.Split(chArray))
    {
      string[] source = str2.Split('=');
      if (((IEnumerable<string>) source).Count<string>() > 1)
      {
        try
        {
          this.httpRequest_0.Cookies.Add(source[0], str2.Substring(str2.IndexOf("=") + 1));
        }
        catch
        {
        }
      }
    }
  }

  public string method_5() => this.httpRequest_0.Cookies.ToString();
}
