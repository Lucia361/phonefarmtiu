// Decompiled with JetBrains decompiler
// Type: GClass30
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

public static class GClass30
{
  public static Bitmap smethod_0(this string string_0)
  {
    try
    {
      byte[] buffer = Convert.FromBase64String(string_0);
      MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length);
      memoryStream.Write(buffer, 0, buffer.Length);
      return new Bitmap(Image.FromStream((Stream) memoryStream, true));
    }
    catch
    {
    }
    return (Bitmap) null;
  }

  public static void smethod_1(this Control control_0, bool bool_0)
  {
    try
    {
      control_0.Invoke((Delegate) (() => control_0.Enabled = bool_0));
    }
    catch
    {
    }
  }

  public static string smethod_2(this string string_0) => WebUtility.UrlEncode(string_0);

  public static string smethod_3(this string string_0) => WebUtility.HtmlDecode(string_0);

  public static void smethod_4(this Form form_0)
  {
    if (form_0.WindowState == FormWindowState.Maximized)
    {
      form_0.WindowState = FormWindowState.Normal;
    }
    else
    {
      Rectangle workingArea = Screen.FromHandle(form_0.Handle).WorkingArea with
      {
        Location = new Point(0, 0)
      };
      form_0.MaximumSize = workingArea.Size;
      form_0.WindowState = FormWindowState.Maximized;
    }
  }

  public static void smethod_5(this Control control_0)
  {
    control_0.Text = "Search...";
    control_0.ForeColor = Color.Gray;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    control_0.Leave += GClass30.\u003C\u003EO.\u003C0\u003E__smethod_7 ?? (GClass30.\u003C\u003EO.\u003C0\u003E__smethod_7 = new EventHandler(GClass30.smethod_7));
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    control_0.Enter += GClass30.\u003C\u003EO.\u003C1\u003E__smethod_6 ?? (GClass30.\u003C\u003EO.\u003C1\u003E__smethod_6 = new EventHandler(GClass30.smethod_6));
  }

  private static void smethod_6(object sender, EventArgs e)
  {
    Control control = sender as Control;
    if (!(control.Text == "Search..."))
      return;
    control.Text = "";
    control.ForeColor = Color.Black;
  }

  private static void smethod_7(object sender, EventArgs e)
  {
    Control control = sender as Control;
    if (!(control.Text == ""))
      return;
    control.Text = "Search...";
    control.ForeColor = Color.Gray;
  }
}
