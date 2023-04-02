// Decompiled with JetBrains decompiler
// Type: fActive
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using DeviceId;
using maxcare.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class fActive : Form
{
  private int int_0 = 0;
  private Bitmap bitmap_0 = Resource.Bitmap_286;
  private Bitmap bitmap_1 = Resource.Bitmap_281;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private BunifuMetroTextbox txbUserName;
  private BunifuCustomLabel bunifuCustomLabel2;
  private BunifuCustomLabel bunifuCustomLabel3;
  private BunifuMetroTextbox txbPassword;
  private Button btnLogin;
  private Label lblStatus;
  private LinkLabel linkLabel1;
  private Label label1;
  private Button btnMinimize;
  private BunifuDragControl bunifuDragControl_0;
  private PictureBox pictureBox2;
  private BunifuCustomLabel bunifuCustomLabel8;
  private BunifuCustomLabel bunifuCustomLabel5;
  private BunifuCustomLabel bunifuCustomLabel6;
  private BunifuCustomLabel bunifuCustomLabel4;
  private BunifuCustomLabel lblKey;
  private BunifuCustomLabel bunifuCustomLabel7;
  private BunifuDragControl bunifuDragControl_1;
  private IContainer components;
  private PictureBox picLanguage;

  public fActive(int int_1)
  {
    this.InitializeComponent();
    this.int_0 = int_1;
    this.lblStatus.Text = this.method_0(int_1);
    this.lblKey.Text = GClass19.smethod_1();
    this.picLanguage.Image = Class54.smethod_2() != "VN" ? (Image) this.bitmap_0 : (Image) this.bitmap_1;
    GClass35.smethod_5((Control) this);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => Environment.Exit(0);

  private string method_0(int int_1 = 0)
  {
    if (true)
      ;
    string str;
    switch (int_1)
    {
      case 0:
        str = "";
        break;
      case 1:
        str = GClass35.smethod_0("Vui lòng đăng nhập để sử dụng phần mềm!!!");
        break;
      case 2:
        str = GClass35.smethod_0("Thiết bị của bạn chưa được kích hoạt!!!");
        break;
      case 3:
        str = GClass35.smethod_0("Thiết bị của bạn đã hết hạn sử dụng!!!");
        break;
      case 4:
        str = GClass35.smethod_0("Tài khoản hoặc mật khẩu bạn nhập không đúng!!!");
        break;
      default:
        str = GClass35.smethod_0("Lỗi không xác định!!!");
        break;
    }
    if (true)
      ;
    return str;
  }

  private void btnLogin_Click(object sender, EventArgs e)
  {
    string string_0 = this.txbUserName.Text.Trim();
    string string_1 = this.txbPassword.Text.Trim();
    if (string_0 == "" || string_1 == "")
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng điền đầy đủ thông tin!"), 3);
    }
    else
    {
      if (!string_0.Contains("@"))
        string_0 += "@gmail.com";
      new Thread((ThreadStart) (() =>
      {
        this.btnLogin.Invoke((Delegate) (() => this.btnLogin.Enabled = false));
        this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Text = GClass35.smethod_0("Đang kiểm tra đăng nhập...")));
        try
        {
          GClass4 gclass4 = new GClass4();
          GClass19.smethod_56(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber().AddSystemDriveSerialNumber().ToString());
          GClass23 gclass23 = new GClass23();
          GClass3 gclass3 = new GClass3();
          Random random = new Random();
          string string_0_1 = GClass19.smethod_3(string_0, string_1);
          if (string_0_1.Trim() == "")
          {
            this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Text = this.method_0(4)));
            this.btnLogin.Invoke((Delegate) (() => this.btnLogin.Enabled = true));
          }
          else
          {
            string str1 = GClass19.smethod_2(string_0_1, 70.ToString());
            if (str1.Contains("chuakichhoat"))
            {
              this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Text = this.method_0(2)));
              this.btnLogin.Invoke((Delegate) (() => this.btnLogin.Enabled = true));
            }
            else if (str1.Contains("error"))
            {
              this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Text = this.method_0(5)));
              this.btnLogin.Invoke((Delegate) (() => this.btnLogin.Enabled = true));
            }
            else if (str1.Contains("hethan"))
            {
              this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Text = this.method_0(3)));
              this.btnLogin.Invoke((Delegate) (() => this.btnLogin.Enabled = true));
            }
            else
            {
              string str2 = str1.Split('|')[0];
              string str3 = str1.Split('|')[1];
              string str4 = str1.Split('|')[2];
              string str5 = str1.Split('|')[3];
              string str6 = str1.Split('|')[4];
              string str7 = str1.Split('|')[5];
              this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Text = GClass35.smethod_0("Đăng nhập thành công!")));
              GClass14.smethod_0((object) (GClass35.smethod_0("Thiết bị của bạn đã được kích hoạt, cảm ơn đã sử dụng phần mềm của Min Software.") + "\r\n" + GClass35.smethod_0("Vui lòng mở lại phần mềm để sử dụng!")));
              Settings.Default.UserName = string_0;
              Settings.Default.PassWord = string_1;
              Settings.Default.Save();
              Environment.Exit(0);
            }
          }
        }
        catch (Exception ex)
        {
          GClass19.smethod_79((GClass18) null, ex, "Active error");
          GClass14.smethod_0((object) "Lỗi không xác định!!!", 2);
          this.btnLogin.Invoke((Delegate) (() => this.btnLogin.Enabled = true));
        }
      }))
      {
        IsBackground = true
      }.Start();
    }
  }

  private void fActive_FormClosing(object sender, FormClosingEventArgs e) => Environment.Exit(0);

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      Process.Start("chrome.exe", "http://app.minsoftware.xyz/signup");
    }
    catch
    {
      Process.Start("http://app.minsoftware.xyz/signup");
    }
  }

  private void pictureBox2_Click(object sender, EventArgs e)
  {
    Clipboard.SetText(this.lblKey.Text);
    GClass14.smethod_0((object) GClass35.smethod_0("Đã copy mã thiết bị!"));
  }

  private void txbPassword_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnLogin_Click((object) null, (EventArgs) null);
  }

  private void picLanguage_Click(object sender, EventArgs e)
  {
    if (this.picLanguage.Image == this.bitmap_0)
    {
      this.picLanguage.Image = (Image) this.bitmap_1;
      Class54.smethod_3();
      GClass14.smethod_0((object) "Vui lòng mở lại phần mềm để cập nhật ngôn ngữ!");
    }
    else
    {
      this.picLanguage.Image = (Image) this.bitmap_0;
      Class54.smethod_3("EN");
    }
    Class54.smethod_2();
    GClass35.smethod_5((Control) this);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fActive));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.picLanguage = new PictureBox();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.txbUserName = new BunifuMetroTextbox();
    this.bunifuCustomLabel2 = new BunifuCustomLabel();
    this.bunifuCustomLabel3 = new BunifuCustomLabel();
    this.txbPassword = new BunifuMetroTextbox();
    this.btnLogin = new Button();
    this.lblStatus = new Label();
    this.linkLabel1 = new LinkLabel();
    this.label1 = new Label();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.pictureBox2 = new PictureBox();
    this.bunifuCustomLabel8 = new BunifuCustomLabel();
    this.bunifuCustomLabel5 = new BunifuCustomLabel();
    this.bunifuCustomLabel6 = new BunifuCustomLabel();
    this.bunifuCustomLabel4 = new BunifuCustomLabel();
    this.lblKey = new BunifuCustomLabel();
    this.bunifuCustomLabel7 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    ((ISupportInitialize) this.picLanguage).BeginInit();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    this.SuspendLayout();
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(395, 38);
    this.bunifuCards1.TabIndex = 11;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.picLanguage);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(393, 32);
    this.pnlHeader.TabIndex = 9;
    this.picLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.picLanguage.Cursor = Cursors.Hand;
    this.picLanguage.Location = new Point(330, 2);
    this.picLanguage.Name = "picLanguage";
    this.picLanguage.Size = new Size(25, 25);
    this.picLanguage.SizeMode = PictureBoxSizeMode.StretchImage;
    this.picLanguage.TabIndex = 14;
    this.picLanguage.TabStop = false;
    this.picLanguage.Click += new EventHandler(this.picLanguage_Click);
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(361, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 13;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.bunifuCustomLabel1.AutoSize = true;
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(42, 7);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(268, 16);
    this.bunifuCustomLabel1.TabIndex = 7;
    this.bunifuCustomLabel1.Text = "MAX PHONE FARM - Kích hoạt bản quyền";
    this.txbUserName.BorderColorFocused = Color.FromArgb(192, 64, 0);
    this.txbUserName.BorderColorIdle = Color.FromArgb(64, 64, 64);
    this.txbUserName.BorderColorMouseHover = Color.FromArgb(192, 64, 0);
    this.txbUserName.BorderThickness = 3;
    this.txbUserName.Cursor = Cursors.IBeam;
    this.txbUserName.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txbUserName.ForeColor = Color.FromArgb(64, 64, 64);
    this.txbUserName.isPassword = false;
    this.txbUserName.Location = new Point(117, 46);
    this.txbUserName.Margin = new Padding(4);
    this.txbUserName.Name = "txbUserName";
    this.txbUserName.Size = new Size(228, 29);
    this.txbUserName.TabIndex = 0;
    this.txbUserName.TextAlign = HorizontalAlignment.Left;
    this.txbUserName.KeyDown += new KeyEventHandler(this.txbPassword_KeyDown);
    this.bunifuCustomLabel2.AutoSize = true;
    this.bunifuCustomLabel2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel2.Location = new Point(37, 52);
    this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
    this.bunifuCustomLabel2.Size = new Size(44, 16);
    this.bunifuCustomLabel2.TabIndex = 13;
    this.bunifuCustomLabel2.Text = "Email:";
    this.bunifuCustomLabel3.AutoSize = true;
    this.bunifuCustomLabel3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel3.Location = new Point(37, 91);
    this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
    this.bunifuCustomLabel3.Size = new Size(72, 16);
    this.bunifuCustomLabel3.TabIndex = 15;
    this.bunifuCustomLabel3.Text = "Mật khẩu:";
    this.txbPassword.BorderColorFocused = Color.FromArgb(192, 64, 0);
    this.txbPassword.BorderColorIdle = Color.FromArgb(64, 64, 64);
    this.txbPassword.BorderColorMouseHover = Color.FromArgb(192, 64, 0);
    this.txbPassword.BorderThickness = 3;
    this.txbPassword.Cursor = Cursors.IBeam;
    this.txbPassword.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txbPassword.ForeColor = Color.FromArgb(64, 64, 64);
    this.txbPassword.isPassword = true;
    this.txbPassword.Location = new Point(117, 83);
    this.txbPassword.Margin = new Padding(4);
    this.txbPassword.Name = "txbPassword";
    this.txbPassword.Size = new Size(228, 29);
    this.txbPassword.TabIndex = 1;
    this.txbPassword.TextAlign = HorizontalAlignment.Left;
    this.txbPassword.KeyDown += new KeyEventHandler(this.txbPassword_KeyDown);
    this.btnLogin.BackColor = Color.FromArgb(53, 120, 229);
    this.btnLogin.Cursor = Cursors.Hand;
    this.btnLogin.FlatAppearance.BorderSize = 0;
    this.btnLogin.FlatStyle = FlatStyle.Flat;
    this.btnLogin.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnLogin.ForeColor = Color.White;
    this.btnLogin.Location = new Point(149, 136);
    this.btnLogin.Name = "btnLogin";
    this.btnLogin.Size = new Size(115, 29);
    this.btnLogin.TabIndex = 2;
    this.btnLogin.Text = "Đăng nhập";
    this.btnLogin.UseVisualStyleBackColor = false;
    this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
    this.lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblStatus.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.ForeColor = Color.Red;
    this.lblStatus.Location = new Point(10, 115);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(371, 18);
    this.lblStatus.TabIndex = 28;
    this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.Cursor = Cursors.Hand;
    this.linkLabel1.LinkColor = Color.FromArgb(53, 120, 229);
    this.linkLabel1.Location = new Point(274, 172);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(25, 13);
    this.linkLabel1.TabIndex = 3;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "đây";
    this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
    this.label1.AutoSize = true;
    this.label1.Location = new Point(118, 172);
    this.label1.Name = "label1";
    this.label1.Size = new Size(157, 13);
    this.label1.TabIndex = 30;
    this.label1.Text = "Đăng ký tài khoản mới bấm vào";
    this.label1.TextAlign = ContentAlignment.MiddleRight;
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_0.Vertical = true;
    this.pictureBox2.Cursor = Cursors.Hand;
    this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(357, 208);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(20, 20);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox2.TabIndex = 42;
    this.pictureBox2.TabStop = false;
    this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
    this.bunifuCustomLabel8.Anchor = AnchorStyles.Right;
    this.bunifuCustomLabel8.AutoSize = true;
    this.bunifuCustomLabel8.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel8.ForeColor = Color.Gray;
    this.bunifuCustomLabel8.Location = new Point(224, 195);
    this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
    this.bunifuCustomLabel8.Size = new Size(140, 13);
    this.bunifuCustomLabel8.TabIndex = 40;
    this.bunifuCustomLabel8.Text = "https://minsoftware.vn";
    this.bunifuCustomLabel5.Anchor = AnchorStyles.Right;
    this.bunifuCustomLabel5.AutoSize = true;
    this.bunifuCustomLabel5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel5.ForeColor = Color.Gray;
    this.bunifuCustomLabel5.Location = new Point(73, 195);
    this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
    this.bunifuCustomLabel5.Size = new Size(83, 13);
    this.bunifuCustomLabel5.TabIndex = 41;
    this.bunifuCustomLabel5.Text = "0358.39.4040";
    this.bunifuCustomLabel6.Anchor = AnchorStyles.Right;
    this.bunifuCustomLabel6.AutoSize = true;
    this.bunifuCustomLabel6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel6.Location = new Point(168, 195);
    this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
    this.bunifuCustomLabel6.Size = new Size(56, 13);
    this.bunifuCustomLabel6.TabIndex = 38;
    this.bunifuCustomLabel6.Text = "Website:";
    this.bunifuCustomLabel4.Anchor = AnchorStyles.Right;
    this.bunifuCustomLabel4.AutoSize = true;
    this.bunifuCustomLabel4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel4.Location = new Point(22, 195);
    this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
    this.bunifuCustomLabel4.Size = new Size(53, 13);
    this.bunifuCustomLabel4.TabIndex = 39;
    this.bunifuCustomLabel4.Text = "Hotline: ";
    this.lblKey.Anchor = AnchorStyles.Right;
    this.lblKey.AutoSize = true;
    this.lblKey.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblKey.ForeColor = Color.Gray;
    this.lblKey.Location = new Point(94, 213);
    this.lblKey.Name = "lblKey";
    this.lblKey.Size = new Size(231, 13);
    this.lblKey.TabIndex = 37;
    this.lblKey.Text = "********************************";
    this.bunifuCustomLabel7.Anchor = AnchorStyles.Right;
    this.bunifuCustomLabel7.AutoSize = true;
    this.bunifuCustomLabel7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel7.Location = new Point(22, 213);
    this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
    this.bunifuCustomLabel7.Size = new Size(70, 13);
    this.bunifuCustomLabel7.TabIndex = 36;
    this.bunifuCustomLabel7.Text = "Mã thiết bị:";
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_1.Vertical = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(393, 238);
    this.Controls.Add((Control) this.pictureBox2);
    this.Controls.Add((Control) this.bunifuCustomLabel8);
    this.Controls.Add((Control) this.bunifuCustomLabel5);
    this.Controls.Add((Control) this.bunifuCustomLabel6);
    this.Controls.Add((Control) this.bunifuCustomLabel4);
    this.Controls.Add((Control) this.lblKey);
    this.Controls.Add((Control) this.bunifuCustomLabel7);
    this.Controls.Add((Control) this.linkLabel1);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.btnLogin);
    this.Controls.Add((Control) this.bunifuCustomLabel3);
    this.Controls.Add((Control) this.txbPassword);
    this.Controls.Add((Control) this.bunifuCustomLabel2);
    this.Controls.Add((Control) this.txbUserName);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (fActive);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "MAX PHONE FARM";
    this.FormClosing += new FormClosingEventHandler(this.fActive_FormClosing);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.pnlHeader.PerformLayout();
    ((ISupportInitialize) this.picLanguage).EndInit();
    ((ISupportInitialize) this.pictureBox2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
