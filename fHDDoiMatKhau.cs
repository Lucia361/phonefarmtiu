// Decompiled with JetBrains decompiler
// Type: fHDDoiMatKhau
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

public class fHDDoiMatKhau : Form
{
  private GClass22 gclass22_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private List<string> list_0 = new List<string>();
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
  private RadioButton rbMatKhauChiDinh;
  private RadioButton rbMatKhauRandom;
  private Label label8;
  private NumericUpDown nudTimeOut;
  private Label label3;
  private Label label2;
  private Button button2;
  private Button btnNhapMatKhau;
  private IContainer components;
  private CheckBox ckbDangXuatThietBiCu;

  public fHDDoiMatKhau(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDDoiMatKhau.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1_1 = this.Name.Substring(1);
    string str = "Đổi mật khẩu";
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
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.rbMatKhauRandom);
    GClass35.smethod_1((Control) this.rbMatKhauChiDinh);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDDoiMatKhau_Load(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass22_0.method_3("typeMatKhau") == 0)
        this.rbMatKhauRandom.Checked = true;
      else
        this.rbMatKhauChiDinh.Checked = true;
      this.list_0 = this.gclass22_0.method_2("txtMatKhau");
      GClass19.smethod_6((Control) this.btnNhapMatKhau, this.list_0.Count);
      this.nudTimeOut.Value = (Decimal) this.gclass22_0.method_3("nudTimeOut", 30);
      this.ckbDangXuatThietBiCu.Checked = this.gclass22_0.method_4("ckbDangXuatThietBiCu");
      this.method_1((object) null, (EventArgs) null);
      this.rbMatKhauChiDinh_CheckedChanged((object) null, (EventArgs) null);
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
      if (this.rbMatKhauRandom.Checked)
        gclass22.method_6("typeMatKhau", (object) 0);
      else
        gclass22.method_6("typeMatKhau", (object) 1);
      gclass22.method_8("txtMatKhau", this.list_0);
      gclass22.method_6("nudTimeOut", (object) this.nudTimeOut.Value);
      gclass22.method_6("ckbDangXuatThietBiCu", (object) this.ckbDangXuatThietBiCu.Checked);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDDoiMatKhau.bool_0 = true;
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
          fHDDoiMatKhau.bool_0 = true;
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

  private void rbMatKhauChiDinh_CheckedChanged(object sender, EventArgs e)
  {
    this.btnNhapMatKhau.Enabled = this.rbMatKhauChiDinh.Checked;
    this.btnNhapMatKhau.Enabled = this.rbMatKhauChiDinh.Checked;
  }

