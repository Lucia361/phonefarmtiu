﻿// Decompiled with JetBrains decompiler
// Type: fTienIchCheckProxy
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

public class fTienIchCheckProxy : Form
{
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel panel1;
  private BunifuDragControl bunifuDragControl_0;
  private ToolTip toolTip_0;
  private BunifuCards bunifuCards2;
  private Panel pnlHeader;
  private Button button2;
  private Button btnMinimize;
  private BunifuCustomLabel lblTitle;
  private Button btnAdd;
  private RichTextBox txtInput;
  private GroupBox grDaTao;
  private RichTextBox txtDaTao;
  private GroupBox groupBox1;
  private GroupBox grChuaTao;
  private RichTextBox txtChuaTao;
  private Label lblStatus;
  private ComboBox cbbTypeProxy;
  private IContainer components;
  private Label label3;

  public fTienIchCheckProxy()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.groupBox1);
    GClass35.smethod_1((Control) this.label3);
  }

  private void button2_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      int int_0 = this.cbbTypeProxy.SelectedIndex;
      List<string> stringList = new List<string>();
      List<string> list = ((IEnumerable<string>) this.txtInput.Lines).ToList<string>();
      int int_1 = 0;
      int num1 = 10;
      this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Visible = true));
      int num2 = 0;
      while (num2 < list.Count)
      {
        if (int_1 < num1)
        {
          Interlocked.Increment(ref int_1);
          string string_0 = list[num2++];
          new Thread((ThreadStart) (() =>
          {
            if (this.method_2(string_0, int_0))
              this.method_1(this.txtDaTao, string_0);
            else
              this.method_1(this.txtChuaTao, string_0);
            Interlocked.Decrement(ref int_1);
          }))
          {
            IsBackground = true
          }.Start();
        }
        else
        {
          Application.DoEvents();
          GClass19.smethod_64(1.0);
        }
      }
      while (int_1 > 0)
        GClass19.smethod_64(1.0);
      this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Visible = false));
      GClass14.smethod_0((object) GClass35.smethod_0("Đã check xong!"));
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
    }
  }

  private void method_1(RichTextBox richTextBox_0, string string_0) => richTextBox_0.Invoke((Delegate) (() =>
  {
    Application.DoEvents();
    RichTextBox richTextBox = richTextBox_0;
    richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
  }));

  private bool method_2(string string_0, int int_0)
  {
    try
    {
      if (GClass19.smethod_75(string_0, int_0) != "")
        return true;
    }
    catch
    {
    }
    return false;
  }

  private void txtInput_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtInput, (Control) this.groupBox1);

  private void txtDaTao_TextChanged(object sender, EventArgs e)
  {
    try
    {
      this.grDaTao.Text = "LIVE (" + GClass19.smethod_39(((IEnumerable<string>) this.txtDaTao.Lines).ToList<string>()).Count.ToString() + ")";
    }
    catch
    {
    }
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void fTienIchCheckProxy_Load(object sender, EventArgs e) => this.cbbTypeProxy.SelectedIndex = 0;

  private void txtChuaTao_TextChanged(object sender, EventArgs e)
  {
    try
    {
      this.grChuaTao.Text = "DIE (" + GClass19.smethod_39(((IEnumerable<string>) this.txtChuaTao.Lines).ToList<string>()).Count.ToString() + ")";
    }
    catch
    {
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
    this.components = (IContainer) new System.ComponentModel.Container();
    this.bunifuCards1 = new BunifuCards();
    this.panel1 = new Panel();
    this.lblStatus = new Label();
    this.grChuaTao = new GroupBox();
    this.txtChuaTao = new RichTextBox();
    this.grDaTao = new GroupBox();
    this.txtDaTao = new RichTextBox();
    this.groupBox1 = new GroupBox();
    this.cbbTypeProxy = new ComboBox();
    this.label3 = new Label();
    this.txtInput = new RichTextBox();
    this.btnAdd = new Button();
    this.bunifuCards2 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.btnMinimize = new Button();
    this.lblTitle = new BunifuCustomLabel();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.panel1.SuspendLayout();
    this.grChuaTao.SuspendLayout();
    this.grDaTao.SuspendLayout();
    this.groupBox1.SuspendLayout();
    this.bunifuCards2.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.SuspendLayout();
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 5;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Margin = new Padding(3, 4, 3, 4);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(421, 47);
    this.bunifuCards1.TabIndex = 12;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.lblStatus);
    this.panel1.Controls.Add((Control) this.grChuaTao);
    this.panel1.Controls.Add((Control) this.grDaTao);
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards2);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Margin = new Padding(3, 4, 3, 4);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(750, 404);
    this.panel1.TabIndex = 37;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.lblStatus.AutoSize = true;
    this.lblStatus.ForeColor = Color.DarkGreen;
    this.lblStatus.Location = new Point(435, 59);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(70, 16);
    this.lblStatus.TabIndex = 52;
    this.lblStatus.Text = "Checking...";
    this.lblStatus.Visible = false;
    this.grChuaTao.Controls.Add((Control) this.txtChuaTao);
    this.grChuaTao.ForeColor = Color.DarkRed;
    this.grChuaTao.Location = new Point(521, 91);
    this.grChuaTao.Name = "grChuaTao";
    this.grChuaTao.Size = new Size(221, 307);
    this.grChuaTao.TabIndex = 51;
    this.grChuaTao.TabStop = false;
    this.grChuaTao.Text = "DIE (0)";
    this.txtChuaTao.Dock = DockStyle.Fill;
    this.txtChuaTao.Location = new Point(3, 19);
    this.txtChuaTao.Name = "txtChuaTao";
    this.txtChuaTao.Size = new Size(215, 285);
    this.txtChuaTao.TabIndex = 50;
    this.txtChuaTao.Text = "";
    this.txtChuaTao.WordWrap = false;
    this.txtChuaTao.TextChanged += new EventHandler(this.txtChuaTao_TextChanged);
    this.grDaTao.Controls.Add((Control) this.txtDaTao);
    this.grDaTao.ForeColor = Color.DarkGreen;
    this.grDaTao.Location = new Point(294, 91);
    this.grDaTao.Name = "grDaTao";
    this.grDaTao.Size = new Size(221, 307);
    this.grDaTao.TabIndex = 51;
    this.grDaTao.TabStop = false;
    this.grDaTao.Text = "LIVE (0)";
    this.txtDaTao.Dock = DockStyle.Fill;
    this.txtDaTao.Location = new Point(3, 19);
    this.txtDaTao.Name = "txtDaTao";
    this.txtDaTao.Size = new Size(215, 285);
    this.txtDaTao.TabIndex = 50;
    this.txtDaTao.Text = "";
    this.txtDaTao.WordWrap = false;
    this.txtDaTao.TextChanged += new EventHandler(this.txtDaTao_TextChanged);
    this.groupBox1.Controls.Add((Control) this.cbbTypeProxy);
    this.groupBox1.Controls.Add((Control) this.label3);
    this.groupBox1.Controls.Add((Control) this.txtInput);
    this.groupBox1.Location = new Point(6, 40);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(282, 358);
    this.groupBox1.TabIndex = 51;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Nhập Proxy (0)";
    this.cbbTypeProxy.Cursor = Cursors.Hand;
    this.cbbTypeProxy.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbTypeProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbTypeProxy.FormattingEnabled = true;
    this.cbbTypeProxy.Items.AddRange(new object[2]
    {
      (object) "HTTP/HTTPS",
      (object) "Sock5"
    });
    this.cbbTypeProxy.Location = new Point(83, 324);
    this.cbbTypeProxy.Name = "cbbTypeProxy";
    this.cbbTypeProxy.Size = new Size(193, 24);
    this.cbbTypeProxy.TabIndex = 126;
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(6, 327);
    this.label3.Name = "label3";
    this.label3.Size = new Size(70, 16);
    this.label3.TabIndex = 125;
    this.label3.Text = "Loại Proxy:";
    this.txtInput.Location = new Point(9, 19);
    this.txtInput.Name = "txtInput";
    this.txtInput.Size = new Size(267, 299);
    this.txtInput.TabIndex = 50;
    this.txtInput.Text = "";
    this.txtInput.WordWrap = false;
    this.txtInput.TextChanged += new EventHandler(this.txtInput_TextChanged);
    this.btnAdd.BackColor = Color.Green;
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(294, 49);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(135, 36);
    this.btnAdd.TabIndex = 45;
    this.btnAdd.Text = "Check";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.bunifuCards2.BackColor = Color.White;
    this.bunifuCards2.BorderRadius = 0;
    this.bunifuCards2.BottomSahddow = true;
    this.bunifuCards2.color = Color.SaddleBrown;
    this.bunifuCards2.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards2.Dock = DockStyle.Top;
    this.bunifuCards2.LeftSahddow = false;
    this.bunifuCards2.Location = new Point(0, 0);
    this.bunifuCards2.Name = "bunifuCards2";
    this.bunifuCards2.RightSahddow = true;
    this.bunifuCards2.ShadowDepth = 20;
    this.bunifuCards2.Size = new Size(748, 37);
    this.bunifuCards2.TabIndex = 43;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.lblTitle);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(748, 31);
    this.pnlHeader.TabIndex = 9;
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) Resources.btnMinimize_Image;
    this.button2.Location = new Point(717, 1);
    this.button2.Name = "button2";
    this.button2.Size = new Size(30, 30);
    this.button2.TabIndex = 77;
    this.button2.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Location = new Point(899, 1);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(30, 30);
    this.btnMinimize.TabIndex = 9;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.lblTitle.BackColor = Color.Transparent;
    this.lblTitle.Cursor = Cursors.SizeAll;
    this.lblTitle.Dock = DockStyle.Fill;
    this.lblTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.Black;
    this.lblTitle.Location = new Point(0, 0);
    this.lblTitle.Name = "lblTitle";
    this.lblTitle.Size = new Size(748, 31);
    this.lblTitle.TabIndex = 12;
    this.lblTitle.Text = "Check Proxy";
    this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.lblTitle;
    this.bunifuDragControl_0.Vertical = true;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 10000;
    this.toolTip_0.InitialDelay = 200;
    this.toolTip_0.ReshowDelay = 40;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(750, 404);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fTienIchCheckProxy);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fTienIchCheckProxy_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.grChuaTao.ResumeLayout(false);
    this.grDaTao.ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
