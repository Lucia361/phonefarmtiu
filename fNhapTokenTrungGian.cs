// Decompiled with JetBrains decompiler
// Type: fNhapTokenTrungGian
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fNhapTokenTrungGian : Form
{
  public static bool bool_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuDragControl bunifuDragControl_0;
  private Label label2;
  private TextBox token;
  private IContainer components;
  private MetroButton btnCheckLiveTokenTg;

  public fNhapTokenTrungGian()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    fNhapTokenTrungGian.bool_0 = false;
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    GClass33.smethod_0("configGeneral").method_6("token", (object) this.token.Text);
    GClass33.smethod_2("configGeneral");
    fNhapTokenTrungGian.bool_0 = true;
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void fNhapTokenTrungGian_Load(object sender, EventArgs e) => this.token.Text = GClass33.smethod_0("configGeneral").method_1("token");

  private void btnCheckLiveTokenTg_Click(object sender, EventArgs e)
  {
    if (Class38.smethod_21("", this.token.Text, "", ""))
      GClass14.smethod_0((object) "Token live!");
    else
      GClass14.smethod_0((object) "Token die!");
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fNhapTokenTrungGian));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.label2 = new Label();
    this.token = new TextBox();
    this.btnCheckLiveTokenTg = new MetroButton();
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
    this.bunifuCards1.Size = new Size(449, 34);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(449, 28);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(417, 0);
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
    this.bunifuCustomLabel1.Size = new Size(449, 28);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Nhập Token trung gian";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(230, 112);
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
    this.btnAdd.Location = new Point(126, 112);
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
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.Location = new Point(31, 61);
    this.label2.Name = "label2";
    this.label2.Size = new Size(110, 16);
    this.label2.TabIndex = 36;
    this.label2.Text = "Token trung gian:";
    this.label2.TextAlign = ContentAlignment.MiddleRight;
    this.token.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.token.Location = new Point(147, 58);
    this.token.Name = "token";
    this.token.Size = new Size(196, 23);
    this.token.TabIndex = 35;
    this.btnCheckLiveTokenTg.Cursor = Cursors.Hand;
    this.btnCheckLiveTokenTg.Location = new Point(349, 58);
    this.btnCheckLiveTokenTg.Name = "btnCheckLiveTokenTg";
    this.btnCheckLiveTokenTg.Size = new Size(61, 23);
    this.btnCheckLiveTokenTg.TabIndex = 37;
    this.btnCheckLiveTokenTg.Text = "Kiểm tra";
    this.btnCheckLiveTokenTg.UseSelectable = true;
    this.btnCheckLiveTokenTg.Click += new EventHandler(this.btnCheckLiveTokenTg_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(449, 159);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.token);
    this.Controls.Add((Control) this.btnCheckLiveTokenTg);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fNhapTokenTrungGian);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fNhapTokenTrungGian_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
