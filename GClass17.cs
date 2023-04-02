// Decompiled with JetBrains decompiler
// Type: GClass17
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public class GClass17
{
  private static GClass17 gclass17_0;
  private string string_0 = "Data Source=" + Class54.string_4 + "\\database\\db_maxcare.sqlite;Version=3;";
  private SQLiteConnection sqliteConnection_0 = (SQLiteConnection) null;

  public static GClass17 GClass17_0
  {
    get
    {
      if (GClass17.gclass17_0 == null)
        GClass17.gclass17_0 = new GClass17();
      return GClass17.gclass17_0;
    }
    private set => GClass17.gclass17_0 = value;
  }

  private GClass17()
  {
  }

  private void method_0()
  {
    try
    {
      string str = "Data Source=" + Class54.string_4 + "\\database\\db_maxcare.sqlite;Version=3;";
      if (str != this.string_0)
      {
        this.string_0 = str;
        if (this.sqliteConnection_0.State == ConnectionState.Open)
          this.sqliteConnection_0.Close();
        this.sqliteConnection_0.ConnectionString = this.string_0;
        this.sqliteConnection_0.Open();
      }
      else
      {
        if (this.sqliteConnection_0 == null)
          this.sqliteConnection_0 = new SQLiteConnection(this.string_0);
        if (this.sqliteConnection_0.State == ConnectionState.Closed)
          this.sqliteConnection_0.Open();
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "CheckConnectServer");
    }
  }

  public DataTable method_1(string string_1)
  {
    DataTable dataTable = new DataTable();
    try
    {
      this.method_0();
      new SQLiteDataAdapter(new SQLiteCommand(string_1, this.sqliteConnection_0)).Fill(dataTable);
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "ExecuteQuery");
    }
    return dataTable;
  }

  public DataTable method_2(List<string> list_0)
  {
    DataTable dataTable = new DataTable();
    try
    {
      this.method_0();
      for (int index = 0; index < list_0.Count; ++index)
        new SQLiteDataAdapter(new SQLiteCommand(list_0[index], this.sqliteConnection_0)).Fill(dataTable);
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "ExecuteQuery");
    }
    return dataTable;
  }

  public int method_3(List<string> list_0)
  {
    int num = 0;
    try
    {
      this.method_0();
      for (int index = 0; index < list_0.Count; ++index)
        num = new SQLiteCommand(list_0[index], this.sqliteConnection_0).ExecuteNonQuery();
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "ExecuteNonQuery");
    }
    return num;
  }

  public int method_4(string string_1)
  {
    int num = 0;
    try
    {
      this.method_0();
      num = new SQLiteCommand(string_1, this.sqliteConnection_0).ExecuteNonQuery();
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "ExecuteNonQuery: " + string_1);
    }
    return num;
  }

  public int method_5(string string_1)
  {
    int num = 0;
    try
    {
      this.method_0();
      num = (int) (long) new SQLiteCommand(string_1, this.sqliteConnection_0).ExecuteScalar();
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "ExecuteScalar: " + string_1);
    }
    return num;
  }

  public string method_6(string string_1)
  {
    string str = "";
    try
    {
      this.method_0();
      str = new SQLiteCommand(string_1, this.sqliteConnection_0).ExecuteScalar().ToString();
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "ExecuteScalarV2: " + string_1);
    }
    return str;
  }
}
