// Decompiled with JetBrains decompiler
// Type: GClass27
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

public class GClass27
{
  private Random random_0 = new Random();
  public bool bool_0 = false;
  private string string_4 = "";
  public string string_5 = "com.facebook.katana";
  public string string_6 = "com.ss.android.ugc.trill";
  public string string_7 = "com.instagram.android";
  public bool bool_1 = false;
  private System.Drawing.Point? nullable_0 = new System.Drawing.Point?();
  public int int_1 = 0;
  public string string_8 = "";
  public GClass25 gclass25_0;
  private bool bool_2 = false;
  private object object_0 = new object();
  private int int_2 = 0;
  private int int_3 = 10;
  public string string_9 = "";
  private object object_1 = new object();
  private object object_2 = new object();
  private string string_10 = "";

  private string String_0 { get; set; } = "http://127.0.0.1";

  private string String_1 { get; set; } = "4723";

  public int Int32_0 { get; set; } = 360000;

  public string String_2 { get; set; } = "";

  private string String_3 { get; set; } = "";

  public string method_0()
  {
    if (this.String_3 == "")
      this.String_3 = this.CMD("shell getprop ro.build.version.release");
    return this.String_3;
  }

  public string method_1(bool bool_3 = false)
  {
    if (this.string_4 == "")
    {
      this.string_4 = Class76.smethod_4(this.String_2);
      if (this.string_4 == "")
      {
        if (bool_3)
          return "";
        this.method_16();
      }
    }
    return this.string_4;
  }

  public void method_2(string string_11 = "") => this.string_4 = string_11;

  public void method_3(int int_4, string string_11)
  {
    this.int_1 = int_4;
    this.string_8 = string_11;
  }

  public void RemoveProxy()
  {
    this.CMD("shell settings put global http_proxy :0");
    this.CMD("shell settings delete global http_proxy");
    this.CMD("shell settings delete global global_http_proxy_host");
    this.CMD("shell settings delete global global_http_proxy_port");
    this.Cleardata("com.cell47.College_Proxy");
    this.int_1 = 0;
    this.string_8 = "";
  }

  public bool method_5(int int_4 = 0)
  {
    if (string.IsNullOrEmpty(this.string_8))
      return true;
    if (int_4 != 0)
      return this.method_32(this.string_8);
    this.CMD("shell settings put global http_proxy " + this.string_8);
    return true;
  }

  public void method_6(string string_11, string string_12) => this.gclass25_0 = new GClass25(string_11, string_12, 0, 1);

  public string method_7()
  {
    this.bool_2 = false;
    return this.gclass25_0.string_1;
  }

  public void method_8(int int_4 = 60) => new Thread((ThreadStart) (() =>
  {
    lock (this.object_0)
    {
      int tickCount = Environment.TickCount;
      do
      {
        this.bool_2 = this.gclass25_0.method_1() == 1;
      }
      while (!this.bool_2 && Environment.TickCount - tickCount < int_4 * 1000);
    }
  }))
  {
    IsBackground = true
  }.Start();

  public bool method_9(int int_4 = 300)
  {
    lock (this.object_0)
      ;
    int tickCount = Environment.TickCount;
    do
    {
      if (this.bool_2)
      {
        if (this.gclass25_0.method_4())
          return true;
      }
      else
      {
        this.method_8();
        lock (this.object_0)
          ;
        this.SleepSeconds(5.0);
      }
    }
    while (Environment.TickCount - tickCount < int_4 * 1000);
    return false;
  }

  private string method_10(int int_4, string string_11, string string_12 = "")
  {
    try
    {
      string input;
      while (true)
      {
        do
        {
          if (!this.bool_1)
          {
            string str = this.String_0 + ":" + this.String_1 + "/wd/hub";
            string string_0;
            if (string_11.Contains("{this.sessionId}"))
            {
              string newValue = this.method_1();
              if (!(newValue == ""))
                string_0 = str + string_11.Replace("{this.sessionId}", newValue);
              else
                goto label_4;
            }
            else
              string_0 = str + string_11;
            GClass24 gclass24 = new GClass24("", "", "", 0);
            input = int_4 == 0 ? gclass24.method_0(string_0) : gclass24.method_1(string_0, string_12, "application/json");
            if (!this.bool_1)
            {
              if (!input.Contains("cannot be proxied to UiAutomator2 server because the instrumentation process is not running (probably crashed)"))
              {
                this.int_2 = 0;
                if (!input.Contains("Cannot find any free port in range 8200..8299"))
                {
                  if (!input.Contains("cannot_connect") && !input.Contains("A session is either terminated or not started") && !input.Contains("Could not proxy command to the remote server") && !input.Contains("The requested resource could not be found, or a request was received using an HTTP method that is not supported by the mapped resource"))
                  {
                    if (!(Regex.Match(input, "device (.*?) not found").Groups[1].Value != "") && !input.Contains("was not in the list of connected devices") && !input.Contains("Could not find a connected Android device"))
                      goto label_22;
                  }
                  else
                    goto label_15;
                }
                else
                  goto label_13;
              }
              else
                goto label_9;
            }
            else
              goto label_19;
          }
          else
            goto label_20;
        }
        while (this.method_12());
        goto label_18;
label_9:
        if (this.int_2 >= this.int_3)
        {
          this.int_2 = 0;
          Class76.smethod_2();
          Class76.smethod_3();
        }
        ++this.int_2;
        continue;
label_13:
        GClass7.smethod_3();
        GClass7.smethod_4();
        continue;
label_15:
        Class76.smethod_3();
        this.method_17();
      }
label_4:
      return "";
label_18:
      return "disconnect";
label_19:
      return "disconnect";
label_20:
      return "disconnect";
label_22:
      return input;
    }
    catch (Exception ex)
    {
      return "";
    }
  }

  private bool method_11()
  {
    List<string> stringList = GClass7.smethod_0();
    if (stringList.Contains(this.String_2))
      return true;
    if (!this.String_2.StartsWith("127.0.0.1:") && !this.String_2.StartsWith("emulator-"))
      return false;
    if (this.String_2.StartsWith("127.0.0.1:"))
      this.String_2 = string.Format("emulator-{0}", (object) (Convert.ToInt32(this.String_2.Replace("127.0.0.1:", "")) - 1));
    else if (this.String_2.StartsWith("emulator-"))
      this.String_2 = string.Format("127.0.0.1:{0}", (object) (Convert.ToInt32(this.String_2.Replace("emulator-", "")) + 1));
    return stringList.Contains(this.String_2);
  }

