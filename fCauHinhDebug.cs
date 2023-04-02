// Decompiled with JetBrains decompiler
// Type: fCauHinhDebug
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fCauHinhDebug : Form
{
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuCustomLabel lblStatus;
  private CheckBox ckbCheckpoint;
  private CheckBox ckbChangedPass;
  private CheckBox ckbChangeInfoDevice;
  private CheckBox ckbLoginFail;
  private CheckBox ckbCheckSpam;
  private IContainer components;
  private CheckBox ckbJobSeeding;

  public fCauHinhDebug()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    GClass33.smethod_0("configDebug").method_6("ckbCheckpoint", (object) this.ckbCheckpoint.Checked);
    GClass33.smethod_0("configDebug").method_6("ckbChangedPass", (object) this.ckbChangedPass.Checked);
    GClass33.smethod_0("configDebug").method_6("ckbChangeInfoDevice", (object) this.ckbChangeInfoDevice.Checked);
    GClass33.smethod_0("configDebug").method_6("ckbLoginFail", (object) this.ckbLoginFail.Checked);
    GClass33.smethod_0("configDebug").method_6("ckbCheckSpam", (object) this.ckbCheckSpam.Checked);
    GClass33.smethod_0("configDebug").method_6("ckbJobSeeding", (object) this.ckbJobSeeding.Checked);
    GClass33.smethod_2("configDebug");
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void lblStatus_Click(object sender, EventArgs e)
  {
  }

  private void fCauHinhDebug_Load(object sender, EventArgs e)
  {
    this.ckbCheckpoint.Checked = GClass33.smethod_0("configDebug").method_4("ckbCheckpoint");
    this.ckbChangedPass.Checked = GClass33.smethod_0("configDebug").method_4("ckbChangedPass");
    this.ckbChangeInfoDevice.Checked = GClass33.smethod_0("configDebug").method_4("ckbChangeInfoDevice");
    this.ckbLoginFail.Checked = GClass33.smethod_0("configDebug").method_4("ckbLoginFail");
    this.ckbCheckSpam.Checked = GClass33.smethod_0("configDebug").method_4("ckbCheckSpam");
    this.ckbJobSeeding.Checked = GClass33.smethod_0("configDebug").method_4("ckbJobSeeding");
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCauHinhDebug));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.lblStatus = new BunifuCustomLabel();
    this.ckbCheckpoint = new CheckBox();
    this.ckbChangedPass = new CheckBox();
    this.ckbChangeInfoDevice = new CheckBox();
    this.ckbLoginFail = new CheckBox();
    this.ckbCheckSpam = new CheckBox();
    this.ckbJobSeeding = new CheckBox();
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
    this.bunifuCards1.Size = new Size(479, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(479, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(447, 0);
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
    this.bunifuCustomLabel1.Size = new Size(479, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Cấu hình Debug";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(247, 258);
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
    this.btnAdd.Location = new Point(143, 258);
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
    this.lblStatus.BackColor = Color.Transparent;
    this.lblStatus.Cursor = Cursors.SizeAll;
    this.lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.ForeColor = Color.Black;
    this.lblStatus.Location = new Point(51, 41);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(384, 32);
    this.lblStatus.TabIndex = 21;
    this.lblStatus.Text = "Vui lòng chọn những thông tin cần xuất log!";
    this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;
    this.lblStatus.Click += new EventHandler(this.lblStatus_Click);
    this.ckbCheckpoint.AutoSize = true;
    this.ckbCheckpoint.Cursor = Cursors.Hand;
    this.ckbCheckpoint.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbCheckpoint.Location = new Point(118, 86);
    this.ckbCheckpoint.Name = "ckbCheckpoint";
    this.ckbCheckpoint.Size = new Size(88, 20);
    this.ckbCheckpoint.TabIndex = 22;
    this.ckbCheckpoint.Text = "Checkpoint";
    this.ckbCheckpoint.UseVisualStyleBackColor = true;
    this.ckbChangedPass.AutoSize = true;
    this.ckbChangedPass.Cursor = Cursors.Hand;
    this.ckbChangedPass.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbChangedPass.Location = new Point(118, 112);
    this.ckbChangedPass.Name = "ckbChangedPass";
    this.ckbChangedPass.Size = new Size(106, 20);
    this.ckbChangedPass.TabIndex = 22;
    this.ckbChangedPass.Text = "Changed pass";
    this.ckbChangedPass.UseVisualStyleBackColor = true;
    this.ckbChangeInfoDevice.AutoSize = true;
    this.ckbChangeInfoDevice.Cursor = Cursors.Hand;
    this.ckbChangeInfoDevice.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbChangeInfoDevice.Location = new Point(118, 138);
    this.ckbChangeInfoDevice.Name = "ckbChangeInfoDevice";
    this.ckbChangeInfoDevice.Size = new Size(136, 20);
    this.ckbChangeInfoDevice.TabIndex = 22;
    this.ckbChangeInfoDevice.Text = "Change Info Device";
    this.ckbChangeInfoDevice.UseVisualStyleBackColor = true;
    this.ckbLoginFail.AutoSize = true;
    this.ckbLoginFail.Cursor = Cursors.Hand;
    this.ckbLoginFail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbLoginFail.Location = new Point(118, 164);
    this.ckbLoginFail.Name = "ckbLoginFail";
    this.ckbLoginFail.Size = new Size(77, 20);
    this.ckbLoginFail.TabIndex = 22;
    this.ckbLoginFail.Text = "Login fail";
    this.ckbLoginFail.UseVisualStyleBackColor = true;
    this.ckbCheckSpam.AutoSize = true;
    this.ckbCheckSpam.Cursor = Cursors.Hand;
    this.ckbCheckSpam.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbCheckSpam.Location = new Point(118, 190);
    this.ckbCheckSpam.Name = "ckbCheckSpam";
    this.ckbCheckSpam.Size = new Size(117, 20);
    this.ckbCheckSpam.TabIndex = 22;
    this.ckbCheckSpam.Text = "Facebook Spam";
    this.ckbCheckSpam.UseVisualStyleBackColor = true;
    this.ckbJobSeeding.AutoSize = true;
    this.ckbJobSeeding.Cursor = Cursors.Hand;
    this.ckbJobSeeding.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbJobSeeding.Location = new Point(118, 216);
    this.ckbJobSeeding.Name = "ckbJobSeeding";
    this.ckbJobSeeding.Size = new Size(95, 20);
    this.ckbJobSeeding.TabIndex = 22;
    this.ckbJobSeeding.Text = "Job Seeding";
    this.ckbJobSeeding.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(479, 300);
    this.Controls.Add((Control) this.ckbJobSeeding);
    this.Controls.Add((Control) this.ckbCheckSpam);
    this.Controls.Add((Control) this.ckbLoginFail);
    this.Controls.Add((Control) this.ckbChangeInfoDevice);
    this.Controls.Add((Control) this.ckbChangedPass);
    this.Controls.Add((Control) this.ckbCheckpoint);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fCauHinhDebug);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fCauHinhDebug_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
