﻿// Decompiled with JetBrains decompiler
// Type: fHDMoiBanBeVaoNhom
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fHDMoiBanBeVaoNhom : Form
{
  private GClass22 gclass22_0 = (GClass22) null;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private Panel panel1;
  private NumericUpDown nudSoLuongTo;
  private NumericUpDown nudSoLuongFrom;
  private TextBox txtTenHanhDong;
  private Label label3;
  private Label label4;
  private Label label2;
  private Label label1;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private Button button1;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Label lblStatus;
  private ToolTip toolTip_0;
  private RadioButton rbInviteSuggest;
  private RadioButton rbInviteRandom;
  private Label label5;
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label9;
  private Label label7;
  private Label label6;
  private IContainer components;
  private TextBox txtIdGroup;

  public fHDMoiBanBeVaoNhom(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDMoiBanBeVaoNhom.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDMoiBanBeVaoNhom");
        string_1 = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        string_1 = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.gclass22_0 = new GClass22(string_1, true);
    GClass35.smethod_5((Control) this);
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.label4);
    GClass35.smethod_1((Control) this.label6);
    GClass35.smethod_1((Control) this.label9);
    GClass35.smethod_1((Control) this.label7);
    GClass35.smethod_1((Control) this.label5);
    GClass35.smethod_1((Control) this.rbInviteRandom);
    GClass35.smethod_1((Control) this.rbInviteSuggest);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDMoiBanBeVaoNhom_Load(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass22_0.method_3("typeInvite", 1) == 0)
        this.rbInviteRandom.Checked = true;
      else
        this.rbInviteSuggest.Checked = true;
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom", 3);
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo", 5);
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom", 1);
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo", 3);
      this.txtIdGroup.Text = this.gclass22_0.method_1("txtIdGroup");
    }
    catch
    {
    }
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("txtIdGroup", (object) this.txtIdGroup.Text.Trim());
      if (this.rbInviteRandom.Checked)
        gclass22.method_6("typeInvite", (object) 0);
      else
        gclass22.method_6("typeInvite", (object) 1);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDMoiBanBeVaoNhom.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Thêm thất bại, vui lòng thử lại sau!"), 2);
      }
      else
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn cập nhật hành động?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_21(this.string_2, string_1, str))
        {
          fHDMoiBanBeVaoNhom.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Cập nhật thất bại, vui lòng thử lại sau!"), 2);
      }
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
    if (this.panel1.BorderStyle != BorderStyle.FixedSingle)
      return;
    int num1 = 1;
    int num2 = 0;
    using (Pen pen1 = new Pen(Color.DarkViolet, 1f))
    {
      Graphics graphics = e.Graphics;
      Pen pen2 = pen1;
      int x = num2;
      int y = num2;
      Size clientSize = this.panel1.ClientSize;
      int width = clientSize.Width - num1;
      clientSize = this.panel1.ClientSize;
      int height = clientSize.Height - num1;
      Rectangle rect = new Rectangle(x, y, width, height);
      graphics.DrawRectangle(pen2, rect);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDMoiBanBeVaoNhom));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.txtIdGroup = new TextBox();
    this.rbInviteSuggest = new RadioButton();
    this.rbInviteRandom = new RadioButton();
    this.label5 = new Label();
    this.lblStatus = new Label();
    this.nudDelayTo = new NumericUpDown();
    this.nudSoLuongTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.nudSoLuongFrom = new NumericUpDown();
    this.txtTenHanhDong = new TextBox();
    this.label9 = new Label();
    this.label3 = new Label();
    this.label7 = new Label();
    this.label4 = new Label();
    this.label6 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.toolTip_0 = new ToolTip(this.components);
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.nudDelayTo.BeginInit();
    this.nudSoLuongTo.BeginInit();
    this.nudDelayFrom.BeginInit();
    this.nudSoLuongFrom.BeginInit();
    this.bunifuCards1.SuspendLayout();
    this.SuspendLayout();
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(359, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Mời bạn bè vào nhóm";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button1);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(359, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(328, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.txtIdGroup);
    this.panel1.Controls.Add((Control) this.rbInviteSuggest);
    this.panel1.Controls.Add((Control) this.rbInviteRandom);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.lblStatus);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.nudSoLuongTo);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.nudSoLuongFrom);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label9);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(362, 214);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.txtIdGroup.Location = new Point(132, 138);
    this.txtIdGroup.Name = "txtIdGroup";
    this.txtIdGroup.Size = new Size(194, 23);
    this.txtIdGroup.TabIndex = 116;
    this.rbInviteSuggest.AutoSize = true;
    this.rbInviteSuggest.Cursor = Cursors.Hand;
    this.rbInviteSuggest.Location = new Point(132, 232);
    this.rbInviteSuggest.Name = "rbInviteSuggest";
    this.rbInviteSuggest.Size = new Size(135, 20);
    this.rbInviteSuggest.TabIndex = 115;
    this.rbInviteSuggest.Text = "Gợi ý của Facebook";
    this.rbInviteSuggest.UseVisualStyleBackColor = true;
    this.rbInviteSuggest.Visible = false;
    this.rbInviteRandom.AutoSize = true;
    this.rbInviteRandom.Checked = true;
    this.rbInviteRandom.Cursor = Cursors.Hand;
    this.rbInviteRandom.Location = new Point(132, 256);
    this.rbInviteRandom.Name = "rbInviteRandom";
    this.rbInviteRandom.Size = new Size(155, 20);
    this.rbInviteRandom.TabIndex = 115;
    this.rbInviteRandom.TabStop = true;
    this.rbInviteRandom.Text = "Mời ngẫu nhiên bạn bè";
    this.rbInviteRandom.UseVisualStyleBackColor = true;
    this.rbInviteRandom.Visible = false;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 234);
    this.label5.Name = "label5";
    this.label5.Size = new Size(89, 16);
    this.label5.TabIndex = 0;
    this.label5.Text = "Tùy chọn mời:";
    this.label5.Visible = false;
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(27, 141);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(93, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nhập ID nhóm:";
    this.nudDelayTo.Location = new Point(229, 109);
    this.nudDelayTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayTo.Name = "nudDelayTo";
    this.nudDelayTo.Size = new Size(56, 23);
    this.nudDelayTo.TabIndex = 2;
    this.nudSoLuongTo.Location = new Point(229, 80);
    this.nudSoLuongTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongTo.Name = "nudSoLuongTo";
    this.nudSoLuongTo.Size = new Size(56, 23);
    this.nudSoLuongTo.TabIndex = 2;
    this.nudDelayFrom.Location = new Point(132, 109);
    this.nudDelayFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayFrom.Name = "nudDelayFrom";
    this.nudDelayFrom.Size = new Size(56, 23);
    this.nudDelayFrom.TabIndex = 1;
    this.nudSoLuongFrom.Location = new Point(132, 80);
    this.nudSoLuongFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongFrom.Name = "nudSoLuongFrom";
    this.nudSoLuongFrom.Size = new Size(56, 23);
    this.nudSoLuongFrom.TabIndex = 1;
    this.txtTenHanhDong.Location = new Point(132, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label9.Location = new Point(194, 111);
    this.label9.Name = "label9";
    this.label9.Size = new Size(29, 16);
    this.label9.TabIndex = 37;
    this.label9.Text = "đến";
    this.label9.TextAlign = ContentAlignment.MiddleCenter;
    this.label3.Location = new Point(194, 82);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(287, 111);
    this.label7.Name = "label7";
    this.label7.Size = new Size(30, 16);
    this.label7.TabIndex = 35;
    this.label7.Text = "giây";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(287, 82);
    this.label4.Name = "label4";
    this.label4.Size = new Size(28, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "bạn";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(27, 111);
    this.label6.Name = "label6";
    this.label6.Size = new Size(99, 16);
    this.label6.TabIndex = 32;
    this.label6.Text = "Thời gian delay:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 82);
    this.label2.Name = "label2";
    this.label2.Size = new Size(88, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Số lượng mời:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(27, 52);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 16);
    this.label1.TabIndex = 31;
    this.label1.Text = "Tên hành động:";
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(191, 174);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 7;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(80, 174);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 6;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.DarkViolet;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(1, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(359, 37);
    this.bunifuCards1.TabIndex = 28;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 0;
    this.toolTip_0.InitialDelay = 0;
    this.toolTip_0.ReshowDelay = 0;
    this.toolTip_0.ShowAlways = true;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(362, 214);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDMoiBanBeVaoNhom);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDMoiBanBeVaoNhom_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.nudDelayTo.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
