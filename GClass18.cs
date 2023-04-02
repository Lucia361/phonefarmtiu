// Decompiled with JetBrains decompiler
// Type: GClass18
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;

public class GClass18
{
  public int int_0;
  private Random random_0;

  public Process Process_0 { get; set; }

  public ChromeDriver ChromeDriver_0 { get; set; }

  public bool Boolean_0 { get; set; }

  public bool Boolean_1 { get; set; }

  public bool Boolean_2 { get; set; }

  public bool Boolean_3 { get; set; }

  public bool Boolean_4 { get; set; }

  public string String_0 { get; set; }

  public int Int32_0 { get; set; }

  public string String_1 { get; set; }

  public Point Point_0 { get; set; }

  public Point Point_1 { get; set; }

  public int Int32_1 { get; set; }

  public int Int32_2 { get; set; }

  public string String_2 { get; set; }

  public int Int32_3 { get; set; }

  public string String_3 { get; set; }

  public string String_4 { get; set; }

  public string String_5 { get; set; }

  public bool Boolean_5 { get; set; }

  public bool Boolean_6 { get; set; }

  public string String_6 { get; set; }

  public Point Point_2 { get; set; }

  public GEnum11 GEnum11_0 { get; set; }

  public GClass18()
  {
    this.int_0 = 0;
    this.Boolean_0 = false;
    this.Boolean_2 = false;
    this.Boolean_3 = false;
    this.Boolean_1 = false;
    this.String_0 = "";
    this.String_1 = "";
    this.Point_0 = new Point(300, 300);
    Point point0 = this.Point_0;
    int x1 = point0.X;
    point0 = this.Point_0;
    int y1 = point0.Y;
    this.Point_0 = new Point(x1, y1);
    this.String_2 = "";
    this.Int32_3 = 0;
    Point point1 = this.Point_1;
    int x2 = point1.X;
    point1 = this.Point_1;
    int y2 = point1.Y;
    this.Point_1 = new Point(x2, y2);
    this.Int32_1 = 0;
    this.Int32_2 = 5;
    this.String_3 = "";
    this.Boolean_4 = false;
    this.String_4 = "";
    this.String_5 = "data\\extension";
    this.Boolean_5 = false;
    this.Point_2 = new Point(300, 300);
    this.GEnum11_0 = GEnum11.const_0;
    this.Boolean_6 = false;
    this.String_6 = "";
    this.random_0 = new Random();
  }

  public bool method_0()
  {
    bool flag1 = false;
    try
    {
      ChromeDriverService defaultService = ChromeDriverService.CreateDefaultService();
      defaultService.HideCommandPromptWindow = true;
      ChromeOptions options = new ChromeOptions();
      options.AddArguments("--disable-3d-apis", "--disable-background-networking", "--disable-bundled-ppapi-flash", "--disable-client-side-phishing-detection", "--disable-default-apps", "--disable-hang-monitor", "--disable-prompt-on-repost", "--disable-sync", "--disable-webgl", "--enable-blink-features=ShadowDOMV0", "--enable-logging", "--disable-notifications", "--window-size=" + this.Point_0.X.ToString() + "," + this.Point_0.Y.ToString(), "--window-position=" + this.Point_1.X.ToString() + "," + this.Point_1.Y.ToString(), "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-blink-features=\"BlockCredentialedSubresources\"", "--disable-popup-blocking");
      options.AddUserProfilePreference("profile.default_content_setting_values.geolocation", (object) 0);
      if (this.Boolean_3)
        options.AddArgument("--mute-audio");
      if (this.String_4 != "" && File.Exists(this.String_4))
        options.BinaryLocation = this.String_4;
      if (this.Boolean_6)
      {
        if (!string.IsNullOrEmpty(this.String_1.Trim()))
        {
          if (!Directory.Exists(this.String_1))
            ZipFile.ExtractToDirectory(this.String_6, this.String_1);
          options.BinaryLocation = this.String_1 + "\\App\\Chrome-bin\\chrome.exe";
          if (!this.Boolean_0)
          {
            if (this.Boolean_2)
              options.AddArgument("--blink-settings=imagesEnabled=false");
            options.AddArgument("--user-data-dir=" + this.String_1 + "\\Data\\profile");
          }
          else
          {
            options.AddArgument("--blink-settings=imagesEnabled=false");
            options.AddArgument("--headless");
          }
        }
      }
      else if (!this.Boolean_0)
      {
        if (this.Boolean_2)
          options.AddArgument("--blink-settings=imagesEnabled=false");
        if (!string.IsNullOrEmpty(this.String_1.Trim()))
          options.AddArgument("--user-data-dir=" + this.String_1);
      }
      else
      {
        options.AddArgument("--blink-settings=imagesEnabled=false");
        options.AddArgument("--headless");
      }
      if (this.Boolean_1)
        options.AddArguments("--incognito");
      if (!string.IsNullOrEmpty(this.String_2.Trim()))
      {
        switch (((IEnumerable<string>) this.String_2.Split(':')).Count<string>())
        {
          case 1:
            if (this.Int32_3 == 0)
            {
              options.AddArgument("--proxy-server= 127.0.0.1:" + this.String_2);
              break;
            }
            options.AddArgument("--proxy-server= socks5://127.0.0.1:" + this.String_2);
            break;
          case 2:
            if (this.Int32_3 == 0)
            {
              options.AddArgument("--proxy-server= " + this.String_2);
              break;
            }
            options.AddArgument("--proxy-server= socks5://" + this.String_2);
            break;
          case 4:
            if (this.Int32_3 == 0)
            {
              options.AddArgument("--proxy-server= " + this.String_2.Split(':')[0] + ":" + this.String_2.Split(':')[1]);
              options.AddExtension("extension\\proxy.crx");
              break;
            }
            options.AddArgument("--proxy-server= socks5://" + this.String_2.Split(':')[0] + ":" + this.String_2.Split(':')[1]);
            options.AddExtension("extension\\proxy.crx");
            break;
        }
      }
      bool flag2 = false;
      if (!this.Boolean_0 && this.String_5.Trim() != "")
      {
        if (!Directory.Exists(this.String_5))
          Directory.CreateDirectory(this.String_5);
        string[] files = Directory.GetFiles(this.String_5);
        if (files.Length != 0)
          flag2 = true;
        for (int index = 0; index < files.Length; ++index)
          options.AddExtension(files[index]);
      }
      if (!flag2 && !string.IsNullOrEmpty(this.String_3.Trim()))
        options.AddArgument("--app= " + this.String_3);
      if (this.String_0 != "")
      {
        if (((IEnumerable<string>) this.String_2.Split(':')).Count<string>() == 4)
          options.AddArgument("--user-agent=" + this.String_0 + "$PC$" + this.String_2.Split(':')[2] + ":" + this.String_2.Split(':')[3]);
        else
          options.AddArgument("--user-agent=" + this.String_0);
      }
      if (this.Boolean_5)
      {
        ChromeMobileEmulationDeviceSettings deviceSettings = new ChromeMobileEmulationDeviceSettings()
        {
          EnableTouchEvents = true,
          Width = (long) this.Point_2.X,
          Height = (long) this.Point_2.Y,
          UserAgent = this.String_0,
          PixelRatio = (double) this.Int32_0
        };
        options.EnableMobileEmulation(deviceSettings);
      }
      if (this.Boolean_4)
        options.AddArgument("--autoplay-policy=no-user-gesture-required");
      this.ChromeDriver_0 = new ChromeDriver(defaultService, options);
      this.ChromeDriver_0.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds((double) this.Int32_1);
      this.ChromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes((double) this.Int32_2);
      return true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.Open()");
      return flag1;
    }
  }

