// Decompiled with JetBrains decompiler
// Type: Class23
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using AE.Net.Mail;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

internal class Class23
{
  public static void smethod_0(string string_0, string string_1)
  {
    int num = 0;
label_21:
    try
    {
      string host = "outlook.office365.com";
      if (string_0.EndsWith("@hotmail.com") || string_0.EndsWith("@outlook.com"))
        host = "outlook.office365.com";
      else if (string_0.EndsWith("@yandex.com"))
        host = "imap.yandex.com";
      ImapClient imapClient = new ImapClient(host, string_0, string_1, port: 993, secure: true);
      Lazy<MailMessage>[] lazyArray1;
      if (host == "imap.yandex.com")
        lazyArray1 = imapClient.SearchMessages(SearchCondition.Unseen());
      else
        lazyArray1 = imapClient.SearchMessages(SearchCondition.From("security@facebookmail.com").And(SearchCondition.Unseen()));
      Lazy<MailMessage>[] lazyArray2 = lazyArray1;
      if (lazyArray2.Length != 0)
      {
        for (int index = lazyArray2.Length - 1; index >= 0; --index)
        {
          Lazy<MailMessage> lazy = lazyArray2[index];
          imapClient.DeleteMessage(lazy.Value);
        }
      }
      if (imapClient.IsDisposed)
        imapClient.Dispose();
      if (!imapClient.IsConnected)
        return;
      imapClient.Disconnect();
    }
    catch (Exception ex)
    {
      if (!ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
        return;
      ++num;
      if (num < 10)
        goto label_21;
    }
  }

  public static string smethod_1(
    int int_0,
    string string_0,
    string string_1,
    int int_1 = 120,
    string string_2 = "")
  {
    string str = "";
    int num1 = 0;
label_38:
    int tickCount = Environment.TickCount;
    try
    {
      ServicePointManager.SecurityProtocol = (SecurityProtocolType) 4032;
      do
      {
        int num2;
        if (!string_0.Split('@')[1].StartsWith("hotmail."))
          num2 = string_0.Split('@')[1].StartsWith("outlook.") ? 1 : 0;
        else
          num2 = 1;
        int num3;
        ImapClient imapClient;
        if (num2 != 0)
        {
          num3 = 1;
          imapClient = new ImapClient("outlook.office365.com", string_0, string_1, port: 993, secure: true);
          imapClient.SelectMailbox("Inbox");
        }
        else
        {
          num3 = 0;
          if (string_0.Split('@')[1].Contains("gmail.com"))
          {
            imapClient = new ImapClient("imap.gmail.com", string_0, string_1, port: 993, secure: true);
            imapClient.SelectMailbox("Inbox");
          }
          else
          {
            imapClient = new ImapClient("imap.yandex.com", string_0, string_1, port: 993, secure: true);
            imapClient.SelectMailbox("Spam");
          }
        }
        try
        {
          Lazy<MailMessage>[] source;
          if (num3 == 0 || int_0 == 3)
          {
            source = imapClient.SearchMessages(SearchCondition.To(string_0));
          }
          else
          {
            source = imapClient.SearchMessages(SearchCondition.From("security@facebookmail.com").And(SearchCondition.Unseen()));
            if (source == null || source.Length == 0)
              source = imapClient.SearchMessages(SearchCondition.From("registration@facebookmail.com").And(SearchCondition.Unseen()));
          }
          if (source != null && source.Length != 0)
          {
            for (int index = ((IEnumerable<Lazy<MailMessage>>) source).Count<Lazy<MailMessage>>() - 1; index >= 0; --index)
            {
              MailMessage msg = source[index].Value;
              str = Class23.smethod_2(msg.AlternateViews[1].Body.ToString(), int_0, string_2);
              imapClient.DeleteMessage(msg);
              if (str != "")
              {
                if (!imapClient.IsDisposed)
                  imapClient.Dispose();
                if (!imapClient.IsConnected)
                  return str;
                imapClient.Disconnect();
                return str;
              }
            }
          }
        }
        catch (Exception ex)
        {
        }
        if (!imapClient.IsDisposed)
          imapClient.Dispose();
        if (imapClient.IsConnected)
          imapClient.Disconnect();
      }
      while (Environment.TickCount - tickCount < int_1 * 1000);
    }
    catch (Exception ex)
    {
      if (ex.ToString().Contains("The remote certificate is invalid according to the validation procedure") || ex.ToString().Contains("An established connection was aborted by the software in your host machine"))
      {
        ++num1;
        if (num1 < 3)
          goto label_38;
      }
      else if (ex.ToString().ToLower().Contains("blocked"))
        return "block";
      return "not connect";
    }
    return str;
  }

  public static string smethod_2(string string_0, int int_0, string string_1 = "")
  {
    string str1 = "";
    switch (int_0)
    {
      case 0:
        str1 = Regex.Match(string_0, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
        if (str1 == "")
          str1 = Regex.Match(string_0, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
        if (str1 == "")
        {
          str1 = Regex.Match(string_0, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\n").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
          break;
        }
        break;
      case 1:
        str1 = Regex.Match(string_0, "\\d{8}").Value.Trim();
        if (string_1.StartsWith(str1))
        {
          str1 = "";
          break;
        }
        break;
      case 2:
        str1 = Regex.Match(string_0, "c=(\\d+)&").Groups[1].Value;
        break;
      case 3:
        str1 = Regex.Match(string_0, ">\\d+<").Value.Trim().Replace(">", "").Replace("<", "");
        if (str1 == "")
        {
          str1 = Regex.Match(Regex.Match(string_0, "Security code: \\d+").Value, "\\d+").Value;
          break;
        }
        break;
      case 4:
        string str2 = Regex.Match(string_0, "\\?n=(.*?)&").Groups[1].Value;
        string str3 = Regex.Match(string_0, ";id=(.*?)&").Groups[1].Value;
        if (str2 != "" && str3 != "")
        {
          str1 = "https://m.facebook.com/recover/password/?u=" + str3 + "&n=" + str2 + "&fl=default_recover&sih=0&msgr=0";
          break;
        }
        break;
    }
    return str1;
  }

  internal static string smethod_3(
    int int_0,
    string string_0,
    string string_1,
    string string_2 = "",
    int int_1 = 60)
  {
    GClass24 gclass24 = new GClass24("", "", "", 0);
    string_0 = string_0.Substring(0, string_0.LastIndexOf("=") + 1) + string_1;
    int tickCount = Environment.TickCount;
    do
    {
      string str1 = gclass24.method_0(string_0);
      try
      {
        JObject jobject = JObject.Parse("{\"data\":" + str1 + "}");
        for (int key = jobject["data"].Count<JToken>() - 1; key >= 0; --key)
        {
          jobject["data"][(object) key][(object) "created_at"].ToString();
          string input = Class23.smethod_2(jobject["data"][(object) key][(object) "body"].ToString(), int_0, string_2);
          if (input != "")
          {
            string str2 = Regex.Match(input, "c=(\\d+)&").Value;
            if (str2 != "")
              return str2;
          }
        }
      }
      catch
      {
      }
      GClass19.smethod_64(3.0);
    }
    while (Environment.TickCount - tickCount < int_1 * 1000);
    return "";
  }

  internal static string smethod_4(
    int int_0,
    string string_0,
    string string_1,
    string string_2 = "",
    int int_1 = 60)
  {
    GClass24 gclass24 = new GClass24("", "", "", 0);
    string_0 = string_0.Substring(0, string_0.LastIndexOf("=") + 1) + string_1;
    int tickCount = Environment.TickCount;
    do
    {
      string str1 = gclass24.method_0(string_0);
      try
      {
        JObject jobject = JObject.Parse("{\"data\":" + str1 + "}");
        for (int key = jobject["data"].Count<JToken>() - 1; key >= 0; --key)
        {
          jobject["data"][(object) key][(object) "created_at"].ToString();
          string str2 = Regex.Match(jobject["data"][(object) key][(object) "body"].ToString(), ">(\\d+)<").Groups[1].Value;
          if (str2 != "")
            return str2;
        }
      }
      catch
      {
      }
      GClass19.smethod_64(3.0);
    }
    while (Environment.TickCount - tickCount < int_1 * 1000);
    return "";
  }
}
