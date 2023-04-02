// Decompiled with JetBrains decompiler
// Type: fCauHinhKhoiPhucTaiKhoan
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fCauHinhKhoiPhucTaiKhoan : Form
{
  public static bool bool_0 = false;
  public static int int_0 = 0;
  public static string string_0 = "";
  private int int_1 = 0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuDragControl bunifuDragControl_0;
  private RadioButton rbThuMucCu;
  private RadioButton rbThuMucKhac;
  private Button button1;
  private ComboBox cbbThuMuc;
  private IContainer components;
  private Panel plThuMucKhac;

  public fCauHinhKhoiPhucTaiKhoan()
  {
    this.InitializeComponent();
    this.method_1();
    GClass35.smethod_5((Control) this);
    fCauHinhKhoiPhucTaiKhoan.bool_0 = false;
    fCauHinhKhoiPhucTaiKhoan.int_0 = 0;
    fCauHinhKhoiPhucTaiKhoan.string_0 = "";
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.rbThuMucCu);
    GClass35.smethod_1((Control) this.rbThuMucKhac);
    GClass35.smethod_1((Control) this.button1);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (this.rbThuMucKhac.Checked)
    {
      if (this.cbbThuMuc.SelectedIndex == -1)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng thêm thư mục để lưu tài khoản!"), 3);
        return;
      }
      fCauHinhKhoiPhucTaiKhoan.int_0 = 1;
      fCauHinhKhoiPhucTaiKhoan.string_0 = this.cbbThuMuc.SelectedValue.ToString();
    }
    fCauHinhKhoiPhucTaiKhoan.bool_0 = true;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void fCauHinhKhoiPhucTaiKhoan_Load(object sender, EventArgs e) => this.rbThuMucKhac_CheckedChanged((object) null, (EventArgs) null);

  private void button1_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fAddFile());
    if (!fAddFile.bool_0)
      return;
    this.method_1();
    this.cbbThuMuc.SelectedIndex = this.cbbThuMuc.Items.Count - 1;
  }

  private void method_1()
  {
    this.int_1 = this.cbbThuMuc.SelectedIndex;
    DataTable dataTable = Class42.smethod_1();
    if (dataTable.Rows.Count <= 0)
      return;
    this.cbbThuMuc.DataSource = (object) dataTable;
    this.cbbThuMuc.ValueMember = "id";
    this.cbbThuMuc.DisplayMember = "name";
    if (this.int_1 == -1)
      this.int_1 = 0;
    this.cbbThuMuc.SelectedIndex = this.int_1;
  }

  private void rbThuMucKhac_CheckedChanged(object sender, EventArgs e) => this.plThuMucKhac.Enabled = this.rbThuMucKhac.Checked;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCauHinhKhoiPhucTaiKhoan));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.rbThuMucCu = new RadioButton();
    this.rbThuMucKhac = new RadioButton();
    this.button1 = new Button();
    this.cbbThuMuc = new ComboBox();
    this.plThuMucKhac = new Panel();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.plThuMucKhac.SuspendLayout();
    this.SuspendLayout();
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.Dock = DockStyle.Top;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(365, 34);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(365, 28);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(333, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 28);
    this.btnMinimize.TabIndex = 9;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(365, 28);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Cấu hình Khôi phục tài khoản";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(188, 162);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 4;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(84, 162);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Lưu";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.rbThuMucCu.AutoSize = true;
    this.rbThuMucCu.Checked = true;
    this.rbThuMucCu.Cursor = Cursors.Hand;
    this.rbThuMucCu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbThuMucCu.Location = new Point(36, 56);
    this.rbThuMucCu.Name = "rbThuMucCu";
    this.rbThuMucCu.Size = new Size(165, 20);
    this.rbThuMucCu.TabIndex = 5;
    this.rbThuMucCu.TabStop = true;
    this.rbThuMucCu.Text = "Khôi phục về thư mục cũ";
    this.rbThuMucCu.UseVisualStyleBackColor = true;
    this.rbThuMucKhac.AutoSize = true;
    this.rbThuMucKhac.Cursor = Cursors.Hand;
    this.rbThuMucKhac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbThuMucKhac.Location = new Point(36, 82);
    this.rbThuMucKhac.Name = "rbThuMucKhac";
    this.rbThuMucKhac.Size = new Size(179, 20);
    this.rbThuMucKhac.TabIndex = 5;
    this.rbThuMucKhac.Text = "Chuyển sang thư mục khác";
    this.rbThuMucKhac.UseVisualStyleBackColor = true;
    this.rbThuMucKhac.CheckedChanged += new EventHandler(this.rbThuMucKhac_CheckedChanged);
    this.button1.Cursor = Cursors.Hand;
    this.button1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.Location = new Point(210, 2);
    this.button1.Name = "button1";
    this.button1.Size = new Size(62, 27);
    this.button1.TabIndex = 48;
    this.button1.Text = "Thêm";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.cbbThuMuc.Cursor = Cursors.Hand;
    this.cbbThuMuc.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbThuMuc.DropDownWidth = 269;
    this.cbbThuMuc.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbThuMuc.FormattingEnabled = true;
    this.cbbThuMuc.Location = new Point(3, 3);
    this.cbbThuMuc.Name = "cbbThuMuc";
    this.cbbThuMuc.Size = new Size(201, 24);
    this.cbbThuMuc.TabIndex = 47;
    this.plThuMucKhac.BorderStyle = BorderStyle.FixedSingle;
    this.plThuMucKhac.Controls.Add((Control) this.cbbThuMuc);
    this.plThuMucKhac.Controls.Add((Control) this.button1);
    this.plThuMucKhac.Location = new Point(55, 108);
    this.plThuMucKhac.Name = "plThuMucKhac";
    this.plThuMucKhac.Size = new Size(278, 33);
    this.plThuMucKhac.TabIndex = 49;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(365, 205);
    this.Controls.Add((Control) this.plThuMucKhac);
    this.Controls.Add((Control) this.rbThuMucKhac);
    this.Controls.Add((Control) this.rbThuMucCu);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fCauHinhKhoiPhucTaiKhoan);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fCauHinhKhoiPhucTaiKhoan_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.plThuMucKhac.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
