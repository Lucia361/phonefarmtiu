// Decompiled with JetBrains decompiler
// Type: GClass22
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GClass22
{
  private string string_0;
  private JObject jobject_0;

  public GClass22(string string_1, bool bool_0 = false)
  {
    if (bool_0)
    {
      if (string_1.Trim() == "")
        string_1 = "{}";
      this.jobject_0 = JObject.Parse(string_1);
    }
    else
    {
      try
      {
        this.string_0 = !string_1.Contains("\\") && !string_1.Contains("/") ? "settings\\" + string_1 + ".json" : string_1;
        if (!File.Exists(this.string_0))
        {
          using (File.AppendText(this.string_0))
            ;
        }
        this.jobject_0 = JObject.Parse(File.ReadAllText(this.string_0));
      }
      catch
      {
        this.jobject_0 = new JObject();
      }
    }
  }

  public Dictionary<string, object> method_0(JObject jobject_1 = null)
  {
    Dictionary<string, object> dic = new Dictionary<string, object>();
    try
    {
      dic = jobject_1.ToObject<Dictionary<string, object>>();
      List<string> list = dic.Select(r =>
      {
        var data = new{ value = r, key = r.Key };
        return data;
      }).Where(x => x.value.GetType() == typeof (JObject)).Select(x => x.key).ToList<string>();
      dic.Select(r =>
      {
        var data = new{ value = r, key = r.Key };
        return data;
      }).Where(x => x.value.GetType() == typeof (JObject)).Select(x => x.key).ToList<string>().ForEach((Action<string>) (key => dic[key] = (object) ((IEnumerable<JToken>) dic[key]).Values().Select<JToken, object>((Func<JToken, object>) (x => ((JValue) x).Value)).ToArray<object>()));
      list.ForEach((Action<string>) (key => dic[key] = (object) this.method_0(dic[key] as JObject)));
    }
    catch
    {
    }
    return dic;
  }

  public GClass22() => this.jobject_0 = new JObject();

  public string method_1(string string_1, string string_2 = "")
  {
    string str = string_2;
    try
    {
      str = this.jobject_0[string_1] == null ? string_2 : this.jobject_0[string_1].ToString();
    }
    catch
    {
    }
    return str;
  }

  public List<string> method_2(string string_1, int int_0 = 0)
  {
    List<string> list_0 = new List<string>();
    try
    {
      List<string> list;
      if (int_0 == 0)
        list = ((IEnumerable<string>) this.method_1(string_1).Split('\n')).ToList<string>();
      else
        list = ((IEnumerable<string>) this.method_1(string_1).Split(new string[1]
        {
          "\n|\n"
        }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();
      list_0 = list;
      list_0 = GClass19.smethod_39(list_0);
    }
    catch
    {
    }
    return list_0;
  }

  public int method_3(string string_1, int int_0 = 0)
  {
    int num = int_0;
    try
    {
      num = this.jobject_0[string_1] == null ? int_0 : Convert.ToInt32(this.jobject_0[string_1].ToString());
    }
    catch
    {
    }
    return num;
  }

  public bool method_4(string string_1, bool bool_0 = false)
  {
    bool flag = bool_0;
    try
    {
      return this.jobject_0[string_1] == null ? bool_0 : Convert.ToBoolean(this.jobject_0[string_1].ToString());
    }
    catch
    {
      return flag;
    }
  }

  public void method_5(string string_1, string string_2)
  {
    try
    {
      if (!this.jobject_0.ContainsKey(string_1))
        this.jobject_0.Add(string_1, (JToken) string_2);
      else
        this.jobject_0[string_1] = (JToken) string_2;
    }
    catch (Exception ex)
    {
    }
  }

  public void method_6(string string_1, object object_0)
  {
    try
    {
      this.jobject_0[string_1] = (JToken) object_0.ToString();
    }
    catch
    {
    }
  }

  public void method_7(string string_1, List<string> list_0, int int_0 = 0)
  {
    try
    {
      this.jobject_0[string_1] = (JToken) string.Join("\n", (IEnumerable<string>) list_0).ToString();
      if (int_0 == 0)
        this.jobject_0[string_1] = (JToken) string.Join("\n", (IEnumerable<string>) list_0).ToString();
      else
        this.jobject_0[string_1] = (JToken) string.Join("\n|\n", (IEnumerable<string>) list_0).ToString();
    }
    catch
    {
    }
  }

  public void method_8(string string_1, List<string> list_0)
  {
    try
    {
      bool flag = false;
      foreach (string str in list_0)
      {
        if (str.Contains("\n"))
        {
          flag = true;
          break;
        }
      }
      if (flag)
        this.jobject_0[string_1] = (JToken) string.Join("\n|\n", (IEnumerable<string>) list_0).ToString();
      else
        this.jobject_0[string_1] = (JToken) string.Join("\n", (IEnumerable<string>) list_0).ToString();
    }
    catch
    {
    }
  }

  public void method_9(string string_1)
  {
    try
    {
      this.jobject_0.Remove(string_1);
    }
    catch
    {
    }
  }

  public void method_10(string string_1 = "")
  {
    try
    {
      if (string_1 == "")
        string_1 = this.string_0;
      File.WriteAllText(string_1, this.jobject_0.ToString());
    }
    catch
    {
    }
  }

  public string method_11()
  {
    string str = "";
    try
    {
      str = this.jobject_0.ToString().Replace("\r\n", "");
    }
    catch (Exception ex)
    {
    }
    return str;
  }
}
