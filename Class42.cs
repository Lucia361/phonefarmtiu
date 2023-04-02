// Decompiled with JetBrains decompiler
// Type: Class42
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

internal class Class42
{
  public static bool smethod_0(string string_0) => GClass17.GClass17_0.method_5("SELECT COUNT(*) FROM files WHERE name='" + string_0 + "' AND active=1;") > 0;

  public static DataTable smethod_1(bool bool_0 = false)
  {
    DataTable dataTable = new DataTable();
    try
    {
      string string_1;
      if (!bool_0)
        string_1 = "select id, name from files where active=1";
      else
        string_1 = "select id, name from files where active=1 UNION SELECT -1 AS id, '" + GClass35.smethod_0("[Tất cả thư mục]") + "' AS name UNION SELECT 999999 AS id, '" + GClass35.smethod_0("[Chọn nhiều thư mục]") + "' AS name ORDER BY id ASC";
      dataTable = GClass17.GClass17_0.method_1(string_1);
    }
    catch
    {
    }
    return dataTable;
  }

  public static DataTable smethod_2(bool bool_0 = false)
  {
    DataTable dataTable = new DataTable();
    try
    {
      string string_1;
      if (!bool_0)
        string_1 = "select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0)";
      else
        string_1 = "select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0) UNION SELECT -1 AS id, '" + GClass35.smethod_0("[Tất cả thư mục]") + "' AS name UNION SELECT 999999 AS id, '" + GClass35.smethod_0("[Chọn nhiều thư mục]") + "' AS name ORDER BY id ASC";
      dataTable = GClass17.GClass17_0.method_1(string_1);
    }
    catch
    {
    }
    return dataTable;
  }

  public static bool smethod_3(string string_0)
  {
    bool flag = true;
    try
    {
      GClass17.GClass17_0.method_1("insert into files values(null,'" + string_0 + "','" + DateTime.Now.ToString() + "',1)");
      return flag;
    }
    catch
    {
      return false;
    }
  }

  public static bool smethod_4(string string_0, string string_1)
  {
    try
    {
      return GClass17.GClass17_0.method_4("UPDATE files SET name='" + string_1 + "' where id=" + string_0) > 0;
    }
    catch
    {
    }
    return false;
  }

