// Decompiled with JetBrains decompiler
// Type: fCauHinhTuongTac
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fCauHinhTuongTac : Form
{
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuDragControl bunifuDragControl_0;
  private GroupBox groupBox2;
  private CheckBox ckbRandomHanhDong;
  private ComboBox cbbKichBan;
  private MetroButton btnQuanLyKichBan;
  private Label label1;
  private CheckBox ckbGetCookie;
  private Panel panel1;
  private CheckBox ckbRepeatAll;
  private Label label2;
  private Panel panel2;
  private RadioButton rbLoginEmailPass;
  private RadioButton rbLoginUidPass;
  private Panel plRepeatAll;
  private Label label6;
  private Label label4;
  private NumericUpDown nudDelayTurnFrom;
  private Label label5;
  private NumericUpDown nudDelayTurnTo;
  private Label label11;
  private NumericUpDown nudSoLuotChay;
  private Label label10;
  private CheckBox ckbCheckLiveUid;
  private GroupBox groupBox1;
  private CheckBox ckbRandomThuTuTaiKhoan;
  private Panel plGioiHanThoiGianChayKichBan;
  private Label label3;
  private NumericUpDown nudThoiGianChayKichBanTo;
  private NumericUpDown nudThoiGianChayKichBanFrom;
  private Panel plGioiHanThoiGianChayTaiKhoan;
  private Label label13;
  private NumericUpDown nudThoiGianChayTaiKhoanTo;
  private NumericUpDown nudThoiGianChayTaiKhoanFrom;
  private CheckBox ckbGioiHanThoiGianChayKichBan;
  private CheckBox ckbGioiHanThoiGianChayTaiKhoan;
  private CheckBox ckbCheckGoiYKetBan;
  private Panel plCapNhatThongTin;
  private CheckBox ckbEmail;
  private CheckBox ckbNgayTao;
  private CheckBox ckbFollow;
  private CheckBox ckbBirthday;
  private CheckBox ckbGroup;
  private CheckBox ckbGender;
  private CheckBox ckbFriend;
  private CheckBox ckbName;
  private CheckBox ckbCapNhatThongTin;
  private CheckBox ckbCongKhaiThongTin;
  private IContainer components;
  private CheckBox ckbPhone;

  public fCauHinhTuongTac()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    int object_0 = 0;
    if (this.rbLoginEmailPass.Checked)
      object_0 = 1;
    GClass33.smethod_0("configInteractGeneral").method_6("typeLogin", (object) object_0);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbGetCookie", (object) this.ckbGetCookie.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbCheckGoiYKetBan", (object) this.ckbCheckGoiYKetBan.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbCheckLiveUid", (object) this.ckbCheckLiveUid.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbCongKhaiThongTin", (object) this.ckbCongKhaiThongTin.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbCapNhatThongTin", (object) this.ckbCapNhatThongTin.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbName", (object) this.ckbName.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbGender", (object) this.ckbGender.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbBirthday", (object) this.ckbBirthday.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbNgayTao", (object) this.ckbNgayTao.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbEmail", (object) this.ckbEmail.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbPhone", (object) this.ckbPhone.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbFriend", (object) this.ckbFriend.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbGroup", (object) this.ckbGroup.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbFollow", (object) this.ckbFollow.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbRepeatAll", (object) this.ckbRepeatAll.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("nudDelayTurnFrom", (object) this.nudDelayTurnFrom.Value);
    GClass33.smethod_0("configInteractGeneral").method_6("nudDelayTurnTo", (object) this.nudDelayTurnTo.Value);
    GClass33.smethod_0("configInteractGeneral").method_6("nudSoLuotChay", (object) this.nudSoLuotChay.Value);
    GClass33.smethod_0("configInteractGeneral").method_6("RepeatAllVIP", (object) "false");
    GClass33.smethod_0("configInteractGeneral").method_6("ckbRandomThuTuTaiKhoan", (object) this.ckbRandomThuTuTaiKhoan.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("cbbKichBan", this.cbbKichBan.SelectedValue);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbRandomHanhDong", (object) this.ckbRandomHanhDong.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbGioiHanThoiGianChayTaiKhoan", (object) this.ckbGioiHanThoiGianChayTaiKhoan.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("nudThoiGianChayTaiKhoanFrom", (object) this.nudThoiGianChayTaiKhoanFrom.Value);
    GClass33.smethod_0("configInteractGeneral").method_6("nudThoiGianChayTaiKhoanTo", (object) this.nudThoiGianChayTaiKhoanTo.Value);
    GClass33.smethod_0("configInteractGeneral").method_6("ckbGioiHanThoiGianChayKichBan", (object) this.ckbGioiHanThoiGianChayKichBan.Checked);
    GClass33.smethod_0("configInteractGeneral").method_6("nudThoiGianChayKichBanFrom", (object) this.nudThoiGianChayKichBanFrom.Value);
    GClass33.smethod_0("configInteractGeneral").method_6("nudThoiGianChayKichBanTo", (object) this.nudThoiGianChayKichBanTo.Value);
    GClass33.smethod_2("configInteractGeneral");
    if (GClass14.smethod_1(GClass35.smethod_0("Lưu thành công, bạn có muốn đóng cửa sổ?")) != DialogResult.Yes)
      return;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnQuanLyKichBan_Click(object sender, EventArgs e)
  {
    string string_1 = "";
    try
    {
      if (this.cbbKichBan.Items.Count > 0)
        string_1 = this.cbbKichBan.SelectedValue.ToString();
    }
    catch
    {
    }
    GClass19.smethod_35((Form) new fDanhSachKichBan_Old(string_1));
    this.method_2();
  }

  private void method_0()
  {
    this.ckbRepeatAll_CheckedChanged((object) null, (EventArgs) null);
    this.ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged((object) null, (EventArgs) null);
    this.ckbGioiHanThoiGianChayKichBan_CheckedChanged((object) null, (EventArgs) null);
    this.ckbCapNhatThongTin_CheckedChanged((object) null, (EventArgs) null);
  }

  private void fCauHinhTuongTac_Load(object sender, EventArgs e)
  {
    this.method_2();
    this.method_1();
    this.method_0();
  }

  private void method_1()
  {
    try
    {
      switch (GClass33.smethod_0("configInteractGeneral").method_3("typeLogin"))
      {
        case 0:
          this.rbLoginUidPass.Checked = true;
          break;
        case 1:
          this.rbLoginEmailPass.Checked = true;
          break;
      }
      this.ckbGetCookie.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbGetCookie");
      this.ckbCheckGoiYKetBan.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbCheckGoiYKetBan");
      this.ckbCheckLiveUid.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbCheckLiveUid");
      this.ckbCongKhaiThongTin.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbCongKhaiThongTin");
      this.ckbCapNhatThongTin.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbCapNhatThongTin");
      this.ckbName.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbName");
      this.ckbGender.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbGender");
      this.ckbBirthday.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbBirthday");
      this.ckbNgayTao.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbNgayTao");
      this.ckbEmail.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbEmail");
      this.ckbPhone.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbPhone");
      this.ckbFriend.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbFriend");
      this.ckbGroup.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbGroup");
      this.ckbFollow.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbFollow");
      this.ckbRepeatAll.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll");
      this.nudDelayTurnFrom.Value = (Decimal) GClass33.smethod_0("configInteractGeneral").method_3("nudDelayTurnFrom");
      this.nudDelayTurnTo.Value = (Decimal) GClass33.smethod_0("configInteractGeneral").method_3("nudDelayTurnTo");
      this.nudSoLuotChay.Value = (Decimal) GClass33.smethod_0("configInteractGeneral").method_3("nudSoLuotChay");
      this.ckbRandomThuTuTaiKhoan.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbRandomThuTuTaiKhoan");
      this.cbbKichBan.SelectedValue = (object) GClass33.smethod_0("configInteractGeneral").method_1("cbbKichBan");
      this.ckbRandomHanhDong.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbRandomHanhDong");
      this.ckbGioiHanThoiGianChayTaiKhoan.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbGioiHanThoiGianChayTaiKhoan");
      this.nudThoiGianChayTaiKhoanFrom.Value = (Decimal) GClass33.smethod_0("configInteractGeneral").method_3("nudThoiGianChayTaiKhoanFrom", 1);
      this.nudThoiGianChayTaiKhoanTo.Value = (Decimal) GClass33.smethod_0("configInteractGeneral").method_3("nudThoiGianChayTaiKhoanTo", 1);
      this.ckbGioiHanThoiGianChayKichBan.Checked = GClass33.smethod_0("configInteractGeneral").method_4("ckbGioiHanThoiGianChayKichBan");
      this.nudThoiGianChayKichBanFrom.Value = (Decimal) GClass33.smethod_0("configInteractGeneral").method_3("nudThoiGianChayKichBanFrom", 1);
      this.nudThoiGianChayKichBanTo.Value = (Decimal) GClass33.smethod_0("configInteractGeneral").method_3("nudThoiGianChayKichBanTo", 1);
    }
    catch
    {
    }
  }

  private void method_2()
  {
    int num = -1;
    if (this.cbbKichBan.SelectedIndex != -1)
      num = this.cbbKichBan.SelectedIndex;
    this.cbbKichBan.DataSource = (object) Class205.smethod_4();
    this.cbbKichBan.ValueMember = "Id_KichBan";
    this.cbbKichBan.DisplayMember = "Ten";
    if (num != -1 && num != 0 && this.cbbKichBan.Items.Count >= num + 1)
    {
      this.cbbKichBan.SelectedIndex = num;
    }
    else
    {
      if (this.cbbKichBan.Items.Count <= 0)
        return;
      this.cbbKichBan.SelectedIndex = 0;
    }
  }

  private void ckbRepeatAll_CheckedChanged(object sender, EventArgs e) => this.plRepeatAll.Enabled = this.ckbRepeatAll.Checked;

  private void ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(object sender, EventArgs e) => this.plGioiHanThoiGianChayTaiKhoan.Enabled = this.ckbGioiHanThoiGianChayTaiKhoan.Checked;

  private void ckbGioiHanThoiGianChayKichBan_CheckedChanged(object sender, EventArgs e) => this.plGioiHanThoiGianChayKichBan.Enabled = this.ckbGioiHanThoiGianChayKichBan.Checked;

  private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e) => this.plCapNhatThongTin.Enabled = this.ckbCapNhatThongTin.Checked;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCauHinhTuongTac));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.groupBox2 = new GroupBox();
    this.plGioiHanThoiGianChayKichBan = new Panel();
    this.label3 = new Label();
    this.nudThoiGianChayKichBanTo = new NumericUpDown();
    this.nudThoiGianChayKichBanFrom = new NumericUpDown();
    this.plGioiHanThoiGianChayTaiKhoan = new Panel();
    this.label13 = new Label();
    this.nudThoiGianChayTaiKhoanTo = new NumericUpDown();
    this.nudThoiGianChayTaiKhoanFrom = new NumericUpDown();
    this.ckbGioiHanThoiGianChayKichBan = new CheckBox();
    this.ckbGioiHanThoiGianChayTaiKhoan = new CheckBox();
    this.ckbRandomHanhDong = new CheckBox();
    this.cbbKichBan = new ComboBox();
    this.label1 = new Label();
    this.btnQuanLyKichBan = new MetroButton();
    this.label2 = new Label();
    this.ckbGetCookie = new CheckBox();
    this.ckbRepeatAll = new CheckBox();
    this.panel1 = new Panel();
    this.groupBox1 = new GroupBox();
    this.plCapNhatThongTin = new Panel();
    this.ckbPhone = new CheckBox();
    this.ckbEmail = new CheckBox();
    this.ckbNgayTao = new CheckBox();
    this.ckbFollow = new CheckBox();
    this.ckbBirthday = new CheckBox();
    this.ckbGroup = new CheckBox();
    this.ckbGender = new CheckBox();
    this.ckbFriend = new CheckBox();
    this.ckbName = new CheckBox();
    this.ckbCapNhatThongTin = new CheckBox();
    this.panel2 = new Panel();
    this.rbLoginEmailPass = new RadioButton();
    this.rbLoginUidPass = new RadioButton();
    this.plRepeatAll = new Panel();
    this.label6 = new Label();
    this.label4 = new Label();
    this.nudDelayTurnFrom = new NumericUpDown();
    this.label5 = new Label();
    this.nudDelayTurnTo = new NumericUpDown();
    this.label11 = new Label();
    this.nudSoLuotChay = new NumericUpDown();
    this.label10 = new Label();
    this.ckbCheckLiveUid = new CheckBox();
    this.ckbCongKhaiThongTin = new CheckBox();
    this.ckbCheckGoiYKetBan = new CheckBox();
    this.ckbRandomThuTuTaiKhoan = new CheckBox();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.groupBox2.SuspendLayout();
    this.plGioiHanThoiGianChayKichBan.SuspendLayout();
    this.nudThoiGianChayKichBanTo.BeginInit();
    this.nudThoiGianChayKichBanFrom.BeginInit();
    this.plGioiHanThoiGianChayTaiKhoan.SuspendLayout();
    this.nudThoiGianChayTaiKhoanTo.BeginInit();
    this.nudThoiGianChayTaiKhoanFrom.BeginInit();
    this.panel1.SuspendLayout();
    this.groupBox1.SuspendLayout();
    this.plCapNhatThongTin.SuspendLayout();
    this.panel2.SuspendLayout();
    this.plRepeatAll.SuspendLayout();
    this.nudDelayTurnFrom.BeginInit();
    this.nudDelayTurnTo.BeginInit();
    this.nudSoLuotChay.BeginInit();
    this.SuspendLayout();
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.FromArgb(24, 119, 242);
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(2, 1);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(441, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(441, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(407, -2);
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
    this.bunifuCustomLabel1.Size = new Size(441, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Cấu hình Tương tác";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(226, 559);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 4;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(122, 559);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Lưu";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.groupBox2.Controls.Add((Control) this.plGioiHanThoiGianChayKichBan);
    this.groupBox2.Controls.Add((Control) this.plGioiHanThoiGianChayTaiKhoan);
    this.groupBox2.Controls.Add((Control) this.ckbGioiHanThoiGianChayKichBan);
    this.groupBox2.Controls.Add((Control) this.ckbGioiHanThoiGianChayTaiKhoan);
    this.groupBox2.Controls.Add((Control) this.ckbRandomHanhDong);
    this.groupBox2.Controls.Add((Control) this.cbbKichBan);
    this.groupBox2.Controls.Add((Control) this.label1);
    this.groupBox2.Controls.Add((Control) this.btnQuanLyKichBan);
    this.groupBox2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.groupBox2.Location = new Point(11, 399);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(420, 144);
    this.groupBox2.TabIndex = 7;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Tùy chọn tương tác";
    this.groupBox2.Enter += new EventHandler(this.groupBox2_Enter);
    this.plGioiHanThoiGianChayKichBan.BorderStyle = BorderStyle.FixedSingle;
    this.plGioiHanThoiGianChayKichBan.Controls.Add((Control) this.label3);
    this.plGioiHanThoiGianChayKichBan.Controls.Add((Control) this.nudThoiGianChayKichBanTo);
    this.plGioiHanThoiGianChayKichBan.Controls.Add((Control) this.nudThoiGianChayKichBanFrom);
    this.plGioiHanThoiGianChayKichBan.Location = new Point(292, 108);
    this.plGioiHanThoiGianChayKichBan.Name = "plGioiHanThoiGianChayKichBan";
    this.plGioiHanThoiGianChayKichBan.Size = new Size(123, 27);
    this.plGioiHanThoiGianChayKichBan.TabIndex = 10;
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(52, 4);
    this.label3.Name = "label3";
    this.label3.Size = new Size(18, 16);
    this.label3.TabIndex = 4;
    this.label3.Text = ">";
    this.nudThoiGianChayKichBanTo.Location = new Point(71, 1);
    this.nudThoiGianChayKichBanTo.Maximum = new Decimal(new int[4]
    {
      276447231,
      23283,
      0,
      0
    });
    this.nudThoiGianChayKichBanTo.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudThoiGianChayKichBanTo.Name = "nudThoiGianChayKichBanTo";
    this.nudThoiGianChayKichBanTo.Size = new Size(48, 23);
    this.nudThoiGianChayKichBanTo.TabIndex = 3;
    this.nudThoiGianChayKichBanTo.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudThoiGianChayKichBanFrom.Location = new Point(1, 1);
    this.nudThoiGianChayKichBanFrom.Maximum = new Decimal(new int[4]
    {
      276447231,
      23283,
      0,
      0
    });
    this.nudThoiGianChayKichBanFrom.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudThoiGianChayKichBanFrom.Name = "nudThoiGianChayKichBanFrom";
    this.nudThoiGianChayKichBanFrom.Size = new Size(48, 23);
    this.nudThoiGianChayKichBanFrom.TabIndex = 3;
    this.nudThoiGianChayKichBanFrom.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.plGioiHanThoiGianChayTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
    this.plGioiHanThoiGianChayTaiKhoan.Controls.Add((Control) this.label13);
    this.plGioiHanThoiGianChayTaiKhoan.Controls.Add((Control) this.nudThoiGianChayTaiKhoanTo);
    this.plGioiHanThoiGianChayTaiKhoan.Controls.Add((Control) this.nudThoiGianChayTaiKhoanFrom);
    this.plGioiHanThoiGianChayTaiKhoan.Location = new Point(292, 76);
    this.plGioiHanThoiGianChayTaiKhoan.Name = "plGioiHanThoiGianChayTaiKhoan";
    this.plGioiHanThoiGianChayTaiKhoan.Size = new Size(123, 27);
    this.plGioiHanThoiGianChayTaiKhoan.TabIndex = 10;
    this.label13.AutoSize = true;
    this.label13.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label13.Location = new Point(52, 4);
    this.label13.Name = "label13";
    this.label13.Size = new Size(18, 16);
    this.label13.TabIndex = 4;
    this.label13.Text = ">";
    this.nudThoiGianChayTaiKhoanTo.Location = new Point(71, 1);
    this.nudThoiGianChayTaiKhoanTo.Maximum = new Decimal(new int[4]
    {
      276447231,
      23283,
      0,
      0
    });
    this.nudThoiGianChayTaiKhoanTo.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudThoiGianChayTaiKhoanTo.Name = "nudThoiGianChayTaiKhoanTo";
    this.nudThoiGianChayTaiKhoanTo.Size = new Size(48, 23);
    this.nudThoiGianChayTaiKhoanTo.TabIndex = 3;
    this.nudThoiGianChayTaiKhoanTo.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudThoiGianChayTaiKhoanFrom.Location = new Point(1, 1);
    this.nudThoiGianChayTaiKhoanFrom.Maximum = new Decimal(new int[4]
    {
      276447231,
      23283,
      0,
      0
    });
    this.nudThoiGianChayTaiKhoanFrom.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudThoiGianChayTaiKhoanFrom.Name = "nudThoiGianChayTaiKhoanFrom";
    this.nudThoiGianChayTaiKhoanFrom.Size = new Size(48, 23);
    this.nudThoiGianChayTaiKhoanFrom.TabIndex = 3;
    this.nudThoiGianChayTaiKhoanFrom.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.ckbGioiHanThoiGianChayKichBan.AutoSize = true;
    this.ckbGioiHanThoiGianChayKichBan.Cursor = Cursors.Hand;
    this.ckbGioiHanThoiGianChayKichBan.Location = new Point(19, 112);
    this.ckbGioiHanThoiGianChayKichBan.Name = "ckbGioiHanThoiGianChayKichBan";
    this.ckbGioiHanThoiGianChayKichBan.Size = new Size(270, 20);
    this.ckbGioiHanThoiGianChayKichBan.TabIndex = 7;
    this.ckbGioiHanThoiGianChayKichBan.Text = "Giới hạn thời gian chạy mỗi kịch bản (phút)";
    this.ckbGioiHanThoiGianChayKichBan.UseVisualStyleBackColor = true;
    this.ckbGioiHanThoiGianChayKichBan.CheckedChanged += new EventHandler(this.ckbGioiHanThoiGianChayKichBan_CheckedChanged);
    this.ckbGioiHanThoiGianChayTaiKhoan.AutoSize = true;
    this.ckbGioiHanThoiGianChayTaiKhoan.Cursor = Cursors.Hand;
    this.ckbGioiHanThoiGianChayTaiKhoan.Location = new Point(19, 79);
    this.ckbGioiHanThoiGianChayTaiKhoan.Name = "ckbGioiHanThoiGianChayTaiKhoan";
    this.ckbGioiHanThoiGianChayTaiKhoan.Size = new Size(273, 20);
    this.ckbGioiHanThoiGianChayTaiKhoan.TabIndex = 8;
    this.ckbGioiHanThoiGianChayTaiKhoan.Text = "Giới hạn thời gian chạy mỗi tài khoản (giây)";
    this.ckbGioiHanThoiGianChayTaiKhoan.UseVisualStyleBackColor = true;
    this.ckbGioiHanThoiGianChayTaiKhoan.CheckedChanged += new EventHandler(this.ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged);
    this.ckbRandomHanhDong.AutoSize = true;
    this.ckbRandomHanhDong.Cursor = Cursors.Hand;
    this.ckbRandomHanhDong.Location = new Point(19, 53);
    this.ckbRandomHanhDong.Name = "ckbRandomHanhDong";
    this.ckbRandomHanhDong.Size = new Size(199, 20);
    this.ckbRandomHanhDong.TabIndex = 2;
    this.ckbRandomHanhDong.Text = "Random thứ tự các hành động";
    this.ckbRandomHanhDong.UseVisualStyleBackColor = true;
    this.cbbKichBan.Cursor = Cursors.Hand;
    this.cbbKichBan.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbKichBan.DropDownWidth = 300;
    this.cbbKichBan.FormattingEnabled = true;
    this.cbbKichBan.Location = new Point(115, 23);
    this.cbbKichBan.Name = "cbbKichBan";
    this.cbbKichBan.Size = new Size(174, 24);
    this.cbbKichBan.TabIndex = 1;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(16, 26);
    this.label1.Name = "label1";
    this.label1.Size = new Size(92, 16);
    this.label1.TabIndex = 0;
    this.label1.Text = "Chọn kịch bản:";
    this.btnQuanLyKichBan.Cursor = Cursors.Hand;
    this.btnQuanLyKichBan.Location = new Point(295, 22);
    this.btnQuanLyKichBan.Name = "btnQuanLyKichBan";
    this.btnQuanLyKichBan.Size = new Size(120, 25);
    this.btnQuanLyKichBan.TabIndex = 1;
    this.btnQuanLyKichBan.Text = "Quản lý kịch bản";
    this.btnQuanLyKichBan.UseSelectable = true;
    this.btnQuanLyKichBan.Click += new EventHandler(this.btnQuanLyKichBan_Click);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(16, 24);
    this.label2.Name = "label2";
    this.label2.Size = new Size(100, 16);
    this.label2.TabIndex = 3;
    this.label2.Text = "Kiểu đăng nhập:";
    this.ckbGetCookie.AutoSize = true;
    this.ckbGetCookie.Cursor = Cursors.Hand;
    this.ckbGetCookie.Location = new Point(19, 76);
    this.ckbGetCookie.Name = "ckbGetCookie";
    this.ckbGetCookie.Size = new Size(176, 20);
    this.ckbGetCookie.TabIndex = 2;
    this.ckbGetCookie.Text = "Tự động lấy Token/Cookie";
    this.ckbGetCookie.UseVisualStyleBackColor = true;
    this.ckbRepeatAll.AutoSize = true;
    this.ckbRepeatAll.Cursor = Cursors.Hand;
    this.ckbRepeatAll.Location = new Point(19, 258);
    this.ckbRepeatAll.Name = "ckbRepeatAll";
    this.ckbRepeatAll.Size = new Size(344, 20);
    this.ckbRepeatAll.TabIndex = 2;
    this.ckbRepeatAll.Text = "Chạy tương tác lại toàn bộ tài khoản sau khi hoàn thành";
    this.ckbRepeatAll.UseVisualStyleBackColor = true;
    this.ckbRepeatAll.CheckedChanged += new EventHandler(this.ckbRepeatAll_CheckedChanged);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.groupBox2);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(443, 601);
    this.panel1.TabIndex = 8;
    this.groupBox1.Controls.Add((Control) this.plCapNhatThongTin);
    this.groupBox1.Controls.Add((Control) this.ckbCapNhatThongTin);
    this.groupBox1.Controls.Add((Control) this.panel2);
    this.groupBox1.Controls.Add((Control) this.plRepeatAll);
    this.groupBox1.Controls.Add((Control) this.ckbCheckLiveUid);
    this.groupBox1.Controls.Add((Control) this.ckbCongKhaiThongTin);
    this.groupBox1.Controls.Add((Control) this.ckbCheckGoiYKetBan);
    this.groupBox1.Controls.Add((Control) this.ckbGetCookie);
    this.groupBox1.Controls.Add((Control) this.label2);
    this.groupBox1.Controls.Add((Control) this.ckbRandomThuTuTaiKhoan);
    this.groupBox1.Controls.Add((Control) this.ckbRepeatAll);
    this.groupBox1.Font = new Font("Tahoma", 9.75f);
    this.groupBox1.Location = new Point(11, 43);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(420, 350);
    this.groupBox1.TabIndex = 8;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Tùy chọn";
    this.plCapNhatThongTin.BorderStyle = BorderStyle.FixedSingle;
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbPhone);
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbEmail);
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbNgayTao);
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbFollow);
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbBirthday);
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbGroup);
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbGender);
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbFriend);
    this.plCapNhatThongTin.Controls.Add((Control) this.ckbName);
    this.plCapNhatThongTin.Location = new Point(39, 151);
    this.plCapNhatThongTin.Name = "plCapNhatThongTin";
    this.plCapNhatThongTin.Size = new Size(376, 52);
    this.plCapNhatThongTin.TabIndex = 15;
    this.ckbPhone.AutoSize = true;
    this.ckbPhone.Cursor = Cursors.Hand;
    this.ckbPhone.Location = new Point(173, 28);
    this.ckbPhone.Name = "ckbPhone";
    this.ckbPhone.Size = new Size(61, 20);
    this.ckbPhone.TabIndex = 0;
    this.ckbPhone.Text = "Phone";
    this.ckbPhone.UseVisualStyleBackColor = true;
    this.ckbEmail.AutoSize = true;
    this.ckbEmail.Cursor = Cursors.Hand;
    this.ckbEmail.Location = new Point(173, 2);
    this.ckbEmail.Name = "ckbEmail";
    this.ckbEmail.Size = new Size(57, 20);
    this.ckbEmail.TabIndex = 0;
    this.ckbEmail.Text = "Email";
    this.ckbEmail.UseVisualStyleBackColor = true;
    this.ckbNgayTao.AutoSize = true;
    this.ckbNgayTao.Cursor = Cursors.Hand;
    this.ckbNgayTao.Location = new Point(84, 28);
    this.ckbNgayTao.Name = "ckbNgayTao";
    this.ckbNgayTao.Size = new Size(76, 20);
    this.ckbNgayTao.TabIndex = 0;
    this.ckbNgayTao.Text = "Ngày tạo";
    this.ckbNgayTao.UseVisualStyleBackColor = true;
    this.ckbFollow.AutoSize = true;
    this.ckbFollow.Location = new Point(304, 27);
    this.ckbFollow.Name = "ckbFollow";
    this.ckbFollow.Size = new Size(91, 20);
    this.ckbFollow.TabIndex = 0;
    this.ckbFollow.Text = "Follow (ẩn)";
    this.ckbFollow.UseVisualStyleBackColor = true;
    this.ckbFollow.Visible = false;
    this.ckbBirthday.AutoSize = true;
    this.ckbBirthday.Cursor = Cursors.Hand;
    this.ckbBirthday.Location = new Point(84, 2);
    this.ckbBirthday.Name = "ckbBirthday";
    this.ckbBirthday.Size = new Size(81, 20);
    this.ckbBirthday.TabIndex = 0;
    this.ckbBirthday.Text = "Ngày sinh";
    this.ckbBirthday.UseVisualStyleBackColor = true;
    this.ckbGroup.AutoSize = true;
    this.ckbGroup.Cursor = Cursors.Hand;
    this.ckbGroup.Location = new Point(238, 2);
    this.ckbGroup.Name = "ckbGroup";
    this.ckbGroup.Size = new Size(60, 20);
    this.ckbGroup.TabIndex = 0;
    this.ckbGroup.Text = "Group";
    this.ckbGroup.UseVisualStyleBackColor = true;
    this.ckbGender.AutoSize = true;
    this.ckbGender.Cursor = Cursors.Hand;
    this.ckbGender.Location = new Point(4, 2);
    this.ckbGender.Name = "ckbGender";
    this.ckbGender.Size = new Size(72, 20);
    this.ckbGender.TabIndex = 0;
    this.ckbGender.Text = "Giới tính";
    this.ckbGender.UseVisualStyleBackColor = true;
    this.ckbFriend.AutoSize = true;
    this.ckbFriend.Location = new Point(304, 3);
    this.ckbFriend.Name = "ckbFriend";
    this.ckbFriend.Size = new Size(90, 20);
    this.ckbFriend.TabIndex = 0;
    this.ckbFriend.Text = "Friend (ẩn)";
    this.ckbFriend.UseVisualStyleBackColor = true;
    this.ckbFriend.CheckedChanged += new EventHandler(this.ckbFriend_CheckedChanged);
    this.ckbName.AutoSize = true;
    this.ckbName.Cursor = Cursors.Hand;
    this.ckbName.Location = new Point(4, 28);
    this.ckbName.Name = "ckbName";
    this.ckbName.Size = new Size(59, 20);
    this.ckbName.TabIndex = 0;
    this.ckbName.Text = "Name";
    this.ckbName.UseVisualStyleBackColor = true;
    this.ckbCapNhatThongTin.AutoSize = true;
    this.ckbCapNhatThongTin.Cursor = Cursors.Hand;
    this.ckbCapNhatThongTin.Location = new Point(19, 128);
    this.ckbCapNhatThongTin.Name = "ckbCapNhatThongTin";
    this.ckbCapNhatThongTin.Size = new Size(181, 20);
    this.ckbCapNhatThongTin.TabIndex = 14;
    this.ckbCapNhatThongTin.Text = "Tự động cập nhật thông tin";
    this.ckbCapNhatThongTin.UseVisualStyleBackColor = true;
    this.ckbCapNhatThongTin.CheckedChanged += new EventHandler(this.ckbCapNhatThongTin_CheckedChanged);
    this.panel2.Controls.Add((Control) this.rbLoginEmailPass);
    this.panel2.Controls.Add((Control) this.rbLoginUidPass);
    this.panel2.Location = new Point(115, 21);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(292, 26);
    this.panel2.TabIndex = 6;
    this.rbLoginEmailPass.AutoSize = true;
    this.rbLoginEmailPass.Cursor = Cursors.Hand;
    this.rbLoginEmailPass.Location = new Point(93, 3);
    this.rbLoginEmailPass.Name = "rbLoginEmailPass";
    this.rbLoginEmailPass.Size = new Size(88, 20);
    this.rbLoginEmailPass.TabIndex = 4;
    this.rbLoginEmailPass.Text = "Email|Pass";
    this.rbLoginEmailPass.UseVisualStyleBackColor = true;
    this.rbLoginUidPass.AutoSize = true;
    this.rbLoginUidPass.Checked = true;
    this.rbLoginUidPass.Cursor = Cursors.Hand;
    this.rbLoginUidPass.Location = new Point(3, 3);
    this.rbLoginUidPass.Name = "rbLoginUidPass";
    this.rbLoginUidPass.Size = new Size(75, 20);
    this.rbLoginUidPass.TabIndex = 4;
    this.rbLoginUidPass.TabStop = true;
    this.rbLoginUidPass.Text = "Uid|Pass";
    this.rbLoginUidPass.UseVisualStyleBackColor = true;
    this.plRepeatAll.BorderStyle = BorderStyle.FixedSingle;
    this.plRepeatAll.Controls.Add((Control) this.label6);
    this.plRepeatAll.Controls.Add((Control) this.label4);
    this.plRepeatAll.Controls.Add((Control) this.nudDelayTurnFrom);
    this.plRepeatAll.Controls.Add((Control) this.label5);
    this.plRepeatAll.Controls.Add((Control) this.nudDelayTurnTo);
    this.plRepeatAll.Controls.Add((Control) this.label11);
    this.plRepeatAll.Controls.Add((Control) this.nudSoLuotChay);
    this.plRepeatAll.Controls.Add((Control) this.label10);
    this.plRepeatAll.Location = new Point(39, 280);
    this.plRepeatAll.Name = "plRepeatAll";
    this.plRepeatAll.Size = new Size(376, 64);
    this.plRepeatAll.TabIndex = 13;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(3, 7);
    this.label6.Name = "label6";
    this.label6.Size = new Size(83, 16);
    this.label6.TabIndex = 5;
    this.label6.Text = "Số lượt chạy:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(3, 36);
    this.label4.Name = "label4";
    this.label4.Size = new Size(144, 16);
    this.label4.TabIndex = 6;
    this.label4.Text = "Chờ chạy lượt tiếp theo:";
    this.nudDelayTurnFrom.Location = new Point(154, 34);
    this.nudDelayTurnFrom.Maximum = new Decimal(new int[4]
    {
      276447231,
      23283,
      0,
      0
    });
    this.nudDelayTurnFrom.Name = "nudDelayTurnFrom";
    this.nudDelayTurnFrom.Size = new Size(65, 23);
    this.nudDelayTurnFrom.TabIndex = 9;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(222, 8);
    this.label5.Name = "label5";
    this.label5.Size = new Size(29, 16);
    this.label5.TabIndex = 10;
    this.label5.Text = "lượt";
    this.label5.TextAlign = ContentAlignment.MiddleCenter;
    this.nudDelayTurnTo.Location = new Point(252, 34);
    this.nudDelayTurnTo.Maximum = new Decimal(new int[4]
    {
      276447231,
      23283,
      0,
      0
    });
    this.nudDelayTurnTo.Name = "nudDelayTurnTo";
    this.nudDelayTurnTo.Size = new Size(65, 23);
    this.nudDelayTurnTo.TabIndex = 8;
    this.label11.AutoSize = true;
    this.label11.Location = new Point(320, 37);
    this.label11.Name = "label11";
    this.label11.Size = new Size(32, 16);
    this.label11.TabIndex = 11;
    this.label11.Text = "phút";
    this.nudSoLuotChay.Location = new Point(154, 5);
    this.nudSoLuotChay.Maximum = new Decimal(new int[4]
    {
      276447231,
      23283,
      0,
      0
    });
    this.nudSoLuotChay.Name = "nudSoLuotChay";
    this.nudSoLuotChay.Size = new Size(65, 23);
    this.nudSoLuotChay.TabIndex = 7;
    this.label10.Location = new Point(222, 37);
    this.label10.Name = "label10";
    this.label10.Size = new Size(29, 16);
    this.label10.TabIndex = 12;
    this.label10.Text = "đến";
    this.label10.TextAlign = ContentAlignment.MiddleCenter;
    this.ckbCheckLiveUid.AutoSize = true;
    this.ckbCheckLiveUid.Cursor = Cursors.Hand;
    this.ckbCheckLiveUid.Location = new Point(19, 51);
    this.ckbCheckLiveUid.Name = "ckbCheckLiveUid";
    this.ckbCheckLiveUid.Size = new Size(192, 20);
    this.ckbCheckLiveUid.TabIndex = 2;
    this.ckbCheckLiveUid.Text = "Check Live Uid trước khi chạy";
    this.ckbCheckLiveUid.UseVisualStyleBackColor = true;
    this.ckbCongKhaiThongTin.AutoSize = true;
    this.ckbCongKhaiThongTin.Cursor = Cursors.Hand;
    this.ckbCongKhaiThongTin.Location = new Point(19, 208);
    this.ckbCongKhaiThongTin.Name = "ckbCongKhaiThongTin";
    this.ckbCongKhaiThongTin.Size = new Size(192, 20);
    this.ckbCongKhaiThongTin.TabIndex = 2;
    this.ckbCongKhaiThongTin.Text = "Công khai thông tin tài khoản";
    this.ckbCongKhaiThongTin.UseVisualStyleBackColor = true;
    this.ckbCheckGoiYKetBan.AutoSize = true;
    this.ckbCheckGoiYKetBan.Cursor = Cursors.Hand;
    this.ckbCheckGoiYKetBan.Location = new Point(19, 102);
    this.ckbCheckGoiYKetBan.Name = "ckbCheckGoiYKetBan";
    this.ckbCheckGoiYKetBan.Size = new Size(138, 20);
    this.ckbCheckGoiYKetBan.TabIndex = 2;
    this.ckbCheckGoiYKetBan.Text = "Check Gợi ý kết bạn";
    this.ckbCheckGoiYKetBan.UseVisualStyleBackColor = true;
    this.ckbRandomThuTuTaiKhoan.AutoSize = true;
    this.ckbRandomThuTuTaiKhoan.Cursor = Cursors.Hand;
    this.ckbRandomThuTuTaiKhoan.Location = new Point(19, 233);
    this.ckbRandomThuTuTaiKhoan.Name = "ckbRandomThuTuTaiKhoan";
    this.ckbRandomThuTuTaiKhoan.Size = new Size(254, 20);
    this.ckbRandomThuTuTaiKhoan.TabIndex = 2;
    this.ckbRandomThuTuTaiKhoan.Text = "Xáo trộn thứ tự tài khoản trước khi chạy";
    this.ckbRandomThuTuTaiKhoan.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(443, 601);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Controls.Add((Control) this.panel1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fCauHinhTuongTac);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fCauHinhTuongTac_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    this.plGioiHanThoiGianChayKichBan.ResumeLayout(false);
    this.plGioiHanThoiGianChayKichBan.PerformLayout();
    this.nudThoiGianChayKichBanTo.EndInit();
    this.nudThoiGianChayKichBanFrom.EndInit();
    this.plGioiHanThoiGianChayTaiKhoan.ResumeLayout(false);
    this.plGioiHanThoiGianChayTaiKhoan.PerformLayout();
    this.nudThoiGianChayTaiKhoanTo.EndInit();
    this.nudThoiGianChayTaiKhoanFrom.EndInit();
    this.panel1.ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.plCapNhatThongTin.ResumeLayout(false);
    this.plCapNhatThongTin.PerformLayout();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.plRepeatAll.ResumeLayout(false);
    this.plRepeatAll.PerformLayout();
    this.nudDelayTurnFrom.EndInit();
    this.nudDelayTurnTo.EndInit();
    this.nudSoLuotChay.EndInit();
    this.ResumeLayout(false);
  }

  private void ckbFriend_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void groupBox2_Enter(object sender, EventArgs e)
  {
  }
}
