// Decompiled with JetBrains decompiler
// Type: Class77
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml;

internal class Class77
{
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  private Random random_0;

  public Class77(string string_0)
  {
    string[] strArray = string_0.Split('[', ',', ']');
    this.int_0 = Convert.ToInt32(strArray[1]);
    this.int_2 = Convert.ToInt32(strArray[4]);
    this.int_1 = Convert.ToInt32(strArray[2]);
    this.int_3 = Convert.ToInt32(strArray[5]);
    this.random_0 = new Random();
  }

  public Class77(int int_4, int int_5, int int_6, int int_7)
  {
    this.int_0 = int_4;
    this.int_1 = int_5;
    this.int_2 = int_6;
    this.int_3 = int_7;
    this.random_0 = new Random();
  }

  public string method_0() => string.Format("[{0},{1}][{2},{3}]", (object) this.int_0, (object) this.int_1, (object) this.int_2, (object) this.int_3);

  internal Point method_1()
  {
    try
    {
      return new Point((this.int_0 + this.int_2) / 2, (this.int_1 + this.int_3) / 2);
    }
    catch (Exception ex)
    {
    }
    return new Point();
  }

  internal int method_2() => this.int_3 - this.int_1;

  internal int method_3() => this.int_2 - this.int_0;

  public Point method_4()
  {
    try
    {
      return new Point(this.random_0.Next(this.int_0, this.int_2 + 1), this.random_0.Next(this.int_1, this.int_3 + 1));
    }
    catch (Exception ex)
    {
    }
    return new Point();
  }

  public static Class77 smethod_0(string string_0, List<string> list_0)
  {
    Class77 class77_1 = (Class77) null;
    try
    {
      Class77 class77_2 = new Class77(string_0);
      for (int index = 0; index < list_0.Count; ++index)
      {
        Class77 class77_3 = new Class77(list_0[index]);
        int int_5 = class77_2.int_1 < class77_3.int_1 ? class77_3.int_1 : class77_2.int_1;
        int int_7 = class77_2.int_3 < class77_3.int_3 ? class77_2.int_3 : class77_3.int_3;
        if (int_5 < int_7)
        {
          class77_1 = new Class77(class77_3.int_0, int_5, class77_3.int_2, int_7);
          break;
        }
      }
    }
    catch
    {
    }
    return class77_1;
  }

  public static List<Class77> smethod_1(string string_0, string string_1)
  {
    Dictionary<int, List<Class77>> source = new Dictionary<int, List<Class77>>();
    foreach (string string_0_1 in Class77.smethod_2(string_0, string_1))
    {
      Class77 class77 = new Class77(string_0_1);
      if (!source.ContainsKey(class77.int_1))
        source.Add(class77.int_1, new List<Class77>());
      source[class77.int_1].Add(class77);
    }
    return source.Count > 0 ? source.OrderByDescending<KeyValuePair<int, List<Class77>>, int>((Func<KeyValuePair<int, List<Class77>>, int>) (keyValuePair_0 => keyValuePair_0.Value.Count)).First<KeyValuePair<int, List<Class77>>>().Value : new List<Class77>();
  }

  public static List<string> smethod_2(string string_0, string string_1, string string_2 = "bounds")
  {
    List<string> stringList = new List<string>();
    try
    {
      string_0 = string_0.ToLower();
      string_1 = string_1.ToLower();
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(string_0);
      XmlNodeList xmlNodeList = xmlDocument.SelectNodes(string_1);
      for (int i = 0; i < xmlNodeList.Count; ++i)
        stringList.Add(xmlNodeList[i].Attributes[string_2].Value);
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }
}
