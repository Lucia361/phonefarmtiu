// Decompiled with JetBrains decompiler
// Type: fCauHinhLDPlayer
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fCauHinhLDPlayer : Form
{
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel panel1;
  private BunifuDragControl bunifuDragControl_0;
  private ToolTip toolTip_0;
  private Button btnCancel;
  private Button btnSave;
  private RadioButton rbBackupNhe;
  private Label label10;
  private BunifuCards bunifuCards2;
  private Panel pnlHeader;
  private Button button2;
  private BunifuCustomLabel bunifuCustomLabel1;
  private RadioButton rbBackupFull;
  private RadioButton rbBackupThuong;
  private ComboBox cbbRAM;
  private ComboBox cbbCPU;
  private Label label2;
  private Label label1;
  private CheckBox ckbEnableGPS;
  private IContainer components;
  private CheckBox ckbTuDongClearDataAppFbKhiLogout;

  public fCauHinhLDPlayer()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void fCauHinhLDPlayer_Load(object sender, EventArgs e)
  {
    this.cbbCPU.Text = GClass33.smethod_0("configLDPlayer").method_1("cbbCPU", "1 cores (Khuyến nghị)");
    this.cbbRAM.Text = GClass33.smethod_0("configLDPlayer").method_1("cbbRAM", "1024M (Khuyến nghị)");
    this.ckbEnableGPS.Checked = GClass33.smethod_0("configLDPlayer").method_4("ckbEnableGPS");
    this.ckbTuDongClearDataAppFbKhiLogout.Checked = GClass33.smethod_0("configLDPlayer").method_4("ckbTuDongClearDataAppFbKhiLogout");
    switch (GClass33.smethod_0("configLDPlayer").method_3("typeBackupDataFb"))
    {
      case 0:
        this.rbBackupNhe.Checked = true;
        break;
      case 1:
        this.rbBackupThuong.Checked = true;
        break;
      case 2:
        this.rbBackupFull.Checked = true;
        break;
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      GClass33.smethod_0("configLDPlayer").method_6("cbbCPU", (object) this.cbbCPU.Text);
      GClass33.smethod_0("configLDPlayer").method_6("cbbRAM", (object) this.cbbRAM.Text);
      GClass33.smethod_0("configLDPlayer").method_6("ckbEnableGPS", (object) this.ckbEnableGPS.Checked);
      GClass33.smethod_0("configLDPlayer").method_6("ckbTuDongClearDataAppFbKhiLogout", (object) this.ckbTuDongClearDataAppFbKhiLogout.Checked);
      int object_0 = 0;
      if (this.rbBackupNhe.Checked)
        object_0 = 0;
      else if (this.rbBackupThuong.Checked)
        object_0 = 1;
      else if (this.rbBackupFull.Checked)
        object_0 = 2;
      GClass33.smethod_0("configLDPlayer").method_6("typeBackupDataFb", (object) object_0);
      GClass33.smethod_2("configLDPlayer");
      if (GClass14.smethod_1(GClass35.smethod_0("Lưu thành công, bạn có muốn đóng cửa sổ?")) != DialogResult.Yes)
        return;
      this.Close();
    }
    catch
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Lỗi!"));
    }
  }

  private void pictureBox1_Click(object sender, EventArgs e)
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCauHinhLDPlayer));
    this.bunifuCards1 = new BunifuCards();
    this.panel1 = new Panel();
    this.ckbTuDongClearDataAppFbKhiLogout = new CheckBox();
    this.ckbEnableGPS = new CheckBox();
    this.cbbRAM = new ComboBox();
    this.cbbCPU = new ComboBox();
    this.bunifuCards2 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnSave = new Button();
    this.rbBackupFull = new RadioButton();
    this.rbBackupThuong = new RadioButton();
    this.label2 = new Label();
    this.rbBackupNhe = new RadioButton();
    this.label1 = new Label();
    this.label10 = new Label();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.panel1.SuspendLayout();
    this.bunifuCards2.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.SuspendLayout();
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 5;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(0, 38);
    this.bunifuCards1.TabIndex = 12;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.ckbTuDongClearDataAppFbKhiLogout);
    this.panel1.Controls.Add((Control) this.ckbEnableGPS);
    this.panel1.Controls.Add((Control) this.cbbRAM);
    this.panel1.Controls.Add((Control) this.cbbCPU);
    this.panel1.Controls.Add((Control) this.bunifuCards2);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnSave);
    this.panel1.Controls.Add((Control) this.rbBackupFull);
    this.panel1.Controls.Add((Control) this.rbBackupThuong);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.rbBackupNhe);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.label10);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(302, 293);
    this.panel1.TabIndex = 37;
    this.ckbTuDongClearDataAppFbKhiLogout.AutoSize = true;
    this.ckbTuDongClearDataAppFbKhiLogout.Cursor = Cursors.Hand;
    this.ckbTuDongClearDataAppFbKhiLogout.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbTuDongClearDataAppFbKhiLogout.Location = new Point(35, 219);
    this.ckbTuDongClearDataAppFbKhiLogout.Name = "ckbTuDongClearDataAppFbKhiLogout";
    this.ckbTuDongClearDataAppFbKhiLogout.Size = new Size(244, 20);
    this.ckbTuDongClearDataAppFbKhiLogout.TabIndex = 165;
    this.ckbTuDongClearDataAppFbKhiLogout.Text = "Tự động Clear Data App Fb khi Logout";
    this.ckbTuDongClearDataAppFbKhiLogout.UseVisualStyleBackColor = true;
    this.ckbEnableGPS.AutoSize = true;
    this.ckbEnableGPS.Cursor = Cursors.Hand;
    this.ckbEnableGPS.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbEnableGPS.Location = new Point(35, 197);
    this.ckbEnableGPS.Name = "ckbEnableGPS";
    this.ckbEnableGPS.Size = new Size(91, 20);
    this.ckbEnableGPS.TabIndex = 165;
    this.ckbEnableGPS.Text = "Enable GPS";
    this.ckbEnableGPS.UseVisualStyleBackColor = true;
    this.cbbRAM.Cursor = Cursors.Hand;
    this.cbbRAM.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbRAM.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbRAM.FormattingEnabled = true;
    this.cbbRAM.Items.AddRange(new object[9]
    {
      (object) "256M",
      (object) "512M",
      (object) "768M",
      (object) "1024M (Khuyến nghị)",
      (object) "1536M",
      (object) "2048M",
      (object) "3072M",
      (object) "4096M",
      (object) "8192M"
    });
    this.cbbRAM.Location = new Point(74, 80);
    this.cbbRAM.Name = "cbbRAM";
    this.cbbRAM.Size = new Size(152, 24);
    this.cbbRAM.TabIndex = 162;
    this.cbbCPU.Cursor = Cursors.Hand;
    this.cbbCPU.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbCPU.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbCPU.FormattingEnabled = true;
    this.cbbCPU.Items.AddRange(new object[5]
    {
      (object) "1 cores (Khuyến nghị)",
      (object) "2 cores",
      (object) "3 cores",
      (object) "4 cores",
      (object) "6 cores"
    });
    this.cbbCPU.Location = new Point(74, 50);
    this.cbbCPU.Name = "cbbCPU";
    this.cbbCPU.Size = new Size(152, 24);
    this.cbbCPU.TabIndex = 162;
    this.bunifuCards2.BackColor = Color.White;
    this.bunifuCards2.BorderRadius = 0;
    this.bunifuCards2.BottomSahddow = true;
    this.bunifuCards2.color = Color.SaddleBrown;
    this.bunifuCards2.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards2.Dock = DockStyle.Top;
    this.bunifuCards2.LeftSahddow = false;
    this.bunifuCards2.Location = new Point(0, 0);
    this.bunifuCards2.Name = "bunifuCards2";
    this.bunifuCards2.RightSahddow = true;
    this.bunifuCards2.ShadowDepth = 20;
    this.bunifuCards2.Size = new Size(300, 37);
    this.bunifuCards2.TabIndex = 40;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(300, 31);
    this.pnlHeader.TabIndex = 9;
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) componentResourceManager.GetObject("button2.Image");
    this.button2.Location = new Point(269, 1);
    this.button2.Name = "button2";
    this.button2.Size = new Size(30, 30);
    this.button2.TabIndex = 77;
    this.button2.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.btnCancel_Click);
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(300, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình LDPlayer";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(155, 251);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 20;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnSave.Anchor = AnchorStyles.Bottom;
    this.btnSave.BackColor = Color.FromArgb(53, 120, 229);
    this.btnSave.Cursor = Cursors.Hand;
    this.btnSave.FlatAppearance.BorderSize = 0;
    this.btnSave.FlatStyle = FlatStyle.Flat;
    this.btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnSave.ForeColor = Color.White;
    this.btnSave.Location = new Point(55, 251);
    this.btnSave.Name = "btnSave";
    this.btnSave.Size = new Size(92, 29);
    this.btnSave.TabIndex = 19;
    this.btnSave.Text = "Lưu";
    this.btnSave.UseVisualStyleBackColor = false;
    this.btnSave.Click += new EventHandler(this.btnSave_Click);
    this.rbBackupFull.AutoSize = true;
    this.rbBackupFull.Cursor = Cursors.Hand;
    this.rbBackupFull.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbBackupFull.Location = new Point(73, 174);
    this.rbBackupFull.Name = "rbBackupFull";
    this.rbBackupFull.Size = new Size(107, 20);
    this.rbBackupFull.TabIndex = 161;
    this.rbBackupFull.Text = "Backup đầy đủ";
    this.rbBackupFull.UseVisualStyleBackColor = true;
    this.rbBackupThuong.AutoSize = true;
    this.rbBackupThuong.Cursor = Cursors.Hand;
    this.rbBackupThuong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbBackupThuong.Location = new Point(73, 151);
    this.rbBackupThuong.Name = "rbBackupThuong";
    this.rbBackupThuong.Size = new Size(109, 20);
    this.rbBackupThuong.TabIndex = 161;
    this.rbBackupThuong.Text = "Backup thường";
    this.rbBackupThuong.UseVisualStyleBackColor = true;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.Location = new Point(32, 83);
    this.label2.Name = "label2";
    this.label2.Size = new Size(38, 16);
    this.label2.TabIndex = 158;
    this.label2.Text = "RAM:";
    this.rbBackupNhe.AutoSize = true;
    this.rbBackupNhe.Checked = true;
    this.rbBackupNhe.Cursor = Cursors.Hand;
    this.rbBackupNhe.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbBackupNhe.Location = new Point(73, 128);
    this.rbBackupNhe.Name = "rbBackupNhe";
    this.rbBackupNhe.Size = new Size(200, 20);
    this.rbBackupNhe.TabIndex = 161;
    this.rbBackupNhe.TabStop = true;
    this.rbBackupNhe.Text = "Backup siêu nhẹ (Khuyến nghị)";
    this.rbBackupNhe.UseVisualStyleBackColor = true;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(32, 53);
    this.label1.Name = "label1";
    this.label1.Size = new Size(35, 16);
    this.label1.TabIndex = 158;
    this.label1.Text = "CPU:";
    this.label10.AutoSize = true;
    this.label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label10.Location = new Point(32, 109);
    this.label10.Name = "label10";
    this.label10.Size = new Size(139, 16);
    this.label10.TabIndex = 158;
    this.label10.Text = "Backup data Facebook:";
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 10000;
    this.toolTip_0.InitialDelay = 200;
    this.toolTip_0.ReshowDelay = 40;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(302, 293);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fCauHinhLDPlayer);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fCauHinhLDPlayer_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
