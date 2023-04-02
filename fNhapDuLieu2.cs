// Decompiled with JetBrains decompiler
// Type: fNhapDuLieu2
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class fNhapDuLieu2 : Form
{
  private string string_0 = "";
  private Random random_0 = new Random();
  private bool bool_0 = false;
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
  private Button btnSave;
  private TextBox txtContent;
  private GroupBox groupBox1;
  private GroupBox groupBox2;
  public DataGridView dtgvDanhSach;
  private Button btnAdd;
  private DataGridViewTextBoxColumn cSTT;
  private DataGridViewTextBoxColumn cName;
  private DataGridViewButtonColumn cChiTiet;
  private DataGridViewButtonColumn cSua;
  private DataGridViewButtonColumn cXoa;
  private IContainer components;
  private Button btnHuy;

  public fNhapDuLieu2(string string_1, string string_2)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.string_0 = string_1;
    this.lblTitle.Text = string_2;
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.lblTitle);
    GClass35.smethod_1((Control) this.groupBox1);
    GClass35.smethod_1((Control) this.groupBox2);
    foreach (DataGridViewColumn column in (BaseCollection) this.dtgvDanhSach.Columns)
      GClass35.smethod_3(column);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnSave);
    GClass35.smethod_1((Control) this.btnHuy);
  }

  private void fNhapDuLieu2_Load(object sender, EventArgs e)
  {
    GClass19.smethod_34(this.string_0);
    this.method_2(this.string_0);
  }

  private void method_1(int int_0) => this.txtContent.Lines = File.ReadAllLines(Class14.smethod_3(this.dtgvDanhSach, int_0, "cName"));

  private void method_2(string string_1)
  {
    int num = -1;
    switch (this.dtgvDanhSach.RowCount)
    {
      case 0:
        this.dtgvDanhSach.Rows.Clear();
        List<string> list = ((IEnumerable<string>) Directory.GetFiles(string_1)).ToList<string>();
        for (int index = 0; index < list.Count; ++index)
          this.dtgvDanhSach.Rows.Add((object) (index + 1), (object) list[index], (object) GClass35.smethod_0("Chi tiết"), (object) GClass35.smethod_0("Sửa"), (object) GClass35.smethod_0("Xóa"));
        if (num == -1 && this.dtgvDanhSach.RowCount > 0)
          num = 0;
        else if (num + 1 > this.dtgvDanhSach.RowCount)
          num = this.dtgvDanhSach.RowCount - 1;
        if (num == -1)
        {
          this.txtContent.Text = "";
          break;
        }
        GClass19.smethod_33(this.dtgvDanhSach);
        this.dtgvDanhSach.Rows[num].Selected = true;
        this.method_1(num);
        break;
      case 1:
        num = 0;
        goto case 0;
      default:
        num = this.dtgvDanhSach.SelectedRows[0].Index;
        goto case 0;
    }
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void button2_Click(object sender, EventArgs e) => this.Close();

  private void method_3(int int_0)
  {
    if (int_0 == 1)
    {
      this.dtgvDanhSach.Enabled = false;
      this.btnAdd.Enabled = false;
      this.btnSave.Enabled = true;
      this.btnHuy.Enabled = true;
      this.txtContent.ReadOnly = false;
      this.txtContent.Focus();
    }
    else
    {
      this.dtgvDanhSach.Enabled = true;
      this.btnAdd.Enabled = true;
      this.btnSave.Enabled = false;
      this.btnHuy.Enabled = false;
      this.txtContent.ReadOnly = true;
    }
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      string path;
      do
      {
        path = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + GClass19.smethod_60(3, this.random_0) + ".txt";
      }
      while (File.Exists(path));
      string str = this.string_0 + "\\" + path;
      GClass19.smethod_32(str);
      this.txtContent.Lines = File.ReadAllLines(str);
      this.dtgvDanhSach.Rows.Add((object) (this.dtgvDanhSach.RowCount + 1), (object) str, (object) GClass35.smethod_0("Chi tiết"), (object) GClass35.smethod_0("Sửa"), (object) GClass35.smethod_0("Xóa"));
      GClass19.smethod_33(this.dtgvDanhSach);
      this.dtgvDanhSach.Rows[this.dtgvDanhSach.RowCount - 1].Selected = true;
      this.method_3(1);
      this.bool_0 = true;
    }
    catch
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
    }
  }

  private void txtContent_TextChanged(object sender, EventArgs e)
  {
  }

  private void dtgvDanhSach_MouseHover(object sender, EventArgs e)
  {
  }

  private void dtgvDanhSach_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
  {
    string name = this.dtgvDanhSach.Columns[e.ColumnIndex].Name;
    if (name != "cChiTiet" && name != "cSua" && name != "cXoa")
    {
      this.dtgvDanhSach.Cursor = Cursors.Default;
    }
    else
    {
      if (e.RowIndex >= this.dtgvDanhSach.RowCount)
        return;
      this.dtgvDanhSach.Cursor = Cursors.Hand;
    }
  }

  private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
    DataGridView dataGridView = (DataGridView) sender;
    if (!(dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0)
      return;
    switch (dataGridView.Columns[e.ColumnIndex].Name)
    {
      case "cXoa":
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn xóa?")) != DialogResult.Yes)
          break;
        File.Delete(Class14.smethod_3(this.dtgvDanhSach, e.RowIndex, "cName"));
        this.method_2(this.string_0);
        break;
      case "cSua":
        this.txtContent.Lines = File.ReadAllLines(Class14.smethod_3(this.dtgvDanhSach, e.RowIndex, "cName"));
        this.bool_0 = false;
        this.method_3(1);
        break;
      case "cChiTiet":
        this.method_1(e.RowIndex);
        break;
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      string str = this.dtgvDanhSach.SelectedRows[0].Cells["cName"].Value.ToString();
      GClass19.smethod_32(str);
      if (this.txtContent.Text.Trim() == "")
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung cần lưu!"), 3);
      }
      else
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn lưu lại?")) != DialogResult.Yes)
          return;
        File.WriteAllLines(str, this.txtContent.Lines);
        GClass14.smethod_0((object) GClass35.smethod_0("Lưu thành công!"));
        this.method_3(2);
      }
    }
    catch
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
    }
  }

  private void btnHuy_Click(object sender, EventArgs e)
  {
    try
    {
      string str = this.dtgvDanhSach.SelectedRows[0].Cells["cName"].Value.ToString();
      GClass19.smethod_32(str);
      if (GClass14.smethod_1(GClass35.smethod_0("Bạn có muốn hủy?")) != DialogResult.Yes)
        return;
      if (this.bool_0)
        File.Delete(str);
      this.method_3(2);
      this.method_2(this.string_0);
    }
    catch
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
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
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    this.bunifuCards1 = new BunifuCards();
    this.panel1 = new Panel();
    this.groupBox1 = new GroupBox();
    this.dtgvDanhSach = new DataGridView();
    this.cSTT = new DataGridViewTextBoxColumn();
    this.cName = new DataGridViewTextBoxColumn();
    this.cChiTiet = new DataGridViewButtonColumn();
    this.cSua = new DataGridViewButtonColumn();
    this.cXoa = new DataGridViewButtonColumn();
    this.btnAdd = new Button();
    this.groupBox2 = new GroupBox();
    this.txtContent = new TextBox();
    this.btnHuy = new Button();
    this.btnSave = new Button();
    this.bunifuCards2 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.btnMinimize = new Button();
    this.lblTitle = new BunifuCustomLabel();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.panel1.SuspendLayout();
    this.groupBox1.SuspendLayout();
    ((ISupportInitialize) this.dtgvDanhSach).BeginInit();
    this.groupBox2.SuspendLayout();
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
    this.bunifuCards1.Size = new Size(425, 47);
    this.bunifuCards1.TabIndex = 12;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.groupBox2);
    this.panel1.Controls.Add((Control) this.bunifuCards2);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Margin = new Padding(3, 4, 3, 4);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(754, 388);
    this.panel1.TabIndex = 37;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.groupBox1.Controls.Add((Control) this.dtgvDanhSach);
    this.groupBox1.Controls.Add((Control) this.btnAdd);
    this.groupBox1.Location = new Point(3, 43);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(284, 339);
    this.groupBox1.TabIndex = 50;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = " Danh sách nội dung";
    this.dtgvDanhSach.AllowUserToAddRows = false;
    this.dtgvDanhSach.AllowUserToDeleteRows = false;
    this.dtgvDanhSach.AllowUserToResizeRows = false;
    this.dtgvDanhSach.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = Color.Teal;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.dtgvDanhSach.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.dtgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgvDanhSach.Columns.AddRange((DataGridViewColumn) this.cSTT, (DataGridViewColumn) this.cName, (DataGridViewColumn) this.cChiTiet, (DataGridViewColumn) this.cSua, (DataGridViewColumn) this.cXoa);
    this.dtgvDanhSach.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.dtgvDanhSach.Location = new Point(6, 22);
    this.dtgvDanhSach.Name = "dtgvDanhSach";
    this.dtgvDanhSach.RowHeadersVisible = false;
    this.dtgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvDanhSach.Size = new Size(272, 277);
    this.dtgvDanhSach.TabIndex = 76;
    this.dtgvDanhSach.CellContentClick += new DataGridViewCellEventHandler(this.dtgvDanhSach_CellContentClick);
    this.dtgvDanhSach.CellMouseEnter += new DataGridViewCellEventHandler(this.dtgvDanhSach_CellMouseEnter);
    this.dtgvDanhSach.MouseHover += new EventHandler(this.dtgvDanhSach_MouseHover);
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.cSTT.DefaultCellStyle = gridViewCellStyle2;
    this.cSTT.HeaderText = "STT";
    this.cSTT.Name = "cSTT";
    this.cSTT.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cSTT.Width = 40;
    this.cName.HeaderText = "Tên file";
    this.cName.Name = "cName";
    this.cName.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cName.Visible = false;
    this.cChiTiet.HeaderText = "Chi tiết";
    this.cChiTiet.Name = "cChiTiet";
    this.cChiTiet.Resizable = DataGridViewTriState.True;
    this.cChiTiet.Width = 80;
    this.cSua.HeaderText = "Sửa";
    this.cSua.Name = "cSua";
    this.cSua.Resizable = DataGridViewTriState.True;
    this.cSua.Width = 71;
    this.cXoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cXoa.HeaderText = "Xóa";
    this.cXoa.Name = "cXoa";
    this.cXoa.Resizable = DataGridViewTriState.True;
    this.btnAdd.BackColor = Color.Green;
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(186, 303);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 45;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.groupBox2.Controls.Add((Control) this.txtContent);
    this.groupBox2.Controls.Add((Control) this.btnHuy);
    this.groupBox2.Controls.Add((Control) this.btnSave);
    this.groupBox2.Location = new Point(293, 43);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(455, 339);
    this.groupBox2.TabIndex = 50;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Chi tiết";
    this.txtContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtContent.Location = new Point(5, 22);
    this.txtContent.Multiline = true;
    this.txtContent.Name = "txtContent";
    this.txtContent.ReadOnly = true;
    this.txtContent.ScrollBars = ScrollBars.Both;
    this.txtContent.Size = new Size(444, 277);
    this.txtContent.TabIndex = 48;
    this.txtContent.WordWrap = false;
    this.txtContent.TextChanged += new EventHandler(this.txtContent_TextChanged);
    this.btnHuy.BackColor = Color.FromArgb(128, 64, 0);
    this.btnHuy.Cursor = Cursors.Hand;
    this.btnHuy.Enabled = false;
    this.btnHuy.FlatAppearance.BorderSize = 0;
    this.btnHuy.FlatStyle = FlatStyle.Flat;
    this.btnHuy.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnHuy.ForeColor = Color.White;
    this.btnHuy.Location = new Point(357, 304);
    this.btnHuy.Name = "btnHuy";
    this.btnHuy.Size = new Size(92, 29);
    this.btnHuy.TabIndex = 45;
    this.btnHuy.Text = "Hủy";
    this.btnHuy.UseVisualStyleBackColor = false;
    this.btnHuy.Click += new EventHandler(this.btnHuy_Click);
    this.btnSave.BackColor = Color.FromArgb(53, 120, 229);
    this.btnSave.Cursor = Cursors.Hand;
    this.btnSave.Enabled = false;
    this.btnSave.FlatAppearance.BorderSize = 0;
    this.btnSave.FlatStyle = FlatStyle.Flat;
    this.btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnSave.ForeColor = Color.White;
    this.btnSave.Location = new Point(256, 304);
    this.btnSave.Name = "btnSave";
    this.btnSave.Size = new Size(92, 29);
    this.btnSave.TabIndex = 45;
    this.btnSave.Text = "Lưu";
    this.btnSave.UseVisualStyleBackColor = false;
    this.btnSave.Click += new EventHandler(this.btnSave_Click);
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
    this.bunifuCards2.Size = new Size(752, 37);
    this.bunifuCards2.TabIndex = 43;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.lblTitle);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(752, 31);
    this.pnlHeader.TabIndex = 9;
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) Resources.btnMinimize_Image;
    this.button2.Location = new Point(721, 1);
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
    this.lblTitle.Size = new Size(752, 31);
    this.lblTitle.TabIndex = 12;
    this.lblTitle.Text = "Nhập nội dung comment";
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
    this.ClientSize = new Size(754, 388);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fNhapDuLieu2);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fNhapDuLieu2_Load);
    this.panel1.ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    ((ISupportInitialize) this.dtgvDanhSach).EndInit();
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
