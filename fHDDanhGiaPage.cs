// Decompiled with JetBrains decompiler
// Type: fHDDanhGiaPage
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fHDDanhGiaPage : Form
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
  private BunifuCustomLabel bunifuCustomLabel1;
  private Label lblStatus;
  private CheckBox ckbInteract;
  private RichTextBox txtComment;
  private Button btnMinimize;
  private Label lblUid;
  private TextBox txtUid;
  private CheckBox ckbTuDongXoaNoiDung;
  private Button button3;
  private Button button2;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private IContainer components;
  private Label label9;

  public fHDDanhGiaPage(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDDanhGiaPage.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDDanhGiaPage").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDDanhGiaPage', 'Đánh giá Page');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDDanhGiaPage");
        string_1 = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        string_1 = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.gclass22_0 = new GClass22(string_1, true);
    GClass35.smethod_5((Control) this);
  }

  private void fHDDanhGiaPage_Load(object sender, EventArgs e)
  {
    try
    {
      this.txtUid.Text = this.gclass22_0.method_1("txtUid");
      this.ckbInteract.Checked = this.gclass22_0.method_4("ckbInteract");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
      if (this.gclass22_0.method_3("typeNganCach") == 1)
        this.rbNganCachKyTu.Checked = true;
      else
        this.rbNganCachMoiDong.Checked = true;
      this.ckbTuDongXoaNoiDung.Checked = this.gclass22_0.method_4("ckbTuDongXoaNoiDung");
    }
    catch
    {
    }
    this.method_0();
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
      GClass14.smethod_0((object) "Vui lòng nhập tên hành động!", 3);
    else if (GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) "Vui lòng nhập nội dung đánh giá!", 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("txtUid", (object) this.txtUid.Text.Trim());
      gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      int object_0 = 0;
      if (this.rbNganCachKyTu.Checked)
        object_0 = 1;
      gclass22.method_6("typeNganCach", (object) object_0);
      gclass22.method_6("ckbTuDongXoaNoiDung", (object) this.ckbTuDongXoaNoiDung.Checked);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1("Bạn có muốn thêm hành động mới?") != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDDanhGiaPage.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) "Thêm thất bại, vui lòng thử lại sau!", 2);
      }
      else
      {
        if (GClass14.smethod_1("Bạn có muốn cập nhật hành động?") != DialogResult.Yes)
          return;
        if (Class205.smethod_21(this.string_2, string_1, str))
        {
          fHDDanhGiaPage.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) "Cập nhật thất bại, vui lòng thử lại sau!", 2);
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

  private void txtComment_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtComment, (Control) this.lblStatus, !this.rbNganCachMoiDong.Checked ? 1 : 0);

  private void method_0()
  {
    this.ckbInteract_CheckedChanged((object) null, (EventArgs) null);
    this.method_1((object) null, (EventArgs) null);
    this.method_2((object) null, (EventArgs) null);
  }

  private void method_1(object sender, EventArgs e)
  {
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
  }

  private void ckbInteract_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void method_2(object sender, EventArgs e)
  {
  }

  private void button2_Click(object sender, EventArgs e)
  {
    GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
    this.txtComment.Focus();
  }

  private void button3_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHelpNhapComment());
    this.txtComment.Focus();
  }

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtComment, (Control) this.lblStatus, !this.rbNganCachMoiDong.Checked ? 1 : 0);

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtComment, (Control) this.lblStatus, !this.rbNganCachMoiDong.Checked ? 1 : 0);

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.panel1 = new Panel();
    this.button3 = new Button();
    this.button2 = new Button();
    this.rbNganCachKyTu = new RadioButton();
    this.rbNganCachMoiDong = new RadioButton();
    this.label9 = new Label();
    this.ckbTuDongXoaNoiDung = new CheckBox();
    this.txtComment = new RichTextBox();
    this.txtUid = new TextBox();
    this.lblStatus = new Label();
    this.ckbInteract = new CheckBox();
    this.lblUid = new Label();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(343, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Đánh giá Page";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(343, 31);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) Resources.btnMinimize_Image;
    this.btnMinimize.Location = new Point(310, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 78;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.button3);
    this.panel1.Controls.Add((Control) this.button2);
    this.panel1.Controls.Add((Control) this.rbNganCachKyTu);
    this.panel1.Controls.Add((Control) this.rbNganCachMoiDong);
    this.panel1.Controls.Add((Control) this.label9);
    this.panel1.Controls.Add((Control) this.ckbTuDongXoaNoiDung);
    this.panel1.Controls.Add((Control) this.txtComment);
    this.panel1.Controls.Add((Control) this.txtUid);
    this.panel1.Controls.Add((Control) this.lblStatus);
    this.panel1.Controls.Add((Control) this.ckbInteract);
    this.panel1.Controls.Add((Control) this.lblUid);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(346, 387);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.button3.Cursor = Cursors.Help;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.Location = new Point(245, 286);
    this.button3.Name = "button3";
    this.button3.Size = new Size(21, 23);
    this.button3.TabIndex = 134;
    this.button3.Text = "?";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button2.Cursor = Cursors.Help;
    this.button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button2.Location = new Point(245, 263);
    this.button2.Name = "button2";
    this.button2.Size = new Size(21, 23);
    this.button2.TabIndex = 135;
    this.button2.Text = "?";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(86, 286);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(159, 20);
    this.rbNganCachKyTu.TabIndex = 132;
    this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachKyTu.CheckedChanged += new EventHandler(this.rbNganCachKyTu_CheckedChanged);
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(86, 265);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(155, 20);
    this.rbNganCachMoiDong.TabIndex = 133;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.CheckedChanged += new EventHandler(this.rbNganCachMoiDong_CheckedChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(21, 265);
    this.label9.Name = "label9";
    this.label9.Size = new Size(64, 16);
    this.label9.TabIndex = 131;
    this.label9.Text = "Tùy chọn:";
    this.ckbTuDongXoaNoiDung.AutoSize = true;
    this.ckbTuDongXoaNoiDung.Cursor = Cursors.Hand;
    this.ckbTuDongXoaNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuDongXoaNoiDung.Location = new Point(24, 312);
    this.ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
    this.ckbTuDongXoaNoiDung.Size = new Size(219, 20);
    this.ckbTuDongXoaNoiDung.TabIndex = 130;
    this.ckbTuDongXoaNoiDung.Text = "Tự động xóa nội dung đã sử dụng";
    this.ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
    this.txtComment.Location = new Point(25, 150);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(295, 111);
    this.txtComment.TabIndex = 106;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.txtUid.Location = new Point(132, 78);
    this.txtUid.Name = "txtUid";
    this.txtUid.Size = new Size(188, 23);
    this.txtUid.TabIndex = 129;
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(21, 130);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(136, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung đánh giá (0):";
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(24, 105);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(80, 20);
    this.ckbInteract.TabIndex = 7;
    this.ckbInteract.Text = "Like page";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.lblUid.AutoSize = true;
    this.lblUid.Location = new Point(21, 81);
    this.lblUid.Name = "lblUid";
    this.lblUid.Size = new Size(55, 16);
    this.lblUid.TabIndex = 126;
    this.lblUid.Text = "Id Page:";
    this.txtTenHanhDong.Location = new Point(132, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(188, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(21, 52);
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
    this.btnCancel.Location = new Point(177, 345);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 12;
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
    this.btnAdd.Location = new Point(79, 345);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 11;
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
    this.bunifuCards1.Size = new Size(343, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(346, 387);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDDanhGiaPage);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDDanhGiaPage_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
