// Decompiled with JetBrains decompiler
// Type: GClass12
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

public class GClass12
{
  public static string smethod_0()
  {
    string source = GClass33.smethod_0("configGeneral").method_1("txbPathProfile");
    if (!source.Contains<char>('\\'))
      source = GClass13.smethod_0() + "\\" + (GClass33.smethod_0("configGeneral").method_1("txbPathProfile") == "" ? "profiles" : GClass33.smethod_0("configGeneral").method_1("txbPathProfile"));
    return source;
  }

  public static string smethod_1() => GClass13.smethod_0() + "\\backup";

  public static string smethod_2(int int_0 = 0)
  {
    switch (int_0)
    {
      case 1:
        return GClass33.smethod_0("configGeneral").method_1("txtLDPathThuong").Trim();
      case 2:
        return GClass33.smethod_0("configGeneral").method_1("txtLDPathSwap").Trim();
      default:
        return GClass33.smethod_0("configGeneral").method_4("isRunSwap") ? GClass33.smethod_0("configGeneral").method_1("txtLDPathSwap").Trim() : GClass33.smethod_0("configGeneral").method_1("txtLDPathThuong").Trim();
    }
  }

  public static string smethod_3()
  {
    string str = "";
    try
    {
      string path1 = GClass12.smethod_2() + "\\vms\\config\\leidian0.config";
      string path2 = GClass12.smethod_2() + "\\vms\\config\\leidian1.config";
      if (File.Exists(path2))
        path1 = path2;
      str = JObject.Parse(File.ReadAllText(path1))["statusSettings.sharedPictures"].ToString();
    }
    catch
    {
    }
    return str;
  }
}
