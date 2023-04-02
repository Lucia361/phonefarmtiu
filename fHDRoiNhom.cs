// Decompiled with JetBrains decompiler
// Type: fHDRoiNhom
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

public class fHDRoiNhom : Form
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
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label7;
  private Label label6;
  private Label label5;
  private RadioButton rbRoiTheoDieuKien;
  private RadioButton rbNgauNhien;
  private Label label9;
  private Panel plUidChiDinh;
  private TextBox txtTuKhoa;
  private Label label10;
  private Label lblStatusUid;
  private Panel plDieuKienTuKhoa;
  private CheckBox ckbDieuKienTuKhoa;
  private CheckBox ckbDieuKienThanhVien;
  private NumericUpDown nudThanhVienToiDa;
  private RichTextBox txtIDNhomGiuLai;
  private Label label8;
  private CheckBox ckbDieuKienKiemDuyet;
  private IContainer components;
  private CheckBox ckbBackupDanhSachNhom;

  public fHDRoiNhom(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDRoiNhom.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDRoiNhom");
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

  private void fHDRoiNhom_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom");
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo");
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom");
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo");
      if (this.gclass22_0.method_3("typeRoiNhom") == 0)
        this.rbNgauNhien.Checked = true;
      else
        this.rbRoiTheoDieuKien.Checked = true;
      this.ckbDieuKienKiemDuyet.Checked = this.gclass22_0.method_4("ckbDieuKienKiemDuyet");
      this.ckbDieuKienThanhVien.Checked = this.gclass22_0.method_4("ckbDieuKienThanhVien");
      this.nudThanhVienToiDa.Value = (Decimal) this.gclass22_0.method_3("nudThanhVienToiDa");
      this.ckbDieuKienTuKhoa.Checked = this.gclass22_0.method_4("ckbDieuKienTuKhoa");
      this.txtTuKhoa.Text = this.gclass22_0.method_1("txtTuKhoa");
      this.txtIDNhomGiuLai.Text = this.gclass22_0.method_1("txtIDNhomGiuLai");
      this.ckbBackupDanhSachNhom.Checked = this.gclass22_0.method_4("ckbBackupDanhSachNhom");
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
      if (this.rbRoiTheoDieuKien.Checked)
      {
        if (!this.ckbDieuKienThanhVien.Checked && !this.ckbDieuKienTuKhoa.Checked && !this.ckbDieuKienKiemDuyet.Checked)
        {
          GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn ít nhất một điều kiện rời nhóm!"), 3);
          return;
        }
        if (this.ckbDieuKienTuKhoa.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtTuKhoa.Lines).ToList<string>()).Count == 0)
        {
          GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách từ khóa!"), 3);
          return;
        }
      }
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      if (this.rbNgauNhien.Checked)
        gclass22.method_6("typeRoiNhom", (object) 0);
      else
        gclass22.method_6("typeRoiNhom", (object) 1);
      gclass22.method_6("ckbDieuKienKiemDuyet", (object) this.ckbDieuKienKiemDuyet.Checked);
      gclass22.method_6("ckbDieuKienThanhVien", (object) this.ckbDieuKienThanhVien.Checked);
      gclass22.method_6("nudThanhVienToiDa", (object) this.nudThanhVienToiDa.Value);
      gclass22.method_6("ckbDieuKienTuKhoa", (object) this.ckbDieuKienTuKhoa.Checked);
      gclass22.method_6("txtTuKhoa", (object) this.txtTuKhoa.Text.Trim());
      gclass22.method_6("txtIDNhomGiuLai", (object) this.txtIDNhomGiuLai.Text);
      gclass22.method_6("ckbBackupDanhSachNhom", (object) this.ckbBackupDanhSachNhom.Checked);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDRoiNhom.bool_0 = true;
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
          fHDRoiNhom.bool_0 = true;
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

  private void rbRoiTheoDieuKien_CheckedChanged(object sender, EventArgs e) => this.method_0();

  private void method_0() => this.plUidChiDinh.Enabled = this.rbRoiTheoDieuKien.Checked;

  private void txtTuKhoa_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtTuKhoa.Lines).ToList<string>());
      this.lblStatusUid.Text = string.Format(GClass35.smethod_0("Danh sách từ khóa ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void method_1()
  {
    this.ckbDieuKienThanhVien_CheckedChanged((object) null, (EventArgs) null);
    this.ckbDieuKienTuKhoa_CheckedChanged((object) null, (EventArgs) null);
    this.method_0();
  }

  private void ckbDieuKienThanhVien_CheckedChanged(object sender, EventArgs e) => this.nudThanhVienToiDa.Enabled = this.ckbDieuKienThanhVien.Checked;

  private void ckbDieuKienTuKhoa_CheckedChanged(object sender, EventArgs e) => this.plDieuKienTuKhoa.Enabled = this.ckbDieuKienTuKhoa.Checked;

  private void label8_Click(object sender, EventArgs e)
  {
  }

  private void txtIDNhomGiuLai_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtIDNhomGiuLai.Lines).ToList<string>());
      this.label8.Text = string.Format(GClass35.smethod_0("Danh sách ID nhóm cần giữ lại ({0}):"), (object) stringList.Count);
    }
    catch
    {
    }
  }

  private void ckbDieuKienKiemDuyet_Click(object sender, EventArgs e)
  {
    if (!this.ckbDieuKienKiemDuyet.Checked || GClass14.smethod_1(GClass35.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) != DialogResult.No)
      return;
    this.ckbDieuKienKiemDuyet.Checked = false;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDRoiNhom));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.ckbBackupDanhSachNhom = new CheckBox();
    this.txtIDNhomGiuLai = new RichTextBox();
    this.label8 = new Label();
    this.plUidChiDinh = new Panel();
    this.plDieuKienTuKhoa = new Panel();
    this.lblStatusUid = new Label();
    this.label10 = new Label();
    this.txtTuKhoa = new TextBox();
    this.ckbDieuKienTuKhoa = new CheckBox();
    this.ckbDieuKienKiemDuyet = new CheckBox();
    this.ckbDieuKienThanhVien = new CheckBox();
    this.nudThanhVienToiDa = new NumericUpDown();
    this.rbRoiTheoDieuKien = new RadioButton();
    this.rbNgauNhien = new RadioButton();
    this.label9 = new Label();
    this.nudDelayTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.label7 = new Label();
    this.label6 = new Label();
    this.label5 = new Label();
    this.nudSoLuongTo = new NumericUpDown();
    this.nudSoLuongFrom = new NumericUpDown();
    this.txtTenHanhDong = new TextBox();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plUidChiDinh.SuspendLayout();
    this.plDieuKienTuKhoa.SuspendLayout();
    this.nudThanhVienToiDa.BeginInit();
    this.nudDelayTo.BeginInit();
    this.nudDelayFrom.BeginInit();
    this.nudSoLuongTo.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(644, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Rời nhóm";
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
    this.pnlHeader.Size = new Size(644, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(613, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.ckbBackupDanhSachNhom);
    this.panel1.Controls.Add((Control) this.txtIDNhomGiuLai);
    this.panel1.Controls.Add((Control) this.label8);
    this.panel1.Controls.Add((Control) this.plUidChiDinh);
    this.panel1.Controls.Add((Control) this.rbRoiTheoDieuKien);
    this.panel1.Controls.Add((Control) this.rbNgauNhien);
    this.panel1.Controls.Add((Control) this.label9);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.nudSoLuongTo);
    this.panel1.Controls.Add((Control) this.nudSoLuongFrom);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(647, 528);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.ckbBackupDanhSachNhom.AutoSize = true;
    this.ckbBackupDanhSachNhom.Cursor = Cursors.Hand;
    this.ckbBackupDanhSachNhom.Location = new Point(31, 453);
    this.ckbBackupDanhSachNhom.Name = "ckbBackupDanhSachNhom";
    this.ckbBackupDanhSachNhom.Size = new Size(262, 20);
    this.ckbBackupDanhSachNhom.TabIndex = 121;
    this.ckbBackupDanhSachNhom.Text = "Sử dụng danh sách nhóm đã backup (ẩn)";
    this.ckbBackupDanhSachNhom.UseVisualStyleBackColor = true;
    this.txtIDNhomGiuLai.BorderStyle = BorderStyle.FixedSingle;
    this.txtIDNhomGiuLai.Location = new Point(359, 157);
    this.txtIDNhomGiuLai.Name = "txtIDNhomGiuLai";
    this.txtIDNhomGiuLai.Size = new Size(253, 293);
    this.txtIDNhomGiuLai.TabIndex = 120;
    this.txtIDNhomGiuLai.Text = "";
    this.txtIDNhomGiuLai.WordWrap = false;
    this.txtIDNhomGiuLai.TextChanged += new EventHandler(this.txtIDNhomGiuLai_TextChanged);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(356, 138);
    this.label8.Name = "label8";
    this.label8.Size = new Size(207, 16);
    this.label8.TabIndex = 118;
    this.label8.Text = "Danh sách ID nhóm cần giữ lại (0):";
    this.label8.Click += new EventHandler(this.label8_Click);
    this.plUidChiDinh.BorderStyle = BorderStyle.FixedSingle;
    this.plUidChiDinh.Controls.Add((Control) this.plDieuKienTuKhoa);
    this.plUidChiDinh.Controls.Add((Control) this.ckbDieuKienTuKhoa);
    this.plUidChiDinh.Controls.Add((Control) this.ckbDieuKienKiemDuyet);
    this.plUidChiDinh.Controls.Add((Control) this.ckbDieuKienThanhVien);
    this.plUidChiDinh.Controls.Add((Control) this.nudThanhVienToiDa);
    this.plUidChiDinh.Location = new Point(31, 206);
    this.plUidChiDinh.Name = "plUidChiDinh";
    this.plUidChiDinh.Size = new Size(295, 244);
    this.plUidChiDinh.TabIndex = 49;
    this.plDieuKienTuKhoa.BorderStyle = BorderStyle.FixedSingle;
    this.plDieuKienTuKhoa.Controls.Add((Control) this.lblStatusUid);
    this.plDieuKienTuKhoa.Controls.Add((Control) this.label10);
    this.plDieuKienTuKhoa.Controls.Add((Control) this.txtTuKhoa);
    this.plDieuKienTuKhoa.Location = new Point(23, 79);
    this.plDieuKienTuKhoa.Name = "plDieuKienTuKhoa";
    this.plDieuKienTuKhoa.Size = new Size(265, 160);
    this.plDieuKienTuKhoa.TabIndex = 50;
    this.lblStatusUid.AutoSize = true;
    this.lblStatusUid.Location = new Point(3, 3);
    this.lblStatusUid.Name = "lblStatusUid";
    this.lblStatusUid.Size = new Size(139, 16);
    this.lblStatusUid.TabIndex = 0;
    this.lblStatusUid.Text = "Danh sách từ khóa (0):";
    this.label10.AutoSize = true;
    this.label10.Location = new Point(4, 139);
    this.label10.Name = "label10";
    this.label10.Size = new Size((int) sbyte.MaxValue, 16);
    this.label10.TabIndex = 0;
    this.label10.Text = "(Mỗi từ khóa 1 dòng)";
    this.txtTuKhoa.Location = new Point(7, 25);
    this.txtTuKhoa.Multiline = true;
    this.txtTuKhoa.Name = "txtTuKhoa";
    this.txtTuKhoa.ScrollBars = ScrollBars.Both;
    this.txtTuKhoa.Size = new Size(253, 111);
    this.txtTuKhoa.TabIndex = 1;
    this.txtTuKhoa.WordWrap = false;
    this.txtTuKhoa.TextChanged += new EventHandler(this.txtTuKhoa_TextChanged);
    this.ckbDieuKienTuKhoa.AutoSize = true;
    this.ckbDieuKienTuKhoa.Cursor = Cursors.Hand;
    this.ckbDieuKienTuKhoa.Location = new Point(5, 53);
    this.ckbDieuKienTuKhoa.Name = "ckbDieuKienTuKhoa";
    this.ckbDieuKienTuKhoa.Size = new Size(209, 20);
    this.ckbDieuKienTuKhoa.TabIndex = 2;
    this.ckbDieuKienTuKhoa.Text = "Tên nhóm có chứa từ khóa sau:";
    this.ckbDieuKienTuKhoa.UseVisualStyleBackColor = true;
    this.ckbDieuKienTuKhoa.CheckedChanged += new EventHandler(this.ckbDieuKienTuKhoa_CheckedChanged);
    this.ckbDieuKienKiemDuyet.AutoSize = true;
    this.ckbDieuKienKiemDuyet.Cursor = Cursors.Hand;
    this.ckbDieuKienKiemDuyet.Location = new Point(5, 3);
    this.ckbDieuKienKiemDuyet.Name = "ckbDieuKienKiemDuyet";
    this.ckbDieuKienKiemDuyet.Size = new Size(191, 20);
    this.ckbDieuKienKiemDuyet.TabIndex = 2;
    this.ckbDieuKienKiemDuyet.Text = "Rời nhóm kiểm duyệt bài viết";
    this.ckbDieuKienKiemDuyet.UseVisualStyleBackColor = true;
    this.ckbDieuKienKiemDuyet.Click += new EventHandler(this.ckbDieuKienKiemDuyet_Click);
    this.ckbDieuKienThanhVien.AutoSize = true;
    this.ckbDieuKienThanhVien.Cursor = Cursors.Hand;
    this.ckbDieuKienThanhVien.Location = new Point(5, 27);
    this.ckbDieuKienThanhVien.Name = "ckbDieuKienThanhVien";
    this.ckbDieuKienThanhVien.Size = new Size(181, 20);
    this.ckbDieuKienThanhVien.TabIndex = 2;
    this.ckbDieuKienThanhVien.Text = "Số lượng thành viên ít hơn:";
    this.ckbDieuKienThanhVien.UseVisualStyleBackColor = true;
    this.ckbDieuKienThanhVien.CheckedChanged += new EventHandler(this.ckbDieuKienThanhVien_CheckedChanged);
    this.nudThanhVienToiDa.Location = new Point(196, 26);
    this.nudThanhVienToiDa.Maximum = new Decimal(new int[4]
    {
      999999999,
      0,
      0,
      0
    });
    this.nudThanhVienToiDa.Name = "nudThanhVienToiDa";
    this.nudThanhVienToiDa.Size = new Size(92, 23);
    this.nudThanhVienToiDa.TabIndex = 1;
    this.rbRoiTheoDieuKien.AutoSize = true;
    this.rbRoiTheoDieuKien.Cursor = Cursors.Hand;
    this.rbRoiTheoDieuKien.Location = new Point(31, 182);
    this.rbRoiTheoDieuKien.Name = "rbRoiTheoDieuKien";
    this.rbRoiTheoDieuKien.Size = new Size(163, 20);
    this.rbRoiTheoDieuKien.TabIndex = 48;
    this.rbRoiTheoDieuKien.Text = "Rời nhóm theo điều kiện";
    this.rbRoiTheoDieuKien.UseVisualStyleBackColor = true;
    this.rbRoiTheoDieuKien.CheckedChanged += new EventHandler(this.rbRoiTheoDieuKien_CheckedChanged);
    this.rbNgauNhien.AutoSize = true;
    this.rbNgauNhien.Checked = true;
    this.rbNgauNhien.Cursor = Cursors.Hand;
    this.rbNgauNhien.Location = new Point(31, 157);
    this.rbNgauNhien.Name = "rbNgauNhien";
    this.rbNgauNhien.Size = new Size(187, 20);
    this.rbNgauNhien.TabIndex = 48;
    this.rbNgauNhien.TabStop = true;
    this.rbNgauNhien.Text = "Ngẫu nhiên danh sách nhóm";
    this.rbNgauNhien.UseVisualStyleBackColor = true;
    this.label9.AutoSize = true;
    this.label9.Location = new Point(28, 135);
    this.label9.Name = "label9";
    this.label9.Size = new Size(137, 16);
    this.label9.TabIndex = 47;
    this.label9.Text = "Tùy chọn nhóm để rời:";
    this.nudDelayTo.Location = new Point(228, 107);
    this.nudDelayTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayTo.Name = "nudDelayTo";
    this.nudDelayTo.Size = new Size(56, 23);
    this.nudDelayTo.TabIndex = 4;
    this.nudDelayFrom.Location = new Point(131, 107);
    this.nudDelayFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayFrom.Name = "nudDelayFrom";
    this.nudDelayFrom.Size = new Size(56, 23);
    this.nudDelayFrom.TabIndex = 3;
    this.label7.Location = new Point(193, 109);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 46;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(286, 109);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 45;
    this.label6.Text = "giây";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(26, 109);
    this.label5.Name = "label5";
    this.label5.Size = new Size(89, 16);
    this.label5.TabIndex = 44;
    this.label5.Text = "Thời gian chờ:";
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
    this.nudSoLuongTo.TabIndex = 2;
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
    this.nudSoLuongFrom.TabIndex = 1;
    this.txtTenHanhDong.Location = new Point(132, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label3.Location = new Point(194, 80);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(287, 80);
    this.label4.Name = "label4";
    this.label4.Size = new Size(39, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "nhóm";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 80);
    this.label2.Name = "label2";
    this.label2.Size = new Size(99, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Số lượng nhóm:";
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
    this.btnCancel.Location = new Point(331, 486);
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
    this.btnAdd.Location = new Point(224, 486);
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
    this.bunifuCards1.Size = new Size(644, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(647, 528);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDRoiNhom);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDRoiNhom_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plUidChiDinh.ResumeLayout(false);
    this.plUidChiDinh.PerformLayout();
    this.plDieuKienTuKhoa.ResumeLayout(false);
    this.plDieuKienTuKhoa.PerformLayout();
    this.nudThanhVienToiDa.EndInit();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
