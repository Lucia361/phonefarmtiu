// Decompiled with JetBrains decompiler
// Type: fHDTuongTacPage
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

public class fHDTuongTacPage : Form
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
  private Panel plComment;
  private Label label8;
  private Label lblStatus;
  private CheckBox ckbComment;
  private CheckBox ckbInteract;
  private CheckBox ckbShareWall;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private Label label9;
  private MetroButton btnDown;
  private MetroButton btnUp;
  private RichTextBox txtComment;
  private Panel plCountComment;
  private NumericUpDown nudCountCommentFrom;
  private Label label13;
  private Label label14;
  private NumericUpDown nudCountCommentTo;
  private Panel plCountShareWall;
  private NumericUpDown nudCountShareFrom;
  private Label label11;
  private Label label12;
  private NumericUpDown nudCountShareTo;
  private Panel plCountLike;
  private NumericUpDown nudCountLikeFrom;
  private Label label2;
  private Label label10;
  private NumericUpDown nudCountLikeTo;
  private NumericUpDown nudTimeTo;
  private NumericUpDown nudTimeFrom;
  private Label label16;
  private Label label18;
  private Label label21;
  private GroupBox groupBox1;
  private Label label49;
  private NumericUpDown nudSoLuongPageFrom;
  private Label label68;
  private NumericUpDown nudSoLuongPageTo;
  private Label label66;
  private Button btnMinimize;
  private RichTextBox txtUid;
  private Label label3;
  private Label lblUid;
  private IContainer components;
  private CheckBox ckbTuDongXoaUid;

  public fHDTuongTacPage(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDTuongTacPage.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDTuongTacPage").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacPage', 'Tương tác Page');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDTuongTacPage");
        string_1 = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        string_1 = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = "Cập nhật";
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
    GClass35.smethod_1((Control) this.label68);
    GClass35.smethod_1((Control) this.groupBox1);
    GClass35.smethod_1((Control) this.label21);
    GClass35.smethod_1((Control) this.label16);
    GClass35.smethod_1((Control) this.label18);
    GClass35.smethod_1((Control) this.ckbInteract);
    GClass35.smethod_1((Control) this.label10);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.label12);
    GClass35.smethod_1((Control) this.label11);
    GClass35.smethod_1((Control) this.label14);
    GClass35.smethod_1((Control) this.label13);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.label9);
    GClass35.smethod_1((Control) this.rbNganCachMoiDong);
    GClass35.smethod_1((Control) this.rbNganCachKyTu);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
    GClass35.smethod_1((Control) this.lblUid);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.ckbTuDongXoaUid);
  }

  private void fHDTuongTacPage_Load(object sender, EventArgs e)
  {
    try
    {
      this.txtUid.Text = this.gclass22_0.method_1("txtUid");
      this.ckbTuDongXoaUid.Checked = this.gclass22_0.method_4("ckbTuDongXoaUid");
      this.nudSoLuongPageFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongPageFrom", 1);
      this.nudSoLuongPageTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongPageTo", 3);
      this.nudTimeFrom.Value = (Decimal) this.gclass22_0.method_3("nudTimeFrom", 10);
      this.nudTimeTo.Value = (Decimal) this.gclass22_0.method_3("nudTimeTo", 30);
      this.nudCountLikeFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountLikeFrom", 1);
      this.nudCountLikeTo.Value = (Decimal) this.gclass22_0.method_3("nudCountLikeTo", 3);
      this.nudCountShareFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountShareFrom", 1);
      this.nudCountShareTo.Value = (Decimal) this.gclass22_0.method_3("nudCountShareTo", 3);
      this.nudCountCommentFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountCommentFrom", 1);
      this.nudCountCommentTo.Value = (Decimal) this.gclass22_0.method_3("nudCountCommentTo", 3);
      this.ckbInteract.Checked = this.gclass22_0.method_4("ckbInteract");
      this.ckbShareWall.Checked = this.gclass22_0.method_4("ckbShareWall");
      this.ckbComment.Checked = this.gclass22_0.method_4("ckbComment");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
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

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
      GClass14.smethod_0((object) "Vui lòng nhập tên hành động!", 3);
    else if (this.ckbComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) "Vui lòng nhập nội dung bình luận!", 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("txtUid", (object) this.txtUid.Text.Trim());
      gclass22.method_6("ckbTuDongXoaUid", (object) this.ckbTuDongXoaUid.Checked);
      gclass22.method_6("nudSoLuongPageFrom", (object) this.nudSoLuongPageFrom.Value);
      gclass22.method_6("nudSoLuongPageTo", (object) this.nudSoLuongPageTo.Value);
      gclass22.method_6("nudTimeFrom", (object) this.nudTimeFrom.Value);
      gclass22.method_6("nudTimeTo", (object) this.nudTimeTo.Value);
      gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
      gclass22.method_6("ckbShareWall", (object) this.ckbShareWall.Checked);
      gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      gclass22.method_6("nudCountLikeFrom", (object) this.nudCountLikeFrom.Value);
      gclass22.method_6("nudCountLikeTo", (object) this.nudCountLikeTo.Value);
      gclass22.method_6("nudCountShareFrom", (object) this.nudCountShareFrom.Value);
      gclass22.method_6("nudCountShareTo", (object) this.nudCountShareTo.Value);
      gclass22.method_6("nudCountCommentFrom", (object) this.nudCountCommentFrom.Value);
      gclass22.method_6("nudCountCommentTo", (object) this.nudCountCommentTo.Value);
      int object_0 = 0;
      if (this.rbNganCachKyTu.Checked)
        object_0 = 1;
      gclass22.method_6("typeNganCach", (object) object_0);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1("Bạn có muốn thêm hành động mới?") != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDTuongTacPage.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) "Thêm thất bại, vui lòng thử lại sau!", 2);
      }
      else
      {
        if (GClass14.smethod_1("Bạn có muốn cập nhật hành động?") != DialogResult.Yes)
          return;
        if (Class205.smethod_21(this.string_2, string_1, str))
        {
          fHDTuongTacPage.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) "Cập nhật thất bại, vui lòng thử lại sau!", 2);
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

  private void txtComment_TextChanged(object sender, EventArgs e) => this.method_2();

  private void method_2()
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
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Nội dung bình luận ({0}):"), (object) stringList2.Count.ToString());
    }
    catch
    {
    }
  }

  private void method_3()
  {
    this.ckbInteract_CheckedChanged((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
    this.ckbShareWall_CheckedChanged((object) null, (EventArgs) null);
  }

  private void ckbComment_CheckedChanged(object sender, EventArgs e)
  {
    this.plCountComment.Enabled = this.ckbComment.Checked;
    this.plComment.Enabled = this.ckbComment.Checked;
  }

  private void btnUp_Click(object sender, EventArgs e) => this.groupBox1.Height = 312;

  private void btnDown_Click(object sender, EventArgs e) => this.groupBox1.Height = 353;

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.btnUp.Visible = true;
    this.btnDown.Visible = true;
  }

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => this.method_2();

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => this.method_2();

  private void ckbInteract_CheckedChanged(object sender, EventArgs e) => this.plCountLike.Enabled = this.ckbInteract.Checked;

  private void ckbShareWall_CheckedChanged(object sender, EventArgs e) => this.plCountShareWall.Enabled = this.ckbShareWall.Checked;

  private void txtUid_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtUid, (Control) this.lblUid);

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
    this.ckbTuDongXoaUid = new CheckBox();
    this.txtUid = new RichTextBox();
    this.label3 = new Label();
    this.lblUid = new Label();
    this.groupBox1 = new GroupBox();
    this.plComment = new Panel();
    this.txtComment = new RichTextBox();
    this.btnDown = new MetroButton();
    this.btnUp = new MetroButton();
    this.rbNganCachKyTu = new RadioButton();
    this.rbNganCachMoiDong = new RadioButton();
    this.label9 = new Label();
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.label21 = new Label();
    this.ckbInteract = new CheckBox();
    this.ckbShareWall = new CheckBox();
    this.ckbComment = new CheckBox();
    this.plCountComment = new Panel();
    this.nudCountCommentFrom = new NumericUpDown();
    this.label13 = new Label();
    this.label14 = new Label();
    this.nudCountCommentTo = new NumericUpDown();
    this.label18 = new Label();
    this.plCountShareWall = new Panel();
    this.nudCountShareFrom = new NumericUpDown();
    this.label11 = new Label();
    this.label12 = new Label();
    this.nudCountShareTo = new NumericUpDown();
    this.plCountLike = new Panel();
    this.nudCountLikeFrom = new NumericUpDown();
    this.label2 = new Label();
    this.label10 = new Label();
    this.nudCountLikeTo = new NumericUpDown();
    this.label16 = new Label();
    this.nudTimeTo = new NumericUpDown();
    this.nudTimeFrom = new NumericUpDown();
    this.label49 = new Label();
    this.nudSoLuongPageFrom = new NumericUpDown();
    this.label68 = new Label();
    this.nudSoLuongPageTo = new NumericUpDown();
    this.label66 = new Label();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.groupBox1.SuspendLayout();
    this.plComment.SuspendLayout();
    this.plCountComment.SuspendLayout();
    this.nudCountCommentFrom.BeginInit();
    this.nudCountCommentTo.BeginInit();
    this.plCountShareWall.SuspendLayout();
    this.nudCountShareFrom.BeginInit();
    this.nudCountShareTo.BeginInit();
    this.plCountLike.SuspendLayout();
    this.nudCountLikeFrom.BeginInit();
    this.nudCountLikeTo.BeginInit();
    this.nudTimeTo.BeginInit();
    this.nudTimeFrom.BeginInit();
    this.nudSoLuongPageFrom.BeginInit();
    this.nudSoLuongPageTo.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(687, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Page";
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
    this.pnlHeader.Size = new Size(687, 31);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) Resources.btnMinimize_Image;
    this.btnMinimize.Location = new Point(654, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 78;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.ckbTuDongXoaUid);
    this.panel1.Controls.Add((Control) this.txtUid);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.lblUid);
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.label49);
    this.panel1.Controls.Add((Control) this.nudSoLuongPageFrom);
    this.panel1.Controls.Add((Control) this.label68);
    this.panel1.Controls.Add((Control) this.nudSoLuongPageTo);
    this.panel1.Controls.Add((Control) this.label66);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(690, 453);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.ckbTuDongXoaUid.AutoSize = true;
    this.ckbTuDongXoaUid.Cursor = Cursors.Hand;
    this.ckbTuDongXoaUid.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuDongXoaUid.Location = new Point(24, 371);
    this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
    this.ckbTuDongXoaUid.Size = new Size(228, 20);
    this.ckbTuDongXoaUid.TabIndex = 128;
    this.ckbTuDongXoaUid.Text = "Tự động xóa Uid page đã tương tác";
    this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
    this.txtUid.BorderStyle = BorderStyle.FixedSingle;
    this.txtUid.Location = new Point(25, 130);
    this.txtUid.Name = "txtUid";
    this.txtUid.Size = new Size(295, 219);
    this.txtUid.TabIndex = (int) sbyte.MaxValue;
    this.txtUid.Text = "";
    this.txtUid.WordWrap = false;
    this.txtUid.TextChanged += new EventHandler(this.txtUid_TextChanged);
    this.label3.AutoSize = true;
    this.label3.Location = new Point(222, 352);
    this.label3.Name = "label3";
    this.label3.Size = new Size(102, 16);
    this.label3.TabIndex = 125;
    this.label3.Text = "(Mỗi Uid 1 dòng)";
    this.lblUid.AutoSize = true;
    this.lblUid.Location = new Point(21, 110);
    this.lblUid.Name = "lblUid";
    this.lblUid.Size = new Size(146, 16);
    this.lblUid.TabIndex = 126;
    this.lblUid.Text = "Danh sách Uid Page (0):";
    this.groupBox1.Controls.Add((Control) this.plComment);
    this.groupBox1.Controls.Add((Control) this.label21);
    this.groupBox1.Controls.Add((Control) this.ckbInteract);
    this.groupBox1.Controls.Add((Control) this.ckbShareWall);
    this.groupBox1.Controls.Add((Control) this.ckbComment);
    this.groupBox1.Controls.Add((Control) this.plCountComment);
    this.groupBox1.Controls.Add((Control) this.label18);
    this.groupBox1.Controls.Add((Control) this.plCountShareWall);
    this.groupBox1.Controls.Add((Control) this.plCountLike);
    this.groupBox1.Controls.Add((Control) this.label16);
    this.groupBox1.Controls.Add((Control) this.nudTimeTo);
    this.groupBox1.Controls.Add((Control) this.nudTimeFrom);
    this.groupBox1.Location = new Point(344, 80);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(321, 312);
    this.groupBox1.TabIndex = 124;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Cấu hình tương tác/Page";
    this.plComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.btnDown);
    this.plComment.Controls.Add((Control) this.btnUp);
    this.plComment.Controls.Add((Control) this.rbNganCachKyTu);
    this.plComment.Controls.Add((Control) this.rbNganCachMoiDong);
    this.plComment.Controls.Add((Control) this.label9);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(30, 140);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(281, 163);
    this.plComment.TabIndex = 10;
    this.txtComment.Location = new Point(7, 27);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(266, 111);
    this.txtComment.TabIndex = 106;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.btnDown.Cursor = Cursors.Hand;
    this.btnDown.Location = new Point(224, -1);
    this.btnDown.Name = "btnDown";
    this.btnDown.Size = new Size(25, 25);
    this.btnDown.TabIndex = 7;
    this.btnDown.UseSelectable = true;
    this.btnDown.Visible = false;
    this.btnDown.Click += new EventHandler(this.btnDown_Click);
    this.btnUp.Cursor = Cursors.Hand;
    this.btnUp.Location = new Point((int) byte.MaxValue, -1);
    this.btnUp.Name = "btnUp";
    this.btnUp.Size = new Size(25, 25);
    this.btnUp.TabIndex = 7;
    this.btnUp.UseSelectable = true;
    this.btnUp.Visible = false;
    this.btnUp.Click += new EventHandler(this.btnUp_Click);
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(69, 182);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(202, 20);
    this.rbNganCachKyTu.TabIndex = 6;
    this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachKyTu.CheckedChanged += new EventHandler(this.rbNganCachKyTu_CheckedChanged);
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(69, 161);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(170, 20);
    this.rbNganCachMoiDong.TabIndex = 5;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.CheckedChanged += new EventHandler(this.rbNganCachMoiDong_CheckedChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(4, 161);
    this.label9.Name = "label9";
    this.label9.Size = new Size(64, 16);
    this.label9.TabIndex = 4;
    this.label9.Text = "Tùy chọn:";
    this.label8.AutoSize = true;
    this.label8.Location = new Point(4, 141);
    this.label8.Name = "label8";
    this.label8.Size = new Size(265, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(139, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung bình luận (0):";
    this.label21.AutoSize = true;
    this.label21.Location = new Point(6, 25);
    this.label21.Name = "label21";
    this.label21.Size = new Size(91, 16);
    this.label21.TabIndex = 110;
    this.label21.Text = "Thời gian lướt:";
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(9, 53);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(75, 20);
    this.ckbInteract.TabIndex = 7;
    this.ckbInteract.Text = "Cảm xúc";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.ckbShareWall.AutoSize = true;
    this.ckbShareWall.Cursor = Cursors.Hand;
    this.ckbShareWall.Location = new Point(9, 82);
    this.ckbShareWall.Name = "ckbShareWall";
    this.ckbShareWall.Size = new Size(89, 20);
    this.ckbShareWall.TabIndex = 8;
    this.ckbShareWall.Text = "Share Wall";
    this.ckbShareWall.UseVisualStyleBackColor = true;
    this.ckbShareWall.CheckedChanged += new EventHandler(this.ckbShareWall_CheckedChanged);
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(9, 111);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size(81, 20);
    this.ckbComment.TabIndex = 9;
    this.ckbComment.Text = "Comment";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.plCountComment.Controls.Add((Control) this.nudCountCommentFrom);
    this.plCountComment.Controls.Add((Control) this.label13);
    this.plCountComment.Controls.Add((Control) this.label14);
    this.plCountComment.Controls.Add((Control) this.nudCountCommentTo);
    this.plCountComment.Location = new Point(116, 110);
    this.plCountComment.Name = "plCountComment";
    this.plCountComment.Size = new Size(196, 25);
    this.plCountComment.TabIndex = 118;
    this.nudCountCommentFrom.Location = new Point(1, 1);
    this.nudCountCommentFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountCommentFrom.Name = "nudCountCommentFrom";
    this.nudCountCommentFrom.Size = new Size(56, 23);
    this.nudCountCommentFrom.TabIndex = 1;
    this.label13.AutoSize = true;
    this.label13.Location = new Point(159, 3);
    this.label13.Name = "label13";
    this.label13.Size = new Size(29, 16);
    this.label13.TabIndex = 35;
    this.label13.Text = "lượt";
    this.label14.Location = new Point(63, 3);
    this.label14.Name = "label14";
    this.label14.Size = new Size(29, 16);
    this.label14.TabIndex = 37;
    this.label14.Text = "đến";
    this.label14.TextAlign = ContentAlignment.MiddleCenter;
    this.nudCountCommentTo.Location = new Point(98, 1);
    this.nudCountCommentTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountCommentTo.Name = "nudCountCommentTo";
    this.nudCountCommentTo.Size = new Size(56, 23);
    this.nudCountCommentTo.TabIndex = 2;
    this.label18.AutoSize = true;
    this.label18.Location = new Point(275, 25);
    this.label18.Name = "label18";
    this.label18.Size = new Size(30, 16);
    this.label18.TabIndex = 112;
    this.label18.Text = "giây";
    this.plCountShareWall.Controls.Add((Control) this.nudCountShareFrom);
    this.plCountShareWall.Controls.Add((Control) this.label11);
    this.plCountShareWall.Controls.Add((Control) this.label12);
    this.plCountShareWall.Controls.Add((Control) this.nudCountShareTo);
    this.plCountShareWall.Location = new Point(116, 80);
    this.plCountShareWall.Name = "plCountShareWall";
    this.plCountShareWall.Size = new Size(196, 25);
    this.plCountShareWall.TabIndex = 117;
    this.nudCountShareFrom.Location = new Point(1, 1);
    this.nudCountShareFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountShareFrom.Name = "nudCountShareFrom";
    this.nudCountShareFrom.Size = new Size(56, 23);
    this.nudCountShareFrom.TabIndex = 1;
    this.label11.AutoSize = true;
    this.label11.Location = new Point(159, 3);
    this.label11.Name = "label11";
    this.label11.Size = new Size(29, 16);
    this.label11.TabIndex = 35;
    this.label11.Text = "lượt";
    this.label12.Location = new Point(63, 3);
    this.label12.Name = "label12";
    this.label12.Size = new Size(29, 16);
    this.label12.TabIndex = 37;
    this.label12.Text = "đến";
    this.label12.TextAlign = ContentAlignment.MiddleCenter;
    this.nudCountShareTo.Location = new Point(98, 1);
    this.nudCountShareTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountShareTo.Name = "nudCountShareTo";
    this.nudCountShareTo.Size = new Size(56, 23);
    this.nudCountShareTo.TabIndex = 2;
    this.plCountLike.Controls.Add((Control) this.nudCountLikeFrom);
    this.plCountLike.Controls.Add((Control) this.label2);
    this.plCountLike.Controls.Add((Control) this.label10);
    this.plCountLike.Controls.Add((Control) this.nudCountLikeTo);
    this.plCountLike.Location = new Point(116, 51);
    this.plCountLike.Name = "plCountLike";
    this.plCountLike.Size = new Size(196, 25);
    this.plCountLike.TabIndex = 116;
    this.nudCountLikeFrom.Location = new Point(1, 1);
    this.nudCountLikeFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountLikeFrom.Name = "nudCountLikeFrom";
    this.nudCountLikeFrom.Size = new Size(56, 23);
    this.nudCountLikeFrom.TabIndex = 1;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(159, 3);
    this.label2.Name = "label2";
    this.label2.Size = new Size(29, 16);
    this.label2.TabIndex = 35;
    this.label2.Text = "lượt";
    this.label10.Location = new Point(63, 3);
    this.label10.Name = "label10";
    this.label10.Size = new Size(29, 16);
    this.label10.TabIndex = 37;
    this.label10.Text = "đến";
    this.label10.TextAlign = ContentAlignment.MiddleCenter;
    this.nudCountLikeTo.Location = new Point(98, 1);
    this.nudCountLikeTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountLikeTo.Name = "nudCountLikeTo";
    this.nudCountLikeTo.Size = new Size(56, 23);
    this.nudCountLikeTo.TabIndex = 2;
    this.label16.Location = new Point(179, 25);
    this.label16.Name = "label16";
    this.label16.Size = new Size(29, 16);
    this.label16.TabIndex = 114;
    this.label16.Text = "đến";
    this.label16.TextAlign = ContentAlignment.MiddleCenter;
    this.nudTimeTo.Location = new Point(214, 23);
    this.nudTimeTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeTo.Name = "nudTimeTo";
    this.nudTimeTo.Size = new Size(56, 23);
    this.nudTimeTo.TabIndex = 107;
    this.nudTimeFrom.Location = new Point(117, 23);
    this.nudTimeFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeFrom.Name = "nudTimeFrom";
    this.nudTimeFrom.Size = new Size(56, 23);
    this.nudTimeFrom.TabIndex = 106;
    this.label49.AutoSize = true;
    this.label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label49.Location = new Point(21, 82);
    this.label49.Name = "label49";
    this.label49.Size = new Size(95, 16);
    this.label49.TabIndex = 121;
    this.label49.Text = "Số lượng page:";
    this.nudSoLuongPageFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongPageFrom.Location = new Point(132, 80);
    this.nudSoLuongPageFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongPageFrom.Name = "nudSoLuongPageFrom";
    this.nudSoLuongPageFrom.Size = new Size(56, 23);
    this.nudSoLuongPageFrom.TabIndex = 119;
    this.nudSoLuongPageFrom.Value = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.label68.AutoSize = true;
    this.label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label68.Location = new Point(290, 82);
    this.label68.Name = "label68";
    this.label68.Size = new Size(35, 16);
    this.label68.TabIndex = 122;
    this.label68.Text = "page";
    this.nudSoLuongPageTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongPageTo.Location = new Point(229, 80);
    this.nudSoLuongPageTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongPageTo.Name = "nudSoLuongPageTo";
    this.nudSoLuongPageTo.Size = new Size(56, 23);
    this.nudSoLuongPageTo.TabIndex = 120;
    this.nudSoLuongPageTo.Value = new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label66.Location = new Point(194, 82);
    this.label66.Name = "label66";
    this.label66.Size = new Size(29, 16);
    this.label66.TabIndex = 123;
    this.label66.Text = "đến";
    this.label66.TextAlign = ContentAlignment.MiddleCenter;
    this.txtTenHanhDong.Location = new Point(132, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(188, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(21, 52);
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
    this.btnCancel.Location = new Point(354, 407);
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
    this.btnAdd.Location = new Point(241, 407);
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
    this.bunifuCards1.Size = new Size(687, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(690, 453);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDTuongTacPage);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDTuongTacPage_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.plCountComment.ResumeLayout(false);
    this.plCountComment.PerformLayout();
    this.nudCountCommentFrom.EndInit();
    this.nudCountCommentTo.EndInit();
    this.plCountShareWall.ResumeLayout(false);
    this.plCountShareWall.PerformLayout();
    this.nudCountShareFrom.EndInit();
    this.nudCountShareTo.EndInit();
    this.plCountLike.ResumeLayout(false);
    this.plCountLike.PerformLayout();
    this.nudCountLikeFrom.EndInit();
    this.nudCountLikeTo.EndInit();
    this.nudTimeTo.EndInit();
    this.nudTimeFrom.EndInit();
    this.nudSoLuongPageFrom.EndInit();
    this.nudSoLuongPageTo.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
