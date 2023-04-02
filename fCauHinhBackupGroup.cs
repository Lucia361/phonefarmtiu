// Decompiled with JetBrains decompiler
// Type: fCauHinhBackupGroup
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fCauHinhBackupGroup : Form
{
  public bool bool_0 = false;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuDragControl bunifuDragControl_0;
  private CheckBox ckbCheckNhomKiemDuyet;
  private Label label1;
  private RadioButton rbRunByPhone;
  private IContainer components;
  private RadioButton rbRunHidden;

  public fCauHinhBackupGroup()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (this.rbRunByPhone.Checked)
      GClass33.smethod_0("configBackupGroup").method_6("typeRun", (object) 0);
    else if (this.rbRunHidden.Checked)
      GClass33.smethod_0("configBackupGroup").method_6("typeRun", (object) 1);
    GClass33.smethod_0("configBackupGroup").method_6("ckbCheckNhomKiemDuyet", (object) this.ckbCheckNhomKiemDuyet.Checked);
    GClass33.smethod_2("configBackupGroup");
    this.bool_0 = true;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void fCauHinhBackupGroup_Load(object sender, EventArgs e)
  {
    switch (GClass33.smethod_0("configBackupGroup").method_3("typeRun"))
    {
      case 0:
        this.rbRunByPhone.Checked = true;
        break;
      case 1:
        this.rbRunHidden.Checked = true;
        break;
    }
    this.ckbCheckNhomKiemDuyet.Checked = GClass33.smethod_0("configBackupGroup").method_4("ckbCheckNhomKiemDuyet");
  }

  private void rbRunHidden_Click(object sender, EventArgs e)
  {
    if (!this.rbRunHidden.Checked || GClass14.smethod_1(GClass35.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) != DialogResult.No)
      return;
    this.rbRunHidden.Checked = false;
  }

  private void ckbCheckNhomKiemDuyet_Click(object sender, EventArgs e)
  {
    if (!this.ckbCheckNhomKiemDuyet.Checked || GClass14.smethod_1(GClass35.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) != DialogResult.No)
      return;
    this.ckbCheckNhomKiemDuyet.Checked = false;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCauHinhBackupGroup));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.ckbCheckNhomKiemDuyet = new CheckBox();
    this.label1 = new Label();
    this.rbRunByPhone = new RadioButton();
    this.rbRunHidden = new RadioButton();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
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
    this.bunifuCards1.Size = new Size(319, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(319, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(287, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
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
    this.bunifuCustomLabel1.Size = new Size(319, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Cấu hình Backup Group";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(167, 147);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 4;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(63, 147);
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
    this.ckbCheckNhomKiemDuyet.AutoSize = true;
    this.ckbCheckNhomKiemDuyet.Cursor = Cursors.Hand;
    this.ckbCheckNhomKiemDuyet.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbCheckNhomKiemDuyet.Location = new Point(67, 111);
    this.ckbCheckNhomKiemDuyet.Name = "ckbCheckNhomKiemDuyet";
    this.ckbCheckNhomKiemDuyet.Size = new Size(162, 20);
    this.ckbCheckNhomKiemDuyet.TabIndex = 22;
    this.ckbCheckNhomKiemDuyet.Text = "Check nhóm kiểm duyệt";
    this.ckbCheckNhomKiemDuyet.UseVisualStyleBackColor = true;
    this.ckbCheckNhomKiemDuyet.Click += new EventHandler(this.ckbCheckNhomKiemDuyet_Click);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(64, 62);
    this.label1.Name = "label1";
    this.label1.Size = new Size(64, 16);
    this.label1.TabIndex = 23;
    this.label1.Text = "Tùy chọn:";
    this.rbRunByPhone.AutoSize = true;
    this.rbRunByPhone.Cursor = Cursors.Hand;
    this.rbRunByPhone.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbRunByPhone.Location = new Point(134, 62);
    this.rbRunByPhone.Name = "rbRunByPhone";
    this.rbRunByPhone.Size = new Size(112, 20);
    this.rbRunByPhone.TabIndex = 24;
    this.rbRunByPhone.TabStop = true;
    this.rbRunByPhone.Text = "Sử dụng phone";
    this.rbRunByPhone.UseVisualStyleBackColor = true;
    this.rbRunHidden.AutoSize = true;
    this.rbRunHidden.Cursor = Cursors.Hand;
    this.rbRunHidden.Enabled = false;
    this.rbRunHidden.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbRunHidden.Location = new Point(134, 85);
    this.rbRunHidden.Name = "rbRunHidden";
    this.rbRunHidden.Size = new Size(121, 20);
    this.rbRunHidden.TabIndex = 24;
    this.rbRunHidden.TabStop = true;
    this.rbRunHidden.Text = "Chạy ẩn (cookie)";
    this.rbRunHidden.UseVisualStyleBackColor = true;
    this.rbRunHidden.Click += new EventHandler(this.rbRunHidden_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(319, 189);
    this.Controls.Add((Control) this.rbRunHidden);
    this.Controls.Add((Control) this.rbRunByPhone);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.ckbCheckNhomKiemDuyet);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fCauHinhBackupGroup);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fCauHinhBackupGroup_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
