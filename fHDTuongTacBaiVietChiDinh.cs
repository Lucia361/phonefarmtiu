// Decompiled with JetBrains decompiler
// Type: fHDTuongTacBaiVietChiDinh
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fHDTuongTacBaiVietChiDinh : Form
{
  private GClass22 gclass22_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private List<CheckBox> list_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private Panel panel1;
  private TextBox txtTenHanhDong;
  private Label label1;
  private Button btnCancel;
  private Button btnAdd;
  private NumericUpDown nudTimeTo;
  private NumericUpDown nudTimeFrom;
  private Label label9;
  private Label label4;
  private Label label3;
  private Panel plComment;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private Label label8;
  private RichTextBox txtComment;
  private Label label11;
  private Label lblStatus;
  private CheckBox ckbComment;
  private Panel panel2;
  private Button button3;
  private Button button2;
  private CheckBox ckbTuDongXoaNoiDung;
  private CheckBox ckbInteract;
  private LinkLabel linkLabel1;
  private Panel plAnh;
  private TextBox txtPathAnh;
  private Label label14;
  private CheckBox ckbAnh;
  private Label label49;
  private NumericUpDown nudSoLuongUidFrom;
  private Label label68;
  private NumericUpDown nudSoLuongUidTo;
  private Label label66;
  private RichTextBox txtIdPost;
  private Label lblDanhSachBaiViet;
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label7;
  private Label label6;
  private Label label10;
  private Panel plTuongTacVideoTrenPost;
  private CheckBox ckbTuongTacVideoTrenPost;
  private Label label2;
  private Label label5;
  private Label label12;
  private NumericUpDown nudTuongTacVideoTrenPostFrom;
  private NumericUpDown nudTuongTacVideoTrenPostTo;
  private MetroButton btnUp;
  private Panel plInteract;
  private CheckBox ckbGian;
  private CheckBox ckbBuon;
  private CheckBox ckbWow;
  private CheckBox ckbHaha;
  private CheckBox ckbThuong;
  private CheckBox ckbTym;
  private CheckBox ckbLike;
  private Panel panel7;
  private RadioButton radioButton3;
  private RadioButton radioButton4;
  private IContainer components;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private Button button4;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Label label26;

  public fHDTuongTacBaiVietChiDinh(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDTuongTacBaiVietChiDinh.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    if (Class205.smethod_13(string_1: "HDTuongTacBaiVietChiDinh").Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietChiDinh', 'Tương tác bài viết chỉ định');");
    string string_1 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDTuongTacBaiVietChiDinh");
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
  }

  private void fHDTuongTacBaiVietChiDinh_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom", 3);
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo", 5);
      this.nudSoLuongUidFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongUidFrom", 1);
      this.nudSoLuongUidTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongUidTo", 3);
      this.txtIdPost.Text = this.gclass22_0.method_1("txtIdPost");
      this.nudTimeFrom.Value = (Decimal) this.gclass22_0.method_3("nudTimeFrom", 3);
      this.nudTimeTo.Value = (Decimal) this.gclass22_0.method_3("nudTimeTo", 5);
      this.ckbInteract.Checked = this.gclass22_0.method_4("ckbInteract");
      string str = this.gclass22_0.method_1("typeReaction");
      this.list_0 = new List<CheckBox>()
      {
        this.ckbLike,
        this.ckbTym,
        this.ckbThuong,
        this.ckbHaha,
        this.ckbWow,
        this.ckbBuon,
        this.ckbGian
      };
      for (int index = 0; index < this.list_0.Count; ++index)
        this.list_0[index].Checked = str.Contains(index.ToString());
      this.ckbComment.Checked = this.gclass22_0.method_4("ckbComment");
      this.txtComment.Text = this.gclass22_0.method_1("txtComment");
      this.ckbTuDongXoaNoiDung.Checked = this.gclass22_0.method_4("ckbTuDongXoaNoiDung");
      if (this.gclass22_0.method_3("typeNganCach") == 1)
        this.rbNganCachKyTu.Checked = true;
      else
        this.rbNganCachMoiDong.Checked = true;
      this.ckbAnh.Checked = this.gclass22_0.method_4("ckbAnh");
      this.txtPathAnh.Text = this.gclass22_0.method_1("txtPathAnh");
      this.ckbTuongTacVideoTrenPost.Checked = this.gclass22_0.method_4("ckbTuongTacVideoTrenPost");
      this.nudTuongTacVideoTrenPostFrom.Value = (Decimal) this.gclass22_0.method_3("nudTuongTacVideoTrenPostFrom", 3);
      this.nudTuongTacVideoTrenPostTo.Value = (Decimal) this.gclass22_0.method_3("nudTuongTacVideoTrenPostTo", 5);
    }
    catch
    {
    }
    this.method_1();
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    else if (GClass19.smethod_39(((IEnumerable<string>) this.txtIdPost.Lines).ToList<string>()).Count == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách Id bài viết cần buff like, comment!"), 3);
    else if (this.ckbComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung bình luận!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("nudSoLuongUidFrom", (object) this.nudSoLuongUidFrom.Value);
      gclass22.method_6("nudSoLuongUidTo", (object) this.nudSoLuongUidTo.Value);
      gclass22.method_6("txtIdPost", (object) this.txtIdPost.Text.Trim());
      gclass22.method_6("nudTimeFrom", (object) this.nudTimeFrom.Value);
      gclass22.method_6("nudTimeTo", (object) this.nudTimeTo.Value);
      gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
      string object_0_1 = "";
      for (int index = 0; index < this.list_0.Count; ++index)
        object_0_1 += this.list_0[index].Checked ? index.ToString() ?? "" : "";
      gclass22.method_6("typeReaction", (object) object_0_1);
      gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
      gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
      gclass22.method_6("ckbTuDongXoaNoiDung", (object) this.ckbTuDongXoaNoiDung.Checked);
      int object_0_2 = 0;
      if (this.rbNganCachKyTu.Checked)
        object_0_2 = 1;
      gclass22.method_6("typeNganCach", (object) object_0_2);
      gclass22.method_6("ckbAnh", (object) this.ckbAnh.Checked);
      gclass22.method_6("txtPathAnh", (object) this.txtPathAnh.Text.Trim());
      gclass22.method_6("ckbTuongTacVideoTrenPost", (object) this.ckbTuongTacVideoTrenPost.Checked);
      gclass22.method_6("nudTuongTacVideoTrenPostFrom", (object) this.nudTuongTacVideoTrenPostFrom.Value);
      gclass22.method_6("nudTuongTacVideoTrenPostTo", (object) this.nudTuongTacVideoTrenPostTo.Value);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDTuongTacBaiVietChiDinh.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Thêm thất bại, vui lòng thử lại sau!"), 2);
      }
      else
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn cập nhật hành động?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_21(this.string_2, string_1, str))
        {
          fHDTuongTacBaiVietChiDinh.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Cập nhật thất bại, vui lòng thử lại sau!"), 2);
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

  private void method_0(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Nội dung bình luận ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void method_1()
  {
    this.ckbInteract_CheckedChanged((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
    this.ckbAnh_CheckedChanged((object) null, (EventArgs) null);
    this.ckbTuongTacVideoTrenPost_CheckedChanged((object) null, (EventArgs) null);
  }

  private void ckbComment_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbComment.Checked;

  private void method_2(object sender, EventArgs e)
  {
  }

  private void panel1_Click(object sender, EventArgs e)
  {
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
  }

  private void method_3(object sender, EventArgs e)
  {
  }

  private void method_4(object sender, EventArgs e)
  {
  }

  private void method_5(object sender, EventArgs e)
  {
  }

  private void method_6(object sender, EventArgs e)
  {
  }

  private void method_7(object sender, EventArgs e) => this.plComment.Height = 195;

  private void method_8(object sender, EventArgs e) => this.plComment.Height = 237;

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

  private void txtComment_TextChanged(object sender, EventArgs e) => this.method_10();

  private void method_9(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Có thể dùng [u] để thay thế tên của người đăng bài!"));

  private void method_10()
  {
    try
    {
      List<string> stringList1 = new List<string>();
      List<string> list;
      if (this.rbNganCachMoiDong.Checked)
        list = ((IEnumerable<string>) this.txtComment.Lines).ToList<string>();
      else
        list = ((IEnumerable<string>) this.txtComment.Text.Split(new string[1]
        {
          "\n|\n"
        }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();
      List<string> stringList2 = GClass19.smethod_39(list);
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Nội dung bình luận ({0}):"), (object) stringList2.Count.ToString());
    }
    catch
    {
    }
  }

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => this.method_10();

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => this.method_10();

  private void ckbInteract_CheckedChanged(object sender, EventArgs e) => this.plInteract.Enabled = this.ckbInteract.Checked;

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => GClass19.smethod_35((Form) new fHuongDanRandom());

  private void ckbAnh_CheckedChanged(object sender, EventArgs e) => this.plAnh.Enabled = this.ckbAnh.Checked;

  private void txtIdPost_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtIdPost, (Control) this.lblDanhSachBaiViet);

  private void ckbTuongTacVideoTrenPost_CheckedChanged(object sender, EventArgs e) => this.plTuongTacVideoTrenPost.Enabled = this.ckbTuongTacVideoTrenPost.Checked;

  private void btnUp_Click(object sender, EventArgs e) => this.txtIdPost.Height = 251;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDTuongTacBaiVietChiDinh));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.panel1 = new Panel();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button4 = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.plInteract = new Panel();
    this.ckbGian = new CheckBox();
    this.ckbBuon = new CheckBox();
    this.ckbWow = new CheckBox();
    this.ckbHaha = new CheckBox();
    this.ckbThuong = new CheckBox();
    this.ckbTym = new CheckBox();
    this.ckbLike = new CheckBox();
    this.panel7 = new Panel();
    this.radioButton3 = new RadioButton();
    this.radioButton4 = new RadioButton();
    this.label26 = new Label();
    this.btnUp = new MetroButton();
    this.label49 = new Label();
    this.nudSoLuongUidFrom = new NumericUpDown();
    this.label68 = new Label();
    this.nudSoLuongUidTo = new NumericUpDown();
    this.label66 = new Label();
    this.txtIdPost = new RichTextBox();
    this.lblDanhSachBaiViet = new Label();
    this.nudDelayTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.label7 = new Label();
    this.label6 = new Label();
    this.label10 = new Label();
    this.plAnh = new Panel();
    this.txtPathAnh = new TextBox();
    this.label14 = new Label();
    this.ckbAnh = new CheckBox();
    this.ckbInteract = new CheckBox();
    this.plTuongTacVideoTrenPost = new Panel();
    this.label2 = new Label();
    this.label5 = new Label();
    this.label12 = new Label();
    this.nudTuongTacVideoTrenPostFrom = new NumericUpDown();
    this.nudTuongTacVideoTrenPostTo = new NumericUpDown();
    this.plComment = new Panel();
    this.linkLabel1 = new LinkLabel();
    this.ckbTuDongXoaNoiDung = new CheckBox();
    this.panel2 = new Panel();
    this.button3 = new Button();
    this.rbNganCachMoiDong = new RadioButton();
    this.button2 = new Button();
    this.rbNganCachKyTu = new RadioButton();
    this.label8 = new Label();
    this.txtComment = new RichTextBox();
    this.label11 = new Label();
    this.lblStatus = new Label();
    this.ckbTuongTacVideoTrenPost = new CheckBox();
    this.ckbComment = new CheckBox();
    this.nudTimeTo = new NumericUpDown();
    this.nudTimeFrom = new NumericUpDown();
    this.txtTenHanhDong = new TextBox();
    this.label9 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.panel1.SuspendLayout();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.plInteract.SuspendLayout();
    this.panel7.SuspendLayout();
    this.nudSoLuongUidFrom.BeginInit();
    this.nudSoLuongUidTo.BeginInit();
    this.nudDelayTo.BeginInit();
    this.nudDelayFrom.BeginInit();
    this.plAnh.SuspendLayout();
    this.plTuongTacVideoTrenPost.SuspendLayout();
    this.nudTuongTacVideoTrenPostFrom.BeginInit();
    this.nudTuongTacVideoTrenPostTo.BeginInit();
    this.plComment.SuspendLayout();
    this.panel2.SuspendLayout();
    this.nudTimeTo.BeginInit();
    this.nudTimeFrom.BeginInit();
    this.SuspendLayout();
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) null;
    this.bunifuDragControl_0.Vertical = true;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) null;
    this.bunifuDragControl_1.Vertical = true;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Controls.Add((Control) this.plInteract);
    this.panel1.Controls.Add((Control) this.btnUp);
    this.panel1.Controls.Add((Control) this.label49);
    this.panel1.Controls.Add((Control) this.nudSoLuongUidFrom);
    this.panel1.Controls.Add((Control) this.label68);
    this.panel1.Controls.Add((Control) this.nudSoLuongUidTo);
    this.panel1.Controls.Add((Control) this.label66);
    this.panel1.Controls.Add((Control) this.txtIdPost);
    this.panel1.Controls.Add((Control) this.lblDanhSachBaiViet);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label10);
    this.panel1.Controls.Add((Control) this.plAnh);
    this.panel1.Controls.Add((Control) this.ckbAnh);
    this.panel1.Controls.Add((Control) this.ckbInteract);
    this.panel1.Controls.Add((Control) this.plTuongTacVideoTrenPost);
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.ckbTuongTacVideoTrenPost);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.nudTimeTo);
    this.panel1.Controls.Add((Control) this.nudTimeFrom);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label9);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(723, 535);
    this.panel1.TabIndex = 0;
    this.panel1.Click += new EventHandler(this.panel1_Click);
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.DarkViolet;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(3, 3);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(723, 37);
    this.bunifuCards1.TabIndex = 195;
    this.pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button4);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(723, 31);
    this.pnlHeader.TabIndex = 9;
    this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button4.Cursor = Cursors.Hand;
    this.button4.FlatAppearance.BorderSize = 0;
    this.button4.FlatStyle = FlatStyle.Flat;
    this.button4.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button4.ForeColor = Color.White;
    this.button4.Image = (Image) componentResourceManager.GetObject("button4.Image");
    this.button4.Location = new Point(685, 1);
    this.button4.Name = "button4";
    this.button4.Size = new Size(34, 30);
    this.button4.TabIndex = 77;
    this.button4.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(723, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Tương tác bài viết chỉ định";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.plInteract.BorderStyle = BorderStyle.FixedSingle;
    this.plInteract.Controls.Add((Control) this.ckbGian);
    this.plInteract.Controls.Add((Control) this.ckbBuon);
    this.plInteract.Controls.Add((Control) this.ckbWow);
    this.plInteract.Controls.Add((Control) this.ckbHaha);
    this.plInteract.Controls.Add((Control) this.ckbThuong);
    this.plInteract.Controls.Add((Control) this.ckbTym);
    this.plInteract.Controls.Add((Control) this.ckbLike);
    this.plInteract.Controls.Add((Control) this.panel7);
    this.plInteract.Controls.Add((Control) this.label26);
    this.plInteract.Location = new Point(380, 130);
    this.plInteract.Name = "plInteract";
    this.plInteract.Size = new Size(312, 33);
    this.plInteract.TabIndex = 192;
    this.ckbGian.Cursor = Cursors.Hand;
    this.ckbGian.Image = (Image) Resources.angry;
    this.ckbGian.Location = new Point(266, 1);
    this.ckbGian.Name = "ckbGian";
    this.ckbGian.Size = new Size(40, 30);
    this.ckbGian.TabIndex = 179;
    this.ckbGian.UseVisualStyleBackColor = true;
    this.ckbBuon.Cursor = Cursors.Hand;
    this.ckbBuon.Image = (Image) Resources.sad;
    this.ckbBuon.Location = new Point(222, 1);
    this.ckbBuon.Name = "ckbBuon";
    this.ckbBuon.Size = new Size(40, 30);
    this.ckbBuon.TabIndex = 178;
    this.ckbBuon.UseVisualStyleBackColor = true;
    this.ckbWow.Cursor = Cursors.Hand;
    this.ckbWow.Image = (Image) Resources.wow;
    this.ckbWow.Location = new Point(178, 1);
    this.ckbWow.Name = "ckbWow";
    this.ckbWow.Size = new Size(40, 30);
    this.ckbWow.TabIndex = 177;
    this.ckbWow.UseVisualStyleBackColor = true;
    this.ckbHaha.Cursor = Cursors.Hand;
    this.ckbHaha.Image = (Image) Resources.haha;
    this.ckbHaha.Location = new Point(134, 1);
    this.ckbHaha.Name = "ckbHaha";
    this.ckbHaha.Size = new Size(40, 30);
    this.ckbHaha.TabIndex = 176;
    this.ckbHaha.UseVisualStyleBackColor = true;
    this.ckbThuong.Cursor = Cursors.Hand;
    this.ckbThuong.Image = (Image) Resources.care;
    this.ckbThuong.Location = new Point(90, 1);
    this.ckbThuong.Name = "ckbThuong";
    this.ckbThuong.Size = new Size(40, 30);
    this.ckbThuong.TabIndex = 175;
    this.ckbThuong.UseVisualStyleBackColor = true;
    this.ckbTym.Cursor = Cursors.Hand;
    this.ckbTym.Image = (Image) Resources.love;
    this.ckbTym.Location = new Point(46, 1);
    this.ckbTym.Name = "ckbTym";
    this.ckbTym.Size = new Size(40, 30);
    this.ckbTym.TabIndex = 174;
    this.ckbTym.UseVisualStyleBackColor = true;
    this.ckbLike.Checked = true;
    this.ckbLike.CheckState = CheckState.Checked;
    this.ckbLike.Cursor = Cursors.Hand;
    this.ckbLike.Image = (Image) Resources.like1;
    this.ckbLike.Location = new Point(2, 1);
    this.ckbLike.Name = "ckbLike";
    this.ckbLike.Size = new Size(40, 30);
    this.ckbLike.TabIndex = 173;
    this.ckbLike.UseVisualStyleBackColor = true;
    this.panel7.Controls.Add((Control) this.radioButton3);
    this.panel7.Controls.Add((Control) this.radioButton4);
    this.panel7.Location = new Point(67, 300);
    this.panel7.Name = "panel7";
    this.panel7.Size = new Size(200, 43);
    this.panel7.TabIndex = 43;
    this.radioButton3.AutoSize = true;
    this.radioButton3.Checked = true;
    this.radioButton3.Cursor = Cursors.Hand;
    this.radioButton3.Location = new Point(3, 2);
    this.radioButton3.Name = "radioButton3";
    this.radioButton3.Size = new Size(201, 20);
    this.radioButton3.TabIndex = 3;
    this.radioButton3.TabStop = true;
    this.radioButton3.Text = "Comment theo thứ tự nội dung";
    this.radioButton3.UseVisualStyleBackColor = true;
    this.radioButton4.AutoSize = true;
    this.radioButton4.Cursor = Cursors.Hand;
    this.radioButton4.Location = new Point(3, 23);
    this.radioButton4.Name = "radioButton4";
    this.radioButton4.Size = new Size(200, 20);
    this.radioButton4.TabIndex = 3;
    this.radioButton4.Text = "Comment ngẫu nhiên nội dung";
    this.radioButton4.UseVisualStyleBackColor = true;
    this.label26.AutoSize = true;
    this.label26.Location = new Point(4, 302);
    this.label26.Name = "label26";
    this.label26.Size = new Size(64, 16);
    this.label26.TabIndex = 2;
    this.label26.Text = "Tùy chọn:";
    this.btnUp.Cursor = Cursors.Hand;
    this.btnUp.Location = new Point(304, 131);
    this.btnUp.Name = "btnUp";
    this.btnUp.Size = new Size(25, 25);
    this.btnUp.TabIndex = 191;
    this.btnUp.UseSelectable = true;
    this.btnUp.Click += new EventHandler(this.btnUp_Click);
    this.label49.AutoSize = true;
    this.label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label49.Location = new Point(27, 80);
    this.label49.Name = "label49";
    this.label49.Size = new Size(100, 16);
    this.label49.TabIndex = 188;
    this.label49.Text = "Số bài viết/Nick:";
    this.nudSoLuongUidFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongUidFrom.Location = new Point(136, 78);
    this.nudSoLuongUidFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
    this.nudSoLuongUidFrom.Size = new Size(56, 23);
    this.nudSoLuongUidFrom.TabIndex = 186;
    this.nudSoLuongUidFrom.Value = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.label68.AutoSize = true;
    this.label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label68.Location = new Point(291, 80);
    this.label68.Name = "label68";
    this.label68.Size = new Size(24, 16);
    this.label68.TabIndex = 189;
    this.label68.Text = "bài";
    this.nudSoLuongUidTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongUidTo.Location = new Point(233, 78);
    this.nudSoLuongUidTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongUidTo.Name = "nudSoLuongUidTo";
    this.nudSoLuongUidTo.Size = new Size(56, 23);
    this.nudSoLuongUidTo.TabIndex = 187;
    this.nudSoLuongUidTo.Value = new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label66.Location = new Point(198, 80);
    this.label66.Name = "label66";
    this.label66.Size = new Size(29, 16);
    this.label66.TabIndex = 190;
    this.label66.Text = "đến";
    this.label66.TextAlign = ContentAlignment.MiddleCenter;
    this.txtIdPost.Location = new Point(30, 156);
    this.txtIdPost.Name = "txtIdPost";
    this.txtIdPost.Size = new Size(300, 311);
    this.txtIdPost.TabIndex = 179;
    this.txtIdPost.Text = "";
    this.txtIdPost.WordWrap = false;
    this.txtIdPost.TextChanged += new EventHandler(this.txtIdPost_TextChanged);
    this.lblDanhSachBaiViet.AutoSize = true;
    this.lblDanhSachBaiViet.Location = new Point(27, 137);
    this.lblDanhSachBaiViet.Name = "lblDanhSachBaiViet";
    this.lblDanhSachBaiViet.Size = new Size(160, 16);
    this.lblDanhSachBaiViet.TabIndex = 185;
    this.lblDanhSachBaiViet.Text = "Danh sách link bài viết (0):";
    this.nudDelayTo.Location = new Point(233, 107);
    this.nudDelayTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayTo.Name = "nudDelayTo";
    this.nudDelayTo.Size = new Size(56, 23);
    this.nudDelayTo.TabIndex = 181;
    this.nudDelayFrom.Location = new Point(136, 107);
    this.nudDelayFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayFrom.Name = "nudDelayFrom";
    this.nudDelayFrom.Size = new Size(56, 23);
    this.nudDelayFrom.TabIndex = 180;
    this.label7.Location = new Point(198, 109);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 184;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(291, 109);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 183;
    this.label6.Text = "giây";
    this.label10.AutoSize = true;
    this.label10.Location = new Point(27, 109);
    this.label10.Name = "label10";
    this.label10.Size = new Size(89, 16);
    this.label10.TabIndex = 182;
    this.label10.Text = "Thời gian chờ:";
    this.plAnh.BorderStyle = BorderStyle.FixedSingle;
    this.plAnh.Controls.Add((Control) this.txtPathAnh);
    this.plAnh.Controls.Add((Control) this.label14);
    this.plAnh.Location = new Point(379, 436);
    this.plAnh.Name = "plAnh";
    this.plAnh.Size = new Size(313, 31);
    this.plAnh.TabIndex = 178;
    this.txtPathAnh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtPathAnh.Location = new Point(90, 3);
    this.txtPathAnh.Name = "txtPathAnh";
    this.txtPathAnh.Size = new Size(218, 23);
    this.txtPathAnh.TabIndex = 1;
    this.label14.AutoSize = true;
    this.label14.Location = new Point(3, 6);
    this.label14.Name = "label14";
    this.label14.Size = new Size(88, 16);
    this.label14.TabIndex = 0;
    this.label14.Text = "Thư mục ảnh:";
    this.ckbAnh.AutoSize = true;
    this.ckbAnh.Cursor = Cursors.Hand;
    this.ckbAnh.Location = new Point(362, 412);
    this.ckbAnh.Name = "ckbAnh";
    this.ckbAnh.Size = new Size(103, 20);
    this.ckbAnh.TabIndex = 177;
    this.ckbAnh.Text = "Bình luận ảnh";
    this.ckbAnh.UseVisualStyleBackColor = true;
    this.ckbAnh.CheckedChanged += new EventHandler(this.ckbAnh_CheckedChanged);
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(362, 104);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(112, 20);
    this.ckbInteract.TabIndex = 167;
    this.ckbInteract.Text = "Bày tỏ cảm xúc";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.plTuongTacVideoTrenPost.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTacVideoTrenPost.Controls.Add((Control) this.label2);
    this.plTuongTacVideoTrenPost.Controls.Add((Control) this.label5);
    this.plTuongTacVideoTrenPost.Controls.Add((Control) this.label12);
    this.plTuongTacVideoTrenPost.Controls.Add((Control) this.nudTuongTacVideoTrenPostFrom);
    this.plTuongTacVideoTrenPost.Controls.Add((Control) this.nudTuongTacVideoTrenPostTo);
    this.plTuongTacVideoTrenPost.Location = new Point(49, 436);
    this.plTuongTacVideoTrenPost.Name = "plTuongTacVideoTrenPost";
    this.plTuongTacVideoTrenPost.Size = new Size(281, 31);
    this.plTuongTacVideoTrenPost.TabIndex = 164;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(3, 5);
    this.label2.Name = "label2";
    this.label2.Size = new Size(93, 16);
    this.label2.TabIndex = 34;
    this.label2.Text = "Thời gian xem:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(237, 5);
    this.label5.Name = "label5";
    this.label5.Size = new Size(30, 16);
    this.label5.TabIndex = 36;
    this.label5.Text = "giây";
    this.label12.Location = new Point(154, 5);
    this.label12.Name = "label12";
    this.label12.Size = new Size(29, 16);
    this.label12.TabIndex = 38;
    this.label12.Text = "đến";
    this.label12.TextAlign = ContentAlignment.MiddleCenter;
    this.nudTuongTacVideoTrenPostFrom.Location = new Point(102, 3);
    this.nudTuongTacVideoTrenPostFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTuongTacVideoTrenPostFrom.Name = "nudTuongTacVideoTrenPostFrom";
    this.nudTuongTacVideoTrenPostFrom.Size = new Size(51, 23);
    this.nudTuongTacVideoTrenPostFrom.TabIndex = 3;
    this.nudTuongTacVideoTrenPostTo.Location = new Point(184, 3);
    this.nudTuongTacVideoTrenPostTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTuongTacVideoTrenPostTo.Name = "nudTuongTacVideoTrenPostTo";
    this.nudTuongTacVideoTrenPostTo.Size = new Size(51, 23);
    this.nudTuongTacVideoTrenPostTo.TabIndex = 4;
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.linkLabel1);
    this.plComment.Controls.Add((Control) this.ckbTuDongXoaNoiDung);
    this.plComment.Controls.Add((Control) this.panel2);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.label11);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(380, 193);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(312, 216);
    this.plComment.TabIndex = 164;
    this.linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.Cursor = Cursors.Hand;
    this.linkLabel1.Location = new Point(221, 128);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(81, 16);
    this.linkLabel1.TabIndex = 191;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "Random icon";
    this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
    this.ckbTuDongXoaNoiDung.AutoSize = true;
    this.ckbTuDongXoaNoiDung.Cursor = Cursors.Hand;
    this.ckbTuDongXoaNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbTuDongXoaNoiDung.Location = new Point(7, 192);
    this.ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
    this.ckbTuDongXoaNoiDung.Size = new Size(219, 20);
    this.ckbTuDongXoaNoiDung.TabIndex = 131;
    this.ckbTuDongXoaNoiDung.Text = "Tự động xóa nội dung đã sử dụng";
    this.ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
    this.panel2.Controls.Add((Control) this.button3);
    this.panel2.Controls.Add((Control) this.rbNganCachMoiDong);
    this.panel2.Controls.Add((Control) this.button2);
    this.panel2.Controls.Add((Control) this.rbNganCachKyTu);
    this.panel2.Location = new Point(70, 144);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(200, 46);
    this.panel2.TabIndex = 42;
    this.button3.Cursor = Cursors.Help;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.Location = new Point(165, 22);
    this.button3.Name = "button3";
    this.button3.Size = new Size(21, 21);
    this.button3.TabIndex = 172;
    this.button3.Text = "?";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(3, 3);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(155, 20);
    this.rbNganCachMoiDong.TabIndex = 3;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.CheckedChanged += new EventHandler(this.rbNganCachMoiDong_CheckedChanged);
    this.button2.Cursor = Cursors.Help;
    this.button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button2.Location = new Point(165, 1);
    this.button2.Name = "button2";
    this.button2.Size = new Size(21, 21);
    this.button2.TabIndex = 173;
    this.button2.Text = "?";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(3, 24);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(159, 20);
    this.rbNganCachKyTu.TabIndex = 3;
    this.rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachKyTu.CheckedChanged += new EventHandler(this.rbNganCachKyTu_CheckedChanged);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(4, 147);
    this.label8.Name = "label8";
    this.label8.Size = new Size(64, 16);
    this.label8.TabIndex = 2;
    this.label8.Text = "Tùy chọn:";
    this.txtComment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtComment.Location = new Point(7, 25);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(294, 102);
    this.txtComment.TabIndex = 1;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.label11.AutoSize = true;
    this.label11.Location = new Point(5, 128);
    this.label11.Name = "label11";
    this.label11.Size = new Size(133, 16);
    this.label11.TabIndex = 0;
    this.label11.Text = "Spin nội dung {a|b|c}";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(139, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung bình luận (0):";
    this.ckbTuongTacVideoTrenPost.AutoSize = true;
    this.ckbTuongTacVideoTrenPost.Cursor = Cursors.Hand;
    this.ckbTuongTacVideoTrenPost.Location = new Point(31, 413);
    this.ckbTuongTacVideoTrenPost.Name = "ckbTuongTacVideoTrenPost";
    this.ckbTuongTacVideoTrenPost.Size = new Size(190, 20);
    this.ckbTuongTacVideoTrenPost.TabIndex = 163;
    this.ckbTuongTacVideoTrenPost.Text = "Tương tác video trên bài viết";
    this.ckbTuongTacVideoTrenPost.UseVisualStyleBackColor = true;
    this.ckbTuongTacVideoTrenPost.CheckedChanged += new EventHandler(this.ckbTuongTacVideoTrenPost_CheckedChanged);
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(362, 170);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size((int) sbyte.MaxValue, 20);
    this.ckbComment.TabIndex = 163;
    this.ckbComment.Text = "Bình luận văn bản";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.nudTimeTo.Location = new Point(526, 78);
    this.nudTimeTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeTo.Name = "nudTimeTo";
    this.nudTimeTo.Size = new Size(51, 23);
    this.nudTimeTo.TabIndex = 4;
    this.nudTimeFrom.Location = new Point(448, 78);
    this.nudTimeFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTimeFrom.Name = "nudTimeFrom";
    this.nudTimeFrom.Size = new Size(51, 23);
    this.nudTimeFrom.TabIndex = 3;
    this.txtTenHanhDong.Location = new Point(136, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(194, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label9.Location = new Point(499, 80);
    this.label9.Name = "label9";
    this.label9.Size = new Size(29, 16);
    this.label9.TabIndex = 38;
    this.label9.Text = "đến";
    this.label9.TextAlign = ContentAlignment.MiddleCenter;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(579, 80);
    this.label4.Name = "label4";
    this.label4.Size = new Size(30, 16);
    this.label4.TabIndex = 36;
    this.label4.Text = "giây";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(359, 80);
    this.label3.Name = "label3";
    this.label3.Size = new Size(83, 16);
    this.label3.TabIndex = 34;
    this.label3.Text = "Xem bài viết:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(27, 52);
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
    this.btnCancel.Location = new Point(369, 490);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 10;
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
    this.btnAdd.Location = new Point(262, 490);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 9;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(723, 535);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDTuongTacBaiVietChiDinh);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDTuongTacBaiVietChiDinh_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.plInteract.ResumeLayout(false);
    this.plInteract.PerformLayout();
    this.panel7.ResumeLayout(false);
    this.panel7.PerformLayout();
    this.nudSoLuongUidFrom.EndInit();
    this.nudSoLuongUidTo.EndInit();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.plAnh.ResumeLayout(false);
    this.plAnh.PerformLayout();
    this.plTuongTacVideoTrenPost.ResumeLayout(false);
    this.plTuongTacVideoTrenPost.PerformLayout();
    this.nudTuongTacVideoTrenPostFrom.EndInit();
    this.nudTuongTacVideoTrenPostTo.EndInit();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.nudTimeTo.EndInit();
    this.nudTimeFrom.EndInit();
    this.ResumeLayout(false);
  }

  private void button4_Click(object sender, EventArgs e) => this.Close();
}
