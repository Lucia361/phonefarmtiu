// Decompiled with JetBrains decompiler
// Type: fHDChiaSeLivestream
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

public class fHDChiaSeLivestream : Form
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
  private BunifuCustomLabel bunifuCustomLabel1;
  private CheckBox ckbVanBan;
  private Panel plVanBan;
  private Label label8;
  private Label lblStatus;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private Label label9;
  private MetroButton btnDown;
  private MetroButton btnUp;
  private Button btnMinimize;
  private GroupBox groupBox1;
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label15;
  private Label label14;
  private Label label13;
  private GroupBox groupBox2;
  private Panel plDangBaiLenNhom;
  private CheckBox ckbChiaSeLenNhom;
  private CheckBox ckbChiaSeLenTuong;
  private NumericUpDown nudCountGroupTo;
  private NumericUpDown nudCountGroupFrom;
  private Label label16;
  private Label label17;
  private Label label18;
  private Label label2;
  private TextBox txtLinkChiaSe;
  private RichTextBox txtNoiDung;
  private Panel plTuongTacLivestream;
  private CheckBox ckbTuongTacLivestream;
  private Panel plComment;
  private Panel plBinhLuanNhieuLan;
  private NumericUpDown nudBinhLuanNhieuLanDelayTo;
  private Label lblmc1;
  private NumericUpDown nudBinhLuanNhieuLanDelayFrom;
  private Label label5;
  private Label label6;
  private CheckBox ckbBinhLuanNhieuLan;
  private Label label3;
  private TextBox txtComment;
  private Label label4;
  private Panel plInteract;
  private Label label25;
  private Label label26;
  private Label label28;
  private Label label29;
  private Label label30;
  private CheckBox ckbGian;
  private CheckBox ckbBuon;
  private CheckBox ckbWow;
  private CheckBox ckbHaha;
  private CheckBox ckbTym;
  private CheckBox ckbLike;
  private Label label32;
  private CheckBox ckbComment;
  private CheckBox ckbInteract;
  private NumericUpDown nudSoLuongTo;
  private NumericUpDown nudSoLuongFrom;
  private Label label10;
  private Label label11;
  private Label label12;
  private Button button3;
  private IContainer components;
  private Button button2;

  public fHDChiaSeLivestream(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDChiaSeLivestream.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDChiaSeLivestream").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDChiaSeLivestream', 'Chia sẻ livestream');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDChiaSeLivestream");
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

  private void fHDChiaSeLivestream_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom", 3);
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo", 5);
      this.ckbChiaSeLenTuong.Checked = this.gclass22_0.method_4("ckbChiaSeLenTuong");
      this.ckbChiaSeLenNhom.Checked = this.gclass22_0.method_4("ckbChiaSeLenNhom");
      this.nudCountGroupFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountGroupFrom", 1);
      this.nudCountGroupTo.Value = (Decimal) this.gclass22_0.method_3("nudCountGroupTo", 3);
      this.ckbVanBan.Checked = this.gclass22_0.method_4("ckbVanBan");
      this.txtNoiDung.Text = this.gclass22_0.method_1("txtNoiDung");
      if (this.gclass22_0.method_3("typeNganCach") == 1)
        this.rbNganCachKyTu.Checked = true;
      else
        this.rbNganCachMoiDong.Checked = true;
      this.txtLinkChiaSe.Text = this.gclass22_0.method_1("txtLinkChiaSe");
      this.ckbTuongTacLivestream.Checked = this.gclass22_0.method_4("ckbTuongTacLivestream");
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom", 30);
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo", 30);
      this.ckbInteract.Checked = this.gclass22_0.method_4("ckbInteract");
      string str = this.gclass22_0.method_1("typeReaction");
      List<CheckBox> checkBoxList = new List<CheckBox>()
      {
        this.ckbLike,
        this.ckbTym,
        this.ckbHaha,
        this.ckbWow,
        this.ckbBuon,
        this.ckbGian
      };
      for (int index = 0; index < checkBoxList.Count; ++index)
      {
        if (str.Contains(index.ToString()))
          checkBoxList[index].Checked = true;
      }
      this.ckbComment.Checked = this.gclass22_0.method_4("ckbComment");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
      this.ckbBinhLuanNhieuLan.Checked = this.gclass22_0.method_4("ckbBinhLuanNhieuLan");
      this.nudBinhLuanNhieuLanDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudBinhLuanNhieuLanDelayFrom", 10);
      this.nudBinhLuanNhieuLanDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudBinhLuanNhieuLanDelayTo", 10);
    }
    catch
    {
    }
    this.method_0();
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

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
      gclass22.method_6("ckbChiaSeLenTuong", (object) this.ckbChiaSeLenTuong.Checked);
      gclass22.method_6("ckbChiaSeLenNhom", (object) this.ckbChiaSeLenNhom.Checked);
      gclass22.method_6("nudCountGroupFrom", (object) this.nudCountGroupFrom.Value);
      gclass22.method_6("nudCountGroupTo", (object) this.nudCountGroupTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("txtLinkChiaSe", (object) this.txtLinkChiaSe.Text.Trim());
      gclass22.method_6("ckbVanBan", (object) this.ckbVanBan.Checked);
      gclass22.method_6("txtNoiDung", (object) this.txtNoiDung.Text.Trim());
      int object_0_1 = 0;
      if (this.rbNganCachKyTu.Checked)
        object_0_1 = 1;
      gclass22.method_6("typeNganCach", (object) object_0_1);
      gclass22.method_6("ckbTuongTacLivestream", (object) this.ckbTuongTacLivestream.Checked);
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
      string object_0_2 = "";
      List<CheckBox> checkBoxList = new List<CheckBox>()
      {
        this.ckbLike,
        this.ckbTym,
        this.ckbHaha,
        this.ckbWow,
        this.ckbBuon,
        this.ckbGian
      };
      for (int index = 0; index < checkBoxList.Count; ++index)
      {
        if (checkBoxList[index].Checked)
          object_0_2 += index.ToString();
      }
      gclass22.method_6("typeReaction", (object) object_0_2);
      gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      gclass22.method_6("ckbBinhLuanNhieuLan", (object) this.ckbBinhLuanNhieuLan.Checked);
      gclass22.method_6("nudBinhLuanNhieuLanDelayFrom", (object) this.nudBinhLuanNhieuLanDelayFrom.Value);
      gclass22.method_6("nudBinhLuanNhieuLanDelayTo", (object) this.nudBinhLuanNhieuLanDelayTo.Value);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (MessageBox.Show(GClass35.smethod_0("Bạn có muốn thêm hành động mới?"), GClass35.smethod_0("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDChiaSeLivestream.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Thêm thất bại, vui lòng thử lại sau!"), 2);
      }
      else
      {
        if (MessageBox.Show(GClass35.smethod_0("Bạn có muốn cập nhật hành động?"), GClass35.smethod_0("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        if (Class205.smethod_21(this.string_2, string_1, str))
        {
          fHDChiaSeLivestream.bool_0 = true;
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
    this.ckbChiaSeLenNhom_CheckedChanged((object) null, (EventArgs) null);
    this.ckbTuongTacLivestream_CheckedChanged((object) null, (EventArgs) null);
    this.ckbInteract_CheckedChanged((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
    this.ckbBinhLuanNhieuLan_CheckedChanged((object) null, (EventArgs) null);
  }

  private void ckbVanBan_CheckedChanged(object sender, EventArgs e) => this.plVanBan.Enabled = this.ckbVanBan.Checked;

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
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.btnUp.Visible = true;
    this.btnDown.Visible = true;
  }

  private void btnDown_Click(object sender, EventArgs e) => this.groupBox1.Height = 290;

  private void btnUp_Click(object sender, EventArgs e) => this.groupBox1.Height = 246;

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => this.method_1();

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => this.method_1();

  private void ckbChiaSeLenNhom_CheckedChanged(object sender, EventArgs e) => this.plDangBaiLenNhom.Enabled = this.ckbChiaSeLenNhom.Checked;

  private void ckbTuongTacLivestream_CheckedChanged(object sender, EventArgs e) => this.plTuongTacLivestream.Enabled = this.ckbTuongTacLivestream.Checked;

  private void ckbInteract_CheckedChanged(object sender, EventArgs e) => this.plInteract.Enabled = this.ckbInteract.Checked;

  private void ckbComment_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbComment.Checked;

  private void ckbBinhLuanNhieuLan_CheckedChanged(object sender, EventArgs e) => this.plBinhLuanNhieuLan.Enabled = this.ckbBinhLuanNhieuLan.Checked;

  private void txtComment_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList1 = new List<string>();
      List<string> list;
      if (this.rbNganCachMoiDong.Checked)
        list = ((IEnumerable<string>) this.txtComment.Lines).ToList<string>();
      else
        list = ((IEnumerable<string>) this.txtComment.Text.Split(new string[1]
        {
          "\n|\n"
        }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();
      List<string> stringList2 = GClass19.smethod_39(list);
      this.label4.Text = string.Format(GClass35.smethod_0("Nội dung bình luận ({0}):"), (object) stringList2.Count.ToString());
    }
    catch
    {
    }
  }

  private void button2_Click(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));

  private void button3_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fHelpNhapComment());

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.panel1 = new Panel();
    this.plTuongTacLivestream = new Panel();
    this.plComment = new Panel();
    this.plBinhLuanNhieuLan = new Panel();
    this.nudBinhLuanNhieuLanDelayTo = new NumericUpDown();
    this.lblmc1 = new Label();
    this.nudBinhLuanNhieuLanDelayFrom = new NumericUpDown();
    this.label5 = new Label();
    this.label6 = new Label();
    this.ckbBinhLuanNhieuLan = new CheckBox();
    this.label3 = new Label();
    this.txtComment = new TextBox();
    this.label4 = new Label();
    this.plInteract = new Panel();
    this.label25 = new Label();
    this.label26 = new Label();
    this.label28 = new Label();
    this.label29 = new Label();
    this.label30 = new Label();
    this.ckbGian = new CheckBox();
    this.ckbBuon = new CheckBox();
    this.ckbWow = new CheckBox();
    this.ckbHaha = new CheckBox();
    this.ckbTym = new CheckBox();
    this.ckbLike = new CheckBox();
    this.label32 = new Label();
    this.ckbComment = new CheckBox();
    this.ckbInteract = new CheckBox();
    this.nudSoLuongTo = new NumericUpDown();
    this.nudSoLuongFrom = new NumericUpDown();
    this.label10 = new Label();
    this.label11 = new Label();
    this.label12 = new Label();
    this.groupBox2 = new GroupBox();
    this.plDangBaiLenNhom = new Panel();
    this.nudCountGroupTo = new NumericUpDown();
    this.nudCountGroupFrom = new NumericUpDown();
    this.label16 = new Label();
    this.label17 = new Label();
    this.label18 = new Label();
    this.ckbChiaSeLenNhom = new CheckBox();
    this.ckbChiaSeLenTuong = new CheckBox();
    this.nudDelayTo = new NumericUpDown();
    this.ckbTuongTacLivestream = new CheckBox();
    this.nudDelayFrom = new NumericUpDown();
    this.label15 = new Label();
    this.label14 = new Label();
    this.label13 = new Label();
    this.groupBox1 = new GroupBox();
    this.ckbVanBan = new CheckBox();
    this.plVanBan = new Panel();
    this.button3 = new Button();
    this.button2 = new Button();
    this.btnDown = new MetroButton();
    this.btnUp = new MetroButton();
    this.rbNganCachKyTu = new RadioButton();
    this.rbNganCachMoiDong = new RadioButton();
    this.label9 = new Label();
    this.txtNoiDung = new RichTextBox();
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.label2 = new Label();
    this.txtLinkChiaSe = new TextBox();
    this.btnAdd = new Button();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plTuongTacLivestream.SuspendLayout();
    this.plComment.SuspendLayout();
    this.plBinhLuanNhieuLan.SuspendLayout();
    this.nudBinhLuanNhieuLanDelayTo.BeginInit();
    this.nudBinhLuanNhieuLanDelayFrom.BeginInit();
    this.plInteract.SuspendLayout();
    this.nudSoLuongTo.BeginInit();
    this.nudSoLuongFrom.BeginInit();
    this.groupBox2.SuspendLayout();
    this.plDangBaiLenNhom.SuspendLayout();
    this.nudCountGroupTo.BeginInit();
    this.nudCountGroupFrom.BeginInit();
    this.nudDelayTo.BeginInit();
    this.nudDelayFrom.BeginInit();
    this.groupBox1.SuspendLayout();
    this.plVanBan.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(875, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Chia sẻ livestream";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(875, 31);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) Resources.btnMinimize_Image;
    this.btnMinimize.Location = new Point(842, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 79;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plTuongTacLivestream);
    this.panel1.Controls.Add((Control) this.groupBox2);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.ckbTuongTacLivestream);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.label15);
    this.panel1.Controls.Add((Control) this.label14);
    this.panel1.Controls.Add((Control) this.label13);
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(878, 501);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plTuongTacLivestream.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTacLivestream.Controls.Add((Control) this.plComment);
    this.plTuongTacLivestream.Controls.Add((Control) this.plInteract);
    this.plTuongTacLivestream.Controls.Add((Control) this.ckbComment);
    this.plTuongTacLivestream.Controls.Add((Control) this.ckbInteract);
    this.plTuongTacLivestream.Controls.Add((Control) this.nudSoLuongTo);
    this.plTuongTacLivestream.Controls.Add((Control) this.nudSoLuongFrom);
    this.plTuongTacLivestream.Controls.Add((Control) this.label10);
    this.plTuongTacLivestream.Controls.Add((Control) this.label11);
    this.plTuongTacLivestream.Controls.Add((Control) this.label12);
    this.plTuongTacLivestream.Location = new Point(530, 89);
    this.plTuongTacLivestream.Name = "plTuongTacLivestream";
    this.plTuongTacLivestream.Size = new Size(315, 351);
    this.plTuongTacLivestream.TabIndex = 53;
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.plBinhLuanNhieuLan);
    this.plComment.Controls.Add((Control) this.ckbBinhLuanNhieuLan);
    this.plComment.Controls.Add((Control) this.label3);
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.label4);
    this.plComment.Location = new Point(25, 128);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(278, 213);
    this.plComment.TabIndex = 43;
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.nudBinhLuanNhieuLanDelayTo);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.lblmc1);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.nudBinhLuanNhieuLanDelayFrom);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.label5);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.label6);
    this.plBinhLuanNhieuLan.Location = new Point(19, 182);
    this.plBinhLuanNhieuLan.Name = "plBinhLuanNhieuLan";
    this.plBinhLuanNhieuLan.Size = new Size(254, 27);
    this.plBinhLuanNhieuLan.TabIndex = 134;
    this.nudBinhLuanNhieuLanDelayTo.Cursor = Cursors.Hand;
    this.nudBinhLuanNhieuLanDelayTo.Location = new Point(174, 2);
    this.nudBinhLuanNhieuLanDelayTo.Maximum = new Decimal(new int[4]
    {
      100000000,
      0,
      0,
      0
    });
    this.nudBinhLuanNhieuLanDelayTo.Name = "nudBinhLuanNhieuLanDelayTo";
    this.nudBinhLuanNhieuLanDelayTo.Size = new Size(50, 23);
    this.nudBinhLuanNhieuLanDelayTo.TabIndex = 22;
    this.lblmc1.AutoSize = true;
    this.lblmc1.Location = new Point(4, 4);
    this.lblmc1.Name = "lblmc1";
    this.lblmc1.Size = new Size(72, 16);
    this.lblmc1.TabIndex = 18;
    this.lblmc1.Text = "Delay time:";
    this.nudBinhLuanNhieuLanDelayFrom.Cursor = Cursors.Hand;
    this.nudBinhLuanNhieuLanDelayFrom.Location = new Point(86, 2);
    this.nudBinhLuanNhieuLanDelayFrom.Maximum = new Decimal(new int[4]
    {
      100000000,
      0,
      0,
      0
    });
    this.nudBinhLuanNhieuLanDelayFrom.Name = "nudBinhLuanNhieuLanDelayFrom";
    this.nudBinhLuanNhieuLanDelayFrom.Size = new Size(45, 23);
    this.nudBinhLuanNhieuLanDelayFrom.TabIndex = 21;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(226, 4);
    this.label5.Name = "label5";
    this.label5.Size = new Size(30, 16);
    this.label5.TabIndex = 20;
    this.label5.Text = "giây";
    this.label6.Location = new Point(133, 4);
    this.label6.Name = "label6";
    this.label6.Size = new Size(39, 16);
    this.label6.TabIndex = 20;
    this.label6.Text = "đến";
    this.label6.TextAlign = ContentAlignment.MiddleCenter;
    this.ckbBinhLuanNhieuLan.AutoSize = true;
    this.ckbBinhLuanNhieuLan.Cursor = Cursors.Hand;
    this.ckbBinhLuanNhieuLan.Location = new Point(7, 163);
    this.ckbBinhLuanNhieuLan.Name = "ckbBinhLuanNhieuLan";
    this.ckbBinhLuanNhieuLan.Size = new Size(134, 20);
    this.ckbBinhLuanNhieuLan.TabIndex = 133;
    this.ckbBinhLuanNhieuLan.Text = "Bình luận nhiều lần";
    this.ckbBinhLuanNhieuLan.UseVisualStyleBackColor = true;
    this.ckbBinhLuanNhieuLan.CheckedChanged += new EventHandler(this.ckbBinhLuanNhieuLan_CheckedChanged);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(3, 141);
    this.label3.Name = "label3";
    this.label3.Size = new Size(265, 16);
    this.label3.TabIndex = 2;
    this.label3.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
    this.txtComment.Location = new Point(7, 27);
    this.txtComment.Multiline = true;
    this.txtComment.Name = "txtComment";
    this.txtComment.ScrollBars = ScrollBars.Both;
    this.txtComment.Size = new Size(261, 111);
    this.txtComment.TabIndex = 1;
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.label4.AutoSize = true;
    this.label4.Location = new Point(3, 5);
    this.label4.Name = "label4";
    this.label4.Size = new Size(139, 16);
    this.label4.TabIndex = 0;
    this.label4.Text = "Nội dung bình luận (0):";
    this.plInteract.BorderStyle = BorderStyle.FixedSingle;
    this.plInteract.Controls.Add((Control) this.label25);
    this.plInteract.Controls.Add((Control) this.label26);
    this.plInteract.Controls.Add((Control) this.label28);
    this.plInteract.Controls.Add((Control) this.label29);
    this.plInteract.Controls.Add((Control) this.label30);
    this.plInteract.Controls.Add((Control) this.ckbGian);
    this.plInteract.Controls.Add((Control) this.ckbBuon);
    this.plInteract.Controls.Add((Control) this.ckbWow);
    this.plInteract.Controls.Add((Control) this.ckbHaha);
    this.plInteract.Controls.Add((Control) this.ckbTym);
    this.plInteract.Controls.Add((Control) this.ckbLike);
    this.plInteract.Controls.Add((Control) this.label32);
    this.plInteract.Location = new Point(25, 59);
    this.plInteract.Name = "plInteract";
    this.plInteract.Size = new Size(278, 40);
    this.plInteract.TabIndex = 41;
    this.label25.Cursor = Cursors.Hand;
    this.label25.Location = new Point(4, 1);
    this.label25.Name = "label25";
    this.label25.Size = new Size(30, 16);
    this.label25.TabIndex = 0;
    this.label25.Text = "Like";
    this.label25.TextAlign = ContentAlignment.MiddleCenter;
    this.label26.Cursor = Cursors.Hand;
    this.label26.Location = new Point(46, 1);
    this.label26.Name = "label26";
    this.label26.Size = new Size(39, 16);
    this.label26.TabIndex = 2;
    this.label26.Text = "Tym";
    this.label26.TextAlign = ContentAlignment.MiddleCenter;
    this.label28.Cursor = Cursors.Hand;
    this.label28.Location = new Point(93, 1);
    this.label28.Name = "label28";
    this.label28.Size = new Size(37, 16);
    this.label28.TabIndex = 6;
    this.label28.Text = "Haha";
    this.label28.TextAlign = ContentAlignment.MiddleCenter;
    this.label29.Cursor = Cursors.Hand;
    this.label29.Location = new Point(140, 1);
    this.label29.Name = "label29";
    this.label29.Size = new Size(37, 16);
    this.label29.TabIndex = 8;
    this.label29.Text = "Wow";
    this.label29.TextAlign = ContentAlignment.MiddleCenter;
    this.label30.Cursor = Cursors.Hand;
    this.label30.Location = new Point(187, 1);
    this.label30.Name = "label30";
    this.label30.Size = new Size(36, 16);
    this.label30.TabIndex = 10;
    this.label30.Text = "Buồn";
    this.label30.TextAlign = ContentAlignment.MiddleCenter;
    this.ckbGian.AutoSize = true;
    this.ckbGian.Cursor = Cursors.Hand;
    this.ckbGian.Location = new Point(246, 20);
    this.ckbGian.Name = "ckbGian";
    this.ckbGian.Size = new Size(15, 14);
    this.ckbGian.TabIndex = 13;
    this.ckbGian.UseVisualStyleBackColor = true;
    this.ckbBuon.AutoSize = true;
    this.ckbBuon.Cursor = Cursors.Hand;
    this.ckbBuon.Location = new Point(199, 20);
    this.ckbBuon.Name = "ckbBuon";
    this.ckbBuon.Size = new Size(15, 14);
    this.ckbBuon.TabIndex = 11;
    this.ckbBuon.UseVisualStyleBackColor = true;
    this.ckbWow.AutoSize = true;
    this.ckbWow.Cursor = Cursors.Hand;
    this.ckbWow.Location = new Point(152, 20);
    this.ckbWow.Name = "ckbWow";
    this.ckbWow.Size = new Size(15, 14);
    this.ckbWow.TabIndex = 9;
    this.ckbWow.UseVisualStyleBackColor = true;
    this.ckbHaha.AutoSize = true;
    this.ckbHaha.Cursor = Cursors.Hand;
    this.ckbHaha.Location = new Point(105, 20);
    this.ckbHaha.Name = "ckbHaha";
    this.ckbHaha.Size = new Size(15, 14);
    this.ckbHaha.TabIndex = 7;
    this.ckbHaha.UseVisualStyleBackColor = true;
    this.ckbTym.AutoSize = true;
    this.ckbTym.Cursor = Cursors.Hand;
    this.ckbTym.Location = new Point(58, 20);
    this.ckbTym.Name = "ckbTym";
    this.ckbTym.Size = new Size(15, 14);
    this.ckbTym.TabIndex = 3;
    this.ckbTym.UseVisualStyleBackColor = true;
    this.ckbLike.AutoSize = true;
    this.ckbLike.Cursor = Cursors.Hand;
    this.ckbLike.Location = new Point(11, 20);
    this.ckbLike.Name = "ckbLike";
    this.ckbLike.Size = new Size(15, 14);
    this.ckbLike.TabIndex = 1;
    this.ckbLike.UseVisualStyleBackColor = true;
    this.label32.Cursor = Cursors.Hand;
    this.label32.Location = new Point(230, 1);
    this.label32.Name = "label32";
    this.label32.Size = new Size(44, 16);
    this.label32.TabIndex = 12;
    this.label32.Text = "Giận";
    this.label32.TextAlign = ContentAlignment.MiddleCenter;
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(7, 103);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size(130, 20);
    this.ckbComment.TabIndex = 42;
    this.ckbComment.Text = "Tự động bình luận";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(7, 35);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(112, 20);
    this.ckbInteract.TabIndex = 40;
    this.ckbInteract.Text = "Bày tỏ cảm xúc";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.nudSoLuongTo.Location = new Point(206, 6);
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
    this.nudSoLuongFrom.Location = new Point(109, 6);
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
    this.label10.Location = new Point(171, 8);
    this.label10.Name = "label10";
    this.label10.Size = new Size(29, 16);
    this.label10.TabIndex = 46;
    this.label10.Text = "đến";
    this.label10.TextAlign = ContentAlignment.MiddleCenter;
    this.label11.AutoSize = true;
    this.label11.Location = new Point(267, 8);
    this.label11.Name = "label11";
    this.label11.Size = new Size(30, 16);
    this.label11.TabIndex = 45;
    this.label11.Text = "giây";
    this.label12.AutoSize = true;
    this.label12.Location = new Point(4, 8);
    this.label12.Name = "label12";
    this.label12.Size = new Size(93, 16);
    this.label12.TabIndex = 44;
    this.label12.Text = "Thời gian xem:";
    this.groupBox2.Controls.Add((Control) this.plDangBaiLenNhom);
    this.groupBox2.Controls.Add((Control) this.ckbChiaSeLenNhom);
    this.groupBox2.Controls.Add((Control) this.ckbChiaSeLenTuong);
    this.groupBox2.Location = new Point(30, 107);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(475, 81);
    this.groupBox2.TabIndex = 52;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Tùy chọn chia sẻ";
    this.plDangBaiLenNhom.BorderStyle = BorderStyle.FixedSingle;
    this.plDangBaiLenNhom.Controls.Add((Control) this.nudCountGroupTo);
    this.plDangBaiLenNhom.Controls.Add((Control) this.nudCountGroupFrom);
    this.plDangBaiLenNhom.Controls.Add((Control) this.label16);
    this.plDangBaiLenNhom.Controls.Add((Control) this.label17);
    this.plDangBaiLenNhom.Controls.Add((Control) this.label18);
    this.plDangBaiLenNhom.Location = new Point(157, 47);
    this.plDangBaiLenNhom.Name = "plDangBaiLenNhom";
    this.plDangBaiLenNhom.Size = new Size(310, 27);
    this.plDangBaiLenNhom.TabIndex = 1;
    this.nudCountGroupTo.Location = new Point(205, 1);
    this.nudCountGroupTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountGroupTo.Name = "nudCountGroupTo";
    this.nudCountGroupTo.Size = new Size(56, 23);
    this.nudCountGroupTo.TabIndex = 53;
    this.nudCountGroupFrom.Location = new Point(108, 1);
    this.nudCountGroupFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountGroupFrom.Name = "nudCountGroupFrom";
    this.nudCountGroupFrom.Size = new Size(56, 23);
    this.nudCountGroupFrom.TabIndex = 52;
    this.label16.Location = new Point(170, 3);
    this.label16.Name = "label16";
    this.label16.Size = new Size(29, 16);
    this.label16.TabIndex = 56;
    this.label16.Text = "đến";
    this.label16.TextAlign = ContentAlignment.MiddleCenter;
    this.label17.AutoSize = true;
    this.label17.Location = new Point(264, 3);
    this.label17.Name = "label17";
    this.label17.Size = new Size(39, 16);
    this.label17.TabIndex = 55;
    this.label17.Text = "nhóm";
    this.label18.AutoSize = true;
    this.label18.Location = new Point(3, 3);
    this.label18.Name = "label18";
    this.label18.Size = new Size(99, 16);
    this.label18.TabIndex = 54;
    this.label18.Text = "Số lượng nhóm:";
    this.ckbChiaSeLenNhom.AutoSize = true;
    this.ckbChiaSeLenNhom.Cursor = Cursors.Hand;
    this.ckbChiaSeLenNhom.Location = new Point(11, 49);
    this.ckbChiaSeLenNhom.Name = "ckbChiaSeLenNhom";
    this.ckbChiaSeLenNhom.Size = new Size(125, 20);
    this.ckbChiaSeLenNhom.TabIndex = 0;
    this.ckbChiaSeLenNhom.Text = "Chia sẻ lên nhóm";
    this.ckbChiaSeLenNhom.UseVisualStyleBackColor = true;
    this.ckbChiaSeLenNhom.CheckedChanged += new EventHandler(this.ckbChiaSeLenNhom_CheckedChanged);
    this.ckbChiaSeLenTuong.AutoSize = true;
    this.ckbChiaSeLenTuong.Cursor = Cursors.Hand;
    this.ckbChiaSeLenTuong.Location = new Point(11, 23);
    this.ckbChiaSeLenTuong.Name = "ckbChiaSeLenTuong";
    this.ckbChiaSeLenTuong.Size = new Size(126, 20);
    this.ckbChiaSeLenTuong.TabIndex = 0;
    this.ckbChiaSeLenTuong.Text = "Chia sẻ lên tường";
    this.ckbChiaSeLenTuong.UseVisualStyleBackColor = true;
    this.nudDelayTo.Location = new Point(220, 78);
    this.nudDelayTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayTo.Name = "nudDelayTo";
    this.nudDelayTo.Size = new Size(56, 23);
    this.nudDelayTo.TabIndex = 48;
    this.ckbTuongTacLivestream.AutoSize = true;
    this.ckbTuongTacLivestream.Cursor = Cursors.Hand;
    this.ckbTuongTacLivestream.Location = new Point(530, 66);
    this.ckbTuongTacLivestream.Name = "ckbTuongTacLivestream";
    this.ckbTuongTacLivestream.Size = new Size(237, 20);
    this.ckbTuongTacLivestream.TabIndex = 0;
    this.ckbTuongTacLivestream.Text = "Tương tác livestream trước khi share";
    this.ckbTuongTacLivestream.UseVisualStyleBackColor = true;
    this.ckbTuongTacLivestream.CheckedChanged += new EventHandler(this.ckbTuongTacLivestream_CheckedChanged);
    this.nudDelayFrom.Location = new Point(123, 78);
    this.nudDelayFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayFrom.Name = "nudDelayFrom";
    this.nudDelayFrom.Size = new Size(56, 23);
    this.nudDelayFrom.TabIndex = 47;
    this.label15.Location = new Point(185, 80);
    this.label15.Name = "label15";
    this.label15.Size = new Size(29, 16);
    this.label15.TabIndex = 51;
    this.label15.Text = "đến";
    this.label15.TextAlign = ContentAlignment.MiddleCenter;
    this.label14.AutoSize = true;
    this.label14.Location = new Point(279, 80);
    this.label14.Name = "label14";
    this.label14.Size = new Size(30, 16);
    this.label14.TabIndex = 50;
    this.label14.Text = "giây";
    this.label13.AutoSize = true;
    this.label13.Location = new Point(27, 80);
    this.label13.Name = "label13";
    this.label13.Size = new Size(89, 16);
    this.label13.TabIndex = 49;
    this.label13.Text = "Thời gian chờ:";
    this.groupBox1.Controls.Add((Control) this.ckbVanBan);
    this.groupBox1.Controls.Add((Control) this.plVanBan);
    this.groupBox1.Controls.Add((Control) this.label2);
    this.groupBox1.Controls.Add((Control) this.txtLinkChiaSe);
    this.groupBox1.Location = new Point(30, 194);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(475, 246);
    this.groupBox1.TabIndex = 34;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Cấu hình nội dung chia sẻ";
    this.ckbVanBan.AutoSize = true;
    this.ckbVanBan.Cursor = Cursors.Hand;
    this.ckbVanBan.Location = new Point(11, 50);
    this.ckbVanBan.Name = "ckbVanBan";
    this.ckbVanBan.Size = new Size(120, 20);
    this.ckbVanBan.TabIndex = 32;
    this.ckbVanBan.Text = "Nội dung chia sẻ";
    this.ckbVanBan.UseVisualStyleBackColor = true;
    this.ckbVanBan.CheckedChanged += new EventHandler(this.ckbVanBan_CheckedChanged);
    this.plVanBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.plVanBan.BorderStyle = BorderStyle.FixedSingle;
    this.plVanBan.Controls.Add((Control) this.button3);
    this.plVanBan.Controls.Add((Control) this.button2);
    this.plVanBan.Controls.Add((Control) this.btnDown);
    this.plVanBan.Controls.Add((Control) this.btnUp);
    this.plVanBan.Controls.Add((Control) this.rbNganCachKyTu);
    this.plVanBan.Controls.Add((Control) this.rbNganCachMoiDong);
    this.plVanBan.Controls.Add((Control) this.label9);
    this.plVanBan.Controls.Add((Control) this.txtNoiDung);
    this.plVanBan.Controls.Add((Control) this.label8);
    this.plVanBan.Controls.Add((Control) this.lblStatus);
    this.plVanBan.Location = new Point(28, 74);
    this.plVanBan.Name = "plVanBan";
    this.plVanBan.Size = new Size(439, 163);
    this.plVanBan.TabIndex = 33;
    this.button3.Cursor = Cursors.Help;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.Location = new Point(223, 185);
    this.button3.Name = "button3";
    this.button3.Size = new Size(21, 23);
    this.button3.TabIndex = 195;
    this.button3.Text = "?";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button2.Cursor = Cursors.Help;
    this.button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button2.Location = new Point(223, 162);
    this.button2.Name = "button2";
    this.button2.Size = new Size(21, 23);
    this.button2.TabIndex = 196;
    this.button2.Text = "?";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.btnDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnDown.Cursor = Cursors.Hand;
    this.btnDown.Location = new Point(382, -1);
    this.btnDown.Name = "btnDown";
    this.btnDown.Size = new Size(25, 25);
    this.btnDown.TabIndex = 38;
    this.btnDown.UseSelectable = true;
    this.btnDown.Visible = false;
    this.btnDown.Click += new EventHandler(this.btnDown_Click);
    this.btnUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnUp.Cursor = Cursors.Hand;
    this.btnUp.Location = new Point(413, -1);
    this.btnUp.Name = "btnUp";
    this.btnUp.Size = new Size(25, 25);
    this.btnUp.TabIndex = 39;
    this.btnUp.UseSelectable = true;
    this.btnUp.Visible = false;
    this.btnUp.Click += new EventHandler(this.btnUp_Click);
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(69, 183);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(159, 20);
    this.rbNganCachKyTu.TabIndex = 37;
    this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachKyTu.CheckedChanged += new EventHandler(this.rbNganCachKyTu_CheckedChanged);
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(69, 162);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(155, 20);
    this.rbNganCachMoiDong.TabIndex = 36;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.CheckedChanged += new EventHandler(this.rbNganCachMoiDong_CheckedChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(4, 162);
    this.label9.Name = "label9";
    this.label9.Size = new Size(64, 16);
    this.label9.TabIndex = 35;
    this.label9.Text = "Tùy chọn:";
    this.txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtNoiDung.Location = new Point(7, 24);
    this.txtNoiDung.Name = "txtNoiDung";
    this.txtNoiDung.Size = new Size(424, 114);
    this.txtNoiDung.TabIndex = 34;
    this.txtNoiDung.Text = "";
    this.txtNoiDung.WordWrap = false;
    this.txtNoiDung.TextChanged += new EventHandler(this.txtNoiDung_TextChanged);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(4, 141);
    this.label8.Name = "label8";
    this.label8.Size = new Size(265, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(145, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Danh sách nội dung (0):";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(8, 26);
    this.label2.Name = "label2";
    this.label2.Size = new Size(97, 16);
    this.label2.TabIndex = 31;
    this.label2.Text = "Link livestream:";
    this.txtLinkChiaSe.Location = new Point(112, 23);
    this.txtLinkChiaSe.Name = "txtLinkChiaSe";
    this.txtLinkChiaSe.Size = new Size(355, 23);
    this.txtLinkChiaSe.TabIndex = 0;
    this.btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(343, 454);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.txtTenHanhDong.Location = new Point(123, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(193, 23);
    this.txtTenHanhDong.TabIndex = 0;
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
    this.btnCancel.Location = new Point(442, 454);
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
    this.bunifuCards1.Size = new Size(875, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(878, 501);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDChiaSeLivestream);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDChiaSeLivestream_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plTuongTacLivestream.ResumeLayout(false);
    this.plTuongTacLivestream.PerformLayout();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.plBinhLuanNhieuLan.ResumeLayout(false);
    this.plBinhLuanNhieuLan.PerformLayout();
    this.nudBinhLuanNhieuLanDelayTo.EndInit();
    this.nudBinhLuanNhieuLanDelayFrom.EndInit();
    this.plInteract.ResumeLayout(false);
    this.plInteract.PerformLayout();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    this.plDangBaiLenNhom.ResumeLayout(false);
    this.plDangBaiLenNhom.PerformLayout();
    this.nudCountGroupTo.EndInit();
    this.nudCountGroupFrom.EndInit();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.plVanBan.ResumeLayout(false);
    this.plVanBan.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