  public static bool smethod_5(string string_0)
  {
    bool flag = false;
    try
    {
      if (GClass17.GClass17_0.method_5("SELECT COUNT(idfile) FROM accounts WHERE idfile=" + string_0) == 0)
        return GClass17.GClass17_0.method_4("delete from files where id=" + string_0) > 0;
      return GClass17.GClass17_0.method_4("UPDATE files SET active=0 where id=" + string_0) > 0 ? Class42.smethod_22(string_0) : flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_6()
  {
    bool flag = false;
    try
    {
      return GClass17.GClass17_0.method_4("delete from files where id NOT IN (SELECT DISTINCT idfile FROM accounts)") > 0;
    }
    catch
    {
      return flag;
    }
  }

  public static string smethod_7(string string_0)
  {
    try
    {
      return GClass17.GClass17_0.method_6("SELECT device FROM accounts WHERE id='" + string_0 + "'").ToString();
    }
    catch
    {
    }
    return "";
  }

  public static DataTable smethod_8()
  {
    DataTable dataTable = new DataTable();
    try
    {
      dataTable = GClass17.GClass17_0.method_1("SELECT id, status FROM accounts");
    }
    catch
    {
    }
    return dataTable;
  }

  public static DataTable smethod_9(List<string> list_0, bool bool_0 = true)
  {
    DataTable dataTable = new DataTable();
    try
    {
      string str = list_0 == null || list_0.Count == 0 ? "where active=" + (bool_0 ? 1 : 0).ToString() : "where idfile IN (" + string.Join(",", (IEnumerable<string>) list_0) + ") AND active=" + (bool_0 ? 1 : 0).ToString();
      dataTable = GClass17.GClass17_0.method_1("SELECT '-1' as id, '" + GClass35.smethod_0("[Tất cả tình trạng]") + "' AS name UNION select DISTINCT '0' as id,info from accounts " + str + " ORDER BY id ASC");
    }
    catch
    {
    }
    return dataTable;
  }

  public static bool smethod_10(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    string string_4,
    string string_5,
    string string_6,
    string string_7,
    string string_8,
    string string_9,
    string string_10,
    string string_11,
    string string_12,
    string string_13,
    string string_14,
    string string_15 = "",
    string string_16 = "",
    string string_17 = "",
    string string_18 = "")
  {
    bool flag = true;
    try
    {
      GClass17.GClass17_0.method_1(string.Format("INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,backup,idfile,passmail,useragent,proxy,dateImport,active) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}',1)", (object) string_0, (object) string_1.Replace("'", "''"), (object) string_2, (object) string_3, (object) string_4, (object) string_6, (object) string_7, (object) string_8, (object) string_9, (object) string_10, (object) string_11, (object) string_13, (object) string_12, (object) string_14, (object) string_16, (object) string_17, (object) string_18, (object) DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
      return flag;
    }
    catch
    {
      return false;
    }
  }

  public static List<string> smethod_11(List<string> list_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      int num = 100;
      int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
      for (int index = 0; index < int32; ++index)
      {
        string str = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,idfile,passmail,useragent,proxy,dateImport,active, device) VALUES " + string.Join(",", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num));
        stringList.Add(str);
      }
    }
    catch
    {
    }
    return stringList;
  }

  public static string smethod_12(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    string string_4,
    string string_5,
    string string_6,
    string string_7,
    string string_8,
    string string_9,
    string string_10,
    string string_11,
    string string_12,
    string string_13,
    string string_14,
    string string_15,
    string string_16)
  {
    string format = "";
    try
    {
      format = "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}',1,'{17}')";
      format = string.Format(format, (object) string_0, (object) string_1.Replace("'", "''"), (object) string_2, (object) string_3, (object) string_4, (object) string_5.Replace("'", "''"), (object) string_6, (object) string_7, (object) string_8, (object) string_9, (object) string_10, (object) string_11, (object) string_12, (object) string_13, (object) string_14, (object) string_15, (object) DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), (object) string_16);
    }
    catch
    {
    }
    return format;
  }

  public static bool smethod_13(string string_0, string string_1, string string_2)
  {
    bool flag = false;
    try
    {
      string str = "";
      if (string_1 == "pass")
        str = ", pass_old=pass";
      return GClass17.GClass17_0.method_4("update accounts set " + string_1 + " = '" + string_2.Replace("'", "''") + "'" + str + " where id=" + string_0) > 0;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_14(string string_0, string string_1, string string_2, bool bool_0 = true)
  {
    bool flag = false;
    try
    {
      if (string_1.Split('|').Length != string_2.Split('|').Length)
        return flag;
      int length = string_1.Split('|').Length;
      string str = "";
      for (int index = 0; index < length; ++index)
      {
        int num;
        if (!bool_0)
          num = !(string_2.Split('|')[index].Trim() == "") ? 1 : 0;
        else
          num = 1;
        if (num != 0)
          str = str + string_1.Split('|')[index] + "='" + string_2.Split('|')[index].Replace("'", "''") + "',";
      }
      return GClass17.GClass17_0.method_4("update accounts set " + str.TrimEnd(',') + " where id=" + string_0) > 0;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_15(List<string> list_0, string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      if (string_0.Split('|').Length != string_1.Split('|').Length)
        return flag;
      int length = string_0.Split('|').Length;
      string str1 = "";
      for (int index = 0; index < length; ++index)
        str1 = str1 + string_0.Split('|')[index] + "='" + string_1.Split('|')[index].Replace("'", "''") + "',";
      string str2 = str1.TrimEnd(',');
      int num = 100;
      int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
      List<string> list_0_1 = new List<string>();
      for (int index = 0; index < int32; ++index)
      {
        string str3 = "update accounts set " + str2 + " where id IN (" + string.Join(",", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num)) + ")";
        list_0_1.Add(str3);
      }
      return GClass17.GClass17_0.method_3(list_0_1) > 0;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_16(string string_0, string string_1, string string_2)
  {
    bool flag = false;
    try
    {
      return GClass17.GClass17_0.method_4("update files set " + string_1 + " = '" + string_2.Replace("'", "''") + "' where id=" + string_0) > 0;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_17(List<string> list_0, string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      int num = 100;
      int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
      List<string> list_0_1 = new List<string>();
      string str1 = "";
      if (string_0 == "pass")
        str1 = ", pass_old=pass";
      for (int index = 0; index < int32; ++index)
      {
        string str2 = "update accounts set " + string_0 + " = '" + string_1.Replace("'", "''") + "'" + str1 + " where id IN (" + string.Join(",", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num)) + ")";
        list_0_1.Add(str2);
      }
      return GClass17.GClass17_0.method_3(list_0_1) > 0;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_18(List<string> list_0, string string_0, string string_1)
  {
    bool flag = true;
    try
    {
      return GClass17.GClass17_0.method_4("update files set " + string_0 + " = '" + string_1 + "' where id IN (" + string.Join(",", (IEnumerable<string>) list_0) + ")") > 0;
    }
    catch
    {
      return flag;
    }
  }

  public static DataTable smethod_19(List<string> list_0 = null, string string_0 = "", bool bool_0 = true)
  {
    DataTable dataTable = new DataTable();
    try
    {
      string str1 = "WHERE ";
      string str2 = list_0 == null || list_0.Count <= 0 ? "" : "t1.idFile IN (" + string.Join(",", (IEnumerable<string>) list_0) + ")";
      if (str2 != "")
        str1 = str1 + str2 + " AND ";
      string str3 = string_0 != "" ? "t1.info = '" + string_0 + "'" : "";
      if (str3 != "")
        str1 = str1 + str3 + " AND ";
      string str4 = string.Format("t1.active = '{0}'", (object) (bool_0 ? 1 : 0));
      dataTable = GClass17.GClass17_0.method_1("SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id " + (str1 + str4) + " ORDER BY t1.idfile");
    }
    catch
    {
    }
    return dataTable;
  }

  public static DataTable smethod_20(List<string> list_0)
  {
    DataTable dataTable = new DataTable();
    try
    {
      int num = 100;
      int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
      List<string> list_0_1 = new List<string>();
      for (int index = 0; index < int32; ++index)
      {
        string str = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num)) + "') and t1.active=1 ORDER BY t1.uid";
        list_0_1.Add(str);
      }
      dataTable = GClass17.GClass17_0.method_2(list_0_1);
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "GetAccFromFile");
    }
    return dataTable;
  }

  public static DataTable smethod_21(string string_0)
  {
    DataTable dataTable = new DataTable();
    try
    {
      dataTable = GClass17.GClass17_0.method_1("select " + string_0 + " from accounts where active = 1");
    }
    catch
    {
    }
    return dataTable;
  }

  public static bool smethod_22(string string_0)
  {
    bool flag = true;
    try
    {
      return GClass17.GClass17_0.method_4("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where idfile=" + string_0) > 0;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_23(string string_0)
  {
    try
    {
      return GClass17.GClass17_0.method_4("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id=" + string_0) > 0;
    }
    catch
    {
    }
    return false;
  }

  public static DataTable smethod_24(List<string> list_0)
  {
    DataTable dataTable = new DataTable();
    try
    {
      int num = 100;
      int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
      List<string> list_0_1 = new List<string>();
      for (int index = 0; index < int32; ++index)
      {
        string str = "SELECT uid, pass, token, cookie1,email, passmail, fa2 FROM accounts WHERE id IN ('" + string.Join("','", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num)) + "')";
        list_0_1.Add(str);
      }
      dataTable = GClass17.GClass17_0.method_2(list_0_1);
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "GetAccFromFile");
    }
    return dataTable;
  }

  public static bool smethod_25(List<string> list_0, bool bool_0 = false)
  {
    DateTime now;
    if (bool_0)
    {
      List<string> contents = new List<string>();
      DataTable dataTable = Class42.smethod_24(list_0);
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        string str1 = "";
        for (int columnIndex = 0; columnIndex < dataTable.Columns.Count; ++columnIndex)
          str1 = str1 + dataTable.Rows[index][columnIndex].ToString() + "|";
        string str2 = str1.Substring(0, str1.Length - 1);
        contents.Add(str2);
      }
      now = DateTime.Now;
      File.AppendAllText("bin.txt", "======" + now.ToString("HH:mm:ss dd/MM/yyyy") + "======\r\n");
      File.AppendAllLines("bin.txt", (IEnumerable<string>) contents);
    }
    bool flag = true;
    try
    {
      int num = 100;
      int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
      List<string> stringList = new List<string>();
      for (int index = 0; index < int32; ++index)
      {
        string str3;
        if (bool_0)
        {
          str3 = "delete from accounts where id IN (" + string.Join(",", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num)) + ")";
        }
        else
        {
          string[] strArray = new string[5]
          {
            "UPDATE accounts SET active=0, dateDelete='",
            null,
            null,
            null,
            null
          };
          now = DateTime.Now;
          strArray[1] = now.ToString("HH:mm:ss dd/MM/yyyy");
          strArray[2] = "' where id IN (";
          strArray[3] = string.Join(",", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num));
          strArray[4] = ")";
          str3 = string.Concat(strArray);
        }
        string str4 = str3;
        stringList.Add(str4);
      }
      for (int index = 0; index < stringList.Count; ++index)
        flag = GClass17.GClass17_0.method_4(stringList[index]) > 0;
      return flag;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "DeleteAccountToDatabase");
      return flag;
    }
  }

