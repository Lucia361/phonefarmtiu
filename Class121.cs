// Decompiled with JetBrains decompiler
// Type: Class121
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System.Collections.Generic;
using System.Data;
using System.Linq;

internal class Class121
{
  private static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();
  public static bool bool_0 = false;

  public static string smethod_0(string string_0)
  {
    if (!Class121.bool_0)
      return "";
    string str = "";
    if (Class121.dictionary_0.ContainsKey(string_0))
      str = Class121.dictionary_0[string_0];
    return str;
  }

  public static void smethod_1(string string_0, string string_1)
  {
    if (!Class121.bool_0)
      return;
    if (Class121.dictionary_0.ContainsKey(string_0))
      Class121.dictionary_0[string_0] = string_1;
    else
      Class121.dictionary_0.Add(string_0, string_1);
  }

  public static void smethod_2()
  {
    if (!Class121.bool_0)
      return;
    Class121.dictionary_0 = Class42.smethod_8().AsEnumerable().ToDictionary<DataRow, string, string>((System.Func<DataRow, string>) (dataRow_0 => dataRow_0[0].ToString()), (System.Func<DataRow, string>) (dataRow_0 => dataRow_0[1].ToString()));
  }

  public static void smethod_3()
  {
    if (!Class121.bool_0)
      return;
    Class42.smethod_32("status", Class121.dictionary_0.Where<KeyValuePair<string, string>>((System.Func<KeyValuePair<string, string>, bool>) (keyValuePair_0 => keyValuePair_0.Value.Trim() != "")).Select<KeyValuePair<string, string>, string>((System.Func<KeyValuePair<string, string>, string>) (keyValuePair_0 => keyValuePair_0.Key + "|" + keyValuePair_0.Value)).ToList<string>());
  }
}
