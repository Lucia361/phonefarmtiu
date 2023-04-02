// Decompiled with JetBrains decompiler
// Type: fHDSeedingByVideo
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

public class fHDSeedingByVideo : Form
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
  private Label label10;
  private Label label2;
  private Panel plComment;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private Label label8;
  private RichTextBox txtComment;
  private Label label11;
  private Label lblStatus;
  private Panel plVideo;
  private Button button3;
  private TextBox txtVideo;
  private RichTextBox txtIdPost;
  private CheckBox ckbSendVideo;
  private IContainer components;
  private CheckBox ckbComment;

  public fHDSeedingByVideo(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDSeedingByVideo.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDSeedingByVideo").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSeedingByVideo', 'Seeding bằng video');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDSeedingByVideo");
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
    GClass35.smethod_1((Control) this.label5);
    GClass35.smethod_1((Control) this.label7);
    GClass35.smethod_1((Control) this.label6);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.label10);
    GClass35.smethod_1((Control) this.label10);
    GClass35.smethod_1((Control) this.ckbComment);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label11);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.rbNganCachMoiDong);
    GClass35.smethod_1((Control) this.rbNganCachKyTu);
    GClass35.smethod_1((Control) this.ckbSendVideo);
    GClass35.smethod_1((Control) this.button3);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDSeedingByVideo_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom", 3);
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo", 5);
      this.ckbComment.Checked = this.gclass22_0.method_4("ckbComment");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
      this.txtIdPost.Text = this.gclass22_0.method_1("txtIdPost");
      this.ckbSendVideo.Checked = this.gclass22_0.method_4("ckbSendVideo");
      this.txtVideo.Text = this.gclass22_0.method_1("txtVideo");
      if (this.gclass22_0.method_3("typeNganCach") == 1)
        this.rbNganCachKyTu.Checked = true;
      else
        this.rbNganCachMoiDong.Checked = true;
    }
    catch
    {
    }
    this.method_2();
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    else if (GClass19.smethod_39(((IEnumerable<string>) this.txtIdPost.Lines).ToList<string>()).Count == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách Id bài viết cần buff like, comment!"), 3);
    else if (this.ckbComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung bình luận!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      gclass22.method_6("txtIdPost", (object) this.txtIdPost.Text.Trim());
      gclass22.method_6("ckbSendVideo", (object) this.ckbSendVideo.Checked);
      gclass22.method_6("txtVideo", (object) this.txtVideo.Text.Trim());
      int object_0 = 0;
      if (this.rbNganCachKyTu.Checked)
        object_0 = 1;
      gclass22.method_6("typeNganCach", (object) object_0);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDSeedingByVideo.bool_0 = true;
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
          fHDSeedingByVideo.bool_0 = true;
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
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Nội dung bình luận ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void method_2()
  {
    this.method_3((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
  }

  private void method_3(object sender, EventArgs e)
  {
  }

  private void ckbComment_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbComment.Checked;

  private void txtIdPost_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtIdPost.Lines).ToList<string>());
      this.label2.Text = string.Format(GClass35.smethod_0("Danh sách ID bài viết ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void button3_Click(object sender, EventArgs e) => this.txtVideo.Text = GClass19.smethod_45();

  private void ckbSendVideo_CheckedChanged(object sender, EventArgs e) => this.plVideo.Enabled = this.ckbSendVideo.Checked;

  private void panel1_Click(object sender, EventArgs e)
  {
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDSeedingByVideo));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plComment = new Panel();
    this.rbNganCachKyTu = new RadioButton();
    this.rbNganCachMoiDong = new RadioButton();
    this.label8 = new Label();
    this.txtComment = new RichTextBox();
    this.label11 = new Label();
    this.lblStatus = new Label();
    this.plVideo = new Panel();
    this.button3 = new Button();
    this.txtVideo = new TextBox();
    this.txtIdPost = new RichTextBox();
    this.ckbSendVideo = new CheckBox();
    this.ckbComment = new CheckBox();
    this.label10 = new Label();
    this.label2 = new Label();
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
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plComment.SuspendLayout();
    this.plVideo.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(684, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Seeding bài viết";
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
    this.pnlHeader.Size = new Size(684, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(653, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.plVideo);
    this.panel1.Controls.Add((Control) this.txtIdPost);
    this.panel1.Controls.Add((Control) this.ckbSendVideo);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.label10);
    this.panel1.Controls.Add((Control) this.label2);
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
    this.panel1.Size = new Size(687, 437);
    this.panel1.TabIndex = 0;
    this.panel1.Click += new EventHandler(this.panel1_Click);
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.rbNganCachKyTu);
    this.plComment.Controls.Add((Control) this.rbNganCachMoiDong);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.label11);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(371, 104);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(281, 193);
    this.plComment.TabIndex = 164;
    this.rbNganCachKyTu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(70, 168);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(202, 20);
    this.rbNganCachKyTu.TabIndex = 3;
    this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(70, 147);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(170, 20);
    this.rbNganCachMoiDong.TabIndex = 3;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label8.AutoSize = true;
    this.label8.Location = new Point(4, 147);
    this.label8.Name = "label8";
    this.label8.Size = new Size(64, 16);
    this.label8.TabIndex = 2;
    this.label8.Text = "Tùy chọn:";
    this.txtComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtComment.Location = new Point(7, 25);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(263, 99);
    this.txtComment.TabIndex = 1;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label11.AutoSize = true;
    this.label11.Location = new Point(5, (int) sbyte.MaxValue);
    this.label11.Name = "label11";
    this.label11.Size = new Size(133, 16);
    this.label11.TabIndex = 0;
    this.label11.Text = "Spin nội dung {a|b|c}";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(118, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung bình luận:";
    this.plVideo.BorderStyle = BorderStyle.FixedSingle;
    this.plVideo.Controls.Add((Control) this.button3);
    this.plVideo.Controls.Add((Control) this.txtVideo);
    this.plVideo.Enabled = false;
    this.plVideo.Location = new Point(371, 325);
    this.plVideo.Name = "plVideo";
    this.plVideo.Size = new Size(281, 31);
    this.plVideo.TabIndex = 166;
    this.button3.Cursor = Cursors.Hand;
    this.button3.Location = new Point(217, 2);
    this.button3.Name = "button3";
    this.button3.Size = new Size(59, 25);
    this.button3.TabIndex = 156;
    this.button3.Text = "Chọn";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.txtVideo.Location = new Point(3, 3);
    this.txtVideo.Name = "txtVideo";
    this.txtVideo.Size = new Size(208, 23);
    this.txtVideo.TabIndex = 155;
    this.txtIdPost.Location = new Point(30, 129);
    this.txtIdPost.Name = "txtIdPost";
    this.txtIdPost.Size = new Size(297, 230);
    this.txtIdPost.TabIndex = 1;
    this.txtIdPost.Text = "";
    this.txtIdPost.WordWrap = false;
    this.txtIdPost.TextChanged += new EventHandler(this.txtIdPost_TextChanged);
    this.ckbSendVideo.AutoSize = true;
    this.ckbSendVideo.Cursor = Cursors.Hand;
    this.ckbSendVideo.Location = new Point(353, 303);
    this.ckbSendVideo.Name = "ckbSendVideo";
    this.ckbSendVideo.Size = new Size(112, 20);
    this.ckbSendVideo.TabIndex = 165;
    this.ckbSendVideo.Text = "Bình luận video";
    this.ckbSendVideo.UseVisualStyleBackColor = true;
    this.ckbSendVideo.CheckedChanged += new EventHandler(this.ckbSendVideo_CheckedChanged);
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(353, 79);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size((int) sbyte.MaxValue, 20);
    this.ckbComment.TabIndex = 163;
    this.ckbComment.Text = "Bình luận văn bản";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.label10.AutoSize = true;
    this.label10.Location = new Point(27, 362);
    this.label10.Name = "label10";
    this.label10.Size = new Size(96, 16);
    this.label10.TabIndex = 39;
    this.label10.Text = "(Mỗi ID 1 dòng)";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 108);
    this.label2.Name = "label2";
    this.label2.Size = new Size(153, 16);
    this.label2.TabIndex = 40;
    this.label2.Text = "Danh sách ID bài viết (0):";
    this.nudDelayTo.Location = new Point(231, 78);
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
    this.nudDelayFrom.Location = new Point(134, 78);
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
    this.txtTenHanhDong.Location = new Point(134, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(196, 80);
    this.label7.Name = "label7";
    this.label7.Size = new Size(28, 16);
    this.label7.TabIndex = 38;
    this.label7.Text = "đến";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(292, 80);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 36;
    this.label6.Text = "giây";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 80);
    this.label5.Name = "label5";
    this.label5.Size = new Size(99, 16);
    this.label5.TabIndex = 34;
    this.label5.Text = "Thời gian delay:";
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
    this.btnCancel.Location = new Point(343, 395);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 10;
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
    this.btnAdd.Location = new Point(236, 395);
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
    this.bunifuCards1.Size = new Size(684, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(687, 437);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDSeedingByVideo);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDSeedingByVideo_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.plVideo.ResumeLayout(false);
    this.plVideo.PerformLayout();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
