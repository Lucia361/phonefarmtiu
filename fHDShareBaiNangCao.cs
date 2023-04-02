// Decompiled with JetBrains decompiler
// Type: fHDShareBaiNangCao
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

public class fHDShareBaiNangCao : Form
{
  private GClass22 gclass22_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private List<CheckBox> list_0;
  private List<string> list_1 = new List<string>();
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
  private Button button1;
  private BunifuCustomLabel bunifuCustomLabel1;
  private GroupBox groupBox2;
  private Panel plShareBaiLenNhom;
  private NumericUpDown nudCountGroupTo;
  private NumericUpDown nudCountGroupFrom;
  private Label label24;
  private Label label25;
  private Label label26;
  private CheckBox ckbShareBaiLenNhom;
  private CheckBox ckbShareBaiLenTuong;
  private Panel plShareNhomNangCao;
  private CheckBox ckbChiShareNhomKKD;
  private CheckBox ckbUuTienShareNhomNhieuThanhVien;
  private CheckBox ckbKhongShareTrungNhom;
  private CheckBox ckbShareNhomNangCao;
  private GroupBox groupBox1;
  private RichTextBox txtLinkChiaSe;
  private Panel plTuongTacTruocKhiShare;
  private Label label22;
  private Panel plComment;
  private LinkLabel linkLabel2;
  private Panel plBinhLuanNhieuLan;
  private NumericUpDown nudBinhLuanNhieuLanDelayTo;
  private Label lblmc1;
  private NumericUpDown nudBinhLuanNhieuLanDelayFrom;
  private Label label9;
  private Label label13;
  private CheckBox ckbBinhLuanNhieuLan;
  private Label label14;
  private TextBox txtComment;
  private Label label15;
  private Label label21;
  private Label label18;
  private CheckBox ckbComment;
  private NumericUpDown nudSoLuongFrom;
  private CheckBox ckbInteract;
  private NumericUpDown nudSoLuongTo;
  private Panel plVanBan;
  private LinkLabel linkLabel1;
  private RichTextBox txtNoiDung;
  private Label label8;
  private Label lblStatus;
  private RadioButton rbShareOther;
  private RadioButton rbShareLivestream;
  private CheckBox ckbTuongTacTruocKhiShare;
  private Label label7;
  private Label label3;
  private CheckBox ckbVanBan;
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudDelayFrom;
  private Label label20;
  private Label label19;
  private Label label2;
  private CheckBox ckbBackupDanhSachNhom;
  private RadioButton rbShareReel;
  private Button btnNhapDanhSachNhom;
  private CheckBox ckbChiShareNhomThuocDanhSach;
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
  private Label label4;