  public static bool smethod_26(string string_0)
  {
    string[] strArray = string_0.Split('|');
    string str1 = strArray[0];
    if (str1.Trim() == "")
      return false;
    string str2 = strArray[1];
    string str3 = strArray[2];
    string str4 = strArray[3];
    string str5 = strArray[4];
    string str6 = strArray[5];
    string str7 = strArray[6];
    string str8 = strArray[7];
    string str9 = strArray[8];
    string str10 = strArray[9];
    string str11 = strArray[10];
    string str12 = strArray[11];
    string str13 = strArray[12];
    string str14 = strArray[13];
    string str15 = strArray[14];
    List<string> stringList = new List<string>();
    stringList.Add(str2 != "" ? "pass|" + str2 : "");
    stringList.Add(str3 != "" ? "token|" + str3 : "");
    stringList.Add(str4 != "" ? "cookie1|" + str4 : "");
    stringList.Add(str5 != "" ? "email|" + str5 : "");
    stringList.Add(str6 != "" ? "passmail|" + str6 : "");
    stringList.Add(str7 != "" ? "fa2|" + str7 : "");
    stringList.Add(str8 != "" ? "useragent|" + str8 : "");
    stringList.Add(str9 != "" ? "proxy|" + str9 : "");
    stringList.Add(str10 != "" ? "birthday|" + str10 : "");
    stringList.Add(str11 != "" ? "friends|" + str11 : "");
    stringList.Add(str12 != "" ? "dateCreateAcc|" + str12 : "");
    stringList.Add(str13 != "" ? "mailrecovery|" + str13 : "");
    stringList.Add(str14 != "" ? "ghiChu|" + str14 : "");
    stringList.Add(str15 != "" ? "interactEnd|" + str15 : "");
    string str16 = "update accounts set";
    foreach (string str17 in stringList)
    {
      if (str17 != "")
      {
        str16 = str16 + " " + str17.Split('|')[0] + "='" + str17.Split('|')[1] + "',";
        if (str17.Split('|')[0] == "pass")
          str16 += "pass_old=pass,";
      }
    }
    return GClass17.GClass17_0.method_4(str16.TrimEnd(',') + " where uid='" + str1 + "'") > 0;
  }

