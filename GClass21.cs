// Decompiled with JetBrains decompiler
// Type: GClass21
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

public class GClass21
{
  private FirefoxDriver firefoxDriver_0;
  public bool bool_0 = false;

  public bool Boolean_0 { get; set; }

  public bool Boolean_1 { get; set; }

  public bool Boolean_2 { get; set; }

  public bool Boolean_3 { get; set; }

  public string String_0 { get; set; }

  public string String_1 { get; set; }

  public Point Point_0 { get; set; }

  public int Int32_0 { get; set; }

  public int Int32_1 { get; set; }

  public Point Point_1 { get; set; }

  public int Int32_2 { get; set; }

  public int Int32_3 { get; set; }

  public int Int32_4 { get; set; }

  public int Int32_5 { get; set; }

  public string String_2 { get; set; }

  public int Int32_6 { get; set; }

  public string String_3 { get; set; }

  public string String_4 { get; set; }

  public string String_5 { get; set; }

  public GClass21()
  {
    this.Boolean_1 = true;
    this.Boolean_2 = false;
    this.String_0 = "";
    this.String_1 = "";
    this.Int32_0 = 300;
    this.Int32_1 = 300;
    this.Point_0 = new Point(this.Int32_1, this.Int32_0);
    this.Int32_2 = 300;
    this.Int32_3 = 0;
    this.String_2 = "";
    this.Int32_6 = 0;
    this.Point_1 = new Point(this.Int32_2, this.Int32_3);
    this.Int32_4 = 0;
    this.Int32_5 = 5;
    this.String_3 = "";
    this.Boolean_3 = false;
    this.String_4 = "";
    this.String_5 = "data\\extension";
  }

  public bool method_0()
  {
    bool flag = false;
    this.bool_0 = true;
    try
    {
      FirefoxDriverService defaultService = FirefoxDriverService.CreateDefaultService();
      defaultService.HideCommandPromptWindow = true;
      FirefoxOptions options = new FirefoxOptions();
      options.SetPreference("security.notification_enable_delay", 0);
      options.SetPreference("dom.webnotifications.enabled", false);
      options.SetPreference("permissions.default.image", this.Boolean_1 ? 1 : 0);
      options.SetPreference("browser.download.folderList", 2);
      options.SetPreference("browser.download.manager.alertOnEXEOpen", false);
      options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/msword, application/csv, application/ris, text/csv, image/png, application/pdf, text/html, text/plain, application/zip, application/x-zip, application/x-zip-compressed, application/download, application/octet-stream");
      options.SetPreference("browser.download.manager.showWhenStarting", false);
      options.SetPreference("browser.download.manager.focusWhenStarting", false);
      options.SetPreference("browser.download.useDownloadDir", true);
      options.SetPreference("browser.helperApps.alwaysAsk.force", false);
      options.SetPreference("browser.download.manager.alertOnEXEOpen", false);
      options.SetPreference("browser.download.manager.closeWhenDone", true);
      options.SetPreference("browser.download.manager.showAlertOnComplete", false);
      options.SetPreference("browser.download.manager.useWindow", false);
      options.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
      options.SetPreference("pdfjs.disabled", true);
      FirefoxOptions firefoxOptions = options;
      string[] strArray = new string[2];
      int num = this.Point_0.X;
      strArray[0] = "-width=" + num.ToString();
      num = this.Point_0.Y;
      strArray[1] = "-height=" + num.ToString();
      firefoxOptions.AddArguments(strArray);
      if (this.String_0 != "")
        options.SetPreference("general.useragent.override", this.String_0);
      else
        options.SetPreference("general.useragent.override", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0");
      FirefoxProfileManager firefoxProfileManager = new FirefoxProfileManager();
      this.firefoxDriver_0 = new FirefoxDriver(defaultService, options);
      this.firefoxDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes((double) this.Int32_5);
      this.firefoxDriver_0.Manage().Window.Position = this.Point_1;
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.Open()");
      return flag;
    }
  }

  public static string smethod_0(FirefoxOptions firefoxOptions_0, int int_7)
  {
    int width = Screen.PrimaryScreen.Bounds.Width;
    int height = Screen.PrimaryScreen.Bounds.Height;
    int num1 = width / 3;
    int num2 = height / 2;
    int num3;
    int num4;
    if (int_7 < 3)
    {
      num3 = num1 * int_7;
      num4 = 0;
    }
    else
    {
      num3 = num1 * (int_7 % 3);
      num4 = int_7 / 2 % 2 != 0 ? num2 : 0;
    }
    firefoxOptions_0.AddArgument(string.Format("--width={0}", (object) num1));
    firefoxOptions_0.AddArgument(string.Format("--height={0}", (object) num2));
    return num3.ToString() + "|" + num4.ToString();
  }

  public string method_1(string string_6, string string_7, string string_8)
  {
    string str = "";
    if (this.bool_0)
    {
      try
      {
        str = this.firefoxDriver_0.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + string_6 + "','" + string_7 + "','" + string_8 + "')", Array.Empty<object>()).ToString();
      }
      catch (Exception ex)
      {
        GClass21.smethod_1((GClass18) null, ex, "firefox.GetCssSelector(" + string_6 + "," + string_7 + "," + string_8 + ")");
      }
    }
    return str;
  }

