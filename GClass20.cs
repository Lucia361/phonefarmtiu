// Decompiled with JetBrains decompiler
// Type: GClass20
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

public class GClass20
{
  public static bool smethod_0(GClass18 gclass18_0)
  {
    int num;
    if (!gclass18_0.method_11().StartsWith("https://m.facebook.com/feature_limit_notice/"))
      num = gclass18_0.method_41(0.0, "[href=\"https://www.facebook.com/help/177066345680802\"]", "[href*=\"https://m.facebook.com/help/contact/\"]") != 0 ? 1 : 0;
    else
      num = 1;
    return num != 0;
  }

  public static void smethod_1(GClass18 gclass18_0, List<string> list_0)
  {
    List<string> stringList = new List<string>();
    int num = gclass18_0.method_37("textarea");
    gclass18_0.method_44("document.querySelector('textarea')");
    gclass18_0.method_31();
    for (int int_6 = 0; int_6 < num; ++int_6)
    {
      if (stringList.Count == 0)
        stringList = GClass19.smethod_27(list_0);
      string string_8 = GClass19.smethod_28(stringList[Class54.random_0.Next(0, stringList.Count)], Class54.random_0);
      stringList.Remove(string_8);
      gclass18_0.method_27(4, "textarea", int_6, string_8, 0.1);
      gclass18_0.method_31();
    }
  }

  public static bool smethod_2(GClass18 gclass18_0)
  {
    try
    {
      return gclass18_0.method_38("#captcha_response") == 1 || gclass18_0.method_38("[name=\"captcha_response\"]") == 1 || gclass18_0.method_38("[name=\"verification_method\"]") == 1 || gclass18_0.method_38("[name=\"password_new\"]") == 1 || gclass18_0.method_38("[href=\"https://www.facebook.com/communitystandards/\"]") == 1;
    }
    catch
    {
      return false;
    }
  }

