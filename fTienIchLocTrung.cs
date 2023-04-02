// Decompiled with JetBrains decompiler
// Type: fTienIchLocTrung
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class fTienIchLocTrung : Form
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
  private GroupBox groupBox2;
  private RichTextBox txtOutput;
  private GroupBox groupBox1;
  private MetroButton btnNhapTuFile;
  private TextBox txtNhapTuFile;
  private RadioButton rbTuNhap;
  private IContainer components;
  private RadioButton rbNhapTuFile;

  public fTienIchLocTrung()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.lblTitle);
    GClass35.smethod_1((Control) this.rbNhapTuFile);
    GClass35.smethod_1((Control) this.btnNhapTuFile);
    GClass35.smethod_1((Control) this.rbTuNhap);
  }

  private void button2_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> source = new List<string>();
      string path = this.txtNhapTuFile.Text.Trim();
      if (this.rbNhapTuFile.Checked)
      {
        if (path.EndsWith(".txt"))
        {
          if (!File.Exists(path))
            GClass14.smethod_0((object) GClass35.smethod_0("File dữ liệu nhập không tồn tại!"), 2);
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("File nhập vào chỉ hỗ trợ đối với File (.txt)!"), 2);
      }
      if (this.rbNhapTuFile.Checked)
        source = ((IEnumerable<string>) File.ReadAllLines(path)).ToList<string>();
      else if (this.rbTuNhap.Checked)
        source = ((IEnumerable<string>) this.txtInput.Lines).ToList<string>();
      this.txtOutput.Lines = source.Distinct<string>().ToList<string>().ToArray();
      GClass14.smethod_0((object) GClass35.smethod_0("Đã lọc xong!"));
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
    }
  }

  private void txtInput_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtInput, (Control) this.rbTuNhap);

  private void rbNhapTuFile_CheckedChanged(object sender, EventArgs e)
  {
    this.txtNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
    this.btnNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
  }

  private void rbTuNhap_CheckedChanged(object sender, EventArgs e) => this.txtInput.Enabled = this.rbTuNhap.Checked;

  private void btnNhapTuFile_Click(object sender, EventArgs e) => this.txtNhapTuFile.Text = GClass19.smethod_46();

  private void txtOutput_TextChanged(object sender, EventArgs e)
  {
    try
    {
      this.groupBox2.Text = "Output (" + GClass19.smethod_39(((IEnumerable<string>) this.txtOutput.Lines).ToList<string>()).Count.ToString() + ")";
    }
    catch
    {
    }
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void fTienIchLocTrung_Load(object sender, EventArgs e)
  {
    this.rbNhapTuFile_CheckedChanged((object) null, (EventArgs) null);
    this.rbTuNhap_CheckedChanged((object) null, (EventArgs) null);
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
    this.groupBox2 = new GroupBox();
    this.txtOutput = new RichTextBox();
    this.groupBox1 = new GroupBox();
    this.btnNhapTuFile = new MetroButton();
    this.txtInput = new RichTextBox();
    this.txtNhapTuFile = new TextBox();
    this.rbTuNhap = new RadioButton();
    this.rbNhapTuFile = new RadioButton();
    this.btnAdd = new Button();
    this.bunifuCards2 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.btnMinimize = new Button();
    this.lblTitle = new BunifuCustomLabel();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.panel1.SuspendLayout();
    this.groupBox2.SuspendLayout();
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
    this.bunifuCards1.Size = new Size(509, 47);
    this.bunifuCards1.TabIndex = 12;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.groupBox2);
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.btnAdd);
    this.panel1.Controls.Add((Control) this.bunifuCards2);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Margin = new Padding(3, 4, 3, 4);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(838, 270);
    this.panel1.TabIndex = 37;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.groupBox2.Controls.Add((Control) this.txtOutput);
    this.groupBox2.Location = new Point(469, 40);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(361, 223);
    this.groupBox2.TabIndex = 51;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Output (0)";
    this.txtOutput.Location = new Point(6, 22);
    this.txtOutput.Name = "txtOutput";
    this.txtOutput.Size = new Size(349, 194);
    this.txtOutput.TabIndex = 50;
    this.txtOutput.Text = "";
    this.txtOutput.WordWrap = false;
    this.txtOutput.TextChanged += new EventHandler(this.txtOutput_TextChanged);
    this.groupBox1.Controls.Add((Control) this.btnNhapTuFile);
    this.groupBox1.Controls.Add((Control) this.txtInput);
    this.groupBox1.Controls.Add((Control) this.txtNhapTuFile);
    this.groupBox1.Controls.Add((Control) this.rbTuNhap);
    this.groupBox1.Controls.Add((Control) this.rbNhapTuFile);
    this.groupBox1.Location = new Point(6, 40);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(361, 223);
    this.groupBox1.TabIndex = 51;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Input";
    this.btnNhapTuFile.Cursor = Cursors.Hand;
    this.btnNhapTuFile.Location = new Point(287, 22);
    this.btnNhapTuFile.Name = "btnNhapTuFile";
    this.btnNhapTuFile.Size = new Size(65, 24);
    this.btnNhapTuFile.TabIndex = 2;
    this.btnNhapTuFile.Text = "Chọn";
    this.btnNhapTuFile.UseSelectable = true;
    this.btnNhapTuFile.Click += new EventHandler(this.btnNhapTuFile_Click);
    this.txtInput.Location = new Point(30, 75);
    this.txtInput.Name = "txtInput";
    this.txtInput.Size = new Size(322, 141);
    this.txtInput.TabIndex = 50;
    this.txtInput.Text = "";
    this.txtInput.WordWrap = false;
    this.txtInput.TextChanged += new EventHandler(this.txtInput_TextChanged);
    this.txtNhapTuFile.Location = new Point(110, 22);
    this.txtNhapTuFile.Name = "txtNhapTuFile";
    this.txtNhapTuFile.Size = new Size(171, 23);
    this.txtNhapTuFile.TabIndex = 1;
    this.rbTuNhap.AutoSize = true;
    this.rbTuNhap.Cursor = Cursors.Hand;
    this.rbTuNhap.Location = new Point(9, 49);
    this.rbTuNhap.Name = "rbTuNhap";
    this.rbTuNhap.Size = new Size(94, 20);
    this.rbTuNhap.TabIndex = 0;
    this.rbTuNhap.Text = "Tự nhập (0)";
    this.rbTuNhap.UseVisualStyleBackColor = true;
    this.rbTuNhap.CheckedChanged += new EventHandler(this.rbTuNhap_CheckedChanged);
    this.rbNhapTuFile.AutoSize = true;
    this.rbNhapTuFile.Checked = true;
    this.rbNhapTuFile.Cursor = Cursors.Hand;
    this.rbNhapTuFile.Location = new Point(9, 23);
    this.rbNhapTuFile.Name = "rbNhapTuFile";
    this.rbNhapTuFile.Size = new Size(94, 20);
    this.rbNhapTuFile.TabIndex = 0;
    this.rbNhapTuFile.TabStop = true;
    this.rbNhapTuFile.Text = "Nhập từ File";
    this.rbNhapTuFile.UseVisualStyleBackColor = true;
    this.rbNhapTuFile.CheckedChanged += new EventHandler(this.rbNhapTuFile_CheckedChanged);
    this.btnAdd.BackColor = Color.Green;
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(379, 138);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(78, 29);
    this.btnAdd.TabIndex = 45;
    this.btnAdd.Text = "Start";
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
    this.bunifuCards2.Size = new Size(836, 37);
    this.bunifuCards2.TabIndex = 43;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.lblTitle);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(836, 31);
    this.pnlHeader.TabIndex = 9;
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) Resources.btnMinimize_Image;
    this.button2.Location = new Point(805, 1);
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
    this.lblTitle.Size = new Size(836, 31);
    this.lblTitle.TabIndex = 12;
    this.lblTitle.Text = "Lọc trùng dữ liệu";
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
    this.ClientSize = new Size(838, 270);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fTienIchLocTrung);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fTienIchLocTrung_Load);
    this.panel1.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