  public fHDShareBaiNangCao(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDShareBaiNangCao.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1_1 = this.Name.Substring(1);
    string str = "Share bài nâng cao";
    if (Class205.smethod_13(string_1: string_1_1).Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + string_1_1 + "', '" + str + "');");
    string string_1_2 = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: string_1_1);
        string_1_2 = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        string_1_2 = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.gclass22_0 = new GClass22(string_1_2, true);
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
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.label15);
    GClass35.smethod_1((Control) this.label20);
    GClass35.smethod_1((Control) this.label19);
    GClass35.smethod_1((Control) this.groupBox2);
    GClass35.smethod_1((Control) this.ckbShareBaiLenTuong);
    GClass35.smethod_1((Control) this.ckbShareBaiLenNhom);
    GClass35.smethod_1((Control) this.label26);
    GClass35.smethod_1((Control) this.label24);
    GClass35.smethod_1((Control) this.label25);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.ckbVanBan);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
    GClass35.smethod_1((Control) this.label9);
  }

  private void fHDShareBaiNangCao_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudDelayFrom", 3);
      this.nudDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudDelayTo", 5);
      this.ckbShareBaiLenTuong.Checked = this.gclass22_0.method_4("ckbShareBaiLenTuong");
      this.ckbShareBaiLenNhom.Checked = this.gclass22_0.method_4("ckbShareBaiLenNhom");
      this.nudCountGroupFrom.Value = (Decimal) this.gclass22_0.method_3("nudCountGroupFrom", 1);
      this.nudCountGroupTo.Value = (Decimal) this.gclass22_0.method_3("nudCountGroupTo", 1);
      this.ckbShareNhomNangCao.Checked = this.gclass22_0.method_4("ckbShareNhomNangCao");
      this.ckbChiShareNhomKKD.Checked = this.gclass22_0.method_4("ckbChiShareNhomKKD");
      this.ckbUuTienShareNhomNhieuThanhVien.Checked = this.gclass22_0.method_4("ckbUuTienShareNhomNhieuThanhVien");
      this.ckbBackupDanhSachNhom.Checked = this.gclass22_0.method_4("ckbBackupDanhSachNhom");
      this.ckbKhongShareTrungNhom.Checked = this.gclass22_0.method_4("ckbKhongShareTrungNhom");
      this.ckbChiShareNhomThuocDanhSach.Checked = this.gclass22_0.method_4("ckbChiShareNhomThuocDanhSach");
      this.list_1 = this.gclass22_0.method_2("lstNhomTuNhap");
      this.txtLinkChiaSe.Text = this.gclass22_0.method_1("txtLinkChiaSe");
      if (this.gclass22_0.method_3("typeLinkShare") == 1)
        this.rbShareOther.Checked = true;
      else if (this.gclass22_0.method_3("typeLinkShare") == 2)
        this.rbShareReel.Checked = true;
      else
        this.rbShareLivestream.Checked = true;
      this.ckbVanBan.Checked = this.gclass22_0.method_4("ckbVanBan");
      this.txtNoiDung.Text = this.gclass22_0.method_1("txtNoiDung");
      this.ckbTuongTacTruocKhiShare.Checked = this.gclass22_0.method_4("ckbTuongTacTruocKhiShare");
      this.nudSoLuongFrom.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongFrom", 30);
      this.nudSoLuongTo.Value = (Decimal) this.gclass22_0.method_3("nudSoLuongTo", 30);
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
      this.ckbBinhLuanNhieuLan.Checked = this.gclass22_0.method_4("ckbBinhLuanNhieuLan");
      this.nudBinhLuanNhieuLanDelayFrom.Value = (Decimal) this.gclass22_0.method_3("nudBinhLuanNhieuLanDelayFrom", 10);
      this.nudBinhLuanNhieuLanDelayTo.Value = (Decimal) this.gclass22_0.method_3("nudBinhLuanNhieuLanDelayTo", 10);
    }
    catch
    {
    }
    this.method_3();
    this.method_1();
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtTenHanhDong.Text.Trim();
    if (string_1 == "")
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
    }
    else
    {
      GClass22 gclass22 = new GClass22();
      gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
      gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
      gclass22.method_6("ckbShareBaiLenTuong", (object) this.ckbShareBaiLenTuong.Checked);
      gclass22.method_6("ckbShareBaiLenNhom", (object) this.ckbShareBaiLenNhom.Checked);
      gclass22.method_6("nudCountGroupFrom", (object) this.nudCountGroupFrom.Value);
      gclass22.method_6("nudCountGroupTo", (object) this.nudCountGroupTo.Value);
      gclass22.method_6("ckbShareNhomNangCao", (object) this.ckbShareNhomNangCao.Checked);
      gclass22.method_6("ckbChiShareNhomKKD", (object) this.ckbChiShareNhomKKD.Checked);
      gclass22.method_6("ckbUuTienShareNhomNhieuThanhVien", (object) this.ckbUuTienShareNhomNhieuThanhVien.Checked);
      gclass22.method_6("ckbBackupDanhSachNhom", (object) this.ckbBackupDanhSachNhom.Checked);
      gclass22.method_6("ckbKhongShareTrungNhom", (object) this.ckbKhongShareTrungNhom.Checked);
      gclass22.method_6("ckbChiShareNhomThuocDanhSach", (object) this.ckbChiShareNhomThuocDanhSach.Checked);
      gclass22.method_8("lstNhomTuNhap", this.list_1);
      if (this.txtLinkChiaSe.Text.Trim() == "")
      {
        GClass14.smethod_0((object) "Vui lòng nhập Link cần share!", 3);
      }
      else
      {
        gclass22.method_6("txtLinkChiaSe", (object) this.txtLinkChiaSe.Text.Trim());
        int object_0_1 = 0;
        if (this.rbShareOther.Checked)
          object_0_1 = 1;
        else if (this.rbShareReel.Checked)
          object_0_1 = 2;
        gclass22.method_6("typeLinkShare", (object) object_0_1);
        gclass22.method_6("ckbVanBan", (object) this.ckbVanBan.Checked);
        gclass22.method_6("txtNoiDung", (object) this.txtNoiDung.Text.Trim());
        gclass22.method_6("ckbTuongTacTruocKhiShare", (object) this.ckbTuongTacTruocKhiShare.Checked);
        gclass22.method_6("nudSoLuongFrom", (object) this.nudSoLuongFrom.Value);
        gclass22.method_6("nudSoLuongTo", (object) this.nudSoLuongTo.Value);
        gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
        string object_0_2 = "";
        for (int index = 0; index < this.list_0.Count; ++index)
          object_0_2 += this.list_0[index].Checked ? index.ToString() ?? "" : "";
        gclass22.method_6("typeReaction", (object) object_0_2);
        gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
        gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
        gclass22.method_6("ckbBinhLuanNhieuLan", (object) this.ckbBinhLuanNhieuLan.Checked);
        gclass22.method_6("nudBinhLuanNhieuLanDelayFrom", (object) this.nudBinhLuanNhieuLanDelayFrom.Value);
        gclass22.method_6("nudBinhLuanNhieuLanDelayTo", (object) this.nudBinhLuanNhieuLanDelayTo.Value);
        string str = gclass22.method_11();
        if (this.int_0 == 0)
        {
          if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
            return;
          if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
          {
            fHDShareBaiNangCao.bool_0 = true;
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
            fHDShareBaiNangCao.bool_0 = true;
            this.Close();
          }
          else
            GClass14.smethod_0((object) GClass35.smethod_0("Cập nhật thất bại, vui lòng thử lại sau!"), 2);
        }
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

  private void method_1()
  {
    this.ckbVanBan_CheckedChanged((object) null, (EventArgs) null);
    this.ckbTuongTacTruocKhiShare_CheckedChanged((object) null, (EventArgs) null);
    this.ckbInteract_CheckedChanged((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
    this.ckbBinhLuanNhieuLan_CheckedChanged((object) null, (EventArgs) null);
    this.ckbShareNhomNangCao_CheckedChanged((object) null, (EventArgs) null);
    this.ckbShareBaiLenNhom_CheckedChanged((object) null, (EventArgs) null);
    this.ckbChiShareNhomThuocDanhSach_CheckedChanged((object) null, (EventArgs) null);
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
  }

  private void txtLinkChiaSe_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtLinkChiaSe, (Control) this.label3);

  private void ckbVanBan_CheckedChanged(object sender, EventArgs e) => this.plVanBan.Enabled = this.ckbVanBan.Checked;

  private void txtNoiDung_TextChanged(object sender, EventArgs e) => this.method_2();

  private void method_2()
  {
    try
    {
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = GClass19.smethod_39(((IEnumerable<string>) this.txtNoiDung.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Danh sách nội dung ({0}):"), (object) stringList2.Count.ToString());
    }
    catch
    {
    }
  }

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => GClass19.smethod_35((Form) new fHuongDanRandom());

  private void txtComment_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>());
      this.label15.Text = string.Format(GClass35.smethod_0("Nội dung bình luận ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => GClass19.smethod_35((Form) new fHuongDanRandom());

  private void ckbTuongTacTruocKhiShare_CheckedChanged(object sender, EventArgs e) => this.plTuongTacTruocKhiShare.Enabled = this.ckbTuongTacTruocKhiShare.Checked;

  private void ckbShareBaiLenNhom_CheckedChanged(object sender, EventArgs e) => this.plShareBaiLenNhom.Enabled = this.ckbShareBaiLenNhom.Checked;

  private void ckbInteract_CheckedChanged(object sender, EventArgs e) => this.plInteract.Enabled = this.ckbInteract.Checked;

  private void ckbComment_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbComment.Checked;

  private void ckbBinhLuanNhieuLan_CheckedChanged(object sender, EventArgs e) => this.plBinhLuanNhieuLan.Enabled = this.ckbBinhLuanNhieuLan.Checked;

  private void ckbShareNhomNangCao_CheckedChanged(object sender, EventArgs e) => this.plShareNhomNangCao.Enabled = this.ckbShareNhomNangCao.Checked;

  private void rbShareOther_CheckedChanged(object sender, EventArgs e) => this.method_3();

  private void rbShareLivestream_CheckedChanged(object sender, EventArgs e) => this.method_3();

  private void method_3()
  {
    if (this.rbShareOther.Checked || this.rbShareReel.Checked)
      this.ckbBinhLuanNhieuLan.Checked = false;
    this.ckbBinhLuanNhieuLan.Enabled = this.rbShareLivestream.Checked;
    this.plBinhLuanNhieuLan.Enabled = this.rbShareLivestream.Checked;
  }

  private void ckbShareNhomNangCao_Click(object sender, EventArgs e)
  {
    if (!this.ckbShareNhomNangCao.Checked || GClass14.smethod_1(GClass35.smethod_0("Tính năng này có thể khiến tài khoản bị khóa và làm giảm tốc độ chia sẻ, bạn vẫn muốn sử dụng?")) != DialogResult.No)
      return;
    this.ckbShareNhomNangCao.Checked = false;
  }

  private void btnNhapDanhSachNhom_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_1, "Nhập danh sách Id nhóm", "Danh sách Id nhóm", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_1 = form_0.list_0;
  }

  private void ckbChiShareNhomThuocDanhSach_CheckedChanged(object sender, EventArgs e) => this.btnNhapDanhSachNhom.Enabled = this.ckbChiShareNhomThuocDanhSach.Checked;

  private void ckbChiShareNhomKKD_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void ckbChiShareNhomKKD_Click(object sender, EventArgs e)
  {
    if (!this.ckbChiShareNhomKKD.Checked || GClass14.smethod_1(GClass35.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) != DialogResult.No)
      return;
    this.ckbChiShareNhomKKD.Checked = false;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDShareBaiNangCao));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.groupBox1 = new GroupBox();
    this.txtLinkChiaSe = new RichTextBox();
    this.plTuongTacTruocKhiShare = new Panel();
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
    this.label4 = new Label();
    this.label22 = new Label();
    this.plComment = new Panel();
    this.linkLabel2 = new LinkLabel();
    this.plBinhLuanNhieuLan = new Panel();
    this.nudBinhLuanNhieuLanDelayTo = new NumericUpDown();
    this.nudBinhLuanNhieuLanDelayFrom = new NumericUpDown();
    this.label9 = new Label();
    this.label13 = new Label();
    this.lblmc1 = new Label();
    this.ckbBinhLuanNhieuLan = new CheckBox();
    this.label14 = new Label();
    this.txtComment = new TextBox();
    this.label15 = new Label();
    this.label21 = new Label();
    this.label18 = new Label();
    this.ckbComment = new CheckBox();
    this.nudSoLuongFrom = new NumericUpDown();
    this.ckbInteract = new CheckBox();
    this.nudSoLuongTo = new NumericUpDown();
    this.plVanBan = new Panel();
    this.linkLabel1 = new LinkLabel();
    this.txtNoiDung = new RichTextBox();
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.rbShareReel = new RadioButton();
    this.rbShareOther = new RadioButton();
    this.rbShareLivestream = new RadioButton();
    this.ckbTuongTacTruocKhiShare = new CheckBox();
    this.label7 = new Label();
    this.label3 = new Label();
    this.ckbVanBan = new CheckBox();
    this.nudDelayTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.label20 = new Label();
    this.label19 = new Label();
    this.label2 = new Label();
    this.groupBox2 = new GroupBox();
    this.plShareBaiLenNhom = new Panel();
    this.plShareNhomNangCao = new Panel();
    this.btnNhapDanhSachNhom = new Button();
    this.ckbChiShareNhomThuocDanhSach = new CheckBox();
    this.ckbBackupDanhSachNhom = new CheckBox();
    this.ckbKhongShareTrungNhom = new CheckBox();
    this.ckbUuTienShareNhomNhieuThanhVien = new CheckBox();
    this.ckbChiShareNhomKKD = new CheckBox();
    this.ckbShareNhomNangCao = new CheckBox();
    this.nudCountGroupTo = new NumericUpDown();
    this.nudCountGroupFrom = new NumericUpDown();
    this.label24 = new Label();
    this.label25 = new Label();
    this.label26 = new Label();
    this.ckbShareBaiLenNhom = new CheckBox();
    this.ckbShareBaiLenTuong = new CheckBox();
    this.btnAdd = new Button();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.groupBox1.SuspendLayout();
    this.plTuongTacTruocKhiShare.SuspendLayout();
    this.plInteract.SuspendLayout();
    this.panel7.SuspendLayout();
    this.plComment.SuspendLayout();
    this.plBinhLuanNhieuLan.SuspendLayout();
    this.nudBinhLuanNhieuLanDelayTo.BeginInit();
    this.nudBinhLuanNhieuLanDelayFrom.BeginInit();
    this.nudSoLuongFrom.BeginInit();
    this.nudSoLuongTo.BeginInit();
    this.plVanBan.SuspendLayout();
    this.nudDelayTo.BeginInit();
    this.nudDelayFrom.BeginInit();
    this.groupBox2.SuspendLayout();
    this.plShareBaiLenNhom.SuspendLayout();
    this.plShareNhomNangCao.SuspendLayout();
    this.nudCountGroupTo.BeginInit();
    this.nudCountGroupFrom.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(1153, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Share bài nâng cao";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button1);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(1153, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(1122, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 0;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.groupBox2);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(1156, 582);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.groupBox1.Controls.Add((Control) this.txtLinkChiaSe);
    this.groupBox1.Controls.Add((Control) this.plTuongTacTruocKhiShare);
    this.groupBox1.Controls.Add((Control) this.plVanBan);
    this.groupBox1.Controls.Add((Control) this.rbShareReel);
    this.groupBox1.Controls.Add((Control) this.rbShareOther);
    this.groupBox1.Controls.Add((Control) this.rbShareLivestream);
    this.groupBox1.Controls.Add((Control) this.ckbTuongTacTruocKhiShare);
    this.groupBox1.Controls.Add((Control) this.label7);
    this.groupBox1.Controls.Add((Control) this.label3);
    this.groupBox1.Controls.Add((Control) this.ckbVanBan);
    this.groupBox1.Controls.Add((Control) this.nudDelayTo);
    this.groupBox1.Controls.Add((Control) this.nudDelayFrom);
    this.groupBox1.Controls.Add((Control) this.label20);
    this.groupBox1.Controls.Add((Control) this.label19);
    this.groupBox1.Controls.Add((Control) this.label2);
    this.groupBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.groupBox1.Location = new Point(30, 80);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(745, 447);
    this.groupBox1.TabIndex = 8;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Cấu hình chạy";
    this.txtLinkChiaSe.Location = new Point(17, 67);
    this.txtLinkChiaSe.Name = "txtLinkChiaSe";
    this.txtLinkChiaSe.Size = new Size(349, 93);
    this.txtLinkChiaSe.TabIndex = 73;
    this.txtLinkChiaSe.Text = "";
    this.txtLinkChiaSe.WordWrap = false;
    this.txtLinkChiaSe.TextChanged += new EventHandler(this.txtLinkChiaSe_TextChanged);
    this.plTuongTacTruocKhiShare.BorderStyle = BorderStyle.FixedSingle;
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.plInteract);
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.label22);
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.plComment);
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.label21);
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.label18);
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.ckbComment);
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.nudSoLuongFrom);
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.ckbInteract);
    this.plTuongTacTruocKhiShare.Controls.Add((Control) this.nudSoLuongTo);
    this.plTuongTacTruocKhiShare.Font = new Font("Tahoma", 9.75f);
    this.plTuongTacTruocKhiShare.Location = new Point(391, 90);
    this.plTuongTacTruocKhiShare.Name = "plTuongTacTruocKhiShare";
    this.plTuongTacTruocKhiShare.Size = new Size(345, 345);
    this.plTuongTacTruocKhiShare.TabIndex = 10;
    this.plInteract.BorderStyle = BorderStyle.FixedSingle;
    this.plInteract.Controls.Add((Control) this.ckbGian);
    this.plInteract.Controls.Add((Control) this.ckbBuon);
    this.plInteract.Controls.Add((Control) this.ckbWow);
    this.plInteract.Controls.Add((Control) this.ckbHaha);
    this.plInteract.Controls.Add((Control) this.ckbThuong);
    this.plInteract.Controls.Add((Control) this.ckbTym);
    this.plInteract.Controls.Add((Control) this.ckbLike);
    this.plInteract.Controls.Add((Control) this.panel7);
    this.plInteract.Controls.Add((Control) this.label4);
    this.plInteract.Location = new Point(24, 53);
    this.plInteract.Name = "plInteract";
    this.plInteract.Size = new Size(312, 33);
    this.plInteract.TabIndex = 182;
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
    this.label4.AutoSize = true;
    this.label4.Location = new Point(4, 302);
    this.label4.Name = "label4";
    this.label4.Size = new Size(64, 16);
    this.label4.TabIndex = 2;
    this.label4.Text = "Tùy chọn:";
    this.label22.AutoSize = true;
    this.label22.Location = new Point(3, 7);
    this.label22.Name = "label22";
    this.label22.Size = new Size(93, 16);
    this.label22.TabIndex = 44;
    this.label22.Text = "Thời gian xem:";
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.linkLabel2);
    this.plComment.Controls.Add((Control) this.plBinhLuanNhieuLan);
    this.plComment.Controls.Add((Control) this.ckbBinhLuanNhieuLan);
    this.plComment.Controls.Add((Control) this.label14);
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.label15);
    this.plComment.Location = new Point(24, 117);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(312, 213);
    this.plComment.TabIndex = 43;
    this.linkLabel2.AutoSize = true;
    this.linkLabel2.Cursor = Cursors.Hand;
    this.linkLabel2.Location = new Point(228, 146);
    this.linkLabel2.Name = "linkLabel2";
    this.linkLabel2.Size = new Size(81, 16);
    this.linkLabel2.TabIndex = 192;
    this.linkLabel2.TabStop = true;
    this.linkLabel2.Text = "Random icon";
    this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.nudBinhLuanNhieuLanDelayTo);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.nudBinhLuanNhieuLanDelayFrom);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.label9);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.label13);
    this.plBinhLuanNhieuLan.Controls.Add((Control) this.lblmc1);
    this.plBinhLuanNhieuLan.Location = new Point(19, 183);
    this.plBinhLuanNhieuLan.Name = "plBinhLuanNhieuLan";
    this.plBinhLuanNhieuLan.Size = new Size(254, 27);
    this.plBinhLuanNhieuLan.TabIndex = 134;
    this.nudBinhLuanNhieuLanDelayTo.Cursor = Cursors.Hand;
    this.nudBinhLuanNhieuLanDelayTo.Location = new Point(177, 2);
    this.nudBinhLuanNhieuLanDelayTo.Maximum = new Decimal(new int[4]
    {
      100000000,
      0,
      0,
      0
    });
    this.nudBinhLuanNhieuLanDelayTo.Name = "nudBinhLuanNhieuLanDelayTo";
    this.nudBinhLuanNhieuLanDelayTo.Size = new Size(50, 23);
    this.nudBinhLuanNhieuLanDelayTo.TabIndex = 22;
    this.nudBinhLuanNhieuLanDelayFrom.Cursor = Cursors.Hand;
    this.nudBinhLuanNhieuLanDelayFrom.Location = new Point(104, 2);
    this.nudBinhLuanNhieuLanDelayFrom.Maximum = new Decimal(new int[4]
    {
      100000000,
      0,
      0,
      0
    });
    this.nudBinhLuanNhieuLanDelayFrom.Name = "nudBinhLuanNhieuLanDelayFrom";
    this.nudBinhLuanNhieuLanDelayFrom.Size = new Size(45, 23);
    this.nudBinhLuanNhieuLanDelayFrom.TabIndex = 21;
    this.label9.AutoSize = true;
    this.label9.Location = new Point(226, 4);
    this.label9.Name = "label9";
    this.label9.Size = new Size(30, 16);
    this.label9.TabIndex = 20;
    this.label9.Text = "giây";
    this.label13.AutoSize = true;
    this.label13.Location = new Point(149, 4);
    this.label13.Name = "label13";
    this.label13.Size = new Size(28, 16);
    this.label13.TabIndex = 20;
    this.label13.Text = "đến";
    this.lblmc1.AutoSize = true;
    this.lblmc1.Location = new Point(4, 4);
    this.lblmc1.Name = "lblmc1";
    this.lblmc1.Size = new Size(100, 16);
    this.lblmc1.TabIndex = 18;
    this.lblmc1.Text = "Delay comment:";
    this.ckbBinhLuanNhieuLan.AutoSize = true;
    this.ckbBinhLuanNhieuLan.Cursor = Cursors.Hand;
    this.ckbBinhLuanNhieuLan.Location = new Point(7, 164);
    this.ckbBinhLuanNhieuLan.Name = "ckbBinhLuanNhieuLan";
    this.ckbBinhLuanNhieuLan.Size = new Size(134, 20);
    this.ckbBinhLuanNhieuLan.TabIndex = 133;
    this.ckbBinhLuanNhieuLan.Text = "Bình luận nhiều lần";
    this.ckbBinhLuanNhieuLan.UseVisualStyleBackColor = true;
    this.ckbBinhLuanNhieuLan.CheckedChanged += new EventHandler(this.ckbBinhLuanNhieuLan_CheckedChanged);
    this.label14.AutoSize = true;
    this.label14.Location = new Point(4, 146);
    this.label14.Name = "label14";
    this.label14.Size = new Size(143, 16);
    this.label14.TabIndex = 2;
    this.label14.Text = "(Spin nội dung {a|b|c})";
    this.txtComment.Location = new Point(7, 27);
    this.txtComment.Multiline = true;
    this.txtComment.Name = "txtComment";
    this.txtComment.ScrollBars = ScrollBars.Both;
    this.txtComment.Size = new Size(299, 117);
    this.txtComment.TabIndex = 1;
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.label15.AutoSize = true;
    this.label15.Location = new Point(3, 5);
    this.label15.Name = "label15";
    this.label15.Size = new Size(139, 16);
    this.label15.TabIndex = 0;
    this.label15.Text = "Nội dung bình luận (0):";
    this.label21.AutoSize = true;
    this.label21.Location = new Point(266, 7);
    this.label21.Name = "label21";
    this.label21.Size = new Size(30, 16);
    this.label21.TabIndex = 45;
    this.label21.Text = "giây";
    this.label18.Location = new Point(170, 7);
    this.label18.Name = "label18";
    this.label18.Size = new Size(29, 16);
    this.label18.TabIndex = 46;
    this.label18.Text = "đến";
    this.label18.TextAlign = ContentAlignment.MiddleCenter;
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(6, 92);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size(130, 20);
    this.ckbComment.TabIndex = 42;
    this.ckbComment.Text = "Tự động bình luận";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.nudSoLuongFrom.Location = new Point(108, 5);
    this.nudSoLuongFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongFrom.Name = "nudSoLuongFrom";
    this.nudSoLuongFrom.Size = new Size(56, 23);
    this.nudSoLuongFrom.TabIndex = 38;
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(6, 31);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(112, 20);
    this.ckbInteract.TabIndex = 40;
    this.ckbInteract.Text = "Bày tỏ cảm xúc";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.ckbInteract.CheckedChanged += new EventHandler(this.ckbInteract_CheckedChanged);
    this.nudSoLuongTo.Location = new Point(205, 5);
    this.nudSoLuongTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudSoLuongTo.Name = "nudSoLuongTo";
    this.nudSoLuongTo.Size = new Size(56, 23);
    this.nudSoLuongTo.TabIndex = 39;
    this.plVanBan.BorderStyle = BorderStyle.FixedSingle;
    this.plVanBan.Controls.Add((Control) this.linkLabel1);
    this.plVanBan.Controls.Add((Control) this.txtNoiDung);
    this.plVanBan.Controls.Add((Control) this.label8);
    this.plVanBan.Controls.Add((Control) this.lblStatus);
    this.plVanBan.Location = new Point(35, 211);
    this.plVanBan.Name = "plVanBan";
    this.plVanBan.Size = new Size(331, 224);
    this.plVanBan.TabIndex = 72;
    this.linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.Cursor = Cursors.Hand;
    this.linkLabel1.Location = new Point(155, 202);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(81, 16);
    this.linkLabel1.TabIndex = 195;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "Random icon";
    this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
    this.txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtNoiDung.Location = new Point(7, 24);
    this.txtNoiDung.Name = "txtNoiDung";
    this.txtNoiDung.Size = new Size(319, 175);
    this.txtNoiDung.TabIndex = 34;
    this.txtNoiDung.Text = "";
    this.txtNoiDung.WordWrap = false;
    this.txtNoiDung.TextChanged += new EventHandler(this.txtNoiDung_TextChanged);
    this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label8.AutoSize = true;
    this.label8.Location = new Point(5, 202);
    this.label8.Name = "label8";
    this.label8.Size = new Size(143, 16);
    this.label8.TabIndex = 0;
    this.label8.Text = "(Spin nội dung {a|b|c})";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(145, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Danh sách nội dung (0):";
    this.rbShareReel.AutoSize = true;
    this.rbShareReel.Cursor = Cursors.Hand;
    this.rbShareReel.Location = new Point(279, 163);
    this.rbShareReel.Name = "rbShareReel";
    this.rbShareReel.Size = new Size(50, 20);
    this.rbShareReel.TabIndex = 71;
    this.rbShareReel.TabStop = true;
    this.rbShareReel.Text = "Reel";
    this.rbShareReel.UseVisualStyleBackColor = true;
    this.rbShareOther.AutoSize = true;
    this.rbShareOther.Cursor = Cursors.Hand;
    this.rbShareOther.Location = new Point(207, 163);
    this.rbShareOther.Name = "rbShareOther";
    this.rbShareOther.Size = new Size(66, 20);
    this.rbShareOther.TabIndex = 71;
    this.rbShareOther.TabStop = true;
    this.rbShareOther.Text = "Bài viết";
    this.rbShareOther.UseVisualStyleBackColor = true;
    this.rbShareOther.CheckedChanged += new EventHandler(this.rbShareOther_CheckedChanged);
    this.rbShareLivestream.AutoSize = true;
    this.rbShareLivestream.Cursor = Cursors.Hand;
    this.rbShareLivestream.Location = new Point(114, 163);
    this.rbShareLivestream.Name = "rbShareLivestream";
    this.rbShareLivestream.Size = new Size(87, 20);
    this.rbShareLivestream.TabIndex = 71;
    this.rbShareLivestream.TabStop = true;
    this.rbShareLivestream.Text = "Livestream";
    this.rbShareLivestream.UseVisualStyleBackColor = true;
    this.rbShareLivestream.CheckedChanged += new EventHandler(this.rbShareLivestream_CheckedChanged);
    this.ckbTuongTacTruocKhiShare.AutoSize = true;
    this.ckbTuongTacTruocKhiShare.Cursor = Cursors.Hand;
    this.ckbTuongTacTruocKhiShare.Location = new Point(391, 67);
    this.ckbTuongTacTruocKhiShare.Name = "ckbTuongTacTruocKhiShare";
    this.ckbTuongTacTruocKhiShare.Size = new Size(174, 20);
    this.ckbTuongTacTruocKhiShare.TabIndex = 3;
    this.ckbTuongTacTruocKhiShare.Text = "Tương tác trước khi share";
    this.ckbTuongTacTruocKhiShare.UseVisualStyleBackColor = true;
    this.ckbTuongTacTruocKhiShare.CheckedChanged += new EventHandler(this.ckbTuongTacTruocKhiShare_CheckedChanged);
    this.label7.AutoSize = true;
    this.label7.Location = new Point(14, 165);
    this.label7.Name = "label7";
    this.label7.Size = new Size(94, 16);
    this.label7.TabIndex = 70;
    this.label7.Text = "Loại link share:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(14, 49);
    this.label3.Name = "label3";
    this.label3.Size = new Size(115, 16);
    this.label3.TabIndex = 70;
    this.label3.Text = "Link cần share (0):";
    this.ckbVanBan.AutoSize = true;
    this.ckbVanBan.Cursor = Cursors.Hand;
    this.ckbVanBan.Location = new Point(17, 188);
    this.ckbVanBan.Name = "ckbVanBan";
    this.ckbVanBan.Size = new Size(112, 20);
    this.ckbVanBan.TabIndex = 67;
    this.ckbVanBan.Text = "Nội dung share";
    this.ckbVanBan.UseVisualStyleBackColor = true;
    this.ckbVanBan.CheckedChanged += new EventHandler(this.ckbVanBan_CheckedChanged);
    this.nudDelayTo.Location = new Point(238, 22);
    this.nudDelayTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayTo.Name = "nudDelayTo";
    this.nudDelayTo.Size = new Size(56, 23);
    this.nudDelayTo.TabIndex = 63;
    this.nudDelayFrom.Location = new Point(141, 22);
    this.nudDelayFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudDelayFrom.Name = "nudDelayFrom";
    this.nudDelayFrom.Size = new Size(56, 23);
    this.nudDelayFrom.TabIndex = 62;
    this.label20.AutoSize = true;
    this.label20.Location = new Point(203, 24);
    this.label20.Name = "label20";
    this.label20.Size = new Size(28, 16);
    this.label20.TabIndex = 66;
    this.label20.Text = "đến";
    this.label19.AutoSize = true;
    this.label19.Location = new Point(297, 24);
    this.label19.Name = "label19";
    this.label19.Size = new Size(30, 16);
    this.label19.TabIndex = 65;
    this.label19.Text = "giây";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(14, 24);
    this.label2.Name = "label2";
    this.label2.Size = new Size(120, 16);
    this.label2.TabIndex = 64;
    this.label2.Text = "Khoảng cách share:";
    this.groupBox2.Controls.Add((Control) this.plShareBaiLenNhom);
    this.groupBox2.Controls.Add((Control) this.ckbShareBaiLenNhom);
    this.groupBox2.Controls.Add((Control) this.ckbShareBaiLenTuong);
    this.groupBox2.Location = new Point(781, 80);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(343, 275);
    this.groupBox2.TabIndex = 62;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Tùy chọn share";
    this.plShareBaiLenNhom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.plShareBaiLenNhom.BorderStyle = BorderStyle.FixedSingle;
    this.plShareBaiLenNhom.Controls.Add((Control) this.plShareNhomNangCao);
    this.plShareBaiLenNhom.Controls.Add((Control) this.ckbShareNhomNangCao);
    this.plShareBaiLenNhom.Controls.Add((Control) this.nudCountGroupTo);
    this.plShareBaiLenNhom.Controls.Add((Control) this.nudCountGroupFrom);
    this.plShareBaiLenNhom.Controls.Add((Control) this.label24);
    this.plShareBaiLenNhom.Controls.Add((Control) this.label25);
    this.plShareBaiLenNhom.Controls.Add((Control) this.label26);
    this.plShareBaiLenNhom.Location = new Point(23, 73);
    this.plShareBaiLenNhom.Name = "plShareBaiLenNhom";
    this.plShareBaiLenNhom.Size = new Size(312, 195);
    this.plShareBaiLenNhom.TabIndex = 1;
    this.plShareNhomNangCao.BorderStyle = BorderStyle.FixedSingle;
    this.plShareNhomNangCao.Controls.Add((Control) this.btnNhapDanhSachNhom);
    this.plShareNhomNangCao.Controls.Add((Control) this.ckbChiShareNhomThuocDanhSach);
    this.plShareNhomNangCao.Controls.Add((Control) this.ckbBackupDanhSachNhom);
    this.plShareNhomNangCao.Controls.Add((Control) this.ckbKhongShareTrungNhom);
    this.plShareNhomNangCao.Controls.Add((Control) this.ckbUuTienShareNhomNhieuThanhVien);
    this.plShareNhomNangCao.Controls.Add((Control) this.ckbChiShareNhomKKD);
    this.plShareNhomNangCao.Location = new Point(19, 55);
    this.plShareNhomNangCao.Name = "plShareNhomNangCao";
    this.plShareNhomNangCao.Size = new Size(285, 133);
    this.plShareNhomNangCao.TabIndex = 58;
    this.btnNhapDanhSachNhom.Cursor = Cursors.Hand;
    this.btnNhapDanhSachNhom.Location = new Point(218, 103);
    this.btnNhapDanhSachNhom.Name = "btnNhapDanhSachNhom";
    this.btnNhapDanhSachNhom.Size = new Size(62, 25);
    this.btnNhapDanhSachNhom.TabIndex = 4;
    this.btnNhapDanhSachNhom.Text = "Nhập";
    this.btnNhapDanhSachNhom.UseVisualStyleBackColor = true;
    this.btnNhapDanhSachNhom.Click += new EventHandler(this.btnNhapDanhSachNhom_Click);
    this.ckbChiShareNhomThuocDanhSach.AutoSize = true;
    this.ckbChiShareNhomThuocDanhSach.Cursor = Cursors.Hand;
    this.ckbChiShareNhomThuocDanhSach.Location = new Point(4, 105);
    this.ckbChiShareNhomThuocDanhSach.Name = "ckbChiShareNhomThuocDanhSach";
    this.ckbChiShareNhomThuocDanhSach.Size = new Size(218, 20);
    this.ckbChiShareNhomThuocDanhSach.TabIndex = 3;
    this.ckbChiShareNhomThuocDanhSach.Text = "Chỉ share nhóm thuộc danh sách:";
    this.ckbChiShareNhomThuocDanhSach.UseVisualStyleBackColor = true;
    this.ckbChiShareNhomThuocDanhSach.CheckedChanged += new EventHandler(this.ckbChiShareNhomThuocDanhSach_CheckedChanged);
    this.ckbBackupDanhSachNhom.AutoSize = true;
    this.ckbBackupDanhSachNhom.Cursor = Cursors.Hand;
    this.ckbBackupDanhSachNhom.Location = new Point(4, 80);
    this.ckbBackupDanhSachNhom.Name = "ckbBackupDanhSachNhom";
    this.ckbBackupDanhSachNhom.Size = new Size(234, 20);
    this.ckbBackupDanhSachNhom.TabIndex = 3;
    this.ckbBackupDanhSachNhom.Text = "Sử dụng danh sách nhóm đã backup";
    this.ckbBackupDanhSachNhom.UseVisualStyleBackColor = true;
    this.ckbKhongShareTrungNhom.AutoSize = true;
    this.ckbKhongShareTrungNhom.Cursor = Cursors.Hand;
    this.ckbKhongShareTrungNhom.Location = new Point(4, 55);
    this.ckbKhongShareTrungNhom.Name = "ckbKhongShareTrungNhom";
    this.ckbKhongShareTrungNhom.Size = new Size(273, 20);
    this.ckbKhongShareTrungNhom.TabIndex = 3;
    this.ckbKhongShareTrungNhom.Text = "Không share trùng nhóm với tài khoản khác";
    this.ckbKhongShareTrungNhom.UseVisualStyleBackColor = true;
    this.ckbUuTienShareNhomNhieuThanhVien.AutoSize = true;
    this.ckbUuTienShareNhomNhieuThanhVien.Cursor = Cursors.Hand;
    this.ckbUuTienShareNhomNhieuThanhVien.Location = new Point(4, 29);
    this.ckbUuTienShareNhomNhieuThanhVien.Name = "ckbUuTienShareNhomNhieuThanhVien";
    this.ckbUuTienShareNhomNhieuThanhVien.Size = new Size(254, 20);
    this.ckbUuTienShareNhomNhieuThanhVien.TabIndex = 3;
    this.ckbUuTienShareNhomNhieuThanhVien.Text = "Ưu tiên share nhóm có nhiều thành viên";
    this.ckbUuTienShareNhomNhieuThanhVien.UseVisualStyleBackColor = true;
    this.ckbChiShareNhomKKD.AutoSize = true;
    this.ckbChiShareNhomKKD.Cursor = Cursors.Hand;
    this.ckbChiShareNhomKKD.Location = new Point(4, 3);
    this.ckbChiShareNhomKKD.Name = "ckbChiShareNhomKKD";
    this.ckbChiShareNhomKKD.Size = new Size(220, 20);
    this.ckbChiShareNhomKKD.TabIndex = 3;
    this.ckbChiShareNhomKKD.Text = "Chỉ share nhóm không kiểm duyệt";
    this.ckbChiShareNhomKKD.UseVisualStyleBackColor = true;
    this.ckbChiShareNhomKKD.CheckedChanged += new EventHandler(this.ckbChiShareNhomKKD_CheckedChanged);
    this.ckbChiShareNhomKKD.Click += new EventHandler(this.ckbChiShareNhomKKD_Click);
    this.ckbShareNhomNangCao.AutoSize = true;
    this.ckbShareNhomNangCao.Cursor = Cursors.Hand;
    this.ckbShareNhomNangCao.Location = new Point(6, 33);
    this.ckbShareNhomNangCao.Name = "ckbShareNhomNangCao";
    this.ckbShareNhomNangCao.Size = new Size(132, 20);
    this.ckbShareNhomNangCao.TabIndex = 57;
    this.ckbShareNhomNangCao.Text = "Cấu hình nâng cao";
    this.ckbShareNhomNangCao.UseVisualStyleBackColor = true;
    this.ckbShareNhomNangCao.CheckedChanged += new EventHandler(this.ckbShareNhomNangCao_CheckedChanged);
    this.ckbShareNhomNangCao.Click += new EventHandler(this.ckbShareNhomNangCao_Click);
    this.nudCountGroupTo.Location = new Point(205, 4);
    this.nudCountGroupTo.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountGroupTo.Name = "nudCountGroupTo";
    this.nudCountGroupTo.Size = new Size(56, 23);
    this.nudCountGroupTo.TabIndex = 53;
    this.nudCountGroupFrom.Location = new Point(108, 4);
    this.nudCountGroupFrom.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudCountGroupFrom.Name = "nudCountGroupFrom";
    this.nudCountGroupFrom.Size = new Size(56, 23);
    this.nudCountGroupFrom.TabIndex = 52;
    this.label24.AutoSize = true;
    this.label24.Location = new Point(170, 6);
    this.label24.Name = "label24";
    this.label24.Size = new Size(28, 16);
    this.label24.TabIndex = 56;
    this.label24.Text = "đến";
    this.label25.AutoSize = true;
    this.label25.Location = new Point(264, 6);
    this.label25.Name = "label25";
    this.label25.Size = new Size(39, 16);
    this.label25.TabIndex = 55;
    this.label25.Text = "nhóm";
    this.label26.AutoSize = true;
    this.label26.Location = new Point(3, 6);
    this.label26.Name = "label26";
    this.label26.Size = new Size(99, 16);
    this.label26.TabIndex = 54;
    this.label26.Text = "Số lượng nhóm:";
    this.ckbShareBaiLenNhom.AutoSize = true;
    this.ckbShareBaiLenNhom.Cursor = Cursors.Hand;
    this.ckbShareBaiLenNhom.Location = new Point(11, 50);
    this.ckbShareBaiLenNhom.Name = "ckbShareBaiLenNhom";
    this.ckbShareBaiLenNhom.Size = new Size(138, 20);
    this.ckbShareBaiLenNhom.TabIndex = 0;
    this.ckbShareBaiLenNhom.Text = "Share bài lên nhóm";
    this.ckbShareBaiLenNhom.UseVisualStyleBackColor = true;
    this.ckbShareBaiLenNhom.CheckedChanged += new EventHandler(this.ckbShareBaiLenNhom_CheckedChanged);
    this.ckbShareBaiLenTuong.AutoSize = true;
    this.ckbShareBaiLenTuong.Cursor = Cursors.Hand;
    this.ckbShareBaiLenTuong.Location = new Point(11, 23);
    this.ckbShareBaiLenTuong.Name = "ckbShareBaiLenTuong";
    this.ckbShareBaiLenTuong.Size = new Size(139, 20);
    this.ckbShareBaiLenTuong.TabIndex = 0;
    this.ckbShareBaiLenTuong.Text = "Share bài lên tường";
    this.ckbShareBaiLenTuong.UseVisualStyleBackColor = true;
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(482, 540);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.txtTenHanhDong.Location = new Point(132, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(193, 23);
    this.txtTenHanhDong.TabIndex = 0;
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
    this.btnCancel.Location = new Point(581, 540);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 4;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
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
    this.bunifuCards1.Size = new Size(1153, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1156, 582);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDShareBaiNangCao);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDShareBaiNangCao_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.plTuongTacTruocKhiShare.ResumeLayout(false);
    this.plTuongTacTruocKhiShare.PerformLayout();
    this.plInteract.ResumeLayout(false);
    this.plInteract.PerformLayout();
    this.panel7.ResumeLayout(false);
    this.panel7.PerformLayout();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.plBinhLuanNhieuLan.ResumeLayout(false);
    this.plBinhLuanNhieuLan.PerformLayout();
    this.nudBinhLuanNhieuLanDelayTo.EndInit();
    this.nudBinhLuanNhieuLanDelayFrom.EndInit();
    this.nudSoLuongFrom.EndInit();
    this.nudSoLuongTo.EndInit();
    this.plVanBan.ResumeLayout(false);
    this.plVanBan.PerformLayout();
    this.nudDelayTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    this.plShareBaiLenNhom.ResumeLayout(false);
    this.plShareBaiLenNhom.PerformLayout();
    this.plShareNhomNangCao.ResumeLayout(false);
    this.plShareNhomNangCao.PerformLayout();
    this.nudCountGroupTo.EndInit();
    this.nudCountGroupFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