  public static int smethod_3(
    GClass18 gclass18_0,
    string string_0,
    string string_1,
    string string_2 = "",
    string string_3 = "https://www.facebook.com")
  {
    Random random = new Random();
    int num1 = 0;
    try
    {
      int num2 = GClass20.smethod_28(gclass18_0.method_11());
      if (num2 == 0)
      {
        if (gclass18_0.method_12(string_3) != -2)
        {
          num2 = GClass20.smethod_28(gclass18_0.method_11());
        }
        else
        {
          num1 = -2;
          goto label_58;
        }
      }
      if (gclass18_0.method_38("[data-cookiebanner=\"accept_button\"]") == 1)
      {
        gclass18_0.method_21(4, "[data-cookiebanner=\"accept_button\"]");
        gclass18_0.method_56(1.0);
      }
      if (num2 == 1)
      {
        gclass18_0.method_14("https://www.facebook.com/login");
        if (gclass18_0.method_38("[data-cookiebanner=\"accept_button\"]") == 1)
        {
          gclass18_0.method_21(4, "[data-cookiebanner=\"accept_button\"]");
          gclass18_0.method_56(1.0);
        }
        if (gclass18_0.method_26(1, "email", string_0, 0.1) == -2)
        {
          num1 = -2;
          goto label_58;
        }
        else
        {
          gclass18_0.method_56(1.0);
          if (gclass18_0.method_26(1, "pass", string_1, 0.1) == -2)
          {
            num1 = -2;
          }
          else
          {
            gclass18_0.method_56(1.0);
            if (gclass18_0.method_21(1, "loginbutton") != -2)
            {
              gclass18_0.method_56(1.0);
              if (gclass18_0.method_38("#approvals_code", 5.0) == 1 && string_2 != "")
              {
                string string_8 = GClass19.smethod_85(string_2.Replace(" ", "").Replace("\n", ""));
                if (string_8 != "")
                {
                  gclass18_0.method_26(1, "approvals_code", string_8, 0.1);
                  gclass18_0.method_56(1.0);
                  gclass18_0.method_21(1, "checkpointSubmitButton");
                  gclass18_0.method_56(1.0);
                }
              }
              int num3 = 0;
              while (gclass18_0.method_38("#checkpointSubmitButton", 3.0) == 1)
              {
                if (gclass18_0.method_2())
                {
                  if (!GClass20.smethod_2(gclass18_0) && num3 != 7)
                  {
                    gclass18_0.method_21(1, "checkpointSubmitButton");
                    gclass18_0.method_56(1.0);
                    ++num3;
                  }
                  else
                    break;
                }
                else
                {
                  num1 = -2;
                  goto label_58;
                }
              }
              goto label_42;
            }
            else
              num1 = -2;
          }
          goto label_58;
        }
      }
      else
      {
        gclass18_0.method_14("https://m.facebook.com/login");
        if (gclass18_0.method_38("[data-cookiebanner=\"accept_button\"]") == 1)
        {
          gclass18_0.method_21(4, "[data-cookiebanner=\"accept_button\"]");
          gclass18_0.method_56(1.0);
        }
        switch (gclass18_0.method_38("[data-sigil=\"login_profile_form\"] div[role=\"button\"]", 1.0))
        {
          case -2:
            num1 = -2;
            break;
          case 1:
            gclass18_0.method_31();
            if (gclass18_0.method_21(4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") != -2)
            {
              gclass18_0.method_31(2);
              switch (gclass18_0.method_41(10.0, "[name=\"pass\"]", "#approvals_code"))
              {
                case -2:
                  num1 = -2;
                  goto label_58;
                case 1:
                  if (gclass18_0.method_26(2, "pass", string_1, 0.1) == 1)
                  {
                    gclass18_0.method_31();
                    if (gclass18_0.method_21(4, gclass18_0.method_5("button", "data-sigil", "password_login_button")) == 1)
                      gclass18_0.method_56(1.0);
                    goto label_43;
                  }
                  else
                    goto label_43;
                default:
                  goto label_43;
              }
            }
            else
            {
              num1 = -2;
              break;
            }
          default:
            if (gclass18_0.method_26(1, "m_login_email", string_0, 0.1) == 1)
            {
              gclass18_0.method_31();
              string string_7 = gclass18_0.method_41(3.0, "#m_login_password", "[name=\"pass\"]") == 1 ? "#m_login_password" : "[name=\"pass\"]";
              gclass18_0.method_26(4, string_7, string_1, 0.1);
              gclass18_0.method_31();
              gclass18_0.method_21(2, "login");
              gclass18_0.method_31();
              goto label_43;
            }
            else
              goto label_43;
        }
        goto label_58;
label_43:
        int num4;
        switch (gclass18_0.method_38("#approvals_code", 5.0))
        {
          case -2:
            num1 = -2;
            goto label_58;
          case 1:
            num4 = string_2.Trim() != "" ? 1 : 0;
            break;
          default:
            num4 = 0;
            break;
        }
        if (num4 != 0)
        {
          string string_8 = GClass19.smethod_85(string_2.Replace(" ", "").Replace("\n", ""));
          if (string_8 != "")
          {
            gclass18_0.method_26(1, "approvals_code", string_8, 0.1);
            gclass18_0.method_31(-1);
            gclass18_0.method_21(1, "checkpointSubmitButton-actual-button");
            gclass18_0.method_31();
          }
        }
        int num5 = 0;
        while (gclass18_0.method_38("#checkpointSubmitButton-actual-button", 3.0) == 1 && gclass18_0.method_38("[name=\"password_new\"]") != 1)
        {
          if (gclass18_0.method_2())
          {
            if (!GClass20.smethod_36(gclass18_0) && num5 != 7)
            {
              gclass18_0.method_21(1, "checkpointSubmitButton-actual-button");
              gclass18_0.method_31();
              ++num5;
            }
            else
              break;
          }
          else
          {
            num1 = -2;
            goto label_58;
          }
        }
      }
label_42:
      gclass18_0.method_56(1.0);
      return GClass20.smethod_34(gclass18_0);
    }
    catch (Exception ex)
    {
      GClass19.smethod_79(gclass18_0, ex, "Login Uid Pass Fail");
    }
label_58:
    return num1;
  }

  public static string smethod_4(GClass18 gclass18_0) => gclass18_0.method_20("var x='';document.querySelectorAll('[property=\"og:title\"]').length>0&&(x=document.querySelector('[property=\"og:title\"]').getAttribute('content')),''==x&&document.querySelectorAll('[data-gt] a').length>0&&(x=document.querySelector('[data-gt] a').innerText),''==x&&document.querySelectorAll('.actor').length>0&&(x=document.querySelector('.actor').innerText), x+''; return x;").ToString();

  public static string smethod_5(GClass18 gclass18_0) => gclass18_0.method_20("var x='';document.querySelectorAll('.overflowText').length>0&&(x=document.querySelector('.overflowText').innerText), x+''; return x;").ToString();

  public static int smethod_6(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (!(gclass18_0.method_11() == "https://m.facebook.com/home.php") && !(gclass18_0.method_11() == "https://m.facebook.com"))
        {
          if (gclass18_0.method_38("#feed_jewel a") == 1)
          {
            gclass18_0.method_45("document.querySelector('#feed_jewel a')");
            gclass18_0.method_31();
          }
          if (gclass18_0.method_21(4, "#feed_jewel a") != 1)
            gclass18_0.method_12("https://m.facebook.com/home.php");
          gclass18_0.method_56(1.0);
          if (gclass18_0.method_38("#nux-nav-button", 2.0) == 1)
          {
            gclass18_0.method_23(1, "nux-nav-button");
            gclass18_0.method_56(2.0);
          }
        }
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_11() == "https://m.facebook.com/home.php" || gclass18_0.method_11() == "https://m.facebook.com/home.php?ref=wizard&_rdr" || gclass18_0.method_11() == "https://m.facebook.com")
          return 1;
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_7(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_38("#requests_jewel a") == 1)
        {
          gclass18_0.method_45("document.querySelector('#requests_jewel a')");
          gclass18_0.method_31();
        }
        int num = gclass18_0.method_21(4, "#requests_jewel a");
        if (num != 1)
        {
          GClass20.smethod_6(gclass18_0);
          gclass18_0.method_31(2);
          num = gclass18_0.method_21(4, "#requests_jewel a");
        }
        if (num == 1)
        {
          gclass18_0.method_31(1);
          if (gclass18_0.method_21(4, "[href=\"/friends/center/friends/?mff_nav=1\"]") == 1)
          {
            gclass18_0.method_31();
            return 1;
          }
        }
        return gclass18_0.method_12("https://m.facebook.com/friends/center/friends/?mff_nav=1");
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_8(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_38("#requests_jewel a") == 1)
        {
          gclass18_0.method_45("document.querySelector('#requests_jewel a')");
          gclass18_0.method_31();
        }
        int num = gclass18_0.method_21(4, "#requests_jewel a");
        if (num != 1)
        {
          GClass20.smethod_6(gclass18_0);
          gclass18_0.method_31(2);
          num = gclass18_0.method_21(4, "#requests_jewel a");
        }
        if (num == 1)
        {
          gclass18_0.method_31(1);
          if (gclass18_0.method_21(4, "[href=\"/friends/center/suggestions/?mff_nav=1&ref=bookmarks\"]") == 1)
          {
            gclass18_0.method_31();
            return 1;
          }
        }
        return gclass18_0.method_12("https://m.facebook.com/friends/center/suggestions/?mff_nav=1&ref=bookmarks");
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_9(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_38("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
        {
          gclass18_0.method_45("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
          gclass18_0.method_31();
        }
        int num = gclass18_0.method_21(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
        if (num != 1)
        {
          GClass20.smethod_6(gclass18_0);
          gclass18_0.method_31(2);
          num = gclass18_0.method_21(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
        }
        if (num == 1)
        {
          gclass18_0.method_31(1);
          string string_7 = gclass18_0.method_5("a", "href", "/groups/");
          if (string_7 != "")
          {
            gclass18_0.method_45("document.querySelector('" + string_7 + "')");
            gclass18_0.method_31();
            if (gclass18_0.method_21(4, string_7) == 1)
            {
              gclass18_0.method_31(2);
              if (gclass18_0.method_21(4, "[href=\"/groups_browse/your_groups/\"]") == 1)
              {
                gclass18_0.method_31();
                return 1;
              }
            }
          }
        }
        return gclass18_0.method_12("https://m.facebook.com/groups_browse/your_groups/");
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_10(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_38("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
        {
          gclass18_0.method_45("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
          gclass18_0.method_31();
        }
        int num = gclass18_0.method_21(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
        if (num != 1)
        {
          GClass20.smethod_6(gclass18_0);
          gclass18_0.method_31(2);
          num = gclass18_0.method_21(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
        }
        if (num == 1)
        {
          gclass18_0.method_31(1);
          string string_7 = gclass18_0.method_5("a", "href", "/watch/");
          if (string_7 != "")
          {
            gclass18_0.method_45("document.querySelector('" + string_7 + "')");
            gclass18_0.method_31();
            if (gclass18_0.method_21(4, string_7) == 1)
            {
              gclass18_0.method_31();
              return 1;
            }
          }
        }
        return gclass18_0.method_12("https://m.facebook.com/watch/?ref=bookmarks");
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_11(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_38("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
        {
          gclass18_0.method_45("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
          gclass18_0.method_31();
        }
        int num = gclass18_0.method_21(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
        if (num != 1)
        {
          GClass20.smethod_6(gclass18_0);
          gclass18_0.method_31(2);
          num = gclass18_0.method_21(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
        }
        if (num == 1)
        {
          gclass18_0.method_31(1);
          string string_7 = gclass18_0.method_5("a", "href", "/settings/");
          if (string_7 != "")
          {
            gclass18_0.method_45("document.querySelector('" + string_7 + "')");
            gclass18_0.method_31();
            if (gclass18_0.method_21(4, string_7) == 1)
            {
              gclass18_0.method_31();
              return 1;
            }
          }
        }
        return gclass18_0.method_12("https://m.facebook.com/settings/?entry_point=bookmark");
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_12(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        GClass20.smethod_11(gclass18_0);
        string string_7 = gclass18_0.method_5("a", "href", "/privacy/touch/timeline_and_tagging/");
        if (string_7 != "")
        {
          gclass18_0.method_45("document.querySelector('" + string_7 + "')");
          gclass18_0.method_31();
          if (gclass18_0.method_21(4, string_7) == 1)
          {
            gclass18_0.method_31();
            return 1;
          }
        }
        return gclass18_0.method_12("https://m.facebook.com/privacy/touch/timeline_and_tagging/");
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_13(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_38("#notifications_jewel a") == 1)
        {
          gclass18_0.method_45("document.querySelector('#notifications_jewel a')");
          gclass18_0.method_31();
        }
        int num = gclass18_0.method_21(4, "#notifications_jewel a");
        if (num != 1)
        {
          GClass20.smethod_6(gclass18_0);
          num = gclass18_0.method_21(4, "#notifications_jewel a");
        }
        if (num != 1)
          return gclass18_0.method_12("https://m.facebook.com/notifications.php?ref=bookmarks");
        gclass18_0.method_31(1);
        return 1;
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_14(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_38("#messages_jewel a") == 1)
        {
          gclass18_0.method_45("document.querySelector('#messages_jewel a')");
          gclass18_0.method_31();
        }
        int num = gclass18_0.method_21(4, "#messages_jewel a");
        if (num != 1)
        {
          GClass20.smethod_6(gclass18_0);
          gclass18_0.method_31(2);
          num = gclass18_0.method_21(4, "#messages_jewel a");
        }
        if (num != 1)
          return gclass18_0.method_12("https://m.facebook.com/messages/?entrypoint=jewel&no_hist=1&ref=bookmarks");
        gclass18_0.method_31(1);
        return 1;
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_15(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (GClass20.smethod_14(gclass18_0) != 1 || gclass18_0.method_21(4, "[href=\"/messages/?folder=unread&refid=11&ref=bookmarks\"]") != 1)
          return gclass18_0.method_12("https://m.facebook.com/messages/?folder=unread&ref=bookmarks");
        gclass18_0.method_32(3, 5);
        return 1;
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_16(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (gclass18_0.method_38("#notifications_jewel a") == 1)
        {
          gclass18_0.method_45("document.querySelector('#search_jewel a')");
          gclass18_0.method_31();
        }
        int num = gclass18_0.method_21(4, "#search_jewel a");
        if (num != 1)
        {
          GClass20.smethod_6(gclass18_0);
          gclass18_0.method_31(2);
          num = gclass18_0.method_21(4, "#search_jewel a");
        }
        if (num == 1 && gclass18_0.method_38("#main-search-input") == 1)
        {
          gclass18_0.method_31(1);
          return 1;
        }
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_17(GClass18 gclass18_0, string string_0, int int_0 = 0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (GClass20.smethod_16(gclass18_0) == 1)
        {
          bool flag = false;
          if (gclass18_0.method_38("#main-search-input") == 1)
          {
            string_0 = GClass19.smethod_28(string_0, Class54.random_0);
            switch (int_0)
            {
              case 0:
                gclass18_0.method_28(Class54.random_0, 1, "main-search-input", string_0, 0.1);
                break;
              case 1:
                gclass18_0.method_26(1, "main-search-input", string_0, 0.1);
                break;
              case 2:
                gclass18_0.method_24(1, "main-search-input", string_0);
                break;
            }
            gclass18_0.method_31();
            gclass18_0.method_42(1, "main-search-input");
            gclass18_0.method_31(2);
            string string_7_1 = gclass18_0.method_5("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
            if (string_7_1 != "")
            {
              if (gclass18_0.method_21(4, string_7_1) == 0)
              {
                if (gclass18_0.method_21(4, "[data-sigil=\" flyout-causal\"]") == 1)
                {
                  gclass18_0.method_31();
                  string string_7_2 = gclass18_0.method_5("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
                  if (string_7_2 != "")
                  {
                    flag = true;
                    gclass18_0.method_21(4, string_7_2);
                    gclass18_0.method_31(2);
                  }
                }
              }
              else
              {
                flag = true;
                gclass18_0.method_31(2);
              }
            }
          }
          if (!flag)
          {
            gclass18_0.method_12("https://m.facebook.com/search/groups/?q=" + string_0);
            gclass18_0.method_31(2);
            flag = true;
          }
          if (flag)
          {
            gclass18_0.method_31(1);
            return 1;
          }
        }
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_18(GClass18 gclass18_0, string string_0, int int_0 = 0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        if (GClass20.smethod_16(gclass18_0) == 1)
        {
          bool flag = false;
          if (gclass18_0.method_38("#main-search-input") == 1)
          {
            string_0 = GClass19.smethod_28(string_0, Class54.random_0);
            switch (int_0)
            {
              case 0:
                gclass18_0.method_28(Class54.random_0, 1, "main-search-input", string_0, 0.1);
                break;
              case 1:
                gclass18_0.method_26(1, "main-search-input", string_0, 0.1);
                break;
              case 2:
                gclass18_0.method_24(1, "main-search-input", string_0);
                break;
            }
            gclass18_0.method_31();
            gclass18_0.method_42(1, "main-search-input");
            gclass18_0.method_31(2);
            string string_7_1 = gclass18_0.method_5("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
            if (string_7_1 != "")
            {
              if (gclass18_0.method_21(4, string_7_1) == 0)
              {
                if (gclass18_0.method_21(4, "[data-sigil=\" flyout-causal\"]") == 1)
                {
                  gclass18_0.method_31();
                  string string_7_2 = gclass18_0.method_5("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
                  if (string_7_2 != "")
                  {
                    flag = true;
                    gclass18_0.method_21(4, string_7_2);
                    gclass18_0.method_31(2);
                  }
                }
              }
              else
              {
                flag = true;
                gclass18_0.method_31(2);
              }
            }
          }
          if (!flag)
          {
            gclass18_0.method_12("https://m.facebook.com/search/people/?q=" + string_0 + "&source=filter&isTrending=0");
            gclass18_0.method_31(2);
            flag = true;
          }
          if (flag)
          {
            gclass18_0.method_31(1);
            return 1;
          }
        }
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_19(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_12("https://m.facebook.com/browse/birthdays/") == -2)
          return -2;
        gclass18_0.method_32(2, 5);
        return 1;
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_20(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_12("https://m.facebook.com/pokes/") == -2)
          return -2;
        gclass18_0.method_32(2, 5);
        return 1;
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_21(GClass18 gclass18_0, int int_0 = 3, int int_1 = 5)
  {
    try
    {
      if (gclass18_0.method_3())
        return -2;
      int num1 = Class54.random_0.Next(int_0, int_1 + 1);
      int int32_1 = Convert.ToInt32(gclass18_0.method_20("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
      GClass18 gclass18_1 = gclass18_0;
      Random random0_1 = Class54.random_0;
      int minValue1 = gclass18_0.method_47().Y / 2;
      Point point = gclass18_0.method_47();
      int y1 = point.Y;
      int int_5_1 = random0_1.Next(minValue1, y1);
      if (gclass18_1.method_8(int_5_1) == 1)
      {
        gclass18_0.method_32(1, 3);
        int int32_2 = Convert.ToInt32(gclass18_0.method_20("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
        if (int32_1 != int32_2)
        {
          for (int index = 0; index < num1 - 1; ++index)
          {
            int int32_3 = Convert.ToInt32(gclass18_0.method_20("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
            GClass18 gclass18_2 = gclass18_0;
            int num2 = Class54.random_0.Next(1, 1000) % 5 != 0 ? 1 : -1;
            Random random0_2 = Class54.random_0;
            point = gclass18_0.method_47();
            int minValue2 = point.Y / 2;
            point = gclass18_0.method_47();
            int y2 = point.Y;
            int num3 = random0_2.Next(minValue2, y2);
            int int_5_2 = num2 * num3;
            if (gclass18_2.method_8(int_5_2) == -2)
              return -2;
            gclass18_0.method_32(1, 3);
            int int32_4 = Convert.ToInt32(gclass18_0.method_20("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
            if (int32_3 != int32_4)
              gclass18_0.method_32(1, 2);
            else
              break;
          }
        }
        return 1;
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_22(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0 != null)
      {
        if (gclass18_0.method_3())
          return -2;
        switch (gclass18_0.method_38("[jsselect=\"suggestionsSummaryList\"]"))
        {
          case -2:
            return -2;
          case 1:
            return -3;
          default:
            if (GClass20.smethod_35(gclass18_0))
              return -1;
            break;
        }
      }
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_23(GClass18 gclass18_0, int int_0)
  {
    int num = 0;
    try
    {
      string string_7 = "https://www.facebook.com";
      if (!gclass18_0.method_11().StartsWith(string_7) && gclass18_0.method_12(string_7) == -2)
      {
        num = -2;
      }
      else
      {
        object obj = gclass18_0.method_20("async function ConvertFacebook(e) { var t = require([\"DTSGInitData\"]).token, a = require([\"CurrentUserInitialData\"]).USER_ID, r = \"\", o = \"\"; 0 == e ? (r = \"https://www.facebook.com/api/graphql/\", o = \"av=\" + a + \"&__user=\" + a + \"&__a=1&dpr=1&fb_dtsg=\" + t + \"&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=CometTrialParticipationChangeMutation&variables=%7B%22input%22%3A%7B%22change_type%22%3A%22OPT_OUT%22%2C%22source%22%3A%22SETTINGS_MENU%22%2C%22actor_id%22%3A%22\" + a + \"%22%2C%22client_mutation_id%22%3A%221%22%7D%7D&server_timestamps=true&doc_id=2317726921658975\") : (r = \"https://www.facebook.com/comet/try/\", o = \"source=SETTINGS_MENU&nctr[_mod]=pagelet_bluebar&__user=\" + a + \"&__a=1dpr=1&fb_dtsg=\" + t); var output = ''; try { var response = await fetch(r, { method: 'POST', body: o, headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; } var c = await ConvertFacebook(" + int_0.ToString() + ");");
        if (obj != null && obj.ToString() == "-2")
          num = -2;
        else if (gclass18_0.method_15() == -2)
        {
          num = -2;
        }
        else
        {
          switch (gclass18_0.method_38("[role=\"navigation\"]", 10.0))
          {
            case -2:
              num = -2;
              break;
            case 1:
              if (int_0 == 0 && gclass18_0.method_37("[role=\"navigation\"]") < 3 || int_0 == 1 && gclass18_0.method_37("[role=\"navigation\"]") == 3)
              {
                num = 1;
                break;
              }
              break;
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
    return num;
  }

  public static string smethod_24() => "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36";

  public static bool smethod_25()
  {
    try
    {
      GClass18 gclass18 = new GClass18()
      {
        Boolean_0 = true,
        String_5 = ""
      };
      if (GClass33.smethod_0("configGeneral").method_3("typeBrowser") != 0)
        gclass18.String_4 = GClass33.smethod_0("configGeneral").method_1("txtLinkToOtherBrowser");
      if (gclass18.method_0())
        return true;
    }
    catch
    {
    }
    return false;
  }

  public static bool smethod_26(GClass18 gclass18_0, string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      gclass18_0.method_12("chrome-extension://ggmdpepbjljkkkdaklfihhngmmgmpggp/options.html");
      gclass18_0.method_24(1, "login", string_0);
      gclass18_0.method_24(1, "password", string_1);
      gclass18_0.method_36(1, "retry");
      gclass18_0.method_24(1, "retry", "2");
      gclass18_0.method_21(1, "save");
      gclass18_0.method_56(2.0);
      gclass18_0.method_12("http://lumtest.com/myip.json");
      return JObject.Parse(gclass18_0.method_20("return document.documentElement.innerText;").ToString())["ip"].ToString() != "" || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static int smethod_27(GClass18 gclass18_0, string string_0, string string_1 = "https://www.facebook.com")
  {
    try
    {
      return gclass18_0.method_14(string_1) == -2 || gclass18_0.method_50(string_0) == -2 || gclass18_0.method_15() == -2 ? -2 : GClass20.smethod_34(gclass18_0);
    }
    catch
    {
    }
    return 0;
  }

  public static int smethod_28(string string_0)
  {
    int num = 0;
    if (string_0.StartsWith("https://www.facebook") || string_0.StartsWith("https://facebook") || string_0.StartsWith("https://web.facebook"))
      num = 1;
    else if (string_0.StartsWith("https://m.facebook") || string_0.StartsWith("https://d.facebook") || string_0.StartsWith("https://mobile.facebook"))
      num = 2;
    else if (string_0.StartsWith("https://mbasic.facebook"))
      num = 3;
    return num;
  }

  public static int smethod_29(GClass18 gclass18_0, string string_0)
  {
    if (!gclass18_0.method_2())
      return -2;
    int num = 0;
    for (int index = 0; index < 2; ++index)
    {
      if (gclass18_0.method_11().StartsWith("https://www.facebook") || gclass18_0.method_11().StartsWith("https://facebook") || gclass18_0.method_11().StartsWith("https://web.facebook"))
        num = 1;
      else if (gclass18_0.method_11().StartsWith("https://m.facebook") || gclass18_0.method_11().StartsWith("https://mobile.facebook"))
        num = 2;
      else if (gclass18_0.method_11().StartsWith("https://mbasic.facebook"))
        num = 3;
      if (num == 0 || num != GClass20.smethod_28(string_0))
      {
        gclass18_0.method_12(string_0);
        gclass18_0.method_56(1.0);
      }
      else
        break;
    }
    return num;
  }

  public static List<string> smethod_30(GClass18 gclass18_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      stringList = ((IEnumerable<string>) gclass18_0.method_20("var arr=[]; document.querySelectorAll('a').forEach(e=>{arr.push(e.href)});var s=arr.join('|'); return s").ToString().Split('|')).ToList<string>();
    }
    catch
    {
    }
    return stringList;
  }

  public static string smethod_31(
    GClass18 gclass18_0,
    string string_0,
    string string_1,
    string string_2 = "",
    string string_3 = "https://m.facebook.com",
    int int_0 = 0,
    bool bool_0 = false,
    int int_1 = 120)
  {
    int num1 = 0;
    int tickCount = Environment.TickCount;
    try
    {
      int int_5 = GClass20.smethod_29(gclass18_0, string_3);
      switch (gclass18_0.method_41(0.0, "[data-cookiebanner=\"accept_button\"]", "[name=\"pass\"]"))
      {
        case 0:
          gclass18_0.method_13(int_5);
          gclass18_0.method_22(0.0, 4, "[data-cookiebanner=\"accept_button\"]");
          break;
        case 1:
          gclass18_0.method_22(0.0, 4, "[data-cookiebanner=\"accept_button\"]");
          if (gclass18_0.method_38("[name=\"pass\"]") != 1)
          {
            gclass18_0.method_13(int_5);
            gclass18_0.method_22(0.0, 4, "[data-cookiebanner=\"accept_button\"]");
            break;
          }
          break;
      }
      if (GClass20.smethod_28(gclass18_0.method_11()) == 2 && gclass18_0.method_22(0.0, 4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") == 1)
      {
        gclass18_0.method_56(1.0);
        if (gclass18_0.method_41(5.0, "[name=\"pass\"]", "#approvals_code") == 1 && gclass18_0.method_29(int_0, 2, "pass", string_1, 0.1) == 1)
        {
          gclass18_0.method_56(1.0);
          if (gclass18_0.method_21(4, gclass18_0.method_5("button", "data-sigil", "password_login_button")) == 1)
            gclass18_0.method_56(1.0);
        }
      }
      else
      {
        if (gclass18_0.method_38("[data-sigil=\"touchable\"]") == 1 && gclass18_0.method_38("#m_login_auto_search_form_forgot_password_button") != 1)
          gclass18_0.method_22(0.0, 4, "[data-sigil=\"touchable\"]");
        int num2 = 1;
        bool flag = false;
label_13:
        int num3 = gclass18_0.method_29(int_0, 2, "email", string_0, 0.1);
        while (true)
        {
          if (num3 != -2)
          {
            gclass18_0.method_56(1.0);
            ++num2;
            if (!flag)
            {
              switch (num2)
              {
                case 1:
                  goto label_13;
                case 2:
                  num3 = gclass18_0.method_29(int_0, 2, "pass", string_1, 0.1);
                  continue;
                case 3:
                  num3 = gclass18_0.method_21(2, "login");
                  gclass18_0.method_56(3.0);
                  flag = true;
                  continue;
                default:
                  flag = true;
                  continue;
              }
            }
            else
              goto label_21;
          }
          else
            break;
        }
        num1 = -2;
        goto label_116;
      }
label_21:
      int num4 = 0;
      int num5 = 0;
      while (Environment.TickCount - tickCount < int_1 * 1000)
      {
        switch (gclass18_0.method_41(0.0, "[name=\"login\"]", "[name=\"approvals_code\"]", "#checkpointSubmitButton", "#qf_skip_dialog_skip_link", "#nux-nav-button", "[name=\"n\"]", "[name=\"reset_action\"]", "#checkpointBottomBar"))
        {
          case 1:
          case 7:
            if (num4 == 0 && num5 == 0)
            {
              string str1 = "";
              switch (GClass20.smethod_28(gclass18_0.method_11()))
              {
                case 1:
                  string str2 = gclass18_0.method_20("var out='';var x=document.querySelector('#error_box');if(x!=null) out=x.innerText;return out;").ToString();
                  string str3;
                  if (((IEnumerable<string>) str2.Split(new string[1]
                  {
                    "\r\n"
                  }, StringSplitOptions.RemoveEmptyEntries)).Count<string>() <= 1)
                    str3 = str2;
                  else
                    str3 = str2.Split(new string[1]
                    {
                      "\r\n"
                    }, StringSplitOptions.RemoveEmptyEntries)[1];
                  str1 = str3;
                  break;
                case 2:
                  str1 = gclass18_0.method_20("var out='';var x=document.querySelector('#login_error');if(x!=null) out=x.innerText;return out;").ToString();
                  break;
              }
              if (str1 != "")
                return str1;
              if (gclass18_0.method_38("[href=\"/login/identify/\"]") == 1)
              {
                num1 = 4;
                break;
              }
              if (gclass18_0.method_38("#account_recovery_initiate_view_label") == 1)
              {
                num1 = 5;
                break;
              }
              if (!Convert.ToBoolean(gclass18_0.method_20("return (document.querySelector('[name=\"email\"]').value!='' && document.querySelector('[name=\"pass\"]').value!='')+''").ToString()))
              {
                if (gclass18_0.method_20("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "")
                  num1 = 4;
                else if (gclass18_0.method_20("return document.querySelector('[name=\"pass\"]').value").ToString().Trim() == "")
                  num1 = 5;
                break;
              }
              break;
            }
            if (gclass18_0.method_20("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "")
            {
              num1 = 0;
              goto label_116;
            }
            else
              break;
          case 2:
            if (string_2 == "")
            {
              num1 = 3;
              break;
            }
            if (num4 == 3)
            {
              num1 = 6;
              break;
            }
            string string_8 = GClass19.smethod_85(string_2.Replace(" ", "").Replace("\n", "").Trim());
            if (string_8 != "")
            {
              ++num4;
              gclass18_0.method_29(int_0, 2, "approvals_code", string_8, 0.1);
              gclass18_0.method_56(1.0);
              if (gclass18_0.method_41(0.0, "button#checkpointSubmitButton", "#checkpointSubmitButton [type=\"submit\"]") == 1)
                gclass18_0.method_21(4, "button#checkpointSubmitButton");
              else
                gclass18_0.method_21(4, "#checkpointSubmitButton [type=\"submit\"]");
              gclass18_0.method_56(1.0);
            }
            else
              num1 = 6;
            break;
          case 3:
          case 8:
            if (num4 > 1)
            {
              num1 = 6;
              break;
            }
            int num6;
            if (gclass18_0.method_41(0.0, "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"password_new\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]", "[name=\"code_1\"]", "[action=\"/login/checkpoint/\"] [name=\"contact_index\"]") == 0)
              num6 = GClass20.smethod_45(gclass18_0.method_1(), new List<string>()
              {
                "/checkpoint/dyi",
                "https://www.facebook.com/communitystandards/",
                "help/121104481304395"
              }) ? 1 : 0;
            else
              num6 = 1;
            if (num6 != 0)
            {
              num1 = 2;
              break;
            }
            int num7 = gclass18_0.method_41(0.0, "button#checkpointSubmitButton", "#checkpointSubmitButton [type=\"submit\"]");
            if (num5 < 10)
            {
              if (gclass18_0.method_38("[value=\"dont_save\"]") == 1 & bool_0)
                gclass18_0.method_21(4, "[value=\"dont_save\"]");
              ++num5;
              if (num7 == 1)
                gclass18_0.method_21(4, "button#checkpointSubmitButton");
              else
                gclass18_0.method_21(4, "#checkpointSubmitButton [type=\"submit\"]");
              gclass18_0.method_56(1.0);
            }
            else
              num1 = 0;
            break;
          case 4:
            gclass18_0.method_23(1, "qf_skip_dialog_skip_link");
            gclass18_0.method_56(2.0);
            break;
          case 5:
            gclass18_0.method_21(1, "nux-nav-button");
            gclass18_0.method_56(2.0);
            break;
          case 6:
            num1 = 5;
            break;
          default:
            int num8;
            if (!gclass18_0.method_11().Contains("facebook.com/nt/screen/?params=%7B%22token"))
            {
              if (gclass18_0.method_41(0.0, "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"password_new\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]", "[action=\"/login/checkpoint/\"] [name=\"contact_index\"]") == 0)
              {
                num8 = GClass20.smethod_45(gclass18_0.method_1(), new List<string>()
                {
                  "/checkpoint/dyi",
                  "https://www.facebook.com/communitystandards/",
                  "help/121104481304395"
                }) ? 1 : 0;
                goto label_27;
              }
            }
            num8 = 1;
label_27:
            if (num8 != 0)
            {
              num1 = 2;
              break;
            }
            if (gclass18_0.method_38("a[href*='/friends/']") == 1)
            {
              num1 = 1;
              break;
            }
            if (GClass20.smethod_28(gclass18_0.method_11()) == 2)
            {
              if (gclass18_0.method_11().StartsWith("https://m.facebook.com/zero/policy/optin"))
              {
                gclass18_0.method_56(1.0);
                gclass18_0.method_20("document.querySelector('a[data-sigil=\"touchable\"]').click()");
                gclass18_0.method_56(3.0);
                if (gclass18_0.method_38("button[data-sigil=\"touchable\"]", 10.0) == 1)
                {
                  gclass18_0.method_56(1.0);
                  gclass18_0.method_20("document.querySelector('button[data-sigil=\"touchable\"]').click()");
                  gclass18_0.method_56(3.0);
                }
              }
              if (Convert.ToBoolean(gclass18_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
              {
                for (int index = 0; index < 5; ++index)
                {
                  GClass19.smethod_64(2.0);
                  if (!Convert.ToBoolean(gclass18_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
                    break;
                }
                for (int index = 0; index < 5; ++index)
                {
                  GClass19.smethod_64(2.0);
                  if (!Convert.ToBoolean(gclass18_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
                    break;
                }
                if (gclass18_0.method_38("[href=\"/home.php\"]") == 1)
                  gclass18_0.method_21(4, "[href=\"/home.php\"]");
              }
              if (gclass18_0.method_11().StartsWith("https://m.facebook.com/legal_consent"))
              {
                gclass18_0.method_20("document.querySelector('button').click()");
                gclass18_0.method_56(1.0);
                gclass18_0.method_20("document.querySelectorAll('button')[1].click()");
                gclass18_0.method_56(1.0);
                gclass18_0.method_20("document.querySelector('button').click()");
                gclass18_0.method_56(1.0);
                gclass18_0.method_20("document.querySelectorAll('button')[1].click()");
                gclass18_0.method_56(1.0);
              }
              if (gclass18_0.method_11().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
              {
                gclass18_0.method_21(4, "[data-sigil=\"touchable\"]");
                gclass18_0.method_56(1.0);
              }
              if (gclass18_0.method_38("button[value=\"OK\"]") == 1)
              {
                gclass18_0.method_21(4, "button[value=\"OK\"]");
                gclass18_0.method_56(1.0);
              }
              if (gclass18_0.method_38("[data-store-id=\"2\"]>span") == 1)
              {
                gclass18_0.method_21(4, "[data-store-id=\"2\"]>span");
                gclass18_0.method_56(1.0);
              }
              if (gclass18_0.method_38("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
              {
                gclass18_0.method_21(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
                gclass18_0.method_56(3.0);
                break;
              }
              break;
            }
            if (gclass18_0.method_11().StartsWith("https://www.facebook.com/legal_consent"))
            {
              for (int index = 0; index < 5 && gclass18_0.method_38("button") == 1; ++index)
              {
                gclass18_0.method_20("document.querySelector('button').click()");
                gclass18_0.method_56(1.0);
              }
              break;
            }
            break;
        }
        if (num1 != 0)
          break;
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79(gclass18_0, ex, "Error Login Uid Pass");
    }
label_116:
    return num1.ToString() ?? "";
  }

  public static int smethod_32(
    GClass18 gclass18_0,
    string string_0,
    string string_1,
    string string_2 = "",
    string string_3 = "https://www.facebook.com",
    int int_0 = 0)
  {
    Random random_1 = new Random();
    int num1 = 0;
    int num2 = 0;
    try
    {
      int num3 = 0;
      if (gclass18_0.method_11().StartsWith("https://www.facebook") || gclass18_0.method_11().StartsWith("https://facebook") || gclass18_0.method_11().StartsWith("https://web.facebook"))
        num3 = 1;
      else if (gclass18_0.method_11().StartsWith("https://m.facebook") || gclass18_0.method_11().StartsWith("https://mobile.facebook"))
        num3 = 2;
      if (num3 == 0)
      {
        if (gclass18_0.method_12(string_3) != -2)
        {
          if (gclass18_0.method_11().StartsWith("https://www.facebook") || gclass18_0.method_11().StartsWith("https://facebook"))
            num3 = 1;
          else if (gclass18_0.method_11().StartsWith("https://m.facebook"))
            num3 = 2;
        }
        else
        {
          num1 = -2;
          goto label_88;
        }
      }
      if (gclass18_0.method_38("[data-cookiebanner=\"accept_button\"]") == 1)
      {
        gclass18_0.method_21(4, "[data-cookiebanner=\"accept_button\"]");
        gclass18_0.method_56(1.0);
      }
      if (num3 == 1)
      {
        gclass18_0.method_14("https://www.facebook.com/login");
        if (gclass18_0.method_38("[data-cookiebanner=\"accept_button\"]") == 1)
        {
          gclass18_0.method_21(4, "[data-cookiebanner=\"accept_button\"]");
          gclass18_0.method_56(1.0);
        }
        gclass18_0.method_56(1.0);
        switch (int_0)
        {
          case 0:
            num2 = gclass18_0.method_28(Class54.random_0, 1, "email", string_0, 0.1);
            break;
          case 1:
            num2 = gclass18_0.method_26(1, "email", string_0, 0.1);
            break;
          case 2:
            num2 = gclass18_0.method_24(1, "email", string_0);
            break;
        }
        if (num2 == -2)
        {
          num1 = -2;
          goto label_88;
        }
        else
        {
          gclass18_0.method_56(1.0);
          switch (int_0)
          {
            case 0:
              num2 = gclass18_0.method_28(Class54.random_0, 1, "pass", string_1, 0.1);
              break;
            case 1:
              num2 = gclass18_0.method_26(1, "pass", string_1, 0.1);
              break;
            case 2:
              num2 = gclass18_0.method_24(1, "pass", string_1);
              break;
          }
          if (num2 == -2)
          {
            num1 = -2;
          }
          else
          {
            gclass18_0.method_56(1.0);
            if (gclass18_0.method_21(1, "loginbutton") != -2)
            {
              gclass18_0.method_56(1.0);
              if (gclass18_0.method_38("#approvals_code", 5.0) == 1 && string_2 != "")
              {
                string string_8 = GClass19.smethod_85(string_2.Replace(" ", "").Replace("\n", ""));
                if (string_8 != "")
                {
                  gclass18_0.method_26(1, "approvals_code", string_8, 0.1);
                  gclass18_0.method_56(1.0);
                  gclass18_0.method_21(1, "checkpointSubmitButton");
                  gclass18_0.method_56(1.0);
                }
              }
              int num4 = 0;
              while (gclass18_0.method_38("#checkpointSubmitButton", 3.0) == 1)
              {
                if (gclass18_0.method_2())
                {
                  if (!GClass20.smethod_36(gclass18_0) && num4 != 7)
                  {
                    gclass18_0.method_21(1, "checkpointSubmitButton");
                    gclass18_0.method_56(1.0);
                    ++num4;
                  }
                  else
                    break;
                }
                else
                {
                  num1 = -2;
                  goto label_88;
                }
              }
              goto label_86;
            }
            else
              num1 = -2;
          }
          goto label_88;
        }
      }
      else
      {
        gclass18_0.method_14("https://m.facebook.com/login");
        if (gclass18_0.method_38("[data-cookiebanner=\"accept_button\"]") == 1)
        {
          gclass18_0.method_21(4, "[data-cookiebanner=\"accept_button\"]");
          gclass18_0.method_56(1.0);
        }
        switch (gclass18_0.method_38("[data-sigil=\"login_profile_form\"] div[role=\"button\"]", 1.0))
        {
          case -2:
            num1 = -2;
            break;
          case 1:
            gclass18_0.method_31();
            if (gclass18_0.method_21(4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") != -2)
            {
              gclass18_0.method_31(2);
              switch (gclass18_0.method_41(10.0, "[name=\"pass\"]", "#approvals_code"))
              {
                case -2:
                  num1 = -2;
                  goto label_88;
                case 1:
                  switch (int_0)
                  {
                    case 0:
                      num2 = gclass18_0.method_28(random_1, 2, "pass", string_1, 0.1);
                      break;
                    case 1:
                      num2 = gclass18_0.method_26(2, "pass", string_1, 0.1);
                      break;
                    case 2:
                      num2 = gclass18_0.method_24(2, "pass", string_1);
                      break;
                  }
                  if (num2 == 1)
                  {
                    gclass18_0.method_31();
                    if (gclass18_0.method_21(4, gclass18_0.method_5("button", "data-sigil", "password_login_button")) == 1)
                      gclass18_0.method_56(1.0);
                    goto label_69;
                  }
                  else
                    goto label_69;
                default:
                  goto label_69;
              }
            }
            else
            {
              num1 = -2;
              break;
            }
          default:
            switch (int_0)
            {
              case 0:
                num2 = gclass18_0.method_28(random_1, 1, "m_login_email", string_0, 0.1);
                break;
              case 1:
                num2 = gclass18_0.method_26(1, "m_login_email", string_0, 0.1);
                break;
              case 2:
                num2 = gclass18_0.method_24(1, "m_login_email", string_0);
                break;
            }
            if (num2 == 1)
            {
              gclass18_0.method_31();
              string string_7 = gclass18_0.method_41(3.0, "#m_login_password", "[name=\"pass\"]") == 1 ? "#m_login_password" : "[name=\"pass\"]";
              switch (int_0)
              {
                case 0:
                  gclass18_0.method_28(random_1, 4, string_7, string_1, 0.1);
                  break;
                case 1:
                  gclass18_0.method_26(4, string_7, string_1, 0.1);
                  break;
                case 2:
                  gclass18_0.method_24(4, string_7, string_1);
                  break;
              }
              gclass18_0.method_31();
              gclass18_0.method_21(2, "login");
              gclass18_0.method_31();
              goto label_69;
            }
            else
              goto label_69;
        }
        goto label_88;
label_69:
        int num5 = 0;
        while (gclass18_0.method_38("#checkpointSubmitButton-actual-button", 3.0) == 1)
        {
          int num6 = gclass18_0.method_41(2.0, "#approvals_code", "[name=\"approvals_code\"]");
          if (num6 != 0)
          {
            string string_7 = num6 == 1 ? "#approvals_code" : "[name=\"approvals_code\"]";
            if (string_2.Trim() != "")
            {
              string string_8 = "";
              for (int index = 0; index < 10; ++index)
              {
                string_8 = GClass19.smethod_85(string_2);
                if (!(string_8 != ""))
                  GClass19.smethod_64(1.0);
                else
                  break;
              }
              if (string_8 != "")
              {
                gclass18_0.method_26(4, string_7, string_8, 0.1);
                gclass18_0.method_31(-1);
                gclass18_0.method_21(1, "checkpointSubmitButton-actual-button");
                gclass18_0.method_31();
              }
              else
                GClass19.smethod_81((Exception) null, "Khong Lay Duoc 2FA: " + string_2);
              num5 = 0;
            }
          }
          if (gclass18_0.method_2())
          {
            if (!GClass20.smethod_36(gclass18_0) && num5 != 10)
            {
              gclass18_0.method_21(1, "checkpointSubmitButton-actual-button");
              gclass18_0.method_31();
              ++num5;
            }
            else
              break;
          }
          else
          {
            num1 = -2;
            goto label_88;
          }
        }
      }
label_86:
      gclass18_0.method_56(1.0);
      return GClass20.smethod_34(gclass18_0);
    }
    catch (Exception ex)
    {
      GClass19.smethod_79(gclass18_0, ex, "Login Uid Pass Fail");
    }
label_88:
    return num1;
  }

  public static string smethod_33(GClass18 gclass18_0, string string_0)
  {
    bool flag = false;
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string str4 = "";
    string str5 = "";
    string str6 = "";
    string str7 = "";
    try
    {
      JObject jobject = JObject.Parse(GClass20.smethod_38(gclass18_0, "https://graph.facebook.com/v2.11/me?fields=name,email,gender,birthday&access_token=" + string_0, "https://graph.facebook.com/"));
      flag = true;
      str1 = jobject["name"].ToString();
      try
      {
        str2 = jobject["gender"].ToString();
      }
      catch
      {
      }
      try
      {
        str3 = jobject["birthday"].ToString();
      }
      catch
      {
      }
      try
      {
        str5 = jobject["email"].ToString();
      }
      catch
      {
      }
    }
    catch
    {
    }
    return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", (object) flag, (object) str1, (object) str2, (object) str3, (object) str4, (object) str5, (object) str6, (object) str7);
  }

  public static int smethod_34(GClass18 gclass18_0, string string_0 = "https://m.facebook.com")
  {
    try
    {
      if (gclass18_0.method_3())
        return -2;
      if (GClass20.smethod_28(gclass18_0.method_11()) == 0)
        gclass18_0.method_12(string_0);
      string str = gclass18_0.method_11();
      if (str.Contains("facebook.com/checkpoint/") || str.Contains("facebook.com/nt/screen/?params=%7B%22token") || str.Contains("facebook.com/x/checkpoint/"))
        return 2;
      switch (GClass20.smethod_29(gclass18_0, string_0))
      {
        case 1:
          if (gclass18_0.method_11().StartsWith("https://www.facebook.com/legal_consent"))
          {
            for (int index = 0; index < 5 && gclass18_0.method_38("button") == 1; ++index)
            {
              gclass18_0.method_20("document.querySelector('button').click()");
              gclass18_0.method_56(1.0);
            }
            break;
          }
          break;
        case 2:
          if (gclass18_0.method_11().StartsWith("https://m.facebook.com/zero/policy/optin"))
          {
            gclass18_0.method_56(1.0);
            gclass18_0.method_20("document.querySelector('a[data-sigil=\"touchable\"]').click()");
            gclass18_0.method_56(3.0);
            if (gclass18_0.method_38("button[data-sigil=\"touchable\"]", 10.0) == 1)
            {
              gclass18_0.method_56(1.0);
              gclass18_0.method_20("document.querySelector('button[data-sigil=\"touchable\"]').click()");
              gclass18_0.method_56(3.0);
            }
          }
          if (Convert.ToBoolean(gclass18_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
          {
            for (int index = 0; index < 5; ++index)
            {
              GClass19.smethod_64(2.0);
              if (!Convert.ToBoolean(gclass18_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
                break;
            }
            for (int index = 0; index < 5; ++index)
            {
              GClass19.smethod_64(2.0);
              if (!Convert.ToBoolean(gclass18_0.method_20("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
                break;
            }
            if (gclass18_0.method_38("[href=\"/home.php\"]") == 1)
              gclass18_0.method_21(4, "[href=\"/home.php\"]");
          }
          if (gclass18_0.method_11().StartsWith("https://m.facebook.com/legal_consent"))
          {
            gclass18_0.method_20("document.querySelector('button').click()");
            gclass18_0.method_56(1.0);
            gclass18_0.method_20("document.querySelectorAll('button')[1].click()");
            gclass18_0.method_56(1.0);
            gclass18_0.method_20("document.querySelector('button').click()");
            gclass18_0.method_56(1.0);
            gclass18_0.method_20("document.querySelectorAll('button')[1].click()");
            gclass18_0.method_56(1.0);
          }
          if (gclass18_0.method_11().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
          {
            gclass18_0.method_21(4, "[data-sigil=\"touchable\"]");
            gclass18_0.method_56(1.0);
          }
          if (gclass18_0.method_38("button[value=\"OK\"]") == 1)
          {
            gclass18_0.method_21(4, "button[value=\"OK\"]");
            gclass18_0.method_56(1.0);
          }
          if (gclass18_0.method_38("[data-store-id=\"2\"]>span") == 1)
          {
            gclass18_0.method_21(4, "[data-store-id=\"2\"]>span");
            gclass18_0.method_56(1.0);
          }
          if (gclass18_0.method_38("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
          {
            gclass18_0.method_21(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
            gclass18_0.method_56(3.0);
            break;
          }
          break;
      }
      GClass20.smethod_44(gclass18_0, true);
      switch (gclass18_0.GEnum11_0)
      {
        case GEnum11.const_1:
          return -2;
        case GEnum11.const_2:
        case GEnum11.const_3:
          return 0;
        case GEnum11.const_4:
          return 2;
        case GEnum11.const_5:
          return 1;
        case GEnum11.const_6:
          return -3;
      }
    }
    catch
    {
    }
    return 0;
  }

  public static bool smethod_35(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0.method_41(0.0, "#checkpointSubmitButton", "#captcha_response", "[name=\"verification_method\"]", "#checkpointBottomBar", "[href =\"https://www.facebook.com/communitystandards/\"]") > 0)
        return true;
    }
    catch
    {
    }
    return false;
  }

  public static bool smethod_36(GClass18 gclass18_0)
  {
    try
    {
      if (gclass18_0.method_41(0.0, "[name=\"captcha_response\"]", "#captcha_response", "[name=\"password_new\"]", "[name=\"verification_method\"]", "[href =\"https://www.facebook.com/communitystandards/\"]") > 0)
        return true;
    }
    catch
    {
    }
    return false;
  }

  public static string smethod_37(GClass18 gclass18_0)
  {
    string str = "";
    try
    {
      if (!gclass18_0.method_11().Contains("https://business.facebook.com/"))
        gclass18_0.method_12("https://business.facebook.com/");
      str = (string) gclass18_0.method_20("async function GetTokenEaag() { var output = ''; try { var response = await fetch('https://business.facebook.com/content_management/'); if (response.ok) { var body = await response.text(); output=body.match(new RegExp('EAAG(.*?)\"'))[0].replace('\"',''); } } catch {} return output; }; var c = await GetTokenEaag(); return c;");
    }
    catch
    {
    }
    return str;
  }

  public static string smethod_38(GClass18 gclass18_0, string string_0, string string_1)
  {
    try
    {
      if (!gclass18_0.method_11().StartsWith(string_1))
        gclass18_0.method_12(string_1);
      return (string) gclass18_0.method_20("async function RequestGet() { var output = ''; try { var response = await fetch('" + string_0 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
    }
    catch
    {
    }
    return "";
  }

  public static string smethod_39(
    GClass18 gclass18_0,
    string string_0,
    string string_1,
    string string_2,
    string string_3 = "application/x-www-form-urlencoded")
  {
    try
    {
      if (!gclass18_0.method_11().StartsWith(string_2))
        gclass18_0.method_12(string_2);
      gclass18_0.method_56(1.0);
      string_1 = string_1.Replace("\n", "\\n").Replace("\"", "\\\"");
      return (string) gclass18_0.method_20("async function RequestPost() { var output = ''; try { var response = await fetch('" + string_0 + "', { method: 'POST', body: '" + string_1 + "', headers: { 'Content-Type': '" + string_3 + "' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
    }
    catch
    {
    }
    return "";
  }

  public static string smethod_40(GClass18 gclass18_0, string string_0)
  {
    string str = "";
    try
    {
      if (!gclass18_0.method_11().Contains("https://graph.facebook.com/"))
        gclass18_0.method_12("https://graph.facebook.com/");
      JObject jobject = JObject.Parse((string) gclass18_0.method_20("async function RequestGet() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me?fields=id,birthday,name&access_token=" + string_0 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;"));
      return jobject["id"].ToString() + "|" + jobject["birthday"].ToString() + "|" + jobject["name"].ToString();
    }
    catch
    {
    }
    return str;
  }

  public static List<string> smethod_41(GClass18 gclass18_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      if (!gclass18_0.method_11().Contains("https://mbasic.facebook.com/"))
        gclass18_0.method_12("https://mbasic.facebook.com/");
      string input = (string) gclass18_0.method_20("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com/messages/'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
      int num = 1;
      string str1;
      do
      {
        MatchCollection matchCollection = Regex.Matches(input, "#fua\">(.*?)<");
        for (int i = 0; i < matchCollection.Count; ++i)
        {
          try
          {
            string str2 = WebUtility.HtmlDecode(matchCollection[i].Groups[1].Value.Replace("\"", ""));
            if (!stringList.Contains(str2))
              stringList.Add(str2);
          }
          catch
          {
          }
        }
        str1 = Regex.Match(input, "/messages/.pageNum=(.*?)\"").Value.Replace("amp;", "");
        input = (string) gclass18_0.method_20("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com" + str1 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
        ++num;
      }
      while (num < 5 && str1 != "");
    }
    catch
    {
    }
    return stringList;
  }

  public static List<string> smethod_42(GClass18 gclass18_0, int int_0)
  {
    List<string> stringList1 = new List<string>();
    try
    {
      if (!gclass18_0.method_11().Contains("https://mbasic.facebook.com/"))
        gclass18_0.method_12("https://mbasic.facebook.com/");
      string format = "https://mbasic.facebook.com/{0}/allactivity/?category_key=commentscluster&timestart={1}&timeend={2}";
      string str1 = gclass18_0.method_20("return (document.cookie + ';').match(new RegExp('c_user=(.*?);'))[1]").ToString();
      List<string> stringList2 = new List<string>();
      for (int index = 0; index < int_0; ++index)
      {
        DateTime now = DateTime.Now;
        DateTime dateTime1 = now.AddMonths(2 - index);
        now = DateTime.Now;
        DateTime dateTime2 = now.AddMonths(1 - index);
        double num = GClass19.smethod_74(new DateTime(dateTime1.Year, dateTime1.Month, 1));
        string str2 = num.ToString();
        num = GClass19.smethod_74(new DateTime(dateTime2.Year, dateTime2.Month, 1));
        string str3 = num.ToString();
        string str4 = string.Format(format, (object) str1, (object) str2, (object) str3);
        stringList2.Add(str4);
      }
      for (int index = 0; index < stringList2.Count; ++index)
      {
        string string_0 = stringList2[index];
        bool flag;
        do
        {
          flag = false;
          string input1 = WebUtility.HtmlDecode(GClass20.smethod_38(gclass18_0, string_0, "https://mbasic.facebook.com/"));
          MatchCollection matchCollection1 = Regex.Matches(input1, "<span>(.*?)</h4>");
          for (int i1 = 0; i1 < matchCollection1.Count; ++i1)
          {
            string str5 = matchCollection1[i1].Groups[1].Value;
            string input2 = str5.Substring(0, str5.LastIndexOf('<'));
            MatchCollection matchCollection2 = Regex.Matches(input2, "<(.*?)>");
            for (int i2 = 0; i2 < matchCollection2.Count; ++i2)
              input2 = input2.Replace(matchCollection2[i2].Value, "");
            if (input2 != "" && !stringList1.Contains(input2))
              stringList1.Add(input2);
          }
          if (Regex.IsMatch(input1, "/" + str1 + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\""))
          {
            string_0 = "https://mbasic.facebook.com" + Regex.Match(input1, "/" + str1 + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\"").Value.Replace("\"", "");
            flag = true;
          }
        }
        while (flag);
      }
    }
    catch
    {
    }
    return stringList1;
  }

  public static List<string> smethod_43(GClass18 gclass18_0, string string_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      if (!gclass18_0.method_11().Contains("https://graph.facebook.com/"))
        gclass18_0.method_12("https://graph.facebook.com/");
      JObject jobject = JObject.Parse((string) gclass18_0.method_20("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me/friends?limit=5000&fields=id,name&access_token=" + string_0 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;"));
      if (jobject["data"].Count<JToken>() > 0)
      {
        for (int key = 0; key < jobject["data"].Count<JToken>(); ++key)
        {
          string str1 = jobject["data"][(object) key][(object) "id"].ToString();
          string str2 = jobject["data"][(object) key][(object) "name"].ToString();
          stringList.Add(str1 + "|" + str2);
        }
      }
    }
    catch
    {
    }
    return stringList;
  }

  internal static void smethod_44(GClass18 gclass18_0, bool bool_0)
  {
    try
    {
      if (gclass18_0.method_3())
      {
        gclass18_0.GEnum11_0 = GEnum11.const_1;
      }
      else
      {
        string str1 = "";
        if (bool_0)
          str1 = GClass20.smethod_38(gclass18_0, "https://m.facebook.com/login", "https://m.facebook.com/");
        if (str1 == "")
          str1 = gclass18_0.method_1();
        if (str1 == null || str1 == "" || str1 == "-2")
          gclass18_0.GEnum11_0 = GEnum11.const_1;
        else if (str1.Contains("error-information-popup-content") || str1.Contains("suggestionsSummaryList"))
          gclass18_0.GEnum11_0 = GEnum11.const_6;
        else if (Regex.IsMatch(str1, "login_form"))
          gclass18_0.GEnum11_0 = GEnum11.const_2;
        else if (Regex.IsMatch(str1, "login_profile_form") || Regex.IsMatch(str1, "/login/device-based/validate-pin"))
          gclass18_0.GEnum11_0 = GEnum11.const_3;
        else if (Convert.ToBoolean(gclass18_0.method_20("var kq=false;if(document.querySelector('#mErrorView')!=null && !document.querySelector('#mErrorView').getAttribute('style').includes('display:none')) kq=true;return kq+''")) || Regex.IsMatch(str1, "href=\"https://m.facebook.com/login.php"))
        {
          gclass18_0.GEnum11_0 = GEnum11.const_3;
        }
        else
        {
          string str2 = gclass18_0.method_11();
          int num;
          if (!str2.Contains("facebook.com/checkpoint/") && !str2.Contains("facebook.com/nt/screen/?params=%7B%22token") && !str2.Contains("facebook.com/x/checkpoint/"))
            num = GClass20.smethod_45(str1, new List<string>()
            {
              "verification_method",
              "checkpointBottomBar",
              "submit[Yes]",
              "password_new",
              "send_code",
              "/checkpoint/dyi",
              "captcha_response",
              "https://www.facebook.com/communitystandards/",
              "help/121104481304395"
            }) ? 1 : 0;
          else
            num = 1;
          if (num != 0)
          {
            gclass18_0.GEnum11_0 = GEnum11.const_4;
          }
          else
          {
            if (!Regex.IsMatch(str1, "/friends/") && gclass18_0.method_38("a[href*='/friends/']") != 1 && !(str2 == "https://m.facebook.com/home.php?ref=wizard&_rdr"))
              return;
            gclass18_0.GEnum11_0 = GEnum11.const_5;
          }
        }
      }
    }
    catch
    {
    }
  }

  public static bool smethod_45(string string_0, List<string> list_0)
  {
    int index = 0;
    while (true)
    {
      if (index < list_0.Count)
      {
        if (!Regex.IsMatch(string_0, list_0[index]))
          ++index;
        else
          goto label_5;
      }
      else
        break;
    }
    return false;
label_5:
    return true;
  }

  public static List<string> smethod_46(
    GClass18 gclass18_0,
    string string_0,
    string string_1,
    string string_2,
    int int_0 = 20)
  {
    List<string> stringList = new List<string>();
    try
    {
      if (!gclass18_0.method_11().Contains("https://graph.facebook.com/"))
        gclass18_0.method_12("https://graph.facebook.com/");
      string json = (string) gclass18_0.method_20("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/" + string_0 + "/photos?fields=images&limit=" + int_0.ToString() + "&access_token=" + string_2 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
      JObject jobject = JObject.Parse(json);
      if (jobject != null && json.Contains("images"))
      {
        for (int key1 = 0; key1 < jobject["data"].Count<JToken>(); ++key1)
        {
          int key2 = jobject["data"][(object) key1][(object) "images"].ToList<JToken>().Count - 1;
          stringList.Add(string_0 + "*" + string_1 + "*" + jobject["data"][(object) key1][(object) "images"][(object) key2][(object) "source"]?.ToString() + "|" + jobject["data"][(object) key1][(object) "images"][(object) key2][(object) "width"]?.ToString() + "|" + jobject["data"][(object) key1][(object) "images"][(object) key2][(object) "height"]?.ToString());
        }
      }
    }
    catch
    {
    }
    return stringList;
  }

  public static bool smethod_47(GClass18 gclass18_0)
  {
    bool flag = true;
    string str = "";
    switch (gclass18_0.method_41(2.0, "[data-sigil=\" m-overlay-layer\"] button", "[data-sigil=\" m-overlay-layer\"] [value=\"OK\"]", "[data-sigil=\"touchable m-error-overlay-done\"]", "[data-sigil=\"touchable m-overlay-layer\"]", "[data-sigil=\"touchable m-error-overlay-cancel\"]"))
    {
      case 0:
        flag = false;
        break;
      case 1:
        str = "[data-sigil=\" m-overlay-layer\"] button";
        break;
      case 2:
        str = "[data-sigil=\" m-overlay-layer\"] [value=\"OK\"]";
        break;
      case 3:
        str = "[data-sigil=\"touchable m-error-overlay-done\"]";
        break;
      case 4:
        str = "[data-sigil=\"touchable m-overlay-layer\"]";
        break;
      case 5:
        str = "[data-sigil=\"touchable m-error-overlay-cancel\"]";
        break;
    }
    if (str != "")
      gclass18_0.method_20("document.querySelector('" + str + "').click();");
    return flag;
  }

  public static string smethod_48(GClass18 gclass18_0)
  {
    try
    {
      return Regex.Match(GClass20.smethod_38(gclass18_0, "https://m.facebook.com/help/", "https://m.facebook.com"), GClass19.smethod_58("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
    }
    catch
    {
      return "";
    }
  }

  public static List<string> smethod_49(GClass18 gclass18_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      string str1 = GClass20.smethod_48(gclass18_0);
      string str2 = Regex.Match(gclass18_0.method_51(), "c_user=(.*?);").Groups[1].Value;
      string string_0 = "https://www.facebook.com/ajax/typeahead/first_degree.php?fb_dtsg_ag=" + str1 + "&filter%5B0%5D=group&viewer=" + str2 + "&__user=" + str2 + "&__a=1&__dyn=&__comet_req=0&jazoest=26581";
      foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(GClass20.smethod_38(gclass18_0, string_0, "https://www.facebook.com/ajax/typeahead/first_degree.php").Replace("for (;;);", ""))["payload"][(object) "entries"])
      {
        try
        {
          stringList.Add(string.Format("{0}|{1}|{2}", (object) jtoken[(object) "uid"], (object) jtoken[(object) "text"], (object) jtoken[(object) "size"]));
        }
        catch
        {
        }
      }
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }
}