  public string method_2(string string_6, string string_7)
  {
    string str = "";
    if (this.bool_0)
    {
      try
      {
        str = this.firefoxDriver_0.ExecuteScript("return document.querySelector('" + string_6 + "').getAttribute('" + string_7 + "')", Array.Empty<object>()).ToString();
      }
      catch (Exception ex)
      {
        GClass21.smethod_1((GClass18) null, ex, "firefox.GetAttributeValue(" + string_6 + "," + string_7 + ")");
      }
    }
    return str;
  }

  public void method_3(int int_7)
  {
    if (!this.bool_0)
      return;
    try
    {
      this.firefoxDriver_0.ExecuteScript("window.scrollBy({ top: " + int_7.ToString() + ",behavior: 'smooth'});", Array.Empty<object>());
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("chrome.ScrollSmooth({0})", (object) int_7));
    }
  }

  public string method_4()
  {
    string str = "";
    try
    {
      str = this.firefoxDriver_0.ExecuteScript("return navigator.userAgent", Array.Empty<object>()).ToString();
    }
    catch
    {
    }
    return str;
  }

  public bool method_5(int int_7, string string_6)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      switch (int_7)
      {
        case 1:
          this.firefoxDriver_0.FindElementById(string_6).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
          break;
        case 2:
          this.firefoxDriver_0.FindElementByName(string_6).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
          break;
        case 3:
          this.firefoxDriver_0.FindElementByXPath(string_6).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
          break;
        case 4:
          this.firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.SendKeyDown({0},{1})", (object) int_7, (object) string_6));
      return flag;
    }
  }

  public string method_6()
  {
    if (this.bool_0)
    {
      try
      {
        return this.firefoxDriver_0.Url;
      }
      catch (Exception ex)
      {
        GClass21.smethod_1((GClass18) null, ex, "firefox.GetURL()");
      }
    }
    return "";
  }

  public bool method_7(string string_6)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      this.firefoxDriver_0.Navigate().GoToUrl(string_6);
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.GotoURL(" + string_6 + ")");
      return flag;
    }
  }

  public bool method_8()
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      this.firefoxDriver_0.Navigate().Refresh();
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.Refresh()");
      return flag;
    }
  }

  public bool method_9()
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      this.firefoxDriver_0.Navigate().Back();
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.GotoBackPage()");
      return flag;
    }
  }

  public bool method_10(int int_7, string string_6, double double_0)
  {
    if (this.bool_0)
    {
      try
      {
        switch (int_7)
        {
          case 1:
            new Actions((IWebDriver) this.firefoxDriver_0).MoveToElement(this.firefoxDriver_0.FindElement(By.Id(string_6))).Perform();
            break;
          case 2:
            new Actions((IWebDriver) this.firefoxDriver_0).MoveToElement(this.firefoxDriver_0.FindElement(By.Name(string_6))).Perform();
            break;
          case 3:
            new Actions((IWebDriver) this.firefoxDriver_0).MoveToElement(this.firefoxDriver_0.FindElement(By.XPath(string_6))).Perform();
            break;
          case 4:
            new Actions((IWebDriver) this.firefoxDriver_0).MoveToElement(this.firefoxDriver_0.FindElement(By.CssSelector(string_6))).Perform();
            break;
        }
        Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
        return true;
      }
      catch (Exception ex)
      {
        GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.HoverElement({0}, {1}, {2})", (object) int_7, (object) string_6, (object) double_0));
      }
    }
    return false;
  }

  public bool method_11(
    int int_7,
    string string_6,
    int int_8 = 0,
    int int_9 = 0,
    string string_7 = "",
    int int_10 = 0)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      if (int_9 == 0)
      {
        switch (int_7)
        {
          case 1:
            this.firefoxDriver_0.FindElementsById(string_6)[int_8].Click();
            break;
          case 2:
            this.firefoxDriver_0.FindElementsByName(string_6)[int_8].Click();
            break;
          case 3:
            this.firefoxDriver_0.FindElementsByXPath(string_6)[int_8].Click();
            break;
          case 4:
            this.firefoxDriver_0.FindElementsByCssSelector(string_6)[int_8].Click();
            break;
        }
      }
      else
      {
        switch (int_7)
        {
          case 1:
            this.firefoxDriver_0.FindElementsById(string_6)[int_8].FindElements(By.Id(string_7))[int_10].Click();
            break;
          case 2:
            this.firefoxDriver_0.FindElementsByName(string_6)[int_8].FindElements(By.Name(string_7))[int_10].Click();
            break;
          case 3:
            this.firefoxDriver_0.FindElementsByXPath(string_6)[int_8].FindElements(By.XPath(string_7))[int_10].Click();
            break;
          case 4:
            this.firefoxDriver_0.FindElementsByCssSelector(string_6)[int_8].FindElements(By.CssSelector(string_7))[int_10].Click();
            break;
        }
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.Click({0},{1})", (object) int_7, (object) string_6));
      return flag;
    }
  }

  public bool method_12(
    int int_7,
    string string_6,
    int int_8 = 0,
    int int_9 = 0,
    string string_7 = "",
    int int_10 = 0)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      if (int_9 != 0)
      {
        switch (int_7)
        {
          case 1:
            new Actions((IWebDriver) this.firefoxDriver_0).Click(this.firefoxDriver_0.FindElementsById(string_6)[int_8].FindElements(By.Id(string_7))[int_10]).Perform();
            break;
          case 2:
            new Actions((IWebDriver) this.firefoxDriver_0).Click(this.firefoxDriver_0.FindElementsByName(string_6)[int_8].FindElements(By.Name(string_7))[int_10]).Perform();
            break;
          case 3:
            new Actions((IWebDriver) this.firefoxDriver_0).Click(this.firefoxDriver_0.FindElementsByXPath(string_6)[int_8].FindElements(By.XPath(string_7))[int_10]).Perform();
            break;
          case 4:
            new Actions((IWebDriver) this.firefoxDriver_0).Click(this.firefoxDriver_0.FindElementsByCssSelector(string_6)[int_8].FindElements(By.CssSelector(string_7))[int_10]).Perform();
            break;
        }
      }
      else
      {
        switch (int_7)
        {
          case 1:
            new Actions((IWebDriver) this.firefoxDriver_0).Click(this.firefoxDriver_0.FindElementsById(string_6)[int_8]).Perform();
            break;
          case 2:
            new Actions((IWebDriver) this.firefoxDriver_0).Click(this.firefoxDriver_0.FindElementsByName(string_6)[int_8]).Perform();
            break;
          case 3:
            new Actions((IWebDriver) this.firefoxDriver_0).Click(this.firefoxDriver_0.FindElementsByXPath(string_6)[int_8]).Perform();
            break;
          case 4:
            new Actions((IWebDriver) this.firefoxDriver_0).Click(this.firefoxDriver_0.FindElementsByCssSelector(string_6)[int_8]).Perform();
            break;
        }
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.ClickWithAction({0},{1})", (object) int_7, (object) string_6));
      return flag;
    }
  }

  public bool method_13(int int_7, string string_6, string string_7, bool bool_5 = true)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      if (bool_5)
        this.method_11(int_7, string_6);
      switch (int_7)
      {
        case 1:
          this.firefoxDriver_0.FindElementById(string_6).SendKeys(string_7);
          break;
        case 2:
          this.firefoxDriver_0.FindElementByName(string_6).SendKeys(string_7);
          break;
        case 3:
          this.firefoxDriver_0.FindElementByXPath(string_6).SendKeys(string_7);
          break;
        case 4:
          this.firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(string_7);
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.SendKeys({0},{1},{2},{3})", (object) int_7, (object) string_6, (object) string_7, (object) bool_5));
      return flag;
    }
  }

  public bool method_14(
    int int_7,
    string string_6,
    string string_7,
    double double_0,
    bool bool_5 = true)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      if (bool_5)
        this.method_11(int_7, string_6);
      for (int index = 0; index < string_7.Length; ++index)
      {
        char ch;
        switch (int_7)
        {
          case 1:
            IWebElement elementById = this.firefoxDriver_0.FindElementById(string_6);
            ch = string_7[index];
            string text1 = ch.ToString();
            elementById.SendKeys(text1);
            break;
          case 2:
            IWebElement elementByName = this.firefoxDriver_0.FindElementByName(string_6);
            ch = string_7[index];
            string text2 = ch.ToString();
            elementByName.SendKeys(text2);
            break;
          case 3:
            IWebElement elementByXpath = this.firefoxDriver_0.FindElementByXPath(string_6);
            ch = string_7[index];
            string text3 = ch.ToString();
            elementByXpath.SendKeys(text3);
            break;
          case 4:
            IWebElement elementByCssSelector = this.firefoxDriver_0.FindElementByCssSelector(string_6);
            ch = string_7[index];
            string text4 = ch.ToString();
            elementByCssSelector.SendKeys(text4);
            break;
        }
        Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.SendKeys({0},{1},{2},{3},{4})", (object) int_7, (object) string_6, (object) string_7, (object) double_0, (object) bool_5));
      return flag;
    }
  }

  public bool method_15(int int_7, string string_6)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      switch (int_7)
      {
        case 1:
          this.firefoxDriver_0.FindElementById(string_6).SendKeys(OpenQA.Selenium.Keys.Control + "a");
          break;
        case 2:
          this.firefoxDriver_0.FindElementByName(string_6).SendKeys(OpenQA.Selenium.Keys.Control + "a");
          break;
        case 3:
          this.firefoxDriver_0.FindElementByXPath(string_6).SendKeys(OpenQA.Selenium.Keys.Control + "a");
          break;
        case 4:
          this.firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(OpenQA.Selenium.Keys.Control + "a");
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.SelectText({0},{1})", (object) int_7, (object) string_6));
      return flag;
    }
  }

  public bool method_16(int int_7, string string_6)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      switch (int_7)
      {
        case 1:
          this.firefoxDriver_0.FindElementById(string_6).Clear();
          break;
        case 2:
          this.firefoxDriver_0.FindElementByName(string_6).Clear();
          break;
        case 3:
          this.firefoxDriver_0.FindElementByXPath(string_6).Clear();
          break;
        case 4:
          this.firefoxDriver_0.FindElementByCssSelector(string_6).Clear();
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.ClearText({0},{1})", (object) int_7, (object) string_6));
      return flag;
    }
  }

  public bool method_17(string string_6, double double_0 = 0.0)
  {
    bool flag1 = true;
    if (!this.bool_0)
      return flag1;
    try
    {
      int tickCount = Environment.TickCount;
      while ((string) this.firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''", Array.Empty<object>()) == "0")
      {
        if ((double) (Environment.TickCount - tickCount) > double_0 * 1000.0)
          return false;
        Thread.Sleep(1000);
      }
      return flag1;
    }
    catch (Exception ex)
    {
      bool flag2 = false;
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.CheckExistElement({0},{1})", (object) string_6, (object) double_0));
      return flag2;
    }
  }

  public bool method_18(string string_6, double double_0 = 0.0)
  {
    bool flag1 = true;
    if (!this.bool_0)
      return flag1;
    try
    {
      int tickCount = Environment.TickCount;
      while ((string) this.firefoxDriver_0.ExecuteScript("return " + string_6 + ".length+''", Array.Empty<object>()) == "0")
      {
        if ((double) (Environment.TickCount - tickCount) > double_0 * 1000.0)
          return false;
        Thread.Sleep(1000);
      }
      return flag1;
    }
    catch (Exception ex)
    {
      bool flag2 = false;
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.CheckExistElement({0},{1})", (object) string_6, (object) double_0));
      return flag2;
    }
  }

  public bool method_19()
  {
    bool flag = true;
    if (!this.bool_0)
      return flag;
    try
    {
      string title = this.firefoxDriver_0.Title;
      return false;
    }
    catch (Exception ex)
    {
      this.bool_0 = false;
      GClass21.smethod_1((GClass18) null, ex, "firefox.CheckChromeClosed()");
      return flag;
    }
  }

  public bool method_20(string string_6, int int_7 = 0, double double_0 = 0.0)
  {
    bool flag1 = true;
    if (!this.bool_0)
      return flag1;
    try
    {
      int tickCount = Environment.TickCount;
      if (int_7 != 0)
      {
        while ((string) this.firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''", Array.Empty<object>()) != "0")
        {
          if ((double) (Environment.TickCount - tickCount) > double_0 * 1000.0)
            return false;
          Thread.Sleep(1000);
        }
        return flag1;
      }
      while ((string) this.firefoxDriver_0.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''", Array.Empty<object>()) == "0")
      {
        if ((double) (Environment.TickCount - tickCount) > double_0 * 1000.0)
          return false;
        Thread.Sleep(1000);
      }
      return flag1;
    }
    catch (Exception ex)
    {
      bool flag2 = false;
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.WaitForSearchElement({0},{1},{2})", (object) string_6, (object) int_7, (object) double_0));
      return flag2;
    }
  }

  public int method_21(double double_0 = 0.0, params string[] string_6)
  {
    int num = 0;
    if (this.bool_0)
    {
      try
      {
        int tickCount = Environment.TickCount;
        while (true)
        {
          for (int index = 0; index < string_6.Length; ++index)
          {
            if (this.method_17(string_6[index]))
              return index + 1;
          }
          if ((double) (Environment.TickCount - tickCount) <= double_0 * 1000.0)
            Thread.Sleep(1000);
          else
            break;
        }
      }
      catch (Exception ex)
      {
        GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.CheckExistElements({0},{1})", (object) double_0, (object) string.Join("|", string_6)));
      }
    }
    return num;
  }

  public bool method_22(int int_7, string string_6)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      switch (int_7)
      {
        case 1:
          this.firefoxDriver_0.FindElementById(string_6).SendKeys(OpenQA.Selenium.Keys.Enter);
          break;
        case 2:
          this.firefoxDriver_0.FindElementByName(string_6).SendKeys(OpenQA.Selenium.Keys.Enter);
          break;
        case 3:
          this.firefoxDriver_0.FindElementByXPath(string_6).SendKeys(OpenQA.Selenium.Keys.Enter);
          break;
        case 4:
          this.firefoxDriver_0.FindElementByCssSelector(string_6).SendKeys(OpenQA.Selenium.Keys.Enter);
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.SendEnter({0},{1})", (object) int_7, (object) string_6));
      return flag;
    }
  }

  public bool method_23(int int_7, int int_8)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      this.firefoxDriver_0.ExecuteScript(string.Format("window.scrollTo({0}, {1})", (object) int_7, (object) int_8), Array.Empty<object>());
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.Scroll({0},{1})", (object) int_7, (object) int_8));
      return flag;
    }
  }

  public void method_24(string string_6)
  {
    if (!this.bool_0)
      return;
    try
    {
      this.firefoxDriver_0.ExecuteScript(string_6 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});", Array.Empty<object>());
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.ScrollSmooth(" + string_6 + ")");
    }
  }

  public int method_25(string string_6)
  {
    int num = -2;
    if (this.bool_0)
    {
      try
      {
        num = Convert.ToInt32(this.firefoxDriver_0.ExecuteScript("var check='';x=" + string_6 + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;", Array.Empty<object>()));
      }
      catch (Exception ex)
      {
        GClass21.smethod_1((GClass18) null, ex, "firefox.CheckExistElementOnScreen(" + string_6 + ")");
      }
    }
    return num;
  }

  public Point method_26()
  {
    Point point = new Point(0, 0);
    if (this.bool_0)
    {
      try
      {
        string str = this.firefoxDriver_0.ExecuteScript("return window.innerHeight+'|'+window.innerWidth", Array.Empty<object>()).ToString();
        point.X = Convert.ToInt32(str.Split('|')[1]);
        point.Y = Convert.ToInt32(str.Split('|')[0]);
      }
      catch
      {
      }
    }
    return point;
  }

  public void method_27()
  {
    try
    {
      if (this.firefoxDriver_0 != null)
        this.firefoxDriver_0.Quit();
      this.bool_0 = false;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.Close()");
    }
  }

  public void method_28(string string_6, string string_7 = ".facebook.com")
  {
    if (!this.bool_0)
      return;
    try
    {
      string str1 = string_6;
      char[] chArray = new char[1]{ ';' };
      foreach (string str2 in str1.Split(chArray))
      {
        if (str2.Trim() != "")
        {
          string[] source = str2.Split('=');
          if (((IEnumerable<string>) source).Count<string>() > 1 && source[0].Trim() != "")
          {
            Cookie cookie = new Cookie(source[0].Trim(), str2.Substring(str2.IndexOf('=') + 1).Trim(), string_7, "/", new DateTime?(DateTime.Now.AddDays(10.0)));
            this.firefoxDriver_0.Manage().Cookies.AddCookie(cookie);
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.AddCookieIntoChrome(" + string_6 + "," + string_7 + ")");
    }
  }

  public string method_29(string string_6 = "facebook")
  {
    string str = "";
    if (this.bool_0)
    {
      try
      {
        foreach (Cookie cookie in this.firefoxDriver_0.Manage().Cookies.AllCookies.ToArray<Cookie>())
        {
          if (cookie.Domain.Contains(string_6))
            str = str + cookie.Name + "=" + cookie.Value + ";";
        }
      }
      catch (Exception ex)
      {
        GClass21.smethod_1((GClass18) null, ex, "firefox.GetCookieFromChrome(" + string_6 + ")");
      }
    }
    return str;
  }

  public void method_30(string string_6, bool bool_5 = true)
  {
    if (!this.bool_0)
      return;
    try
    {
      this.firefoxDriver_0.ExecuteScript("window.open('" + string_6 + "', '_blank').focus();", Array.Empty<object>());
      if (!bool_5)
        return;
      this.firefoxDriver_0.SwitchTo().Window(this.firefoxDriver_0.WindowHandles.Last<string>());
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.OpenNewTab({0},{1})", (object) string_6, (object) bool_5));
    }
  }

  public void method_31()
  {
    if (!this.bool_0)
      return;
    try
    {
      this.firefoxDriver_0.Close();
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.CloseCurrentTab()");
    }
  }

  public void method_32()
  {
    if (!this.bool_0)
      return;
    try
    {
      this.firefoxDriver_0.SwitchTo().Window(this.firefoxDriver_0.WindowHandles.First<string>());
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.SwitchToFirstTab()");
    }
  }

  public void method_33()
  {
    if (!this.bool_0)
      return;
    try
    {
      this.firefoxDriver_0.SwitchTo().Window(this.firefoxDriver_0.WindowHandles.Last<string>());
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "firefox.SwitchToLastTab()");
    }
  }

  public void method_34(double double_0)
  {
    if (!this.bool_0)
      return;
    try
    {
      Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.DelayTime({0})", (object) double_0));
    }
  }

  public bool method_35(int int_7, string string_6, string string_7)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      switch (int_7)
      {
        case 1:
          new SelectElement(this.firefoxDriver_0.FindElementById(string_6)).SelectByValue(string_7);
          break;
        case 2:
          new SelectElement(this.firefoxDriver_0.FindElementByName(string_6)).SelectByValue(string_7);
          break;
        case 3:
          new SelectElement(this.firefoxDriver_0.FindElementByXPath(string_6)).SelectByValue(string_7);
          break;
        case 4:
          new SelectElement(this.firefoxDriver_0.FindElementByCssSelector(string_6)).SelectByValue(string_7);
          break;
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, string.Format("firefox.Select({0},{1},{2})", (object) int_7, (object) string_6, (object) string_7));
      return flag;
    }
  }

  public bool method_36(string string_6, string string_7)
  {
    bool flag = false;
    if (!this.bool_0)
      return flag;
    try
    {
      this.firefoxDriver_0.GetScreenshot().SaveAsFile(string_6 + (string_6.EndsWith("\\") ? "" : "\\") + string_7 + ".png");
      return true;
    }
    catch (Exception ex)
    {
      GClass21.smethod_1((GClass18) null, ex, "chrome.ScreenCapture(" + string_6 + "," + string_7 + ")");
      return flag;
    }
  }

  public object method_37(string string_6)
  {
    if (this.bool_0)
    {
      try
      {
        return this.firefoxDriver_0.ExecuteScript(string_6, Array.Empty<object>());
      }
      catch (Exception ex)
      {
        GClass21.smethod_1((GClass18) null, ex, "firefox.ExecuteScript(" + string_6 + ")");
      }
    }
    return (object) "";
  }

  public static void smethod_1(GClass18 gclass18_0, Exception exception_0, string string_6 = "")
  {
    try
    {
      if (!Directory.Exists("log"))
        Directory.CreateDirectory("log");
      if (!Directory.Exists("log\\html"))
        Directory.CreateDirectory("log\\html");
      if (!Directory.Exists("log\\images"))
        Directory.CreateDirectory("log\\images");
      Random random = new Random();
      string[] strArray = new string[13];
      DateTime now = DateTime.Now;
      strArray[0] = now.Day.ToString();
      strArray[1] = "_";
      now = DateTime.Now;
      int num = now.Month;
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
        if (string_6 != "")
          streamWriter1.WriteLine("Error: " + string_6);
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
}