  public string method_1()
  {
    if (!this.method_2())
      return "-2";
    try
    {
      return this.ChromeDriver_0.PageSource;
    }
    catch
    {
    }
    return "";
  }

  public bool method_2() => !this.method_3();

  public bool method_3()
  {
    if (this.Process_0 != null)
      return this.Process_0.HasExited;
    bool flag = true;
    try
    {
      string title = this.ChromeDriver_0.Title;
      flag = false;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.CheckChromeClosed()");
    }
    return flag;
  }

  public bool method_4(string string_7, string string_8, string string_9 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string string_10 = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
  {
    bool flag = false;
    try
    {
      GClass19.smethod_25(string_7, string_8, string_10, "--user-data-dir=\"" + this.String_1 + "\"", string_10.Substring(0, string_10.LastIndexOf("\\")), string_9);
      return flag;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.CreateShortcut(" + string_7 + "," + string_8 + "," + string_10 + ")");
      return flag;
    }
  }

  public string method_5(string string_7, string string_8, string string_9)
  {
    string str = "";
    if (!this.method_2())
      return "-2";
    try
    {
      str = this.ChromeDriver_0.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + string_7 + "','" + string_8 + "','" + string_9 + "')", Array.Empty<object>()).ToString();
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.GetCssSelector(" + string_7 + "," + string_8 + "," + string_9 + ")");
    }
    return str;
  }

  public string method_6(string string_7)
  {
    string str = "";
    if (!this.method_2())
      return "-2";
    try
    {
      str = this.ChromeDriver_0.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; return GetSelector(" + string_7 + ")", Array.Empty<object>()).ToString();
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.GetCssSelector(" + string_7 + ")");
    }
    return str;
  }

  public string method_7(string string_7, string string_8)
  {
    string str = "";
    if (!this.method_2())
      return "-2";
    try
    {
      str = this.ChromeDriver_0.ExecuteScript("return document.querySelector('" + string_7 + "').getAttribute('" + string_8 + "')", Array.Empty<object>()).ToString();
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.GetAttributeValue(" + string_7 + "," + string_8 + ")");
    }
    return str;
  }

