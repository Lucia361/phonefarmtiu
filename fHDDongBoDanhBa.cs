// Decompiled with JetBrains decompiler
// Type: fHDDongBoDanhBa
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fHDDongBoDanhBa : Form
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
  private TextBox txtTenHanhDong;
  private Label label1;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private NumericUpDown nudSoLuongTo;
  private NumericUpDown nudSoLuongFrom;
  private Label label7;
  private Label label6;
  private Label label5;
  private Label label10;
  private Label lblStatusUid;
  private CheckBox ckbTuDongXoa;
  private Button button1;
  private RichTextBox txtSdt;
  private Panel plAutoAddFriend;
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label2;
  private Label label3;
  private Label label4;
  private NumericUpDown nudSoLuongKetBanTo;
  private NumericUpDown nudSoLuongKetBanFrom;
  private Label label8;
  private Label label9;
  private Label label11;
  private IContainer components;
  private RichTextBox txtSdtData;
  private Label lblStatusUidData;
  private CheckBox ckbAutoAddFriend;

  public fHDDongBoDanhBa(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDDongBoDanhBa.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1_1 = "HDDongBoDanhBa";
    string str = "Đồng bộ danh bạ";
    if (Class205.smethod_13(string_1: "HDDongBoDanhBa").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + string_1_1 + "', '" + str + "');");
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

  private void fHDDongBoDanhBa_Load(object sender, EventArgs e)
  {
    try
    {
      this.txtSdt.Text = this.gclass22_0.method_1("txtSdt");
      this.txtSdtData.Text = this.gclass22_0.method_1("txtSdtData");
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom", 10);
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo", 10);
      this.ckbTuDongXoa.Checked = this.gclass22_0.method_4("ckbTuDongXoa");
      this.ckbAutoAddFriend.Checked = this.gclass22_0.method_4("ckbAutoAddFriend");
      this.nudSoLuongKetBanFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongKetBanFrom", 2);
      this.nudSoLuongKetBanTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongKetBanTo", 5);
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom", 2);
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo", 5);
      this.ckbAutoAddFriend_CheckedChanged((object) null, (EventArgs) null);
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
      gclass22.method_6("txtSdt", (object) this.txtSdt.Text.Trim());
      gclass22.method_6("txtSdtData", (object) this.txtSdtData.Text.Trim());
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("ckbTuDongXoa", (object) this.ckbTuDongXoa.Checked);
      gclass22.method_6("ckbAutoAddFriend", (object) this.ckbAutoAddFriend.Checked);
      gclass22.method_6("nudSoLuongKetBanFrom", (object) this.nudSoLuongKetBanFrom.Value);
      gclass22.method_6("nudSoLuongKetBanTo", (object) this.nudSoLuongKetBanTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (MessageBox.Show(GClass35.smethod_0("Bạn có muốn thêm hành động mới?"), GClass35.smethod_0("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDDongBoDanhBa.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Thêm thất bại, vui lòng thử lại sau!"), 2);
      }
      else
      {
        if (MessageBox.Show(GClass35.smethod_0("Bạn có muốn cập nhật hành động?"), GClass35.smethod_0("Thông báo"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        if (Class205.smethod_21(this.string_2, string_1, str))
        {
          fHDDongBoDanhBa.bool_0 = true;
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

  private void txtSdt_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtSdt, (Control) this.lblStatusUid);

  private void ckbAutoAddFriend_CheckedChanged(object sender, EventArgs e) => this.plAutoAddFriend.Enabled = this.ckbAutoAddFriend.Checked;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.txtSdtData = new RichTextBox();
    this.lblStatusUidData = new Label();
    this.plAutoAddFriend = new Panel();
    this.nudDelayTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.nudSoLuongKetBanTo = new NumericUpDown();
    this.nudSoLuongKetBanFrom = new NumericUpDown();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label11 = new Label();
    this.txtSdt = new RichTextBox();
    this.ckbAutoAddFriend = new CheckBox();
    this.ckbTuDongXoa = new CheckBox();
    this.lblStatusUid = new Label();
    this.label10 = new Label();
    this.nudSoLuongTo = new NumericUpDown();
    this.nudSoLuongFrom = new NumericUpDown();
    this.label7 = new Label();
    this.label6 = new Label();
    this.label5 = new Label();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plAutoAddFriend.SuspendLayout();
    this.nudDelayTo.BeginInit();
    this.nudDelayFrom.BeginInit();
    this.nudSoLuongKetBanTo.BeginInit();
    this.nudSoLuongKetBanFrom.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(342, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Đồng bộ danh bạ";
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
    this.pnlHeader.Size = new Size(342, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) Resources.btnMinimize_Image;
    this.button1.Location = new Point(312, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 80;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.txtSdtData);
    this.panel1.Controls.Add((Control) this.lblStatusUidData);
    this.panel1.Controls.Add((Control) this.plAutoAddFriend);
    this.panel1.Controls.Add((Control) this.txtSdt);
    this.panel1.Controls.Add((Control) this.ckbAutoAddFriend);
    this.panel1.Controls.Add((Control) this.ckbTuDongXoa);
    this.panel1.Controls.Add((Control) this.lblStatusUid);
    this.panel1.Controls.Add((Control) this.label10);
    this.panel1.Controls.Add((Control) this.nudSoLuongTo);
    this.panel1.Controls.Add((Control) this.nudSoLuongFrom);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(345, 621);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.txtSdtData.Location = new Point(28, 330);
    this.txtSdtData.Name = "txtSdtData";
    this.txtSdtData.Size = new Size(295, 88);
    this.txtSdtData.TabIndex = 53;
    this.txtSdtData.Text = "";
    this.txtSdtData.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
    this.lblStatusUidData.AutoSize = true;
    this.lblStatusUidData.Location = new Point(24, 310);
    this.lblStatusUidData.Name = "lblStatusUidData";
    this.lblStatusUidData.Size = new Size(136, 16);
    this.lblStatusUidData.TabIndex = 52;
    this.lblStatusUidData.Text = "Data số điện thoại (0):";
    this.plAutoAddFriend.BorderStyle = BorderStyle.FixedSingle;
    this.plAutoAddFriend.Controls.Add((Control) this.nudDelayTo);
    this.plAutoAddFriend.Controls.Add((Control) this.nudDelayFrom);
    this.plAutoAddFriend.Controls.Add((Control) this.label2);
    this.plAutoAddFriend.Controls.Add((Control) this.label3);
    this.plAutoAddFriend.Controls.Add((Control) this.label4);
    this.plAutoAddFriend.Controls.Add((Control) this.nudSoLuongKetBanTo);
    this.plAutoAddFriend.Controls.Add((Control) this.nudSoLuongKetBanFrom);
    this.plAutoAddFriend.Controls.Add((Control) this.label8);
    this.plAutoAddFriend.Controls.Add((Control) this.label9);
    this.plAutoAddFriend.Controls.Add((Control) this.label11);
    this.plAutoAddFriend.Location = new Point(44, 508);
    this.plAutoAddFriend.Name = "plAutoAddFriend";
    this.plAutoAddFriend.Size = new Size(277, 60);
    this.plAutoAddFriend.TabIndex = 51;
    this.nudDelayTo.Location = new Point(173, 32);
    this.nudDelayTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayTo.Name = "nudDelayTo";
    this.nudDelayTo.Size = new Size(56, 23);
    this.nudDelayTo.TabIndex = 51;
    this.nudDelayFrom.Location = new Point(89, 32);
    this.nudDelayFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayFrom.Name = "nudDelayFrom";
    this.nudDelayFrom.Size = new Size(56, 23);
    this.nudDelayFrom.TabIndex = 50;
    this.label2.Location = new Point(145, 34);
    this.label2.Name = "label2";
    this.label2.Size = new Size(29, 16);
    this.label2.TabIndex = 58;
    this.label2.Text = "đến";
    this.label2.TextAlign = ContentAlignment.MiddleCenter;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(231, 34);
    this.label3.Name = "label3";
    this.label3.Size = new Size(30, 16);
    this.label3.TabIndex = 57;
    this.label3.Text = "giây";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(3, 34);
    this.label4.Name = "label4";
    this.label4.Size = new Size(89, 16);
    this.label4.TabIndex = 56;
    this.label4.Text = "Thời gian chờ:";
    this.nudSoLuongKetBanTo.Location = new Point(173, 4);
    this.nudSoLuongKetBanTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongKetBanTo.Name = "nudSoLuongKetBanTo";
    this.nudSoLuongKetBanTo.Size = new Size(56, 23);
    this.nudSoLuongKetBanTo.TabIndex = 49;
    this.nudSoLuongKetBanFrom.Location = new Point(89, 4);
    this.nudSoLuongKetBanFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongKetBanFrom.Name = "nudSoLuongKetBanFrom";
    this.nudSoLuongKetBanFrom.Size = new Size(56, 23);
    this.nudSoLuongKetBanFrom.TabIndex = 48;
    this.label8.Location = new Point(145, 6);
    this.label8.Name = "label8";
    this.label8.Size = new Size(29, 16);
    this.label8.TabIndex = 55;
    this.label8.Text = "đến";
    this.label8.TextAlign = ContentAlignment.MiddleCenter;
    this.label9.AutoSize = true;
    this.label9.Location = new Point(231, 6);
    this.label9.Name = "label9";
    this.label9.Size = new Size(28, 16);
    this.label9.TabIndex = 54;
    this.label9.Text = "bạn";
    this.label11.AutoSize = true;
    this.label11.Location = new Point(3, 6);
    this.label11.Name = "label11";
    this.label11.Size = new Size(63, 16);
    this.label11.TabIndex = 53;
    this.label11.Text = "Số lượng:";
    this.txtSdt.Location = new Point(27, 99);
    this.txtSdt.Name = "txtSdt";
    this.txtSdt.Size = new Size(295, 183);
    this.txtSdt.TabIndex = 50;
    this.txtSdt.Text = "";
    this.txtSdt.TextChanged += new EventHandler(this.txtSdt_TextChanged);
    this.ckbAutoAddFriend.AutoSize = true;
    this.ckbAutoAddFriend.Cursor = Cursors.Hand;
    this.ckbAutoAddFriend.Location = new Point(25, 483);
    this.ckbAutoAddFriend.Name = "ckbAutoAddFriend";
    this.ckbAutoAddFriend.Size = new Size(208, 20);
    this.ckbAutoAddFriend.TabIndex = 2;
    this.ckbAutoAddFriend.Text = "Tự động kết bạn nếu có đề xuất";
    this.ckbAutoAddFriend.UseVisualStyleBackColor = true;
    this.ckbAutoAddFriend.CheckedChanged += new EventHandler(this.ckbAutoAddFriend_CheckedChanged);
    this.ckbTuDongXoa.AutoSize = true;
    this.ckbTuDongXoa.Cursor = Cursors.Hand;
    this.ckbTuDongXoa.Location = new Point(25, 457);
    this.ckbTuDongXoa.Name = "ckbTuDongXoa";
    this.ckbTuDongXoa.Size = new Size(259, 20);
    this.ckbTuDongXoa.TabIndex = 2;
    this.ckbTuDongXoa.Text = "Tự động xóa những sđt đã được đồng bộ";
    this.ckbTuDongXoa.UseVisualStyleBackColor = true;
    this.lblStatusUid.AutoSize = true;
    this.lblStatusUid.Location = new Point(23, 79);
    this.lblStatusUid.Name = "lblStatusUid";
    this.lblStatusUid.Size = new Size(201, 16);
    this.lblStatusUid.TabIndex = 0;
    this.lblStatusUid.Text = "Nhập danh sách số điện thoại (0):";
    this.label10.AutoSize = true;
    this.label10.Location = new Point(23, 285);
    this.label10.Name = "label10";
    this.label10.Size = new Size(157, 16);
    this.label10.TabIndex = 0;
    this.label10.Text = "(Mỗi số điện thoại 1 dòng)";
    this.nudSoLuongTo.Location = new Point(238, 428);
    this.nudSoLuongTo.Maximum = new Decimal(new int[4]
    {
      1215752191,
      23,
      0,
      0
    });
    this.nudSoLuongTo.Name = "nudSoLuongTo";
    this.nudSoLuongTo.Size = new Size(50, 23);
    this.nudSoLuongTo.TabIndex = 4;
    this.nudSoLuongFrom.Location = new Point(155, 428);
    this.nudSoLuongFrom.Maximum = new Decimal(new int[4]
    {
      1215752191,
      23,
      0,
      0
    });
    this.nudSoLuongFrom.Name = "nudSoLuongFrom";
    this.nudSoLuongFrom.Size = new Size(50, 23);
    this.nudSoLuongFrom.TabIndex = 3;
    this.label7.Location = new Point(207, 430);
    this.label7.Name = "label7";
    this.label7.Size = new Size(28, 16);
    this.label7.TabIndex = 46;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(290, 430);
    this.label6.Name = "label6";
    this.label6.Size = new Size(20, 16);
    this.label6.TabIndex = 45;
    this.label6.Text = "số";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(23, 430);
    this.label5.Name = "label5";
    this.label5.Size = new Size(130, 16);
    this.label5.TabIndex = 44;
    this.label5.Text = "Số lượng Sđt/thiết bị:";
    this.txtTenHanhDong.Location = new Point(128, 47);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(23, 50);
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
    this.btnCancel.Location = new Point(195, 581);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 7;
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
    this.btnAdd.Location = new Point(88, 581);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 6;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
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
    this.bunifuCards1.Size = new Size(342, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(348, 623);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDDongBoDanhBa);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDDongBoDanhBa_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plAutoAddFriend.ResumeLayout(false);
    this.plAutoAddFriend.PerformLayout();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.nudSoLuongKetBanTo.EndInit();
    this.nudSoLuongKetBanFrom.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void richTextBox1_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtSdtData, (Control) this.lblStatusUidData);
}
