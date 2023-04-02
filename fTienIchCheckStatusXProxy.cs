// Decompiled with JetBrains decompiler
// Type: fTienIchCheckStatusXProxy
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

public class fTienIchCheckStatusXProxy : Form
{
  private bool bool_0 = false;
  public static List<string> list_0;
  public static List<string> list_1;
  public static bool bool_1;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private BunifuDragControl bunifuDragControl_0;
  public DataGridView dtgv;
  private RichTextBox txtListProxy;
  private Label label17;
  private Label label1;
  private DataGridViewTextBoxColumn cStt;
  private DataGridViewTextBoxColumn cProxy;
  private DataGridViewTextBoxColumn cStatus;
  private Button btnCheck;
  private Label label2;
  private IContainer components;
  private TextBox txtUrl;

  public fTienIchCheckStatusXProxy(bool bool_2 = false)
  {
    this.InitializeComponent();
    fTienIchCheckStatusXProxy.bool_1 = false;
    this.bool_0 = bool_2;
    GClass35.smethod_5((Control) this);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void method_0(object sender, EventArgs e)
  {
    fTienIchCheckStatusXProxy.bool_1 = true;
    if (this.bool_0)
    {
      fTienIchCheckStatusXProxy.list_1 = new List<string>();
      for (int index = 0; index < this.dtgv.Rows.Count; ++index)
      {
        if (Convert.ToBoolean(this.dtgv.Rows[index].Cells["cChose"].Value))
          fTienIchCheckStatusXProxy.list_1.Add(Class14.smethod_3(this.dtgv, index, "cId"));
      }
      if (fTienIchCheckStatusXProxy.list_1.Count == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn ít nhất 1 thư mục!"), 2);
        return;
      }
    }
    else
    {
      fTienIchCheckStatusXProxy.list_0 = new List<string>();
      for (int index = 0; index < this.dtgv.Rows.Count; ++index)
      {
        if (Convert.ToBoolean(this.dtgv.Rows[index].Cells["cChose"].Value))
          fTienIchCheckStatusXProxy.list_0.Add(Class14.smethod_3(this.dtgv, index, "cId"));
      }
      if (fTienIchCheckStatusXProxy.list_0.Count == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn ít nhất 1 thư mục!"), 2);
        return;
      }
    }
    this.Close();
  }

  private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    try
    {
      if (Convert.ToBoolean(this.dtgv.CurrentRow.Cells["cChose"].Value))
        this.dtgv.CurrentRow.Cells["cChose"].Value = (object) false;
      else
        this.dtgv.CurrentRow.Cells["cChose"].Value = (object) true;
    }
    catch
    {
    }
  }

  private int method_1()
  {
    int num = 0;
    for (int index = 0; index < this.dtgv.Rows.Count; ++index)
    {
      if (Convert.ToBoolean(this.dtgv.Rows[index].Cells["cChose"].Value))
        ++num;
    }
    return num;
  }

