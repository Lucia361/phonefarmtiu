// Decompiled with JetBrains decompiler
// Type: GClass33
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GClass33
{
  private static Dictionary<string, GClass22> dictionary_0 = new Dictionary<string, GClass22>();

  public static GClass22 smethod_0(string string_0)
  {
    if (!GClass33.dictionary_0.ContainsKey(string_0))
      GClass33.dictionary_0.Add(string_0, new GClass22(string_0));
    return GClass33.dictionary_0[string_0];
  }

  private static void smethod_1(string string_0)
  {
    if (GClass33.dictionary_0.ContainsKey(string_0))
      GClass33.dictionary_0[string_0] = new GClass22(string_0);
    else
      GClass33.dictionary_0.Add(string_0, new GClass22(string_0));
  }

  public static void smethod_2(string string_0)
  {
    if (GClass33.dictionary_0.ContainsKey(string_0))
      GClass33.dictionary_0[string_0].method_10();
    GClass33.smethod_1(string_0);
  }

  public static string smethod_3()
  {
    string str = GClass33.dictionary_0["configGeneral"].method_1("txbPathProfile");
    if (!str.Contains<char>('\\'))
      str = GClass13.smethod_0() + "\\" + (str == "" ? "profiles" : str);
    return !Directory.Exists(str) ? GClass13.smethod_0() + "\\profiles" : str;
  }

  public static string smethod_4() => GClass13.smethod_0() + "\\backup";
}
