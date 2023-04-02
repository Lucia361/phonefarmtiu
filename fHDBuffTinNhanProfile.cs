// Decompiled with JetBrains decompiler
// Type: fHDBuffTinNhanProfile
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fHDBuffTinNhanProfile : Form
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
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private TextBox txtTenHanhDong;
  private Label label7;
  private Label label6;
  private Label label5;
  private Label label1;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private Button button1;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Panel plComment;
  private Label label8;
  private Label lblStatus;
  private CheckBox ckbNhanTinVanBan;
  private Label label49;
  private NumericUpDown nudSoLuongUidFrom;
  private Label label68;
  private NumericUpDown nudSoLuongUidTo;
  private Label label66;
  private Label label2;
  private Label lblStatusUid;
  private RichTextBox txtUid;
  private Panel plAnh;
  private CheckBox ckbSendAnh;
  private RichTextBox txtNoiDung;
  private CheckBox ckbTuDongXoaUid;
  private ToolTip toolTip_0;
  private Label label3;
  private Label label4;
  private Label label9;
  private NumericUpDown nudSoLuongAnhFrom;
  private NumericUpDown nudSoLuongAnhTo;
  private MetroButton btnDown;
  private MetroButton btnUp;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private Label label11;
  private Panel plTuongTacTruocKhiNhanTin;
  private CheckBox ckbTuongTacKhiNhanTinComment;
  private CheckBox ckbTuongTacKhiNhanTinLike;
  private CheckBox ckbTuongTacKhiNhanTin;
  private Panel plTuongTacTruocKhiNhanTinComment;
  private RadioButton ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong;
  private RadioButton ckbTuongTacKhiNhanTinCommentNoiDung1Dong;
  private Label label12;
  private RichTextBox txtTuongTacKhiNhanTinComment;
  private Label label13;
  private Label label14;
  private RadioButton rbTuongTacSauKhiNhanTin;
  private RadioButton rbTuongTacTruocKhiNhanTin;
  private Label label15;
  private Label label16;
  private Label label10;
  private IContainer components;
  private TextBox txtAnh;

  public fHDBuffTinNhanProfile(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDBuffTinNhanProfile.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDBuffTinNhanProfile").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBuffTinNhanProfile', '{  \"nudSoLuongUidFrom\": \"1\",  \"nudSoLuongUidTo\": \"3\", \"nudSoLuongAnhFrom\": \"1\", \"nudSoLuongAnhTo\": \"1\",  \"nudDelayFrom\": \"3\",  \"nudDelayTo\": \"5\",  \"txtUid\": \"\",  \"ckbNhanTinVanBan\": \"True\",  \"txtNoiDung\": \"hello\",  \"ckbSendAnh\": \"False\",  \"txtAnh\": \"\",  \"ckbTuDongXoaUid\": \"False\"}', 'Buff Tin nhắn Profile');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDBuffTinNhanProfile");
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
    GClass35.smethod_1((Control) this.label49);
    GClass35.smethod_1((Control) this.label66);
    GClass35.smethod_1((Control) this.label5);
    GClass35.smethod_1((Control) this.label7);
    GClass35.smethod_1((Control) this.label6);
    GClass35.smethod_1((Control) this.lblStatusUid);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.ckbTuDongXoaUid);
    GClass35.smethod_1((Control) this.ckbNhanTinVanBan);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.ckbSendAnh);
    GClass35.smethod_1((Control) this.label10);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.label9);
    GClass35.smethod_1((Control) this.label4);
    GClass35.smethod_1((Control) this.ckbTuongTacKhiNhanTin);
    GClass35.smethod_1((Control) this.label15);
    GClass35.smethod_1((Control) this.rbTuongTacTruocKhiNhanTin);
    GClass35.smethod_1((Control) this.rbTuongTacSauKhiNhanTin);
    GClass35.smethod_1((Control) this.label16);
    GClass35.smethod_1((Control) this.label14);
    GClass35.smethod_1((Control) this.label13);
    GClass35.smethod_1((Control) this.label12);
    GClass35.smethod_1((Control) this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong);
    GClass35.smethod_1((Control) this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDBuffTinNhanProfile_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongUidFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongUidFrom", 1);
      this.nudSoLuongUidTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongUidTo", 3);
      this.nudSoLuongAnhFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongAnhFrom", 1);
      this.nudSoLuongAnhTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongAnhTo", 1);
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom", 3);
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo", 5);
      this.txtUid.Text = this.gclass22_0.method_1("txtUid");
      this.ckbNhanTinVanBan.Checked = this.gclass22_0.method_4("ckbNhanTinVanBan");
      this.txtNoiDung.Text = this.gclass22_0.method_1("txtNoiDung");
      this.ckbSendAnh.Checked = this.gclass22_0.method_4("ckbSendAnh");
      this.txtAnh.Text = this.gclass22_0.method_1("txtAnh");
      this.ckbTuongTacKhiNhanTin.Checked = this.gclass22_0.method_4("ckbTuongTacKhiNhanTin");
      if (this.gclass22_0.method_3("typeTuongTacKhiNhanTin") == 0)
        this.rbTuongTacTruocKhiNhanTin.Checked = true;
      else
        this.rbTuongTacSauKhiNhanTin.Checked = true;
      this.ckbTuongTacKhiNhanTinLike.Checked = this.gclass22_0.method_4("ckbTuongTacKhiNhanTinLike");
      this.ckbTuongTacKhiNhanTinComment.Checked = this.gclass22_0.method_4("ckbTuongTacKhiNhanTinComment");
      this.txtTuongTacKhiNhanTinComment.Text = this.gclass22_0.method_1("txtTuongTacKhiNhanTinComment");
      if (this.gclass22_0.method_3("typeNganCachComment") == 1)
        this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked = true;
      else
        this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Checked = true;
      this.ckbTuDongXoaUid.Checked = this.gclass22_0.method_4("ckbTuDongXoaUid");
      if (this.gclass22_0.method_3("typeNganCach") == 1)
        this.rbNganCachKyTu.Checked = true;
      else
        this.rbNganCachMoiDong.Checked = true;
    }
    catch
    {
    }
    this.method_3();
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    else if (GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>()).Count == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách Uid!"), 3);
    else if (this.ckbNhanTinVanBan.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtNoiDung.Lines).ToList<string>()).Count == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung tin nhắn!"), 3);
    else if (this.ckbSendAnh.Checked && this.txtAnh.Text.Trim().Length == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn folder ảnh!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudSoLuongUidFrom", (object) this.nudSoLuongUidFrom.Value);
      gclass22.method_6("nudSoLuongUidTo", (object) this.nudSoLuongUidTo.Value);
      gclass22.method_6("nudSoLuongAnhFrom", (object) this.nudSoLuongAnhFrom.Value);
      gclass22.method_6("nudSoLuongAnhTo", (object) this.nudSoLuongAnhTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("txtUid", (object) this.txtUid.Text.Trim());
      gclass22.method_6("ckbNhanTinVanBan", (object) this.ckbNhanTinVanBan.Checked);
      gclass22.method_6("txtNoiDung", (object) this.txtNoiDung.Text.Trim());
      gclass22.method_6("ckbSendAnh", (object) this.ckbSendAnh.Checked);
      gclass22.method_6("txtAnh", (object) this.txtAnh.Text.Trim());
      gclass22.method_6("ckbTuDongXoaUid", (object) this.ckbTuDongXoaUid.Checked);
      gclass22.method_6("ckbTuongTacKhiNhanTin", (object) this.ckbTuongTacKhiNhanTin.Checked);
      if (this.rbTuongTacTruocKhiNhanTin.Checked)
        gclass22.method_6("typeTuongTacKhiNhanTin", (object) 0);
      else
        gclass22.method_6("typeTuongTacKhiNhanTin", (object) 1);
      gclass22.method_6("ckbTuongTacKhiNhanTinLike", (object) this.ckbTuongTacKhiNhanTinLike.Checked);
      gclass22.method_6("ckbTuongTacKhiNhanTinComment", (object) this.ckbTuongTacKhiNhanTinComment.Checked);
      gclass22.method_6("txtTuongTacKhiNhanTinComment", (object) this.txtTuongTacKhiNhanTinComment.Text.Trim());
      int object_0_1 = 0;
      if (this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked)
        object_0_1 = 1;
      gclass22.method_6("typeNganCachComment", (object) object_0_1);
      int object_0_2 = 0;
      if (this.rbNganCachKyTu.Checked)
        object_0_2 = 1;
      gclass22.method_6("typeNganCach", (object) object_0_2);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDBuffTinNhanProfile.bool_0 = true;
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
          fHDBuffTinNhanProfile.bool_0 = true;
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

  private void method_1(object sender, EventArgs e)
  {
  }

  private void txtNoiDung_TextChanged(object sender, EventArgs e) => this.method_2();

  private void method_2()
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
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Nội dung tin nhắn ({0}):"), (object) stringList2.Count.ToString());
    }
    catch
    {
    }
  }

  private void method_3()
  {
    this.method_4((object) null, (EventArgs) null);
    this.ckbNhanTinVanBan_CheckedChanged((object) null, (EventArgs) null);
    this.ckbTuongTacKhiNhanTin_CheckedChanged((object) null, (EventArgs) null);
    this.ckbTuongTacKhiNhanTinComment_CheckedChanged((object) null, (EventArgs) null);
  }

  private void method_4(object sender, EventArgs e)
  {
  }

  private void ckbNhanTinVanBan_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbNhanTinVanBan.Checked;

  private void txtUid_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>());
      this.lblStatusUid.Text = string.Format(GClass35.smethod_0("Danh sách Uid cá nhân cần nhắn tin ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void ckbSendAnh_CheckedChanged(object sender, EventArgs e) => this.plAnh.Enabled = this.ckbSendAnh.Checked;

  private void method_5(object sender, EventArgs e) => this.txtAnh.Text = GClass19.smethod_45();

  private void btnDown_Click(object sender, EventArgs e) => this.plComment.Height = 235;

  private void btnUp_Click(object sender, EventArgs e) => this.plComment.Height = 185;

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => this.method_2();

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => this.method_2();

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.btnUp.Visible = true;
    this.btnDown.Visible = true;
  }

  private void ckbTuongTacKhiNhanTin_CheckedChanged(object sender, EventArgs e) => this.plTuongTacTruocKhiNhanTin.Enabled = this.ckbTuongTacKhiNhanTin.Checked;

  private void ckbTuongTacKhiNhanTinComment_CheckedChanged(object sender, EventArgs e) => this.plTuongTacTruocKhiNhanTinComment.Enabled = this.ckbTuongTacKhiNhanTinComment.Checked;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDBuffTinNhanProfile));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plTuongTacTruocKhiNhanTin = new Panel();
    this.rbTuongTacSauKhiNhanTin = new RadioButton();
    this.ckbTuongTacKhiNhanTinComment = new CheckBox();
    this.rbTuongTacTruocKhiNhanTin = new RadioButton();
    this.label15 = new Label();
    this.ckbTuongTacKhiNhanTinLike = new CheckBox();
    this.label16 = new Label();
    this.plTuongTacTruocKhiNhanTinComment = new Panel();
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong = new RadioButton();
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong = new RadioButton();
    this.label12 = new Label();
    this.txtTuongTacKhiNhanTinComment = new RichTextBox();
    this.label13 = new Label();
    this.label14 = new Label();
    this.plComment = new Panel();
    this.btnDown = new MetroButton();
    this.btnUp = new MetroButton();
    this.rbNganCachKyTu = new RadioButton();
    this.rbNganCachMoiDong = new RadioButton();
    this.label11 = new Label();
    this.txtNoiDung = new RichTextBox();
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.plAnh = new Panel();
    this.label10 = new Label();
    this.txtAnh = new TextBox();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label9 = new Label();
    this.nudSoLuongAnhFrom = new NumericUpDown();
    this.nudSoLuongAnhTo = new NumericUpDown();
    this.ckbSendAnh = new CheckBox();
    this.txtUid = new RichTextBox();
    this.label2 = new Label();
    this.lblStatusUid = new Label();
    this.label49 = new Label();
    this.nudSoLuongUidFrom = new NumericUpDown();
    this.label68 = new Label();
    this.nudSoLuongUidTo = new NumericUpDown();
    this.label66 = new Label();
    this.ckbTuongTacKhiNhanTin = new CheckBox();
    this.ckbNhanTinVanBan = new CheckBox();
    this.ckbTuDongXoaUid = new CheckBox();
    this.nudDelayTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.txtTenHanhDong = new TextBox();
    this.label7 = new Label();
    this.label6 = new Label();
    this.label5 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.toolTip_0 = new ToolTip(this.components);
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plTuongTacTruocKhiNhanTin.SuspendLayout();
    this.plTuongTacTruocKhiNhanTinComment.SuspendLayout();
    this.plComment.SuspendLayout();
    this.plAnh.SuspendLayout();
    this.nudSoLuongAnhFrom.BeginInit();
    this.nudSoLuongAnhTo.BeginInit();
    this.nudSoLuongUidFrom.BeginInit();
    this.nudSoLuongUidTo.BeginInit();
    this.nudDelayTo.BeginInit();
    this.nudDelayFrom.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(1009, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Buff Tin nhắn Profile";
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
    this.pnlHeader.Size = new Size(1009, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(978, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plTuongTacTruocKhiNhanTin);
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.plAnh);
    this.panel1.Controls.Add((Control) this.ckbSendAnh);
    this.panel1.Controls.Add((Control) this.txtUid);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.lblStatusUid);
    this.panel1.Controls.Add((Control) this.label49);
    this.panel1.Controls.Add((Control) this.nudSoLuongUidFrom);
    this.panel1.Controls.Add((Control) this.label68);
    this.panel1.Controls.Add((Control) this.nudSoLuongUidTo);
    this.panel1.Controls.Add((Control) this.label66);
    this.panel1.Controls.Add((Control) this.ckbTuongTacKhiNhanTin);
    this.panel1.Controls.Add((Control) this.ckbNhanTinVanBan);
    this.panel1.Controls.Add((Control) this.ckbTuDongXoaUid);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(1012, 416);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plTuongTacTruocKhiNhanTin.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTacTruocKhiNhanTin.Controls.Add((Control) this.rbTuongTacSauKhiNhanTin);
    this.plTuongTacTruocKhiNhanTin.Controls.Add((Control) this.ckbTuongTacKhiNhanTinComment);
    this.plTuongTacTruocKhiNhanTin.Controls.Add((Control) this.rbTuongTacTruocKhiNhanTin);
    this.plTuongTacTruocKhiNhanTin.Controls.Add((Control) this.label15);
    this.plTuongTacTruocKhiNhanTin.Controls.Add((Control) this.ckbTuongTacKhiNhanTinLike);
    this.plTuongTacTruocKhiNhanTin.Controls.Add((Control) this.label16);
    this.plTuongTacTruocKhiNhanTin.Controls.Add((Control) this.plTuongTacTruocKhiNhanTinComment);
    this.plTuongTacTruocKhiNhanTin.Enabled = false;
    this.plTuongTacTruocKhiNhanTin.Location = new Point(688, 75);
    this.plTuongTacTruocKhiNhanTin.Name = "plTuongTacTruocKhiNhanTin";
    this.plTuongTacTruocKhiNhanTin.Size = new Size(297, 272);
    this.plTuongTacTruocKhiNhanTin.TabIndex = 163;
    this.rbTuongTacSauKhiNhanTin.AutoSize = true;
    this.rbTuongTacSauKhiNhanTin.Cursor = Cursors.Hand;
    this.rbTuongTacSauKhiNhanTin.Location = new Point(77, 28);
    this.rbTuongTacSauKhiNhanTin.Name = "rbTuongTacSauKhiNhanTin";
    this.rbTuongTacSauKhiNhanTin.Size = new Size(177, 20);
    this.rbTuongTacSauKhiNhanTin.TabIndex = 105;
    this.rbTuongTacSauKhiNhanTin.Text = "Tương tác sau khi nhắn tin";
    this.rbTuongTacSauKhiNhanTin.UseVisualStyleBackColor = true;
    this.ckbTuongTacKhiNhanTinComment.AutoSize = true;
    this.ckbTuongTacKhiNhanTinComment.Cursor = Cursors.Hand;
    this.ckbTuongTacKhiNhanTinComment.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuongTacKhiNhanTinComment.Location = new Point(161, 52);
    this.ckbTuongTacKhiNhanTinComment.Name = "ckbTuongTacKhiNhanTinComment";
    this.ckbTuongTacKhiNhanTinComment.Size = new Size(81, 20);
    this.ckbTuongTacKhiNhanTinComment.TabIndex = 96;
    this.ckbTuongTacKhiNhanTinComment.Text = "Comment";
    this.ckbTuongTacKhiNhanTinComment.UseVisualStyleBackColor = true;
    this.ckbTuongTacKhiNhanTinComment.CheckedChanged += new EventHandler(this.ckbTuongTacKhiNhanTinComment_CheckedChanged);
    this.rbTuongTacTruocKhiNhanTin.AutoSize = true;
    this.rbTuongTacTruocKhiNhanTin.Checked = true;
    this.rbTuongTacTruocKhiNhanTin.Cursor = Cursors.Hand;
    this.rbTuongTacTruocKhiNhanTin.Location = new Point(77, 6);
    this.rbTuongTacTruocKhiNhanTin.Name = "rbTuongTacTruocKhiNhanTin";
    this.rbTuongTacTruocKhiNhanTin.Size = new Size(187, 20);
    this.rbTuongTacTruocKhiNhanTin.TabIndex = 106;
    this.rbTuongTacTruocKhiNhanTin.TabStop = true;
    this.rbTuongTacTruocKhiNhanTin.Text = "Tương tác trước khi nhắn tin";
    this.rbTuongTacTruocKhiNhanTin.UseVisualStyleBackColor = true;
    this.label15.AutoSize = true;
    this.label15.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label15.Location = new Point(6, 8);
    this.label15.Name = "label15";
    this.label15.Size = new Size(64, 16);
    this.label15.TabIndex = 103;
    this.label15.Text = "Tùy chọn:";
    this.ckbTuongTacKhiNhanTinLike.AutoSize = true;
    this.ckbTuongTacKhiNhanTinLike.Cursor = Cursors.Hand;
    this.ckbTuongTacKhiNhanTinLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuongTacKhiNhanTinLike.Location = new Point(106, 52);
    this.ckbTuongTacKhiNhanTinLike.Name = "ckbTuongTacKhiNhanTinLike";
    this.ckbTuongTacKhiNhanTinLike.Size = new Size(48, 20);
    this.ckbTuongTacKhiNhanTinLike.TabIndex = 95;
    this.ckbTuongTacKhiNhanTinLike.Text = "Like";
    this.ckbTuongTacKhiNhanTinLike.UseVisualStyleBackColor = true;
    this.label16.AutoSize = true;
    this.label16.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label16.Location = new Point(6, 53);
    this.label16.Name = "label16";
    this.label16.Size = new Size(93, 16);
    this.label16.TabIndex = 104;
    this.label16.Text = "Loại tương tác:";
    this.plTuongTacTruocKhiNhanTinComment.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTacTruocKhiNhanTinComment.Controls.Add((Control) this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
    this.plTuongTacTruocKhiNhanTinComment.Controls.Add((Control) this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong);
    this.plTuongTacTruocKhiNhanTinComment.Controls.Add((Control) this.label12);
    this.plTuongTacTruocKhiNhanTinComment.Controls.Add((Control) this.txtTuongTacKhiNhanTinComment);
    this.plTuongTacTruocKhiNhanTinComment.Controls.Add((Control) this.label13);
    this.plTuongTacTruocKhiNhanTinComment.Controls.Add((Control) this.label14);
    this.plTuongTacTruocKhiNhanTinComment.Location = new Point(9, 75);
    this.plTuongTacTruocKhiNhanTinComment.Name = "plTuongTacTruocKhiNhanTinComment";
    this.plTuongTacTruocKhiNhanTinComment.Size = new Size(281, 191);
    this.plTuongTacTruocKhiNhanTinComment.TabIndex = 101;
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.AutoSize = true;
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Cursor = Cursors.Hand;
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Location = new Point(70, 164);
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Name = "ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong";
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Size = new Size(202, 20);
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.TabIndex = 3;
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Text = "Các nội dung ngăn cách bởi \"|\"";
    this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.UseVisualStyleBackColor = true;
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.AutoSize = true;
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Checked = true;
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Cursor = Cursors.Hand;
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Location = new Point(70, 143);
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Name = "ckbTuongTacKhiNhanTinCommentNoiDung1Dong";
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Size = new Size(170, 20);
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.TabIndex = 3;
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.TabStop = true;
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Text = "Mỗi dòng là một nội dung";
    this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.UseVisualStyleBackColor = true;
    this.label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label12.AutoSize = true;
    this.label12.Location = new Point(5, 143);
    this.label12.Name = "label12";
    this.label12.Size = new Size(64, 16);
    this.label12.TabIndex = 2;
    this.label12.Text = "Tùy chọn:";
    this.txtTuongTacKhiNhanTinComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtTuongTacKhiNhanTinComment.Location = new Point(7, 23);
    this.txtTuongTacKhiNhanTinComment.Name = "txtTuongTacKhiNhanTinComment";
    this.txtTuongTacKhiNhanTinComment.Size = new Size(263, 97);
    this.txtTuongTacKhiNhanTinComment.TabIndex = 1;
    this.txtTuongTacKhiNhanTinComment.Text = "";
    this.txtTuongTacKhiNhanTinComment.WordWrap = false;
    this.label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label13.AutoSize = true;
    this.label13.Location = new Point(4, 123);
    this.label13.Name = "label13";
    this.label13.Size = new Size(267, 16);
    this.label13.TabIndex = 0;
    this.label13.Text = "(Spin nội dung {a|b|c} - [u]: Họ tên của UID)";
    this.label14.AutoSize = true;
    this.label14.Location = new Point(3, 3);
    this.label14.Name = "label14";
    this.label14.Size = new Size(118, 16);
    this.label14.TabIndex = 0;
    this.label14.Text = "Nội dung bình luận:";
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.btnDown);
    this.plComment.Controls.Add((Control) this.btnUp);
    this.plComment.Controls.Add((Control) this.rbNganCachKyTu);
    this.plComment.Controls.Add((Control) this.rbNganCachMoiDong);
    this.plComment.Controls.Add((Control) this.label11);
    this.plComment.Controls.Add((Control) this.txtNoiDung);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(369, 75);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(281, 185);
    this.plComment.TabIndex = 10;
    this.btnDown.Cursor = Cursors.Hand;
    this.btnDown.Location = new Point(224, -1);
    this.btnDown.Name = "btnDown";
    this.btnDown.Size = new Size(25, 25);
    this.btnDown.TabIndex = 11;
    this.btnDown.UseSelectable = true;
    this.btnDown.Visible = false;
    this.btnDown.Click += new EventHandler(this.btnDown_Click);
    this.btnUp.Cursor = Cursors.Hand;
    this.btnUp.Location = new Point((int) byte.MaxValue, -1);
    this.btnUp.Name = "btnUp";
    this.btnUp.Size = new Size(25, 25);
    this.btnUp.TabIndex = 12;
    this.btnUp.UseSelectable = true;
    this.btnUp.Visible = false;
    this.btnUp.Click += new EventHandler(this.btnUp_Click);
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(68, 209);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(202, 20);
    this.rbNganCachKyTu.TabIndex = 10;
    this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachKyTu.CheckedChanged += new EventHandler(this.rbNganCachKyTu_CheckedChanged);
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(68, 188);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(170, 20);
    this.rbNganCachMoiDong.TabIndex = 9;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.CheckedChanged += new EventHandler(this.rbNganCachMoiDong_CheckedChanged);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(3, 188);
    this.label11.Name = "label11";
    this.label11.Size = new Size(64, 16);
    this.label11.TabIndex = 8;
    this.label11.Text = "Tùy chọn:";
    this.txtNoiDung.Location = new Point(7, 24);
    this.txtNoiDung.Name = "txtNoiDung";
    this.txtNoiDung.Size = new Size(263, 137);
    this.txtNoiDung.TabIndex = 1;
    this.txtNoiDung.Text = "";
    this.txtNoiDung.WordWrap = false;
    this.txtNoiDung.TextChanged += new EventHandler(this.txtNoiDung_TextChanged);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(4, 163);
    this.label8.Name = "label8";
    this.label8.Size = new Size(265, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Spin nội dung {a|b|c} - [u]: Họ tên của Uid)";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 3);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(133, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung tin nhắn (0):";
    this.plAnh.BorderStyle = BorderStyle.FixedSingle;
    this.plAnh.Controls.Add((Control) this.label10);
    this.plAnh.Controls.Add((Control) this.txtAnh);
    this.plAnh.Controls.Add((Control) this.label3);
    this.plAnh.Controls.Add((Control) this.label4);
    this.plAnh.Controls.Add((Control) this.label9);
    this.plAnh.Controls.Add((Control) this.nudSoLuongAnhFrom);
    this.plAnh.Controls.Add((Control) this.nudSoLuongAnhTo);
    this.plAnh.Enabled = false;
    this.plAnh.Location = new Point(369, 289);
    this.plAnh.Name = "plAnh";
    this.plAnh.Size = new Size(281, 58);
    this.plAnh.TabIndex = 162;
    this.label10.AutoSize = true;
    this.label10.Location = new Point(3, 6);
    this.label10.Name = "label10";
    this.label10.Size = new Size(137, 16);
    this.label10.TabIndex = 159;
    this.label10.Text = "Đường dẫn folder ảnh:";
    this.txtAnh.Location = new Point(143, 3);
    this.txtAnh.Name = "txtAnh";
    this.txtAnh.Size = new Size(133, 23);
    this.txtAnh.TabIndex = 158;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(3, 31);
    this.label3.Name = "label3";
    this.label3.Size = new Size(103, 16);
    this.label3.TabIndex = 34;
    this.label3.Text = "Số ảnh/tin nhắn:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(240, 31);
    this.label4.Name = "label4";
    this.label4.Size = new Size(28, 16);
    this.label4.TabIndex = 36;
    this.label4.Text = "ảnh";
    this.label9.Location = new Point(164, 31);
    this.label9.Name = "label9";
    this.label9.Size = new Size(29, 16);
    this.label9.TabIndex = 38;
    this.label9.Text = "đến";
    this.label9.TextAlign = ContentAlignment.MiddleCenter;
    this.nudSoLuongAnhFrom.Location = new Point(118, 29);
    this.nudSoLuongAnhFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
    this.nudSoLuongAnhFrom.Size = new Size(43, 23);
    this.nudSoLuongAnhFrom.TabIndex = 5;
    this.nudSoLuongAnhTo.Location = new Point(195, 29);
    this.nudSoLuongAnhTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
    this.nudSoLuongAnhTo.Size = new Size(43, 23);
    this.nudSoLuongAnhTo.TabIndex = 6;
    this.ckbSendAnh.AutoSize = true;
    this.ckbSendAnh.Cursor = Cursors.Hand;
    this.ckbSendAnh.Location = new Point(351, 266);
    this.ckbSendAnh.Name = "ckbSendAnh";
    this.ckbSendAnh.Size = new Size(70, 20);
    this.ckbSendAnh.TabIndex = 161;
    this.ckbSendAnh.Text = "Gửi ảnh";
    this.ckbSendAnh.UseVisualStyleBackColor = true;
    this.ckbSendAnh.CheckedChanged += new EventHandler(this.ckbSendAnh_CheckedChanged);
    this.txtUid.BorderStyle = BorderStyle.FixedSingle;
    this.txtUid.Location = new Point(31, 154);
    this.txtUid.Name = "txtUid";
    this.txtUid.Size = new Size(299, 152);
    this.txtUid.TabIndex = 117;
    this.txtUid.Text = "";
    this.txtUid.WordWrap = false;
    this.txtUid.TextChanged += new EventHandler(this.txtUid_TextChanged);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(230, 308);
    this.label2.Name = "label2";
    this.label2.Size = new Size(102, 16);
    this.label2.TabIndex = 115;
    this.label2.Text = "(Mỗi Uid 1 dòng)";
    this.lblStatusUid.AutoSize = true;
    this.lblStatusUid.Location = new Point(28, 135);
    this.lblStatusUid.Name = "lblStatusUid";
    this.lblStatusUid.Size = new Size(237, 16);
    this.lblStatusUid.TabIndex = 116;
    this.lblStatusUid.Text = "Danh sách Uid cá nhân cần nhắn tin (0):";
    this.label49.AutoSize = true;
    this.label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label49.Location = new Point(27, 81);
    this.label49.Name = "label49";
    this.label49.Size = new Size(101, 16);
    this.label49.TabIndex = 92;
    this.label49.Text = "Số lượng Uid(?):";
    this.toolTip_0.SetToolTip((Control) this.label49, "Mỗi tài khoản chỉ nhắn tin được tối đa 50 người tại 1 thời điểm!");
    this.nudSoLuongUidFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongUidFrom.Location = new Point(135, 79);
    this.nudSoLuongUidFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
    this.nudSoLuongUidFrom.Size = new Size(56, 23);
    this.nudSoLuongUidFrom.TabIndex = 1;
    this.nudSoLuongUidFrom.Value = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.label68.AutoSize = true;
    this.label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label68.Location = new Point(290, 81);
    this.label68.Name = "label68";
    this.label68.Size = new Size(25, 16);
    this.label68.TabIndex = 99;
    this.label68.Text = "Uid";
    this.nudSoLuongUidTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongUidTo.Location = new Point(232, 79);
    this.nudSoLuongUidTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
    this.nudSoLuongUidTo.Size = new Size(56, 23);
    this.nudSoLuongUidTo.TabIndex = 2;
    this.nudSoLuongUidTo.Value = new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label66.Location = new Point(197, 81);
    this.label66.Name = "label66";
    this.label66.Size = new Size(29, 16);
    this.label66.TabIndex = 105;
    this.label66.Text = "đến";
    this.label66.TextAlign = ContentAlignment.MiddleCenter;
    this.ckbTuongTacKhiNhanTin.AutoSize = true;
    this.ckbTuongTacKhiNhanTin.Cursor = Cursors.Hand;
    this.ckbTuongTacKhiNhanTin.Location = new Point(670, 51);
    this.ckbTuongTacKhiNhanTin.Name = "ckbTuongTacKhiNhanTin";
    this.ckbTuongTacKhiNhanTin.Size = new Size(154, 20);
    this.ckbTuongTacKhiNhanTin.TabIndex = 9;
    this.ckbTuongTacKhiNhanTin.Text = "Tương tác khi nhắn tin";
    this.ckbTuongTacKhiNhanTin.UseVisualStyleBackColor = true;
    this.ckbTuongTacKhiNhanTin.CheckedChanged += new EventHandler(this.ckbTuongTacKhiNhanTin_CheckedChanged);
    this.ckbNhanTinVanBan.AutoSize = true;
    this.ckbNhanTinVanBan.Cursor = Cursors.Hand;
    this.ckbNhanTinVanBan.Location = new Point(351, 51);
    this.ckbNhanTinVanBan.Name = "ckbNhanTinVanBan";
    this.ckbNhanTinVanBan.Size = new Size(122, 20);
    this.ckbNhanTinVanBan.TabIndex = 9;
    this.ckbNhanTinVanBan.Text = "Nhắn tin văn bản";
    this.ckbNhanTinVanBan.UseVisualStyleBackColor = true;
    this.ckbNhanTinVanBan.CheckedChanged += new EventHandler(this.ckbNhanTinVanBan_CheckedChanged);
    this.ckbTuDongXoaUid.AutoSize = true;
    this.ckbTuDongXoaUid.Cursor = Cursors.Hand;
    this.ckbTuDongXoaUid.Location = new Point(31, 324);
    this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
    this.ckbTuDongXoaUid.Size = new Size(295, 20);
    this.ckbTuDongXoaUid.TabIndex = 8;
    this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã nhắn tin (Không trùng UID)";
    this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
    this.nudDelayTo.Location = new Point(232, 108);
    this.nudDelayTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudDelayTo.Name = "nudDelayTo";
    this.nudDelayTo.Size = new Size(56, 23);
    this.nudDelayTo.TabIndex = 6;
    this.nudDelayFrom.Location = new Point(135, 108);
    this.nudDelayFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudDelayFrom.Name = "nudDelayFrom";
    this.nudDelayFrom.Size = new Size(56, 23);
    this.nudDelayFrom.TabIndex = 5;
    this.txtTenHanhDong.Location = new Point(135, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(195, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label7.Location = new Point(197, 110);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 38;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(290, 110);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 36;
    this.label6.Text = "giây";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 110);
    this.label5.Name = "label5";
    this.label5.Size = new Size(89, 16);
    this.label5.TabIndex = 34;
    this.label5.Text = "Thời gian chờ:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(27, 52);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 16);
    this.label1.TabIndex = 31;
    this.label1.Text = "Tên hành động:";
    this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(513, 367);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 12;
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
    this.btnAdd.Location = new Point(406, 367);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 11;
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
    this.bunifuCards1.Size = new Size(1009, 37);
    this.bunifuCards1.TabIndex = 28;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 20000;
    this.toolTip_0.InitialDelay = 0;
    this.toolTip_0.ReshowDelay = 0;
    this.toolTip_0.ToolTipTitle = "Chú ý";
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1012, 416);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDBuffTinNhanProfile);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDBuffTinNhanProfile_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plTuongTacTruocKhiNhanTin.ResumeLayout(false);
    this.plTuongTacTruocKhiNhanTin.PerformLayout();
    this.plTuongTacTruocKhiNhanTinComment.ResumeLayout(false);
    this.plTuongTacTruocKhiNhanTinComment.PerformLayout();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.plAnh.ResumeLayout(false);
    this.plAnh.PerformLayout();
    this.nudSoLuongAnhFrom.EndInit();
    this.nudSoLuongAnhTo.EndInit();
    this.nudSoLuongUidFrom.EndInit();
    this.nudSoLuongUidTo.EndInit();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
