// Decompiled with JetBrains decompiler
// Type: fAddFile
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

public class fAddFile : Form
{
  public static bool bool_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private Label label1;
  private BunifuDragControl bunifuDragControl_0;
  private IContainer components;
  private MetroTextBox txbNameFile;

  public fAddFile()
  {
    this.InitializeComponent();
    fAddFile.bool_0 = false;
    GClass35.smethod_5((Control) this);
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_0 = this.txbNameFile.Text.Trim();
    if (string_0 == "")
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng điền tên thư mục!"));
      this.txbNameFile.Focus();
    }
    else if (Class42.smethod_0(string_0))
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!"));
      this.txbNameFile.Focus();
    }
    else if (Class42.smethod_3(string_0))
    {
      fAddFile.bool_0 = true;
      if (GClass14.smethod_1(GClass35.smethod_0("Thêm thành công, bạn có muốn đóng cửa sổ?")) != DialogResult.Yes)
        return;
      this.Close();
    }
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Thêm thư mục lỗi!"));
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnAdd_Click((object) null, (EventArgs) null);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fAddFile));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.label1 = new Label();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.txbNameFile = new MetroTextBox();
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
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(364, 0);
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
    this.bunifuCustomLabel1.Text = "Thêm thư mục";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(204, 105);
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
    this.btnAdd.Location = new Point(100, 105);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label1.Location = new Point(33, 62);
    this.label1.Name = "label1";
    this.label1.Size = new Size(86, 16);
    this.label1.TabIndex = 20;
    this.label1.Text = "Tên thư mục:";
    this.label1.TextAlign = ContentAlignment.MiddleRight;
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.txbNameFile.CustomButton.Image = (Image) null;
    this.txbNameFile.CustomButton.Location = new Point(212, 1);
    this.txbNameFile.CustomButton.Name = "";
    this.txbNameFile.CustomButton.Size = new Size(21, 21);
    this.txbNameFile.CustomButton.Style = MetroColorStyle.Blue;
    this.txbNameFile.CustomButton.TabIndex = 1;
    this.txbNameFile.CustomButton.Theme = MetroThemeStyle.Light;
    this.txbNameFile.CustomButton.UseSelectable = true;
    this.txbNameFile.CustomButton.Visible = false;
    this.txbNameFile.Lines = new string[0];
    this.txbNameFile.Location = new Point(125, 59);
    this.txbNameFile.MaxLength = (int) short.MaxValue;
    this.txbNameFile.Name = "txbNameFile";
    this.txbNameFile.PasswordChar = char.MinValue;
    this.txbNameFile.ScrollBars = ScrollBars.None;
    this.txbNameFile.SelectedText = "";
    this.txbNameFile.SelectionLength = 0;
    this.txbNameFile.SelectionStart = 0;
    this.txbNameFile.ShortcutsEnabled = true;
    this.txbNameFile.Size = new Size(234, 23);
    this.txbNameFile.TabIndex = 2;
    this.txbNameFile.UseSelectable = true;
    this.txbNameFile.WaterMarkColor = Color.FromArgb(109, 109, 109);
    this.txbNameFile.WaterMarkFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txbNameFile.KeyDown += new KeyEventHandler(this.txbNameFile_KeyDown);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(396, 145);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.txbNameFile);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fAddFile);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = nameof (fAddFile);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
