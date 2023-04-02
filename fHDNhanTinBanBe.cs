// Decompiled with JetBrains decompiler
// Type: fHDNhanTinBanBe
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

public class fHDNhanTinBanBe : Form
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
  private TextBox txtTinNhan;
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label7;
  private Label label6;
  private Label label5;
  private RadioButton rbUidChiDinh;
  private RadioButton rbNgauNhien;
  private Label label9;
  private Panel plUidChiDinh;
  private TextBox txtUidChiDinh;
  private Label label10;
  private Label lblStatusUid;
  private RadioButton rbTrucTuyen;
  private IContainer components;
  private Button button2;

  public fHDNhanTinBanBe(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDNhanTinBanBe.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string json = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDNhanTinBanBe");
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
    GClass35.smethod_1((Control) this.label9);
    GClass35.smethod_1((Control) this.rbNgauNhien);
    GClass35.smethod_1((Control) this.rbUidChiDinh);
    GClass35.smethod_1((Control) this.rbTrucTuyen);
    GClass35.smethod_1((Control) this.lblStatusUid);
    GClass35.smethod_1((Control) this.label10);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDNhanTinBanBe_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudSoLuongFrom"]);
      this.nudSoLuongTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudSoLuongTo"]);
      this.nudDelayFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudDelayFrom"]);
      this.nudDelayTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudDelayTo"]);
      this.txtTinNhan.Text = this.jobject_0["txtTinNhan"].ToString();
      switch (Convert.ToInt32((object) this.jobject_0["typeDoiTuong"]))
      {
        case 0:
          this.rbNgauNhien.Checked = true;
          break;
        case 1:
          this.rbUidChiDinh.Checked = true;
          break;
        case 2:
          this.rbTrucTuyen.Checked = true;
          break;
      }
      this.txtUidChiDinh.Text = this.jobject_0["txtUidChiDinh"].ToString();
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
    else if (GClass19.smethod_39(((IEnumerable<string>) this.txtTinNhan.Lines).ToList<string>()).Count == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung tin nhắn!"), 3);
    else if (this.rbUidChiDinh.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtUidChiDinh.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách UID cần nhắn tin!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("txtTinNhan", (object) this.txtTinNhan.Text.Trim());
      if (this.rbNgauNhien.Checked)
        gclass22.method_6("typeDoiTuong", (object) 0);
      else if (this.rbUidChiDinh.Checked)
        gclass22.method_6("typeDoiTuong", (object) 1);
      else
        gclass22.method_6("typeDoiTuong", (object) 2);
      gclass22.method_6("txtUidChiDinh", (object) this.txtUidChiDinh.Text.Trim());
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDNhanTinBanBe.bool_0 = true;
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
          fHDNhanTinBanBe.bool_0 = true;
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
  }

  private void txtTinNhan_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtTinNhan.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Danh sách tin nhắn ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void rbUidChiDinh_CheckedChanged(object sender, EventArgs e) => this.method_2();

  private void method_2() => this.plUidChiDinh.Enabled = this.rbUidChiDinh.Checked;

  private void rbNgauNhien_CheckedChanged(object sender, EventArgs e) => this.method_2();

  private void txtUidChiDinh_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtUidChiDinh.Lines).ToList<string>());
      this.lblStatusUid.Text = string.Format(GClass35.smethod_0("Danh sách UID ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void panel1_Click(object sender, EventArgs e)
  {
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.rbTrucTuyen.Visible = true;
  }

  private void button2_Click(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"));

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDNhanTinBanBe));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.button2 = new Button();
    this.plUidChiDinh = new Panel();
    this.txtUidChiDinh = new TextBox();
    this.label10 = new Label();
    this.lblStatusUid = new Label();
    this.rbUidChiDinh = new RadioButton();
    this.rbTrucTuyen = new RadioButton();
    this.rbNgauNhien = new RadioButton();
    this.label9 = new Label();
    this.txtTinNhan = new TextBox();
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
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plUidChiDinh.SuspendLayout();
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
    this.bunifuCustomLabel1.Text = "Cấu hình Nhắn tin bạn bè";
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
    this.panel1.Controls.Add((Control) this.button2);
    this.panel1.Controls.Add((Control) this.plUidChiDinh);
    this.panel1.Controls.Add((Control) this.rbUidChiDinh);
    this.panel1.Controls.Add((Control) this.rbTrucTuyen);
    this.panel1.Controls.Add((Control) this.rbNgauNhien);
    this.panel1.Controls.Add((Control) this.label9);
    this.panel1.Controls.Add((Control) this.txtTinNhan);
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
    this.panel1.Size = new Size(690, 349);
    this.panel1.TabIndex = 0;
    this.panel1.Click += new EventHandler(this.panel1_Click);
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.button2.Cursor = Cursors.Help;
    this.button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button2.Location = new Point(304, 265);
    this.button2.Name = "button2";
    this.button2.Size = new Size(23, 23);
    this.button2.TabIndex = 47;
    this.button2.Text = "?";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.plUidChiDinh.BorderStyle = BorderStyle.FixedSingle;
    this.plUidChiDinh.Controls.Add((Control) this.txtUidChiDinh);
    this.plUidChiDinh.Controls.Add((Control) this.label10);
    this.plUidChiDinh.Controls.Add((Control) this.lblStatusUid);
    this.plUidChiDinh.Location = new Point(375, 120);
    this.plUidChiDinh.Name = "plUidChiDinh";
    this.plUidChiDinh.Size = new Size(281, 164);
    this.plUidChiDinh.TabIndex = 49;
    this.txtUidChiDinh.Location = new Point(7, 27);
    this.txtUidChiDinh.Multiline = true;
    this.txtUidChiDinh.Name = "txtUidChiDinh";
    this.txtUidChiDinh.ScrollBars = ScrollBars.Both;
    this.txtUidChiDinh.Size = new Size(266, 111);
    this.txtUidChiDinh.TabIndex = 1;
    this.txtUidChiDinh.WordWrap = false;
    this.txtUidChiDinh.TextChanged += new EventHandler(this.txtUidChiDinh_TextChanged);
    this.label10.AutoSize = true;
    this.label10.Location = new Point(4, 141);
    this.label10.Name = "label10";
    this.label10.Size = new Size(104, 16);
    this.label10.TabIndex = 0;
    this.label10.Text = "(Mỗi UID 1 dòng)";
    this.lblStatusUid.AutoSize = true;
    this.lblStatusUid.Location = new Point(3, 5);
    this.lblStatusUid.Name = "lblStatusUid";
    this.lblStatusUid.Size = new Size(116, 16);
    this.lblStatusUid.TabIndex = 0;
    this.lblStatusUid.Text = "Danh sách UID (0):";
    this.rbUidChiDinh.AutoSize = true;
    this.rbUidChiDinh.Cursor = Cursors.Hand;
    this.rbUidChiDinh.Location = new Point(375, 94);
    this.rbUidChiDinh.Name = "rbUidChiDinh";
    this.rbUidChiDinh.Size = new Size(93, 20);
    this.rbUidChiDinh.TabIndex = 48;
    this.rbUidChiDinh.Text = "UID chỉ định";
    this.rbUidChiDinh.UseVisualStyleBackColor = true;
    this.rbUidChiDinh.CheckedChanged += new EventHandler(this.rbUidChiDinh_CheckedChanged);
    this.rbTrucTuyen.AutoSize = true;
    this.rbTrucTuyen.Checked = true;
    this.rbTrucTuyen.Cursor = Cursors.Hand;
    this.rbTrucTuyen.Location = new Point(479, 94);
    this.rbTrucTuyen.Name = "rbTrucTuyen";
    this.rbTrucTuyen.Size = new Size(186, 20);
    this.rbTrucTuyen.TabIndex = 48;
    this.rbTrucTuyen.TabStop = true;
    this.rbTrucTuyen.Text = "Đang trực tuyến (Chưa làm)";
    this.rbTrucTuyen.UseVisualStyleBackColor = true;
    this.rbTrucTuyen.Visible = false;
    this.rbTrucTuyen.CheckedChanged += new EventHandler(this.rbNgauNhien_CheckedChanged);
    this.rbNgauNhien.AutoSize = true;
    this.rbNgauNhien.Checked = true;
    this.rbNgauNhien.Cursor = Cursors.Hand;
    this.rbNgauNhien.Location = new Point(375, 71);
    this.rbNgauNhien.Name = "rbNgauNhien";
    this.rbNgauNhien.Size = new Size(176, 20);
    this.rbNgauNhien.TabIndex = 48;
    this.rbNgauNhien.TabStop = true;
    this.rbNgauNhien.Text = "Ngẫu nhiên danh sách bạn";
    this.rbNgauNhien.UseVisualStyleBackColor = true;
    this.rbNgauNhien.CheckedChanged += new EventHandler(this.rbNgauNhien_CheckedChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(372, 49);
    this.label9.Name = "label9";
    this.label9.Size = new Size(172, 16);
    this.label9.TabIndex = 47;
    this.label9.Text = "Tùy chọn đối tượng nhắn tin:";
    this.txtTinNhan.Location = new Point(31, 158);
    this.txtTinNhan.Multiline = true;
    this.txtTinNhan.Name = "txtTinNhan";
    this.txtTinNhan.ScrollBars = ScrollBars.Both;
    this.txtTinNhan.Size = new Size(295, 107);
    this.txtTinNhan.TabIndex = 5;
    this.txtTinNhan.WordWrap = false;
    this.txtTinNhan.TextChanged += new EventHandler(this.txtTinNhan_TextChanged);
    this.nudDelayTo.Location = new Point(229, 111);
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
    this.label8.Location = new Point(27, 268);
    this.label8.Name = "label8";
    this.label8.Size = new Size(265, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(27, 139);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(142, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Danh sách tin nhắn (0):";
    this.nudDelayFrom.Location = new Point(132, 111);
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
    this.label7.AutoSize = true;
    this.label7.Location = new Point(194, 113);
    this.label7.Name = "label7";
    this.label7.Size = new Size(28, 16);
    this.label7.TabIndex = 46;
    this.label7.Text = "đến";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(290, 113);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 45;
    this.label6.Text = "giây";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 113);
    this.label5.Name = "label5";
    this.label5.Size = new Size(89, 16);
    this.label5.TabIndex = 44;
    this.label5.Text = "Thời gian chờ:";
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
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(194, 82);
    this.label3.Name = "label3";
    this.label3.Size = new Size(28, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(290, 82);
    this.label4.Name = "label4";
    this.label4.Size = new Size(28, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "bạn";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 82);
    this.label2.Name = "label2";
    this.label2.Size = new Size(88, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Số lượng bạn:";
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
    this.btnCancel.Location = new Point(353, 305);
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
    this.btnAdd.Location = new Point(246, 305);
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
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(690, 349);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDNhanTinBanBe);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDNhanTinBanBe_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plUidChiDinh.ResumeLayout(false);
    this.plUidChiDinh.PerformLayout();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