  private bool method_12(int int_4 = 60)
  {
    try
    {
      if (this.method_11())
        return true;
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        bool flag;
        if (!(flag = Regex.Match(this.CMD("reconnect"), "device (.*?) not found").Groups[1].Value == "") && (this.String_2.StartsWith("127.0.0.1:") || this.String_2.StartsWith("emulator-")))
        {
          int num = 0;
          if (this.String_2.StartsWith("127.0.0.1:"))
            num = Convert.ToInt32(this.String_2.Replace("127.0.0.1:", ""));
          else if (this.String_2.StartsWith("emulator-"))
            num = Convert.ToInt32(this.String_2.Replace("emulator-", "")) + 1;
          flag = !GClass7.smethod_1(string.Format("adb connect 127.0.0.1:{0}", (object) num)).Contains("cannot connect to");
        }
        if (flag)
        {
          this.SleepSeconds(3.0);
          if (this.method_11())
            return true;
        }
        if (Environment.TickCount - tickCount >= int_4 * 1000)
          break;
      }
      this.bool_1 = true;
      Class54.gclass26_0.method_1(this);
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  private string method_13(string string_11) => this.method_10(0, string_11);

  public string method_14(string string_11, string string_12) => this.method_10(1, string_11, string_12);

  public GClass27(string string_11) => this.String_2 = string_11;

  private string method_15() => this.method_13("/session/{this.sessionId}");

  private bool method_16()
  {
    while (Class76.int_0 >= Class76.int_1)
      GClass19.smethod_64(1.0);
    ++Class76.int_0;
    string string_11_1 = "";
    string string_11_2 = "/session";
    GClass22 gclass22 = new GClass22();
    gclass22.method_6("platformName", (object) "Android");
    gclass22.method_6("platformVersion", (object) this.method_0());
    gclass22.method_6("deviceName", (object) this.String_2);
    gclass22.method_6("udid", (object) this.String_2);
    gclass22.method_6("automationName", (object) "UiAutomator2");
    gclass22.method_6("noReset", (object) true);
    gclass22.method_6("disableWindowAnimation", (object) true);
    gclass22.method_6("gpsEnabled", (object) false);
    gclass22.method_6("skipLogcatCapture", (object) true);
    gclass22.method_6("dontStopAppOnReset", (object) true);
    gclass22.method_6("ignoreHiddenApiPolicyError", (object) true);
    gclass22.method_6("noSign", (object) false);
    gclass22.method_6("newCommandTimeout", (object) this.Int32_0);
    string string_12 = "{ \"desiredCapabilities\":" + gclass22.method_11() + "}";
    string str = this.method_14(string_11_2, string_12);
    try
    {
      string_11_1 = JObject.Parse(str)["sessionId"].ToString();
    }
    catch (Exception ex)
    {
    }
    if (string_11_1 != "")
    {
      this.method_2(string_11_1);
      this.method_19(str);
    }
    else
    {
      lock (Class76.object_1)
      {
        System.IO.File.AppendAllText("device.txt", string_12 + Environment.NewLine);
        System.IO.File.AppendAllText("device.txt", str + Environment.NewLine);
        System.IO.File.AppendAllText("device.txt", "-----------------------------" + Environment.NewLine);
      }
    }
    --Class76.int_0;
    return string_11_1 != "";
  }

  public bool method_17()
  {
    string newValue = this.method_1(true);
    if (newValue == "")
      return false;
    string requestUriString = this.String_0 + ":" + this.String_1 + "/wd/hub" + ("/session/" + newValue).Replace("{this.sessionId}", newValue);
    bool flag = false;
    try
    {
      WebRequest webRequest = WebRequest.Create(requestUriString);
      webRequest.Method = "DELETE";
      webRequest.Headers["Cache-Control"] = "no-cache";
      using (StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
        streamReader.ReadToEnd();
      flag = true;
    }
    catch (Exception ex)
    {
    }
    this.method_2();
    return flag;
  }

  private string method_18(int int_4, List<string> list_0 = null)
  {
    string str = "";
    try
    {
      if (list_0 == null || list_0.Count == 0)
        list_0 = GClass7.smethod_0();
      List<string> stringList = new List<string>();
      int num = int_4 * 2 + 5555;
      stringList.Add("127.0.0.1:" + num.ToString());
      num = int_4 * 2 + 5554;
      stringList.Add("emulator-" + num.ToString());
    }
    catch
    {
    }
    return str;
  }

  public System.Drawing.Point? method_19(string string_11 = "")
  {
    try
    {
      if (!this.nullable_0.HasValue)
      {
        if (string.IsNullOrEmpty(string_11))
          string_11 = this.method_15();
        if (string_11.Contains("deviceScreenSize"))
        {
          string str = JObject.Parse(string_11)["value"][(object) "deviceScreenSize"].ToString();
          this.nullable_0 = new System.Drawing.Point?(new System.Drawing.Point(Convert.ToInt32(str.Split('x')[0]), Convert.ToInt32(str.Split('x')[1])));
        }
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return this.nullable_0;
  }

  public int method_20() => this.method_19().Value.Y;

  public int method_21() => this.method_19().Value.X;

  public string method_22()
  {
    try
    {
      return JObject.Parse(this.method_13("/session/{this.sessionId}/appium/device/current_activity"))["value"].ToString();
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return "";
  }

  private bool method_23(string string_11)
  {
    try
    {
      this.method_168("Open app " + this.string_5 + "...");
      this.method_14("/session/{this.sessionId}/appium/device/activate_app", "{\"bundleId\": \"" + string_11 + "\"}");
      return true;
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  private void method_24()
  {
    this.CMD("reboot recovery");
    for (int index = 0; index < 2; ++index)
    {
      this.CMD("wait-for-recovery");
      if (index == 0)
        this.SleepSeconds(5.0);
    }
  }

  internal void method_25(string string_11)
  {
    this.CMD("shell twrp format data");
    this.CMD("shell twrp wipe data");
    this.CMD("shell twrp wipe cache");
    this.CMD("shell twrp wipe dalvik");
    this.CMD("shell twrp wipe system");
    List<string> list = ((IEnumerable<string>) Directory.GetFiles(string_11)).ToList<string>();
    for (int index = 0; index < list.Count; ++index)
    {
      this.CMD("shell rm -r /sdcard/");
      this.CMD("push \"" + list[index] + "\" /sdcard/" + Path.GetFileName(list[index]), 600);
      this.CMD("shell twrp install /sdcard/" + Path.GetFileName(list[index]), 600);
    }
    this.CMD("reboot");
  }

  private int method_26(string string_11)
  {
    try
    {
      return Convert.ToInt32(JObject.Parse(this.method_14("/session/{this.sessionId}/appium/device/app_state", "{\"bundleId\": \"" + string_11 + "\"}"))["value"].ToString());
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return -1;
  }

  public bool method_27(string string_11)
  {
    try
    {
      this.CMD("shell su -c am start -n " + string_11);
      return true;
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public bool method_28(int int_4 = 1, double double_0 = 0.5)
  {
    try
    {
      this.method_168("Back...");
      string string_11 = "/session/{this.sessionId}/back";
      for (int index = 0; index < int_4; ++index)
      {
        this.method_14(string_11, "");
        this.SleepSeconds(double_0);
      }
      return true;
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public string method_29(int int_4, string string_11, List<string> list_0) => this.method_30(int_4, ref string_11, list_0);

  public string method_30(int int_4, ref string string_11, List<string> list_0)
  {
    int tickCount = Environment.TickCount;
    while (!this.bool_1)
    {
      if (string_11 == "")
        string_11 = this.method_53();
      for (int index = 0; index < list_0.Count; ++index)
      {
        if (this.method_31(0, string_11, list_0[index]))
          return list_0[index];
      }
      if (int_4 != 0 && Environment.TickCount - tickCount <= int_4 * 1000)
      {
        this.SleepSeconds(1.0);
        string_11 = "";
        if (Environment.TickCount - tickCount < int_4 * 1000)
          continue;
      }
      return "";
    }
    return "";
  }

  public bool method_31(int int_4, string string_11, string string_12) => this.method_37(int_4, string_11, string_12).Count > 0;

  internal bool method_32(string string_11)
  {
    if (!this.method_175().Contains("com.cell47.College_Proxy"))
    {
      this.method_177(GClass13.smethod_0() + "\\app\\collegeproxy.apk");
      this.SleepSeconds(3.0);
    }
    this.Cleardata("com.cell47.College_Proxy");
    this.Openapp("com.cell47.College_Proxy");
    int tickCount = Environment.TickCount;
    int num = 120;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11_1 = this.method_29(0, str, new List<string>()
      {
        "//*[@text='STOP PROXY SERVICE']",
        "(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]",
        "//android.widget.Button[@text='START SERVICE']",
        "//*[@text='Please enter a valid IPV4 server address.']",
        "//*[@text='OK']"
      });
      switch (string_11_1)
      {
        case "//android.widget.Button[@text='START SERVICE']":
          if (!this.method_146(str, "Things are good and ready to go"))
          {
            this.method_60(string_11_1, str);
            break;
          }
          this.method_60(string_11_1, str);
          return true;
        case "//*[@text='OK']":
          this.method_60(string_11_1, str);
          break;
        case "(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]":
          this.method_50("(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]", string_11.Split(':')[0]);
          this.method_50("(//*[starts-with(@text,'Proxy Port:')]/parent::*/child::*)[last()]", string_11.Split(':')[1]);
          if (string_11.Split(':').Length > 3)
          {
            this.method_50("(//*[starts-with(@text,'Username:')]/parent::*/child::*)[last()]", string_11.Split(':')[2]);
            this.method_50("(//*[starts-with(@text,'Password:')]/parent::*/child::*)[last()]", string_11.Split(':')[3]);
          }
          this.method_60("//*[@text='START PROXY SERVICE']");
          break;
        case "//*[@text='STOP PROXY SERVICE']":
          this.method_163();
          return true;
        case "//*[@text='Please enter a valid IPV4 server address.']":
          return false;
      }
      this.SleepSeconds(2.0);
      if (Environment.TickCount - tickCount >= num * 1000)
        break;
    }
    return false;
  }

  public bool method_33(int int_4, ref string string_11, string string_12) => this.method_38(int_4, ref string_11, string_12).Count > 0;

  public List<string> method_34(string string_11, string string_12, string string_13 = "bounds")
  {
    List<string> stringList = new List<string>();
    try
    {
      if (string_11 == "")
        string_11 = this.method_53();
      string_11 = string_11.ToLower();
      string_12 = string_12.ToLower();
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(string_11);
      XmlNodeList xmlNodeList = xmlDocument.SelectNodes(string_12);
      for (int i = 0; i < xmlNodeList.Count; ++i)
      {
        try
        {
          stringList.Add(xmlNodeList[i].Attributes[string_13].Value);
        }
        catch
        {
        }
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return stringList;
  }

  public List<string> method_35(int int_4, string string_11)
  {
    List<string> source = new List<string>();
    try
    {
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        if (string_11 == "")
          string_11 = this.method_53();
        string_11 = string_11.ToLower();
        MatchCollection matchCollection = Regex.Matches(string_11, "bounds=\"(.*?)\"");
        for (int i = 0; i < matchCollection.Count; ++i)
          source.Add(matchCollection[i].Groups[1].Value);
        if (source.Count <= 0 && int_4 != 0)
        {
          this.SleepSeconds(1.0);
          string_11 = "";
          if (Environment.TickCount - tickCount >= int_4 * 1000)
            break;
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return source.Distinct<string>().ToList<string>();
  }

  public List<string> method_36(int int_4, string string_11, string string_12)
  {
    List<string> source = new List<string>();
    try
    {
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        if (string_11 == "")
          string_11 = this.method_53();
        string_11 = string_11.ToLower();
        MatchCollection matchCollection = Regex.Matches(string_11, Regex.Replace(string_12.ToLower(), "\\p{Cs}", "").Replace("(", "\\(").Replace(")", "\\)").Replace("[", "\\[").Replace("]", "\\]") + "(.*?)/>");
        if (matchCollection.Count == 0 && string_12.Contains("&"))
          matchCollection = Regex.Matches(string_11, Regex.Replace(string_12.ToLower(), "\\p{Cs}", "").Replace("&", "&amp;").Replace("(", "\\(").Replace(")", "\\)").Replace("[", "\\[").Replace("]", "\\]") + "(.*?)/>");
        for (int i = 0; i < matchCollection.Count; ++i)
          source.Add(Regex.Match(matchCollection[i].Value, "bounds=\"(.*?)\"").Groups[1].Value);
        if (source.Count <= 0 && int_4 != 0)
        {
          this.SleepSeconds(1.0);
          string_11 = "";
          if (Environment.TickCount - tickCount >= int_4 * 1000)
            break;
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return source.Distinct<string>().ToList<string>();
  }

  public List<string> method_37(int int_4, string string_11, string string_12)
  {
    List<string> source = new List<string>();
    try
    {
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        if (string_11 == "")
          string_11 = this.method_53();
        source = this.method_34(string_11, string_12);
        if (source.Count <= 0 && int_4 != 0)
        {
          this.SleepSeconds(1.0);
          string_11 = "";
          if (Environment.TickCount - tickCount >= int_4 * 1000)
            break;
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return source.Distinct<string>().ToList<string>();
  }

  public List<string> method_38(int int_4, ref string string_11, string string_12)
  {
    List<string> source = new List<string>();
    try
    {
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        if (string_11 == "")
          string_11 = this.method_53();
        source = this.method_34(string_11, string_12);
        if (source.Count <= 0 && int_4 != 0 && Environment.TickCount - tickCount <= int_4 * 1000)
        {
          this.SleepSeconds(1.0);
          string_11 = "";
          if (Environment.TickCount - tickCount >= int_4 * 1000)
            break;
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return source.Distinct<string>().ToList<string>();
  }

  internal void method_39()
  {
    this.CMD("shell media volume --show --stream 0 --set 1");
    this.CMD("shell media volume --show --stream 1 --set 0");
    this.CMD("shell media volume --show --stream 3 --set 0");
    this.CMD("shell media volume --show --stream 4 --set 1");
    this.CMD("shell media volume --show --stream 5 --set 0");
    this.CMD("shell cmd media_session volume --show --stream 0 --set 1");
    this.CMD("shell cmd media_session volume --show --stream 1 --set 0");
    this.CMD("shell cmd media_session volume --show --stream 3 --set 0");
    this.CMD("shell cmd media_session volume --show --stream 4 --set 1");
    this.CMD("shell cmd media_session volume --show --stream 5 --set 0");
  }

  public List<string> method_40(int int_4, string string_11, List<string> list_0) => this.method_41(int_4, ref string_11, list_0);

  public List<string> method_41(int int_4, ref string string_11, List<string> list_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        if (string_11 == "")
          string_11 = this.method_53();
        for (int index = 0; index < list_0.Count; ++index)
          stringList.AddRange((IEnumerable<string>) this.method_37(0, string_11, list_0[index]));
        if (stringList.Count <= 0 && int_4 != 0)
        {
          this.SleepSeconds(1.0);
          string_11 = "";
          if (Environment.TickCount - tickCount >= int_4 * 1000)
            break;
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return stringList;
  }

  public bool method_42(int int_4)
  {
    try
    {
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        if (!this.method_146("", "android.widget.ProgressBar", "Row showing that your post is", "Sharing", "Uploading", "Finishing up", "Updating"))
          return true;
        if (Environment.TickCount - tickCount < int_4 * 1000)
          this.SleepSeconds(2.0);
        else
          break;
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return false;
  }

  internal bool method_43()
  {
    if (this.CMD("shell ime set com.android.adbkeyboard/.AdbIME") == "")
    {
      this.CMD("shell am start -a android.settings.INPUT_METHOD_SETTINGS");
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        string str = this.method_53();
        string string_11 = this.method_29(0, str, new List<string>()
        {
          "//*[@text='ADB Keyboard']/parent::*/parent::*/child::*/child::*[@checked='true']",
          "//*[@text='ADB Keyboard']",
          "//android.widget.Button[@text='OK']"
        });
        switch (string_11)
        {
          case "//*[@text='ADB Keyboard']":
          case "//android.widget.Button[@text='OK']":
            this.method_60(string_11, str);
            break;
          case "//*[@text='ADB Keyboard']/parent::*/parent::*/child::*/child::*[@checked='true']":
            this.CMD("shell ime set com.android.adbkeyboard/.AdbIME");
            return true;
        }
        this.SleepSeconds(1.0);
        if (Environment.TickCount - tickCount >= 60000)
          break;
      }
    }
    return false;
  }

  internal void method_44()
  {
    this.CMD("reboot");
    this.CMD("wait-for-device", 120);
    while (!this.CMD("shell getprop sys.boot_completed").Equals("1"))
      GClass19.smethod_64(1.0);
  }

  internal void method_45() => this.CMD("shell reboot -p");

  public bool method_46(string string_11, int int_4 = 0)
  {
    string string_11_1 = this.method_48(string_11, int_4).FirstOrDefault<string>();
    return !string.IsNullOrEmpty(string_11_1) && this.method_47(string_11_1);
  }

  private bool method_47(string string_11)
  {
    try
    {
      return JObject.Parse(this.method_14("/session/{this.sessionId}/element/" + string_11 + "/clear", ""))["status"].ToString() == "0";
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public List<string> method_48(string string_11, int int_4 = 0)
  {
    List<string> stringList = new List<string>();
    int tickCount = Environment.TickCount;
    while (!this.bool_1)
    {
      try
      {
        string string_11_1 = "/session/{this.sessionId}/elements";
        GClass22 gclass22 = new GClass22();
        gclass22.method_6("using", (object) "xpath");
        gclass22.method_6("value", (object) string_11);
        string string_12 = gclass22.method_11();
        foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(this.method_14(string_11_1, string_12))["value"])
          stringList.Add(jtoken[(object) "ELEMENT"].ToString());
        if (stringList.Count <= 0 && int_4 != 0)
          this.SleepSeconds(1.0);
        else
          break;
      }
      catch (Exception ex)
      {
        this.method_82(ex);
      }
      if (Environment.TickCount - tickCount >= int_4 * 1000)
        break;
    }
    return stringList;
  }

  internal void method_49(string string_11)
  {
    this.method_168("Uninstall app " + this.string_5 + "...");
    this.CMD("uninstall \"" + string_11 + "\"", 120);
  }

  public bool method_50(string string_11, string string_12, int int_4 = 0, bool bool_3 = false)
  {
    string_12 = GClass19.smethod_28(string_12);
    this.method_168("Send key " + string_12 + "...");
    string string_11_1 = this.method_48(string_11, int_4).FirstOrDefault<string>();
    if (!string.IsNullOrEmpty(string_11_1))
    {
      this.method_47(string_11_1);
      this.method_57(string_11_1);
      if (GClass19.smethod_111(string_12))
      {
        if (bool_3)
        {
          foreach (char ch in string_12)
            this.CMD("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(ch.ToString())) + "'");
        }
        else
          this.CMD("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_12)) + "'");
        return true;
      }
      try
      {
        string string_11_2 = "/session/{this.sessionId}/element/" + string_11_1 + "/value";
        GClass22 gclass22 = new GClass22();
        gclass22.method_6("text", (object) string_12);
        string string_12_1 = gclass22.method_11();
        return JObject.Parse(this.method_14(string_11_2, string_12_1))["status"].ToString() == "0";
      }
      catch (Exception ex)
      {
        this.method_82(ex);
      }
    }
    return false;
  }

  public bool method_51(string string_11, string string_12, int int_4 = 0)
  {
    this.method_168("Send key " + string_12 + "...");
    string string_11_1 = this.method_48(string_11, int_4).FirstOrDefault<string>();
    if (string.IsNullOrEmpty(string_11_1))
      return false;
    this.method_47(string_11_1);
    this.method_57(string_11_1);
    string_12 = string_12.Replace(" ", "%s").Replace("&", "\\&").Replace("<", "\\<").Replace(">", "\\>").Replace("?", "\\?").Replace(":", "\\:").Replace("{", "\\{").Replace("}", "\\}").Replace("[", "\\[").Replace("]", "\\]").Replace("|", "\\|").Replace("'", "\\'");
    this.CMD("shell input text \"" + string_12 + "\"");
    return true;
  }

  internal void CloseAllApp()
  {
    this.CMD("shell input keyevent 3");
    this.CMD("shell input keyevent 187");
    for (int index = 0; index < 10; ++index)
      this.CMD("shell input touchscreen swipe 700 1550 700 50");
    this.CMD("shell input keyevent 3");
  }

  public string method_53()
  {
    string str = "";
    try
    {
      str = JObject.Parse(this.method_13("/session/{this.sessionId}/source"))["value"].ToString();
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return str;
  }

  public bool method_54(System.Drawing.Point point_0, int int_4 = 1, int int_5 = 100) => this.method_55(point_0.X, point_0.Y, int_4, int_5);

  public bool method_55(int int_4, int int_5, int int_6 = 1, int int_7 = 100)
  {
    try
    {
      string string_11 = "/session/{this.sessionId}/touch/perform";
      string str = "{ \"actions\": [ { \"action\": \"tap\", \"options\": { \"x\": " + int_4.ToString() + ", \"y\": " + int_5.ToString() + " } },";
      for (int index = 1; index < int_6; ++index)
        str = str + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_7.ToString() + " } }, { \"action\": \"tap\", \"options\": { \"x\": " + int_4.ToString() + ", \"y\": " + int_5.ToString() + " } },";
      string string_12 = str + "{ \"action\": \"release\", \"options\": {} } ] }";
      this.method_14(string_11, string_12);
      return true;
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public bool method_56(int int_4, int int_5, int int_6 = 1, int int_7 = 100)
  {
    try
    {
      string str = string.Format("shell \"input tap {0} {1}", (object) int_4, (object) int_5);
      for (int index = 1; index < int_6; ++index)
        str = str + string.Format(" && sleep {0} && ", (object) ((double) int_7 * 1.0 / 1000.0)) + string.Format("input tap {0} {1}", (object) int_4, (object) int_5);
      this.CMD(str + "\"");
      return true;
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  private bool method_57(string string_11, int int_4 = 1, int int_5 = 100)
  {
    string string_11_1 = "/session/{this.sessionId}/touch/perform";
    string str = "{ \"actions\": [ { \"action\": \"tap\", \"options\": { \"element\": \"" + string_11 + "\"} },";
    for (int index = 1; index < int_4; ++index)
      str = str + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_5.ToString() + " } }, { \"action\": \"tap\", \"options\": { \"element\": \"" + string_11 + "\"} },";
    string string_12 = str + "{ \"action\": \"release\", \"options\": {} } ] }";
    this.method_14(string_11_1, string_12);
    return true;
  }

  public bool method_58(string string_11, int int_4 = 0, int int_5 = 1, int int_6 = 100)
  {
    this.method_168("Tap " + string_11 + "...");
    string string_11_1 = this.method_48(string_11, int_4).FirstOrDefault<string>();
    return !string.IsNullOrEmpty(string_11_1) && this.method_57(string_11_1, int_5, int_6);
  }

  internal void method_59()
  {
    if (this.method_161())
      return;
    this.CMD("shell input keyevent 26");
  }

  internal void bật_màn_hình()
  {
    this.CMD("shell input keyevent 3");
    Thread.Sleep(100);
    this.CMD("shell input keyevent 26");
  }

  public bool method_60(string string_11, string string_12 = "", int int_4 = 1, int int_5 = 100)
  {
    this.method_168("Tap " + string_11 + "...");
    return this.method_61(0, string_11, string_12, int_4, int_5);
  }

  public bool method_61(int int_4, string string_11, string string_12, int int_5 = 1, int int_6 = 100)
  {
    this.method_168("Tap " + string_11 + "...");
    string string_0 = this.method_37(int_4, string_12, string_11).FirstOrDefault<string>();
    return !string.IsNullOrEmpty(string_0) && this.method_54(new Class77(string_0).method_1());
  }

  public bool method_62(string string_11, string string_12 = "", int int_4 = 1, int int_5 = 100)
  {
    this.method_168("Tap " + string_11 + "...");
    return this.method_63(0, string_11, string_12, int_4, int_5);
  }

  public bool method_63(int int_4, string string_11, string string_12, int int_5 = 1, int int_6 = 100)
  {
    this.method_168("Tap " + string_11 + "...");
    string string_0 = this.method_37(int_4, string_12, string_11).FirstOrDefault<string>();
    return !string.IsNullOrEmpty(string_0) && this.method_54(new Class77(string_0).method_1());
  }

  public bool method_64(string string_11, int int_4, params string[] string_12) => this.method_60(this.method_30(int_4, ref string_11, ((IEnumerable<string>) string_12).ToList<string>()), string_11);

  public bool method_65(int int_4, string string_11, string string_12, int int_5 = 1, int int_6 = 100)
  {
    this.method_168("Tap " + string_11 + "...");
    string string_11_1 = this.method_36(int_4, string_12, string_11).LastOrDefault<string>();
    return !string.IsNullOrEmpty(string_11_1) && this.method_66(string_11_1, int_5, int_6);
  }

  public bool method_66(string string_11, int int_4 = 1, int int_5 = 100)
  {
    try
    {
      System.Drawing.Point point = this.method_74(string_11);
      return this.method_55(point.X, point.Y, int_4, int_5);
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public bool method_67(string string_11, string string_12, int int_4 = 1, int int_5 = 100)
  {
    try
    {
      string string_11_1 = this.method_37(0, string_12, string_11).FirstOrDefault<string>();
      return !string.IsNullOrEmpty(string_11_1) && this.method_68(string_11_1, int_4, int_5);
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public bool method_68(string string_11, int int_4 = 1, int int_5 = 100)
  {
    try
    {
      System.Drawing.Point point = this.method_74(string_11);
      return this.method_56(point.X, point.Y, int_4, int_5);
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  internal void method_69()
  {
    if (this.method_161())
    {
      this.CMD("shell input keyevent 26");
      this.SleepSeconds(1.0);
    }
    this.CMD("shell input keyevent 82");
  }

  internal bool method_70(string string_11)
  {
    this.method_142(new List<string>() { string_11 });
    this.CMD("shell am start -a android.settings.DISPLAY_SETTINGS");
    this.SleepSeconds(2.0);
    int tickCount = Environment.TickCount;
    while (!this.bool_1)
    {
      string str1 = this.method_53();
      string str2 = this.method_29(0, str1, new List<string>()
      {
        "//*[contains(@text,'Styles & wallpapers')]",
        "//*[@text='Wallpaper']",
        "//*[@text='set wallpaper']",
        "//*[@text='Gallery']",
        "//*[@text='Advanced']",
        "//*[@resource-id='org.codeaurora.gallery:id/gl_root_view']",
        "//*[@text='SET WALLPAPER']"
      });
      switch (str2)
      {
        case "//*[@resource-id='org.codeaurora.gallery:id/gl_root_view']":
          this.method_60("//*[@resource-id='org.codeaurora.gallery:id/gl_root_view']", str1);
          this.method_60("//android.widget.Button[@resource-id='org.codeaurora.gallery:id/gl_root_view']", str2);
          this.method_60("//android.widget.Button[@resource-id='org.codeaurora.gallery:id/gl_root_view']");
          break;
        case "//*[@text='Advanced']":
          this.method_60("//*[@text='Advanced']", str1);
          break;
        case "//*[@text='Gallery']":
          this.method_60("//android.widget.LinearLayout/android.widget.RelativeLayout", str1);
          break;
        case "//*[@text='SET WALLPAPER']":
          this.method_62("//*[@text='SET WALLPAPER']", str1);
          break;
        case "//*[@text='Wallpaper']":
          if (this.method_31(0, str1, "//*[@text='Wallpaper categories']/following-sibling::*"))
          {
            this.method_60("//*[@text='Wallpaper categories']/following-sibling::*", str1);
            break;
          }
          this.method_66(this.method_37(0, str1, str2).LastOrDefault<string>());
          break;
        case "//*[@text='set wallpaper']":
          if (!this.method_31(0, str1, "//*[@text='Home screen and lock screen']"))
          {
            this.method_62(str2, str1);
            break;
          }
          this.method_60("//*[@text='Home screen and lock screen']", str1);
          this.SleepSeconds(2.0);
          this.method_79(GClass27.GEnum10.const_3);
          return true;
        case "//*[contains(@text,'Styles & wallpapers')]":
          if (this.method_31(0, str1, "//*[@text='Allow']"))
          {
            this.method_60("//*[@text='Allow']", str1);
            break;
          }
          if (this.method_31(0, str1, "//*[@text='Allow access']"))
          {
            this.method_62("//*[@text='Allow access']", str1);
            break;
          }
          this.method_66(this.method_37(0, str1, str2).LastOrDefault<string>());
          break;
      }
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= 60000)
        break;
    }
    return false;
  }

  internal void method_71()
  {
    bool flag = this.method_161();
    this.CMD("shell \"input keyevent 26\"");
    if (flag)
      return;
    this.SleepSeconds(1.0);
    this.CMD("shell \"input keyevent 26\"");
  }

  public bool method_72(int int_4, int int_5, int int_6 = 500)
  {
    try
    {
      this.method_14("/session/{this.sessionId}/touch/perform", "{ \"actions\": [ { \"action\": \"press\", \"options\": { \"x\": " + int_4.ToString() + ", \"y\": " + int_5.ToString() + " } }, { \"action\": \"wait\", \"options\": { \"ms\": " + int_6.ToString() + " } }, { \"action\": \"release\", \"options\": {} } ] }");
      return true;
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public bool method_73(int int_4, int int_5, int int_6, int int_7, int int_8 = 500)
  {
    try
    {
      this.method_14("/session/{this.sessionId}/touch/perform", "{ \"actions\": [ " + "{ \"action\": \"press\", \"options\": { \"x\": " + int_4.ToString() + ", \"y\": " + int_5.ToString() + " } }," + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_8.ToString() + " } }," + "{ \"action\": \"moveTo\", \"options\": { \"x\": " + int_6.ToString() + ", \"y\": " + int_7.ToString() + " } }," + "{ \"action\": \"release\", \"options\": {} } ] }");
      return true;
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public System.Drawing.Point method_74(string string_11)
  {
    try
    {
      string[] strArray = string_11.Split('[', ',', ']');
      return new System.Drawing.Point(this.random_0.Next(Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[4])), this.random_0.Next(Convert.ToInt32(strArray[2]), Convert.ToInt32(strArray[5])));
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return new System.Drawing.Point();
  }

  public bool method_75(string string_11, string string_12, int int_4 = 500)
  {
    System.Drawing.Point point1 = this.method_74(string_11);
    int x1 = point1.X;
    int y1 = point1.Y;
    System.Drawing.Point point2 = this.method_74(string_12);
    int x2 = point2.X;
    int y2 = point2.Y;
    return this.method_73(x1, y1, x2, y2, int_4);
  }

  public bool method_76(int int_4 = 1, int int_5 = 1, int int_6 = 0)
  {
    int num1 = this.method_20();
    int num2 = this.method_21();
    string str1 = string.Format("[{0},{1}][{2},{3}]", (object) (num2 / 4), (object) (num1 / 4), (object) (num2 / 4 * 3), (object) (num1 / 4 + 50));
    string str2 = string.Format("[{0},{1}][{2},{3}]", (object) (num2 / 4), (object) (num1 / 4 * 3), (object) (num2 / 4 * 3), (object) (num1 / 4 * 3 + 50));
    if (int_6 == 0)
      int_6 = this.random_0.Next(2000000, 2560000) / num1;
    for (int index = 0; index < int_5; ++index)
    {
      if (int_4 == 1)
        this.method_75(str2, str1, int_6);
      else
        this.method_75(str1, str2, int_6);
    }
    return true;
  }

  public bool method_77(string string_11, string string_12, int int_4 = 500, int int_5 = 1, int int_6 = 1)
  {
    string str = this.method_53();
    for (int index = 0; index < int_6; ++index)
    {
      if (int_5 == 1)
        this.method_75(string_11, string_12, int_4);
      else
        this.method_75(string_12, string_11, int_4);
    }
    this.SleepSeconds(1.0);
    return this.method_53() == str;
  }

  public bool method_78(int int_4 = 1, int int_5 = 1, int int_6 = 0)
  {
    this.method_168("Scroll...");
    int num1 = this.method_20();
    int num2 = this.method_21();
    string string_12 = string.Format("[{0},{1}][{2},{3}]", (object) (num2 / 4), (object) (num1 / 4), (object) (num2 / 4 * 3), (object) (num1 / 4 + 50));
    string string_11 = string.Format("[{0},{1}][{2},{3}]", (object) (num2 / 4), (object) (num1 / 4 * 3), (object) (num2 / 4 * 3), (object) (num1 / 4 * 3 + 50));
    if (int_4 == 2)
    {
      string_11 = string.Format("[{0},{1}][{2},{3}]", (object) (num2 / 4), (object) (num1 / 4 * 2), (object) (num2 / 4 * 2), (object) (num1 / 4 * 2 + 50));
      int_4 = 1;
    }
    if (int_6 == 0)
      int_6 = this.random_0.Next(2000000, 2560000) / num1;
    return this.method_77(string_11, string_12, int_6, int_4, int_5);
  }

  public bool method_79(GClass27.GEnum10 genum10_0)
  {
    try
    {
      string string_11 = "/session/{this.sessionId}/appium/device/press_keycode";
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("keycode", (object) (int) genum10_0);
      string string_12 = gclass22.method_11();
      this.method_14(string_11, string_12);
      return true;
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
  }

  public void method_80(double double_0, double double_1)
  {
    this.method_168("Delay...");
    Thread.Sleep(this.random_0.Next(Convert.ToInt32(double_0 * 1000.0), Convert.ToInt32(double_1 * 1000.0 + 1.0)));
    Application.DoEvents();
  }

  public void SleepSeconds(double double_0)
  {
    Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
    Application.DoEvents();
  }

  private bool method_82(Exception exception_0) => false;

  internal bool method_83()
  {
    if (!this.method_91(true))
      return false;
    this.CMD("shell monkey -p ru.andr7e.deviceinfohw -c android.intent.category.LAUNCHER 1");
    return true;
  }

  public void method_84()
  {
    this.CMD("shell pm grant " + this.string_5 + " android.permission.READ_CONTACTS");
    this.CMD("shell pm grant " + this.string_5 + " android.permission.READ_EXTERNAL_STORAGE");
    this.CMD("shell pm grant " + this.string_5 + " android.permission.WRITE_EXTERNAL_STORAGE");
  }

  public int Openapp(string string_11, int int_4 = 10)
  {
    this.method_168("Open app " + this.string_5 + "...");
    int num = 0;
    int tickCount = Environment.TickCount;
    while (!this.bool_1)
    {
      ++num;
      switch (this.method_26(string_11))
      {
        case 0:
          return 0;
        case 4:
          return num == 1 ? 2 : 1;
        default:
          this.method_84();
          this.method_23(string_11);
          this.CMD("shell content insert --uri content://settings/system --bind name:s:accelerometer_rotation --bind value:i:0");
          this.SleepSeconds(1.0);
          if (Environment.TickCount - tickCount < int_4 * 1000)
            continue;
          goto label_8;
      }
    }
label_8:
    return 0;
  }

  public bool method_86(string string_11, double double_0 = 10.0)
  {
    try
    {
      this.method_168("Close app " + this.string_5 + "...");
      this.CMD("shell am force-stop " + string_11);
    }
    catch (Exception ex)
    {
      return this.method_82(ex);
    }
    return false;
  }

  public int method_87(int int_4, int int_5) => this.random_0.Next(int_4, int_5 + 1);

  private string method_88(int int_4 = 0)
  {
    this.method_89("Get device name fake...");
    int tickCount = Environment.TickCount;
    do
    {
      string xml = this.CMD("shell su -c \"cat /data/data/com.minsoftware.maxchanger/shared_prefs/Device.xml");
      if (xml != "")
      {
        try
        {
          XmlDocument xmlDocument = new XmlDocument();
          xmlDocument.LoadXml(xml);
          XmlNode xmlNode1 = xmlDocument.SelectSingleNode("//*[@name='fingerprint']");
          XmlNode xmlNode2 = xmlDocument.SelectSingleNode("//*[@name='time_check']");
          if (xmlNode1 != null && xmlNode1.InnerText != "" && xmlNode2 != null && xmlNode2.InnerText != "")
          {
            this.string_9 = xmlNode1.InnerText + xmlNode2.InnerText;
            return this.string_9;
          }
        }
        catch (Exception ex)
        {
        }
      }
      if (int_4 != 0)
        this.SleepSeconds(2.0);
      else
        break;
    }
    while (Environment.TickCount - tickCount < int_4 * 1000);
    return "";
  }

  private void method_89(string string_11)
  {
    if (!GClass33.smethod_0("configDebug").method_4("ckbChangeInfoDevice"))
      return;
    lock (this.object_1)
    {
      try
      {
        using (StreamWriter streamWriter = new StreamWriter("logdevice\\" + this.String_2 + ".txt", true))
          streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ": " + string_11);
      }
      catch (Exception ex)
      {
      }
    }
  }

  private void method_90()
  {
    this.method_89("open app maxchange...");
    this.CMD("shell monkey -p com.minsoftware.maxchanger -c android.intent.category.LAUNCHER 1");
  }

  private bool method_91(bool bool_3 = false)
  {
    int tickCount = Environment.TickCount;
    do
    {
      this.CMD("shell am force-stop com.minsoftware.maxchanger");
      this.CMD("shell am force-stop ru.andr7e.deviceinfohw");
      this.CMD("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
      this.CMD("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
      this.SleepSeconds(4.0);
      string str1 = this.method_88();
      this.method_89("Get device name fake old => " + str1);
      bool flag1 = false;
      if (bool_3)
      {
        flag1 = true;
        this.method_90();
      }
      int num1 = 1;
      if (num1 > 1 && !flag1)
        this.method_90();
      string string_11 = "shell am broadcast -a com.minsoftware.maxchanger.CHANGE -n com.minsoftware.maxchanger/.AdbCaller";
      if (Class54.string_7 != "Random")
        string_11 = "shell am broadcast -a com.minsoftware.maxchanger.CHANGE --es \"brand\" \"" + ((IEnumerable<string>) Class54.string_7.Split('|')).ToList<string>().OrderBy<string, Guid>((Func<string, Guid>) (string_0 => Guid.NewGuid())).Last<string>() + "\" -n com.minsoftware.maxchanger/.AdbCaller";
      this.method_89(string.Format("{0}. Run cmd: adb {1}...", (object) num1, (object) string_11));
      bool flag2 = this.CMD(string_11, 120).Contains("Broadcast completed");
      this.method_89(string.Format("{0}. Run cmd => ", (object) num1) + flag2.ToString());
      if (flag2)
      {
        this.SleepSeconds(3.0);
        string str2 = this.method_88(10);
        this.method_89(string.Format("{0}. Get device name fake new => ", (object) num1) + str2);
        if (str2 != "" && str2 != str1)
          return true;
      }
      int num2 = num1 + 1;
    }
    while (Environment.TickCount - tickCount < 300000);
    return false;
  }

  internal bool method_92(string string_11)
  {
    this.method_168("Change info...");
    bool flag = false;
    if (this.method_93(string_11))
      flag = this.method_88(10) != "";
    if (!flag && (flag = this.method_91()))
      this.method_94(string_11);
    return flag;
  }

  internal bool method_93(string string_11)
  {
    if (string_11 != "")
    {
      this.Cleardata("com.minsoftware.maxchanger");
      this.CMD("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
      this.CMD("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
      string path = GClass13.smethod_0() + "\\device\\" + string_11 + ".tar.gz";
      if (System.IO.File.Exists(path))
      {
        for (int index = 0; index < 10; ++index)
        {
          string str1 = this.CMD("push \"" + path + "\" /sdcard");
          str1 = this.CMD("shell su -c cp /sdcard/" + string_11 + ".tar.gz /data/data/com.minsoftware.maxchanger/" + string_11 + ".tar.gz");
          str1 = this.CMD("shell su -c tar -xzvf /data/data/com.minsoftware.maxchanger/" + string_11 + ".tar.gz");
          string str2 = this.CMD("shell su -c \"ls -l /data/data | grep com.minsoftware.maxchanger | awk '{print $3\\\":\\\"$4}'\"");
          bool flag = str2 != "";
          str1 = this.CMD("shell su -c chown -R " + str2 + " /data/data/com.minsoftware.maxchanger");
          if (flag)
            return true;
          this.SleepSeconds(2.0);
        }
      }
    }
    return false;
  }

  internal bool method_94(string string_11)
  {
    if (string_11 != "")
    {
      string str = GClass13.smethod_0() + "\\device\\" + string_11 + ".tar.gz";
      if (System.IO.File.Exists(str))
        GClass19.smethod_98(str);
      this.method_86("com.minsoftware.maxchanger");
      for (int index = 0; index < 10 && !this.bool_1; ++index)
      {
        this.CMD("shell su -c tar -czvf /data/data/com.minsoftware.maxchanger/device.tar.gz /data/data/com.minsoftware.maxchanger/shared_prefs/*");
        this.CMD("shell su -c cp /data/data/com.minsoftware.maxchanger/device.tar.gz /sdcard/device.tar.gz");
        this.CMD("pull /sdcard/device.tar.gz \"" + str + "\"");
        this.CMD("shell su -c rm -rf /data/data/com.minsoftware.maxchanger/*.tar.gz");
        this.CMD("shell su -c rm -rf /sdcard/*.tar.gz");
        if (System.IO.File.Exists(str))
          return true;
        this.SleepSeconds(3.0);
      }
    }
    return false;
  }

  internal bool method_95(string string_11)
  {
    this.method_168("Restore data Fb...");
    this.Cleardata(this.string_5);
    if (string.IsNullOrEmpty(string_11))
      return false;
    string path = GClass13.smethod_0() + "\\profile\\" + string_11 + ".tar.gz";
    if (System.IO.File.Exists(path))
    {
      for (int index = 0; index < 10; ++index)
      {
        string str1 = this.CMD("push \"" + path + "\" /sdcard");
        str1 = this.CMD("shell su -c cp /sdcard/" + string_11 + ".tar.gz /data/data/" + this.string_5 + "/" + string_11 + ".tar.gz");
        str1 = this.CMD("shell su -c tar -xpf /data/data/" + this.string_5 + "/" + string_11 + ".tar.gz");
        string str2 = this.CMD("shell su -c \"ls -l /data/data | grep " + this.string_5 + " | awk '{print $3\\\":\\\"$4}'\"");
        bool flag = str2 != "";
        str1 = this.CMD("shell su -c chown -R " + str2 + " /data/data/" + this.string_5);
        if (flag)
          return true;
        this.SleepSeconds(2.0);
      }
    }
    return false;
  }

  internal bool method_96(string string_11)
  {
    if (string_11 != "")
    {
      this.method_168("Backup data Fb...");
      string str = GClass13.smethod_0() + "\\profile\\" + string_11 + ".tar.gz";
      if (System.IO.File.Exists(str))
        GClass19.smethod_98(str);
      for (int index = 0; index < 10 && !this.bool_1; ++index)
      {
        this.CMD("shell su -c tar -czvpf /data/data/" + this.string_5 + "/backup.tar.gz /data/data/" + this.string_5 + "/databases /data/data/" + this.string_5 + "/app_light_prefs /data/data/" + this.string_5 + "/shared_prefs /data/data/" + this.string_5 + "/files/mobileconfig");
        this.CMD("shell su -c cp /data/data/" + this.string_5 + "/backup.tar.gz /sdcard/backup.tar.gz");
        this.CMD("pull /sdcard/backup.tar.gz \"" + str + "\"");
        this.CMD("shell su -c rm -rf /data/data/" + this.string_5 + "/*.tar.gz");
        this.CMD("shell su -c rm -rf /sdcard/*.tar.gz");
        if (System.IO.File.Exists(str))
          return true;
        this.SleepSeconds(3.0);
      }
    }
    return false;
  }

  public string CMD(string string_11, int int_4 = 10)
  {
    string str1;
    while (true)
    {
      if (!this.bool_1)
      {
        int num1 = 0;
        int num2 = 3;
        str1 = "";
        try
        {
          this.String_2 = this.String_2.Replace("recovery", "").Trim();
          string str2 = "adb -s " + this.String_2 + " " + string_11;
          Process process = new Process();
          process.StartInfo.FileName = "cmd.exe";
          process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\" + str2;
          process.StartInfo.Verb = "runas";
          process.StartInfo.CreateNoWindow = true;
          process.StartInfo.UseShellExecute = false;
          process.StartInfo.RedirectStandardError = true;
          process.StartInfo.RedirectStandardOutput = true;
          process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
          process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
          string string_12 = "";
          process.OutputDataReceived += (DataReceivedEventHandler) ((sender, e) =>
          {
            if (string.IsNullOrEmpty(e.Data))
              return;
            string_12 = string_12 + e.Data + "\n";
          });
          string string_13 = "";
          process.ErrorDataReceived += (DataReceivedEventHandler) ((sender, e) =>
          {
            if (string.IsNullOrEmpty(e.Data))
              return;
            string_13 = string_13 + e.Data + "\n";
          });
          process.Start();
          process.BeginOutputReadLine();
          process.BeginErrorReadLine();
          bool flag = !process.WaitForExit(int_4 < 0 ? -1 : int_4 * 1000);
          process.Close();
          if (flag)
          {
            if (num1 > 0 && num1 % num2 == 0)
              GClass7.smethod_3();
            int num3 = num1 + 1;
          }
          else
          {
            if (string_13 != "")
            {
              if (!string_13.Contains("daemon not running") || string_13.Contains("daemon started successfully"))
              {
                if (Regex.Match(string_13, "device (.*?) not found").Groups[1].Value != "" || string_13.Contains("device offline"))
                {
                  if (!this.method_12())
                    return "disconnect";
                  continue;
                }
                lock (Class76.object_1)
                {
                  System.IO.File.AppendAllText("device.txt", "Run ADB error:" + Environment.NewLine);
                  System.IO.File.AppendAllText("device.txt", string_13 + Environment.NewLine);
                  System.IO.File.AppendAllText("device.txt", "-----------------------------" + Environment.NewLine);
                }
              }
              else
                continue;
            }
            str1 = string_12.Trim();
            goto label_20;
          }
        }
        catch
        {
          goto label_20;
        }
      }
      else
        break;
    }
    return "disconnect";
label_20:
    return str1;
  }

  public string CMD_Recovery(string string_11, int int_4 = 10)
  {
    string str1;
    while (true)
    {
      int num1 = 0;
      int num2 = 3;
      str1 = "";
      try
      {
        this.String_2 = this.String_2.Replace("recovery", "").Trim();
        string str2 = "adb -s " + this.String_2 + " " + string_11;
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\" + str2;
        process.StartInfo.Verb = "runas";
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
        process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
        string string_12 = "";
        process.OutputDataReceived += (DataReceivedEventHandler) ((sender, e) =>
        {
          if (string.IsNullOrEmpty(e.Data))
            return;
          string_12 = string_12 + e.Data + "\n";
        });
        string string_13 = "";
        process.ErrorDataReceived += (DataReceivedEventHandler) ((sender, e) =>
        {
          if (string.IsNullOrEmpty(e.Data))
            return;
          string_13 = string_13 + e.Data + "\n";
        });
        process.Start();
        process.BeginOutputReadLine();
        process.BeginErrorReadLine();
        bool flag = !process.WaitForExit(int_4 < 0 ? -1 : int_4 * 1000);
        process.Close();
        if (flag)
        {
          if (num1 > 0 && num1 % num2 == 0)
            GClass7.smethod_3();
          int num3 = num1 + 1;
        }
        else
        {
          if (string_13 != "")
          {
            if (!string_13.Contains("daemon not running") || string_13.Contains("daemon started successfully"))
            {
              if (Regex.Match(string_13, "device (.*?) not found").Groups[1].Value != "" || string_13.Contains("device offline"))
              {
                if (!this.method_12())
                  return "disconnect";
                continue;
              }
              lock (Class76.object_1)
              {
                System.IO.File.AppendAllText("device.txt", "Run ADB error:" + Environment.NewLine);
                System.IO.File.AppendAllText("device.txt", string_13 + Environment.NewLine);
                System.IO.File.AppendAllText("device.txt", "-----------------------------" + Environment.NewLine);
              }
            }
            else
              continue;
          }
          str1 = string_12.Trim();
          break;
        }
      }
      catch
      {
        break;
      }
    }
    return str1;
  }

  internal void Cleardata(string string_11)
  {
    this.method_168("Clear data " + string_11 + "...");
    this.CMD("shell pm clear " + string_11);
  }

  internal int method_99(
    string string_11,
    string string_12,
    string string_13,
    string string_14,
    int int_4 = 0,
    int int_5 = 0,
    int int_6 = 300)
  {
    int tickCount = Environment.TickCount;
    if (int_5 != 2)
      this.method_95(string_11);
    this.Openapp(this.string_5);
    int num1 = 0;
    int num2 = 2;
    int num3 = 0;
    int num4 = 1;
    int num5 = 0;
    int num6 = 1;
    int num7 = 0;
    int num8 = 1;
    int num9 = 0;
    int num10 = int_4 != 15 ? -1 : 0;
    int num11 = 0;
    int num12 = 3;
    int num13 = 0;
    int num14 = 1;
    this.method_168("Login Fb " + string_11 + "...");
    this.SleepSeconds(15.0);
    int num15 = 1;
    while (!this.bool_1)
    {
      int num16 = num15++;
      if (num16 == 45)
      {
        this.CMD("shell am force-stop com.facebook.katana");
        this.SleepSeconds(2.0);
        this.Openapp(this.string_5);
        this.SleepSeconds(15.0);
      }
      if (num16 == 60)
        return 14;
      string str = this.method_53();
      string string_11_1 = this.method_29(0, str, new List<string>()
      {
        "//android.widget.ProgressBar",
        "//*[@text='NONE OF THE ABOVE']",
        "//*[@text='Session Expired']",
        "//android.widget.Button[@content-desc='Menu']",
        "//android.widget.EditText[@content-desc='Username']",
        "//android.widget.EditText[@text='Password']",
        "//android.widget.TextView[@text=\"Can't Find Account\"]",
        "//android.widget.TextView[@text='Incorrect Password']",
        "//android.widget.TextView[@text='Invalid username or password']",
        "//android.widget.TextView[@text='You Entered an Older Password']",
        "//android.widget.TextView[@text='Login Code Required']",
        "//android.widget.EditText[@text='login code']",
        "//android.widget.TextView[@text='Authentication Error']",
        "//*[@text='save your login info']",
        "//*[@content-desc='skip' or @text='skip']",
        "//*[@content-desc='deny' or @text='deny']",
        "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]",
        "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]",
        "//android.view.ViewGroup[@content-desc=\"Allow\"]",
        "//com.android.packageinstaller:id/do_not_ask_checkbox",
        "//android.widget.Button[@text=\"NEVER\"]",
        "//android.widget.TextView[@text=\"Find your account\"]",
        "//android.widget.Button[@text='FIND ACCOUNT']",
        "//*[@text ='LOG IN' or @content-desc='Log In']",
        "//android.widget.TextView[@text='Find Friends']",
        "//*[@text='Enter the code from your email']",
        "//*[@text='Enter the code from your SMS']",
        "//*[@text='Confirm by phone number']",
        "//android.widget.Button[@text='Confirm']",
        "//*[@content-desc='Send login code']",
        "//android.widget.Button[@text='TRY AGAIN']",
        "//android.widget.EditText[@text='Enter code']",
        "//*[@text='No thanks']",
        "//android.view.ViewGroup[@content-desc='Use login code instead']",
        "//*[@content-desc='I ACCEPT']",
        "//*[@content-desc='Allow all cookies']",
        "//*[@text=\"You can't log in right now\"]",
        "//*[@text=\"You Can't Use This Feature Right Now\"]",
        "//*[@text='An unexpected error occurred. Please try logging in again.']",
        "//*[@text='Facebook will be back soon']",
        "//*[@text='Login Failed']",
        "(//android.widget.EditText)[7]",
        "//*[@text='Connection lost']",
        "//*[@text='Trouble Loading']",
        "//*[@content-desc='Yes, continue']",
        "//*[@text='Enter password to log in']",
        "//android.view.ViewGroup[@content-desc='•']",
        "//*[@text='Take photo']",
        "//*[@text='Not now' or @content-desc='Not now']",
        "//android.widget.Button[@text='GET STARTED']",
        "//android.widget.Button[@content-desc='Log into another account']",
        "//*[@content-desc='Next']",
        "//android.widget.EditText[@resource-id=\"com.facebook.katana:id/(name removed)']"
      });
      string s = string_11_1;
      // ISSUE: reference to a compiler-generated method
      uint num17 = Class206.smethod_0(s);
      if (num17 <= 1514243556U)
      {
        if (num17 <= 498126038U)
        {
          if (num17 <= 199939915U)
          {
            if (num17 <= 51955880U)
            {
              if (num17 != 14426572U)
              {
                if (num17 != 38614762U)
                {
                  if (num17 == 51955880U && s == "//*[@text='Not now' or @content-desc='Not now']")
                    goto label_190;
                  else
                    goto label_155;
                }
                else if (s == "//android.view.ViewGroup[@content-desc=\"Allow\"]")
                  goto label_190;
                else
                  goto label_155;
              }
              else if (s == "//*[@content-desc='deny' or @text='deny']")
              {
                this.method_60(string_11_1, str);
                goto label_189;
              }
              else
                goto label_155;
            }
            else if (num17 != 62961010U)
            {
              if (num17 != 181913694U)
              {
                if (num17 == 199939915U && s == "//android.widget.EditText[@text='login code']")
                {
                  if (string_14.Trim() == "")
                    return 3;
                  this.method_50("//android.widget.EditText", GClass19.smethod_85(string_14));
                  this.SleepSeconds(1.0);
                  this.method_79(GClass27.GEnum10.const_66);
                  goto label_189;
                }
                else
                  goto label_155;
              }
              else if (!(s == "//*[@text='Enter the code from your email']"))
                goto label_155;
              else
                goto label_188;
            }
            else if (!(s == "//android.widget.Button[@text='Confirm']"))
              goto label_155;
            else
              goto label_190;
          }
          else if (num17 <= 355810260U)
          {
            if (num17 != 288814156U)
            {
              if (num17 != 300361078U)
              {
                if (num17 == 355810260U && s == "//android.widget.Button[@content-desc='Log into another account']")
                  goto label_190;
                else
                  goto label_155;
              }
              else if (s == "//*[@content-desc='Allow all cookies']")
                goto label_190;
              else
                goto label_155;
            }
            else if (s == "//*[@text='NONE OF THE ABOVE']")
              goto label_190;
            else
              goto label_155;
          }
          else
          {
            if (num17 <= 440181498U)
            {
              if (num17 != 385932458U)
              {
                if (num17 == 440181498U && s == "//*[@text=\"You Can't Use This Feature Right Now\"]")
                  goto label_152;
              }
              else if (s == "//android.widget.EditText[@text='Enter code']")
                goto label_194;
            }
            else if (num17 != 454760892U)
            {
              if (num17 == 498126038U && s == "//android.widget.TextView[@text='You Entered an Older Password']")
                goto label_191;
            }
            else if (s == "//android.widget.Button[@text=\"NEVER\"]")
              goto label_190;
            goto label_155;
          }
        }
        else if (num17 <= 1080039791U)
        {
          if (num17 <= 728177876U)
          {
            if (num17 != 532719482U)
            {
              if (num17 != 601041107U)
              {
                if (num17 != 728177876U || !(s == "//com.android.packageinstaller:id/do_not_ask_checkbox"))
                  goto label_155;
                else
                  goto label_190;
              }
              else if (s == "//android.widget.Button[@content-desc='Menu']")
              {
                this.method_60("//android.widget.TextView", str);
                goto label_189;
              }
              else
                goto label_155;
            }
            else if (s == "//android.widget.ProgressBar")
            {
              ++num9;
              if (num9 % 5 == 0)
              {
                if (this.method_100(str))
                  return 1;
                this.method_60("//*[@content-desc='skip' or @text='skip']", str);
                goto label_189;
              }
              else
                goto label_189;
            }
            else
              goto label_155;
          }
          else if (num17 != 827023039U)
          {
            switch (num17)
            {
              case 1029426508:
                if (s == "//*[@text='Session Expired']")
                {
                  if (num11 >= num12)
                  {
                    this.Cleardata(this.string_5);
                    this.Openapp(this.string_5);
                    num11 = 0;
                    goto label_189;
                  }
                  else
                  {
                    ++num11;
                    this.method_60("//android.widget.Button[@text='OK']", str);
                    goto label_189;
                  }
                }
                else
                  goto label_155;
              case 1080039791:
                if (s == "//android.widget.Button[@text='TRY AGAIN']")
                {
                  if (num3 >= num4)
                    return 5;
                  this.method_60(string_11_1, str);
                  this.SleepSeconds(1.0);
                  ++num3;
                  goto label_189;
                }
                else
                  goto label_155;
              default:
                goto label_155;
            }
          }
          else if (!(s == "//*[@text='Connection lost']"))
            goto label_155;
          else
            goto label_145;
        }
        else if (num17 <= 1236015078U)
        {
          if (num17 != 1094531760U)
          {
            if (num17 != 1156007901U)
            {
              if (num17 == 1236015078U && s == "//android.widget.TextView[@text='Authentication Error']")
              {
                ++num1;
                if (num1 >= num2)
                  return 6;
                this.method_60("//android.widget.Button[@text ='OK']", str);
                goto label_189;
              }
              else
                goto label_155;
            }
            else if (!(s == "//*[@content-desc='Yes, continue']"))
              goto label_155;
            else
              goto label_190;
          }
          else if (!(s == "//*[@text='save your login info']"))
            goto label_155;
          else
            goto label_193;
        }
        else if (num17 <= 1378667548U)
        {
          if (num17 != 1290144582U)
          {
            if (num17 == 1378667548U && s == "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]")
              goto label_190;
            else
              goto label_155;
          }
          else if (s == "//*[@text ='LOG IN' or @content-desc='Log In']")
            goto label_190;
          else
            goto label_155;
        }
        else
        {
          if (num17 != 1451300114U)
          {
            if (num17 == 1514243556U && s == "//*[@text=\"You can't log in right now\"]")
              goto label_152;
          }
          else if (s == "//android.widget.Button[@text='FIND ACCOUNT']")
            goto label_142;
          goto label_155;
        }
      }
      else
      {
        if (num17 <= 2526580307U)
        {
          if (num17 <= 1878701109U)
          {
            if (num17 <= 1734832791U)
            {
              if (num17 != 1580217180U)
              {
                if (num17 != 1684149593U)
                {
                  if (num17 != 1734832791U || !(s == "//*[@content-desc='Send login code']"))
                    goto label_155;
                  else
                    goto label_194;
                }
                else if (!(s == "//android.view.ViewGroup[@content-desc='•']"))
                  goto label_155;
              }
              else if (!(s == "//android.widget.TextView[@text='Incorrect Password']"))
                goto label_155;
              else
                goto label_191;
            }
            else if (num17 != 1761617051U)
            {
              if (num17 != 1792698548U)
              {
                if (num17 != 1878701109U || !(s == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]"))
                  goto label_155;
                else
                  goto label_145;
              }
              else if (!(s == "//*[@content-desc='Next']"))
                goto label_155;
              else
                goto label_190;
            }
            else if (s == "//android.widget.EditText[@content-desc='Username']")
            {
              this.method_50(string_11_1, string_12);
              this.SleepSeconds(1.0);
              this.method_50("//android.widget.EditText[@text='Password']", string_13);
              this.SleepSeconds(1.0);
              this.method_60("//*[@content-desc='Log In']");
              goto label_189;
            }
            else
              goto label_155;
          }
          else if (num17 <= 2283011030U)
          {
            if (num17 != 1997336986U)
            {
              if (num17 != 2146469799U)
              {
                if (num17 != 2283011030U || !(s == "//*[@text='Enter password to log in']"))
                  goto label_155;
                else
                  goto label_190;
              }
              else if (!(s == "//*[@text='Enter the code from your SMS']"))
                goto label_155;
              else
                goto label_188;
            }
            else if (s == "//android.widget.TextView[@text='Find Friends']")
            {
              this.method_60("//android.widget.Button[@text='Get started']");
              goto label_189;
            }
            else
              goto label_155;
          }
          else if (num17 <= 2492217505U)
          {
            if (num17 != 2329336095U)
            {
              if (num17 == 2492217505U && s == "//android.widget.TextView[@text=\"Can't Find Account\"]")
                return 4;
              goto label_155;
            }
            else if (!(s == "//*[@text='An unexpected error occurred. Please try logging in again.']"))
              goto label_155;
            else
              goto label_152;
          }
          else if (num17 != 2507397295U)
          {
            if (num17 != 2526580307U || !(s == "//android.widget.TextView[@text='Login Code Required']"))
              goto label_155;
            else
              goto label_193;
          }
          else if (s == "//android.widget.Button[@text='GET STARTED']")
          {
            if (!this.method_146(str, "To log into your Facebook account, you need to first confirm your identity"))
              return 2;
            this.method_60(string_11_1, str);
            goto label_189;
          }
          else
            goto label_155;
        }
        else if (num17 <= 3496844666U)
        {
          if (num17 <= 2928020320U)
          {
            if (num17 != 2684704644U)
            {
              if (num17 != 2698810085U)
              {
                if (num17 == 2928020320U && s == "//android.widget.EditText[@text='Password']")
                {
                  this.method_50("//android.widget.EditText[@text='Password']", string_13);
                  this.SleepSeconds(1.0);
                  this.method_60("//android.widget.Button[@text ='LOG IN']", str);
                  goto label_189;
                }
                else
                  goto label_155;
              }
              else if (!(s == "//*[@text='No thanks']"))
                goto label_155;
              else
                goto label_190;
            }
            else if (!(s == "//android.view.ViewGroup[@content-desc='Use login code instead']"))
              goto label_155;
            else
              goto label_190;
          }
          else if (num17 != 2934012532U)
          {
            if (num17 != 3186143151U)
            {
              if (num17 != 3496844666U || !(s == "//*[@text='Trouble Loading']"))
                goto label_155;
              else
                goto label_145;
            }
            else if (!(s == "//android.widget.TextView[@text='Invalid username or password']"))
              goto label_155;
            else
              goto label_191;
          }
          else if (!(s == "//*[@text='Take photo']"))
            goto label_155;
        }
        else if (num17 <= 3855779225U)
        {
          if (num17 != 3528901103U)
          {
            if (num17 != 3606322765U)
            {
              if (num17 == 3855779225U && s == "//*[@text='Login Failed']")
              {
                if (num3 >= num4)
                  return 0;
                this.method_60("//android.widget.Button[@text='OK']", str);
                this.SleepSeconds(1.0);
                ++num3;
                goto label_189;
              }
              else
                goto label_155;
            }
            else if (!(s == "//android.widget.TextView[@text=\"Find your account\"]"))
              goto label_155;
            else
              goto label_142;
          }
          else if (!(s == "//*[@text='Confirm by phone number']"))
            goto label_155;
          else
            goto label_188;
        }
        else if (num17 <= 3945336632U)
        {
          if (num17 != 3919975960U)
          {
            if (num17 != 3945336632U || !(s == "//*[@text='Facebook will be back soon']"))
              goto label_155;
            else
              goto label_152;
          }
          else if (!(s == "//*[@content-desc='I ACCEPT']"))
            goto label_155;
          else
            goto label_190;
        }
        else if (num17 != 4002761936U)
        {
          if (num17 != 4158470539U || !(s == "(//android.widget.EditText)[7]"))
            goto label_155;
          else
            goto label_191;
        }
        else if (!(s == "//*[@content-desc='skip' or @text='skip']"))
          goto label_155;
        else
          goto label_190;
        this.method_86(this.string_5);
        this.Openapp(this.string_5);
        goto label_189;
      }
label_142:
      if (num3 >= num4)
        return 4;
      this.method_60("//android.widget.ImageView[@content-desc=\"Back\"]", str);
      this.SleepSeconds(1.0);
      ++num3;
      goto label_189;
label_145:
      if (num5 >= num6)
      {
        if (num10 != 0 || !this.method_160())
          return 7;
        num10 = 1;
        this.Openapp(this.string_5);
      }
      ++num5;
      if (string_11_1 == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
      {
        this.method_60("//android.widget.Button[@text='OK']", str);
        goto label_189;
      }
      else
      {
        this.method_60("//*[@text='Tap to retry']", str);
        goto label_189;
      }
label_152:
      if (num3 >= num4)
        return 12;
      this.method_60("//*[@text='OK']", str);
      this.SleepSeconds(1.0);
      ++num3;
      goto label_189;
label_155:
      if (!this.method_22().Contains("FacebookSplashScreenActivity"))
      {
        if (this.method_146(str, "Create new account"))
        {
          if (this.method_78())
            return 0;
        }
        else if (this.method_146(str, "You have attempted to share a private intimate image"))
          this.method_60("//android.widget.Button[@resource-id='checkpointSubmitButton-actual-button']", str);
        else if (this.method_31(0, str, "//android.widget.ImageView[@content-desc='Unlock']"))
        {
          this.method_69();
          this.Openapp(this.string_5);
        }
        else if (str.Contains("com.android.systemui"))
        {
          this.method_28();
          this.Openapp(this.string_5);
        }
        else if (this.Openapp(this.string_5) != 1)
        {
          if (this.method_146(str, "Something went wrong.Please try again"))
            return 0;
          if (this.method_146(str, "You’re Temporarily Blocked", "It looks like you were misusing this feature by going too fast"))
            return 11;
          if (this.method_146(str, "Facebook isn't responding", "Facebook keeps stopping"))
          {
            if (num7 < num8)
            {
              if (!this.method_95(string_11))
                num7 = num8 - 1;
            }
            else if (num7 < num8 + 1)
            {
              this.Cleardata(this.string_5);
            }
            else
            {
              this.method_49(this.string_5);
              this.method_177(GClass13.smethod_0() + "\\app\\facebook.apk");
              this.method_17();
              this.method_44();
              this.method_69();
              this.method_95(string_11);
            }
            ++num7;
            this.Openapp(this.string_5);
            this.SleepSeconds(2.0);
          }
          else if (this.method_101(str))
          {
            if (num13 >= num14)
              return 13;
            ++num13;
            this.method_60("//*[@text='Close']", str);
          }
          else
          {
            if (this.method_103(str))
              return 2;
            if (!this.method_104(str) && this.method_100(str))
              return 1;
          }
        }
        goto label_189;
      }
      else
        goto label_189;
label_188:
      return 8;
label_189:
      this.SleepSeconds(2.0);
      if (Environment.TickCount - tickCount >= int_6 * 1000)
        return 0;
      continue;
label_190:
      this.method_60(string_11_1, str);
      goto label_189;
label_191:
      return 5;
label_193:
      this.method_60("//*[@text='OK']", str);
      goto label_189;
label_194:
      return 2;
    }
    return -2;
  }

  public bool method_100(string string_11 = "")
  {
    if (string_11 == "")
      string_11 = this.method_53();
    return this.method_146(string_11, "News Feed, Tab", "Notifications, Tab", "Menu, Tab", "Make a post on Facebook", "\"Notifications");
  }

  public bool method_101(string string_11 = "")
  {
    if (string_11 == "")
      string_11 = this.method_53();
    return this.method_146(string_11, "of your comments go against our standards on spam", "This comment goes against our Community Standards on spam", "Standards on spam");
  }

  public bool method_102(string string_11 = "")
  {
    if (string_11 == "")
      string_11 = this.method_53();
    return this.method_146(string_11, "Turn on data or check your Wi-Fi settings", "Please check your internet connection", "Connection lost", "Trouble Loading");
  }

  public bool method_103(string string_11 = "")
  {
    if (string_11 == "")
      string_11 = this.method_53();
    if (this.method_150(string_11).Count == 0 && this.method_31(0, string_11, "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup[3]"))
    {
      this.method_60("//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup[1]", string_11);
      this.SleepSeconds(2.0);
      this.method_42(30);
      if (this.method_146("", "my account been locked") || this.method_127("dataimage\\956") || this.method_127("dataimage\\282"))
        return true;
      this.method_28();
    }
    if (this.method_127("dataimage\\956") || this.method_127("dataimage\\282"))
      return true;
    int num1;
    if (this.method_150(string_11).Count == 1)
      num1 = this.method_146(string_11, "\"Get started", "\"Learn more\"") ? 1 : 0;
    else
      num1 = 0;
    if (num1 != 0)
      return true;
    int num2;
    if (this.method_146(string_11, "Confirm Your Identity"))
      num2 = !this.method_146(string_11, "Contact info") ? 1 : 0;
    else
      num2 = 0;
    if (num2 != 0)
      return true;
    return this.method_146(string_11, "Record a video of yourself", "To make sure you're a real person, we need you to record a video selfie. We'll ask you to move your head during the recording to help us capture your face at different angles.", "We use this video to help us check that this account belongs to you. We'll delete the video once we've done this, and it will never appear on your profile.", "Request a review", "Download your information", "Your account has been disabled", "Go to Community Standards", "We need more information", "Disagree with decision", "\"Record video", "Type the text", "a few steps to confirm your account on Facebook", "Help us confirm it's you", "checkpointSubmitButton-actual-button", "checkpoint_title", "Confirm your account", "Get a code by email", "Get a code on your phone", "your account has been locked", "Send login code");
  }

  public bool method_104(string string_11 = "")
  {
    this.method_168("Check popup...");
    int num1 = 0;
    int num2 = 1;
    string str;
    while (true)
    {
      do
      {
        if (string_11 == "")
          string_11 = this.method_53();
        List<string> stringList = this.method_150(string_11.ToLower());
        if (stringList.Count == 2 && stringList.Contains("profile picture") && stringList.Contains("photo"))
        {
          this.method_76(-1);
          this.SleepSeconds(1.0);
          string_11 = this.method_53();
        }
        if (this.method_31(0, string_11, "//android.widget.Button[@text='Continue']"))
        {
          Class77 class77 = new Class77(this.method_37(0, string_11, "//android.widget.Button[@text='Continue']/parent::*[1]").First<string>());
          if (class77.int_2 - class77.int_0 > 800)
          {
            this.method_76(-1);
            this.SleepSeconds(1.0);
            string_11 = this.method_53();
          }
        }
        string string_0 = this.method_37(0, string_11, "//*[@content-desc='Close']").FirstOrDefault<string>();
        if (string.IsNullOrEmpty(string_0) || new Class77(string_0).int_1 <= 2300)
        {
          str = this.method_29(0, string_11, new List<string>()
          {
            "//*[@text='Tap to view story']",
            "//*[@content-desc='Close' or @text='CLOSE']",
            "//*[@content-desc='Dismiss' or @text='Dismiss']",
            "//*[@text='New! Post in this group without sharing your name.']",
            "//*[@content-desc='deny' or @text='deny']",
            "//*[@text='No thanks']",
            "//*[@content-desc='I ACCEPT']",
            "//*[@content-desc='Allow all cookies']",
            "//*[@text='Try again']",
            "//*[@content-desc='Unplug charger' or @text='Unplug charger']"
          });
          if (!(str != ""))
          {
            if (this.method_146(string_11, "Review Your Data Settings"))
            {
              this.method_60("//*[@content-desc='Get Started']", string_11);
              string_11 = "";
            }
            else if (this.method_31(0, string_11, "//*[@content-desc='Accept and Continue']"))
            {
              this.method_60("//*[@content-desc='Accept and Continue']", string_11);
              string_11 = "";
            }
          }
          else
            goto label_10;
        }
        else
          goto label_36;
      }
      while (string_11 == "");
      goto label_31;
label_10:
      if (!(str == "//*[@content-desc='Close' or @text='CLOSE']") || !this.method_31(0, string_11, "//android.widget.ScrollView"))
      {
        switch (str)
        {
          case "//*[@text='Try again']":
            if (num1 < num2)
            {
              ++num1;
              this.method_60(str, string_11);
              this.SleepSeconds(2.0);
              continue;
            }
            goto label_14;
          case "//*[@content-desc='Unplug charger' or @text='Unplug charger']":
            goto label_15;
          case "//*[@text='Tap to view story']":
            goto label_16;
          default:
            goto label_17;
        }
      }
      else
        goto label_18;
label_31:
      switch (this.method_150(string_11).Distinct<string>().Count<string>())
      {
        case 0:
          goto label_34;
        case 1:
          if (!this.method_78(-1))
          {
            string_11 = this.method_53();
            continue;
          }
          goto label_38;
        default:
          goto label_38;
      }
    }
label_14:
    this.method_28();
    goto label_25;
label_15:
    this.method_60("//*[@content-desc='OK' or @text='OK']", string_11);
    goto label_25;
label_16:
    return false;
label_17:
    this.method_60(str, string_11);
    goto label_25;
label_18:
    Class77 class77_1 = new Class77(this.method_37(0, string_11, "//android.widget.ScrollView").First<string>());
    if (class77_1.int_0 != 0)
      this.method_73((class77_1.int_0 + class77_1.int_2) / 2, class77_1.int_1, (class77_1.int_0 + class77_1.int_2) / 2, class77_1.int_3 < this.method_19().Value.Y ? class77_1.int_3 : class77_1.int_3 - 10);
    else if (new Class77(this.method_37(0, string_11, str).First<string>()).int_0 == 0)
      this.method_28();
    else
      this.method_60(str, string_11);
label_25:
    this.method_80(2.0, 3.0);
    return true;
label_34:
    if (string_11 != "" && !this.method_22().Contains("pagerecommendations"))
    {
      this.method_28();
      return true;
    }
    goto label_38;
label_36:
    return false;
label_38:
    return false;
  }

  public string method_105(string string_11, int int_4 = 10) => this.CMD("shell am start -n " + this.string_5 + "/.IntentUriHandler \"" + string_11 + "\"", int_4);

  public int method_106(string string_11, int int_4 = 10)
  {
    this.method_168("Open gr " + string_11 + "...");
    this.method_105("fb://group/" + string_11);
    this.SleepSeconds(2.0);
    int_4 -= 2;
    return !(this.method_29(int_4, "", new List<string>()
    {
      "//android.view.ViewGroup[starts-with(@content-desc,\"Cover photo of group\")]",
      "//android.widget.Button[@content-desc=\"Member Tools\"]",
      "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]"
    }) == "") ? 1 : 0;
  }

  public void method_107()
  {
    this.method_168("Open Timeline...");
    this.method_105("fb://dbl_login_activity", 3);
    for (int index = 0; index < 5 && !this.bool_1; ++index)
    {
      string string_11_1 = "";
      string string_11_2 = this.method_30(3, ref string_11_1, new List<string>()
      {
        "//android.view.ViewGroup[@content-desc='Add more to your post']",
        "//android.widget.TextView[@text='Create post']",
        "//android.widget.Button[@content-desc='Discard post']"
      });
      int num;
      switch (string_11_2)
      {
        case "":
          return;
        case "//android.view.ViewGroup[@content-desc='Add more to your post']":
          num = 1;
          break;
        default:
          num = string_11_2 == "//android.widget.TextView[@text='Create post']" ? 1 : 0;
          break;
      }
      if (num != 0)
        this.method_60("//android.widget.ImageView[@content-desc='Back']", string_11_1);
      else
        this.method_60(string_11_2, string_11_1);
    }
  }

  public bool method_108(string string_11 = "", string string_12 = "people")
  {
    this.method_107();
    bool flag;
    if (!(flag = this.method_61(5, "//android.widget.Button[contains(@content-desc, \"Search\")]", "")))
    {
      this.method_105("fb://search");
      flag = true;
    }
    if (flag && string_11 != "" && this.method_50("//android.widget.EditText", string_11, 5))
    {
      this.method_80(1.0, 1.5);
      this.method_79(GClass27.GEnum10.const_66);
      this.method_80(1.5, 2.5);
      this.method_61(10, "//android.view.ViewGroup[@content-desc=\"" + string_12 + " search results\"]", "");
    }
    return flag;
  }

  public bool method_109()
  {
    if (!this.method_31(0, "", "//*[starts-with(@content-desc,'Friends, tab')]"))
      this.method_107();
    if (this.method_61(5, "//*[starts-with(@content-desc,'Friends, tab')]", ""))
    {
      string string_11 = "";
      switch (this.method_30(5, ref string_11, new List<string>()
      {
        "//*[@content-desc='Suggestions']",
        "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]",
        "//*[@content-desc='Requests']"
      }))
      {
        case "//*[@content-desc='Suggestions']":
          return this.method_61(0, "//*[@content-desc='Suggestions']", string_11);
        case "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]":
          return true;
        case "//*[@content-desc='Requests']":
          if (this.method_61(0, "//*[@content-desc='Requests']", string_11))
            return this.method_61(5, "//*[@content-desc='See friend suggestions']", "");
          break;
      }
    }
    return false;
  }

  public bool method_110()
  {
    if (!this.method_31(0, "", "//*[starts-with(@content-desc,'Friends, tab')]"))
      this.method_107();
    if (!this.method_61(5, "//*[starts-with(@content-desc,'Friends, tab')]", ""))
      return false;
    return this.method_64("", 10, "//*[@content-desc='Your Friends']", "//*[@content-desc='All friends']");
  }

  public bool method_111()
  {
    this.method_168("Open Notify...");
    int tickCount = Environment.TickCount;
    while (true)
    {
      if (Environment.TickCount - tickCount < 30000 && !this.bool_1)
      {
        string str = this.method_53();
        if (!(this.method_29(0, str, new List<string>()
        {
          "//android.widget.TextView[@text=\"No notifications\"]",
          "//*[@text='Notifications']"
        }) != ""))
        {
          string string_11 = this.method_29(0, str, new List<string>()
          {
            "//android.view.View[contains(@content-desc,'Notifications, tab')]"
          });
          if (string_11 == "")
            this.method_107();
          else
            this.method_60(string_11, str);
          this.SleepSeconds(2.0);
        }
        else
          goto label_8;
      }
      else
        break;
    }
    return false;
label_8:
    return true;
  }

  public bool method_112()
  {
    this.method_168("Open Page...");
    this.method_107();
    int tickCount = Environment.TickCount;
    do
    {
      string str1 = this.method_53();
      string str2 = this.method_29(0, str1, new List<string>()
      {
        "//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/child::*",
        "//*[starts-with(@content-desc,'Menu, tab')]",
        "//android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/child::*",
        "//android.widget.ProgressBar"
      });
      switch (str2)
      {
        case "//*[starts-with(@content-desc,'Menu, tab')]":
          this.method_60(str2, str1);
          break;
        case "//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/child::*":
          List<Class77> source1 = Class77.smethod_1(str1, str2);
          if (source1.Count > 0)
          {
            this.method_66(source1.First<Class77>().method_0());
            return true;
          }
          break;
        case "//android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/child::*":
          List<Class77> source2 = Class77.smethod_1(str1, str2);
          if (source2.Count > 0)
          {
            this.method_66(source2.Last<Class77>().method_0());
            break;
          }
          break;
      }
      this.SleepSeconds(2.0);
    }
    while (Environment.TickCount - tickCount < 300000);
    return false;
  }

  public bool method_113(string string_11 = "1|2|4|5")
  {
    this.method_168("Reaction...");
    List<string> list_0 = new List<string>()
    {
      "Like",
      "Love",
      "Care",
      "Haha",
      "Wow",
      "Sad",
      "Angry"
    };
    string str1 = "";
    if (string_11 == "")
      string_11 = "1|2|4|5";
    List<string> list = ((IEnumerable<string>) string_11.Split('|')).ToList<string>();
    if (list.Count > 0)
    {
      string str2 = list.smethod_10();
      str1 = list_0[Convert.ToInt32(str2) - 1];
    }
    if (string.IsNullOrEmpty(str1))
      str1 = list_0.smethod_10();
    return this.method_58("//*[contains(@content-desc, \"" + str1 + "\")]");
  }

  public string method_114()
  {
    string input1 = "";
    string str1 = "";
    try
    {
      for (int index = 0; index < 2; ++index)
      {
        if (!this.bool_1)
        {
          string str2;
          if (index == 0)
            str2 = this.CMD("shell su -c cat data/data/" + this.string_5 + "/app_light_prefs/" + this.string_5 + "/authentication");
          else
            str2 = this.CMD("shell cat data/data/" + this.string_5 + "/app_light_prefs/" + this.string_5 + "/authentication");
          string input2 = str2;
          if (!(input2 == ""))
          {
            try
            {
              input1 = Regex.Match(input2, "EAAAAU\\S+").Value;
              string oldValue = Regex.Match(input1, "\u0005(.*?)$").Value;
              input1 = input1.Replace(oldValue, "");
            }
            catch
            {
            }
            JObject jobject = JObject.Parse("{\"data\": [" + Regex.Match(input2, "\\[(.*?)\\]").Groups[1].Value + "]}");
            for (int key = 0; key < jobject["data"].Count<JToken>(); ++key)
              str1 = str1 + jobject["data"][(object) key][(object) "name"].ToString() + "=" + jobject["data"][(object) key][(object) "value"].ToString() + ";";
            if (input1 != "")
              break;
          }
        }
        else
          break;
      }
    }
    catch
    {
    }
    return input1 + "|" + str1;
  }

  public string method_115()
  {
    string str1 = "";
    try
    {
      string str2 = this.method_116();
      if (!(str2 == ""))
      {
        for (int index = 0; index < 2 && !this.bool_1; ++index)
        {
          string str3;
          if (index == 0)
            str3 = this.CMD("shell cat data/data/" + this.string_5 + "/app_light_prefs/" + this.string_5 + "/logged_in_" + str2);
          else
            str3 = this.CMD("shell su -c cat data/data/" + this.string_5 + "/app_light_prefs/" + this.string_5 + "/logged_in_" + str2);
          string input1 = str3;
          if (!(input1 == ""))
          {
            string input2 = Regex.Replace(input1, "[\0-\u001F]+", " ");
            string str4 = Regex.Match(input2, " name(.*?)is_pushable").Groups[1].Value.Trim();
            string lower = Regex.Match(input2, "gender (.*?)\\s").Groups[1].Value.Trim().ToLower();
            string str5 = Regex.Match(input2, "phone_full_number\":\"(.*?)\"").Groups[1].Value.Trim();
            string str6 = Regex.Match(input2, "emails (.*?) uid").Groups[1].Value.Trim();
            string str7 = Regex.Match(input2, "pic_square(.*?)(http.*?)\\s").Groups[2].Value.Trim();
            str1 = str2 + "|" + str4 + "|" + lower + "|" + str5 + "|" + str6 + "|" + str7;
          }
        }
      }
    }
    catch
    {
    }
    return str1;
  }

  public string method_116()
  {
    string str = "";
    try
    {
      str = Regex.Match(this.method_114().Split('|')[1] + ";", "c_user=(.*?);").Groups[1].Value;
    }
    catch
    {
    }
    return str;
  }

  public bool method_117(double double_0 = 0.0, params string[] string_11)
  {
    try
    {
      List<string> list = ((IEnumerable<string>) ((IEnumerable<string>) string_11).ToArray<string>()).ToList<string>();
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        if (this.method_29(0, "", list) == "")
          return true;
        if (double_0 != 0.0)
        {
          this.SleepSeconds(1.0);
          if ((double) (Environment.TickCount - tickCount) >= double_0 * 1000.0)
            break;
        }
        else
          break;
      }
    }
    catch
    {
    }
    return false;
  }

  public Rect method_118(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.95)
  {
    try
    {
      using (Mat mat1 = bitmap_0.ToMat())
      {
        using (Mat mat2 = bitmap_1.ToMat())
        {
          using (Mat image = mat1.Clone())
          {
            using (Mat templ = mat2.Clone())
            {
              using (Mat mat3 = new Mat(mat1.Rows - mat2.Rows + 1, mat1.Cols - mat2.Cols + 1, MatType.CV_32FC1))
              {
                Cv2.MatchTemplate((InputArray) image, (InputArray) templ, (OutputArray) mat3, TemplateMatchModes.CCoeffNormed);
                Cv2.Threshold((InputArray) mat3, (OutputArray) mat3, double_0, 1.0, ThresholdTypes.Tozero);
                double maxVal;
                OpenCvSharp.Point maxLoc;
                Cv2.MinMaxLoc((InputArray) mat3, out double _, out maxVal, out OpenCvSharp.Point _, out maxLoc);
                if (maxVal >= double_0)
                  return new Rect(maxLoc.X, maxLoc.Y, mat2.Width, mat2.Height);
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
    return Rect.Empty;
  }

  public Rect[] method_119(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.95)
  {
    List<Rect> source = new List<Rect>();
    try
    {
      using (Mat mat1 = bitmap_0.ToMat())
      {
        using (Mat mat2 = bitmap_1.ToMat())
        {
          using (Mat image = mat1.Clone())
          {
            using (Mat templ = mat2.Clone())
            {
              using (Mat mat3 = new Mat(mat1.Rows - mat2.Rows + 1, mat1.Cols - mat2.Cols + 1, MatType.CV_32FC1))
              {
                Cv2.MatchTemplate((InputArray) image, (InputArray) templ, (OutputArray) mat3, TemplateMatchModes.CCoeffNormed);
                Cv2.Threshold((InputArray) mat3, (OutputArray) mat3, double_0, 1.0, ThresholdTypes.Tozero);
                while (true)
                {
                  double maxVal;
                  OpenCvSharp.Point maxLoc;
                  Cv2.MinMaxLoc((InputArray) mat3, out double _, out maxVal, out OpenCvSharp.Point _, out maxLoc);
                  if (maxVal >= double_0)
                  {
                    Rect rect = new Rect(new OpenCvSharp.Point(maxLoc.X, maxLoc.Y), new OpenCvSharp.Size(mat2.Width, mat2.Height));
                    source.Add(rect);
                    Cv2.FloodFill((InputOutputArray) mat3, maxLoc, new Scalar(0.0));
                  }
                  else
                    break;
                }
              }
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
    return source.OrderBy<Rect, int>((Func<Rect, int>) (rect_0 => rect_0.Y)).ThenBy<Rect, int>((Func<Rect, int>) (rect_0 => rect_0.X)).ToArray<Rect>();
  }

  public string method_120(string string_11, Bitmap bitmap_0 = null, int int_4 = 0)
  {
    try
    {
      List<Bitmap> bitmapList = new List<Bitmap>();
      foreach (FileSystemInfo file in new DirectoryInfo(string_11).GetFiles())
      {
        Bitmap bitmap = (Bitmap) Image.FromFile(file.FullName);
        bitmapList.Add(bitmap);
      }
      int tickCount = Environment.TickCount;
      while (true)
      {
        if (bitmap_0 == null)
          bitmap_0 = this.method_130();
        foreach (Bitmap bitmap_1 in bitmapList)
        {
          Rect rect = this.method_118(bitmap_0, bitmap_1);
          if (rect != Rect.Empty)
            return string.Format("[{0},{1}][{2},{3}]", (object) rect.Left, (object) rect.Top, (object) rect.Right, (object) rect.Bottom);
        }
        if (Environment.TickCount - tickCount < int_4 * 1000)
        {
          this.SleepSeconds(1.0);
          bitmap_0 = this.method_130();
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
    }
    return "";
  }

  public string method_121(Bitmap bitmap_0, Bitmap bitmap_1 = null, int int_4 = 0)
  {
    try
    {
      int tickCount = Environment.TickCount;
      Rect rect;
      while (true)
      {
        if (bitmap_1 == null)
          bitmap_1 = this.method_130();
        rect = this.method_118(bitmap_1, bitmap_0);
        if (!(rect != Rect.Empty))
        {
          if (Environment.TickCount - tickCount < int_4 * 1000)
          {
            this.SleepSeconds(1.0);
            bitmap_1 = this.method_130();
          }
          else
            goto label_9;
        }
        else
          break;
      }
      return string.Format("[{0},{1}][{2},{3}]", (object) rect.Left, (object) rect.Top, (object) rect.Right, (object) rect.Bottom);
    }
    catch (Exception ex)
    {
    }
label_9:
    return "";
  }

  public List<string> method_122(string string_11, Bitmap bitmap_0 = null, int int_4 = 0)
  {
    List<string> stringList = new List<string>();
    try
    {
      List<Bitmap> bitmapList = new List<Bitmap>();
      foreach (FileSystemInfo file in new DirectoryInfo(string_11).GetFiles())
      {
        Bitmap bitmap = (Bitmap) Image.FromFile(file.FullName);
        bitmapList.Add(bitmap);
      }
      int tickCount = Environment.TickCount;
      while (true)
      {
        if (bitmap_0 == null)
          bitmap_0 = this.method_130();
        foreach (Bitmap bitmap_1 in bitmapList)
        {
          Rect[] rectArray = this.method_119(bitmap_0, bitmap_1);
          if (rectArray.Length != 0)
          {
            for (int index = 0; index < rectArray.Length; ++index)
            {
              if (rectArray[index].X != 0 && rectArray[index].Y != 0)
                stringList.Add(string.Format("[{0},{1}][{2},{3}]", (object) rectArray[index].Left, (object) rectArray[index].Top, (object) rectArray[index].Right, (object) rectArray[index].Bottom));
            }
            return stringList;
          }
        }
        if (Environment.TickCount - tickCount < int_4 * 1000)
        {
          this.SleepSeconds(1.0);
          bitmap_0 = this.method_130();
        }
        else
          break;
      }
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  public bool method_123(string string_11, Bitmap bitmap_0 = null, int int_4 = 0)
  {
    try
    {
      string string_11_1 = this.method_120(string_11, bitmap_0, int_4);
      if (string_11_1 != "")
        return this.method_66(string_11_1);
    }
    catch
    {
    }
    return false;
  }

  public bool method_124(string string_11, int int_4 = 0, int int_5 = 10)
  {
    try
    {
      int tickCount = Environment.TickCount;
      while (true)
      {
        string string_11_1 = this.method_120(string_11);
        if (string_11_1 != "")
        {
          for (int index = 0; index < int_5; ++index)
          {
            this.method_66(string_11_1);
            this.SleepSeconds(1.0);
            string str = this.method_120(string_11);
            if (str == "" || str != string_11_1)
              return true;
          }
        }
        if (Environment.TickCount - tickCount < int_4 * 1000)
          this.SleepSeconds(1.0);
        else
          break;
      }
    }
    catch
    {
    }
    return false;
  }

  public bool method_125(string string_11, double double_0 = 0.0)
  {
    try
    {
      int tickCount = Environment.TickCount;
      while (true)
      {
        if (!(this.method_120(string_11) != ""))
        {
          if ((double) (Environment.TickCount - tickCount) < double_0 * 1000.0)
            this.SleepSeconds(1.0);
          else
            goto label_7;
        }
        else
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
    }
label_7:
    return false;
  }

  public bool method_126(string string_11, double double_0 = 0.0)
  {
    try
    {
      int tickCount = Environment.TickCount;
      while (true)
      {
        if (!(this.method_120(string_11) == ""))
        {
          if ((double) (Environment.TickCount - tickCount) < double_0 * 1000.0)
            this.SleepSeconds(1.0);
          else
            goto label_7;
        }
        else
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
    }
label_7:
    return false;
  }

  public bool method_127(string string_11, Bitmap bitmap_0 = null, int int_4 = 0)
  {
    try
    {
      return this.method_120(string_11, bitmap_0, int_4) != "";
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  public string method_128(int int_4, ref Bitmap bitmap_0, List<string> list_0)
  {
    int tickCount = Environment.TickCount;
    while (true)
    {
      if (!this.bool_1)
      {
        if (bitmap_0 == null)
          bitmap_0 = this.method_130();
        for (int index = 0; index < list_0.Count; ++index)
        {
          if (this.method_127(list_0[index], bitmap_0))
            return list_0[index];
        }
        if (int_4 != 0 && Environment.TickCount - tickCount <= int_4 * 1000)
        {
          this.SleepSeconds(1.0);
          bitmap_0 = this.method_130();
        }
        else
          goto label_12;
      }
      else
        break;
    }
    return "";
label_12:
    return "";
  }

  public string method_129(int int_4, Bitmap bitmap_0, List<string> list_0) => this.method_129(int_4, bitmap_0, list_0);

  public Bitmap method_130() => GClass7.smethod_2(this.String_2);

  private bool method_131(string string_11) => this.method_175().Contains(string_11);

  public bool method_132(string string_11, string string_12)
  {
    this.RemoveProxy();
    this.CMD("shell su -c 'svc wifi enable'");
    if (!this.method_131("com.steinwurf.adbjoinwifi"))
      this.method_177(GClass13.smethod_0() + "\\app\\adb-join-wifi.apk");
    this.method_86("com.steinwurf.adbjoinwifi");
    this.CMD("shell am start -n com.steinwurf.adbjoinwifi/.MainActivity -e ssid '" + string_11 + "' -e password_type WPA -e password '" + string_12 + "'");
    return true;
  }

  public void method_133(int int_4, int int_5, int int_6 = 1, int int_7 = 2)
  {
    int num = Class54.random_0.Next(int_4, int_5 + 1);
    int tickCount = Environment.TickCount;
    while (Environment.TickCount - tickCount < num * 1000 && !this.bool_1 && !this.method_78())
      this.SleepSeconds((double) Class54.random_0.Next(int_6, int_7 + 1));
  }

  public void Openreel()
  {
    this.method_168("Open reel...");
    this.method_27(this.string_5 + "/com.facebook.fbshorts.viewer.activity.FbShortsViewerActivity");
  }

  internal string method_135(string string_11, string string_12)
  {
    string string_0 = "";
    try
    {
      GClass24 gclass24 = new GClass24("", "[FBAN/FB4A;FBAV/322.0.0.35.121;FBBV/297186297;FBDM/{density=2.75,width=1080,height=2130};FBLC/en_US;FBRV/298570471;FBCR/Viettel;FBMF/Xiaomi;FBBD/xiaomi;FBPN/com.facebook.katana;FBDV/Redmi Note 8;FBSV/10;FBOP/1;FBCA/arm64-v8a:;]", "", 0);
      gclass24.httpRequest_0.AddHeader("Authorization", "OAuth " + string_12);
      string string_1_1 = "method=POST&challenge_type=PASSWORD&challenge_params={\"password\":\"" + string_11 + "\"}&locale=en_US&client_country_code=VN&fb_api_req_friendly_name=validate_challenge&fb_api_caller_class=SecuredActionServiceHandler";
      gclass24.method_1("https://graph.facebook.com/secured_action/validate_challenge", string_1_1);
      gclass24.httpRequest_0.AddHeader("X-FB-Net-HNI", " 45204");
      gclass24.httpRequest_0.AddHeader("X-FB-SIM-HNI", " 45201");
      gclass24.httpRequest_0.AddHeader("Authorization", " OAuth " + string_12);
      gclass24.httpRequest_0.AddHeader("X-FB-Connection-Type", " WIFI");
      gclass24.httpRequest_0.AddHeader("X-Tigon-Is-Retry", " False");
      gclass24.httpRequest_0.AddHeader("x-fb-rmd", " state=NO_MATCH");
      gclass24.httpRequest_0.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
      gclass24.httpRequest_0.AddHeader("x-fb-device-group", " 5120");
      gclass24.httpRequest_0.AddHeader("X-FB-Friendly-Name", " PageCreationNewPage");
      gclass24.httpRequest_0.AddHeader("X-FB-Request-Analytics-Tags", " graphservice");
      gclass24.httpRequest_0.AddHeader("X-FB-HTTP-Engine", " Liger");
      gclass24.httpRequest_0.AddHeader("X-FB-Client-IP", " True");
      gclass24.httpRequest_0.AddHeader("X-FB-Server-Cluster", " True");
      gclass24.httpRequest_0.AddHeader("x-fb-connection-token", " f36ca4f6f658dd2e6a1f0ff6e43e6051");
      string string_1_2 = "doc_id=4330798123599254&method=post&locale=en_US&pretty=false&format=json&purpose=fetch&variables={\"params\":{\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"},\"path\":\"security/2fac/nt/setup/qr_code\",\"params\":\"{\\\"start_screen_id\\\":\\\"[\\\\\\\"__ntid:uu97dx:0__\\\\\\\",null]\\\"}\",\"extra_client_data\":{}},\"scale\":\"3\",\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"}}&fb_api_req_friendly_name=NativeTemplateScreenQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=[\"GraphServices\"]&server_timestamps=true";
      string_0 = Regex.Match(gclass24.method_1("https://graph.facebook.com/graphql/", string_1_2), "secret=(.*?)&").Groups[1].Value;
      string str = GClass19.smethod_85(string_0);
      gclass24.httpRequest_0.AddHeader("X-FB-Net-HNI", " 45204");
      gclass24.httpRequest_0.AddHeader("X-FB-SIM-HNI", " 45201");
      gclass24.httpRequest_0.AddHeader("Authorization", "OAuth " + string_12);
      gclass24.httpRequest_0.AddHeader("X-FB-Connection-Type", " WIFI");
      gclass24.httpRequest_0.AddHeader("X-Tigon-Is-Retry", " False");
      gclass24.httpRequest_0.AddHeader("x-fb-rmd", " state=NO_MATCH");
      gclass24.httpRequest_0.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
      gclass24.httpRequest_0.AddHeader("x-fb-device-group", " 5120");
      string string_1_3 = "doc_id=6091464777534071&method=post&locale=en_US&pretty=false&format=json&variables=%7B%22scale%22%3A%223%22%2C%22params%22%3A%7B%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22payload%22%3A%22security%2F2fac%2Fnt%2Fsetup%2Fcode_entry%2Fsubmit%3Fcontent_id%3D%255B%2522__ntid%253Av10gun%253A1__%2522%252Cnull%255D%26error_element_id%3D%255B%2522__ntid%253Av10gun%253A6__%2522%252Cnull%255D%26submit_button_id%3D%255B%2522__ntid%253Av10gun%253A4__%2522%252Cnull%255D%26progress_id%3D%255B%2522__ntid%253Av10gun%253A5__%2522%252Cnull%255D%26form_id%3D%255B%2522__ntid%253Av10gun%253A2__%2522%252Cnull%255D%26start_screen_id%3D%255B%2522__ntid%253Auu97dx%253A0__%2522%252Cnull%255D%22%2C%22client_data%22%3A%7B%22sensitive_string_value%22%3A%22%5B%5B%5C%22code%5B%5D%5C%22%2C%5C%22" + str + "%5C%22%5D%2C%5B%5C%22code_handler_type%5C%22%2C%5C%22third_party_qr_auth%5C%22%5D%5D%22%7D%7D%2C%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22profile_image_size%22%3A258%2C%22include_image_ranges%22%3Atrue%7D&fb_api_req_friendly_name=NativeTemplateAsyncQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=%5B%22GraphServices%22%5D&server_timestamps=true";
      if (gclass24.method_1("https://graph.facebook.com/graphql/", string_1_3).Contains("error"))
        string_0 = "";
    }
    catch
    {
    }
    return string_0;
  }

  internal int method_136(
    string string_11,
    string string_12,
    string string_13,
    string string_14,
    int int_4 = 0,
    int int_5 = 0,
    int int_6 = 300)
  {
    int tickCount = Environment.TickCount;
    this.Cleardata(this.string_6);
    this.Openapp(this.string_6);
    int num1 = 0;
    int num2 = 1;
    int num3 = 0;
    int num4 = int_4 != 15 ? -1 : 0;
    this.method_168("Login Tiktok...");
    while (!this.bool_1)
    {
      string str1 = this.method_53();
      string str2 = this.method_29(0, str1, new List<string>()
      {
        "//*[@text='Log in or sign up']",
        "//*[@text='Sign up']",
        "//*[@text='Agree and continue']",
        "//*[@text='Swipe up for more']",
        "//*[@text='Start watching']",
        "//*[@text='Profile']",
        "//*[@text='Continue with Facebook']",
        "//android.widget.Button[starts-with(@text,'Continue as')]",
        "//*[starts-with(@text,'user')]",
        "//*[@text='Use phone / email / username']",
        "//*[@text='Email / Username']",
        "//android.widget.EditText[@text='Email or username']",
        "//*[@text='verify captcha']",
        "//*[@content-desc='deny' or @text='deny']",
        "//*[@content-desc='Skip' or @text='Skip']",
        "//android.widget.Button[@text='Not now']",
        "//*[@text='This will help us customize your viewing experience.']",
        "//android.widget.Button[@text='NONE OF THE ABOVE']",
        "//android.widget.Button[@text='No thanks']",
        "//*[@text='Already have an account? Log in']",
        "//*[@text='Follow your friends']",
        "//*[@content-desc='Unplug charger' or @text='Unplug charger']"
      });
      string s1 = str2;
      // ISSUE: reference to a compiler-generated method
      uint num5 = Class206.smethod_0(s1);
      if (num5 <= 2488835064U)
      {
        if (num5 <= 940370423U)
        {
          if (num5 <= 503461667U)
          {
            if (num5 != 14426572U)
            {
              if (num5 != 491345232U)
              {
                if (num5 == 503461667U && s1 == "//android.widget.Button[@text='Not now']")
                  goto label_145;
                else
                  goto label_153;
              }
              else if (s1 == "//*[@content-desc='Skip' or @text='Skip']")
                goto label_145;
              else
                goto label_153;
            }
            else if (s1 == "//*[@content-desc='deny' or @text='deny']")
              goto label_145;
            else
              goto label_153;
          }
          else if (num5 <= 729358616U)
          {
            if (num5 != 532719482U)
            {
              if (num5 == 729358616U && s1 == "//*[@text='verify captcha']")
                this.method_130();
              else
                goto label_153;
            }
            else if (s1 == "//android.widget.ProgressBar")
            {
              ++num3;
              if (num3 % 5 == 0)
              {
                if (this.method_100(str1))
                  return 1;
                this.method_60("//*[@content-desc='skip' or @text='skip']", str1);
              }
            }
            else
              goto label_153;
          }
          else if (num5 != 827023039U)
          {
            if (num5 == 940370423U && s1 == "//*[@text='Incorrect account or password']")
              return 5;
            goto label_153;
          }
          else if (!(s1 == "//*[@text='Connection lost']"))
            goto label_153;
          else
            goto label_146;
        }
        else if (num5 <= 1289675325U)
        {
          if (num5 != 975982194U)
          {
            if (num5 != 1100426492U)
            {
              if (num5 != 1289675325U || !(s1 == "//android.widget.Button[starts-with(@text,'Continue as')]"))
                goto label_153;
              else
                goto label_145;
            }
            else if (s1 == "//*[@content-desc='Unplug charger' or @text='Unplug charger']")
              this.method_60("//*[@content-desc='OK' or @text='OK']", str1);
            else
              goto label_153;
          }
          else
          {
            if (s1 == "//*[@text='Edit profile']")
              return 1;
            goto label_153;
          }
        }
        else if (num5 <= 1803252991U)
        {
          if (num5 != 1450627680U)
          {
            if (num5 == 1803252991U && s1 == "//*[@text='This will help us customize your viewing experience.']")
              this.method_60("//*[@text='Confirm']", str1);
            else
              goto label_153;
          }
          else if (s1 == "//*[starts-with(@text,'user')]")
          {
            string_12 = this.method_34(str1, str2, "text").First<string>();
            this.method_60("//*[starts-with(@text,'user')]/parent::*/parent::*/child::*[last()]/child::*[last()]", str1);
          }
          else
            goto label_153;
        }
        else
        {
          if (num5 != 1878701109U)
          {
            if (num5 == 2488835064U && s1 == "//*[@text='Follow your friends']")
            {
              this.method_28();
              goto label_144;
            }
          }
          else if (s1 == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
            goto label_146;
          goto label_153;
        }
      }
      else if (num5 <= 3301521716U)
      {
        if (num5 <= 2826808716U)
        {
          if (num5 != 2558777018U)
          {
            if (num5 != 2681761929U)
            {
              if (num5 == 2826808716U && s1 == "//*[@text='Swipe up for more']")
                this.method_76();
              else
                goto label_153;
            }
            else if (!(s1 == "//*[@text='Log in or sign up']"))
              goto label_153;
            else
              goto label_145;
          }
          else if (!(s1 == "//*[@text='Start watching']"))
            goto label_153;
          else
            goto label_145;
        }
        else if (num5 <= 3036778647U)
        {
          if (num5 != 2893717309U)
          {
            if (num5 == 3036778647U && s1 == "//android.widget.Button[@text='NONE OF THE ABOVE']")
              goto label_145;
            else
              goto label_153;
          }
          else if (s1 == "//*[@text='Agree and continue']")
            goto label_145;
          else
            goto label_153;
        }
        else
        {
          if (num5 != 3036894654U)
          {
            if (num5 == 3301521716U && s1 == "//android.widget.EditText[@text='Email or username']")
            {
              this.method_50("//android.widget.EditText[@text='Email or username']", string_12);
              this.SleepSeconds(1.0);
              this.method_50("//android.widget.EditText[@text='Password']", string_13);
              this.SleepSeconds(1.0);
              this.method_60("//*[@text='Log in']", str1);
              goto label_144;
            }
          }
          else if (s1 == "//*[@text='Continue with Facebook']")
            goto label_145;
          goto label_153;
        }
      }
      else if (num5 <= 3496844666U)
      {
        if (num5 != 3386554506U)
        {
          if (num5 != 3408017596U)
          {
            if (num5 != 3496844666U || !(s1 == "//*[@text='Trouble Loading']"))
              goto label_153;
            else
              goto label_146;
          }
          else if (s1 == "//*[@text='Profile']")
          {
            if (!this.method_31(0, str1, "//*[@text='Edit profile']"))
            {
              this.method_60(str2, str1);
            }
            else
            {
              string str3 = "http://45.77.37.128/?type=getcode&mail=aaasasasas2323232@smakit.vn";
              string str4 = "";
              while (!this.bool_1)
              {
                string str5 = this.method_53();
                string str6 = this.method_29(0, str5, new List<string>()
                {
                  "//*[starts-with(@text,'user')]",
                  "//*[@text='Settings and privacy']",
                  "//*[@text='Manage account']",
                  "//*[@text='Password']",
                  "//*[@text=\"Can't verify your phone? Use email\"]",
                  "//android.widget.EditText[@text='Email address']",
                  "//*[@text='Change email address']",
                  "//*[@text='Enter 6-digit code']",
                  "//*[@text='No thanks']",
                  "//android.widget.EditText[@text='Enter password']"
                });
                string s2 = str6;
                // ISSUE: reference to a compiler-generated method
                uint num6 = Class206.smethod_0(s2);
                if (num6 <= 1450627680U)
                {
                  if (num6 <= 937886214U)
                  {
                    if (num6 != 802456587U)
                    {
                      if (num6 == 937886214U && s2 == "//*[@text='Enter 6-digit code']")
                      {
                        if (str4 == "")
                          return -1;
                        this.method_50("//android.widget.EditText", Class23.smethod_4(0, str3, str4));
                      }
                      else
                        goto label_110;
                    }
                    else if (s2 == "//*[@text='Manage account']")
                    {
                      if (string_13 != "")
                      {
                        string str7 = string_12 + "|" + string_13 + "|" + str4 + "|";
                        lock (this.object_2)
                          System.IO.File.AppendAllText("tiktok.txt", str7 + "\r\n");
                        return 1;
                      }
                      if (this.method_31(0, str5, "//*[@text='Password']"))
                        this.method_60("//*[@text='Password']", str5);
                      else
                        this.method_60(str6, str5);
                    }
                    else
                      goto label_110;
                  }
                  else if (num6 != 1113589947U)
                  {
                    if (num6 == 1450627680U && s2 == "//*[starts-with(@text,'user')]")
                    {
                      string_12 = this.method_34(str5, str6, "text").First<string>();
                      this.method_60("//*[starts-with(@text,'user')]/parent::*/parent::*/child::*[last()]/child::*[last()]", str5);
                    }
                    else
                      goto label_110;
                  }
                  else if (s2 == "//*[@text='Settings and privacy']")
                  {
                    if (this.method_31(0, str5, "//*[@text='Manage account']"))
                      this.method_60("//*[@text='Manage account']", str5);
                    else
                      this.method_60(str6, str5);
                  }
                  else
                    goto label_110;
                }
                else
                {
                  if (num6 <= 2745425442U)
                  {
                    if (num6 != 2698810085U)
                    {
                      if (num6 == 2745425442U && s2 == "//android.widget.EditText[@text='Enter password']")
                      {
                        string_13 = "Min@123" + GClass19.smethod_59(5);
                        this.method_50(str6, string_13);
                        this.method_60("//*[@text='Next']", str5);
                        goto label_109;
                      }
                      else
                        goto label_110;
                    }
                    else if (!(s2 == "//*[@text='No thanks']"))
                      goto label_110;
                  }
                  else if (num6 != 3054835099U)
                  {
                    if (num6 != 3234013380U)
                    {
                      if (num6 == 3691564067U && s2 == "//android.widget.EditText[@text='Email address']")
                      {
                        str4 = GClass19.smethod_62(Class44.smethod_3().OrderBy<string, Guid>((Func<string, Guid>) (string_0 => Guid.NewGuid())).First<string>() + Class44.smethod_5().OrderBy<string, Guid>((Func<string, Guid>) (string_0 => Guid.NewGuid())).First<string>()).Replace(" ", "").ToLower() + GClass19.smethod_61(6, this.random_0) + Regex.Match(str3, "@\\w+.\\w+").Value;
                        this.method_50(str6, str4);
                        this.method_60("//*[@text='Send code']", str5);
                        goto label_109;
                      }
                      else
                        goto label_110;
                    }
                    else if (!(s2 == "//*[@text=\"Can't verify your phone? Use email\"]"))
                      goto label_110;
                  }
                  else if (!(s2 == "//*[@text='Change email address']"))
                    goto label_110;
                  this.method_60(str6, str5);
                }
label_109:
                this.SleepSeconds(1.0);
                goto label_116;
label_110:
                if (this.method_31(0, str5, "//android.widget.ImageView[@content-desc='Unlock']"))
                {
                  this.method_69();
                  this.Openapp(this.string_6);
                }
                else if (str5.Contains("com.android.systemui"))
                {
                  this.method_28();
                  this.Openapp(this.string_6);
                }
                else if (this.Openapp(this.string_6) != 1)
                  goto label_109;
label_116:
                if (Environment.TickCount - tickCount >= int_6 * 1000)
                  goto label_160;
              }
              return -2;
            }
          }
          else
            goto label_153;
        }
        else if (!(s1 == "//*[@text='Use phone / email / username']"))
          goto label_153;
        else
          goto label_145;
      }
      else if (num5 > 3971055724U)
      {
        int num7;
        switch (num5)
        {
          case 4180370898:
            if (s1 == "//android.widget.Button[@text='No thanks']")
              goto label_145;
            else
              goto label_153;
          case 4245741645:
            num7 = !(s1 == "//*[@text='Already have an account? Log in']") ? 1 : 0;
            break;
          default:
            num7 = 1;
            break;
        }
        if (num7 == 0)
          goto label_145;
        else
          goto label_153;
      }
      else
      {
        int num8;
        switch (num5)
        {
          case 3915792911:
            if (s1 == "//*[@text='Sign up']")
            {
              if (this.method_31(0, str1, "//*[@text=\"When’s your birthday?\"]"))
              {
                for (int index1 = 1; index1 < 4; ++index1)
                {
                  string string_12_1 = "//*[@text='Next']/parent::*/child::*[last()]/child::*/child::*[" + index1.ToString() + "]";
                  Class77 class77 = new Class77(this.method_37(0, str1, string_12_1).First<string>());
                  int num9 = this.method_87(1, 4);
                  if (index1 == 3)
                    num9 = 4;
                  for (int index2 = 0; index2 < num9; ++index2)
                    this.method_73(class77.int_0 + 5, class77.int_1 + 5, class77.int_2 - 5, class77.int_3 - 5, this.method_87(100, 200));
                }
                this.method_60("//*[@text='Next']", str1);
                goto label_144;
              }
              else if (this.method_31(0, str1, "//*[@content-desc='Skip' or @text='Skip']"))
              {
                this.method_60("//*[@content-desc='Skip' or @text='Skip']", str1);
                goto label_144;
              }
              else
              {
                this.method_60(str2, str1);
                goto label_144;
              }
            }
            else
              goto label_142;
          case 3971055724:
            num8 = s1 == "//*[@text='Email / Username']" ? 1 : 0;
            break;
          default:
            num8 = 0;
            break;
        }
        if (num8 != 0)
          goto label_145;
label_142:
        goto label_153;
      }
label_144:
      this.SleepSeconds(1.0);
      goto label_159;
label_145:
      this.method_60(str2, str1);
      goto label_144;
label_146:
      if (num1 >= num2)
      {
        if (num4 != 0 || !this.method_160())
          return 7;
        num4 = 1;
        this.Openapp(this.string_5);
      }
      ++num1;
      if (str2 == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
      {
        this.method_60("//android.widget.Button[@text='OK']", str1);
        goto label_144;
      }
      else
      {
        this.method_60("//*[@text='Tap to retry']", str1);
        goto label_144;
      }
label_153:
      if (this.method_31(0, str1, "//android.widget.ImageView[@content-desc='Unlock']"))
      {
        this.method_69();
        this.Openapp(this.string_6);
      }
      else if (str1.Contains("com.android.systemui"))
      {
        this.method_28();
        this.Openapp(this.string_6);
      }
      else if (this.Openapp(this.string_6) != 1)
        goto label_144;
label_159:
      if (Environment.TickCount - tickCount < int_6 * 1000)
        continue;
label_160:
      return 0;
    }
    return -2;
  }

  internal int method_137(string string_11, string string_12, string string_13, int int_4 = 300)
  {
    this.Cleardata(this.string_7);
    this.Openapp(this.string_7);
    int num1 = 0;
    int num2 = 5;
    string str1 = "";
    string string_12_1 = "";
    int tickCount = Environment.TickCount;
    while (!this.bool_1)
    {
      string str2 = this.method_53();
      string str3 = this.method_29(0, str2, new List<string>()
      {
        "android.widget.ProgressBar",
        "//*[starts-with(@text,'Continue as')]",
        "//*[@text='Log in with Facebook']",
        "//android.widget.Button[@text='Yes, finish setup']",
        "//*[@text='CREATE USERNAME']",
        "//android.widget.Button[@text='Sign up']",
        "//android.widget.Button[@text='Not now']",
        "//android.widget.Button[@text='Skip']",
        "//android.widget.Button[@content-desc='Next']",
        "//*[@content-desc='Profile']",
        "//*[@text='If you forgot your password, you can reset it with Facebook.']",
        "//android.widget.Button[@text='Đăng nhập']",
        "//android.widget.EditText[@text='New password']",
        "//android.widget.Button[@text='Dismiss']",
        "//android.widget.Button[@text='NONE OF THE ABOVE']",
        "//*[@content-desc='Unplug charger' or @text='Unplug charger']",
        "//*[starts-with(@text,'Log into Instagram as')]",
        "//*[@text='Current password']",
        "//*[@text='An unknown network error has occurred.']",
        "//*[@text=\"We couldn't log you in with Facebook.\"]"
      });
      string s = str3;
      // ISSUE: reference to a compiler-generated method
      uint num3 = Class206.smethod_0(s);
      if (num3 <= 1896311505U)
      {
        if (num3 <= 532719482U)
        {
          if (num3 <= 203803302U)
          {
            if (num3 != 101514837U)
            {
              if (num3 == 203803302U && s == "//*[@content-desc='Profile']")
              {
                if (!(string_12_1 != ""))
                {
                  if (this.method_31(0, str2, "//android.widget.EditText[@text='Password']"))
                  {
                    string_12_1 = "Min@123" + GClass19.smethod_59(5);
                    this.method_50("//android.widget.EditText[@text='Password']", string_12_1);
                    this.method_60("//android.widget.Button[@text='Create']", str2);
                  }
                  else if (this.method_31(0, str2, "//*[@text='Create password']"))
                    this.method_60("//*[@text='Create password']", str2);
                  else if (this.method_31(0, str2, "//*[@text='Password']"))
                    this.method_60("//*[@text='Password']", str2);
                  else if (this.method_31(0, str2, "//*[@text='Security']"))
                    this.method_60("//*[@text='Security']", str2);
                  else if (this.method_31(0, str2, "//android.widget.Button[@content-desc='Settings']"))
                    this.method_60("//android.widget.Button[@content-desc='Settings']", str2);
                  else if (this.method_31(0, str2, "//android.widget.Button[@content-desc='Options']"))
                  {
                    if (str1 == "")
                      str1 = this.method_34(str2, "//android.widget.Button[@content-desc='Options']/parent::*/child::*[1]/child::*[1]/child::*[1]/child::*[1]", "text").First<string>();
                    this.method_60("//android.widget.Button[@content-desc='Options']", str2);
                  }
                  else
                    this.method_60(str3, str2);
                }
                else
                {
                  string str4 = str1 + "|" + string_12_1;
                  lock (this.object_2)
                    System.IO.File.AppendAllText("instagram.txt", str4 + "\r\n");
                  return 1;
                }
              }
              else
                goto label_80;
            }
            else if (!(s == "//*[@text=\"We couldn't log you in with Facebook.\"]"))
              goto label_80;
            else
              goto label_87;
          }
          else if (num3 != 359269505U)
          {
            if (num3 != 503461667U)
            {
              if (num3 != 532719482U || !(s == "//android.widget.ProgressBar"))
                goto label_80;
            }
            else if (!(s == "//android.widget.Button[@text='Not now']"))
              goto label_80;
            else
              goto label_76;
          }
          else if (!(s == "//*[starts-with(@text,'Log into Instagram as')]"))
            goto label_80;
          else
            goto label_87;
        }
        else if (num3 <= 1100426492U)
        {
          if (num3 != 978746329U)
          {
            if (num3 == 1100426492U && s == "//*[@content-desc='Unplug charger' or @text='Unplug charger']")
              this.method_60("//*[@content-desc='OK' or @text='OK']", str2);
            else
              goto label_80;
          }
          else if (s == "//*[@text='Current password']")
          {
            if (!this.method_31(0, str2, "//*[@text='If you forgot your password, you can reset it with Facebook.']"))
              return 3;
          }
          else
            goto label_80;
        }
        else if (num3 != 1620566430U)
        {
          if (num3 != 1753985601U)
          {
            if (num3 == 1896311505U && s == "//android.widget.Button[@content-desc='Next']")
              goto label_76;
            else
              goto label_80;
          }
          else if (s == "//android.widget.Button[@text='Skip']")
            goto label_76;
          else
            goto label_80;
        }
        else if (s == "//*[@text='Log in with Facebook']")
          goto label_76;
        else
          goto label_80;
      }
      else if (num3 <= 2853230193U)
      {
        if (num3 > 2467940779U)
        {
          int num4;
          switch (num3)
          {
            case 2621521766:
              if (s == "//android.widget.EditText[@text='New password']")
              {
                string_12_1 = "LongP@123" + GClass19.smethod_59(5);
                this.method_50(str3, string_12_1);
                this.method_50("//android.widget.EditText[@text='New password, again']", string_12_1);
                this.method_60("//android.widget.Button[@content-desc='Done']", str2);
                goto label_75;
              }
              else
                goto label_80;
            case 2746707739:
              if (s == "//android.widget.Button[@text='Đăng nhập']")
              {
                this.method_50("//android.widget.EditText", string_12);
                this.method_60(str3, str2);
                goto label_75;
              }
              else
                goto label_80;
            case 2853230193:
              num4 = !(s == "//*[@text='If you forgot your password, you can reset it with Facebook.']") ? 1 : 0;
              break;
            default:
              num4 = 1;
              break;
          }
          if (num4 == 0)
          {
            System.Drawing.Point point = new Class77(this.method_37(0, str2, str3).First<string>()).method_1();
            this.method_55(point.X + 200, point.Y);
          }
          else
            goto label_80;
        }
        else
        {
          int num5;
          switch (num3)
          {
            case 2032129326:
              if (s == "//android.widget.Button[@text='Dismiss']")
                goto label_76;
              else
                goto label_80;
            case 2467940779:
              num5 = !(s == "//android.widget.Button[@text='Yes, finish setup']") ? 1 : 0;
              break;
            default:
              num5 = 1;
              break;
          }
          if (num5 == 0)
            goto label_76;
          else
            goto label_80;
        }
      }
      else if (num3 <= 2915547065U)
      {
        if (num3 != 2912895069U)
        {
          if (num3 == 2915547065U && s == "//*[@text='CREATE USERNAME']")
          {
            str1 = this.method_34(str2, "//android.widget.EditText", "text").First<string>();
            this.method_60("//android.widget.Button[@text='Next']", str2);
          }
          else
            goto label_80;
        }
        else if (!(s == "//*[@text='An unknown network error has occurred.']"))
          goto label_80;
        else
          goto label_87;
      }
      else
      {
        if (num3 != 3036778647U)
        {
          if (num3 != 3556196668U)
          {
            if (num3 != 3850556364U || !(s == "//android.widget.Button[@text='Sign up']"))
              goto label_80;
          }
          else if (!(s == "//*[starts-with(@text,'Continue as')]"))
            goto label_80;
        }
        else if (!(s == "//android.widget.Button[@text='NONE OF THE ABOVE']"))
          goto label_80;
        goto label_76;
      }
label_75:
      this.SleepSeconds(1.0);
      goto label_86;
label_76:
      if (str3 == "//android.widget.Button[@text='Sign up']" || str3 == "//android.widget.Button[@text='Dismiss']")
      {
        if (num1 < num2)
          ++num1;
        else
          goto label_87;
      }
      this.method_60(str3, str2);
      goto label_75;
label_80:
      if (this.method_31(0, str2, "//android.widget.ImageView[@content-desc='Unlock']"))
      {
        this.method_69();
        this.Openapp(this.string_7);
      }
      else if (str2.Contains("com.android.systemui"))
      {
        this.method_28();
        this.Openapp(this.string_7);
      }
      else if (this.Openapp(this.string_7) != 1)
        goto label_75;
label_86:
      if (Environment.TickCount - tickCount < int_4 * 1000)
        continue;
label_87:
      return 0;
    }
    return -2;
  }

  internal int method_138(string string_11, string string_12, string string_13)
  {
    this.method_168("Check status...");
    int num1 = 0;
    this.Openapp(this.string_5);
    int num2 = 0;
    int num3 = 1;
    int num4 = 0;
    int num5 = 6;
    int num6 = 0;
    int num7 = 1;
    while (true)
    {
      string str;
      do
      {
        if (!this.bool_1)
        {
          str = this.method_53();
          if (!this.method_146(str, "Tap to view story"))
          {
            if (!this.method_31(0, str, "//*[@text='Tap to retry']"))
            {
              if (this.method_31(0, str, "//android.widget.ProgressBar"))
                ;
              if (!this.method_146(str, "Save your login info"))
              {
                if (!this.method_60("//*[@text='skip']", str))
                {
                  if (!this.method_31(0, str, "//android.widget.ImageView[@content-desc='Unlock']"))
                  {
                    if (!str.Contains("com.android.systemui"))
                    {
                      if (!(this.method_29(0, str, new List<string>()
                      {
                        "//*[@text='Save your login info']",
                        "//*[@text='Next time you log in on this phone, just tap your profile picture instead of typing a password.']"
                      }) != ""))
                      {
                        if (!this.method_146(str, "Facebook isn't responding", "Facebook keeps stopping"))
                        {
                          if (!this.method_101(str))
                          {
                            if (this.method_103(str))
                              goto label_39;
                          }
                          else
                            goto label_26;
                        }
                        else
                          goto label_18;
                      }
                      else
                        goto label_16;
                    }
                    else
                      goto label_14;
                  }
                  else
                    goto label_12;
                }
                else
                  goto label_10;
              }
              else
                goto label_8;
            }
            else
              goto label_3;
          }
          else
            goto label_40;
        }
        else
          goto label_41;
      }
      while (this.method_104(str));
      goto label_31;
label_3:
      if (num4 < num5)
      {
        ++num4;
        this.method_78(-1);
        continue;
      }
      break;
label_8:
      this.method_64(str, 0, "//*[@text='OK']", "//*[@text='Not now' or @content-desc='Not now']");
      num1 = 1;
      continue;
label_10:
      num1 = 1;
      continue;
label_12:
      this.method_69();
      this.Openapp(this.string_5);
      continue;
label_14:
      this.method_28();
      this.Openapp(this.string_5);
      continue;
label_16:
      this.method_64(str, 0, "//*[@text='OK']", "//*[@text='Not now' or @content-desc='Not now']");
      this.method_80(2.0, 3.0);
      continue;
label_18:
      if (num2 < num3)
      {
        if (!this.method_95(string_11))
          num2 = num3 - 1;
      }
      else if (num2 == num3)
      {
        this.Cleardata(this.string_5);
      }
      else
      {
        this.method_49(this.string_5);
        this.method_177(GClass13.smethod_0() + "\\app\\facebook.apk");
        this.method_17();
        this.method_44();
        this.method_69();
        this.method_95(string_11);
      }
      ++num2;
      this.Openapp(this.string_5);
      this.SleepSeconds(2.0);
      continue;
label_26:
      if (num6 < num7)
      {
        ++num6;
        this.method_60("//*[@text='Close']", str);
        continue;
      }
      goto label_28;
label_31:
      if (!this.method_139(str))
      {
        if (!this.method_100(str))
        {
          if (this.Openapp(this.string_5) == 1)
            this.SleepSeconds(3.0);
          else
            goto label_43;
        }
        else
          goto label_35;
      }
      else
        goto label_36;
    }
    return 7;
label_28:
    return 13;
label_35:
    return 0;
label_36:
    int num8 = this.method_99(string_11, string_11, string_12, string_13);
    return num8 == 0 ? -1 : num8;
label_39:
    return 2;
label_40:
    return 0;
label_41:
    return -2;
label_43:
    return num1;
  }

  private bool method_139(string string_11)
  {
    if (string_11 == "")
      string_11 = this.method_53();
    return this.method_29(0, string_11, new List<string>()
    {
      "//android.widget.TextView[@text='Session Expired']",
      "//android.widget.TextView[@text='Please log in again.']",
      "//android.view.ViewGroup[@content-desc='Reload Menu']",
      "//*[@text='Log Into Another Account']",
      "//*[@text='Find Your Account']"
    }) != "";
  }

  internal void method_140(string string_11, string string_12)
  {
    string str = this.CMD("shell pm path " + string_11).Split('\n')[0];
    this.CMD("pull " + str.Substring(str.IndexOf(":") + 1) + " " + string_12);
  }

  private void method_141(string string_11)
  {
    List<string> list = ((IEnumerable<string>) this.CMD("shell ls " + string_11).Split(new string[2]
    {
      Environment.NewLine,
      "\n"
    }, StringSplitOptions.None)).Where<string>((Func<string, bool>) (string_0 => !string.IsNullOrEmpty(string_0))).ToList<string>();
    this.CMD("shell su -c rm -rf /" + string_11 + "/*");
    this.CMD("shell su -c rm -r /" + string_11 + "/.thumbnails");
    foreach (string path in list)
      this.CMD("shell am broadcast -a android.intent.action.MEDIA_SCANNER_SCAN_FILE -d \"file:///mnt/" + string_11 + "/" + Path.GetFileName(path) + "\"");
  }

  internal void method_142(List<string> list_0)
  {
    this.method_168("Up ảnh...");
    this.method_141("sdcard/dcim/camera");
    this.method_141("sdcard/pictures");
    this.method_141("sdcard/movies");
    foreach (string path in list_0)
    {
      string str = GClass19.smethod_60(10).TrimEnd('.') + "." + Path.GetExtension(path).TrimStart('.');
      this.CMD("push \"" + path + "\" \"/sdcard/pictures/" + str + "\"");
      this.CMD("shell am broadcast -a android.intent.action.MEDIA_SCANNER_SCAN_FILE -d \"file:///mnt/sdcard/pictures/" + str + "\"");
    }
  }

  internal bool method_143()
  {
    List<string> stringList = this.method_175();
    if (stringList.Contains("com.minsoftware.maxchanger"))
      this.method_49("com.minsoftware.maxchanger");
    if (!stringList.Contains("ru.andr7e.deviceinfohw"))
      this.method_177(GClass13.smethod_0() + "\\app\\DeviceInfoHW.apk");
    this.method_177(GClass13.smethod_0() + "\\app\\maxchange.apk");
    this.SleepSeconds(2.0);
    this.method_60("//android.widget.Button[@text='INSTALL ANYWAY']");
    this.CMD("shell am start -n com.android.shell/.BugreportWarningActivity -c org.lsposed.manager.LAUNCH_MANAGER -p com.android.shell -a android.intent.action.MAIN");
    this.SleepSeconds(2.0);
    this.CMD("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
    this.CMD("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
    string string_12 = "facebook";
    bool flag = false;
    int tickCount = Environment.TickCount;
    int num1 = 300;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11 = this.method_29(0, str, new List<string>()
      {
        "//android.widget.EditText[@text='Search…']",
        "//android.widget.Switch[@text='ON']",
        "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='true']",
        "//android.widget.Switch[@text='OFF']",
        "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='false']",
        "//android.widget.TextView[@text='MaxChanger']",
        "//android.widget.FrameLayout[contains(@content-desc,'Modules')]"
      });
      string s = string_11;
      // ISSUE: reference to a compiler-generated method
      uint num2 = Class206.smethod_0(s);
      if (num2 <= 1582824711U)
      {
        if (num2 <= 1265225096U)
        {
          if (num2 != 141461479U)
          {
            if (num2 != 1265225096U || !(s == "//android.widget.TextView[@text='MaxChanger']"))
              goto label_35;
          }
          else if (!(s == "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='false']"))
            goto label_35;
        }
        else if (num2 != 1397864407U)
        {
          if (num2 != 1582824711U || !(s == "//android.widget.Switch[@text='ON']"))
            goto label_35;
          else
            goto label_26;
        }
        else if (s == "//android.widget.FrameLayout[contains(@content-desc,'Modules')]")
        {
          if (flag)
          {
            this.method_60("//*[@content-desc='More options']/parent::*/child::*[1]", str);
          }
          else
          {
            flag = true;
            this.method_60(string_11, str);
          }
          goto label_35;
        }
        else
          goto label_35;
      }
      else if (num2 <= 2084351161U)
      {
        if (num2 != 1926143043U)
        {
          if (num2 == 2084351161U && s == "//android.widget.EditText[@text='Search…']")
          {
            this.method_50("//android.widget.EditText[@text='Search…']", string_12);
            goto label_35;
          }
          else
            goto label_35;
        }
        else if (!(s == "//*[@content-desc='More options']/parent::*/child::*[1]"))
          goto label_35;
      }
      else if (num2 != 2687307995U)
      {
        if (num2 != 4211664092U || !(s == "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='true']"))
          goto label_35;
        else
          goto label_26;
      }
      else if (!(s == "//android.widget.Switch[@text='OFF']"))
        goto label_35;
      this.method_60(string_11, str);
      goto label_35;
label_26:
      if (!this.method_31(0, str, "//android.widget.textview[contains(@text,'" + string_12 + "')]/parent::*/android.widget.checkbox"))
      {
        this.method_60("//androidx.appcompat.widget.LinearLayoutCompat[@class='androidx.appcompat.widget.LinearLayoutCompat']/android.widget.TextView", str);
      }
      else
      {
        if (this.method_31(0, str, "//android.widget.TextView[contains(@text,'" + string_12 + "')]/parent::*/android.widget.checkbox[@checked='false']"))
          this.method_60("//android.widget.TextView[contains(@text,'" + string_12 + "')]", str);
        this.method_46("//android.widget.EditText");
        switch (string_12)
        {
          case "facebook":
            string_12 = "device info hw";
            break;
          case "device info hw":
            string_12 = "System";
            break;
          default:
            return true;
        }
      }
label_35:
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= num1 * 1000)
        break;
    }
    return false;
  }

  internal bool method_144()
  {
    foreach (string str in this.method_176())
    {
      string string_0 = str;
      new Thread((ThreadStart) (() => this.CMD("shell am start -n " + string_0 + "/v.q -c android.intent.category.LAUNCHER -a android.intent.action.MAIN")))
      {
        IsBackground = true
      }.Start();
    }
    this.SleepSeconds(2.0);
    int tickCount = Environment.TickCount;
    int num1 = 300;
    bool flag = false;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11 = this.method_29(0, str, new List<string>()
      {
        "//android.widget.TextView[@text='No apps have asked for Superuser permission yet.']",
        "//android.widget.TextView[@text='Shell']/parent::*/*[@text='OFF']",
        "//android.widget.TextView[@text='Shell']/parent::*/*[@text='ON']",
        "//android.widget.FrameLayout[@content-desc='Superuser']",
        "//android.widget.TextView[@content-desc='Settings']",
        "//android.widget.TextView[@text='Settings']",
        "//android.widget.TextView[@text='Grant']"
      });
      string s = string_11;
      // ISSUE: reference to a compiler-generated method
      uint num2 = Class206.smethod_0(s);
      if (num2 <= 1133221858U)
      {
        switch (num2)
        {
          case 184981057:
            if (s == "//android.widget.FrameLayout[@content-desc='Superuser']")
            {
              if (flag)
              {
                this.method_60("//android.widget.TextView[@content-desc='Settings']");
                break;
              }
              this.method_60(string_11, str);
              flag = true;
              break;
            }
            break;
          case 829350801:
            if (s == "//android.widget.TextView[@text='Settings']")
            {
              while (!this.method_60("//android.widget.TextView[@text='Automatic Response']"))
              {
                if (this.method_78())
                  return false;
              }
              break;
            }
            break;
          case 1133221858:
            if (s == "//android.widget.TextView[@text='Grant']")
            {
              this.method_60(string_11, str);
              return true;
            }
            break;
        }
      }
      else if (num2 <= 2493362195U)
      {
        if (num2 != 1228394547U)
        {
          if (num2 != 2493362195U || !(s == "//android.widget.TextView[@text='Shell']/parent::*/*[@text='OFF']"))
            goto label_27;
        }
        else if (!(s == "//android.widget.TextView[@content-desc='Settings']"))
          goto label_27;
        this.method_60(string_11, str);
      }
      else
      {
        if (num2 != 3190033371U)
        {
          if (num2 != 3353998111U || !(s == "//android.widget.TextView[@text='Shell']/parent::*/*[@text='ON']"))
            goto label_27;
        }
        else if (!(s == "//android.widget.TextView[@text='No apps have asked for Superuser permission yet.']"))
          goto label_27;
        this.method_28();
      }
label_27:
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= num1 * 1000)
        break;
    }
    return false;
  }

  internal bool method_145()
  {
    if (this.method_175().Contains("com.builuc1998.max_mobile_app"))
      this.method_49("com.builuc1998.max_mobile_app");
    this.method_177(GClass13.smethod_0() + "\\app\\maxhelper.apk");
    this.SleepSeconds(2.0);
    this.CMD("shell am start -a android.settings.ACCESSIBILITY_SETTINGS");
    this.SleepSeconds(2.0);
    int tickCount = Environment.TickCount;
    int num1 = 300;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11 = this.method_29(0, str, new List<string>()
      {
        "//android.widget.Button[@resource-id='com.android.settings:id/permission_disable_stop_button']",
        "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']",
        "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='true']",
        "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='false']",
        "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='true']",
        "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='false']",
        "//android.widget.TextView[@text='max_mobile_app']",
        "//android.widget.Button[@text='OK']",
        "//android.widget.Button[@text='Got it']"
      });
      string s = string_11;
      // ISSUE: reference to a compiler-generated method
      uint num2 = Class206.smethod_0(s);
      if (num2 <= 2286921084U)
      {
        if (num2 <= 675693509U)
        {
          if (num2 != 366645833U)
          {
            if (num2 == 675693509U && s == "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='true']")
              goto label_21;
          }
          else if (s == "//android.widget.TextView[@text='max_mobile_app']")
            goto label_22;
        }
        else if (num2 != 1232705540U)
        {
          if (num2 == 2286921084U && s == "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='false']")
            goto label_22;
        }
        else if (s == "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='false']")
          goto label_22;
      }
      else if (num2 <= 2609368340U)
      {
        if (num2 != 2593255712U)
        {
          if (num2 == 2609368340U && s == "//android.widget.Button[@resource-id='com.android.settings:id/permission_disable_stop_button']")
            goto label_21;
        }
        else if (s == "//android.widget.Button[@text='OK']")
          goto label_22;
      }
      else if (num2 != 2614915793U)
      {
        if (num2 != 3036346468U)
        {
          if (num2 == 3445947035U && s == "//android.widget.Switch[@resource-id='android:id/switch_widget'][@checked='true']")
            goto label_21;
        }
        else if (s == "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']")
          goto label_22;
      }
      else if (s == "//android.widget.Button[@text='Got it']")
        goto label_22;
label_20:
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount < num1 * 1000)
        continue;
      break;
label_21:
      return true;
label_22:
      this.method_60(string_11, str);
      if (string_11 == "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']" || string_11 == "//android.widget.Button[@text='OK']")
        return true;
      goto label_20;
    }
    return false;
  }

  public bool method_146(string string_11, params string[] string_12)
  {
    if (string_11 == "")
      string_11 = this.method_53();
    string_11 = string_11.ToLower();
    int index = 0;
    while (true)
    {
      if (index < string_12.Length)
      {
        if (!string_11.Contains(string_12[index].ToLower()))
          ++index;
        else
          goto label_7;
      }
      else
        break;
    }
    return false;
label_7:
    return true;
  }

  public bool method_147(int int_4, string string_11, params string[] string_12)
  {
    try
    {
      int tickCount = Environment.TickCount;
      while (!this.bool_1)
      {
        if (string_11 == "")
          string_11 = this.method_53();
        if (this.method_146(string_11, string_12))
          return true;
        string_11 = "";
        if (Environment.TickCount - tickCount < int_4 * 1000)
          this.SleepSeconds(1.0);
        else
          break;
      }
    }
    catch (Exception ex)
    {
      this.method_82(ex);
    }
    return false;
  }

  internal bool method_148()
  {
    this.CMD("shell am start -a android.settings.LOCALE_SETTINGS");
    int tickCount = Environment.TickCount;
    int num = 300;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11 = this.method_29(0, str, new List<string>()
      {
        "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']",
        "//android.widget.TextView[@text='United States']",
        "//android.widget.TextView[@resource-id='android:id/locale_search_menu']",
        "//android.widget.EditText[@resource-id='android:id/search_src_text']",
        "//android.widget.Button[@resource-id='com.android.settings:id/add_language']"
      });
      switch (string_11)
      {
        case "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']":
          if (this.method_31(0, str, "//android.widget.TextView[@text='Languages']"))
            return true;
          if (str.Contains("English"))
          {
            List<string> source = this.method_37(0, str, "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']");
            if (source.Count > 1)
            {
              this.method_75(source.Last<string>(), this.method_37(0, str, "//android.view.ViewGroup[@resource-id='com.android.settings:id/action_bar']/android.widget.LinearLayout/android.widget.ImageButton").First<string>());
              return true;
            }
          }
          this.method_60("//android.widget.Button[@resource-id='com.android.settings:id/add_language']");
          break;
        case "//android.widget.EditText[@resource-id='android:id/search_src_text']":
          this.method_50(string_11, "English");
          this.SleepSeconds(2.0);
          this.method_61(5, "//android.widget.TextView[@resource-id='android:id/locale']", "");
          break;
        case "//android.widget.TextView[@resource-id='android:id/locale_search_menu']":
        case "//android.widget.TextView[@text='United States']":
          this.method_60(string_11, str);
          break;
        case "//android.widget.Button[@resource-id='com.android.settings:id/add_language']":
          if (str.Contains("English (United States)"))
            return true;
          this.method_60(string_11, str);
          break;
      }
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= num * 1000)
        break;
    }
    return false;
  }

  internal bool setup_tiengviet()
  {
    this.CMD("shell am start -a android.settings.LOCALE_SETTINGS");
    int tickCount = Environment.TickCount;
    int num = 300;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11 = this.method_29(0, str, new List<string>()
      {
        "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']",
        "//android.widget.TextView[@text='United States']",
        "//android.widget.TextView[@resource-id='android:id/locale_search_menu']",
        "//android.widget.EditText[@resource-id='android:id/search_src_text']",
        "//android.widget.Button[@resource-id='com.android.settings:id/add_language']"
      });
      switch (string_11)
      {
        case "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']":
          if (this.method_31(0, str, "//android.widget.TextView[@text='Languages']"))
            return true;
          if (str.Contains("English"))
          {
            List<string> source = this.method_37(0, str, "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']");
            if (source.Count > 1)
            {
              this.method_75(source.Last<string>(), this.method_37(0, str, "//android.view.ViewGroup[@resource-id='com.android.settings:id/action_bar']/android.widget.LinearLayout/android.widget.ImageButton").First<string>());
              return true;
            }
          }
          this.method_60("//android.widget.Button[@resource-id='com.android.settings:id/add_language']");
          break;
        case "//android.widget.EditText[@resource-id='android:id/search_src_text']":
          this.method_50(string_11, "English");
          this.SleepSeconds(2.0);
          this.method_61(5, "//android.widget.TextView[@resource-id='android:id/locale']", "");
          break;
        case "//android.widget.TextView[@resource-id='android:id/locale_search_menu']":
        case "//android.widget.TextView[@text='United States']":
          this.method_60(string_11, str);
          break;
        case "//android.widget.Button[@resource-id='com.android.settings:id/add_language']":
          if (str.Contains("English (United States)"))
            return true;
          this.method_60(string_11, str);
          break;
      }
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= num * 1000)
        break;
    }
    return false;
  }

  public List<string> method_149() => this.method_175().Where<string>((Func<string, bool>) (string_0 => string_0.StartsWith("com.facebook.ka"))).ToList<string>();

  public List<string> method_150(string string_11 = "", int int_4 = 0)
  {
    if (string_11 == "")
      string_11 = this.method_53().ToLower();
    List<string> collection1 = this.method_152(string_11, "text=\"(.*?)\"");
    List<string> collection2 = this.method_152(string_11, "content-desc=\"(.*?)\"");
    List<string> collection3 = this.method_152(string_11, "text='(.*?)'");
    List<string> collection4 = this.method_152(string_11, "content-desc='(.*?)'");
    List<string> stringList = new List<string>();
    switch (int_4)
    {
      case 0:
        stringList.AddRange((IEnumerable<string>) collection1);
        stringList.AddRange((IEnumerable<string>) collection2);
        stringList.AddRange((IEnumerable<string>) collection3);
        stringList.AddRange((IEnumerable<string>) collection4);
        break;
      case 1:
        stringList.AddRange((IEnumerable<string>) collection1);
        stringList.AddRange((IEnumerable<string>) collection3);
        break;
      case 2:
        stringList.AddRange((IEnumerable<string>) collection2);
        stringList.AddRange((IEnumerable<string>) collection4);
        break;
    }
    return stringList;
  }

  public string method_151(string string_11)
  {
    string str = this.method_150(string_11).FirstOrDefault<string>();
    if (string.IsNullOrEmpty(str))
      str = "";
    return str;
  }

  private List<string> method_152(string string_11, string string_12)
  {
    List<string> stringList = new List<string>();
    try
    {
      MatchCollection matchCollection = Regex.Matches(string_11, string_12);
      for (int i = 0; i < matchCollection.Count; ++i)
      {
        if (!string.IsNullOrEmpty(matchCollection[i].Groups[1].Value))
          stringList.Add(matchCollection[i].Groups[1].Value);
      }
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  private bool method_153() => this.CMD("shell settings get global airplane_mode_on").Contains("1");

  private void method_154()
  {
    this.CMD("shell settings put global airplane_mode_on 1");
    this.SleepSeconds(1.0);
    this.CMD("shell su -c am broadcast -a android.intent.action.AIRPLANE_MODE --ez state true");
  }

  private void method_155()
  {
    this.CMD("shell settings put global airplane_mode_on 0");
    this.SleepSeconds(1.0);
    this.CMD("shell su -c am broadcast -a android.intent.action.AIRPLANE_MODE --ez state false");
  }

  public void method_156() => this.CMD("shell su -c 'svc wifi disable'");

  public void method_157() => this.CMD("shell su -c 'svc wifi enable'");

  public void method_158() => this.CMD("shell settings put secure location_mode 0");

  public void method_159() => this.CMD("shell settings put secure location_mode 1");

  internal bool method_160()
  {
    this.RemoveProxy();
    int num = 0;
    while (true)
    {
      if (num < 3)
      {
        if (!this.method_153())
        {
          this.method_154();
          this.SleepSeconds(5.0);
        }
        this.method_155();
        if (!this.method_163(60))
          ++num;
        else
          goto label_7;
      }
      else
        break;
    }
    return false;
label_7:
    return true;
  }

  public bool method_161()
  {
    string str = "";
    for (int index = 0; index < 100; ++index)
    {
      str = this.CMD("shell \"dumpsys power | grep 'Display Power' | grep -oE '(ON|OFF)'\"");
      if (str != "")
        break;
    }
    return str == "OFF";
  }

  public string method_162(int int_4 = 10, int int_5 = 0)
  {
    string string_11 = !(this.string_8 != "") || int_5 != 0 ? "shell curl -s -H 'Cache-Control: no-cache' ifconfig.co" : "shell curl -s -H 'Cache-Control: no-cache' ifconfig.co -x \"" + this.string_8 + "\"";
    int tickCount = Environment.TickCount;
    string str;
    do
    {
      str = this.CMD(string_11);
      if (!str.Contains("you have authenticated yourself"))
      {
        if (str.Contains("html"))
          str = "";
        this.SleepSeconds(1.0);
      }
      else
        goto label_5;
    }
    while (str == "" && Environment.TickCount - tickCount < int_4 * 1000);
    goto label_6;
label_5:
    str = "Proxy Authentication Required";
label_6:
    return str;
  }

  public bool method_163(int int_4 = 15)
  {
    int tickCount = Environment.TickCount;
    while (!(this.CMD("shell curl -s -H 'Cache-Control: no-cache' \"google.com\"") != ""))
    {
      this.SleepSeconds(2.0);
      if (Environment.TickCount - tickCount >= int_4 * 1000)
        return false;
    }
    return true;
  }

  public void method_164(string string_11 = "https://ifconfig.co/") => this.CMD("shell am start -a android.intent.action.VIEW -d \"" + string_11 + "\"");

  public string method_165()
  {
    string input = "";
    try
    {
      for (int index = 0; index < 3; ++index)
      {
        try
        {
          input = this.CMD("shell \"uiautomator dump && cat /sdcard/window_dump.xml && rm /sdcard/window_dump.xml\"").ToLower();
          input = Regex.Match(input, "<\\?xml(.*?)</hierarchy>").Value;
          if (!(input.Trim() != ""))
            Thread.Sleep(1000);
          else
            break;
        }
        catch
        {
        }
      }
    }
    catch
    {
    }
    return input;
  }

  public string method_166()
  {
    string input = "";
    try
    {
      for (int index = 0; index < 3; ++index)
      {
        try
        {
          input = this.CMD("shell \"dumpsys activity | grep top-activity\"").ToLower();
          input = Regex.Match(input, "com(.*?)/").Value.TrimEnd('/');
          if (!(input.Trim() != ""))
            Thread.Sleep(1000);
          else
            break;
        }
        catch
        {
        }
      }
    }
    catch
    {
    }
    return input;
  }

  public string method_167(string string_11)
  {
    string str = "";
    try
    {
      for (int index = 0; index < 3; ++index)
      {
        try
        {
          str = this.CMD("shell \"dumpsys package " + string_11 + " | grep versionName\"").ToLower();
          str = str.Split('=')[1];
          if (!(str.Trim() != ""))
            Thread.Sleep(1000);
          else
            break;
        }
        catch
        {
        }
      }
    }
    catch
    {
    }
    return str;
  }

  public void method_168(string string_11)
  {
  }

  internal bool method_169(int int_4)
  {
    this.CMD("shell am start -a android.settings.NETWORK_OPERATOR_SETTINGS");
    int tickCount = Environment.TickCount;
    int num1 = 300;
    bool flag = false;
    int num2 = 0;
    int num3 = 2;
    while (!this.bool_1)
    {
      string str1 = this.method_53();
      string str2 = this.method_29(0, str1, new List<string>()
      {
        "//android.widget.TextView[@text='Advanced']",
        "//android.widget.TextView[@text='Access Point Names']",
        "//android.widget.RadioButton[@resource-id='com.android.settings:id/apn_radiobutton']",
        "//android.widget.CheckedTextView[@class='android.widget.CheckedTextView']",
        "//android.widget.TextView[@text='APN protocol']",
        "//android.widget.TextView[@text='Save']"
      });
      switch (str2)
      {
        case "//android.widget.RadioButton[@resource-id='com.android.settings:id/apn_radiobutton']":
          System.Drawing.Point point = new Class77(this.method_37(0, str1, str2).First<string>()).method_1();
          this.method_55(point.X - 300, point.Y);
          break;
        case "//android.widget.CheckedTextView[@class='android.widget.CheckedTextView']":
          this.method_60(string.Format("({0})[{1}]", (object) str2, (object) int_4), str1);
          flag = true;
          break;
        case "//android.widget.TextView[@text='APN protocol']":
          if (flag)
          {
            this.method_60("//android.widget.ImageButton[@content-desc='More options']");
            break;
          }
          this.method_60(str2, str1);
          break;
        case "//android.widget.TextView[@text='Advanced']":
        case "//android.widget.TextView[@text='Access Point Names']":
          this.method_60(str2, str1);
          break;
        case "//android.widget.TextView[@text='Save']":
          this.method_60(str2, str1);
          return true;
        default:
          if (this.method_78())
          {
            if (num2 >= num3)
              return false;
            ++num2;
            break;
          }
          break;
      }
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= num1 * 1000)
        break;
    }
    return false;
  }

  internal bool method_170()
  {
    this.CMD("shell am start -a android.settings.NETWORK_OPERATOR_SETTINGS");
    int tickCount = Environment.TickCount;
    int num1 = 300;
    int num2 = 0;
    int num3 = 2;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11 = this.method_29(0, str, new List<string>()
      {
        "//*[@text='Preferred network type']"
      });
      if (!(string_11 == "//*[@text='Preferred network type']"))
      {
        if (this.method_78())
        {
          if (num2 >= num3)
            return false;
          ++num2;
        }
      }
      else
      {
        if (this.method_31(0, str, "//android.widget.CheckedTextView[contains(@text,'LTE')]"))
        {
          this.method_76(-1, 4);
          this.SleepSeconds(1.0);
          this.method_76(int_5: this.method_87(0, 4));
          this.method_66(this.method_37(0, "", "//android.widget.CheckedTextView[contains(@text,'LTE')]").smethod_10());
          this.SleepSeconds(1.0);
          return true;
        }
        this.method_60(string_11, str);
      }
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= num1 * 1000)
        break;
    }
    return false;
  }

  internal bool method_171()
  {
    this.CMD("shell am start -a android.settings.ZEN_MODE_PRIORITY_SETTINGS");
    int tickCount = Environment.TickCount;
    int num1 = 300;
    int num2 = 0;
    int num3 = 2;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11 = this.method_29(0, str, new List<string>()
      {
        "//android.widget.Button[@text='Turn on now']",
        "//android.widget.Button[@text='Turn off now']"
      });
      switch (string_11)
      {
        case "//android.widget.Button[@text='Turn on now']":
          this.method_60(string_11, str);
          break;
        case "//android.widget.Button[@text='Turn off now']":
          return true;
        default:
          if (this.method_78())
          {
            if (num2 >= num3)
              return false;
            ++num2;
            break;
          }
          break;
      }
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= num1 * 1000)
        break;
    }
    return false;
  }

  internal List<string> method_172(List<string> list_0)
  {
    List<string> stringList = new List<string>();
    List<string> source1 = new List<string>();
    foreach (string string_0 in list_0)
      source1.Add(new Class77(string_0).int_0.ToString());
    string s = "";
    int num = 0;
    foreach (IGrouping<string, string> source2 in source1.GroupBy<string, string>((Func<string, string>) (string_0 => string_0)))
    {
      if (source2.Count<string>() > num)
      {
        s = source2.Key;
        num = source2.Count<string>();
      }
    }
    foreach (string string_0 in list_0)
    {
      if (new Class77(string_0).int_0 == int.Parse(s))
        stringList.Add(string_0);
    }
    return stringList;
  }

  internal bool method_173()
  {
    this.CMD("shell am start -a android.settings.DISPLAY_SETTINGS");
    int tickCount = Environment.TickCount;
    while (!this.bool_1)
    {
      string str = this.method_53();
      string string_11 = this.method_29(0, str, new List<string>()
      {
        "//android.widget.Switch[@content-desc='Dark theme'][@text='ON']",
        "//android.widget.Switch[@content-desc='Dark theme'][@text='OFF']"
      });
      switch (string_11)
      {
        case "//android.widget.Switch[@content-desc='Dark theme'][@text='OFF']":
          this.method_60(string_11, str);
          break;
        case "//android.widget.Switch[@content-desc='Dark theme'][@text='ON']":
          return true;
      }
      this.SleepSeconds(1.0);
      if (Environment.TickCount - tickCount >= 60000)
        break;
    }
    return false;
  }

  internal string method_174()
  {
    string input = this.CMD("shell dumpsys display");
    return Regex.Match(Regex.Match(input, "deviceWidth=\\d+").Value, "\\d+").Value + "x" + Regex.Match(Regex.Match(input, "deviceHeight=\\d+").Value, "\\d+").Value;
  }

  public List<string> method_175()
  {
    List<string> stringList = new List<string>();
    string str = this.CMD("shell pm list packages").Replace("package:", "").Trim();
    if (str != "" && str != "not found emulator!")
      stringList = ((IEnumerable<string>) str.Split('\n')).ToList<string>();
    return stringList;
  }

  public List<string> method_176()
  {
    List<string> stringList = new List<string>();
    string str = this.CMD("shell pm list packages -3").Replace("package:", "").Trim();
    if (str != "" && str != "not found emulator!")
      stringList = ((IEnumerable<string>) str.Split('\n')).ToList<string>();
    return stringList;
  }

  public bool method_177(string string_11)
  {
    this.CMD("shell settings put global verifier_verify_adb_installs 0");
    this.CMD("install \"" + string_11 + "\"", 120);
    return true;
  }

  public bool method_178(string string_11 = "")
  {
    try
    {
      string string2 = this.String_2;
      if (string_11 == "")
        string_11 = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
      string string_0 = "CheckDevice";
      GClass19.smethod_34(string_0);
      GClass19.smethod_34(string_0 + "\\" + string2);
      this.method_130().Save(string_0 + "\\" + string2 + "\\" + string_11 + ".png");
      System.IO.File.AppendAllText(string_0 + "\\" + string2 + "\\" + string_11 + ".txt", this.method_22() + "\r\n");
      System.IO.File.AppendAllText(string_0 + "\\" + string2 + "\\" + string_11 + ".txt", this.method_53());
      return true;
    }
    catch
    {
    }
    return false;
  }

  public void method_179(string string_11 = "")
  {
    if (string_11 == "")
      string_11 = this.method_53();
    this.string_10 = string_11;
  }

  public bool method_180(int int_4, ref string string_11)
  {
    int tickCount = Environment.TickCount;
    while (!this.bool_1)
    {
      if (string_11 == "")
        string_11 = this.method_53();
      if (this.string_10 != string_11)
        return true;
      if (int_4 != 0)
      {
        this.SleepSeconds(1.0);
        string_11 = "";
        if (Environment.TickCount - tickCount >= int_4 * 1000)
          break;
      }
      else
        break;
    }
    return false;
  }

  public bool method_181(int int_4 = 0, string string_11 = "") => this.method_180(int_4, ref string_11);

  public enum GEnum10
  {
    const_0 = 0,
    const_1 = 1,
    const_2 = 2,
    const_3 = 3,
    const_4 = 4,
    const_5 = 5,
    const_6 = 6,
    const_7 = 7,
    const_8 = 8,
    const_9 = 9,
    const_10 = 10, // 0x0000000A
    const_11 = 11, // 0x0000000B
    const_12 = 12, // 0x0000000C
    const_13 = 13, // 0x0000000D
    const_14 = 14, // 0x0000000E
    const_15 = 15, // 0x0000000F
    const_16 = 16, // 0x00000010
    const_17 = 17, // 0x00000011
    const_18 = 18, // 0x00000012
    const_19 = 19, // 0x00000013
    const_20 = 20, // 0x00000014
    const_21 = 21, // 0x00000015
    const_22 = 22, // 0x00000016
    const_23 = 23, // 0x00000017
    const_24 = 24, // 0x00000018
    const_25 = 25, // 0x00000019
    const_26 = 26, // 0x0000001A
    const_27 = 27, // 0x0000001B
    const_28 = 28, // 0x0000001C
    const_29 = 29, // 0x0000001D
    const_30 = 30, // 0x0000001E
    const_31 = 31, // 0x0000001F
    const_32 = 32, // 0x00000020
    const_33 = 33, // 0x00000021
    const_34 = 34, // 0x00000022
    const_35 = 35, // 0x00000023
    const_36 = 36, // 0x00000024
    const_37 = 37, // 0x00000025
    const_38 = 38, // 0x00000026
    const_39 = 39, // 0x00000027
    const_40 = 40, // 0x00000028
    const_41 = 41, // 0x00000029
    const_42 = 42, // 0x0000002A
    const_43 = 43, // 0x0000002B
    const_44 = 44, // 0x0000002C
    const_45 = 45, // 0x0000002D
    const_46 = 46, // 0x0000002E
    const_47 = 47, // 0x0000002F
    const_48 = 48, // 0x00000030
    const_49 = 49, // 0x00000031
    const_50 = 50, // 0x00000032
    const_51 = 51, // 0x00000033
    const_52 = 52, // 0x00000034
    const_53 = 53, // 0x00000035
    const_54 = 54, // 0x00000036
    const_55 = 55, // 0x00000037
    const_56 = 56, // 0x00000038
    const_57 = 57, // 0x00000039
    const_58 = 58, // 0x0000003A
    const_59 = 59, // 0x0000003B
    const_60 = 60, // 0x0000003C
    const_61 = 61, // 0x0000003D
    const_62 = 62, // 0x0000003E
    const_63 = 63, // 0x0000003F
    const_64 = 64, // 0x00000040
    const_65 = 65, // 0x00000041
    const_66 = 66, // 0x00000042
    const_67 = 67, // 0x00000043
    const_68 = 68, // 0x00000044
    const_69 = 69, // 0x00000045
    const_70 = 70, // 0x00000046
    const_71 = 71, // 0x00000047
    const_72 = 72, // 0x00000048
    const_73 = 73, // 0x00000049
    const_74 = 74, // 0x0000004A
    const_75 = 75, // 0x0000004B
    const_76 = 76, // 0x0000004C
    const_77 = 77, // 0x0000004D
    const_78 = 78, // 0x0000004E
    const_79 = 79, // 0x0000004F
    const_80 = 80, // 0x00000050
    const_81 = 81, // 0x00000051
    const_82 = 82, // 0x00000052
    const_83 = 83, // 0x00000053
    const_85 = 164, // 0x000000A4
    const_84 = 187, // 0x000000BB
  }
}
