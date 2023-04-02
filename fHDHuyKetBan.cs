// Decompiled with JetBrains decompiler
// Type: fHDHuyKetBan
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

public class fHDHuyKetBan : Form
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
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label7;
  private Label label6;
  private Label label5;
  private RadioButton rbHuyTheoUid;
  private RadioButton rbHuyNgauNhien;
  private Label label8;
  private Panel plHuyTheoUid;
  private Label lblStatus;
  private RichTextBox txtUid;
  private Panel plHuyNgauNhien;
  private RichTextBox txtUidKhongHuyKetBan;
  private IContainer components;
  private Label label10;

  public fHDHuyKetBan(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDHuyKetBan.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDHuyKetBan");
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

  private void fHDHuyKetBan_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom");
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo");
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom");
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo");
      if (this.gclass22_0.method_3("typeHuyKetBan") == 0)
        this.rbHuyNgauNhien.Checked = true;
      else
        this.rbHuyTheoUid.Checked = true;
      this.txtUid.Text = this.gclass22_0.method_1("txtUid");
      this.txtUidKhongHuyKetBan.Text = this.gclass22_0.method_1("txtUidKhongHuyKetBan");
      this.rbHuyNgauNhien_CheckedChanged((object) null, (EventArgs) null);
      this.rbHuyTheoUid_CheckedChanged((object) null, (EventArgs) null);
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
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      if (this.rbHuyNgauNhien.Checked)
        gclass22.method_6("typeHuyKetBan", (object) 0);
      else
        gclass22.method_6("typeHuyKetBan", (object) 1);
      gclass22.method_6("txtUid", (object) this.txtUid.Text);
      gclass22.method_6("txtUidKhongHuyKetBan", (object) this.txtUidKhongHuyKetBan.Text);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDHuyKetBan.bool_0 = true;
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
          fHDHuyKetBan.bool_0 = true;
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

  private void txtUid_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Danh sách Uid cần hủy kết bạn ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void rbHuyNgauNhien_CheckedChanged(object sender, EventArgs e) => this.plHuyNgauNhien.Enabled = this.rbHuyNgauNhien.Checked;

  private void rbHuyTheoUid_CheckedChanged(object sender, EventArgs e) => this.plHuyTheoUid.Enabled = this.rbHuyTheoUid.Checked;

  private void txtUidKhongHuyKetBan_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtUidKhongHuyKetBan.Lines).ToList<string>());
      this.label10.Text = string.Format(GClass35.smethod_0("Danh sách UID bạn bè cần giữ lại ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void method_0(object sender, EventArgs e)
  {
  }

  private void label10_Click(object sender, EventArgs e)
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDHuyKetBan));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.txtUidKhongHuyKetBan = new RichTextBox();
    this.plHuyTheoUid = new Panel();
    this.lblStatus = new Label();
    this.txtUid = new RichTextBox();
    this.plHuyNgauNhien = new Panel();
    this.label2 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.nudSoLuongFrom = new NumericUpDown();
    this.nudSoLuongTo = new NumericUpDown();
    this.rbHuyTheoUid = new RadioButton();
    this.rbHuyNgauNhien = new RadioButton();
    this.nudDelayTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.label7 = new Label();
    this.label6 = new Label();
    this.label10 = new Label();
    this.label8 = new Label();
    this.label5 = new Label();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plHuyTheoUid.SuspendLayout();
    this.plHuyNgauNhien.SuspendLayout();
    this.nudSoLuongFrom.BeginInit();
    this.nudSoLuongTo.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(645, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Hủy kết bạn";
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
    this.pnlHeader.Size = new Size(645, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(614, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.txtUidKhongHuyKetBan);
    this.panel1.Controls.Add((Control) this.plHuyTheoUid);
    this.panel1.Controls.Add((Control) this.plHuyNgauNhien);
    this.panel1.Controls.Add((Control) this.rbHuyTheoUid);
    this.panel1.Controls.Add((Control) this.rbHuyNgauNhien);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label10);
    this.panel1.Controls.Add((Control) this.label8);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(648, 411);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.txtUidKhongHuyKetBan.BorderStyle = BorderStyle.FixedSingle;
    this.txtUidKhongHuyKetBan.Location = new Point(361, 99);
    this.txtUidKhongHuyKetBan.Name = "txtUidKhongHuyKetBan";
    this.txtUidKhongHuyKetBan.Size = new Size(253, 243);
    this.txtUidKhongHuyKetBan.TabIndex = 117;
    this.txtUidKhongHuyKetBan.Text = "";
    this.txtUidKhongHuyKetBan.WordWrap = false;
    this.txtUidKhongHuyKetBan.TextChanged += new EventHandler(this.txtUidKhongHuyKetBan_TextChanged);
    this.plHuyTheoUid.BorderStyle = BorderStyle.FixedSingle;
    this.plHuyTheoUid.Controls.Add((Control) this.lblStatus);
    this.plHuyTheoUid.Controls.Add((Control) this.txtUid);
    this.plHuyTheoUid.Location = new Point(59, 208);
    this.plHuyTheoUid.Name = "plHuyTheoUid";
    this.plHuyTheoUid.Size = new Size(267, 134);
    this.plHuyTheoUid.TabIndex = 118;
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 3);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(208, 16);
    this.lblStatus.TabIndex = 116;
    this.lblStatus.Text = "Danh sách Uid cần hủy kết bạn (0):";
    this.txtUid.BorderStyle = BorderStyle.FixedSingle;
    this.txtUid.Location = new Point(7, 23);
    this.txtUid.Name = "txtUid";
    this.txtUid.Size = new Size(253, 106);
    this.txtUid.TabIndex = 117;
    this.txtUid.Text = "";
    this.txtUid.WordWrap = false;
    this.txtUid.TextChanged += new EventHandler(this.txtUid_TextChanged);
    this.plHuyNgauNhien.BorderStyle = BorderStyle.FixedSingle;
    this.plHuyNgauNhien.Controls.Add((Control) this.label2);
    this.plHuyNgauNhien.Controls.Add((Control) this.label4);
    this.plHuyNgauNhien.Controls.Add((Control) this.label3);
    this.plHuyNgauNhien.Controls.Add((Control) this.nudSoLuongFrom);
    this.plHuyNgauNhien.Controls.Add((Control) this.nudSoLuongTo);
    this.plHuyNgauNhien.Location = new Point(59, 155);
    this.plHuyNgauNhien.Name = "plHuyNgauNhien";
    this.plHuyNgauNhien.Size = new Size(267, 27);
    this.plHuyNgauNhien.TabIndex = 118;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(3, 3);
    this.label2.Name = "label2";
    this.label2.Size = new Size(63, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Số lượng:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(225, 3);
    this.label4.Name = "label4";
    this.label4.Size = new Size(28, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "bạn";
    this.label3.Location = new Point(135, 3);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.nudSoLuongFrom.Location = new Point(73, 1);
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
    this.nudSoLuongTo.Location = new Point(167, 1);
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
    this.rbHuyTheoUid.AutoSize = true;
    this.rbHuyTheoUid.Cursor = Cursors.Hand;
    this.rbHuyTheoUid.Location = new Point(46, 185);
    this.rbHuyTheoUid.Name = "rbHuyTheoUid";
    this.rbHuyTheoUid.Size = new Size(145, 20);
    this.rbHuyTheoUid.TabIndex = 47;
    this.rbHuyTheoUid.Text = "Hủy kết bạn theo UID";
    this.rbHuyTheoUid.UseVisualStyleBackColor = true;
    this.rbHuyTheoUid.CheckedChanged += new EventHandler(this.rbHuyTheoUid_CheckedChanged);
    this.rbHuyNgauNhien.AutoSize = true;
    this.rbHuyNgauNhien.Checked = true;
    this.rbHuyNgauNhien.Cursor = Cursors.Hand;
    this.rbHuyNgauNhien.Location = new Point(46, 132);
    this.rbHuyNgauNhien.Name = "rbHuyNgauNhien";
    this.rbHuyNgauNhien.Size = new Size(176, 20);
    this.rbHuyNgauNhien.TabIndex = 47;
    this.rbHuyNgauNhien.TabStop = true;
    this.rbHuyNgauNhien.Text = "Ngẫu nhiên danh sách bạn";
    this.rbHuyNgauNhien.UseVisualStyleBackColor = true;
    this.rbHuyNgauNhien.CheckedChanged += new EventHandler(this.rbHuyNgauNhien_CheckedChanged);
    this.nudDelayTo.Location = new Point(226, 78);
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
    this.nudDelayFrom.Location = new Point(132, 78);
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
    this.label7.Location = new Point(192, 80);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 46;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(285, 80);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 45;
    this.label6.Text = "giây";
    this.label10.AutoSize = true;
    this.label10.Location = new Point(358, 80);
    this.label10.Name = "label10";
    this.label10.Size = new Size(222, 16);
    this.label10.TabIndex = 44;
    this.label10.Text = "Danh sách UID bạn bè cần giữ lại (0):";
    this.label10.Click += new EventHandler(this.label10_Click);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(27, 110);
    this.label8.Name = "label8";
    this.label8.Size = new Size(134, 16);
    this.label8.TabIndex = 44;
    this.label8.Text = "Tùy chọn hủy kết bạn:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 80);
    this.label5.Name = "label5";
    this.label5.Size = new Size(89, 16);
    this.label5.TabIndex = 44;
    this.label5.Text = "Thời gian chờ:";
    this.txtTenHanhDong.Location = new Point(132, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
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
    this.btnCancel.Location = new Point(351, 364);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 7;
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
    this.btnAdd.Location = new Point(244, 364);
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
    this.bunifuCards1.Size = new Size(645, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(648, 411);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDHuyKetBan);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDHuyKetBan_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plHuyTheoUid.ResumeLayout(false);
    this.plHuyTheoUid.PerformLayout();
    this.plHuyNgauNhien.ResumeLayout(false);
    this.plHuyNgauNhien.PerformLayout();
    this.nudSoLuongFrom.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