  public static string smethod_27(string string_0)
  {
    try
    {
      return GClass17.GClass17_0.method_5("SELECT idFile FROM accounts WHERE id='" + string_0 + "'").ToString();
    }
    catch
    {
    }
    return "";
  }

  public static bool smethod_28(string string_0, string string_1) => GClass17.GClass17_0.method_5("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'") > 0;

  public static bool smethod_29(string string_0) => GClass17.GClass17_0.method_5("SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='" + string_0 + "';") > 0;

  public static bool smethod_30(string string_0, string string_1, int int_0)
  {
    bool flag = false;
    try
    {
      return GClass17.GClass17_0.method_4("ALTER TABLE " + string_0 + " ADD COLUMN '" + string_1 + "' " + (int_0 == 0 ? "INT" : "TEXT") + ";") > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_31(string string_0, string string_1, string string_2)
  {
    bool flag = true;
    try
    {
      GClass17.GClass17_0.method_1("INSERT INTO interacts(uid, timeInteract,hanhDong,cauHinh) VALUES ('" + string_0 + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + string_1 + "','" + string_2 + "')");
      return flag;
    }
    catch
    {
      return false;
    }
  }

  public static bool smethod_32(string string_0, List<string> list_0, string string_1 = "accounts")
  {
    List<string> values = new List<string>();
    string str1 = "";
    for (int index = 0; index < list_0.Count; ++index)
    {
      string str2 = list_0[index].Split('|')[0];
      string str3 = list_0[index].Split('|')[1];
      if (!string.IsNullOrEmpty(str2))
      {
        values.Add(str2);
        str1 = str1 + "WHEN '" + str2 + "' THEN '" + str3 + "' ";
      }
    }
    return GClass17.GClass17_0.method_4("UPDATE " + string_1 + " SET " + string_0 + " = CASE id " + str1 + "END WHERE id IN('" + string.Join("','", (IEnumerable<string>) values) + "'); ") > 0;
  }

  public static List<string> smethod_33(string string_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      DataTable dataTable = GClass17.GClass17_0.method_1("SELECT device FROM accounts WHERE device LIKE '" + string_0 + "_com.facebook.ka%' AND active=1");
      for (int index = 0; index < dataTable.Rows.Count; ++index)
        stringList.Add(dataTable.Rows[index]["device"].ToString().Trim().Replace(string_0 + "_", ""));
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  public static DataTable smethod_34(List<string> list_0, bool bool_0 = true)
  {
    DataTable dataTable = new DataTable();
    try
    {
      if (list_0[0].StartsWith("@"))
      {
        List<string> list_0_1 = new List<string>();
        for (int index = 0; index < list_0.Count; ++index)
        {
          string str = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email Like ('%" + list_0[index] + "%') and t1.active=" + (bool_0 ? 1 : 0).ToString();
          list_0_1.Add(str);
        }
        dataTable = GClass17.GClass17_0.method_2(list_0_1);
      }
      else if (list_0[0].Contains("@"))
      {
        int num = 100;
        int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
        List<string> list_0_2 = new List<string>();
        for (int index = 0; index < int32; ++index)
        {
          string str = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num)) + "') and t1.active=" + (bool_0 ? 1 : 0).ToString() + " ORDER BY t1.email";
          list_0_2.Add(str);
        }
        dataTable = GClass17.GClass17_0.method_2(list_0_2);
      }
      else
      {
        int num = 100;
        int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
        List<string> list_0_3 = new List<string>();
        for (int index = 0; index < int32; ++index)
        {
          string str = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num)) + "') and t1.active=" + (bool_0 ? 1 : 0).ToString() + " ORDER BY t1.uid";
          list_0_3.Add(str);
        }
        dataTable = GClass17.GClass17_0.method_2(list_0_3);
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "GetAccFromFile");
    }
    return dataTable;
  }

  public static bool smethod_35(List<string> list_0)
  {
    bool flag = false;
    try
    {
      int num = 100;
      int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_0.Count * 1.0 / 100.0)));
      List<string> list_0_1 = new List<string>();
      for (int index = 0; index < int32; ++index)
      {
        string str = "update accounts set pass=pass_old, pass_old=pass where id IN (" + string.Join(",", (IEnumerable<string>) list_0.GetRange(num * index, num * index + num <= list_0.Count ? num : list_0.Count % num)) + ")";
        list_0_1.Add(str);
      }
      return GClass17.GClass17_0.method_3(list_0_1) > 0;
    }
    catch
    {
      return flag;
    }
  }
}
