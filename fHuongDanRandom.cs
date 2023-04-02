// Decompiled with JetBrains decompiler
// Type: fHuongDanRandom
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fHuongDanRandom : Form
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
  private BunifuCustomLabel bunifuCustomLabel1;
  private ContextMenuStrip contextMenuStrip1;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private DataGridView dgv;
  private DataGridViewTextBoxColumn cSTT;
  private DataGridViewTextBoxColumn cTuKhoa;
  private IContainer components;
  private DataGridViewImageColumn cNoiDung;

  public fHuongDanRandom()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.method_1();
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    foreach (DataGridViewColumn column in (BaseCollection) this.dgv.Columns)
      GClass35.smethod_3(column);
  }

  private void method_1()
  {
    Random random = new Random();
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[r1]", (object) Resource.Bitmap_65);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[r2]", (object) Resource.Bitmap_66);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[r3]", (object) Resource.Bitmap_67);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[r4]", (object) Resource.Bitmap_68);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[r5]", (object) Resource.Bitmap_69);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[r6]", (object) Resource.Bitmap_70);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[r7]", (object) Resource.Bitmap_71);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[r8]", (object) Resource.Bitmap_72);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[d]", (object) Resource.Bitmap_73);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[t]", (object) Resource.Bitmap_74);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[n*]", (object) Resource.Bitmap_75);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[s*]", (object) Resource.Bitmap_76);
    this.dgv.Rows.Add((object) (this.dgv.RowCount + 1), (object) "[q***]", (object) Resource.Bitmap_77);
  }

  private void fHuongDanRandom_Load(object sender, EventArgs e)
  {
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void button2_Click(object sender, EventArgs e) => this.Close();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    this.bunifuCards1 = new BunifuCards();
    this.panel1 = new Panel();
    this.dgv = new DataGridView();
    this.cSTT = new DataGridViewTextBoxColumn();
    this.cTuKhoa = new DataGridViewTextBoxColumn();
    this.cNoiDung = new DataGridViewImageColumn();
    this.bunifuCards2 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.contextMenuStrip1 = new ContextMenuStrip(this.components);
    this.toolStripMenuItem_0 = new ToolStripMenuItem();
    this.toolStripMenuItem_1 = new ToolStripMenuItem();
    this.toolStripMenuItem_2 = new ToolStripMenuItem();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.dgv).BeginInit();
    this.bunifuCards2.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.contextMenuStrip1.SuspendLayout();
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
    this.bunifuCards1.Size = new Size(243, 47);
    this.bunifuCards1.TabIndex = 12;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.dgv);
    this.panel1.Controls.Add((Control) this.bunifuCards2);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Margin = new Padding(3, 4, 3, 4);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(572, 503);
    this.panel1.TabIndex = 37;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.dgv.AllowUserToAddRows = false;
    this.dgv.AllowUserToDeleteRows = false;
    this.dgv.AllowUserToResizeRows = false;
    this.dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
    this.dgv.BackgroundColor = Color.White;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.dgv.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgv.Columns.AddRange((DataGridViewColumn) this.cSTT, (DataGridViewColumn) this.cTuKhoa, (DataGridViewColumn) this.cNoiDung);
    this.dgv.Location = new Point(11, 43);
    this.dgv.Name = "dgv";
    this.dgv.ReadOnly = true;
    this.dgv.RowHeadersVisible = false;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle2.ForeColor = Color.Black;
    gridViewCellStyle2.SelectionBackColor = Color.White;
    gridViewCellStyle2.SelectionForeColor = Color.Black;
    this.dgv.RowsDefaultCellStyle = gridViewCellStyle2;
    this.dgv.RowTemplate.Resizable = DataGridViewTriState.True;
    this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dgv.Size = new Size(547, 447);
    this.dgv.TabIndex = 75;
    this.cSTT.HeaderText = "STT";
    this.cSTT.Name = "cSTT";
    this.cSTT.ReadOnly = true;
    this.cSTT.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cSTT.Width = 40;
    this.cTuKhoa.HeaderText = "Từ khóa";
    this.cTuKhoa.Name = "cTuKhoa";
    this.cTuKhoa.ReadOnly = true;
    this.cTuKhoa.Width = 80;
    this.cNoiDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cNoiDung.HeaderText = "Nội dung random";
    this.cNoiDung.Name = "cNoiDung";
    this.cNoiDung.ReadOnly = true;
    this.cNoiDung.Resizable = DataGridViewTriState.True;
    this.cNoiDung.SortMode = DataGridViewColumnSortMode.Automatic;
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
    this.bunifuCards2.Size = new Size(570, 37);
    this.bunifuCards2.TabIndex = 43;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(570, 31);
    this.pnlHeader.TabIndex = 9;
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) Resources.btnMinimize_Image;
    this.button2.Location = new Point(539, 1);
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
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(570, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Hướng dẫn random nội dung";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.contextMenuStrip1.Items.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.toolStripMenuItem_0,
      (ToolStripItem) this.toolStripMenuItem_1,
      (ToolStripItem) this.toolStripMenuItem_2
    });
    this.contextMenuStrip1.Name = "contextMenuStrip1";
    this.contextMenuStrip1.Size = new Size(153, 70);
    this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
    this.toolStripMenuItem_0.Size = new Size(152, 22);
    this.toolStripMenuItem_0.Text = "Thêm chủ đề";
    this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
    this.toolStripMenuItem_1.Size = new Size(152, 22);
    this.toolStripMenuItem_1.Text = "Sửa tên chủ đề";
    this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
    this.toolStripMenuItem_2.Size = new Size(152, 22);
    this.toolStripMenuItem_2.Text = "Xóa chủ đề";
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 10000;
    this.toolTip_0.InitialDelay = 200;
    this.toolTip_0.ReshowDelay = 40;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(572, 503);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fHuongDanRandom);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fHuongDanRandom_Load);
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.dgv).EndInit();
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.contextMenuStrip1.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
