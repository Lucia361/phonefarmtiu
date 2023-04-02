// Decompiled with JetBrains decompiler
// Type: fHDOnOff2FA
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fHDOnOff2FA : Form
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
  private Button button1;
  private BunifuCustomLabel bunifuCustomLabel1;
  private RadioButton rbBat2FA;
  private RadioButton rbTat2FA;
  private Panel plBat2FA;
  private RadioButton rbXoa2FACu;
  private RadioButton rbGiu2FACu;
  private RadioButton rbKhongBat2FA;
  private IContainer components;
  private Label label2;

  public fHDOnOff2FA(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDOnOff2FA.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1_1 = this.Name.Substring(1);
    string str = "Bật - Tắt 2FA";
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
    GClass35.smethod_1((Control) this.rbTat2FA);
    GClass35.smethod_1((Control) this.rbBat2FA);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void fHDOnOff2FA_Load(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass22_0.method_3("typeOnOff2FA") == 0)
        this.rbTat2FA.Checked = true;
      else
        this.rbBat2FA.Checked = true;
      if (this.gclass22_0.method_3("neuDaCo2FA") == 0)
        this.rbKhongBat2FA.Checked = true;
      else if (this.gclass22_0.method_3("neuDaCo2FA") == 1)
        this.rbGiu2FACu.Checked = true;
      else
        this.rbXoa2FACu.Checked = true;
      this.method_1((object) null, (EventArgs) null);
      this.rbBat2FA_CheckedChanged((object) null, (EventArgs) null);
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
      if (this.rbTat2FA.Checked)
        gclass22.method_6("typeOnOff2FA", (object) 0);
      else
        gclass22.method_6("typeOnOff2FA", (object) 1);
      if (this.rbKhongBat2FA.Checked)
        gclass22.method_6("neuDaCo2FA", (object) 0);
      else if (this.rbGiu2FACu.Checked)
        gclass22.method_6("neuDaCo2FA", (object) 1);
      else
        gclass22.method_6("neuDaCo2FA", (object) 2);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDOnOff2FA.bool_0 = true;
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
          fHDOnOff2FA.bool_0 = true;
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

  private void rbBat2FA_CheckedChanged(object sender, EventArgs e) => this.plBat2FA.Enabled = this.rbBat2FA.Checked;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDOnOff2FA));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plBat2FA = new Panel();
    this.rbXoa2FACu = new RadioButton();
    this.rbGiu2FACu = new RadioButton();
    this.rbKhongBat2FA = new RadioButton();
    this.label2 = new Label();
    this.rbBat2FA = new RadioButton();
    this.rbTat2FA = new RadioButton();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plBat2FA.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(358, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Bật - Tắt 2FA";
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
    this.pnlHeader.Size = new Size(358, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(327, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plBat2FA);
    this.panel1.Controls.Add((Control) this.rbBat2FA);
    this.panel1.Controls.Add((Control) this.rbTat2FA);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(361, 263);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plBat2FA.BorderStyle = BorderStyle.FixedSingle;
    this.plBat2FA.Controls.Add((Control) this.rbXoa2FACu);
    this.plBat2FA.Controls.Add((Control) this.rbGiu2FACu);
    this.plBat2FA.Controls.Add((Control) this.rbKhongBat2FA);
    this.plBat2FA.Controls.Add((Control) this.label2);
    this.plBat2FA.Location = new Point(131, 105);
    this.plBat2FA.Name = "plBat2FA";
    this.plBat2FA.Size = new Size(204, 97);
    this.plBat2FA.TabIndex = 48;
    this.rbXoa2FACu.AutoSize = true;
    this.rbXoa2FACu.Cursor = Cursors.Hand;
    this.rbXoa2FACu.Location = new Point(6, 72);
    this.rbXoa2FACu.Name = "rbXoa2FACu";
    this.rbXoa2FACu.Size = new Size(193, 20);
    this.rbXoa2FACu.TabIndex = 34;
    this.rbXoa2FACu.TabStop = true;
    this.rbXoa2FACu.Text = "Xóa 2FA cũ rồi thêm 2FA mới";
    this.rbXoa2FACu.UseVisualStyleBackColor = true;
    this.rbGiu2FACu.AutoSize = true;
    this.rbGiu2FACu.Cursor = Cursors.Hand;
    this.rbGiu2FACu.Location = new Point(6, 47);
    this.rbGiu2FACu.Name = "rbGiu2FACu";
    this.rbGiu2FACu.Size = new Size(188, 20);
    this.rbGiu2FACu.TabIndex = 33;
    this.rbGiu2FACu.TabStop = true;
    this.rbGiu2FACu.Text = "Giữ 2FA cũ và thêm 2FA mới";
    this.rbGiu2FACu.UseVisualStyleBackColor = true;
    this.rbKhongBat2FA.AutoSize = true;
    this.rbKhongBat2FA.Cursor = Cursors.Hand;
    this.rbKhongBat2FA.Location = new Point(6, 22);
    this.rbKhongBat2FA.Name = "rbKhongBat2FA";
    this.rbKhongBat2FA.Size = new Size(134, 20);
    this.rbKhongBat2FA.TabIndex = 32;
    this.rbKhongBat2FA.TabStop = true;
    this.rbKhongBat2FA.Text = "Không bật 2FA nữa";
    this.rbKhongBat2FA.UseVisualStyleBackColor = true;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(3, 2);
    this.label2.Name = "label2";
    this.label2.Size = new Size(169, 16);
    this.label2.TabIndex = 31;
    this.label2.Text = "Nếu tài khoản đã có 2FA thì:";
    this.rbBat2FA.AutoSize = true;
    this.rbBat2FA.Cursor = Cursors.Hand;
    this.rbBat2FA.Location = new Point(30, 105);
    this.rbBat2FA.Name = "rbBat2FA";
    this.rbBat2FA.Size = new Size(69, 20);
    this.rbBat2FA.TabIndex = 47;
    this.rbBat2FA.Text = "Bật 2FA";
    this.rbBat2FA.UseVisualStyleBackColor = true;
    this.rbBat2FA.CheckedChanged += new EventHandler(this.rbBat2FA_CheckedChanged);
    this.rbTat2FA.AutoSize = true;
    this.rbTat2FA.Checked = true;
    this.rbTat2FA.Cursor = Cursors.Hand;
    this.rbTat2FA.Location = new Point(29, 81);
    this.rbTat2FA.Name = "rbTat2FA";
    this.rbTat2FA.Size = new Size(70, 20);
    this.rbTat2FA.TabIndex = 47;
    this.rbTat2FA.TabStop = true;
    this.rbTat2FA.Text = "Tắt 2FA";
    this.rbTat2FA.UseVisualStyleBackColor = true;
    this.txtTenHanhDong.Location = new Point(131, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(204, 23);
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
    this.btnCancel.Location = new Point(187, 218);
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
    this.btnAdd.Location = new Point(80, 218);
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
    this.bunifuCards1.Size = new Size(358, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(361, 263);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDOnOff2FA);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDOnOff2FA_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plBat2FA.ResumeLayout(false);
    this.plBat2FA.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