  public int method_8(int int_5)
  {
    if (!this.method_2())
      return -2;
    try
    {
      int int32 = Convert.ToInt32(this.ChromeDriver_0.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''", Array.Empty<object>()).ToString());
      this.ChromeDriver_0.ExecuteScript("window.scrollBy({ top: " + int_5.ToString() + ",behavior: 'smooth'});", Array.Empty<object>());
      this.method_56(0.1);
      if (int32 == Convert.ToInt32(this.ChromeDriver_0.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''", Array.Empty<object>()).ToString()))
        return 2;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.ScrollSmooth({0})", (object) int_5));
    }
    return 1;
  }

  public string method_9()
  {
    string str = "";
    if (!this.method_2())
      return "-2";
    try
    {
      str = this.ChromeDriver_0.ExecuteScript("return navigator.userAgent", Array.Empty<object>()).ToString();
    }
    catch
    {
    }
    return str;
  }

  public int method_10(int int_5, string string_7)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementById(string_7).SendKeys(Keys.ArrowDown);
          break;
        case 2:
          this.ChromeDriver_0.FindElementByName(string_7).SendKeys(Keys.ArrowDown);
          break;
        case 3:
          this.ChromeDriver_0.FindElementByXPath(string_7).SendKeys(Keys.ArrowDown);
          break;
        case 4:
          this.ChromeDriver_0.FindElementByCssSelector(string_7).SendKeys(Keys.ArrowDown);
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendKeyDown({0},{1})", (object) int_5, (object) string_7));
    }
    return flag ? 1 : 0;
  }

  public string method_11()
  {
    if (!this.method_2())
      return "-2";
    try
    {
      return this.ChromeDriver_0.Url;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.GetURL()");
    }
    return "";
  }

  public int method_12(string string_7)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.Navigate().GoToUrl(string_7);
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.GotoURL(" + string_7 + ")");
    }
    return flag ? 1 : 0;
  }

  public int method_13(int int_5)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      switch (int_5)
      {
        case 1:
          this.method_12("https://www.facebook.com/login");
          break;
        case 2:
          this.method_12("https://m.facebook.com/login");
          break;
        case 3:
          this.method_12("https://mbasic.facebook.com/login");
          break;
      }
      flag = true;
      this.method_56(1.0);
    }
    catch (Exception ex)
    {
    }
    return flag ? 1 : 0;
  }

  public int method_14(string string_7)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      if (this.method_11() != string_7)
        this.ChromeDriver_0.Navigate().GoToUrl(string_7);
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.GotoURL(" + string_7 + ")");
    }
    return flag ? 1 : 0;
  }

  public int method_15()
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.Navigate().Refresh();
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.Refresh()");
    }
    return flag ? 1 : 0;
  }

  public int method_16(int int_5 = 1)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      for (int index = 0; index < int_5; ++index)
      {
        this.ChromeDriver_0.Navigate().Back();
        this.method_56(0.5);
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.GotoBackPage()");
    }
    return flag ? 1 : 0;
  }

  public int method_17(int int_5, string string_7, int int_6, double double_0)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      WebDriverWait webDriverWait = new WebDriverWait((IWebDriver) this.ChromeDriver_0, TimeSpan.FromSeconds(10.0));
      switch (int_5)
      {
        case 1:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(this.ChromeDriver_0.FindElementsById(string_7)[int_6]).Perform();
          break;
        case 2:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(this.ChromeDriver_0.FindElementsByName(string_7)[int_6]).Perform();
          break;
        case 3:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6]).Perform();
          break;
        case 4:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6]).Perform();
          break;
      }
      Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.HoverElement({0}, {1}, {2})", (object) int_5, (object) string_7, (object) double_0));
    }
    return flag ? 1 : 0;
  }

  public int method_18(int int_5, string string_7, double double_0)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      WebDriverWait webDriverWait = new WebDriverWait((IWebDriver) this.ChromeDriver_0, TimeSpan.FromSeconds(10.0));
      switch (int_5)
      {
        case 1:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(webDriverWait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.Id(string_7)))).Perform();
          break;
        case 2:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(webDriverWait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.Name(string_7)))).Perform();
          break;
        case 3:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(webDriverWait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.XPath(string_7)))).Perform();
          break;
        case 4:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(webDriverWait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.CssSelector(string_7)))).Perform();
          break;
      }
      Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.HoverElement({0}, {1}, {2})", (object) int_5, (object) string_7, (object) double_0));
    }
    return flag ? 1 : 0;
  }

  public bool method_19(int int_5, string string_7, int int_6)
  {
    bool flag = true;
    try
    {
      switch (int_5)
      {
        case 1:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(this.ChromeDriver_0.FindElementsById(string_7)[int_6]).Build().Perform();
          break;
        case 2:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(this.ChromeDriver_0.FindElementsByName(string_7)[int_6]).Build().Perform();
          break;
        case 3:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6]).Build().Perform();
          break;
        case 4:
          new Actions((IWebDriver) this.ChromeDriver_0).MoveToElement(this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6]).Build().Perform();
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.MoveToElement({0},{1},{2})", (object) int_5, (object) string_7, (object) int_6));
      return flag;
    }
  }

  public object method_20(string string_7)
  {
    if (!this.method_2())
      return (object) -2;
    try
    {
      return this.ChromeDriver_0.ExecuteScript(string_7, Array.Empty<object>());
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.ExecuteScript(" + string_7 + ")");
    }
    return (object) "";
  }

  public int method_21(
    int int_5,
    string string_7,
    int int_6 = 0,
    int int_7 = 0,
    string string_8 = "",
    int int_8 = 0,
    int int_9 = 1)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    for (int index = 0; index < int_9; ++index)
    {
      try
      {
        if (int_7 == 0)
        {
          switch (int_5)
          {
            case 1:
              this.ChromeDriver_0.FindElementsById(string_7)[int_6].Click();
              break;
            case 2:
              this.ChromeDriver_0.FindElementsByName(string_7)[int_6].Click();
              break;
            case 3:
              this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6].Click();
              break;
            case 4:
              this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6].Click();
              break;
          }
        }
        else
        {
          switch (int_5)
          {
            case 1:
              this.ChromeDriver_0.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8].Click();
              break;
            case 2:
              this.ChromeDriver_0.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8].Click();
              break;
            case 3:
              this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8].Click();
              break;
            case 4:
              this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8].Click();
              break;
          }
        }
        flag = true;
        break;
      }
      catch (Exception ex)
      {
        GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.Click({0},{1})", (object) int_5, (object) string_7));
      }
      this.method_56(1.0);
    }
    return flag ? 1 : 0;
  }

  public int method_22(
    double double_0,
    int int_5,
    string string_7,
    int int_6 = 0,
    int int_7 = 0,
    string string_8 = "",
    int int_8 = 0)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      int tickCount = Environment.TickCount;
      while (true)
      {
        try
        {
          if (int_7 == 0)
          {
            switch (int_5)
            {
              case 1:
                this.ChromeDriver_0.FindElementsById(string_7)[int_6].Click();
                break;
              case 2:
                this.ChromeDriver_0.FindElementsByName(string_7)[int_6].Click();
                break;
              case 3:
                this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6].Click();
                break;
              case 4:
                this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6].Click();
                break;
            }
          }
          else
          {
            switch (int_5)
            {
              case 1:
                this.ChromeDriver_0.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8].Click();
                break;
              case 2:
                this.ChromeDriver_0.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8].Click();
                break;
              case 3:
                this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8].Click();
                break;
              case 4:
                this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8].Click();
                break;
            }
          }
          flag = true;
          this.method_56(1.0);
          break;
        }
        catch (Exception ex)
        {
        }
        if ((double) (Environment.TickCount - tickCount) < double_0 * 1000.0)
          this.method_56(1.0);
        else
          break;
      }
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.FindAndClick({0},{1},{2},{3},{4},{5},{6}", (object) double_0, (object) int_5, (object) string_7, (object) int_6, (object) int_7, (object) string_8, (object) int_8));
    }
    return flag ? 1 : 0;
  }

  public int method_23(
    int int_5,
    string string_7,
    int int_6 = 0,
    int int_7 = 0,
    string string_8 = "",
    int int_8 = 0)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      if (int_7 != 0)
      {
        switch (int_5)
        {
          case 1:
            new Actions((IWebDriver) this.ChromeDriver_0).Click(this.ChromeDriver_0.FindElementsById(string_7)[int_6].FindElements(By.Id(string_8))[int_8]).Perform();
            break;
          case 2:
            new Actions((IWebDriver) this.ChromeDriver_0).Click(this.ChromeDriver_0.FindElementsByName(string_7)[int_6].FindElements(By.Name(string_8))[int_8]).Perform();
            break;
          case 3:
            new Actions((IWebDriver) this.ChromeDriver_0).Click(this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6].FindElements(By.XPath(string_8))[int_8]).Perform();
            break;
          case 4:
            new Actions((IWebDriver) this.ChromeDriver_0).Click(this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6].FindElements(By.CssSelector(string_8))[int_8]).Perform();
            break;
        }
      }
      else
      {
        switch (int_5)
        {
          case 1:
            new Actions((IWebDriver) this.ChromeDriver_0).Click(this.ChromeDriver_0.FindElementsById(string_7)[int_6]).Perform();
            break;
          case 2:
            new Actions((IWebDriver) this.ChromeDriver_0).Click(this.ChromeDriver_0.FindElementsByName(string_7)[int_6]).Perform();
            break;
          case 3:
            new Actions((IWebDriver) this.ChromeDriver_0).Click(this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6]).Perform();
            break;
          case 4:
            new Actions((IWebDriver) this.ChromeDriver_0).Click(this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6]).Perform();
            break;
        }
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.ClickWithAction({0},{1})", (object) int_5, (object) string_7));
    }
    return flag ? 1 : 0;
  }

  public int method_24(int int_5, string string_7, string string_8, bool bool_7 = true, double double_0 = 0.1)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      if (bool_7)
      {
        this.method_21(int_5, string_7);
        this.method_56(double_0);
      }
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementById(string_7).SendKeys(string_8);
          break;
        case 2:
          this.ChromeDriver_0.FindElementByName(string_7).SendKeys(string_8);
          break;
        case 3:
          this.ChromeDriver_0.FindElementByXPath(string_7).SendKeys(string_8);
          break;
        case 4:
          this.ChromeDriver_0.FindElementByCssSelector(string_7).SendKeys(string_8);
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendKeys({0},{1},{2},{3})", (object) int_5, (object) string_7, (object) string_8, (object) bool_7));
    }
    return flag ? 1 : 0;
  }

  public int method_25(
    int int_5,
    string string_7,
    int int_6,
    string string_8,
    bool bool_7 = true,
    double double_0 = 0.1)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      if (bool_7)
      {
        this.method_21(int_5, string_7);
        this.method_56(double_0);
      }
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementsById(string_7)[int_6].SendKeys(string_8);
          break;
        case 2:
          this.ChromeDriver_0.FindElementsByName(string_7)[int_6].SendKeys(string_8);
          break;
        case 3:
          this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6].SendKeys(string_8);
          break;
        case 4:
          this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6].SendKeys(string_8);
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendKeys({0},{1},{2},{3})", (object) int_5, (object) string_7, (object) string_8, (object) bool_7));
    }
    return flag ? 1 : 0;
  }

  public int method_26(
    int int_5,
    string string_7,
    string string_8,
    double double_0,
    bool bool_7 = true,
    double double_1 = 0.1)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      if (bool_7)
      {
        this.method_21(int_5, string_7);
        this.method_56(double_1);
      }
      for (int index = 0; index < string_8.Length; ++index)
      {
        switch (int_5)
        {
          case 1:
            this.ChromeDriver_0.FindElementById(string_7).SendKeys(string_8[index].ToString());
            break;
          case 2:
            this.ChromeDriver_0.FindElementByName(string_7).SendKeys(string_8[index].ToString());
            break;
          case 3:
            this.ChromeDriver_0.FindElementByXPath(string_7).SendKeys(string_8[index].ToString());
            break;
          case 4:
            this.ChromeDriver_0.FindElementByCssSelector(string_7).SendKeys(string_8[index].ToString());
            break;
        }
        if (double_0 > 0.0)
        {
          int minValue = Convert.ToInt32(double_0 * 1000.0);
          if (minValue < 100)
            minValue = 100;
          Thread.Sleep(Class54.random_0.Next(minValue, minValue + 50));
        }
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendKeys({0},{1},{2},{3},{4})", (object) int_5, (object) string_7, (object) string_8, (object) double_0, (object) bool_7));
    }
    return flag ? 1 : 0;
  }

  public int method_27(
    int int_5,
    string string_7,
    int int_6,
    string string_8,
    double double_0,
    bool bool_7 = true,
    double double_1 = 0.1)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      if (bool_7)
      {
        this.method_21(int_5, string_7);
        this.method_56(double_1);
      }
      for (int index = 0; index < string_8.Length; ++index)
      {
        char ch;
        switch (int_5)
        {
          case 1:
            IWebElement webElement1 = this.ChromeDriver_0.FindElementsById(string_7)[int_6];
            ch = string_8[index];
            string text1 = ch.ToString();
            webElement1.SendKeys(text1);
            break;
          case 2:
            IWebElement webElement2 = this.ChromeDriver_0.FindElementsByName(string_7)[int_6];
            ch = string_8[index];
            string text2 = ch.ToString();
            webElement2.SendKeys(text2);
            break;
          case 3:
            IWebElement webElement3 = this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6];
            ch = string_8[index];
            string text3 = ch.ToString();
            webElement3.SendKeys(text3);
            break;
          case 4:
            IWebElement webElement4 = this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6];
            ch = string_8[index];
            string text4 = ch.ToString();
            webElement4.SendKeys(text4);
            break;
        }
        if (double_0 > 0.0)
        {
          int minValue = Convert.ToInt32(double_0 * 1000.0);
          if (minValue < 100)
            minValue = 100;
          Thread.Sleep(Class54.random_0.Next(minValue, minValue + 50));
        }
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendKeys({0},{1},{2},{3},{4})", (object) int_5, (object) string_7, (object) string_8, (object) double_0, (object) bool_7));
    }
    return flag ? 1 : 0;
  }

  public int method_28(
    Random random_1,
    int int_5,
    string string_7,
    string string_8,
    double double_0,
    bool bool_7 = true,
    double double_1 = 0.1)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      if (bool_7)
      {
        this.method_21(int_5, string_7);
        this.method_56(double_1);
      }
      int num1 = random_1.Next(1, 1000) % 3;
      if (string_8.Length >= 3)
      {
        int num2 = random_1.Next(1, string_8.Length * 3 / 4);
        switch (num1)
        {
          case 0:
            string string_8_1 = string_8.Substring(0, num2);
            this.method_26(int_5, string_7, string_8_1, Convert.ToDouble(random_1.Next(10, 100)) / 1000.0);
            this.method_56((double) random_1.Next(1, 3));
            int num3 = random_1.Next(1, num2);
            for (int index = 0; index < num3; ++index)
            {
              this.method_30(int_5, string_7);
              this.method_56(Convert.ToDouble(random_1.Next(1000, 2000)) / 10000.0);
            }
            string str = "";
            switch (int_5)
            {
              case 1:
                str = "#" + string_7;
                break;
              case 2:
                str = "[name=\"" + string_7 + "\"]";
                break;
              case 4:
                str = string_7;
                break;
            }
            string string_8_2 = string_8.Substring(this.ChromeDriver_0.ExecuteScript("return document.querySelector('" + str + "').value+''", Array.Empty<object>()).ToString().Length);
            this.method_56((double) random_1.Next(1, 3));
            this.method_26(int_5, string_7, string_8_2, Convert.ToDouble(random_1.Next(100, 300)) / 1000.0, false);
            this.method_56((double) random_1.Next(1, 3));
            goto label_17;
          case 1:
            string string_8_3 = string_8.Substring(0, num2);
            string string_8_4 = string_8.Substring(num2);
            this.method_26(int_5, string_7, string_8_3, Convert.ToDouble(random_1.Next(10, 100)) / 1000.0);
            this.method_56((double) random_1.Next(1, 3));
            this.method_26(int_5, string_7, string_8_4, Convert.ToDouble(random_1.Next(100, 300)) / 1000.0, false);
            this.method_56((double) random_1.Next(1, 3));
            goto label_17;
          case 2:
            break;
          default:
            goto label_17;
        }
      }
      this.method_26(int_5, string_7, string_8, Convert.ToDouble(random_1.Next(100, 200)) / 1000.0);
      this.method_56((double) random_1.Next(1, 3));
