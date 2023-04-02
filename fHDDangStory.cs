// Decompiled with JetBrains decompiler
// Type: fHDDangStory
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fHDDangStory : Form
{
  private GClass22 gclass22_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private Panel panel1;
  private TextBox txtTenHanhDong;
  private Label label1;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private Button button1;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Label lblStatus;
  private CheckBox ckbUseBackgroundText;
  private Label label8;
  private Panel plDangText;
  private Label label2;
  private Panel plDangNhac;
  private Panel plBaiHatChiDinh;
  private Label label3;
  private Label label4;
  private RadioButton rbBaiHatChiDinh;
  private RadioButton rbBaiHatNgauNhien;
  private RadioButton rbDangNhac;
  private RadioButton rbDangText;
  private Label label5;
  private NumericUpDown nudSoLuongTo;
  private NumericUpDown nudSoLuongFrom;
  private Label label6;
  private Label label7;
  private RichTextBox txtNoiDung;
  private RichTextBox txtDanhSachBaiHat;
  private CheckBox ckbAnh;
  private CheckBox ckbUseBackgroundNhac;
  private Panel plAnh;
  private CheckBox ckbXoaAnhDaDang;
  private TextBox txtPathAnh;
  private Label label12;
  private RadioButton rbChiDangAnh;
  private Panel plChiDangAnh;
  private CheckBox ckbChiDangAnhXoaAnhDaDang;
  private TextBox txtChiDangAnhPathAnh;
  private IContainer components;
  private Label label9;

  public fHDDangStory(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDDangStory.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDDangStory").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDDangStory', 'Đăng story');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDDangStory");
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

  private void fHDDangStory_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom", 1);
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo", 1);
      if (this.gclass22_0.method_3("typeDang") == 0)
        this.rbDangText.Checked = true;
      else if (this.gclass22_0.method_3("typeDang") == 1)
        this.rbDangNhac.Checked = true;
      else
        this.rbChiDangAnh.Checked = true;
      this.txtNoiDung.Text = this.gclass22_0.method_1("txtNoiDung");
      this.ckbUseBackgroundText.Checked = this.gclass22_0.method_4("ckbUseBackgroundText");
      if (this.gclass22_0.method_3("typeBaiHat") == 0)
        this.rbBaiHatNgauNhien.Checked = true;
      else
        this.rbBaiHatChiDinh.Checked = true;
      this.txtDanhSachBaiHat.Text = this.gclass22_0.method_1("txtDanhSachBaiHat");
      this.ckbUseBackgroundNhac.Checked = this.gclass22_0.method_4("ckbUseBackgroundNhac");
      this.ckbAnh.Checked = this.gclass22_0.method_4("ckbAnh");
      this.txtPathAnh.Text = this.gclass22_0.method_1("txtPathAnh");
      this.ckbXoaAnhDaDang.Checked = this.gclass22_0.method_4("ckbXoaAnhDaDang");
      this.txtChiDangAnhPathAnh.Text = this.gclass22_0.method_1("txtChiDangAnhPathAnh");
      this.ckbChiDangAnhXoaAnhDaDang.Checked = this.gclass22_0.method_4("ckbChiDangAnhXoaAnhDaDang");
    }
    catch
    {
    }
    this.method_1();
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
      if (this.rbDangText.Checked)
        gclass22.method_6("typeDang", (object) 0);
      else if (this.rbDangNhac.Checked)
        gclass22.method_6("typeDang", (object) 1);
      else
        gclass22.method_6("typeDang", (object) 2);
      gclass22.method_6("txtNoiDung", (object) this.txtNoiDung.Text);
      gclass22.method_6("ckbUseBackgroundText", (object) this.ckbUseBackgroundText.Checked);
      if (this.rbBaiHatNgauNhien.Checked)
        gclass22.method_6("typeBaiHat", (object) 0);
      else
        gclass22.method_6("typeBaiHat", (object) 1);
      gclass22.method_6("txtDanhSachBaiHat", (object) this.txtDanhSachBaiHat.Text);
      gclass22.method_6("ckbUseBackgroundNhac", (object) this.ckbUseBackgroundNhac.Checked);
      gclass22.method_6("ckbAnh", (object) this.ckbAnh.Checked);
      gclass22.method_6("txtPathAnh", (object) this.txtPathAnh.Text);
      gclass22.method_6("ckbXoaAnhDaDang", (object) this.ckbXoaAnhDaDang.Checked);
      gclass22.method_6("txtChiDangAnhPathAnh", (object) this.txtChiDangAnhPathAnh.Text);
      gclass22.method_6("ckbChiDangAnhXoaAnhDaDang", (object) this.ckbChiDangAnhXoaAnhDaDang.Checked);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDDangStory.bool_0 = true;
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
          fHDDangStory.bool_0 = true;
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

  private void method_0(object sender, EventArgs e)
  {
  }

  private void method_1()
  {
    this.rbDangText_CheckedChanged((object) null, (EventArgs) null);
    this.rbDangNhac_CheckedChanged((object) null, (EventArgs) null);
    this.rbBaiHatChiDinh_CheckedChanged((object) null, (EventArgs) null);
    this.ckbAnh_CheckedChanged((object) null, (EventArgs) null);
    this.rbChiDangAnh_CheckedChanged((object) null, (EventArgs) null);
  }

  private void rbDangText_CheckedChanged(object sender, EventArgs e) => this.plDangText.Enabled = this.rbDangText.Checked;

  private void rbDangNhac_CheckedChanged(object sender, EventArgs e) => this.plDangNhac.Enabled = this.rbDangNhac.Checked;

  private void method_2(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtDanhSachBaiHat.Lines).ToList<string>());
      this.label4.Text = string.Format(GClass35.smethod_0("Danh sách bài hát ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void rbBaiHatChiDinh_CheckedChanged(object sender, EventArgs e) => this.plBaiHatChiDinh.Enabled = this.rbBaiHatChiDinh.Checked;

  private void plBaiHatChiDinh_Paint(object sender, PaintEventArgs e)
  {
  }

  private void txtNoiDung_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtNoiDung, (Control) this.lblStatus);

  private void txtDanhSachBaiHat_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtDanhSachBaiHat, (Control) this.label4);

  private void ckbAnh_CheckedChanged(object sender, EventArgs e) => this.plAnh.Enabled = this.ckbAnh.Checked;

  private void rbChiDangAnh_CheckedChanged(object sender, EventArgs e) => this.plChiDangAnh.Enabled = this.rbChiDangAnh.Checked;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDDangStory));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.nudSoLuongTo = new NumericUpDown();
    this.nudSoLuongFrom = new NumericUpDown();
    this.label6 = new Label();
    this.label7 = new Label();
    this.plDangNhac = new Panel();
    this.plAnh = new Panel();
    this.ckbXoaAnhDaDang = new CheckBox();
    this.txtPathAnh = new TextBox();
    this.label12 = new Label();
    this.plBaiHatChiDinh = new Panel();
    this.txtDanhSachBaiHat = new RichTextBox();
    this.label3 = new Label();
    this.label4 = new Label();
    this.rbBaiHatChiDinh = new RadioButton();
    this.ckbAnh = new CheckBox();
    this.ckbUseBackgroundNhac = new CheckBox();
    this.rbBaiHatNgauNhien = new RadioButton();
    this.plChiDangAnh = new Panel();
    this.ckbChiDangAnhXoaAnhDaDang = new CheckBox();
    this.txtChiDangAnhPathAnh = new TextBox();
    this.label9 = new Label();
    this.plDangText = new Panel();
    this.txtNoiDung = new RichTextBox();
    this.label8 = new Label();
    this.ckbUseBackgroundText = new CheckBox();
    this.lblStatus = new Label();
    this.rbDangNhac = new RadioButton();
    this.rbChiDangAnh = new RadioButton();
    this.rbDangText = new RadioButton();
    this.txtTenHanhDong = new TextBox();
    this.label5 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.nudSoLuongTo.BeginInit();
    this.nudSoLuongFrom.BeginInit();
    this.plDangNhac.SuspendLayout();
    this.plAnh.SuspendLayout();
    this.plBaiHatChiDinh.SuspendLayout();
    this.plChiDangAnh.SuspendLayout();
    this.plDangText.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(807, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Đăng Story";
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
    this.pnlHeader.Size = new Size(807, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(776, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.nudSoLuongTo);
    this.panel1.Controls.Add((Control) this.nudSoLuongFrom);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.plDangNhac);
    this.panel1.Controls.Add((Control) this.plChiDangAnh);
    this.panel1.Controls.Add((Control) this.plDangText);
    this.panel1.Controls.Add((Control) this.rbDangNhac);
    this.panel1.Controls.Add((Control) this.rbChiDangAnh);
    this.panel1.Controls.Add((Control) this.rbDangText);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(810, 525);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.nudSoLuongTo.Location = new Point(229, 78);
    this.nudSoLuongTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongTo.Name = "nudSoLuongTo";
    this.nudSoLuongTo.Size = new Size(56, 23);
    this.nudSoLuongTo.TabIndex = 39;
    this.nudSoLuongFrom.Location = new Point(132, 78);
    this.nudSoLuongFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongFrom.Name = "nudSoLuongFrom";
    this.nudSoLuongFrom.Size = new Size(56, 23);
    this.nudSoLuongFrom.TabIndex = 38;
    this.label6.Location = new Point(194, 80);
    this.label6.Name = "label6";
    this.label6.Size = new Size(29, 16);
    this.label6.TabIndex = 41;
    this.label6.Text = "đến";
    this.label6.TextAlign = ContentAlignment.MiddleCenter;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(290, 80);
    this.label7.Name = "label7";
    this.label7.Size = new Size(35, 16);
    this.label7.TabIndex = 40;
    this.label7.Text = "story";
    this.plDangNhac.BorderStyle = BorderStyle.FixedSingle;
    this.plDangNhac.Controls.Add((Control) this.plAnh);
    this.plDangNhac.Controls.Add((Control) this.plBaiHatChiDinh);
    this.plDangNhac.Controls.Add((Control) this.rbBaiHatChiDinh);
    this.plDangNhac.Controls.Add((Control) this.ckbAnh);
    this.plDangNhac.Controls.Add((Control) this.ckbUseBackgroundNhac);
    this.plDangNhac.Controls.Add((Control) this.rbBaiHatNgauNhien);
    this.plDangNhac.Location = new Point(132, 129);
    this.plDangNhac.Name = "plDangNhac";
    this.plDangNhac.Size = new Size(305, 330);
    this.plDangNhac.TabIndex = 33;
    this.plAnh.BorderStyle = BorderStyle.FixedSingle;
    this.plAnh.Controls.Add((Control) this.ckbXoaAnhDaDang);
    this.plAnh.Controls.Add((Control) this.txtPathAnh);
    this.plAnh.Controls.Add((Control) this.label12);
    this.plAnh.Location = new Point(18, 265);
    this.plAnh.Name = "plAnh";
    this.plAnh.Size = new Size(278, 58);
    this.plAnh.TabIndex = 61;
    this.ckbXoaAnhDaDang.AutoSize = true;
    this.ckbXoaAnhDaDang.Cursor = Cursors.Hand;
    this.ckbXoaAnhDaDang.Location = new Point(6, 32);
    this.ckbXoaAnhDaDang.Name = "ckbXoaAnhDaDang";
    this.ckbXoaAnhDaDang.Size = new Size(123, 20);
    this.ckbXoaAnhDaDang.TabIndex = 33;
    this.ckbXoaAnhDaDang.Text = "Xóa ảnh đã đăng";
    this.ckbXoaAnhDaDang.UseVisualStyleBackColor = true;
    this.txtPathAnh.Location = new Point(97, 3);
    this.txtPathAnh.Name = "txtPathAnh";
    this.txtPathAnh.Size = new Size(176, 23);
    this.txtPathAnh.TabIndex = 1;
    this.label12.AutoSize = true;
    this.label12.Location = new Point(3, 6);
    this.label12.Name = "label12";
    this.label12.Size = new Size(88, 16);
    this.label12.TabIndex = 0;
    this.label12.Text = "Thư mục ảnh:";
    this.plBaiHatChiDinh.BorderStyle = BorderStyle.FixedSingle;
    this.plBaiHatChiDinh.Controls.Add((Control) this.txtDanhSachBaiHat);
    this.plBaiHatChiDinh.Controls.Add((Control) this.label3);
    this.plBaiHatChiDinh.Controls.Add((Control) this.label4);
    this.plBaiHatChiDinh.Location = new Point(18, 51);
    this.plBaiHatChiDinh.Name = "plBaiHatChiDinh";
    this.plBaiHatChiDinh.Size = new Size(278, 161);
    this.plBaiHatChiDinh.TabIndex = 8;
    this.plBaiHatChiDinh.Paint += new PaintEventHandler(this.plBaiHatChiDinh_Paint);
    this.txtDanhSachBaiHat.Location = new Point(6, 22);
    this.txtDanhSachBaiHat.Name = "txtDanhSachBaiHat";
    this.txtDanhSachBaiHat.Size = new Size(267, 112);
    this.txtDanhSachBaiHat.TabIndex = 8;
    this.txtDanhSachBaiHat.Text = "";
    this.txtDanhSachBaiHat.TextChanged += new EventHandler(this.txtDanhSachBaiHat_TextChanged);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(3, 138);
    this.label3.Name = "label3";
    this.label3.Size = new Size(133, 16);
    this.label3.TabIndex = 2;
    this.label3.Text = "(Mỗi nội dung 1 dòng)";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(3, 3);
    this.label4.Name = "label4";
    this.label4.Size = new Size(135, 16);
    this.label4.TabIndex = 0;
    this.label4.Text = "Danh sách bài hát (0):";
    this.rbBaiHatChiDinh.AutoSize = true;
    this.rbBaiHatChiDinh.Cursor = Cursors.Hand;
    this.rbBaiHatChiDinh.Location = new Point(6, 29);
    this.rbBaiHatChiDinh.Name = "rbBaiHatChiDinh";
    this.rbBaiHatChiDinh.Size = new Size(112, 20);
    this.rbBaiHatChiDinh.TabIndex = 32;
    this.rbBaiHatChiDinh.TabStop = true;
    this.rbBaiHatChiDinh.Text = "Bài hát chỉ định";
    this.rbBaiHatChiDinh.UseVisualStyleBackColor = true;
    this.rbBaiHatChiDinh.CheckedChanged += new EventHandler(this.rbBaiHatChiDinh_CheckedChanged);
    this.ckbAnh.AutoSize = true;
    this.ckbAnh.Cursor = Cursors.Hand;
    this.ckbAnh.Location = new Point(6, 242);
    this.ckbAnh.Name = "ckbAnh";
    this.ckbAnh.Size = new Size(48, 20);
    this.ckbAnh.TabIndex = 7;
    this.ckbAnh.Text = "Ảnh";
    this.ckbAnh.UseVisualStyleBackColor = true;
    this.ckbAnh.CheckedChanged += new EventHandler(this.ckbAnh_CheckedChanged);
    this.ckbUseBackgroundNhac.AutoSize = true;
    this.ckbUseBackgroundNhac.Cursor = Cursors.Hand;
    this.ckbUseBackgroundNhac.Location = new Point(6, 216);
    this.ckbUseBackgroundNhac.Name = "ckbUseBackgroundNhac";
    this.ckbUseBackgroundNhac.Size = new Size(144, 20);
    this.ckbUseBackgroundNhac.TabIndex = 7;
    this.ckbUseBackgroundNhac.Text = "Sử dụng background";
    this.ckbUseBackgroundNhac.UseVisualStyleBackColor = true;
    this.rbBaiHatNgauNhien.AutoSize = true;
    this.rbBaiHatNgauNhien.Cursor = Cursors.Hand;
    this.rbBaiHatNgauNhien.Location = new Point(6, 3);
    this.rbBaiHatNgauNhien.Name = "rbBaiHatNgauNhien";
    this.rbBaiHatNgauNhien.Size = new Size(131, 20);
    this.rbBaiHatNgauNhien.TabIndex = 32;
    this.rbBaiHatNgauNhien.TabStop = true;
    this.rbBaiHatNgauNhien.Text = "Bài hát ngẫu nhiên";
    this.rbBaiHatNgauNhien.UseVisualStyleBackColor = true;
    this.plChiDangAnh.BorderStyle = BorderStyle.FixedSingle;
    this.plChiDangAnh.Controls.Add((Control) this.ckbChiDangAnhXoaAnhDaDang);
    this.plChiDangAnh.Controls.Add((Control) this.txtChiDangAnhPathAnh);
    this.plChiDangAnh.Controls.Add((Control) this.label9);
    this.plChiDangAnh.Location = new Point(472, 336);
    this.plChiDangAnh.Name = "plChiDangAnh";
    this.plChiDangAnh.Size = new Size(305, 56);
    this.plChiDangAnh.TabIndex = 33;
    this.ckbChiDangAnhXoaAnhDaDang.AutoSize = true;
    this.ckbChiDangAnhXoaAnhDaDang.Cursor = Cursors.Hand;
    this.ckbChiDangAnhXoaAnhDaDang.Location = new Point(6, 30);
    this.ckbChiDangAnhXoaAnhDaDang.Name = "ckbChiDangAnhXoaAnhDaDang";
    this.ckbChiDangAnhXoaAnhDaDang.Size = new Size(137, 20);
    this.ckbChiDangAnhXoaAnhDaDang.TabIndex = 33;
    this.ckbChiDangAnhXoaAnhDaDang.Text = "Xóa media đã đăng";
    this.ckbChiDangAnhXoaAnhDaDang.UseVisualStyleBackColor = true;
    this.txtChiDangAnhPathAnh.Location = new Point(101, 4);
    this.txtChiDangAnhPathAnh.Name = "txtChiDangAnhPathAnh";
    this.txtChiDangAnhPathAnh.Size = new Size(199, 23);
    this.txtChiDangAnhPathAnh.TabIndex = 1;
    this.label9.AutoSize = true;
    this.label9.Location = new Point(3, 7);
    this.label9.Name = "label9";
    this.label9.Size = new Size(102, 16);
    this.label9.TabIndex = 0;
    this.label9.Text = "Thư mục media:";
    this.plDangText.BorderStyle = BorderStyle.FixedSingle;
    this.plDangText.Controls.Add((Control) this.txtNoiDung);
    this.plDangText.Controls.Add((Control) this.label8);
    this.plDangText.Controls.Add((Control) this.ckbUseBackgroundText);
    this.plDangText.Controls.Add((Control) this.lblStatus);
    this.plDangText.Location = new Point(472, 129);
    this.plDangText.Name = "plDangText";
    this.plDangText.Size = new Size(305, 183);
    this.plDangText.TabIndex = 33;
    this.txtNoiDung.Location = new Point(6, 22);
    this.txtNoiDung.Name = "txtNoiDung";
    this.txtNoiDung.Size = new Size(294, 112);
    this.txtNoiDung.TabIndex = 8;
    this.txtNoiDung.Text = "";
    this.txtNoiDung.TextChanged += new EventHandler(this.txtNoiDung_TextChanged);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(3, 137);
    this.label8.Name = "label8";
    this.label8.Size = new Size(265, 16);
    this.label8.TabIndex = 2;
    this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
    this.ckbUseBackgroundText.AutoSize = true;
    this.ckbUseBackgroundText.Cursor = Cursors.Hand;
    this.ckbUseBackgroundText.Location = new Point(6, 158);
    this.ckbUseBackgroundText.Name = "ckbUseBackgroundText";
    this.ckbUseBackgroundText.Size = new Size(144, 20);
    this.ckbUseBackgroundText.TabIndex = 7;
    this.ckbUseBackgroundText.Text = "Sử dụng background";
    this.ckbUseBackgroundText.UseVisualStyleBackColor = true;
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 3);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(115, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung story (0):";
    this.rbDangNhac.AutoSize = true;
    this.rbDangNhac.Cursor = Cursors.Hand;
    this.rbDangNhac.Location = new Point(132, 107);
    this.rbDangNhac.Name = "rbDangNhac";
    this.rbDangNhac.Size = new Size(86, 20);
    this.rbDangNhac.TabIndex = 32;
    this.rbDangNhac.TabStop = true;
    this.rbDangNhac.Text = "Đăng nhạc";
    this.rbDangNhac.UseVisualStyleBackColor = true;
    this.rbDangNhac.CheckedChanged += new EventHandler(this.rbDangNhac_CheckedChanged);
    this.rbChiDangAnh.AutoSize = true;
    this.rbChiDangAnh.Cursor = Cursors.Hand;
    this.rbChiDangAnh.Location = new Point(472, 314);
    this.rbChiDangAnh.Name = "rbChiDangAnh";
    this.rbChiDangAnh.Size = new Size(115, 20);
    this.rbChiDangAnh.TabIndex = 32;
    this.rbChiDangAnh.TabStop = true;
    this.rbChiDangAnh.Text = "Đăng ảnh/video";
    this.rbChiDangAnh.UseVisualStyleBackColor = true;
    this.rbChiDangAnh.CheckedChanged += new EventHandler(this.rbChiDangAnh_CheckedChanged);
    this.rbDangText.AutoSize = true;
    this.rbDangText.Cursor = Cursors.Hand;
    this.rbDangText.Location = new Point(472, 107);
    this.rbDangText.Name = "rbDangText";
    this.rbDangText.Size = new Size(80, 20);
    this.rbDangText.TabIndex = 32;
    this.rbDangText.TabStop = true;
    this.rbDangText.Text = "Đăng text";
    this.rbDangText.UseVisualStyleBackColor = true;
    this.rbDangText.CheckedChanged += new EventHandler(this.rbDangText_CheckedChanged);
    this.txtTenHanhDong.Location = new Point(132, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(305, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 80);
    this.label5.Name = "label5";
    this.label5.Size = new Size(95, 16);
    this.label5.TabIndex = 31;
    this.label5.Text = "Số lượng story:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 109);
    this.label2.Name = "label2";
    this.label2.Size = new Size(96, 16);
    this.label2.TabIndex = 31;
    this.label2.Text = "Tùy chọn đăng:";
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
    this.btnCancel.Location = new Point(413, 482);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 10;
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
    this.btnAdd.Location = new Point(306, 482);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 9;
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
    this.bunifuCards1.Size = new Size(807, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(810, 525);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDDangStory);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDDangStory_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.plDangNhac.ResumeLayout(false);
    this.plDangNhac.PerformLayout();
    this.plAnh.ResumeLayout(false);
    this.plAnh.PerformLayout();
    this.plBaiHatChiDinh.ResumeLayout(false);
    this.plBaiHatChiDinh.PerformLayout();
    this.plChiDangAnh.ResumeLayout(false);
    this.plChiDangAnh.PerformLayout();
    this.plDangText.ResumeLayout(false);
    this.plDangText.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
