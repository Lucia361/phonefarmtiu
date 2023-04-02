// Decompiled with JetBrains decompiler
// Type: GClass5
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class GClass5
{
  public static string smethod_0(string string_0)
  {
    string str1 = "";
    if (!string_0.EndsWith("/"))
      string_0 += "/";
    List<string> stringList = new List<string>()
    {
      "story_fbid=(.*?)&",
      "permalink/(.*?)/",
      "v=(.*?)&",
      "post_id=(.*?)&",
      "v=(.*?)/",
      "videos/(.*?)/",
      "videos/(.*?)\\?",
      "posts/(.*?)/",
      "posts/(.*?)\\?",
      "view_tray_pagination/(.*?)/",
      "fbid=(.*?)&",
      "multi_permalinks=(.*?)&"
    };
    for (int index = 0; index < stringList.Count; ++index)
    {
      string str2 = Regex.Match(string_0, stringList[index].Replace("(.*?)", "\\d+")).Value;
      if (str2 != "")
      {
        str1 = str2.Replace(stringList[index].Split(new string[1]
        {
          "(.*?)"
        }, StringSplitOptions.None)[0], "").Replace(stringList[index].Split(new string[1]
        {
          "(.*?)"
        }, StringSplitOptions.None)[1], "").Replace("?", "");
        if (!str1.StartsWith("0"))
          break;
      }
      else
      {
        str1 = Regex.Match(string_0, stringList[index]).Groups[1].Value;
        if (str1 != "" && !str1.Contains("&"))
          break;
      }
    }
    if (str1 == "" && string_0.Contains("photos"))
    {
      MatchCollection matchCollection = Regex.Matches(string_0, "/\\d+/");
      if (matchCollection.Count > 0)
        str1 = matchCollection[matchCollection.Count - 1].Value.Replace("/", "");
    }
    return str1;
  }
}
