// Decompiled with JetBrains decompiler
// Type: GClass38
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Data;
using System.Data.SQLite;

public class GClass38
{
  private static GClass38 gclass38_0;
  private string string_0 = "Data Source=interact\\interact.sqlite;Version=3;";
  private SQLiteConnection sqliteConnection_0 = (SQLiteConnection) null;

  public static GClass38 GClass38_0
  {
    get
    {
      if (GClass38.gclass38_0 == null)
        GClass38.gclass38_0 = new GClass38();
      return GClass38.gclass38_0;
    }
    private set => GClass38.gclass38_0 = value;
  }

  private GClass38()
  {
  }

  private void method_0()
  {
    try
    {
      if (this.sqliteConnection_0 == null)
        this.sqliteConnection_0 = new SQLiteConnection(this.string_0);
      if (this.sqliteConnection_0.State != ConnectionState.Closed)
        return;
      this.sqliteConnection_0.Open();
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
    catch
    {
    }
    return dataTable;
  }

  public int method_2(string string_1)
  {
    int num = 0;
    try
    {
      this.method_0();
      num = new SQLiteCommand(string_1, this.sqliteConnection_0).ExecuteNonQuery();
    }
    catch
    {
    }
    return num;
  }

  public int method_3(string string_1)
  {
    int num = -1;
    try
    {
      this.method_0();
      num = (int) (long) new SQLiteCommand(string_1, this.sqliteConnection_0).ExecuteScalar();
    }
    catch
    {
    }
    return num;
  }
}
