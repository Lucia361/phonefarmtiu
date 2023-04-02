// Decompiled with JetBrains decompiler
// Type: fHDBaiVietFanpage
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fHDBaiVietFanpage : Form
{
  private JObject jobject_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private Panel panel1;
  private NumericUpDown nudDelayTo;
  private NumericUpDown nudSoLuongBaiVietTo;
  private NumericUpDown nudDelayFrom;
  private NumericUpDown nudSoLuongBaiVietFrom;
  private TextBox txtTenHanhDong;
  private Label label7;
  private Label label3;
  private Label label6;
  private Label label4;
  private Label label5;
  private Label label1;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private Button button1;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Panel plComment;
  private Label lblStatus;
  private CheckBox ckbComment;
  private CheckBox ckbInteract;
  private CheckBox ckbShareWall;
  private Label label49;
  private NumericUpDown nudSoLuongPageFrom;
  private Label label68;
  private Label label19;
  private NumericUpDown nudSoLuongPageTo;
  private Label label66;
  private Label label2;
  private Label lblStatusUid;
  private RichTextBox txtUid;
  private CheckBox ckbLikePage;
  private Panel panel2;
  private Label label9;
  private NumericUpDown nudViewFrom;
  private Label label10;
  private Label label11;
  private NumericUpDown nudViewTo;
  private CheckBox ckbAutoPlayVideo;
  private RichTextBox txtComment;
  private MetroButton btnDown;
  private MetroButton btnUp;
  private RadioButton rbNganCachKyTu;
  private RadioButton rbNganCachMoiDong;
  private Label label8;
  private Label label12;
  private IContainer components;
  private Button button3;

  public fHDBaiVietFanpage(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDBaiVietFanpage.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string json = "";
    switch (int_1)
    {
      case 0:
        DataTable dataTable1 = Class205.smethod_13(string_1: "HDBaiVietFanpage");
        json = dataTable1.Rows[0]["CauHinh"].ToString();
        this.string_1 = dataTable1.Rows[0]["Id_TuongTac"].ToString();
        this.txtTenHanhDong.Text = GClass35.smethod_0(dataTable1.Rows[0]["MoTa"].ToString());
        break;
      case 1:
        DataTable dataTable2 = Class205.smethod_15(string_4);
        json = dataTable2.Rows[0]["CauHinh"].ToString();
        this.btnAdd.Text = GClass35.smethod_0("Cập nhật");
        this.txtTenHanhDong.Text = dataTable2.Rows[0]["TenHanhDong"].ToString();
        break;
    }
    this.jobject_0 = JObject.Parse(json);
    GClass35.smethod_5((Control) this);
  }

  private void fHDBaiVietFanpage_Load(object sender, EventArgs e)
  {
    try
    {
      this.nudSoLuongPageFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudSoLuongPageFrom"]);
      this.nudSoLuongPageTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudSoLuongPageTo"]);
      this.nudSoLuongBaiVietFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudSoLuongBaiVietFrom"]);
      this.nudSoLuongBaiVietTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudSoLuongBaiVietTo"]);
      this.nudDelayFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudDelayFrom"]);
      this.nudDelayTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudDelayTo"]);
      this.txtUid.Text = this.jobject_0["txtUid"].ToString();
      this.ckbInteract.Checked = Convert.ToBoolean((object) this.jobject_0["ckbInteract"]);
      this.ckbShareWall.Checked = Convert.ToBoolean((object) this.jobject_0["ckbShareWall"]);
      this.ckbComment.Checked = Convert.ToBoolean((object) this.jobject_0["ckbComment"]);
      this.txtComment.Text = this.jobject_0["txtComment"].ToString();
      if (Convert.ToInt32((object) this.jobject_0["typeNganCach"]) == 1)
        this.rbNganCachKyTu.Checked = true;
      else
        this.rbNganCachMoiDong.Checked = true;
      this.ckbLikePage.Checked = Convert.ToBoolean((object) this.jobject_0["ckbLikePage"]);
      this.ckbAutoPlayVideo.Checked = Convert.ToBoolean((object) this.jobject_0["ckbAutoPlayVideo"]);
      this.nudViewFrom.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudViewFrom"]);
      this.nudViewTo.Value = (Decimal) Convert.ToInt32((object) this.jobject_0["nudViewTo"]);
    }
    catch
    {
    }
    this.method_1();
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (this.int_0 == 0)
    {
      if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn thêm hành động mới?")) != DialogResult.Yes)
        return;
      string string_1 = this.txtTenHanhDong.Text.Trim();
      if (string_1 == "")
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
      else if (GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>()).Count == 0)
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách Id page!"), 3);
      else if (this.ckbComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung bình luận!"), 3);
      }
      else
      {
        GClass22 gclass22 = new GClass22();
        gclass22.method_6("nudSoLuongPageFrom", (object) this.nudSoLuongPageFrom.Value);
        gclass22.method_6("nudSoLuongPageTo", (object) this.nudSoLuongPageTo.Value);
        gclass22.method_6("nudSoLuongBaiVietFrom", (object) this.nudSoLuongBaiVietFrom.Value);
        gclass22.method_6("nudSoLuongBaiVietTo", (object) this.nudSoLuongBaiVietTo.Value);
        gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
        gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
        gclass22.method_6("txtUid", (object) this.txtUid.Text.Trim());
        gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
        gclass22.method_6("ckbShareWall", (object) this.ckbShareWall.Checked);
        gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
        gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
        int object_0 = 0;
        if (this.rbNganCachKyTu.Checked)
          object_0 = 1;
        gclass22.method_6("typeNganCach", (object) object_0);
        gclass22.method_6("ckbLikePage", (object) this.ckbLikePage.Checked);
        gclass22.method_6("ckbAutoPlayVideo", (object) this.ckbAutoPlayVideo.Checked);
        gclass22.method_6("nudViewFrom", (object) this.nudViewFrom.Value);
        gclass22.method_6("nudViewTo", (object) this.nudViewTo.Value);
        string string_3 = gclass22.method_11();
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, string_3))
        {
          fHDBaiVietFanpage.bool_0 = true;
          this.Close();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Thêm thất bại, vui lòng thử lại sau!"), 2);
      }
    }
    else
    {
      if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn cập nhật hành động?")) != DialogResult.Yes)
        return;
      string string_1 = this.txtTenHanhDong.Text.Trim();
      if (string_1 == "")
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập tên hành động!"), 3);
      else if (GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>()).Count == 0)
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập danh sách Id page!"), 3);
      else if (this.ckbComment.Checked && GClass19.smethod_39(((IEnumerable<string>) this.txtComment.Lines).ToList<string>()).Count == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung bình luận!"), 3);
      }
      else
      {
        GClass22 gclass22 = new GClass22();
        gclass22.method_6("nudSoLuongPageFrom", (object) this.nudSoLuongPageFrom.Value);
        gclass22.method_6("nudSoLuongPageTo", (object) this.nudSoLuongPageTo.Value);
        gclass22.method_6("nudSoLuongBaiVietFrom", (object) this.nudSoLuongBaiVietFrom.Value);
        gclass22.method_6("nudSoLuongBaiVietTo", (object) this.nudSoLuongBaiVietTo.Value);
        gclass22.method_6("nudDelayFrom", (object) this.nudDelayFrom.Value);
        gclass22.method_6("nudDelayTo", (object) this.nudDelayTo.Value);
        gclass22.method_6("txtUid", (object) this.txtUid.Text.Trim());
        gclass22.method_6("ckbInteract", (object) this.ckbInteract.Checked);
        gclass22.method_6("ckbShareWall", (object) this.ckbShareWall.Checked);
        gclass22.method_6("ckbComment", (object) this.ckbComment.Checked);
        gclass22.method_6("txtComment", (object) this.txtComment.Text.Trim());
        int object_0 = 0;
        if (this.rbNganCachKyTu.Checked)
          object_0 = 1;
        gclass22.method_6("typeNganCach", (object) object_0);
        gclass22.method_6("ckbLikePage", (object) this.ckbLikePage.Checked);
        gclass22.method_6("ckbAutoPlayVideo", (object) this.ckbAutoPlayVideo.Checked);
        gclass22.method_6("nudViewFrom", (object) this.nudViewFrom.Value);
        gclass22.method_6("nudViewTo", (object) this.nudViewTo.Value);
        string string_2 = gclass22.method_11();
        if (Class205.smethod_21(this.string_2, string_1, string_2))
        {
          fHDBaiVietFanpage.bool_0 = true;
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

  private void txtComment_TextChanged(object sender, EventArgs e) => this.method_0();

  private void method_0()
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

  private void method_1()
  {
    this.method_2((object) null, (EventArgs) null);
    this.ckbComment_CheckedChanged((object) null, (EventArgs) null);
    this.ckbAutoPlayVideo_CheckedChanged((object) null, (EventArgs) null);
  }

  private void method_2(object sender, EventArgs e)
  {
  }

  private void ckbComment_CheckedChanged(object sender, EventArgs e) => this.plComment.Enabled = this.ckbComment.Checked;

  private void txtUid_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtUid.Lines).ToList<string>());
      this.lblStatusUid.Text = string.Format(GClass35.smethod_0("Danh sách Uid page cần tương tác ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void ckbAutoPlayVideo_CheckedChanged(object sender, EventArgs e) => this.panel2.Enabled = this.ckbAutoPlayVideo.Checked;

  private void btnDown_Click(object sender, EventArgs e) => this.plComment.Height = 206;

  private void btnUp_Click(object sender, EventArgs e) => this.plComment.Height = 164;

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.btnUp.Visible = true;
    this.btnDown.Visible = true;
  }

  private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e) => this.method_0();

  private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e) => this.method_0();

  private void button3_Click(object sender, EventArgs e) => GClass14.smethod_0((object) GClass35.smethod_0("Có thể dùng [u] để thay thế tên page!"));

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDBaiVietFanpage));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.txtUid = new RichTextBox();
    this.label2 = new Label();
    this.lblStatusUid = new Label();
    this.label49 = new Label();
    this.nudSoLuongPageFrom = new NumericUpDown();
    this.label68 = new Label();
    this.label19 = new Label();
    this.nudSoLuongPageTo = new NumericUpDown();
    this.label66 = new Label();
    this.panel2 = new Panel();
    this.label9 = new Label();
    this.nudViewFrom = new NumericUpDown();
    this.label10 = new Label();
    this.label11 = new Label();
    this.nudViewTo = new NumericUpDown();
    this.plComment = new Panel();
    this.button3 = new Button();
    this.txtComment = new RichTextBox();
    this.btnDown = new MetroButton();
    this.btnUp = new MetroButton();
    this.rbNganCachKyTu = new RadioButton();
    this.rbNganCachMoiDong = new RadioButton();
    this.label8 = new Label();
    this.label12 = new Label();
    this.lblStatus = new Label();
    this.ckbComment = new CheckBox();
    this.ckbShareWall = new CheckBox();
    this.ckbLikePage = new CheckBox();
    this.ckbAutoPlayVideo = new CheckBox();
    this.ckbInteract = new CheckBox();
    this.nudDelayTo = new NumericUpDown();
    this.nudSoLuongBaiVietTo = new NumericUpDown();
    this.nudDelayFrom = new NumericUpDown();
    this.nudSoLuongBaiVietFrom = new NumericUpDown();
    this.txtTenHanhDong = new TextBox();
    this.label7 = new Label();
    this.label3 = new Label();
    this.label6 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.nudSoLuongPageFrom.BeginInit();
    this.nudSoLuongPageTo.BeginInit();
    this.panel2.SuspendLayout();
    this.nudViewFrom.BeginInit();
    this.nudViewTo.BeginInit();
    this.plComment.SuspendLayout();
    this.nudDelayTo.BeginInit();
    this.nudSoLuongBaiVietTo.BeginInit();
    this.nudDelayFrom.BeginInit();
    this.nudSoLuongBaiVietFrom.BeginInit();
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
    this.bunifuCustomLabel1.Size = new Size(680, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Bài viết Fanpage";
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
    this.pnlHeader.Size = new Size(680, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(649, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.txtUid);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.lblStatusUid);
    this.panel1.Controls.Add((Control) this.label49);
    this.panel1.Controls.Add((Control) this.nudSoLuongPageFrom);
    this.panel1.Controls.Add((Control) this.label68);
    this.panel1.Controls.Add((Control) this.label19);
    this.panel1.Controls.Add((Control) this.nudSoLuongPageTo);
    this.panel1.Controls.Add((Control) this.label66);
    this.panel1.Controls.Add((Control) this.panel2);
    this.panel1.Controls.Add((Control) this.plComment);
    this.panel1.Controls.Add((Control) this.ckbComment);
    this.panel1.Controls.Add((Control) this.ckbShareWall);
    this.panel1.Controls.Add((Control) this.ckbLikePage);
    this.panel1.Controls.Add((Control) this.ckbAutoPlayVideo);
    this.panel1.Controls.Add((Control) this.ckbInteract);
    this.panel1.Controls.Add((Control) this.nudDelayTo);
    this.panel1.Controls.Add((Control) this.nudSoLuongBaiVietTo);
    this.panel1.Controls.Add((Control) this.nudDelayFrom);
    this.panel1.Controls.Add((Control) this.nudSoLuongBaiVietFrom);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label6);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(683, 427);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.txtUid.BorderStyle = BorderStyle.FixedSingle;
    this.txtUid.Location = new Point(31, 186);
    this.txtUid.Name = "txtUid";
    this.txtUid.Size = new Size(299, 166);
    this.txtUid.TabIndex = 117;
    this.txtUid.Text = "";
    this.txtUid.WordWrap = false;
    this.txtUid.TextChanged += new EventHandler(this.txtUid_TextChanged);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(28, 356);
    this.label2.Name = "label2";
    this.label2.Size = new Size(102, 16);
    this.label2.TabIndex = 115;
    this.label2.Text = "(Mỗi Uid 1 dòng)";
    this.lblStatusUid.AutoSize = true;
    this.lblStatusUid.Location = new Point(27, 166);
    this.lblStatusUid.Name = "lblStatusUid";
    this.lblStatusUid.Size = new Size(228, 16);
    this.lblStatusUid.TabIndex = 116;
    this.lblStatusUid.Text = "Danh sách Uid page cần tương tác (0):";
    this.label49.AutoSize = true;
    this.label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label49.Location = new Point(27, 81);
    this.label49.Name = "label49";
    this.label49.Size = new Size(95, 16);
    this.label49.TabIndex = 92;
    this.label49.Text = "Số lượng page:";
    this.nudSoLuongPageFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongPageFrom.Location = new Point(135, 79);
    this.nudSoLuongPageFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongPageFrom.Name = "nudSoLuongPageFrom";
    this.nudSoLuongPageFrom.Size = new Size(56, 23);
    this.nudSoLuongPageFrom.TabIndex = 1;
    this.nudSoLuongPageFrom.Value = new Decimal(new int[4]
    {
      5,
      0,
      0,
      0
    });
    this.label68.AutoSize = true;
    this.label68.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label68.Location = new Point(290, 81);
    this.label68.Name = "label68";
    this.label68.Size = new Size(35, 16);
    this.label68.TabIndex = 99;
    this.label68.Text = "page";
    this.label19.AutoSize = true;
    this.label19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label19.Location = new Point(27, 112);
    this.label19.Name = "label19";
    this.label19.Size = new Size(105, 16);
    this.label19.TabIndex = 101;
    this.label19.Text = "Số bài viết/page:";
    this.nudSoLuongPageTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudSoLuongPageTo.Location = new Point(232, 79);
    this.nudSoLuongPageTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongPageTo.Name = "nudSoLuongPageTo";
    this.nudSoLuongPageTo.Size = new Size(56, 23);
    this.nudSoLuongPageTo.TabIndex = 2;
    this.nudSoLuongPageTo.Value = new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.label66.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label66.Location = new Point(197, 81);
    this.label66.Name = "label66";
    this.label66.Size = new Size(29, 16);
    this.label66.TabIndex = 105;
    this.label66.Text = "đến";
    this.label66.TextAlign = ContentAlignment.MiddleCenter;
    this.panel2.BorderStyle = BorderStyle.FixedSingle;
    this.panel2.Controls.Add((Control) this.label9);
    this.panel2.Controls.Add((Control) this.nudViewFrom);
    this.panel2.Controls.Add((Control) this.label10);
    this.panel2.Controls.Add((Control) this.label11);
    this.panel2.Controls.Add((Control) this.nudViewTo);
    this.panel2.Location = new Point(369, 76);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(281, 29);
    this.panel2.TabIndex = 10;
    this.label9.AutoSize = true;
    this.label9.Location = new Point(4, 5);
    this.label9.Name = "label9";
    this.label9.Size = new Size(93, 16);
    this.label9.TabIndex = 0;
    this.label9.Text = "Thời gian xem:";
    this.nudViewFrom.Location = new Point(101, 2);
    this.nudViewFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudViewFrom.Name = "nudViewFrom";
    this.nudViewFrom.Size = new Size(48, 23);
    this.nudViewFrom.TabIndex = 5;
    this.label10.AutoSize = true;
    this.label10.Location = new Point(241, 5);
    this.label10.Name = "label10";
    this.label10.Size = new Size(30, 16);
    this.label10.TabIndex = 36;
    this.label10.Text = "giây";
    this.label11.Location = new Point(155, 4);
    this.label11.Name = "label11";
    this.label11.Size = new Size(29, 16);
    this.label11.TabIndex = 38;
    this.label11.Text = "đến";
    this.label11.TextAlign = ContentAlignment.MiddleCenter;
    this.nudViewTo.Location = new Point(190, 2);
    this.nudViewTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudViewTo.Name = "nudViewTo";
    this.nudViewTo.Size = new Size(48, 23);
    this.nudViewTo.TabIndex = 6;
    this.plComment.BorderStyle = BorderStyle.FixedSingle;
    this.plComment.Controls.Add((Control) this.button3);
    this.plComment.Controls.Add((Control) this.txtComment);
    this.plComment.Controls.Add((Control) this.btnDown);
    this.plComment.Controls.Add((Control) this.btnUp);
    this.plComment.Controls.Add((Control) this.rbNganCachKyTu);
    this.plComment.Controls.Add((Control) this.rbNganCachMoiDong);
    this.plComment.Controls.Add((Control) this.label8);
    this.plComment.Controls.Add((Control) this.label12);
    this.plComment.Controls.Add((Control) this.lblStatus);
    this.plComment.Location = new Point(369, 188);
    this.plComment.Name = "plComment";
    this.plComment.Size = new Size(281, 164);
    this.plComment.TabIndex = 10;
    this.button3.Cursor = Cursors.Help;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.Location = new Point(199, 2);
    this.button3.Name = "button3";
    this.button3.Size = new Size(23, 23);
    this.button3.TabIndex = 166;
    this.button3.Text = "?";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.txtComment.Location = new Point(6, 27);
    this.txtComment.Name = "txtComment";
    this.txtComment.Size = new Size(266, 111);
    this.txtComment.TabIndex = 113;
    this.txtComment.Text = "";
    this.txtComment.WordWrap = false;
    this.txtComment.TextChanged += new EventHandler(this.txtComment_TextChanged);
    this.btnDown.Cursor = Cursors.Hand;
    this.btnDown.Location = new Point(224, -1);
    this.btnDown.Name = "btnDown";
    this.btnDown.Size = new Size(25, 25);
    this.btnDown.TabIndex = 111;
    this.btnDown.UseSelectable = true;
    this.btnDown.Visible = false;
    this.btnDown.Click += new EventHandler(this.btnDown_Click);
    this.btnUp.Cursor = Cursors.Hand;
    this.btnUp.Location = new Point((int) byte.MaxValue, -1);
    this.btnUp.Name = "btnUp";
    this.btnUp.Size = new Size(25, 25);
    this.btnUp.TabIndex = 112;
    this.btnUp.UseSelectable = true;
    this.btnUp.Visible = false;
    this.btnUp.Click += new EventHandler(this.btnUp_Click);
    this.rbNganCachKyTu.AutoSize = true;
    this.rbNganCachKyTu.Cursor = Cursors.Hand;
    this.rbNganCachKyTu.Location = new Point(68, 182);
    this.rbNganCachKyTu.Name = "rbNganCachKyTu";
    this.rbNganCachKyTu.Size = new Size(202, 20);
    this.rbNganCachKyTu.TabIndex = 110;
    this.rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
    this.rbNganCachKyTu.UseVisualStyleBackColor = true;
    this.rbNganCachKyTu.CheckedChanged += new EventHandler(this.rbNganCachKyTu_CheckedChanged);
    this.rbNganCachMoiDong.AutoSize = true;
    this.rbNganCachMoiDong.Checked = true;
    this.rbNganCachMoiDong.Cursor = Cursors.Hand;
    this.rbNganCachMoiDong.Location = new Point(68, 161);
    this.rbNganCachMoiDong.Name = "rbNganCachMoiDong";
    this.rbNganCachMoiDong.Size = new Size(170, 20);
    this.rbNganCachMoiDong.TabIndex = 109;
    this.rbNganCachMoiDong.TabStop = true;
    this.rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
    this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
    this.rbNganCachMoiDong.CheckedChanged += new EventHandler(this.rbNganCachMoiDong_CheckedChanged);
    this.label8.AutoSize = true;
    this.label8.Location = new Point(3, 161);
    this.label8.Name = "label8";
    this.label8.Size = new Size(64, 16);
    this.label8.TabIndex = 108;
    this.label8.Text = "Tùy chọn:";
    this.label12.AutoSize = true;
    this.label12.Location = new Point(3, 141);
    this.label12.Name = "label12";
    this.label12.Size = new Size(265, 16);
    this.label12.TabIndex = 107;
    this.label12.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Location = new Point(3, 5);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(139, 16);
    this.lblStatus.TabIndex = 0;
    this.lblStatus.Text = "Nội dung bình luận (0):";
    this.ckbComment.AutoSize = true;
    this.ckbComment.Cursor = Cursors.Hand;
    this.ckbComment.Location = new Point(351, 163);
    this.ckbComment.Name = "ckbComment";
    this.ckbComment.Size = new Size(175, 20);
    this.ckbComment.TabIndex = 9;
    this.ckbComment.Text = "Tự động bình luận bài viết";
    this.ckbComment.UseVisualStyleBackColor = true;
    this.ckbComment.CheckedChanged += new EventHandler(this.ckbComment_CheckedChanged);
    this.ckbShareWall.AutoSize = true;
    this.ckbShareWall.Cursor = Cursors.Hand;
    this.ckbShareWall.Location = new Point(351, 137);
    this.ckbShareWall.Name = "ckbShareWall";
    this.ckbShareWall.Size = new Size(167, 20);
    this.ckbShareWall.TabIndex = 8;
    this.ckbShareWall.Text = "Chia sẻ bài viết về tường";
    this.ckbShareWall.UseVisualStyleBackColor = true;
    this.ckbLikePage.AutoSize = true;
    this.ckbLikePage.Cursor = Cursors.Hand;
    this.ckbLikePage.Location = new Point(351, 355);
    this.ckbLikePage.Name = "ckbLikePage";
    this.ckbLikePage.Size = new Size(234, 20);
    this.ckbLikePage.TabIndex = 7;
    this.ckbLikePage.Text = "Like Fanpage sau khi tương tác xong";
    this.ckbLikePage.UseVisualStyleBackColor = true;
    this.ckbAutoPlayVideo.AutoSize = true;
    this.ckbAutoPlayVideo.Cursor = Cursors.Hand;
    this.ckbAutoPlayVideo.Location = new Point(351, 50);
    this.ckbAutoPlayVideo.Name = "ckbAutoPlayVideo";
    this.ckbAutoPlayVideo.Size = new Size(285, 20);
    this.ckbAutoPlayVideo.TabIndex = 7;
    this.ckbAutoPlayVideo.Text = "Tự động xem Video (Nếu bài viết chứa video)";
    this.ckbAutoPlayVideo.UseVisualStyleBackColor = true;
    this.ckbAutoPlayVideo.CheckedChanged += new EventHandler(this.ckbAutoPlayVideo_CheckedChanged);
    this.ckbInteract.AutoSize = true;
    this.ckbInteract.Cursor = Cursors.Hand;
    this.ckbInteract.Location = new Point(351, 111);
    this.ckbInteract.Name = "ckbInteract";
    this.ckbInteract.Size = new Size(93, 20);
    this.ckbInteract.TabIndex = 7;
    this.ckbInteract.Text = "Like bài viết";
    this.ckbInteract.UseVisualStyleBackColor = true;
    this.nudDelayTo.Location = new Point(232, 140);
    this.nudDelayTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudDelayTo.Name = "nudDelayTo";
    this.nudDelayTo.Size = new Size(56, 23);
    this.nudDelayTo.TabIndex = 6;
    this.nudSoLuongBaiVietTo.Location = new Point(232, 110);
    this.nudSoLuongBaiVietTo.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
    this.nudSoLuongBaiVietTo.Size = new Size(56, 23);
    this.nudSoLuongBaiVietTo.TabIndex = 4;
    this.nudDelayFrom.Location = new Point(135, 140);
    this.nudDelayFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudDelayFrom.Name = "nudDelayFrom";
    this.nudDelayFrom.Size = new Size(56, 23);
    this.nudDelayFrom.TabIndex = 5;
    this.nudSoLuongBaiVietFrom.Location = new Point(135, 110);
    this.nudSoLuongBaiVietFrom.Maximum = new Decimal(new int[4]
    {
      99999,
      0,
      0,
      0
    });
    this.nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
    this.nudSoLuongBaiVietFrom.Size = new Size(56, 23);
    this.nudSoLuongBaiVietFrom.TabIndex = 3;
    this.txtTenHanhDong.Location = new Point(135, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(195, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label7.Location = new Point(197, 142);
    this.label7.Name = "label7";
    this.label7.Size = new Size(29, 16);
    this.label7.TabIndex = 38;
    this.label7.Text = "đến";
    this.label7.TextAlign = ContentAlignment.MiddleCenter;
    this.label3.Location = new Point(197, 112);
    this.label3.Name = "label3";
    this.label3.Size = new Size(29, 16);
    this.label3.TabIndex = 37;
    this.label3.Text = "đến";
    this.label3.TextAlign = ContentAlignment.MiddleCenter;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(290, 142);
    this.label6.Name = "label6";
    this.label6.Size = new Size(30, 16);
    this.label6.TabIndex = 36;
    this.label6.Text = "giây";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(290, 112);
    this.label4.Name = "label4";
    this.label4.Size = new Size(24, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "bài";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(27, 142);
    this.label5.Name = "label5";
    this.label5.Size = new Size(89, 16);
    this.label5.TabIndex = 34;
    this.label5.Text = "Thời gian chờ:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(27, 52);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 16);
    this.label1.TabIndex = 31;
    this.label1.Text = "Tên hành động:";
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(351, 383);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 12;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(244, 383);
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
    this.bunifuCards1.Size = new Size(680, 37);
    this.bunifuCards1.TabIndex = 28;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(683, 427);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDBaiVietFanpage);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDBaiVietFanpage_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.nudSoLuongPageFrom.EndInit();
    this.nudSoLuongPageTo.EndInit();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.nudViewFrom.EndInit();
    this.nudViewTo.EndInit();
    this.plComment.ResumeLayout(false);
    this.plComment.PerformLayout();
    this.nudDelayTo.EndInit();
    this.nudSoLuongBaiVietTo.EndInit();
    this.nudDelayFrom.EndInit();
    this.nudSoLuongBaiVietFrom.EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
