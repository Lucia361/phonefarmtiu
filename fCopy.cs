// Decompiled with JetBrains decompiler
// Type: fCopy
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class fCopy : Form
{
  private List<ComboBox> list_0;
  private List<string> list_1 = new List<string>();
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private Label label1;
  private BunifuDragControl bunifuDragControl_0;
  private ComboBox cbbDinhDang1;
  private ComboBox cbbDinhDang2;
  private ComboBox cbbDinhDang3;
  private ComboBox cbbDinhDang4;
  private Label label14;
  private ComboBox cbbDinhDang5;
  private Label label13;
  private ComboBox cbbDinhDang6;
  private Label label12;
  private ComboBox cbbDinhDang7;
  private Label label11;
  private Label label9;
  private Label label10;
  private ComboBox cbbDinhDang9;
  private ComboBox cbbDinhDang8;
  private Label label2;
  private Label label3;
  private Button button1;
  private ComboBox cbbDinhDang10;
  private Label label4;

  public fCopy(List<string> list_2)
  {
    this.InitializeComponent();
    this.list_1 = list_2;
    GClass35.smethod_5((Control) this);
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
      this.cbbDinhDang10
    };
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.button1);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void method_1()
  {
    try
    {
      string str = "";
      for (int index = 0; index < this.list_0.Count; ++index)
        str = str + this.list_0[index].SelectedIndex.ToString() + "|";
      File.WriteAllText("settings\\format_copy.txt", str.TrimEnd('|'));
    }
    catch
    {
    }
  }

  private void method_2()
  {
    try
    {
      if (!File.Exists("settings\\format_copy.txt"))
        return;
      string str = File.ReadAllText("settings\\format_copy.txt");
      for (int index = 0; index < this.list_0.Count; ++index)
        this.list_0[index].SelectedIndex = Convert.ToInt32(str.Split('|')[index]);
    }
    catch
    {
    }
  }

  private void method_3()
  {
    try
    {
      for (int index = 0; index < this.list_0.Count; ++index)
        this.list_0[index].SelectedIndex = -1;
    }
    catch
    {
    }
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> values = new List<string>();
      int num = 0;
      for (int index = this.list_0.Count - 1; index >= 0; --index)
      {
        if (this.list_0[index].SelectedIndex != -1)
        {
          num = index + 1;
          break;
        }
      }
      if (num == 0)
      {
        GClass14.smethod_0((object) "vui lòng chọn định dạng cần copy!", 3);
      }
      else
      {
        this.method_1();
        for (int index1 = 0; index1 < this.list_1.Count; ++index1)
        {
          string str1 = "";
          string[] strArray = this.list_1[index1].Split('|');
          for (int index2 = 0; index2 < this.list_0.Count; ++index2)
          {
            if (this.list_0[index2].SelectedIndex != -1)
              str1 += strArray[this.list_0[index2].SelectedIndex];
            str1 += "|";
          }
          string str2 = str1.TrimEnd('|');
          string str3 = str2;
          char[] chArray = new char[1]{ '|' };
          for (int index3 = ((IEnumerable<string>) str3.Split(chArray)).Count<string>(); index3 < num; ++index3)
            str2 += "|";
          values.Add(str2);
        }
        Clipboard.SetDataObject((object) string.Join("\r\n", (IEnumerable<string>) values), true, 10, 100);
        GClass14.smethod_0((object) "Copy thành công!");
        this.Close();
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_81((Exception) null, ex.ToString());
      GClass14.smethod_0((object) "Có lỗi xảy ra, vui lòng thử lại sau!", 2);
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void button1_Click(object sender, EventArgs e) => this.method_3();

  private void fCopy_Load(object sender, EventArgs e)
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
        "Tên",
        "Giới tính",
        "Theo dõi",
        "Bạn bè",
        "Nhóm",
        "Ngày sinh",
        "Ngày tạo",
        "Ghi chú",
        "Mail khôi phục",
        "Tương tác cuối"
      });
      comboBox_0.SelectedIndex = -1;
      comboBox_0.DropDownWidth = 100;
    }
    this.method_2();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCopy));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.label1 = new Label();
    this.bunifuDragControl_0 = new BunifuDragControl(this.icontainer_0);
    this.cbbDinhDang1 = new ComboBox();
    this.cbbDinhDang2 = new ComboBox();
    this.cbbDinhDang3 = new ComboBox();
    this.cbbDinhDang4 = new ComboBox();
    this.label14 = new Label();
    this.cbbDinhDang5 = new ComboBox();
    this.label13 = new Label();
    this.cbbDinhDang6 = new ComboBox();
    this.label12 = new Label();
    this.cbbDinhDang7 = new ComboBox();
    this.label11 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.cbbDinhDang9 = new ComboBox();
    this.cbbDinhDang8 = new ComboBox();
    this.label2 = new Label();
    this.label3 = new Label();
    this.button1 = new Button();
    this.cbbDinhDang10 = new ComboBox();
    this.label4 = new Label();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
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
    this.bunifuCards1.Size = new Size(1122, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(1122, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(1090, 0);
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
    this.bunifuCustomLabel1.Size = new Size(1122, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Tùy chọn định dạng sao chép";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(622, 124);
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
    this.btnAdd.Location = new Point(514, 124);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Xác nhận";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label1.Location = new Point(20, 66);
    this.label1.Name = "label1";
    this.label1.Size = new Size(131, 16);
    this.label1.TabIndex = 20;
    this.label1.Text = "Chọn định dạng copy:";
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.cbbDinhDang1.Cursor = Cursors.Hand;
    this.cbbDinhDang1.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang1.FormattingEnabled = true;
    this.cbbDinhDang1.Location = new Point(158, 65);
    this.cbbDinhDang1.Name = "cbbDinhDang1";
    this.cbbDinhDang1.Size = new Size(78, 24);
    this.cbbDinhDang1.TabIndex = 42;
    this.cbbDinhDang2.Cursor = Cursors.Hand;
    this.cbbDinhDang2.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang2.FormattingEnabled = true;
    this.cbbDinhDang2.Location = new Point((int) byte.MaxValue, 65);
    this.cbbDinhDang2.Name = "cbbDinhDang2";
    this.cbbDinhDang2.Size = new Size(78, 24);
    this.cbbDinhDang2.TabIndex = 43;
    this.cbbDinhDang3.Cursor = Cursors.Hand;
    this.cbbDinhDang3.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang3.FormattingEnabled = true;
    this.cbbDinhDang3.Location = new Point(352, 65);
    this.cbbDinhDang3.Name = "cbbDinhDang3";
    this.cbbDinhDang3.Size = new Size(78, 24);
    this.cbbDinhDang3.TabIndex = 44;
    this.cbbDinhDang4.Cursor = Cursors.Hand;
    this.cbbDinhDang4.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang4.FormattingEnabled = true;
    this.cbbDinhDang4.Location = new Point(449, 65);
    this.cbbDinhDang4.Name = "cbbDinhDang4";
    this.cbbDinhDang4.Size = new Size(78, 24);
    this.cbbDinhDang4.TabIndex = 45;
    this.label14.AutoSize = true;
    this.label14.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label14.Location = new Point(721, 67);
    this.label14.Name = "label14";
    this.label14.Size = new Size(19, 19);
    this.label14.TabIndex = 49;
    this.label14.Text = "|";
    this.cbbDinhDang5.Cursor = Cursors.Hand;
    this.cbbDinhDang5.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang5.FormattingEnabled = true;
    this.cbbDinhDang5.Location = new Point(546, 65);
    this.cbbDinhDang5.Name = "cbbDinhDang5";
    this.cbbDinhDang5.Size = new Size(78, 24);
    this.cbbDinhDang5.TabIndex = 46;
    this.label13.AutoSize = true;
    this.label13.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label13.Location = new Point(624, 67);
    this.label13.Name = "label13";
    this.label13.Size = new Size(19, 19);
    this.label13.TabIndex = 50;
    this.label13.Text = "|";
    this.cbbDinhDang6.Cursor = Cursors.Hand;
    this.cbbDinhDang6.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang6.FormattingEnabled = true;
    this.cbbDinhDang6.Location = new Point(643, 65);
    this.cbbDinhDang6.Name = "cbbDinhDang6";
    this.cbbDinhDang6.Size = new Size(78, 24);
    this.cbbDinhDang6.TabIndex = 47;
    this.label12.AutoSize = true;
    this.label12.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label12.Location = new Point(527, 67);
    this.label12.Name = "label12";
    this.label12.Size = new Size(19, 19);
    this.label12.TabIndex = 51;
    this.label12.Text = "|";
    this.cbbDinhDang7.Cursor = Cursors.Hand;
    this.cbbDinhDang7.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang7.FormattingEnabled = true;
    this.cbbDinhDang7.Location = new Point(740, 65);
    this.cbbDinhDang7.Name = "cbbDinhDang7";
    this.cbbDinhDang7.Size = new Size(78, 24);
    this.cbbDinhDang7.TabIndex = 48;
    this.label11.AutoSize = true;
    this.label11.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label11.Location = new Point(430, 67);
    this.label11.Name = "label11";
    this.label11.Size = new Size(19, 19);
    this.label11.TabIndex = 52;
    this.label11.Text = "|";
    this.label9.AutoSize = true;
    this.label9.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label9.Location = new Point(236, 67);
    this.label9.Name = "label9";
    this.label9.Size = new Size(19, 19);
    this.label9.TabIndex = 53;
    this.label9.Text = "|";
    this.label10.AutoSize = true;
    this.label10.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label10.Location = new Point(333, 67);
    this.label10.Name = "label10";
    this.label10.Size = new Size(19, 19);
    this.label10.TabIndex = 54;
    this.label10.Text = "|";
    this.cbbDinhDang9.Cursor = Cursors.Hand;
    this.cbbDinhDang9.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang9.FormattingEnabled = true;
    this.cbbDinhDang9.Location = new Point(934, 65);
    this.cbbDinhDang9.Name = "cbbDinhDang9";
    this.cbbDinhDang9.Size = new Size(78, 24);
    this.cbbDinhDang9.TabIndex = 48;
    this.cbbDinhDang8.Cursor = Cursors.Hand;
    this.cbbDinhDang8.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang8.FormattingEnabled = true;
    this.cbbDinhDang8.Location = new Point(837, 65);
    this.cbbDinhDang8.Name = "cbbDinhDang8";
    this.cbbDinhDang8.Size = new Size(78, 24);
    this.cbbDinhDang8.TabIndex = 47;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label2.Location = new Point(818, 67);
    this.label2.Name = "label2";
    this.label2.Size = new Size(19, 19);
    this.label2.TabIndex = 50;
    this.label2.Text = "|";
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(915, 67);
    this.label3.Name = "label3";
    this.label3.Size = new Size(19, 19);
    this.label3.TabIndex = 49;
    this.label3.Text = "|";
    this.button1.BackColor = Color.DarkOrange;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Location = new Point(377, 124);
    this.button1.Name = "button1";
    this.button1.Size = new Size(121, 29);
    this.button1.TabIndex = 4;
    this.button1.Text = "Reset định dạng";
    this.button1.UseVisualStyleBackColor = false;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.cbbDinhDang10.Cursor = Cursors.Hand;
    this.cbbDinhDang10.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbDinhDang10.FormattingEnabled = true;
    this.cbbDinhDang10.Location = new Point(1033, 65);
    this.cbbDinhDang10.Name = "cbbDinhDang10";
    this.cbbDinhDang10.Size = new Size(78, 24);
    this.cbbDinhDang10.TabIndex = 48;
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label4.Location = new Point(1014, 67);
    this.label4.Name = "label4";
    this.label4.Size = new Size(19, 19);
    this.label4.TabIndex = 49;
    this.label4.Text = "|";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1122, 165);
    this.Controls.Add((Control) this.cbbDinhDang1);
    this.Controls.Add((Control) this.cbbDinhDang2);
    this.Controls.Add((Control) this.cbbDinhDang3);
    this.Controls.Add((Control) this.cbbDinhDang4);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label14);
    this.Controls.Add((Control) this.cbbDinhDang5);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.cbbDinhDang8);
    this.Controls.Add((Control) this.label13);
    this.Controls.Add((Control) this.cbbDinhDang6);
    this.Controls.Add((Control) this.cbbDinhDang10);
    this.Controls.Add((Control) this.cbbDinhDang9);
    this.Controls.Add((Control) this.label12);
    this.Controls.Add((Control) this.cbbDinhDang7);
    this.Controls.Add((Control) this.label11);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.label10);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fCopy);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fCopy_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