label_17:
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendKeys({0},{1},{2},{3},{4})", (object) int_5, (object) string_7, (object) string_8, (object) double_0, (object) bool_7));
    }
    return flag ? 1 : 0;
  }

  public int method_29(
    int int_5,
    int int_6,
    string string_7,
    string string_8,
    double double_0,
    bool bool_7 = true,
    double double_1 = 0.1)
  {
    if (!this.method_2())
      return -2;
    int num = 0;
    switch (int_5)
    {
      case 0:
        num = this.method_28(Class54.random_0, int_6, string_7, string_8, double_0, bool_7, double_1);
        break;
      case 1:
        num = this.method_26(int_6, string_7, string_8, double_0, bool_7, double_1);
        break;
      case 2:
        num = this.method_24(int_6, string_7, string_8, bool_7, double_1);
        break;
    }
    return num;
  }

  public int method_30(int int_5, string string_7)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementById(string_7).SendKeys(Keys.Backspace);
          break;
        case 2:
          this.ChromeDriver_0.FindElementByName(string_7).SendKeys(Keys.Backspace);
          break;
        case 3:
          this.ChromeDriver_0.FindElementByXPath(string_7).SendKeys(Keys.Backspace);
          break;
        case 4:
          this.ChromeDriver_0.FindElementByCssSelector(string_7).SendKeys(Keys.Backspace);
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendBackspace({0},{1})", (object) int_5, (object) string_7));
    }
    return flag ? 1 : 0;
  }

  public void method_31(int int_5 = 0, Random random_1 = null)
  {
    if (random_1 == null)
      random_1 = new Random();
    this.method_56((double) random_1.Next(int_5 + 1, int_5 + 4));
  }

  public void method_32(int int_5, int int_6) => this.method_56((double) Class54.random_0.Next(int_5, int_6 + 1));

  public int method_33(int int_5, string string_7, int int_6)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementsById(string_7)[int_6].SendKeys(Keys.Enter);
          break;
        case 2:
          this.ChromeDriver_0.FindElementsByTagName(string_7)[int_6].SendKeys(Keys.Enter);
          break;
        case 3:
          this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6].SendKeys(Keys.Enter);
          break;
        case 4:
          this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6].SendKeys(Keys.Enter);
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendEnter({0},{1},{2})", (object) int_5, (object) string_7, (object) int_6));
    }
    return flag ? 1 : 0;
  }

  public int method_34(int int_5, string string_7, int int_6 = 0, bool bool_7 = true, int int_7 = 0)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      if (bool_7)
      {
        this.method_21(int_5, string_7);
        Thread.Sleep(Convert.ToInt32(int_7 * 1000));
      }
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementsById(string_7)[int_6].SendKeys(Keys.Control + "v");
          break;
        case 2:
          this.ChromeDriver_0.FindElementsByName(string_7)[int_6].SendKeys(Keys.Control + "v");
          break;
        case 3:
          this.ChromeDriver_0.FindElementsByXPath(string_7)[int_6].SendKeys(Keys.Control + "v");
          break;
        case 4:
          this.ChromeDriver_0.FindElementsByCssSelector(string_7)[int_6].SendKeys(Keys.Control + "v");
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.PasteContent({0},{1},{2})", (object) int_5, (object) string_7, (object) bool_7));
    }
    return flag ? 1 : 0;
  }

  public int method_35(int int_5, string string_7)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementById(string_7).SendKeys(Keys.Control + "a");
          break;
        case 2:
          this.ChromeDriver_0.FindElementByName(string_7).SendKeys(Keys.Control + "a");
          break;
        case 3:
          this.ChromeDriver_0.FindElementByXPath(string_7).SendKeys(Keys.Control + "a");
          break;
        case 4:
          this.ChromeDriver_0.FindElementByCssSelector(string_7).SendKeys(Keys.Control + "a");
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SelectText({0},{1})", (object) int_5, (object) string_7));
    }
    return flag ? 1 : 0;
  }

  public int method_36(int int_5, string string_7)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementById(string_7).Clear();
          break;
        case 2:
          this.ChromeDriver_0.FindElementByName(string_7).Clear();
          break;
        case 3:
          this.ChromeDriver_0.FindElementByXPath(string_7).Clear();
          break;
        case 4:
          this.ChromeDriver_0.FindElementByCssSelector(string_7).Clear();
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.ClearText({0},{1})", (object) int_5, (object) string_7));
    }
    return flag ? 1 : 0;
  }

  public int method_37(string string_7)
  {
    int num = 0;
    if (!this.method_2())
      return -2;
    try
    {
      num = Convert.ToInt32(this.ChromeDriver_0.ExecuteScript("return document.querySelectorAll('" + string_7 + "').length+''", Array.Empty<object>()).ToString());
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.CountElement(" + string_7 + ")");
    }
    return num;
  }

  public int method_38(string string_7, double double_0 = 0.0)
  {
    bool flag = true;
    if (!this.method_2())
      return -2;
    try
    {
      int tickCount = Environment.TickCount;
      while ((string) this.ChromeDriver_0.ExecuteScript("return document.querySelectorAll('" + string_7 + "').length+''", Array.Empty<object>()) == "0")
      {
        if ((double) (Environment.TickCount - tickCount) <= double_0 * 1000.0)
        {
          if (!this.method_2())
            return -2;
          Thread.Sleep(1000);
        }
        else
        {
          flag = false;
          break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.CheckExistElement({0},{1})", (object) string_7, (object) double_0));
    }
    return flag ? 1 : 0;
  }

  public int method_39(string string_7, double double_0 = 0.0)
  {
    bool flag = true;
    if (!this.method_2())
      return -2;
    try
    {
      int tickCount = Environment.TickCount;
      while ((string) this.ChromeDriver_0.ExecuteScript("return " + string_7 + ".length+''", Array.Empty<object>()) == "0")
      {
        if ((double) (Environment.TickCount - tickCount) <= double_0 * 1000.0)
        {
          Thread.Sleep(1000);
        }
        else
        {
          flag = false;
          break;
        }
      }
    }
    catch (Exception ex)
    {
      flag = false;
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.CheckExistElement({0},{1})", (object) string_7, (object) double_0));
    }
    return flag ? 1 : 0;
  }

  public int method_40(string string_7, int int_5 = 0, double double_0 = 0.0)
  {
    bool flag = true;
    if (!this.method_2())
      return -2;
    try
    {
      int tickCount = Environment.TickCount;
      if (int_5 == 0)
      {
        while ((string) this.ChromeDriver_0.ExecuteScript("return document.querySelectorAll('" + string_7 + "').length+''", Array.Empty<object>()) == "0")
        {
          if ((double) (Environment.TickCount - tickCount) <= double_0 * 1000.0)
          {
            Thread.Sleep(1000);
          }
          else
          {
            flag = false;
            break;
          }
        }
      }
      else
      {
        while ((string) this.ChromeDriver_0.ExecuteScript("return document.querySelectorAll('" + string_7 + "').length+''", Array.Empty<object>()) != "0")
        {
          if ((double) (Environment.TickCount - tickCount) <= double_0 * 1000.0)
          {
            Thread.Sleep(1000);
          }
          else
          {
            flag = false;
            break;
          }
        }
      }
    }
    catch (Exception ex)
    {
      flag = false;
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.WaitForSearchElement({0},{1},{2})", (object) string_7, (object) int_5, (object) double_0));
    }
    return flag ? 1 : 0;
  }

  public int method_41(double double_0 = 0.0, params string[] string_7)
  {
    int num = 0;
    if (!this.method_2())
      return -2;
    try
    {
      int tickCount = Environment.TickCount;
      while (true)
      {
        num = Convert.ToInt32(this.ChromeDriver_0.ExecuteScript("var arr='" + string.Join("|", string_7) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); ", Array.Empty<object>()));
        if (num == 0 && (double) (Environment.TickCount - tickCount) <= double_0 * 1000.0)
          Thread.Sleep(1000);
        else
          break;
      }
      return num;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.CheckExistElements({0},{1})", (object) double_0, (object) string.Join("|", string_7)));
    }
    return num;
  }

  public int method_42(int int_5, string string_7)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      switch (int_5)
      {
        case 1:
          this.ChromeDriver_0.FindElementById(string_7).SendKeys(Keys.Enter);
          break;
        case 2:
          this.ChromeDriver_0.FindElementByName(string_7).SendKeys(Keys.Enter);
          break;
        case 3:
          this.ChromeDriver_0.FindElementByXPath(string_7).SendKeys(Keys.Enter);
          break;
        case 4:
          this.ChromeDriver_0.FindElementByCssSelector(string_7).SendKeys(Keys.Enter);
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.SendEnter({0},{1})", (object) int_5, (object) string_7));
    }
    return flag ? 1 : 0;
  }

  public int method_43(int int_5, int int_6)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.ExecuteScript(string.Format("window.scrollTo({0}, {1})", (object) int_5, (object) int_6), Array.Empty<object>());
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.Scroll({0},{1})", (object) int_5, (object) int_6));
    }
    return flag ? 1 : 0;
  }

  public int method_44(string string_7)
  {
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.ExecuteScript(string_7 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});", Array.Empty<object>());
      return 1;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.ScrollSmooth(" + string_7 + ")");
      return 0;
    }
  }

  public int method_45(string string_7)
  {
    if (!this.method_2())
      return -2;
    try
    {
      if (this.method_46(string_7) != 0)
        this.ChromeDriver_0.ExecuteScript(string_7 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});", Array.Empty<object>());
      return 1;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.ScrollSmoothIfNotExistOnScreen(" + string_7 + ")");
      return 0;
    }
  }

  public int method_46(string string_7)
  {
    int num = 0;
    if (!this.method_2())
      return -2;
    try
    {
      num = Convert.ToInt32(this.ChromeDriver_0.ExecuteScript("var check='';x=" + string_7 + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;", Array.Empty<object>()));
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.CheckExistElementOnScreen(" + string_7 + ")");
    }
    return num;
  }

  public Point method_47()
  {
    Point point = new Point(0, 0);
    if (this.method_2())
    {
      try
      {
        string str = this.ChromeDriver_0.ExecuteScript("return window.innerHeight+'|'+window.innerWidth", Array.Empty<object>()).ToString();
        point.X = Convert.ToInt32(str.Split('|')[1]);
        point.Y = Convert.ToInt32(str.Split('|')[0]);
      }
      catch
      {
      }
    }
    return point;
  }

  public int method_48()
  {
    if (!this.method_2())
      return -2;
    try
    {
      try
      {
        this.ChromeDriver_0.Quit();
      }
      catch
      {
      }
      if (this.Process_0 != null)
      {
        try
        {
          this.Process_0.Kill();
        }
        catch
        {
        }
      }
      return 1;
    }
    catch
    {
      return 0;
    }
  }

  public int method_49(string string_7, string string_8)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.GetScreenshot().SaveAsFile(string_7 + (string_7.EndsWith("\\") ? "" : "\\") + string_8 + ".png");
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.ScreenCapture(" + string_7 + "," + string_8 + ")");
    }
    return flag ? 1 : 0;
  }

  public int method_50(string string_7, string string_8 = ".facebook.com")
  {
    if (!this.method_2())
      return -2;
    try
    {
      string str1 = string_7;
      char[] chArray = new char[1]{ ';' };
      foreach (string str2 in str1.Split(chArray))
      {
        if (str2.Trim() != "")
        {
          string[] source = str2.Split('=');
          if (((IEnumerable<string>) source).Count<string>() > 1 && source[0].Trim() != "")
          {
            Cookie cookie = new Cookie(source[0].Trim(), str2.Substring(str2.IndexOf('=') + 1).Trim(), string_8, "/", new DateTime?(DateTime.Now.AddDays(10.0)));
            this.ChromeDriver_0.Manage().Cookies.AddCookie(cookie);
          }
        }
      }
      return 1;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.AddCookieIntoChrome(" + string_7 + "," + string_8 + ")");
      return 0;
    }
  }

  public string method_51(string string_7 = "facebook")
  {
    string str = "";
    if (!this.method_2())
      return "-2";
    try
    {
      foreach (Cookie cookie in this.ChromeDriver_0.Manage().Cookies.AllCookies.ToArray<Cookie>())
      {
        if (cookie.Domain.Contains(string_7))
          str = str + cookie.Name + "=" + cookie.Value + ";";
      }
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.GetCookieFromChrome(" + string_7 + ")");
    }
    return str;
  }

  public int method_52(string string_7, bool bool_7 = true)
  {
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.ExecuteScript("window.open('" + string_7 + "', '_blank').focus();", Array.Empty<object>());
      if (bool_7)
        this.ChromeDriver_0.SwitchTo().Window(this.ChromeDriver_0.WindowHandles.Last<string>());
      return 1;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.OpenNewTab({0},{1})", (object) string_7, (object) bool_7));
      return 0;
    }
  }

  public int method_53()
  {
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.Close();
      return 1;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.CloseCurrentTab()");
      return 0;
    }
  }

  public int method_54()
  {
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.SwitchTo().Window(this.ChromeDriver_0.WindowHandles.First<string>());
      return 1;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.SwitchToFirstTab()");
      return 0;
    }
  }

  public int method_55()
  {
    if (!this.method_2())
      return -2;
    try
    {
      this.ChromeDriver_0.SwitchTo().Window(this.ChromeDriver_0.WindowHandles.Last<string>());
      return 1;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, "chrome.SwitchToLastTab()");
      return 0;
    }
  }

  public void method_56(double double_0)
  {
    try
    {
      if (this.method_3())
        return;
      Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.DelayTime({0})", (object) double_0));
    }
  }

  public static void smethod_0(GClass18 gclass18_0, Exception exception_0, string string_7 = "")
  {
    try
    {
      if (!(string_7 == "chrome.Open()"))
        return;
      if (!Directory.Exists("log"))
        Directory.CreateDirectory("log");
      if (!Directory.Exists("log\\html"))
        Directory.CreateDirectory("log\\html");
      if (!Directory.Exists("log\\images"))
        Directory.CreateDirectory("log\\images");
      Random random = new Random();
      string[] strArray = new string[13];
      int num = DateTime.Now.Day;
      strArray[0] = num.ToString();
      strArray[1] = "_";
      DateTime now = DateTime.Now;
      num = now.Month;
      strArray[2] = num.ToString();
      strArray[3] = "_";
      now = DateTime.Now;
      num = now.Year;
      strArray[4] = num.ToString();
      strArray[5] = "_";
      now = DateTime.Now;
      num = now.Hour;
      strArray[6] = num.ToString();
      strArray[7] = "_";
      now = DateTime.Now;
      num = now.Minute;
      strArray[8] = num.ToString();
      strArray[9] = "_";
      now = DateTime.Now;
      num = now.Second;
      strArray[10] = num.ToString();
      strArray[11] = "_";
      num = random.Next(1000, 9999);
      strArray[12] = num.ToString();
      string string_8 = string.Concat(strArray);
      if (gclass18_0 != null)
      {
        string contents = gclass18_0.method_20("var markup = document.documentElement.innerHTML;return markup;").ToString();
        gclass18_0.method_49("log\\images\\", string_8);
        File.WriteAllText("log\\html\\" + string_8 + ".html", contents);
      }
      using (StreamWriter streamWriter1 = new StreamWriter("log\\log.txt", true))
      {
        streamWriter1.WriteLine("-----------------------------------------------------------------------------");
        StreamWriter streamWriter2 = streamWriter1;
        now = DateTime.Now;
        string str = "Date: " + now.ToString("dd/MM/yyyy HH:mm:ss");
        streamWriter2.WriteLine(str);
        streamWriter1.WriteLine("File: " + string_8);
        if (string_7 != "")
          streamWriter1.WriteLine("Error: " + string_7);
        streamWriter1.WriteLine();
        if (exception_0 == null)
          return;
        streamWriter1.WriteLine("Type: " + exception_0.GetType().FullName);
        streamWriter1.WriteLine("Message: " + exception_0.Message);
        streamWriter1.WriteLine("StackTrace: " + exception_0.StackTrace);
        exception_0 = exception_0.InnerException;
      }
    }
    catch
    {
    }
  }

  public int method_57(int int_5, string string_7, string string_8)
  {
    bool flag = false;
    if (!this.method_2())
      return -2;
    try
    {
      switch (int_5)
      {
        case 1:
          new SelectElement(this.ChromeDriver_0.FindElementById(string_7)).SelectByValue(string_8);
          break;
        case 2:
          new SelectElement(this.ChromeDriver_0.FindElementByName(string_7)).SelectByValue(string_8);
          break;
        case 3:
          new SelectElement(this.ChromeDriver_0.FindElementByXPath(string_7)).SelectByValue(string_8);
          break;
        case 4:
          new SelectElement(this.ChromeDriver_0.FindElementByCssSelector(string_7)).SelectByValue(string_8);
          break;
      }
      flag = true;
    }
    catch (Exception ex)
    {
      GClass18.smethod_0((GClass18) null, ex, string.Format("chrome.Select({0},{1},{2})", (object) int_5, (object) string_7, (object) string_8));
    }
    return flag ? 1 : 0;
  }

  internal bool method_58()
  {
    try
    {
      if (this.Process_0 != null)
        return true;
      string string_0 = "";
      for (int index1 = 0; index1 < 10; ++index1)
      {
        try
        {
          try
          {
            string_0 = this.ChromeDriver_0.CurrentWindowHandle;
          }
          catch
          {
            string_0 = GClass19.smethod_59(15, this.random_0);
          }
          if (string_0 != "")
          {
            for (int index2 = 0; index2 < 30; ++index2)
            {
              this.ChromeDriver_0.ExecuteScript("document.title='" + string_0 + "'", Array.Empty<object>());
              this.method_56(1.0);
              this.Process_0 = ((IEnumerable<Process>) Process.GetProcessesByName("chrome")).Where<Process>((Func<Process, bool>) (process_0 => process_0.MainWindowTitle.Contains(string_0))).FirstOrDefault<Process>();
              if (this.Process_0 != null)
                return true;
            }
          }
        }
        catch
        {
        }
        this.method_56(1.0);
      }
    }
    catch
    {
    }
    return false;
  }
}
