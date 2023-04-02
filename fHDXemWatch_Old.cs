// Decompiled with JetBrains decompiler
// Type: fHDXemWatch_Old
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

public class fHDXemWatch_Old : Form
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
  private NumericUpDown nudTimeWatchTo;
  private NumericUpDown nudSoLuongTo;
  private NumericUpDown nudTimeWatchFrom;
  private NumericUpDown nudSoLuongFrom;
  private TextBox txtTenHanhDong;
  private Label label7;
  private Label label3;
  private Label label6;
  private Label label4;
  private Label label5;
  private Label label2;
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
  private CheckBox ckbComment;
  private CheckBox ckbInteract;
  private CheckBox ckbShareWall;
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
  private Label label9;
  private Label label10;
  private NumericUpDown nudCountLikeTo;
  private IContainer components;
  private RichTextBox txtComment;

  public fHDXemWatch_Old(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDXemWatch_Old.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDXemWatch");
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
    GClass35.smethod_1((Control) this.label5);
    GClass35.smethod_1((Control) this.label7);
    GClass35.smethod_1((Control) this.label6);
    GClass35.smethod_1((Control) this.label10);
    GClass35.smethod_1((Control) this.label9);
    GClass35.smethod_1((Control) this.label12);
    GClass35.smethod_1((Control) this.label11);
    GClass35.smethod_1((Control) this.label14);
    GClass35.smethod_1((Control) this.label13);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDXemWatch_Old_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom");
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo");
      this.nudTimeWatchFrom.Value = (Decimal) this.gclass22_0.method_3("nudTimeWatchFrom");
      this.nudTimeWatchTo.Value = (Decimal) this.gclass22_0.method_3("nudTimeWatchTo");
      this.ckbInteract.Checked = this.gclass22_0.method_4("ckbInteract");
      this.ckbComment.Checked = this.gclass22_0.method_4("ckbComment");
      this.ckbShareWall.Checked = this.gclass22_0.method_4("ckbShareWall");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
      this.nudCountLikeFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountLikeFrom", 1);
      this.nudCountLikeTo.Value = (Decimal) this.gclass22_0.method_3("nudCountLikeTo", 3);
      this.nudCountShareFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountShareFrom", 1);
      this.nudCountShareTo.Value = (Decimal) this.gclass22_0.method_3("nudCountShareTo", 3);
      this.nudCountCommentFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountCommentFrom", 1);
      this.nudCountCommentTo.Value = (Decimal) this.gclass22_0.method_3("nudCountCommentTo", 3);
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
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    else if (this.ckbComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung bình luận!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("nudTimeWatchFrom", (object) this.nudTimeWatchFrom.Value);
      gclass22.method_6("nudTimeWatchTo", (object) this.nudTimeWatchTo.Value);
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
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDXemWatch_Old.bool_0 = true;
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
          fHDXemWatch_Old.bool_0 = true;
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

  private void txtComment_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Nội dung bình luận ({0}):"), (object) stringList.Count.ToString());
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
    this.plComment.Enabled = this.ckbComment.Checked;
    this.plCountComment.Enabled = this.ckbComment.Checked;
  }

  private void ckbInteract_CheckedChanged(object sender, EventArgs e) => this.plCountLike.Enabled = this.ckbInteract.Checked;

  private void ckbShareWall_CheckedChanged(object sender, EventArgs e) => this.plCountShareWall.Enabled = this.ckbShareWall.Checked;

  private void method_2(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Có thể dùng [u] để thay thế tên của người đăng bài!"));

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDXemWatch_Old));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plCountComment = new Panel();
    this.nudCountCommentFrom = new NumericUpDown();
    this.label13 = new Label();
    this.label14 = new Label();
    this.nudCountCommentTo = new NumericUpDown();
    this.plCountShareWall = new Panel();
    this.nudCountShareFrom = new NumericUpDown();
    this.label11 = new Label();
    this.label12 = new Label();
    this.nudCountShareTo = new NumericUpDown();
    this.plCountLike = new Panel();
    this.nudCountLikeFrom = new NumericUpDown();
    this.label9 = new Label();
    this.label10 = new Label();
    this.nudCountLikeTo = new NumericUpDown();
    this.plComment = new Panel();
    this.txtComment = new RichTextBox();
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.ckbComment = new CheckBox();
    this.ckbShareWall = new CheckBox();
    this.ckbInteract = new CheckBox();
    this.nudTimeWatchTo = new NumericUpDown();
    this.nudSoLuongTo = new NumericUpDown();
    this.nudTimeWatchFrom = new NumericUpDown();
    this.nudSoLuongFrom = new NumericUpDown();
    this.txtTenHanhDong = new TextBox();
    this.label7 = new Label();
    this.label3 = new Label();
    this.label6 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plCountComment.SuspendLayout();
    this.nudCountCommentFrom.BeginInit();
    this.nudCountCommentTo.BeginInit();
    this.plCountShareWall.SuspendLayout();
    this.nudCountShareFrom.BeginInit();
    this.nudCountShareTo.BeginInit();
    this.plCountLike.SuspendLayout();
    this.nudCountLikeFrom.BeginInit();
    this.nudCountLikeTo.BeginInit();
    this.plComment.SuspendLayout();
    this.nudTimeWatchTo.BeginInit();
    this.nudSoLuongTo.BeginInit();
    this.nudTimeWatchFrom.BeginInit();
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
    this.bunifuCustomLabel1.Text = "Cấu hình Xem Watch";
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
    this.panel1.Controls.Add((Control) this.plCountComment);
    this.panel1.Controls.Add((Control) this.plCountShareWall);
    this.panel1.Controls.Add((Control) this.plCountLike);
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.ckbShareWall);
    this.panel1.Controls.Add((Control) this.ckbInteract);
    this.panel1.Controls.Add((Control) this.nudTimeWatchTo);
    this.panel1.Controls.Add((Control) this.nudSoLuongTo);
    this.panel1.Controls.Add((Control) this.nudTimeWatchFrom);
    this.panel1.Controls.Add((Control) this.nudSoLuongFrom);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label4);
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
    this.panel1.Size = new Size(362, 436);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plCountComment.Controls.Add((Control) this.nudCountCommentFrom);
    this.plCountComment.Controls.Add((Control) this.label13);
    this.plCountComment.Controls.Add((Control) this.label14);
    this.plCountComment.Controls.Add((Control) this.nudCountCommentTo);
    this.plCountComment.Location = new Point(132, 186);
    this.plCountComment.Name = "plCountComment";
    this.plCountComment.Size = new Size(194, 25);
    this.plCountComment.TabIndex = 44;
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
    this.label13.Size = new Size(24, 16);
    this.label13.TabIndex = 35;
    this.label13.Text = "lần";
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
    this.plCountShareWall.Controls.Add((Control) this.nudCountShareFrom);
    this.plCountShareWall.Controls.Add((Control) this.label11);
    this.plCountShareWall.Controls.Add((Control) this.label12);
    this.plCountShareWall.Controls.Add((Control) this.nudCountShareTo);
    this.plCountShareWall.Location = new Point(132, 158);
    this.plCountShareWall.Name = "plCountShareWall";
    this.plCountShareWall.Size = new Size(194, 25);
    this.plCountShareWall.TabIndex = 43;
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
    this.label11.Size = new Size(24, 16);
    this.label11.TabIndex = 35;
    this.label11.Text = "lần";
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
    this.plCountLike.Controls.Add((Control) this.label9);
    this.plCountLike.Controls.Add((Control) this.label10);
    this.plCountLike.Controls.Add((Control) this.nudCountLikeTo);
    this.plCountLike.Location = new Point(132, 130);
    this.plCountLike.Name = "plCountLike";
    this.plCountLike.Size = new Size(194, 25);
    this.plCountLike.TabIndex = 42;
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
    this.label9.AutoSize = true;
    this.label9.Location = new Point(159, 3);
    this.label9.Name = "label9";
    this.label9.Size = new Size(24, 16);
    this.label9.TabIndex = 35;
    this.label9.Text = "lần";
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
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(48, 214);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(278, 164);
    this.plComment.TabIndex = 8;
    this.txtComment.Location = new Point(6, 24);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(264, 114);
    this.txtComment.TabIndex = 45;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
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
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(30, 188);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size(81, 20);
    this.ckbComment.TabIndex = 7;
    this.ckbComment.Text = "Comment";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.ckbShareWall.AutoSize = true;
    this.ckbShareWall.Cursor = Cursors.Hand;
    this.ckbShareWall.Location = new Point(30, 160);
    this.ckbShareWall.Name = "ckbShareWall";
    this.ckbShareWall.Size = new Size(89, 20);
    this.ckbShareWall.TabIndex = 6;
    this.ckbShareWall.Text = "Share Wall";
    this.ckbShareWall.UseVisualStyleBackColor = true;
    this.ckbShareWall.CheckedChanged += new EventHandler(this.ckbShareWall_CheckedChanged);
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(30, 132);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(48, 20);
    this.ckbInteract.TabIndex = 5;
    this.ckbInteract.Text = "Like";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.nudTimeWatchTo.Location = new Point(229, 103);
    this.nudTimeWatchTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeWatchTo.Name = "nudTimeWatchTo";
    this.nudTimeWatchTo.Size = new Size(56, 23);
    this.nudTimeWatchTo.TabIndex = 4;
    this.nudSoLuongTo.Location = new Point(229, 76);
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
    this.nudTimeWatchFrom.Location = new Point(132, 103);
    this.nudTimeWatchFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeWatchFrom.Name = "nudTimeWatchFrom";
    this.nudTimeWatchFrom.Size = new Size(56, 23);
    this.nudTimeWatchFrom.TabIndex = 3;
    this.nudSoLuongFrom.Location = new Point(132, 76);
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
    this.label7.Location = new Point(194, 105);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 38;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label3.Location = new Point(194, 78);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(290, 105);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 36;
    this.label6.Text = "giây";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(290, 78);
    this.label4.Name = "label4";
    this.label4.Size = new Size(37, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "video";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 105);
    this.label5.Name = "label5";
    this.label5.Size = new Size(93, 16);
    this.label5.TabIndex = 34;
    this.label5.Text = "Thời gian xem:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 78);
    this.label2.Name = "label2";
    this.label2.Size = new Size(97, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Số lượng video:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(27, 52);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 16);
    this.label1.TabIndex = 31;
    this.label1.Text = "Tên hành động:";
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(189, 393);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 10;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(82, 393);
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
    this.bunifuCards1.Size = new Size(359, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(362, 436);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDXemWatch_Old);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDXemWatch_Old_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
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
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.nudTimeWatchTo.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudTimeWatchFrom.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
