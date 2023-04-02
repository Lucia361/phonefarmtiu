// Decompiled with JetBrains decompiler
// Type: fImportProxy
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

public class fImportProxy : Form
{
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuDragControl bunifuDragControl_0;
  private Label label8;
  private Label lblStatus;
  private RichTextBox txtProxy;
  private Label label1;
  private NumericUpDown nudTaiKhoanPerUa;
  private CheckBox ckbKhongNhapTaiKhoanDaCo;
  private Label label2;
  private RadioButton rbNgauNhien;
  private RadioButton rbLanLuot;
  private Label label3;
  private ComboBox cbbTypeProxy;
  private IContainer components;
  private Label label4;

  public fImportProxy()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.cbbTypeProxy.SelectedIndex = 0;
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.lblStatus);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.rbLanLuot);
    GClass35.smethod_1((Control) this.rbNgauNhien);
    GClass35.smethod_1((Control) this.ckbKhongNhapTaiKhoanDaCo);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> collection = GClass19.smethod_39(((IEnumerable<string>) this.txtProxy.Lines).ToList<string>());
      List<string> stringList = new List<string>();
      if (collection.Count == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập thêm Proxy!"), 3);
      }
      else
      {
        int int32 = Convert.ToInt32(this.nudTaiKhoanPerUa.Value);
        for (int index = 0; index < int32; ++index)
          stringList.AddRange((IEnumerable<string>) collection);
        if (this.rbNgauNhien.Checked)
          stringList = GClass19.smethod_38(stringList);
        Queue<string> stringQueue1 = new Queue<string>((IEnumerable<string>) stringList);
        int selectedIndex = this.cbbTypeProxy.SelectedIndex;
        List<string> list_0 = new List<string>();
        for (int int_4 = 0; int_4 < fMain.fMain_0.dtgvAcc.Rows.Count; ++int_4)
        {
          if (Convert.ToBoolean(fMain.fMain_0.method_191(int_4, "cChose")) && (!(fMain.fMain_0.method_191(int_4, "cProxy") != "") || !this.ckbKhongNhapTaiKhoanDaCo.Checked))
          {
            if (stringQueue1.Count != 0)
            {
              string str = (stringQueue1.Dequeue() + "*" + selectedIndex.ToString()).Replace("'", "''");
              list_0.Add(fMain.fMain_0.method_191(int_4, "cId") + "|" + str);
            }
            else
              break;
          }
        }
        if (Class42.smethod_32("proxy", list_0))
        {
          Queue<string> stringQueue2 = new Queue<string>((IEnumerable<string>) stringList);
          for (int int_4 = 0; int_4 < fMain.fMain_0.dtgvAcc.Rows.Count; ++int_4)
          {
            if (Convert.ToBoolean(fMain.fMain_0.method_191(int_4, "cChose")) && (!(fMain.fMain_0.method_191(int_4, "cProxy") != "") || !this.ckbKhongNhapTaiKhoanDaCo.Checked))
            {
              if (stringQueue2.Count != 0)
              {
                string object_17 = (stringQueue2.Dequeue() + "*" + selectedIndex.ToString()).Replace("'", "''");
                fMain.fMain_0.method_186(int_4, "cProxy", (object) object_17);
              }
              else
                break;
            }
          }
        }
        if (GClass14.smethod_1(GClass35.smethod_0("Nhập thành công, bạn có muốn đóng cửa sổ?")) != DialogResult.Yes)
          return;
        this.Close();
      }
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void method_1(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnAdd_Click((object) null, (EventArgs) null);
  }

  private void txtProxy_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtProxy.Lines).ToList<string>());
      this.lblStatus.Text = string.Format(GClass35.smethod_0("Danh sách Proxy ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fImportProxy));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.label8 = new Label();
    this.lblStatus = new Label();
    this.txtProxy = new RichTextBox();
    this.label1 = new Label();
    this.nudTaiKhoanPerUa = new NumericUpDown();
    this.ckbKhongNhapTaiKhoanDaCo = new CheckBox();
    this.label2 = new Label();
    this.rbNgauNhien = new RadioButton();
    this.rbLanLuot = new RadioButton();
    this.label3 = new Label();
    this.cbbTypeProxy = new ComboBox();
    this.label4 = new Label();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.nudTaiKhoanPerUa.BeginInit();
    this.SuspendLayout();
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.Dock = DockStyle.Top;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(477, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(477, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(445, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 9;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(477, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Nhập Proxy";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(244, 386);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 4;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(135, 386);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Xác nhận";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label8.Location = new Point(331, 252);
    this.label8.Name = "label8";
    this.label8.Size = new Size(115, 16);
    this.label8.TabIndex = 5;
    this.label8.Text = "(Mỗi proxy 1 dòng)";
    this.lblStatus.AutoSize = true;
    this.lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.Location = new Point(30, 47);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size((int) sbyte.MaxValue, 16);
    this.lblStatus.TabIndex = 6;
    this.lblStatus.Text = "Danh sách Proxy (0):";
    this.txtProxy.BorderStyle = BorderStyle.FixedSingle;
    this.txtProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtProxy.Location = new Point(34, 66);
    this.txtProxy.Name = "txtProxy";
    this.txtProxy.Size = new Size(409, 181);
    this.txtProxy.TabIndex = 118;
    this.txtProxy.Text = "";
    this.txtProxy.WordWrap = false;
    this.txtProxy.TextChanged += new EventHandler(this.txtProxy_TextChanged);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(31, 298);
    this.label1.Name = "label1";
    this.label1.Size = new Size(119, 16);
    this.label1.TabIndex = 119;
    this.label1.Text = "Số tài khoản/proxy:";
    this.nudTaiKhoanPerUa.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.nudTaiKhoanPerUa.Location = new Point(164, 296);
    this.nudTaiKhoanPerUa.Maximum = new Decimal(new int[4]
    {
      999999,
      0,
      0,
      0
    });
    this.nudTaiKhoanPerUa.Minimum = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.nudTaiKhoanPerUa.Name = "nudTaiKhoanPerUa";
    this.nudTaiKhoanPerUa.Size = new Size(69, 23);
    this.nudTaiKhoanPerUa.TabIndex = 120;
    this.nudTaiKhoanPerUa.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.ckbKhongNhapTaiKhoanDaCo.AutoSize = true;
    this.ckbKhongNhapTaiKhoanDaCo.Cursor = Cursors.Hand;
    this.ckbKhongNhapTaiKhoanDaCo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbKhongNhapTaiKhoanDaCo.Location = new Point(33, 349);
    this.ckbKhongNhapTaiKhoanDaCo.Name = "ckbKhongNhapTaiKhoanDaCo";
    this.ckbKhongNhapTaiKhoanDaCo.Size = new Size(283, 20);
    this.ckbKhongNhapTaiKhoanDaCo.TabIndex = 121;
    this.ckbKhongNhapTaiKhoanDaCo.Text = "Không nhập vào những tài khoản đã có Proxy";
    this.ckbKhongNhapTaiKhoanDaCo.UseVisualStyleBackColor = true;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.Location = new Point(30, 325);
    this.label2.Name = "label2";
    this.label2.Size = new Size(131, 16);
    this.label2.TabIndex = 119;
    this.label2.Text = "Tùy chọn nhập Proxy:";
    this.rbNgauNhien.AutoSize = true;
    this.rbNgauNhien.Cursor = Cursors.Hand;
    this.rbNgauNhien.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbNgauNhien.Location = new Point(253, 323);
    this.rbNgauNhien.Name = "rbNgauNhien";
    this.rbNgauNhien.Size = new Size(89, 20);
    this.rbNgauNhien.TabIndex = 122;
    this.rbNgauNhien.Text = "Ngẫu nhiên";
    this.rbNgauNhien.UseVisualStyleBackColor = true;
    this.rbLanLuot.AutoSize = true;
    this.rbLanLuot.Checked = true;
    this.rbLanLuot.Cursor = Cursors.Hand;
    this.rbLanLuot.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbLanLuot.Location = new Point(164, 323);
    this.rbLanLuot.Name = "rbLanLuot";
    this.rbLanLuot.Size = new Size(71, 20);
    this.rbLanLuot.TabIndex = 122;
    this.rbLanLuot.TabStop = true;
    this.rbLanLuot.Text = "Lần lượt";
    this.rbLanLuot.UseVisualStyleBackColor = true;
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(31, 267);
    this.label3.Name = "label3";
    this.label3.Size = new Size(70, 16);
    this.label3.TabIndex = 119;
    this.label3.Text = "Loại Proxy:";
    this.cbbTypeProxy.Cursor = Cursors.Hand;
    this.cbbTypeProxy.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbTypeProxy.Enabled = false;
    this.cbbTypeProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbTypeProxy.FormattingEnabled = true;
    this.cbbTypeProxy.Items.AddRange(new object[2]
    {
      (object) "HTTP",
      (object) "Sock5"
    });
    this.cbbTypeProxy.Location = new Point(164, 264);
    this.cbbTypeProxy.Name = "cbbTypeProxy";
    this.cbbTypeProxy.Size = new Size(140, 24);
    this.cbbTypeProxy.TabIndex = 123;
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label4.ForeColor = Color.Red;
    this.label4.Location = new Point(179, 47);
    this.label4.Name = "label4";
    this.label4.Size = new Size(265, 16);
    this.label4.TabIndex = 119;
    this.label4.Text = "(Định dạng: IP:PORT, chưa hỗ trợ user pass)";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(477, 432);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.cbbTypeProxy);
    this.Controls.Add((Control) this.rbLanLuot);
    this.Controls.Add((Control) this.rbNgauNhien);
    this.Controls.Add((Control) this.ckbKhongNhapTaiKhoanDaCo);
    this.Controls.Add((Control) this.nudTaiKhoanPerUa);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.txtProxy);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fImportProxy);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.nudTaiKhoanPerUa.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
