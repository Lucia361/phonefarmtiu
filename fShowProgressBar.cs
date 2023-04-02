// Decompiled with JetBrains decompiler
// Type: fShowProgressBar
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class fShowProgressBar : Form
{
  private List<string> list_0 = new List<string>();
  private IContainer icontainer_0 = (IContainer) null;
  private Label lblproccess;
  private MetroProgressBar progressBar1;

  public fShowProgressBar(List<string> list_1)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.list_0 = list_1;
  }

  private void method_0() => GClass35.smethod_1((Control) this.lblproccess);

  private void fShowProgressBar_Load(object sender, EventArgs e)
  {
    try
    {
      new Thread((ThreadStart) (() =>
      {
        int int_0 = 0;
        int int_1 = this.list_0.Count;
        this.BeginInvoke((Delegate) (() => this.lblproccess.Text = string.Format(GClass35.smethod_0("Đang copy, vui lòng chờ ({0}/{1})..."), (object) int_0, (object) int_1)));
        for (int index = 0; index < this.list_0.Count; ++index)
        {
          if (GClass13.smethod_3(this.list_0[index].Split('|')[0], this.list_0[index].Split('|')[1], true))
            int_0++;
          double double_0 = (double) int_0 * 1.0 / (double) int_1 * 100.0;
          this.BeginInvoke((Delegate) (() =>
          {
            this.lblproccess.Text = string.Format(GClass35.smethod_0("Đang copy, vui lòng chờ ({0}/{1})..."), (object) int_0, (object) int_1);
            this.progressBar1.Value = int.Parse(Math.Truncate(double_0).ToString());
          }));
        }
        this.BeginInvoke((Delegate) (() => this.Close()));
      }))
      {
        IsBackground = true
      }.Start();
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) ("Error: " + ex.Message), 2);
      this.Close();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.lblproccess = new Label();
    this.progressBar1 = new MetroProgressBar();
    this.SuspendLayout();
    this.lblproccess.AutoSize = true;
    this.lblproccess.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblproccess.Location = new Point(34, 22);
    this.lblproccess.Name = "lblproccess";
    this.lblproccess.Size = new Size(189, 16);
    this.lblproccess.TabIndex = 1;
    this.lblproccess.Text = "Đang copy, vui lòng chờ (0/0)...";
    this.progressBar1.Location = new Point(37, 52);
    this.progressBar1.Name = "progressBar1";
    this.progressBar1.Size = new Size(219, 23);
    this.progressBar1.TabIndex = 2;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(224, 224, 224);
    this.ClientSize = new Size(294, 104);
    this.Controls.Add((Control) this.progressBar1);
    this.Controls.Add((Control) this.lblproccess);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fShowProgressBar);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "frm_progress";
    this.Load += new EventHandler(this.fShowProgressBar_Load);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
