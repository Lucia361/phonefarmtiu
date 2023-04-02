// Decompiled with JetBrains decompiler
// Type: GClass29
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using DeviceId;
using HttpRequest;
using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using xNet;

public class GClass29
{
  public static int int_0;
  public static int int_1;
  public static string string_0;
  public static string string_1;
  public static string string_2;
  private static string[] string_3 = new string[15]
  {
    "aAeEoOuUiIdDyY",
    "áàạảãâấầậẩẫăắằặẳẵ",
    "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
    "éèẹẻẽêếềệểễ",
    "ÉÈẸẺẼÊẾỀỆỂỄ",
    "óòọỏõôốồộổỗơớờợởỡ",
    "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
    "úùụủũưứừựửữ",
    "ÚÙỤỦŨƯỨỪỰỬỮ",
    "íìịỉĩ",
    "ÍÌỊỈĨ",
    "đ",
    "Đ",
    "ýỳỵỷỹ",
    "ÝỲỴỶỸ"
  };

  public static string smethod_0(string string_4)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[3]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
      "cookie: " + string_4
    });
    return Regex.Match(requestHttp.Request(Url: "https://business.facebook.com/content_management/"), "EAAG(.*?)\"").Value.Replace("\"", "");
  }

  public static void smethod_1(ChromeDriver chromeDriver_0)
  {
    try
    {
      chromeDriver_0.Quit();
    }
    catch
    {
    }
  }

  public static ChromeDriver smethod_2(
    ChromeDriver chromeDriver_0,
    bool bool_0,
    bool bool_1,
    string string_4,
    string string_5,
    bool bool_2,
    Point point_0,
    Point point_1,
    string string_6,
    int int_2 = 0,
    int int_3 = 0)
  {
    ChromeDriverService defaultService = ChromeDriverService.CreateDefaultService();
    if (bool_0)
      defaultService.HideCommandPromptWindow = true;
    ChromeOptions options = new ChromeOptions();
    ChromeOptions chromeOptions = options;
    string[] strArray = new string[19];
    strArray[0] = "--disable-notifications";
    int num = point_0.X;
    string str1 = num.ToString();
    num = point_0.Y;
    string str2 = num.ToString();
    strArray[1] = "--window-size=" + str1 + "," + str2;
    num = point_1.X;
    string str3 = num.ToString();
    num = point_1.Y;
    string str4 = num.ToString();
    strArray[2] = "--window-position=" + str3 + "," + str4;
    strArray[3] = "--no-sandbox";
    strArray[4] = "--disable-gpu";
    strArray[5] = "--disable-dev-shm-usage";
    strArray[6] = "--disable-web-security";
    strArray[7] = "--disable-rtc-smoothness-algorithm";
    strArray[8] = "--disable-webrtc-hw-decoding";
    strArray[9] = "--disable-webrtc-hw-encoding";
    strArray[10] = "--disable-webrtc-multiple-routes";
    strArray[11] = "--disable-webrtc-hw-vp8-encoding";
    strArray[12] = "--enforce-webrtc-ip-permission-check";
    strArray[13] = "--force-webrtc-ip-handling-policy";
    strArray[14] = "--ignore-certificate-errors";
    strArray[15] = "--disable-infobars";
    strArray[16] = "--mute-audio";
    strArray[17] = "--disable-popup-blocking";
    strArray[18] = "--user-agent=" + string_4;
    chromeOptions.AddArguments(strArray);
    options.AddUserProfilePreference("profile.default_content_setting_values.notifications", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.plugins", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.popups", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.geolocation", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.auto_select_certificate", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.mixed_script", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.media_stream", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.media_stream_mic", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.media_stream_camera", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.protocol_handlers", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.midi_sysex", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.push_messaging", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.ssl_cert_decisions", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.metro_switch_to_desktop", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.protected_media_identifier", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.site_engagement", (object) 1);
    options.AddUserProfilePreference("profile.default_content_setting_values.durable_storage", (object) 1);
    options.AddUserProfilePreference("profile.managed_default_content_settings.images", (object) 1);
    options.AddUserProfilePreference("useAutomationExtension", (object) true);
    if (bool_2)
    {
      string_5 = "";
      options.AddArgument("--headless");
    }
    if (bool_1)
      options.AddArgument("--blink-settings=imagesEnabled=false");
    if (!string.IsNullOrEmpty(string_5.Trim()))
      options.AddArgument("--user-data-dir=" + string_5);
    if (string_6 == "-1")
      string_6 = "";
    if (!string.IsNullOrEmpty(string_6.Trim()))
      options.AddArgument("--proxy-server= 127.0.0.1:" + string_6);
    chromeDriver_0 = new ChromeDriver(defaultService, options);
    chromeDriver_0.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds((double) int_2);
    chromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds((double) int_3);
    return chromeDriver_0;
  }

  public static List<string> smethod_3(List<string> list_0)
  {
    for (int index = 0; index < list_0.Count; ++index)
    {
      if (list_0[index].Trim() == "")
        list_0.RemoveAt(index--);
    }
    return list_0;
  }

  public static string smethod_4(string string_4)
  {
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        "cookie: " + string_4
      });
      return Regex.Matches(requestHttp.Request(Url: "https://mbasic.facebook.com/groups/?seemore&refid=27"), "</li>").Count.ToString();
    }
    catch
    {
      return "";
    }
  }

  public static string smethod_5(string string_4)
  {
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        "cookie: " + string_4
      });
      string str = Regex.Match(Regex.Match(requestHttp.Request(Url: "https://mbasic.facebook.com/profile.php?v=friends&refid=17"), "allactivity\\?refid=17\"(.*?)</h3>").Value.ToString(), "\\((.*?)\\)").Groups[1].Value.ToString().Replace(".", "");
      if (str == "")
        str = "0";
      return str;
    }
    catch
    {
      return "";
    }
  }

  public static string smethod_6(string string_4)
  {
    try
    {
      return Regex.Match(string_4, "c_user=(.*?);").Value + Regex.Match(string_4, "xs=(.*?);").Value + Regex.Match(string_4, "fr=(.*?);").Value + Regex.Match(string_4, "datr=(.*?);").Value;
    }
    catch
    {
      return string_4;
    }
  }

  public static bool smethod_7(ChromeDriver chromeDriver_0, int int_2, string string_4)
  {
    try
    {
      if (int_2 == 0)
        chromeDriver_0.FindElementById(string_4);
      return true;
    }
    catch
    {
      return false;
    }
  }

  public static bool smethod_8(string string_4)
  {
    bool flag = false;
    try
    {
      xNet.HttpRequest httpRequest = new xNet.HttpRequest();
      httpRequest.KeepAlive = true;
      httpRequest.Cookies = new CookieDictionary();
      httpRequest.AddHeader(HttpHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
      httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
      httpRequest.UserAgent = xNet.Http.ChromeUserAgent();
      string address = "https://graph.facebook.com/" + string_4 + "/picture";
      httpRequest.Get(address).ToString();
      return true;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_9(string string_4)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
    });
    return !requestHttp.Request(Url: ("https://graph.facebook.com/" + string_4 + "/picture")).Contains("error");
  }

  public static string smethod_10(string string_4, string string_5)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
    });
    string input1 = requestHttp.Request(Url: "https://login.yahoo.com/config/login");
    string str1 = Regex.Match(input1, "acrumb\" value=\"(.*?)\"").Groups[1].Value;
    string str2 = Regex.Match(input1, "sessionIndex\" value=\"(.*?)\"").Groups[1].Value;
    string str3 = Regex.Match(input1, "persistent\" value=\"(.*?)\"").Groups[1].Value;
    string s1 = "acrumb=" + str1 + "&sessionIndex=" + str2 + "&username=" + string_4 + "&passwd=&signin=Ti%E1%BA%BFp%C2%A0theo&persistent=" + str3;
    string input2 = requestHttp.Request("POST", "https://login.yahoo.com/config/login", Data: Encoding.ASCII.GetBytes(s1));
    string str4 = Regex.Match(input2, "crumb\" value=\"(.*?)\"").Groups[1].Value;
    string str5 = Regex.Match(input2, "passwordContext\" value=\"(.*?)\"").Groups[1].Value;
    string s2 = "browser-fp-data=%7B%22language%22%3A%22en-US%22%2C%22colorDepth%22%3A24%2C%22deviceMemory%22%3A8%2C%22pixelRatio%22%3A1%2C%22hardwareConcurrency%22%3A8%2C%22timezoneOffset%22%3A-420%2C%22timezone%22%3A%22Asia%2FBangkok%22%2C%22sessionStorage%22%3A1%2C%22localStorage%22%3A1%2C%22indexedDb%22%3A1%2C%22openDatabase%22%3A1%2C%22cpuClass%22%3A%22unknown%22%2C%22platform%22%3A%22Win32%22%2C%22doNotTrack%22%3A%221%22%2C%22plugins%22%3A%7B%22count%22%3A3%2C%22hash%22%3A%22e43a8bc708fc490225cde0663b28278c%22%7D%2C%22canvas%22%3A%22canvas+winding%3Ayes%7Ecanvas%22%2C%22webgl%22%3A1%2C%22webglVendorAndRenderer%22%3A%22Google+Inc.%7EANGLE+%28Intel%28R%29+UHD+Graphics+630+Direct3D11+vs_5_0+ps_5_0%29%22%2C%22adBlock%22%3A1%2C%22hasLiedLanguages%22%3A0%2C%22hasLiedResolution%22%3A0%2C%22hasLiedOs%22%3A0%2C%22hasLiedBrowser%22%3A0%2C%22touchSupport%22%3A%7B%22points%22%3A0%2C%22event%22%3A0%2C%22start%22%3A0%7D%2C%22fonts%22%3A%7B%22count%22%3A45%2C%22hash%22%3A%2246a30c0488455f08568f3e573502b25e%22%7D%2C%22audio%22%3A%22124.0434474653739%22%2C%22resolution%22%3A%7B%22w%22%3A%221920%22%2C%22h%22%3A%221080%22%7D%2C%22availableResolution%22%3A%7B%22w%22%3A%221040%22%2C%22h%22%3A%221920%22%7D%2C%22ts%22%3A%7B%22serve%22%3A1559177497471%2C%22render%22%3A1559177497688%7D%7D&crumb=" + str4 + "&acrumb=" + str1 + "&sessionIndex=" + str2 + "&displayName=phuonglazy&username=" + string_4 + "&passwordContext=" + str5 + "&password=" + string_5 + "&verifyPassword=%C4%90%C4%83ng+nh%E1%BA%ADp";
    string str6 = requestHttp.Request("POST", "https://login.yahoo.com/account/challenge/password", Data: Encoding.ASCII.GetBytes(s2));
    requestHttp.Request(Url: "https://mail.yahoo.com").ToString();
    return (str6.Contains("login-passwd") || !str6.Contains(string_4.Replace("@yahoo.com", "")) ? "0|" : "1|") + requestHttp.GetCookiesString("https://login.yahoo.com");
  }

  public static string smethod_11(string string_4, string string_5)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[3]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
      "cookie: " + string_5
    });
    string str = requestHttp.Request(Url: "https://mail.yahoo.com").ToString();
    return (str.Contains("login-username") || !str.Contains(string_4.Replace("@yahoo.com", "")) ? "0|" : "1|") + requestHttp.GetCookiesString("https://login.yahoo.com");
  }

  public static string smethod_12(string string_4, int int_2)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[3]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
      "cookie: " + string_4
    });
    requestHttp.Request(Url: "https://mail.yahoo.com").ToString();
    bool flag = false;
    int tickCount = Environment.TickCount;
    while (Environment.TickCount - tickCount <= int_2 * 1000)
    {
      string str = Regex.Match(Regex.Match(requestHttp.Request(Url: "https://mail.yahoo.com").ToString(), "message-subject(.*?)</span>", RegexOptions.Singleline).Value, "\\d{6}", RegexOptions.Singleline).Value;
      if (!(str != ""))
      {
        if (!flag)
          continue;
      }
      return str;
    }
    return "";
  }

  public static string smethod_13(string string_4, string string_5)
  {
    try
    {
      using (ImapClient imapClient = new ImapClient())
      {
        imapClient.Connect("outlook.office365.com", 993, true, new CancellationToken());
        imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
        imapClient.Authenticate(string_4, string_5, new CancellationToken());
        IMailFolder inbox = imapClient.Inbox;
        int num = (int) inbox.Open(FolderAccess.ReadOnly);
        for (int index = 0; index < inbox.Count; ++index)
        {
          MimeMessage message = inbox.GetMessage(index);
          inbox.AddFlags(index, MessageFlags.Deleted, true);
          string subject = message.Subject;
        }
        imapClient.Disconnect(true, new CancellationToken());
      }
      return "1";
    }
    catch
    {
      return "0";
    }
  }

  public static void smethod_14(ChromeDriver chromeDriver_0, string string_4)
  {
    try
    {
      Random random = new Random();
      string str = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + "_" + random.Next(1, 1000).ToString();
      if (chromeDriver_0 != null)
      {
        string contents = chromeDriver_0.ExecuteScript("var markup = document.documentElement.innerHTML;return markup;", Array.Empty<object>()).ToString();
        chromeDriver_0.GetScreenshot().SaveAsFile("log\\images\\" + str + ".png");
        System.IO.File.WriteAllText("log\\html\\" + str + ".html", contents);
      }
      System.IO.File.AppendAllText("log\\log.txt", DateTime.Now.ToString() + "|<" + str + ">|" + string_4 + Environment.NewLine);
    }
    catch
    {
    }
  }

  public static string smethod_15(string string_4, string string_5, int int_2)
  {
    bool flag = false;
    string str = "";
    int tickCount = Environment.TickCount;
    while (Environment.TickCount - tickCount <= int_2 * 1000)
    {
      using (ImapClient imapClient = new ImapClient())
      {
        imapClient.Connect("outlook.office365.com", 993, true, new CancellationToken());
        imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
        imapClient.Authenticate(string_4, string_5, new CancellationToken());
        IMailFolder inbox = imapClient.Inbox;
        int num = (int) inbox.Open(FolderAccess.ReadOnly);
        if (inbox.Count > 0)
        {
          str = Regex.Match(inbox.GetMessage(0).Body.ToString(), "\\d{6}", RegexOptions.Singleline).Value;
          if (!str.Equals(""))
          {
            flag = true;
            goto label_12;
          }
        }
        imapClient.Disconnect(true, new CancellationToken());
      }
      if (!flag)
        continue;
label_12:
      return str;
    }
    return "";
  }

  public static bool smethod_16(string string_4, string string_5)
  {
    bool flag = false;
    try
    {
      if (GClass29.smethod_18(string_4).Equals("Die"))
        return flag;
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        "cookie: " + string_4
      });
      string str = Regex.Match(requestHttp.Request(Url: ("https://mbasic.facebook.com/" + string_5)), "/a/mobile/friends/profile_add_friend(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
      if (str.Equals(""))
        return flag;
      string Url = "https://mbasic.facebook.com" + str;
      requestHttp.Request(Url: Url);
      Thread.Sleep(300);
      flag = !requestHttp.Request(Url: ("https://mbasic.facebook.com/" + string_5)).Contains("profile_add_friend");
    }
    catch
    {
    }
    return flag;
  }

  public static string smethod_17(string string_4, string string_5, int int_2 = 0)
  {
    int num = 0;
    try
    {
      if (GClass29.smethod_18(string_4).Equals("Die"))
        return "";
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        "cookie: " + string_4
      });
      string Url1 = "https://mbasic.facebook.com/send_page_invite/?pageid=" + string_5;
      bool flag;
      do
      {
        flag = false;
        string input = requestHttp.Request(Url: Url1);
        MatchCollection matchCollection = Regex.Matches(input, "/pages/friend_invite/send/(.*?)\"");
        for (int i = 0; i < matchCollection.Count; ++i)
        {
          string Url2 = "https://mbasic.facebook.com" + matchCollection[i].Value.Replace("\"", "").Replace("amp;", "");
          requestHttp.Request(Url: Url2);
          ++num;
          if (int_2 != 0)
            Thread.Sleep(int_2);
        }
        if (input.Contains("offset"))
          flag = true;
      }
      while (flag);
    }
    catch
    {
    }
    return num.ToString() ?? "";
  }

  public static string smethod_18(string string_4)
  {
    string_4 = GClass29.smethod_66(string_4);
    string str1 = "Die";
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        "cookie: " + string_4
      });
      string str2 = Regex.Match(string_4, "c_user=(.*?);").Groups[1].Value;
      string str3 = requestHttp.Request(Url: "https://www.facebook.com/me");
      if (!str2.Equals("") && str3.Contains(str2) && str3.Contains("entity_id") && !str3.Contains("checkpointSubmitButton"))
        str1 = "Live";
    }
    catch
    {
    }
    return str1;
  }

  public static string smethod_19(string string_4, string string_5 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36")
  {
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: application/x-www-form-urlencoded",
        "user-agent: " + string_5,
        "cookie: " + string_4
      });
      return JObject.Parse(requestHttp.Request(Url: "https://m.facebook.com/ajax/dtsg/?__ajax__=true").Replace("for (;;);", ""))["payload"][(object) "token"].ToString();
    }
    catch
    {
      return "";
    }
  }

  public static string smethod_20(
    string string_4,
    string string_5,
    string string_6,
    string string_7)
  {
    string str1 = GClass29.smethod_21(string_6);
    if (str1 == "")
      return "";
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[3]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
      "cookie: " + string_4
    });
    string str2 = Regex.Match(string_4, "c_user=(.*?);").Groups[1].Value;
    string str3 = GClass29.smethod_19(string_4);
    string input = requestHttp.Request(Url: "https://m.facebook.com/me");
    string str4 = Regex.Match(input, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
    string str5 = Regex.Match(input, "name=\"privacyx\" value=\"(.*?)\"").Groups[1].Value;
    string str6 = Regex.Match(input, "__spin_r\":(.*?),").Groups[1].Value;
    string str7 = str6;
    string str8 = Regex.Match(input, "__spin_t\":(.*?),").Groups[1].Value;
    string s = "__user=" + str2 + "&__a=1&__dyn=7AgNe-UOByEogDxyHqzGomzFEbEyGzEy4aheC267Uqzob4q2i5UK3u2C3-u5RyUoxGEbbyEjKewXwgUOdwJyFElwzxCuifz8nxm1Dxa2m4o6e2e79oeGwaWum1NwJxCq7ooxu6U8kU4m3mbx-2K1KUkBzXG6o6CEWu4EhwG-U99m4-3Cfz8-4U-5898Gfxm7omyUnG12AgG4eeKi8wg8jyE5WcyES48y8xK3yeCzEmgK7o88vwEy8iwSwjU4W2WE9EjwtUym2mfxW68lBwcO&__csr=&__req=13&__pc=PHASED%3ADEFAULT&dpr=1&__rev=" + str6 + "&__s=k2qltm%3Act038n%3Av4okyh&__hsi=6766055500147629515-0&fb_dtsg=" + WebUtility.UrlEncode(str3) + "&jazoest=" + str4 + "&__spin_r=" + str7 + "&__spin_b=trunk&__spin_t=" + str8;
    string str9;
    if (string_7 != "")
      str9 = "https://www.facebook.com/share/dialog/submit/?app_id=2309869772&audience_type=group&audience_targets[0]=" + string_7 + "&composer_session_id=38700f24-cbee-4aaa-a626-9fd6f4056e3a&ephemeral_ttl_mode=0&ft[tn]=J]-R-R&ft[type]=25&ft[mf_story_key]=&ft[top_level_post_id]=&ft[tl_objid]=&ft[content_owner_id_new]=&ft[throwback_story_fbid]=&ft[story_location]=9&ft[story_attachment_style]=share&ft[fbfeed_location]=5&internalextra[feedback_source]=2&is_forced_reshare_of_post=true&message=" + WebUtility.UrlEncode(string_5) + "&owner_id=&post_id=" + str1 + "&share_to_group_as_page=false&share_type=99&shared_ad_id=&source=osbach&is_throwback_post=false&url=&shared_from_post_id=&logging_session_id=e24e7b30-b545-4305-a233-b9874afe63d4&perform_messenger_logging=true&video_start_time_ms=0&is_app_content_token=false&av=" + str2;
    else
      str9 = "https://www.facebook.com/share/dialog/submit/?app_id=2309869772&audience_type=self&composer_session_id=38700f24-cbee-4aaa-a626-9fd6f4056e3a&ephemeral_ttl_mode=0&ft[tn]=J]-R-R&ft[type]=25&ft[mf_story_key]=&ft[top_level_post_id]=&ft[tl_objid]=&ft[content_owner_id_new]=&ft[throwback_story_fbid]=&ft[story_location]=9&ft[story_attachment_style]=share&ft[fbfeed_location]=5&internalextra[feedback_source]=2&is_forced_reshare_of_post=true&message=" + WebUtility.UrlEncode(string_5) + "&owner_id=&post_id=" + str1 + "&privacy=" + str5 + "&share_to_group_as_page=false&share_type=99&shared_ad_id=&source=osbach&is_throwback_post=false&url=&shared_from_post_id=&logging_session_id=e24e7b30-b545-4305-a233-b9874afe63d4&perform_messenger_logging=true&video_start_time_ms=0&is_app_content_token=false&av=" + str2;
    string Url = str9;
    return Regex.Match(requestHttp.Request("POST", Url, Data: Encoding.ASCII.GetBytes(s)), "object_id\":(.*?),").Groups[1].Value;
  }

  public static string smethod_21(string string_4)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: application/x-www-form-urlencoded",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36"
    });
    string input = requestHttp.Request(Url: string_4);
    string str = Regex.Match(input, "\\\\\"post_fbid\\\\\":(.*?)}", RegexOptions.Singleline).Groups[1].Value;
    if (str == "")
      str = Regex.Match(input, "share_fbid:\"(.*?)\"", RegexOptions.Singleline).Groups[1].Value;
    if (str == "")
      str = Regex.Match(input, "videos/(.*?)/", RegexOptions.Singleline).Groups[1].Value;
    return str;
  }

  public static void smethod_22(string string_4)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[3]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
      "cookie: " + string_4
    });
    string str = Regex.Match(requestHttp.Request(Url: "https://mbasic.facebook.com/privacy/touch/composer/selector/?logging_source=composer_options"), "/privacy/save(.*?)\"").Value.Replace("\"", "").Replace("&amp;", "&");
    requestHttp.Request(Url: ("https://mbasic.facebook.com" + str));
  }

  public static List<string> smethod_23(string string_4)
  {
    List<string> stringList = new List<string>();
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[3]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
      "cookie: " + string_4
    });
    string Url = "https://mbasic.facebook.com/friends/center/friends/?ppk=" + 0.ToString();
    bool flag = true;
    try
    {
      while (flag)
      {
        string input = requestHttp.Request(Url: Url);
        MatchCollection matchCollection = Regex.Matches(input, "/friends/hovercard(.*?)<");
        for (int i = 0; i < matchCollection.Count; ++i)
        {
          string str1 = Regex.Match(matchCollection[i].Value, "uid=(.*?)&").Groups[1].Value;
          string str2 = Regex.Match(matchCollection[i].Value, ">(.*?)<").Groups[1].Value;
          stringList.Add(str1 + "|" + str2);
        }
        Url = Regex.Match(input, "/friends/center/friends/.ppk=(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
        if (Url.Equals(""))
        {
          flag = false;
        }
        else
        {
          flag = true;
          Url = "https://mbasic.facebook.com" + Url;
        }
      }
    }
    catch
    {
    }
    return stringList;
  }

  public static bool smethod_24(string string_4)
  {
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        "cookie: " + string_4
      });
      string Url1 = "https://mbasic.facebook.com" + Regex.Match(requestHttp.Request(Url: "https://mbasic.facebook.com/me/friends"), "/privacyx/selector/(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
      string Url2 = "https://mbasic.facebook.com" + Regex.Match(requestHttp.Request(Url: Url1), "/a/privacy/.px=300645083384735(.*?)\"").Value.Replace("\"", "").Replace("amp;", "");
      requestHttp.Request(Url: Url2);
      return true;
    }
    catch
    {
      return false;
    }
  }

  public static List<string> smethod_25(string string_4)
  {
    List<string> stringList = new List<string>();
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[2]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
      });
      JObject jobject = JObject.Parse(requestHttp.Request(Url: ("https://graph.facebook.com/me/accounts?access_token=" + string_4 + "&fields=id,likes&limit=50")));
      for (int key = 0; key < jobject["data"].Count<JToken>(); ++key)
        stringList.Add(jobject["data"][(object) key][(object) "id"].ToString() + "|" + jobject["data"][(object) key][(object) "likes"].ToString());
    }
    catch
    {
    }
    return stringList;
  }

  public static List<string> smethod_26(string string_4)
  {
    List<string> stringList = new List<string>();
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[2]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
      });
      JObject jobject = JObject.Parse(requestHttp.Request(Url: ("https://graph.facebook.com/me/businesses?access_token=" + string_4 + "&fields=id,name&limit=50")));
      for (int key = 0; key < jobject["data"].Count<JToken>(); ++key)
        stringList.Add(jobject["data"][(object) key][(object) "id"].ToString() + "|" + jobject["data"][(object) key][(object) "name"].ToString());
    }
    catch
    {
    }
    return stringList;
  }

  public static List<string> smethod_27(string string_4)
  {
    List<string> stringList = new List<string>();
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[2]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
      });
      JObject jobject = JObject.Parse(requestHttp.Request(Url: ("https://graph.facebook.com/me/adaccounts?access_token=" + string_4 + "&fields=id,min_billing_threshold&limit=100")));
      for (int key = 0; key < jobject["data"].Count<JToken>(); ++key)
      {
        try
        {
          stringList.Add(jobject["data"][(object) key][(object) "id"].ToString() + "|" + jobject["data"][(object) key][(object) "min_billing_threshold"][(object) "amount"].ToString() + " " + jobject["data"][(object) key][(object) "min_billing_threshold"][(object) "currency"].ToString());
        }
        catch
        {
        }
      }
    }
    catch
    {
    }
    return stringList;
  }

  public static List<string> smethod_28(string string_4)
  {
    List<string> stringList = new List<string>();
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[2]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
      });
      JObject jobject = JObject.Parse(requestHttp.Request(Url: ("https://graph.facebook.com/me/groups?access_token=" + string_4 + "&fields=id,administrator,member_count&limit=5000")));
      for (int key = 0; key < jobject["data"].Count<JToken>(); ++key)
      {
        try
        {
          if (jobject["data"][(object) key][(object) "administrator"].ToString().Equals("True"))
            stringList.Add(jobject["data"][(object) key][(object) "id"].ToString() + "|" + jobject["data"][(object) key][(object) "member_count"].ToString());
        }
        catch
        {
        }
      }
    }
    catch
    {
    }
    return stringList;
  }

  public static Dictionary<string, string> smethod_29(
    string string_4,
    string string_5,
    string string_6 = "")
  {
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[2]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
      });
      int num = 0;
      JObject jobject;
      string str1;
      string str2;
      string str3;
      string str4;
      string str5;
      string str6;
      string str7;
      while (true)
      {
        jobject = JObject.Parse(requestHttp.Request(Url: ("https://graph.facebook.com/v2.11/" + string_5 + "?fields=id,name,email,gender,birthday,friends.limit(0),groups.limit(5000){id}&access_token=" + string_4)));
        str1 = "";
        str2 = "";
        str3 = "";
        str4 = "";
        str5 = "";
        str6 = "";
        str7 = "Live";
        jobject["name"].ToString();
        try
        {
          str6 = jobject["birthday"].ToString();
        }
        catch
        {
        }
        try
        {
          str5 = jobject["gender"].ToString();
        }
        catch
        {
        }
        try
        {
          str1 = jobject["email"].ToString();
        }
        catch
        {
        }
        try
        {
          str4 = jobject["mobile_phone"].ToString();
        }
        catch
        {
        }
        try
        {
          str3 = jobject["friends"][(object) "summary"][(object) "total_count"].ToString();
          break;
        }
        catch
        {
          if (string_6 != "" && GClass29.smethod_18(string_6) == "Live" && num == 0 && GClass29.smethod_24(string_6))
            ++num;
          else
            break;
        }
      }
      if (str3 == "")
        str3 = "0";
      try
      {
        str2 = jobject["groups"][(object) "data"].Count<JToken>().ToString() ?? "";
      }
      catch
      {
      }
      if (str2 == "")
        str2 = "0";
      dictionary.Add("uid", jobject["id"].ToString());
      dictionary.Add("name", jobject["name"].ToString());
      dictionary.Add("birthday", str6);
      dictionary.Add("gender", str5);
      dictionary.Add("token", string_4);
      dictionary.Add("email", str1);
      dictionary.Add("phone", str4);
      dictionary.Add("friends", str3);
      dictionary.Add("groups", str2);
      dictionary.Add("info", str7);
    }
    catch
    {
      dictionary.Add("info", "Die");
    }
    return dictionary;
  }

  public static List<string> smethod_30(string string_4, int int_2)
  {
    List<string> stringList = new List<string>();
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
    });
    List<JObject> list = JArray.Parse(requestHttp.Request(Url: ("https://api.facebook.com/method/fql.query?query=select%20uid2%20from%20friend%20where%20uid1%20=%20me()%20order%20by%20rand()%20limit%20" + int_2.ToString() + "&access_token=" + string_4 + "&format=json")).ToString()).OfType<JObject>().ToList<JObject>();
    for (int index = 0; index < list.Count<JObject>(); ++index)
      stringList.Add(list[index]["uid2"].ToString());
    return stringList;
  }

  public static Dictionary<string, string> smethod_31(string string_4)
  {
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[2]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
      });
      JObject jobject = JObject.Parse(requestHttp.Request(Url: ("https://graph.facebook.com/v2.11/me?fields=id,name,email,gender,birthday,friends.limit(0),groups.limit(5000){id}&access_token=" + string_4)).ToString());
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string str4 = "";
      string str5 = "Live";
      jobject["name"].ToString();
      try
      {
        jobject["birthday"].ToString();
      }
      catch
      {
      }
      try
      {
        str4 = jobject["gender"].ToString();
      }
      catch
      {
      }
      try
      {
        str1 = jobject["email"].ToString();
      }
      catch
      {
      }
      try
      {
        str3 = jobject["mobile_phone"].ToString();
      }
      catch
      {
      }
      string str6 = jobject["friends"][(object) "summary"][(object) "total_count"].ToString();
      try
      {
        str2 = jobject["groups"][(object) "data"].Count<JToken>().ToString() ?? "";
      }
      catch
      {
      }
      if (str2 == "")
        str2 = "0";
      dictionary.Add("uid", jobject["id"].ToString());
      dictionary.Add("name", jobject["name"].ToString());
      dictionary.Add("birthday", jobject["birthday"].ToString());
      dictionary.Add("gender", str4);
      dictionary.Add("token", string_4);
      dictionary.Add("email", str1);
      dictionary.Add("phone", str3);
      dictionary.Add("friends", str6);
      dictionary.Add("groups", str2);
      dictionary.Add("info", str5);
    }
    catch (Exception ex)
    {
      dictionary.Add("info", "Die");
    }
    return dictionary;
  }

  public static string smethod_32(string string_4, string string_5)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
    });
    bool flag = false;
    string str1 = "882a8490361da98702bf97a021ddc14d";
    string lower = GClass29.smethod_42("api_key=" + str1 + "email=" + string_4 + "format=JSONlocale=vi_vnmethod=auth.loginpassword=" + string_5 + "return_ssl_resources=0v=1.062f8ce9f74b12f84c123cc23437a4a32").ToLower();
    JObject jobject = JObject.Parse(requestHttp.Request(Url: ("https://api.facebook.com/restserver.php?&api_key=" + str1 + "&email=" + string_4 + "&format=JSON&locale=vi_vn&method=auth.login&password=" + string_5 + "&return_ssl_resources=0&v=1.0&sig=" + lower)));
    string str2;
    try
    {
      str2 = jobject["access_token"].ToString();
    }
    catch
    {
      flag = true;
      JToken jtoken = jobject["error_code"];
      object obj;
      if (jtoken != null)
      {
        obj = (object) jtoken.ToString();
        if (obj != null)
          goto label_6;
      }
      obj = (object) "";
label_6:
      str2 = (string) obj;
    }
    return flag ? "1|" + str2 : "0|" + str2;
  }

  public static string smethod_33(string string_4, string string_5)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
    });
    bool flag = false;
    string str1 = "3e7c78e35a76a9299309885393b02d97";
    string lower = GClass29.smethod_42("api_key=" + str1 + "email=" + string_4 + "format=JSONlocale=vi_vnmethod=auth.loginpassword=" + string_5 + "return_ssl_resources=0v=1.0c1e620fa708a1d5696fb991c1bde5662").ToLower();
    JObject jobject = JObject.Parse(requestHttp.Request(Url: ("https://api.facebook.com/restserver.php?&api_key=" + str1 + "&email=" + string_4 + "&format=JSON&locale=vi_vn&method=auth.login&password=" + string_5 + "&return_ssl_resources=0&v=1.0&sig=" + lower)));
    string str2;
    try
    {
      str2 = jobject["access_token"].ToString();
    }
    catch
    {
      flag = true;
      JToken jtoken = jobject["error_code"];
      object obj;
      if (jtoken != null)
      {
        obj = (object) jtoken.ToString();
        if (obj != null)
          goto label_6;
      }
      obj = (object) "";
label_6:
      str2 = (string) obj;
    }
    return flag ? "1|" + str2 : "0|" + str2;
  }

  public static string smethod_34(string string_4, string string_5)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
    });
    string input1 = requestHttp.Request(Url: "https://mbasic.facebook.com");
    string str1 = Regex.Match(input1, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
    string str2 = Regex.Match(input1, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
    string str3 = Regex.Match(input1, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
    string str4 = Regex.Match(input1, "\"li\" value=\"(.*?)\"").Groups[1].Value;
    new string[1][0] = "referer: https://mbasic.facebook.com/checkpoint/?_rdr";
    requestHttp.Request("POST", "https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", Data: Encoding.UTF8.GetBytes("fb_dtsg=" + str1 + "%3D&jazoest=" + str2 + "&m_ts=" + str3 + "&li=" + str4 + "&try_number=0&unrecognized_tries=0&email=" + string_4 + "&pass=" + string_5 + "&login=Log+In"));
    string input2 = requestHttp.Request(Url: "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F");
    if (input2.Contains("checkpoint/?next"))
    {
      string str5 = "2|";
      string str6 = Regex.Match(input2, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
      string str7 = Regex.Match(input2, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
      string str8 = Regex.Match(input2, "\"nh\" value=\"(.*?)\"").Groups[1].Value;
      string str9 = Regex.Match(input2, "client_revision\":(.*?),").Groups[1].Value;
      requestHttp.Request("POST", "https://www.facebook.com/checkpoint/async?next=https%3A%2F%2Fwww.facebook.com%2F", Data: Encoding.UTF8.GetBytes("jazoest=" + str7 + "&fb_dtsg=" + str6 + "&nh=" + str8 + "&submit[Continue]=Ti%E1%BA%BFp%20t%E1%BB%A5c&__user=0&__a=1&__dyn=&__req=&__be=0&__pc=PHASED%3ADEFAULT&dpr=&__rev=" + str9));
      string input3 = requestHttp.Request(Url: "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F");
      MatchCollection matchCollection = Regex.Matches(input3, "verification_method\" value=\"(.*?)\"");
      if (matchCollection.Count > 0)
      {
        foreach (Match match in matchCollection)
          str5 = str5 + match.Groups[1].Value + "-";
        str5 = str5.TrimEnd('-');
      }
      else if (input3.Contains("full-name") || input3.Contains("captcha"))
        str5 += "72h";
      else if (input3.Contains("mvm uiP fsm"))
        str5 += "vhh";
      return str5 + "|" + requestHttp.GetCookiesString("https://www.facebook.com/");
    }
    return input2.Contains("id=\"email\"") || input2.Contains("id=\"pass\"") ? "3|" : "1|" + requestHttp.GetCookiesString("https://www.facebook.com/");
  }

  public static string smethod_35(
    string string_4,
    string string_5,
    string string_6,
    string string_7,
    int int_2)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: " + string_6
    });
    requestHttp.SetProxy(string_7, int_2);
    requestHttp.usProxy = true;
    string str1 = "";
    string input = requestHttp.Request(Url: "https://mbasic.facebook.com");
    string str2 = Regex.Match(input, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
    string str3 = Regex.Match(input, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
    string str4 = Regex.Match(input, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
    string str5 = Regex.Match(input, "\"li\" value=\"(.*?)\"").Groups[1].Value;
    requestHttp.Request("POST", "https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", Data: Encoding.UTF8.GetBytes("fb_dtsg=" + str2 + "%3D&jazoest=" + str3 + "&m_ts=" + str4 + "&li=" + str5 + "&try_number=0&unrecognized_tries=0&email=" + string_4 + "&pass=" + string_5 + "&login=Log+In"));
    requestHttp.Request(Url: "https://m.facebook.com/checkpoint/?next=https%3A%2F%2Fm.facebook.com%2F");
    requestHttp.Request(Url: "https://mbasic.facebook.com/checkpoint/?next=https%3A%2F%2Fmbasic.facebook.com%2F");
    requestHttp.Request(Url: "https://www.facebook.com/checkpoint/?next=https%3A%2F%www.facebook.com%2F");
    return str1;
  }

  public static string smethod_36(string string_4)
  {
    string str = "";
    // ISSUE: reference to a compiler-generated method
    switch (Class206.smethod_0(string_4))
    {
      case 334175660:
        if (string_4 == "18")
        {
          str = "Bình luận";
          break;
        }
        break;
      case 401286136:
        if (string_4 == "14")
        {
          str = "Thiết bị";
          break;
        }
        break;
      case 822911587:
        if (string_4 == "4")
        {
          str = "Otp";
          break;
        }
        break;
      case 906799682:
        if (string_4 == "3")
        {
          str = "Ảnh";
          break;
        }
        break;
      case 923577301:
        if (string_4 == "2")
        {
          str = "Ngày sinh";
          break;
        }
        break;
      case 1153637868:
        if (string_4 == "72h")
        {
          str = "72h";
          break;
        }
        break;
      case 2347784130:
        if (string_4 == "34")
        {
          str = "Otp";
          break;
        }
        break;
      case 2347931225:
        if (string_4 == "26")
        {
          str = "Bạn bè";
          break;
        }
        break;
      case 2381486463:
        if (string_4 == "20")
        {
          str = "Tin nhắn";
          break;
        }
        break;
      case 2517938561:
        if (string_4 == "vhh")
        {
          str = "Vô hiệu hóa";
          break;
        }
        break;
    }
    return str;
  }

  public static List<string> smethod_37(string string_4, string string_5)
  {
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
    });
    List<string> stringList = new List<string>();
    string input1 = requestHttp.Request(Url: "https://mbasic.facebook.com");
    string str1 = Regex.Match(input1, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
    string str2 = Regex.Match(input1, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
    string str3 = Regex.Match(input1, "\"m_ts\" value=\"(.*?)\"").Groups[1].Value;
    string str4 = Regex.Match(input1, "\"li\" value=\"(.*?)\"").Groups[1].Value;
    new string[1][0] = "referer: https://mbasic.facebook.com/checkpoint/?_rdr";
    string input2 = requestHttp.Request("POST", "https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", Data: Encoding.UTF8.GetBytes("fb_dtsg=" + str1 + "%3D&jazoest=" + str2 + "&m_ts=" + str3 + "&li=" + str4 + "&try_number=0&unrecognized_tries=0&email=" + string_4 + "&pass=" + string_5 + "&login=Log+In"));
    if (input2.Contains("checkpoint_title"))
    {
      string str5 = Regex.Match(input2, "\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
      string str6 = Regex.Match(input2, "\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
      string str7 = Regex.Match(input1, "\"nh\" value=\"(.*?)\"").Groups[1].Value;
      foreach (Match match in Regex.Matches(Regex.Match(requestHttp.Request(Url: "https://www.facebook.com/checkpoint/?next=https%3A%2F%2Fwww.facebook.com%2F"), "<select name=\"verification_method(.*?)</select>").Value, "\\d{2}"))
        stringList.Add(match.Value);
    }
    return stringList;
  }

  public static bool smethod_38(string string_4)
  {
    bool flag = false;
    string_4 = string_4.Replace("@yahoo.com", "");
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[5]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
      "X-Requested-With: XMLHttpRequest",
      "Cookie: AS=v=1&s=jc8Jz1UA",
      "Referrer: https://login.yahoo.com/account/module/create?validateField=yid"
    });
    if (requestHttp.Request("POST", "https://login.yahoo.com/account/module/create?validateField=yid", Data: Encoding.UTF8.GetBytes("browser-fp-data=&specId=yidReg&crumb=&acrumb=jc8Jz1UA&c=&s=&done=https%3A%2F%2Fwww.yahoo.com&googleIdToken=&authCode=&tos0=yahoo_freereg%7Cvn%7Cvi-VN&tos1=yahoo_comms_atos%7Cvn%7Cvi-VN&firstName=&lastName=&yid=" + string_4 + "&password=&shortCountryCode=VN&phone=&mm=&dd=&yyyy=&freeformGender=")).Contains("yid\",\"error"))
      flag = true;
    return flag;
  }

  public static bool smethod_39(string string_4)
  {
    string_4 = string_4.Replace("@yahoo.com", "");
    RequestHTTP requestHttp = new RequestHTTP();
    requestHttp.SetSSL((SecurityProtocolType) 3072);
    requestHttp.SetKeepAlive(true);
    requestHttp.SetDefaultHeaders(new string[2]
    {
      "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
      "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36"
    });
    return !JObject.Parse(requestHttp.Request(Url: ("https://login.microsoftonline.com/common/userrealm/?user=" + string_4 + "&api-version=2.1&stsRequest=rQIIAbPSySgpKSi20tcvyC8qSczRy81MLsovzk8ryc_LycxL1UvOz9XLL0rPTAGxioS4BC6HNYTFGB7zWy90MI6xcUHgKkZlwkboX2BkfMHIeItJ0L8o3TMlvNgtNSW1KLEkMz_vERNvaHFqkX9eTmVIfnZq3iRmvpz89My8-OKitPi0nPxyoADQhILE5JL4kszk7NSSXcwqiSaWqYZpKWm6xpZplromhiZmupYWiWa6FhYmZqaGFqlpFomJF1gEfrAwLmIFurmyae30LeVybvNE3C_Vi-5_e4pVPy_FOcvSIiIgNUPbJyU1KjE0PTcsMdezzCM5PN2oJN8zyN0g0MjZ3bzSuNzW0srwACcjAA2&checkForMicrosoftAccount=true")).ToString())["MicrosoftAccount"].ToString().Equals("1");
  }

  public static bool smethod_40(string string_4)
  {
    try
    {
      string str1 = Regex.Match(string_4, "c_user=(.*?);").Groups[1].Value;
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.87 Safari/537.36",
        "cookie: " + string_4
      });
      string str2 = requestHttp.Request(Url: "https://www.facebook.com/");
      if (str1.Equals("") || !str2.Contains(str1) || !str2.Contains("name=\"fb_dtsg\" value="))
        return false;
      string str3 = Regex.Match(requestHttp.Request(Url: "https://mbasic.facebook.com/settings/email/"), "/privacyx/selector(.*?)\"").Value.Replace("amp;", "").Replace("\"", "");
      string str4 = Regex.Match(requestHttp.Request(Url: ("https://mbasic.facebook.com" + str3 + "&priv_expand=see_all")), "/a/privacy/.px=286958161406148(.*?)\"").Value.Replace("amp;", "").Replace("\"", "");
      if (str4.Equals(""))
        return false;
      requestHttp.Request(Url: ("https://mbasic.facebook.com" + str4));
      return true;
    }
    catch
    {
      return false;
    }
  }

  public static string smethod_41(string string_4)
  {
    string str1 = "";
    if (string_4.Split('|')[0] == "1")
    {
      int int32 = Convert.ToInt32(string_4.Split('|')[1]);
      if (true)
        ;
      string str2;
      switch (int32)
      {
        case 104:
          str2 = "Lỗi phần mềm";
          break;
        case 400:
          str2 = "Tài khoản không tồn tại";
          break;
        case 401:
          str2 = "Changed pass";
          break;
        case 405:
          str2 = GClass35.smethod_0("Checkpoint");
          break;
        case 613:
          str2 = "Giới hạn lấy token";
          break;
        default:
          str2 = "Lỗi hệ thống";
          break;
      }
      if (true)
        ;
      str1 = str2;
    }
    return str1;
  }

  public static string smethod_42(string string_4)
  {
    byte[] hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(string_4));
    StringBuilder stringBuilder = new StringBuilder();
    for (int index = 0; index < hash.Length; ++index)
      stringBuilder.Append(hash[index].ToString("X2"));
    return stringBuilder.ToString();
  }

  public static void smethod_43(string string_4)
  {
    Process process = new Process();
    process.StartInfo.FileName = "rasdial.exe";
    process.StartInfo.Arguments = "\"" + string_4 + "\" /disconnect";
    process.StartInfo.UseShellExecute = false;
    process.StartInfo.RedirectStandardOutput = true;
    process.StartInfo.RedirectStandardError = true;
    process.Start();
    process.WaitForExit();
    Thread.Sleep(1000);
  }

  public static void smethod_44(double double_0)
  {
    Application.DoEvents();
    Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
  }

  public static void smethod_45(string string_4)
  {
    Thread.Sleep(1000);
    Process process = new Process();
    process.StartInfo.FileName = "rasdial.exe";
    process.StartInfo.Arguments = "\"" + string_4 + "\"";
    process.StartInfo.UseShellExecute = false;
    process.StartInfo.RedirectStandardOutput = true;
    process.StartInfo.RedirectStandardError = true;
    process.Start();
    process.WaitForExit();
    Thread.Sleep(1500);
  }

  public static bool smethod_46(int int_2, string string_4, int int_3, string string_5) => true;

  private static string smethod_47(string string_4)
  {
    Process process = new Process();
    process.StartInfo.FileName = "cmd.exe";
    process.StartInfo.Arguments = "/c " + string_4;
    process.StartInfo.RedirectStandardOutput = true;
    process.StartInfo.UseShellExecute = false;
    process.StartInfo.CreateNoWindow = true;
    process.Start();
    string end = process.StandardOutput.ReadToEnd();
    process.WaitForExit();
    return string.IsNullOrEmpty(end) ? "" : end;
  }

  public static void smethod_48()
  {
    foreach (Process process in Process.GetProcessesByName("chromedriver"))
      process.Kill();
  }

  public static Point smethod_49(int int_2, int int_3 = 6)
  {
    Point point = new Point();
    int num1 = 2 * GClass29.int_0 / int_3;
    int num2 = int_3 / 2;
    while (int_2 > 5)
      int_2 -= 6;
    if (int_2 <= num2 - 1)
      point.Y = 0;
    else if (int_2 < int_3)
    {
      point.Y = GClass29.int_1 / 2;
      int_2 -= num2;
    }
    point.X = int_2 * num1;
    return point;
  }

  public static DataTable smethod_50(string string_4, string string_5, int int_2)
  {
    DataTable dataTable = new DataTable();
    try
    {
      // ISSUE: reference to a compiler-generated method
      uint num = Class206.smethod_0(string_4);
      string str;
      if (num <= 2071622424U)
      {
        if (num <= 1605967500U)
        {
          if (num <= 850372319U)
          {
            if (num != 321211332U)
            {
              if (num == 850372319U && string_4 == "backup")
              {
                str = string.Format("(backup like '%{0}%')", (object) string_5);
                goto label_49;
              }
            }
            else if (string_4 == "all")
            {
              str = string.Format("(uid like '%{0}%' OR token like '%{0}%' OR email like '%{0}%' OR phone like '%{0}%' OR name like '%{0}%' OR friends like '%{0}%' OR groups like '%{0}%' OR gender like '%{0}%' OR backup like '%{0}%' OR info like '%{0}%' OR pass like '%{0}%' OR cookie like '%{0}%' OR mailrecovery like '%{0}%' OR passmail like '%{0}%')", (object) string_5);
              goto label_49;
            }
          }
          else if (num != 1556604621U)
          {
            if (num == 1605967500U && string_4 == "group")
            {
              str = string.Format("(groups like '%{0}%')", (object) string_5);
              goto label_49;
            }
          }
          else if (string_4 == "uid")
          {
            str = string.Format("(uid like '%{0}%')", (object) string_5);
            goto label_49;
          }
        }
        else if (num <= 2000032175U)
        {
          if (num != 1841097094U)
          {
            if (num == 2000032175U && string_4 == "phone")
            {
              str = string.Format("(phone like '%{0}%')", (object) string_5);
              goto label_49;
            }
          }
          else if (string_4 == "tinhtrang")
          {
            str = string.Format("(info like '%{0}%')", (object) string_5);
            goto label_49;
          }
        }
        else if (num != 2007449791U)
        {
          if (num == 2071622424U && string_4 == "pass")
          {
            str = string.Format("(pass like '%{0}%')", (object) string_5);
            goto label_49;
          }
        }
        else if (string_4 == "cookie")
        {
          str = string.Format("(cookie like '%{0}%')", (object) string_5);
          goto label_49;
        }
      }
      else if (num <= 3416301453U)
      {
        if (num <= 2369371622U)
        {
          if (num != 2324124615U)
          {
            if (num == 2369371622U && string_4 == "name")
            {
              str = string.Format("(name like '%{0}%')", (object) string_5);
              goto label_49;
            }
          }
          else if (string_4 == "email")
          {
            str = string.Format("(email like '%{0}%')", (object) string_5);
            goto label_49;
          }
        }
        else if (num != 2491017778U)
        {
          if (num == 3416301453U && string_4 == "friend")
          {
            str = string.Format("(friends like '%{0}%')", (object) string_5);
            goto label_49;
          }
        }
        else if (string_4 == "token")
        {
          str = string.Format("(token like '%{0}%')", (object) string_5);
          goto label_49;
        }
      }
      else if (num <= 3979810479U)
      {
        if (num != 3968918830U)
        {
          if (num == 3979810479U && string_4 == "passmail")
          {
            str = string.Format("(passmail like '%{0}%')", (object) string_5);
            goto label_49;
          }
        }
        else if (string_4 == "mail")
        {
          str = string.Format("(mailrecovery like '%{0}%')", (object) string_5);
          goto label_49;
        }
      }
      else if (num != 4025178668U)
      {
        if (num == 4280007968U && string_4 == "gioitinh")
        {
          str = string.Format("(gender like '%{0}%')", (object) string_5);
          goto label_49;
        }
      }
      else if (string_4 == "birthday")
      {
        str = string.Format("(birthday like '%{0}%')", (object) string_5);
        goto label_49;
      }
      str = "(0 = 1)";
label_49:
      dataTable = GClass17.GClass17_0.method_1("SELECT * FROM accounts WHERE idfile = " + int_2.ToString() + " AND " + str);
    }
    catch
    {
    }
    return dataTable;
  }

  private static string smethod_51(string string_4) => string_4 + "minsoftware.tk";

  public static string smethod_52(int int_2 = 15)
  {
    string str = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    Random random = new Random();
    char[] chArray = new char[int_2];
    for (int index = 0; index < int_2 - 2; ++index)
      chArray[index] = str[random.Next(0, str.Length)];
    chArray[13] = '1';
    chArray[14] = 'T';
    return new string(chArray);
  }

  public static bool smethod_53(object object_0, string string_4) => object_0.GetType().GetMethod(string_4) != (MethodInfo) null;

  public static string smethod_54(string string_4) => Encoding.UTF8.GetString(Encoding.Default.GetBytes(string_4));

  public static double smethod_55(string string_4, string string_5)
  {
    double num = 0.0;
    string[] strArray = string_5.Split(' ');
    for (int index = 0; index < strArray.Length; ++index)
    {
      if (string_5 != "" && string_4.Contains(" " + strArray[index] + " "))
        ++num;
    }
    return num / (double) strArray.Length;
  }

  public static string smethod_56(string string_4)
  {
    int int_6 = Class55.smethod_0();
    try
    {
      return Class55.smethod_1(string_4.Split('|')[0], string_4.Split('|')[1], string_4.Split('|')[2], int_6) ? "1|" + int_6.ToString() : "0|" + int_6.ToString();
    }
    catch
    {
      return "0|" + int_6.ToString();
    }
  }

  private static string smethod_57(string string_4)
  {
    byte[] hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(string_4));
    StringBuilder stringBuilder = new StringBuilder();
    for (int index = 0; index < hash.Length; ++index)
      stringBuilder.Append(hash[index].ToString("X"));
    return stringBuilder.ToString();
  }

  public static string smethod_58(string string_4 = "") => GClass29.smethod_57(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber().AddSystemDriveSerialNumber().ToString());

  public static string smethod_59(string string_4 = "")
  {
    if (string_4.Equals(""))
      string_4 = GClass29.smethod_58();
    return GClass29.smethod_60(GClass29.smethod_51(string_4));
  }

  public static string smethod_60(string string_4)
  {
    string str = "";
    foreach (byte num in new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(string_4)))
      str += num.ToString("X2");
    return str.ToLower();
  }

  public static string smethod_61()
  {
    Process process = new Process()
    {
      StartInfo = new ProcessStartInfo()
      {
        WindowStyle = ProcessWindowStyle.Hidden,
        CreateNoWindow = true,
        FileName = "CMD.exe",
        Arguments = "/C wmic csproduct get UUID"
      }
    };
    process.StartInfo.UseShellExecute = false;
    process.StartInfo.RedirectStandardOutput = true;
    process.Start();
    process.WaitForExit();
    return process.StandardOutput.ReadToEnd().Replace("UUID", "").Replace("\n", "").Replace(" ", "").Replace("-", "").Replace("\r", "");
  }

  public static string smethod_62()
  {
    string empty = string.Empty;
    using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass("win32_processor").GetInstances().GetEnumerator())
    {
      if (enumerator.MoveNext())
        empty = enumerator.Current.Properties["processorID"].Value.ToString();
    }
    return empty;
  }

  public static void smethod_63()
  {
    ManagementClass managementClass = new ManagementClass("Win32_OperatingSystem");
    managementClass.Get();
    managementClass.Scope.Options.EnablePrivileges = true;
    ManagementBaseObject methodParameters = managementClass.GetMethodParameters("Win32Shutdown");
    methodParameters["Flags"] = (object) "1";
    methodParameters["Reserved"] = (object) "0";
    foreach (ManagementObject instance in managementClass.GetInstances())
      instance.InvokeMethod("Win32Shutdown", methodParameters, (InvokeMethodOptions) null);
  }

  public static string smethod_64(string string_4) => Encoding.UTF8.GetString(Convert.FromBase64String(string_4));

  public static bool smethod_65(string string_4)
  {
    try
    {
      MailAddress mailAddress = new MailAddress(string_4);
      return true;
    }
    catch (FormatException ex)
    {
      return false;
    }
  }

  public static string smethod_66(string string_4)
  {
    try
    {
      return Regex.Match(string_4, "c_user=(.*?);").Value + Regex.Match(string_4, "xs=(.*?);").Value + Regex.Match(string_4, "fr=(.*?);").Value + Regex.Match(string_4, "datr=(.*?);").Value;
    }
    catch
    {
      return string_4;
    }
  }

  public static void smethod_67(int int_2)
  {
    try
    {
      Class55.smethod_2(int_2);
    }
    catch
    {
    }
  }

  public static List<string> smethod_68(string string_4, string string_5 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36")
  {
    string_4 = GClass29.smethod_66(string_4);
    List<string> stringList = new List<string>();
    try
    {
      RequestHTTP requestHttp = new RequestHTTP();
      requestHttp.SetSSL((SecurityProtocolType) 3072);
      requestHttp.SetKeepAlive(true);
      requestHttp.SetDefaultHeaders(new string[3]
      {
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: " + string_5,
        "cookie: " + string_4
      });
      MatchCollection matchCollection = Regex.Matches(requestHttp.Request(Url: "https://mbasic.facebook.com/groups/?seemore"), "<a href=\"/groups/[0-9]+\\?refid=27");
      for (int i = 0; i < matchCollection.Count; ++i)
      {
        try
        {
          string str = Regex.Match(matchCollection[i].Value, "groups/(.*?)\\?refid=27").Groups[1].Value.ToString();
          if (str != "")
            stringList.Add(str);
        }
        catch
        {
        }
      }
    }
    catch
    {
    }
    return stringList;
  }

  public static string smethod_69(string string_4)
  {
    for (int index1 = 1; index1 < GClass29.string_3.Length; ++index1)
    {
      for (int index2 = 0; index2 < GClass29.string_3[index1].Length; ++index2)
        string_4 = string_4.Replace(GClass29.string_3[index1][index2], GClass29.string_3[0][index1 - 1]);
    }
    return string_4;
  }
}
