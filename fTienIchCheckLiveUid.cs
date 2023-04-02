// Decompiled with JetBrains decompiler
// Type: fTienIchCheckLiveUid
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

public class fTienIchCheckLiveUid : Form
{
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel panel1;
  private BunifuDragControl bunifuDragControl_0;
  private ToolTip toolTip_0;
  private BunifuCards bunifuCards2;
  private Panel pnlHeader;
  private Button button2;
  private Button btnMinimize;
  private BunifuCustomLabel lblTitle;
  private Button btnAdd;
  private RichTextBox txtInput;
  private GroupBox grDaTao;
  private RichTextBox txtLive;
  private GroupBox groupBox1;
  private GroupBox grChuaTao;
  private RichTextBox txtDie;
  private Label lblStatus;
  private GroupBox grKhongCheckDuoc;
  private RichTextBox txtKhongCheckDuoc;
  private NumericUpDown nudThread;
  private IContainer components;
  private Label label2;

  public fTienIchCheckLiveUid()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void method_0() => GClass35.smethod_1((Control) this.groupBox1);

  private void button2_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = new List<string>();
      List<string> list = ((IEnumerable<string>) this.txtInput.Lines).ToList<string>();
      int int_0 = 0;
      int num1 = Convert.ToInt32(this.nudThread.Value);
      if (num1 == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Số luồng phải >0, vui lòng nhập lại!"), 3);
      }
      else
      {
        if (list.Count < num1)
          num1 = list.Count;
        this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Visible = true));
        int num2 = 0;
        while (num2 < list.Count)
        {
          if (int_0 < num1)
          {
            Interlocked.Increment(ref int_0);
            string string_0 = list[num2++];
            new Thread((ThreadStart) (() =>
            {
              string str = Class38.smethod_17(string_0);
              if (str.StartsWith("0|"))
                this.method_1(this.txtDie, string_0);
              else if (str.StartsWith("1|"))
                this.method_1(this.txtLive, string_0);
              else
                this.method_1(this.txtKhongCheckDuoc, string_0);
              Interlocked.Decrement(ref int_0);
            }))
            {
              IsBackground = true
            }.Start();
          }
          else
          {
            Application.DoEvents();
            GClass19.smethod_64(1.0);
          }
        }
        while (int_0 > 0)
          GClass19.smethod_64(1.0);
        this.lblStatus.Invoke((Delegate) (() => this.lblStatus.Visible = false));
        GClass14.smethod_0((object) GClass35.smethod_0("Đã check xong!"));
      }
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
    }
  }

  private void method_1(RichTextBox richTextBox_0, string string_0) => richTextBox_0.Invoke((Delegate) (() =>
  {
    Application.DoEvents();
    RichTextBox richTextBox = richTextBox_0;
    richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
  }));

  private void txtInput_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtInput, (Control) this.groupBox1);

  private void txtLive_TextChanged(object sender, EventArgs e)
  {
    try
    {
      this.grDaTao.Text = "LIVE (" + GClass19.smethod_39(((IEnumerable<string>) this.txtLive.Lines).ToList<string>()).Count.ToString() + ")";
    }
    catch
    {
    }
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void fTienIchCheckLiveUid_Load(object sender, EventArgs e)
  {
  }

  private void txtDie_TextChanged(object sender, EventArgs e)
  {
    try
    {
      this.grChuaTao.Text = "DIE (" + GClass19.smethod_39(((IEnumerable<string>) this.txtDie.Lines).ToList<string>()).Count.ToString() + ")";
    }
    catch
    {
    }
  }

  private void txtKhongCheckDuoc_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtKhongCheckDuoc.Lines).ToList<string>());
      this.grKhongCheckDuoc.Text = string.Format(GClass35.smethod_0("Không check được ({0})"), (object) stringList.Count.ToString());
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
    this.bunifuCards1 = new BunifuCards();
    this.panel1 = new Panel();
    this.nudThread = new NumericUpDown();
    this.label2 = new Label();
    this.lblStatus = new Label();
    this.grKhongCheckDuoc = new GroupBox();
    this.txtKhongCheckDuoc = new RichTextBox();
    this.grChuaTao = new GroupBox();
    this.txtDie = new RichTextBox();
    this.grDaTao = new GroupBox();
    this.txtLive = new RichTextBox();
    this.groupBox1 = new GroupBox();
    this.txtInput = new RichTextBox();
    this.btnAdd = new Button();
    this.bunifuCards2 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.btnMinimize = new Button();
    this.lblTitle = new BunifuCustomLabel();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.panel1.SuspendLayout();
    this.nudThread.BeginInit();
    this.grKhongCheckDuoc.SuspendLayout();
    this.grChuaTao.SuspendLayout();
    this.grDaTao.SuspendLayout();
    this.groupBox1.SuspendLayout();
    this.bunifuCards2.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.SuspendLayout();
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 5;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Margin = new Padding(3, 4, 3, 4);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(649, 47);
    this.bunifuCards1.TabIndex = 12;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.nudThread);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.lblStatus);
    this.panel1.Controls.Add((Control) this.grKhongCheckDuoc);
    this.panel1.Controls.Add((Control) this.grChuaTao);
    this.panel1.Controls.Add((Control) this.grDaTao);
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards2);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Margin = new Padding(3, 4, 3, 4);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(978, 406);
    this.panel1.TabIndex = 37;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.nudThread.Location = new Point(360, 60);
    this.nudThread.Maximum = new Decimal(new int[4]
    {
      999999999,
      0,
      0,
      0
    });
    this.nudThread.Name = "nudThread";
    this.nudThread.Size = new Size(69, 23);
    this.nudThread.TabIndex = 54;
    this.nudThread.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.label2.AutoSize = true;
    this.label2.Location = new Point(294, 62);
    this.label2.Name = "label2";
    this.label2.Size = new Size(59, 16);
    this.label2.TabIndex = 53;
    this.label2.Text = "Threads:";
    this.lblStatus.AutoSize = true;
    this.lblStatus.ForeColor = Color.DarkGreen;
    this.lblStatus.Location = new Point(617, 62);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(70, 16);
    this.lblStatus.TabIndex = 52;
    this.lblStatus.Text = "Checking...";
    this.lblStatus.Visible = false;
    this.grKhongCheckDuoc.Controls.Add((Control) this.txtKhongCheckDuoc);
    this.grKhongCheckDuoc.ForeColor = Color.Red;
    this.grKhongCheckDuoc.Location = new Point(748, 91);
    this.grKhongCheckDuoc.Name = "grKhongCheckDuoc";
    this.grKhongCheckDuoc.Size = new Size(221, 307);
    this.grKhongCheckDuoc.TabIndex = 51;
    this.grKhongCheckDuoc.TabStop = false;
    this.grKhongCheckDuoc.Text = "Can't check (0)";
    this.txtKhongCheckDuoc.Dock = DockStyle.Fill;
    this.txtKhongCheckDuoc.Location = new Point(3, 19);
    this.txtKhongCheckDuoc.Name = "txtKhongCheckDuoc";
    this.txtKhongCheckDuoc.Size = new Size(215, 285);
    this.txtKhongCheckDuoc.TabIndex = 50;
    this.txtKhongCheckDuoc.Text = "";
    this.txtKhongCheckDuoc.WordWrap = false;
    this.txtKhongCheckDuoc.TextChanged += new EventHandler(this.txtKhongCheckDuoc_TextChanged);
    this.grChuaTao.Controls.Add((Control) this.txtDie);
    this.grChuaTao.ForeColor = Color.DarkRed;
    this.grChuaTao.Location = new Point(521, 91);
    this.grChuaTao.Name = "grChuaTao";
    this.grChuaTao.Size = new Size(221, 307);
    this.grChuaTao.TabIndex = 51;
    this.grChuaTao.TabStop = false;
    this.grChuaTao.Text = "DIE (0)";
    this.txtDie.Dock = DockStyle.Fill;
    this.txtDie.Location = new Point(3, 19);
    this.txtDie.Name = "txtDie";
    this.txtDie.Size = new Size(215, 285);
    this.txtDie.TabIndex = 50;
    this.txtDie.Text = "";
    this.txtDie.WordWrap = false;
    this.txtDie.TextChanged += new EventHandler(this.txtDie_TextChanged);
    this.grDaTao.Controls.Add((Control) this.txtLive);
    this.grDaTao.ForeColor = Color.DarkGreen;
    this.grDaTao.Location = new Point(294, 91);
    this.grDaTao.Name = "grDaTao";
    this.grDaTao.Size = new Size(221, 307);
    this.grDaTao.TabIndex = 51;
    this.grDaTao.TabStop = false;
    this.grDaTao.Text = "LIVE (0)";
    this.txtLive.Dock = DockStyle.Fill;
    this.txtLive.Location = new Point(3, 19);
    this.txtLive.Name = "txtLive";
    this.txtLive.Size = new Size(215, 285);
    this.txtLive.TabIndex = 50;
    this.txtLive.Text = "";
    this.txtLive.WordWrap = false;
    this.txtLive.TextChanged += new EventHandler(this.txtLive_TextChanged);
    this.groupBox1.Controls.Add((Control) this.txtInput);
    this.groupBox1.Location = new Point(6, 40);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(282, 358);
    this.groupBox1.TabIndex = 51;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Nhập Uid (0)";
    this.txtInput.Location = new Point(9, 19);
    this.txtInput.Name = "txtInput";
    this.txtInput.Size = new Size(267, 336);
    this.txtInput.TabIndex = 50;
    this.txtInput.Text = "";
    this.txtInput.WordWrap = false;
    this.txtInput.TextChanged += new EventHandler(this.txtInput_TextChanged);
    this.btnAdd.BackColor = Color.Green;
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(476, 52);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(135, 36);
    this.btnAdd.TabIndex = 45;
    this.btnAdd.Text = "Check";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.bunifuCards2.BackColor = Color.White;
    this.bunifuCards2.BorderRadius = 0;
    this.bunifuCards2.BottomSahddow = true;
    this.bunifuCards2.color = Color.SaddleBrown;
    this.bunifuCards2.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards2.Dock = DockStyle.Top;
    this.bunifuCards2.LeftSahddow = false;
    this.bunifuCards2.Location = new Point(0, 0);
    this.bunifuCards2.Name = "bunifuCards2";
    this.bunifuCards2.RightSahddow = true;
    this.bunifuCards2.ShadowDepth = 20;
    this.bunifuCards2.Size = new Size(976, 37);
    this.bunifuCards2.TabIndex = 43;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.lblTitle);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(976, 31);
    this.pnlHeader.TabIndex = 9;
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) Resources.btnMinimize_Image;
    this.button2.Location = new Point(945, 1);
    this.button2.Name = "button2";
    this.button2.Size = new Size(30, 30);
    this.button2.TabIndex = 77;
    this.button2.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Location = new Point(899, 1);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(30, 30);
    this.btnMinimize.TabIndex = 9;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.lblTitle.BackColor = Color.Transparent;
    this.lblTitle.Cursor = Cursors.SizeAll;
    this.lblTitle.Dock = DockStyle.Fill;
    this.lblTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTitle.ForeColor = Color.Black;
    this.lblTitle.Location = new Point(0, 0);
    this.lblTitle.Name = "lblTitle";
    this.lblTitle.Size = new Size(976, 31);
    this.lblTitle.TabIndex = 12;
    this.lblTitle.Text = "Check Live Uid";
    this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.lblTitle;
    this.bunifuDragControl_0.Vertical = true;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 10000;
    this.toolTip_0.InitialDelay = 200;
    this.toolTip_0.ReshowDelay = 40;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(978, 406);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fTienIchCheckLiveUid);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fTienIchCheckLiveUid_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.nudThread.EndInit();
    this.grKhongCheckDuoc.ResumeLayout(false);
    this.grChuaTao.ResumeLayout(false);
    this.grDaTao.ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
