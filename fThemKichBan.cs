// Decompiled with JetBrains decompiler
// Type: fThemKichBan
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

public class fThemKichBan : Form
{
  private int int_0 = 0;
  private string string_0 = "";
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button button1;
  private Label label2;
  private Button btnCancel;
  private Button btnAdd;
  private MetroTextBox txtTen;
  private IContainer components;
  private Panel panel1;

  public fThemKichBan(int int_1, string string_1 = "")
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.int_0 = int_1;
    this.string_0 = string_1;
    if (int_1 != 1)
      return;
    this.bunifuCustomLabel1.Text = GClass35.smethod_0("Cập nhật kịch bản");
    this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
    this.txtTen.Text = Class205.smethod_2(string_1).Rows[0]["TenKichBan"].ToString();
  }

  private void fThemKichBan_Load(object sender, EventArgs e)
  {
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string str = this.txtTen.Text.Trim();
    if (str == "")
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên kịch bản!"), 2);
    else if (this.int_0 == 0)
    {
      if (Class205.smethod_9(str))
        this.Close();
      else
        GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
    }
    else if (Class205.smethod_10(this.string_0, str))
      this.Close();
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
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

  private void txtTen_KeyDown(object sender, KeyEventArgs e)
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fThemKichBan));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.label2 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.txtTen = new MetroTextBox();
    this.panel1 = new Panel();
    this.pnlHeader.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(324, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Thêm kịch bản";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button1);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(1, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(324, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(293, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.DarkViolet;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(2, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(327, 37);
    this.bunifuCards1.TabIndex = 12;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label2.Location = new Point(32, 55);
    this.label2.Name = "label2";
    this.label2.Size = new Size(85, 16);
    this.label2.TabIndex = 24;
    this.label2.Text = "Tên kịch bản:";
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(171, 96);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 2;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(67, 96);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.txtTen.CustomButton.Image = (Image) null;
    this.txtTen.CustomButton.Location = new Point(149, 1);
    this.txtTen.CustomButton.Name = "";
    this.txtTen.CustomButton.Size = new Size(21, 21);
    this.txtTen.CustomButton.Style = MetroColorStyle.Blue;
    this.txtTen.CustomButton.TabIndex = 1;
    this.txtTen.CustomButton.Theme = MetroThemeStyle.Light;
    this.txtTen.CustomButton.UseSelectable = true;
    this.txtTen.CustomButton.Visible = false;
    this.txtTen.Lines = new string[0];
    this.txtTen.Location = new Point(124, 52);
    this.txtTen.MaxLength = (int) short.MaxValue;
    this.txtTen.Name = "txtTen";
    this.txtTen.PasswordChar = char.MinValue;
    this.txtTen.ScrollBars = ScrollBars.None;
    this.txtTen.SelectedText = "";
    this.txtTen.SelectionLength = 0;
    this.txtTen.SelectionStart = 0;
    this.txtTen.ShortcutsEnabled = true;
    this.txtTen.Size = new Size(171, 23);
    this.txtTen.TabIndex = 0;
    this.txtTen.UseSelectable = true;
    this.txtTen.WaterMarkColor = Color.FromArgb(109, 109, 109);
    this.txtTen.WaterMarkFont = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTen.KeyDown += new KeyEventHandler(this.txtTen_KeyDown);
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(330, 137);
    this.panel1.TabIndex = 25;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(330, 137);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.txtTen);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fThemKichBan);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fThemKichBan_Load);
    this.pnlHeader.ResumeLayout(false);
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
