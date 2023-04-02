// Decompiled with JetBrains decompiler
// Type: fClearBackup
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

public class fClearBackup : Form
{
  private List<string> list_0 = new List<string>();
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private Button btnCancel;
  private Button btnAdd;
  private BunifuDragControl bunifuDragControl_0;
  private IContainer components;
  private BunifuCustomLabel lblStatus;

  public fClearBackup()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    this.btnAdd.Enabled = false;
    this.btnCancel.Enabled = false;
    this.method_1(string.Format(GClass35.smethod_0("Đang dọn dẹp backup {0}/{1}..."), (object) 0, (object) this.list_0.Count));
    int int_0 = 0;
    int int_1 = 20;
    int int_2 = 0;
    string string_0 = GClass13.smethod_0() + "\\backup";
    new Thread((ThreadStart) (() =>
    {
      try
      {
        int num = 0;
        while (num < this.list_0.Count)
        {
          if (int_0 < int_1)
          {
            Interlocked.Increment(ref int_0);
            int int_3 = num++;
            new Thread((ThreadStart) (() =>
            {
              try
              {
                Directory.Delete(string_0 + "\\" + this.list_0[int_3], true);
                Interlocked.Increment(ref int_2);
                this.method_1(string.Format(GClass35.smethod_0("Đang dọn dẹp backup {0}/{1}..."), (object) int_2, (object) this.list_0.Count));
                Interlocked.Decrement(ref int_0);
              }
              catch
              {
              }
            }))
            {
              IsBackground = true
            }.Start();
          }
          else
          {
            Application.DoEvents();
            Thread.Sleep(200);
          }
        }
        while (int_0 > 0)
          GClass19.smethod_64(1.0);
        this.Invoke((Delegate) (() =>
        {
          this.Close();
          GClass14.smethod_0((object) GClass35.smethod_0("Đã dọn dẹp file backup xong!"));
        }));
      }
      catch
      {
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void lblStatus_Click(object sender, EventArgs e)
  {
  }

  private List<string> method_0()
  {
    List<string> stringList = new List<string>();
    try
    {
      DataTable dataTable = Class42.smethod_21("uid");
      for (int index = 0; index < dataTable.Rows.Count; ++index)
        stringList.Add(dataTable.Rows[index]["uid"].ToString());
    }
    catch
    {
    }
    return stringList;
  }

  private void method_1(string string_0) => this.Invoke((Delegate) (() => this.lblStatus.Text = string_0));

  private void fClearBackup_Load(object sender, EventArgs e) => new Thread((ThreadStart) (() =>
  {
    try
    {
      List<string> list = ((IEnumerable<string>) Directory.GetDirectories(GClass13.smethod_0() + "\\backup")).ToList<string>();
      List<string> stringList = this.method_0();
      for (int index = 0; index < list.Count; ++index)
      {
        string str = list[index].Substring(list[index].LastIndexOf("\\") + 1);
        if (!stringList.Contains(str))
          this.list_0.Add(str);
      }
      if (this.list_0.Count > 0)
        this.Invoke((Delegate) (() =>
        {
          this.lblStatus.Text = string.Format(GClass35.smethod_0("Tìm thấy {0} file backup rác!"), (object) this.list_0.Count) + "\r\n" + GClass35.smethod_0("Bạn có muốn dọn dẹp?");
          this.btnAdd.Visible = true;
          this.btnCancel.Visible = true;
        }));
      else
        this.Invoke((Delegate) (() =>
        {
          this.Close();
          GClass14.smethod_0((object) GClass35.smethod_0("Không có file backup rác!"));
        }));
    }
    catch (Exception ex)
    {
      this.Invoke((Delegate) (() => this.Close()));
    }
  }))
  {
    IsBackground = true
  }.Start();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fClearBackup));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.lblStatus = new BunifuCustomLabel();
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
    this.bunifuCards1.Size = new Size(396, 38);
    this.bunifuCards1.TabIndex = 0;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(396, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(364, 0);
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
    this.bunifuCustomLabel1.Size = new Size(396, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Dọn dẹp backup";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(204, 105);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 4;
    this.btnCancel.Text = "Hủy";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Visible = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(100, 105);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "Đồng ý";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Visible = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.lblStatus.BackColor = Color.Transparent;
    this.lblStatus.Cursor = Cursors.SizeAll;
    this.lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.ForeColor = Color.Black;
    this.lblStatus.Location = new Point(-1, 57);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(396, 32);
    this.lblStatus.TabIndex = 21;
    this.lblStatus.Text = "Đang quét file backup...";
    this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;
    this.lblStatus.Click += new EventHandler(this.lblStatus_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(396, 145);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fClearBackup);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "fAddFile";
    this.Load += new EventHandler(this.fClearBackup_Load);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
