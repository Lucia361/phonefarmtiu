// Decompiled with JetBrains decompiler
// Type: fHenGioChayDung
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fHenGioChayDung : Form
{
  private GClass22 gclass22_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private BunifuDragControl bunifuDragControl_0;
  private Button btnCancel;
  private Button btnAdd;
  private CheckBox ckbTatPhanMem;
  private CheckBox ckbTatMay;
  private CheckBox ckbGiaiPhongDungLuong;
  private ComboBox cbbHenGioChayTime;
  private Button button1;
  private Button button4;
  private CheckBox ckbHenGioChay;
  private CheckBox ckbHenGioDung;
  private ComboBox cbbHenGioDungTime;
  private Button button7;
  private Button button8;
  private Panel plHenGioChay;
  private Panel plHenGioDung;
  private IContainer components;
  private Panel panel1;

  public fHenGioChayDung(GClass22 gclass22_1)
  {
    this.InitializeComponent();
    this.gclass22_0 = gclass22_1;
  }

  private void btnMinimize_Click(object sender, EventArgs e)
  {
    this.gclass22_0.method_6("isCancel", (object) true);
    this.Close();
  }

  private void method_0(Control control_0, bool bool_0 = true)
  {
    try
    {
      control_0.Invoke((Delegate) (() => control_0.Enabled = bool_0));
    }
    catch
    {
    }
  }

  private void fHenGioChayDung_Load(object sender, EventArgs e)
  {
    this.method_1();
    this.ckbHenGioChay.Checked = GClass33.smethod_0("henGioTatTool").method_4("ckbHenGioChay");
    this.cbbHenGioChayTime.Text = GClass33.smethod_0("henGioTatTool").method_1("timeStart");
    this.ckbHenGioDung.Checked = GClass33.smethod_0("henGioTatTool").method_4("ckbHenGioDung");
    this.cbbHenGioDungTime.Text = GClass33.smethod_0("henGioTatTool").method_1("timeStop");
    this.ckbTatPhanMem.Checked = GClass33.smethod_0("henGioTatTool").method_4("ckbTatPhanMem");
    this.ckbGiaiPhongDungLuong.Checked = GClass33.smethod_0("henGioTatTool").method_4("ckbGiaiPhongDungLuong");
    this.ckbTatMay.Checked = GClass33.smethod_0("henGioTatTool").method_4("ckbTatMay");
    this.ckbHenGioChay_CheckedChanged((object) null, (EventArgs) null);
    this.ckbHenGioDung_CheckedChanged((object) null, (EventArgs) null);
  }

  private void method_1()
  {
    this.method_4(this.cbbHenGioChayTime, "lstTimeStart");
    this.method_4(this.cbbHenGioDungTime, "lstTimeStop");
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    GClass33.smethod_0("henGioTatTool").method_6("ckbHenGioChay", (object) this.ckbHenGioChay.Checked);
    GClass33.smethod_0("henGioTatTool").method_6("timeStart", (object) this.cbbHenGioChayTime.Text);
    GClass33.smethod_0("henGioTatTool").method_6("ckbHenGioDung", (object) this.ckbHenGioDung.Checked);
    GClass33.smethod_0("henGioTatTool").method_6("timeStop", (object) this.cbbHenGioDungTime.Text);
    GClass33.smethod_0("henGioTatTool").method_6("ckbTatPhanMem", (object) this.ckbTatPhanMem.Checked);
    GClass33.smethod_0("henGioTatTool").method_6("ckbGiaiPhongDungLuong", (object) this.ckbGiaiPhongDungLuong.Checked);
    GClass33.smethod_0("henGioTatTool").method_6("ckbTatMay", (object) this.ckbTatMay.Checked);
    GClass33.smethod_2("henGioTatTool");
    if (this.ckbHenGioChay.Checked)
      this.gclass22_0.method_6("timeStart", (object) this.cbbHenGioChayTime.Text);
    if (this.ckbHenGioDung.Checked)
      this.gclass22_0.method_6("timeStop", (object) this.cbbHenGioDungTime.Text);
    this.gclass22_0.method_6("ckbTatPhanMem", (object) (bool) (!this.ckbTatPhanMem.Enabled ? 0 : (this.ckbTatPhanMem.Checked ? 1 : 0)));
    this.gclass22_0.method_6("ckbGiaiPhongDungLuong", (object) (bool) (!this.ckbGiaiPhongDungLuong.Enabled ? 0 : (this.ckbGiaiPhongDungLuong.Checked ? 1 : 0)));
    this.gclass22_0.method_6("ckbTatMay", (object) (bool) (!this.ckbTatMay.Enabled ? 0 : (this.ckbTatMay.Checked ? 1 : 0)));
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.gclass22_0.method_6("isCancel", (object) true);
    this.Close();
  }

  private void method_2(ComboBox comboBox_0, string string_0)
  {
    fHenGioChayDungAddTime gioChayDungAddTime = new fHenGioChayDungAddTime();
    int num = (int) gioChayDungAddTime.ShowDialog();
    string string0 = gioChayDungAddTime.string_0;
    if (string0 == "")
      return;
    List<string> list_0 = GClass33.smethod_0("henGioTatTool").method_2(string_0);
    list_0.Add(string0);
    GClass33.smethod_0("henGioTatTool").method_8(string_0, list_0);
    GClass33.smethod_2("henGioTatTool");
    comboBox_0.Items.Add((object) string0);
    comboBox_0.SelectedIndex = comboBox_0.Items.Count - 1;
  }

  private void method_3(ComboBox comboBox_0, string string_0)
  {
    if (comboBox_0.Items.Count == 0 || GClass14.smethod_1("Bạn có chắc chắn muốn xóa thời gian này không?") == DialogResult.No)
      return;
    List<string> list_0 = GClass33.smethod_0("henGioTatTool").method_2(string_0);
    for (int index = 0; index < list_0.Count; ++index)
    {
      if (list_0[index].Split('-')[0].Trim() == comboBox_0.Text)
        list_0.RemoveAt(index--);
    }
    GClass33.smethod_0("henGioTatTool").method_8(string_0, list_0);
    GClass33.smethod_2("henGioTatTool");
    int selectedIndex = comboBox_0.SelectedIndex;
    comboBox_0.Items.RemoveAt(comboBox_0.SelectedIndex);
    if (selectedIndex == comboBox_0.Items.Count)
      comboBox_0.SelectedIndex = comboBox_0.Items.Count - 1;
    else
      comboBox_0.SelectedIndex = selectedIndex;
  }

  private void method_4(ComboBox comboBox_0, string string_0)
  {
    List<string> list_0 = GClass33.smethod_0("henGioTatTool").method_2(string_0);
    if (list_0.Count == 0)
    {
      if (string_0 == "lstTimeStart")
        list_0.Add("08:00:00");
      else
        list_0.Add("22:30:00");
      GClass33.smethod_0("henGioTatTool").method_8(string_0, list_0);
      GClass33.smethod_2("henGioTatTool");
    }
    foreach (string str in list_0)
      comboBox_0.Items.Add((object) str.Split('-')[0].Trim());
    comboBox_0.SelectedIndex = 0;
  }

  private void button1_Click(object sender, EventArgs e) => this.method_2(this.cbbHenGioChayTime, "lstTimeStart");

  private void button4_Click(object sender, EventArgs e) => this.method_3(this.cbbHenGioChayTime, "lstTimeStart");

  private void button7_Click(object sender, EventArgs e) => this.method_2(this.cbbHenGioDungTime, "lstTimeStop");

  private void button8_Click(object sender, EventArgs e) => this.method_3(this.cbbHenGioDungTime, "lstTimeStop");

  private void ckbHenGioChay_CheckedChanged(object sender, EventArgs e) => this.plHenGioChay.Enabled = this.ckbHenGioChay.Checked;

  private void ckbHenGioDung_CheckedChanged(object sender, EventArgs e)
  {
    this.plHenGioDung.Enabled = this.ckbHenGioDung.Checked;
    this.ckbTatPhanMem.Enabled = this.ckbHenGioDung.Checked;
    this.ckbGiaiPhongDungLuong.Enabled = this.ckbHenGioDung.Checked;
    this.ckbTatMay.Enabled = this.ckbHenGioDung.Checked;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHenGioChayDung));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.ckbTatPhanMem = new CheckBox();
    this.ckbTatMay = new CheckBox();
    this.ckbGiaiPhongDungLuong = new CheckBox();
    this.cbbHenGioChayTime = new ComboBox();
    this.button1 = new Button();
    this.button4 = new Button();
    this.ckbHenGioChay = new CheckBox();
    this.ckbHenGioDung = new CheckBox();
    this.cbbHenGioDungTime = new ComboBox();
    this.button7 = new Button();
    this.button8 = new Button();
    this.plHenGioChay = new Panel();
    this.plHenGioDung = new Panel();
    this.panel1 = new Panel();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.plHenGioChay.SuspendLayout();
    this.plHenGioDung.SuspendLayout();
    this.panel1.SuspendLayout();
    this.SuspendLayout();
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.Dock = DockStyle.Top;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(379, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(379, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(347, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 9;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(379, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Hẹn giờ chạy tool";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(200, 100);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 183;
    this.btnCancel.Text = "Hủy";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(92, 100);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 182;
    this.btnAdd.Text = "Xác nhận";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.ckbTatPhanMem.AutoSize = true;
    this.ckbTatPhanMem.Cursor = Cursors.Hand;
    this.ckbTatPhanMem.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbTatPhanMem.Location = new Point(34, 199);
    this.ckbTatPhanMem.Name = "ckbTatPhanMem";
    this.ckbTatPhanMem.Size = new Size(110, 20);
    this.ckbTatPhanMem.TabIndex = 194;
    this.ckbTatPhanMem.Text = "Tắt phần mềm";
    this.ckbTatPhanMem.UseVisualStyleBackColor = true;
    this.ckbTatPhanMem.Visible = false;
    this.ckbTatMay.AutoSize = true;
    this.ckbTatMay.Cursor = Cursors.Hand;
    this.ckbTatMay.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbTatMay.Location = new Point(34, 251);
    this.ckbTatMay.Name = "ckbTatMay";
    this.ckbTatMay.Size = new Size(73, 20);
    this.ckbTatMay.TabIndex = 194;
    this.ckbTatMay.Text = "Tắt máy";
    this.ckbTatMay.UseVisualStyleBackColor = true;
    this.ckbTatMay.Visible = false;
    this.ckbGiaiPhongDungLuong.AutoSize = true;
    this.ckbGiaiPhongDungLuong.Cursor = Cursors.Hand;
    this.ckbGiaiPhongDungLuong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbGiaiPhongDungLuong.Location = new Point(34, 225);
    this.ckbGiaiPhongDungLuong.Name = "ckbGiaiPhongDungLuong";
    this.ckbGiaiPhongDungLuong.Size = new Size(154, 20);
    this.ckbGiaiPhongDungLuong.TabIndex = 194;
    this.ckbGiaiPhongDungLuong.Text = "Giải phóng dung lượng";
    this.ckbGiaiPhongDungLuong.UseVisualStyleBackColor = true;
    this.ckbGiaiPhongDungLuong.Visible = false;
    this.cbbHenGioChayTime.Cursor = Cursors.Hand;
    this.cbbHenGioChayTime.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbHenGioChayTime.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbHenGioChayTime.FormattingEnabled = true;
    this.cbbHenGioChayTime.Location = new Point(3, 3);
    this.cbbHenGioChayTime.Name = "cbbHenGioChayTime";
    this.cbbHenGioChayTime.Size = new Size(151, 24);
    this.cbbHenGioChayTime.TabIndex = 195;
    this.button1.Cursor = Cursors.Hand;
    this.button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button1.Location = new Point(160, 2);
    this.button1.Name = "button1";
    this.button1.Size = new Size(25, 25);
    this.button1.TabIndex = 196;
    this.button1.Text = "+";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.button4.Cursor = Cursors.Hand;
    this.button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button4.Location = new Point(187, 2);
    this.button4.Name = "button4";
    this.button4.Size = new Size(25, 25);
    this.button4.TabIndex = 196;
    this.button4.Text = "-";
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.ckbHenGioChay.AutoSize = true;
    this.ckbHenGioChay.Cursor = Cursors.Hand;
    this.ckbHenGioChay.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbHenGioChay.Location = new Point(34, 62);
    this.ckbHenGioChay.Name = "ckbHenGioChay";
    this.ckbHenGioChay.Size = new Size(99, 20);
    this.ckbHenGioChay.TabIndex = 194;
    this.ckbHenGioChay.Text = "Hẹn giờ chạy";
    this.ckbHenGioChay.UseVisualStyleBackColor = true;
    this.ckbHenGioChay.CheckedChanged += new EventHandler(this.ckbHenGioChay_CheckedChanged);
    this.ckbHenGioDung.AutoSize = true;
    this.ckbHenGioDung.Cursor = Cursors.Hand;
    this.ckbHenGioDung.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbHenGioDung.Location = new Point(34, 172);
    this.ckbHenGioDung.Name = "ckbHenGioDung";
    this.ckbHenGioDung.Size = new Size(102, 20);
    this.ckbHenGioDung.TabIndex = 194;
    this.ckbHenGioDung.Text = "Hẹn giờ dừng";
    this.ckbHenGioDung.UseVisualStyleBackColor = true;
    this.ckbHenGioDung.Visible = false;
    this.ckbHenGioDung.CheckedChanged += new EventHandler(this.ckbHenGioDung_CheckedChanged);
    this.cbbHenGioDungTime.Cursor = Cursors.Hand;
    this.cbbHenGioDungTime.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbHenGioDungTime.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbHenGioDungTime.FormattingEnabled = true;
    this.cbbHenGioDungTime.Location = new Point(3, 3);
    this.cbbHenGioDungTime.Name = "cbbHenGioDungTime";
    this.cbbHenGioDungTime.Size = new Size(151, 24);
    this.cbbHenGioDungTime.TabIndex = 195;
    this.button7.Cursor = Cursors.Hand;
    this.button7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button7.Location = new Point(160, 2);
    this.button7.Name = "button7";
    this.button7.Size = new Size(25, 25);
    this.button7.TabIndex = 196;
    this.button7.Text = "+";
    this.button7.UseVisualStyleBackColor = true;
    this.button7.Click += new EventHandler(this.button7_Click);
    this.button8.Cursor = Cursors.Hand;
    this.button8.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button8.Location = new Point(187, 2);
    this.button8.Name = "button8";
    this.button8.Size = new Size(25, 25);
    this.button8.TabIndex = 196;
    this.button8.Text = "-";
    this.button8.UseVisualStyleBackColor = true;
    this.button8.Click += new EventHandler(this.button8_Click);
    this.plHenGioChay.Controls.Add((Control) this.cbbHenGioChayTime);
    this.plHenGioChay.Controls.Add((Control) this.button1);
    this.plHenGioChay.Controls.Add((Control) this.button4);
    this.plHenGioChay.Location = new Point(135, 57);
    this.plHenGioChay.Name = "plHenGioChay";
    this.plHenGioChay.Size = new Size(212, 29);
    this.plHenGioChay.TabIndex = 197;
    this.plHenGioDung.Controls.Add((Control) this.cbbHenGioDungTime);
    this.plHenGioDung.Controls.Add((Control) this.button7);
    this.plHenGioDung.Controls.Add((Control) this.button8);
    this.plHenGioDung.Location = new Point(135, 167);
    this.plHenGioDung.Name = "plHenGioDung";
    this.plHenGioDung.Size = new Size(212, 29);
    this.plHenGioDung.TabIndex = 197;
    this.plHenGioDung.Visible = false;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(381, 142);
    this.panel1.TabIndex = 198;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(381, 142);
    this.Controls.Add((Control) this.plHenGioDung);
    this.Controls.Add((Control) this.plHenGioChay);
    this.Controls.Add((Control) this.ckbTatMay);
    this.Controls.Add((Control) this.ckbGiaiPhongDungLuong);
    this.Controls.Add((Control) this.ckbHenGioDung);
    this.Controls.Add((Control) this.ckbHenGioChay);
    this.Controls.Add((Control) this.ckbTatPhanMem);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.panel1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fHenGioChayDung);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fHenGioChayDung_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.plHenGioChay.ResumeLayout(false);
    this.plHenGioDung.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
