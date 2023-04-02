// Decompiled with JetBrains decompiler
// Type: fHDTuongTacBaiVietIA
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fHDTuongTacBaiVietIA : Form
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
  private Button btnMinimize;
  private Label lblUid;
  private Label label15;
  private Label label5;
  private TextBox txtIdPage;
  private Label label7;
  private Label label4;
  private Label label6;
  private NumericUpDown nudThoiGianLuotTo;
  private NumericUpDown nudThoiGianLuotFrom;
  private Label label3;
  private NumericUpDown nudSoLuongBaiFrom;
  private NumericUpDown nudSoLuongBaiTo;
  private Panel plTuongTacQuangCao;
  private RichTextBox txtNoiDungTinNhan;
  private Label label2;
  private IContainer components;
  private CheckBox ckbTuongTacQuangCao;

  public fHDTuongTacBaiVietIA(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDTuongTacBaiVietIA.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDTuongTacBaiVietIA").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietIA', 'Tương tác bài viết IA');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDTuongTacBaiVietIA");
        string_1 = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        string_1 = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = "Cập nhật";
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.gclass22_0 = new GClass22(string_1, true);
    GClass35.smethod_5((Control) this);
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
    GClass35.smethod_1((Control) this.lblUid);
    GClass35.smethod_1((Control) this.label3);
  }

  private void fHDTuongTacBaiVietIA_Load(object sender, EventArgs e)
  {
    try
    {
      this.txtIdPage.Text = this.gclass22_0.method_1("txtIdPage");
      this.nudSoLuongBaiFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongBaiFrom", 1);
      this.nudSoLuongBaiTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongBaiTo", 3);
      this.nudThoiGianLuotFrom.Value = (Decimal) this.gclass22_0.method_3("nudThoiGianLuotFrom", 30);
      this.nudThoiGianLuotTo.Value = (Decimal) this.gclass22_0.method_3("nudThoiGianLuotTo", 30);
    }
    catch
    {
    }
    this.method_3();
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
    {
      GClass14.smethod_0((object) "Vui lòng nhập tên hành động!", 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("txtIdPage", (object) this.txtIdPage.Text.Trim());
      gclass22.method_6("nudSoLuongBaiFrom", (object) this.nudSoLuongBaiFrom.Value);
      gclass22.method_6("nudSoLuongBaiTo", (object) this.nudSoLuongBaiTo.Value);
      gclass22.method_6("nudThoiGianLuotFrom", (object) this.nudThoiGianLuotFrom.Value);
      gclass22.method_6("nudThoiGianLuotTo", (object) this.nudThoiGianLuotTo.Value);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1("Bạn có muốn thêm hành động mới?") != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDTuongTacBaiVietIA.bool_0 = true;
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
          fHDTuongTacBaiVietIA.bool_0 = true;
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

  private void method_1(object sender, EventArgs e)
  {
  }

  private void method_2()
  {
  }

  private void method_3()
  {
    this.method_5((object) null, (EventArgs) null);
    this.method_4((object) null, (EventArgs) null);
    this.ckbTuongTacQuangCao_CheckedChanged((object) null, (EventArgs) null);
  }

  private void method_4(object sender, EventArgs e)
  {
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      ;
  }

  private void method_5(object sender, EventArgs e)
  {
  }

  private void ckbTuongTacQuangCao_CheckedChanged(object sender, EventArgs e) => this.plTuongTacQuangCao.Enabled = this.ckbTuongTacQuangCao.Checked;

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
    this.plTuongTacQuangCao = new Panel();
    this.txtNoiDungTinNhan = new RichTextBox();
    this.label2 = new Label();
    this.ckbTuongTacQuangCao = new CheckBox();
    this.lblUid = new Label();
    this.label15 = new Label();
    this.label5 = new Label();
    this.txtIdPage = new TextBox();
    this.label7 = new Label();
    this.label4 = new Label();
    this.label6 = new Label();
    this.nudThoiGianLuotTo = new NumericUpDown();
    this.nudThoiGianLuotFrom = new NumericUpDown();
    this.label3 = new Label();
    this.nudSoLuongBaiFrom = new NumericUpDown();
    this.nudSoLuongBaiTo = new NumericUpDown();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plTuongTacQuangCao.SuspendLayout();
    this.nudThoiGianLuotTo.BeginInit();
    this.nudThoiGianLuotFrom.BeginInit();
    this.nudSoLuongBaiFrom.BeginInit();
    this.nudSoLuongBaiTo.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(352, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Tương tác bài viết IA";
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
    this.pnlHeader.Size = new Size(352, 31);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) Resources.btnMinimize_Image;
    this.btnMinimize.Location = new Point(319, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 78;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plTuongTacQuangCao);
    this.panel1.Controls.Add((Control) this.ckbTuongTacQuangCao);
    this.panel1.Controls.Add((Control) this.lblUid);
    this.panel1.Controls.Add((Control) this.label15);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.txtIdPage);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.nudThoiGianLuotTo);
    this.panel1.Controls.Add((Control) this.nudThoiGianLuotFrom);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.nudSoLuongBaiFrom);
    this.panel1.Controls.Add((Control) this.nudSoLuongBaiTo);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(355, 222);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plTuongTacQuangCao.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTacQuangCao.Controls.Add((Control) this.txtNoiDungTinNhan);
    this.plTuongTacQuangCao.Controls.Add((Control) this.label2);
    this.plTuongTacQuangCao.Location = new Point(24, 241);
    this.plTuongTacQuangCao.Name = "plTuongTacQuangCao";
    this.plTuongTacQuangCao.Size = new Size(305, 103);
    this.plTuongTacQuangCao.TabIndex = 142;
    this.plTuongTacQuangCao.Visible = false;
    this.txtNoiDungTinNhan.Location = new Point(7, 24);
    this.txtNoiDungTinNhan.Name = "txtNoiDungTinNhan";
    this.txtNoiDungTinNhan.Size = new Size(292, 73);
    this.txtNoiDungTinNhan.TabIndex = 1;
    this.txtNoiDungTinNhan.Text = "";
    this.txtNoiDungTinNhan.WordWrap = false;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(4, 4);
    this.label2.Name = "label2";
    this.label2.Size = new Size(165, 16);
    this.label2.TabIndex = 0;
    this.label2.Text = "Nhập nội dung tin nhắn (0):";
    this.ckbTuongTacQuangCao.AutoSize = true;
    this.ckbTuongTacQuangCao.Cursor = Cursors.Hand;
    this.ckbTuongTacQuangCao.Location = new Point(24, 219);
    this.ckbTuongTacQuangCao.Name = "ckbTuongTacQuangCao";
    this.ckbTuongTacQuangCao.Size = new Size(246, 20);
    this.ckbTuongTacQuangCao.TabIndex = 141;
    this.ckbTuongTacQuangCao.Text = "Tự động tương tác quảng cáo (sắp có)";
    this.ckbTuongTacQuangCao.UseVisualStyleBackColor = true;
    this.ckbTuongTacQuangCao.Visible = false;
    this.ckbTuongTacQuangCao.CheckedChanged += new EventHandler(this.ckbTuongTacQuangCao_CheckedChanged);
    this.lblUid.AutoSize = true;
    this.lblUid.Location = new Point(21, 81);
    this.lblUid.Name = "lblUid";
    this.lblUid.Size = new Size(56, 16);
    this.lblUid.TabIndex = 140;
    this.lblUid.Text = "ID Page:";
    this.label15.AutoSize = true;
    this.label15.Location = new Point(21, 138);
    this.label15.Name = "label15";
    this.label15.Size = new Size(113, 16);
    this.label15.TabIndex = 134;
    this.label15.Text = "Thời gian lướt/bài:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(21, 109);
    this.label5.Name = "label5";
    this.label5.Size = new Size(108, 16);
    this.label5.TabIndex = 135;
    this.label5.Text = "Số lượng bài viết:";
    this.txtIdPage.Location = new Point(141, 78);
    this.txtIdPage.Name = "txtIdPage";
    this.txtIdPage.Size = new Size(188, 23);
    this.txtIdPage.TabIndex = (int) sbyte.MaxValue;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(299, 138);
    this.label7.Name = "label7";
    this.label7.Size = new Size(30, 16);
    this.label7.TabIndex = 136;
    this.label7.Text = "giây";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(299, 109);
    this.label4.Name = "label4";
    this.label4.Size = new Size(24, 16);
    this.label4.TabIndex = 137;
    this.label4.Text = "bài";
    this.label6.Location = new Point(203, 138);
    this.label6.Name = "label6";
    this.label6.Size = new Size(29, 16);
    this.label6.TabIndex = 138;
    this.label6.Text = "đến";
    this.label6.TextAlign = ContentAlignment.MiddleCenter;
    this.nudThoiGianLuotTo.Location = new Point(238, 136);
    this.nudThoiGianLuotTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudThoiGianLuotTo.Name = "nudThoiGianLuotTo";
    this.nudThoiGianLuotTo.Size = new Size(56, 23);
    this.nudThoiGianLuotTo.TabIndex = 132;
    this.nudThoiGianLuotFrom.Location = new Point(141, 136);
    this.nudThoiGianLuotFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudThoiGianLuotFrom.Name = "nudThoiGianLuotFrom";
    this.nudThoiGianLuotFrom.Size = new Size(56, 23);
    this.nudThoiGianLuotFrom.TabIndex = 130;
    this.label3.Location = new Point(203, 109);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 139;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.nudSoLuongBaiFrom.Location = new Point(141, 107);
    this.nudSoLuongBaiFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongBaiFrom.Name = "nudSoLuongBaiFrom";
    this.nudSoLuongBaiFrom.Size = new Size(56, 23);
    this.nudSoLuongBaiFrom.TabIndex = 131;
    this.nudSoLuongBaiTo.Location = new Point(238, 107);
    this.nudSoLuongBaiTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongBaiTo.Name = "nudSoLuongBaiTo";
    this.nudSoLuongBaiTo.Size = new Size(56, 23);
    this.nudSoLuongBaiTo.TabIndex = 133;
    this.txtTenHanhDong.Location = new Point(141, 49);
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
    this.btnCancel.Location = new Point(180, 176);
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
    this.btnAdd.Location = new Point(78, 176);
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
    this.bunifuCards1.Size = new Size(352, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(355, 222);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDTuongTacBaiVietIA);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDTuongTacBaiVietIA_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plTuongTacQuangCao.ResumeLayout(false);
    this.plTuongTacQuangCao.PerformLayout();
    this.nudThoiGianLuotTo.EndInit();
    this.nudThoiGianLuotFrom.EndInit();
    this.nudSoLuongBaiFrom.EndInit();
    this.nudSoLuongBaiTo.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
