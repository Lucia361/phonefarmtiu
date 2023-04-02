// Decompiled with JetBrains decompiler
// Type: fHDAddMail
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

public class fHDAddMail : Form
{
  private GClass22 gclass22_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private int int_0;
  public static bool bool_0;
  private List<string> list_0 = new List<string>();
  private List<string> list_1 = new List<string>();
  private List<string> list_2 = new List<string>();
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
  private CheckBox ckbRemoveMail;
  private ToolTip toolTip_0;
  private Panel plAddMail;
  private CheckBox ckbAddMail;
  private Button btnNhapMail;
  private CheckBox ckbSetPrimaryMail;
  private Label label4;
  private ComboBox cbbTypeMail;
  private ComboBox cbbTypeAddMail;
  private IContainer components;
  private Label label3;

  public fHDAddMail(string string_3, int int_1 = 0, string string_4 = "")
  {
    this.InitializeComponent();
    fHDAddMail.bool_0 = false;
    this.string_0 = string_3;
    this.string_2 = string_4;
    this.int_0 = int_1;
    string string_1_1 = this.Name.Substring(1);
    string str = "Add mail";
    if (Class205.smethod_13(string_1: string_1_1).Rows.Count == 0)
      GClass38.GClass38_0.method_2("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + string_1_1 + "', '" + str + "');");
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
    GClass35.smethod_5((Control) this);
  }

  private void fHDAddMail_Load(object sender, EventArgs e)
  {
    try
    {
      this.ckbAddMail.Checked = this.gclass22_0.method_4("ckbAddMail");
      this.cbbTypeAddMail.SelectedIndex = this.gclass22_0.method_3("typeAddMail");
      this.cbbTypeMail.SelectedIndex = this.gclass22_0.method_3("typeMail");
      this.list_0 = this.gclass22_0.method_2("lstHotmail");
      this.list_1 = this.gclass22_0.method_2("lstMailDomain");
      this.list_2 = this.gclass22_0.method_2("lstDomain");
      this.ckbSetPrimaryMail.Checked = this.gclass22_0.method_4("ckbSetPrimaryMail");
      this.ckbRemoveMail.Checked = this.gclass22_0.method_4("ckbRemoveMail");
    }
    catch
    {
    }
    this.ckbSetPrimaryMail_CheckedChanged((object) null, (EventArgs) null);
    this.ckbAddMail_CheckedChanged((object) null, (EventArgs) null);
    this.cbbTypeMail_SelectedIndexChanged((object) null, (EventArgs) null);
    this.method_0();
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

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
      gclass22.method_6("ckbAddMail", (object) this.ckbAddMail.Checked);
      gclass22.method_6("typeAddMail", (object) this.cbbTypeAddMail.SelectedIndex);
      gclass22.method_6("typeMail", (object) this.cbbTypeMail.SelectedIndex);
      gclass22.method_8("lstHotmail", this.list_0);
      gclass22.method_8("lstMailDomain", this.list_1);
      gclass22.method_8("lstDomain", this.list_2);
      gclass22.method_6("ckbSetPrimaryMail", (object) this.ckbSetPrimaryMail.Checked);
      gclass22.method_6("ckbRemoveMail", (object) this.ckbRemoveMail.Checked);
      string str = gclass22.method_11();
      if (this.int_0 == 0)
      {
        if (GClass14.smethod_1("Bạn có muốn thêm hành động mới?") != DialogResult.Yes)
          return;
        if (Class205.smethod_19(this.string_0, string_1, this.string_1, str))
        {
          fHDAddMail.bool_0 = true;
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
          fHDAddMail.bool_0 = true;
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

  private void ckbAddMail_CheckedChanged(object sender, EventArgs e)
  {
    this.plAddMail.Enabled = this.ckbAddMail.Checked;
    if (!this.ckbAddMail.Checked)
    {
      this.ckbRemoveMail.Enabled = true;
    }
    else
    {
      if (!this.ckbSetPrimaryMail.Checked)
        return;
      this.ckbRemoveMail.Checked = true;
      this.ckbRemoveMail.Enabled = false;
    }
  }

  private void btnNhapMail_Click(object sender, EventArgs e)
  {
    switch (this.cbbTypeMail.SelectedIndex)
    {
      case 0:
        fNhapDuLieu1 form_0_1 = new fNhapDuLieu1(this.list_0, "Nhập danh sách hotmail (mail|pass mail)", "Danh sách mail|pass mail", "(Mỗi nội dung 1 dòng)");
        GClass19.smethod_35((Form) form_0_1);
        this.list_0 = form_0_1.list_0;
        GClass19.smethod_6((Control) this.btnNhapMail, this.list_0.Count);
        break;
      case 1:
        fNhapDuLieu1 form_0_2 = new fNhapDuLieu1(this.list_1, "Nhập danh sách link mail domain", "Danh sách link mail domain", "(Mỗi nội dung 1 dòng)");
        GClass19.smethod_35((Form) form_0_2);
        this.list_1 = form_0_2.list_0;
        GClass19.smethod_6((Control) this.btnNhapMail, this.list_1.Count);
        break;
      case 2:
        fNhapDuLieu1 form_0_3 = new fNhapDuLieu1(this.list_2, "Nhập danh sách domain", "Danh sách domain", "(Mỗi nội dung 1 dòng)");
        GClass19.smethod_35((Form) form_0_3);
        this.list_2 = form_0_3.list_0;
        GClass19.smethod_6((Control) this.btnNhapMail, this.list_2.Count);
        break;
    }
  }

  private void ckbSetPrimaryMail_CheckedChanged(object sender, EventArgs e)
  {
    if (this.ckbSetPrimaryMail.Checked)
    {
      this.ckbRemoveMail.Checked = true;
      this.ckbRemoveMail.Enabled = false;
    }
    else
      this.ckbRemoveMail.Enabled = true;
  }

  private void cbbTypeMail_SelectedIndexChanged(object sender, EventArgs e) => this.method_0();

  private void method_0()
  {
    switch (this.cbbTypeMail.SelectedIndex)
    {
      case 0:
        GClass19.smethod_6((Control) this.btnNhapMail, this.list_0.Count);
        break;
      case 1:
        GClass19.smethod_6((Control) this.btnNhapMail, this.list_1.Count);
        break;
      case 2:
        GClass19.smethod_6((Control) this.btnNhapMail, this.list_2.Count);
        break;
    }
  }

  private void plAddMail_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Alt)
      return;
    this.plAddMail.Height = this.plAddMail.Height == 90 ? 58 : 90;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHDAddMail));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.panel1 = new Panel();
    this.plAddMail = new Panel();
    this.cbbTypeMail = new ComboBox();
    this.cbbTypeAddMail = new ComboBox();
    this.btnNhapMail = new Button();
    this.ckbSetPrimaryMail = new CheckBox();
    this.label4 = new Label();
    this.label3 = new Label();
    this.ckbAddMail = new CheckBox();
    this.ckbRemoveMail = new CheckBox();
    this.txtTenHanhDong = new TextBox();
    this.label1 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.toolTip_0 = new ToolTip(this.components);
    this.pnlHeader.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plAddMail.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(363, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình Add Mail";
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
    this.pnlHeader.Size = new Size(363, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(332, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.plAddMail);
    this.panel1.Controls.Add((Control) this.ckbAddMail);
    this.panel1.Controls.Add((Control) this.ckbRemoveMail);
    this.panel1.Controls.Add((Control) this.txtTenHanhDong);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Cursor = Cursors.Arrow;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(366, 235);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.plAddMail.BorderStyle = BorderStyle.FixedSingle;
    this.plAddMail.Controls.Add((Control) this.cbbTypeMail);
    this.plAddMail.Controls.Add((Control) this.cbbTypeAddMail);
    this.plAddMail.Controls.Add((Control) this.btnNhapMail);
    this.plAddMail.Controls.Add((Control) this.ckbSetPrimaryMail);
    this.plAddMail.Controls.Add((Control) this.label4);
    this.plAddMail.Controls.Add((Control) this.label3);
    this.plAddMail.Location = new Point(41, 98);
    this.plAddMail.Name = "plAddMail";
    this.plAddMail.Size = new Size(300, 58);
    this.plAddMail.TabIndex = 115;
    this.plAddMail.Click += new EventHandler(this.plAddMail_Click);
    this.cbbTypeMail.Cursor = Cursors.Hand;
    this.cbbTypeMail.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbTypeMail.DropDownWidth = 200;
    this.cbbTypeMail.FormattingEnabled = true;
    this.cbbTypeMail.Items.AddRange(new object[3]
    {
      (object) "Hotmail",
      (object) "Mail domain",
      (object) "https://generator.email/"
    });
    this.cbbTypeMail.Location = new Point(83, 6);
    this.cbbTypeMail.Name = "cbbTypeMail";
    this.cbbTypeMail.Size = new Size(121, 24);
    this.cbbTypeMail.TabIndex = 118;
    this.cbbTypeMail.SelectedIndexChanged += new EventHandler(this.cbbTypeMail_SelectedIndexChanged);
    this.cbbTypeAddMail.Cursor = Cursors.Hand;
    this.cbbTypeAddMail.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbTypeAddMail.FormattingEnabled = true;
    this.cbbTypeAddMail.Items.AddRange(new object[2]
    {
      (object) "Add mail bình thường",
      (object) "Tut không cần pass"
    });
    this.cbbTypeAddMail.Location = new Point(76, 58);
    this.cbbTypeAddMail.Name = "cbbTypeAddMail";
    this.cbbTypeAddMail.Size = new Size(213, 24);
    this.cbbTypeAddMail.TabIndex = 118;
    this.btnNhapMail.Cursor = Cursors.Hand;
    this.btnNhapMail.Location = new Point(209, 5);
    this.btnNhapMail.Name = "btnNhapMail";
    this.btnNhapMail.Size = new Size(86, 27);
    this.btnNhapMail.TabIndex = 116;
    this.btnNhapMail.Text = "Nhập (0)";
    this.btnNhapMail.UseVisualStyleBackColor = true;
    this.btnNhapMail.Click += new EventHandler(this.btnNhapMail_Click);
    this.ckbSetPrimaryMail.AutoSize = true;
    this.ckbSetPrimaryMail.Cursor = Cursors.Hand;
    this.ckbSetPrimaryMail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbSetPrimaryMail.Location = new Point(10, 34);
    this.ckbSetPrimaryMail.Name = "ckbSetPrimaryMail";
    this.ckbSetPrimaryMail.Size = new Size(181, 20);
    this.ckbSetPrimaryMail.TabIndex = 113;
    this.ckbSetPrimaryMail.Text = "Set mail mới lên mail chính";
    this.ckbSetPrimaryMail.UseVisualStyleBackColor = true;
    this.ckbSetPrimaryMail.CheckedChanged += new EventHandler(this.ckbSetPrimaryMail_CheckedChanged);
    this.label4.AutoSize = true;
    this.label4.Location = new Point(7, 9);
    this.label4.Name = "label4";
    this.label4.Size = new Size(63, 16);
    this.label4.TabIndex = 31;
    this.label4.Text = "Loại mail:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(7, 61);
    this.label3.Name = "label3";
    this.label3.Size = new Size(64, 16);
    this.label3.TabIndex = 31;
    this.label3.Text = "Tùy chọn:";
    this.ckbAddMail.AutoSize = true;
    this.ckbAddMail.Cursor = Cursors.Hand;
    this.ckbAddMail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbAddMail.Location = new Point(23, 75);
    this.ckbAddMail.Name = "ckbAddMail";
    this.ckbAddMail.Size = new Size(75, 20);
    this.ckbAddMail.TabIndex = 113;
    this.ckbAddMail.Text = "Add Mail";
    this.ckbAddMail.UseVisualStyleBackColor = true;
    this.ckbAddMail.CheckedChanged += new EventHandler(this.ckbAddMail_CheckedChanged);
    this.ckbRemoveMail.AutoSize = true;
    this.ckbRemoveMail.Cursor = Cursors.Hand;
    this.ckbRemoveMail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.ckbRemoveMail.Location = new Point(23, 162);
    this.ckbRemoveMail.Name = "ckbRemoveMail";
    this.ckbRemoveMail.Size = new Size(101, 20);
    this.ckbRemoveMail.TabIndex = 113;
    this.ckbRemoveMail.Text = "Xóa mail phụ";
    this.ckbRemoveMail.UseVisualStyleBackColor = true;
    this.txtTenHanhDong.Location = new Point(125, 49);
    this.txtTenHanhDong.Name = "txtTenHanhDong";
    this.txtTenHanhDong.Size = new Size(216, 23);
    this.txtTenHanhDong.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(20, 52);
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
    this.btnCancel.Location = new Point(193, 192);
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
    this.btnAdd.Location = new Point(86, 192);
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
    this.bunifuCards1.Size = new Size(363, 37);
    this.bunifuCards1.TabIndex = 28;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 0;
    this.toolTip_0.InitialDelay = 0;
    this.toolTip_0.ReshowDelay = 0;
    this.toolTip_0.ShowAlways = true;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(366, 235);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHDAddMail);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fHDAddMail_Load);
    this.pnlHeader.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plAddMail.ResumeLayout(false);
    this.plAddMail.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
