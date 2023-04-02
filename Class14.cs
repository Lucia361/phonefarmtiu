// Decompiled with JetBrains decompiler
// Type: Class14
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Data;
using System.Windows.Forms;

internal class Class14
{
  public static void smethod_0(
    DataGridView dataGridView_0,
    int int_0,
    string string_0,
    int int_1 = 0,
    string string_1 = "Đợi {time} giây...")
  {
    try
    {
      int int_2 = Environment.TickCount;
      while ((Environment.TickCount - int_2) / 1000 - int_1 < 0)
      {
        dataGridView_0.Invoke((Delegate) (() => dataGridView_0.Rows[int_0].Cells[string_0].Value = (object) string_1.Replace("{time}", (int_1 - (Environment.TickCount - int_2) / 1000).ToString())));
        GClass19.smethod_64(0.5);
      }
    }
    catch
    {
    }
  }

  public static void smethod_1(
    DataGridView dataGridView_0,
    int int_0,
    string string_0,
    int int_1 = 0,
    int int_2 = 0,
    string string_1 = "Đợi {time} giây...")
  {
    try
    {
      int int_3 = Environment.TickCount;
      while ((Environment.TickCount - int_3) / 1000 - int_1 < 0)
      {
        dataGridView_0.Invoke((Delegate) (() => dataGridView_0.Rows[int_0].Cells[string_0].Value = (object) string_1.Replace("{time}", (int_2 - (Environment.TickCount - int_3) / 1000).ToString())));
        GClass19.smethod_64(0.5);
      }
    }
    catch
    {
    }
  }

  public static string smethod_2(DataGridView dataGridView_0, int int_0, int int_1)
  {
    string string_0 = "";
    try
    {
      if (dataGridView_0.Rows[int_0].Cells[int_1].Value != null)
      {
        try
        {
          string_0 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString();
        }
        catch
        {
          dataGridView_0.Invoke((Delegate) (() => string_0 = dataGridView_0.Rows[int_0].Cells[int_1].Value.ToString()));
        }
      }
    }
    catch
    {
    }
    return string_0;
  }

  public static string smethod_3(DataGridView dataGridView_0, int int_0, string string_0)
  {
    string string_ = "";
    try
    {
      if (dataGridView_0.Rows[int_0].Cells[string_0].Value != null)
      {
        try
        {
          string_ = dataGridView_0.Rows[int_0].Cells[string_0].Value.ToString();
        }
        catch
        {
          dataGridView_0.Invoke((Delegate) (() => string_ = dataGridView_0.Rows[int_0].Cells[string_0].Value.ToString()));
        }
      }
    }
    catch
    {
    }
    return string_;
  }

  public static void smethod_4(DataGridView dataGridView_0, int int_0, int int_1, object object_0)
  {
    try
    {
      try
      {
        dataGridView_0.Invoke((Delegate) (() => dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0));
      }
      catch
      {
        dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
      }
    }
    catch
    {
    }
  }

  public static void Status(
    DataGridView dataGridView_0,
    int int_0,
    string string_0,
    object object_0)
  {
    try
    {
      if (Class121.bool_0 && string_0 == "cStatus")
        Class121.smethod_1(Class14.smethod_3(dataGridView_0, int_0, "cId"), object_0.ToString());
      try
      {
        dataGridView_0.Invoke((Delegate) (() => dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0));
      }
      catch
      {
        dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
      }
    }
    catch
    {
    }
  }

  public static void smethod_6(DataGridView dataGridView_0, DataTable dataTable_0)
  {
    for (int index = 0; index < dataTable_0.Rows.Count; ++index)
    {
      DataRow row = dataTable_0.Rows[index];
      dataGridView_0.Rows.Add((object) false, (object) (dataGridView_0.RowCount + 1), row["id"], row["uid"], row["token"], row["cookie1"], row["email"], row["phone"], row["name"], row["follow"], row["friends"], row["groups"], row["birthday"], row["gender"], row["pass"], (object) "", row["passmail"], row["backup"], row["fa2"], row["useragent"], row["proxy"], row["dateCreateAcc"], row["avatar"], row["profile"], row["nameFile"], row["interactEnd"], row["device"], row["info"], row["ghiChu"], (object) "", (object) "", (object) Class121.smethod_0(row["id"].ToString()));
    }
  }
}
