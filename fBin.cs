// Decompiled with JetBrains decompiler
// Type: fBin
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

public class fBin : Form
{
  private bool bool_0;
  private object object_0 = new object();
  private object object_1 = new object();
  private int int_0 = 0;
  private object object_2 = new object();
  private List<string> list_0 = new List<string>();
  private List<string> list_1 = new List<string>();
  private List<string> list_2 = new List<string>();
  private object object_3 = new object();
  private List<int> list_3 = new List<int>();
  private bool bool_1 = false;
  private object object_4 = new object();
  private int int_1 = -1;
  private bool bool_2 = true;
  private object object_5 = new object();
  private object object_6 = new object();
  private object object_7 = new object();
  private object object_8 = new object();
  private object object_9 = new object();
  private int int_2 = -1;
  private bool bool_3 = true;
  private List<Thread> list_4 = (List<Thread>) null;
  private IContainer icontainer_0 = (IContainer) null;
  public DataGridView dtgvAcc;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private Button button2;
  private Button button1;
  private Button btnMinimize;
  private BunifuCustomLabel bunifuCustomLabel1;
  private MenuStrip menuStrip1;
  private GroupBox grQuanLyThuMuc;
  private Label label1;
  private MetroComboBox cbbThuMuc;
  private MetroContextMenu ctmsAcc;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem liveToolStripMenuItem;
  private ToolStripMenuItem copyToolStripMenuItem;
  private ToolStripMenuItem tokenToolStripMenuItem;
  private ToolStripMenuItem cookieToolStripMenuItem;
  private ToolStripMenuItem uidPassToolStripMenuItem;
  private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem checkCookieToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem passToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_4;
  private ToolStripMenuItem toolStripMenuItem_5;
  private ToolStripMenuItem toolStripMenuItem_6;
  private ToolStripMenuItem toolStripMenuItem_7;
  private ToolStripMenuItem mailPassMailToolStripMenuItem;
  private ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_8;
  private ToolStripMenuItem toolStripMenuItem_9;
  private GroupBox grTimKiem;
  private BunifuCustomTextbox txbSearch;
  private ToolStripMenuItem mailToolStripMenuItem;
  private ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;
  private ToolStripMenuItem fAToolStripMenuItem;
  private ToolStripMenuItem tinhTrangToolStripMenuItem;
  private ToolStripMenuItem uidPass2FaToolStripMenuItem;
  private BunifuDragControl bunifuDragControl_1;
  private ToolTip toolTip_0;
  private ToolStripMenuItem toolStripMenuItem_10;
  private ToolStripMenuItem toolStripMenuItem_11;
  private ToolStripMenuItem toolStripMenuItem_12;
  private ToolStripMenuItem useragentToolStripMenuItem1;
  private ToolStripMenuItem proxyToolStripMenuItem1;
  private ComboBox cbbSearch;
  private MetroButton btnLoadAcc;
  private MetroComboBox cbbTinhTrang;
  private Label label2;
  private ToolStripMenuItem toolStripMenuItem_13;
  private MetroButton BtnSearch;
  private ToolStripMenuItem uidToolStripMenuItem;
  private ToolStripMenuItem checkAvatarToolStripMenuItem;
  private ToolStripMenuItem checkProxyToolStripMenuItem;
  private ToolStripMenuItem checkProfileToolStripMenuItem1;
  private ToolStripMenuItem checkInfoUIDToolStripMenuItem;
  private ToolStripMenuItem checkBackupToolStripMenuItem1;
  private ToolStripMenuItem toolStripMenuItem_14;
  private StatusStrip statusStrip1;
  private ToolStripStatusLabel toolStripStatusLabel5;
  private ToolStripStatusLabel lblCountSelect;
  private ToolStripStatusLabel toolStripStatusLabel7;
  private ToolStripStatusLabel lblCountTotal;
  private Button button9;
  private Button button3;
  private Label label3;
  private DataGridViewCheckBoxColumn cChose;
  private DataGridViewTextBoxColumn cStt;
  private DataGridViewTextBoxColumn cId;
  private DataGridViewTextBoxColumn cUid;
  private DataGridViewTextBoxColumn cToken;
  private DataGridViewTextBoxColumn cCookies;
  private DataGridViewTextBoxColumn cEmail;
  private DataGridViewTextBoxColumn cPhone;
  private DataGridViewTextBoxColumn cName;
  private DataGridViewTextBoxColumn cFollow;
  private DataGridViewTextBoxColumn cFriend;
  private DataGridViewTextBoxColumn cGroup;
  private DataGridViewTextBoxColumn cBirthday;
  private DataGridViewTextBoxColumn cGender;
  private DataGridViewTextBoxColumn cPassword;
  private DataGridViewTextBoxColumn cMailRecovery;
  private DataGridViewTextBoxColumn cPassMail;
  private DataGridViewTextBoxColumn cBackup;
  private DataGridViewTextBoxColumn cFa2;
  private DataGridViewTextBoxColumn cUseragent;
  private DataGridViewTextBoxColumn cProxy;
  private DataGridViewTextBoxColumn cDateCreateAcc;
  private DataGridViewTextBoxColumn cAvatar;
  private DataGridViewTextBoxColumn cProfile;
  private DataGridViewTextBoxColumn cThuMuc;
  private DataGridViewTextBoxColumn cInteractEnd;
  private DataGridViewTextBoxColumn cDevice;
  private DataGridViewTextBoxColumn cInfo;
  private DataGridViewTextBoxColumn cGhiChu;
  private DataGridViewTextBoxColumn cDateDelete;
  private IContainer components;
  private DataGridViewTextBoxColumn cStatus;

  public fBin()
  {
    this.InitializeComponent();
    this.method_1();
    this.method_0();
    this.menuStrip1.Cursor = Cursors.Hand;
    GClass35.smethod_5((Control) this);
    GClass35.smethod_7(this.ctmsAcc);
  }

  private void method_0()
  {
    this.cbbSearch.DataSource = (object) new BindingSource((object) new Dictionary<string, string>()
    {
      {
        "cUid",
        "UID"
      },
      {
        "cToken",
        "Token"
      },
      {
        "cCookies",
        "Cookie"
      },
      {
        "cEmail",
        "Email"
      },
      {
        "cPassMail",
        "Pass email"
      },
      {
        "cName",
        GClass35.smethod_0("Tên")
      },
      {
        "cBirthday",
        GClass35.smethod_0("Ngày sinh")
      },
      {
        "cGender",
        GClass35.smethod_0("Giới tính")
      },
      {
        "cPassword",
        GClass35.smethod_0("Mật khẩu")
      },
      {
        "cGhiChu",
        GClass35.smethod_0("Ghi chú")
      },
      {
        "cInteractEnd",
        GClass35.smethod_0("Tương tác cuối")
      }
    }, (string) null);
    this.cbbSearch.ValueMember = "Key";
    this.cbbSearch.DisplayMember = "Value";
  }

