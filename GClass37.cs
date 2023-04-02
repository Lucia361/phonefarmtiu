// Decompiled with JetBrains decompiler
// Type: GClass37
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Linq;

public static class GClass37
{
  public static bool smethod_0(List<string> list_0, List<string> list_1)
  {
    List<string> list1 = list_0.Except<string>((IEnumerable<string>) list_1).ToList<string>();
    List<string> list2 = list_1.Except<string>((IEnumerable<string>) list_0).ToList<string>();
    return !list1.Any<string>() && !list2.Any<string>();
  }

  public static List<string> smethod_1(List<string> list_0)
  {
    int count = list_0.Count;
    while (count != 0)
    {
      int index = Class54.random_0.Next(0, list_0.Count);
      --count;
      string str = list_0[count];
      list_0[count] = list_0[index];
      list_0[index] = str;
    }
    return list_0;
  }

  public static List<string> smethod_2(List<string> list_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      for (int index = 0; index < list_0.Count; ++index)
        stringList.Add(list_0[index]);
    }
    catch
    {
    }
    return stringList;
  }

  public static List<List<string>> smethod_3(List<string> list_0, int int_0)
  {
    List<List<string>> stringListList = new List<List<string>>();
    try
    {
      int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / (double) int_0)));
      for (int index = 0; index < int32; ++index)
        stringListList.Add(list_0.GetRange(int_0 * index, int_0 * index + int_0 <= list_0.Count ? int_0 : list_0.Count % int_0));
    }
    catch
    {
    }
    return stringListList;
  }

  public static string smethod_4(List<string> list_0, string string_0 = "\r\n") => string.Join(string_0, (IEnumerable<string>) list_0);

  public static string smethod_5(List<string> list_0)
  {
    string str = "";
    if (list_0.Count > 0)
    {
      str = list_0.Last<string>();
      list_0.RemoveAt(list_0.Count - 1);
    }
    return str;
  }

  public static List<string> smethod_6(List<string> list_0, List<string> list_1)
  {
    foreach (string str in list_1)
      list_0.Remove(str);
    return list_0;
  }

  public static int smethod_7(int int_0) => GClass37.smethod_8(0, int_0 - 1);

  public static int smethod_8(int int_0, int int_1) => Class54.random_0.Next(int_0, int_1 + 1);

  public static int smethod_9(this List<string> list_0) => GClass37.smethod_7(list_0.Count);

  public static string smethod_10(this List<string> list_0) => list_0[list_0.smethod_9()];
}
