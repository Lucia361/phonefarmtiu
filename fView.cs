// Decompiled with JetBrains decompiler
// Type: fView
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

public class fView : Form
{
  public bool bool_0 = false;
  public int[] int_0 = new int[6]
  {
    -700412699,
    930305305,
    711991953,
    -95280325,
    1745676906,
    -1265859784
  };
  private object object_0 = new object();
  public static fView fView_0;
  private IContainer icontainer_0 = (IContainer) null;
  private ToolTip toolTip_0;
  private FlowLayoutPanel panelListDevice;

  public fView()
  {
    this.InitializeComponent();
    fView.fView_0 = this;
  }

  public void method_0(IntPtr intptr_0, int int_1, int int_2)
  {
  }

  public void method_1(IntPtr intptr_0, string string_0)
  {
    try
    {
      this.method_4(string_0);
      Control control_ = this.panelListDevice.Controls.Cast<Control>().Where<Control>((Func<Control, bool>) (control_0 => control_0.Name.Equals("dv" + string_0))).FirstOrDefault<Control>();
      control_ = control_.Controls.Cast<Control>().Where<Control>((Func<Control, bool>) (control_0 => control_0.Name.Equals("view_" + string_0))).FirstOrDefault<Control>();
      if (control_ == null)
        return;
      this.Invoke((Delegate) (() =>
      {
        GClass8.SetParent(intptr_0, control_.Handle);
        GClass8.MoveWindow(intptr_0, this.int_0[2], this.int_0[3], this.int_0[4], this.int_0[5], true);
      }));
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "AddDeviceIntoPanel");
    }
  }

  public void method_2(int int_1)
  {
    try
    {
      this.method_10(int_1, "");
      this.method_11(int_1, "");
      this.method_15(int_1);
      if (this.bool_0)
        return;
      this.method_6(this.panelListDevice.Controls["dv" + int_1.ToString()], -1);
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "RemovePanelDevice");
    }
  }

  public void method_3(string string_0)
  {
    try
    {
      Control control_0 = this.panelListDevice.Controls["dv" + string_0];
      this.panelListDevice.Invoke((Delegate) (() => this.panelListDevice.Controls.Remove(control_0)));
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "RemovePanelDevice");
    }
  }

  public void method_4(string string_0)
  {
    try
    {
      Panel panel_0 = new Panel();
      panel_0.Name = "dv" + string_0;
      panel_0.Tag = (object) string_0;
      panel_0.Size = new Size(this.int_0[0], this.int_0[1] + 60);
      panel_0.BackColor = Color.White;
      panel_0.BorderStyle = BorderStyle.FixedSingle;
      Panel panel = new Panel();
      panel.Location = new Point(0, 0);
      panel.Name = "view_" + string_0;
      panel.Size = new Size(this.int_0[0], this.int_0[1]);
      panel_0.Controls.Add((Control) panel);
      Label label1 = new Label();
      label1.Text = string_0;
      label1.Location = new Point(0, this.int_0[1] + 6);
      label1.Size = new Size(this.int_0[0], 20);
      label1.BackColor = Color.White;
      label1.BorderStyle = BorderStyle.None;
      label1.ForeColor = Color.Black;
      label1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      label1.Name = string_0;
      label1.AutoSize = false;
      Label label2 = label1;
      panel_0.Controls.Add((Control) label2);
      Button button1 = new Button();
      button1.Location = new Point(3, this.int_0[1] + 28);
      button1.Name = string_0;
      button1.Size = new Size(80, 27);
      button1.Cursor = Cursors.Hand;
      button1.Visible = true;
      button1.ForeColor = Color.Black;
      button1.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
      button1.Text = "Close";
      Button button2 = button1;
      button2.Click += new EventHandler(this.method_12);
      panel_0.Controls.Add((Control) button2);
      Button button3 = new Button();
      button3.Location = new Point(this.int_0[0] - 85, this.int_0[1] + 28);
      button3.Name = string_0;
      button3.Size = new Size(80, 27);
      button3.Cursor = Cursors.Hand;
      button3.Visible = true;
      button3.BackColor = Color.FromArgb(212, 237, 182);
      button3.ForeColor = Color.Black;
      button3.Text = "Xuất lỗi";
      Button button4 = button3;
      button4.Click += new EventHandler(this.method_13);
      panel_0.Controls.Add((Control) button4);
      lock (this.object_0)
        this.panelListDevice.Invoke((Delegate) (() => this.panelListDevice.Controls.Add((Control) panel_0)));
      for (int index = 0; index < 5 && this.panelListDevice.Controls["dv" + string_0] == null; ++index)
        Thread.Sleep(1000);
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "AddPanelDevice");
    }
  }

  public void method_5(int int_1)
  {
  }

  public void method_6(Control control_0, int int_1, int int_2 = 0)
  {
  }

  public void method_7(Control control_0, string string_0, int int_1 = 0)
  {
    try
    {
      control_0.Invoke((Delegate) (() =>
      {
        control_0.Name = "dv" + string_0;
        control_0.Tag = (object) string_0;
        control_0.Controls[0].Text = string_0;
        if (int_1 > 0)
        {
          Control control = control_0.Controls[0];
          control.Text = control.Text + "-TK " + int_1.ToString();
        }
        control_0.Controls[0].Name = string_0;
        control_0.Controls[1].Name = string_0;
        control_0.Controls[2].Name = string_0;
        control_0.Controls[3].Name = string_0;
        control_0.Controls[4].Name = string_0;
      }));
    }
    catch
    {
    }
  }

  public void method_8(int int_1, string string_0)
  {
    try
    {
      Control control_ = this.panelListDevice.Controls.Cast<Control>().Where<Control>((Func<Control, bool>) (control_0 => control_0.Tag.Equals((object) int_1))).FirstOrDefault<Control>();
      if (control_ == null)
        return;
      control_.Invoke((Delegate) (() => control_.Controls[4].Name = string_0));
      Application.DoEvents();
    }
    catch
    {
    }
  }

  public bool method_9(int int_1) => this.panelListDevice.Controls.Cast<Control>().Where<Control>((Func<Control, bool>) (control_0 => control_0.Tag.Equals((object) int_1))).Count<Control>() == 1;

  public void method_10(int int_1, string string_0)
  {
    try
    {
      Application.DoEvents();
      if (string_0.Trim() != "")
      {
        string_0 = string_0.Replace("\"", "");
        string_0 += string_0.EndsWith("...") ? "" : "...";
      }
      this.panelListDevice.Invoke((Delegate) (() => this.panelListDevice.Controls["dv" + int_1.ToString()].Controls[2].Text = string_0));
      Application.DoEvents();
    }
    catch (Exception ex)
    {
    }
  }

  public void method_11(int int_1, string string_0)
  {
    try
    {
      Application.DoEvents();
      if (string_0.Trim() != "")
      {
        string_0 = string_0.Replace("\"", "");
        string_0 += string_0.EndsWith("...") ? "" : "...";
      }
      this.panelListDevice.Invoke((Delegate) (() => this.panelListDevice.Controls["dv" + int_1.ToString()].Controls[1].Text = ">" + string_0));
      this.method_10(int_1, "");
      Application.DoEvents();
    }
    catch (Exception ex)
    {
    }
  }

  private void method_12(object sender, EventArgs e)
  {
    try
    {
      this.method_3((sender as Button).Name);
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "TurnOffDevice");
    }
  }

  private void method_13(object sender, EventArgs e)
  {
    try
    {
      string name = (sender as Button).Name;
      if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
        new fCheckAppium(name).Show();
      else if (new GClass27(name).method_178())
        GClass14.smethod_0((object) "Success!");
      else
        GClass14.smethod_0((object) "Fail!", 2);
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "CheckDevice");
    }
  }

  public void method_14(int int_1)
  {
    try
    {
      this.Invoke((Delegate) (() =>
      {
        this.panelListDevice.Controls["dv" + int_1.ToString()].Controls[3].Visible = true;
        this.panelListDevice.Controls["dv" + int_1.ToString()].Controls[4].Visible = true;
      }));
    }
    catch (Exception ex)
    {
    }
  }

  public void method_15(int int_1)
  {
    try
    {
      this.Invoke((Delegate) (() =>
      {
        this.panelListDevice.Controls["dv" + int_1.ToString()].Controls[3].Visible = false;
        this.panelListDevice.Controls["dv" + int_1.ToString()].Controls[4].Visible = false;
      }));
    }
    catch (Exception ex)
    {
    }
  }

  private void fView_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      foreach (Control control in (ArrangedElementCollection) this.panelListDevice.Controls)
        this.method_2(Convert.ToInt32(control.Name.Replace("dv", "")));
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "fViewChrome_FormClosing");
    }
  }

  public List<string> method_16()
  {
    List<string> stringList = new List<string>();
    foreach (Control control in (ArrangedElementCollection) this.panelListDevice.Controls)
      stringList.Add(control.Tag.ToString());
    return stringList;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fView));
    this.toolTip_0 = new ToolTip(this.icontainer_0);
    this.panelListDevice = new FlowLayoutPanel();
    this.SuspendLayout();
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 5000;
    this.toolTip_0.InitialDelay = 0;
    this.toolTip_0.ReshowDelay = 100;
    this.toolTip_0.ShowAlways = true;
    this.panelListDevice.AutoScroll = true;
    this.panelListDevice.BackColor = Color.White;
    this.panelListDevice.Dock = DockStyle.Fill;
    this.panelListDevice.Location = new Point(0, 0);
    this.panelListDevice.Name = "panelListDevice";
    this.panelListDevice.Padding = new Padding(10);
    this.panelListDevice.Size = new Size(1044, 441);
    this.panelListDevice.TabIndex = 2;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1044, 441);
    this.Controls.Add((Control) this.panelListDevice);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fView);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "View Phone - MIN SOFTWARE";
    this.FormClosing += new FormClosingEventHandler(this.fView_FormClosing);
    this.ResumeLayout(false);
  }
}
