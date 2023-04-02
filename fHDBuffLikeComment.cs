// Decompiled with JetBrains decompiler
// Type: fHDBuffLikeComment
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

public class fHDBuffLikeComment : Form
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
  private CheckBox ckbInteract;
  private CheckBox ckbShareWall;
  private Label label10;
  private Label label2;
  private NumericUpDown nudTimeTo;
  private NumericUpDown nudTimeFrom;
  private Label label9;
  private Label label4;
  private Label label3;
  private Panel plComment;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private Label label8;
  private RichTextBox txtComment;
  private Label label11;
  private Label lblStatus;
  private Panel plAnh;
  private TextBox txtAnh;
  private RichTextBox txtIdPost;
  private CheckBox ckbSendAnh;
  private CheckBox ckbComment;
  private Label label12;
  private Label label49;
  private NumericUpDown nudSoLuongUidFrom;
  private Label label68;
  private NumericUpDown nudSoLuongUidTo;
  private Label label66;
  private RadioButton rbCommentNgauNhien;
  private RadioButton rbCommentTheoThuTu;
  private Label label13;
  private MetroButton btnDown;
  private MetroButton btnUp;
  private Panel panel2;
  private Panel panel3;
  private Button button3;
  private Button button2;
  private IContainer components;
  private Button button4;

  public fHDBuffLikeComment(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDBuffLikeComment.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDBuffLikeComment").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBuffLikeComment', 'Buff Like, Comment');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDBuffLikeComment");
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

  private void fHDBuffLikeComment_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudTimeFrom.Value = (Decimal) this.gclass22_0.method_3("nudTimeFrom", 3);
      this.nudTimeTo.Value = (Decimal) this.gclass22_0.method_3("nudTimeTo", 5);
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom", 3);
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo", 5);
      this.nudSoLuongUidFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongUidFrom", 1);
      this.nudSoLuongUidTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongUidTo", 3);
      this.ckbInteract.Checked = this.gclass22_0.method_4("ckbInteract");
      this.ckbShareWall.Checked = this.gclass22_0.method_4("ckbShareWall");
      this.ckbComment.Checked = this.gclass22_0.method_4("ckbComment");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
      this.txtIdPost.Text = this.gclass22_0.method_1("txtIdPost");
      this.ckbSendAnh.Checked = this.gclass22_0.method_4("ckbSendAnh");
      this.txtAnh.Text = this.gclass22_0.method_1("txtAnh");
      if (this.gclass22_0.method_3("typeNganCach") == 1)
        this.rbNganCachKyTu.Checked = true;
      else
        this.rbNganCachMoiDong.Checked = true;
      if (this.gclass22_0.method_3("typeComment") == 1)
        this.rbCommentNgauNhien.Checked = true;
      else
        this.rbCommentTheoThuTu.Checked = true;
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
    else if (GClass19.smethod_39(((IEnumerable<string>) this.txtIdPost.Lines).ToList<string>()).Count == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách Id bài viết cần buff like, comment!"), 3);
    else if (this.ckbComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung bình luận!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudTimeFrom", (object) this.nudTimeFrom.Value);
      gclass22.method_6("nudTimeTo", (object) this.nudTimeTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("nudSoLuongUidFrom", (object) this.nudSoLuongUidFrom.Value);
      gclass22.method_6("nudSoLuongUidTo", (object) this.nudSoLuongUidTo.Value);
      gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
      gclass22.method_6("ckbShareWall", (object) this.ckbShareWall.Checked);
      gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      gclass22.method_6("txtIdPost", (object) this.txtIdPost.Text.Trim());
      gclass22.method_6("ckbSendAnh", (object) this.ckbSendAnh.Checked);
      gclass22.method_6("txtAnh", (object) this.txtAnh.Text.Trim());
      int object_0_1 = 0;
      if (this.rbNganCachKyTu.Checked)
        object_0_1 = 1;
      gclass22.method_6("typeNganCach", (object) object_0_1);
      int object_0_2 = 0;
      if (this.rbCommentNgauNhien.Checked)
        object_0_2 = 1;
      gclass22.method_6("typeComment", (object) object_0_2);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDBuffLikeComment.bool_0 = true;
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
          fHDBuffLikeComment.bool_0 = true;
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

  private void method_0(object sender, EventArgs e)
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
    this.method_2((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
  }

  private void method_2(object sender, EventArgs e)
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

  private void ckbSendAnh_CheckedChanged(object sender, EventArgs e) => this.plAnh.Enabled = this.ckbSendAnh.Checked;

  private void panel1_Click(object sender, EventArgs e)
  {
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
  }

  private void label12_Click(object sender, EventArgs e)
  {
  }

  private void rbCommentTheoThuTu_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void label13_Click(object sender, EventArgs e)
  {
  }

  private void rbCommentNgauNhien_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void btnUp_Click(object sender, EventArgs e) => this.plComment.Height = 195;

  private void btnDown_Click(object sender, EventArgs e) => this.plComment.Height = 237;

  private void button2_Click(object sender, EventArgs e)
  {
    GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
    this.txtComment.Focus();
  }

  private void button3_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHelpNhapComment());
    this.txtComment.Focus();
  }

  private void txtComment_TextChanged(object sender, EventArgs e)
  {
  }

  private void button4_Click(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Có thể dùng [u] để thay thế tên của người đăng bài!"));

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDBuffLikeComment));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.panel2 = new Panel();
    this.button3 = new Button();
    this.rbNganCachMoiDong = new RadioButton();
    this.button2 = new Button();
    this.rbNganCachKyTu = new RadioButton();
    this.label49 = new Label();
    this.nudSoLuongUidFrom = new NumericUpDown();
    this.label68 = new Label();
    this.nudSoLuongUidTo = new NumericUpDown();
    this.label66 = new Label();
    this.plComment = new Panel();
    this.panel3 = new Panel();
    this.rbCommentTheoThuTu = new RadioButton();
    this.rbCommentNgauNhien = new RadioButton();
    this.btnDown = new MetroButton();
    this.button4 = new Button();
    this.btnUp = new MetroButton();
    this.label13 = new Label();
    this.label8 = new Label();
    this.txtComment = new RichTextBox();
    this.label11 = new Label();
    this.lblStatus = new Label();
    this.plAnh = new Panel();
    this.txtAnh = new TextBox();
    this.label12 = new Label();
    this.txtIdPost = new RichTextBox();
    this.ckbSendAnh = new CheckBox();
    this.ckbComment = new CheckBox();
    this.label10 = new Label();
    this.label2 = new Label();
    this.ckbShareWall = new CheckBox();
    this.ckbInteract = new CheckBox();
    this.nudTimeTo = new NumericUpDown();
    this.nudDelayTo = new NumericUpDown();
    this.nudTimeFrom = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.txtTenHanhDong = new TextBox();
    this.label9 = new Label();
    this.label7 = new Label();
    this.label4 = new Label();
    this.label6 = new Label();
    this.label3 = new Label();
    this.label5 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    this.nudSoLuongUidFrom.BeginInit();
    this.nudSoLuongUidTo.BeginInit();
    this.plComment.SuspendLayout();
    this.panel3.SuspendLayout();
    this.plAnh.SuspendLayout();
    this.nudTimeTo.BeginInit();
    this.nudDelayTo.BeginInit();
    this.nudTimeFrom.BeginInit();
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
    this.bunifuCustomLabel1.Text = "Cấu hình Buff Like, Comment bài viết";
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
    this.panel1.Controls.Add((Control) this.panel2);
    this.panel1.Controls.Add((Control) this.label49);
    this.panel1.Controls.Add((Control) this.nudSoLuongUidFrom);
    this.panel1.Controls.Add((Control) this.label68);
    this.panel1.Controls.Add((Control) this.nudSoLuongUidTo);
    this.panel1.Controls.Add((Control) this.label66);
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.plAnh);
    this.panel1.Controls.Add((Control) this.txtIdPost);
    this.panel1.Controls.Add((Control) this.ckbSendAnh);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.label10);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.ckbShareWall);
    this.panel1.Controls.Add((Control) this.ckbInteract);
    this.panel1.Controls.Add((Control) this.nudTimeTo);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.nudTimeFrom);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label9);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label3);
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
    this.panel2.Controls.Add((Control) this.button3);
    this.panel2.Controls.Add((Control) this.rbNganCachMoiDong);
    this.panel2.Controls.Add((Control) this.button2);
    this.panel2.Controls.Add((Control) this.rbNganCachKyTu);
    this.panel2.Location = new Point(439, 274);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(200, 43);
    this.panel2.TabIndex = 42;
    this.button3.Cursor = Cursors.Help;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.Location = new Point(165, 22);
    this.button3.Name = "button3";
    this.button3.Size = new Size(21, 21);
    this.button3.TabIndex = 172;
    this.button3.Text = "?";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(3, 3);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(155, 20);
    this.rbNganCachMoiDong.TabIndex = 3;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.button2.Cursor = Cursors.Help;
    this.button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button2.Location = new Point(165, 1);
    this.button2.Name = "button2";
    this.button2.Size = new Size(21, 21);
    this.button2.TabIndex = 173;
    this.button2.Text = "?";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(3, 24);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(159, 20);
    this.rbNganCachKyTu.TabIndex = 3;
    this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.label49.AutoSize = true;
    this.label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label49.Location = new Point(26, 108);
    this.label49.Name = "label49";
    this.label49.Size = new Size(107, 16);
    this.label49.TabIndex = 169;
    this.label49.Text = "Số lượng ID/Nick:";
    this.nudSoLuongUidFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongUidFrom.Location = new Point(134, 106);
    this.nudSoLuongUidFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
    this.nudSoLuongUidFrom.Size = new Size(56, 23);
    this.nudSoLuongUidFrom.TabIndex = 167;
    this.nudSoLuongUidFrom.Value = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.label68.AutoSize = true;
    this.label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label68.Location = new Point(289, 108);
    this.label68.Name = "label68";
    this.label68.Size = new Size(19, 16);
    this.label68.TabIndex = 170;
    this.label68.Text = "ID";
    this.nudSoLuongUidTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongUidTo.Location = new Point(231, 106);
    this.nudSoLuongUidTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
    this.nudSoLuongUidTo.Size = new Size(56, 23);
    this.nudSoLuongUidTo.TabIndex = 168;
    this.nudSoLuongUidTo.Value = new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label66.Location = new Point(196, 108);
    this.label66.Name = "label66";
    this.label66.Size = new Size(29, 16);
    this.label66.TabIndex = 171;
    this.label66.Text = "đến";
    this.label66.TextAlign = ContentAlignment.MiddleCenter;
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.panel3);
    this.plComment.Controls.Add((Control) this.btnDown);
    this.plComment.Controls.Add((Control) this.button4);
    this.plComment.Controls.Add((Control) this.btnUp);
    this.plComment.Controls.Add((Control) this.label13);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.label11);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(371, 126);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(281, 195);
    this.plComment.TabIndex = 164;
    this.panel3.Controls.Add((Control) this.rbCommentTheoThuTu);
    this.panel3.Controls.Add((Control) this.rbCommentNgauNhien);
    this.panel3.Location = new Point(67, 191);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(200, 43);
    this.panel3.TabIndex = 43;
    this.rbCommentTheoThuTu.AutoSize = true;
    this.rbCommentTheoThuTu.Checked = true;
    this.rbCommentTheoThuTu.Cursor = Cursors.Hand;
    this.rbCommentTheoThuTu.Location = new Point(3, 2);
    this.rbCommentTheoThuTu.Name = "rbCommentTheoThuTu";
    this.rbCommentTheoThuTu.Size = new Size(201, 20);
    this.rbCommentTheoThuTu.TabIndex = 3;
    this.rbCommentTheoThuTu.TabStop = true;
    this.rbCommentTheoThuTu.Text = "Comment theo thứ tự nội dung";
    this.rbCommentTheoThuTu.UseVisualStyleBackColor = true;
    this.rbCommentTheoThuTu.CheckedChanged += new EventHandler(this.rbCommentTheoThuTu_CheckedChanged);
    this.rbCommentNgauNhien.AutoSize = true;
    this.rbCommentNgauNhien.Cursor = Cursors.Hand;
    this.rbCommentNgauNhien.Location = new Point(3, 23);
    this.rbCommentNgauNhien.Name = "rbCommentNgauNhien";
    this.rbCommentNgauNhien.Size = new Size(200, 20);
    this.rbCommentNgauNhien.TabIndex = 3;
    this.rbCommentNgauNhien.Text = "Comment ngẫu nhiên nội dung";
    this.rbCommentNgauNhien.UseVisualStyleBackColor = true;
    this.rbCommentNgauNhien.CheckedChanged += new EventHandler(this.rbCommentNgauNhien_CheckedChanged);
    this.btnDown.Cursor = Cursors.Hand;
    this.btnDown.Location = new Point(224, -1);
    this.btnDown.Name = "btnDown";
    this.btnDown.Size = new Size(25, 25);
    this.btnDown.TabIndex = 40;
    this.btnDown.UseSelectable = true;
    this.btnDown.Click += new EventHandler(this.btnDown_Click);
    this.button4.Cursor = Cursors.Help;
    this.button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button4.Location = new Point(136, 126);
    this.button4.Name = "button4";
    this.button4.Size = new Size(21, 21);
    this.button4.TabIndex = 173;
    this.button4.Text = "?";
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.btnUp.Cursor = Cursors.Hand;
    this.btnUp.Location = new Point((int) byte.MaxValue, -1);
    this.btnUp.Name = "btnUp";
    this.btnUp.Size = new Size(25, 25);
    this.btnUp.TabIndex = 41;
    this.btnUp.UseSelectable = true;
    this.btnUp.Click += new EventHandler(this.btnUp_Click);
    this.label13.AutoSize = true;
    this.label13.Location = new Point(4, 193);
    this.label13.Name = "label13";
    this.label13.Size = new Size(64, 16);
    this.label13.TabIndex = 2;
    this.label13.Text = "Tùy chọn:";
    this.label13.Click += new EventHandler(this.label13_Click);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(4, 150);
    this.label8.Name = "label8";
    this.label8.Size = new Size(64, 16);
    this.label8.TabIndex = 2;
    this.label8.Text = "Tùy chọn:";
    this.txtComment.Location = new Point(7, 25);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(263, 102);
    this.txtComment.TabIndex = 1;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(5, 128);
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
    this.plAnh.BorderStyle = BorderStyle.FixedSingle;
    this.plAnh.Controls.Add((Control) this.txtAnh);
    this.plAnh.Controls.Add((Control) this.label12);
    this.plAnh.Enabled = false;
    this.plAnh.Location = new Point(371, 348);
    this.plAnh.Name = "plAnh";
    this.plAnh.Size = new Size(281, 31);
    this.plAnh.TabIndex = 166;
    this.txtAnh.Location = new Point(136, 3);
    this.txtAnh.Name = "txtAnh";
    this.txtAnh.Size = new Size(140, 23);
    this.txtAnh.TabIndex = 155;
    this.label12.AutoSize = true;
    this.label12.Location = new Point(3, 6);
    this.label12.Name = "label12";
    this.label12.Size = new Size(137, 16);
    this.label12.TabIndex = 39;
    this.label12.Text = "Đường dẫn folder ảnh:";
    this.label12.Click += new EventHandler(this.label12_Click);
    this.txtIdPost.Location = new Point(30, 152);
    this.txtIdPost.Name = "txtIdPost";
    this.txtIdPost.Size = new Size(297, 207);
    this.txtIdPost.TabIndex = 1;
    this.txtIdPost.Text = "";
    this.txtIdPost.WordWrap = false;
    this.txtIdPost.TextChanged += new EventHandler(this.txtIdPost_TextChanged);
    this.ckbSendAnh.AutoSize = true;
    this.ckbSendAnh.Cursor = Cursors.Hand;
    this.ckbSendAnh.Location = new Point(353, 324);
    this.ckbSendAnh.Name = "ckbSendAnh";
    this.ckbSendAnh.Size = new Size(103, 20);
    this.ckbSendAnh.TabIndex = 165;
    this.ckbSendAnh.Text = "Bình luận ảnh";
    this.ckbSendAnh.UseVisualStyleBackColor = true;
    this.ckbSendAnh.CheckedChanged += new EventHandler(this.ckbSendAnh_CheckedChanged);
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(353, 103);
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
    this.label2.Location = new Point(27, 132);
    this.label2.Name = "label2";
    this.label2.Size = new Size(153, 16);
    this.label2.TabIndex = 40;
    this.label2.Text = "Danh sách ID bài viết (0):";
    this.ckbShareWall.AutoSize = true;
    this.ckbShareWall.Cursor = Cursors.Hand;
    this.ckbShareWall.Location = new Point(508, 79);
    this.ckbShareWall.Name = "ckbShareWall";
    this.ckbShareWall.Size = new Size(143, 20);
    this.ckbShareWall.TabIndex = 6;
    this.ckbShareWall.Text = "Chia sẻ bài về tường";
    this.ckbShareWall.UseVisualStyleBackColor = true;
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(353, 79);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(93, 20);
    this.ckbInteract.TabIndex = 5;
    this.ckbInteract.Text = "Like bài viết";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.nudTimeTo.Location = new Point(568, 50);
    this.nudTimeTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeTo.Name = "nudTimeTo";
    this.nudTimeTo.Size = new Size(51, 23);
    this.nudTimeTo.TabIndex = 4;
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
    this.nudTimeFrom.Location = new Point(490, 50);
    this.nudTimeFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeFrom.Name = "nudTimeFrom";
    this.nudTimeFrom.Size = new Size(51, 23);
    this.nudTimeFrom.TabIndex = 3;
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
    this.label9.Location = new Point(541, 52);
    this.label9.Name = "label9";
    this.label9.Size = new Size(29, 16);
    this.label9.TabIndex = 38;
    this.label9.Text = "đến";
    this.label9.TextAlign = ContentAlignment.MiddleCenter;
    this.label7.Location = new Point(196, 80);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 38;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(621, 52);
    this.label4.Name = "label4";
    this.label4.Size = new Size(30, 16);
    this.label4.TabIndex = 36;
    this.label4.Text = "giây";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(289, 80);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 36;
    this.label6.Text = "giây";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(350, 52);
    this.label3.Name = "label3";
    this.label3.Size = new Size(138, 16);
    this.label3.TabIndex = 34;
    this.label3.Text = "Thời gian xem bài viết:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 80);
    this.label5.Name = "label5";
    this.label5.Size = new Size(89, 16);
    this.label5.TabIndex = 34;
    this.label5.Text = "Thời gian chờ:";
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
    this.btnCancel.Location = new Point(349, 395);
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
    this.btnAdd.Location = new Point(242, 395);
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
    this.Name = nameof (fHDBuffLikeComment);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDBuffLikeComment_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.nudSoLuongUidFrom.EndInit();
    this.nudSoLuongUidTo.EndInit();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.panel3.ResumeLayout(false);
    this.panel3.PerformLayout();
    this.plAnh.ResumeLayout(false);
    this.plAnh.PerformLayout();
    this.nudTimeTo.EndInit();
    this.nudDelayTo.EndInit();
    this.nudTimeFrom.EndInit();
    this.nudDelayFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
