// Decompiled with JetBrains decompiler
// Type: fHDTimKiemGoogle
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

public class fHDTimKiemGoogle : Form
{
  private GClass22 gclass22_0 = (GClass22) null;
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
  private RichTextBox txtTuKhoa;
  private NumericUpDown nudCountTimeScrollTo;
  private NumericUpDown nudCountLinkClickTo;
  private NumericUpDown nudCountPageTo;
  private NumericUpDown nudCountTuKhoaTo;
  private NumericUpDown nudCountTimeScrollFrom;
  private NumericUpDown nudCountLinkClickFrom;
  private NumericUpDown nudCountPageFrom;
  private NumericUpDown nudCountTuKhoaFrom;
  private Label label4;
  private Label label17;
  private Label label14;
  private Label label3;
  private Label label13;
  private Label label16;
  private Label label12;
  private Label label11;
  private Label label15;
  private Label label10;
  private IContainer components;
  private Label label9;

  public fHDTimKiemGoogle(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDTimKiemGoogle.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDTimKiemGoogle").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTimKiemGoogle', 'Tìm kiếm Google');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDTimKiemGoogle");
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
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.label9);
    GClass35.smethod_1((Control) this.label13);
    GClass35.smethod_1((Control) this.label11);
    GClass35.smethod_1((Control) this.label10);
    GClass35.smethod_1((Control) this.label14);
    GClass35.smethod_1((Control) this.label12);
    GClass35.smethod_1((Control) this.label15);
    GClass35.smethod_1((Control) this.label17);
    GClass35.smethod_1((Control) this.label16);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.label4);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDTimKiemGoogle_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudCountTuKhoaFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountTuKhoaFrom", 1);
      this.nudCountTuKhoaTo.Value = (Decimal) this.gclass22_0.method_3("nudCountTuKhoaTo", 1);
      this.nudCountPageFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountPageFrom", 3);
      this.nudCountPageTo.Value = (Decimal) this.gclass22_0.method_3("nudCountPageTo", 3);
      this.nudCountLinkClickFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountLinkClickFrom", 3);
      this.nudCountLinkClickTo.Value = (Decimal) this.gclass22_0.method_3("nudCountLinkClickTo", 5);
      this.nudCountTimeScrollFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountTimeScrollFrom", 30);
      this.nudCountTimeScrollTo.Value = (Decimal) this.gclass22_0.method_3("nudCountTimeScrollTo", 30);
      this.txtTuKhoa.Text = this.gclass22_0.method_1("txtTuKhoa");
    }
    catch
    {
    }
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

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
      gclass22.method_6("nudCountTuKhoaFrom", (object) this.nudCountTuKhoaFrom.Value);
      gclass22.method_6("nudCountTuKhoaTo", (object) this.nudCountTuKhoaTo.Value);
      gclass22.method_6("nudCountPageFrom", (object) this.nudCountPageFrom.Value);
      gclass22.method_6("nudCountPageTo", (object) this.nudCountPageTo.Value);
      gclass22.method_6("nudCountLinkClickFrom", (object) this.nudCountLinkClickFrom.Value);
      gclass22.method_6("nudCountLinkClickTo", (object) this.nudCountLinkClickTo.Value);
      gclass22.method_6("nudCountTimeScrollFrom", (object) this.nudCountTimeScrollFrom.Value);
      gclass22.method_6("nudCountTimeScrollTo", (object) this.nudCountTimeScrollTo.Value);
      gclass22.method_6("txtTuKhoa", (object) this.txtTuKhoa.Text.Trim());
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDTimKiemGoogle.bool_0 = true;
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
          fHDTimKiemGoogle.bool_0 = true;
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

  private void txtTuKhoa_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtTuKhoa.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Danh sách Từ khóa|Link Web ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDTimKiemGoogle));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.txtTuKhoa = new RichTextBox();
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.nudCountTimeScrollTo = new NumericUpDown();
    this.nudCountLinkClickTo = new NumericUpDown();
    this.nudCountPageTo = new NumericUpDown();
    this.nudCountTuKhoaTo = new NumericUpDown();
    this.nudCountTimeScrollFrom = new NumericUpDown();
    this.nudCountLinkClickFrom = new NumericUpDown();
    this.nudCountPageFrom = new NumericUpDown();
    this.nudCountTuKhoaFrom = new NumericUpDown();
    this.label4 = new Label();
    this.txtTenHanhDong = new TextBox();
    this.label17 = new Label();
    this.label14 = new Label();
    this.label3 = new Label();
    this.label13 = new Label();
    this.label16 = new Label();
    this.label12 = new Label();
    this.label11 = new Label();
    this.label15 = new Label();
    this.label10 = new Label();
    this.label9 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.nudCountTimeScrollTo.BeginInit();
    this.nudCountLinkClickTo.BeginInit();
    this.nudCountPageTo.BeginInit();
    this.nudCountTuKhoaTo.BeginInit();
    this.nudCountTimeScrollFrom.BeginInit();
    this.nudCountLinkClickFrom.BeginInit();
    this.nudCountPageFrom.BeginInit();
    this.nudCountTuKhoaFrom.BeginInit();
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
    this.bunifuCustomLabel1.Text = "Cấu hình Tìm kiếm Google";
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
    this.panel1.Controls.Add((Control) this.txtTuKhoa);
    this.panel1.Controls.Add((Control) this.label8);
    this.panel1.Controls.Add((Control) this.lblStatus);
    this.panel1.Controls.Add((Control) this.nudCountTimeScrollTo);
    this.panel1.Controls.Add((Control) this.nudCountLinkClickTo);
    this.panel1.Controls.Add((Control) this.nudCountPageTo);
    this.panel1.Controls.Add((Control) this.nudCountTuKhoaTo);
    this.panel1.Controls.Add((Control) this.nudCountTimeScrollFrom);
    this.panel1.Controls.Add((Control) this.nudCountLinkClickFrom);
    this.panel1.Controls.Add((Control) this.nudCountPageFrom);
    this.panel1.Controls.Add((Control) this.nudCountTuKhoaFrom);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label17);
    this.panel1.Controls.Add((Control) this.label14);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label13);
    this.panel1.Controls.Add((Control) this.label16);
    this.panel1.Controls.Add((Control) this.label12);
    this.panel1.Controls.Add((Control) this.label11);
    this.panel1.Controls.Add((Control) this.label15);
    this.panel1.Controls.Add((Control) this.label10);
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
    this.panel1.Size = new Size(362, 428);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.txtTuKhoa.Location = new Point(30, 94);
    this.txtTuKhoa.Name = "txtTuKhoa";
    this.txtTuKhoa.Size = new Size(298, 142);
    this.txtTuKhoa.TabIndex = 42;
    this.txtTuKhoa.Text = "";
    this.txtTuKhoa.WordWrap = false;
    this.txtTuKhoa.TextChanged += new EventHandler(this.txtTuKhoa_TextChanged);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(28, 239);
    this.label8.Name = "label8";
    this.label8.Size = new Size(133, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Mỗi nội dung 1 dòng)";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(27, 75);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(201, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Danh sách Từ khóa|Link Web (0):";
    this.nudCountTimeScrollTo.Location = new Point(263, 344);
    this.nudCountTimeScrollTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
    this.nudCountTimeScrollTo.Size = new Size(36, 23);
    this.nudCountTimeScrollTo.TabIndex = 2;
    this.nudCountLinkClickTo.Location = new Point(263, 316);
    this.nudCountLinkClickTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountLinkClickTo.Name = "nudCountLinkClickTo";
    this.nudCountLinkClickTo.Size = new Size(36, 23);
    this.nudCountLinkClickTo.TabIndex = 2;
    this.nudCountPageTo.Location = new Point(263, 288);
    this.nudCountPageTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountPageTo.Name = "nudCountPageTo";
    this.nudCountPageTo.Size = new Size(36, 23);
    this.nudCountPageTo.TabIndex = 2;
    this.nudCountTuKhoaTo.Location = new Point(263, 260);
    this.nudCountTuKhoaTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountTuKhoaTo.Name = "nudCountTuKhoaTo";
    this.nudCountTuKhoaTo.Size = new Size(36, 23);
    this.nudCountTuKhoaTo.TabIndex = 2;
    this.nudCountTimeScrollFrom.Location = new Point(192, 344);
    this.nudCountTimeScrollFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
    this.nudCountTimeScrollFrom.Size = new Size(36, 23);
    this.nudCountTimeScrollFrom.TabIndex = 1;
    this.nudCountLinkClickFrom.Location = new Point(192, 316);
    this.nudCountLinkClickFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
    this.nudCountLinkClickFrom.Size = new Size(36, 23);
    this.nudCountLinkClickFrom.TabIndex = 1;
    this.nudCountPageFrom.Location = new Point(192, 288);
    this.nudCountPageFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountPageFrom.Name = "nudCountPageFrom";
    this.nudCountPageFrom.Size = new Size(36, 23);
    this.nudCountPageFrom.TabIndex = 1;
    this.nudCountTuKhoaFrom.Location = new Point(192, 260);
    this.nudCountTuKhoaFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountTuKhoaFrom.Name = "nudCountTuKhoaFrom";
    this.nudCountTuKhoaFrom.Size = new Size(36, 23);
    this.nudCountTuKhoaFrom.TabIndex = 1;
    this.label4.Location = new Point(231, 346);
    this.label4.Name = "label4";
    this.label4.Size = new Size(29, 16);
    this.label4.TabIndex = 37;
    this.label4.Text = "đến";
    this.label4.TextAlign = ContentAlignment.MiddleCenter;
    this.txtTenHanhDong.Location = new Point(134, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label17.Location = new Point(231, 318);
    this.label17.Name = "label17";
    this.label17.Size = new Size(29, 16);
    this.label17.TabIndex = 37;
    this.label17.Text = "đến";
    this.label17.TextAlign = ContentAlignment.MiddleCenter;
    this.label14.Location = new Point(231, 290);
    this.label14.Name = "label14";
    this.label14.Size = new Size(29, 16);
    this.label14.TabIndex = 37;
    this.label14.Text = "đến";
    this.label14.TextAlign = ContentAlignment.MiddleCenter;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(299, 346);
    this.label3.Name = "label3";
    this.label3.Size = new Size(30, 16);
    this.label3.TabIndex = 35;
    this.label3.Text = "giây";
    this.label13.Location = new Point(231, 262);
    this.label13.Name = "label13";
    this.label13.Size = new Size(29, 16);
    this.label13.TabIndex = 37;
    this.label13.Text = "đến";
    this.label13.TextAlign = ContentAlignment.MiddleCenter;
    this.label16.AutoSize = true;
    this.label16.Location = new Point(299, 318);
    this.label16.Name = "label16";
    this.label16.Size = new Size(26, 16);
    this.label16.TabIndex = 35;
    this.label16.Text = "link";
    this.label12.AutoSize = true;
    this.label12.Location = new Point(299, 290);
    this.label12.Name = "label12";
    this.label12.Size = new Size(37, 16);
    this.label12.TabIndex = 35;
    this.label12.Text = "trang";
    this.label11.AutoSize = true;
    this.label11.Location = new Point(299, 262);
    this.label11.Name = "label11";
    this.label11.Size = new Size(50, 16);
    this.label11.TabIndex = 35;
    this.label11.Text = "từ khóa";
    this.label15.AutoSize = true;
    this.label15.Location = new Point(28, 318);
    this.label15.Name = "label15";
    this.label15.Size = new Size(164, 16);
    this.label15.TabIndex = 34;
    this.label15.Text = "Click random link trên web:";
    this.label10.AutoSize = true;
    this.label10.Location = new Point(27, 290);
    this.label10.Name = "label10";
    this.label10.Size = new Size(150, 16);
    this.label10.TabIndex = 34;
    this.label10.Text = "Số trang tìm kiếm tối đa:";
    this.label9.AutoSize = true;
    this.label9.Location = new Point(27, 262);
    this.label9.Name = "label9";
    this.label9.Size = new Size(120, 16);
    this.label9.TabIndex = 32;
    this.label9.Text = "Số từ khóa cần tìm:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 346);
    this.label2.Name = "label2";
    this.label2.Size = new Size(146, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Thời gian lướt trên web:";
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
    this.btnCancel.Location = new Point(189, 384);
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
    this.btnAdd.Location = new Point(82, 384);
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
    this.ClientSize = new Size(362, 428);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDTimKiemGoogle);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDTimKiemGoogle_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.nudCountTimeScrollTo.EndInit();
    this.nudCountLinkClickTo.EndInit();
    this.nudCountPageTo.EndInit();
    this.nudCountTuKhoaTo.EndInit();
    this.nudCountTimeScrollFrom.EndInit();
    this.nudCountLinkClickFrom.EndInit();
    this.nudCountPageFrom.EndInit();
    this.nudCountTuKhoaFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
