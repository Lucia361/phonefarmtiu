// Decompiled with JetBrains decompiler
// Type: fEditFile
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fEditFile : Form
{
  private string string_0;
  private string string_1;
  public bool bool_0 = false;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private Label label1;
  private BunifuDragControl bunifuDragControl_0;
  private MetroTextBox txtNameFileOld;
  private MetroTextBox txtNameFileNew;
  private IContainer components;
  private Label label2;

  public fEditFile(string string_2, string string_3)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.string_0 = string_2;
    this.string_1 = string_3;
    this.bool_0 = false;
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string str = this.txtNameFileNew.Text.Trim();
    if (str == "")
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng điền tên thư mục mới!"), 3);
      this.txtNameFileNew.Focus();
    }
    else if (Class42.smethod_0(str))
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!"), 3);
      this.txtNameFileNew.Focus();
    }
    else if (str.Equals(this.txtNameFileOld.Text.Trim()))
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Tên thư mục mới phải khác thư mục cũ!"), 3);
      this.txtNameFileNew.Focus();
    }
    else if (Class42.smethod_4(this.string_0, str))
    {
      this.bool_0 = true;
      if (GClass14.smethod_1(GClass35.smethod_0("Cập nhật thành công, bạn có muốn đóng cửa sổ?")) != DialogResult.Yes)
        return;
      this.Close();
    }
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Cập nhật tên thư mục lỗi!"));
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void txtNameFileNew_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnAdd_Click((object) null, (EventArgs) null);
  }

  private void fEditFile_Load(object sender, EventArgs e) => this.txtNameFileOld.Text = this.string_1;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fEditFile));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.label1 = new Label();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.txtNameFileOld = new MetroTextBox();
    this.txtNameFileNew = new MetroTextBox();
    this.label2 = new Label();
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
    this.bunifuCards1.Size = new Size(396, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(396, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(362, -2);
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
    this.bunifuCustomLabel1.Size = new Size(396, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Cập nhật Tên thư mục";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(204, 138);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 4;
    this.btnCancel.Text = "Hủy";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(100, 138);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Cập nhật";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label1.Location = new Point(33, 69);
    this.label1.Name = "label1";
    this.label1.Size = new Size(102, 16);
    this.label1.TabIndex = 20;
    this.label1.Text = "Tên thư mục cũ:";
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.txtNameFileOld.CustomButton.Image = (Image) null;
    this.txtNameFileOld.CustomButton.Location = new Point(187, 1);
    this.txtNameFileOld.CustomButton.Name = "";
    this.txtNameFileOld.CustomButton.Size = new Size(21, 21);
    this.txtNameFileOld.CustomButton.Style = MetroColorStyle.Blue;
    this.txtNameFileOld.CustomButton.TabIndex = 1;
    this.txtNameFileOld.CustomButton.Theme = MetroThemeStyle.Light;
    this.txtNameFileOld.CustomButton.UseSelectable = true;
    this.txtNameFileOld.CustomButton.Visible = false;
    this.txtNameFileOld.Enabled = false;
    this.txtNameFileOld.ForeColor = SystemColors.ControlDarkDark;
    this.txtNameFileOld.Lines = new string[0];
    this.txtNameFileOld.Location = new Point(150, 66);
    this.txtNameFileOld.MaxLength = (int) short.MaxValue;
    this.txtNameFileOld.Name = "txtNameFileOld";
    this.txtNameFileOld.PasswordChar = char.MinValue;
    this.txtNameFileOld.ScrollBars = ScrollBars.None;
    this.txtNameFileOld.SelectedText = "";
    this.txtNameFileOld.SelectionLength = 0;
    this.txtNameFileOld.SelectionStart = 0;
    this.txtNameFileOld.ShortcutsEnabled = true;
    this.txtNameFileOld.Size = new Size(209, 23);
    this.txtNameFileOld.TabIndex = 2;
    this.txtNameFileOld.UseSelectable = true;
    this.txtNameFileOld.WaterMarkColor = Color.FromArgb(109, 109, 109);
    this.txtNameFileOld.WaterMarkFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtNameFileOld.KeyDown += new KeyEventHandler(this.txtNameFileNew_KeyDown);
    this.txtNameFileNew.CustomButton.Image = (Image) null;
    this.txtNameFileNew.CustomButton.Location = new Point(187, 1);
    this.txtNameFileNew.CustomButton.Name = "";
    this.txtNameFileNew.CustomButton.Size = new Size(21, 21);
    this.txtNameFileNew.CustomButton.Style = MetroColorStyle.Blue;
    this.txtNameFileNew.CustomButton.TabIndex = 1;
    this.txtNameFileNew.CustomButton.Theme = MetroThemeStyle.Light;
    this.txtNameFileNew.CustomButton.UseSelectable = true;
    this.txtNameFileNew.CustomButton.Visible = false;
    this.txtNameFileNew.Lines = new string[0];
    this.txtNameFileNew.Location = new Point(150, 95);
    this.txtNameFileNew.MaxLength = (int) short.MaxValue;
    this.txtNameFileNew.Name = "txtNameFileNew";
    this.txtNameFileNew.PasswordChar = char.MinValue;
    this.txtNameFileNew.ScrollBars = ScrollBars.None;
    this.txtNameFileNew.SelectedText = "";
    this.txtNameFileNew.SelectionLength = 0;
    this.txtNameFileNew.SelectionStart = 0;
    this.txtNameFileNew.ShortcutsEnabled = true;
    this.txtNameFileNew.Size = new Size(209, 23);
    this.txtNameFileNew.TabIndex = 2;
    this.txtNameFileNew.UseSelectable = true;
    this.txtNameFileNew.WaterMarkColor = Color.FromArgb(109, 109, 109);
    this.txtNameFileNew.WaterMarkFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtNameFileNew.KeyDown += new KeyEventHandler(this.txtNameFileNew_KeyDown);
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label2.Location = new Point(33, 98);
    this.label2.Name = "label2";
    this.label2.Size = new Size(110, 16);
    this.label2.TabIndex = 20;
    this.label2.Text = "Tên thư mục mới:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(396, 182);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.txtNameFileNew);
    this.Controls.Add((Control) this.txtNameFileOld);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fEditFile);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fEditFile_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
