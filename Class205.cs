// Decompiled with JetBrains decompiler
// Type: Class205
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Data;

internal class Class205
{
  public static bool smethod_0(string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      return GClass38.GClass38_0.method_3("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'") > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_1(string string_0, string string_1, int int_0)
  {
    bool flag = false;
    try
    {
      return GClass38.GClass38_0.method_2("ALTER TABLE " + string_0 + " ADD COLUMN '" + string_1 + "' " + (int_0 == 0 ? "INT" : "TEXT") + ";") > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static DataTable smethod_2(string string_0)
  {
    DataTable dataTable = new DataTable();
    try
    {
      dataTable = GClass38.GClass38_0.method_1("SELECT * FROM Kich_Ban WHERE Id_KichBan = " + string_0);
    }
    catch
    {
    }
    return dataTable;
  }

  public static string smethod_3(string string_0)
  {
    string str = "";
    try
    {
      str = GClass38.GClass38_0.method_1("SELECT TenKichBan FROM Kich_Ban WHERE Id_KichBan = " + string_0).Rows[0][0].ToString();
    }
    catch (Exception ex)
    {
    }
    return str;
  }

  public static DataTable smethod_4()
  {
    DataTable dataTable = new DataTable();
    try
    {
      dataTable = GClass38.GClass38_0.method_1("DROP TABLE IF EXISTS tmp;CREATE TEMPORARY TABLE tmp(Stt INTEGER PRIMARY KEY AUTOINCREMENT, Id_KichBan INTEGER, TenKichBan TEXT);INSERT INTO tmp (Id_KichBan, TenKichBan) SELECT Id_KichBan, TenKichBan FROM Kich_Ban;SELECT Id_KichBan, TenKichBan, (Stt||'. '||TenKichBan) AS Ten FROM tmp;");
    }
    catch
    {
    }
    return dataTable;
  }

  public static DataTable smethod_5()
  {
    DataTable dataTable = new DataTable();
    try
    {
      dataTable = GClass38.GClass38_0.method_1("SELECT * FROM Kich_Ban ORDER BY Id_KichBan DESC LIMIT 1");
    }
    catch
    {
    }
    return dataTable;
  }

  public static string smethod_6(string string_0)
  {
    string str = "";
    try
    {
      str = GClass38.GClass38_0.method_1("SELECT CauHinh FROM Kich_Ban WHERE Id_KichBan = " + string_0).Rows[0]["CauHinh"].ToString();
    }
    catch
    {
    }
    return str;
  }

  public static bool smethod_7(string string_0, string string_1)
  {
    try
    {
      return GClass38.GClass38_0.method_2("UPDATE Kich_Ban SET CauHinh = '" + string_1 + "' WHERE Id_KichBan = " + string_0) > 0;
    }
    catch
    {
    }
    return false;
  }

  public static bool smethod_8(string string_0)
  {
    try
    {
      if (GClass38.GClass38_0.method_1("SELECT Id_KichBan FROM Kich_Ban WHERE TenKichBan = '" + string_0 + "'").Rows.Count > 0)
        return true;
    }
    catch
    {
    }
    return false;
  }

  public static bool smethod_9(string string_0)
  {
    bool flag = false;
    try
    {
      return GClass38.GClass38_0.method_2("INSERT INTO Kich_Ban (TenKichBan) VALUES ('" + string_0 + "')") > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_10(string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      return GClass38.GClass38_0.method_2("UPDATE Kich_Ban SET TenKichBan = '" + string_1 + "' WHERE Id_KichBan = " + string_0) > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_11(string string_0)
  {
    bool flag = false;
    try
    {
      if (GClass38.GClass38_0.method_2("DELETE FROM Kich_Ban WHERE Id_KichBan = " + string_0) <= 0)
        return flag;
      Class205.smethod_24(string_0);
      return true;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_12(string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      if (!Class205.smethod_9(string_1))
        return flag;
      string str = Class205.smethod_5().Rows[0]["Id_KichBan"].ToString();
      DataTable dataTable = GClass38.GClass38_0.method_1("SELECT * FROM Hanh_Dong WHERE Id_KichBan = " + string_0);
      for (int index = 0; index < dataTable.Rows.Count; ++index)
        GClass38.GClass38_0.method_2("INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + dataTable.Rows[index]["STT"].ToString() + "," + str + ", '" + dataTable.Rows[index]["TenHanhDong"].ToString() + "', " + dataTable.Rows[index]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[index]["CauHinh"].ToString().Replace("'", "''") + "')");
      return true;
    }
    catch
    {
      return flag;
    }
  }

  public static DataTable smethod_13(string string_0 = "", string string_1 = "")
  {
    DataTable dataTable = new DataTable();
    try
    {
      string str = "";
      if (string_0 != "")
        str = str + "Id_TuongTac = " + string_0 + " AND ";
      if (string_1 != "")
        str = str + "TenTuongTac = '" + string_1 + "'";
      if (str != "")
      {
        if (str.EndsWith(" AND "))
          str = str.Replace(" AND ", "");
        dataTable = GClass38.GClass38_0.method_1("SELECT * FROM Tuong_Tac WHERE " + str);
      }
    }
    catch
    {
    }
    return dataTable;
  }

  public static DataTable smethod_14(string string_0)
  {
    DataTable dataTable = new DataTable();
    try
    {
      dataTable = GClass38.GClass38_0.method_1("SELECT t1.Id_HanhDong, t1.TenHanhDong,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + string_0 + " ORDER BY t1.STT");
    }
    catch
    {
    }
    return dataTable;
  }

  public static DataTable smethod_15(string string_0)
  {
    DataTable dataTable = new DataTable();
    try
    {
      dataTable = GClass38.GClass38_0.method_1("SELECT t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_HanhDong = " + string_0);
    }
    catch
    {
    }
    return dataTable;
  }

  public static DataTable smethod_16()
  {
    DataTable dataTable = new DataTable();
    try
    {
      dataTable = GClass38.GClass38_0.method_1("SELECT t1.Id_HanhDong,t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac ORDER BY Id_HanhDong DESC LIMIT 1");
    }
    catch
    {
    }
    return dataTable;
  }

  public static bool smethod_17(string string_0)
  {
    try
    {
      if (GClass38.GClass38_0.method_1("SELECT Id_HanhDong FROM Hanh_Dong WHERE TenHanhDong = '" + string_0 + "'").Rows.Count > 0)
        return true;
    }
    catch
    {
    }
    return false;
  }

  public static int smethod_18()
  {
    try
    {
      return GClass38.GClass38_0.method_3("SELECT Id_HanhDong FROM Hanh_Dong ORDER BY Id_HanhDong DESC LIMIT 1");
    }
    catch
    {
    }
    return -1;
  }

  public static bool smethod_19(
    string string_0,
    string string_1,
    string string_2,
    string string_3)
  {
    bool flag = false;
    try
    {
      string str1 = "";
      try
      {
        str1 = GClass38.GClass38_0.method_1("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + string_0 + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
      }
      catch
      {
      }
      string str2 = str1 == "" ? "1" : (Convert.ToInt32(str1) + 1).ToString();
      string_3 = string_3.Replace("'", "''");
      return GClass38.GClass38_0.method_2("INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + str2 + "," + string_0 + ", '" + string_1 + "', " + string_2 + ", '" + string_3 + "')") > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_20(string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      DataTable dataTable = GClass38.GClass38_0.method_1("SELECT * FROM Hanh_Dong WHERE Id_HanhDong = " + string_0);
      string str = "";
      try
      {
        str = GClass38.GClass38_0.method_1("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + dataTable.Rows[0]["Id_KichBan"].ToString() + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
      }
      catch
      {
      }
      return GClass38.GClass38_0.method_2("INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + (str == "" ? "1" : (Convert.ToInt32(str) + 1).ToString()) + "," + dataTable.Rows[0]["Id_KichBan"].ToString() + ", '" + string_1 + "', " + dataTable.Rows[0]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[0]["CauHinh"].ToString().Replace("'", "''") + "')") > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_21(string string_0, string string_1 = "", string string_2 = "")
  {
    bool flag = false;
    try
    {
      string str = "";
      string_2 = string_2.Replace("'", "''");
      if (string_1 != "")
        str = str + "TenHanhDong = '" + string_1 + "',";
      if (string_2 != "")
        str = str + "CauHinh = '" + string_2 + "'";
      if (!(str != ""))
        return flag;
      return GClass38.GClass38_0.method_2("UPDATE Hanh_Dong SET " + str.TrimEnd(',') + " WHERE Id_HanhDong = " + string_0) > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_22(string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      string str = GClass38.GClass38_0.method_1("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_0).Rows[0]["STT"].ToString();
      string string_1_1 = "UPDATE Hanh_Dong SET STT = " + GClass38.GClass38_0.method_1("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_1).Rows[0]["STT"].ToString() + " WHERE Id_HanhDong = " + string_0;
      string string_1_2 = "UPDATE Hanh_Dong SET STT = " + str + " WHERE Id_HanhDong = " + string_1;
      return GClass38.GClass38_0.method_2(string_1_1) > 0 && GClass38.GClass38_0.method_2(string_1_2) > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool KichBan_ds(string string_0, string string_1)
  {
    bool flag = false;
    try
    {
      string str = GClass38.GClass38_0.method_1("SELECT STT FROM Kich_Ban WHERE Id_Kich_Ban = " + string_0).Rows[0]["STT"].ToString();
      string string_1_1 = "UPDATE Kich_Ban SET STT = " + GClass38.GClass38_0.method_1("SELECT STT FROM Kich_Ban WHERE Id_Kich_Ban = " + string_1).Rows[0]["STT"].ToString() + " WHERE Id_Kich_Ban = " + string_0;
      string string_1_2 = "UPDATE Kich_Ban SET STT = " + str + " WHERE Id_Kich_Ban = " + string_1;
      return GClass38.GClass38_0.method_2(string_1_1) > 0 && GClass38.GClass38_0.method_2(string_1_2) > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_23(string string_0)
  {
    bool flag = false;
    try
    {
      return GClass38.GClass38_0.method_2("DELETE FROM Hanh_Dong WHERE Id_HanhDong = " + string_0) > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static bool smethod_24(string string_0)
  {
    bool flag = false;
    try
    {
      return GClass38.GClass38_0.method_2("DELETE FROM Hanh_Dong WHERE Id_KichBan = " + string_0) > 0 || flag;
    }
    catch
    {
      return flag;
    }
  }

  public static List<string> smethod_25(string string_0, string string_1)
  {
    List<string> stringList = new List<string>();
    try
    {
      DataTable dataTable = GClass38.GClass38_0.method_1("SELECT t1.Id_HanhDong FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + string_0 + " AND t2.TenTuongTac = '" + string_1 + "'");
      for (int index = 0; index < dataTable.Rows.Count; ++index)
        stringList.Add(dataTable.Rows[index]["Id_HanhDong"].ToString());
    }
    catch
    {
    }
    return stringList;
  }

  public static string smethod_26(string string_0)
  {
    string str = "";
    try
    {
      str = GClass38.GClass38_0.method_1("SELECT CauHinh FROM Hanh_Dong WHERE Id_HanhDong = " + string_0).Rows[0]["CauHinh"].ToString();
    }
    catch
    {
    }
    return str;
  }

  public static bool smethod_27(List<string> list_0, string string_0)
  {
    try
    {
      return GClass38.GClass38_0.method_3("SELECT COUNT(*) FROM Hanh_Dong WHERE Id_KichBan IN (" + string.Join(",", (IEnumerable<string>) list_0) + ") AND Id_TuongTac = (SELECT Id_TuongTac FROM Tuong_Tac WHERE TenTuongTac='" + string_0 + "')") > 0;
    }
    catch
    {
    }
    return false;
  }
}
