// Decompiled with JetBrains decompiler
// Type: fHDTuongTacNhom
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

public class fHDTuongTacNhom : Form
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
  private IContainer components;
  private Button btnMinimize;

  public fHDTuongTacNhom(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDTuongTacNhom.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDTuongTacNhom").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacNhom', 'Tương tác Nhóm');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDTuongTacNhom");
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

  private void fHDTuongTacNhom_Load(object sender, EventArgs e)
  {
    try
    {
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
    this.method_1();
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    else if (this.ckbComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung bình luận!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
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
        if (MessageBox.Show(GClass35.smethod_0("Bạn có muốn thêm hành động mới?"), GClass35.smethod_0("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDTuongTacNhom.bool_0 = true;
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
          fHDTuongTacNhom.bool_0 = true;
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

  private void txtComment_TextChanged(object sender, EventArgs e) => this.method_0();

  private void method_0()
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
      this.lblStatus.Text = GClass35.smethod_0("Nội dung bình luận") + " (" + stringList2.Count.ToString() + "):";
    }
    catch
    {
    }
  }

  private void method_1()
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

  private void btnUp_Click(object sender, EventArgs e) => this.plComment.Height = 195;

  private void btnDown_Click(object sender, EventArgs e) => this.plComment.Height = 209;

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.btnUp.Visible = true;
    this.btnDown.Visible = true;
  }

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => this.method_0();

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => this.method_0();

  private void ckbInteract_CheckedChanged(object sender, EventArgs e) => this.plCountLike.Enabled = this.ckbInteract.Checked;

  private void ckbShareWall_CheckedChanged(object sender, EventArgs e) => this.plCountShareWall.Enabled = this.ckbShareWall.Checked;

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
    this.txtTenHanhDong = new TextBox();
    this.plCountLike = new Panel();
    this.nudCountLikeFrom = new NumericUpDown();
    this.label2 = new Label();
    this.label10 = new Label();
    this.nudCountLikeTo = new NumericUpDown();
    this.label1 = new Label();
    this.label16 = new Label();
    this.btnCancel = new Button();
    this.nudTimeTo = new NumericUpDown();
    this.btnAdd = new Button();
    this.nudTimeFrom = new NumericUpDown();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
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
    this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Nhóm";
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
    this.pnlHeader.Size = new Size(359, 31);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) Resources.btnMinimize_Image;
    this.btnMinimize.Location = new Point(326, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 78;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.label21);
    this.panel1.Controls.Add((Control) this.ckbInteract);
    this.panel1.Controls.Add((Control) this.ckbShareWall);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.plCountComment);
    this.panel1.Controls.Add((Control) this.label18);
    this.panel1.Controls.Add((Control) this.plCountShareWall);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.plCountLike);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.label16);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.nudTimeTo);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.nudTimeFrom);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(362, 420);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
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
    this.plComment.Location = new Point(42, 195);
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
    this.label21.Location = new Point(18, 80);
    this.label21.Name = "label21";
    this.label21.Size = new Size(91, 16);
    this.label21.TabIndex = 110;
    this.label21.Text = "Thời gian lướt:";
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(21, 108);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(75, 20);
    this.ckbInteract.TabIndex = 7;
    this.ckbInteract.Text = "Cảm xúc";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.ckbShareWall.AutoSize = true;
    this.ckbShareWall.Cursor = Cursors.Hand;
    this.ckbShareWall.Location = new Point(21, 137);
    this.ckbShareWall.Name = "ckbShareWall";
    this.ckbShareWall.Size = new Size(89, 20);
    this.ckbShareWall.TabIndex = 8;
    this.ckbShareWall.Text = "Share Wall";
    this.ckbShareWall.UseVisualStyleBackColor = true;
    this.ckbShareWall.CheckedChanged += new EventHandler(this.ckbShareWall_CheckedChanged);
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(21, 166);
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
    this.plCountComment.Location = new Point(128, 165);
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
    this.label14.AutoSize = true;
    this.label14.Location = new Point(63, 3);
    this.label14.Name = "label14";
    this.label14.Size = new Size(28, 16);
    this.label14.TabIndex = 37;
    this.label14.Text = "đến";
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
    this.label18.Location = new Point(287, 80);
    this.label18.Name = "label18";
    this.label18.Size = new Size(30, 16);
    this.label18.TabIndex = 112;
    this.label18.Text = "giây";
    this.plCountShareWall.Controls.Add((Control) this.nudCountShareFrom);
    this.plCountShareWall.Controls.Add((Control) this.label11);
    this.plCountShareWall.Controls.Add((Control) this.label12);
    this.plCountShareWall.Controls.Add((Control) this.nudCountShareTo);
    this.plCountShareWall.Location = new Point(128, 135);
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
    this.label12.AutoSize = true;
    this.label12.Location = new Point(63, 3);
    this.label12.Name = "label12";
    this.label12.Size = new Size(28, 16);
    this.label12.TabIndex = 37;
    this.label12.Text = "đến";
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
    this.txtTenHanhDong.Location = new Point(129, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(195, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.plCountLike.Controls.Add((Control) this.nudCountLikeFrom);
    this.plCountLike.Controls.Add((Control) this.label2);
    this.plCountLike.Controls.Add((Control) this.label10);
    this.plCountLike.Controls.Add((Control) this.nudCountLikeTo);
    this.plCountLike.Location = new Point(128, 106);
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
    this.label10.AutoSize = true;
    this.label10.Location = new Point(63, 3);
    this.label10.Name = "label10";
    this.label10.Size = new Size(28, 16);
    this.label10.TabIndex = 37;
    this.label10.Text = "đến";
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
    this.label1.AutoSize = true;
    this.label1.Location = new Point(18, 52);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 16);
    this.label1.TabIndex = 31;
    this.label1.Text = "Tên hành động:";
    this.label16.AutoSize = true;
    this.label16.Location = new Point(191, 80);
    this.label16.Name = "label16";
    this.label16.Size = new Size(28, 16);
    this.label16.TabIndex = 114;
    this.label16.Text = "đến";
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(189, 375);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 12;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.nudTimeTo.Location = new Point(226, 78);
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
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(82, 375);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 11;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.nudTimeFrom.Location = new Point(129, 78);
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
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(362, 420);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDTuongTacNhom);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDTuongTacNhom_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
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
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
