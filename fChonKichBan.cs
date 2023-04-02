// Decompiled with JetBrains decompiler
// Type: fChonKichBan
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fChonKichBan : Form
{
  private IContainer icontainer_0 = (IContainer) null;
  private ToolTip toolTip_0;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private GroupBox groupBox1;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button button1;
  public DataGridView dtgvKichBan;
  private Panel panel1;
  private Button button2;
  private Button button3;
  private GroupBox groupBox2;
  private Label label2;
  private Button btnCancel;
  private Button btnSave;
  private Label lblCountAcc;
  private Label label7;
  private Label label1;
  public DataGridView dtgvKichBanChoose;
  private DataGridViewTextBoxColumn cStt;
  private DataGridViewTextBoxColumn cIdKichBan;
  private DataGridViewTextBoxColumn cTenKichBan;
  private DataGridViewTextBoxColumn cSTTChoose;
  private DataGridViewTextBoxColumn cIdKichBanChoose;
  private IContainer components;
  private DataGridViewTextBoxColumn cTenKichBanChoose;

  public fChonKichBan()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void fChonKichBan_Load(object sender, EventArgs e)
  {
    this.method_0();
    this.method_0(GClass33.smethod_0("configInteractGeneral").method_2("lstIdKichBan"));
  }

  private void method_0(List<string> list_0 = null)
  {
    try
    {
      if (list_0 != null && list_0.Count > 0)
      {
        this.dtgvKichBanChoose.Rows.Clear();
        for (int index = 0; index < list_0.Count; ++index)
        {
          DataTable dataTable = Class205.smethod_2(list_0[index]);
          if (dataTable.Rows.Count > 0)
          {
            DataRow row = dataTable.Rows[0];
            this.dtgvKichBanChoose.Rows.Add((object) (this.dtgvKichBanChoose.RowCount + 1), row["Id_KichBan"], row["TenKichBan"]);
          }
        }
      }
      else
      {
        this.dtgvKichBan.Rows.Clear();
        DataTable dataTable = Class205.smethod_4();
        if (dataTable.Rows.Count <= 0)
          return;
        for (int index = 0; index < dataTable.Rows.Count; ++index)
        {
          DataRow row = dataTable.Rows[index];
          this.dtgvKichBan.Rows.Add((object) (index + 1), row["Id_KichBan"], row["TenKichBan"]);
        }
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
    }
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  public void method_1(ref DataGridView dataGridView_0, int int_0, int int_1)
  {
    for (int int_1_1 = 1; int_1_1 < dataGridView_0.Columns.Count; ++int_1_1)
    {
      string object_0 = Class14.smethod_2(dataGridView_0, int_0, int_1_1);
      Class14.smethod_4(dataGridView_0, int_0, int_1_1, (object) Class14.smethod_2(dataGridView_0, int_1, int_1_1));
      Class14.smethod_4(dataGridView_0, int_1, int_1_1, (object) object_0);
    }
  }

  private void button2_Click(object sender, EventArgs e)
  {
    int index = this.dtgvKichBanChoose.SelectedRows[0].Index;
    if (index == 0 || !(Class14.smethod_3(this.dtgvKichBanChoose, index - 1, "cIdKichBanChoose") + Class14.smethod_3(this.dtgvKichBanChoose, index, "cIdKichBanChoose") != ""))
      return;
    this.method_1(ref this.dtgvKichBanChoose, index, index - 1);
    this.dtgvKichBanChoose.Rows[index - 1].Selected = true;
  }

  private void button3_Click(object sender, EventArgs e)
  {
    int index = this.dtgvKichBanChoose.SelectedRows[0].Index;
    if (index == this.dtgvKichBanChoose.RowCount - 1 || !(Class14.smethod_3(this.dtgvKichBanChoose, index + 1, "cIdKichBanChoose") + Class14.smethod_3(this.dtgvKichBanChoose, index, "cIdKichBanChoose") != ""))
      return;
    this.method_1(ref this.dtgvKichBanChoose, index, index + 1);
    this.dtgvKichBanChoose.Rows[index + 1].Selected = true;
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
    if (this.panel1.BorderStyle != BorderStyle.FixedSingle)
      return;
    int num1 = 1;
    int num2 = 0;
    using (Pen pen1 = new Pen(Color.DarkViolet, 1f))
    {
      Graphics graphics = e.Graphics;
      Pen pen2 = pen1;
      int x = num2;
      int y = num2;
      Size clientSize = this.panel1.ClientSize;
      int width = clientSize.Width - num1;
      clientSize = this.panel1.ClientSize;
      int height = clientSize.Height - num1;
      Rectangle rect = new Rectangle(x, y, width, height);
      graphics.DrawRectangle(pen2, rect);
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private bool method_2(string string_0)
  {
    bool flag = false;
    for (int index = 0; index < this.dtgvKichBanChoose.RowCount; ++index)
    {
      if (string_0 == this.dtgvKichBanChoose.Rows[index].Cells[1].Value.ToString())
      {
        flag = true;
        break;
      }
    }
    return flag;
  }

  private void dtgvKichBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    int int32 = Convert.ToInt32(this.dtgvKichBan.SelectedRows[0].Cells[1].Value);
    string str = this.dtgvKichBan.SelectedRows[0].Cells[2].Value.ToString();
    if (this.method_2(int32.ToString()))
      return;
    this.dtgvKichBanChoose.Rows.Add((object) (this.dtgvKichBanChoose.RowCount + 1), (object) int32, (object) str);
  }

  private void dtgvKichBanChoose_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    this.dtgvKichBanChoose.Rows.RemoveAt(this.dtgvKichBanChoose.SelectedRows[0].Index);
    for (int int_0 = 0; int_0 < this.dtgvKichBanChoose.RowCount; ++int_0)
      Class14.Status(this.dtgvKichBanChoose, int_0, "cSTTChoose", (object) (int_0 + 1));
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> list_0 = new List<string>();
      for (int int_0 = 0; int_0 < this.dtgvKichBanChoose.RowCount; ++int_0)
        list_0.Add(Class14.smethod_3(this.dtgvKichBanChoose, int_0, "cIdKichBanChoose"));
      GClass33.smethod_0("configInteractGeneral").method_8("lstIdKichBan", list_0);
      GClass33.smethod_2("configInteractGeneral");
      this.Close();
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 3);
    }
  }

  private void dtgvKichBanChoose_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => this.lblCountAcc.Text = this.dtgvKichBanChoose.RowCount.ToString();

  private void dtgvKichBanChoose_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => this.lblCountAcc.Text = this.dtgvKichBanChoose.RowCount.ToString();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fChonKichBan));
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    this.toolTip_0 = new ToolTip(this.components);
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.groupBox1 = new GroupBox();
    this.label2 = new Label();
    this.dtgvKichBan = new DataGridView();
    this.cStt = new DataGridViewTextBoxColumn();
    this.cIdKichBan = new DataGridViewTextBoxColumn();
    this.cTenKichBan = new DataGridViewTextBoxColumn();
    this.bunifuCards1 = new BunifuCards();
    this.panel1 = new Panel();
    this.btnCancel = new Button();
    this.btnSave = new Button();
    this.groupBox2 = new GroupBox();
    this.lblCountAcc = new Label();
    this.label7 = new Label();
    this.label1 = new Label();
    this.button3 = new Button();
    this.dtgvKichBanChoose = new DataGridView();
    this.cSTTChoose = new DataGridViewTextBoxColumn();
    this.cIdKichBanChoose = new DataGridViewTextBoxColumn();
    this.cTenKichBanChoose = new DataGridViewTextBoxColumn();
    this.button2 = new Button();
    this.pnlHeader.SuspendLayout();
    this.groupBox1.SuspendLayout();
    ((ISupportInitialize) this.dtgvKichBan).BeginInit();
    this.bunifuCards1.SuspendLayout();
    this.panel1.SuspendLayout();
    this.groupBox2.SuspendLayout();
    ((ISupportInitialize) this.dtgvKichBanChoose).BeginInit();
    this.SuspendLayout();
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 10000;
    this.toolTip_0.InitialDelay = 200;
    this.toolTip_0.ReshowDelay = 40;
    this.toolTip_0.ToolTipTitle = "Chú thích";
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
    this.bunifuCustomLabel1.Size = new Size(696, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Chọn danh sách kịch bản chạy";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button1);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(696, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(667, 2);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.groupBox1.BackColor = Color.White;
    this.groupBox1.Controls.Add((Control) this.label2);
    this.groupBox1.Controls.Add((Control) this.dtgvKichBan);
    this.groupBox1.Location = new Point(12, 41);
    this.groupBox1.Margin = new Padding(3, 4, 3, 4);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Padding = new Padding(3, 4, 3, 4);
    this.groupBox1.Size = new Size(308, 302);
    this.groupBox1.TabIndex = 1;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Danh sách kịch bản";
    this.label2.AutoSize = true;
    this.label2.ForeColor = Color.Red;
    this.label2.Location = new Point(3, 281);
    this.label2.Name = "label2";
    this.label2.Size = new Size(192, 16);
    this.label2.TabIndex = 81;
    this.label2.Text = "(Click đúp vào kịch bản để chọn)";
    this.dtgvKichBan.AllowUserToAddRows = false;
    this.dtgvKichBan.AllowUserToDeleteRows = false;
    this.dtgvKichBan.AllowUserToResizeRows = false;
    this.dtgvKichBan.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = Color.Teal;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.dtgvKichBan.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.dtgvKichBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgvKichBan.Columns.AddRange((DataGridViewColumn) this.cStt, (DataGridViewColumn) this.cIdKichBan, (DataGridViewColumn) this.cTenKichBan);
    this.dtgvKichBan.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.dtgvKichBan.Location = new Point(6, 20);
    this.dtgvKichBan.MultiSelect = false;
    this.dtgvKichBan.Name = "dtgvKichBan";
    this.dtgvKichBan.RowHeadersVisible = false;
    this.dtgvKichBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvKichBan.Size = new Size(296, 258);
    this.dtgvKichBan.TabIndex = 76;
    this.dtgvKichBan.CellDoubleClick += new DataGridViewCellEventHandler(this.dtgvKichBan_CellDoubleClick);
    this.cStt.HeaderText = "STT";
    this.cStt.Name = "cStt";
    this.cStt.Width = 35;
    this.cIdKichBan.HeaderText = "Id kịch bản";
    this.cIdKichBan.Name = "cIdKichBan";
    this.cIdKichBan.Visible = false;
    this.cTenKichBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cTenKichBan.HeaderText = "Tên kịch bản";
    this.cTenKichBan.Name = "cTenKichBan";
    this.cTenKichBan.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.DarkViolet;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(1, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(699, 37);
    this.bunifuCards1.TabIndex = 12;
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnSave);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Controls.Add((Control) this.groupBox2);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(702, 391);
    this.panel1.TabIndex = 13;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(359, 350);
    this.btnCancel.Margin = new Padding(3, 4, 3, 4);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 22;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnSave.BackColor = Color.FromArgb(53, 120, 229);
    this.btnSave.Cursor = Cursors.Hand;
    this.btnSave.FlatAppearance.BorderSize = 0;
    this.btnSave.FlatStyle = FlatStyle.Flat;
    this.btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnSave.ForeColor = Color.White;
    this.btnSave.Location = new Point(252, 350);
    this.btnSave.Margin = new Padding(3, 4, 3, 4);
    this.btnSave.Name = "btnSave";
    this.btnSave.Size = new Size(92, 29);
    this.btnSave.TabIndex = 21;
    this.btnSave.Text = "Lưu";
    this.btnSave.UseVisualStyleBackColor = false;
    this.btnSave.Click += new EventHandler(this.btnSave_Click);
    this.groupBox2.BackColor = Color.White;
    this.groupBox2.Controls.Add((Control) this.lblCountAcc);
    this.groupBox2.Controls.Add((Control) this.label7);
    this.groupBox2.Controls.Add((Control) this.label1);
    this.groupBox2.Controls.Add((Control) this.button3);
    this.groupBox2.Controls.Add((Control) this.dtgvKichBanChoose);
    this.groupBox2.Controls.Add((Control) this.button2);
    this.groupBox2.Location = new Point(325, 40);
    this.groupBox2.Margin = new Padding(3, 4, 3, 4);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Padding = new Padding(3, 4, 3, 4);
    this.groupBox2.Size = new Size(363, 302);
    this.groupBox2.TabIndex = 1;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Kịch bản cần chạy";
    this.lblCountAcc.AutoSize = true;
    this.lblCountAcc.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.lblCountAcc.ForeColor = Color.Blue;
    this.lblCountAcc.Location = new Point(297, 281);
    this.lblCountAcc.Name = "lblCountAcc";
    this.lblCountAcc.Size = new Size(15, 16);
    this.lblCountAcc.TabIndex = 82;
    this.lblCountAcc.Text = "0";
    this.label7.AutoSize = true;
    this.label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label7.Location = new Point((int) byte.MaxValue, 281);
    this.label7.Name = "label7";
    this.label7.Size = new Size(43, 16);
    this.label7.TabIndex = 83;
    this.label7.Text = "Tổng:";
    this.label1.AutoSize = true;
    this.label1.ForeColor = Color.Red;
    this.label1.Location = new Point(4, 282);
    this.label1.Name = "label1";
    this.label1.Size = new Size(185, 16);
    this.label1.TabIndex = 81;
    this.label1.Text = "(Click đúp vào kịch bản để xóa)";
    this.button3.Cursor = Cursors.Hand;
    this.button3.Location = new Point(314, 64);
    this.button3.Name = "button3";
    this.button3.Size = new Size(41, 38);
    this.button3.TabIndex = 78;
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.dtgvKichBanChoose.AllowUserToAddRows = false;
    this.dtgvKichBanChoose.AllowUserToDeleteRows = false;
    this.dtgvKichBanChoose.AllowUserToResizeRows = false;
    this.dtgvKichBanChoose.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = Color.Teal;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.dtgvKichBanChoose.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.dtgvKichBanChoose.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgvKichBanChoose.Columns.AddRange((DataGridViewColumn) this.cSTTChoose, (DataGridViewColumn) this.cIdKichBanChoose, (DataGridViewColumn) this.cTenKichBanChoose);
    this.dtgvKichBanChoose.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.dtgvKichBanChoose.Location = new Point(6, 20);
    this.dtgvKichBanChoose.MultiSelect = false;
    this.dtgvKichBanChoose.Name = "dtgvKichBanChoose";
    this.dtgvKichBanChoose.RowHeadersVisible = false;
    this.dtgvKichBanChoose.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvKichBanChoose.Size = new Size(302, 258);
    this.dtgvKichBanChoose.TabIndex = 76;
    this.dtgvKichBanChoose.CellDoubleClick += new DataGridViewCellEventHandler(this.dtgvKichBanChoose_CellDoubleClick);
    this.dtgvKichBanChoose.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dtgvKichBanChoose_RowsAdded);
    this.dtgvKichBanChoose.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dtgvKichBanChoose_RowsRemoved);
    this.cSTTChoose.HeaderText = "STT";
    this.cSTTChoose.Name = "cSTTChoose";
    this.cSTTChoose.Width = 35;
    this.cIdKichBanChoose.HeaderText = "Id kịch bản";
    this.cIdKichBanChoose.Name = "cIdKichBanChoose";
    this.cIdKichBanChoose.Visible = false;
    this.cTenKichBanChoose.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cTenKichBanChoose.HeaderText = "Tên kịch bản";
    this.cTenKichBanChoose.Name = "cTenKichBanChoose";
    this.cTenKichBanChoose.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.button2.Cursor = Cursors.Hand;
    this.button2.Location = new Point(314, 19);
    this.button2.Name = "button2";
    this.button2.Size = new Size(41, 38);
    this.button2.TabIndex = 78;
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(702, 391);
    this.Controls.Add((Control) this.groupBox1);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fChonKichBan);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fChonKichBan_Load);
    this.pnlHeader.ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    ((ISupportInitialize) this.dtgvKichBan).EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    ((ISupportInitialize) this.dtgvKichBanChoose).EndInit();
    this.ResumeLayout(false);
  }
}
