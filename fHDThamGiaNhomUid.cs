// Decompiled with JetBrains decompiler
// Type: fHDThamGiaNhomUid
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

public class fHDThamGiaNhomUid : Form
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
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label7;
  private Label label6;
  private Label label5;
  private RichTextBox txtUid;
  private CheckBox ckbTuDongXoaUid;
  private ToolTip toolTip_0;
  private Panel plTuongTac;
  private CheckBox ckbTuDongTraLoiCauHoi;
  private TextBox txtCauTraLoi;
  private Label label9;
  private IContainer components;
  private Label lblStatusComment;

  public fHDThamGiaNhomUid(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDThamGiaNhomUid.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string json = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDThamGiaNhomUid");
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
    GClass35.smethod_1((Control) this.ckbTuDongTraLoiCauHoi);
    GClass35.smethod_1((Control) this.lblStatusComment);
    GClass35.smethod_1((Control) this.label9);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.ckbTuDongXoaUid);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDThamGiaNhomUid_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudSoLuongFrom"]);
      this.nudSoLuongTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudSoLuongTo"]);
      this.nudDelayFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudDelayFrom"]);
      this.nudDelayTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudDelayTo"]);
      this.ckbTuDongXoaUid.Checked = Convert.ToBoolean((object) this.jobject_0["ckbThamGiaNhomTrungNhau"]);
      this.txtUid.Text = this.jobject_0["txtUid"].ToString();
      this.ckbTuDongTraLoiCauHoi.Checked = Convert.ToBoolean((object) this.jobject_0["ckbTuDongTraLoiCauHoi"]);
      this.ckbTuDongXoaUid.Checked = Convert.ToBoolean((object) this.jobject_0["ckbTuDongXoaUid"]);
      this.txtCauTraLoi.Text = this.jobject_0["txtCauTraLoi"].ToString();
    }
    catch
    {
    }
    this.method_1();
  }

  private void method_1() => this.ckbTuDongTraLoiCauHoi_CheckedChanged((object) null, (EventArgs) null);

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    else if (GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>()).Count == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách uid nhóm!"), 3);
    else if (this.ckbTuDongTraLoiCauHoi.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtCauTraLoi.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách câu trả lời!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
      gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("ckbThamGiaNhomTrungNhau", (object) this.ckbTuDongXoaUid.Checked);
      gclass22.method_6("txtUid", (object) this.txtUid.Text.Trim());
      gclass22.method_6("ckbTuDongTraLoiCauHoi", (object) this.ckbTuDongTraLoiCauHoi.Checked);
      gclass22.method_6("ckbTuDongXoaUid", (object) this.ckbTuDongXoaUid.Checked);
      gclass22.method_6("txtCauTraLoi", (object) this.txtCauTraLoi.Text.Trim());
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDThamGiaNhomUid.bool_0 = true;
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
          fHDThamGiaNhomUid.bool_0 = true;
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
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Danh sách Uid nhóm cần tham gia ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void txtCauTraLoi_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtCauTraLoi.Lines).ToList<string>());
      this.lblStatusComment.Text = string.Format(GClass35.smethod_0("Danh sách câu trả lời ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void ckbTuDongTraLoiCauHoi_CheckedChanged(object sender, EventArgs e) => this.plTuongTac.Enabled = this.ckbTuDongTraLoiCauHoi.Checked;

  private void label8_Click(object sender, EventArgs e)
  {
  }

  private void lblStatus_Click(object sender, EventArgs e)
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDThamGiaNhomUid));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plTuongTac = new Panel();
    this.txtCauTraLoi = new TextBox();
    this.label9 = new Label();
    this.lblStatusComment = new Label();
    this.ckbTuDongTraLoiCauHoi = new CheckBox();
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
    this.bunifuCustomLabel1.Text = "Cấu hình Tham gia nhóm theo tệp UID";
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
    this.panel1.Controls.Add((Control) this.ckbTuDongTraLoiCauHoi);
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
    this.panel1.Size = new Size(690, 402);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plTuongTac.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTac.Controls.Add((Control) this.txtCauTraLoi);
    this.plTuongTac.Controls.Add((Control) this.label9);
    this.plTuongTac.Controls.Add((Control) this.lblStatusComment);
    this.plTuongTac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plTuongTac.Location = new Point(48, 162);
    this.plTuongTac.Name = "plTuongTac";
    this.plTuongTac.Size = new Size(278, 179);
    this.plTuongTac.TabIndex = 116;
    this.txtCauTraLoi.Location = new Point(6, 25);
    this.txtCauTraLoi.Multiline = true;
    this.txtCauTraLoi.Name = "txtCauTraLoi";
    this.txtCauTraLoi.ScrollBars = ScrollBars.Both;
    this.txtCauTraLoi.Size = new Size(265, 128);
    this.txtCauTraLoi.TabIndex = 1;
    this.txtCauTraLoi.WordWrap = false;
    this.txtCauTraLoi.TextChanged += new EventHandler(this.txtCauTraLoi_TextChanged);
    this.label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label9.AutoSize = true;
    this.label9.Location = new Point(3, 158);
    this.label9.Name = "label9";
    this.label9.Size = new Size(133, 16);
    this.label9.TabIndex = 0;
    this.label9.Text = "(Mỗi nội dung 1 dòng)";
    this.lblStatusComment.AutoSize = true;
    this.lblStatusComment.Location = new Point(3, 4);
    this.lblStatusComment.Name = "lblStatusComment";
    this.lblStatusComment.Size = new Size(153, 16);
    this.lblStatusComment.TabIndex = 0;
    this.lblStatusComment.Text = "Danh sách câu trả lời (0):";
    this.ckbTuDongTraLoiCauHoi.AutoSize = true;
    this.ckbTuDongTraLoiCauHoi.Cursor = Cursors.Hand;
    this.ckbTuDongTraLoiCauHoi.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuDongTraLoiCauHoi.Location = new Point(30, 139);
    this.ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
    this.ckbTuDongTraLoiCauHoi.Size = new Size(156, 20);
    this.ckbTuDongTraLoiCauHoi.TabIndex = 115;
    this.ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
    this.ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
    this.ckbTuDongTraLoiCauHoi.CheckedChanged += new EventHandler(this.ckbTuDongTraLoiCauHoi_CheckedChanged);
    this.txtUid.BorderStyle = BorderStyle.FixedSingle;
    this.txtUid.Location = new Point(356, 72);
    this.txtUid.Name = "txtUid";
    this.txtUid.Size = new Size(295, 230);
    this.txtUid.TabIndex = 114;
    this.txtUid.Text = "";
    this.txtUid.WordWrap = false;
    this.txtUid.TextChanged += new EventHandler(this.txtUid_TextChanged);
    this.ckbTuDongXoaUid.AutoSize = true;
    this.ckbTuDongXoaUid.Cursor = Cursors.Hand;
    this.ckbTuDongXoaUid.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuDongXoaUid.Location = new Point(355, 324);
    this.ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
    this.ckbTuDongXoaUid.Size = new Size(298, 20);
    this.ckbTuDongXoaUid.TabIndex = 113;
    this.ckbTuDongXoaUid.Text = "Tự động xóa Uid nhóm đã gửi yêu cầu tham gia";
    this.ckbTuDongXoaUid.UseVisualStyleBackColor = true;
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
    this.label8.Location = new Point(553, 305);
    this.label8.Name = "label8";
    this.label8.Size = new Size(102, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Mỗi Uid 1 dòng)";
    this.label8.Click += new EventHandler(this.label8_Click);
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(352, 52);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(228, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Danh sách Uid nhóm cần tham gia (0):";
    this.lblStatus.Click += new EventHandler(this.lblStatus_Click);
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
    this.label7.Location = new Point(194, 113);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 46;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(287, 113);
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
    this.label3.Location = new Point(194, 82);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(287, 82);
    this.label4.Name = "label4";
    this.label4.Size = new Size(39, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "nhóm";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 82);
    this.label2.Name = "label2";
    this.label2.Size = new Size(99, 16);
    this.label2.TabIndex = 32;
    this.label2.Text = "Số lượng nhóm:";
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
    this.btnCancel.Location = new Point(355, 359);
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
    this.btnAdd.Location = new Point(248, 359);
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
    this.ClientSize = new Size(690, 402);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDThamGiaNhomUid);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDThamGiaNhomUid_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plTuongTac.ResumeLayout(false);
    this.plTuongTac.PerformLayout();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.nudSoLuongTo.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
