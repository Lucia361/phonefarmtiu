// Decompiled with JetBrains decompiler
// Type: fHDDangBaiTuong
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fHDDangBaiTuong : Form
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
  private CheckBox ckbVanBan;
  private Panel plVanBan;
  private Label label8;
  private Label lblStatus;
  private RichTextBox txtNoiDung;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private Label label9;
  private CheckBox ckbUseBackground;
  private Label label19;
  private Label label20;
  private NumericUpDown nudKhoangCachTo;
  private NumericUpDown nudKhoangCachFrom;
  private Label label18;
  private Label label17;
  private NumericUpDown nudSoLuongTo;
  private NumericUpDown nudSoLuongFrom;
  private Label label16;
  private Label label15;
  private CheckBox ckbXoaNguyenLieuDaDung;
  private LinkLabel linkLabel1;
  private Button button3;
  private Button button2;
  private Panel plAnh;
  private NumericUpDown nudSoLuongAnhTo;
  private NumericUpDown nudSoLuongAnhFrom;
  private TextBox txtPathAnh;
  private Label label10;
  private Label label4;
  private Label label2;
  private Label label3;
  private CheckBox ckbAnh;
  private Panel plDangLink;
  private Label lblDanhSachLink;
  private RichTextBox txtLinkShare;
  private CheckBox ckbXoaLink;
  private CheckBox ckbDangLink;
  private MetroButton btnDown;
  private IContainer components;
  private MetroButton btnUp;

  public fHDDangBaiTuong(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDDangBaiTuong.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1_1 = this.Name.Substring(1);
    string str = "Đăng bài lên tường";
    if (Class205.smethod_13(string_1: string_1_1).Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + string_1_1 + "', '" + str + "');");
    string string_1_2 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: string_1_1);
        string_1_2 = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        string_1_2 = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.gclass22_0 = new GClass22(string_1_2, true);
    GClass35.smethod_5((Control) this);
  }

  private void fHDDangBaiTuong_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom", 1);
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo", 1);
      this.nudKhoangCachFrom.Value = (Decimal) this.gclass22_0.method_3("nudKhoangCachFrom", 5);
      this.nudKhoangCachTo.Value = (Decimal) this.gclass22_0.method_3("nudKhoangCachTo", 10);
      this.ckbVanBan.Checked = this.gclass22_0.method_4("ckbVanBan");
      this.ckbUseBackground.Checked = this.gclass22_0.method_4("ckbUseBackground");
      this.ckbXoaNguyenLieuDaDung.Checked = this.gclass22_0.method_4("ckbXoaNguyenLieuDaDung");
      this.txtNoiDung.Text = this.gclass22_0.method_1("txtNoiDung");
      if (this.gclass22_0.method_3("typeNganCach") == 1)
        this.rbNganCachKyTu.Checked = true;
      else
        this.rbNganCachMoiDong.Checked = true;
      this.ckbAnh.Checked = this.gclass22_0.method_4("ckbAnh");
      this.txtPathAnh.Text = this.gclass22_0.method_1("txtPathAnh");
      this.nudSoLuongAnhFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongAnhFrom", 1);
      this.nudSoLuongAnhTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongAnhTo", 1);
      this.ckbDangLink.Checked = this.gclass22_0.method_4("ckbDangLink");
      this.txtLinkShare.Text = this.gclass22_0.method_1("txtLinkShare");
      this.ckbXoaLink.Checked = this.gclass22_0.method_4("ckbXoaLink", true);
    }
    catch (Exception ex)
    {
    }
    this.method_0();
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
      gclass22.method_6("nudKhoangCachFrom", (object) this.nudKhoangCachFrom.Value);
      gclass22.method_6("nudKhoangCachTo", (object) this.nudKhoangCachTo.Value);
      gclass22.method_6("ckbVanBan", (object) this.ckbVanBan.Checked);
      gclass22.method_6("ckbUseBackground", (object) this.ckbUseBackground.Checked);
      gclass22.method_6("ckbXoaNguyenLieuDaDung", (object) this.ckbXoaNguyenLieuDaDung.Checked);
      gclass22.method_6("txtNoiDung", (object) this.txtNoiDung.Text.Trim());
      int object_0 = 0;
      if (this.rbNganCachKyTu.Checked)
        object_0 = 1;
      gclass22.method_6("typeNganCach", (object) object_0);
      gclass22.method_6("ckbAnh", (object) this.ckbAnh.Checked);
      gclass22.method_6("txtPathAnh", (object) this.txtPathAnh.Text.Trim());
      gclass22.method_6("nudSoLuongAnhFrom", (object) this.nudSoLuongAnhFrom.Value);
      gclass22.method_6("nudSoLuongAnhTo", (object) this.nudSoLuongAnhTo.Value);
      gclass22.method_6("ckbDangLink", (object) this.ckbDangLink.Checked);
      gclass22.method_6("txtLinkShare", (object) this.txtLinkShare.Text.Trim());
      gclass22.method_6("ckbXoaLink", (object) this.ckbXoaLink.Checked);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDDangBaiTuong.bool_0 = true;
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
          fHDDangBaiTuong.bool_0 = true;
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

  private void method_0()
  {
    this.ckbVanBan_CheckedChanged((object) null, (EventArgs) null);
    this.ckbAnh_CheckedChanged((object) null, (EventArgs) null);
    this.ckbDangLink_CheckedChanged((object) null, (EventArgs) null);
  }

  private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
  {
    this.plVanBan.Enabled = this.ckbVanBan.Checked;
    if (this.ckbVanBan.Checked)
      return;
    this.ckbUseBackground.Checked = false;
  }

  private void txtNoiDung_TextChanged(object sender, EventArgs e) => this.method_1();

  private void method_1()
  {
    try
    {
      List<string> stringList1 = new List<string>();
      List<string> list;
      if (this.rbNganCachMoiDong.Checked)
        list = ((IEnumerable<string>) this.txtNoiDung.Lines).ToList<string>();
      else
        list = ((IEnumerable<string>) this.txtNoiDung.Text.Split(new string[1]
        {
          "\n|\n"
        }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();
      List<string> stringList2 = GClass19.smethod_39(list);
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Danh sách nội dung ({0}):"), (object) stringList2.Count.ToString());
    }
    catch
    {
    }
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
  }

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => this.method_1();

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => this.method_1();

  private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => GClass19.smethod_35((Form) new fHuongDanRandom());

  private void button2_Click(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));

  private void button3_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fHelpNhapComment());

  private void ckbAnh_CheckedChanged(object sender, EventArgs e)
  {
    this.plAnh.Enabled = this.ckbAnh.Checked;
    this.ckbUseBackground.Enabled = !this.ckbAnh.Checked;
    if (!this.ckbAnh.Checked)
      return;
    this.ckbUseBackground.Checked = false;
  }

  private void ckbDangLink_CheckedChanged(object sender, EventArgs e) => this.plDangLink.Enabled = this.ckbDangLink.Checked;

  private void txtLinkShare_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtLinkShare, (Control) this.lblDanhSachLink);

  private void ckbDangLink_VisibleChanged(object sender, EventArgs e) => this.plDangLink.Visible = this.ckbDangLink.Visible;

  private void btnUp_Click(object sender, EventArgs e)
  {
    this.plVanBan.Height = 122;
    this.ckbDangLink.Visible = true;
  }

  private void btnDown_Click(object sender, EventArgs e)
  {
    this.plVanBan.Height = 250;
    this.ckbDangLink.Visible = false;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDDangBaiTuong));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.panel1 = new Panel();
    this.btnDown = new MetroButton();
    this.btnUp = new MetroButton();
    this.plAnh = new Panel();
    this.nudSoLuongAnhTo = new NumericUpDown();
    this.nudSoLuongAnhFrom = new NumericUpDown();
    this.txtPathAnh = new TextBox();
    this.label10 = new Label();
    this.label4 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.ckbAnh = new CheckBox();
    this.label19 = new Label();
    this.label20 = new Label();
    this.nudKhoangCachTo = new NumericUpDown();
    this.nudKhoangCachFrom = new NumericUpDown();
    this.label18 = new Label();
    this.label17 = new Label();
    this.nudSoLuongTo = new NumericUpDown();
    this.nudSoLuongFrom = new NumericUpDown();
    this.label16 = new Label();
    this.label15 = new Label();
    this.plVanBan = new Panel();
    this.linkLabel1 = new LinkLabel();
    this.button3 = new Button();
    this.button2 = new Button();
    this.rbNganCachKyTu = new RadioButton();
    this.rbNganCachMoiDong = new RadioButton();
    this.label9 = new Label();
    this.txtNoiDung = new RichTextBox();
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.ckbUseBackground = new CheckBox();
    this.ckbXoaNguyenLieuDaDung = new CheckBox();
    this.btnAdd = new Button();
    this.ckbVanBan = new CheckBox();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.plDangLink = new Panel();
    this.lblDanhSachLink = new Label();
    this.txtLinkShare = new RichTextBox();
    this.ckbXoaLink = new CheckBox();
    this.ckbDangLink = new CheckBox();
    this.button1 = new Button();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plAnh.SuspendLayout();
    this.nudSoLuongAnhTo.BeginInit();
    this.nudSoLuongAnhFrom.BeginInit();
    this.nudKhoangCachTo.BeginInit();
    this.nudKhoangCachFrom.BeginInit();
    this.nudSoLuongTo.BeginInit();
    this.nudSoLuongFrom.BeginInit();
    this.plVanBan.SuspendLayout();
    this.bunifuCards1.SuspendLayout();
    this.plDangLink.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(674, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Đăng bài lên tường";
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
    this.pnlHeader.Size = new Size(674, 31);
    this.pnlHeader.TabIndex = 9;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.btnDown);
    this.panel1.Controls.Add((Control) this.btnUp);
    this.panel1.Controls.Add((Control) this.plAnh);
    this.panel1.Controls.Add((Control) this.ckbAnh);
    this.panel1.Controls.Add((Control) this.label19);
    this.panel1.Controls.Add((Control) this.label20);
    this.panel1.Controls.Add((Control) this.nudKhoangCachTo);
    this.panel1.Controls.Add((Control) this.nudKhoangCachFrom);
    this.panel1.Controls.Add((Control) this.label18);
    this.panel1.Controls.Add((Control) this.label17);
    this.panel1.Controls.Add((Control) this.nudSoLuongTo);
    this.panel1.Controls.Add((Control) this.nudSoLuongFrom);
    this.panel1.Controls.Add((Control) this.label16);
    this.panel1.Controls.Add((Control) this.label15);
    this.panel1.Controls.Add((Control) this.plVanBan);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.ckbVanBan);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Controls.Add((Control) this.plDangLink);
    this.panel1.Controls.Add((Control) this.ckbDangLink);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(677, 546);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.btnDown.Cursor = Cursors.Hand;
    this.btnDown.Image = (Image) Resources.icons8_down_arrow_32px2;
    this.btnDown.Location = new Point(619, 126);
    this.btnDown.Name = "btnDown";
    this.btnDown.Size = new Size(25, 25);
    this.btnDown.TabIndex = 200;
    this.btnDown.UseSelectable = true;
    this.btnDown.Click += new EventHandler(this.btnDown_Click);
    this.btnUp.Cursor = Cursors.Hand;
    this.btnUp.Location = new Point(588, 126);
    this.btnUp.Name = "btnUp";
    this.btnUp.Size = new Size(25, 25);
    this.btnUp.TabIndex = 201;
    this.btnUp.UseSelectable = true;
    this.btnUp.Click += new EventHandler(this.btnUp_Click);
    this.plAnh.BorderStyle = BorderStyle.FixedSingle;
    this.plAnh.Controls.Add((Control) this.nudSoLuongAnhTo);
    this.plAnh.Controls.Add((Control) this.nudSoLuongAnhFrom);
    this.plAnh.Controls.Add((Control) this.txtPathAnh);
    this.plAnh.Controls.Add((Control) this.label10);
    this.plAnh.Controls.Add((Control) this.label4);
    this.plAnh.Controls.Add((Control) this.label2);
    this.plAnh.Controls.Add((Control) this.label3);
    this.plAnh.Location = new Point(47, 433);
    this.plAnh.Name = "plAnh";
    this.plAnh.Size = new Size(597, 58);
    this.plAnh.TabIndex = 45;
    this.nudSoLuongAnhTo.Location = new Point(191, 30);
    this.nudSoLuongAnhTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
    this.nudSoLuongAnhTo.Size = new Size(45, 23);
    this.nudSoLuongAnhTo.TabIndex = 3;
    this.nudSoLuongAnhFrom.Location = new Point(113, 30);
    this.nudSoLuongAnhFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
    this.nudSoLuongAnhFrom.Size = new Size(45, 23);
    this.nudSoLuongAnhFrom.TabIndex = 3;
    this.txtPathAnh.Location = new Point(113, 3);
    this.txtPathAnh.Name = "txtPathAnh";
    this.txtPathAnh.Size = new Size(476, 23);
    this.txtPathAnh.TabIndex = 1;
    this.label10.Location = new Point(160, 32);
    this.label10.Name = "label10";
    this.label10.Size = new Size(29, 16);
    this.label10.TabIndex = 0;
    this.label10.Text = "đến";
    this.label10.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(236, 32);
    this.label4.Name = "label4";
    this.label4.Size = new Size(28, 16);
    this.label4.TabIndex = 0;
    this.label4.Text = "ảnh";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(3, 32);
    this.label2.Name = "label2";
    this.label2.Size = new Size(110, 16);
    this.label2.TabIndex = 0;
    this.label2.Text = "Số lượng ảnh/bài:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(3, 6);
    this.label3.Name = "label3";
    this.label3.Size = new Size(88, 16);
    this.label3.TabIndex = 0;
    this.label3.Text = "Thư mục ảnh:";
    this.ckbAnh.AutoSize = true;
    this.ckbAnh.Cursor = Cursors.Hand;
    this.ckbAnh.Location = new Point(33, 409);
    this.ckbAnh.Name = "ckbAnh";
    this.ckbAnh.Size = new Size(48, 20);
    this.ckbAnh.TabIndex = 44;
    this.ckbAnh.Text = "Ảnh";
    this.ckbAnh.UseVisualStyleBackColor = true;
    this.ckbAnh.CheckedChanged += new EventHandler(this.ckbAnh_CheckedChanged);
    this.label19.AutoSize = true;
    this.label19.Location = new Point(291, 109);
    this.label19.Name = "label19";
    this.label19.Size = new Size(30, 16);
    this.label19.TabIndex = 43;
    this.label19.Text = "giây";
    this.label20.Location = new Point(205, 109);
    this.label20.Name = "label20";
    this.label20.Size = new Size(29, 16);
    this.label20.TabIndex = 42;
    this.label20.Text = "đến";
    this.label20.TextAlign = ContentAlignment.MiddleCenter;
    this.nudKhoangCachTo.Location = new Point(236, 107);
    this.nudKhoangCachTo.Name = "nudKhoangCachTo";
    this.nudKhoangCachTo.Size = new Size(51, 23);
    this.nudKhoangCachTo.TabIndex = 41;
    this.nudKhoangCachFrom.Location = new Point(151, 107);
    this.nudKhoangCachFrom.Name = "nudKhoangCachFrom";
    this.nudKhoangCachFrom.Size = new Size(51, 23);
    this.nudKhoangCachFrom.TabIndex = 40;
    this.label18.AutoSize = true;
    this.label18.Location = new Point(291, 83);
    this.label18.Name = "label18";
    this.label18.Size = new Size(24, 16);
    this.label18.TabIndex = 39;
    this.label18.Text = "bài";
    this.label17.Location = new Point(205, 83);
    this.label17.Name = "label17";
    this.label17.Size = new Size(29, 16);
    this.label17.TabIndex = 38;
    this.label17.Text = "đến";
    this.label17.TextAlign = ContentAlignment.MiddleCenter;
    this.nudSoLuongTo.Location = new Point(236, 78);
    this.nudSoLuongTo.Name = "nudSoLuongTo";
    this.nudSoLuongTo.Size = new Size(51, 23);
    this.nudSoLuongTo.TabIndex = 37;
    this.nudSoLuongFrom.Location = new Point(151, 78);
    this.nudSoLuongFrom.Name = "nudSoLuongFrom";
    this.nudSoLuongFrom.Size = new Size(51, 23);
    this.nudSoLuongFrom.TabIndex = 36;
    this.label16.AutoSize = true;
    this.label16.Location = new Point(30, 109);
    this.label16.Name = "label16";
    this.label16.Size = new Size(116, 16);
    this.label16.TabIndex = 35;
    this.label16.Text = "Khoảng cách đăng:";
    this.label15.AutoSize = true;
    this.label15.Location = new Point(30, 83);
    this.label15.Name = "label15";
    this.label15.Size = new Size(108, 16);
    this.label15.TabIndex = 34;
    this.label15.Text = "Số lượng bài viết:";
    this.plVanBan.BorderStyle = BorderStyle.FixedSingle;
    this.plVanBan.Controls.Add((Control) this.linkLabel1);
    this.plVanBan.Controls.Add((Control) this.button3);
    this.plVanBan.Controls.Add((Control) this.button2);
    this.plVanBan.Controls.Add((Control) this.rbNganCachKyTu);
    this.plVanBan.Controls.Add((Control) this.rbNganCachMoiDong);
    this.plVanBan.Controls.Add((Control) this.label9);
    this.plVanBan.Controls.Add((Control) this.txtNoiDung);
    this.plVanBan.Controls.Add((Control) this.label8);
    this.plVanBan.Controls.Add((Control) this.lblStatus);
    this.plVanBan.Controls.Add((Control) this.ckbUseBackground);
    this.plVanBan.Controls.Add((Control) this.ckbXoaNguyenLieuDaDung);
    this.plVanBan.Location = new Point(47, 155);
    this.plVanBan.Name = "plVanBan";
    this.plVanBan.Size = new Size(597, 250);
    this.plVanBan.TabIndex = 33;
    this.linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.Cursor = Cursors.Hand;
    this.linkLabel1.Location = new Point(154, 199);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(81, 16);
    this.linkLabel1.TabIndex = 195;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "Random icon";
    this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
    this.button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button3.Cursor = Cursors.Help;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.Location = new Point(571, 221);
    this.button3.Name = "button3";
    this.button3.Size = new Size(21, 23);
    this.button3.TabIndex = 193;
    this.button3.Text = "?";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Help;
    this.button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button2.Location = new Point(571, 198);
    this.button2.Name = "button2";
    this.button2.Size = new Size(21, 23);
    this.button2.TabIndex = 194;
    this.button2.Text = "?";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.rbNganCachKyTu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(412, 222);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(159, 20);
    this.rbNganCachKyTu.TabIndex = 37;
    this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachKyTu.CheckedChanged += new EventHandler(this.rbNganCachKyTu_CheckedChanged);
    this.rbNganCachMoiDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(412, 200);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(155, 20);
    this.rbNganCachMoiDong.TabIndex = 36;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.CheckedChanged += new EventHandler(this.rbNganCachMoiDong_CheckedChanged);
    this.label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label9.AutoSize = true;
    this.label9.Location = new Point(347, 200);
    this.label9.Name = "label9";
    this.label9.Size = new Size(64, 16);
    this.label9.TabIndex = 35;
    this.label9.Text = "Tùy chọn:";
    this.txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtNoiDung.Location = new Point(7, 24);
    this.txtNoiDung.Name = "txtNoiDung";
    this.txtNoiDung.Size = new Size(585, 173);
    this.txtNoiDung.TabIndex = 34;
    this.txtNoiDung.Text = "";
    this.txtNoiDung.WordWrap = false;
    this.txtNoiDung.TextChanged += new EventHandler(this.txtNoiDung_TextChanged);
    this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label8.AutoSize = true;
    this.label8.Location = new Point(4, 199);
    this.label8.Name = "label8";
    this.label8.Size = new Size(143, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Spin nội dung {a|b|c})";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(145, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Danh sách nội dung (0):";
    this.ckbUseBackground.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.ckbUseBackground.AutoSize = true;
    this.ckbUseBackground.Cursor = Cursors.Hand;
    this.ckbUseBackground.Location = new Point(6, 222);
    this.ckbUseBackground.Name = "ckbUseBackground";
    this.ckbUseBackground.Size = new Size(144, 20);
    this.ckbUseBackground.TabIndex = 32;
    this.ckbUseBackground.Text = "Sử dụng Background";
    this.ckbUseBackground.UseVisualStyleBackColor = true;
    this.ckbUseBackground.CheckedChanged += new EventHandler(this.ckbUseBackground_CheckedChanged);
    this.ckbXoaNguyenLieuDaDung.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.ckbXoaNguyenLieuDaDung.AutoSize = true;
    this.ckbXoaNguyenLieuDaDung.Cursor = Cursors.Hand;
    this.ckbXoaNguyenLieuDaDung.Location = new Point(157, 222);
    this.ckbXoaNguyenLieuDaDung.Name = "ckbXoaNguyenLieuDaDung";
    this.ckbXoaNguyenLieuDaDung.Size = new Size(151, 20);
    this.ckbXoaNguyenLieuDaDung.TabIndex = 32;
    this.ckbXoaNguyenLieuDaDung.Text = "Xóa nội dung đã đăng";
    this.ckbXoaNguyenLieuDaDung.UseVisualStyleBackColor = true;
    this.ckbXoaNguyenLieuDaDung.CheckedChanged += new EventHandler(this.ckbVanBan_CheckedChanged);
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(242, 505);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.ckbVanBan.AutoSize = true;
    this.ckbVanBan.Cursor = Cursors.Hand;
    this.ckbVanBan.Location = new Point(33, 131);
    this.ckbVanBan.Name = "ckbVanBan";
    this.ckbVanBan.Size = new Size(73, 20);
    this.ckbVanBan.TabIndex = 32;
    this.ckbVanBan.Text = "Văn bản";
    this.ckbVanBan.UseVisualStyleBackColor = true;
    this.ckbVanBan.CheckedChanged += new EventHandler(this.ckbVanBan_CheckedChanged);
    this.txtTenHanhDong.Location = new Point(151, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(174, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(30, 52);
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
    this.btnCancel.Location = new Point(341, 505);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 4;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
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
    this.bunifuCards1.Size = new Size(674, 37);
    this.bunifuCards1.TabIndex = 28;
    this.plDangLink.BorderStyle = BorderStyle.FixedSingle;
    this.plDangLink.Controls.Add((Control) this.lblDanhSachLink);
    this.plDangLink.Controls.Add((Control) this.txtLinkShare);
    this.plDangLink.Controls.Add((Control) this.ckbXoaLink);
    this.plDangLink.Location = new Point(47, 303);
    this.plDangLink.Name = "plDangLink";
    this.plDangLink.Size = new Size(597, 102);
    this.plDangLink.TabIndex = 60;
    this.plDangLink.Visible = false;
    this.lblDanhSachLink.AutoSize = true;
    this.lblDanhSachLink.Location = new Point(2, 2);
    this.lblDanhSachLink.Name = "lblDanhSachLink";
    this.lblDanhSachLink.Size = new Size(115, 16);
    this.lblDanhSachLink.TabIndex = 0;
    this.lblDanhSachLink.Text = "Danh sách link (0):";
    this.txtLinkShare.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtLinkShare.Location = new Point(5, 21);
    this.txtLinkShare.Name = "txtLinkShare";
    this.txtLinkShare.Size = new Size(587, 55);
    this.txtLinkShare.TabIndex = 34;
    this.txtLinkShare.Text = "";
    this.txtLinkShare.WordWrap = false;
    this.txtLinkShare.TextChanged += new EventHandler(this.txtLinkShare_TextChanged);
    this.ckbXoaLink.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.ckbXoaLink.AutoSize = true;
    this.ckbXoaLink.Cursor = Cursors.Hand;
    this.ckbXoaLink.Location = new Point(5, 77);
    this.ckbXoaLink.Name = "ckbXoaLink";
    this.ckbXoaLink.Size = new Size(253, 20);
    this.ckbXoaLink.TabIndex = 168;
    this.ckbXoaLink.Text = "Tự động xóa link sau khi hiện thumbnail";
    this.ckbXoaLink.UseVisualStyleBackColor = true;
    this.ckbDangLink.AutoSize = true;
    this.ckbDangLink.Cursor = Cursors.Hand;
    this.ckbDangLink.Location = new Point(33, 281);
    this.ckbDangLink.Name = "ckbDangLink";
    this.ckbDangLink.Size = new Size(79, 20);
    this.ckbDangLink.TabIndex = 59;
    this.ckbDangLink.Text = "Đăng link";
    this.ckbDangLink.UseVisualStyleBackColor = true;
    this.ckbDangLink.Visible = false;
    this.ckbDangLink.CheckedChanged += new EventHandler(this.ckbDangLink_CheckedChanged);
    this.ckbDangLink.VisibleChanged += new EventHandler(this.ckbDangLink_VisibleChanged);
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(643, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 0;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(677, 546);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDDangBaiTuong);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDDangBaiTuong_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plAnh.ResumeLayout(false);
    this.plAnh.PerformLayout();
    this.nudSoLuongAnhTo.EndInit();
    this.nudSoLuongAnhFrom.EndInit();
    this.nudKhoangCachTo.EndInit();
    this.nudKhoangCachFrom.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.plVanBan.ResumeLayout(false);
    this.plVanBan.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.plDangLink.ResumeLayout(false);
    this.plDangLink.PerformLayout();
    this.ResumeLayout(false);
  }
}
