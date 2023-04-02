// Decompiled with JetBrains decompiler
// Type: fTienIchTestSpinContent
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fTienIchTestSpinContent : Form
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
  private IContainer components;
  private GroupBox groupBox1;

  public fTienIchTestSpinContent()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void button2_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      this.txtOutput.Text = GClass19.smethod_28(this.txtInput.Text);
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) "Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
    }
  }

  private void txtInput_TextChanged(object sender, EventArgs e)
  {
  }

  private void method_0(object sender, EventArgs e)
  {
  }

  private void method_1(object sender, EventArgs e)
  {
  }

  private void txtOutput_TextChanged(object sender, EventArgs e)
  {
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void fTienIchTestSpinContent_Load(object sender, EventArgs e)
  {
    this.method_0((object) null, (EventArgs) null);
    this.method_1((object) null, (EventArgs) null);
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
    this.groupBox2.Text = "Output";
    this.txtOutput.Location = new Point(6, 22);
    this.txtOutput.Name = "txtOutput";
    this.txtOutput.Size = new Size(349, 194);
    this.txtOutput.TabIndex = 50;
    this.txtOutput.Text = "";
    this.txtOutput.WordWrap = false;
    this.txtOutput.TextChanged += new EventHandler(this.txtOutput_TextChanged);
    this.groupBox1.Controls.Add((Control) this.txtInput);
    this.groupBox1.Location = new Point(6, 40);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(361, 223);
    this.groupBox1.TabIndex = 51;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Input";
    this.txtInput.Location = new Point(6, 22);
    this.txtInput.Name = "txtInput";
    this.txtInput.Size = new Size(349, 194);
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
    this.btnAdd.Location = new Point(379, 138);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(78, 29);
    this.btnAdd.TabIndex = 45;
    this.btnAdd.Text = "Spin";
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
    this.lblTitle.Text = "Test Spin Content";
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
    this.Name = nameof (fTienIchTestSpinContent);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fTienIchTestSpinContent_Load);
    this.panel1.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
