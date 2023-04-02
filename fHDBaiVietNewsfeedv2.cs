// Decompiled with JetBrains decompiler
// Type: fHDBaiVietNewsfeedv2
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fHDBaiVietNewsfeedv2 : Form
{
  private JObject jobject_0;
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
  private NumericUpDown nudTimeTo;
  private NumericUpDown nudDelayFrom;
  private NumericUpDown nudTimeFrom;
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
  private TextBox txtComment;
  private IContainer components;
  private CheckBox ckbShareWall;

  public fHDBaiVietNewsfeedv2(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDBaiVietNewsfeedv2.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDBaiVietNewsfeedv2").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBaiVietNewsfeedv2', '{  \"nudTimeFrom\": \"10\",  \"nudTimeTo\": \"30\",  \"nudDelayFrom\": \"2\",  \"nudDelayTo\": \"3\",  \"ckbInteract\": \"True\",  \"ckbShareWall\": \"False\",  \"ckbComment\": \"False\",  \"txtComment\": \"\"}', 'Bài viết Newsfeed v2');");
    string json = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDBaiVietNewsfeedv2");
        json = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        json = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.jobject_0 = JObject.Parse(json);
    GClass35.smethod_5((Control) this);
  }

  private void fHDBaiVietNewsfeedv2_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudTimeFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudTimeFrom"]);
      this.nudTimeTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudTimeTo"]);
      this.nudDelayFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudDelayFrom"]);
      this.nudDelayTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudDelayTo"]);
      this.ckbInteract.Checked = Convert.ToBoolean((object) this.jobject_0["ckbInteract"]);
      this.ckbShareWall.Checked = Convert.ToBoolean((object) this.jobject_0["ckbShareWall"]);
      this.ckbComment.Checked = Convert.ToBoolean((object) this.jobject_0["ckbComment"]);
      this.txtComment.Text = this.jobject_0["txtComment"].ToString();
    }
    catch
    {
    }
    this.method_1();
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (this.int_0 == 0)
    {
      if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
        return;
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
        gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
        gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
        gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
        gclass22.method_6("ckbShareWall", (object) this.ckbShareWall.Checked);
        gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
        gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
        string string_3 = gclass22.method_11();
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, string_3))
        {
          fHDBaiVietNewsfeedv2.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Thêm thất bại, vui lòng thử lại sau!"), 2);
      }
    }
    else
    {
      if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn cập nhật hành động?")) != DialogResult.Yes)
        return;
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
        gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
        gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
        gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
        gclass22.method_6("ckbShareWall", (object) this.ckbShareWall.Checked);
        gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
        gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
        string string_2 = gclass22.method_11();
        if (Class205.smethod_21(this.string_2, string_1, string_2))
        {
          fHDBaiVietNewsfeedv2.bool_0 = true;
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
    this.method_2((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
  }

  private void method_2(object sender, EventArgs e)
  {
  }

  private void ckbComment_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbComment.Checked;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDBaiVietNewsfeedv2));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plComment = new Panel();
    this.txtComment = new TextBox();
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.ckbComment = new CheckBox();
    this.ckbShareWall = new CheckBox();
    this.ckbInteract = new CheckBox();
    this.nudDelayTo = new NumericUpDown();
    this.nudTimeTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.nudTimeFrom = new NumericUpDown();
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
    this.plComment.SuspendLayout();
    this.nudDelayTo.BeginInit();
    this.nudTimeTo.BeginInit();
    this.nudDelayFrom.BeginInit();
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
    this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Newsfeed v2";
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
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.ckbShareWall);
    this.panel1.Controls.Add((Control) this.ckbInteract);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.nudTimeTo);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.nudTimeFrom);
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
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(48, 218);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(278, 164);
    this.plComment.TabIndex = 8;
    this.txtComment.Location = new Point(7, 27);
    this.txtComment.Multiline = true;
    this.txtComment.Name = "txtComment";
    this.txtComment.ScrollBars = ScrollBars.Both;
    this.txtComment.Size = new Size(261, 111);
    this.txtComment.TabIndex = 1;
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
    this.ckbComment.Location = new Point(30, 193);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size(130, 20);
    this.ckbComment.TabIndex = 7;
    this.ckbComment.Text = "Tự động bình luận";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.ckbShareWall.AutoSize = true;
    this.ckbShareWall.Cursor = Cursors.Hand;
    this.ckbShareWall.Location = new Point(30, 167);
    this.ckbShareWall.Name = "ckbShareWall";
    this.ckbShareWall.Size = new Size(122, 20);
    this.ckbShareWall.TabIndex = 6;
    this.ckbShareWall.Text = "Chia sẻ về tường";
    this.ckbShareWall.UseVisualStyleBackColor = true;
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(30, 141);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(48, 20);
    this.ckbInteract.TabIndex = 5;
    this.ckbInteract.Text = "Like";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.nudDelayTo.Location = new Point(231, 111);
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
    this.nudTimeTo.Location = new Point(231, 80);
    this.nudTimeTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeTo.Name = "nudTimeTo";
    this.nudTimeTo.Size = new Size(56, 23);
    this.nudTimeTo.TabIndex = 2;
    this.nudDelayFrom.Location = new Point(134, 111);
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
    this.nudTimeFrom.Location = new Point(134, 80);
    this.nudTimeFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeFrom.Name = "nudTimeFrom";
    this.nudTimeFrom.Size = new Size(56, 23);
    this.nudTimeFrom.TabIndex = 1;
    this.txtTenHanhDong.Location = new Point(134, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(196, 113);
    this.label7.Name = "label7";
    this.label7.Size = new Size(28, 16);
    this.label7.TabIndex = 38;
    this.label7.Text = "đến";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(196, 82);
    this.label3.Name = "label3";
    this.label3.Size = new Size(28, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(292, 113);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 36;
    this.label6.Text = "giây";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(292, 82);
    this.label4.Name = "label4";
    this.label4.Size = new Size(30, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "giây";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 113);
    this.label5.Name = "label5";
    this.label5.Size = new Size(110, 16);
    this.label5.TabIndex = 34;
    this.label5.Text = "Khoảng cách lướt:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 82);
    this.label2.Name = "label2";
    this.label2.Size = new Size(91, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Thời gian lướt:";
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
    this.Name = nameof (fHDBaiVietNewsfeedv2);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDBaiVietNewsfeedv2_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.nudDelayTo.EndInit();
    this.nudTimeTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.nudTimeFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
