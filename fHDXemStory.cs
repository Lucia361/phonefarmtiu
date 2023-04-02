// Decompiled with JetBrains decompiler
// Type: fHDXemStory
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fHDXemStory : Form
{
  private GClass22 gclass22_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private List<CheckBox> list_0;
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
  private Panel plComment;
  private Label lblStatus;
  private CheckBox ckbComment;
  private CheckBox ckbInteract;
  private TextBox txtComment;
  private Label label8;
  private Panel plInteract;
  private CheckBox ckbGian;
  private CheckBox ckbBuon;
  private CheckBox ckbWow;
  private CheckBox ckbHaha;
  private CheckBox ckbThuong;
  private CheckBox ckbTym;
  private CheckBox ckbLike;
  private Panel panel7;
  private RadioButton radioButton3;
  private RadioButton radioButton4;
  private IContainer components;
  private Label label26;

  public fHDXemStory(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDXemStory.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDXemStory");
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
  }

  private void fHDXemStory_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom");
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo");
      this.ckbInteract.Checked = this.gclass22_0.method_4("ckbInteract");
      string str = this.gclass22_0.method_1("typeReaction");
      this.list_0 = new List<CheckBox>()
      {
        this.ckbLike,
        this.ckbTym,
        this.ckbThuong,
        this.ckbHaha,
        this.ckbWow,
        this.ckbBuon,
        this.ckbGian
      };
      for (int index = 0; index < this.list_0.Count; ++index)
        this.list_0[index].Checked = str.Contains(index.ToString());
      this.ckbComment.Checked = this.gclass22_0.method_4("ckbComment");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
    }
    catch
    {
    }
    this.method_0();
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
      gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
      string object_0 = "";
      for (int index = 0; index < this.list_0.Count; ++index)
        object_0 += this.list_0[index].Checked ? index.ToString() ?? "" : "";
      gclass22.method_6("typeReaction", (object) object_0);
      gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDXemStory.bool_0 = true;
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
          fHDXemStory.bool_0 = true;
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

  private void method_0()
  {
    this.ckbInteract_CheckedChanged((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
  }

  private void ckbInteract_CheckedChanged(object sender, EventArgs e) => this.plInteract.Enabled = this.ckbInteract.Checked;

  private void ckbComment_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbComment.Checked;

  private void method_1(object sender, EventArgs e) => this.ckbLike.Checked = !this.ckbLike.Checked;

  private void method_2(object sender, EventArgs e) => this.ckbTym.Checked = !this.ckbTym.Checked;

  private void method_3(object sender, EventArgs e) => this.ckbHaha.Checked = !this.ckbHaha.Checked;

  private void method_4(object sender, EventArgs e) => this.ckbWow.Checked = !this.ckbWow.Checked;

  private void method_5(object sender, EventArgs e) => this.ckbBuon.Checked = !this.ckbBuon.Checked;

  private void method_6(object sender, EventArgs e) => this.ckbGian.Checked = !this.ckbGian.Checked;

  private void method_7(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Có thể dùng [u] để thay thế tên của người đăng story!"));

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDXemStory));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plInteract = new Panel();
    this.ckbGian = new CheckBox();
    this.ckbBuon = new CheckBox();
    this.ckbWow = new CheckBox();
    this.ckbHaha = new CheckBox();
    this.ckbThuong = new CheckBox();
    this.ckbTym = new CheckBox();
    this.ckbLike = new CheckBox();
    this.panel7 = new Panel();
    this.radioButton3 = new RadioButton();
    this.radioButton4 = new RadioButton();
    this.label26 = new Label();
    this.plComment = new Panel();
    this.label8 = new Label();
    this.txtComment = new TextBox();
    this.lblStatus = new Label();
    this.ckbComment = new CheckBox();
    this.ckbInteract = new CheckBox();
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
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plInteract.SuspendLayout();
    this.panel7.SuspendLayout();
    this.plComment.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(391, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Xem Story";
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
    this.pnlHeader.Size = new Size(391, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(360, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plInteract);
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.ckbInteract);
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
    this.panel1.Size = new Size(394, 423);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plInteract.BorderStyle = BorderStyle.FixedSingle;
    this.plInteract.Controls.Add((Control) this.ckbGian);
    this.plInteract.Controls.Add((Control) this.ckbBuon);
    this.plInteract.Controls.Add((Control) this.ckbWow);
    this.plInteract.Controls.Add((Control) this.ckbHaha);
    this.plInteract.Controls.Add((Control) this.ckbThuong);
    this.plInteract.Controls.Add((Control) this.ckbTym);
    this.plInteract.Controls.Add((Control) this.ckbLike);
    this.plInteract.Controls.Add((Control) this.panel7);
    this.plInteract.Controls.Add((Control) this.label26);
    this.plInteract.Location = new Point(48, 135);
    this.plInteract.Name = "plInteract";
    this.plInteract.Size = new Size(312, 33);
    this.plInteract.TabIndex = 181;
    this.ckbGian.Cursor = Cursors.Hand;
    this.ckbGian.Image = (Image) Resources.angry;
    this.ckbGian.Location = new Point(266, 1);
    this.ckbGian.Name = "ckbGian";
    this.ckbGian.Size = new Size(40, 30);
    this.ckbGian.TabIndex = 179;
    this.ckbGian.UseVisualStyleBackColor = true;
    this.ckbBuon.Cursor = Cursors.Hand;
    this.ckbBuon.Image = (Image) Resources.sad;
    this.ckbBuon.Location = new Point(222, 1);
    this.ckbBuon.Name = "ckbBuon";
    this.ckbBuon.Size = new Size(40, 30);
    this.ckbBuon.TabIndex = 178;
    this.ckbBuon.UseVisualStyleBackColor = true;
    this.ckbWow.Cursor = Cursors.Hand;
    this.ckbWow.Image = (Image) Resources.wow;
    this.ckbWow.Location = new Point(178, 1);
    this.ckbWow.Name = "ckbWow";
    this.ckbWow.Size = new Size(40, 30);
    this.ckbWow.TabIndex = 177;
    this.ckbWow.UseVisualStyleBackColor = true;
    this.ckbHaha.Cursor = Cursors.Hand;
    this.ckbHaha.Image = (Image) Resources.haha;
    this.ckbHaha.Location = new Point(134, 1);
    this.ckbHaha.Name = "ckbHaha";
    this.ckbHaha.Size = new Size(40, 30);
    this.ckbHaha.TabIndex = 176;
    this.ckbHaha.UseVisualStyleBackColor = true;
    this.ckbThuong.Cursor = Cursors.Hand;
    this.ckbThuong.Image = (Image) Resources.care;
    this.ckbThuong.Location = new Point(90, 1);
    this.ckbThuong.Name = "ckbThuong";
    this.ckbThuong.Size = new Size(40, 30);
    this.ckbThuong.TabIndex = 175;
    this.ckbThuong.UseVisualStyleBackColor = true;
    this.ckbTym.Cursor = Cursors.Hand;
    this.ckbTym.Image = (Image) Resources.love;
    this.ckbTym.Location = new Point(46, 1);
    this.ckbTym.Name = "ckbTym";
    this.ckbTym.Size = new Size(40, 30);
    this.ckbTym.TabIndex = 174;
    this.ckbTym.UseVisualStyleBackColor = true;
    this.ckbLike.Checked = true;
    this.ckbLike.CheckState = CheckState.Checked;
    this.ckbLike.Cursor = Cursors.Hand;
    this.ckbLike.Image = (Image) Resources.like1;
    this.ckbLike.Location = new Point(2, 1);
    this.ckbLike.Name = "ckbLike";
    this.ckbLike.Size = new Size(40, 30);
    this.ckbLike.TabIndex = 173;
    this.ckbLike.UseVisualStyleBackColor = true;
    this.panel7.Controls.Add((Control) this.radioButton3);
    this.panel7.Controls.Add((Control) this.radioButton4);
    this.panel7.Location = new Point(67, 300);
    this.panel7.Name = "panel7";
    this.panel7.Size = new Size(200, 43);
    this.panel7.TabIndex = 43;
    this.radioButton3.AutoSize = true;
    this.radioButton3.Checked = true;
    this.radioButton3.Cursor = Cursors.Hand;
    this.radioButton3.Location = new Point(3, 2);
    this.radioButton3.Name = "radioButton3";
    this.radioButton3.Size = new Size(201, 20);
    this.radioButton3.TabIndex = 3;
    this.radioButton3.TabStop = true;
    this.radioButton3.Text = "Comment theo thứ tự nội dung";
    this.radioButton3.UseVisualStyleBackColor = true;
    this.radioButton4.AutoSize = true;
    this.radioButton4.Cursor = Cursors.Hand;
    this.radioButton4.Location = new Point(3, 23);
    this.radioButton4.Name = "radioButton4";
    this.radioButton4.Size = new Size(200, 20);
    this.radioButton4.TabIndex = 3;
    this.radioButton4.Text = "Comment ngẫu nhiên nội dung";
    this.radioButton4.UseVisualStyleBackColor = true;
    this.label26.AutoSize = true;
    this.label26.Location = new Point(4, 302);
    this.label26.Name = "label26";
    this.label26.Size = new Size(64, 16);
    this.label26.TabIndex = 2;
    this.label26.Text = "Tùy chọn:";
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(48, 202);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(312, 164);
    this.plComment.TabIndex = 8;
    this.label8.AutoSize = true;
    this.label8.Location = new Point(3, 141);
    this.label8.Name = "label8";
    this.label8.Size = new Size(265, 16);
    this.label8.TabIndex = 2;
    this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
    this.txtComment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtComment.Location = new Point(7, 27);
    this.txtComment.Multiline = true;
    this.txtComment.Name = "txtComment";
    this.txtComment.ScrollBars = ScrollBars.Both;
    this.txtComment.Size = new Size(295, 111);
    this.txtComment.TabIndex = 1;
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(139, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung bình luận (0):";
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(30, 177);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size(130, 20);
    this.ckbComment.TabIndex = 7;
    this.ckbComment.Text = "Tự động bình luận";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(30, 109);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(112, 20);
    this.ckbInteract.TabIndex = 5;
    this.ckbInteract.Text = "Bày tỏ cảm xúc";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.nudSoLuongTo.Location = new Point(229, 80);
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
    this.nudSoLuongFrom.Location = new Point(132, 80);
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
    this.txtTenHanhDong.Size = new Size(228, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label3.Location = new Point(194, 82);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(290, 82);
    this.label4.Name = "label4";
    this.label4.Size = new Size(30, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "giây";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 82);
    this.label2.Name = "label2";
    this.label2.Size = new Size(93, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Thời gian xem:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(27, 52);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 16);
    this.label1.TabIndex = 31;
    this.label1.Text = "Tên hành động:";
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(205, 380);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 10;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(98, 380);
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
    this.bunifuCards1.Size = new Size(391, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(394, 423);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDXemStory);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDXemStory_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plInteract.ResumeLayout(false);
    this.plInteract.PerformLayout();
    this.panel7.ResumeLayout(false);
    this.panel7.PerformLayout();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
