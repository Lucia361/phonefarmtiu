// Decompiled with JetBrains decompiler
// Type: fChonBrandDevice
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fChonBrandDevice : Form
{
  public List<string> list_0 = new List<string>();
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuDragControl bunifuDragControl_0;
  private Label label1;
  private Label lblCountTotal;
  private Label label3;
  private Label lblCountChoose;
  private Label label2;
  public DataGridView dtgvAcc;
  private CheckBox checkBox1;
  private DataGridViewCheckBoxColumn cChose;
  private DataGridViewTextBoxColumn cStt;
  private DataGridViewTextBoxColumn cBrandDevice;
  private IContainer components;
  private Panel panel1;

  public fChonBrandDevice(List<string> list_1)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.list_0 = list_1;
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    this.list_0 = new List<string>();
    for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        this.list_0.Add(Class14.smethod_3(this.dtgvAcc, index, "cBrandDevice"));
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void fChonBrandDevice_Load(object sender, EventArgs e) => this.method_0();

  private void method_0()
  {
    try
    {
      List<string> stringList = new List<string>()
      {
        "vsmart",
        "google",
        "samsung",
        "LGE",
        "YuLong",
        "OPPO",
        "vivo",
        "realme",
        "Xiaomi",
        "Redmi",
        "Asus",
        "Huawei",
        "Sony",
        "Sharp",
        "motorola",
        "Fujitsu",
        "Kyocera",
        "FREETEL",
        "Nokia",
        "ZTE",
        "Lenovo",
        "HONOR",
        "HTC",
        "Essential",
        "Verizon",
        "Panasonic",
        "VAIO",
        "micromax",
        "MetroPCS",
        "NEC"
      };
      for (int index = 0; index < stringList.Count; ++index)
        this.dtgvAcc.Rows.Add((object) this.list_0.Contains(stringList[index]), (object) (index + 1), (object) stringList[index]);
      this.method_1();
      this.method_2();
      if (this.method_3() == this.dtgvAcc.RowCount)
        this.checkBox1.Checked = true;
      else
        this.checkBox1.Checked = false;
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
    }
  }

  private void method_1()
  {
    try
    {
      this.lblCountChoose.Text = this.method_3().ToString();
    }
    catch
    {
    }
  }

  private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex != 0)
      return;
    this.method_1();
    this.checkBox1.Checked = this.method_3() == this.dtgvAcc.RowCount;
  }

  private void method_2()
  {
    try
    {
      this.lblCountTotal.Text = this.dtgvAcc.Rows.Count.ToString();
    }
    catch
    {
    }
  }

  private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    try
    {
      this.dtgvAcc.CurrentRow.Cells["cChose"].Value = (object) !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value);
    }
    catch
    {
    }
  }

  private int method_3()
  {
    int num = 0;
    for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        ++num;
    }
    return num;
  }

  private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex != 0)
      return;
    try
    {
      if (Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value))
        this.dtgvAcc.CurrentRow.Cells["cChose"].Value = (object) false;
      else
        this.dtgvAcc.CurrentRow.Cells["cChose"].Value = (object) true;
    }
    catch
    {
    }
  }

  private void checkBox1_Click(object sender, EventArgs e)
  {
    if (this.checkBox1.Checked)
    {
      for (int int_0 = 0; int_0 < this.dtgvAcc.Rows.Count; ++int_0)
        Class14.Status(this.dtgvAcc, int_0, "cChose", (object) true);
    }
    else
    {
      for (int int_0 = 0; int_0 < this.dtgvAcc.Rows.Count; ++int_0)
        Class14.Status(this.dtgvAcc, int_0, "cChose", (object) false);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fChonBrandDevice));
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.label1 = new Label();
    this.lblCountTotal = new Label();
    this.label3 = new Label();
    this.lblCountChoose = new Label();
    this.label2 = new Label();
    this.dtgvAcc = new DataGridView();
    this.cChose = new DataGridViewCheckBoxColumn();
    this.cStt = new DataGridViewTextBoxColumn();
    this.cBrandDevice = new DataGridViewTextBoxColumn();
    this.checkBox1 = new CheckBox();
    this.panel1 = new Panel();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    ((ISupportInitialize) this.dtgvAcc).BeginInit();
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
    this.bunifuCards1.Size = new Size(317, 34);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(317, 28);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(285, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 28);
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
    this.bunifuCustomLabel1.Size = new Size(317, 28);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Chọn Danh sách brand device";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(156, 280);
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
    this.btnAdd.Location = new Point(52, 280);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Lưu";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(153, 252);
    this.label1.Name = "label1";
    this.label1.Size = new Size(59, 16);
    this.label1.TabIndex = 6;
    this.label1.Text = "Tổng số:";
    this.label1.TextAlign = ContentAlignment.MiddleRight;
    this.lblCountTotal.AutoSize = true;
    this.lblCountTotal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCountTotal.ForeColor = Color.DarkRed;
    this.lblCountTotal.Location = new Point(211, 253);
    this.lblCountTotal.Name = "lblCountTotal";
    this.lblCountTotal.Size = new Size(14, 16);
    this.lblCountTotal.TabIndex = 6;
    this.lblCountTotal.Text = "0";
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(49, 252);
    this.label3.Name = "label3";
    this.label3.Size = new Size(59, 16);
    this.label3.TabIndex = 6;
    this.label3.Text = "Đã chọn:";
    this.lblCountChoose.AutoSize = true;
    this.lblCountChoose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCountChoose.ForeColor = Color.DarkGreen;
    this.lblCountChoose.Location = new Point(107, 253);
    this.lblCountChoose.Name = "lblCountChoose";
    this.lblCountChoose.Size = new Size(14, 16);
    this.lblCountChoose.TabIndex = 6;
    this.lblCountChoose.Text = "0";
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.ForeColor = Color.DarkRed;
    this.label2.Location = new Point(12, 227);
    this.label2.Name = "label2";
    this.label2.Size = new Size(177, 16);
    this.label2.TabIndex = 6;
    this.label2.Text = "(Click đúp vào dòng để chọn!)";
    this.dtgvAcc.AllowUserToAddRows = false;
    this.dtgvAcc.AllowUserToDeleteRows = false;
    this.dtgvAcc.AllowUserToResizeRows = false;
    this.dtgvAcc.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = Color.Teal;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.dtgvAcc.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.dtgvAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgvAcc.Columns.AddRange((DataGridViewColumn) this.cChose, (DataGridViewColumn) this.cStt, (DataGridViewColumn) this.cBrandDevice);
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.dtgvAcc.DefaultCellStyle = gridViewCellStyle2;
    this.dtgvAcc.Location = new Point(15, 40);
    this.dtgvAcc.Name = "dtgvAcc";
    this.dtgvAcc.ReadOnly = true;
    this.dtgvAcc.RowHeadersVisible = false;
    this.dtgvAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvAcc.Size = new Size(287, 184);
    this.dtgvAcc.TabIndex = 7;
    this.dtgvAcc.CellClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellClick);
    this.dtgvAcc.CellDoubleClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
    this.dtgvAcc.CellValueChanged += new DataGridViewCellEventHandler(this.dtgvAcc_CellValueChanged);
    this.cChose.HeaderText = "";
    this.cChose.Name = "cChose";
    this.cChose.ReadOnly = true;
    this.cChose.Resizable = DataGridViewTriState.False;
    this.cChose.Width = 30;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.cStt.DefaultCellStyle = gridViewCellStyle3;
    this.cStt.HeaderText = "STT";
    this.cStt.Name = "cStt";
    this.cStt.ReadOnly = true;
    this.cStt.Resizable = DataGridViewTriState.False;
    this.cStt.Width = 35;
    this.cBrandDevice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cBrandDevice.HeaderText = "Brand Device";
    this.cBrandDevice.Name = "cBrandDevice";
    this.cBrandDevice.ReadOnly = true;
    this.checkBox1.AutoSize = true;
    this.checkBox1.Cursor = Cursors.Hand;
    this.checkBox1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.checkBox1.Location = new Point(25, 45);
    this.checkBox1.Name = "checkBox1";
    this.checkBox1.Size = new Size(15, 14);
    this.checkBox1.TabIndex = 8;
    this.checkBox1.UseVisualStyleBackColor = true;
    this.checkBox1.Click += new EventHandler(this.checkBox1_Click);
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(317, 322);
    this.panel1.TabIndex = 9;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(317, 322);
    this.Controls.Add((Control) this.checkBox1);
    this.Controls.Add((Control) this.dtgvAcc);
    this.Controls.Add((Control) this.lblCountChoose);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.lblCountTotal);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Controls.Add((Control) this.panel1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fChonBrandDevice);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Chọn brand device";
    this.Load += new EventHandler(this.fChonBrandDevice_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    ((ISupportInitialize) this.dtgvAcc).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
