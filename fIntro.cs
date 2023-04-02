// Decompiled with JetBrains decompiler
// Type: fIntro
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class fIntro : Form
{
  private IContainer icontainer_0;
  private MetroProgressBar progressBar;
  private Timer timer_0;
  private Timer timer_1;
  private Label label7;
  private ImageList imageList1;
  private ImageList imageList2;
  private Label label1;
  private IContainer components;

  [DllImport("kernel32.dll")]
  private static extern long GetVolumeInformation(
    string string_0,
    StringBuilder stringBuilder_0,
    uint uint_0,
    ref uint uint_1,
    ref uint uint_2,
    ref uint uint_3,
    StringBuilder stringBuilder_1,
    uint uint_4);

  public fIntro()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void method_0() => GClass35.smethod_1((Control) this.label7);

  private void fIntro_Load(object sender, EventArgs e)
  {
    this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
    this.timer_0.Start();
  }

  private void timer_0_Tick(object sender, EventArgs e)
  {
    if (this.Opacity >= 0.0)
    {
      this.timer_0.Stop();
      try
      {
        this.Hide();
        try
        {
          int num = (int) new fMain("LongPham|DucLong@gmail.com|01/01/2099|PCMXNVCMSLOEJS|999|100").ShowDialog();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error:" + ex.ToString());
        }
      }
      catch (Exception ex)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi xảy ra, vui lòng liên hệ Admin để được hỗ trợ!"), 2);
        GClass19.smethod_79((GClass18) null, ex, "Run Program");
        this.Close();
      }
    }
    else
      this.Opacity += 0.02;
  }

  private void method_1(object sender, EventArgs e)
  {
    if (this.Opacity <= 0.0)
    {
      this.timer_0.Stop();
      this.Close();
    }
    else
      this.Opacity -= 0.05;
  }

  private void timer_1_Tick(object sender, EventArgs e)
  {
    if (this.progressBar.Value < 90)
      this.progressBar.Value += 10;
    else
      this.timer_1.Stop();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fIntro));
    this.progressBar = new MetroProgressBar();
    this.timer_0 = new Timer(this.components);
    this.timer_1 = new Timer(this.components);
    this.label7 = new Label();
    this.imageList1 = new ImageList(this.components);
    this.imageList2 = new ImageList(this.components);
    this.label1 = new Label();
    this.SuspendLayout();
    this.progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.progressBar.Location = new Point(38, 76);
    this.progressBar.Name = "progressBar";
    this.progressBar.Size = new Size(653, 23);
    this.progressBar.Step = 50;
    this.progressBar.TabIndex = 7;
    this.progressBar.Click += new EventHandler(this.progressBar_Click);
    this.timer_0.Interval = 30;
    this.timer_0.Tick += new EventHandler(this.timer_0_Tick_1);
    this.timer_1.Enabled = true;
    this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
    this.label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label7.AutoSize = true;
    this.label7.Font = new Font("Tahoma", 30f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label7.ForeColor = Color.DarkViolet;
    this.label7.Location = new Point(241, -5);
    this.label7.Name = "label7";
    this.label7.Size = new Size(218, 48);
    this.label7.TabIndex = 9;
    this.label7.Text = "MaxFarm ";
    this.label7.Click += new EventHandler(this.label7_Click);
    this.imageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList1.ImageStream");
    this.imageList1.TransparentColor = Color.Transparent;
    this.imageList1.Images.SetKeyName(0, "309424348_535573888567806_3761480761543198881_n.jpg");
    this.imageList2.ColorDepth = ColorDepth.Depth8Bit;
    this.imageList2.ImageSize = new Size(16, 16);
    this.imageList2.TransparentColor = Color.Transparent;
    this.label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 16.25f, FontStyle.Bold);
    this.label1.ForeColor = Color.DarkViolet;
    this.label1.Location = new Point(259, 43);
    this.label1.Name = "label1";
    this.label1.Size = new Size(166, 27);
    this.label1.TabIndex = 10;
    this.label1.Text = "038.472.1090";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.BackgroundImageLayout = ImageLayout.Center;
    this.ClientSize = new Size(731, 111);
    this.ControlBox = false;
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.progressBar);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (fIntro);
    this.Opacity = 0.0;
    this.ShowInTaskbar = false;
    this.SizeGripStyle = SizeGripStyle.Hide;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Kiểm tra thông tin";
    this.TopMost = true;
    this.Load += new EventHandler(this.fIntro_Load);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void ucContact1_Load(object sender, EventArgs e)
  {
  }

  private void timer_0_Tick_1(object sender, EventArgs e)
  {
  }

  private void label7_Click(object sender, EventArgs e)
  {
  }

  private void progressBar_Click(object sender, EventArgs e)
  {
  }
}
