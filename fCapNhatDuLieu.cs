// Decompiled with JetBrains decompiler
// Type: fCapNhatDuLieu
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class fCapNhatDuLieu : Form
{
  public static bool bool_0;
  private List<ComboBox> list_0;
  private List<string> list_1 = new List<string>();
  private List<string> list_2 = new List<string>();
  private List<string> list_3 = new List<string>();
  private IContainer icontainer_0 = (IContainer) null;
  private Button btnAdd;
  private Button btnCancel;
  private Label label8;
  private ComboBox cbbDinhDangNhap;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private RichTextBox txbAccount;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Panel pnlHeader;
  private BunifuCards bunifuCards1;
  private ContextMenuStrip ctmsAcc;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem toolStripMenuItem_4;
  private ToolStripMenuItem toolStripMenuItem2;
  private ToolStripMenuItem toolStripMenuItem_5;
  private ToolStripMenuItem toolStripMenuItem_6;
  private ToolStripMenuItem toolStripMenuItem_7;
  private Label label3;
  private Label lblSuccess;
  private Label lblError;
  private Label lblTotal;
  private Label label4;
  private Label label7;
  private Label lblStatus;
  private PictureBox pictureBox1;
  private Button btnMinimize;
  private Panel plDinhDangNhap;
  private Label label1;
  private ComboBox cbbDinhDang1;
  private ComboBox cbbDinhDang2;
  private ComboBox cbbDinhDang3;
  private ComboBox cbbDinhDang4;
  private Label label14;
  private ComboBox cbbDinhDang5;
  private Label label17;
  private ComboBox cbbDinhDang8;
  private Label label13;
  private ComboBox cbbDinhDang6;
  private Label label12;
  private ComboBox cbbDinhDang7;
  private Label label11;
  private Label label9;
  private Label label10;
  private ComboBox cbbTypeProxy;
  private Label label2;
  private Label label5;
  private ComboBox cbbDinhDang9;
  private Label label15;
  private ComboBox cbbDinhDang11;
  private Label label6;
  private ComboBox cbbDinhDang10;
  private Label label16;
  private IContainer components;
  private ComboBox cbbDinhDang12;

  public fCapNhatDuLieu()
  {
    this.InitializeComponent();
    this.cbbDinhDangNhap.SelectedIndex = 0;
    this.list_0 = new List<ComboBox>()
    {
      this.cbbDinhDang1,
      this.cbbDinhDang2,
      this.cbbDinhDang3,
      this.cbbDinhDang4,
      this.cbbDinhDang5,
      this.cbbDinhDang6,
      this.cbbDinhDang7,
      this.cbbDinhDang8,
      this.cbbDinhDang9,
      this.cbbDinhDang10,
      this.cbbDinhDang11,
      this.cbbDinhDang12
    };
    fCapNhatDuLieu.bool_0 = false;
    GClass35.smethod_5((Control) this);
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.label4);
    GClass35.smethod_1((Control) this.label7);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    this.list_2 = new List<string>();
    this.list_3 = new List<string>();
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txbAccount.Lines).ToList<string>());
      if (stringList.Count == 0)
      {
        GClass14.smethod_0((object) "Vui lòng nhập thông tin tài khoản!");
        this.txbAccount.Focus();
      }
      else
      {
        int selectedIndex = this.cbbDinhDangNhap.SelectedIndex;
        if (selectedIndex == 5)
        {
          bool flag = false;
          for (int index = 0; index < this.list_0.Count; ++index)
          {
            if (this.list_0[index].SelectedIndex > -1)
            {
              flag = true;
              break;
            }
          }
          if (!flag)
          {
            GClass14.smethod_0((object) "Vui lòng chọn định dạng tài khoản!");
            return;
          }
        }
        this.lblSuccess.Text = "0";
        this.lblError.Text = "0";
        this.list_1 = new List<string>();
        for (int index1 = 0; index1 < stringList.Count; ++index1)
        {
          string str1 = "";
          string str2 = "";
          string str3 = "";
          string str4 = "";
          string str5 = "";
          string str6 = "";
          string str7 = "";
          string str8 = "";
          string str9 = "";
          string str10 = "";
          string str11 = "";
          string str12 = "";
          string str13 = "";
          string str14 = "";
          string str15 = "";
          try
          {
            string[] strArray = stringList[index1].Split('|');
            switch (selectedIndex)
            {
              case 0:
                str1 = strArray[0];
                str2 = strArray[1];
                break;
              case 1:
                str1 = strArray[0];
                str2 = strArray[1];
                str7 = strArray[2];
                break;
              case 2:
                str1 = strArray[0];
                str2 = strArray[1];
                str3 = strArray[2];
                str4 = strArray[3];
                break;
              case 3:
                str1 = strArray[0];
                str2 = strArray[1];
                str3 = strArray[2];
                str4 = strArray[3];
                str5 = strArray[4];
                str6 = strArray[5];
                break;
              case 4:
                str1 = strArray[0];
                str2 = strArray[1];
                str3 = strArray[2];
                str4 = strArray[3];
                str5 = strArray[4];
                str6 = strArray[5];
                str7 = strArray[6];
                break;
              case 5:
                str1 = strArray[0];
                for (int index2 = 1; index2 < this.list_0.Count; ++index2)
                {
                  switch (this.list_0[index2 - 1].SelectedIndex)
                  {
                    case 0:
                      str1 = strArray[index2];
                      break;
                    case 1:
                      str2 = strArray[index2];
                      break;
                    case 2:
                      str3 = strArray[index2];
                      break;
                    case 3:
                      str4 = strArray[index2];
                      break;
                    case 4:
                      str5 = strArray[index2];
                      break;
                    case 5:
                      str6 = strArray[index2];
                      break;
                    case 6:
                      str7 = strArray[index2];
                      break;
                    case 7:
                      str8 = strArray[index2];
                      break;
                    case 8:
                      str9 = strArray[index2] == "" ? "" : strArray[index2] + "*" + this.cbbTypeProxy.SelectedIndex.ToString();
                      break;
                    case 9:
                      str10 = strArray[index2];
                      break;
                    case 10:
                      str11 = strArray[index2];
                      break;
                    case 11:
                      str12 = strArray[index2];
                      break;
                    case 12:
                      str13 = strArray[index2];
                      break;
                    case 13:
                      str14 = strArray[index2];
                      break;
                    case 14:
                      str15 = strArray[index2];
                      break;
                  }
                }
                break;
            }
            this.list_1.Add(str1 + "|" + str2 + "|" + str3 + "|" + str4 + "|" + str5 + "|" + str6 + "|" + str7 + "|" + str8 + "|" + str9 + "|" + str10 + "|" + str11 + "|" + str12 + "|" + str13 + "|" + str14 + "|" + str15);
            this.list_2.Add(stringList[index1]);
          }
          catch
          {
            this.method_2(this.lblError);
            this.list_3.Add(stringList[index1]);
          }
        }
        this.btnAdd.Invoke((Delegate) (() => this.btnAdd.Enabled = false));
        this.method_1("Đang cập nhật dữ liệu...");
        for (int index = 0; index < this.list_1.Count; ++index)
        {
          if (Class42.smethod_26(this.list_1[index]))
            this.method_2(this.lblSuccess);
          else
            this.method_2(this.lblError);
        }
        this.btnAdd.Invoke((Delegate) (() => this.btnAdd.Enabled = true));
        this.list_2.AddRange((IEnumerable<string>) this.list_3);
        this.txbAccount.Lines = this.list_2.ToArray();
        this.method_1(GClass35.smethod_0("Cập nhật dữ liệu xong!"));
        GClass14.smethod_0((object) "Cập nhật dữ liệu xong!");
        fCapNhatDuLieu.bool_0 = true;
      }
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) "Đã có lỗi xảy ra, vui lòng thử lại sau!");
      GClass19.smethod_81(ex, "UpdateAccount");
    }
  }

  private void method_1(string string_0)
  {
    Application.DoEvents();
    this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Text = string_0));
  }

  private void txbAccount_TextChanged(object sender, EventArgs e)
  {
    try
    {
      this.lblTotal.Text = GClass19.smethod_39(((IEnumerable<string>) this.txbAccount.Lines).ToList<string>()).Count.ToString();
    }
    catch
    {
    }
  }

  private void method_2(Label label_0)
  {
    Application.DoEvents();
    lock (label_0)
      label_0.Invoke((Delegate) (() => label_0.Text = (Convert.ToInt32(label_0.Text) + 1).ToString()));
  }

  private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e) => this.plDinhDangNhap.Visible = this.cbbDinhDangNhap.SelectedIndex == this.cbbDinhDangNhap.Items.Count - 1;

  private bool method_3()
  {
    bool flag = false;
    List<int> intList = new List<int>();
    for (int index = 0; index <= 6; ++index)
    {
      int selectedIndex = this.list_0[index].SelectedIndex;
      if (selectedIndex != -1)
      {
        if (intList.Contains(selectedIndex))
        {
          flag = true;
          break;
        }
        intList.Add(selectedIndex);
      }
    }
    return flag;
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void cbbDinhDang7_SelectedIndexChanged(object sender, EventArgs e)
  {
    bool flag = false;
    for (int index = 0; index < this.list_0.Count; ++index)
    {
      if (this.list_0[index].Text == "Proxy")
      {
        flag = true;
        break;
      }
    }
    this.label2.Visible = flag;
    this.cbbTypeProxy.Visible = flag;
  }

  private void fCapNhatDuLieu_Load(object sender, EventArgs e)
  {
    foreach (ComboBox comboBox_0 in this.list_0)
    {
      GClass19.smethod_116(comboBox_0, new List<string>()
      {
        "Uid",
        "Pass",
        "Token",
        "Cookie",
        "Email",
        "Pass Email",
        "2FA",
        "Useragent",
        "Proxy",
        "Ngày sinh",
        "Bạn bè",
        "Ngày tạo",
        "Mail khôi phục",
        "Ghi chú",
        "Tương tác cuối"
      });
      comboBox_0.SelectedIndex = -1;
      comboBox_0.DropDownWidth = 100;
    }
    this.cbbTypeProxy.SelectedIndex = 0;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCapNhatDuLieu));
    this.btnAdd = new Button();
    this.btnCancel = new Button();
    this.label8 = new Label();
    this.cbbDinhDangNhap = new ComboBox();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.pictureBox1 = new PictureBox();
    this.btnMinimize = new Button();
    this.txbAccount = new RichTextBox();
    this.bunifuCards1 = new BunifuCards();
    this.ctmsAcc = new ContextMenuStrip(this.components);
    this.toolStripMenuItem_0 = new ToolStripMenuItem();
    this.toolStripMenuItem_1 = new ToolStripMenuItem();
    this.toolStripMenuItem_2 = new ToolStripMenuItem();
    this.toolStripMenuItem_3 = new ToolStripMenuItem();
    this.toolStripMenuItem_4 = new ToolStripMenuItem();
    this.toolStripMenuItem2 = new ToolStripMenuItem();
    this.toolStripMenuItem_5 = new ToolStripMenuItem();
    this.toolStripMenuItem_6 = new ToolStripMenuItem();
    this.toolStripMenuItem_7 = new ToolStripMenuItem();
    this.label3 = new Label();
    this.lblSuccess = new Label();
    this.lblError = new Label();
    this.lblTotal = new Label();
    this.label4 = new Label();
    this.label7 = new Label();
    this.lblStatus = new Label();
    this.plDinhDangNhap = new Panel();
    this.label16 = new Label();
    this.label15 = new Label();
    this.label5 = new Label();
    this.cbbDinhDang12 = new ComboBox();
    this.cbbDinhDang11 = new ComboBox();
    this.cbbDinhDang9 = new ComboBox();
    this.cbbTypeProxy = new ComboBox();
    this.label2 = new Label();
    this.label1 = new Label();
    this.cbbDinhDang1 = new ComboBox();
    this.cbbDinhDang2 = new ComboBox();
    this.cbbDinhDang3 = new ComboBox();
    this.cbbDinhDang4 = new ComboBox();
    this.label14 = new Label();
    this.cbbDinhDang5 = new ComboBox();
    this.label6 = new Label();
    this.label17 = new Label();
    this.cbbDinhDang10 = new ComboBox();
    this.cbbDinhDang8 = new ComboBox();
    this.label13 = new Label();
    this.cbbDinhDang6 = new ComboBox();
    this.label12 = new Label();
    this.cbbDinhDang7 = new ComboBox();
    this.label11 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.pnlHeader.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.bunifuCards1.SuspendLayout();
    this.ctmsAcc.SuspendLayout();
    this.plDinhDangNhap.SuspendLayout();
    this.SuspendLayout();
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(482, 460);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(97, 31);
    this.btnAdd.TabIndex = 13;
    this.btnAdd.Text = "Lưu";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(599, 460);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(97, 31);
    this.btnCancel.TabIndex = 14;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.label8.Location = new Point(9, 367);
    this.label8.Name = "label8";
    this.label8.Size = new Size(97, 14);
    this.label8.TabIndex = 39;
    this.label8.Text = "Chọn định dạng:";
    this.label8.TextAlign = ContentAlignment.MiddleRight;
    this.cbbDinhDangNhap.Cursor = Cursors.Hand;
    this.cbbDinhDangNhap.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDangNhap.FormattingEnabled = true;
    this.cbbDinhDangNhap.Items.AddRange(new object[6]
    {
      (object) "Uid|Pass",
      (object) "Uid|Pass|2FA",
      (object) "Uid|Pass|Token|Cookie",
      (object) "Uid|Pass|Token|Cookie|Email|Pass Email",
      (object) "Uid|Pass|Token|Cookie|Email|Pass Email|2FA",
      (object) "Other..."
    });
    this.cbbDinhDangNhap.Location = new Point(112, 364);
    this.cbbDinhDangNhap.Name = "cbbDinhDangNhap";
    this.cbbDinhDangNhap.Size = new Size(269, 22);
    this.cbbDinhDangNhap.TabIndex = 40;
    this.cbbDinhDangNhap.SelectedIndexChanged += new EventHandler(this.cbbDinhDangNhap_SelectedIndexChanged);
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
    this.bunifuCustomLabel1.Size = new Size(1179, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.pictureBox1);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(1179, 31);
    this.pnlHeader.TabIndex = 9;
    this.pictureBox1.Cursor = Cursors.Default;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(-156, 2);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(34, 27);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    this.pictureBox1.TabIndex = 78;
    this.pictureBox1.TabStop = false;
    this.btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(1147, 1);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(30, 30);
    this.btnMinimize.TabIndex = 77;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.txbAccount.BorderStyle = BorderStyle.FixedSingle;
    this.txbAccount.Location = new Point(12, 77);
    this.txbAccount.Name = "txbAccount";
    this.txbAccount.Size = new Size(1147, 277);
    this.txbAccount.TabIndex = 48;
    this.txbAccount.Text = "";
    this.txbAccount.WordWrap = false;
    this.txbAccount.TextChanged += new EventHandler(this.txbAccount_TextChanged);
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.DarkViolet;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.Dock = DockStyle.Top;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(1179, 37);
    this.bunifuCards1.TabIndex = 49;
    this.ctmsAcc.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ctmsAcc.Items.AddRange(new ToolStripItem[5]
    {
      (ToolStripItem) this.toolStripMenuItem_0,
      (ToolStripItem) this.toolStripMenuItem2,
      (ToolStripItem) this.toolStripMenuItem_5,
      (ToolStripItem) this.toolStripMenuItem_6,
      (ToolStripItem) this.toolStripMenuItem_7
    });
    this.ctmsAcc.Name = "ctmsAcc";
    this.ctmsAcc.Size = new Size(179, 114);
    this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.toolStripMenuItem_1,
      (ToolStripItem) this.toolStripMenuItem_2,
      (ToolStripItem) this.toolStripMenuItem_3,
      (ToolStripItem) this.toolStripMenuItem_4
    });
    this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
    this.toolStripMenuItem_0.Size = new Size(178, 22);
    this.toolStripMenuItem_0.Text = "Chọn";
    this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
    this.toolStripMenuItem_1.Size = new Size(143, 22);
    this.toolStripMenuItem_1.Text = "Tất cả";
    this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
    this.toolStripMenuItem_2.Size = new Size(143, 22);
    this.toolStripMenuItem_2.Text = "Bôi đen";
    this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
    this.toolStripMenuItem_3.Size = new Size(143, 22);
    this.toolStripMenuItem_3.Text = "Tài khoản=0";
    this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
    this.toolStripMenuItem_4.Size = new Size(143, 22);
    this.toolStripMenuItem_4.Text = "Tài khoản=1";
    this.toolStripMenuItem2.Name = "toolStripMenuItem2";
    this.toolStripMenuItem2.Size = new Size(178, 22);
    this.toolStripMenuItem2.Text = "Bỏ chọn tất cả";
    this.toolStripMenuItem_5.Name = "toolStripMenuItem_5";
    this.toolStripMenuItem_5.Size = new Size(178, 22);
    this.toolStripMenuItem_5.Text = "Tạo thiết bị";
    this.toolStripMenuItem_6.Name = "toolStripMenuItem_6";
    this.toolStripMenuItem_6.Size = new Size(178, 22);
    this.toolStripMenuItem_6.Text = "Xóa thiết bị";
    this.toolStripMenuItem_7.Name = "toolStripMenuItem_7";
    this.toolStripMenuItem_7.Size = new Size(178, 22);
    this.toolStripMenuItem_7.Text = "Làm mới danh sách";
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label3.Location = new Point(704, 58);
    this.label3.Name = "label3";
    this.label3.Size = new Size(87, 16);
    this.label3.TabIndex = 55;
    this.label3.Text = "Thành công:";
    this.label3.TextAlign = ContentAlignment.MiddleRight;
    this.lblSuccess.AutoSize = true;
    this.lblSuccess.BackColor = SystemColors.Control;
    this.lblSuccess.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblSuccess.ForeColor = Color.FromArgb(53, 120, 229);
    this.lblSuccess.Location = new Point(787, 55);
    this.lblSuccess.Name = "lblSuccess";
    this.lblSuccess.Size = new Size(19, 19);
    this.lblSuccess.TabIndex = 50;
    this.lblSuccess.Text = "0";
    this.lblError.AutoSize = true;
    this.lblError.BackColor = SystemColors.Control;
    this.lblError.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblError.ForeColor = Color.FromArgb(192, 64, 0);
    this.lblError.Location = new Point(910, 55);
    this.lblError.Name = "lblError";
    this.lblError.Size = new Size(19, 19);
    this.lblError.TabIndex = 51;
    this.lblError.Text = "0";
    this.lblTotal.AutoSize = true;
    this.lblTotal.BackColor = SystemColors.Control;
    this.lblTotal.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTotal.ForeColor = Color.Teal;
    this.lblTotal.Location = new Point(1070, 56);
    this.lblTotal.Name = "lblTotal";
    this.lblTotal.Size = new Size(19, 19);
    this.lblTotal.TabIndex = 53;
    this.lblTotal.Text = "0";
    this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label4.Location = new Point(861, 58);
    this.label4.Name = "label4";
    this.label4.Size = new Size(52, 16);
    this.label4.TabIndex = 56;
    this.label4.Text = "Lỗi:";
    this.label4.TextAlign = ContentAlignment.MiddleRight;
    this.label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label7.Location = new Point(1010, 58);
    this.label7.Name = "label7";
    this.label7.Size = new Size(63, 16);
    this.label7.TabIndex = 59;
    this.label7.Text = "Tổng số:";
    this.label7.TextAlign = ContentAlignment.MiddleRight;
    this.lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.ForeColor = Color.DarkGreen;
    this.lblStatus.Location = new Point(12, 44);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(227, 28);
    this.lblStatus.TabIndex = 60;
    this.lblStatus.Text = "Nhập thông tin tài khoản:";
    this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;
    this.plDinhDangNhap.Controls.Add((Control) this.label16);
    this.plDinhDangNhap.Controls.Add((Control) this.label15);
    this.plDinhDangNhap.Controls.Add((Control) this.label5);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang12);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang11);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang9);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbTypeProxy);
    this.plDinhDangNhap.Controls.Add((Control) this.label2);
    this.plDinhDangNhap.Controls.Add((Control) this.label1);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang1);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang2);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang3);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang4);
    this.plDinhDangNhap.Controls.Add((Control) this.label14);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang5);
    this.plDinhDangNhap.Controls.Add((Control) this.label6);
    this.plDinhDangNhap.Controls.Add((Control) this.label17);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang10);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang8);
    this.plDinhDangNhap.Controls.Add((Control) this.label13);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang6);
    this.plDinhDangNhap.Controls.Add((Control) this.label12);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang7);
    this.plDinhDangNhap.Controls.Add((Control) this.label11);
    this.plDinhDangNhap.Controls.Add((Control) this.label9);
    this.plDinhDangNhap.Controls.Add((Control) this.label10);
    this.plDinhDangNhap.Location = new Point(12, 392);
    this.plDinhDangNhap.Name = "plDinhDangNhap";
    this.plDinhDangNhap.Size = new Size(1157, 62);
    this.plDinhDangNhap.TabIndex = 61;
    this.plDinhDangNhap.Paint += new PaintEventHandler(this.plDinhDangNhap_Paint);
    this.label16.AutoSize = true;
    this.label16.Font = new Font("Tahoma", 12f);
    this.label16.Location = new Point(1057, 7);
    this.label16.Name = "label16";
    this.label16.Size = new Size(15, 19);
    this.label16.TabIndex = 128;
    this.label16.Text = "|";
    this.label15.AutoSize = true;
    this.label15.Font = new Font("Tahoma", 12f);
    this.label15.Location = new Point(961, 6);
    this.label15.Name = "label15";
    this.label15.Size = new Size(15, 19);
    this.label15.TabIndex = 128;
    this.label15.Text = "|";
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Tahoma", 12f);
    this.label5.Location = new Point(774, 4);
    this.label5.Name = "label5";
    this.label5.Size = new Size(15, 19);
    this.label5.TabIndex = 128;
    this.label5.Text = "|";
    this.cbbDinhDang12.Cursor = Cursors.Hand;
    this.cbbDinhDang12.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang12.FormattingEnabled = true;
    this.cbbDinhDang12.Location = new Point(1072, 7);
    this.cbbDinhDang12.Name = "cbbDinhDang12";
    this.cbbDinhDang12.Size = new Size(78, 22);
    this.cbbDinhDang12.TabIndex = (int) sbyte.MaxValue;
    this.cbbDinhDang11.Cursor = Cursors.Hand;
    this.cbbDinhDang11.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang11.FormattingEnabled = true;
    this.cbbDinhDang11.Location = new Point(976, 6);
    this.cbbDinhDang11.Name = "cbbDinhDang11";
    this.cbbDinhDang11.Size = new Size(78, 22);
    this.cbbDinhDang11.TabIndex = (int) sbyte.MaxValue;
    this.cbbDinhDang9.Cursor = Cursors.Hand;
    this.cbbDinhDang9.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang9.FormattingEnabled = true;
    this.cbbDinhDang9.Location = new Point(789, 4);
    this.cbbDinhDang9.Name = "cbbDinhDang9";
    this.cbbDinhDang9.Size = new Size(78, 22);
    this.cbbDinhDang9.TabIndex = (int) sbyte.MaxValue;
    this.cbbTypeProxy.Cursor = Cursors.Hand;
    this.cbbTypeProxy.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbTypeProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbTypeProxy.FormattingEnabled = true;
    this.cbbTypeProxy.Items.AddRange(new object[2]
    {
      (object) "HTTP",
      (object) "Sock5"
    });
    this.cbbTypeProxy.Location = new Point(85, 33);
    this.cbbTypeProxy.Name = "cbbTypeProxy";
    this.cbbTypeProxy.Size = new Size(130, 24);
    this.cbbTypeProxy.TabIndex = 126;
    this.cbbTypeProxy.Visible = false;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.Location = new Point(7, 36);
    this.label2.Name = "label2";
    this.label2.Size = new Size(70, 16);
    this.label2.TabIndex = 125;
    this.label2.Text = "Loại proxy:";
    this.label2.Visible = false;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 12f);
    this.label1.Location = new Point(5, 3);
    this.label1.Name = "label1";
    this.label1.Size = new Size(39, 19);
    this.label1.TabIndex = 42;
    this.label1.Text = "Uid|";
    this.cbbDinhDang1.Cursor = Cursors.Hand;
    this.cbbDinhDang1.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang1.FormattingEnabled = true;
    this.cbbDinhDang1.Location = new Point(44, 3);
    this.cbbDinhDang1.Name = "cbbDinhDang1";
    this.cbbDinhDang1.Size = new Size(78, 22);
    this.cbbDinhDang1.TabIndex = 40;
    this.cbbDinhDang1.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.cbbDinhDang2.Cursor = Cursors.Hand;
    this.cbbDinhDang2.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang2.FormattingEnabled = true;
    this.cbbDinhDang2.Location = new Point(137, 3);
    this.cbbDinhDang2.Name = "cbbDinhDang2";
    this.cbbDinhDang2.Size = new Size(78, 22);
    this.cbbDinhDang2.TabIndex = 40;
    this.cbbDinhDang2.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.cbbDinhDang3.Cursor = Cursors.Hand;
    this.cbbDinhDang3.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang3.FormattingEnabled = true;
    this.cbbDinhDang3.Location = new Point(230, 3);
    this.cbbDinhDang3.Name = "cbbDinhDang3";
    this.cbbDinhDang3.Size = new Size(78, 22);
    this.cbbDinhDang3.TabIndex = 40;
    this.cbbDinhDang3.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.cbbDinhDang4.Cursor = Cursors.Hand;
    this.cbbDinhDang4.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang4.FormattingEnabled = true;
    this.cbbDinhDang4.Location = new Point(323, 3);
    this.cbbDinhDang4.Name = "cbbDinhDang4";
    this.cbbDinhDang4.Size = new Size(78, 22);
    this.cbbDinhDang4.TabIndex = 40;
    this.cbbDinhDang4.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.label14.AutoSize = true;
    this.label14.Font = new Font("Tahoma", 12f);
    this.label14.Location = new Point(587, 3);
    this.label14.Name = "label14";
    this.label14.Size = new Size(15, 19);
    this.label14.TabIndex = 41;
    this.label14.Text = "|";
    this.cbbDinhDang5.Cursor = Cursors.Hand;
    this.cbbDinhDang5.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang5.FormattingEnabled = true;
    this.cbbDinhDang5.Location = new Point(416, 3);
    this.cbbDinhDang5.Name = "cbbDinhDang5";
    this.cbbDinhDang5.Size = new Size(78, 22);
    this.cbbDinhDang5.TabIndex = 40;
    this.cbbDinhDang5.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.label6.AutoSize = true;
    this.label6.Font = new Font("Tahoma", 12f);
    this.label6.Location = new Point(867, 5);
    this.label6.Name = "label6";
    this.label6.Size = new Size(15, 19);
    this.label6.TabIndex = 41;
    this.label6.Text = "|";
    this.label17.AutoSize = true;
    this.label17.Font = new Font("Tahoma", 12f);
    this.label17.Location = new Point(680, 3);
    this.label17.Name = "label17";
    this.label17.Size = new Size(15, 19);
    this.label17.TabIndex = 41;
    this.label17.Text = "|";
    this.cbbDinhDang10.Cursor = Cursors.Hand;
    this.cbbDinhDang10.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang10.FormattingEnabled = true;
    this.cbbDinhDang10.Location = new Point(882, 5);
    this.cbbDinhDang10.Name = "cbbDinhDang10";
    this.cbbDinhDang10.Size = new Size(78, 22);
    this.cbbDinhDang10.TabIndex = 40;
    this.cbbDinhDang10.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.cbbDinhDang8.Cursor = Cursors.Hand;
    this.cbbDinhDang8.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang8.FormattingEnabled = true;
    this.cbbDinhDang8.Location = new Point(695, 3);
    this.cbbDinhDang8.Name = "cbbDinhDang8";
    this.cbbDinhDang8.Size = new Size(78, 22);
    this.cbbDinhDang8.TabIndex = 40;
    this.cbbDinhDang8.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.label13.AutoSize = true;
    this.label13.Font = new Font("Tahoma", 12f);
    this.label13.Location = new Point(494, 3);
    this.label13.Name = "label13";
    this.label13.Size = new Size(15, 19);
    this.label13.TabIndex = 41;
    this.label13.Text = "|";
    this.cbbDinhDang6.Cursor = Cursors.Hand;
    this.cbbDinhDang6.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang6.FormattingEnabled = true;
    this.cbbDinhDang6.Location = new Point(509, 3);
    this.cbbDinhDang6.Name = "cbbDinhDang6";
    this.cbbDinhDang6.Size = new Size(78, 22);
    this.cbbDinhDang6.TabIndex = 40;
    this.cbbDinhDang6.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.label12.AutoSize = true;
    this.label12.Font = new Font("Tahoma", 12f);
    this.label12.Location = new Point(401, 3);
    this.label12.Name = "label12";
    this.label12.Size = new Size(15, 19);
    this.label12.TabIndex = 41;
    this.label12.Text = "|";
    this.cbbDinhDang7.Cursor = Cursors.Hand;
    this.cbbDinhDang7.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang7.FormattingEnabled = true;
    this.cbbDinhDang7.Location = new Point(602, 3);
    this.cbbDinhDang7.Name = "cbbDinhDang7";
    this.cbbDinhDang7.Size = new Size(78, 22);
    this.cbbDinhDang7.TabIndex = 40;
    this.cbbDinhDang7.SelectedIndexChanged += new EventHandler(this.cbbDinhDang7_SelectedIndexChanged);
    this.label11.AutoSize = true;
    this.label11.Font = new Font("Tahoma", 12f);
    this.label11.Location = new Point(308, 3);
    this.label11.Name = "label11";
    this.label11.Size = new Size(15, 19);
    this.label11.TabIndex = 41;
    this.label11.Text = "|";
    this.label9.AutoSize = true;
    this.label9.Font = new Font("Tahoma", 12f);
    this.label9.Location = new Point(122, 3);
    this.label9.Name = "label9";
    this.label9.Size = new Size(15, 19);
    this.label9.TabIndex = 41;
    this.label9.Text = "|";
    this.label10.AutoSize = true;
    this.label10.Font = new Font("Tahoma", 12f);
    this.label10.Location = new Point(215, 3);
    this.label10.Name = "label10";
    this.label10.Size = new Size(15, 19);
    this.label10.TabIndex = 41;
    this.label10.Text = "|";
    this.AutoScaleDimensions = new SizeF(7f, 14f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1179, 502);
    this.Controls.Add((Control) this.plDinhDangNhap);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.lblSuccess);
    this.Controls.Add((Control) this.lblError);
    this.Controls.Add((Control) this.lblTotal);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.txbAccount);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Controls.Add((Control) this.cbbDinhDangNhap);
    this.Controls.Add((Control) this.label8);
    this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fCapNhatDuLieu);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Nhập tài khoản";
    this.Load += new EventHandler(this.fCapNhatDuLieu_Load);
    this.pnlHeader.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.ctmsAcc.ResumeLayout(false);
    this.plDinhDangNhap.ResumeLayout(false);
    this.plDinhDangNhap.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void plDinhDangNhap_Paint(object sender, PaintEventArgs e)
  {
  }
}