  private void method_1()
  {
    this.dtgvAcc.Columns["cToken"].Visible = GClass33.smethod_0("configDatagridview").method_4("cToken");
    this.dtgvAcc.Columns["cCookies"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbCookie");
    this.dtgvAcc.Columns["cEmail"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbEmail");
    this.dtgvAcc.Columns["cName"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbTen");
    this.dtgvAcc.Columns["cFriend"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbBanBe");
    this.dtgvAcc.Columns["cGroup"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbNhom");
    this.dtgvAcc.Columns["cBirthday"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbNgaySinh");
    this.dtgvAcc.Columns["cGender"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbGioiTinh");
    this.dtgvAcc.Columns["cPassword"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbMatKhau");
    this.dtgvAcc.Columns["cPassMail"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbMatKhauMail");
    this.dtgvAcc.Columns["cBackup"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbBackup");
    this.dtgvAcc.Columns["cFa2"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbMa2FA");
    this.dtgvAcc.Columns["cUseragent"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbUseragent");
    this.dtgvAcc.Columns["cProxy"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbProxy");
    this.dtgvAcc.Columns["cDateCreateAcc"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbNgayTao");
    this.dtgvAcc.Columns["cAvatar"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbAvatar");
    this.dtgvAcc.Columns["cProfile"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbProfile");
    this.dtgvAcc.Columns["cInfo"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbTinhTrang");
    this.dtgvAcc.Columns["cThuMuc"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbThuMuc");
    this.dtgvAcc.Columns["cGhiChu"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbGhiChu");
    this.dtgvAcc.Columns["cFollow"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbFollow");
    this.dtgvAcc.Columns["cInteractEnd"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbInteractEnd");
    this.dtgvAcc.Columns["cDevice"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbDevice");
  }

  protected override void OnLoad(EventArgs e) => Application.Idle += new EventHandler(this.method_31);

  private void btnMinimize_Click(object sender, EventArgs e) => this.Close();

  private void button1_Click(object sender, EventArgs e) => this.smethod_4();

  private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

  private void btnLoadAcc_Click(object sender, EventArgs e)
  {
    string str = "";
    if (this.cbbThuMuc.SelectedValue != null)
      str = this.cbbThuMuc.SelectedValue.ToString();
    this.method_32();
    if (str != "999999" && str != "-1")
    {
      this.int_1 = -1;
      this.cbbThuMuc.SelectedValue = (object) str;
    }
    else
    {
      this.bool_2 = false;
      this.cbbThuMuc.SelectedValue = (object) str;
      this.bool_2 = true;
      this.method_33(fChonThuMuc.list_1);
    }
  }

  private List<string> method_2()
  {
    List<string> stringList1 = (List<string>) null;
    try
    {
      List<string> stringList2;
      switch (this.cbbThuMuc.SelectedValue.ToString())
      {
        case "-1":
          goto label_6;
        case "999999":
          stringList2 = GClass37.smethod_2(fChonThuMuc.list_1);
          break;
        default:
          stringList2 = new List<string>()
          {
            this.cbbThuMuc.SelectedValue.ToString()
          };
          break;
      }
      stringList1 = stringList2;
    }
    catch
    {
    }
label_6:
    return stringList1;
  }

  private void method_3(List<string> list_5 = null, string string_0 = "", bool bool_4 = false)
  {
    try
    {
      this.dtgvAcc.Rows.Clear();
      if (string_0 == "[Tất cả tình trạng]" || string_0 == GClass35.smethod_0("[Tất cả tình trạng]"))
        string_0 = "";
      this.method_4(Class42.smethod_19(list_5, string_0, bool_4));
    }
    catch (Exception ex)
    {
    }
  }

  private void method_4(DataTable dataTable_0)
  {
    Class14.smethod_6(this.dtgvAcc, dataTable_0);
    this.method_16(0);
    this.method_6();
    this.method_15();
  }

  private void method_5(int int_3, int int_4)
  {
    switch (int_4)
    {
      case 1:
        this.dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
        break;
      case 2:
        this.dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
        break;
    }
  }

  private void method_6(int int_3 = -1)
  {
    if (GClass33.smethod_0("configGeneral").method_3("typePhanBietMau") == 0)
    {
      if (int_3 == -1)
      {
        for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
        {
          string str = this.method_12(index);
          if (str == "Live")
            this.dtgvAcc.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
          else if (str.Contains("Die") || str.Contains(GClass35.smethod_0("Checkpoint")) || str.Contains("Changed pass"))
            this.dtgvAcc.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
        }
      }
      else
      {
        string str = this.method_12(int_3);
        if (str == "Live")
          this.dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
        else if (str.Contains("Die") || str.Contains(GClass35.smethod_0("Checkpoint")) || str.Contains("Changed pass"))
          this.dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
      }
    }
    else if (int_3 == -1)
    {
      for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      {
        string str = this.method_12(index);
        if (str == "Live")
          this.dtgvAcc.Rows[index].DefaultCellStyle.ForeColor = Color.Green;
        else if (str.Contains("Die") || str.Contains(GClass35.smethod_0("Checkpoint")) || str.Contains("Changed pass"))
          this.dtgvAcc.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
      }
    }
    else
    {
      string str = this.method_12(int_3);
      if (str == "Live")
        this.dtgvAcc.Rows[int_3].DefaultCellStyle.ForeColor = Color.Green;
      else if (str.Contains("Die") || str.Contains(GClass35.smethod_0("Checkpoint")) || str.Contains("Changed pass"))
        this.dtgvAcc.Rows[int_3].DefaultCellStyle.ForeColor = Color.Red;
    }
  }

  public void method_7(int int_3, string string_0) => Class14.Status(this.dtgvAcc, int_3, "cStatus", (object) string_0);

  public void method_8(string string_0, int int_3, string string_1)
  {
    Class14.Status(this.dtgvAcc, int_3, "cInfo", (object) string_1);
    this.method_6(int_3);
    Class42.smethod_13(string_0, "info", string_1);
  }

  public void method_9(int int_3, string string_0, object object_10) => Class14.Status(this.dtgvAcc, int_3, string_0, object_10);

  public void method_10(int int_3, int int_4, object object_10) => Class14.smethod_4(this.dtgvAcc, int_3, int_4, object_10);

  public string method_11(int int_3) => Class14.smethod_3(this.dtgvAcc, int_3, "cStatus");

  public string method_12(int int_3) => Class14.smethod_3(this.dtgvAcc, int_3, "cInfo");

  public string method_13(int int_3, string string_0) => Class14.smethod_3(this.dtgvAcc, int_3, string_0);

  public string method_14(int int_3, int int_4) => Class14.smethod_2(this.dtgvAcc, int_3, int_4);

  private void method_15()
  {
    try
    {
      this.lblCountTotal.Text = this.dtgvAcc.Rows.Count.ToString();
    }
    catch
    {
    }
  }

  private void method_16(int int_3 = -1)
  {
    if (int_3 == -1)
    {
      int_3 = 0;
      for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          ++int_3;
      }
    }
    this.lblCountSelect.Text = int_3.ToString();
  }

  private void method_17(int int_3 = -1)
  {
    if (GClass33.smethod_0("configGeneral").method_3("typePhanBietMau") == 0)
    {
      if (int_3 == -1)
      {
        for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
        {
          string str = Class14.smethod_3(this.dtgvAcc, index, "cInfo");
          if (str == "Live")
            this.dtgvAcc.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
          else if (str.Contains("Die") || str.Contains(GClass35.smethod_0("Checkpoint")) || str.Contains("Changed pass"))
            this.dtgvAcc.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
        }
      }
      else
      {
        switch (Class14.smethod_3(this.dtgvAcc, int_3, "cInfo"))
        {
          case "Live":
            this.dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
            break;
          case "Die":
            this.dtgvAcc.Rows[int_3].DefaultCellStyle.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
            break;
        }
      }
    }
    else if (int_3 == -1)
    {
      for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      {
        string str = Class14.smethod_3(this.dtgvAcc, index, "cInfo");
        if (str.Contains("Die") || str.Contains(GClass35.smethod_0("Checkpoint")))
          this.dtgvAcc.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
      }
    }
    else
    {
      string str = Class14.smethod_3(this.dtgvAcc, int_3, "cInfo");
      if (!(str == "Live") && str == "Die")
        this.dtgvAcc.Rows[int_3].DefaultCellStyle.ForeColor = Color.Red;
    }
  }

  private void method_18(
    string string_0,
    string string_1,
    int int_3,
    int int_4,
    DataGridView dataGridView_0)
  {
    if (!this.bool_1)
      Class14.Status(this.dtgvAcc, int_3, string_1, (object) string_0);
    if (!(string_1 == "cInfo"))
      return;
    this.method_17(int_3);
  }

  private void method_19(string string_0)
  {
    switch (string_0)
    {
      case "ToggleCheck":
        for (int index1 = 0; index1 < this.dtgvAcc.SelectedRows.Count; ++index1)
        {
          int index2 = this.dtgvAcc.SelectedRows[index1].Index;
          this.method_9(index2, "cChose", (object) !Convert.ToBoolean(this.method_13(index2, "cChose")));
        }
        this.method_16();
        break;
      case "SelectHighline":
        DataGridViewSelectedRowCollection selectedRows = this.dtgvAcc.SelectedRows;
        for (int index = 0; index < selectedRows.Count; ++index)
          this.method_9(selectedRows[index].Index, "cChose", (object) true);
        this.method_16();
        break;
      case "UnAll":
        for (int int_3 = 0; int_3 < this.dtgvAcc.RowCount; ++int_3)
          this.method_9(int_3, "cChose", (object) false);
        this.method_16(0);
        break;
      case "All":
        for (int int_3 = 0; int_3 < this.dtgvAcc.RowCount; ++int_3)
          this.method_9(int_3, "cChose", (object) true);
        this.method_16(this.dtgvAcc.RowCount);
        break;
    }
  }

  private void method_20(string string_0)
  {
    try
    {
      List<string> stringList = new List<string>();
      for (int int_0 = 0; int_0 < this.dtgvAcc.Rows.Count; ++int_0)
      {
        if (Convert.ToBoolean(Class14.smethod_3(this.dtgvAcc, int_0, "cChose")))
        {
          stringList.Add(Class14.smethod_3(this.dtgvAcc, int_0, "cId"));
          break;
        }
      }
      if (stringList.Count == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn danh sách tài khoản muốn copy thông tin!"), 3);
      }
      else
      {
        string text = "";
        // ISSUE: reference to a compiler-generated method
        switch (Class206.smethod_0(string_0))
        {
          case 159575910:
            if (!(string_0 == "uid|pass"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cUid") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cPassword") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 457434463:
            if (!(string_0 == "uid|pass|token|cookie"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cUid") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cPassword") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cToken") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cCookies") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 738560386:
            if (!(string_0 == "ma2fa"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + GClass19.smethod_85(Class14.smethod_3(this.dtgvAcc, index, "cFa2")) + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 1329202400:
            if (!(string_0 == "mail|passmail"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cEmail") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cPassMail") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 1556604621:
            if (!(string_0 == "uid"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cUid") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 1718322808:
            if (!(string_0 == "2fa"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cFa2") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 2007449791:
            if (!(string_0 == "cookie"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cCookies") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 2071622424:
            if (!(string_0 == "pass"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cPassword") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 2107770459:
            if (!(string_0 == "proxy"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  string str = Class14.smethod_3(this.dtgvAcc, index, "cProxy");
                  if (str.EndsWith("*0") || str.EndsWith("*1"))
                    str = str.Substring(0, str.Length - 2);
                  text = text + str + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 2337339239:
            if (!(string_0 == "useragent"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cUseragent") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 2369371622:
            if (!(string_0 == "name"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cName") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text.TrimEnd('\r', '\n'));
            break;
          case 2491017778:
            if (!(string_0 == "token"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cToken") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 2703251604:
            if (!(string_0 == "uid|pass|token|cookie|mail|passmail"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cUid") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cPassword") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cToken") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cCookies") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cEmail") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cPassMail") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 3144981877:
            if (!(string_0 == "uid|pass|2fa"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cUid") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cPassword") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cFa2") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 3728375369:
            if (!(string_0 == "uid|pass|token|cookie|mail|passmail|fa2"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cUid") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cPassword") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cToken") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cCookies") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cEmail") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cPassMail") + "|" + Class14.smethod_3(this.dtgvAcc, index, "cFa2") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 3968918830:
            if (!(string_0 == "mail"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cEmail") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text);
            break;
          case 4025178668:
            if (!(string_0 == "birthday"))
              break;
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                try
                {
                  text = text + Class14.smethod_3(this.dtgvAcc, index, "cBirthday") + "\r\n";
                }
                catch
                {
                }
              }
            }
            Clipboard.SetText(text.TrimEnd('\r', '\n'));
            break;
        }
      }
    }
    catch
    {
    }
  }

  private void toolStripMenuItem_2_Click(object sender, EventArgs e) => this.method_19("All");

  private void liveToolStripMenuItem_Click(object sender, EventArgs e) => this.method_19("SelectHighline");

  private void toolStripMenuItem_3_Click(object sender, EventArgs e) => this.method_19("UnAll");

  private void tokenToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("token");

  private void cookieToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("cookie");

  private void uidToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("uid");

  private void passToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("pass");

  private void uidPassToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("uid|pass");

  private void uidPassTokenCookieToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("uid|pass|token|cookie");

  private void fBin_Load(object sender, EventArgs e)
  {
  }

  private void ctmsAcc_Opening(object sender, CancelEventArgs e)
  {
    this.toolStripMenuItem_8.DropDownItems.Clear();
    List<string> stringList1 = new List<string>();
    for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
    {
      string input = Class14.smethod_3(this.dtgvAcc, int_0, "cStatus");
      if (input != "")
      {
        string oldValue1 = Regex.Match(input, "\\(IP: (.*?)\\)").Value;
        if (oldValue1 != "")
          input = input.Replace(oldValue1, "").Trim();
        string oldValue2 = Regex.Match(input, "\\[(.*?)\\]").Value;
        if (oldValue2 != "")
          input = input.Replace(oldValue2, "").Trim();
        if (input != "" && !stringList1.Contains(input))
          stringList1.Add(input);
      }
    }
    for (int index = 0; index < stringList1.Count; ++index)
    {
      this.toolStripMenuItem_8.DropDownItems.Add(stringList1[index]);
      this.toolStripMenuItem_8.DropDownItems[index].Click += new EventHandler(this.method_22);
    }
    this.tinhTrangToolStripMenuItem.DropDownItems.Clear();
    List<string> stringList2 = new List<string>();
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (this.dtgvAcc.Rows[index].Cells["cInfo"].Value != null && !Class14.smethod_3(this.dtgvAcc, index, "cInfo").Equals("") && !stringList2.Contains(Class14.smethod_3(this.dtgvAcc, index, "cInfo")))
        stringList2.Add(Class14.smethod_3(this.dtgvAcc, index, "cInfo"));
    }
    for (int index = 0; index < stringList2.Count; ++index)
    {
      this.tinhTrangToolStripMenuItem.DropDownItems.Add(stringList2[index]);
      this.tinhTrangToolStripMenuItem.DropDownItems[index].Click += new EventHandler(this.method_21);
    }
  }

  private void method_21(object sender, EventArgs e)
  {
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      string text = ((ToolStripItem) sender).Text;
      this.dtgvAcc.Rows[index].Cells["cChose"].Value = !Class14.smethod_3(this.dtgvAcc, index, "cInfo").Equals(text) ? (object) false : (object) true;
    }
  }

  private void method_22(object sender, EventArgs e)
  {
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      string text = ((ToolStripItem) sender).Text;
      this.dtgvAcc.Rows[index].Cells["cChose"].Value = !Class14.smethod_3(this.dtgvAcc, index, "cStatus").Contains(text) ? (object) false : (object) true;
    }
  }

  private void method_23()
  {
    List<string> list_0 = new List<string>();
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        list_0.Add(this.dtgvAcc.Rows[index].Cells["cId"].Value.ToString());
    }
    if (list_0.Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn tài khoản cần xóa!"), 3);
    }
    else
    {
      if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có thực sự muốn xóa {0} tài khoản đã chọn?"), (object) this.method_53()) + "\r\n\r\n" + GClass35.smethod_0("Chú ý: Tài khoản đã xóa thì không thể khôi phục lại được nữa!")) == DialogResult.Yes)
      {
        if (Class42.smethod_25(list_0, true))
        {
          for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              this.dtgvAcc.Rows.RemoveAt(index--);
          }
          if (Class42.smethod_6())
            this.method_24();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Xóa thất bại, vui lòng thử lại sau!"), 2);
        this.method_41();
      }
      this.method_30();
      this.method_28();
    }
  }

  private void method_24()
  {
    this.method_17();
    this.method_41();
    this.method_30();
    this.method_28();
  }

  private bool method_25(string string_0) => GClass19.smethod_51(string_0) && !string_0.StartsWith("0");

  private void method_26(string string_0) => this.Invoke((Delegate) (() =>
  {
    try
    {
      switch (string_0)
      {
        case "start":
          this.grTimKiem.Enabled = false;
          this.grQuanLyThuMuc.Enabled = false;
          break;
        case "stop":
          this.grTimKiem.Enabled = true;
          this.grQuanLyThuMuc.Enabled = true;
          break;
      }
    }
    catch (Exception ex)
    {
    }
  }));

  private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.ColumnIndex != 0)
      return;
    try
    {
      this.dtgvAcc.CurrentRow.Cells["cChose"].Value = (object) !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value);
      this.method_16();
    }
    catch
    {
    }
  }

  private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyValue != 32)
      return;
    this.method_19("ToggleCheck");
  }

  private void method_27(int int_3, string string_0)
  {
    if (this.bool_1)
      return;
    Class14.Status(this.dtgvAcc, int_3, "cStatus", (object) string_0);
  }

  private void toolStripMenuItem_6_Click(object sender, EventArgs e) => this.btnLoadAcc_Click((object) null, (EventArgs) null);

  private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!this.bool_2 || this.cbbThuMuc.SelectedValue == null || !GClass15.smethod_0(this.cbbThuMuc.SelectedValue.ToString()) || this.cbbThuMuc.SelectedValue.ToString() != "999999" && this.int_1 == this.cbbThuMuc.SelectedIndex)
      return;
    switch (this.cbbThuMuc.SelectedValue.ToString())
    {
      case "-1":
        this.method_33();
        break;
      case "999999":
        GClass19.smethod_35((Form) new fChonThuMuc(true));
        if (!fChonThuMuc.bool_1 || fChonThuMuc.list_1 == null || fChonThuMuc.list_1.Count == 0)
        {
          this.bool_2 = false;
          this.cbbThuMuc.SelectedIndex = this.int_1 != -1 ? this.int_1 : 0;
          this.bool_2 = true;
        }
        else
          this.method_33(fChonThuMuc.list_1);
        break;
      default:
        this.method_33(this.method_2());
        break;
    }
    this.int_1 = this.cbbThuMuc.SelectedIndex;
  }

  private void mailPassMailToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("mail|passmail");

  private void uidPassTokenCookieMailPassMailToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("uid|pass|token|cookie|mail|passmail");

  private void method_28()
  {
    int num = 0;
    for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        ++num;
    }
    try
    {
      this.lblCountSelect.Text = num.ToString();
    }
    catch
    {
    }
  }

  private void checkAvatarToolStripMenuItem_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fNhapTokenTrungGian());
    if (!fNhapTokenTrungGian.bool_0)
      return;
    string string_0 = GClass33.smethod_0("configGeneral").method_1("token");
    if (!Class38.smethod_21("", string_0, "", ""))
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng kiểm tra lại token trung gian!"));
    }
    else
    {
      int int_0 = 0;
      int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
      this.bool_0 = false;
      new Thread((ThreadStart) (() =>
      {
        this.method_26("start");
        int index = 0;
        while (index < this.dtgvAcc.Rows.Count)
        {
          Application.DoEvents();
          if (!this.bool_0)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
            {
              if (int_0 < int_1)
              {
                Interlocked.Increment(ref int_0);
                int int_2 = index++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_18(GClass35.smethod_0("Đang kiểm tra..."), "cStatus", int_2, 0, this.dtgvAcc);
                  this.method_29(int_2, string_0);
                  Interlocked.Decrement(ref int_0);
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
            else
              ++index;
          }
          else
            break;
        }
        int tickCount = Environment.TickCount;
        while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
        {
          Application.DoEvents();
          Thread.Sleep(300);
        }
        this.method_26("stop");
      }))
      {
        IsBackground = true
      }.Start();
    }
  }

  private void method_29(int int_3, string string_0)
  {
    try
    {
      string string_0_1 = this.dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
      string string_0_2 = this.dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
      if (Class38.smethod_12(string_0_1, string_0))
      {
        this.method_18(GClass35.smethod_0("Đã có avatar!"), "cStatus", int_3, 2, this.dtgvAcc);
        this.method_18("Yes", "cAvatar", int_3, 0, this.dtgvAcc);
        Class42.smethod_13(string_0_2, "avatar", "Yes");
      }
      else
      {
        this.method_18(GClass35.smethod_0("Không có avatar!"), "cStatus", int_3, 2, this.dtgvAcc);
        this.method_18("No", "cAvatar", int_3, 0, this.dtgvAcc);
        Class42.smethod_13(string_0_2, "avatar", "No");
      }
    }
    catch
    {
      this.method_18(GClass35.smethod_0("Lỗi!!!"), "cStatus", int_3, 2, this.dtgvAcc);
    }
  }

  private void method_30()
  {
    try
    {
      this.lblCountTotal.Text = this.dtgvAcc.Rows.Count.ToString();
    }
    catch
    {
    }
  }

  private void method_31(object sender, EventArgs e)
  {
    Application.Idle -= new EventHandler(this.method_31);
    this.method_1();
    this.method_32();
    this.method_33();
  }

  private void method_32()
  {
    this.bool_2 = false;
    this.cbbThuMuc.DataSource = (object) Class42.smethod_2(true);
    this.cbbThuMuc.ValueMember = "id";
    this.cbbThuMuc.DisplayMember = "name";
    this.bool_2 = true;
  }

  private void method_33(List<string> list_5 = null)
  {
    try
    {
      this.cbbTinhTrang.DataSource = (object) Class42.smethod_9(list_5, false);
      this.cbbTinhTrang.ValueMember = "id";
      this.cbbTinhTrang.DisplayMember = "name";
    }
    catch
    {
    }
  }

  private void method_34(int int_3)
  {
    int int_4 = 0;
    int int_5 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    string string_0 = GClass33.smethod_0("configGeneral").method_1("token");
    this.bool_0 = false;
    new Thread((ThreadStart) (() =>
    {
      this.method_26("start");
      switch (int_3)
      {
        case 0:
          int index1 = 0;
          while (index1 < this.dtgvAcc.Rows.Count && !this.bool_0)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index1].Cells["cChose"].Value))
            {
              if (int_4 < int_5)
              {
                Interlocked.Increment(ref int_4);
                int int_8 = index1++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_18(GClass35.smethod_0("Đang kiểm tra..."), "cStatus", int_8, 0, this.dtgvAcc);
                  this.method_37(int_8, string_0);
                  Interlocked.Decrement(ref int_4);
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
            else
              ++index1;
          }
          break;
        case 1:
          int index2 = 0;
          while (index2 < this.dtgvAcc.Rows.Count && !this.bool_0)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index2].Cells["cChose"].Value))
            {
              if (int_4 < int_5)
              {
                Interlocked.Increment(ref int_4);
                int int_6 = index2++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_18(GClass35.smethod_0("Đang kiểm tra..."), "cStatus", int_6, 0, this.dtgvAcc);
                  this.method_38(int_6);
                  Interlocked.Decrement(ref int_4);
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
            else
              ++index2;
          }
          break;
        case 2:
          int index3 = 0;
          while (index3 < this.dtgvAcc.Rows.Count && !this.bool_0)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index3].Cells["cChose"].Value))
            {
              if (int_4 < int_5)
              {
                Interlocked.Increment(ref int_4);
                int int_10 = index3++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_18(GClass35.smethod_0("Đang kiểm tra..."), "cStatus", int_10, 0, this.dtgvAcc);
                  this.method_39(int_10);
                  Interlocked.Decrement(ref int_4);
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
            else
              ++index3;
          }
          break;
        case 3:
          int index4 = 0;
          while (index4 < this.dtgvAcc.Rows.Count && !this.bool_0)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index4].Cells["cChose"].Value))
            {
              if (int_4 < int_5)
              {
                Interlocked.Increment(ref int_4);
                int int_7 = index4++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_18(GClass35.smethod_0("Đang kiểm tra..."), "cStatus", int_7, 0, this.dtgvAcc);
                  this.method_40(int_7);
                  Interlocked.Decrement(ref int_4);
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
            else
              ++index4;
          }
          break;
        case 4:
          int index5 = 0;
          while (index5 < this.dtgvAcc.Rows.Count && !this.bool_0)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index5].Cells["cChose"].Value))
            {
              if (int_4 < int_5)
              {
                Interlocked.Increment(ref int_4);
                int int_9 = index5++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_18(GClass35.smethod_0("Đang kiểm tra..."), "cStatus", int_9, 0, this.dtgvAcc);
                  this.method_36(int_9);
                  Interlocked.Decrement(ref int_4);
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
            else
              ++index5;
          }
          break;
        case 5:
          int index6 = 0;
          while (index6 < this.dtgvAcc.Rows.Count && !this.bool_0)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index6].Cells["cChose"].Value))
            {
              if (int_4 < int_5)
              {
                Interlocked.Increment(ref int_4);
                int int_11 = index6++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_18(GClass35.smethod_0("Đang kiểm tra..."), "cStatus", int_11, 0, this.dtgvAcc);
                  this.method_35(int_11);
                  Interlocked.Decrement(ref int_4);
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
            else
              ++index6;
          }
          break;
      }
      int tickCount = Environment.TickCount;
      while (int_4 > 0 && Environment.TickCount - tickCount <= 60000)
        GClass19.smethod_64(1.0);
      this.method_26("stop");
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_35(int int_3)
  {
    try
    {
      string string_0_1 = this.method_13(int_3, "cId");
      string string_0_2 = this.method_13(int_3, "cUid");
      if (!this.method_25(string_0_2))
      {
        this.method_7(int_3, GClass35.smethod_0("Uid không hợp lệ!"));
      }
      else
      {
        string str1 = Class38.smethod_19(string_0_2);
        if (str1.StartsWith("0|"))
        {
          if (Class38.smethod_17(string_0_2).StartsWith("0|"))
          {
            this.method_7(int_3, GClass35.smethod_0("Tài khoản Die!"));
            this.method_8(string_0_1, int_3, "Die");
          }
          else
            this.method_7(int_3, GClass35.smethod_0("Không check được!"));
        }
        else if (str1.StartsWith("1|"))
        {
          string[] strArray = str1.Split('|');
          string object_10_1 = strArray[2];
          string lower = strArray[3].ToLower();
          string str2 = strArray[4];
          string object_10_2 = strArray[5];
          string object_10_3 = strArray[6];
          Class42.smethod_14(string_0_1, "name|gender|friends|groups", object_10_1 + "|" + lower + "|" + object_10_2 + "|" + object_10_3);
          this.method_9(int_3, "cName", (object) object_10_1);
          this.method_9(int_3, "cGender", (object) lower);
          this.method_9(int_3, "cFriend", (object) object_10_2);
          this.method_9(int_3, "cGroup", (object) object_10_3);
          if (str2 != "")
          {
            this.method_9(int_3, "cBirthday", (object) str2);
            Class42.smethod_13(string_0_1, "birthday", str2);
          }
          this.method_8(string_0_1, int_3, "Live");
          string string_0_3 = GClass35.smethod_0("Cập nhật thông tin thành công!");
          this.method_7(int_3, string_0_3);
        }
        else
          this.method_7(int_3, GClass35.smethod_0("Không check được!"));
      }
    }
    catch
    {
      this.method_7(int_3, GClass35.smethod_0("Không check được!"));
    }
  }

  private void method_36(int int_3)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_3].Cells["cEmail"].Value.ToString();
      string string_1 = this.dtgvAcc.Rows[int_3].Cells["cPassMail"].Value.ToString();
      if (string_0 == "" || string_1 == "")
        this.method_18(GClass35.smethod_0("Không tìm thấy mail") + "!!!", "cStatus", int_3, 2, this.dtgvAcc);
      else if (string_0.EndsWith("@hotmail.com") || string_0.EndsWith("@outlook.com"))
      {
        if (GClass19.smethod_21(string_0, string_1).Equals("1"))
          this.method_18(GClass35.smethod_0("Tài khoản mail: live!"), "cStatus", int_3, 0, this.dtgvAcc);
        else
          this.method_18(GClass35.smethod_0("Tài khoản mail: die!"), "cStatus", int_3, 1, this.dtgvAcc);
      }
      else
        this.method_18(GClass35.smethod_0("Mail chưa hỗ trợ") + "!!!", "cStatus", int_3, 2, this.dtgvAcc);
    }
    catch
    {
      this.method_18(GClass35.smethod_0("Lỗi!!!"), "cStatus", int_3, 2, this.dtgvAcc);
    }
  }

  private void method_37(int int_3, string string_0)
  {
    try
    {
      string string_0_1 = this.method_13(int_3, "cId");
      string string_0_2 = this.method_13(int_3, "cUid");
      if (!this.method_25(string_0_2))
      {
        this.method_7(int_3, GClass35.smethod_0("Uid không hợp lệ!"));
      }
      else
      {
        string string_1 = "";
        string str = Class38.smethod_17(string_0_2);
        string string_0_3;
        if (str.StartsWith("0|"))
        {
          string_1 = "Die";
          string_0_3 = "Wall die";
        }
        else if (str.StartsWith("1|"))
        {
          string_1 = "Live";
          string_0_3 = "Wall live";
        }
        else
          string_0_3 = GClass35.smethod_0("Không check được!");
        this.method_7(int_3, string_0_3);
        if (!(string_1 != ""))
          return;
        this.method_8(string_0_1, int_3, string_1);
      }
    }
    catch
    {
      this.method_7(int_3, GClass35.smethod_0("Không check được!"));
    }
  }

  private void method_38(int int_3)
  {
    try
    {
      string string_1_1 = "";
      string string_0_1 = Class14.smethod_3(this.dtgvAcc, int_3, "cId");
      string string_0_2 = Class14.smethod_3(this.dtgvAcc, int_3, "cCookies");
      string string_1_2 = Class14.smethod_3(this.dtgvAcc, int_3, "cToken");
      string string_2 = Class14.smethod_3(this.dtgvAcc, int_3, "cUseragent");
      string string_3 = "";
      int int_0 = 0;
      if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
      {
        string_3 = Class14.smethod_3(this.dtgvAcc, int_3, "cProxy");
        int_0 = string_3.EndsWith("*1") ? 1 : 0;
        if (string_3.EndsWith("*0") || string_3.EndsWith("*1"))
          string_3 = string_3.Substring(0, string_3.Length - 2);
      }
      int num;
      if (string_2 == "")
        num = string_3.Split(':').Length == 4 ? 1 : 0;
      else
        num = 0;
      if (num != 0)
        string_2 = Class54.string_5;
      string string_0_3;
      if (!Class38.smethod_21(string_0_2, string_1_2, string_2, string_3, int_0))
      {
        string_0_3 = "Token die";
      }
      else
      {
        string_1_1 = "Live";
        string_0_3 = "Token live";
      }
      this.method_18(string_0_3, "cStatus", int_3, 2, this.dtgvAcc);
      if (!(string_1_1 != ""))
        return;
      this.method_8(string_0_1, int_3, string_1_1);
    }
    catch
    {
      this.method_18(GClass35.smethod_0("Không check được!"), "cStatus", int_3, 2, this.dtgvAcc);
    }
  }

  private void method_39(int int_3)
  {
    try
    {
      string string_1_1 = "";
      string string_0_1 = Class14.smethod_3(this.dtgvAcc, int_3, "cId");
      string string_0_2 = Class14.smethod_3(this.dtgvAcc, int_3, "cCookies");
      string string_1_2 = Class14.smethod_3(this.dtgvAcc, int_3, "cUseragent");
      string string_2 = "";
      int int_0 = 0;
      if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
      {
        string_2 = Class14.smethod_3(this.dtgvAcc, int_3, "cProxy");
        int_0 = string_2.EndsWith("*1") ? 1 : 0;
        if (string_2.EndsWith("*0") || string_2.EndsWith("*1"))
          string_2 = string_2.Substring(0, string_2.Length - 2);
      }
      int num;
      if (string_1_2 == "")
        num = string_2.Split(':').Length == 4 ? 1 : 0;
      else
        num = 0;
      if (num != 0)
        string_1_2 = Class54.string_5;
      string string_0_3;
      if (!Class38.smethod_4(string_0_2, string_1_2, string_2, int_0).StartsWith("1|"))
      {
        string_0_3 = "Cookie die";
      }
      else
      {
        string_1_1 = "Live";
        string_0_3 = "Cookie live";
      }
      this.method_18(string_0_3, "cStatus", int_3, 2, this.dtgvAcc);
      if (!(string_1_1 != ""))
        return;
      this.method_8(string_0_1, int_3, string_1_1);
    }
    catch
    {
      this.method_18(GClass35.smethod_0("Không check được!"), "cStatus", int_3, 2, this.dtgvAcc);
    }
  }

  private void method_40(int int_3)
  {
    string string_0_1 = this.dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
    string string_0_2 = this.dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
    string string_1_1 = this.dtgvAcc.Rows[int_3].Cells["cPassword"].Value.ToString();
    string str1 = Class14.smethod_3(this.dtgvAcc, int_3, "cUseragent");
    string string_3 = "";
    int int_0 = 0;
    if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
    {
      string_3 = Class14.smethod_3(this.dtgvAcc, int_3, "cProxy");
      int_0 = string_3.EndsWith("*1") ? 1 : 0;
      if (string_3.EndsWith("*0") || string_3.EndsWith("*1"))
        string_3 = string_3.Substring(0, string_3.Length - 2);
    }
    int num;
    if (str1 == "")
      num = string_3.Split(':').Length == 4 ? 1 : 0;
    else
      num = 0;
    if (num != 0)
    {
      string string5 = Class54.string_5;
    }
    string string_1_2 = "";
    string string_0_3 = "";
    string str2 = "";
    string str3 = Class38.smethod_24(string_0_2, string_1_1, "", string_3, int_0);
    switch (str3.Split('|')[0])
    {
      case "3":
        string_1_2 = "Changed pass";
        break;
      case "2":
        string str4;
        if (str3.Split('|')[1].Trim() != "")
          str4 = "Checkpoint: " + str3.Split('|')[1];
        else
          str4 = GClass35.smethod_0("Checkpoint");
        string_1_2 = str4;
        break;
      case "1":
        str2 = str3.Split('|')[1];
        string_1_2 = "Live";
        break;
      case "5":
        string_0_3 = GClass35.smethod_0("Không check được (Có 2fa)!");
        break;
      case "0":
      case "4":
        string_0_3 = GClass35.smethod_0("Không check được!");
        break;
    }
    if (string_0_3 == "")
      string_0_3 = GClass35.smethod_0("Đã check xong!");
    if (str2 != "")
    {
      Class42.smethod_13(string_0_1, "cookie1", str2);
      this.method_18(str2, "cCookies", int_3, 1, this.dtgvAcc);
    }
    if (string_1_2 != "")
      this.method_8(string_0_1, int_3, string_1_2);
    this.method_18(string_0_3, "cStatus", int_3, 1, this.dtgvAcc);
  }

  private void toolStripMenuItem_9_Click(object sender, EventArgs e) => this.method_34(0);

  private void toolStripMenuItem_5_Click(object sender, EventArgs e)
  {
    if (GClass14.smethod_1(GClass35.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) != DialogResult.Yes)
      return;
    this.method_34(1);
  }

  private void toolStripMenuItem_4_Click(object sender, EventArgs e) => this.method_34(2);

  private void toolStripMenuItem_7_Click(object sender, EventArgs e) => this.method_34(3);

  private void mailToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("mail");

  private void BtnSearch_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.cbbSearch.SelectedIndex == -1)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn kiểu tìm kiếm!"));
      }
      else
      {
        string columnName = this.cbbSearch.SelectedValue.ToString();
        string str1 = this.txbSearch.Text.Trim();
        if (str1 == "")
        {
          GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung tìm kiếm!"));
        }
        else
        {
          List<int> intList = new List<int>();
          string str2 = GClass19.smethod_62(str1.ToLower());
          for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
          {
            string str3 = GClass19.smethod_62(this.dtgvAcc.Rows[index].Cells[columnName].Value.ToString().ToLower());
            str2 = GClass19.smethod_62(str2.ToLower());
            if (str3.Contains(str2))
              intList.Add(index);
          }
          int index1 = 0;
          if (intList.Count <= 0)
            return;
          int index2 = this.dtgvAcc.CurrentRow.Index;
          if (index2 >= intList[intList.Count - 1])
          {
            index1 = 0;
          }
          else
          {
            for (int index3 = 0; index3 < intList.Count; ++index3)
            {
              if (index2 < intList[index3])
              {
                index1 = index3;
                break;
              }
            }
          }
          int index4 = intList[index1];
          this.dtgvAcc.CurrentCell = this.dtgvAcc.Rows[index4].Cells[columnName];
          this.dtgvAcc.ClearSelection();
          this.dtgvAcc.Rows[index4].Selected = true;
        }
      }
    }
    catch
    {
    }
  }

  private void uidPassTokenCookieMailPassMail2faToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("uid|pass|token|cookie|mail|passmail|fa2");

  private void method_41()
  {
    for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
      Class14.Status(this.dtgvAcc, int_0, "cSTT", (object) (int_0 + 1));
  }

  private void fAToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("2fa");

  private void method_42(object sender, EventArgs e)
  {
    if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có chắc muốn xóa Profile của {0} tài khoản?"), (object) this.method_53())) != DialogResult.Yes)
      return;
    int int_0 = 0;
    int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    new Thread((ThreadStart) (() =>
    {
      int index = 0;
      while (index < this.dtgvAcc.Rows.Count)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        {
          if (int_0 < int_1)
          {
            Interlocked.Increment(ref int_0);
            int int_2 = index++;
            new Thread((ThreadStart) (() =>
            {
              this.method_18(GClass35.smethod_0("Đang xóa profile..."), "cStatus", int_2, 0, this.dtgvAcc);
              this.method_43(int_2);
              Interlocked.Decrement(ref int_0);
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
        else
          ++index;
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_43(int int_3)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
      string str = this.dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
      if (str.Trim() == "")
      {
        this.method_18(GClass35.smethod_0("Chưa tạo profile!"), "cStatus", int_3, 0, this.dtgvAcc);
      }
      else
      {
        string path = GClass33.smethod_0("configGeneral").method_1("txbPathProfile") + "\\" + str;
        if (Directory.Exists(path))
        {
          Directory.Delete(path, true);
          this.method_18(GClass35.smethod_0("Xóa profile thành công!"), "cStatus", int_3, 0, this.dtgvAcc);
          this.method_18("No", "cProfile", int_3, 0, this.dtgvAcc);
          Class42.smethod_13(string_0, "profile", "No");
        }
        else
          this.method_18(GClass35.smethod_0("Chưa tạo profile!"), "cStatus", int_3, 0, this.dtgvAcc);
      }
    }
    catch
    {
      this.method_18(GClass35.smethod_0("Xóa profile thất bại!"), "cStatus", int_3, 0, this.dtgvAcc);
    }
  }

  private void checkProfileToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = 10;
    new Thread((ThreadStart) (() =>
    {
      int index = 0;
      while (index < this.dtgvAcc.Rows.Count)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        {
          if (int_0 < int_1)
          {
            Interlocked.Increment(ref int_0);
            int int_2 = index++;
            new Thread((ThreadStart) (() =>
            {
              this.method_18(GClass35.smethod_0("Đang check profile..."), "cStatus", int_2, 0, this.dtgvAcc);
              this.method_44(int_2);
              Interlocked.Decrement(ref int_0);
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
        else
          ++index;
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_44(int int_3)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
      string str = this.dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
      if (Directory.Exists(GClass33.smethod_0("configGeneral").method_1("txbPathProfile") + "\\" + str))
      {
        this.method_18(GClass35.smethod_0("Đã có profile!"), "cStatus", int_3, 0, this.dtgvAcc);
        this.method_18("Yes", "cProfile", int_3, 0, this.dtgvAcc);
        Class42.smethod_13(string_0, "profile", "Yes");
      }
      else
      {
        this.method_18(GClass35.smethod_0("Chưa tạo profile!"), "cStatus", int_3, 0, this.dtgvAcc);
        this.method_18("No", "cProfile", int_3, 0, this.dtgvAcc);
        Class42.smethod_13(string_0, "profile", "No");
      }
    }
    catch
    {
    }
  }

  public void method_45(string string_0)
  {
    try
    {
      foreach (Process process in Process.GetProcessesByName(string_0))
        process.Kill();
    }
    catch
    {
    }
  }

  private void pictureBox1_DoubleClick(object sender, EventArgs e) => this.method_45("Chrome");

  private void uidPass2FaToolStripMenuItem_Click(object sender, EventArgs e) => this.method_20("uid|pass|2fa");

  private void toolStripMenuItem_10_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> list_2 = new List<string>();
      for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        {
          string str = this.method_13(index, "cProxy");
          if (str.EndsWith("*0") || str.EndsWith("*1"))
            str = str.Substring(0, str.Length - 2);
          list_2.Add(this.method_13(index, "cUid") + "|" + this.method_13(index, "cPassword") + "|" + this.method_13(index, "cToken") + "|" + this.method_13(index, "cCookies") + "|" + this.method_13(index, "cEmail") + "|" + this.method_13(index, "cPassMail") + "|" + this.method_13(index, "cFa2") + "|" + this.method_13(index, "cUseragent") + "|" + str + "|" + this.method_13(index, "cName") + "|" + this.method_13(index, "cGender") + "|" + this.method_13(index, "cFollow") + "|" + this.method_13(index, "cFriend") + "|" + this.method_13(index, "cGroup") + "|" + this.method_13(index, "cBirthday") + "|" + this.method_13(index, "cDateCreateAcc") + "|" + this.method_13(index, "cDevice") + "|LDPlayer-" + this.method_13(index, "cDevice"));
        }
      }
      if (list_2.Count <= 0)
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn danh sách tài khoản muốn copy thông tin!"), 3);
      else
        GClass19.smethod_35((Form) new fCopy(list_2));
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Error Copy");
    }
  }

  private void toolStripMenuItem_11_Click(object sender, EventArgs e) => this.method_20("ma2fa");

  private void toolStripMenuItem_8_Click(object sender, EventArgs e)
  {
  }

  private void method_46(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = 10;
    new Thread((ThreadStart) (() =>
    {
      try
      {
        int index = 0;
        while (index < this.dtgvAcc.Rows.Count)
        {
          if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          {
            if (int_0 < int_1)
            {
              Interlocked.Increment(ref int_0);
              int int_2 = index++;
              new Thread((ThreadStart) (() =>
              {
                try
                {
                  string input = Class14.smethod_3(this.dtgvAcc, int_2, "cCookies");
                  string str = Class14.smethod_3(this.dtgvAcc, int_2, "cUid");
                  if (str == "")
                    str = Regex.Match(input, "c_user=(.*?);").Groups[1].Value;
                  if (File.Exists("backup\\" + str + "\\" + str + ".html"))
                    Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + str + "\\" + str + ".html");
                  else
                    Class14.Status(this.dtgvAcc, int_2, "cStatus", (object) GClass35.smethod_0("Chưa tạo html!"));
                  Interlocked.Decrement(ref int_0);
                }
                catch (Exception ex)
                {
                  GClass19.smethod_81(ex);
                }
              }))
              {
                IsBackground = true
              }.Start();
            }
            else
              GClass19.smethod_64(1.0);
          }
          else
            ++index;
        }
        while (int_0 > 0)
          GClass19.smethod_64(1.0);
      }
      catch (Exception ex)
      {
        GClass19.smethod_81(ex);
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_47(object sender, EventArgs e)
  {
    string str1 = "";
    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
    {
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
        return;
      str1 = folderBrowserDialog.SelectedPath;
    }
    int num = 0;
    for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
    {
      try
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        {
          string str2 = this.dtgvAcc.Rows[index].Cells["cUid"].Value.ToString();
          try
          {
            if (File.Exists("backup\\" + str2 + "\\" + str2 + ".html"))
            {
              File.Copy("backup\\" + str2 + "\\" + str2 + ".html", str1 + "\\" + str2 + ".html");
              ++num;
            }
          }
          catch
          {
          }
        }
      }
      catch
      {
      }
    }
    GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Copy thành công {0} tệp backup html!"), (object) num));
  }

  private void method_48(object sender, EventArgs e)
  {
    string str1 = "";
    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
    {
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
        return;
      str1 = folderBrowserDialog.SelectedPath;
    }
    int num = 0;
    for (int index1 = 0; index1 < this.dtgvAcc.Rows.Count; ++index1)
    {
      try
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index1].Cells["cChose"].Value))
        {
          string str2 = this.dtgvAcc.Rows[index1].Cells["cUid"].Value.ToString();
          try
          {
            if (!Directory.Exists(str1 + "\\" + str2))
              Directory.CreateDirectory(str1 + "\\" + str2);
            string[] files = Directory.GetFiles("backup\\" + str2);
            for (int index2 = 0; index2 < files.Length; ++index2)
              File.Copy(files[index2], str1 + "\\" + str2 + "\\" + Path.GetFileName(files[index2]));
            ++num;
          }
          catch
          {
          }
        }
      }
      catch
      {
      }
    }
    GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Copy thành công {0} thư mục backup!"), (object) num));
  }

  private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
  {
    if (new List<string>()
    {
      "cStt",
      "cFriend",
      "cGroup",
      "cFollow"
    }.Contains(e.Column.Name))
    {
      e.SortResult = int.Parse(e.CellValue1.ToString() == "" ? "-1" : e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString() == "" ? "-1" : e.CellValue2.ToString()));
      e.Handled = true;
    }
    else
    {
      e.SortResult = (e.CellValue1.ToString() == "" ? "" : e.CellValue1.ToString()).CompareTo(e.CellValue2.ToString() == "" ? "" : e.CellValue2.ToString());
      e.Handled = true;
    }
  }

  private void toolStripMenuItem_12_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fCauHinhHienThi());
    this.method_1();
  }

  private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    this.bool_0 = false;
    new Thread((ThreadStart) (() =>
    {
      this.method_26("start");
      int index = 0;
      while (index < this.dtgvAcc.Rows.Count)
      {
        Application.DoEvents();
        if (!this.bool_0)
        {
          if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          {
            if (int_0 < int_1)
            {
              Interlocked.Increment(ref int_0);
              int int_2 = index++;
              new Thread((ThreadStart) (() =>
              {
                this.method_18(GClass35.smethod_0("Đang kiểm tra..."), "cStatus", int_2, 0, this.dtgvAcc);
                this.method_49(int_2);
                Interlocked.Decrement(ref int_0);
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
          else
            ++index;
        }
        else
          break;
      }
      int tickCount = Environment.TickCount;
      while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
      {
        Application.DoEvents();
        Thread.Sleep(300);
      }
      this.method_26("stop");
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_49(int int_3)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_3].Cells["cProxy"].Value.ToString();
      int int_2 = 0;
      if (string_0.EndsWith("*1"))
        int_2 = 1;
      if (string_0.EndsWith("*0") || string_0.EndsWith("*1"))
        string_0 = string_0.Substring(0, string_0.Length - 2);
      int num1 = 0;
      int num2 = 0;
      bool flag = false;
      for (int index = 0; index < 10; ++index)
      {
        if (GClass19.smethod_75(string_0, int_2) != "")
        {
          ++num1;
          if (num1 == 3)
          {
            flag = true;
            break;
          }
        }
        else
        {
          ++num2;
          if (num2 == 3)
            break;
        }
      }
      if (!flag)
        this.method_18("Proxy Die!", "cStatus", int_3, 2, this.dtgvAcc);
      else
        this.method_18("Proxy Live!", "cStatus", int_3, 2, this.dtgvAcc);
    }
    catch
    {
      this.method_18(GClass35.smethod_0("Lỗi!!!"), "cStatus", int_3, 2, this.dtgvAcc);
    }
  }

  private void useragentToolStripMenuItem1_Click(object sender, EventArgs e) => this.method_20("useragent");

  private void proxyToolStripMenuItem1_Click(object sender, EventArgs e) => this.method_20("proxy");

  private void method_50(object sender, EventArgs e)
  {
    for (int index = 0; index < this.dtgvAcc.Rows.Count && !this.bool_0; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
      {
        string str = "backup\\" + Class14.smethod_3(this.dtgvAcc, index, "cUid");
        if (Directory.Exists(str))
        {
          try
          {
            Process.Start(str);
            this.method_27(index, GClass35.smethod_0("Mở thành công!"));
          }
          catch
          {
            this.method_27(index, GClass35.smethod_0("Mở thất bại!"));
          }
        }
        else
          this.method_27(index, GClass35.smethod_0("Chưa backup!"));
      }
    }
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Alt)
      return;
    try
    {
      Process.Start(Path.GetDirectoryName(Application.ExecutablePath));
    }
    catch
    {
    }
  }

  private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!this.bool_3 || this.cbbTinhTrang.SelectedValue == null || !GClass15.smethod_0(this.cbbTinhTrang.SelectedValue.ToString()) || this.cbbTinhTrang.SelectedValue.ToString() != "-1" && this.int_2 == this.cbbTinhTrang.SelectedIndex)
      return;
    switch (this.cbbThuMuc.SelectedValue.ToString())
    {
      case "-1":
        this.method_3(string_0: this.cbbTinhTrang.Text);
        break;
      case "999999":
        this.method_3(fChonThuMuc.list_1, this.cbbTinhTrang.Text);
        break;
      default:
        this.method_3(this.method_2(), this.cbbTinhTrang.Text);
        break;
    }
    this.int_2 = this.cbbTinhTrang.SelectedIndex;
  }

  private void toolStripMenuItem_1_Click(object sender, EventArgs e) => this.method_23();

  private void toolStripMenuItem_13_Click(object sender, EventArgs e) => this.method_34(4);

  private void method_51(object sender, EventArgs e) => this.method_20("name");

  private void method_52(object sender, EventArgs e) => this.method_20("birthday");

  public int method_53()
  {
    int num = 0;
    try
    {
      for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          ++num;
      }
    }
    catch
    {
    }
    return num;
  }

  private void method_54(object sender, EventArgs e)
  {
    if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có chắc muốn xóa dữ liệu backup của {0} tài khoản?"), (object) this.method_53())) != DialogResult.Yes)
      return;
    int int_0 = 0;
    int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    new Thread((ThreadStart) (() =>
    {
      int index = 0;
      while (index < this.dtgvAcc.Rows.Count)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        {
          if (int_0 < int_1)
          {
            Interlocked.Increment(ref int_0);
            int int_2 = index++;
            new Thread((ThreadStart) (() =>
            {
              this.method_18(GClass35.smethod_0("Đang xóa dữ liệu backup..."), "cStatus", int_2, 0, this.dtgvAcc);
              this.method_55(int_2);
              Interlocked.Decrement(ref int_0);
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
        else
          ++index;
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_55(int int_3)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
      string str = this.dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
      if (str.Trim() == "")
      {
        this.method_18(GClass35.smethod_0("Chưa backup!"), "cStatus", int_3, 0, this.dtgvAcc);
      }
      else
      {
        string path = "backup\\" + str;
        if (Directory.Exists(path))
        {
          Directory.Delete(path, true);
          this.method_18(GClass35.smethod_0("Xóa dữ liệu backup thành công!"), "cStatus", int_3, 0, this.dtgvAcc);
          this.method_18("", "cBackup", int_3, 0, this.dtgvAcc);
          Class42.smethod_13(string_0, "backup", "");
        }
        else
          this.method_18(GClass35.smethod_0("Chưa backup!"), "cStatus", int_3, 0, this.dtgvAcc);
      }
    }
    catch
    {
      this.method_18(GClass35.smethod_0("Xóa dữ liệu backup thất bại!"), "cStatus", int_3, 0, this.dtgvAcc);
    }
  }

  private void checkBackupToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = 10;
    string string_0 = GClass12.smethod_1();
    new Thread((ThreadStart) (() =>
    {
      int index = 0;
      while (index < this.dtgvAcc.Rows.Count)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        {
          if (int_0 < int_1)
          {
            Interlocked.Increment(ref int_0);
            int int_2 = index++;
            new Thread((ThreadStart) (() =>
            {
              this.method_7(int_2, GClass35.smethod_0("Đang check backup..."));
              this.method_56(int_2, string_0);
              Interlocked.Decrement(ref int_0);
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
        else
          ++index;
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_56(int int_3, string string_0)
  {
    try
    {
      string string_0_1 = this.dtgvAcc.Rows[int_3].Cells["cId"].Value.ToString();
      string str = this.dtgvAcc.Rows[int_3].Cells["cUid"].Value.ToString();
      string_0 = string_0 + "\\" + str + "\\" + str + ".txt";
      if (File.Exists(string_0))
      {
        this.method_7(int_3, GClass35.smethod_0("Đã backup!"));
        this.method_9(int_3, "cBackup", (object) GClass19.smethod_19(string_0));
        Class42.smethod_13(string_0_1, "backup", GClass19.smethod_19(string_0));
      }
      else
      {
        this.method_7(int_3, GClass35.smethod_0("Chưa backup!"));
        this.method_9(int_3, "cBackup", (object) "");
        Class42.smethod_13(string_0_1, "backup", "");
      }
    }
    catch
    {
    }
  }

  private void checkInfoUIDToolStripMenuItem_Click(object sender, EventArgs e) => this.method_34(5);

  private void button9_Click(object sender, EventArgs e) => this.method_57();

  private void method_57()
  {
    if (this.method_53() == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn tài khoản cần khôi phục!"), 3);
    }
    else
    {
      GClass19.smethod_35((Form) new fCauHinhKhoiPhucTaiKhoan());
      if (fCauHinhKhoiPhucTaiKhoan.bool_0)
      {
        try
        {
          if (fCauHinhKhoiPhucTaiKhoan.int_0 == 0)
          {
            List<string> list_0_1 = new List<string>();
            List<string> list_0_2 = new List<string>();
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                string string_0 = Class14.smethod_3(this.dtgvAcc, index, "cId");
                string str = Class42.smethod_27(string_0);
                list_0_1.Add(string_0);
                list_0_2.Add(str);
                this.dtgvAcc.Rows.RemoveAt(index--);
              }
            }
            this.method_41();
            Class42.smethod_18(list_0_2, "active", "1");
            if (Class42.smethod_17(list_0_1, "active", "1"))
              GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Đã khôi phục thành công {0} tài khoản!"), (object) list_0_1.Count));
            else
              GClass14.smethod_0((object) GClass35.smethod_0("Lỗi khôi phục tài khoản, vui lòng thử lại sau!"), 2);
          }
          else
          {
            string string0 = fCauHinhKhoiPhucTaiKhoan.string_0;
            List<string> list_0 = new List<string>();
            for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                string str = Class14.smethod_3(this.dtgvAcc, index, "cId");
                list_0.Add(str);
                this.dtgvAcc.Rows.RemoveAt(index--);
              }
            }
            this.method_41();
            if (Class42.smethod_17(list_0, "idFile", string0) && Class42.smethod_17(list_0, "active", "1"))
              GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Đã khôi phục thành công {0} tài khoản!"), (object) list_0.Count));
            else
              GClass14.smethod_0((object) GClass35.smethod_0("Lỗi khôi phục tài khoản, vui lòng thử lại sau!"), 2);
          }
        }
        catch (Exception ex)
        {
          GClass19.smethod_79((GClass18) null, ex, "Khoi Phuc Tai Khoan");
        }
      }
      this.method_30();
      this.method_28();
    }
  }

  private void button3_Click(object sender, EventArgs e) => this.method_23();

  private void toolStripMenuItem_14_Click(object sender, EventArgs e) => this.method_57();

  private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    try
    {
      this.dtgvAcc.CurrentRow.Cells["cChose"].Value = (object) !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value);
      this.method_16();
    }
    catch
    {
    }
  }

  private void label3_Click(object sender, EventArgs e)
  {
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
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fBin));
    this.dtgvAcc = new DataGridView();
    this.cChose = new DataGridViewCheckBoxColumn();
    this.cStt = new DataGridViewTextBoxColumn();
    this.cId = new DataGridViewTextBoxColumn();
    this.cUid = new DataGridViewTextBoxColumn();
    this.cToken = new DataGridViewTextBoxColumn();
    this.cCookies = new DataGridViewTextBoxColumn();
    this.cEmail = new DataGridViewTextBoxColumn();
    this.cPhone = new DataGridViewTextBoxColumn();
    this.cName = new DataGridViewTextBoxColumn();
    this.cFollow = new DataGridViewTextBoxColumn();
    this.cFriend = new DataGridViewTextBoxColumn();
    this.cGroup = new DataGridViewTextBoxColumn();
    this.cBirthday = new DataGridViewTextBoxColumn();
    this.cGender = new DataGridViewTextBoxColumn();
    this.cPassword = new DataGridViewTextBoxColumn();
    this.cMailRecovery = new DataGridViewTextBoxColumn();
    this.cPassMail = new DataGridViewTextBoxColumn();
    this.cBackup = new DataGridViewTextBoxColumn();
    this.cFa2 = new DataGridViewTextBoxColumn();
    this.cUseragent = new DataGridViewTextBoxColumn();
    this.cProxy = new DataGridViewTextBoxColumn();
    this.cDateCreateAcc = new DataGridViewTextBoxColumn();
    this.cAvatar = new DataGridViewTextBoxColumn();
    this.cProfile = new DataGridViewTextBoxColumn();
    this.cThuMuc = new DataGridViewTextBoxColumn();
    this.cInteractEnd = new DataGridViewTextBoxColumn();
    this.cDevice = new DataGridViewTextBoxColumn();
    this.cInfo = new DataGridViewTextBoxColumn();
    this.cGhiChu = new DataGridViewTextBoxColumn();
    this.cDateDelete = new DataGridViewTextBoxColumn();
    this.cStatus = new DataGridViewTextBoxColumn();
    this.ctmsAcc = new MetroContextMenu(this.components);
    this.toolStripMenuItem_0 = new ToolStripMenuItem();
    this.toolStripMenuItem_2 = new ToolStripMenuItem();
    this.liveToolStripMenuItem = new ToolStripMenuItem();
    this.tinhTrangToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_8 = new ToolStripMenuItem();
    this.toolStripMenuItem_3 = new ToolStripMenuItem();
    this.toolStripMenuItem_14 = new ToolStripMenuItem();
    this.toolStripMenuItem_1 = new ToolStripMenuItem();
    this.copyToolStripMenuItem = new ToolStripMenuItem();
    this.uidToolStripMenuItem = new ToolStripMenuItem();
    this.passToolStripMenuItem = new ToolStripMenuItem();
    this.tokenToolStripMenuItem = new ToolStripMenuItem();
    this.cookieToolStripMenuItem = new ToolStripMenuItem();
    this.mailToolStripMenuItem = new ToolStripMenuItem();
    this.fAToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_11 = new ToolStripMenuItem();
    this.uidPassToolStripMenuItem = new ToolStripMenuItem();
    this.uidPass2FaToolStripMenuItem = new ToolStripMenuItem();
    this.mailPassMailToolStripMenuItem = new ToolStripMenuItem();
    this.uidPassTokenCookieToolStripMenuItem = new ToolStripMenuItem();
    this.uidPassTokenCookieMailPassMailToolStripMenuItem = new ToolStripMenuItem();
    this.uidPassTokenCookieMailPassMail2faToolStripMenuItem = new ToolStripMenuItem();
    this.useragentToolStripMenuItem1 = new ToolStripMenuItem();
    this.proxyToolStripMenuItem1 = new ToolStripMenuItem();
    this.toolStripMenuItem_10 = new ToolStripMenuItem();
    this.checkCookieToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_9 = new ToolStripMenuItem();
    this.checkInfoUIDToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_5 = new ToolStripMenuItem();
    this.toolStripMenuItem_4 = new ToolStripMenuItem();
    this.checkAvatarToolStripMenuItem = new ToolStripMenuItem();
    this.checkProfileToolStripMenuItem1 = new ToolStripMenuItem();
    this.checkBackupToolStripMenuItem1 = new ToolStripMenuItem();
    this.toolStripMenuItem_7 = new ToolStripMenuItem();
    this.toolStripMenuItem_13 = new ToolStripMenuItem();
    this.checkProxyToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_6 = new ToolStripMenuItem();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.button1 = new Button();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuCards1 = new BunifuCards();
    this.menuStrip1 = new MenuStrip();
    this.toolStripMenuItem_12 = new ToolStripMenuItem();
    this.grQuanLyThuMuc = new GroupBox();
    this.btnLoadAcc = new MetroButton();
    this.cbbTinhTrang = new MetroComboBox();
    this.cbbThuMuc = new MetroComboBox();
    this.label2 = new Label();
    this.label1 = new Label();
    this.grTimKiem = new GroupBox();
    this.BtnSearch = new MetroButton();
    this.cbbSearch = new ComboBox();
    this.txbSearch = new BunifuCustomTextbox();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.statusStrip1 = new StatusStrip();
    this.toolStripStatusLabel5 = new ToolStripStatusLabel();
    this.lblCountSelect = new ToolStripStatusLabel();
    this.toolStripStatusLabel7 = new ToolStripStatusLabel();
    this.lblCountTotal = new ToolStripStatusLabel();
    this.button9 = new Button();
    this.button3 = new Button();
    this.label3 = new Label();
    ((ISupportInitialize) this.dtgvAcc).BeginInit();
    this.ctmsAcc.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.bunifuCards1.SuspendLayout();
    this.menuStrip1.SuspendLayout();
    this.grQuanLyThuMuc.SuspendLayout();
    this.grTimKiem.SuspendLayout();
    this.statusStrip1.SuspendLayout();
    this.SuspendLayout();
    this.dtgvAcc.AllowUserToAddRows = false;
    this.dtgvAcc.AllowUserToDeleteRows = false;
    this.dtgvAcc.AllowUserToResizeRows = false;
    this.dtgvAcc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
    this.dtgvAcc.Columns.AddRange((DataGridViewColumn) this.cChose, (DataGridViewColumn) this.cStt, (DataGridViewColumn) this.cId, (DataGridViewColumn) this.cUid, (DataGridViewColumn) this.cToken, (DataGridViewColumn) this.cCookies, (DataGridViewColumn) this.cEmail, (DataGridViewColumn) this.cPhone, (DataGridViewColumn) this.cName, (DataGridViewColumn) this.cFollow, (DataGridViewColumn) this.cFriend, (DataGridViewColumn) this.cGroup, (DataGridViewColumn) this.cBirthday, (DataGridViewColumn) this.cGender, (DataGridViewColumn) this.cPassword, (DataGridViewColumn) this.cMailRecovery, (DataGridViewColumn) this.cPassMail, (DataGridViewColumn) this.cBackup, (DataGridViewColumn) this.cFa2, (DataGridViewColumn) this.cUseragent, (DataGridViewColumn) this.cProxy, (DataGridViewColumn) this.cDateCreateAcc, (DataGridViewColumn) this.cAvatar, (DataGridViewColumn) this.cProfile, (DataGridViewColumn) this.cThuMuc, (DataGridViewColumn) this.cInteractEnd, (DataGridViewColumn) this.cDevice, (DataGridViewColumn) this.cInfo, (DataGridViewColumn) this.cGhiChu, (DataGridViewColumn) this.cDateDelete, (DataGridViewColumn) this.cStatus);
    this.dtgvAcc.ContextMenuStrip = (ContextMenuStrip) this.ctmsAcc;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.dtgvAcc.DefaultCellStyle = gridViewCellStyle2;
    this.dtgvAcc.Location = new Point(2, 124);
    this.dtgvAcc.Name = "dtgvAcc";
    this.dtgvAcc.ReadOnly = true;
    this.dtgvAcc.RowHeadersVisible = false;
    this.dtgvAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvAcc.Size = new Size(1199, 461);
    this.dtgvAcc.TabIndex = 0;
    this.dtgvAcc.CellClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellClick);
    this.dtgvAcc.CellDoubleClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
    this.dtgvAcc.SortCompare += new DataGridViewSortCompareEventHandler(this.dtgvAcc_SortCompare);
    this.dtgvAcc.KeyDown += new KeyEventHandler(this.dtgvAcc_KeyDown);
    this.cChose.HeaderText = "Chọn";
    this.cChose.Name = "cChose";
    this.cChose.ReadOnly = true;
    this.cChose.Width = 40;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.cStt.DefaultCellStyle = gridViewCellStyle3;
    this.cStt.HeaderText = "STT";
    this.cStt.Name = "cStt";
    this.cStt.ReadOnly = true;
    this.cStt.Width = 35;
    this.cId.HeaderText = "Id";
    this.cId.Name = "cId";
    this.cId.ReadOnly = true;
    this.cId.Visible = false;
    this.cId.Width = 90;
    this.cUid.HeaderText = "UID";
    this.cUid.Name = "cUid";
    this.cUid.ReadOnly = true;
    this.cUid.Width = 80;
    this.cToken.HeaderText = "Token";
    this.cToken.Name = "cToken";
    this.cToken.ReadOnly = true;
    this.cToken.Width = 70;
    this.cCookies.HeaderText = "Cookie";
    this.cCookies.Name = "cCookies";
    this.cCookies.ReadOnly = true;
    this.cCookies.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cCookies.Width = 70;
    this.cEmail.HeaderText = "Email";
    this.cEmail.Name = "cEmail";
    this.cEmail.ReadOnly = true;
    this.cEmail.Width = 60;
    this.cPhone.HeaderText = "Phone";
    this.cPhone.Name = "cPhone";
    this.cPhone.ReadOnly = true;
    this.cPhone.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cPhone.Visible = false;
    this.cPhone.Width = 90;
    this.cName.HeaderText = "Tên";
    this.cName.Name = "cName";
    this.cName.ReadOnly = true;
    this.cName.Width = 70;
    this.cFollow.HeaderText = "Theo dõi";
    this.cFollow.Name = "cFollow";
    this.cFollow.ReadOnly = true;
    this.cFollow.Width = 80;
    this.cFriend.HeaderText = "Bạn bè";
    this.cFriend.Name = "cFriend";
    this.cFriend.ReadOnly = true;
    this.cFriend.Width = 70;
    this.cGroup.HeaderText = "Nhóm";
    this.cGroup.Name = "cGroup";
    this.cGroup.ReadOnly = true;
    this.cGroup.Width = 60;
    this.cBirthday.HeaderText = "Ngày sinh";
    this.cBirthday.Name = "cBirthday";
    this.cBirthday.ReadOnly = true;
    this.cBirthday.Width = 90;
    this.cGender.HeaderText = "Giới Tính";
    this.cGender.Name = "cGender";
    this.cGender.ReadOnly = true;
    this.cGender.Width = 80;
    this.cPassword.HeaderText = "Mật khẩu";
    this.cPassword.Name = "cPassword";
    this.cPassword.ReadOnly = true;
    this.cPassword.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cPassword.Visible = false;
    this.cPassword.Width = 70;
    this.cMailRecovery.HeaderText = "Email khôi phục";
    this.cMailRecovery.Name = "cMailRecovery";
    this.cMailRecovery.ReadOnly = true;
    this.cMailRecovery.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cMailRecovery.Visible = false;
    this.cMailRecovery.Width = 120;
    this.cPassMail.HeaderText = "Mật khẩu mail";
    this.cPassMail.Name = "cPassMail";
    this.cPassMail.ReadOnly = true;
    this.cPassMail.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cPassMail.Visible = false;
    this.cPassMail.Width = 120;
    this.cBackup.HeaderText = "Backup";
    this.cBackup.Name = "cBackup";
    this.cBackup.ReadOnly = true;
    this.cBackup.Width = 70;
    this.cFa2.HeaderText = "Mã 2FA";
    this.cFa2.Name = "cFa2";
    this.cFa2.ReadOnly = true;
    this.cFa2.Width = 65;
    this.cUseragent.HeaderText = "Useragent";
    this.cUseragent.Name = "cUseragent";
    this.cUseragent.ReadOnly = true;
    this.cUseragent.Width = 70;
    this.cProxy.HeaderText = "Proxy";
    this.cProxy.Name = "cProxy";
    this.cProxy.ReadOnly = true;
    this.cProxy.Width = 55;
    this.cDateCreateAcc.HeaderText = "Ngày tạo";
    this.cDateCreateAcc.Name = "cDateCreateAcc";
    this.cDateCreateAcc.ReadOnly = true;
    this.cDateCreateAcc.Width = 85;
    this.cAvatar.HeaderText = "Avatar";
    this.cAvatar.Name = "cAvatar";
    this.cAvatar.ReadOnly = true;
    this.cAvatar.Width = 50;
    this.cProfile.HeaderText = "Profile";
    this.cProfile.Name = "cProfile";
    this.cProfile.ReadOnly = true;
    this.cProfile.Width = 50;
    this.cThuMuc.HeaderText = "Thư mục";
    this.cThuMuc.Name = "cThuMuc";
    this.cThuMuc.ReadOnly = true;
    this.cInteractEnd.HeaderText = "Lần tương tác cuối";
    this.cInteractEnd.Name = "cInteractEnd";
    this.cInteractEnd.ReadOnly = true;
    this.cDevice.HeaderText = "LD Index";
    this.cDevice.Name = "cDevice";
    this.cDevice.ReadOnly = true;
    this.cDevice.Width = 80;
    this.cInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
    this.cInfo.HeaderText = "Tình Trạng";
    this.cInfo.Name = "cInfo";
    this.cInfo.ReadOnly = true;
    this.cInfo.Width = 90;
    this.cGhiChu.HeaderText = "Ghi Chú";
    this.cGhiChu.Name = "cGhiChu";
    this.cGhiChu.ReadOnly = true;
    this.cDateDelete.HeaderText = "Thời gian xóa";
    this.cDateDelete.Name = "cDateDelete";
    this.cDateDelete.ReadOnly = true;
    this.cDateDelete.Width = 111;
    this.cStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cStatus.HeaderText = "Trạng Thái";
    this.cStatus.Name = "cStatus";
    this.cStatus.ReadOnly = true;
    this.ctmsAcc.Items.AddRange(new ToolStripItem[7]
    {
      (ToolStripItem) this.toolStripMenuItem_0,
      (ToolStripItem) this.toolStripMenuItem_3,
      (ToolStripItem) this.toolStripMenuItem_14,
      (ToolStripItem) this.toolStripMenuItem_1,
      (ToolStripItem) this.copyToolStripMenuItem,
      (ToolStripItem) this.checkCookieToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_6
    });
    this.ctmsAcc.Name = "ctmsAcc";
    this.ctmsAcc.Size = new Size(198, 158);
    this.ctmsAcc.Opening += new CancelEventHandler(this.ctmsAcc_Opening);
    this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.toolStripMenuItem_2,
      (ToolStripItem) this.liveToolStripMenuItem,
      (ToolStripItem) this.tinhTrangToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_8
    });
    this.toolStripMenuItem_0.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_0.Image");
    this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
    this.toolStripMenuItem_0.Size = new Size(197, 22);
    this.toolStripMenuItem_0.Text = "Chọn";
    this.toolStripMenuItem_2.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_2.Image");
    this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
    this.toolStripMenuItem_2.Size = new Size(129, 22);
    this.toolStripMenuItem_2.Text = "Tất cả";
    this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
    this.liveToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("liveToolStripMenuItem.Image");
    this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
    this.liveToolStripMenuItem.Size = new Size(129, 22);
    this.liveToolStripMenuItem.Text = "Bôi đen";
    this.liveToolStripMenuItem.Click += new EventHandler(this.liveToolStripMenuItem_Click);
    this.tinhTrangToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("tinhTrangToolStripMenuItem.Image");
    this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
    this.tinhTrangToolStripMenuItem.Size = new Size(129, 22);
    this.tinhTrangToolStripMenuItem.Text = "Tình trạng";
    this.toolStripMenuItem_8.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_8.Image");
    this.toolStripMenuItem_8.Name = "toolStripMenuItem_8";
    this.toolStripMenuItem_8.Size = new Size(129, 22);
    this.toolStripMenuItem_8.Text = "Trạng thái";
    this.toolStripMenuItem_8.Click += new EventHandler(this.toolStripMenuItem_8_Click);
    this.toolStripMenuItem_3.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_3.Image");
    this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
    this.toolStripMenuItem_3.Size = new Size(197, 22);
    this.toolStripMenuItem_3.Text = "Bỏ chọn tất cả";
    this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
    this.toolStripMenuItem_14.Name = "toolStripMenuItem_14";
    this.toolStripMenuItem_14.Size = new Size(197, 22);
    this.toolStripMenuItem_14.Text = "Khôi phục tài khoản";
    this.toolStripMenuItem_14.Click += new EventHandler(this.toolStripMenuItem_14_Click);
    this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
    this.toolStripMenuItem_1.Size = new Size(197, 22);
    this.toolStripMenuItem_1.Text = "Xóa tài khoản vĩnh viễn";
    this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
    this.copyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[16]
    {
      (ToolStripItem) this.uidToolStripMenuItem,
      (ToolStripItem) this.passToolStripMenuItem,
      (ToolStripItem) this.tokenToolStripMenuItem,
      (ToolStripItem) this.cookieToolStripMenuItem,
      (ToolStripItem) this.mailToolStripMenuItem,
      (ToolStripItem) this.fAToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_11,
      (ToolStripItem) this.uidPassToolStripMenuItem,
      (ToolStripItem) this.uidPass2FaToolStripMenuItem,
      (ToolStripItem) this.mailPassMailToolStripMenuItem,
      (ToolStripItem) this.uidPassTokenCookieToolStripMenuItem,
      (ToolStripItem) this.uidPassTokenCookieMailPassMailToolStripMenuItem,
      (ToolStripItem) this.uidPassTokenCookieMailPassMail2faToolStripMenuItem,
      (ToolStripItem) this.useragentToolStripMenuItem1,
      (ToolStripItem) this.proxyToolStripMenuItem1,
      (ToolStripItem) this.toolStripMenuItem_10
    });
    this.copyToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("copyToolStripMenuItem.Image");
    this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
    this.copyToolStripMenuItem.Size = new Size(197, 22);
    this.copyToolStripMenuItem.Text = "Copy";
    this.uidToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("uidToolStripMenuItem.Image");
    this.uidToolStripMenuItem.Name = "uidToolStripMenuItem";
    this.uidToolStripMenuItem.Size = new Size(290, 22);
    this.uidToolStripMenuItem.Text = "Uid";
    this.uidToolStripMenuItem.Click += new EventHandler(this.uidToolStripMenuItem_Click);
    this.passToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("passToolStripMenuItem.Image");
    this.passToolStripMenuItem.Name = "passToolStripMenuItem";
    this.passToolStripMenuItem.Size = new Size(290, 22);
    this.passToolStripMenuItem.Text = "Pass";
    this.passToolStripMenuItem.Click += new EventHandler(this.passToolStripMenuItem_Click);
    this.tokenToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("tokenToolStripMenuItem.Image");
    this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
    this.tokenToolStripMenuItem.Size = new Size(290, 22);
    this.tokenToolStripMenuItem.Text = "Token";
    this.tokenToolStripMenuItem.Click += new EventHandler(this.tokenToolStripMenuItem_Click);
    this.cookieToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("cookieToolStripMenuItem.Image");
    this.cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
    this.cookieToolStripMenuItem.Size = new Size(290, 22);
    this.cookieToolStripMenuItem.Text = "Cookie";
    this.cookieToolStripMenuItem.Click += new EventHandler(this.cookieToolStripMenuItem_Click);
    this.mailToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("mailToolStripMenuItem.Image");
    this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
    this.mailToolStripMenuItem.Size = new Size(290, 22);
    this.mailToolStripMenuItem.Text = "Email";
    this.mailToolStripMenuItem.Click += new EventHandler(this.mailToolStripMenuItem_Click);
    this.fAToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("fAToolStripMenuItem.Image");
    this.fAToolStripMenuItem.Name = "fAToolStripMenuItem";
    this.fAToolStripMenuItem.Size = new Size(290, 22);
    this.fAToolStripMenuItem.Text = "2FA";
    this.fAToolStripMenuItem.Click += new EventHandler(this.fAToolStripMenuItem_Click);
    this.toolStripMenuItem_11.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_11.Image");
    this.toolStripMenuItem_11.Name = "toolStripMenuItem_11";
    this.toolStripMenuItem_11.Size = new Size(290, 22);
    this.toolStripMenuItem_11.Text = "Mã bảo mật 6 số";
    this.toolStripMenuItem_11.Click += new EventHandler(this.toolStripMenuItem_11_Click);
    this.uidPassToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("uidPassToolStripMenuItem.Image");
    this.uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
    this.uidPassToolStripMenuItem.Size = new Size(290, 22);
    this.uidPassToolStripMenuItem.Text = "Uid|Pass";
    this.uidPassToolStripMenuItem.Click += new EventHandler(this.uidPassToolStripMenuItem_Click);
    this.uidPass2FaToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("uidPass2FaToolStripMenuItem.Image");
    this.uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
    this.uidPass2FaToolStripMenuItem.Size = new Size(290, 22);
    this.uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
    this.uidPass2FaToolStripMenuItem.Click += new EventHandler(this.uidPass2FaToolStripMenuItem_Click);
    this.mailPassMailToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("mailPassMailToolStripMenuItem.Image");
    this.mailPassMailToolStripMenuItem.Name = "mailPassMailToolStripMenuItem";
    this.mailPassMailToolStripMenuItem.Size = new Size(290, 22);
    this.mailPassMailToolStripMenuItem.Text = "Mail|Pass mail";
    this.mailPassMailToolStripMenuItem.Click += new EventHandler(this.mailPassMailToolStripMenuItem_Click);
    this.uidPassTokenCookieToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
    this.uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
    this.uidPassTokenCookieToolStripMenuItem.Size = new Size(290, 22);
    this.uidPassTokenCookieToolStripMenuItem.Text = "Uid|Pass|Token|Cookie";
    this.uidPassTokenCookieToolStripMenuItem.Click += new EventHandler(this.uidPassTokenCookieToolStripMenuItem_Click);
    this.uidPassTokenCookieMailPassMailToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
    this.uidPassTokenCookieMailPassMailToolStripMenuItem.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
    this.uidPassTokenCookieMailPassMailToolStripMenuItem.Size = new Size(290, 22);
    this.uidPassTokenCookieMailPassMailToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
    this.uidPassTokenCookieMailPassMailToolStripMenuItem.Click += new EventHandler(this.uidPassTokenCookieMailPassMailToolStripMenuItem_Click);
    this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
    this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
    this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new Size(290, 22);
    this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
    this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Click += new EventHandler(this.uidPassTokenCookieMailPassMail2faToolStripMenuItem_Click);
    this.useragentToolStripMenuItem1.Image = (Image) componentResourceManager.GetObject("useragentToolStripMenuItem1.Image");
    this.useragentToolStripMenuItem1.Name = "useragentToolStripMenuItem1";
    this.useragentToolStripMenuItem1.Size = new Size(290, 22);
    this.useragentToolStripMenuItem1.Text = "Useragent";
    this.useragentToolStripMenuItem1.Click += new EventHandler(this.useragentToolStripMenuItem1_Click);
    this.proxyToolStripMenuItem1.Image = (Image) componentResourceManager.GetObject("proxyToolStripMenuItem1.Image");
    this.proxyToolStripMenuItem1.Name = "proxyToolStripMenuItem1";
    this.proxyToolStripMenuItem1.Size = new Size(290, 22);
    this.proxyToolStripMenuItem1.Text = "Proxy";
    this.proxyToolStripMenuItem1.Click += new EventHandler(this.proxyToolStripMenuItem1_Click);
    this.toolStripMenuItem_10.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_10.Image");
    this.toolStripMenuItem_10.Name = "toolStripMenuItem_10";
    this.toolStripMenuItem_10.Size = new Size(290, 22);
    this.toolStripMenuItem_10.Text = "Định dạng khác...";
    this.toolStripMenuItem_10.Click += new EventHandler(this.toolStripMenuItem_10_Click);
    this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[10]
    {
      (ToolStripItem) this.toolStripMenuItem_9,
      (ToolStripItem) this.checkInfoUIDToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_5,
      (ToolStripItem) this.toolStripMenuItem_4,
      (ToolStripItem) this.checkAvatarToolStripMenuItem,
      (ToolStripItem) this.checkProfileToolStripMenuItem1,
      (ToolStripItem) this.checkBackupToolStripMenuItem1,
      (ToolStripItem) this.toolStripMenuItem_7,
      (ToolStripItem) this.toolStripMenuItem_13,
      (ToolStripItem) this.checkProxyToolStripMenuItem
    });
    this.checkCookieToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("checkCookieToolStripMenuItem.Image");
    this.checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
    this.checkCookieToolStripMenuItem.Size = new Size(197, 22);
    this.checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
    this.toolStripMenuItem_9.Name = "toolStripMenuItem_9";
    this.toolStripMenuItem_9.Size = new Size(164, 22);
    this.toolStripMenuItem_9.Text = "Check Wall";
    this.toolStripMenuItem_9.ToolTipText = "Không cần dùng token";
    this.toolStripMenuItem_9.Click += new EventHandler(this.toolStripMenuItem_9_Click);
    this.checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
    this.checkInfoUIDToolStripMenuItem.Size = new Size(164, 22);
    this.checkInfoUIDToolStripMenuItem.Text = "Check Info UID";
    this.checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCập nhật thông tin: Họ tên, Giớ́i tính, [Email], [Bạn bè], [Nhóm], [Ngày sinh]";
    this.checkInfoUIDToolStripMenuItem.Click += new EventHandler(this.checkInfoUIDToolStripMenuItem_Click);
    this.toolStripMenuItem_5.Name = "toolStripMenuItem_5";
    this.toolStripMenuItem_5.Size = new Size(164, 22);
    this.toolStripMenuItem_5.Text = "Check Token";
    this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripMenuItem_5_Click);
    this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
    this.toolStripMenuItem_4.Size = new Size(164, 22);
    this.toolStripMenuItem_4.Text = "Check Cookie";
    this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
    this.checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
    this.checkAvatarToolStripMenuItem.Size = new Size(164, 22);
    this.checkAvatarToolStripMenuItem.Text = "Check Avatar";
    this.checkAvatarToolStripMenuItem.Click += new EventHandler(this.checkAvatarToolStripMenuItem_Click);
    this.checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
    this.checkProfileToolStripMenuItem1.Size = new Size(164, 22);
    this.checkProfileToolStripMenuItem1.Text = "Check Profile";
    this.checkProfileToolStripMenuItem1.Click += new EventHandler(this.checkProfileToolStripMenuItem1_Click);
    this.checkBackupToolStripMenuItem1.Name = "checkBackupToolStripMenuItem1";
    this.checkBackupToolStripMenuItem1.Size = new Size(164, 22);
    this.checkBackupToolStripMenuItem1.Text = "Check Backup";
    this.checkBackupToolStripMenuItem1.Click += new EventHandler(this.checkBackupToolStripMenuItem1_Click);
    this.toolStripMenuItem_7.Name = "toolStripMenuItem_7";
    this.toolStripMenuItem_7.Size = new Size(164, 22);
    this.toolStripMenuItem_7.Text = "Dạng checkpoint";
    this.toolStripMenuItem_7.ToolTipText = "Chỉ sử dụng khi tài khoản đã bị checkpoint!";
    this.toolStripMenuItem_7.Click += new EventHandler(this.toolStripMenuItem_7_Click);
    this.toolStripMenuItem_13.Name = "toolStripMenuItem_13";
    this.toolStripMenuItem_13.Size = new Size(164, 22);
    this.toolStripMenuItem_13.Text = "Mail|pass Mail";
    this.toolStripMenuItem_13.Click += new EventHandler(this.toolStripMenuItem_13_Click);
    this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
    this.checkProxyToolStripMenuItem.Size = new Size(164, 22);
    this.checkProxyToolStripMenuItem.Text = "Check Proxy";
    this.checkProxyToolStripMenuItem.Click += new EventHandler(this.checkProxyToolStripMenuItem_Click);
    this.toolStripMenuItem_6.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_6.Image");
    this.toolStripMenuItem_6.Name = "toolStripMenuItem_6";
    this.toolStripMenuItem_6.Size = new Size(197, 22);
    this.toolStripMenuItem_6.Text = "Tải lại danh sách";
    this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_0.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.button1);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(1203, 29);
    this.pnlHeader.TabIndex = 0;
    this.button2.Cursor = Cursors.Hand;
    this.button2.Dock = DockStyle.Right;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) componentResourceManager.GetObject("button2.Image");
    this.button2.Location = new Point(1107, 0);
    this.button2.Name = "button2";
    this.button2.Size = new Size(32, 29);
    this.button2.TabIndex = 0;
    this.button2.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button1.Cursor = Cursors.Hand;
    this.button1.Dock = DockStyle.Right;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(1139, 0);
    this.button1.Name = "button1";
    this.button1.Size = new Size(32, 29);
    this.button1.TabIndex = 1;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.Dock = DockStyle.Right;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(1171, 0);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(32, 29);
    this.btnMinimize.TabIndex = 2;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnMinimize_Click);
    this.bunifuCustomLabel1.AutoSize = true;
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(475, 4);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(185, 16);
    this.bunifuCustomLabel1.TabIndex = 3;
    this.bunifuCustomLabel1.Text = "Danh sách tài khoản đã xóa";
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.DarkRed;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.Dock = DockStyle.Top;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(1204, 38);
    this.bunifuCards1.TabIndex = 0;
    this.menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.menuStrip1.AutoSize = false;
    this.menuStrip1.Dock = DockStyle.None;
    this.menuStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.menuStrip1.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.toolStripMenuItem_12
    });
    this.menuStrip1.Location = new Point(0, 37);
    this.menuStrip1.Name = "menuStrip1";
    this.menuStrip1.RenderMode = ToolStripRenderMode.Professional;
    this.menuStrip1.Size = new Size(1201, 25);
    this.menuStrip1.Stretch = false;
    this.menuStrip1.TabIndex = 1;
    this.menuStrip1.Text = "menuStrip1";
    this.toolStripMenuItem_12.Name = "toolStripMenuItem_12";
    this.toolStripMenuItem_12.Size = new Size(115, 21);
    this.toolStripMenuItem_12.Text = "Cấu hình hiển thị";
    this.toolStripMenuItem_12.Click += new EventHandler(this.toolStripMenuItem_12_Click);
    this.grQuanLyThuMuc.Controls.Add((Control) this.btnLoadAcc);
    this.grQuanLyThuMuc.Controls.Add((Control) this.cbbTinhTrang);
    this.grQuanLyThuMuc.Controls.Add((Control) this.cbbThuMuc);
    this.grQuanLyThuMuc.Controls.Add((Control) this.label2);
    this.grQuanLyThuMuc.Controls.Add((Control) this.label1);
    this.grQuanLyThuMuc.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.grQuanLyThuMuc.Location = new Point(292, 65);
    this.grQuanLyThuMuc.Name = "grQuanLyThuMuc";
    this.grQuanLyThuMuc.Size = new Size(445, 53);
    this.grQuanLyThuMuc.TabIndex = 5;
    this.grQuanLyThuMuc.TabStop = false;
    this.grQuanLyThuMuc.Text = "Quản lý thư mục";
    this.btnLoadAcc.BackgroundImageLayout = ImageLayout.Center;
    this.btnLoadAcc.Cursor = Cursors.Hand;
    this.btnLoadAcc.Location = new Point(416, 19);
    this.btnLoadAcc.Name = "btnLoadAcc";
    this.btnLoadAcc.Size = new Size(25, 25);
    this.btnLoadAcc.TabIndex = 6;
    this.toolTip_0.SetToolTip((Control) this.btnLoadAcc, "Load lại danh sách");
    this.btnLoadAcc.UseSelectable = true;
    this.btnLoadAcc.Click += new EventHandler(this.btnLoadAcc_Click);
    this.cbbTinhTrang.Cursor = Cursors.Hand;
    this.cbbTinhTrang.DropDownWidth = 300;
    this.cbbTinhTrang.FontSize = MetroComboBoxSize.Small;
    this.cbbTinhTrang.FormattingEnabled = true;
    this.cbbTinhTrang.ItemHeight = 19;
    this.cbbTinhTrang.Items.AddRange(new object[1]
    {
      (object) "[Tất cả tình trạng]"
    });
    this.cbbTinhTrang.Location = new Point(289, 19);
    this.cbbTinhTrang.Name = "cbbTinhTrang";
    this.cbbTinhTrang.Size = new Size(121, 25);
    this.cbbTinhTrang.TabIndex = 3;
    this.cbbTinhTrang.UseSelectable = true;
    this.cbbTinhTrang.SelectedIndexChanged += new EventHandler(this.cbbTinhTrang_SelectedIndexChanged);
    this.cbbThuMuc.Cursor = Cursors.Hand;
    this.cbbThuMuc.DropDownWidth = 350;
    this.cbbThuMuc.FontSize = MetroComboBoxSize.Small;
    this.cbbThuMuc.FormattingEnabled = true;
    this.cbbThuMuc.ItemHeight = 19;
    this.cbbThuMuc.Items.AddRange(new object[1]
    {
      (object) "[Tất cả thư mục]"
    });
    this.cbbThuMuc.Location = new Point(72, 19);
    this.cbbThuMuc.Name = "cbbThuMuc";
    this.cbbThuMuc.Size = new Size(173, 25);
    this.cbbThuMuc.TabIndex = 1;
    this.cbbThuMuc.UseSelectable = true;
    this.cbbThuMuc.SelectedIndexChanged += new EventHandler(this.cbbThuMuc_SelectedIndexChanged);
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.Location = new Point(249, 22);
    this.label2.Name = "label2";
    this.label2.Size = new Size(42, 16);
    this.label2.TabIndex = 2;
    this.label2.Text = "Lọc:";
    this.label2.TextAlign = ContentAlignment.MiddleRight;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(8, 23);
    this.label1.Name = "label1";
    this.label1.Size = new Size(64, 16);
    this.label1.TabIndex = 0;
    this.label1.Text = "Thư mục:";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.grTimKiem.Controls.Add((Control) this.BtnSearch);
    this.grTimKiem.Controls.Add((Control) this.cbbSearch);
    this.grTimKiem.Controls.Add((Control) this.txbSearch);
    this.grTimKiem.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.grTimKiem.Location = new Point(2, 65);
    this.grTimKiem.Name = "grTimKiem";
    this.grTimKiem.Size = new Size(284, 53);
    this.grTimKiem.TabIndex = 4;
    this.grTimKiem.TabStop = false;
    this.grTimKiem.Text = "Tìm kiếm";
    this.BtnSearch.BackgroundImageLayout = ImageLayout.None;
    this.BtnSearch.Cursor = Cursors.Hand;
    this.BtnSearch.Location = new Point(253, 18);
    this.BtnSearch.Name = "BtnSearch";
    this.BtnSearch.Size = new Size(24, 24);
    this.BtnSearch.TabIndex = 2;
    this.BtnSearch.UseSelectable = true;
    this.BtnSearch.Click += new EventHandler(this.BtnSearch_Click);
    this.cbbSearch.Cursor = Cursors.Hand;
    this.cbbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbSearch.DropDownWidth = 100;
    this.cbbSearch.FormattingEnabled = true;
    this.cbbSearch.Location = new Point(12, 18);
    this.cbbSearch.Name = "cbbSearch";
    this.cbbSearch.Size = new Size(86, 24);
    this.cbbSearch.TabIndex = 0;
    this.txbSearch.BorderColor = Color.SeaGreen;
    this.txbSearch.Location = new Point(104, 19);
    this.txbSearch.Name = "txbSearch";
    this.txbSearch.Size = new Size(143, 23);
    this.txbSearch.TabIndex = 1;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_1.Vertical = true;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 30000;
    this.toolTip_0.InitialDelay = 0;
    this.toolTip_0.ReshowDelay = 40;
    this.statusStrip1.BackColor = SystemColors.Control;
    this.statusStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.statusStrip1.Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.toolStripStatusLabel5,
      (ToolStripItem) this.lblCountSelect,
      (ToolStripItem) this.toolStripStatusLabel7,
      (ToolStripItem) this.lblCountTotal
    });
    this.statusStrip1.Location = new Point(0, 588);
    this.statusStrip1.Name = "statusStrip1";
    this.statusStrip1.Size = new Size(1204, 22);
    this.statusStrip1.TabIndex = 11;
    this.statusStrip1.Text = "statusStrip1";
    this.toolStripStatusLabel5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
    this.toolStripStatusLabel5.Size = new Size(65, 17);
    this.toolStripStatusLabel5.Text = "Đã chọn:";
    this.lblCountSelect.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCountSelect.ForeColor = Color.FromArgb(0, 64, 0);
    this.lblCountSelect.Name = "lblCountSelect";
    this.lblCountSelect.Size = new Size(15, 17);
    this.lblCountSelect.Text = "0";
    this.toolStripStatusLabel7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
    this.toolStripStatusLabel7.Size = new Size(52, 17);
    this.toolStripStatusLabel7.Text = "Tất cả:";
    this.lblCountTotal.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCountTotal.ForeColor = Color.Maroon;
    this.lblCountTotal.Name = "lblCountTotal";
    this.lblCountTotal.Size = new Size(15, 17);
    this.lblCountTotal.Text = "0";
    this.button9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button9.BackColor = Color.White;
    this.button9.Cursor = Cursors.Hand;
    this.button9.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button9.ImageAlign = ContentAlignment.MiddleLeft;
    this.button9.Location = new Point(836, 78);
    this.button9.Name = "button9";
    this.button9.Size = new Size(158, 34);
    this.button9.TabIndex = 12;
    this.button9.Text = "Khôi phục tài khoản";
    this.button9.UseVisualStyleBackColor = true;
    this.button9.Click += new EventHandler(this.button9_Click);
    this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button3.BackColor = Color.White;
    this.button3.Cursor = Cursors.Hand;
    this.button3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.ImageAlign = ContentAlignment.MiddleLeft;
    this.button3.Location = new Point(1000, 78);
    this.button3.Name = "button3";
    this.button3.Size = new Size(201, 34);
    this.button3.TabIndex = 12;
    this.button3.Text = "Xóa tài khoản vĩnh viễn";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label3.BackColor = SystemColors.Control;
    this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label3.ForeColor = Color.Red;
    this.label3.Location = new Point(688, 591);
    this.label3.Name = "label3";
    this.label3.Size = new Size(515, 16);
    this.label3.TabIndex = 13;
    this.label3.Text = "[Bôi đen nhiều dòng rồi nhấn phím Space] hoặc [Click đúp vào tài khoản] để tích chọn!";
    this.label3.TextAlign = ContentAlignment.MiddleRight;
    this.label3.Click += new EventHandler(this.label3_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1204, 610);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.button3);
    this.Controls.Add((Control) this.button9);
    this.Controls.Add((Control) this.statusStrip1);
    this.Controls.Add((Control) this.grTimKiem);
    this.Controls.Add((Control) this.grQuanLyThuMuc);
    this.Controls.Add((Control) this.dtgvAcc);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Controls.Add((Control) this.menuStrip1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MainMenuStrip = this.menuStrip1;
    this.Name = nameof (fBin);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "MAX CARE";
    this.Load += new EventHandler(this.fBin_Load);
    ((ISupportInitialize) this.dtgvAcc).EndInit();
    this.ctmsAcc.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.pnlHeader.PerformLayout();
    this.bunifuCards1.ResumeLayout(false);
    this.menuStrip1.ResumeLayout(false);
    this.menuStrip1.PerformLayout();
    this.grQuanLyThuMuc.ResumeLayout(false);
    this.grTimKiem.ResumeLayout(false);
    this.grTimKiem.PerformLayout();
    this.statusStrip1.ResumeLayout(false);
    this.statusStrip1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
