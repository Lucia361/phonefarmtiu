// Decompiled with JetBrains decompiler
// Type: fHDKetBanTepUid
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

public class fHDKetBanTepUid : Form
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
  private Label label8;
  private Label lblStatus;
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label7;
  private Label label6;
  private Label label5;
  private RichTextBox txtUid;
  private CheckBox ckbTuDongXoaUid;
  private ToolTip toolTip_0;
  private Panel plTuongTac;
  private CheckBox ckbTuongTac;
  private Panel plTuongTacComment;
  private RichTextBox txtComment;
  private Label label9;
  private Label lblStatusComment;
  private CheckBox ckbTuongTacComment;
  private Panel plCountComment;
  private NumericUpDown nudCountCommentFrom;
  private Label label13;
  private Label label14;
  private NumericUpDown nudCountCommentTo;
  private Label label21;
  private NumericUpDown nudTimeFrom;
  private CheckBox ckbTuongTacLike;
  private NumericUpDown nudTimeTo;
  private Label label18;
  private Label label16;
  private Panel plCountLike;
  private NumericUpDown nudCountLikeFrom;
  private Label label10;
  private Label label11;
  private IContainer components;
  private NumericUpDown nudCountLikeTo;

  public fHDKetBanTepUid(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDKetBanTepUid.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDKetBanTepUid");
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
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.ckbTuDongXoaUid);
    GClass35.smethod_1((Control) this.ckbTuongTac);
    GClass35.smethod_1((Control) this.ckbTuongTacComment);
    GClass35.smethod_1((Control) this.lblStatusComment);
    GClass35.smethod_1((Control) this.label9);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDKetBanTepUid_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom");
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo");
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom");
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo");
      this.ckbTuDongXoaUid.Checked = this.gclass22_0.method_4("ckbKetBanTrungNhau");
      this.txtUid.Text = this.gclass22_0.method_1("txtUid");
      this.ckbTuongTac.Checked = this.gclass22_0.method_4("ckbTuongTac");
      this.nudTimeFrom.Value = (Decimal) this.gclass22_0.method_3("nudTimeFrom", 5);
      this.nudTimeTo.Value = (Decimal) this.gclass22_0.method_3("nudTimeTo", 10);
      this.nudCountLikeFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountLikeFrom", 1);
      this.nudCountLikeTo.Value = (Decimal) this.gclass22_0.method_3("nudCountLikeTo", 3);
      this.nudCountCommentFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountCommentFrom", 1);
      this.nudCountCommentTo.Value = (Decimal) this.gclass22_0.method_3("nudCountCommentTo", 3);
      this.ckbTuongTacLike.Checked = this.gclass22_0.method_4("ckbTuongTacLike");
      this.ckbTuongTacComment.Checked = this.gclass22_0.method_4("ckbTuongTacComment");
      this.ckbTuDongXoaUid.Checked = this.gclass22_0.method_4("ckbTuDongXoaUid");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
    }
    catch
    {
    }
    this.method_1();
  }

  private void method_1()
  {
    this.ckbTuongTac_CheckedChanged((object) null, (EventArgs) null);
    this.ckbTuongTacLike_CheckedChanged((object) null, (EventArgs) null);
    this.ckbTuongTacComment_CheckedChanged((object) null, (EventArgs) null);
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    else if (GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>()).Count == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách uid cần kết bạn!"), 3);
    else if (this.ckbTuongTac.Checked && this.ckbTuongTacComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung bình luận!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("ckbKetBanTrungNhau", (object) this.ckbTuDongXoaUid.Checked);
      gclass22.method_6("txtUid", (object) this.txtUid.Text.Trim());
      gclass22.method_6("ckbTuongTac", (object) this.ckbTuongTac.Checked);
      gclass22.method_6("nudTimeFrom", (object) this.nudTimeFrom.Value);
      gclass22.method_6("nudTimeTo", (object) this.nudTimeTo.Value);
      gclass22.method_6("nudCountLikeFrom", (object) this.nudCountLikeFrom.Value);
      gclass22.method_6("nudCountLikeTo", (object) this.nudCountLikeTo.Value);
      gclass22.method_6("nudCountCommentFrom", (object) this.nudCountCommentFrom.Value);
      gclass22.method_6("nudCountCommentTo", (object) this.nudCountCommentTo.Value);
      gclass22.method_6("ckbTuongTacLike", (object) this.ckbTuongTacLike.Checked);
      gclass22.method_6("ckbTuongTacComment", (object) this.ckbTuongTacComment.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      gclass22.method_6("ckbTuDongXoaUid", (object) this.ckbTuDongXoaUid.Checked);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDKetBanTepUid.bool_0 = true;
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
          fHDKetBanTepUid.bool_0 = true;
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

  private void method_2(object sender, EventArgs e)
  {
  }

  private void txtUid_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Danh sách Uid cần kết bạn ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void txtComment_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>());
      this.lblStatusComment.Text = string.Format(GClass35.smethod_0("Nội dung bình luận ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void ckbTuongTac_CheckedChanged(object sender, EventArgs e) => this.plTuongTac.Enabled = this.ckbTuongTac.Checked;

  private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
  {
    this.plCountComment.Enabled = this.ckbTuongTacComment.Checked;
    this.plTuongTacComment.Enabled = this.ckbTuongTacComment.Checked;
  }

  private void ckbTuongTacLike_CheckedChanged(object sender, EventArgs e) => this.plCountLike.Enabled = this.ckbTuongTacLike.Checked;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDKetBanTepUid));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plTuongTac = new Panel();
    this.plTuongTacComment = new Panel();
    this.txtComment = new RichTextBox();
    this.label9 = new Label();
    this.lblStatusComment = new Label();
    this.ckbTuongTacComment = new CheckBox();
    this.plCountComment = new Panel();
    this.nudCountCommentFrom = new NumericUpDown();
    this.label13 = new Label();
    this.label14 = new Label();
    this.nudCountCommentTo = new NumericUpDown();
    this.label21 = new Label();
    this.nudTimeFrom = new NumericUpDown();
    this.ckbTuongTacLike = new CheckBox();
    this.nudTimeTo = new NumericUpDown();
    this.label18 = new Label();
    this.label16 = new Label();
    this.plCountLike = new Panel();
    this.nudCountLikeFrom = new NumericUpDown();
    this.label10 = new Label();
    this.label11 = new Label();
    this.nudCountLikeTo = new NumericUpDown();
    this.ckbTuongTac = new CheckBox();
    this.txtUid = new RichTextBox();
    this.ckbTuDongXoaUid = new CheckBox();
    this.nudDelayTo = new NumericUpDown();
    this.label8 = new Label();
    this.lblStatus = new Label();
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
    this.toolTip_0 = new ToolTip(this.components);
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plTuongTac.SuspendLayout();
    this.plTuongTacComment.SuspendLayout();
    this.plCountComment.SuspendLayout();
    this.nudCountCommentFrom.BeginInit();
    this.nudCountCommentTo.BeginInit();
    this.nudTimeFrom.BeginInit();
    this.nudTimeTo.BeginInit();
    this.plCountLike.SuspendLayout();
    this.nudCountLikeFrom.BeginInit();
    this.nudCountLikeTo.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(687, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo tệp UID";
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
    this.pnlHeader.Size = new Size(687, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(656, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plTuongTac);
    this.panel1.Controls.Add((Control) this.ckbTuongTac);
    this.panel1.Controls.Add((Control) this.txtUid);
    this.panel1.Controls.Add((Control) this.ckbTuDongXoaUid);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.label8);
    this.panel1.Controls.Add((Control) this.lblStatus);
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
    this.panel1.Size = new Size(690, 406);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plTuongTac.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTac.Controls.Add((Control) this.plTuongTacComment);
    this.plTuongTac.Controls.Add((Control) this.ckbTuongTacComment);
    this.plTuongTac.Controls.Add((Control) this.plCountComment);
    this.plTuongTac.Controls.Add((Control) this.label21);
    this.plTuongTac.Controls.Add((Control) this.nudTimeFrom);
    this.plTuongTac.Controls.Add((Control) this.ckbTuongTacLike);
    this.plTuongTac.Controls.Add((Control) this.nudTimeTo);
    this.plTuongTac.Controls.Add((Control) this.label18);
    this.plTuongTac.Controls.Add((Control) this.label16);
    this.plTuongTac.Controls.Add((Control) this.plCountLike);
    this.plTuongTac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plTuongTac.Location = new Point(360, 74);
    this.plTuongTac.Name = "plTuongTac";
    this.plTuongTac.Size = new Size(310, 272);
    this.plTuongTac.TabIndex = 116;
    this.plTuongTacComment.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTacComment.Controls.Add((Control) this.txtComment);
    this.plTuongTacComment.Controls.Add((Control) this.label9);
    this.plTuongTacComment.Controls.Add((Control) this.lblStatusComment);
    this.plTuongTacComment.Location = new Point(24, 94);
    this.plTuongTacComment.Name = "plTuongTacComment";
    this.plTuongTacComment.Size = new Size(278, 169);
    this.plTuongTacComment.TabIndex = 135;
    this.txtComment.Location = new Point(6, 24);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(266, 120);
    this.txtComment.TabIndex = 107;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(2, 147);
    this.label9.Name = "label9";
    this.label9.Size = new Size(265, 16);
    this.label9.TabIndex = 0;
    this.label9.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
    this.lblStatusComment.AutoSize = true;
    this.lblStatusComment.Location = new Point(3, 5);
    this.lblStatusComment.Name = "lblStatusComment";
    this.lblStatusComment.Size = new Size(139, 16);
    this.lblStatusComment.TabIndex = 0;
    this.lblStatusComment.Text = "Nội dung bình luận (0):";
    this.ckbTuongTacComment.AutoSize = true;
    this.ckbTuongTacComment.Cursor = Cursors.Hand;
    this.ckbTuongTacComment.Location = new Point(6, 65);
    this.ckbTuongTacComment.Name = "ckbTuongTacComment";
    this.ckbTuongTacComment.Size = new Size(81, 20);
    this.ckbTuongTacComment.TabIndex = 133;
    this.ckbTuongTacComment.Text = "Comment";
    this.ckbTuongTacComment.UseVisualStyleBackColor = true;
    this.ckbTuongTacComment.CheckedChanged += new EventHandler(this.ckbTuongTacComment_CheckedChanged);
    this.plCountComment.Controls.Add((Control) this.nudCountCommentFrom);
    this.plCountComment.Controls.Add((Control) this.label13);
    this.plCountComment.Controls.Add((Control) this.label14);
    this.plCountComment.Controls.Add((Control) this.nudCountCommentTo);
    this.plCountComment.Location = new Point(113, 64);
    this.plCountComment.Name = "plCountComment";
    this.plCountComment.Size = new Size(189, 25);
    this.plCountComment.TabIndex = 134;
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
    this.label13.Location = new Point(157, 3);
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
    this.label21.AutoSize = true;
    this.label21.Location = new Point(3, 7);
    this.label21.Name = "label21";
    this.label21.Size = new Size(91, 16);
    this.label21.TabIndex = 129;
    this.label21.Text = "Thời gian lướt:";
    this.nudTimeFrom.Location = new Point(114, 5);
    this.nudTimeFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeFrom.Name = "nudTimeFrom";
    this.nudTimeFrom.Size = new Size(56, 23);
    this.nudTimeFrom.TabIndex = (int) sbyte.MaxValue;
    this.ckbTuongTacLike.AutoSize = true;
    this.ckbTuongTacLike.Cursor = Cursors.Hand;
    this.ckbTuongTacLike.Location = new Point(6, 35);
    this.ckbTuongTacLike.Name = "ckbTuongTacLike";
    this.ckbTuongTacLike.Size = new Size(48, 20);
    this.ckbTuongTacLike.TabIndex = 126;
    this.ckbTuongTacLike.Text = "Like";
    this.ckbTuongTacLike.UseVisualStyleBackColor = true;
    this.ckbTuongTacLike.CheckedChanged += new EventHandler(this.ckbTuongTacLike_CheckedChanged);
    this.nudTimeTo.Location = new Point(211, 5);
    this.nudTimeTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeTo.Name = "nudTimeTo";
    this.nudTimeTo.Size = new Size(56, 23);
    this.nudTimeTo.TabIndex = 128;
    this.label18.AutoSize = true;
    this.label18.Location = new Point(272, 7);
    this.label18.Name = "label18";
    this.label18.Size = new Size(30, 16);
    this.label18.TabIndex = 130;
    this.label18.Text = "giây";
    this.label16.AutoSize = true;
    this.label16.Location = new Point(176, 7);
    this.label16.Name = "label16";
    this.label16.Size = new Size(28, 16);
    this.label16.TabIndex = 131;
    this.label16.Text = "đến";
    this.plCountLike.Controls.Add((Control) this.nudCountLikeFrom);
    this.plCountLike.Controls.Add((Control) this.label10);
    this.plCountLike.Controls.Add((Control) this.label11);
    this.plCountLike.Controls.Add((Control) this.nudCountLikeTo);
    this.plCountLike.Location = new Point(113, 33);
    this.plCountLike.Name = "plCountLike";
    this.plCountLike.Size = new Size(189, 25);
    this.plCountLike.TabIndex = 132;
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
    this.label10.AutoSize = true;
    this.label10.Location = new Point(157, 3);
    this.label10.Name = "label10";
    this.label10.Size = new Size(29, 16);
    this.label10.TabIndex = 35;
    this.label10.Text = "lượt";
    this.label11.AutoSize = true;
    this.label11.Location = new Point(63, 3);
    this.label11.Name = "label11";
    this.label11.Size = new Size(28, 16);
    this.label11.TabIndex = 37;
    this.label11.Text = "đến";
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
    this.ckbTuongTac.AutoSize = true;
    this.ckbTuongTac.Cursor = Cursors.Hand;
    this.ckbTuongTac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuongTac.Location = new Point(342, 51);
    this.ckbTuongTac.Name = "ckbTuongTac";
    this.ckbTuongTac.Size = new Size(184, 20);
    this.ckbTuongTac.TabIndex = 115;
    this.ckbTuongTac.Text = "Tương tác trước khi kết bạn";
    this.ckbTuongTac.UseVisualStyleBackColor = true;
    this.ckbTuongTac.CheckedChanged += new EventHandler(this.ckbTuongTac_CheckedChanged);
    this.txtUid.BorderStyle = BorderStyle.FixedSingle;
    this.txtUid.Location = new Point(24, 163);
    this.txtUid.Name = "txtUid";
    this.txtUid.Size = new Size(295, 141);
    this.txtUid.TabIndex = 114;
    this.txtUid.Text = "";
    this.txtUid.WordWrap = false;
    this.txtUid.TextChanged += new EventHandler(this.txtUid_TextChanged);
    this.ckbTuDongXoaUid.AutoSize = true;
    this.ckbTuDongXoaUid.Cursor = Cursors.Hand;
    this.ckbTuDongXoaUid.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuDongXoaUid.Location = new Point(23, 326);
    this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
    this.ckbTuDongXoaUid.Size = new Size(248, 20);
    this.ckbTuDongXoaUid.TabIndex = 113;
    this.ckbTuDongXoaUid.Text = "Tự động xóa Uid đã gửi lời mời kết bạn";
    this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
    this.nudDelayTo.Location = new Point(222, 111);
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
    this.label8.AutoSize = true;
    this.label8.Location = new Point(220, 307);
    this.label8.Name = "label8";
    this.label8.Size = new Size(102, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Mỗi Uid 1 dòng)";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(20, 141);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(184, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Danh sách Uid cần kết bạn (0):";
    this.nudDelayFrom.Location = new Point(125, 111);
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
    this.label7.Location = new Point(187, 113);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 46;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(280, 113);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 45;
    this.label6.Text = "giây";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(20, 113);
    this.label5.Name = "label5";
    this.label5.Size = new Size(89, 16);
    this.label5.TabIndex = 44;
    this.label5.Text = "Thời gian chờ:";
    this.nudSoLuongTo.Location = new Point(222, 80);
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
    this.nudSoLuongFrom.Location = new Point(125, 80);
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
    this.txtTenHanhDong.Location = new Point(125, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label3.Location = new Point(187, 82);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(280, 82);
    this.label4.Name = "label4";
    this.label4.Size = new Size(28, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "bạn";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(20, 82);
    this.label2.Name = "label2";
    this.label2.Size = new Size(88, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Số lượng bạn:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(20, 52);
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
    this.btnCancel.Location = new Point(355, 362);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 7;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(248, 362);
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
    this.bunifuCards1.Size = new Size(687, 37);
    this.bunifuCards1.TabIndex = 28;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 0;
    this.toolTip_0.InitialDelay = 0;
    this.toolTip_0.ReshowDelay = 0;
    this.toolTip_0.ShowAlways = true;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(690, 406);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDKetBanTepUid);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDKetBanTepUid_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plTuongTac.ResumeLayout(false);
    this.plTuongTac.PerformLayout();
    this.plTuongTacComment.ResumeLayout(false);
    this.plTuongTacComment.PerformLayout();
    this.plCountComment.ResumeLayout(false);
    this.plCountComment.PerformLayout();
    this.nudCountCommentFrom.EndInit();
    this.nudCountCommentTo.EndInit();
    this.nudTimeFrom.EndInit();
    this.nudTimeTo.EndInit();
    this.plCountLike.ResumeLayout(false);
    this.plCountLike.PerformLayout();
    this.nudCountLikeFrom.EndInit();
    this.nudCountLikeTo.EndInit();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
