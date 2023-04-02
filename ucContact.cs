// Decompiled with JetBrains decompiler
// Type: ucContact
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class ucContact : UserControl
{
  private IContainer icontainer_0 = (IContainer) null;
  private Label label12;
  private Label label3;
  private Panel panel2;
  private LinkLabel linkLabel1;
  private LinkLabel linkLabel2;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label11;
  private PictureBox pictureBox2;
  private PictureBox pictureBox1;
  private Label label1;
  private PictureBox pictureBox3;
  private Label label9;
  private Label label7;
  private Label label8;
  private Label label2;

  public ucContact() => this.InitializeComponent();

  private void linkLabel2_Click(object sender, EventArgs e)
  {
    string text = (sender as LinkLabel).Text;
    try
    {
      Process.Start("chrome.exe", text);
    }
    catch
    {
      Process.Start(text);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ucContact));
    this.label12 = new Label();
    this.label3 = new Label();
    this.panel2 = new Panel();
    this.pictureBox3 = new PictureBox();
    this.linkLabel1 = new LinkLabel();
    this.linkLabel2 = new LinkLabel();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label11 = new Label();
    this.label1 = new Label();
    this.pictureBox2 = new PictureBox();
    this.pictureBox1 = new PictureBox();
    this.label2 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.pictureBox3).BeginInit();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.SuspendLayout();
    this.label12.BorderStyle = BorderStyle.FixedSingle;
    this.label12.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label12.ForeColor = Color.Red;
    this.label12.Location = new Point(214, 357);
    this.label12.Name = "label12";
    this.label12.Size = new Size(489, 110);
    this.label12.TabIndex = 28;
    this.label12.Text = "Chú ý: Nghiêm cấm sử dụng phần mềm vào các mục đích xấu, vi phạm pháp luật. Nếu cố tình sẽ bị xóa khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trước pháp luật.";
    this.label12.TextAlign = ContentAlignment.MiddleCenter;
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label3.ForeColor = Color.FromArgb(192, 64, 0);
    this.label3.Location = new Point(209, 172);
    this.label3.Name = "label3";
    this.label3.Size = new Size(164, 25);
    this.label3.TabIndex = 27;
    this.label3.Text = "Hỗ trợ phần mềm:";
    this.panel2.BackColor = Color.WhiteSmoke;
    this.panel2.BorderStyle = BorderStyle.FixedSingle;
    this.panel2.Controls.Add((Control) this.pictureBox3);
    this.panel2.Controls.Add((Control) this.linkLabel1);
    this.panel2.Controls.Add((Control) this.linkLabel2);
    this.panel2.Controls.Add((Control) this.label4);
    this.panel2.Controls.Add((Control) this.label9);
    this.panel2.Controls.Add((Control) this.label7);
    this.panel2.Controls.Add((Control) this.label5);
    this.panel2.Controls.Add((Control) this.label6);
    this.panel2.Controls.Add((Control) this.label8);
    this.panel2.Controls.Add((Control) this.label2);
    this.panel2.Controls.Add((Control) this.label11);
    this.panel2.Location = new Point(214, 198);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(489, 146);
    this.panel2.TabIndex = 25;
    this.pictureBox3.Image = (Image) Resource.Bitmap_2;
    this.pictureBox3.Location = new Point(340, -3);
    this.pictureBox3.Name = "pictureBox3";
    this.pictureBox3.Size = new Size(150, 150);
    this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox3.TabIndex = 10;
    this.pictureBox3.TabStop = false;
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.linkLabel1.Location = new Point(94, 4);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(247, 25);
    this.linkLabel1.TabIndex = 9;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "https://maxphonefarm.com/";
    this.linkLabel1.Click += new EventHandler(this.linkLabel2_Click);
    this.linkLabel2.AutoSize = true;
    this.linkLabel2.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.linkLabel2.Location = new Point(94, 33);
    this.linkLabel2.Name = "linkLabel2";
    this.linkLabel2.Size = new Size(242, 25);
    this.linkLabel2.TabIndex = 9;
    this.linkLabel2.TabStop = true;
    this.linkLabel2.Text = "http://bit.ly/MaxPhoneFarm";
    this.linkLabel2.Click += new EventHandler(this.linkLabel2_Click);
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label4.ForeColor = Color.Black;
    this.label4.Location = new Point(3, 4);
    this.label4.Name = "label4";
    this.label4.Size = new Size(83, 25);
    this.label4.TabIndex = 2;
    this.label4.Text = "Website:";
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label5.ForeColor = Color.Black;
    this.label5.Location = new Point(3, 64);
    this.label5.Name = "label5";
    this.label5.Size = new Size(77, 25);
    this.label5.TabIndex = 2;
    this.label5.Text = "Hotline:";
    this.label6.AutoSize = true;
    this.label6.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label6.ForeColor = Color.Black;
    this.label6.Location = new Point(3, 33);
    this.label6.Name = "label6";
    this.label6.Size = new Size(87, 25);
    this.label6.TabIndex = 2;
    this.label6.Text = "Fanpage:";
    this.label11.AutoSize = true;
    this.label11.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label11.ForeColor = Color.Black;
    this.label11.Location = new Point(94, 64);
    this.label11.Name = "label11";
    this.label11.Size = new Size(246, 25);
    this.label11.TabIndex = 2;
    this.label11.Text = "0975.337.854 - 0869.226.226";
    this.label1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(33, 143);
    this.label1.Name = "label1";
    this.label1.Size = new Size(653, 21);
    this.label1.TabIndex = 21;
    this.label1.Text = "PHẦN MỀM HỖ TRỢ KINH DOANH ONLINE - TỰ ĐỘNG HÓA MỌI THAO TÁC CỦA BẠN";
    this.label1.TextAlign = ContentAlignment.MiddleCenter;
    this.pictureBox2.Image = (Image) Resource.Bitmap_3;
    this.pictureBox2.Location = new Point(-17, 172);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(230, 295);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
    this.pictureBox2.TabIndex = 23;
    this.pictureBox2.TabStop = false;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(66, 3);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(620, 130);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 22;
    this.pictureBox1.TabStop = false;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.ForeColor = Color.Black;
    this.label2.Location = new Point(94, 91);
    this.label2.Name = "label2";
    this.label2.Size = new Size(120, 25);
    this.label2.TabIndex = 2;
    this.label2.Text = "0966.260.829";
    this.label7.AutoSize = true;
    this.label7.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label7.ForeColor = Color.Black;
    this.label7.Location = new Point(3, 91);
    this.label7.Name = "label7";
    this.label7.Size = new Size(62, 25);
    this.label7.TabIndex = 2;
    this.label7.Text = "CSKH:";
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label8.ForeColor = Color.Black;
    this.label8.Location = new Point(94, 118);
    this.label8.Name = "label8";
    this.label8.Size = new Size(120, 25);
    this.label8.TabIndex = 2;
    this.label8.Text = "0358.394.040";
    this.label9.AutoSize = true;
    this.label9.Font = new Font("Segoe UI", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label9.ForeColor = Color.Black;
    this.label9.Location = new Point(4, 118);
    this.label9.Name = "label9";
    this.label9.Size = new Size(95, 25);
    this.label9.TabIndex = 2;
    this.label9.Text = "Khiếu nại:";
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.label12);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this.pictureBox2);
    this.Controls.Add((Control) this.pictureBox1);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Margin = new Padding(4);
    this.Name = nameof (ucContact);
    this.Size = new Size(714, 472);
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    ((ISupportInitialize) this.pictureBox3).EndInit();
    ((ISupportInitialize) this.pictureBox2).EndInit();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
