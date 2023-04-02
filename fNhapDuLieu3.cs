// Decompiled with JetBrains decompiler
// Type: fNhapDuLieu3
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class fNhapDuLieu3 : Form
{
  private string string_0 = "";
  private string string_1 = "";
  public string string_2 = "";
  public int int_0 = 0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel panel1;
  private BunifuDragControl bunifuDragControl_0;
  private ToolTip toolTip_0;
  private BunifuCards bunifuCards2;
  private Panel pnlHeader;
  private Button button2;
  private Button btnMinimize;
  private BunifuCustomLabel lblTitle;
  private Label lblStatus;
  private Button btnCancel;
  private Button btnAdd;
  private Label lblFooter;
  private RichTextBox txtComment;
  private Button button3;
  private Button button1;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private IContainer components;
  private Label label9;

  public fNhapDuLieu3(
    string string_3,
    string string_4 = "Nhập danh sách Uid cần clone",
    string string_5 = "Danh sách Uid",
    string string_6 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})",
    List<string> list_0 = null)
  {
    this.InitializeComponent();
    GClass19.smethod_32(string_3);
    this.string_0 = string_3;
    this.string_1 = string_5;
    this.lblTitle.Text = string_4;
    this.lblStatus.Text = string_5 + " (0):";
    this.lblFooter.Text = string_6;
    if (list_0 != null)
    {
      File.WriteAllLines(string_3, (IEnumerable<string>) list_0);
      this.txtComment.Lines = list_0.ToArray();
    }
    else
      this.txtComment.Lines = File.ReadAllLines(string_3);
    this.txtComment_TextChanged((object) null, (EventArgs) null);
    GClass35.smethod_5((Control) this);
  }

  public fNhapDuLieu3(
    string string_3,
    int int_1,
    string string_4 = "Nhập danh sách Uid cần clone",
    string string_5 = "Danh sách Uid",
    string string_6 = "(Spin nội dung {a|b|c})")
  {
    this.InitializeComponent();
    this.string_2 = string_3;
    this.int_0 = int_1;
    this.string_1 = string_5;
    this.lblTitle.Text = string_4;
    this.lblStatus.Text = string_5 + " (0):";
    this.lblFooter.Text = string_6;
    GClass35.smethod_5((Control) this);
  }

  private void fNhapDuLieu3_Load(object sender, EventArgs e)
  {
    if (this.int_0 == 0)
      this.rbNganCachMoiDong.Checked = true;
    else
      this.rbNganCachKyTu.Checked = true;
    if (this.string_0 != "")
      this.txtComment.Lines = File.ReadAllLines(this.string_0);
    else
      this.txtComment.Text = this.string_2;
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void button2_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.string_0 != "")
      {
        File.WriteAllText(this.string_0, this.txtComment.Text.Trim());
      }
      else
      {
        this.string_2 = this.txtComment.Text;
        this.int_0 = !this.rbNganCachMoiDong.Checked ? 1 : 0;
      }
      if (MessageBox.Show("Lưu thành công, bạn có muốn đóng cửa sổ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      this.Close();
    }
    catch
    {
      GClass14.smethod_0((object) "Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void txtComment_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtComment, (Control) this.lblStatus, !this.rbNganCachMoiDong.Checked ? 1 : 0);

  private void button1_Click(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));

  private void button3_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fHelpNhapComment());

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => this.txtComment_TextChanged((object) null, (EventArgs) null);

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => this.txtComment_TextChanged((object) null, (EventArgs) null);

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.bunifuCards1 = new BunifuCards();
    this.panel1 = new Panel();
    this.button3 = new Button();
    this.button1 = new Button();
    this.rbNganCachKyTu = new RadioButton();
    this.rbNganCachMoiDong = new RadioButton();
    this.label9 = new Label();
    this.txtComment = new RichTextBox();
    this.lblFooter = new Label();
    this.lblStatus = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards2 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.btnMinimize = new Button();
    this.lblTitle = new BunifuCustomLabel();
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
    this.bunifuCards1.Margin = new Padding(3, 4, 3, 4);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(234, 47);
    this.bunifuCards1.TabIndex = 12;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.button3);
    this.panel1.Controls.Add((Control) this.button1);
    this.panel1.Controls.Add((Control) this.rbNganCachKyTu);
    this.panel1.Controls.Add((Control) this.rbNganCachMoiDong);
    this.panel1.Controls.Add((Control) this.label9);
    this.panel1.Controls.Add((Control) this.txtComment);
    this.panel1.Controls.Add((Control) this.lblFooter);
    this.panel1.Controls.Add((Control) this.lblStatus);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards2);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Margin = new Padding(3, 4, 3, 4);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(563, 355);
    this.panel1.TabIndex = 37;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.button3.Cursor = Cursors.Help;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.Location = new Point(237, 274);
    this.button3.Name = "button3";
    this.button3.Size = new Size(21, 23);
    this.button3.TabIndex = 198;
    this.button3.Text = "?";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button1.Cursor = Cursors.Help;
    this.button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button1.Location = new Point(237, 251);
    this.button1.Name = "button1";
    this.button1.Size = new Size(21, 23);
    this.button1.TabIndex = 199;
    this.button1.Text = "?";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(78, 275);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(159, 20);
    this.rbNganCachKyTu.TabIndex = 197;
    this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachKyTu.CheckedChanged += new EventHandler(this.rbNganCachKyTu_CheckedChanged);
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(78, 253);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(155, 20);
    this.rbNganCachMoiDong.TabIndex = 196;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.CheckedChanged += new EventHandler(this.rbNganCachMoiDong_CheckedChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(13, 253);
    this.label9.Name = "label9";
    this.label9.Size = new Size(64, 16);
    this.label9.TabIndex = 195;
    this.label9.Text = "Tùy chọn:";
    this.txtComment.Location = new Point(16, 64);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(528, 186);
    this.txtComment.TabIndex = 50;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.lblFooter.AutoSize = true;
    this.lblFooter.Location = new Point(404, 253);
    this.lblFooter.Name = "lblFooter";
    this.lblFooter.Size = new Size(143, 16);
    this.lblFooter.TabIndex = 49;
    this.lblFooter.Text = "(Spin nội dung {a|b|c})";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.lblStatus.Location = new Point(13, 45);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(139, 16);
    this.lblStatus.TabIndex = 47;
    this.lblStatus.Text = "Nội dung bình luận (0):";
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(287, 313);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 46;
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
    this.btnAdd.Location = new Point(183, 313);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 45;
    this.btnAdd.Text = "Lưu";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
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
    this.bunifuCards2.Size = new Size(561, 37);
    this.bunifuCards2.TabIndex = 43;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.lblTitle);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(561, 31);
    this.pnlHeader.TabIndex = 9;
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) Resources.btnMinimize_Image;
    this.button2.Location = new Point(530, 1);
    this.button2.Name = "button2";
    this.button2.Size = new Size(30, 30);
    this.button2.TabIndex = 77;
    this.button2.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Location = new Point(899, 1);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(30, 30);
    this.btnMinimize.TabIndex = 9;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.lblTitle.BackColor = Color.Transparent;
    this.lblTitle.Cursor = Cursors.SizeAll;
    this.lblTitle.Dock = DockStyle.Fill;
    this.lblTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.Black;
    this.lblTitle.Location = new Point(0, 0);
    this.lblTitle.Name = "lblTitle";
    this.lblTitle.Size = new Size(561, 31);
    this.lblTitle.TabIndex = 12;
    this.lblTitle.Text = "Nhập nội dung comment";
    this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.lblTitle;
    this.bunifuDragControl_0.Vertical = true;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 10000;
    this.toolTip_0.InitialDelay = 200;
    this.toolTip_0.ReshowDelay = 40;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(563, 355);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fNhapDuLieu3);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fNhapDuLieu3_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