  private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex != 0)
      return;
    try
    {
      if (Convert.ToBoolean(this.dtgv.CurrentRow.Cells["cChose"].Value))
        this.dtgv.CurrentRow.Cells["cChose"].Value = (object) false;
      else
        this.dtgv.CurrentRow.Cells["cChose"].Value = (object) true;
    }
    catch
    {
    }
  }

  private void txtListProxy_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtListProxy, (Control) this.label17);

  private void btnCheck_Click(object sender, EventArgs e)
  {
    if (this.txtUrl.Text.Trim() == "")
    {
      GClass14.smethod_0((object) "Vui lòng nhập URL trước!", 3);
      this.txtUrl.Focus();
    }
    else if (this.txtListProxy.Text.Trim() == "")
    {
      GClass14.smethod_0((object) "Vui lòng nhập proxy trước!", 3);
      this.txtListProxy.Focus();
    }
    else
    {
      string string_0 = this.txtUrl.Text.Trim().TrimEnd('/');
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtListProxy.Lines).ToList<string>());
      this.dtgv.Rows.Clear();
      for (int index = 0; index < stringList.Count; ++index)
        this.dtgv.Rows.Add((object) (index + 1), (object) stringList[index], (object) "Đang check...");
      new Thread((ThreadStart) (() =>
      {
        try
        {
          if (string_0.StartsWith("http"))
          {
            for (int index = 0; index < this.dtgv.RowCount; ++index)
            {
              int int_ = index;
              new Thread((ThreadStart) (() =>
              {
                try
                {
                  Class14.Status(this.dtgv, int_, "cStatus", (object) new GClass24("", "", "", 0).method_0(string_0 + "/status?proxy=" + this.dtgv.Rows[int_].Cells["cProxy"].Value.ToString()));
                }
                catch
                {
                }
              }))
              {
                IsBackground = true
              }.Start();
            }
          }
          else
          {
            for (int index = 0; index < this.dtgv.RowCount; ++index)
            {
              int int_0 = index;
              new Thread((ThreadStart) (() =>
              {
                try
                {
                  string str = this.dtgv.Rows[int_0].Cells["cProxy"].Value.ToString();
                  string string_0_2 = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + string_0;
                  string string_1 = "{\"proxies\": [\"" + (str.Split(':')[2] + ":" + str.Split(':')[3] + "@" + str.Split(':')[0] + ":" + str.Split(':')[1]) + "\"]}";
                  Class14.Status(this.dtgv, int_0, "cStatus", (object) new GClass24("", "", "", 0).method_1(string_0_2, string_1, "application/json"));
                }
                catch
                {
                }
              }))
              {
                IsBackground = true
              }.Start();
            }
          }
        }
        catch
        {
        }
      }))
      {
        IsBackground = true
      }.Start();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fTienIchCheckStatusXProxy));
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.dtgv = new DataGridView();
    this.cStt = new DataGridViewTextBoxColumn();
    this.cProxy = new DataGridViewTextBoxColumn();
    this.cStatus = new DataGridViewTextBoxColumn();
    this.txtListProxy = new RichTextBox();
    this.label17 = new Label();
    this.label1 = new Label();
    this.btnCheck = new Button();
    this.label2 = new Label();
    this.txtUrl = new TextBox();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    ((ISupportInitialize) this.dtgv).BeginInit();
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
    this.bunifuCards1.Size = new Size(530, 34);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(530, 28);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(498, 0);
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
    this.bunifuCustomLabel1.Size = new Size(530, 28);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Check status XProxy";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.dtgv.AllowUserToAddRows = false;
    this.dtgv.AllowUserToDeleteRows = false;
    this.dtgv.AllowUserToResizeRows = false;
    this.dtgv.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = Color.Teal;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.dtgv.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgv.Columns.AddRange((DataGridViewColumn) this.cStt, (DataGridViewColumn) this.cProxy, (DataGridViewColumn) this.cStatus);
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.dtgv.DefaultCellStyle = gridViewCellStyle2;
    this.dtgv.Location = new Point(15, 318);
    this.dtgv.Name = "dtgv";
    this.dtgv.ReadOnly = true;
    this.dtgv.RowHeadersVisible = false;
    this.dtgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgv.Size = new Size(499, 211);
    this.dtgv.TabIndex = 7;
    this.dtgv.CellClick += new DataGridViewCellEventHandler(this.dtgv_CellClick);
    this.dtgv.CellDoubleClick += new DataGridViewCellEventHandler(this.dtgv_CellDoubleClick);
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.cStt.DefaultCellStyle = gridViewCellStyle3;
    this.cStt.HeaderText = "STT";
    this.cStt.Name = "cStt";
    this.cStt.ReadOnly = true;
    this.cStt.Resizable = DataGridViewTriState.False;
    this.cStt.Width = 35;
    this.cProxy.HeaderText = "Proxy";
    this.cProxy.Name = "cProxy";
    this.cProxy.ReadOnly = true;
    this.cProxy.Width = 90;
    this.cStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cStatus.HeaderText = "Status";
    this.cStatus.Name = "cStatus";
    this.cStatus.ReadOnly = true;
    this.txtListProxy.BorderStyle = BorderStyle.FixedSingle;
    this.txtListProxy.Font = new Font("Tahoma", 9.75f);
    this.txtListProxy.Location = new Point(15, 92);
    this.txtListProxy.Name = "txtListProxy";
    this.txtListProxy.Size = new Size(499, 158);
    this.txtListProxy.TabIndex = 146;
    this.txtListProxy.Text = "";
    this.txtListProxy.WordWrap = false;
    this.txtListProxy.TextChanged += new EventHandler(this.txtListProxy_TextChanged);
    this.label17.AutoSize = true;
    this.label17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label17.Location = new Point(12, 73);
    this.label17.Name = "label17";
    this.label17.Size = new Size(97, 16);
    this.label17.TabIndex = 145;
    this.label17.Text = "Nhập Proxy (0):";
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label1.Location = new Point(12, 299);
    this.label1.Name = "label1";
    this.label1.Size = new Size(55, 16);
    this.label1.TabIndex = 145;
    this.label1.Text = "Kết quả:";
    this.btnCheck.BackColor = Color.Green;
    this.btnCheck.Cursor = Cursors.Hand;
    this.btnCheck.FlatAppearance.BorderSize = 0;
    this.btnCheck.FlatStyle = FlatStyle.Flat;
    this.btnCheck.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCheck.ForeColor = Color.White;
    this.btnCheck.Location = new Point(223, 261);
    this.btnCheck.Name = "btnCheck";
    this.btnCheck.Size = new Size(82, 33);
    this.btnCheck.TabIndex = 147;
    this.btnCheck.Text = "Check";
    this.btnCheck.UseVisualStyleBackColor = false;
    this.btnCheck.Click += new EventHandler(this.btnCheck_Click);
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label2.Location = new Point(12, 48);
    this.label2.Name = "label2";
    this.label2.Size = new Size(34, 16);
    this.label2.TabIndex = 145;
    this.label2.Text = "URL:";
    this.txtUrl.Font = new Font("Tahoma", 9.75f);
    this.txtUrl.Location = new Point(53, 47);
    this.txtUrl.Name = "txtUrl";
    this.txtUrl.Size = new Size(461, 23);
    this.txtUrl.TabIndex = 148;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(530, 547);
    this.Controls.Add((Control) this.txtUrl);
    this.Controls.Add((Control) this.btnCheck);
    this.Controls.Add((Control) this.txtListProxy);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.label17);
    this.Controls.Add((Control) this.dtgv);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fTienIchCheckStatusXProxy);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    ((ISupportInitialize) this.dtgv).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
