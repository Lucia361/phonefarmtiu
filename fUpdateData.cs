// Decompiled with JetBrains decompiler
// Type: fUpdateData
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
using System.Windows.Forms;

public class fUpdateData : Form
{
  private fMain fMain_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnMinimize;
  private MetroComboBox cbbTypeUpdate;
  private Label label1;
  private TextBox txbData;
  private Label label2;
  private Button btnCancel;
  private Button btnAdd;
  private Label label3;
  private ComboBox cbbTypeProxy;

  public fUpdateData(fMain fMain_1, string string_0)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.fMain_0 = fMain_1;
    this.cbbTypeUpdate.Text = string_0;
    this.cbbTypeProxy.SelectedIndex = 0;
  }

  private void method_0()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label1);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      bool flag = false;
      if (this.txbData.Text.Equals("") || this.txbData.Text.Equals("|"))
      {
        if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có chắc muốn xóa dữ liệu của {0} tài khoản?"), (object) this.fMain_0.method_176())) == DialogResult.Yes)
          flag = true;
      }
      else if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có chắc muốn cập nhật dữ liệu của {0} tài khoản?"), (object) this.fMain_0.method_176())) == DialogResult.Yes)
        flag = true;
      if (!flag)
        return;
      List<string> list_0 = new List<string>();
      string text1 = this.txbData.Text;
      for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
      {
        if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
          list_0.Add(this.fMain_0.method_191(index, "cId"));
      }
      string text2 = this.cbbTypeUpdate.Text;
      // ISSUE: reference to a compiler-generated method
      switch (Class206.smethod_0(text2))
      {
        case 96026087:
          if (text2 == "Mail|pass")
          {
            if (text1.Split('|').Length != 2)
            {
              GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập lại định dạng Mail|Pass Mail!"), 3);
              return;
            }
            if (Class42.smethod_15(list_0, "email|passmail", text1))
            {
              for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
              {
                if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                {
                  this.fMain_0.method_186(index, "cEmail", (object) text1.Split('|')[0]);
                  this.fMain_0.method_186(index, "cPassMail", (object) text1.Split('|')[1]);
                }
              }
              break;
            }
            break;
          }
          break;
        case 267393898:
          if (text2 == "Notes" && Class42.smethod_17(list_0, "ghiChu", text1))
          {
            for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
            {
              if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                this.fMain_0.method_186(index, "cGhiChu", (object) text1);
            }
            break;
          }
          break;
        case 750979128:
          if (text2 == "Password" && Class42.smethod_17(list_0, "pass", text1))
          {
            for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
            {
              if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                this.fMain_0.method_186(index, "cPassword", (object) text1);
            }
            break;
          }
          break;
        case 976575442:
          if (text2 == "Token" && Class42.smethod_17(list_0, "token", text1))
          {
            for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
            {
              if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                this.fMain_0.method_186(index, "cToken", (object) text1);
            }
            break;
          }
          break;
        case 1227920463:
          if (text2 == "Phone" && Class42.smethod_17(list_0, "phone", text1))
          {
            for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
            {
              if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                this.fMain_0.method_186(index, "cPhone", (object) text1);
            }
            break;
          }
          break;
        case 1335761915:
          if (text2 == "Proxy")
          {
            int selectedIndex = this.cbbTypeProxy.SelectedIndex;
            string str = text1 == "" ? "" : text1 + "*" + selectedIndex.ToString();
            if (Class42.smethod_17(list_0, "proxy", str))
            {
              for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
              {
                if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  this.fMain_0.method_186(index, "cProxy", (object) str);
              }
              break;
            }
            break;
          }
          break;
        case 2249983736:
          if (text2 == "2FA" && Class42.smethod_17(list_0, "fa2", text1))
          {
            for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
            {
              if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                this.fMain_0.method_186(index, "cFa2", (object) text1);
            }
            break;
          }
          break;
        case 3183131359:
          if (text2 == "Cookie" && Class42.smethod_17(list_0, "cookie1", text1))
          {
            for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
            {
              if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                this.fMain_0.method_186(index, "cCookies", (object) text1);
            }
            break;
          }
          break;
        case 3243292492:
          if (text2 == "Birthday" && Class42.smethod_17(list_0, "birthday", text1))
          {
            for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
            {
              if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                this.fMain_0.method_186(index, "cBirthday", (object) text1);
            }
            break;
          }
          break;
        case 3646757383:
          if (text2 == "Useragent" && Class42.smethod_17(list_0, "useragent", text1))
          {
            for (int index = 0; index < this.fMain_0.dtgvAcc.Rows.Count; ++index)
            {
              if (Convert.ToBoolean(this.fMain_0.dtgvAcc.Rows[index].Cells["cChose"].Value))
                this.fMain_0.method_186(index, "cUseragent", (object) text1);
            }
            break;
          }
          break;
      }
      this.Close();
    }
    catch
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng thử lại sau!"), 2);
    }
  }

  private void cbbTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
  {
    bool flag = this.cbbTypeUpdate.Text == "Proxy";
    this.label3.Visible = flag;
    this.cbbTypeProxy.Visible = flag;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fUpdateData));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.cbbTypeUpdate = new MetroComboBox();
    this.label1 = new Label();
    this.txbData = new TextBox();
    this.label2 = new Label();
    this.btnCancel = new Button();
    this.btnAdd = new Button();
    this.label3 = new Label();
    this.cbbTypeProxy = new ComboBox();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.SuspendLayout();
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 5;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.Dock = DockStyle.Top;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(416, 38);
    this.bunifuCards1.TabIndex = 12;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(416, 32);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(382, -1);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 32);
    this.btnMinimize.TabIndex = 9;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(416, 32);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.cbbTypeUpdate.Cursor = Cursors.Hand;
    this.cbbTypeUpdate.FontSize = MetroComboBoxSize.Small;
    this.cbbTypeUpdate.FormattingEnabled = true;
    this.cbbTypeUpdate.ItemHeight = 19;
    this.cbbTypeUpdate.Items.AddRange(new object[10]
    {
      (object) "Token",
      (object) "Cookie",
      (object) "Password",
      (object) "Mail|pass",
      (object) "2FA",
      (object) "Birthday",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Notes",
      (object) "Phone"
    });
    this.cbbTypeUpdate.Location = new Point(146, 43);
    this.cbbTypeUpdate.Name = "cbbTypeUpdate";
    this.cbbTypeUpdate.Size = new Size(238, 25);
    this.cbbTypeUpdate.TabIndex = 13;
    this.cbbTypeUpdate.UseSelectable = true;
    this.cbbTypeUpdate.SelectedIndexChanged += new EventHandler(this.cbbTypeUpdate_SelectedIndexChanged);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(34, 51);
    this.label1.Name = "label1";
    this.label1.Size = new Size(105, 16);
    this.label1.TabIndex = 14;
    this.label1.Text = "Dữ liệu cập nhật:";
    this.txbData.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txbData.Location = new Point(146, 79);
    this.txbData.Name = "txbData";
    this.txbData.Size = new Size(238, 23);
    this.txbData.TabIndex = 15;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.Location = new Point(34, 82);
    this.label2.Name = "label2";
    this.label2.Size = new Size(84, 16);
    this.label2.TabIndex = 16;
    this.label2.Text = "Nhập dữ liệu:";
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(209, 145);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 18;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(111, 145);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(92, 29);
    this.btnAdd.TabIndex = 17;
    this.btnAdd.Text = "Lưu";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(34, 111);
    this.label3.Name = "label3";
    this.label3.Size = new Size(70, 16);
    this.label3.TabIndex = 16;
    this.label3.Text = "Loại proxy:";
    this.cbbTypeProxy.Cursor = Cursors.Hand;
    this.cbbTypeProxy.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbTypeProxy.Enabled = false;
    this.cbbTypeProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cbbTypeProxy.FormattingEnabled = true;
    this.cbbTypeProxy.Items.AddRange(new object[2]
    {
      (object) "HTTP",
      (object) "Sock5"
    });
    this.cbbTypeProxy.Location = new Point(146, 108);
    this.cbbTypeProxy.Name = "cbbTypeProxy";
    this.cbbTypeProxy.Size = new Size(130, 24);
    this.cbbTypeProxy.TabIndex = 124;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(416, 188);
    this.Controls.Add((Control) this.cbbTypeProxy);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.txbData);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.cbbTypeUpdate);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fUpdateData);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = nameof (fUpdateData);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
