// Decompiled with JetBrains decompiler
// Type: fHDCapNhatThongTin
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fHDCapNhatThongTin : Form
{
  private GClass22 gclass22_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private string string_3 = "";
  private int int_1 = 0;
  private List<string> list_0 = new List<string>();
  private List<string> list_1 = new List<string>();
  private List<string> list_2 = new List<string>();
  private List<string> list_3 = new List<string>();
  private List<string> list_4 = new List<string>();
  private List<string> list_5 = new List<string>();
  private List<string> list_6 = new List<string>();
  private List<string> list_7 = new List<string>();
  private List<string> list_8 = new List<string>()
  {
    "Single",
    "In a relationship",
    "Engaged",
    "Married",
    "In a civil union",
    "In a domestic partnership",
    "In an open relationship",
    "It's complicated",
    "Separated",
    "Divorced",
    "Widowed"
  };
  private List<string> list_9 = new List<string>()
  {
    "Female",
    "Male"
  };
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
  private Button btnNhapBio;
  private CheckBox ckbRelationship;
  private CheckBox ckbCurrentCity;
  private CheckBox ckbCollege;
  private CheckBox ckbHighSchool;
  private CheckBox ckbWork;
  private Button btnNhapCurrentCity;
  private Button btnNhapCollege;
  private Button btnNhapHighSchool;
  private Button btnNhapWork;
  private CheckBox ckbBio;
  private ComboBox cbbRelationship;
  private CheckBox ckbHometown;
  private Button btnNhapHometown;
  private CheckBox ckbSkipWhenHave;
  private ComboBox cbbGender;
  private CheckBox ckbGender;
  private CheckBox ckbBirthday;
  private Button btnYear;
  private Button btnMonth;
  private IContainer components;
  private Button btnDay;

  public fHDCapNhatThongTin(string string_4, int int_2 = 0, string string_5 = "")
  {
    this.InitializeComponent();
    fHDCapNhatThongTin.bool_0 = false;
    this.string_0 = string_4;
    this.string_2 = string_5;
    this.int_0 = int_2;
    string string_1_1 = this.Name.Substring(1);
    string str = "Cập nhật thông tin";
    if (Class205.smethod_13(string_1: string_1_1).Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + string_1_1 + "', '" + str + "');");
    string string_1_2 = "";
    switch (int_2)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: string_1_1);
        string_1_2 = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_5);
        string_1_2 = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.gclass22_0 = new GClass22(string_1_2, true);
    GClass35.smethod_5((Control) this);
  }

  private void fHDCapNhatThongTin_Load(object sender, EventArgs e)
  {
    this.method_1();
    this.method_0();
    try
    {
      this.ckbBio.Checked = this.gclass22_0.method_4("ckbBio");
      this.ckbWork.Checked = this.gclass22_0.method_4("ckbWork");
      this.ckbHighSchool.Checked = this.gclass22_0.method_4("ckbHighSchool");
      this.ckbCollege.Checked = this.gclass22_0.method_4("ckbCollege");
      this.ckbCurrentCity.Checked = this.gclass22_0.method_4("ckbCurrentCity");
      this.ckbHometown.Checked = this.gclass22_0.method_4("ckbHometown");
      this.ckbRelationship.Checked = this.gclass22_0.method_4("ckbRelationship");
      this.ckbGender.Checked = this.gclass22_0.method_4("ckbGender");
      this.ckbBirthday.Checked = this.gclass22_0.method_4("ckbBirthday");
      this.string_3 = this.gclass22_0.method_1("txtBio");
      this.int_1 = this.gclass22_0.method_3("typeSplitBio");
      this.list_0 = this.gclass22_0.method_2("lstWork");
      this.list_1 = this.gclass22_0.method_2("lstHighSchool");
      this.list_2 = this.gclass22_0.method_2("lstCollege");
      this.list_3 = this.gclass22_0.method_2("lstCurrentCity");
      this.list_4 = this.gclass22_0.method_2("lstHometown");
      this.cbbRelationship.Text = this.gclass22_0.method_1("cbbRelationship").Split('|').Length == 1 ? this.gclass22_0.method_1("cbbRelationship", "Random") : "Random";
      this.ckbSkipWhenHave.Checked = this.gclass22_0.method_4("ckbSkipWhenHave");
      this.cbbGender.Text = this.gclass22_0.method_1("cbbGender").Split('|').Length == 1 ? this.gclass22_0.method_1("cbbGender", "Random") : "Random";
      this.list_5 = this.gclass22_0.method_2("lstDay");
      this.list_6 = this.gclass22_0.method_2("lstMonth");
      this.list_7 = this.gclass22_0.method_2("lstYear");
      this.ckbBio_CheckedChanged((object) null, (EventArgs) null);
      this.ckbWork_CheckedChanged((object) null, (EventArgs) null);
      this.ckbHighSchool_CheckedChanged((object) null, (EventArgs) null);
      this.ckbCollege_CheckedChanged((object) null, (EventArgs) null);
      this.ckbCurrentCity_CheckedChanged((object) null, (EventArgs) null);
      this.ckbHometown_CheckedChanged((object) null, (EventArgs) null);
      this.ckbRelationship_CheckedChanged((object) null, (EventArgs) null);
      this.ckbGender_CheckedChanged((object) null, (EventArgs) null);
      this.ckbBirthday_CheckedChanged((object) null, (EventArgs) null);
      GClass19.smethod_6((Control) this.btnNhapCurrentCity, this.list_3.Count);
      GClass19.smethod_6((Control) this.btnNhapHometown, this.list_4.Count);
      GClass19.smethod_6((Control) this.btnNhapCollege, this.list_2.Count);
      GClass19.smethod_6((Control) this.btnNhapHighSchool, this.list_1.Count);
      GClass19.smethod_6((Control) this.btnNhapWork, this.list_0.Count);
      GClass19.smethod_6((Control) this.btnNhapBio, this.string_3.Split(new string[1]
      {
        this.int_1 == 0 ? "\n" : "\n|\n"
      }, StringSplitOptions.RemoveEmptyEntries).Length);
    }
    catch
    {
    }
  }

  private void method_0()
  {
    Dictionary<string, string> dataSource = new Dictionary<string, string>();
    for (int index = 0; index < this.list_9.Count; ++index)
      dataSource.Add(index.ToString(), this.list_9[index]);
    dataSource.Add(this.list_9.Count.ToString(), "Random");
    this.cbbGender.DataSource = (object) new BindingSource((object) dataSource, (string) null);
    this.cbbGender.DisplayMember = "Value";
    this.cbbGender.ValueMember = "Key";
  }

  private void method_1()
  {
    Dictionary<string, string> dataSource = new Dictionary<string, string>();
    for (int index = 0; index < this.list_8.Count; ++index)
      dataSource.Add(index.ToString(), this.list_8[index]);
    dataSource.Add(this.list_8.Count.ToString(), "Random");
    this.cbbRelationship.DataSource = (object) new BindingSource((object) dataSource, (string) null);
    this.cbbRelationship.DisplayMember = "Value";
    this.cbbRelationship.ValueMember = "Key";
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
      gclass22.method_6("ckbBio", (object) this.ckbBio.Checked);
      gclass22.method_6("ckbWork", (object) this.ckbWork.Checked);
      gclass22.method_6("ckbHighSchool", (object) this.ckbHighSchool.Checked);
      gclass22.method_6("ckbCollege", (object) this.ckbCollege.Checked);
      gclass22.method_6("ckbCurrentCity", (object) this.ckbCurrentCity.Checked);
      gclass22.method_6("ckbHometown", (object) this.ckbHometown.Checked);
      gclass22.method_6("ckbRelationship", (object) this.ckbRelationship.Checked);
      gclass22.method_6("ckbGender", (object) this.ckbGender.Checked);
      gclass22.method_6("ckbBirthday", (object) this.ckbBirthday.Checked);
      gclass22.method_6("txtBio", (object) this.string_3);
      gclass22.method_6("typeSplitBio", (object) this.int_1);
      gclass22.method_8("lstWork", this.list_0);
      gclass22.method_8("lstHighSchool", this.list_1);
      gclass22.method_8("lstCollege", this.list_2);
      gclass22.method_8("lstCurrentCity", this.list_3);
      gclass22.method_8("lstHometown", this.list_4);
      string text1 = this.cbbRelationship.Text;
      string object_0_1 = text1 == "Random" ? string.Join("|", (IEnumerable<string>) this.list_8) : text1;
      gclass22.method_6("cbbRelationship", (object) object_0_1);
      string text2 = this.cbbGender.Text;
      string object_0_2 = text2 == "Random" ? string.Join("|", (IEnumerable<string>) this.list_9) : text2;
      gclass22.method_6("cbbGender", (object) object_0_2);
      gclass22.method_8("lstDay", this.list_5);
      gclass22.method_8("lstMonth", this.list_6);
      gclass22.method_8("lstYear", this.list_7);
      gclass22.method_6("ckbSkipWhenHave", (object) this.ckbSkipWhenHave.Checked);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDCapNhatThongTin.bool_0 = true;
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
          fHDCapNhatThongTin.bool_0 = true;
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

  private void ckbBio_CheckedChanged(object sender, EventArgs e) => this.btnNhapBio.Enabled = this.ckbBio.Checked;

  private void ckbWork_CheckedChanged(object sender, EventArgs e) => this.btnNhapWork.Enabled = this.ckbWork.Checked;

  private void ckbHighSchool_CheckedChanged(object sender, EventArgs e) => this.btnNhapHighSchool.Enabled = this.ckbHighSchool.Checked;

  private void ckbCollege_CheckedChanged(object sender, EventArgs e) => this.btnNhapCollege.Enabled = this.ckbCollege.Checked;

  private void ckbCurrentCity_CheckedChanged(object sender, EventArgs e) => this.btnNhapCurrentCity.Enabled = this.ckbCurrentCity.Checked;

  private void ckbRelationship_CheckedChanged(object sender, EventArgs e) => this.cbbRelationship.Enabled = this.ckbRelationship.Checked;

  private void btnNhapBio_Click(object sender, EventArgs e)
  {
    fNhapDuLieu3 form_0 = new fNhapDuLieu3(this.string_3, this.int_1, "Nhập danh sách Bio", "Danh sách Bio");
    GClass19.smethod_35((Form) form_0);
    this.string_3 = form_0.string_2;
    this.int_1 = form_0.int_0;
    GClass19.smethod_6((Control) this.btnNhapBio, this.string_3.Split(new string[1]
    {
      this.int_1 == 0 ? "\n" : "\n|\n"
    }, StringSplitOptions.RemoveEmptyEntries).Length);
  }

  private void btnNhapWork_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_0, "Nhập danh sách Work", "Danh sách Work", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_0 = form_0.list_0;
    GClass19.smethod_6((Control) this.btnNhapWork, this.list_0.Count);
  }

  private void btnNhapHighSchool_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_1, "Nhập danh sách High School", "Danh sách High School", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_1 = form_0.list_0;
    GClass19.smethod_6((Control) this.btnNhapHighSchool, this.list_1.Count);
  }

  private void btnNhapCollege_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_2, "Nhập danh sách College", "Danh sách College", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_2 = form_0.list_0;
    GClass19.smethod_6((Control) this.btnNhapCollege, this.list_2.Count);
  }

  private void btnNhapCurrentCity_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_3, "Nhập danh sách Current City", "Danh sách Current City", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_3 = form_0.list_0;
    GClass19.smethod_6((Control) this.btnNhapCurrentCity, this.list_3.Count);
  }

  private void ckbHometown_CheckedChanged(object sender, EventArgs e) => this.btnNhapHometown.Enabled = this.ckbHometown.Checked;

  private void btnNhapHometown_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_4, "Nhập danh sách Hometown", "Danh sách Hometown", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_4 = form_0.list_0;
    GClass19.smethod_6((Control) this.btnNhapHometown, this.list_4.Count);
  }

  private void btnDay_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_5, "Nhập danh sách ngày", "Danh sách ngày", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_5 = form_0.list_0;
  }

  private void btnMonth_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_6, "Nhập danh sách tháng", "Danh sách tháng", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_6 = form_0.list_0;
  }

  private void btnYear_Click(object sender, EventArgs e)
  {
    fNhapDuLieu1 form_0 = new fNhapDuLieu1(this.list_7, "Nhập danh sách năm", "Danh sách năm", "(Mỗi nội dung 1 dòng)");
    GClass19.smethod_35((Form) form_0);
    this.list_7 = form_0.list_0;
  }

  private void ckbGender_CheckedChanged(object sender, EventArgs e) => this.cbbGender.Enabled = this.ckbGender.Checked;

  private void ckbBirthday_CheckedChanged(object sender, EventArgs e)
  {
    this.btnDay.Enabled = this.ckbBirthday.Checked;
    this.btnMonth.Enabled = this.ckbBirthday.Checked;
    this.btnYear.Enabled = this.ckbBirthday.Checked;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDCapNhatThongTin));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.btnYear = new Button();
    this.btnMonth = new Button();
    this.btnDay = new Button();
    this.ckbSkipWhenHave = new CheckBox();
    this.cbbGender = new ComboBox();
    this.ckbBirthday = new CheckBox();
    this.cbbRelationship = new ComboBox();
    this.ckbGender = new CheckBox();
    this.ckbRelationship = new CheckBox();
    this.ckbHometown = new CheckBox();
    this.ckbCurrentCity = new CheckBox();
    this.ckbCollege = new CheckBox();
    this.ckbHighSchool = new CheckBox();
    this.ckbWork = new CheckBox();
    this.btnNhapHometown = new Button();
    this.btnNhapCurrentCity = new Button();
    this.btnNhapCollege = new Button();
    this.btnNhapHighSchool = new Button();
    this.btnNhapWork = new Button();
    this.ckbBio = new CheckBox();
    this.btnNhapBio = new Button();
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
    this.bunifuCustomLabel1.Size = new Size(476, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Cập nhật thông tin";
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
    this.pnlHeader.Size = new Size(476, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(445, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.btnYear);
    this.panel1.Controls.Add((Control) this.btnMonth);
    this.panel1.Controls.Add((Control) this.btnDay);
    this.panel1.Controls.Add((Control) this.ckbSkipWhenHave);
    this.panel1.Controls.Add((Control) this.cbbGender);
    this.panel1.Controls.Add((Control) this.ckbBirthday);
    this.panel1.Controls.Add((Control) this.cbbRelationship);
    this.panel1.Controls.Add((Control) this.ckbGender);
    this.panel1.Controls.Add((Control) this.ckbRelationship);
    this.panel1.Controls.Add((Control) this.ckbHometown);
    this.panel1.Controls.Add((Control) this.ckbCurrentCity);
    this.panel1.Controls.Add((Control) this.ckbCollege);
    this.panel1.Controls.Add((Control) this.ckbHighSchool);
    this.panel1.Controls.Add((Control) this.ckbWork);
    this.panel1.Controls.Add((Control) this.btnNhapHometown);
    this.panel1.Controls.Add((Control) this.btnNhapCurrentCity);
    this.panel1.Controls.Add((Control) this.btnNhapCollege);
    this.panel1.Controls.Add((Control) this.btnNhapHighSchool);
    this.panel1.Controls.Add((Control) this.btnNhapWork);
    this.panel1.Controls.Add((Control) this.ckbBio);
    this.panel1.Controls.Add((Control) this.btnNhapBio);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(479, 447);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.btnYear.Cursor = Cursors.Hand;
    this.btnYear.Location = new Point(384, 335);
    this.btnYear.Name = "btnYear";
    this.btnYear.Size = new Size(61, 25);
    this.btnYear.TabIndex = 128;
    this.btnYear.Text = "Năm";
    this.btnYear.UseVisualStyleBackColor = true;
    this.btnYear.Click += new EventHandler(this.btnYear_Click);
    this.btnMonth.Cursor = Cursors.Hand;
    this.btnMonth.Location = new Point(317, 335);
    this.btnMonth.Name = "btnMonth";
    this.btnMonth.Size = new Size(61, 25);
    this.btnMonth.TabIndex = 128;
    this.btnMonth.Text = "Tháng";
    this.btnMonth.UseVisualStyleBackColor = true;
    this.btnMonth.Click += new EventHandler(this.btnMonth_Click);
    this.btnDay.Cursor = Cursors.Hand;
    this.btnDay.Location = new Point(250, 335);
    this.btnDay.Name = "btnDay";
    this.btnDay.Size = new Size(61, 25);
    this.btnDay.TabIndex = 128;
    this.btnDay.Text = "Ngày";
    this.btnDay.UseVisualStyleBackColor = true;
    this.btnDay.Click += new EventHandler(this.btnDay_Click);
    this.ckbSkipWhenHave.AutoSize = true;
    this.ckbSkipWhenHave.Cursor = Cursors.Hand;
    this.ckbSkipWhenHave.Location = new Point(29, 366);
    this.ckbSkipWhenHave.Name = "ckbSkipWhenHave";
    this.ckbSkipWhenHave.Size = new Size(228, 20);
    this.ckbSkipWhenHave.TabIndex = (int) sbyte.MaxValue;
    this.ckbSkipWhenHave.Text = "Không cập nhật thông tin nếu đã có";
    this.ckbSkipWhenHave.UseVisualStyleBackColor = true;
    this.cbbGender.Cursor = Cursors.Hand;
    this.cbbGender.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbGender.FormattingEnabled = true;
    this.cbbGender.Location = new Point(250, 306);
    this.cbbGender.Name = "cbbGender";
    this.cbbGender.Size = new Size(195, 24);
    this.cbbGender.TabIndex = 126;
    this.ckbBirthday.AutoSize = true;
    this.ckbBirthday.Cursor = Cursors.Hand;
    this.ckbBirthday.Location = new Point(29, 338);
    this.ckbBirthday.Name = "ckbBirthday";
    this.ckbBirthday.Size = new Size(141, 20);
    this.ckbBirthday.TabIndex = 125;
    this.ckbBirthday.Text = "Ngày sinh (Birthday)";
    this.ckbBirthday.UseVisualStyleBackColor = true;
    this.ckbBirthday.CheckedChanged += new EventHandler(this.ckbBirthday_CheckedChanged);
    this.cbbRelationship.Cursor = Cursors.Hand;
    this.cbbRelationship.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbRelationship.FormattingEnabled = true;
    this.cbbRelationship.Location = new Point(250, 276);
    this.cbbRelationship.Name = "cbbRelationship";
    this.cbbRelationship.Size = new Size(195, 24);
    this.cbbRelationship.TabIndex = 126;
    this.ckbGender.AutoSize = true;
    this.ckbGender.Cursor = Cursors.Hand;
    this.ckbGender.Location = new Point(29, 308);
    this.ckbGender.Name = "ckbGender";
    this.ckbGender.Size = new Size((int) sbyte.MaxValue, 20);
    this.ckbGender.TabIndex = 125;
    this.ckbGender.Text = "Giới tính (Gender)";
    this.ckbGender.UseVisualStyleBackColor = true;
    this.ckbGender.CheckedChanged += new EventHandler(this.ckbGender_CheckedChanged);
    this.ckbRelationship.AutoSize = true;
    this.ckbRelationship.Cursor = Cursors.Hand;
    this.ckbRelationship.Location = new Point(29, 278);
    this.ckbRelationship.Name = "ckbRelationship";
    this.ckbRelationship.Size = new Size(218, 20);
    this.ckbRelationship.TabIndex = 125;
    this.ckbRelationship.Text = "Tình trạng quan hệ (Relationship)";
    this.ckbRelationship.UseVisualStyleBackColor = true;
    this.ckbRelationship.CheckedChanged += new EventHandler(this.ckbRelationship_CheckedChanged);
    this.ckbHometown.AutoSize = true;
    this.ckbHometown.Cursor = Cursors.Hand;
    this.ckbHometown.Location = new Point(29, 247);
    this.ckbHometown.Name = "ckbHometown";
    this.ckbHometown.Size = new Size(156, 20);
    this.ckbHometown.TabIndex = 125;
    this.ckbHometown.Text = "Quê quán (Hometown)";
    this.ckbHometown.UseVisualStyleBackColor = true;
    this.ckbHometown.CheckedChanged += new EventHandler(this.ckbHometown_CheckedChanged);
    this.ckbCurrentCity.AutoSize = true;
    this.ckbCurrentCity.Cursor = Cursors.Hand;
    this.ckbCurrentCity.Location = new Point(29, 214);
    this.ckbCurrentCity.Name = "ckbCurrentCity";
    this.ckbCurrentCity.Size = new Size(215, 20);
    this.ckbCurrentCity.TabIndex = 125;
    this.ckbCurrentCity.Text = "Thành phố hiện tại (Current City)";
    this.ckbCurrentCity.UseVisualStyleBackColor = true;
    this.ckbCurrentCity.CheckedChanged += new EventHandler(this.ckbCurrentCity_CheckedChanged);
    this.ckbCollege.AutoSize = true;
    this.ckbCollege.Cursor = Cursors.Hand;
    this.ckbCollege.Location = new Point(29, 181);
    this.ckbCollege.Name = "ckbCollege";
    this.ckbCollege.Size = new Size(169, 20);
    this.ckbCollege.TabIndex = 125;
    this.ckbCollege.Text = "Trường đại học (College)";
    this.ckbCollege.UseVisualStyleBackColor = true;
    this.ckbCollege.CheckedChanged += new EventHandler(this.ckbCollege_CheckedChanged);
    this.ckbHighSchool.AutoSize = true;
    this.ckbHighSchool.Cursor = Cursors.Hand;
    this.ckbHighSchool.Location = new Point(29, 148);
    this.ckbHighSchool.Name = "ckbHighSchool";
    this.ckbHighSchool.Size = new Size(207, 20);
    this.ckbHighSchool.TabIndex = 125;
    this.ckbHighSchool.Text = "Trường trung học (High School)";
    this.ckbHighSchool.UseVisualStyleBackColor = true;
    this.ckbHighSchool.CheckedChanged += new EventHandler(this.ckbHighSchool_CheckedChanged);
    this.ckbWork.AutoSize = true;
    this.ckbWork.Cursor = Cursors.Hand;
    this.ckbWork.Location = new Point(29, 115);
    this.ckbWork.Name = "ckbWork";
    this.ckbWork.Size = new Size(125, 20);
    this.ckbWork.TabIndex = 125;
    this.ckbWork.Text = "Công việc (Work)";
    this.ckbWork.UseVisualStyleBackColor = true;
    this.ckbWork.CheckedChanged += new EventHandler(this.ckbWork_CheckedChanged);
    this.btnNhapHometown.Cursor = Cursors.Hand;
    this.btnNhapHometown.Location = new Point(250, 243);
    this.btnNhapHometown.Name = "btnNhapHometown";
    this.btnNhapHometown.Size = new Size(195, 27);
    this.btnNhapHometown.TabIndex = 124;
    this.btnNhapHometown.Text = "Nhập (0)";
    this.btnNhapHometown.UseVisualStyleBackColor = true;
    this.btnNhapHometown.Click += new EventHandler(this.btnNhapHometown_Click);
    this.btnNhapCurrentCity.Cursor = Cursors.Hand;
    this.btnNhapCurrentCity.Location = new Point(250, 210);
    this.btnNhapCurrentCity.Name = "btnNhapCurrentCity";
    this.btnNhapCurrentCity.Size = new Size(195, 27);
    this.btnNhapCurrentCity.TabIndex = 124;
    this.btnNhapCurrentCity.Text = "Nhập (0)";
    this.btnNhapCurrentCity.UseVisualStyleBackColor = true;
    this.btnNhapCurrentCity.Click += new EventHandler(this.btnNhapCurrentCity_Click);
    this.btnNhapCollege.Cursor = Cursors.Hand;
    this.btnNhapCollege.Location = new Point(250, 177);
    this.btnNhapCollege.Name = "btnNhapCollege";
    this.btnNhapCollege.Size = new Size(195, 27);
    this.btnNhapCollege.TabIndex = 124;
    this.btnNhapCollege.Text = "Nhập (0)";
    this.btnNhapCollege.UseVisualStyleBackColor = true;
    this.btnNhapCollege.Click += new EventHandler(this.btnNhapCollege_Click);
    this.btnNhapHighSchool.Cursor = Cursors.Hand;
    this.btnNhapHighSchool.Location = new Point(250, 144);
    this.btnNhapHighSchool.Name = "btnNhapHighSchool";
    this.btnNhapHighSchool.Size = new Size(195, 27);
    this.btnNhapHighSchool.TabIndex = 124;
    this.btnNhapHighSchool.Text = "Nhập (0)";
    this.btnNhapHighSchool.UseVisualStyleBackColor = true;
    this.btnNhapHighSchool.Click += new EventHandler(this.btnNhapHighSchool_Click);
    this.btnNhapWork.Cursor = Cursors.Hand;
    this.btnNhapWork.Location = new Point(250, 111);
    this.btnNhapWork.Name = "btnNhapWork";
    this.btnNhapWork.Size = new Size(195, 27);
    this.btnNhapWork.TabIndex = 124;
    this.btnNhapWork.Text = "Nhập (0)";
    this.btnNhapWork.UseVisualStyleBackColor = true;
    this.btnNhapWork.Click += new EventHandler(this.btnNhapWork_Click);
    this.ckbBio.AutoSize = true;
    this.ckbBio.Cursor = Cursors.Hand;
    this.ckbBio.Location = new Point(29, 82);
    this.ckbBio.Name = "ckbBio";
    this.ckbBio.Size = new Size(191, 20);
    this.ckbBio.TabIndex = 125;
    this.ckbBio.Text = "Tiểu sử mô tả bản thân (Bio)";
    this.ckbBio.UseVisualStyleBackColor = true;
    this.ckbBio.CheckedChanged += new EventHandler(this.ckbBio_CheckedChanged);
    this.btnNhapBio.Cursor = Cursors.Hand;
    this.btnNhapBio.Location = new Point(250, 78);
    this.btnNhapBio.Name = "btnNhapBio";
    this.btnNhapBio.Size = new Size(195, 27);
    this.btnNhapBio.TabIndex = 124;
    this.btnNhapBio.Text = "Nhập (0)";
    this.btnNhapBio.UseVisualStyleBackColor = true;
    this.btnNhapBio.Click += new EventHandler(this.btnNhapBio_Click);
    this.txtTenHanhDong.Location = new Point(125, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(320, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(26, 52);
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
    this.btnCancel.Location = new Point(246, 402);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 7;
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
    this.btnAdd.Location = new Point(139, 402);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 6;
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
    this.bunifuCards1.Size = new Size(476, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(479, 447);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDCapNhatThongTin);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDCapNhatThongTin_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
