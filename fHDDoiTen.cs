// Decompiled with JetBrains decompiler
// Type: fHDDoiTen
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fHDDoiTen : Form
{
  private GClass22 gclass22_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private List<string> list_0 = new List<string>();
  private List<string> list_1 = new List<string>();
  private List<string> list_2 = new List<string>();
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
  private Button button1;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Panel plTenTuDat;
  private Button button8;
  private Button button7;
  private Button button6;
  private RadioButton rdTenTuDat;
  private RadioButton rdTenRandom;
  private Panel plTenNgauNhien;
  private RadioButton rdTenRandomNgoai;
  private IContainer components;
  private RadioButton rdTenRandomViet;

  public fHDDoiTen(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDDoiTen.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1_1 = this.Name.Substring(1);
    string str = "Đổi tên";
    if (Class205.smethod_13(string_1: string_1_1).Rows.Count == 0)
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

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDDoiTen_Load(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass22_0.method_3("typeDatTen") == 0)
        this.rdTenRandom.Checked = true;
      else
        this.rdTenTuDat.Checked = true;
      if (this.gclass22_0.method_3("typeTenRandom") == 0)
        this.rdTenRandomViet.Checked = true;
      else
        this.rdTenRandomNgoai.Checked = true;
      this.list_0 = this.gclass22_0.method_2("lstHo");
      this.list_1 = this.gclass22_0.method_2("lstTenDem");
      this.list_2 = this.gclass22_0.method_2("lstTen");
      this.rdTenTuDat_CheckedChanged((object) null, (EventArgs) null);
      this.rdTenRandom_CheckedChanged((object) null, (EventArgs) null);
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
      int object_0_1 = 0;
      if (this.rdTenTuDat.Checked)
        object_0_1 = 1;
      gclass22.method_6("typeDatTen", (object) object_0_1);
      int object_0_2 = 0;
      if (this.rdTenRandomNgoai.Checked)
        object_0_2 = 1;
      gclass22.method_6("typeTenRandom", (object) object_0_2);
      gclass22.method_8("lstHo", this.list_0);
      gclass22.method_8("lstTenDem", this.list_1);
      gclass22.method_8("lstTen", this.list_2);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDDoiTen.bool_0 = true;
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
          fHDDoiTen.bool_0 = true;
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

  private void rdTenTuDat_CheckedChanged(object sender, EventArgs e) => this.plTenTuDat.Enabled = this.rdTenTuDat.Checked;

  private void rdTenRandom_CheckedChanged(object sender, EventArgs e) => this.plTenNgauNhien.Enabled = this.rdTenRandom.Checked;

  private void button6_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_0, "Nhập danh sách Họ", "Danh sách Họ", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_0 = form_0.list_0;
  }

  private void button7_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_1, "Nhập danh sách Tên đệm", "Danh sách Tên đệm", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_1 = form_0.list_0;
  }

  private void button8_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_2, "Nhập danh sách Tên", "Danh sách Tên", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_2 = form_0.list_0;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDDoiTen));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plTenTuDat = new Panel();
    this.button8 = new Button();
    this.button7 = new Button();
    this.button6 = new Button();
    this.rdTenTuDat = new RadioButton();
    this.rdTenRandom = new RadioButton();
    this.plTenNgauNhien = new Panel();
    this.rdTenRandomNgoai = new RadioButton();
    this.rdTenRandomViet = new RadioButton();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plTenTuDat.SuspendLayout();
    this.plTenNgauNhien.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(320, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Đổi tên";
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
    this.pnlHeader.Size = new Size(320, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(289, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plTenTuDat);
    this.panel1.Controls.Add((Control) this.rdTenTuDat);
    this.panel1.Controls.Add((Control) this.rdTenRandom);
    this.panel1.Controls.Add((Control) this.plTenNgauNhien);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(323, 238);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plTenTuDat.BorderStyle = BorderStyle.FixedSingle;
    this.plTenTuDat.Controls.Add((Control) this.button8);
    this.plTenTuDat.Controls.Add((Control) this.button7);
    this.plTenTuDat.Controls.Add((Control) this.button6);
    this.plTenTuDat.Location = new Point(44, 150);
    this.plTenTuDat.Name = "plTenTuDat";
    this.plTenTuDat.Size = new Size(240, 29);
    this.plTenTuDat.TabIndex = 136;
    this.button8.Cursor = Cursors.Hand;
    this.button8.Location = new Point(171, 0);
    this.button8.Name = "button8";
    this.button8.Size = new Size(67, 27);
    this.button8.TabIndex = 124;
    this.button8.Text = "Nhập tên";
    this.button8.UseVisualStyleBackColor = true;
    this.button8.Click += new EventHandler(this.button8_Click);
    this.button7.Cursor = Cursors.Hand;
    this.button7.Location = new Point(69, 0);
    this.button7.Name = "button7";
    this.button7.Size = new Size(96, 27);
    this.button7.TabIndex = 124;
    this.button7.Text = "Nhập tên đệm";
    this.button7.UseVisualStyleBackColor = true;
    this.button7.Click += new EventHandler(this.button7_Click);
    this.button6.Cursor = Cursors.Hand;
    this.button6.Location = new Point(0, 0);
    this.button6.Name = "button6";
    this.button6.Size = new Size(63, 27);
    this.button6.TabIndex = 124;
    this.button6.Text = "Nhập họ";
    this.button6.UseVisualStyleBackColor = true;
    this.button6.Click += new EventHandler(this.button6_Click);
    this.rdTenTuDat.AutoSize = true;
    this.rdTenTuDat.Checked = true;
    this.rdTenTuDat.Cursor = Cursors.Hand;
    this.rdTenTuDat.Location = new Point(29, (int) sbyte.MaxValue);
    this.rdTenTuDat.Name = "rdTenTuDat";
    this.rdTenTuDat.Size = new Size(155, 20);
    this.rdTenTuDat.TabIndex = 138;
    this.rdTenTuDat.TabStop = true;
    this.rdTenTuDat.Text = "Tên do người dùng đặt";
    this.rdTenTuDat.UseVisualStyleBackColor = true;
    this.rdTenTuDat.CheckedChanged += new EventHandler(this.rdTenTuDat_CheckedChanged);
    this.rdTenRandom.AutoSize = true;
    this.rdTenRandom.Cursor = Cursors.Hand;
    this.rdTenRandom.Location = new Point(29, 78);
    this.rdTenRandom.Name = "rdTenRandom";
    this.rdTenRandom.Size = new Size(114, 20);
    this.rdTenRandom.TabIndex = 137;
    this.rdTenRandom.Text = "Tên ngẫu nhiên";
    this.rdTenRandom.UseVisualStyleBackColor = true;
    this.rdTenRandom.CheckedChanged += new EventHandler(this.rdTenRandom_CheckedChanged);
    this.plTenNgauNhien.BorderStyle = BorderStyle.FixedSingle;
    this.plTenNgauNhien.Controls.Add((Control) this.rdTenRandomNgoai);
    this.plTenNgauNhien.Controls.Add((Control) this.rdTenRandomViet);
    this.plTenNgauNhien.Location = new Point(44, 98);
    this.plTenNgauNhien.Name = "plTenNgauNhien";
    this.plTenNgauNhien.Size = new Size(240, 25);
    this.plTenNgauNhien.TabIndex = 139;
    this.rdTenRandomNgoai.AutoSize = true;
    this.rdTenRandomNgoai.Cursor = Cursors.Hand;
    this.rdTenRandomNgoai.Location = new Point(80, 1);
    this.rdTenRandomNgoai.Name = "rdTenRandomNgoai";
    this.rdTenRandomNgoai.Size = new Size(82, 20);
    this.rdTenRandomNgoai.TabIndex = 134;
    this.rdTenRandomNgoai.Text = "Tên ngoại";
    this.rdTenRandomNgoai.UseVisualStyleBackColor = true;
    this.rdTenRandomViet.AutoSize = true;
    this.rdTenRandomViet.Checked = true;
    this.rdTenRandomViet.Cursor = Cursors.Hand;
    this.rdTenRandomViet.Location = new Point(2, 1);
    this.rdTenRandomViet.Name = "rdTenRandomViet";
    this.rdTenRandomViet.Size = new Size(71, 20);
    this.rdTenRandomViet.TabIndex = 134;
    this.rdTenRandomViet.TabStop = true;
    this.rdTenRandomViet.Text = "Tên việt";
    this.rdTenRandomViet.UseVisualStyleBackColor = true;
    this.txtTenHanhDong.Location = new Point(125, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(159, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(26, 52);
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
    this.btnCancel.Location = new Point(168, 193);
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
    this.btnAdd.Location = new Point(61, 193);
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
    this.bunifuCards1.Size = new Size(320, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(323, 238);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDDoiTen);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDDoiTen_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plTenTuDat.ResumeLayout(false);
    this.plTenNgauNhien.ResumeLayout(false);
    this.plTenNgauNhien.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
