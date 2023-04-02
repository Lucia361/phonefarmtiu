// Decompiled with JetBrains decompiler
// Type: fQuanLyNhom
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class fQuanLyNhom : Form
{
  public bool bool_0 = false;
  private List<string> list_0 = new List<string>();
  private List<string> list_1 = new List<string>();
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private BunifuDragControl bunifuDragControl_0;
  private MetroComboBox cbbKiemDuyet;
  private Label label1;
  public DataGridView dtgvAcc;
  private DataGridViewCheckBoxColumn cChose;
  private DataGridViewTextBoxColumn cStt;
  private DataGridViewTextBoxColumn cId;
  private DataGridViewTextBoxColumn cTen;
  private DataGridViewTextBoxColumn cThanhVien;
  private DataGridViewTextBoxColumn cKiemDuyet;
  private MetroContextMenu ctmsAcc;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem liveToolStripMenuItem;
  private ToolStripMenuItem tinhTrangToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem toolStripMenuItem_4;
  private ToolStripMenuItem toolStripMenuItem_5;
  private ToolStripMenuItem trueToolStripMenuItem;
  private ToolStripMenuItem falseToolStripMenuItem;
  private StatusStrip statusStrip1;
  private ToolStripStatusLabel toolStripStatusLabel4;
  private ToolStripStatusLabel lblCountHighline;
  private ToolStripStatusLabel toolStripStatusLabel5;
  private ToolStripStatusLabel lblCountSelect;
  private ToolStripStatusLabel toolStripStatusLabel2;
  private IContainer components;
  private ToolStripStatusLabel lblCountTotal;

  public fQuanLyNhom()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void fQuanLyNhom_Load(object sender, EventArgs e)
  {
    this.method_2();
    this.method_0();
  }

  private void method_0()
  {
    try
    {
      this.list_1 = new List<string>();
      this.list_0 = new List<string>();
      foreach (string file in Directory.GetFiles("backupgroup"))
      {
        List<string> list = ((IEnumerable<string>) File.ReadAllText(file).Split(new char[2]
        {
          '\r',
          '\n'
        }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();
        for (int index = 0; index < list.Count; ++index)
        {
          try
          {
            string str = list[index].Replace(" |", " *").Replace("| ", "* ");
            if (str.Split('|').Length < 4)
            {
              int num = 0;
              while (true)
              {
                if (num < 4 - str.Split('|').Length)
                {
                  str += "|";
                  ++num;
                }
                else
                  break;
              }
            }
            if (!this.list_1.Contains(str.Split('|')[0]))
            {
              this.list_1.Add(str.Split('|')[0]);
              this.list_0.Add(str);
            }
          }
          catch
          {
          }
        }
      }
      this.dtgvAcc.Rows.Clear();
      for (int index = 0; index < this.list_0.Count; ++index)
      {
        try
        {
          string str = this.list_0[index];
          this.dtgvAcc.Rows.Add((object) false, (object) (this.dtgvAcc.RowCount + 1), (object) str.Split('|')[0], (object) str.Split('|')[1], (object) str.Split('|')[2], (object) str.Split('|')[3].ToUpper());
        }
        catch
        {
        }
      }
      this.method_5();
    }
    catch
    {
    }
  }

  private void method_1()
  {
    for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
      this.method_3(int_0, "cStt", (object) (int_0 + 1));
  }

  private void method_2() => GClass19.smethod_116((ComboBox) this.cbbKiemDuyet, new List<string>()
  {
    "Tất cả",
    "Kiểm duyệt",
    "Không kiểm duyệt"
  });

  private void toolStripMenuItem_5_Click(object sender, EventArgs e) => this.method_0();

  public void method_3(int int_0, string string_0, object object_0) => Class14.Status(this.dtgvAcc, int_0, string_0, object_0);

  public string method_4(int int_0, string string_0) => Class14.smethod_3(this.dtgvAcc, int_0, string_0);

  private void method_5()
  {
    try
    {
      this.lblCountTotal.Text = this.dtgvAcc.RowCount.ToString();
    }
    catch
    {
    }
  }

  private void method_6(int int_0 = -1)
  {
    if (int_0 == -1)
    {
      int_0 = 0;
      for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          ++int_0;
      }
    }
    this.lblCountSelect.Text = int_0.ToString();
  }

  private void toolStripMenuItem_1_Click(object sender, EventArgs e)
  {
    for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
      this.method_3(int_0, "cChose", (object) true);
    this.method_6(this.dtgvAcc.RowCount);
  }

  private void toolStripMenuItem_2_Click(object sender, EventArgs e)
  {
    for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
      this.method_3(int_0, "cChose", (object) false);
    this.method_6(0);
  }

  private void liveToolStripMenuItem_Click(object sender, EventArgs e)
  {
    DataGridViewSelectedRowCollection selectedRows = this.dtgvAcc.SelectedRows;
    for (int index = 0; index < selectedRows.Count; ++index)
      this.method_3(selectedRows[index].Index, "cChose", (object) true);
    this.method_6();
  }

  private void trueToolStripMenuItem_Click(object sender, EventArgs e)
  {
    for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
      this.method_3(int_0, "cChose", (object) (this.method_4(int_0, "cKiemDuyet").ToLower() == "true"));
    this.method_6();
  }

  private void falseToolStripMenuItem_Click(object sender, EventArgs e)
  {
    for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
      this.method_3(int_0, "cChose", (object) (this.method_4(int_0, "cKiemDuyet").ToLower() == "false"));
    this.method_6();
  }

  private void toolStripMenuItem_3_Click(object sender, EventArgs e)
  {
    try
    {
      string str = "";
      if (this.lblCountSelect.Text == "0")
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn những dòng muốn copy!"), 3);
      }
      else
      {
        for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
        {
          if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
            str = str + this.method_4(index, "cId") + "\r\n";
        }
        Clipboard.SetText(str.TrimEnd('\r', '\n'));
      }
    }
    catch
    {
    }
  }

  private void cbbKiemDuyet_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.dtgvAcc.Rows.Clear();
    if (this.cbbKiemDuyet.SelectedIndex == 0)
    {
      for (int index = 0; index < this.list_0.Count; ++index)
      {
        string str = this.list_0[index];
        try
        {
          this.dtgvAcc.Rows.Add((object) false, (object) (this.dtgvAcc.RowCount + 1), (object) str.Split('|')[0], (object) str.Split('|')[1], (object) str.Split('|')[2], (object) str.Split('|')[3].ToUpper());
        }
        catch
        {
        }
      }
    }
    else if (this.cbbKiemDuyet.SelectedIndex == 1)
    {
      for (int index = 0; index < this.list_0.Count; ++index)
      {
        string str = this.list_0[index];
        try
        {
          if (str.Split('|')[3].ToLower() == "true")
            this.dtgvAcc.Rows.Add((object) false, (object) (this.dtgvAcc.RowCount + 1), (object) str.Split('|')[0], (object) str.Split('|')[1], (object) str.Split('|')[2], (object) str.Split('|')[3].ToUpper());
        }
        catch
        {
        }
      }
    }
    else if (this.cbbKiemDuyet.SelectedIndex == 2)
    {
      for (int index = 0; index < this.list_0.Count; ++index)
      {
        string str = this.list_0[index];
        try
        {
          if (str.Split('|')[3].ToLower() == "false")
            this.dtgvAcc.Rows.Add((object) false, (object) (this.dtgvAcc.RowCount + 1), (object) str.Split('|')[0], (object) str.Split('|')[1], (object) str.Split('|')[2], (object) str.Split('|')[3].ToUpper());
        }
        catch
        {
        }
      }
    }
    this.method_6(0);
    this.method_5();
  }

  private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex != 0)
      return;
    try
    {
      this.dtgvAcc.CurrentRow.Cells["cChose"].Value = (object) !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value);
      this.method_6();
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
      this.method_6();
    }
    catch
    {
    }
  }

  private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
  {
  }

  private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyValue != 32)
      return;
    for (int index1 = 0; index1 < this.dtgvAcc.SelectedRows.Count; ++index1)
    {
      int index2 = this.dtgvAcc.SelectedRows[index1].Index;
      this.method_3(index2, "cChose", (object) !Convert.ToBoolean(this.method_4(index2, "cChose")));
    }
    this.method_6();
  }

  private void dtgvAcc_SelectionChanged(object sender, EventArgs e) => this.lblCountHighline.Text = this.dtgvAcc.SelectedRows.Count.ToString();

  private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
  {
    if (new List<string>() { "cStt", "cThanhVien" }.Contains(e.Column.Name))
    {
      string s1 = e.CellValue1.ToString().Trim() == "" ? "-2" : (!GClass19.smethod_51(e.CellValue1.ToString()) ? "-1" : e.CellValue1.ToString());
      string s2 = e.CellValue2.ToString().Trim() == "" ? "-2" : (!GClass19.smethod_51(e.CellValue2.ToString()) ? "-1" : e.CellValue2.ToString());
      e.SortResult = int.Parse(s1).CompareTo(int.Parse(s2));
      e.Handled = true;
    }
    else
    {
      e.SortResult = (e.CellValue1.ToString() == "" ? "" : e.CellValue1.ToString()).CompareTo(e.CellValue2.ToString() == "" ? "" : e.CellValue2.ToString());
      e.Handled = true;
    }
  }

  private void toolStripMenuItem_4_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> contents = new List<string>();
      string str1 = ((DataObject) Clipboard.GetDataObject()).GetData(DataFormats.Text).ToString();
      char[] separator = new char[2]{ '\r', '\n' };
      foreach (string str2 in str1.Split(separator, StringSplitOptions.RemoveEmptyEntries))
      {
        int num;
        if (str2.Split('|').Length > 1)
          num = !this.list_1.Contains(str2.Split('|')[0]) ? 1 : 0;
        else
          num = 0;
        if (num != 0)
        {
          this.list_1.Add(str2.Split('|')[0]);
          this.list_0.Add(str2.Split('|')[0] + "|||" + str2.Split('|')[1]);
          contents.Add(str2.Split('|')[0] + "|||" + str2.Split('|')[1]);
          this.dtgvAcc.Rows.Add((object) false, (object) (this.dtgvAcc.RowCount + 1), (object) str2.Split('|')[0], (object) "", (object) "", (object) str2.Split('|')[1].ToUpper());
        }
      }
      File.AppendAllLines("backupgroup\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", (IEnumerable<string>) contents);
      this.method_5();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fQuanLyNhom));
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.cbbKiemDuyet = new MetroComboBox();
    this.label1 = new Label();
    this.dtgvAcc = new DataGridView();
    this.cChose = new DataGridViewCheckBoxColumn();
    this.cStt = new DataGridViewTextBoxColumn();
    this.cId = new DataGridViewTextBoxColumn();
    this.cTen = new DataGridViewTextBoxColumn();
    this.cThanhVien = new DataGridViewTextBoxColumn();
    this.cKiemDuyet = new DataGridViewTextBoxColumn();
    this.ctmsAcc = new MetroContextMenu(this.components);
    this.toolStripMenuItem_0 = new ToolStripMenuItem();
    this.toolStripMenuItem_1 = new ToolStripMenuItem();
    this.liveToolStripMenuItem = new ToolStripMenuItem();
    this.tinhTrangToolStripMenuItem = new ToolStripMenuItem();
    this.trueToolStripMenuItem = new ToolStripMenuItem();
    this.falseToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_2 = new ToolStripMenuItem();
    this.toolStripMenuItem_3 = new ToolStripMenuItem();
    this.toolStripMenuItem_4 = new ToolStripMenuItem();
    this.toolStripMenuItem_5 = new ToolStripMenuItem();
    this.statusStrip1 = new StatusStrip();
    this.toolStripStatusLabel4 = new ToolStripStatusLabel();
    this.lblCountHighline = new ToolStripStatusLabel();
    this.toolStripStatusLabel5 = new ToolStripStatusLabel();
    this.lblCountSelect = new ToolStripStatusLabel();
    this.toolStripStatusLabel2 = new ToolStripStatusLabel();
    this.lblCountTotal = new ToolStripStatusLabel();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    ((ISupportInitialize) this.dtgvAcc).BeginInit();
    this.ctmsAcc.SuspendLayout();
    this.statusStrip1.SuspendLayout();
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
    this.bunifuCards1.Size = new Size(906, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(906, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(874, 0);
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
    this.bunifuCustomLabel1.Size = new Size(906, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Quản lý nhóm";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.cbbKiemDuyet.Cursor = Cursors.Hand;
    this.cbbKiemDuyet.DropDownWidth = 350;
    this.cbbKiemDuyet.FontSize = MetroComboBoxSize.Small;
    this.cbbKiemDuyet.FormattingEnabled = true;
    this.cbbKiemDuyet.ItemHeight = 19;
    this.cbbKiemDuyet.Items.AddRange(new object[3]
    {
      (object) "Toàn bộ",
      (object) "Nhóm không kiểm duyệt",
      (object) "Nhóm kiểm duyệt"
    });
    this.cbbKiemDuyet.Location = new Point(71, 41);
    this.cbbKiemDuyet.Name = "cbbKiemDuyet";
    this.cbbKiemDuyet.Size = new Size(184, 25);
    this.cbbKiemDuyet.TabIndex = 7;
    this.cbbKiemDuyet.UseSelectable = true;
    this.cbbKiemDuyet.SelectedIndexChanged += new EventHandler(this.cbbKiemDuyet_SelectedIndexChanged);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(10, 44);
    this.label1.Name = "label1";
    this.label1.Size = new Size(55, 16);
    this.label1.TabIndex = 6;
    this.label1.Text = "Hiển thị:";
    this.dtgvAcc.AllowUserToAddRows = false;
    this.dtgvAcc.AllowUserToDeleteRows = false;
    this.dtgvAcc.AllowUserToResizeRows = false;
    this.dtgvAcc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.dtgvAcc.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = Color.Teal;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.dtgvAcc.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.dtgvAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgvAcc.Columns.AddRange((DataGridViewColumn) this.cChose, (DataGridViewColumn) this.cStt, (DataGridViewColumn) this.cId, (DataGridViewColumn) this.cTen, (DataGridViewColumn) this.cThanhVien, (DataGridViewColumn) this.cKiemDuyet);
    this.dtgvAcc.ContextMenuStrip = (ContextMenuStrip) this.ctmsAcc;
    this.dtgvAcc.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.dtgvAcc.Location = new Point(12, 72);
    this.dtgvAcc.Name = "dtgvAcc";
    this.dtgvAcc.RowHeadersVisible = false;
    gridViewCellStyle2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.dtgvAcc.RowsDefaultCellStyle = gridViewCellStyle2;
    this.dtgvAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvAcc.Size = new Size(882, 483);
    this.dtgvAcc.TabIndex = 5;
    this.dtgvAcc.CellClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellClick);
    this.dtgvAcc.CellContentClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellContentClick);
    this.dtgvAcc.CellDoubleClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
    this.dtgvAcc.CellValueChanged += new DataGridViewCellEventHandler(this.dtgvAcc_CellValueChanged);
    this.dtgvAcc.SelectionChanged += new EventHandler(this.dtgvAcc_SelectionChanged);
    this.dtgvAcc.SortCompare += new DataGridViewSortCompareEventHandler(this.dtgvAcc_SortCompare);
    this.dtgvAcc.KeyDown += new KeyEventHandler(this.dtgvAcc_KeyDown);
    this.cChose.HeaderText = "Chọn";
    this.cChose.Name = "cChose";
    this.cChose.SortMode = DataGridViewColumnSortMode.Automatic;
    this.cChose.Width = 40;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.cStt.DefaultCellStyle = gridViewCellStyle3;
    this.cStt.HeaderText = "STT";
    this.cStt.Name = "cStt";
    this.cStt.Width = 50;
    this.cId.HeaderText = "ID Nhóm";
    this.cId.Name = "cId";
    this.cId.Width = 120;
    this.cTen.HeaderText = "Tên nhóm";
    this.cTen.Name = "cTen";
    this.cTen.Width = 200;
    this.cThanhVien.HeaderText = "Thành viên";
    this.cThanhVien.Name = "cThanhVien";
    this.cThanhVien.Width = 120;
    this.cKiemDuyet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cKiemDuyet.HeaderText = "Kiểm duyệt";
    this.cKiemDuyet.MinimumWidth = 200;
    this.cKiemDuyet.Name = "cKiemDuyet";
    this.ctmsAcc.Items.AddRange(new ToolStripItem[5]
    {
      (ToolStripItem) this.toolStripMenuItem_0,
      (ToolStripItem) this.toolStripMenuItem_2,
      (ToolStripItem) this.toolStripMenuItem_3,
      (ToolStripItem) this.toolStripMenuItem_4,
      (ToolStripItem) this.toolStripMenuItem_5
    });
    this.ctmsAcc.Name = "ctmsAcc";
    this.ctmsAcc.Size = new Size(180, 114);
    this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.toolStripMenuItem_1,
      (ToolStripItem) this.liveToolStripMenuItem,
      (ToolStripItem) this.tinhTrangToolStripMenuItem
    });
    this.toolStripMenuItem_0.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_0.Image");
    this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
    this.toolStripMenuItem_0.Size = new Size(179, 22);
    this.toolStripMenuItem_0.Text = "Chọn";
    this.toolStripMenuItem_1.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_1.Image");
    this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
    this.toolStripMenuItem_1.Size = new Size(134, 22);
    this.toolStripMenuItem_1.Text = "Tất cả";
    this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
    this.liveToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("liveToolStripMenuItem.Image");
    this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
    this.liveToolStripMenuItem.Size = new Size(134, 22);
    this.liveToolStripMenuItem.Text = "Bôi đen";
    this.liveToolStripMenuItem.Click += new EventHandler(this.liveToolStripMenuItem_Click);
    this.tinhTrangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.trueToolStripMenuItem,
      (ToolStripItem) this.falseToolStripMenuItem
    });
    this.tinhTrangToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("tinhTrangToolStripMenuItem.Image");
    this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
    this.tinhTrangToolStripMenuItem.Size = new Size(134, 22);
    this.tinhTrangToolStripMenuItem.Text = "Kiểm duyệt";
    this.trueToolStripMenuItem.Name = "trueToolStripMenuItem";
    this.trueToolStripMenuItem.Size = new Size(100, 22);
    this.trueToolStripMenuItem.Text = "True";
    this.trueToolStripMenuItem.Click += new EventHandler(this.trueToolStripMenuItem_Click);
    this.falseToolStripMenuItem.Name = "falseToolStripMenuItem";
    this.falseToolStripMenuItem.Size = new Size(100, 22);
    this.falseToolStripMenuItem.Text = "False";
    this.falseToolStripMenuItem.Click += new EventHandler(this.falseToolStripMenuItem_Click);
    this.toolStripMenuItem_2.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_2.Image");
    this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
    this.toolStripMenuItem_2.Size = new Size(179, 22);
    this.toolStripMenuItem_2.Text = "Bỏ chọn tất cả";
    this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
    this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
    this.toolStripMenuItem_3.Size = new Size(179, 22);
    this.toolStripMenuItem_3.Text = "Copy ID nhóm";
    this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
    this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
    this.toolStripMenuItem_4.Size = new Size(179, 22);
    this.toolStripMenuItem_4.Text = "Paste ID|Kiểm duyệt";
    this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
    this.toolStripMenuItem_5.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_5.Image");
    this.toolStripMenuItem_5.Name = "toolStripMenuItem_5";
    this.toolStripMenuItem_5.Size = new Size(179, 22);
    this.toolStripMenuItem_5.Text = "Tải lại danh sách";
    this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripMenuItem_5_Click);
    this.statusStrip1.BackColor = SystemColors.Control;
    this.statusStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.statusStrip1.Items.AddRange(new ToolStripItem[6]
    {
      (ToolStripItem) this.toolStripStatusLabel4,
      (ToolStripItem) this.lblCountHighline,
      (ToolStripItem) this.toolStripStatusLabel5,
      (ToolStripItem) this.lblCountSelect,
      (ToolStripItem) this.toolStripStatusLabel2,
      (ToolStripItem) this.lblCountTotal
    });
    this.statusStrip1.Location = new Point(0, 558);
    this.statusStrip1.Name = "statusStrip1";
    this.statusStrip1.Size = new Size(906, 22);
    this.statusStrip1.SizingGrip = false;
    this.statusStrip1.TabIndex = 10;
    this.statusStrip1.Text = "statusStrip1";
    this.toolStripStatusLabel4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
    this.toolStripStatusLabel4.Size = new Size(59, 17);
    this.toolStripStatusLabel4.Text = "Bôi đen:";
    this.lblCountHighline.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCountHighline.ForeColor = Color.Blue;
    this.lblCountHighline.Name = "lblCountHighline";
    this.lblCountHighline.Size = new Size(15, 17);
    this.lblCountHighline.Text = "0";
    this.toolStripStatusLabel5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
    this.toolStripStatusLabel5.Size = new Size(65, 17);
    this.toolStripStatusLabel5.Text = "Đã chọn:";
    this.lblCountSelect.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCountSelect.ForeColor = Color.FromArgb(0, 64, 0);
    this.lblCountSelect.Name = "lblCountSelect";
    this.lblCountSelect.Size = new Size(15, 17);
    this.lblCountSelect.Text = "0";
    this.toolStripStatusLabel2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
    this.toolStripStatusLabel2.Size = new Size(52, 17);
    this.toolStripStatusLabel2.Text = "Tất cả:";
    this.lblCountTotal.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCountTotal.ForeColor = Color.Maroon;
    this.lblCountTotal.Name = "lblCountTotal";
    this.lblCountTotal.Size = new Size(15, 17);
    this.lblCountTotal.Text = "0";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(906, 580);
    this.Controls.Add((Control) this.statusStrip1);
    this.Controls.Add((Control) this.cbbKiemDuyet);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.dtgvAcc);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fQuanLyNhom);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fQuanLyNhom_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    ((ISupportInitialize) this.dtgvAcc).EndInit();
    this.ctmsAcc.ResumeLayout(false);
    this.statusStrip1.ResumeLayout(false);
    this.statusStrip1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void dtgvAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }
}
