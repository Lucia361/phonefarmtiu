// Decompiled with JetBrains decompiler
// Type: fHDTuongTacLivestream
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

public class fHDTuongTacLivestream : Form
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
  private Panel plComment;
  private Label lblStatus;
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
  private TextBox txtComment;
  private Label label8;
  private Panel plBinhLuanNhieuLan;
  private NumericUpDown nudBinhLuanNhieuLanDelayTo;
  private Label lblmc1;
  private NumericUpDown nudBinhLuanNhieuLanDelayFrom;
  private Label label5;
  private Label label6;
  private CheckBox ckbBinhLuanNhieuLan;
  private TextBox txtLinkVideo;
  private Label label9;
  private IContainer components;
  private LinkLabel linkLabel1;

  public fHDTuongTacLivestream(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDTuongTacLivestream.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1_1 = this.Name.Substring(1);
    string str = "Tương tác Livestream";
    if (Class205.smethod_13(string_1: string_1_1).Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + string_1_1 + "', '" + str + "');");
    string string_1_2 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: string_1_1);
        string_1_2 = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        string_1_2 = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.gclass22_0 = new GClass22(string_1_2, true);
    GClass35.smethod_5((Control) this);
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.label4);
    GClass35.smethod_1((Control) this.ckbInteract);
    GClass35.smethod_1((Control) this.label26);
    GClass35.smethod_1((Control) this.label30);
    GClass35.smethod_1((Control) this.label32);
    GClass35.smethod_1((Control) this.ckbComment);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
    GClass35.smethod_1((Control) this.ckbBinhLuanNhieuLan);
    GClass35.smethod_1((Control) this.label6);
    GClass35.smethod_1((Control) this.label5);
  }

  private void fHDTuongTacLivestream_Load(object sender, EventArgs e)
  {
    try
    {
      this.txtLinkVideo.Text = this.gclass22_0.method_1("txtLinkVideo");
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
      gclass22.method_6("txtLinkVideo", (object) this.txtLinkVideo.Text.Trim());
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
      string object_0 = "";
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
          object_0 += index.ToString();
      }
      gclass22.method_6("typeReaction", (object) object_0);
      gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      gclass22.method_6("ckbBinhLuanNhieuLan", (object) this.ckbBinhLuanNhieuLan.Checked);
      gclass22.method_6("nudBinhLuanNhieuLanDelayFrom", (object) this.nudBinhLuanNhieuLanDelayFrom.Value);
      gclass22.method_6("nudBinhLuanNhieuLanDelayTo", (object) this.nudBinhLuanNhieuLanDelayTo.Value);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDTuongTacLivestream.bool_0 = true;
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
          fHDTuongTacLivestream.bool_0 = true;
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
    this.ckbBinhLuanNhieuLan_CheckedChanged((object) null, (EventArgs) null);
  }

  private void ckbInteract_CheckedChanged(object sender, EventArgs e) => this.plInteract.Enabled = this.ckbInteract.Checked;

  private void ckbComment_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbComment.Checked;

  private void label25_Click(object sender, EventArgs e) => this.ckbLike.Checked = !this.ckbLike.Checked;

  private void label26_Click(object sender, EventArgs e) => this.ckbTym.Checked = !this.ckbTym.Checked;

  private void label28_Click(object sender, EventArgs e) => this.ckbHaha.Checked = !this.ckbHaha.Checked;

  private void label29_Click(object sender, EventArgs e) => this.ckbWow.Checked = !this.ckbWow.Checked;

  private void label30_Click(object sender, EventArgs e) => this.ckbBuon.Checked = !this.ckbBuon.Checked;

  private void label32_Click(object sender, EventArgs e) => this.ckbGian.Checked = !this.ckbGian.Checked;

  private void ckbBinhLuanNhieuLan_CheckedChanged(object sender, EventArgs e) => this.plBinhLuanNhieuLan.Enabled = this.ckbBinhLuanNhieuLan.Checked;

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => GClass19.smethod_35((Form) new fHuongDanRandom());

  private void label8_Click(object sender, EventArgs e)
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDTuongTacLivestream));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plComment = new Panel();
    this.linkLabel1 = new LinkLabel();
    this.plBinhLuanNhieuLan = new Panel();
    this.nudBinhLuanNhieuLanDelayTo = new NumericUpDown();
    this.lblmc1 = new Label();
    this.nudBinhLuanNhieuLanDelayFrom = new NumericUpDown();
    this.label5 = new Label();
    this.label6 = new Label();
    this.ckbBinhLuanNhieuLan = new CheckBox();
    this.label8 = new Label();
    this.txtComment = new TextBox();
    this.lblStatus = new Label();
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
    this.txtLinkVideo = new TextBox();
    this.txtTenHanhDong = new TextBox();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label9 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plComment.SuspendLayout();
    this.plBinhLuanNhieuLan.SuspendLayout();
    this.nudBinhLuanNhieuLanDelayTo.BeginInit();
    this.nudBinhLuanNhieuLanDelayFrom.BeginInit();
    this.plInteract.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(359, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Tương tác Livestream";
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
    this.panel1.Controls.Add((Control) this.plInteract);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.ckbInteract);
    this.panel1.Controls.Add((Control) this.nudSoLuongTo);
    this.panel1.Controls.Add((Control) this.nudSoLuongFrom);
    this.panel1.Controls.Add((Control) this.txtLinkVideo);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.label9);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(362, 503);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.linkLabel1);
    this.plComment.Controls.Add((Control) this.plBinhLuanNhieuLan);
    this.plComment.Controls.Add((Control) this.ckbBinhLuanNhieuLan);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(48, 229);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(278, 213);
    this.plComment.TabIndex = 8;
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.Cursor = Cursors.Hand;
    this.linkLabel1.Location = new Point(190, 141);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(81, 16);
    this.linkLabel1.TabIndex = 192;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "Random icon";
    this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
    this.nudBinhLuanNhieuLanDelayTo.Location = new Point(166, 2);
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
    this.nudBinhLuanNhieuLanDelayFrom.Location = new Point(88, 2);
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
    this.label5.Location = new Point(218, 4);
    this.label5.Name = "label5";
    this.label5.Size = new Size(30, 16);
    this.label5.TabIndex = 20;
    this.label5.Text = "giây";
    this.label6.Location = new Point(135, 4);
    this.label6.Name = "label6";
    this.label6.Size = new Size(29, 16);
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
    this.label8.AutoSize = true;
    this.label8.Location = new Point(3, 141);
    this.label8.Name = "label8";
    this.label8.Size = new Size(143, 16);
    this.label8.TabIndex = 2;
    this.label8.Text = "(Spin nội dung {a|b|c})";
    this.label8.Click += new EventHandler(this.label8_Click);
    this.txtComment.Location = new Point(7, 27);
    this.txtComment.Multiline = true;
    this.txtComment.Name = "txtComment";
    this.txtComment.ScrollBars = ScrollBars.Both;
    this.txtComment.Size = new Size(261, 111);
    this.txtComment.TabIndex = 1;
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(139, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung bình luận (0):";
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
    this.plInteract.Location = new Point(48, 160);
    this.plInteract.Name = "plInteract";
    this.plInteract.Size = new Size(278, 40);
    this.plInteract.TabIndex = 6;
    this.label25.Cursor = Cursors.Hand;
    this.label25.Location = new Point(4, 1);
    this.label25.Name = "label25";
    this.label25.Size = new Size(30, 16);
    this.label25.TabIndex = 0;
    this.label25.Text = "Like";
    this.label25.TextAlign = ContentAlignment.MiddleCenter;
    this.label25.Click += new EventHandler(this.label25_Click);
    this.label26.Cursor = Cursors.Hand;
    this.label26.Location = new Point(46, 1);
    this.label26.Name = "label26";
    this.label26.Size = new Size(39, 16);
    this.label26.TabIndex = 2;
    this.label26.Text = "Tym";
    this.label26.TextAlign = ContentAlignment.MiddleCenter;
    this.label26.Click += new EventHandler(this.label26_Click);
    this.label28.Cursor = Cursors.Hand;
    this.label28.Location = new Point(93, 1);
    this.label28.Name = "label28";
    this.label28.Size = new Size(37, 16);
    this.label28.TabIndex = 6;
    this.label28.Text = "Haha";
    this.label28.TextAlign = ContentAlignment.MiddleCenter;
    this.label28.Click += new EventHandler(this.label28_Click);
    this.label29.Cursor = Cursors.Hand;
    this.label29.Location = new Point(140, 1);
    this.label29.Name = "label29";
    this.label29.Size = new Size(37, 16);
    this.label29.TabIndex = 8;
    this.label29.Text = "Wow";
    this.label29.TextAlign = ContentAlignment.MiddleCenter;
    this.label29.Click += new EventHandler(this.label29_Click);
    this.label30.Cursor = Cursors.Hand;
    this.label30.Location = new Point(187, 1);
    this.label30.Name = "label30";
    this.label30.Size = new Size(36, 16);
    this.label30.TabIndex = 10;
    this.label30.Text = "Buồn";
    this.label30.TextAlign = ContentAlignment.MiddleCenter;
    this.label30.Click += new EventHandler(this.label30_Click);
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
    this.label32.Location = new Point(233, 1);
    this.label32.Name = "label32";
    this.label32.Size = new Size(41, 16);
    this.label32.TabIndex = 12;
    this.label32.Text = "Giận";
    this.label32.TextAlign = ContentAlignment.MiddleCenter;
    this.label32.Click += new EventHandler(this.label32_Click);
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(30, 204);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size(130, 20);
    this.ckbComment.TabIndex = 7;
    this.ckbComment.Text = "Tự động bình luận";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(30, 136);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(112, 20);
    this.ckbInteract.TabIndex = 5;
    this.ckbInteract.Text = "Bày tỏ cảm xúc";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.nudSoLuongTo.Location = new Point(229, 107);
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
    this.nudSoLuongFrom.Location = new Point(132, 107);
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
    this.txtLinkVideo.Location = new Point(132, 78);
    this.txtLinkVideo.Name = "txtLinkVideo";
    this.txtLinkVideo.Size = new Size(194, 23);
    this.txtLinkVideo.TabIndex = 0;
    this.txtTenHanhDong.Location = new Point(132, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label3.Location = new Point(194, 109);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(290, 109);
    this.label4.Name = "label4";
    this.label4.Size = new Size(30, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "giây";
    this.label9.AutoSize = true;
    this.label9.Location = new Point(27, 81);
    this.label9.Name = "label9";
    this.label9.Size = new Size(97, 16);
    this.label9.TabIndex = 31;
    this.label9.Text = "Link livestream:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 109);
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
    this.btnCancel.Location = new Point(189, 459);
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
    this.btnAdd.Location = new Point(82, 459);
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
    this.ClientSize = new Size(362, 503);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDTuongTacLivestream);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDTuongTacLivestream_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
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
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