  private void button2_Click(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta"));

  private void btnNhapMatKhau_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_0, "Nhập danh sách mật khẩu", "Danh sách Mật khẩu", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_0 = form_0.list_0;
    GClass19.smethod_6((Control) this.btnNhapMatKhau, this.list_0.Count);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDDoiMatKhau));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.ckbDangXuatThietBiCu = new CheckBox();
    this.btnNhapMatKhau = new Button();
    this.button2 = new Button();
    this.nudTimeOut = new NumericUpDown();
    this.rbMatKhauChiDinh = new RadioButton();
    this.rbMatKhauRandom = new RadioButton();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label8 = new Label();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.nudTimeOut.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(331, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Đổi mật khẩu";
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
    this.pnlHeader.Size = new Size(331, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(300, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.ckbDangXuatThietBiCu);
    this.panel1.Controls.Add((Control) this.btnNhapMatKhau);
    this.panel1.Controls.Add((Control) this.button2);
    this.panel1.Controls.Add((Control) this.nudTimeOut);
    this.panel1.Controls.Add((Control) this.rbMatKhauChiDinh);
    this.panel1.Controls.Add((Control) this.rbMatKhauRandom);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label8);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(334, 226);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.ckbDangXuatThietBiCu.AutoSize = true;
    this.ckbDangXuatThietBiCu.Cursor = Cursors.Hand;
    this.ckbDangXuatThietBiCu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbDangXuatThietBiCu.Location = new Point(30, 149);
    this.ckbDangXuatThietBiCu.Name = "ckbDangXuatThietBiCu";
    this.ckbDangXuatThietBiCu.Size = new Size(144, 20);
    this.ckbDangXuatThietBiCu.TabIndex = 114;
    this.ckbDangXuatThietBiCu.Text = "Đăng xuất thiết bị cũ";
    this.ckbDangXuatThietBiCu.UseVisualStyleBackColor = true;
    this.btnNhapMatKhau.Cursor = Cursors.Hand;
    this.btnNhapMatKhau.Location = new Point(174, 116);
    this.btnNhapMatKhau.Name = "btnNhapMatKhau";
    this.btnNhapMatKhau.Size = new Size(87, 27);
    this.btnNhapMatKhau.TabIndex = 51;
    this.btnNhapMatKhau.Text = "Nhập (0)";
    this.btnNhapMatKhau.UseVisualStyleBackColor = true;
    this.btnNhapMatKhau.Click += new EventHandler(this.btnNhapMatKhau_Click);
    this.button2.Cursor = Cursors.Help;
    this.button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button2.Location = new Point(265, 116);
    this.button2.Name = "button2";
    this.button2.Size = new Size(28, 27);
    this.button2.TabIndex = 50;
    this.button2.Text = "?";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.nudTimeOut.Location = new Point(174, 256);
    this.nudTimeOut.Maximum = new Decimal(new int[4]
    {
      -727379969,
      232,
      0,
      0
    });
    this.nudTimeOut.Name = "nudTimeOut";
    this.nudTimeOut.Size = new Size(87, 23);
    this.nudTimeOut.TabIndex = 49;
    this.rbMatKhauChiDinh.AutoSize = true;
    this.rbMatKhauChiDinh.Cursor = Cursors.Hand;
    this.rbMatKhauChiDinh.Location = new Point(44, 119);
    this.rbMatKhauChiDinh.Name = "rbMatKhauChiDinh";
    this.rbMatKhauChiDinh.Size = new Size(130, 20);
    this.rbMatKhauChiDinh.TabIndex = 47;
    this.rbMatKhauChiDinh.Text = "Mật khẩu chỉ định:";
    this.rbMatKhauChiDinh.UseVisualStyleBackColor = true;
    this.rbMatKhauChiDinh.CheckedChanged += new EventHandler(this.rbMatKhauChiDinh_CheckedChanged);
    this.rbMatKhauRandom.AutoSize = true;
    this.rbMatKhauRandom.Checked = true;
    this.rbMatKhauRandom.Cursor = Cursors.Hand;
    this.rbMatKhauRandom.Location = new Point(44, 96);
    this.rbMatKhauRandom.Name = "rbMatKhauRandom";
    this.rbMatKhauRandom.Size = new Size(89, 20);
    this.rbMatKhauRandom.TabIndex = 47;
    this.rbMatKhauRandom.TabStop = true;
    this.rbMatKhauRandom.Text = "Ngẫu nhiên";
    this.rbMatKhauRandom.UseVisualStyleBackColor = true;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(263, 258);
    this.label3.Name = "label3";
    this.label3.Size = new Size(30, 16);
    this.label3.TabIndex = 44;
    this.label3.Text = "giây";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(27, 258);
    this.label2.Name = "label2";
    this.label2.Size = new Size(140, 16);
    this.label2.TabIndex = 44;
    this.label2.Text = "Thời gian chờ đổi pass:";
    this.label8.AutoSize = true;
    this.label8.Location = new Point(27, 76);
    this.label8.Name = "label8";
    this.label8.Size = new Size(146, 16);
    this.label8.TabIndex = 44;
    this.label8.Text = "Tùy chọn mật khẩu mới:";
    this.txtTenHanhDong.Location = new Point(131, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(162, 23);
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
    this.btnCancel.Location = new Point(174, 184);
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
    this.btnAdd.Location = new Point(67, 184);
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
    this.bunifuCards1.Size = new Size(331, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(334, 226);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDDoiMatKhau);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDDoiMatKhau_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.nudTimeOut.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
