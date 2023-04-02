// Decompiled with JetBrains decompiler
// Type: Class76
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

internal class Class76
{
  private static object object_0 = new object();
  public static int int_0 = 0;
  public static int int_1 = 10;
  public static object object_1 = new object();

  private static string smethod_0()
  {
    string str1 = "";
    string str2 = GClass19.smethod_63("netstat -ano | findstr :4723");
    if (!(str2 != ""))
      return "";
    string str3 = str2;
    char[] chArray = new char[1]{ '\n' };
    foreach (string str4 in ((IEnumerable<string>) str3.Split(chArray)).ToList<string>())
    {
      if (str4.Contains("LISTENING"))
        str1 = ((IEnumerable<string>) str4.Split(' ')).Last<string>();
    }
    return str1;
  }

  public static bool smethod_1() => Class76.smethod_0() != "";

  public static void smethod_2()
  {
    string str = Class76.smethod_0();
    if (string.IsNullOrEmpty(str))
      return;
    GClass19.smethod_63("taskkill /pid " + str + " /F");
  }

  public static void smethod_3()
  {
    lock (Class76.object_0)
    {
      if (Class76.smethod_1())
        return;
      try
      {
        if (!File.Exists("appium.bat"))
          File.WriteAllText("appium.bat", "node \"%appdata%\\npm\\node_modules\\appium\\build\\lib\\main\"");
        Process.Start("appium.bat");
      }
      catch
      {
      }
      for (int index = 0; index < 30 && !Class76.smethod_1(); ++index)
        GClass19.smethod_64(1.0);
    }
  }

  public static string smethod_4(string string_0)
  {
    string str = "";
    try
    {
      List<string> stringList = new List<string>();
      foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(Class76.smethod_5())["value"])
      {
        if (jtoken[(object) "capabilities"][(object) "deviceName"].ToString() == string_0)
          stringList.Add(jtoken[(object) "id"].ToString());
      }
      if (stringList.Count == 1)
        str = stringList[0];
      else if (stringList.Count > 1)
      {
        foreach (string string_11 in stringList)
        {
          GClass27 gclass27 = new GClass27("");
          gclass27.method_2(string_11);
          gclass27.method_17();
        }
      }
    }
    catch (Exception ex)
    {
    }
    return str;
  }

  public static string smethod_5()
  {
    try
    {
      string str;
      while (true)
      {
        str = new GClass24("", "", "", 0).method_0("http://localhost:4723/wd/hub/sessions");
        if (str.Contains("cannot_connect"))
          Class76.smethod_3();
        else
          break;
      }
      return str;
    }
    catch (Exception ex)
    {
    }
    return "";
  }
}
