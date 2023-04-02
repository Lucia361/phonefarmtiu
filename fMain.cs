// Decompiled with JetBrains decompiler
// Type: fMain
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using maxcare.Properties;
using MetroFramework;
using MetroFramework.Controls;
using Newtonsoft.Json.Linq;
using Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

public class fMain : Form
{
  private Random random_0 = new Random();
  private bool bool_0;
  public static fMain fMain_0;
  private List<Thread> list_0 = (List<Thread>) null;
  private Thread thread_0 = (Thread) null;
  private List<string> list_1 = (List<string>) null;
  private List<string> list_2 = new List<string>();
  private List<string> list_3 = new List<string>();
  private List<Class46> list_4 = (List<Class46>) null;
  private List<string> list_5 = (List<string>) null;
  private List<string> list_6 = (List<string>) null;
  private List<Class47> list_7 = (List<Class47>) null;
  private List<string> list_8 = (List<string>) null;
  private List<Class6> list_9 = (List<Class6>) null;
  private List<string> list_10 = (List<string>) null;
  private List<Class7> list_11 = (List<Class7>) null;
  private List<string> list_12 = (List<string>) null;
  private List<Class4> list_13 = (List<Class4>) null;
  private List<string> list_14 = (List<string>) null;
  private List<GClass10> list_15 = (List<GClass10>) null;
  private List<GClass9> list_16 = (List<GClass9>) null;
  private List<string> list_17 = (List<string>) null;
  private Dictionary<string, List<string>> dictionary_0 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_1 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_2 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_3 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_4 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_5 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_6 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_7 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_8 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_9 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_10 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_11 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_12 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_13 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_14 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_15 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_16 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_17 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_18 = (Dictionary<string, List<string>>) null;
  private Dictionary<string, List<string>> dictionary_19 = (Dictionary<string, List<string>>) null;
  private object object_0 = new object();
  private object object_1 = new object();
  private int int_0 = 0;
  private object object_2 = new object();
  private object object_3 = new object();
  private object object_5 = new object();
  private object object_6 = new object();
  private object object_7 = new object();
  private object object_8 = new object();
  private object object_9 = new object();
  private object object_10 = new object();
  private bool bool_1 = false;
  private int int_1 = -1;
  private bool bool_2 = true;
  private object object_11 = new object();
  private object object_12 = new object();
  private object object_13 = new object();
  private object object_14 = new object();
  private object object_15 = new object();
  private int int_2 = -1;
  private bool bool_3 = true;
  private bool bool_4 = false;
  private object object_16 = new object();
  private Bitmap bitmap_0 = Resource.Bitmap_286;
  private Bitmap bitmap_1 = Resource.Bitmap_281;
  private int int_3 = 0;
  private IContainer icontainer_0 = (IContainer) null;
  public DataGridView dtgvAcc;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private PictureBox pictureBox1;
  private Button button2;
  private Button button1;
  private Button btnMinimize;
  private MenuStrip menuStrip1;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private Label label1;
  private MetroComboBox cbbThuMuc;
  private MetroContextMenu ctmsAcc;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem liveToolStripMenuItem;
  private ToolStripMenuItem copyToolStripMenuItem;
  private ToolStripMenuItem tokenToolStripMenuItem;
  private ToolStripMenuItem cookieToolStripMenuItem;
  private ToolStripMenuItem uidPassToolStripMenuItem;
  private ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem toolStripMenuItem_4;
  private ToolStripMenuItem checkCookieToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_5;
  private ToolStripMenuItem toolStripMenuItem_6;
  private ToolStripMenuItem passToolStripMenuItem;
  private Button btnInteract;
  private ToolStripMenuItem toolStripMenuItem_7;
  private ToolStripMenuItem toolStripMenuItem_8;
  private ToolStripMenuItem toolStripMenuItem_9;
  private ToolStripMenuItem toolStripMenuItem_10;
  private ToolStripMenuItem toolStripMenuItem_11;
  private ToolStripMenuItem tokenToolStripMenuItem2;
  private ToolStripMenuItem cookieToolStripMenuItem3;
  private Button btnPause;
  private ToolStripMenuItem toolStripMenuItem_12;
  private ToolStripMenuItem mailPassMailToolStripMenuItem;
  private ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_13;
  private ToolStripMenuItem toolStripMenuItem_14;
  private BunifuCustomTextbox txbSearch;
  private ToolStripMenuItem mailToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_15;
  private ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;
  private StatusStrip statusStrip1;
  private ToolStripStatusLabel toolStripStatusLabel1;
  private ToolStripStatusLabel lblStatus;
  private ToolStripStatusLabel toolStripStatusLabel3;
  private ToolStripStatusLabel lblKey;
  private ToolStripStatusLabel toolStripStatusLabel7;
  private ToolStripStatusLabel lblCountDeviceRunning;
  private ToolStripStatusLabel toolStripStatusLabel8;
  private ToolStripStatusLabel txbUid;
  private ToolStripStatusLabel lblUser;
  private ToolStripStatusLabel toolStripStatusLabel9;
  private ToolStripStatusLabel toolStripStatusLabel10;
  private ToolStripStatusLabel toolStripStatusLabel5;
  private ToolStripStatusLabel lblCountSelect;
  private ToolStripMenuItem fAToolStripMenuItem;
  private ToolStripMenuItem tinhTrangToolStripMenuItem;
  private ToolStripMenuItem locTrungToolStripMenuItem;
  private ToolStripMenuItem uidPass2FaToolStripMenuItem;
  private BunifuDragControl bunifuDragControl_1;
  private ToolTip toolTip_0;
  private ToolStripMenuItem toolStripMenuItem_16;
  private ToolStripMenuItem toolStripMenuItem_17;
  private ToolStripMenuItem toolStripMenuItem_18;
  private ToolStripMenuItem toolStripMenuItem_19;
  private ToolStripMenuItem toolStripMenuItem_20;
  private ToolStripMenuItem toolStripMenuItem_21;
  private ToolStripMenuItem useragentToolStripMenuItem;
  private ToolStripMenuItem proxyToolStripMenuItem;
  private ToolStripMenuItem useragentToolStripMenuItem1;
  private ToolStripMenuItem proxyToolStripMenuItem1;
  private ComboBox cbbSearch;
  private ToolStripMenuItem ghiChuToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_22;
  private MetroButton btnAddFile;
  private MetroButton btnDeleteFile;
  private MetroButton btnLoadAcc;
  private MetroComboBox cbbTinhTrang;
  private Label label2;
  private Button button9;
  private ToolStripMenuItem toolStripMenuItem_23;
  private ToolStripMenuItem loginHotmailToolStripMenuItem;
  private Panel plTrangThai;
  private Label lblTrangThai;
  private ToolStripMenuItem uidToolStripMenuItem;
  private ToolStripMenuItem checkAvatarToolStripMenuItem;
  private ToolStripMenuItem checkProxyToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_24;
  private ToolStripMenuItem checkInfoUIDToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_25;
  private ToolStripMenuItem toolStripMenuItem_26;
  private ToolStripMenuItem toolStripMenuItem_27;
  private ToolStripMenuItem checkHotmailToolStripMenuItem;
  private MetroButton btnEditFile;
  private ToolStripMenuItem checkProxyToolStripMenuItem1;
  private ToolStripMenuItem toolStripMenuItem_29;
  private ToolStripMenuItem lToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_30;
  private ToolStripMenuItem loginYandexToolStripMenuItem;
  private ToolStripMenuItem checkLiveUidToolStripMenuItem;
  private Panel panel1;
  private ToolStripMenuItem toolStripMenuItem_31;
  public ToolStripStatusLabel lblDateExpried;
  public BunifuCustomLabel bunifuCustomLabel1;
  private ToolStripMenuItem toolStripMenuItem5;
  private ToolStripStatusLabel toolStripStatusLabel4;
  private ToolStripStatusLabel lblCountHighline;
  private ToolStripMenuItem checkStatusXproxyToolStripMenuItem;
  private NotifyIcon notifyIcon_0;
  private ToolStripMenuItem profileToolStripMenuItem;
  private ToolStripStatusLabel toolStripStatusLabel2;
  private ToolStripStatusLabel lblCountTotal;
  private ToolStripMenuItem toolStripMenuItem_32;
  private ToolStripMenuItem toolStripMenuItem_33;
  private ToolStripMenuItem toolStripMenuItem3;
  private PictureBox picLanguage;
  private ToolStripMenuItem copyDataDeviceToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_34;
  private ToolStripMenuItem regAccTiktokToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem4;
  private ToolStripMenuItem unlockCheckpointToolStripMenuItem;
  private ToolStripMenuItem dataBackupGroupToolStripMenuItem;
  private ToolStripMenuItem checkFileBackupGroupToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_35;
  private ToolStripMenuItem backupGroupToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_36;
  private Panel panel2;
  private Panel plQuanLyThuMuc;
  private MetroButton BtnSearch;
  private ToolStripMenuItem toolStripMenuItem_37;
  private ToolStripMenuItem toolStripMenuItem_38;
  private ToolStripMenuItem toolStripMenuItem_39;
  private ToolStripMenuItem testSpinTextToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_40;
  private ToolStripMenuItem loginPhoneToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem6;
  private ToolStripMenuItem toolStripMenuItem7;
  private ToolStripMenuItem toolStripMenuItem8;
  private ToolStripMenuItem donDepProfileToolStripMenuItem;
  private IContainer components;
  private Button button3;
  private Button button4;
  private Button button5;
  private ToolStripMenuItem phoneToolStripMenuItem;
  private Button button7;
  private Button button6;
  private ToolStripMenuItem devicesToolStripMenuItem;
  private ToolStripMenuItem phoneToolStripMenuItem1;
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
  private DataGridViewTextBoxColumn cDeviceId;
  private DataGridViewTextBoxColumn cIp;
  private DataGridViewTextBoxColumn cStatus;
  private ToolStripMenuItem toolStripMenuItem9;

  private object Object_0 { get; set; } = new object();

  public fMain(string string_0)
  {
    this.InitializeComponent();
    this.picLanguage.Image = Class54.smethod_2() != "VN" ? (Image) this.bitmap_0 : (Image) this.bitmap_1;
    if (string_0 != "")
    {
      string[] strArray = string_0.Split('|');
      this.lblDateExpried.Text = Convert.ToDateTime(strArray[2]).ToString("dd/MM/yyyy");
      this.lblKey.Text = (strArray[3].Length < 13 ? "MIN" : strArray[3].Substring(0, 12)) + "****";
      this.lblUser.Text = strArray[0];
      Class54.int_1 = Convert.ToInt32(strArray[5]);
    }
    fMain.fMain_0 = this;
    this.method_0();
    this.txbSearch.smethod_5();
  }

  private void method_0()
  {
  }

  protected override void OnLoad(EventArgs e) => Application.Idle += new EventHandler(this.method_1);

  private void method_1(object sender, EventArgs e)
  {
    Application.Idle -= new EventHandler(this.method_1);
    if (!File.Exists("AutoUpdate.exe") || new FileInfo("AutoUpdate.exe").Length != 534016L)
      GClass19.smethod_4("https://download.minsoftware.vn/download/AutoUpdate.zip");
    if (!File.Exists("app\\maxchange.apk") || new FileInfo("app\\maxchange.apk").Length != 4469239L)
      GClass19.smethod_4("https://download.minsoftware.vn/download/maxchange.zip");
    if (!File.Exists("dll\\x64\\OpenCvSharpExtern.dll") || !File.Exists("dll\\x86\\OpenCvSharpExtern.dll"))
      GClass19.smethod_4("https://download.minsoftware.vn/OpenCvSharp/dll.zip");
    if (!File.Exists("app\\collegeproxy.apk") || new FileInfo("app\\collegeproxy.apk").Length != 6811185L)
      GClass19.smethod_4("https://download.minsoftware.vn/download/collegeproxy.zip");
    this.lblStatus.Text = GClass35.smethod_0("Đã kích hoạt");
    Class54.string_5 = GClass20.smethod_24();
    Class54.string_7 = GClass33.smethod_0("configGeneral").method_1("txtBrandDevice", "Random");
    Class44.smethod_9();
    this.method_3();
    this.method_195();
    this.method_4();
    if (this.cbbThuMuc.Items.Count > 2)
      this.cbbThuMuc.SelectedIndex = 1;
    this.method_5();
    this.menuStrip1.Cursor = Cursors.Hand;
  }

  public void method_2(int int_4)
  {
    try
    {
      this.statusStrip1.Invoke((Delegate) (() => this.lblCountDeviceRunning.Text = int_4.ToString()));
    }
    catch
    {
    }
  }

  private void method_3()
  {
    this.cbbSearch.DataSource = (object) new BindingSource((object) new Dictionary<string, string>()
    {
      {
        "cUid",
        "UID"
      },
      {
        "cPassword",
        GClass35.smethod_0("Mật khẩu")
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
        "cFa2",
        "2FA"
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

  private void method_4()
  {
    this.bool_2 = false;
    this.cbbThuMuc.DataSource = (object) Class42.smethod_1(true);
    this.cbbThuMuc.ValueMember = "id";
    this.cbbThuMuc.DisplayMember = "name";
    this.bool_2 = true;
  }

  private void method_5(List<string> list_18 = null)
  {
    try
    {
      this.cbbTinhTrang.DataSource = (object) Class42.smethod_9(list_18);
      this.cbbTinhTrang.ValueMember = "id";
      this.cbbTinhTrang.DisplayMember = "name";
    }
    catch
    {
    }
  }

  private void btnMinimize_Click(object sender, EventArgs e)
  {
    try
    {
      Class121.smethod_3();
      Environment.Exit(0);
      Application.Exit();
    }
    catch
    {
      this.Close();
    }
  }

  private void button1_Click(object sender, EventArgs e) => this.smethod_4();

  private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

  private void btnLoadAcc_Click(object sender, EventArgs e)
  {
    string str = "";
    if (this.cbbThuMuc.SelectedValue != null)
      str = this.cbbThuMuc.SelectedValue.ToString();
    this.method_4();
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
      this.method_5(fChonThuMuc.list_0);
    }
  }

  private List<string> method_6()
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
          stringList2 = GClass37.smethod_2(fChonThuMuc.list_0);
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

  private void method_7(List<string> list_18 = null, string string_0 = "")
  {
    try
    {
      this.dtgvAcc.Rows.Clear();
      if (string_0 == "[Tất cả tình trạng]" || string_0 == GClass35.smethod_0("[Tất cả tình trạng]"))
        string_0 = "";
      this.method_8(Class42.smethod_19(list_18, string_0));
    }
    catch (Exception ex)
    {
    }
  }

  private void method_8(DataTable dataTable_0)
  {
    Class14.smethod_6(this.dtgvAcc, dataTable_0);
    this.method_138(0);
    this.method_193();
    this.method_137();
  }

  private void button9_Click(object sender, EventArgs e)
  {
    try
    {
      string string_0 = "";
      if (this.cbbThuMuc.SelectedValue != null)
        string_0 = this.cbbThuMuc.SelectedValue.ToString();
      GClass19.smethod_35((Form) new fImportAccount(string_0));
      if (!fImportAccount.bool_0 && !fImportAccount.bool_1)
        return;
      this.method_4();
      this.int_1 = -1;
      if (fImportAccount.bool_0)
        this.cbbThuMuc.SelectedValue = (object) fImportAccount.int_0;
      else
        this.cbbThuMuc.SelectedValue = (object) string_0;
    }
    catch
    {
    }
  }

  private int method_9(string string_0)
  {
    int num = -1;
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (this.dtgvAcc.Rows[index].Cells["cId"].Value.ToString().Equals(string_0))
      {
        num = index;
        break;
      }
    }
    return num;
  }

  private void method_10(string string_0)
  {
    switch (string_0)
    {
      case "ToggleCheck":
        for (int index1 = 0; index1 < this.dtgvAcc.SelectedRows.Count; ++index1)
        {
          int index2 = this.dtgvAcc.SelectedRows[index1].Index;
          this.method_186(index2, "cChose", (object) !Convert.ToBoolean(this.method_191(index2, "cChose")));
        }
        this.method_138();
        break;
      case "SelectHighline":
        DataGridViewSelectedRowCollection selectedRows = this.dtgvAcc.SelectedRows;
        for (int index = 0; index < selectedRows.Count; ++index)
          this.method_186(selectedRows[index].Index, "cChose", (object) true);
        this.method_138();
        break;
      case "UnAll":
        for (int int_4 = 0; int_4 < this.dtgvAcc.RowCount; ++int_4)
          this.method_186(int_4, "cChose", (object) false);
        this.method_138(0);
        break;
      case "All":
        for (int int_4 = 0; int_4 < this.dtgvAcc.RowCount; ++int_4)
          this.method_186(int_4, "cChose", (object) true);
        this.method_138(this.dtgvAcc.RowCount);
        break;
    }
  }

  private void method_11(string string_0)
  {
    try
    {
      string str1 = "";
      List<string> stringList = new List<string>();
      for (int int_4 = 0; int_4 < this.dtgvAcc.Rows.Count; ++int_4)
      {
        if (Convert.ToBoolean(this.method_191(int_4, "cChose")))
        {
          stringList.Add(this.method_191(int_4, "cId"));
          break;
        }
      }
      if (stringList.Count == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn danh sách tài khoản muốn copy thông tin!"), 3);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        switch (Class206.smethod_0(string_0))
        {
          case 159575910:
            if (string_0 == "uid|pass")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cUid") + "|" + this.method_191(index, "cPassword") + "\r\n";
              }
              break;
            }
            break;
          case 457434463:
            if (string_0 == "uid|pass|token|cookie")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cUid") + "|" + this.method_191(index, "cPassword") + "|" + this.method_191(index, "cToken") + "|" + this.method_191(index, "cCookies") + "\r\n";
              }
              break;
            }
            break;
          case 738560386:
            if (string_0 == "ma2fa")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + GClass19.smethod_85(this.method_191(index, "cFa2")) + "\r\n";
              }
              break;
            }
            break;
          case 1329202400:
            if (string_0 == "mail|passmail")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cEmail") + "|" + this.method_191(index, "cPassMail") + "\r\n";
              }
              break;
            }
            break;
          case 1556604621:
            if (string_0 == "uid")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cUid") + "\r\n";
              }
              break;
            }
            break;
          case 1718322808:
            if (string_0 == "2fa")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cFa2") + "\r\n";
              }
              break;
            }
            break;
          case 2000032175:
            if (string_0 == "phone")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cPhone") + "\r\n";
              }
              break;
            }
            break;
          case 2007449791:
            if (string_0 == "cookie")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                {
                  string str2 = this.method_191(index, "cCookies");
                  str1 = str1 + str2 + "\r\n";
                }
              }
              break;
            }
            break;
          case 2071622424:
            if (string_0 == "pass")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cPassword") + "\r\n";
              }
              break;
            }
            break;
          case 2107770459:
            if (string_0 == "proxy")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                {
                  string str3 = this.method_191(index, "cProxy");
                  if (str3.EndsWith("*0") || str3.EndsWith("*1"))
                    str3 = str3.Substring(0, str3.Length - 2);
                  str1 = str1 + str3 + "\r\n";
                }
              }
              break;
            }
            break;
          case 2337339239:
            if (string_0 == "useragent")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cUseragent") + "\r\n";
              }
              break;
            }
            break;
          case 2369371622:
            if (string_0 == "name")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cName") + "\r\n";
              }
              break;
            }
            break;
          case 2491017778:
            if (string_0 == "token")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cToken") + "\r\n";
              }
              break;
            }
            break;
          case 2703251604:
            if (string_0 == "uid|pass|token|cookie|mail|passmail")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cUid") + "|" + this.method_191(index, "cPassword") + "|" + this.method_191(index, "cToken") + "|" + this.method_191(index, "cCookies") + "|" + this.method_191(index, "cEmail") + "|" + this.method_191(index, "cPassMail") + "\r\n";
              }
              break;
            }
            break;
          case 3144981877:
            if (string_0 == "uid|pass|2fa")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cUid") + "|" + this.method_191(index, "cPassword") + "|" + this.method_191(index, "cFa2") + "\r\n";
              }
              break;
            }
            break;
          case 3497031411:
            if (string_0 == "device")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cDevice") + "\r\n";
              }
              break;
            }
            break;
          case 3728375369:
            if (string_0 == "uid|pass|token|cookie|mail|passmail|fa2")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cUid") + "|" + this.method_191(index, "cPassword") + "|" + this.method_191(index, "cToken") + "|" + this.method_191(index, "cCookies") + "|" + this.method_191(index, "cEmail") + "|" + this.method_191(index, "cPassMail") + "|" + this.method_191(index, "cFa2") + "\r\n";
              }
              break;
            }
            break;
          case 3968918830:
            if (string_0 == "mail")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cEmail") + "\r\n";
              }
              break;
            }
            break;
          case 4025178668:
            if (string_0 == "birthday")
            {
              for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
                  str1 = str1 + this.method_191(index, "cBirthday") + "\r\n";
              }
              break;
            }
            break;
        }
        Clipboard.SetText(str1.TrimEnd('\r', '\n'));
      }
    }
    catch
    {
    }
  }

  private string method_12(string string_0)
  {
    string str1 = "";
    string str2 = Regex.Match(string_0 + ";", "sb=(.*?);").Groups[1].Value;
    if (str2 != "")
      str1 = str1 + "sb=" + str2 + ";";
    string str3 = Regex.Match(string_0 + ";", "wd=(.*?);").Groups[1].Value;
    if (str3 != "")
      str1 = str1 + "wd=" + str3 + ";";
    string str4 = Regex.Match(string_0 + ";", "datr=(.*?);").Groups[1].Value;
    if (str4 != "")
      str1 = str1 + "datr=" + str4 + ";";
    string str5 = Regex.Match(string_0 + ";", "locale=(.*?);").Groups[1].Value;
    if (str5 != "")
      str1 = str1 + "locale=" + str5 + ";";
    string str6 = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
    if (str6 != "")
      str1 = str1 + "c_user=" + str6 + ";";
    string str7 = Regex.Match(string_0 + ";", "xs=(.*?);").Groups[1].Value;
    if (str7 != "")
      str1 = str1 + "xs=" + str7 + ";";
    string str8 = Regex.Match(string_0 + ";", "fr=(.*?);").Groups[1].Value;
    if (str8 != "")
      str1 = str1 + "fr=" + str8 + ";";
    string str9 = Regex.Match(string_0 + ";", "spin=(.*?);").Groups[1].Value;
    if (str9 != "")
      str1 = str1 + "spin=" + str9 + ";";
    return str1;
  }

  private void toolStripMenuItem_5_Click(object sender, EventArgs e) => this.method_10("All");

  private void liveToolStripMenuItem_Click(object sender, EventArgs e) => this.method_10("SelectHighline");

  private void toolStripMenuItem_6_Click(object sender, EventArgs e) => this.method_10("UnAll");

  private void tokenToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("token");

  private void cookieToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("cookie");

  private void uidToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("uid");

  private void passToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("pass");

  private void uidPassToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("uid|pass");

  private void uidPassTokenCookieToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("uid|pass|token|cookie");

  private void btnAddFile_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fAddFile());
    if (!fAddFile.bool_0)
      return;
    this.method_4();
    this.cbbThuMuc.SelectedIndex = this.cbbThuMuc.Items.Count - 2;
  }

  private void method_13()
  {
    for (int index = 0; index < this.dtgvAcc.SelectedRows.Count; ++index)
      this.dtgvAcc.Rows.RemoveAt(this.dtgvAcc.SelectedRows[index].Index);
  }

  private void fMain_Load(object sender, EventArgs e)
  {
  }

  private void ctmsAcc_Opening(object sender, CancelEventArgs e)
  {
    this.toolStripMenuItem_4.DropDownItems.Clear();
    DataTable dataTable = Class42.smethod_1();
    int num = 0;
    for (int index = 0; index < dataTable.Rows.Count; ++index)
    {
      DataRow row = dataTable.Rows[index];
      if (row["id"].ToString() != (this.cbbThuMuc.SelectedValue == null ? "" : this.cbbThuMuc.SelectedValue.ToString()))
      {
        this.toolStripMenuItem_4.DropDownItems.Add(row["name"].ToString());
        this.toolStripMenuItem_4.DropDownItems[index - num].Tag = row["id"];
        this.toolStripMenuItem_4.DropDownItems[index - num].Click += new EventHandler(this.method_17);
      }
      else
        ++num;
    }
    this.toolStripMenuItem_13.DropDownItems.Clear();
    List<string> stringList1 = new List<string>();
    for (int int_4 = 0; int_4 < this.dtgvAcc.RowCount; ++int_4)
    {
      string input = this.method_191(int_4, "cStatus");
      if (input != "")
      {
        string oldValue1 = Regex.Match(input, "\\(Proxy: (.*?)\\)", RegexOptions.Singleline).Value;
        if (oldValue1 != "")
          input = input.Replace(oldValue1, "").Trim();
        string oldValue2 = Regex.Match(input, "\\(IP: (.*?)\\)", RegexOptions.Singleline).Value;
        if (oldValue2 != "")
          input = input.Replace(oldValue2, "").Trim();
        string oldValue3 = Regex.Match(input, "\\[(.*?)\\]").Value;
        if (oldValue3 != "")
          input = input.Replace(oldValue3, "").Trim();
        if (input != "" && !stringList1.Contains(input))
          stringList1.Add(input);
      }
    }
    for (int index = 0; index < stringList1.Count; ++index)
    {
      this.toolStripMenuItem_13.DropDownItems.Add(stringList1[index]);
      this.toolStripMenuItem_13.DropDownItems[index].Click += new EventHandler(this.method_15);
    }
    this.tinhTrangToolStripMenuItem.DropDownItems.Clear();
    List<string> stringList2 = new List<string>();
    for (int int_4 = 0; int_4 < this.dtgvAcc.RowCount; ++int_4)
    {
      string str = this.method_191(int_4, "cInfo");
      if (!str.Equals("") && !stringList2.Contains(str))
        stringList2.Add(str);
    }
    for (int index = 0; index < stringList2.Count; ++index)
    {
      this.tinhTrangToolStripMenuItem.DropDownItems.Add(stringList2[index]);
      this.tinhTrangToolStripMenuItem.DropDownItems[index].Click += new EventHandler(this.method_14);
    }
  }

  private void method_14(object sender, EventArgs e) => this.method_16("cInfo", (sender as ToolStripMenuItem).Text);

  private void method_15(object sender, EventArgs e) => this.method_16("cStatus", (sender as ToolStripMenuItem).Text);

  private void method_16(string string_0, string string_1)
  {
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      this.dtgvAcc.Rows[index].Cells["cChose"].Value = (object) this.method_191(index, string_0).Contains(string_1);
    this.method_138();
  }

  private void method_17(object sender, EventArgs e)
  {
    if (Convert.ToInt32(this.lblCountSelect.Text) == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn tài khoản muốn chuyển!"), 3);
    }
    else
    {
      ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
      if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có thực sự muốn chuyển {0} tài khoản sang thư mục [{1}]?"), (object) this.lblCountSelect.Text, (object) toolStripMenuItem.Text)) != DialogResult.Yes)
        return;
      this.method_18(toolStripMenuItem.Tag.ToString());
    }
  }

  private void method_18(string string_0)
  {
    try
    {
      List<string> list_0 = new List<string>();
      for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          list_0.Add(this.dtgvAcc.Rows[index].Cells["cId"].Value.ToString());
      }
      if (Class42.smethod_17(list_0, "idfile", string_0))
      {
        for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
        {
          if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
            this.dtgvAcc.Rows.RemoveAt(index--);
        }
        this.method_193();
        this.method_147();
        this.method_138(0);
        this.method_137();
        GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Chuyển thành công {0} tài khoản!"), (object) list_0.Count));
      }
      else
        GClass14.smethod_0((object) GClass35.smethod_0("Chuyển thất bại, vui lòng thử lại sau!"), 2);
    }
    catch
    {
    }
  }

  private void method_19(bool bool_5)
  {
    List<string> list_0 = new List<string>();
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        list_0.Add(this.dtgvAcc.Rows[index].Cells["cId"].Value.ToString());
    }
    if (list_0.Count == 0)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn tài khoản cần xóa!"));
    }
    else
    {
      if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có muốn xóa {0} tài khoản đã chọn?"), (object) this.method_176()) + "\r\n" + GClass35.smethod_0("(Tài khoản sau khi xóa sẽ được lưu tại mục [Tài khoản đã xóa])")) != DialogResult.Yes)
        return;
      if (bool_5)
      {
        int int_ = 0;
        int index = 0;
        while (index < this.dtgvAcc.Rows.Count)
        {
          if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          {
            if (int_ < 10)
            {
              Interlocked.Increment(ref int_);
              int int_0 = index++;
              new Thread((ThreadStart) (() =>
              {
                this.method_184(int_0, GClass35.smethod_0("Đang xóa profile..."));
                this.method_151(int_0);
                Interlocked.Decrement(ref int_);
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
        while (int_ > 0)
          GClass19.smethod_64(1.0);
      }
      if (Class42.smethod_25(list_0))
      {
        Class42.smethod_15(list_0, "device", "");
        bool flag = GClass33.smethod_0("configGeneral").method_4("isRunSwap");
        string str1 = GClass12.smethod_2();
        for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
        {
          if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          {
            if (!flag)
            {
              string str2 = this.method_191(index, "cDevice");
              if (str2 != "" && Directory.Exists(str1 + "\\vms\\leidian" + str2))
              {
                try
                {
                  Directory.Delete(str1 + "\\vms\\leidian" + str2, true);
                }
                catch
                {
                }
              }
            }
            this.dtgvAcc.Rows.RemoveAt(index--);
          }
        }
        this.method_147();
        this.method_137();
        this.method_138(0);
      }
      else
        GClass14.smethod_0((object) GClass35.smethod_0("Xóa thất bại, vui lòng thử lại sau!"), 2);
    }
  }

  public List<string> method_20()
  {
    List<string> stringList = new List<string>();
    try
    {
      if (GClass33.smethod_0("configGeneral").method_3("typeApiTinsoft") == 0)
      {
        foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(new GClass24("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0).method_0("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + GClass33.smethod_0("configGeneral").method_1("txtApiUser")))["data"])
        {
          if (Convert.ToBoolean(jtoken[(object) "success"].ToString()))
            stringList.Add(jtoken[(object) "key"].ToString());
        }
      }
      else
      {
        foreach (string string_5 in GClass33.smethod_0("configGeneral").method_2("txtApiProxy"))
        {
          if (Class46.smethod_1(string_5))
            stringList.Add(string_5);
        }
      }
    }
    catch
    {
    }
    return stringList;
  }

  private bool method_21(string string_0) => GClass19.smethod_51(string_0) && string_0.StartsWith("1");

  private Dictionary<string, List<string>> method_22(
    string string_0,
    string string_1,
    string string_2 = "txtUid")
  {
    Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
    try
    {
      List<string> stringList1 = Class205.smethod_25(string_0, string_1);
      if (stringList1.Count > 0)
      {
        for (int index = 0; index < stringList1.Count; ++index)
        {
          string str = stringList1[index];
          GClass22 gclass22 = new GClass22(Class205.smethod_26(str), true);
          List<string> stringList2 = new List<string>();
          List<string> stringList3 = string_2 == "txtUid" || string_2 == "txtIdNhomChiDinh" ? gclass22.method_2(string_2) : gclass22.method_2(string_2, gclass22.method_3("typeNganCach"));
          dictionary.Add(str, stringList3);
        }
      }
    }
    catch
    {
    }
    return dictionary;
  }

  private void method_23(Dictionary<string, List<string>> dictionary_20, string string_0 = "txtUid")
  {
    if (dictionary_20.Count <= 0)
      return;
    foreach (KeyValuePair<string, List<string>> keyValuePair in dictionary_20)
    {
      string key = keyValuePair.Key;
      List<string> list_0 = keyValuePair.Value;
      GClass22 gclass22 = new GClass22(Class205.smethod_26(key), true);
      if (string_0 == "txtUid" || string_0 == "txtIdNhomChiDinh")
        gclass22.method_8(string_0, list_0);
      else
        gclass22.method_7(string_0, list_0, gclass22.method_3("typeNganCach"));
      Class205.smethod_21(key, string_2: gclass22.method_11());
    }
  }

  private bool method_24(string string_0, string string_1)
  {
    try
    {
      string str1 = string_0.Split(':')[1];
      string str2 = string_1.Split(':')[1];
      if (str1.Substring(1) == str2.Substring(1))
        return true;
    }
    catch
    {
    }
    return false;
  }

  private void method_25(bool bool_5)
  {
    if (GClass19.smethod_11("fViewLD"))
      return;
    new fView() { bool_0 = false }.Show();
  }

  private void method_26() => GClass19.smethod_12("fViewLD");

  private void btnInteract_Click(object sender, EventArgs e) => this.method_27(bool_5: (e != null && (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control));

  private void method_27(int int_4 = 0, bool bool_5 = false, GClass22 gclass22_0 = null)
  {
    try
    {
      if (this.method_176() == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn tài khoản muốn chạy!"), 3);
      }
      else
      {
        GClass22 gclass22_1_1 = new GClass22();
        GClass19.smethod_35((Form) new fDeviceList(ref gclass22_1_1));
        List<string> stringList1 = gclass22_1_1.method_2("lstDeviceId");
        if (stringList1.Count == 0)
          return;
        int int_5 = stringList1.Count;
        int_5 = this.method_176() < int_5 ? this.method_176() : int_5;
        Class54.gclass26_0 = new GClass26(stringList1.GetRange(0, int_5));
        switch (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp"))
        {
          case 7:
            this.list_5 = this.method_20();
            if (this.list_5.Count == 0)
            {
              GClass14.smethod_0((object) GClass35.smethod_0("Proxy Tinsoft không đủ, vui lòng mua thêm!"), 2);
              return;
            }
            this.list_4 = new List<Class46>();
            for (int index = 0; index < this.list_5.Count; ++index)
              this.list_4.Add(new Class46(this.list_5[index], GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPTinsoft"), GClass33.smethod_0("configGeneral").method_3("cbbLocationTinsoft")));
            if (this.list_5.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPTinsoft") < int_5)
            {
              int_5 = this.list_5.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPTinsoft");
              break;
            }
            break;
          case 8:
            this.list_6 = GClass33.smethod_0("configGeneral").method_2("txtListProxy");
            if (this.list_6.Count < Class54.gclass26_0.method_0())
            {
              GClass14.smethod_0((object) GClass35.smethod_0("Số lượng XProxy < Số lượng phone, vui lòng cấu hình lại!"), 2);
              return;
            }
            for (int index = 0; index < Class54.gclass26_0.method_0(); ++index)
              Class54.gclass26_0.list_0[index].method_6(GClass33.smethod_0("configGeneral").method_1("txtServiceURLXProxy"), this.list_6[index]);
            break;
          case 10:
            this.list_8 = GClass33.smethod_0("configGeneral").method_2("txtApiKeyTMProxy");
            if (this.list_8.Count == 0)
            {
              GClass14.smethod_0((object) GClass35.smethod_0("Proxy không đủ, vui lòng mua thêm!"), 2);
              return;
            }
            this.list_7 = new List<Class47>();
            for (int index = 0; index < this.list_8.Count; ++index)
              this.list_7.Add(new Class47(this.list_8[index], 0, GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPTMProxy")));
            if (this.list_8.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPTMProxy") < int_5)
            {
              int_5 = this.list_8.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPTMProxy");
              break;
            }
            break;
          case 11:
            this.list_10 = GClass33.smethod_0("configGeneral").method_2("txtListProxyv6");
            if (this.list_10.Count == 0)
            {
              GClass14.smethod_0((object) GClass35.smethod_0("Proxy không đủ, vui lòng cấu hình lại!"), 2);
              return;
            }
            this.list_9 = new List<Class6>();
            for (int index = 0; index < this.list_10.Count; ++index)
              this.list_9.Add(new Class6(GClass33.smethod_0("configGeneral").method_1("txtApiProxyv6"), this.list_10[index], 0, GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPProxyv6")));
            if (this.list_10.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPProxyv6") < int_5)
            {
              int_5 = this.list_10.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPProxyv6");
              break;
            }
            break;
          case 12:
            this.list_12 = GClass33.smethod_0("configGeneral").method_2("txtApiShopLike");
            if (this.list_12.Count == 0)
            {
              GClass14.smethod_0((object) GClass35.smethod_0("Proxy không đủ, vui lòng mua thêm!"), 2);
              return;
            }
            this.list_11 = new List<Class7>();
            for (int index = 0; index < this.list_12.Count; ++index)
              this.list_11.Add(new Class7(this.list_12[index], 0, GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPShopLike")));
            if (this.list_12.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPShopLike") < int_5)
            {
              int_5 = this.list_12.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPShopLike");
              break;
            }
            break;
          case 13:
            this.list_14 = GClass33.smethod_0("configGeneral").method_2("txtApiKeyMinProxy");
            if (this.list_14.Count == 0)
            {
              GClass14.smethod_0((object) GClass35.smethod_0("MinProxy không đủ, vui lòng mua thêm!"), 2);
              return;
            }
            this.list_13 = new List<Class4>();
            for (int index = 0; index < this.list_14.Count; ++index)
              this.list_13.Add(new Class4(GClass33.smethod_0("configGeneral").method_3("typeMin"), this.list_14[index], GClass33.smethod_0("configGeneral").method_3("typeProxyMin"), GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPMinProxy")));
            if (this.list_14.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPMinProxy") < int_5)
            {
              int_5 = this.list_14.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPMinProxy");
              break;
            }
            break;
          case 14:
            this.list_17 = GClass33.smethod_0("configGeneral").method_2("txtListObcProxy");
            if (this.list_17.Count == 0)
            {
              GClass14.smethod_0((object) GClass35.smethod_0("Proxy không đủ, vui lòng cấu hình lại!"), 2);
              return;
            }
            this.list_15 = new List<GClass10>();
            this.list_16 = new List<GClass9>();
            Dictionary<string, List<string>> source = GClass9.smethod_0(GClass33.smethod_0("configGeneral").method_1("txtLinkWebObcProxy"));
            for (int index = 0; index < this.list_17.Count; ++index)
            {
              string string_0 = this.list_17[index].Split(':')[1];
              string key = source.FirstOrDefault<KeyValuePair<string, List<string>>>((System.Func<KeyValuePair<string, List<string>>, bool>) (keyValuePair_0 => keyValuePair_0.Value.Contains(string_0))).Key;
              if (!string.IsNullOrEmpty(key))
              {
                GClass9 gclass9 = GClass9.smethod_1(this.list_16, key);
                if (gclass9 == null)
                {
                  gclass9 = new GClass9(key);
                  this.list_16.Add(gclass9);
                }
                GClass10 gclass10_0 = new GClass10(GClass33.smethod_0("configGeneral").method_1("txtLinkWebObcProxy"), this.list_17[index], 0, GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPObcProxy"), key);
                this.list_15.Add(gclass10_0);
                gclass9.method_1(gclass10_0);
              }
            }
            if (this.list_15.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPObcProxy") < int_5)
            {
              int_5 = this.list_15.Count * GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPObcProxy");
              break;
            }
            break;
        }
        this.list_0 = new List<Thread>();
        this.list_1 = new List<string>();
        if (int_4 == 1)
          new Thread((ThreadStart) (() =>
          {
            try
            {
              int index1 = 0;
              while (index1 < this.dtgvAcc.Rows.Count && !this.bool_0 && int_5 != 0)
              {
                GClass33.smethod_0("configGeneral").method_3("nudDelayThread", 10);
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index1].Cells["cChose"].Value))
                {
                  --int_5;
                  if (!this.bool_0)
                  {
                    GClass27 gclass27_4 = (GClass27) null;
                    lock (Class54.gclass26_0)
                      gclass27_4 = Class54.gclass26_0.method_2();
                    if (gclass27_4 != null)
                    {
                      int int_10 = index1++;
                      Thread thread = new Thread((ThreadStart) (() =>
                      {
                        try
                        {
                          this.method_184(int_10, "Connect phone...");
                          int tickCount = Environment.TickCount;
                          int num = 1;
                          while (true)
                          {
                            this.method_184(int_10, "Connect phone" + (num != 1 ? string.Format(" ({0})", (object) num) : "") + "...");
                            if (!(gclass27_4.method_1() != ""))
                            {
                              ++num;
                              if (Environment.TickCount - tickCount < 300000)
                                GClass19.smethod_64(1.0);
                              else
                                goto label_8;
                            }
                            else
                              break;
                          }
                          this.method_184(int_10, string.Format("Connect phone ({0}) success!", (object) num));
                          this.method_186(int_10, "cDeviceId", (object) GClass33.smethod_0("device").method_1(gclass27_4.String_2));
                          this.method_33(int_10, gclass27_4, "", int_4);
                          if (!GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll"))
                            this.method_186(int_10, "cChose", (object) false);
                          Class54.gclass26_0.method_3(gclass27_4, false);
                          return;
label_8:
                          this.method_184(int_10, "Connect phone fail!");
                        }
                        catch (Exception ex)
                        {
                          if (!ex.ToString().Contains("Thread was being aborted."))
                            return;
                          if (!GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll"))
                            this.method_186(int_10, "cChose", (object) false);
                          Class54.gclass26_0.method_3(gclass27_4, false);
                        }
                      }))
                      {
                        Name = int_10.ToString()
                      };
                      lock (this.list_0)
                        this.list_0.Add(thread);
                      thread.IsBackground = true;
                      thread.Start();
                    }
                  }
                  else
                    break;
                }
                else
                  ++index1;
              }
              for (int index2 = 0; index2 < this.list_0.Count; ++index2)
                this.list_0[index2].Join();
            }
            catch (ThreadAbortException ex)
            {
              if (!ex.ToString().Contains("Thread was being aborted."))
                ;
            }
            this.method_135("stop");
            this.bool_4 = false;
          }))
          {
            IsBackground = true
          }.Start();
        else if (int_4 == 2)
        {
          new Thread((ThreadStart) (() =>
          {
            try
            {
              int index3 = 0;
              while (index3 < this.dtgvAcc.Rows.Count && !this.bool_0)
              {
                if (Convert.ToBoolean(this.dtgvAcc.Rows[index3].Cells["cChose"].Value))
                {
                  if (!this.bool_0)
                  {
                    GClass27 gclass27_3 = (GClass27) null;
                    lock (Class54.gclass26_0)
                      gclass27_3 = Class54.gclass26_0.method_2();
                    if (gclass27_3 != null)
                    {
                      int int_9 = index3++;
                      Thread thread = new Thread((ThreadStart) (() =>
                      {
                        try
                        {
                          this.method_184(int_9, "Connect phone...");
                          int tickCount = Environment.TickCount;
                          int num = 1;
                          while (true)
                          {
                            this.method_184(int_9, "Connect phone" + (num != 1 ? string.Format(" ({0})", (object) num) : "") + "...");
                            if (!(gclass27_3.method_1() != ""))
                            {
                              ++num;
                              if (Environment.TickCount - tickCount < 300000)
                                GClass19.smethod_64(1.0);
                              else
                                goto label_14;
                            }
                            else
                              break;
                          }
                          this.method_184(int_9, string.Format("Connect phone ({0}) success!", (object) num));
                          this.method_186(int_9, "cDeviceId", (object) GClass33.smethod_0("device").method_1(gclass27_3.String_2));
                          string str = this.method_191(int_9, "cDevice").Trim().Replace(gclass27_3.String_2 + "_", "");
                          List<string> first = gclass27_3.method_149();
                          if (!first.Contains(str))
                          {
                            str = first.Except<string>((IEnumerable<string>) Class42.smethod_33(gclass27_3.String_2)).FirstOrDefault<string>();
                            if (!string.IsNullOrEmpty(str))
                              this.method_187(int_9, "cDevice", gclass27_3.String_2 + "_" + str, "device");
                          }
                          if (string.IsNullOrEmpty(str))
                          {
                            this.bool_0 = true;
                            this.method_184(int_9, GClass35.smethod_0("Hết App Facebook trống!"));
                            return;
                          }
                          gclass27_3.string_5 = str;
                          this.method_33(int_9, gclass27_3, "", int_4);
                          if (!GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll"))
                            this.method_186(int_9, "cChose", (object) false);
                          Class54.gclass26_0.method_3(gclass27_3, false);
                          return;
label_14:
                          this.method_184(int_9, "Connect phone fail!");
                        }
                        catch (Exception ex)
                        {
                          if (!ex.ToString().Contains("Thread was being aborted."))
                            return;
                          if (!GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll"))
                            this.method_186(int_9, "cChose", (object) false);
                          Class54.gclass26_0.method_3(gclass27_3, false);
                        }
                      }))
                      {
                        Name = int_9.ToString()
                      };
                      lock (this.list_0)
                        this.list_0.Add(thread);
                      thread.IsBackground = true;
                      thread.Start();
                    }
                  }
                  else
                    break;
                }
                else
                  ++index3;
              }
              for (int index4 = 0; index4 < this.list_0.Count; ++index4)
                this.list_0[index4].Join();
            }
            catch (ThreadAbortException ex)
            {
              if (!ex.ToString().Contains("Thread was being aborted."))
                ;
            }
            this.method_135("stop");
            this.bool_4 = false;
          }))
          {
            IsBackground = true
          }.Start();
        }
        else
        {
          int int_6;
          string string_;
          new Thread((ThreadStart) (() =>
          {
            try
            {
              GClass22 gclass22_1_2 = new GClass22();
              if (bool_5)
              {
                GClass19.smethod_35((Form) new fHenGioChayDung(gclass22_1_2));
                if (gclass22_1_2.method_4("isCancel"))
                  goto label_60;
              }
              this.bool_0 = false;
              this.method_135("start");
              if (gclass22_1_2.method_1("timeStart") != "")
              {
                string[] strArray = gclass22_1_2.method_1("timeStart").Trim().Split(':');
                DateTime dateTime_0;
                ref DateTime local = ref dateTime_0;
                DateTime now = DateTime.Now;
                int year = now.Year;
                now = DateTime.Now;
                int month = now.Month;
                now = DateTime.Now;
                int day = now.Day;
                int int32_1 = Convert.ToInt32(strArray[0]);
                int int32_2 = Convert.ToInt32(strArray[1]);
                int int32_3 = Convert.ToInt32(strArray[2]);
                local = new DateTime(year, month, day, int32_1, int32_2, int32_3);
                if (dateTime_0.CompareTo(DateTime.Now) == -1)
                  dateTime_0 = dateTime_0.AddDays(1.0);
                int int_7 = GClass19.smethod_80(dateTime_0);
                try
                {
                  int_6 = Environment.TickCount;
                  while (Environment.TickCount - int_6 < int_7 * 1000 && !this.bool_0)
                  {
                    this.Invoke((Delegate) (() => this.lblStatus.Text = "Chạy sau {time}s".Replace("{time}", GClass19.smethod_23(int_7 - (Environment.TickCount - int_6) / 1000))));
                    GClass19.smethod_64(0.5);
                  }
                  this.Invoke((Delegate) (() => this.lblStatus.Text = "Đã kích hoạt"));
                }
                catch (Exception ex)
                {
                }
              }
              if (!this.bool_0)
              {
                foreach (GClass27 gclass27 in Class54.gclass26_0.list_0)
                {
                  GClass27 gclass27_ = gclass27;
                  new Thread((ThreadStart) (() =>
                  {
                    gclass27_.method_69();
                    gclass27_.method_43();
                  }))
                  {
                    IsBackground = true
                  }.Start();
                }
                this.bool_4 = true;
                List<string> stringList2 = new List<string>();
                string_ = "";
                string str1 = "";
                int num1 = GClass33.smethod_0("configInteractGeneral").method_3("nudSoLuotChay", 1);
                if (num1 == 0)
                  num1 = 1;
                for (int index7 = 0; index7 < num1; ++index7)
                {
                  List<string> list_0 = new List<string>();
                  if (GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll"))
                  {
                    str1 = num1 > 1 ? string.Format(GClass35.smethod_0("Lượt {0}/{1}. "), (object) (index7 + 1), (object) num1) : "";
                    if (GClass33.smethod_0("configInteractGeneral").method_4("RepeatAllVIP"))
                    {
                      list_0 = GClass33.smethod_0("configInteractGeneral").method_2("lstIdKichBan");
                      if (GClass33.smethod_0("configInteractGeneral").method_4("ckbRandomKichBan"))
                        list_0 = GClass19.smethod_38(GClass19.smethod_38(GClass19.smethod_38(list_0)));
                    }
                    else
                      list_0.Add(GClass33.smethod_0("configInteractGeneral").method_1("cbbKichBan"));
                  }
                  else
                    list_0.Add(GClass33.smethod_0("configInteractGeneral").method_1("cbbKichBan"));
                  int num2;
                  for (int index8 = 0; index8 < list_0.Count && !this.bool_0; ++index8)
                  {
                    string_ = list_0[index8];
                    if (str1 != "")
                      this.method_103(str1 + string.Format(GClass35.smethod_0("Kịch bản") + ": {0}...", (object) Class205.smethod_3(string_)));
                    if (GClass33.smethod_0("configInteractGeneral").method_4("ckbRandomThuTuTaiKhoan"))
                      this.dtgvAcc.Invoke((Delegate) (closure_0 ?? (closure_0 = (MethodInvoker) (() => this.method_175()))));
                    this.dictionary_0 = this.method_22(string_, "HDThamGiaNhomUid");
                    this.dictionary_1 = this.method_22(string_, "HDKetBanTepUid");
                    this.dictionary_16 = this.method_22(string_, "HDSpamBaiViet");
                    this.dictionary_3 = this.method_22(string_, "HDDangReel", "txtNoiDung");
                    this.dictionary_4 = this.method_22(string_, "HDDangBaiTuong", "txtNoiDung");
                    this.dictionary_5 = this.method_22(string_, "HDDangBaiNhom", "txtNoiDung");
                    this.dictionary_6 = this.method_22(string_, "HDDangBaiNhom", "txtIdNhomChiDinh");
                    this.dictionary_8 = this.method_22(string_, "HDDangBaiPage", "txtNoiDung");
                    this.dictionary_9 = this.method_22(string_, "HDDangBaiPage", "txtIdNhomChiDinh");
                    this.dictionary_10 = this.method_22(string_, "HDAddMail", "lstHotmail");
                    this.dictionary_11 = this.method_22(string_, "HDVerifyAccount", "lstHotmail");
                    this.dictionary_12 = this.method_22(string_, "HDTuongTacPage");
                    this.dictionary_13 = this.method_22(string_, "HDDongBoDanhBa", "txtSdt");
                    this.dictionary_14 = this.method_22(string_, "HDDanhGiaPage", "txtComment");
                    this.dictionary_15 = this.method_22(string_, "HDTuongTacBaiVietChiDinh", "txtComment");
                    this.dictionary_17 = new Dictionary<string, List<string>>();
                    this.dictionary_7 = new Dictionary<string, List<string>>();
                    this.dictionary_18 = this.method_22(string_, "HDDangStory", "txtDanhSachBaiHat");
                    this.dictionary_19 = this.method_22(string_, "HDDangStory", "txtDanhSachBaiHat");
                    if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 14)
                    {
                      for (int index9 = 0; index9 < this.list_16.Count; ++index9)
                        this.list_16[index9].method_4();
                    }
                    GClass33.smethod_0("configGeneral").method_3("nudDelayThread", 10);
                    this.thread_0 = new Thread((ThreadStart) (() =>
                    {
                      try
                      {
                        int index10 = 0;
                        while (index10 < this.dtgvAcc.Rows.Count && !this.bool_0)
                        {
                          if (Convert.ToBoolean(this.dtgvAcc.Rows[index10].Cells["cChose"].Value))
                          {
                            // ISSUE: variable of a compiler-generated type
                            fMain.\u003C\u003Ec__DisplayClass305_1 displayClass3051 = this;
                            if (!this.bool_0)
                            {
                              GClass27 gclass27_2 = (GClass27) null;
                              lock (Class54.gclass26_0)
                                gclass27_2 = Class54.gclass26_0.method_2();
                              if (gclass27_2 != null)
                              {
                                int int_8 = index10++;
                                Thread thread = new Thread((ThreadStart) (() =>
                                {
                                  try
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_184(int_8, "Connect phone...");
                                    int tickCount = Environment.TickCount;
                                    int num = 1;
                                    while (true)
                                    {
                                      // ISSUE: reference to a compiler-generated field
                                      // ISSUE: reference to a compiler-generated field
                                      closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_184(int_8, "Connect phone" + (num != 1 ? string.Format(" ({0})", (object) num) : "") + "...");
                                      if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 8)
                                        gclass27_2.method_8();
                                      if (!(gclass27_2.method_1() != ""))
                                      {
                                        ++num;
                                        if (Environment.TickCount - tickCount < 300000)
                                          GClass19.smethod_64(1.0);
                                        else
                                          goto label_11;
                                      }
                                      else
                                        break;
                                    }
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_184(int_8, string.Format("Connect phone ({0}) success!", (object) num));
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_186(int_8, "cDeviceId", (object) GClass33.smethod_0("device").method_1(gclass27_2.String_2));
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_33(int_8, gclass27_2, closure_2.string_, closure_2.CS\u0024\u003C\u003E8__locals1.int_4, closure_2.CS\u0024\u003C\u003E8__locals1.gclass22_0);
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    if (!GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll") || closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_190(int_8) != "Live" || closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_189(int_8).ToLower().Contains("checkpoint") || closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_189(int_8).ToLower().Contains("invalid username or password"))
                                    {
                                      // ISSUE: reference to a compiler-generated field
                                      // ISSUE: reference to a compiler-generated field
                                      closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_186(int_8, "cChose", (object) false);
                                    }
                                    Class54.gclass26_0.method_3(gclass27_2, false);
                                    return;
label_11:
                                    // ISSUE: reference to a compiler-generated field
                                    // ISSUE: reference to a compiler-generated field
                                    closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_184(int_8, "Connect phone fail!");
                                  }
                                  catch (Exception ex)
                                  {
                                    if (!ex.ToString().Contains("Thread was being aborted."))
                                      return;
                                    if (!GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll"))
                                    {
                                      // ISSUE: reference to a compiler-generated field
                                      // ISSUE: reference to a compiler-generated field
                                      closure_2.CS\u0024\u003C\u003E8__locals1.\u003C\u003E4__this.method_186(int_8, "cChose", (object) false);
                                    }
                                    Class54.gclass26_0.method_3(gclass27_2, false);
                                  }
                                }))
                                {
                                  Name = int_8.ToString()
                                };
                                this.list_1.Add(thread.Name.ToString());
                                lock (this.list_0)
                                  this.list_0.Add(thread);
                                thread.IsBackground = true;
                                thread.Start();
                              }
                            }
                            else
                              break;
                          }
                          else
                            ++index10;
                        }
                        for (int index11 = 0; index11 < this.list_0.Count; ++index11)
                          this.list_0[index11].Join();
                      }
                      catch (ThreadAbortException ex)
                      {
                        if (!ex.ToString().Contains("Thread was being aborted."))
                          ;
                      }
                    }));
                    this.thread_0.IsBackground = true;
                    this.thread_0.Start();
                    if (GClass33.smethod_0("configInteractGeneral").method_4("ckbGioiHanThoiGianChayKichBan"))
                    {
                      if (!this.thread_0.Join(this.random_0.Next(GClass33.smethod_0("configInteractGeneral").method_3("nudThoiGianChayKichBanFrom"), GClass33.smethod_0("configInteractGeneral").method_3("nudThoiGianChayKichBanTo") + 1) * 60000))
                        this.method_28();
                    }
                    else
                      this.thread_0.Join();
                    this.method_23(this.dictionary_0);
                    this.method_23(this.dictionary_1);
                    this.method_23(this.dictionary_16);
                    this.method_23(this.dictionary_3, "txtNoiDung");
                    this.method_23(this.dictionary_4, "txtNoiDung");
                    this.method_23(this.dictionary_5, "txtNoiDung");
                    this.method_23(this.dictionary_6, "txtIdNhomChiDinh");
                    this.method_23(this.dictionary_8, "txtNoiDung");
                    this.method_23(this.dictionary_9, "txtIdNhomChiDinh");
                    this.method_23(this.dictionary_10, "lstHotmail");
                    this.method_23(this.dictionary_11, "lstHotmail");
                    this.method_23(this.dictionary_12);
                    this.method_23(this.dictionary_13, "txtSdt");
                    this.method_23(this.dictionary_14, "txtComment");
                    this.method_23(this.dictionary_15, "txtComment");
                    if (!this.bool_0)
                    {
                      if (index8 + 1 < list_0.Count)
                      {
                        int num3 = Class54.random_0.Next(GClass33.smethod_0("configInteractGeneral").method_3("nudDelayKichBanFrom"), GClass33.smethod_0("configInteractGeneral").method_3("nudDelayKichBanTo") + 1);
                        int tickCount = Environment.TickCount;
                        while ((Environment.TickCount - tickCount) / 1000 - num3 < 0)
                        {
                          string str2 = str1;
                          string str3 = GClass35.smethod_0("Chạy kịch bản tiếp theo sau {time} giây...");
                          num2 = num3 - (Environment.TickCount - tickCount) / 1000;
                          string newValue = num2.ToString();
                          string str4 = string.Format(str3.Replace("{time}", newValue));
                          this.method_103(str2 + str4);
                          GClass19.smethod_64(0.5);
                          if (this.bool_0)
                            break;
                        }
                      }
                    }
                    else
                      break;
                  }
                  if (GClass33.smethod_0("configInteractGeneral").method_4("ckbRepeatAll") && !this.bool_0)
                  {
                    if (index7 + 1 < num1)
                    {
                      int num4 = Class54.random_0.Next(GClass33.smethod_0("configInteractGeneral").method_3("nudDelayTurnFrom"), GClass33.smethod_0("configInteractGeneral").method_3("nudDelayTurnTo") + 1) * 60;
                      int tickCount = Environment.TickCount;
                      while ((Environment.TickCount - tickCount) / 1000 - num4 < 0)
                      {
                        string str5 = str1;
                        string str6 = GClass35.smethod_0("Chạy lượt tiếp theo sau {time} giây...");
                        num2 = num4 - (Environment.TickCount - tickCount) / 1000;
                        string newValue = num2.ToString();
                        string str7 = string.Format(str6.Replace("{time}", newValue));
                        this.method_103(str5 + str7);
                        GClass19.smethod_64(0.5);
                        if (this.bool_0)
                          break;
                      }
                    }
                    if (this.bool_0)
                      break;
                  }
                  else
                    break;
                }
              }
            }
            catch (Exception ex)
            {
              GClass19.smethod_79((GClass18) null, ex);
            }
label_60:
            this.method_104();
            if (!GClass33.smethod_0("configGeneral").method_4("ckbKhongAddVaoFormView"))
              this.method_26();
            this.method_135("stop");
            foreach (GClass27 gclass27 in Class54.gclass26_0.list_0)
              new Thread((ThreadStart) (() => { }))
              {
                IsBackground = true
              }.Start();
            if (GClass33.smethod_0("configGeneral").method_4("ckbTatADBKhiDungTool", true))
            {
              GClass36.smethod_1();
              GClass7.smethod_3();
              Class76.smethod_2();
            }
            this.bool_4 = false;
          }))
          {
            IsBackground = true
          }.Start();
        }
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
      this.method_135("stop");
      this.bool_4 = false;
    }
  }

  private void method_28()
  {
    this.thread_0.Abort();
    for (int index = 0; index < this.list_0.Count; ++index)
    {
      this.list_0[index].Abort();
      while (this.list_0[index].IsAlive)
        Thread.Sleep(1000);
    }
    while (this.thread_0.IsAlive)
      Thread.Sleep(1000);
  }

  private bool method_29(GClass18 gclass18_0)
  {
    bool flag = true;
    try
    {
      GClass20.smethod_12(gclass18_0);
      string string_7 = gclass18_0.method_5("a", "href", "/privacy/touch/tags/review/");
      if (string_7 != "" && gclass18_0.method_21(4, string_7) == 1)
      {
        gclass18_0.method_31();
        if (!Convert.ToBoolean(gclass18_0.method_20("return document.querySelector('input[type=\"checkbox\"]').checked+''").ToString()))
          gclass18_0.method_21(4, "form div[role=\"button\"]");
        return true;
      }
    }
    catch
    {
      flag = false;
    }
    return flag;
  }

  private List<string> method_30(List<string> list_18)
  {
    List<string> stringList = new List<string>();
    list_18 = list_18.Distinct<string>().ToList<string>();
    for (int index = 0; index < list_18.Count; ++index)
    {
      if (list_18[index] != "[0,0][0,0]")
        stringList.Add(list_18[index]);
    }
    return stringList;
  }

  private int method_31(GClass27 gclass27_0, int int_4, string string_0, int int_5)
  {
    string str1 = this.method_191(int_4, "cId");
    string string_11 = this.method_191(int_4, "cUid");
    string str2 = this.method_191(int_4, "cEmail");
    string string_13 = this.method_191(int_4, "cPassword");
    string string_14 = this.method_191(int_4, "cFa2");
    if (string_11 != "")
    {
      string str3 = GClass13.smethod_0() + "\\device\\" + string_11 + ".tar.gz";
      if (!File.Exists(str3))
      {
        string str4 = GClass13.smethod_0() + "\\device\\" + str1 + ".tar.gz";
        string str5 = GClass13.smethod_0() + "\\device\\" + str2 + ".tar.gz";
        if (File.Exists(str4))
          GClass19.smethod_102(str4, str3);
        else if (str2 != "" && File.Exists(str5))
          GClass19.smethod_102(str5, str3);
      }
    }
    string string_12;
    if (GClass33.smethod_0("configInteractGeneral").method_3("typeLogin") == 0)
    {
      this.method_184(int_4, string_0 + GClass35.smethod_0("Login Uid|Pass..."));
      string_12 = string_11;
    }
    else
    {
      this.method_184(int_4, string_0 + GClass35.smethod_0("Login Email|Pass..."));
      string_12 = str2;
    }
    int num = gclass27_0.method_99(string_11, string_12, string_13, string_14, GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp"), int_5);
    switch (num)
    {
      case -2:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Không thể kết nối thiết bị!"));
        break;
      case 0:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Đăng nhập thất bại!"), gclass27_0: gclass27_0);
        break;
      case 1:
        this.method_185(int_4, "Live");
        break;
      case 2:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Checkpoint!"));
        this.method_185(int_4, "Checkpoint", gclass27_0);
        break;
      case 3:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Không có 2fa!"));
        break;
      case 4:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Tài khoản không đúng!"));
        break;
      case 5:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Mật khẩu không đúng!"));
        this.method_185(int_4, "Changed pass", gclass27_0);
        break;
      case 6:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Mã 2FA không đúng!"));
        break;
      case 7:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Lỗi kết nối Internet!"));
        break;
      case 8:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Tài khoản chưa xác minh!"));
        break;
      case 9:
        gclass27_0.method_86(gclass27_0.string_5);
        if (num != 1)
        {
          this.method_184(int_4, string_0 + GClass35.smethod_0("Facebook bắt add sđt!"));
          break;
        }
        break;
      case 10:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Không thể login!"));
        break;
      case 11:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Login fail: You’re Temporarily Blocked"), gclass27_0: gclass27_0);
        break;
      case 12:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Login fail: You can't log in right now"), gclass27_0: gclass27_0);
        break;
      case 13:
        this.method_184(int_4, string_0 + "Facebook Spam", gclass27_0: gclass27_0);
        break;
      case 14:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Lỗi dạng login!"));
        break;
    }
    return num;
  }

  private int method_32(GClass27 gclass27_0, int int_4, string string_0)
  {
    this.method_191(int_4, "cId");
    string string_11 = this.method_191(int_4, "cUid");
    string string_12 = this.method_191(int_4, "cPassword");
    string string_13 = this.method_191(int_4, "cFa2");
    int num = gclass27_0.method_138(string_11, string_12, string_13);
    switch (num)
    {
      case -4:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Lỗi app Fb!"));
        break;
      case -2:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Không thể kết nối thiết bị!"));
        break;
      case -1:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Tài khoản bị đăng xuất!"));
        break;
      case 2:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Checkpoint!"));
        this.method_185(int_4, "Checkpoint", gclass27_0);
        break;
      case 3:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Không có 2fa!"));
        break;
      case 4:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Tài khoản không đúng!"));
        break;
      case 5:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Mật khẩu không đúng!"));
        this.method_185(int_4, "Changed pass", gclass27_0);
        break;
      case 6:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Mã 2FA không đúng!"));
        break;
      case 7:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Lỗi kết nối Internet!"));
        break;
      case 8:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Tài khoản chưa xác minh!"));
        break;
      case 10:
        this.method_184(int_4, string_0 + GClass35.smethod_0("Không thể login lại!"));
        break;
      case 13:
        this.method_184(int_4, string_0 + "Facebook Spam!");
        break;
    }
    return num;
  }

  private void method_33(
    int int_4,
    GClass27 gclass27_0,
    string string_0,
    int int_5 = 0,
    GClass22 gclass22_0 = null)
  {
    int int_2 = 0;
    if (GClass33.smethod_0("configInteractGeneral").method_4("ckbGioiHanThoiGianChayTaiKhoan"))
      int_2 = this.random_0.Next(GClass33.smethod_0("configInteractGeneral").method_3("nudThoiGianChayTaiKhoanFrom"), GClass33.smethod_0("configInteractGeneral").method_3("nudThoiGianChayTaiKhoanTo") + 1);
    GClass6 gclass6 = new GClass6(Thread.CurrentThread, int_2);
    string string_0_1 = "";
    int num1 = -1;
    int int_4_1 = 0;
    int int_4_2 = 0;
    int int_5_1 = 0;
    int int_6 = 0;
    int int_4_3 = 0;
    int int_4_4 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    int num5 = 0;
    int int_4_5 = 0;
    int int_4_6 = 0;
    Class46 class46 = (Class46) null;
    GClass25 gclass25 = (GClass25) null;
    Class47 class47 = (Class47) null;
    Class6 class6 = (Class6) null;
    Class7 class7 = (Class7) null;
    Class4 class4 = (Class4) null;
    GClass10 gclass10 = (GClass10) null;
    int num6 = 0;
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    Convert.ToInt32(this.method_191(int_4, "cSTT"));
    string str1 = this.method_191(int_4, "cUid");
    string string_0_2 = this.method_191(int_4, "cId");
    this.method_191(int_4, "cEmail");
    string string_13 = this.method_191(int_4, "cFa2");
    string string_12 = this.method_191(int_4, "cPassword");
    string str2 = this.method_191(int_4, "cCookies");
    this.method_191(int_4, "cToken");
    if (str1 == "")
    {
      str1 = Regex.Match(str2 + ";", "c_user=(.*?);").Groups[1].Value;
      this.method_187(int_4, "cUid", str1, "uid");
    }
    try
    {
      try
      {
        if (int_5 == 0 && GClass33.smethod_0("configInteractGeneral").method_4("ckbCheckLiveUid", true) && this.method_21(str1) && Class38.smethod_17(str1).StartsWith("0|"))
        {
          this.method_184(int_4, GClass35.smethod_0("Tài khoản Die!"));
          this.method_185(int_4, "Die");
          num6 = 1;
        }
        else if (this.bool_0)
        {
          this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đã dừng!"));
          num6 = 1;
        }
        else
        {
          gclass27_0.RemoveProxy();
          switch (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp"))
          {
            case 7:
              this.method_184(int_4, GClass35.smethod_0("Đang lấy proxy Tinsoft..."));
              break;
            case 8:
              string string_11_1 = gclass27_0.method_7();
              gclass27_0.method_3(0, string_11_1);
              if (GClass33.smethod_0("configGeneral").method_4("ckbShowProxy"))
                string_0_1 = "(Proxy: " + string_11_1 + ") ";
              this.method_184(int_4, string_0_1 + "Reset Xproxy...");
              if (gclass27_0.method_9())
              {
                this.method_184(int_4, string_0_1 + "Reset Xproxy, " + GClass35.smethod_0("đợi") + " {time}s...", GClass33.smethod_0("configGeneral").method_3("nudDelayConnectXproxy", 10));
                break;
              }
              this.method_184(int_4, GClass35.smethod_0("Reset Xproxy fail!"));
              num6 = 1;
              goto label_249;
            case 9:
              string string_11_2 = this.method_191(int_4, "cProxy");
              int int_4_7 = !string_11_2.EndsWith("*0") ? 1 : 0;
              if (string_11_2 != "")
              {
                if (string_11_2.EndsWith("*0") || string_11_2.EndsWith("*1"))
                  string_11_2 = string_11_2.Substring(0, string_11_2.Length - 2);
                gclass27_0.method_3(int_4_7, string_11_2);
                break;
              }
              break;
            case 10:
              this.method_184(int_4, GClass35.smethod_0("Đang lấy TMProxy..."));
              break;
            case 11:
              this.method_184(int_4, GClass35.smethod_0("Đang lấy Proxyv6..."));
              break;
            case 12:
              this.method_184(int_4, GClass35.smethod_0("Đang lấy Proxy ShopLike..."));
              break;
            case 13:
              this.method_184(int_4, GClass35.smethod_0("Đang lấy Api MinProxy..."));
              break;
            case 14:
              this.method_184(int_4, GClass35.smethod_0("Đang chờ lấy Proxy..."));
              break;
            case 15:
              this.method_184(int_4, string_0_1 + GClass35.smethod_0("Reset 4G..."));
              if (!gclass27_0.method_160())
              {
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Error Reset 4G!"));
                num6 = 1;
                goto label_249;
              }
              else
                break;
          }
          if (this.bool_0)
          {
            this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đã dừng!"));
            num6 = 1;
          }
          else if (!gclass27_0.method_5(GClass33.smethod_0("configGeneral").method_3("typeConnectProxy")))
          {
            this.method_184(int_4, string_0_1 + GClass35.smethod_0("Connect proxy fail!"));
            num6 = 1;
          }
          else
          {
            if (!GClass33.smethod_0("configGeneral").method_4("ckbKhongCheckIP"))
            {
              string str3 = "";
              for (int index = 0; index < 2; ++index)
              {
                this.method_184(int_4, string_0_1 + "Check IP...");
                str3 = gclass27_0.method_162(int_5: GClass33.smethod_0("configGeneral").method_3("typeConnectProxy"));
                if (!(str3 != "") && index != 1)
                {
                  if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") != 15)
                  {
                    gclass27_0.method_156();
                    gclass27_0.SleepSeconds(1.0);
                    gclass27_0.method_157();
                    gclass27_0.SleepSeconds(5.0);
                  }
                  else
                  {
                    gclass27_0.method_160();
                    gclass27_0.SleepSeconds(3.0);
                  }
                }
                else
                  break;
              }
              if (str3 == "")
              {
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Không check được IP!"));
                num6 = 1;
              }
              else if (!str3.Contains("Proxy Authentication Required"))
              {
                string_0_1 = "(IP: " + str3 + ") ";
                goto label_241;
              }
              else
              {
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Proxy chưa ủy quyền!"));
                num6 = 1;
              }
              goto label_46;
            }
label_241:
            if (this.bool_0)
            {
              this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đã dừng!"));
              num6 = 1;
              goto label_249;
            }
            else
            {
              if (int_5 != 2 && !GClass33.smethod_0("configGeneral").method_4("ckbKhongChangeDevice"))
                goto label_244;
label_47:
              if (this.bool_0)
              {
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đã dừng!"));
                num6 = 1;
                goto label_249;
              }
              else
              {
                gclass6.method_0();
                string str4;
                string str5;
                string str6;
                while (true)
                {
                  gclass27_0.Cleardata("com.android.providers.contacts");
                  int num7 = this.method_31(gclass27_0, int_4, string_0_1, int_5);
                  if (int_5 != 5)
                  {
                    if (num7 == 1 || num7 == 8)
                    {
                      flag3 = true;
                      this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đăng nhập thành công!"));
                      switch (int_5)
                      {
                        case 3:
                          goto label_224;
                        case 4:
                          goto label_228;
                        case 6:
                          goto label_233;
                        default:
                          if (!this.bool_0)
                          {
                            string str7 = gclass27_0.method_114();
                            str4 = str7.Split('|')[0];
                            str5 = str7.Split('|')[1];
                            str6 = Regex.Match(str5 + ";", "c_user=(.*?);").Groups[1].Value;
                            if (str6.Trim() != "")
                            {
                              if (this.method_21(str1))
                              {
                                if (str1 != str6)
                                {
                                  gclass27_0.Cleardata(gclass27_0.string_5);
                                  GClass19.smethod_98(GClass13.smethod_0() + "\\profile\\" + str1 + ".tar.gz");
                                  continue;
                                }
                                goto label_59;
                              }
                              else
                                goto label_56;
                            }
                            else
                              goto label_60;
                          }
                          else
                            goto label_223;
                      }
                    }
                    else
                      goto label_234;
                  }
                  else
                    goto label_237;
                }
label_56:
                if (str1 != "" && this.method_191(int_4, "cEmail").Trim() == "")
                  this.method_187(int_4, "cEmail", str1, "email");
                str1 = str6;
                this.method_187(int_4, "cUid", str1, "uid");
label_59:
label_60:
                if (GClass33.smethod_0("configInteractGeneral").method_4("ckbGetCookie"))
                {
                  if (str4 != "")
                  {
                    Class42.smethod_13(string_0_2, "token", str4);
                    this.method_186(int_4, "cToken", (object) str4);
                  }
                  if (str5 != "")
                  {
                    Class42.smethod_13(string_0_2, "cookie1", str5);
                    this.method_186(int_4, "cCookies", (object) str5);
                  }
                }
                if (int_5 != 0)
                {
                  num6 = 1;
                  goto label_240;
                }
                else
                {
                  DataTable dataTable_0 = Class205.smethod_14(string_0);
                  if (GClass33.smethod_0("configInteractGeneral").method_4("ckbRandomHanhDong"))
                    dataTable_0 = GClass19.smethod_94(dataTable_0, 3);
                  DataTable dataTable1 = new DataTable();
                  GClass22 gclass22 = new GClass22(Class205.smethod_6(string_0), true);
                  int num8 = gclass22.method_3("typeSoLuongHanhDong");
                  int minValue = gclass22.method_3("nudHanhDongFrom");
                  int num9 = gclass22.method_3("nudHanhDongTo");
                  int num10 = dataTable_0.Rows.Count;
                  if (num8 == 1 && minValue <= num9)
                  {
                    num10 = Class54.random_0.Next(minValue, num9 + 1);
                    if (num10 > dataTable_0.Rows.Count)
                      num10 = dataTable_0.Rows.Count;
                  }
                  int index = 0;
                  while (true)
                  {
                    if (index < num10)
                    {
                      if (!this.bool_0)
                      {
                        int num11 = this.method_32(gclass27_0, int_4, string_0_1);
                        if (num11 == 0 || num11 == 1)
                        {
                          try
                          {
                            string str8 = dataTable_0.Rows[index]["TenHanhDong"].ToString();
                            string str9 = dataTable_0.Rows[index]["Id_HanhDong"].ToString();
                            this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đang") + " " + str8 + "...");
                            DataTable dataTable2 = Class205.smethod_15(str9);
                            GClass22 gclass22_0_1 = new GClass22(dataTable2.Rows[0]["CauHinh"].ToString(), true);
                            try
                            {
                              string s = dataTable2.Rows[0]["TenTuongTac"].ToString();
                              // ISSUE: reference to a compiler-generated method
                              uint num12 = Class206.smethod_0(s);
                              if (num12 <= 2433475627U)
                              {
                                switch (num12)
                                {
                                  case 34992592:
                                    if (s == "HDXemWatchTheoTuKhoa")
                                    {
                                      num11 = this.method_89(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 105160162:
                                    if (s == "HDDangBaiTuong")
                                    {
                                      num11 = this.method_80(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                      break;
                                    }
                                    break;
                                  case 115118702:
                                    if (s == "HDSpamNhom")
                                    {
                                      num11 = this.method_123(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                      break;
                                    }
                                    break;
                                  case 152310871:
                                    if (s == "HDUpCover")
                                    {
                                      num11 = this.method_54(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      num3 = num11 == 1 ? 1 : 2;
                                      break;
                                    }
                                    break;
                                  case 155455705:
                                    if (s == "HDDangBaiNhom")
                                    {
                                      num11 = this.SleepSeconds(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                      break;
                                    }
                                    break;
                                  case 167896116:
                                    if (s == "HDTuongTacBaiVietTuKhoa")
                                    {
                                      num11 = this.method_122(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                      break;
                                    }
                                    break;
                                  case 311671696:
                                    if (s == "HDKetBanGoiY")
                                    {
                                      num11 = this.method_98(ref int_4_5, int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 516966741:
                                    if (s == "HDDangReel")
                                    {
                                      num11 = this.method_79(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9, str5);
                                      break;
                                    }
                                    break;
                                  case 523366477:
                                    if (s == "HDBuffFollowUID")
                                    {
                                      num11 = this.method_119(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 551470432:
                                    if (s == "HDSpamBanBe")
                                    {
                                      num11 = this.method_124(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                      break;
                                    }
                                    break;
                                  case 582938346:
                                    if (s == "HDXemStory")
                                    {
                                      num11 = this.method_93(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 745266353:
                                    if (s == "HDXemReel")
                                    {
                                      num11 = this.method_86(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 786238800:
                                    if (s == "HDXemWatch")
                                    {
                                      num11 = this.method_88(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 852508141:
                                    if (s == "HDKetBanTepUid")
                                    {
                                      num11 = this.method_130(int_4, string_0_1, gclass27_0, gclass22_0_1, str9, str8);
                                      break;
                                    }
                                    break;
                                  case 894688135:
                                    if (s == "HDTuongTacReelChiDinh")
                                    {
                                      num11 = this.method_87(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 1526944464:
                                    if (s == "HDTuongTacBanBe")
                                    {
                                      num11 = this.method_113(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 1577102954:
                                    if (s == "HDSpamNewfeed")
                                    {
                                      num11 = this.method_125(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 1653385921:
                                    if (s == "HDNghiGiaiLao")
                                    {
                                      num11 = this.method_65(int_4, string_0_1, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 1780458336:
                                    if (s == "HDDangBaiPage")
                                    {
                                      num11 = this.method_83(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                      break;
                                    }
                                    break;
                                  case 1823818229:
                                    if (s == "HDUpAvatar")
                                    {
                                      num11 = this.method_53(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      num2 = num11 == 1 ? 1 : 2;
                                      break;
                                    }
                                    break;
                                  case 1884305945:
                                    if (s == "HDDocThongBao")
                                    {
                                      num11 = this.method_90(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 1952866892:
                                    if (s == "HDKetBanTheoTuKhoa")
                                    {
                                      num11 = this.method_97(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 2004466602:
                                    if (s == "HDDoiTen")
                                    {
                                      num11 = this.method_58(ref int_4_4, int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      if (int_4_4 == 1)
                                      {
                                        string string_1 = Class38.smethod_18(str1);
                                        if (string_1 != "")
                                          this.method_187(int_4, "cName", string_1, "name");
                                        break;
                                      }
                                      break;
                                    }
                                    break;
                                  case 2030328732:
                                    if (s == "HDOnOff2FA")
                                    {
                                      num11 = this.method_49(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      num5 = num11;
                                      break;
                                    }
                                    break;
                                  case 2149398608:
                                    if (s == "HDBuffLikePage")
                                    {
                                      num11 = this.method_117(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 2277183375:
                                    if (s == "HDRoiNhom")
                                    {
                                      num11 = this.method_63(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                  case 2433475627:
                                    if (s == "HDChaySeeding")
                                    {
                                      num11 = this.method_91(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                      break;
                                    }
                                    break;
                                }
                              }
                              else
                              {
                                if (num12 <= 3102074063U)
                                {
                                  switch (num12)
                                  {
                                    case 2437988220:
                                      if (s == "HDMoiBanBeLikePage")
                                      {
                                        num11 = this.method_61(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 2540878680:
                                      if (s == "HDThamGiaNhomTuKhoa")
                                      {
                                        num11 = this.method_73(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 2550743232:
                                      if (s == "HDTuongTacWall")
                                      {
                                        num11 = this.method_106(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 2553440797:
                                      if (s == "HDCapNhatThongTin")
                                      {
                                        num11 = this.method_59(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 2821037716:
                                      if (s == "HDHuyKetBan")
                                      {
                                        num11 = this.method_84(int_4, string_0_1, gclass27_0, gclass22_0_1, str4, str5, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 2862981448:
                                      if (s == "HDCauHinhTaiKhoan")
                                      {
                                        num11 = this.method_56(int_4, string_0_1, gclass27_0, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 2924758840:
                                      if (s == "HDMoiBanBeVaoNhom")
                                      {
                                        num11 = this.method_62(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 2944435598:
                                      if (s == "HDThamGiaNhomUid")
                                      {
                                        num11 = this.method_131(int_4, string_0_1, gclass27_0, gclass22_0_1, str9, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 3010844127:
                                      if (s == "HDXoaReel")
                                      {
                                        num11 = this.method_78(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9, str5);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 3035546143:
                                      if (s == "HDTuongTacNewsfeed")
                                      {
                                        num11 = this.method_105(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 3094399544:
                                      if (s == "HDDongBoDanhBa")
                                      {
                                        num11 = this.method_48(int_4, string_0_1, gclass27_0, gclass22_0_1, str9, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 3099572506:
                                      if (s == "HDDangXuatThietBiCu")
                                      {
                                        num11 = this.method_52(int_4, string_0_1, gclass27_0, str8);
                                        goto label_207;
                                      }
                                      else
                                        goto label_207;
                                    case 3102074063:
                                      if (!(s == "HDTuongTacVideo"))
                                        goto label_207;
                                      else
                                        break;
                                    default:
                                      goto label_207;
                                  }
                                }
                                else
                                {
                                  if (num12 <= 3671364376U)
                                  {
                                    switch (num12)
                                    {
                                      case 3182739171:
                                        if (s == "HDTuongTacBaiVietChiDinh")
                                        {
                                          num11 = this.method_111(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                          break;
                                        }
                                        break;
                                      case 3255732838:
                                        if (s == "HDDoiMatKhau")
                                        {
                                          num11 = this.method_57(ref int_4_3, int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                          break;
                                        }
                                        break;
                                      case 3375859832:
                                        if (s == "HDDanhGiaPage")
                                        {
                                          num11 = this.method_116(int_4, string_0_1, gclass27_0, gclass22_0_1, str9, str8);
                                          break;
                                        }
                                        break;
                                      case 3495710863:
                                        if (s == "HDShareBaiNangCao")
                                        {
                                          num11 = this.method_60(int_4, string_0_1, gclass27_0, gclass22_0_1, str9, str8);
                                          num1 = num11;
                                          break;
                                        }
                                        break;
                                      case 3503341118:
                                        if (s == "HDTuongTacNhom")
                                        {
                                          num11 = this.method_114(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                          break;
                                        }
                                        break;
                                      case 3609367991:
                                        if (s == "HDAddMail")
                                        {
                                          num11 = this.method_50(ref int_4_1, ref int_5_1, ref int_6, int_4, string_0_1, gclass27_0, gclass22_0_1, str9, str8);
                                          if (int_4_1 == 7)
                                            this.bool_0 = true;
                                          break;
                                        }
                                        break;
                                      case 3671364376:
                                        if (s == "HDThamGiaNhomGoiY")
                                        {
                                          num11 = this.method_74(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                          break;
                                        }
                                        break;
                                    }
                                  }
                                  else if (num12 <= 4033341327U)
                                  {
                                    if (num12 != 3677432718U)
                                    {
                                      switch (num12)
                                      {
                                        case 3877387086:
                                          if (!(s == "HDTuongTacLivestream"))
                                            goto label_207;
                                          else
                                            goto label_204;
                                        case 4033341327:
                                          if (s == "HDVerifyAccount")
                                          {
                                            num11 = this.method_51(ref int_4_2, int_4, string_0_1, gclass27_0, gclass22_0_1, str9, str8);
                                            if (int_4_2 == 8)
                                            {
                                              int_4_2 = 0;
                                              this.method_185(int_4, "Checkpoint", gclass27_0);
                                              this.method_184(int_4, string_0_1 + "Checkpoint!");
                                              num6 = 1;
                                              goto label_249;
                                            }
                                            else
                                              goto label_207;
                                          }
                                          else
                                            goto label_207;
                                        default:
                                          goto label_207;
                                      }
                                    }
                                    else if (s == "HDDangStory")
                                      num11 = this.method_120(ref int_4_6, int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                  }
                                  else
                                  {
                                    switch (num12)
                                    {
                                      case 4062736188:
                                        if (s == "HDXoaSdt")
                                        {
                                          num11 = this.method_55(int_4, string_0_1, gclass27_0, str8);
                                          num4 = num11;
                                          break;
                                        }
                                        break;
                                      case 4080982511:
                                        if (s == "HDTuongTacPage")
                                        {
                                          num11 = this.method_115(int_4, string_0_1, gclass27_0, gclass22_0_1, str9, str8);
                                          break;
                                        }
                                        break;
                                      case 4095834327:
                                        if (s == "HDXacNhanKetBan")
                                        {
                                          num11 = this.method_96(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                                          break;
                                        }
                                        break;
                                      case 4189681400:
                                        if (s == "HDSpamBaiViet")
                                        {
                                          num11 = this.method_121(int_4, string_0_1, gclass27_0, gclass22_0_1, str8, str9);
                                          break;
                                        }
                                        break;
                                    }
                                  }
                                  goto label_207;
                                }
label_204:
                                num11 = this.method_94(int_4, string_0_1, gclass27_0, gclass22_0_1, str8);
                              }
                            }
                            catch (Exception ex)
                            {
                              GClass19.smethod_81(ex, dataTable2.Rows[0]["TenTuongTac"].ToString());
                            }
                          }
                          catch (Exception ex)
                          {
                            GClass19.smethod_81(ex, "Tuong tac theo kich ban");
                          }
label_207:
                          switch (num11)
                          {
                            case -5:
                              goto label_208;
                            case -4:
                              goto label_209;
                            case -2:
                              goto label_249;
                            default:
                              ++index;
                              continue;
                          }
                        }
                        else
                          goto label_78;
                      }
                      else
                        break;
                    }
                    else
                      goto label_210;
                  }
                  this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đã dừng!"));
                  num6 = 1;
                  goto label_240;
label_78:
                  num6 = 1;
                  goto label_240;
label_208:
                  flag2 = true;
                  goto label_212;
label_209:
                  flag1 = true;
                  goto label_212;
label_210:
                  if (num1 > -1)
                  {
                    this.method_184(int_4, string_0_1 + string.Format("Share success {0}!", (object) num1));
                    num6 = 1;
                    this.method_186(int_4, "cInteractEnd", (object) DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    Class42.smethod_13(string_0_2, "interactEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                  }
label_212:
                  if (GClass33.smethod_0("configInteractGeneral").method_4("ckbCapNhatThongTin"))
                  {
                    this.method_184(int_4, string_0_1 + "Check info...");
                    this.method_47(gclass27_0, int_4, string_0_1 + "Check info...", str5, GClass33.smethod_0("configInteractGeneral"));
                  }
                  if (GClass33.smethod_0("configInteractGeneral").method_4("ckbCongKhaiThongTin"))
                  {
                    this.method_184(int_4, string_0_1 + "Public info account...");
                    this.method_46(gclass27_0, int_4, string_0_1 + "Public info account...");
                  }
                  if (GClass33.smethod_0("configInteractGeneral").method_4("ckbLogOut"))
                    ;
                  if (GClass33.smethod_0("configInteractGeneral").method_4("ckbCheckGoiYKetBan"))
                  {
                    if (int_4_5 == 0)
                    {
                      this.method_184(int_4, string_0_1 + GClass35.smethod_0("Check gợi ý kết bạn") + "...");
                      this.method_215(gclass27_0, int_4, string_0_1, "fb://faceweb/f?href=https://m.facebook.com/friends/center/suggestions/");
                      int_4_5 = gclass27_0.method_29(10, "", new List<string>()
                      {
                        "//*[@text='No Suggestions Available']",
                        "//android.widget.Button[contains(@text, \"as a friend\")]"
                      }) == "//android.widget.Button[contains(@text, \"as a friend\")]" ? 1 : 2;
                      this.method_184(int_4, string_0_1 + GClass35.smethod_0("Check gợi ý kết bạn") + ": " + (int_4_5 == 1 ? "Yes" : "No") + "!");
                      goto label_240;
                    }
                    else
                      goto label_240;
                  }
                  else
                  {
                    int_4_5 = 0;
                    goto label_240;
                  }
                }
label_223:
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đã dừng!"));
                num6 = 1;
                goto label_240;
label_224:
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Reg Tiktok..."));
                if (gclass27_0.method_136("", "", "", "") == 1)
                {
                  this.method_184(int_4, string_0_1 + GClass35.smethod_0("Reg Tiktok success!"));
                  this.method_194(int_4, 2);
                }
                else
                {
                  this.method_184(int_4, string_0_1 + GClass35.smethod_0("Reg Tiktok fail!"));
                  this.method_194(int_4, 1);
                }
                num6 = 1;
                goto label_240;
label_228:
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Reg Instagram..."));
                switch (gclass27_0.method_137(str1, string_12, string_13))
                {
                  case 1:
                    this.method_184(int_4, string_0_1 + GClass35.smethod_0("Reg Instagram success!"));
                    this.method_194(int_4, 2);
                    break;
                  case 3:
                    this.method_184(int_4, string_0_1 + GClass35.smethod_0("Reg Instagram fail: Tài khoản đã tồn tại!"));
                    this.method_194(int_4, 1);
                    break;
                  default:
                    this.method_184(int_4, string_0_1 + GClass35.smethod_0("Reg Instagram fail!"));
                    this.method_194(int_4, 1);
                    break;
                }
                num6 = 1;
                goto label_240;
label_233:
                this.method_184(int_4, string_0_1 + "Backup group...");
                List<string> contents = Class38.smethod_1(gclass27_0.method_114().Split('|')[1], gclass27_0.string_8, gclass27_0.int_1, gclass22_0.method_4("ckbCheckNhomKiemDuyet"));
                File.WriteAllLines("backupgroup\\" + str1 + ".txt", (IEnumerable<string>) contents);
                this.method_184(int_4, string_0_1 + string.Format("Backup group success: {0}!", (object) contents.Count));
                this.method_187(int_4, "cGroup", contents.Count.ToString(), "groups");
                num6 = 1;
                goto label_240;
label_234:
                if (int_5 == 2)
                  gclass27_0.Cleardata(gclass27_0.string_5);
                num6 = 1;
                goto label_240;
label_237:
                this.method_45(int_4, string_0_1, gclass27_0);
                num6 = 1;
label_240:
                goto label_249;
              }
label_244:
              this.method_184(int_4, string_0_1 + "Change info device...");
              if (gclass27_0.method_92(str1))
              {
                this.method_184(int_4, string_0_1 + "Change info device success!");
                this.method_187(int_4, "cDevice", gclass27_0.string_9, "device");
                goto label_47;
              }
              else
              {
                this.method_184(int_4, string_0_1 + "Change info device fail!");
                num6 = 1;
                goto label_249;
              }
            }
          }
label_46:;
        }
      }
      catch (Exception ex)
      {
        if (!ex.ToString().Contains("Thread was being aborted."))
        {
          this.method_184(int_4, string_0_1 + GClass35.smethod_0("Lỗi không xác định!"));
          num6 = 1;
          GClass19.smethod_79((GClass18) null, ex, GClass35.smethod_0("Lỗi không xác định!"));
        }
      }
label_249:
      string str10 = "";
      if (num6 == 1)
        str10 = this.method_189(int_4);
      else if (this.method_21(str1) && Class38.smethod_17(str1).StartsWith("0|"))
      {
        this.method_185(int_4, "Die");
        str10 = GClass35.smethod_0("Tài khoản Die!");
      }
      if (int_5 != 2)
      {
        if (flag3)
        {
          this.method_184(int_4, string_0_1 + GClass35.smethod_0("Backup data Fb..."));
          gclass27_0.method_96(str1);
          Class42.smethod_13(string_0_2, "profile", "Yes");
          this.method_186(int_4, "cProfile", (object) "Yes");
          this.method_184(int_4, string_0_1 + GClass35.smethod_0("Backup data Fb xong!"));
          if (!File.Exists(GClass13.smethod_0() + "\\device\\" + str1 + ".tar.gz"))
            gclass27_0.method_94(str1);
        }
        if (int_5 == 1)
        {
          gclass27_0.Openapp(gclass27_0.string_5);
        }
        else
        {
          gclass27_0.Cleardata("com.facebook.katana");
          gclass27_0.CMD("shell input keyevent 3");
          gclass27_0.RemoveProxy();
        }
      }
      else
        gclass27_0.method_86(gclass27_0.string_5);
      string str11 = "";
      if (int_4_2 != 0)
      {
        string str12 = "";
        switch (int_4_2)
        {
          case 1:
            str12 = "Success";
            break;
          case 2:
            str12 = "Fail";
            break;
          case 3:
            str12 = "Fail (Sai pass)";
            break;
          case 4:
            str12 = "Fail (No OTP)";
            break;
          case 5:
            str12 = "Fail (Cannot connect Mail)";
            break;
          case 6:
            str12 = "Fail (Không có tùy chọn Add mail)";
            break;
          case 7:
            str12 = "Fail (Hết mail)";
            break;
        }
        str11 = str11 + "-Verify " + str12;
      }
      if (int_4_1 != 0)
      {
        string str13 = "";
        switch (int_4_1)
        {
          case 1:
            str13 = "Success";
            break;
          case 2:
            str13 = "Fail";
            break;
          case 3:
            str13 = "Fail (Sai pass)";
            this.method_185(int_4, "Changed pass", gclass27_0);
            break;
          case 4:
            str13 = "Fail (No OTP)";
            break;
          case 5:
            str13 = "Fail (Cannot connect Mail)";
            break;
          case 6:
            str13 = "Fail (Không có tùy chọn Add mail)";
            break;
          case 7:
            str13 = "Fail (Hết mail)";
            break;
          case 8:
            str13 = "Fail (No pass)";
            break;
        }
        str11 = str11 + "-Add Mail " + str13;
      }
      if (int_5_1 != 0)
      {
        string str14 = "";
        switch (int_5_1)
        {
          case 1:
            str14 = "Success";
            break;
          case 2:
            str14 = "Fail";
            break;
        }
        str11 = str11 + "-Set Primary Mail " + str14;
      }
      if (int_6 != 0)
      {
        string str15 = "";
        switch (int_6)
        {
          case 1:
            str15 = "Success";
            break;
          case 2:
            str15 = "Fail";
            break;
        }
        str11 = str11 + "-Remove Mail " + str15;
      }
      if (int_4_3 != 0)
      {
        string str16 = "";
        switch (int_4_3)
        {
          case 1:
            str16 = "Success";
            break;
          case 2:
            str16 = "Fail";
            break;
          case 3:
            str16 = "Fail (Sai pass)";
            this.method_185(int_4, "Changed pass", gclass27_0);
            break;
          case 4:
            str16 = "Fail (Lỗi Internet)";
            break;
          case 5:
            str16 = "Fail (Pass mới giống pass cũ)";
            break;
        }
        str11 = str11 + "-Change Pass " + str16;
      }
      if (int_4_4 != 0)
      {
        string str17 = "";
        switch (int_4_4)
        {
          case 1:
            str17 = "Success";
            break;
          case 2:
            str17 = "Fail";
            break;
          case 3:
            str17 = "Fail (Sai pass)";
            this.method_185(int_4, "Changed pass", gclass27_0);
            break;
          case 4:
            str17 = "Fail (You can't change your name on Facebook right now)";
            break;
          case 5:
            str17 = "Fail (Something went wrong)";
            break;
        }
        str11 = str11 + "-Đổi tên " + str17;
      }
      if (num2 != 0)
      {
        string str18 = "";
        switch (num2)
        {
          case 1:
            str18 = "Success";
            break;
          case 2:
            str18 = "Fail";
            break;
        }
        str11 = str11 + "-Up avatar " + str18;
      }
      if (num3 != 0)
      {
        string str19 = "";
        switch (num3)
        {
          case 1:
            str19 = "Success";
            break;
          case 2:
            str19 = "Fail";
            break;
        }
        str11 = str11 + "-Up cover " + str19;
      }
      if (num5 != 0)
      {
        string str20 = "";
        switch (num5)
        {
          case 1:
            str20 = "-Bật 2FA Success";
            break;
          case 2:
            str20 = "-Bật 2FA Fail";
            break;
          case 3:
            str20 = "-Sai pass";
            this.method_185(int_4, "Changed pass", gclass27_0);
            break;
          case 4:
            str20 = "-Bật 2FA Fail (Đã có 2fa)";
            break;
          case 5:
            str20 = "-Bật 2FA Fail (otp từ 2fa sai)";
            break;
          case 6:
            str20 = "-Tắt 2FA Success";
            break;
        }
        str11 += str20;
      }
      if (num4 != 0)
      {
        string str21 = "";
        switch (num4)
        {
          case 1:
            str21 = "Success";
            break;
          case 2:
            str21 = "Fail";
            break;
          case 3:
            str21 = "Fail (Sai pass)";
            this.method_185(int_4, "Changed pass", gclass27_0);
            break;
          case 4:
            str21 = "Fail (Chưa có mail)";
            break;
          case 5:
            str21 = "Fail (This content is no longer available)";
            break;
        }
        str11 = str11 + "-Xóa Sđt " + str21;
      }
      if (int_4_5 != 0)
      {
        string str22 = "";
        switch (int_4_5)
        {
          case 1:
            str22 = "Yes";
            break;
          case 2:
            str22 = "No";
            break;
        }
        str11 = str11 + "- Gợi ý kết bạn: " + str22;
      }
      if (int_4_6 != 0 && int_4_6 == 2)
        str11 += "- Đăng story fail: Không tìm thấy";
      if (!(str10 == ""))
      {
        int int_4_8 = int_4;
        string[] strArray = new string[5]
        {
          string_0_1,
          str10,
          null,
          null,
          null
        };
        string str23;
        if (!(str10 == ""))
          str23 = str11;
        else
          str23 = str11.TrimStart('-');
        strArray[2] = str23;
        strArray[3] = flag2 ? "- Lỗi mở link" : "";
        strArray[4] = flag1 ? "- Facebook blocked" : "";
        string string_0_3 = string.Concat(strArray);
        this.method_184(int_4_8, string_0_3);
      }
      else
      {
        this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đã tương tác xong!") + (flag2 ? "- Lỗi mở link" : "") + (flag1 ? "- Facebook blocked" : "") + str11 + " [" + gclass6.method_1() + "(s)]");
        this.method_187(int_4, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
        if (this.method_190(int_4) != "Changed pass")
          this.method_185(int_4, "Live");
      }
      if (this.method_189(int_4).Contains("Internet"))
      {
        if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") != 15)
        {
          gclass27_0.method_156();
          gclass27_0.method_157();
        }
        else
          gclass27_0.method_160();
      }
      lock (this.object_1)
      {
        switch (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp"))
        {
          case 7:
            if (class46 != null)
            {
              class46.method_1();
              break;
            }
            break;
          case 8:
            if (gclass25 != null)
            {
              gclass25.method_3(GClass33.smethod_0("configGeneral").method_3("typeRunXproxy"));
              break;
            }
            break;
          case 10:
            if (class47 != null)
            {
              class47.method_2();
              break;
            }
            break;
          case 11:
            if (class6 != null)
            {
              class6.method_1();
              break;
            }
            break;
          case 12:
            if (class7 != null)
            {
              class7.method_0();
              break;
            }
            break;
          case 13:
            if (class4 != null)
            {
              class4.method_2();
              break;
            }
            break;
          case 14:
            if (gclass10 != null)
            {
              gclass10.method_3();
              break;
            }
            break;
        }
      }
      this.list_1.Remove(Thread.CurrentThread.Name.ToString());
    }
    catch (Exception ex1)
    {
      if (!ex1.ToString().Contains("Thread was being aborted."))
        return;
      try
      {
        if (flag3)
        {
          this.method_184(int_4, string_0_1 + GClass35.smethod_0("Backup data Fb..."));
          gclass27_0.method_96(str1);
          Class42.smethod_13(string_0_2, "profile", "Yes");
          this.method_186(int_4, "cProfile", (object) "Yes");
        }
        gclass27_0.Cleardata("com.facebook.katana");
        gclass27_0.CMD("shell input keyevent 3");
        this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đã tương tác xong!") + (flag2 ? "- Lỗi mở link" : "") + (flag1 ? "- Facebook blocked" : "") + " [" + gclass6.method_1() + "(s)]");
        this.method_187(int_4, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
        lock (this.object_1)
        {
          switch (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp"))
          {
            case 7:
              if (class46 != null)
              {
                class46.method_1();
                break;
              }
              break;
            case 8:
              if (gclass25 != null)
              {
                gclass25.method_3(GClass33.smethod_0("configGeneral").method_3("typeRunXproxy"));
                break;
              }
              break;
            case 10:
              if (class47 != null)
              {
                class47.method_2();
                break;
              }
              break;
            case 11:
              if (class6 != null)
              {
                class6.method_1();
                break;
              }
              break;
            case 12:
              if (class7 != null)
              {
                class7.method_0();
                break;
              }
              break;
            case 13:
              if (class4 != null)
              {
                class4.method_2();
                break;
              }
              break;
            case 14:
              if (gclass10 != null)
              {
                gclass10.method_3();
                break;
              }
              break;
          }
        }
        this.list_1.Remove(Thread.CurrentThread.Name.ToString());
      }
      catch (Exception ex2)
      {
      }
    }
  }

  internal Tuple<int, string> method_34(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    if (string0.Contains("facebook.com/reel/"))
      return new Tuple<int, string>(0, "Không dùng được với link reel!");
    try
    {
      int num = ((IEnumerable<string>) "like,love,care,haha,wow,sad,angry".Split(',')).ToList<string>().IndexOf(gclass32_0.String_2) + 1;
      string string_11_1 = num.ToString();
      this.method_184(int_4, string_0 + GClass35.smethod_0("Mở bài viết..."));
      if (this.method_76(gclass27_0, int_4, string_0, string0) != 1)
        return new Tuple<int, string>(0, "Lỗi mở link!");
      for (int index = 0; index < 5; ++index)
      {
        this.method_184(int_4, string_0 + "Find Like...");
        string string_11_2 = gclass27_0.method_53();
        if (gclass27_0.method_31(0, string_11_2, "//*[@content-desc=\"Make a post on Facebook\"]"))
          return new Tuple<int, string>(0, "Lỗi thả cảm xúc!");
        List<string> source = gclass27_0.method_40(0, string_11_2, new List<string>()
        {
          "//*[@content-desc=\"Like button. Double tap and hold to react.\"]",
          "//*[@content-desc=\"Like Button\"]",
          "//*[@content-desc='Like']"
        });
        int int_4_1 = int_4;
        string str1 = string_0;
        num = source.Count;
        string str2 = num.ToString();
        string string_0_1 = str1 + "Find Like: " + str2;
        this.method_184(int_4_1, string_0_1);
        if (source.Count > 0)
        {
          if (gclass27_0.method_22() == "com.facebook.video.activity.DeprecatedFullscreenVideoPlayerActivity")
          {
            string string_0_2 = source.First<string>();
            Point point1 = new Class77(string_0_2).method_4();
            Point point2 = new Class77("[35," + string_0_2.Split(new string[3]
            {
              "[",
              ",",
              "]"
            }, StringSplitOptions.RemoveEmptyEntries)[1] + "][65," + string_0_2.Split(new string[3]
            {
              "[",
              ",",
              "]"
            }, StringSplitOptions.RemoveEmptyEntries)[3] + "]").method_4();
            this.method_184(int_4, string_0 + "Tap Reaction...");
            gclass27_0.method_73(point1.X, point1.Y, point2.X, point2.Y);
            gclass27_0.method_80(1.0, 1.5);
            gclass27_0.method_113(string_11_1);
            gclass27_0.method_80(1.0, 1.5);
            return new Tuple<int, string>(1, "");
          }
          Point point = gclass27_0.method_74(source.First<string>());
          if (gclass27_0.method_146(string_11_2, "Create a reel") && gclass27_0.method_55(point.X, point.Y) || gclass27_0.method_72(point.X, point.Y) && gclass27_0.method_113(string_11_1))
            return new Tuple<int, string>(1, "");
        }
        this.method_184(int_4, string_0 + "Scroll...");
        if (gclass27_0.method_78() && !gclass27_0.method_104())
          break;
      }
    }
    catch
    {
    }
    return new Tuple<int, string>(0, "Lỗi thả cảm xúc!");
  }

  internal Tuple<int, string> method_35(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
      this.method_184(int_4, string_0 + GClass35.smethod_0("Mở bài viết..."));
      if (this.method_76(gclass27_0, int_4, string_0, string0) != 1)
        return new Tuple<int, string>(0, "Lỗi mở link!");
      gclass27_0.method_61(5, "//*[contains(@content-desc,'Play')]", "");
      this.method_184(int_4, string_0 + GClass35.smethod_0("Xem video {time}s..."), 5);
      return new Tuple<int, string>(1, "");
    }
    catch
    {
    }
    return new Tuple<int, string>(0, "Lỗi view video!");
  }

  internal Tuple<int, string> method_36(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
      this.method_184(int_4, string_0 + GClass35.smethod_0("Mở bài viết..."));
      if (this.method_76(gclass27_0, int_4, string_0, string0) != 1)
        return new Tuple<int, string>(0, "Lỗi mở link!");
      this.method_184(int_4, string_0 + GClass35.smethod_0("Xem reel {time}s..."), 5);
      return new Tuple<int, string>(1, "");
    }
    catch
    {
    }
    return new Tuple<int, string>(0, "Lỗi vew reel!");
  }

  internal Tuple<int, string> method_37(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
      this.method_184(int_4, string_0 + GClass35.smethod_0("Mở bài viết..."));
      if (this.method_76(gclass27_0, int_4, string_0, string0) != 1)
        return new Tuple<int, string>(0, "Lỗi mở link!");
      string string_11 = "";
      if (!gclass27_0.method_33(60, ref string_11, "(//*[@text='Stories'])[2]"))
        return new Tuple<int, string>(0, "Không load được story!");
      if (!gclass27_0.method_61(10, "//*[@text='Tap to view story']", string_11))
        return new Tuple<int, string>(0, "Không tìm thấy [Tap to view story]!");
      this.method_184(int_4, string_0 + GClass35.smethod_0("Xem story..."));
      if (gclass27_0.method_61(3, "//*[@text='Play Video']", "") && gclass27_0.method_55(700, 1400))
        ;
      this.method_184(int_4, string_0 + GClass35.smethod_0("Xem story {time}s..."), 1);
      return new Tuple<int, string>(1, "");
    }
    catch
    {
    }
    return new Tuple<int, string>(0, "Lỗi view story!");
  }

  private Tuple<int, string> method_38(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
      string string3 = gclass32_0.String_3;
      this.method_184(int_4, string_0 + GClass35.smethod_0("Mở bài viết..."));
      if (this.method_76(gclass27_0, int_4, string_0, string0) != 1)
        return new Tuple<int, string>(0, "Lỗi mở link!");
      for (int index1 = 0; index1 < 5; ++index1)
      {
        this.method_184(int_4, string_0 + "Find Comment...");
        string string_11_1 = gclass27_0.method_53();
        List<string> source = gclass27_0.method_40(0, string_11_1, new List<string>()
        {
          "//*[@content-desc=\"Comment Button\"]",
          "//*[@content-desc=\"Answer Button\"]",
          "//*[@text='Answer']",
          "//*[@text=\"Comment\"]",
          "//*[@content-desc=\"Comment\"]",
          "//android.widget.EditText[@resource-id='composerInput']"
        });
        this.method_184(int_4, string_0 + "Find Comment: " + source.Count.ToString());
        if (source.Count > 0)
        {
          Point point = gclass27_0.method_74(source.Last<string>());
          this.method_184(int_4, string_0 + "Tap Comment...");
          if (gclass27_0.method_55(point.X, point.Y))
          {
            gclass27_0.method_80(1.0, 2.0);
            for (int index2 = 0; index2 < 2; ++index2)
            {
              this.method_184(int_4, string_0 + "Find EditText...");
              if (!gclass27_0.method_31(5, "", "//android.widget.EditText"))
              {
                if (!gclass27_0.method_60("//android.widget.LinearLayout[@content-desc=\"Comment input box\"]"))
                  break;
              }
              else
              {
                this.method_184(int_4, string_0 + GClass35.smethod_0("Nhập dữ liệu..."));
                gclass27_0.method_50("//android.widget.EditText", string3);
                gclass27_0.method_80(1.0, 2.0);
                this.method_184(int_4, string_0 + "Tap Send...");
                string string_11_2 = "";
                string string_11_3 = gclass27_0.method_30(5, ref string_11_2, new List<string>()
                {
                  "//*[@content-desc=\"Send\"]",
                  "//*[@text='Post']"
                });
                if (gclass27_0.method_60(string_11_3, string_11_2))
                {
                  this.method_184(int_4, string_0 + "Tap Send, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(3, 6));
                  gclass27_0.method_42(120);
                }
                return new Tuple<int, string>(1, "");
              }
            }
          }
        }
        this.method_184(int_4, string_0 + "Scroll...");
        if (gclass27_0.method_78() && !gclass27_0.method_104())
          break;
      }
    }
    catch
    {
    }
    return new Tuple<int, string>(0, "Lỗi comment!");
  }

  private Tuple<int, string> method_39(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
      this.method_184(int_4, string_0 + GClass35.smethod_0("Mở bài viết..."));
      if (this.method_76(gclass27_0, int_4, string_0, string0) != 1)
        return new Tuple<int, string>(0, "Lỗi mở link!");
      int tickCount = Environment.TickCount;
      string str;
      string string_11;
      do
      {
        str = gclass27_0.method_53();
        string_11 = gclass27_0.method_29(0, str, new List<string>()
        {
          "//*[@content-desc=\"Share Button\"]",
          "//*[@text=\"Share\"]",
          "//*[@content-desc=\"Share\"]",
          "//*[@content-desc=\"Share Now\"]",
          "//*[@content-desc='Write Post']",
          "//*[@content-desc='POST']"
        });
        switch (string_11)
        {
          case "//*[@content-desc=\"Share Button\"]":
          case "//*[@text=\"Share\"]":
          case "//*[@content-desc=\"Share\"]":
          case "//*[@content-desc='Write Post']":
            this.method_184(int_4, string_0 + "Tap " + gclass27_0.method_151(string_11) + "...");
            gclass27_0.method_60(string_11, str);
            break;
          case "//*[@content-desc=\"Share Now\"]":
          case "//*[@content-desc='POST']":
            goto label_6;
          default:
            this.method_184(int_4, string_0 + "Scroll...");
            if (!gclass27_0.method_78() || gclass27_0.method_104())
              break;
            goto label_10;
        }
        gclass27_0.SleepSeconds(2.0);
      }
      while (Environment.TickCount - tickCount < 60000);
      goto label_10;
label_6:
      this.method_184(int_4, string_0 + "Tap " + gclass27_0.method_151(string_11) + "...");
      gclass27_0.method_60(string_11, str);
      gclass27_0.SleepSeconds(5.0);
      return new Tuple<int, string>(1, "");
    }
    catch
    {
    }
label_10:
    return new Tuple<int, string>(0, "Lỗi share!");
  }

  private Tuple<int, string> method_40(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
      string str = Regex.Match(string0, "\\d+").Value;
      this.method_184(int_4, string_0 + "Go to Profile " + str + "...");
      if (!this.method_215(gclass27_0, int_4, string_0, "fb://profile/" + str))
        return new Tuple<int, string>(0, "Lỗi mở link!");
      this.method_184(int_4, string_0 + "Follow Uid...");
      int num = 0;
      int tickCount = Environment.TickCount;
      string string_11_1;
      do
      {
        string_11_1 = "";
        switch (gclass27_0.method_30(10, ref string_11_1, new List<string>()
        {
          "//*[@content-desc='Follow']",
          "//*[@content-desc='Following']",
          "//*[@content-desc='More']"
        }))
        {
          case "//*[@content-desc='Follow']":
            if (num <= 2)
            {
              ++num;
              gclass27_0.method_60("//*[@content-desc='Follow']", string_11_1);
              break;
            }
            goto label_6;
          case "//*[@content-desc='Following']":
            goto label_8;
          case "//*[@content-desc='More']":
            goto label_11;
        }
        gclass27_0.SleepSeconds(2.0);
      }
      while (Environment.TickCount - tickCount <= 30000);
      goto label_23;
label_6:
      return new Tuple<int, string>(0, "Fb báo lỗi khi nhấn Follow!");
label_8:
      return num > 0 ? new Tuple<int, string>(1, "") : new Tuple<int, string>(0, "Đã follow trước đó!");
label_11:
      if (gclass27_0.method_61(0, "//*[@content-desc=\"More\"]", string_11_1))
      {
        do
        {
          Bitmap bitmap_0 = (Bitmap) null;
          string string_11_2 = gclass27_0.method_128(10, ref bitmap_0, new List<string>()
          {
            "dataimage\\following",
            "dataimage\\follow"
          });
          switch (string_11_2)
          {
            case "dataimage\\following":
              goto label_17;
            case "dataimage\\follow":
              if (num <= 2)
              {
                ++num;
                gclass27_0.method_123(string_11_2, bitmap_0);
                gclass27_0.SleepSeconds(2.0);
                continue;
              }
              goto label_15;
            default:
              goto label_16;
          }
        }
        while (Environment.TickCount - tickCount <= 30000);
        goto label_20;
label_15:
        return new Tuple<int, string>(0, "Fb báo lỗi khi nhấn Follow!");
label_16:
        return new Tuple<int, string>(0, "Fb không hiện nút Follow!");
label_17:
        return num > 0 ? new Tuple<int, string>(1, "") : new Tuple<int, string>(0, "Đã follow trước đó!");
      }
label_20:
      return new Tuple<int, string>(0, "Fb không hiện nút Follow!");
    }
    catch
    {
    }
label_23:
    return new Tuple<int, string>(0, "Lỗi follow!");
  }

  private Tuple<int, string> method_41(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
label_10:
      this.method_184(int_4, string_0 + "Go to Page " + string0 + "...");
      if (!this.method_215(gclass27_0, int_4, string_0, "fb://" + (!string0.StartsWith("1000") ? "page" : "profile") + "/" + string0))
        return new Tuple<int, string>(0, "Lỗi mở link page!");
      int tickCount = Environment.TickCount;
      int num = 10;
      string str;
      string string_11;
      do
      {
        this.method_184(int_4, string_0 + "Find Like...");
        str = gclass27_0.method_53();
        string_11 = gclass27_0.method_29(0, str, new List<string>()
        {
          "//android.view.ViewGroup[@content-desc='Liked']",
          "//android.view.ViewGroup[@content-desc='Following']",
          "//android.view.ViewGroup[@content-desc='Like']",
          "//android.view.ViewGroup[@content-desc='like button']/android.view.ViewGroup",
          "//android.view.ViewGroup[@content-desc='like button']",
          "//android.view.ViewGroup[@content-desc='Follow']"
        });
        switch (string_11)
        {
          case "//android.view.ViewGroup[@content-desc='Like']":
          case "//android.view.ViewGroup[@content-desc='like button']/android.view.ViewGroup":
          case "//android.view.ViewGroup[@content-desc='like button']":
          case "//android.view.ViewGroup[@content-desc='Follow']":
            goto label_5;
          case "//android.view.ViewGroup[@content-desc='Liked']":
          case "//android.view.ViewGroup[@content-desc='Following']":
            goto label_6;
          default:
            this.method_184(int_4, string_0 + "Scroll...");
            if (gclass27_0.method_78(-1))
            {
              switch (this.method_32(gclass27_0, int_4, string_0))
              {
                case 0:
                  break;
                case 1:
                  goto label_10;
                default:
                  goto label_12;
              }
            }
            gclass27_0.SleepSeconds(1.0);
            continue;
        }
      }
      while (Environment.TickCount - tickCount < num * 1000);
      goto label_12;
label_5:
      this.method_184(int_4, string_0 + "Tap " + gclass27_0.method_151(string_11) + "...");
      gclass27_0.method_60(string_11, str);
      this.method_184(int_4, string_0 + "Tap Like, " + GClass35.smethod_0("đợi") + " {time}s...", 3);
      return new Tuple<int, string>(1, "");
label_6:
      return new Tuple<int, string>(0, "Đã like trước đó!");
    }
    catch
    {
    }
label_12:
    return new Tuple<int, string>(0, "Lỗi like page!");
  }

  private Tuple<int, string> method_42(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
      this.method_184(int_4, string_0 + "Go to Group " + string0 + "...");
      if (!this.method_215(gclass27_0, int_4, string_0, "fb://group/" + string0))
        return new Tuple<int, string>(0, "Lỗi mở link group!");
      this.method_184(int_4, string_0 + "Find Join...");
      string string_11 = "";
      string str = "";
      for (int index = 0; index < 2; ++index)
      {
        str = gclass27_0.method_30(5, ref string_11, new List<string>()
        {
          "//android.view.ViewGroup[@content-desc=\"Cancel Request\"]",
          "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]",
          "//*[starts-with(@content-desc, 'Join ')]"
        });
        if (!(str != ""))
        {
          gclass27_0.method_76(-1);
          gclass27_0.SleepSeconds(1.0);
        }
        else
          break;
      }
      if (str == "//*[starts-with(@content-desc, 'Join ')]")
      {
        this.method_184(int_4, string_0 + "Tap Join...");
        gclass27_0.method_61(0, "//*[starts-with(@content-desc, 'Join ')]", string_11);
        return new Tuple<int, string>(1, "");
      }
    }
    catch
    {
    }
    return new Tuple<int, string>(0, "Lỗi Join nhóm!");
  }

  private Tuple<int, string> method_43(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass32 gclass32_0)
  {
    string string0 = gclass32_0.String_0;
    try
    {
      string string3 = gclass32_0.String_3;
      string str1 = "";
label_66:
      while (true)
      {
        GClass27 gclass27;
        // ISSUE: variable of a reference type
        string& local;
        List<string> list_0;
        do
        {
          this.method_184(int_4, string_0 + "Go to Page " + string0 + "...");
          if (this.method_215(gclass27_0, int_4, string_0, "fb://" + (!string0.StartsWith("1000") ? "page" : "profile") + "/" + string0))
          {
            this.method_184(int_4, string_0 + "Review Page...");
            gclass27 = gclass27_0;
            local = ref str1;
            list_0 = new List<string>();
            list_0.Add("//android.widget.TextView[contains(@content-desc,\"Reviews, Tab\")]");
            list_0.Add("//*[@content-desc='Posts, tab']");
          }
          else
            goto label_65;
        }
        while (gclass27.method_30(0, ref local, list_0) == "" && !gclass27_0.method_60("//android.widget.Button[@content-desc=\"Cancel\"]", str1));
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 1;
        int tickCount = Environment.TickCount;
        int num6 = 60;
        do
        {
          str1 = gclass27_0.method_53();
          string str2 = gclass27_0.method_29(0, str1, new List<string>()
          {
            "//*[contains(@content-desc,\"Reviews, Tab\")]",
            "//*[contains(@content-desc, \"Home\")]",
            "//*[@content-desc='Posts, tab']",
            "//*[@content-desc='How are ratings calculated?']",
            "//*[@content-desc=\"YES\"]",
            "//android.widget.EditText[starts-with(@text,'What')]",
            "//androidx.recyclerview.widget.RecyclerView/parent::*/parent::*/child::*",
            "//androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup"
          });
          string s = str2;
          // ISSUE: reference to a compiler-generated method
          uint num7 = Class206.smethod_0(s);
          if (num7 > 3483486136U)
          {
            if (num7 <= 3976528780U)
            {
              if (num7 != 3660407778U)
              {
                if (num7 == 3976528780U && s == "//*[@content-desc='How are ratings calculated?']")
                {
                  if (gclass27_0.method_31(0, str1, "//*[@content-desc=\"YES\"]"))
                  {
                    if (num2 < 2)
                    {
                      ++num2;
                      gclass27_0.method_60("//*[@content-desc=\"YES\"]", str1);
                    }
                    else
                      goto label_10;
                  }
                  else
                    goto label_8;
                }
                else
                  goto label_62;
              }
              else if (s == "//*[contains(@content-desc,\"Reviews, Tab\")]")
              {
                if (gclass27_0.method_31(0, str1, "//*[@content-desc=\"YES\"]"))
                  gclass27_0.method_60("//*[@content-desc=\"YES\"]", str1);
                else if (num1 < 2)
                {
                  this.method_184(int_4, string_0 + "Tap " + gclass27_0.method_151(str2) + "...");
                  ++num1;
                  gclass27_0.method_60(str2, str1);
                }
                else
                  goto label_16;
              }
              else
                goto label_62;
            }
            else if (num7 == 4058141664U)
            {
              if (!(s == "//androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup"))
                goto label_62;
              else
                goto label_21;
            }
            else if (num7 != 4186682215U)
            {
              if (num7 == 4283911937U && s == "//android.widget.EditText[starts-with(@text,'What')]")
              {
                for (int index = 0; index < 10; ++index)
                {
                  gclass27_0.method_50("//android.widget.EditText", string3);
                  gclass27_0.SleepSeconds(1.0);
                  if (!gclass27_0.method_60("(//androidx.viewpager.widget.ViewPager//android.view.ViewGroup)[last()]"))
                    gclass27_0.SleepSeconds(1.0);
                  else
                    break;
                }
              }
              else
                goto label_62;
            }
            else if (s == "//*[contains(@content-desc, \"Home\")]")
            {
              string string_11 = gclass27_0.method_37(0, str1, "//*[contains(@content-desc, \"Home\")]").FirstOrDefault<string>();
              if (!string.IsNullOrEmpty(string_11))
              {
                if (num3 < 2)
                {
                  ++num3;
                  Point point = gclass27_0.method_74(string_11);
                  gclass27_0.method_73(point.X + gclass27_0.method_21() / 2, point.Y, point.X, point.Y);
                }
                else
                  goto label_31;
              }
            }
            else
              goto label_62;
          }
          else if (num7 <= 2535497917U)
          {
            if (num7 != 532719482U)
            {
              if (num7 == 2535497917U && s == "//androidx.recyclerview.widget.RecyclerView/parent::*/parent::*/child::*")
                gclass27_0.method_66(gclass27_0.method_37(0, str1, str2).LastOrDefault<string>());
              else
                goto label_62;
            }
            else if (s == "//android.widget.ProgressBar")
            {
              this.method_184(int_4, string_0 + "Loading...");
              if (!gclass27_0.method_42(60))
                goto label_41;
            }
            else
              goto label_62;
          }
          else if (num7 != 2786206699U)
          {
            if (num7 == 3483486136U && s == "//*[@content-desc=\"YES\"]")
            {
              if (num2 < 2)
              {
                ++num2;
                gclass27_0.method_60("//*[@content-desc=\"YES\"]", str1);
              }
              else
                goto label_48;
            }
            else
              goto label_62;
          }
          else if (s == "//*[@content-desc='Posts, tab']")
          {
            bool flag = false;
            int num8 = 0;
            while (true)
            {
              if (num8 < 5)
              {
                int num9;
                if (gclass27_0.method_123("dataimage\\rate"))
                  num9 = !gclass27_0.method_147(30, "", "How are ratings calculated") ? 1 : 0;
                else
                  num9 = 1;
                if (num9 != 0)
                {
                  if (!gclass27_0.method_78())
                    ++num8;
                  else
                    goto label_56;
                }
                else
                  break;
              }
              else
                goto label_60;
            }
            gclass27_0.method_28();
            flag = true;
label_60:
            if (!flag)
              break;
          }
          else
            goto label_62;
label_61:
          gclass27_0.SleepSeconds(1.0);
          continue;
label_62:
          this.method_184(int_4, string_0 + "Scroll...");
          if (gclass27_0.method_78())
          {
            switch (this.method_32(gclass27_0, int_4, string_0))
            {
              case 0:
                goto label_61;
              case 1:
                goto label_66;
              default:
                goto label_68;
            }
          }
          else
            goto label_61;
        }
        while (Environment.TickCount - tickCount < num6 * 1000);
        goto label_68;
label_41:
        if (num4 < num5)
        {
          int num10 = num4 + 1;
        }
        else
          goto label_43;
      }
label_8:
      return new Tuple<int, string>(0, "Đã review trước đó rồi");
label_10:
      return new Tuple<int, string>(0, "Lỗi Click Yes");
label_16:
      return new Tuple<int, string>(0, "Không tìm thấy nút YES");
label_21:
      return new Tuple<int, string>(1, "");
label_31:
      return new Tuple<int, string>(0, "Không tìm thấy nút Review Page");
label_43:
      return new Tuple<int, string>(0, "Không load được trang");
label_48:
      return new Tuple<int, string>(0, "Lỗi Click Yes");
label_56:
      return new Tuple<int, string>(0, "Không tìm thấy nút Review Page");
label_65:
      return new Tuple<int, string>(0, "Lỗi mở link!");
    }
    catch
    {
    }
label_68:
    return new Tuple<int, string>(0, "Lỗi review page " + string0);
  }

  private void method_44(GClass32 gclass32_0, string string_0, GClass27 gclass27_0)
  {
    if (!GClass33.smethod_0("configDebug").method_4("ckbJobSeeding"))
      return;
    lock (this.object_3)
    {
      string string_11 = DateTime.Now.ToString("ddMMyyyy_HHmmss");
      gclass27_0.method_178(string_11);
      File.AppendAllText("logJob.txt", "---------" + string_11 + "---------\r\n");
      File.AppendAllText("logJob.txt", "device: " + gclass27_0.String_2 + "\r\n");
      File.AppendAllText("logJob.txt", "filePath: CheckDevice\\" + gclass27_0.String_2 + "\\" + string_11 + ".png\r\n");
      File.AppendAllText("logJob.txt", "type: " + gclass32_0.String_1 + "\r\n");
      File.AppendAllText("logJob.txt", "object_id: " + gclass32_0.String_0 + "\r\n");
      File.AppendAllText("logJob.txt", "error: " + string_0 + "\r\n");
    }
  }

  private void method_45(int int_4, string string_0, GClass27 gclass27_0)
  {
    try
    {
      if (gclass27_0.method_31(20, "", "//*[@content-desc='Get started']"))
      {
        this.method_185(int_4, "Checkpoint", gclass27_0);
        int num1 = 0;
        int num2 = 6;
        int num3 = 0;
        int num4 = 15;
        string str1 = "";
        int tickCount = Environment.TickCount;
        do
        {
          string str2 = gclass27_0.method_53();
          string string_11 = gclass27_0.method_29(0, str2, new List<string>()
          {
            "//android.widget.ProgressBar",
            "//*[@text='Tap to retry']",
            "//*[@content-desc='Get started']",
            "//*[@content-desc='Next']",
            "//android.widget.EditText[@text='Enter new password']",
            "//*[@content-desc='Save changes']",
            "//*[@content-desc='Close']",
            "//*[@content-desc='Back to Facebook']"
          });
          string s = string_11;
          // ISSUE: reference to a compiler-generated method
          uint num5 = Class206.smethod_0(s);
          if (num5 > 1259562933U)
          {
            if (num5 > 1927859440U)
            {
              int num6;
              switch (num5)
              {
                case 3165355182:
                  if (s == "//*[@content-desc='Get started']")
                    goto label_30;
                  else
                    goto label_31;
                case 3880773775:
                  num6 = !(s == "//*[@content-desc='Close']") ? 1 : 0;
                  break;
                default:
                  num6 = 1;
                  break;
              }
              if (num6 != 0)
                goto label_31;
            }
            else
            {
              int num7;
              switch (num5)
              {
                case 1792698548:
                  if (!(s == "//*[@content-desc='Next']"))
                    goto label_31;
                  else
                    goto label_30;
                case 1927859440:
                  num7 = s == "//android.widget.EditText[@text='Enter new password']" ? 1 : 0;
                  break;
                default:
                  num7 = 0;
                  break;
              }
              if (num7 != 0)
              {
                str1 = DateTime.Now.ToString("MMdd") + "unlock956" + GClass19.smethod_59(5, Class54.random_0);
                gclass27_0.method_50(string_11, str1);
                gclass27_0.SleepSeconds(2.0);
                gclass27_0.method_60("//*[@content-desc='Save changes']");
                this.method_187(int_4, "cPassword", str1, "pass");
                goto label_38;
              }
              else
                goto label_31;
            }
          }
          else if (num5 <= 532719482U)
          {
            if (num5 != 281629319U)
            {
              if (num5 == 532719482U && s == "//android.widget.ProgressBar")
                goto label_38;
              else
                goto label_31;
            }
            else if (s == "//*[@text='Tap to retry']")
            {
              if (num1 < num2)
              {
                ++num1;
                gclass27_0.method_78(-1);
                goto label_38;
              }
              else
                goto label_34;
            }
            else
              goto label_31;
          }
          else
          {
            if (num5 != 785803401U)
            {
              if (num5 == 1259562933U && s == "//*[@content-desc='Back to Facebook']")
                goto label_30;
            }
            else if (s == "//*[@content-desc='Save changes']")
            {
              if (str1 == "")
              {
                str1 = DateTime.Now.ToString("MMdd") + "unlock956" + GClass19.smethod_59(5, Class54.random_0);
                gclass27_0.method_50("//android.widget.EditText", str1);
                gclass27_0.SleepSeconds(2.0);
                this.method_187(int_4, "cPassword", str1, "pass");
              }
              gclass27_0.method_60(string_11, str2);
              goto label_38;
            }
            goto label_31;
          }
label_30:
          gclass27_0.method_60(string_11, str2);
          goto label_38;
label_31:
          if (!gclass27_0.method_100())
          {
            if (gclass27_0.method_78())
            {
              if (num3 < num4)
                ++num3;
              else
                goto label_29;
            }
            else
              num3 = 0;
          }
          else
          {
            this.method_185(int_4, "Live");
            this.method_184(int_4, "Unlock checkpoint success!");
            return;
          }
label_38:
          gclass27_0.SleepSeconds(2.0);
        }
        while (Environment.TickCount - tickCount < 300000);
        goto label_39;
label_34:
        return;
label_29:
        return;
      }
label_39:
      if (gclass27_0.method_100())
      {
        this.method_185(int_4, "Live");
        this.method_184(int_4, "Account Live!");
      }
      else
        this.method_184(int_4, string_0 + "Unlock checkpoint fail!");
    }
    catch
    {
    }
  }

  private void method_46(GClass27 gclass27_0, int int_4, string string_0)
  {
    int tickCount = Environment.TickCount;
    int num1 = 120;
    if (!this.method_215(gclass27_0, int_4, string_0, "fb://settings"))
      return;
    string str1 = "How people find and contact you";
    string str2 = "";
    string str3 = "";
    do
    {
      string string_11 = gclass27_0.method_53();
      if (!gclass27_0.method_31(0, string_11, "//*[@content-desc='" + str1 + "']"))
      {
        if (gclass27_0.method_78())
          goto label_21;
      }
      else
      {
        gclass27_0.method_60("//*[@content-desc='" + str1 + "']", string_11);
        while (true)
        {
          do
          {
            switch (str1)
            {
              case "How people find and contact you":
                string str4 = str2;
                if (str4 != null && str4.Length == 0)
                {
                  str2 = "//*[@text='Who can send you friend requests?']";
                  str3 = "[@text='Everyone']";
                  break;
                }
                switch (str4)
                {
                  case "//*[@text='Who can look you up using the email address you provided?']":
                    str2 = "//*[@text='Who can look you up using the phone number you provided?']";
                    str3 = "[@text='Everyone']";
                    break;
                  case "//*[@text='Who can see your friends list?']":
                    str2 = "//*[@text='Who can look you up using the email address you provided?']";
                    str3 = "[@text='Everyone']";
                    break;
                  case "//*[@text='Who can send you friend requests?']":
                    str2 = "//*[@text='Who can see your friends list?']";
                    str3 = "[@text='Public' or starts-with(@content-desc, 'Public')]";
                    break;
                  default:
                    str2 = "";
                    str1 = "Posts";
                    break;
                }
                break;
              case "Reels":
                if (!(str2 == ""))
                {
                  str2 = "";
                  str1 = "";
                  break;
                }
                str2 = "//*[@text='Public' or starts-with(@content-desc, 'Public')]";
                str3 = "[@text='Public' or starts-with(@content-desc, 'Public')]";
                break;
              case "Stories":
                if (!(str2 == ""))
                {
                  str2 = "";
                  str1 = "Reels";
                  break;
                }
                str2 = "//*[contains(@text,'who can see your story')]";
                str3 = "[@text='Public' or starts-with(@content-desc, 'Public')]";
                break;
              case "Posts":
                if (!(str2 == ""))
                {
                  str2 = "";
                  str1 = "Stories";
                  break;
                }
                str2 = "//*[@text='Who can see your future posts?']";
                str3 = "[@text='Public' or starts-with(@content-desc, 'Public')]";
                break;
            }
            if (str2 == "")
              goto label_36;
          }
          while (!gclass27_0.method_33(10, ref string_11, str2));
          int num2 = !gclass27_0.method_31(0, string_11, str2 + "/parent::*/child::*" + str3) ? 1 : 0;
          if (num2 == 0)
            num2 = !(str1 == "Reels") || !gclass27_0.method_31(0, string_11, "//*" + str3) ? 0 : 2;
          if (num2 > 0)
          {
            if (num2 == 1)
            {
              gclass27_0.method_60(str2, string_11);
              gclass27_0.SleepSeconds(1.0);
            }
            gclass27_0.method_61(10, "//*" + str3, "");
            if (gclass27_0.method_61(5, "//*[@content-desc='Done' or @text='CHANGE' or @text='SAVE']", ""))
            {
              gclass27_0.SleepSeconds(3.0);
              gclass27_0.method_42(10);
            }
            gclass27_0.method_28();
            gclass27_0.method_42(10);
          }
          string_11 = "";
        }
label_36:
        gclass27_0.method_28();
        gclass27_0.SleepSeconds(3.0);
      }
    }
    while (!(str1 == "") && Environment.TickCount - tickCount < num1 * 1000);
    goto label_25;
label_21:
    return;
label_25:;
  }

  private void method_47(
    GClass27 gclass27_0,
    int int_4,
    string string_0,
    string string_1,
    GClass22 gclass22_0)
  {
    try
    {
      string str1 = "";
      string str2 = "";
      string string_1_1 = "";
      string string_1_2 = "";
      string str3 = "";
      string str4 = "";
      string string_1_3 = "";
      if (!gclass22_0.method_4("ckbEmail"))
        string_1_1 = "-";
      if (!gclass22_0.method_4("ckbGender"))
        str2 = "-";
      if (!gclass22_0.method_4("ckbBirthday"))
        str1 = "-";
      if (!gclass22_0.method_4("ckbGroup"))
        string_1_2 = "-";
      if (!gclass22_0.method_4("ckbNgayTao"))
        str3 = "-";
      if (!gclass22_0.method_4("ckbName"))
        str4 = "-";
      if (!gclass22_0.method_4("ckbPhone"))
        string_1_3 = "-";
      if ((string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2) || string.IsNullOrEmpty(string_1_1) || string.IsNullOrEmpty(string_1_2) || string.IsNullOrEmpty(string_1_3)) && this.method_215(gclass27_0, int_4, string_0, "fb://profile_edit"))
      {
        int tickCount = Environment.TickCount;
        do
        {
          string str5 = gclass27_0.method_53();
          if (!gclass27_0.method_61(0, "//*[@text='Edit Your About Info']", str5))
          {
            if (string.IsNullOrEmpty(string_1_3) && gclass27_0.method_31(0, str5, "//*[@text='Mobile']/preceding-sibling::*"))
            {
              string_1_3 = gclass27_0.method_34(str5, "//*[@text='Mobile']/preceding-sibling::*", "text").FirstOrDefault<string>();
              if (!string.IsNullOrEmpty(string_1_3))
                this.method_187(int_4, "cPhone", string_1_3, "phone");
            }
            if (string.IsNullOrEmpty(string_1_1) && gclass27_0.method_31(0, str5, "//*[@text='Email']/preceding-sibling::*"))
            {
              string_1_1 = gclass27_0.method_34(str5, "//*[@text='Email']/preceding-sibling::*", "text").FirstOrDefault<string>();
              if (!string.IsNullOrEmpty(string_1_1))
                this.method_187(int_4, "cEmail", string_1_1, "email");
            }
            if (string.IsNullOrEmpty(str1) && gclass27_0.method_31(0, str5, "//*[@text='Birthday']/preceding-sibling::*"))
            {
              str1 = gclass27_0.method_34(str5, "//*[@text='Birthday']/preceding-sibling::*", "text").FirstOrDefault<string>();
              if (!string.IsNullOrEmpty(str1))
              {
                str1 = GClass19.smethod_113(str1);
                if (str1 != "")
                  this.method_187(int_4, "cBirthday", str1, "birthday");
              }
            }
            if (string.IsNullOrEmpty(str2) && gclass27_0.method_31(0, str5, "//*[@text='Gender']/preceding-sibling::*"))
            {
              str2 = gclass27_0.method_34(str5, "//*[@text='Gender']/preceding-sibling::*", "text").FirstOrDefault<string>();
              if (!string.IsNullOrEmpty(str2))
              {
                if (str2 == "male")
                  this.method_187(int_4, "cGender", "Nam", "gender");
                else
                  this.method_187(int_4, "cGender", "Nữ", "gender");
              }
            }
            if (string.IsNullOrEmpty(string_1_2) && gclass27_0.method_31(0, str5, "//*[@content-desc='GROUPS' or @text='GROUPS']"))
            {
              Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str5, "//*[@content-desc='GROUPS' or @text='GROUPS']").First<string>(), gclass27_0.method_37(0, str5, "//*[@content-desc='See All']"));
              if (class77 != null)
              {
                gclass27_0.method_66(class77.method_0());
                string string_11 = "";
                if (gclass27_0.method_33(30, ref string_11, "//*[contains(@text, 'PUBLIC')]"))
                {
                  string_1_2 = gclass27_0.method_34(string_11, "//*[contains(@text, 'PUBLIC')]", "text").FirstOrDefault<string>().Replace("public", "").Trim();
                  if (!string.IsNullOrEmpty(string_1_2))
                    this.method_187(int_4, "cGroup", string_1_2, "groups");
                }
              }
            }
            if (!string.IsNullOrEmpty(str1) && !string.IsNullOrEmpty(str2) && !string.IsNullOrEmpty(string_1_1) && !string.IsNullOrEmpty(string_1_2) && !string.IsNullOrEmpty(string_1_3))
              break;
          }
        }
        while (!gclass27_0.method_78() && Environment.TickCount - tickCount < 90000);
      }
      string string_11_1;
      if (string.IsNullOrEmpty(str3) && this.method_215(gclass27_0, int_4, string_0, "https://m.facebook.com/your_information/list?tile=PERSONAL_INFO_GROUPING"))
      {
        string_11_1 = "";
        if (gclass27_0.method_33(30, ref string_11_1, "//android.widget.Button[starts-with(@text,'Your account creation date')]"))
        {
          string string_0_1 = gclass27_0.method_34(string_11_1, "//android.widget.Button[starts-with(@text,'Your account creation date')]", "text").FirstOrDefault<string>().Replace("Your account creation date".ToLower(), "").Replace("The date you created your account".ToLower(), "").Trim();
          if (!string.IsNullOrEmpty(string_0_1))
          {
            string string_1_4 = GClass19.smethod_114(string_0_1);
            if (string_1_4 != "")
              this.method_187(int_4, "cDateCreateAcc", string_1_4, "dateCreateAcc");
          }
        }
      }
      if (!string.IsNullOrEmpty(str4) || !this.method_215(gclass27_0, int_4, string_0, "https://m.facebook.com/settings/account/"))
        return;
      string_11_1 = "";
      if (!gclass27_0.method_33(30, ref string_11_1, "//*[starts-with(@content-desc,'Name') or starts-with(@text,'Name')]"))
        return;
      string str6 = gclass27_0.method_34(string_11_1, "//*[starts-with(@content-desc,'Name') or starts-with(@text,'Name')]", "content-desc").FirstOrDefault<string>();
      if (string.IsNullOrEmpty(str6))
        str6 = gclass27_0.method_34(string_11_1, "//*[starts-with(@content-desc,'Name') or starts-with(@text,'Name')]", "text").FirstOrDefault<string>();
      if (string.IsNullOrEmpty(str6))
        return;
      string string_1_5 = str6.Substring(str6.IndexOf(' ') + 1);
      if (!string.IsNullOrEmpty(string_1_5))
        this.method_187(int_4, "cName", string_1_5, "name");
    }
    catch
    {
    }
  }

  private int method_48(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int int_4_1 = gclass22_0.method_3("nudSoLuongFrom");
    int int_5 = gclass22_0.method_3("nudSoLuongTo");
    bool flag1 = gclass22_0.method_4("ckbTuDongXoa");
    bool flag2 = gclass22_0.method_4("ckbAutoAddFriend");
    int minValue1 = gclass22_0.method_3("nudSoLuongKetBanFrom");
    int num1 = gclass22_0.method_3("nudSoLuongKetBanTo");
    int minValue2 = gclass22_0.method_3("nudDelayFrom");
    int num2 = gclass22_0.method_3("nudDelayTo");
    int num3 = 0;
    string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_2 + ": ";
    this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đang chạy..."));
    try
    {
      int count1 = gclass27_0.method_87(int_4_1, int_5);
      List<string> stringList = new List<string>();
      if (!flag1)
      {
        stringList = this.dictionary_13[string_1].GetRange(0, count1);
      }
      else
      {
        lock (this.dictionary_13)
        {
          if (this.dictionary_13[string_1].Count > 0)
          {
            if (count1 > this.dictionary_13[string_1].Count)
              count1 = this.dictionary_13[string_1].Count;
            stringList = this.dictionary_13[string_1].GetRange(0, count1);
            this.dictionary_13[string_1].RemoveRange(0, count1);
          }
        }
      }
      if (stringList.Count > 0)
      {
        this.method_184(int_4, string_0_1 + GClass35.smethod_0("Import danh bạ..."));
        gclass27_0.Cleardata("com.android.providers.contacts");
        gclass27_0.Openapp("com.google.android.contacts");
        int count2 = stringList.Count;
        for (int index = 0; index < count2; ++index)
        {
          this.method_184(int_4, string_0_1 + string.Format("Import danh bạ ({0}/{1})...", (object) (index + 1), (object) count2));
          string str = Class44.smethod_6();
          gclass27_0.CMD("shell am start -a android.intent.action.INSERT -t vnd.android.cursor.dir/contact -e name '" + str + "' -e phone " + stringList[index].Replace(" ", ""));
          gclass27_0.SleepSeconds(2.0);
          gclass27_0.method_61(5, "//*[@text='Save']", "");
        }
        try
        {
          int num4 = 0;
          int num5 = 6;
label_59:
label_17:
          gclass27_0.method_27(gclass27_0.string_5 + "/" + gclass27_0.string_5 + ".settings.activity.SettingsActivity");
          gclass27_0.SleepSeconds(3.0);
          switch (this.method_32(gclass27_0, int_4, string_0_1))
          {
            case 0:
              int tickCount = Environment.TickCount;
              do
              {
                string str1 = gclass27_0.method_53();
                string str2 = gclass27_0.method_29(0, str1, new List<string>()
                {
                  "//android.widget.ProgressBar",
                  "//*[@text='Tap to retry']",
                  "//*[@content-desc='Continuous contacts upload, off, switch']",
                  "//*[@text='Allow']",
                  "//*[@content-desc='Continuous contacts upload, on, switch']",
                  "//*[@text='TURN OFF']",
                  "//*[@text='Get started']",
                  "//*[@text='ADD FRIEND']",
                  "//*[@resource-id='android:id/empty']"
                });
                string s = str2;
                // ISSUE: reference to a compiler-generated method
                uint num6 = Class206.smethod_0(s);
                if (num6 > 1811260005U)
                {
                  if (num6 > 2344326954U)
                  {
                    int num7;
                    switch (num6)
                    {
                      case 2566009361:
                        if (s == "//*[@content-desc='Continuous contacts upload, on, switch']")
                          goto label_55;
                        else
                          goto label_56;
                      case 3600610036:
                        if (s == "//*[@text='Get started']")
                          goto label_55;
                        else
                          goto label_56;
                      case 4131407489:
                        num7 = !(s == "//*[@text='TURN OFF']") ? 1 : 0;
                        break;
                      default:
                        num7 = 1;
                        break;
                    }
                    if (num7 != 0)
                      goto label_56;
                  }
                  else
                  {
                    int num8;
                    switch (num6)
                    {
                      case 1983850854:
                        if (!(s == "//*[@resource-id='android:id/empty']"))
                          goto label_56;
                        else
                          goto label_61;
                      case 2344326954:
                        num8 = s == "//*[@text='ADD FRIEND']" ? 1 : 0;
                        break;
                      default:
                        num8 = 0;
                        break;
                    }
                    if (num8 != 0)
                    {
                      if (flag2)
                      {
                        string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_2 + ": Kết bạn ";
                        int num9 = Class54.random_0.Next(minValue1, num1 + 1);
                        int num10 = 0;
                        for (int index = 0; index < num9 + 10; ++index)
                        {
                          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Add Friend...", (object) num10, (object) num9));
                          List<string> list_0 = gclass27_0.method_37(10, "", str2);
                          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Add Friend: ", (object) num10, (object) num9) + list_0.Count.ToString());
                          if (list_0.Count == 0)
                          {
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) num10, (object) num9));
                            if (gclass27_0.method_78())
                            {
                              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Can't Scroll...", (object) num10, (object) num9));
                              break;
                            }
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Add Friend...", (object) num10, (object) num9));
                            list_0 = gclass27_0.method_37(10, "", str2);
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Add Friend: ", (object) num10, (object) num9) + list_0.Count.ToString());
                            if (list_0.Count == 0)
                              break;
                          }
                          string string_11 = list_0.smethod_10();
                          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Add Friend...", (object) num10, (object) num9));
                          if (string_11 != "" && gclass27_0.method_66(string_11))
                            ++num10;
                          if (num10 < num9)
                          {
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num10, (object) num9) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                            switch (this.method_32(gclass27_0, int_4, string_0))
                            {
                              case 0:
                                continue;
                              case 1:
                                goto label_17;
                              default:
                                goto label_61;
                            }
                          }
                          else
                          {
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}): Done!", (object) num10, (object) num9));
                            break;
                          }
                        }
                        break;
                      }
                      break;
                    }
                    goto label_56;
                  }
                }
                else if (num6 <= 281629319U)
                {
                  if (num6 != 82008644U)
                  {
                    if (num6 == 281629319U && s == "//*[@text='Tap to retry']")
                    {
                      if (num4 < num5)
                      {
                        ++num4;
                        gclass27_0.method_78(-1);
                        goto label_58;
                      }
                      else
                        break;
                    }
                    else
                      goto label_56;
                  }
                  else if (!(s == "//*[@text='Allow']"))
                    goto label_56;
                }
                else if (num6 != 532719482U)
                {
                  if (num6 != 1811260005U || !(s == "//*[@content-desc='Continuous contacts upload, off, switch']"))
                    goto label_56;
                }
                else if (s == "//android.widget.ProgressBar")
                {
                  this.method_184(int_4, string_0_1 + "Loading...");
                  goto label_58;
                }
                else
                  goto label_56;
label_55:
                this.method_184(int_4, string_0_1 + "Tap " + gclass27_0.method_151(str2) + "...");
                gclass27_0.method_60(str2, str1);
                goto label_58;
label_56:
                this.method_184(int_4, string_0_1 + "Scroll...");
                if (gclass27_0.method_78())
                {
                  switch (this.method_32(gclass27_0, int_4, string_0_1))
                  {
                    case 0:
                      break;
                    case 1:
                      goto label_17;
                    default:
                      goto label_61;
                  }
                }
label_58:
                gclass27_0.SleepSeconds(2.0);
              }
              while (Environment.TickCount - tickCount < 300000);
              break;
            case 1:
              goto label_59;
          }
        }
        catch
        {
        }
label_61:;
      }
    }
    catch
    {
    }
    return num3;
  }

  private int method_49(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int num1 = 2;
    string string_12_1 = this.method_191(int_4, "cPassword");
    if (string_12_1 == "")
    {
      this.method_184(int_4, string_0 + GClass35.smethod_0("Không có password"));
    }
    else
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đang chạy..."));
      bool flag1 = gclass22_0.method_3("typeOnOff2FA") == 1;
      int num2 = gclass22_0.method_3("neuDaCo2FA");
      bool flag2 = gclass22_0.method_3("typeOnOff2FA") == 0;
      int num3 = 0;
      int num4 = 6;
      while (this.method_215(gclass27_0, int_4, string_0_1, "fb://facewebmodal/f?href=https://m.facebook.com/security/2fac/settings/"))
      {
        string str1 = "";
        int num5 = 0;
        int num6 = 0;
        int tickCount = Environment.TickCount;
        do
        {
          string str2 = gclass27_0.method_53();
          string string_11 = gclass27_0.method_29(0, str2, new List<string>()
          {
            "//android.widget.ProgressBar",
            "//*[@text='Tap to retry']",
            "//*[@text='Turn off']",
            "//*[@text='Enter confirmation code']",
            "//*[@text='Enter Password']//android.widget.EditText",
            "//*[@text='Set up app on a different device']",
            "//*[@text='Two-factor authentication is on']",
            "//*[@text='Use authentication app']"
          });
          string s = string_11;
          // ISSUE: reference to a compiler-generated method
          uint num7 = Class206.smethod_0(s);
          if (num7 > 1211399273U)
          {
            if (num7 <= 1630274194U)
            {
              if (num7 != 1501499670U)
              {
                if (num7 == 1630274194U && s == "//*[@text='Two-factor authentication is on']")
                {
                  if (flag1)
                  {
                    if (str1 != "")
                    {
                      this.method_187(int_4, "cFa2", str1, "fa2");
                      num1 = 1;
                      break;
                    }
                    int num8;
                    switch (num2)
                    {
                      case 0:
                        num1 = 4;
                        goto label_62;
                      case 1:
                        num8 = gclass27_0.method_31(0, str2, "//*[@content-desc='Add a new app']") ? 1 : 0;
                        break;
                      default:
                        num8 = 0;
                        break;
                    }
                    if (num8 != 0)
                      gclass27_0.method_60("//*[@content-desc='Add a new app']", str2);
                    else if (num2 == 2 && gclass27_0.method_31(0, str2, "//*[@text='Turn off']"))
                      gclass27_0.method_60("//*[@text='Turn off']", str2);
                    else
                      gclass27_0.method_60("//*[@text='Authentication app']", str2);
                  }
                  else if (flag2)
                    gclass27_0.method_60("//*[@text='Turn off']", str2);
                }
                else
                  goto label_58;
              }
              else if (!(s == "//*[@content-desc='Add a new app']"))
                goto label_58;
              else
                goto label_55;
            }
            else if (num7 != 2049668434U)
            {
              if (num7 != 2305529162U)
              {
                if (num7 == 2497398125U && s == "//*[@text='Enter confirmation code']")
                {
                  if (gclass27_0.method_146(str2, "This code isn't right. Please try again"))
                  {
                    ++num5;
                    if (num5 > num6)
                    {
                      num1 = 5;
                      break;
                    }
                  }
                  string string_12_2 = GClass19.smethod_85(str1);
                  gclass27_0.method_60("//android.widget.EditText", str2);
                  gclass27_0.method_50("//android.widget.EditText", string_12_2);
                  gclass27_0.SleepSeconds(1.0);
                  gclass27_0.method_79(GClass27.GEnum10.const_66);
                  gclass27_0.SleepSeconds(2.0);
                  gclass27_0.method_79(GClass27.GEnum10.const_66);
                }
                else
                  goto label_58;
              }
              else if (s == "//*[@text='Enter Password']//android.widget.EditText")
              {
                if (gclass27_0.method_146(str2, "The password you entered was incorrect"))
                {
                  num1 = 3;
                  break;
                }
                gclass27_0.method_50(string_11, string_12_1);
                gclass27_0.SleepSeconds(2.0);
                gclass27_0.method_61(3, "//*[@text='Continue']", "");
              }
              else
                goto label_58;
            }
            else if (s == "//*[@text='Set up app on a different device']")
            {
              str1 = Regex.Match(str2, "secret%3D(.*?)%").Groups[1].Value;
              if (str1 == "")
                str1 = gclass27_0.method_34(str2, "//*[@text='Or enter this code into your authentication app']/parent::*/child::*[last()]", "text").FirstOrDefault<string>() ?? "";
              if (str1 != "")
              {
                gclass27_0.method_76(int_5: 2);
                gclass27_0.method_61(3, "//*[@text='Continue']", "");
              }
              else
                goto label_60;
            }
            else
              goto label_58;
          }
          else if (num7 > 532719482U)
          {
            int num9;
            switch (num7)
            {
              case 954530049:
                if (!(s == "//*[@text='Turn off']"))
                  goto label_58;
                else
                  goto label_55;
              case 1211399273:
                num9 = s == "//*[@text='Use authentication app']" ? 1 : 0;
                break;
              default:
                num9 = 0;
                break;
            }
            if (num9 == 0)
              goto label_58;
            else
              goto label_55;
          }
          else
          {
            int num10;
            switch (num7)
            {
              case 281629319:
                if (s == "//*[@text='Tap to retry']")
                {
                  if (num3 < num4)
                  {
                    ++num3;
                    gclass27_0.method_78(-1);
                    goto label_53;
                  }
                  else
                    goto label_62;
                }
                else
                  goto label_58;
              case 532719482:
                num10 = !(s == "//android.widget.ProgressBar") ? 1 : 0;
                break;
              default:
                num10 = 1;
                break;
            }
            if (num10 == 0)
              this.method_184(int_4, string_0_1 + "Loading...");
            else
              goto label_58;
label_53:;
          }
label_54:
          gclass27_0.SleepSeconds(2.0);
          continue;
label_55:
          if (!(string_11 == "//*[@text='Use authentication app']" & flag2))
          {
            this.method_184(int_4, string_0_1 + "Tap " + gclass27_0.method_151(string_11) + "...");
            gclass27_0.method_60(string_11, str2);
            goto label_54;
          }
          else
            goto label_57;
label_58:
          this.method_184(int_4, string_0_1 + "Scroll...");
          if (gclass27_0.method_78())
          {
            switch (this.method_32(gclass27_0, int_4, string_0_1))
            {
              case 0:
                goto label_54;
              case 1:
                goto label_60;
              default:
                goto label_63;
            }
          }
          else
            goto label_54;
        }
        while (Environment.TickCount - tickCount < 300000);
        break;
label_57:
        this.method_187(int_4, "cFa2", "", "fa2");
        num1 = 6;
        break;
label_60:;
      }
label_62:;
    }
label_63:
    return num1;
  }

  private int method_50(
    ref int int_4,
    ref int int_5,
    ref int int_6,
    int int_7,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    string string_12_1 = this.method_191(int_7, "cPassword");
    if (string_12_1 == "")
    {
      int_4 = 8;
    }
    else
    {
      this.method_191(int_7, "cId");
      string string_0 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_2 + ": ";
      this.method_184(int_7, string_0 + GClass35.smethod_0("Đang chạy..."));
      bool flag1 = gclass22_0.method_4("ckbAddMail");
      int num1 = gclass22_0.method_3("typeAddMail");
      int num2 = gclass22_0.method_3("typeMail");
      List<string> source1 = gclass22_0.method_2("lstMailDomain");
      if (num2 != 1 || source1.Count != 0)
      {
        string str1 = "";
        if (source1.Count > 0)
          str1 = source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>();
        List<string> source2 = gclass22_0.method_2("lstDomain");
        if (num2 != 2 || source2.Count != 0)
        {
          string str2 = "";
          if (source2.Count > 0)
            str2 = source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).First<string>();
          bool flag2 = flag1 && gclass22_0.method_4("ckbSetPrimaryMail");
          bool flag3 = gclass22_0.method_4("ckbRemoveMail");
          while (true)
          {
label_9:
            if (flag3)
            {
              int_6 = 2;
              int num3 = 0;
              int num4 = 6;
              while (this.method_215(gclass27_0, int_7, string_0, "fb://notification_settings_email"))
              {
                int num5 = 0;
                int tickCount = Environment.TickCount;
                do
                {
                  string str3 = gclass27_0.method_53();
                  string str4 = gclass27_0.method_29(0, str3, new List<string>()
                  {
                    "//android.widget.ProgressBar",
                    "//*[@text='Tap to retry']",
                    "//*[@content-desc='menu']",
                    "//*[@text='Remove']",
                    "//*[@text='YES']",
                    "//*[@content-desc='+ ADD EMAIL']"
                  });
                  switch (str4)
                  {
                    case "//*[@text='Remove']":
                    case "//*[@text='YES']":
                      this.method_184(int_7, string_0 + "Tap " + gclass27_0.method_151(str4) + "...");
                      gclass27_0.method_60(str4, str3);
                      break;
                    case "//*[@text='Tap to retry']":
                      if (num3 < num4)
                      {
                        ++num3;
                        gclass27_0.method_78(-1);
                        break;
                      }
                      goto label_157;
                    case "//android.widget.ProgressBar":
                      this.method_184(int_7, string_0 + "Loading...");
                      if (!gclass27_0.method_42(15))
                      {
                        gclass27_0.method_28();
                        break;
                      }
                      break;
                    case "//*[@content-desc='menu']":
                      if (num5 == gclass27_0.method_37(0, str3, str4).Count)
                      {
                        this.method_184(int_7, string_0 + "Tap " + gclass27_0.method_151(str4) + "...");
                        gclass27_0.method_60(str4, str3);
                        gclass27_0.SleepSeconds(1.0);
                        gclass27_0.method_61(10, "//*[@text='Make primary']", "");
                        break;
                      }
                      num5 = gclass27_0.method_37(0, str3, str4).Count;
                      this.method_184(int_7, string_0 + "Tap " + gclass27_0.method_151(str4) + "...");
                      gclass27_0.method_60(str4, str3);
                      break;
                    case "//*[@content-desc='+ ADD EMAIL']":
                      goto label_25;
                    default:
                      this.method_184(int_7, string_0 + "Scroll...");
                      if (gclass27_0.method_78())
                      {
                        int num6 = this.method_32(gclass27_0, int_7, string_0);
                        if (num6 != 1)
                        {
                          if (num6 == 0)
                          {
                            List<string> values = gclass27_0.method_150();
                            if (values.Count != 2 || !values.Contains("back") || !string.Join("|", (IEnumerable<string>) values).Contains("email"))
                              break;
                            goto label_17;
                          }
                          else
                            goto label_157;
                        }
                        else
                          goto label_28;
                      }
                      else
                        break;
                  }
                  gclass27_0.SleepSeconds(2.0);
                }
                while (Environment.TickCount - tickCount < 600000);
                goto label_30;
label_17:
                gclass27_0.method_28();
                goto label_28;
label_25:
                int_6 = 1;
                goto label_30;
label_28:;
              }
              goto label_154;
            }
label_30:
            if (flag1 && int_5 != 1)
            {
              int_4 = 2;
              string str5 = "";
              string string_1_1 = "";
              bool flag4 = false;
              int num7 = 0;
              int num8 = 2;
              int num9 = 0;
              int num10 = 6;
              if (num1 == 0)
              {
label_32:
                string str6;
                while (true)
                {
                  str6 = "";
                  if (this.method_215(gclass27_0, int_7, string_0, "https://m.facebook.com/settings/email/add"))
                  {
                    int tickCount = Environment.TickCount;
                    do
                    {
                      string str7 = gclass27_0.method_53();
                      string string_11 = gclass27_0.method_29(0, str7, new List<string>()
                      {
                        "//android.widget.ProgressBar",
                        "//*[@text='Tap to retry']",
                        "//android.widget.Button[@text='Add Email']",
                        "//*[@text='Confirm Email Address' or @content-desc='Confirm Email Address']",
                        "//*[@text='Enter Confirmation Code']",
                        "//*[@content-desc='Next']",
                        "//*[@text='Make primary']",
                        "//*[contains(@text,'please re-enter your password')]/parent::*//android.widget.EditText"
                      });
                      switch (string_11)
                      {
                        case "//android.widget.Button[@text='Add Email']":
                          if (!(str6 != ""))
                          {
                            switch (num2)
                            {
                              case 0:
                                lock (this.dictionary_10)
                                {
                                  while (str6 == "")
                                  {
                                    if (this.dictionary_10[string_1].Count != 0)
                                    {
                                      int index = this.random_0.Next(0, this.dictionary_10[string_1].Count);
                                      string[] strArray = this.dictionary_10[string_1][index].Split('|');
                                      if (strArray.Length > 1)
                                      {
                                        str6 = strArray[0].Trim().ToLower();
                                        string_1_1 = strArray[1].Trim();
                                      }
                                      this.dictionary_10[string_1].RemoveAt(index);
                                    }
                                    else
                                    {
                                      int_4 = 7;
                                      goto label_154;
                                    }
                                  }
                                  break;
                                }
                              case 1:
                                str6 = GClass19.smethod_62(Class44.smethod_3().OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text6 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text6 => string_0_1)).First<string>() + Class44.smethod_5().OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text6 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text6 => string_0_1)).First<string>()).Replace(" ", "").ToLower() + GClass19.smethod_61(6, this.random_0) + Regex.Match(str1, "@\\w+.\\w+").Value;
                                break;
                              case 2:
                                str6 = new GClass28()
                                {
                                  string_1 = str2
                                }.method_1();
                                break;
                            }
                            gclass27_0.method_50("//android.widget.EditText", str6);
                            gclass27_0.SleepSeconds(1.0);
                            gclass27_0.method_50("//*[contains(@text,'please enter your Facebook password')]/parent::*//android.widget.EditText", string_12_1);
                            gclass27_0.SleepSeconds(1.0);
                            gclass27_0.method_60(string_11, str7);
                            break;
                          }
                          break;
                        case "//*[@text='Tap to retry']":
                          if (num9 < num10)
                          {
                            ++num9;
                            gclass27_0.method_78(-1);
                            break;
                          }
                          goto label_154;
                        case "//android.widget.ProgressBar":
                          this.method_184(int_7, string_0 + "Loading...");
                          if (!gclass27_0.method_42(15))
                          {
                            gclass27_0.method_28();
                            break;
                          }
                          break;
                        case "//*[contains(@text,'please re-enter your password')]/parent::*//android.widget.EditText":
                          if (!gclass27_0.method_146(str7, "The password you entered was incorrect"))
                          {
                            gclass27_0.method_50("//android.widget.EditText", string_12_1);
                            gclass27_0.SleepSeconds(1.0);
                            gclass27_0.method_60("//*[@text='Continue']", str7);
                            break;
                          }
                          goto label_72;
                        case "//*[@text='Enter Confirmation Code']":
                          if (gclass27_0.method_31(0, str7, "//*[@text='Confirm']/parent::*/parent::*//android.widget.EditText"))
                          {
                            string string_12_2;
                            while (true)
                            {
                              this.method_184(int_7, string_0 + "Get otp...");
                              string input = "";
                              switch (num2)
                              {
                                case 0:
                                  input = Class23.smethod_1(0, str6, string_1_1, 90);
                                  break;
                                case 1:
                                  input = Class23.smethod_3(0, str1, str6);
                                  break;
                                case 2:
                                  input = new GClass28(str6).method_0(0, 120);
                                  break;
                              }
                              if (!(input == "not connect"))
                              {
                                string_12_2 = Regex.Match(input, "c=(.*?)&").Groups[1].Value;
                                if (string_12_2 == "")
                                {
                                  if (num7 < num8)
                                  {
                                    ++num7;
                                    gclass27_0.method_60("//*[@text='Resend confirmation email']", str7);
                                  }
                                  else
                                    goto label_65;
                                }
                                else
                                  goto label_66;
                              }
                              else
                                break;
                            }
                            int_4 = 5;
                            goto label_154;
label_65:
                            int_4 = 4;
                            goto label_154;
label_66:
                            this.method_184(int_7, string_0 + "Get otp: " + string_12_2);
                            gclass27_0.method_50("//*[@text='Confirm']/parent::*/parent::*//android.widget.EditText", string_12_2);
                            gclass27_0.SleepSeconds(1.0);
                            gclass27_0.method_60("//*[@text='Confirm']", str7);
                            break;
                          }
                          if (gclass27_0.method_31(0, str7, "//*[contains(@text,'profile picture')]"))
                            goto label_148;
                          else
                            break;
                        case "//*[@text='Confirm Email Address' or @content-desc='Confirm Email Address']":
                          this.method_184(int_7, string_0 + "Tap " + gclass27_0.method_151(string_11) + "...");
                          gclass27_0.method_60(string_11, str7);
                          break;
                        default:
                          this.method_184(int_7, string_0 + "Scroll...");
                          if (gclass27_0.method_78())
                          {
                            int num11 = this.method_32(gclass27_0, int_7, string_0);
                            if (num11 != 1)
                            {
                              if (num11 == 0)
                              {
                                List<string> values = gclass27_0.method_150();
                                if (values.Count != 2 || !values.Contains("back") || !string.Join("|", (IEnumerable<string>) values).Contains("email"))
                                  break;
                                goto label_77;
                              }
                              else
                                goto label_154;
                            }
                            else
                              goto label_32;
                          }
                          else
                            break;
                      }
                      gclass27_0.SleepSeconds(2.0);
                    }
                    while (Environment.TickCount - tickCount < 600000);
                    goto label_154;
label_77:
                    gclass27_0.method_28();
                  }
                  else
                    goto label_154;
                }
label_148:
                int_4 = 1;
                this.method_187(int_7, "cEmail", str6, "email");
                this.method_187(int_7, "cPassMail", string_1_1, "passmail");
                if (flag2)
                {
                  int_5 = 2;
                  if (this.method_215(gclass27_0, int_7, string_0, "fb://notification_settings_email"))
                  {
                    if (gclass27_0.method_61(10, "//*[@content-desc='menu']", "") && gclass27_0.method_61(10, "//*[@text='Make primary']", ""))
                    {
                      gclass27_0.method_80(2.0, 3.0);
                      int_5 = 1;
                    }
                    else
                      goto label_152;
                  }
                  else
                    goto label_154;
                }
                else
                  goto label_154;
              }
              else
              {
                while (this.method_215(gclass27_0, int_7, string_0, "fb://notification_settings_email"))
                {
                  int tickCount = Environment.TickCount;
                  do
                  {
                    string str8 = gclass27_0.method_53();
                    string string_11 = gclass27_0.method_29(0, str8, new List<string>()
                    {
                      "//android.widget.ProgressBar",
                      "//*[@text='Tap to retry']",
                      "//*[@content-desc='+ ADD EMAIL']",
                      "//android.widget.EditText[@text='Enter your email']",
                      "//*[@text='Confirm Email']",
                      "//*[@content-desc='Next']",
                      "//*[@text='Make primary']"
                    });
                    string s = string_11;
                    // ISSUE: reference to a compiler-generated method
                    uint num12 = Class206.smethod_0(s);
                    if (num12 > 490657884U)
                    {
                      if (num12 <= 1753447723U)
                      {
                        switch (num12)
                        {
                          case 532719482:
                            if (s == "//android.widget.ProgressBar")
                            {
                              this.method_184(int_7, string_0 + "Loading...");
                              if (!gclass27_0.method_42(15))
                              {
                                gclass27_0.method_28();
                                break;
                              }
                              break;
                            }
                            goto label_141;
                          case 1753447723:
                            if (s == "//*[@text='Make primary']")
                            {
                              this.method_184(int_7, string_0 + "Tap " + gclass27_0.method_151(string_11) + "...");
                              gclass27_0.method_60(string_11, str8);
                              int_5 = 1;
                              break;
                            }
                            goto label_141;
                          default:
                            goto label_141;
                        }
                      }
                      else
                      {
                        if (num12 != 1792698548U)
                        {
                          if (num12 != 3616337277U || !(s == "//*[@content-desc='+ ADD EMAIL']"))
                            goto label_141;
                        }
                        else if (!(s == "//*[@content-desc='Next']"))
                          goto label_141;
                        if (flag4)
                        {
                          int_4 = 1;
                          this.method_187(int_7, "cEmail", str5, "email");
                          this.method_187(int_7, "cPassMail", string_1_1, "passmail");
                          if (flag2)
                          {
                            if (int_5 != 1)
                            {
                              int_5 = 2;
                              if (!(string_11 != "//*[@content-desc='+ ADD EMAIL']"))
                              {
                                if (!gclass27_0.method_31(0, str8, "//*[@content-desc='menu']"))
                                {
                                  int_5 = 1;
                                  int_6 = 1;
                                  break;
                                }
                                gclass27_0.method_60("//*[@content-desc='menu']", str8);
                              }
                              else
                                goto label_146;
                            }
                            else
                              goto label_9;
                          }
                          else
                            break;
                        }
                        else
                        {
                          this.method_184(int_7, string_0 + "Tap " + gclass27_0.method_151(string_11) + "...");
                          gclass27_0.method_60(string_11, str8);
                          if (string_11 == "//*[@content-desc='Next']")
                          {
                            string str9 = "";
                            for (int index = 0; index < 3; ++index)
                            {
                              gclass27_0.SleepSeconds(2.0);
                              str9 = gclass27_0.method_34("", "//android.widget.EditText", "text").FirstOrDefault<string>();
                              if (string.IsNullOrEmpty(str9))
                                break;
                            }
                            if (!string.IsNullOrEmpty(str9))
                            {
                              gclass27_0.method_46("//android.widget.EditText");
                              str5 = "";
                            }
                          }
                        }
                      }
                    }
                    else
                    {
                      int num13;
                      switch (num12)
                      {
                        case 130929265:
                          if (s == "//*[@text='Confirm Email']")
                          {
                            if (gclass27_0.method_31(0, str8, "//android.widget.EditText[@text='Confirmation Code']"))
                            {
                              this.method_184(int_7, string_0 + "Get otp...");
                              string input = num2 != 0 ? Class23.smethod_3(0, str1, str5) : Class23.smethod_1(0, str5, string_1_1, 90);
                              if (input == "not connect")
                              {
                                int_4 = 5;
                                goto label_154;
                              }
                              else
                              {
                                string string_12_3 = Regex.Match(input, "c=(.*?)&").Groups[1].Value;
                                if (string_12_3 == "")
                                {
                                  int_4 = 4;
                                  goto label_154;
                                }
                                else
                                {
                                  this.method_184(int_7, string_0 + "Get otp: " + string_12_3);
                                  gclass27_0.method_50("//android.widget.EditText[@text='Confirmation Code']", string_12_3);
                                  gclass27_0.SleepSeconds(1.0);
                                  gclass27_0.method_60("//*[@content-desc='CONFIRM']", str8);
                                  flag4 = true;
                                }
                              }
                            }
                            else if (!string.IsNullOrEmpty(gclass27_0.method_34(str8, "//android.widget.EditText", "text").FirstOrDefault<string>()))
                            {
                              if (num7 >= num8)
                              {
                                int_4 = 4;
                                goto label_154;
                              }
                              else
                              {
                                ++num7;
                                gclass27_0.method_46("//android.widget.EditText");
                              }
                            }
                            goto label_140;
                          }
                          else
                            goto label_141;
                        case 281629319:
                          if (s == "//*[@text='Tap to retry']")
                          {
                            if (num9 < num10)
                            {
                              ++num9;
                              gclass27_0.method_78(-1);
                              goto label_140;
                            }
                            else
                              goto label_154;
                          }
                          else
                            goto label_141;
                        case 490657884:
                          num13 = !(s == "//android.widget.EditText[@text='Enter your email']") ? 1 : 0;
                          break;
                        default:
                          num13 = 1;
                          break;
                      }
                      if (num13 == 0)
                      {
                        if (num2 == 0)
                        {
                          lock (this.dictionary_10)
                          {
                            while (str5 == "")
                            {
                              if (this.dictionary_10[string_1].Count != 0)
                              {
                                int index = this.random_0.Next(0, this.dictionary_10[string_1].Count);
                                string[] strArray = this.dictionary_10[string_1][index].Split('|');
                                if (strArray.Length > 1)
                                {
                                  str5 = strArray[0].Trim().ToLower();
                                  string_1_1 = strArray[1].Trim();
                                }
                                this.dictionary_10[string_1].RemoveAt(index);
                              }
                              else
                              {
                                int_4 = 7;
                                goto label_157;
                              }
                            }
                          }
                        }
                        else
                          str5 = GClass19.smethod_62(Class44.smethod_3().OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text6 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text6 => string_0_1)).First<string>() + Class44.smethod_5().OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text6 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text6 => string_0_1)).First<string>()).Replace(" ", "").ToLower() + GClass19.smethod_61(6, this.random_0) + Regex.Match(str1, "@\\w+.\\w+").Value;
                        gclass27_0.method_50(string_11, str5);
                        gclass27_0.SleepSeconds(1.0);
                        gclass27_0.method_60("//*[@content-desc='NEXT']", str8);
                      }
                      else
                        goto label_141;
                    }
label_140:
                    gclass27_0.SleepSeconds(2.0);
                    continue;
label_141:
                    this.method_184(int_7, string_0 + "Scroll...");
                    if (gclass27_0.method_78())
                    {
                      switch (this.method_32(gclass27_0, int_7, string_0))
                      {
                        case 0:
                          List<string> values = gclass27_0.method_150();
                          if (values.Count == 2 && values.Contains("back") && string.Join("|", (IEnumerable<string>) values).Contains("email"))
                            gclass27_0.method_28();
                          goto label_140;
                        case 1:
                          goto label_146;
                        default:
                          goto label_157;
                      }
                    }
                    else
                      goto label_140;
                  }
                  while (Environment.TickCount - tickCount < 600000);
                  break;
label_146:;
                }
                goto label_154;
              }
            }
            else
              goto label_154;
          }
label_72:
          int_4 = 3;
          goto label_154;
label_152:
          int_5 = 1;
          int_6 = 1;
label_154:;
        }
      }
    }
label_157:
    return 0;
  }

  private int method_51(
    ref int int_4,
    int int_5,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    this.method_191(int_5, "cId");
    string string_0_3 = Regex.Match(gclass27_0.method_114().Split('|')[1] + ";", "c_user=(.*?);").Groups[1].Value;
    string string_0_4 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_2 + ": ";
    this.method_184(int_5, string_0_4 + GClass35.smethod_0("Đang chạy..."));
    int num1 = gclass22_0.method_3("typeMail");
    List<string> source = gclass22_0.method_2("lstMailDomain");
    if (num1 != 1 || source.Count != 0)
    {
      string str1 = source.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>();
      int_4 = 2;
      string str2 = "";
      string string_1_1 = "";
      int num2 = 0;
      int num3 = 2;
      int num4 = 0;
      int num5 = 6;
label_2:
      int tickCount = Environment.TickCount;
      do
      {
        string str3 = gclass27_0.method_53();
        string string_11_1 = gclass27_0.method_29(0, str3, new List<string>()
        {
          "//android.widget.ProgressBar",
          "//*[@text='Tap to retry']",
          "//*[@content-desc='Confirm by email']",
          "//android.widget.EditText[@text='Email address']",
          "//android.widget.EditText[@text='Confirmation code']",
          "//android.widget.TextView[@text='save your login info']",
          "//*[@content-desc='skip' or @text='skip']",
          "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]",
          "//android.view.ViewGroup[@content-desc=\"Allow\"]",
          "//com.android.packageinstaller,id/do_not_ask_checkbox",
          "//android.widget.Button[@text=\"NEVER\"]",
          "//*[@text='No thanks']",
          "//*[@content-desc='I ACCEPT']",
          "//*[@content-desc='Allow all cookies']",
          "//*[@content-desc='deny' or @text='deny']"
        });
        string s = string_11_1;
        // ISSUE: reference to a compiler-generated method
        uint num6 = Class206.smethod_0(s);
        if (num6 > 689557640U)
        {
          if (num6 <= 2879920751U)
          {
            if (num6 > 1378667548U)
            {
              int num7;
              switch (num6)
              {
                case 2698810085:
                  if (!(s == "//*[@text='No thanks']"))
                    goto label_80;
                  else
                    goto label_79;
                case 2879920751:
                  num7 = s == "//android.widget.TextView[@text='save your login info']" ? 1 : 0;
                  break;
                default:
                  num7 = 0;
                  break;
              }
              if (num7 != 0)
                gclass27_0.method_60("//android.widget.Button[@text='OK']", str3);
              else
                goto label_80;
            }
            else
            {
              int num8;
              switch (num6)
              {
                case 728177876:
                  if (s == "//com.android.packageinstaller:id/do_not_ask_checkbox")
                    goto label_79;
                  else
                    goto label_80;
                case 1378667548:
                  num8 = !(s == "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]") ? 1 : 0;
                  break;
                default:
                  num8 = 1;
                  break;
              }
              if (num8 == 0)
                goto label_79;
              else
                goto label_80;
            }
          }
          else if (num6 <= 3691564067U)
          {
            if (num6 != 3056511029U)
            {
              if (num6 == 3691564067U && s == "//android.widget.EditText[@text='Email address']")
              {
                if (num1 == 0)
                {
                  lock (this.dictionary_11)
                  {
                    while (str2 == "")
                    {
                      if (this.dictionary_11[string_1].Count != 0)
                      {
                        int index = this.random_0.Next(0, this.dictionary_11[string_1].Count);
                        string[] strArray = this.dictionary_11[string_1][index].Split('|');
                        if (strArray.Length > 1)
                        {
                          str2 = strArray[0].Trim().ToLower();
                          string_1_1 = strArray[1].Trim();
                        }
                        this.dictionary_11[string_1].RemoveAt(index);
                      }
                      else
                      {
                        int_4 = 7;
                        goto label_91;
                      }
                    }
                  }
                }
                else
                  str2 = GClass19.smethod_62(Class44.smethod_3().OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text3 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text3 => string_0_1)).First<string>() + Class44.smethod_5().OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text3 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text3 => string_0_1)).First<string>()).Replace(" ", "").ToLower() + GClass19.smethod_61(6, this.random_0) + Regex.Match(str1, "@\\w+.\\w+").Value;
                gclass27_0.method_50(string_11_1, str2);
                gclass27_0.SleepSeconds(1.0);
                string string_11_2 = gclass27_0.method_29(0, str3, new List<string>()
                {
                  "//*[@text='Continue']",
                  "//*[@text='Update email address']"
                });
                gclass27_0.method_60(string_11_2, str3);
              }
              else
                goto label_80;
            }
            else if (s == "//android.widget.EditText[@text='Confirmation code']")
            {
              if (gclass27_0.method_31(0, str3, "//android.widget.EditText[@text='Confirmation Code']"))
              {
                this.method_184(int_5, string_0_4 + "Get otp...");
                string input = "";
                for (int index = 0; index < 3; ++index)
                {
                  if (!Class38.smethod_17(string_0_3).StartsWith("0|"))
                  {
                    input = num1 != 0 ? Class23.smethod_3(0, str1, str2) : Class23.smethod_1(0, str2, string_1_1, 90);
                    if (!(input == "not connect"))
                    {
                      if (input != "")
                        break;
                    }
                    else
                    {
                      int_4 = 5;
                      goto label_90;
                    }
                  }
                  else
                  {
                    int_4 = 8;
                    goto label_90;
                  }
                }
                string string_12 = Regex.Match(input, "c=(.*?)&").Groups[1].Value;
                if (string_12 == "")
                {
                  int_4 = 4;
                  break;
                }
                this.method_184(int_5, string_0_4 + "Get otp: " + string_12);
                gclass27_0.method_50(string_11_1, string_12);
                gclass27_0.SleepSeconds(1.0);
                gclass27_0.method_60("//*[@text='Confirm']", str3);
              }
              else if (!string.IsNullOrEmpty(gclass27_0.method_34(str3, "//android.widget.EditText", "text").FirstOrDefault<string>()))
              {
                if (num2 >= num3)
                {
                  int_4 = 4;
                  break;
                }
                ++num2;
                gclass27_0.method_46("//android.widget.EditText");
              }
            }
            else
              goto label_80;
          }
          else
          {
            if (num6 != 3919975960U)
            {
              if (num6 != 4002761936U || !(s == "//*[@content-desc='skip' or @text='skip']"))
                goto label_80;
            }
            else if (!(s == "//*[@content-desc='I ACCEPT']"))
              goto label_80;
            goto label_79;
          }
        }
        else if (num6 <= 281629319U)
        {
          if (num6 != 14426572U)
          {
            if (num6 != 38614762U)
            {
              if (num6 == 281629319U && s == "//*[@text='Tap to retry']")
              {
                if (num4 < num5)
                {
                  ++num4;
                  gclass27_0.method_78(-1);
                }
                else
                  break;
              }
              else
                goto label_80;
            }
            else if (!(s == "//android.view.ViewGroup[@content-desc=\"Allow\"]"))
              goto label_80;
            else
              goto label_79;
          }
          else if (!(s == "//*[@content-desc='deny' or @text='deny']"))
            goto label_80;
          else
            goto label_79;
        }
        else if (num6 > 454760892U)
        {
          int num9;
          switch (num6)
          {
            case 532719482:
              if (s == "//android.widget.ProgressBar")
              {
                this.method_184(int_5, string_0_4 + "Loading...");
                goto label_78;
              }
              else
                goto label_80;
            case 689557640:
              num9 = !(s == "//*[@content-desc='Confirm by email']") ? 1 : 0;
              break;
            default:
              num9 = 1;
              break;
          }
          if (num9 == 0)
            gclass27_0.method_60(string_11_1, str3);
          else
            goto label_80;
        }
        else
        {
          int num10;
          switch (num6)
          {
            case 300361078:
              if (s == "//*[@content-desc='Allow all cookies']")
                goto label_75;
              else
                goto label_80;
            case 454760892:
              num10 = !(s == "//android.widget.Button[@text=\"NEVER\"]") ? 1 : 0;
              break;
            default:
              num10 = 1;
              break;
          }
          if (num10 != 0)
            goto label_80;
label_75:
          goto label_79;
        }
label_78:
        gclass27_0.SleepSeconds(2.0);
        continue;
label_79:
        gclass27_0.method_60(string_11_1, str3);
        goto label_78;
label_80:
        if (!Class38.smethod_17(string_0_3).StartsWith("0|"))
        {
          if (gclass27_0.method_146(str3, "Something went wrong. Please try again"))
          {
            gclass27_0.method_46("//android.widget.EditText");
            goto label_78;
          }
          else if (!gclass27_0.method_100(str3))
          {
            this.method_184(int_5, string_0_4 + "Scroll...");
            if (gclass27_0.method_78())
            {
              int num11 = this.method_32(gclass27_0, int_5, string_0_4);
              if (num11 != 1)
              {
                if (num11 != 0)
                  break;
              }
              else
                goto label_2;
            }
            goto label_78;
          }
          else
            goto label_84;
        }
        else
          goto label_89;
      }
      while (Environment.TickCount - tickCount < 600000);
      goto label_90;
label_84:
      int_4 = 1;
      this.method_187(int_5, "cEmail", str2, "email");
      this.method_187(int_5, "cPassMail", string_1_1, "passmail");
      goto label_90;
label_89:
      int_4 = 8;
label_90:;
    }
label_91:
    return 0;
  }

  private int method_52(int int_4, string string_0, GClass27 gclass27_0, string string_1)
  {
    string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
    this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đang chạy..."));
    bool flag = false;
    try
    {
      if (this.method_215(gclass27_0, int_4, string_0_1, "fb://facewebmodal/f?href=https://mbasic.facebook.com/settings/security_login/sessions/"))
        flag = gclass27_0.method_61(10, "//android.widget.Button[@text='Log out of all sessions']", "") && gclass27_0.method_61(10, "//android.widget.Button[@text='Log out']", "");
    }
    catch
    {
    }
    return flag ? 1 : 0;
  }

  private int method_53(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    bool flag1 = false;
    string str1 = gclass22_0.method_1("txtPathFolder");
    bool flag2 = gclass22_0.method_4("ckbXoaAnhDaDung");
    if (Directory.GetFiles(str1).Length != 0)
    {
      string string_0_3 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_4, string_0_3 + GClass35.smethod_0("Đang chạy..."));
      try
      {
        int num1 = 0;
        int num2 = 3;
        int num3 = 0;
        int num4 = 6;
        while (this.method_215(gclass27_0, int_4, string_0_3, "fb://profile_edit"))
        {
          string str2 = "";
          if (flag2)
          {
            lock (this.Object_0)
            {
              string string_0_4 = ((IEnumerable<string>) Directory.GetFiles(str1)).OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text2 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text2 => string_0_1)).FirstOrDefault<string>();
              if (!string.IsNullOrEmpty(string_0_4))
              {
                gclass27_0.method_142(new List<string>()
                {
                  string_0_4
                });
                GClass19.smethod_98(string_0_4);
              }
              else
                break;
            }
          }
          else
          {
            str2 = ((IEnumerable<string>) Directory.GetFiles(str1)).OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text2 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text2 => string_0_1)).FirstOrDefault<string>();
            if (!string.IsNullOrEmpty(str1))
              this.method_77(gclass27_0, str1);
            else
              break;
          }
          int tickCount = Environment.TickCount;
          bool flag3 = false;
          do
          {
            string str3 = gclass27_0.method_53();
            string str4 = gclass27_0.method_29(0, str3, new List<string>()
            {
              "//android.widget.ProgressBar",
              "//*[@text='Tap to retry']",
              "//*[@content-desc='Profile picture, Button']",
              "//android.widget.Button[@text='ALLOW']",
              "//android.view.ViewGroup[@content-desc='SAVE']",
              "//*[@content-desc='Photo']",
              "//*[@content-desc='Photo. Disabled.']"
            });
            string s = str4;
            // ISSUE: reference to a compiler-generated method
            uint num5 = Class206.smethod_0(s);
            if (num5 > 532719482U)
            {
              if (num5 <= 3462202881U)
              {
                if (num5 != 2289923420U)
                {
                  if (num5 == 3462202881U && s == "//*[@content-desc='Photo. Disabled.']")
                  {
                    if (num1 < num2)
                    {
                      ++num1;
                      gclass27_0.method_60("//*[@content-desc='Back']", str3);
                      goto label_35;
                    }
                    else
                      goto label_43;
                  }
                  else
                    goto label_39;
                }
                else if (!(s == "//*[@content-desc='Profile picture, Button']"))
                  goto label_39;
              }
              else if (num5 != 3803917544U)
              {
                if (num5 != 4090015443U || !(s == "//android.widget.Button[@text='ALLOW']"))
                  goto label_39;
              }
              else if (!(s == "//android.view.ViewGroup[@content-desc='SAVE']"))
                goto label_39;
              if (!(str4 == "//*[@content-desc='Profile picture, Button']" & flag3))
              {
                this.method_184(int_4, string_0_3 + "Tap " + gclass27_0.method_151(str4) + "...");
                gclass27_0.method_60(str4, str3);
              }
              else
                goto label_38;
            }
            else
            {
              int num6;
              switch (num5)
              {
                case 273826655:
                  if (s == "//*[@content-desc='Photo']")
                  {
                    List<string> source = gclass27_0.method_37(0, "", str4);
                    if (source.Count > 1)
                      source = source.GetRange(0, source.Count - 1);
                    string string_11 = source.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).FirstOrDefault<string>();
                    gclass27_0.method_66(string_11);
                    flag3 = true;
                    goto label_35;
                  }
                  else
                    goto label_39;
                case 281629319:
                  if (s == "//*[@text='Tap to retry']")
                  {
                    if (num3 < num4)
                    {
                      ++num3;
                      gclass27_0.method_78(-1);
                      goto label_35;
                    }
                    else
                      goto label_46;
                  }
                  else
                    goto label_39;
                case 532719482:
                  num6 = !(s == "//android.widget.ProgressBar") ? 1 : 0;
                  break;
                default:
                  num6 = 1;
                  break;
              }
              if (num6 == 0)
                this.method_184(int_4, string_0_3 + "Loading...");
              else
                goto label_39;
            }
label_35:
            gclass27_0.SleepSeconds(2.0);
            continue;
label_39:
            if (gclass27_0.method_31(0, str3, "//android.widget.TextView[@text='CAMERA ROLL']") && !gclass27_0.method_31(0, str3, "//*[@content-desc='Live camera']"))
            {
              gclass27_0.method_60("//*[@content-desc='Back']", str3);
              goto label_35;
            }
            else
            {
              this.method_184(int_4, string_0_3 + "Scroll...");
              if (gclass27_0.method_78())
              {
                switch (this.method_32(gclass27_0, int_4, string_0_3))
                {
                  case 0:
                    goto label_35;
                  case 1:
                    goto label_43;
                  default:
                    goto label_46;
                }
              }
              else
                goto label_35;
            }
          }
          while (Environment.TickCount - tickCount < 300000);
          break;
label_38:
          flag1 = true;
          break;
label_43:;
        }
      }
      catch
      {
      }
label_46:;
    }
    return flag1 ? 1 : 0;
  }

  private int method_54(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    bool flag1 = false;
    string str1 = gclass22_0.method_1("txtPathFolder");
    bool flag2 = gclass22_0.method_4("ckbXoaAnhDaDung");
    if (Directory.GetFiles(str1).Length != 0)
    {
      string string_0_3 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_4, string_0_3 + GClass35.smethod_0("Đang chạy..."));
      try
      {
        int num1 = 0;
        int num2 = 3;
        int num3 = 0;
        int num4 = 6;
        while (this.method_215(gclass27_0, int_4, string_0_3, "fb://profile_edit"))
        {
          string str2 = "";
          if (flag2)
          {
            lock (this.object_5)
            {
              string string_0_4 = ((IEnumerable<string>) Directory.GetFiles(str1)).OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text2 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text2 => string_0_1)).FirstOrDefault<string>();
              if (!string.IsNullOrEmpty(string_0_4))
              {
                gclass27_0.method_142(new List<string>()
                {
                  string_0_4
                });
                GClass19.smethod_98(string_0_4);
              }
              else
                break;
            }
          }
          else
          {
            str2 = ((IEnumerable<string>) Directory.GetFiles(str1)).OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text2 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text2 => string_0_1)).FirstOrDefault<string>();
            if (!string.IsNullOrEmpty(str1))
              this.method_77(gclass27_0, str1);
            else
              break;
          }
          int tickCount = Environment.TickCount;
          bool flag3 = false;
          do
          {
            string str3 = gclass27_0.method_53();
            string str4 = gclass27_0.method_29(0, str3, new List<string>()
            {
              "//android.widget.ProgressBar",
              "//*[@text='Tap to retry']",
              "//*[contains(@content-desc,'cover photo')]",
              "//android.widget.Button[@text='ALLOW']",
              "//android.view.ViewGroup[@content-desc='SAVE']",
              "//*[@content-desc='Photo']",
              "//*[@content-desc='Photo. Disabled.']"
            });
            string s = str4;
            // ISSUE: reference to a compiler-generated method
            uint num5 = Class206.smethod_0(s);
            if (num5 > 281629319U)
            {
              if (num5 > 3462202881U)
              {
                int num6;
                switch (num5)
                {
                  case 3803917544:
                    if (s == "//android.view.ViewGroup[@content-desc='SAVE']")
                      goto label_40;
                    else
                      goto label_44;
                  case 4090015443:
                    num6 = !(s == "//android.widget.Button[@text='ALLOW']") ? 1 : 0;
                    break;
                  default:
                    num6 = 1;
                    break;
                }
                if (num6 != 0)
                  goto label_44;
              }
              else
              {
                int num7;
                switch (num5)
                {
                  case 532719482:
                    if (s == "//android.widget.ProgressBar")
                    {
                      this.method_184(int_4, string_0_3 + "Loading...");
                      goto label_43;
                    }
                    else
                      goto label_44;
                  case 3462202881:
                    num7 = !(s == "//*[@content-desc='Photo. Disabled.']") ? 1 : 0;
                    break;
                  default:
                    num7 = 1;
                    break;
                }
                if (num7 == 0)
                {
                  if (num1 < num2)
                  {
                    ++num1;
                    gclass27_0.method_60("//*[@content-desc='Back']", str3);
                    goto label_43;
                  }
                  else
                    goto label_46;
                }
                else
                  goto label_44;
              }
            }
            else
            {
              int num8;
              switch (num5)
              {
                case 250204863:
                  if (s == "//*[contains(@content-desc,'cover photo')]")
                    goto label_40;
                  else
                    goto label_44;
                case 273826655:
                  if (s == "//*[@content-desc='Photo']")
                  {
                    List<string> source = gclass27_0.method_37(0, "", str4);
                    if (source.Count > 1)
                      source = source.GetRange(0, source.Count - 1);
                    string string_11 = source.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).FirstOrDefault<string>();
                    gclass27_0.method_66(string_11);
                    flag3 = true;
                    goto label_39;
                  }
                  else
                    goto label_44;
                case 281629319:
                  num8 = !(s == "//*[@text='Tap to retry']") ? 1 : 0;
                  break;
                default:
                  num8 = 1;
                  break;
              }
              if (num8 == 0)
              {
                if (num3 < num4)
                {
                  ++num3;
                  gclass27_0.method_78(-1);
                }
                else
                  break;
              }
              else
                goto label_44;
label_39:
              goto label_43;
            }
label_40:
            if (!(str4 == "//*[contains(@content-desc,'cover photo')]" & flag3))
            {
              this.method_184(int_4, string_0_3 + "Tap " + gclass27_0.method_151(str4) + "...");
              gclass27_0.method_60(str4, str3);
            }
            else
            {
              flag1 = true;
              break;
            }
label_43:
            gclass27_0.SleepSeconds(2.0);
            continue;
label_44:
            this.method_184(int_4, string_0_3 + "Scroll...");
            if (gclass27_0.method_78())
            {
              switch (this.method_32(gclass27_0, int_4, string_0_3))
              {
                case 0:
                  goto label_43;
                case 1:
                  goto label_46;
                default:
                  goto label_49;
              }
            }
            else
              goto label_43;
          }
          while (Environment.TickCount - tickCount < 300000);
          break;
label_46:;
        }
      }
      catch
      {
      }
label_49:;
    }
    return flag1 ? 1 : 0;
  }

  private int method_55(int int_4, string string_0, GClass27 gclass27_0, string string_1)
  {
    string string_12 = this.method_191(int_4, "cPassword");
    if (string_12 == "")
    {
      this.method_184(int_4, string_0 + GClass35.smethod_0("Không có password"));
      return 0;
    }
    string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
    this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đang chạy..."));
    int num1 = 2;
    int num2 = 0;
    int num3 = 2;
    int num4 = 0;
    int num5 = 6;
label_24:
    while (this.method_215(gclass27_0, int_4, string_0_1, "fb://facewebmodal/f?href=https://mbasic.facebook.com/settings/sms/?ref_component=mbasic_bookmark&ref_page=XMenuController"))
    {
      int tickCount = Environment.TickCount;
      do
      {
        string str = gclass27_0.method_53();
        string string_11 = gclass27_0.method_29(0, str, new List<string>()
        {
          "//android.widget.ProgressBar",
          "//*[@text='Tap to retry']",
          "//*[@text='Remove']",
          "//android.widget.CheckBox[@text='I understand I could lose access to my account']",
          "//*[@text='Remove phone'][@focused='false']",
          "//*[@text='Remove phone'][@focused='true']"
        });
        switch (string_11)
        {
          case "//*[@text='Remove']":
            if (!str.Contains("you can't delete the primary phone number if we don't have other contact info for you. Please add another phone or add an email address to your account"))
            {
              this.method_184(int_4, string_0_1 + "Tap " + gclass27_0.method_151(string_11) + "...");
              gclass27_0.method_60(string_11, str);
              break;
            }
            goto label_6;
          case "//*[@text='Tap to retry']":
            if (num4 < num5)
            {
              ++num4;
              gclass27_0.method_78(-1);
              break;
            }
            goto label_25;
          case "//android.widget.ProgressBar":
            this.method_184(int_4, string_0_1 + "Loading...");
            break;
          case "//*[@text='Remove phone'][@focused='true']":
            if (!str.Contains("Incorrect password"))
              break;
            goto label_16;
          case "//*[@text='Remove phone'][@focused='false']":
            gclass27_0.method_50("//android.widget.EditText", string_12);
            gclass27_0.SleepSeconds(2.0);
            this.method_184(int_4, string_0_1 + "Tap " + gclass27_0.method_151(string_11) + "...");
            gclass27_0.method_60(string_11, str);
            break;
          case "//android.widget.CheckBox[@text='I understand I could lose access to my account']":
            gclass27_0.method_60("//android.widget.CheckBox[@text='I understand I could lose access to my account'][@checked='false']", str);
            gclass27_0.SleepSeconds(2.0);
            gclass27_0.method_60("//*[@text='Remove Number']", str);
            break;
          default:
            if (!gclass27_0.method_146(str, "Add a Mobile Number", "Add Number", "Add phone number"))
            {
              if (!gclass27_0.method_146(str, "This content is no longer available"))
              {
                this.method_184(int_4, string_0_1 + "Scroll...");
                if (gclass27_0.method_78())
                {
                  switch (this.method_32(gclass27_0, int_4, string_0_1))
                  {
                    case 0:
                      break;
                    case 1:
                      goto label_24;
                    default:
                      goto label_25;
                  }
                }
                else
                  break;
              }
              else
                goto label_21;
            }
            else
              goto label_11;
            break;
        }
        gclass27_0.SleepSeconds(2.0);
      }
      while (Environment.TickCount - tickCount < 300000);
      break;
label_6:
      num1 = 4;
      break;
label_11:
      num1 = 1;
      break;
label_16:
      num1 = 3;
      break;
label_21:
      if (num2 < num3)
      {
        ++num2;
      }
      else
      {
        num1 = 5;
        break;
      }
    }
label_25:
    return num1;
  }

  private int method_56(int int_4, string string_0, GClass27 gclass27_0, string string_1)
  {
    string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
    this.method_184(int_4, string_0_1 + GClass35.smethod_0("Đang chạy..."));
    int num1 = 2;
    int num2 = 0;
    int num3 = 6;
label_32:
    if (this.method_215(gclass27_0, int_4, string_0_1, "fb://facewebmodal/f?href=https://m.facebook.com/settings/subscribe/?settings_tracking=mbasic_footer_link%3Asettings_3_0_pecs&_rdr"))
    {
      int tickCount = Environment.TickCount;
      do
      {
        foreach (string string_11 in gclass27_0.method_37(0, "", "//android.view.View[@resource-id='m_check_list_aria_label']/parent::*/*[@text='Public']"))
          gclass27_0.method_66(string_11);
        string str = gclass27_0.method_53();
        string string_11_1 = gclass27_0.method_29(0, str, new List<string>()
        {
          "//android.widget.ProgressBar",
          "//*[@text='Tap to retry']",
          "//android.view.View[@resource-id='m_check_list_aria_label']/parent::*/*[@text='Public']",
          "//android.widget.CheckBox[@text='I understand I could lose access to my account']",
          "//android.widget.Button[@text='Remove phone'][@focused='false']",
          "//android.widget.Button[@text='Remove phone'][@focused='true']",
          "//android.widget.Button[@text='Add Number']"
        });
        string s = string_11_1;
        // ISSUE: reference to a compiler-generated method
        uint num4 = Class206.smethod_0(s);
        if (num4 <= 1240253437U)
        {
          if (num4 != 281629319U)
          {
            switch (num4)
            {
              case 532719482:
                if (s == "//android.widget.ProgressBar")
                {
                  this.method_184(int_4, string_0_1 + "Loading...");
                  goto label_31;
                }
                else
                  break;
              case 1240253437:
                if (s == "//android.widget.Button[@text='Remove phone'][@focused='false']")
                  goto label_31;
                else
                  break;
            }
          }
          else if (s == "//*[@text='Tap to retry']")
          {
            if (num2 < num3)
            {
              ++num2;
              gclass27_0.method_78(-1);
              goto label_31;
            }
            else
              break;
          }
        }
        else if (num4 <= 3058708030U)
        {
          switch (num4)
          {
            case 2264810661:
              if (s == "//android.widget.CheckBox[@text='I understand I could lose access to my account']")
              {
                gclass27_0.method_60("//android.widget.CheckBox[@text='I understand I could lose access to my account'][@checked='false']", str);
                gclass27_0.SleepSeconds(2.0);
                gclass27_0.method_60("//android.widget.Button[@text='Remove Number']", str);
                goto label_31;
              }
              else
                break;
            case 3058708030:
              if (s == "//android.view.View[@resource-id='m_check_list_aria_label']/parent::*/*[@text='Public']")
              {
                gclass27_0.method_60(string_11_1, str);
                goto label_31;
              }
              else
                break;
          }
        }
        else if (num4 != 4038011690U)
        {
          if (num4 == 4151471674U && s == "//android.widget.Button[@text='Add Number']")
          {
            num1 = 1;
            break;
          }
        }
        else if (s == "//android.widget.Button[@text='Remove phone'][@focused='true']")
        {
          if (str.Contains("Incorrect password"))
          {
            num1 = 3;
            break;
          }
          goto label_31;
        }
        this.method_184(int_4, string_0_1 + "Scroll...");
        if (gclass27_0.method_78())
        {
          int num5 = this.method_32(gclass27_0, int_4, string_0_1);
          if (num5 != 1)
          {
            if (num5 != 0)
              break;
          }
          else
            goto label_32;
        }
label_31:
        gclass27_0.SleepSeconds(2.0);
      }
      while (Environment.TickCount - tickCount < 300000);
    }
    return num1;
  }

  private int method_57(
    ref int int_4,
    int int_5,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    this.method_191(int_5, "cId");
    string string_12 = this.method_191(int_5, "cPassword");
    if (!(string_12 == ""))
    {
      string str1;
      if (gclass22_0.method_3("typeMatKhau") == 0)
      {
        str1 = GClass19.smethod_59(10, this.random_0);
      }
      else
      {
        string str2 = gclass22_0.method_2("txtMatKhau").OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text3 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text3 => string_0)).FirstOrDefault<string>();
        if (!string.IsNullOrEmpty(str2))
        {
          if (str2.Contains("*"))
          {
            string[] strArray = str2.Split('*');
            str1 = strArray[0];
            for (int index = 1; index < strArray.Length; ++index)
              str1 = str1 + GClass19.smethod_60(1, this.random_0) + strArray[index];
          }
          else
            str1 = str2;
        }
        else
          goto label_39;
      }
      gclass22_0.method_3("nudTimeOut", 30);
      bool flag = gclass22_0.method_4("ckbDangXuatThietBiCu");
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_5, string_0_1 + GClass35.smethod_0("Đang chạy..."));
      int_4 = 2;
      int num1 = 0;
      int num2 = 6;
label_37:
      if (this.method_215(gclass27_0, int_5, string_0_1, "fb://security_settings"))
      {
        int num3 = 0;
        int tickCount = Environment.TickCount;
        do
        {
          string string_11_1 = gclass27_0.method_53();
          string string_11_2 = gclass27_0.method_29(0, string_11_1, new List<string>()
          {
            "//android.widget.EditText",
            "//*[@text='Change password' or @content-desc='Change password']",
            "//*[@text='Log out of other devices?']",
            "//*[@text='Log out']",
            "//android.widget.ProgressBar",
            "//*[@text='Tap to retry']"
          });
          switch (string_11_2)
          {
            case "//*[@text='Change password' or @content-desc='Change password']":
            case "//*[@text='Log out']":
              this.method_184(int_5, string_0_1 + "Tap " + gclass27_0.method_151(string_11_2) + "...");
              gclass27_0.method_60(string_11_2, string_11_1);
              if (!(string_11_2 == "//*[@text='Log out']"))
                break;
              goto label_38;
            case "//*[@text='Tap to retry']":
              if (num1 < num2)
              {
                ++num1;
                gclass27_0.method_78(-1);
                break;
              }
              int_4 = 4;
              goto label_38;
            case "//android.widget.ProgressBar":
              this.method_184(int_5, string_0_1 + "Loading...");
              break;
            case "//*[@text='Log out of other devices?']":
              int_4 = 1;
              this.method_187(int_5, "cPassword", str1, "pass");
              if (gclass27_0.method_31(0, string_11_1, "//*[@text=\"WHERE YOU'RE LOGGED IN\"]"))
              {
                if (!gclass27_0.method_31(0, string_11_1, "//*[@text='Log out of all sessions']"))
                {
                  do
                  {
                    this.method_184(int_5, string_0_1 + "Scroll...");
                    if (!gclass27_0.method_78())
                    {
                      gclass27_0.SleepSeconds(2.0);
                      string_11_1 = "";
                    }
                    else
                      break;
                  }
                  while (!gclass27_0.method_33(0, ref string_11_1, "//*[@text='Log out of all sessions']"));
                }
                gclass27_0.method_60("//*[@text='Log out of all sessions']", string_11_1);
                break;
              }
              if (!flag)
              {
                gclass27_0.method_60("//*[@text='stay logged in']", string_11_1);
                gclass27_0.SleepSeconds(2.0);
                gclass27_0.method_60("//*[@text='Continue']", string_11_1);
                goto label_38;
              }
              else
              {
                gclass27_0.method_60("//*[@text='Review other devices']", string_11_1);
                gclass27_0.SleepSeconds(2.0);
                gclass27_0.method_60("//*[@text='Continue']", string_11_1);
                break;
              }
            case "//android.widget.EditText":
              if (num3 > 0)
              {
                if (!(gclass27_0.method_29(0, string_11_1, new List<string>()
                {
                  "//*[@text='Enter a valid password and try again.']",
                  "//*[@text='Your old password was incorrectly typed.']"
                }) != ""))
                {
                  if (gclass27_0.method_146(string_11_1, "Password must differ from old password"))
                  {
                    int_4 = 5;
                    goto label_38;
                  }
                  else
                    goto label_36;
                }
                else
                {
                  int_4 = 3;
                  goto label_38;
                }
              }
              else
              {
                ++num3;
                gclass27_0.method_50("(//android.widget.EditText)[1]", string_12);
                gclass27_0.SleepSeconds(1.0);
                gclass27_0.method_50("(//android.widget.EditText)[2]", str1);
                gclass27_0.SleepSeconds(1.0);
                gclass27_0.method_50("(//android.widget.EditText)[3]", str1);
                gclass27_0.SleepSeconds(1.0);
                gclass27_0.method_60("//*[@text='Save changes' or @content-desc='Update Password']", string_11_1);
                break;
              }
            default:
              int num4 = this.method_32(gclass27_0, int_5, string_0_1);
              if (num4 != 1)
              {
                if (num4 == 0)
                  break;
                goto label_38;
              }
              else
                goto label_37;
          }
          gclass27_0.SleepSeconds(2.0);
label_36:;
        }
        while (Environment.TickCount - tickCount < 300000);
      }
label_38:;
    }
label_39:
    return 1;
  }

  private int method_58(
    ref int int_4,
    int int_5,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    this.method_191(int_5, "cId");
    string string_12_1 = this.method_191(int_5, "cPassword");
    if (!(string_12_1 == ""))
    {
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      List<string> stringList3 = new List<string>();
      List<string> source1;
      List<string> source2;
      List<string> source3;
      if (gclass22_0.method_3("typeDatTen") == 1)
      {
        source1 = gclass22_0.method_2("lstHo");
        source2 = gclass22_0.method_2("lstTenDem");
        source3 = gclass22_0.method_2("lstTen");
      }
      else if (gclass22_0.method_3("typeTenRandom") == 0)
      {
        source1 = Class44.smethod_3();
        source2 = Class44.smethod_4();
        source3 = Class44.smethod_5();
      }
      else
      {
        source1 = Class44.smethod_7();
        source2 = new List<string>();
        source3 = Class44.smethod_8();
      }
      string string_12_2 = "";
      string string_12_3 = source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>();
      if (source2.Count > 0)
        string_12_2 = source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).First<string>();
      string string_12_4 = source3.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_4 => Guid.NewGuid())).First<string>();
      string string_0 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_5, string_0 + GClass35.smethod_0("Đang chạy..."));
      int_4 = 2;
      int num1 = 0;
      int num2 = 6;
label_43:
      if (this.method_215(gclass27_0, int_5, string_0, "fb://settings"))
      {
        int tickCount = Environment.TickCount;
        do
        {
          string str = gclass27_0.method_53();
          string string_11 = gclass27_0.method_29(0, str, new List<string>()
          {
            "//android.widget.ProgressBar",
            "//*[@text='Tap to retry']",
            "//*[@content-desc='Personal and account information']",
            "//*[contains(@text, \"You can't change your name on Facebook right now\")]",
            "//*[@text='Something went wrong. We're working on getting it fixed as soon as we can.']",
            "//*[@text='Review Change']",
            "//*[@text='Incorrect password.']",
            "//*[@text='Save changes']",
            "//*[@text='Name']",
            "//*[@text='Preview Your New Name']"
          });
          string s = string_11;
          // ISSUE: reference to a compiler-generated method
          uint num3 = Class206.smethod_0(s);
          if (num3 > 1042405475U)
          {
            if (num3 <= 1706730051U)
            {
              if (num3 != 1076335294U)
              {
                if (num3 == 1706730051U && s == "//*[contains(@text, \"You can't change your name on Facebook right now\")]")
                {
                  int_4 = 4;
                  break;
                }
                goto label_41;
              }
              else
              {
                if (s == "//*[@text='Something went wrong. We're working on getting it fixed as soon as we can.']")
                {
                  int_4 = 5;
                  break;
                }
                goto label_41;
              }
            }
            else if (num3 != 2517234137U)
            {
              if (num3 != 2597739800U)
              {
                if (num3 == 3711050133U && s == "//*[@text='Review Change']")
                {
                  gclass27_0.method_50("(//android.widget.EditText)[1]", string_12_3);
                  gclass27_0.SleepSeconds(1.0);
                  gclass27_0.method_50("(//android.widget.EditText)[2]", string_12_2);
                  gclass27_0.SleepSeconds(1.0);
                  gclass27_0.method_50("(//android.widget.EditText)[3]", string_12_4);
                  gclass27_0.SleepSeconds(1.0);
                  gclass27_0.method_60(string_11, str);
                  gclass27_0.SleepSeconds(3.0);
                }
                else
                  goto label_41;
              }
              else if (!(s == "//*[@text='Name']"))
                goto label_41;
              else
                goto label_40;
            }
            else
            {
              if (s == "//*[@text='Preview Your New Name']")
              {
                int_4 = 1;
                break;
              }
              goto label_41;
            }
          }
          else if (num3 <= 322623071U)
          {
            if (num3 != 281629319U)
            {
              if (num3 == 322623071U && s == "//*[@text='Save changes']")
              {
                gclass27_0.method_50("//android.widget.EditText", string_12_1);
                gclass27_0.SleepSeconds(1.0);
                gclass27_0.method_60(string_11, str);
              }
              else
                goto label_41;
            }
            else if (s == "//*[@text='Tap to retry']")
            {
              if (num1 < num2)
              {
                ++num1;
                gclass27_0.method_78(-1);
              }
              else
                break;
            }
            else
              goto label_41;
          }
          else
          {
            if (num3 != 532719482U)
            {
              if (num3 != 937661789U)
              {
                if (num3 == 1042405475U && s == "//*[@text='Incorrect password.']")
                {
                  int_4 = 3;
                  break;
                }
              }
              else if (s == "//*[@content-desc='Personal and account information']")
                goto label_40;
            }
            else if (s == "//android.widget.ProgressBar")
            {
              this.method_184(int_5, string_0 + "Loading...");
              goto label_39;
            }
            goto label_41;
          }
label_39:
          gclass27_0.SleepSeconds(2.0);
          continue;
label_40:
          gclass27_0.method_60(string_11, str);
          goto label_39;
label_41:
          int num4 = this.method_32(gclass27_0, int_5, string_0);
          if (num4 != 1)
          {
            if (num4 == 0)
              goto label_39;
            else
              break;
          }
          else
            goto label_43;
        }
        while (Environment.TickCount - tickCount < 300000);
      }
    }
    return 1;
  }

  private int method_59(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    bool flag1 = gclass22_0.method_4("ckbBio");
    bool flag2 = gclass22_0.method_4("ckbWork");
    bool flag3 = gclass22_0.method_4("ckbHighSchool");
    bool flag4 = gclass22_0.method_4("ckbCollege");
    bool flag5 = gclass22_0.method_4("ckbCurrentCity");
    bool flag6 = gclass22_0.method_4("ckbHometown");
    bool flag7 = gclass22_0.method_4("ckbRelationship");
    bool flag8 = gclass22_0.method_4("ckbGender");
    bool flag9 = gclass22_0.method_4("ckbBirthday");
    List<string> source1 = gclass22_0.method_2("txtBio", gclass22_0.method_3("typeSplitBio"));
    List<string> source2 = gclass22_0.method_2("lstWork");
    List<string> source3 = gclass22_0.method_2("lstHighSchool");
    List<string> source4 = gclass22_0.method_2("lstCollege");
    List<string> source5 = gclass22_0.method_2("lstCurrentCity");
    List<string> source6 = gclass22_0.method_2("lstHometown");
    string str1 = ((IEnumerable<string>) gclass22_0.method_1("cbbRelationship").Split('|')).ToList<string>().smethod_10();
    bool flag10 = gclass22_0.method_4("ckbSkipWhenHave");
    string str2 = ((IEnumerable<string>) gclass22_0.method_1("cbbGender").Split('|')).ToList<string>().smethod_10();
    List<string> source7 = gclass22_0.method_2("lstDay");
    List<string> source8 = gclass22_0.method_2("lstMonth");
    List<string> source9 = gclass22_0.method_2("lstYear");
    string string_0_16 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
    this.method_184(int_4, string_0_16 + GClass35.smethod_0("Đang chạy..."));
    if (flag1)
    {
      int num1 = 0;
      int num2 = 6;
      this.method_184(int_4, string_0_16 + GClass35.smethod_0("Cập nhật") + " Bio...");
label_16:
      if (this.method_215(gclass27_0, int_4, string_0_16, "fb://profile_edit"))
      {
        bool flag11 = false;
        int tickCount = Environment.TickCount;
        do
        {
          string str3 = gclass27_0.method_53();
          string str4 = gclass27_0.method_29(0, str3, new List<string>()
          {
            "//android.widget.ProgressBar",
            "//*[@text='Tap to retry']",
            "//*[contains(@content-desc, 'Tap to edit bio')]",
            "//android.widget.EditText",
            "//*[@text='Edit']",
            "//*[@content-desc='Edit Bio']"
          });
          switch (str4)
          {
            case "//*[contains(@content-desc, 'Tap to edit bio')]":
            case "//*[@text='Edit']":
            case "//*[@content-desc='Edit Bio']":
              if ((!flag10 || !(str4 == "//*[@content-desc='Edit Bio']")) && !flag11)
              {
                if (str4 == "//*[@text='Edit']")
                {
                  Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str3, "//*[@text='Bio']").First<string>(), gclass27_0.method_37(0, str3, str4));
                  if (class77 != null)
                  {
                    gclass27_0.method_66(class77.method_0());
                    break;
                  }
                  break;
                }
                gclass27_0.method_60(str4, str3);
                break;
              }
              goto label_113;
            case "//*[@text='Tap to retry']":
              if (num1 < num2)
              {
                ++num1;
                gclass27_0.method_78(-1);
                break;
              }
              goto label_17;
            case "//android.widget.ProgressBar":
              this.method_184(int_4, string_0_16 + "Loading...");
              break;
            case "//android.widget.EditText":
              string string_12 = GClass19.smethod_28(source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>());
              gclass27_0.method_50(str4, string_12);
              gclass27_0.SleepSeconds(3.0);
              gclass27_0.method_60("//*[@text='Save' or @content-desc='Save']", str3);
              flag11 = true;
              break;
            default:
              int num3 = this.method_32(gclass27_0, int_4, string_0_16);
              if (num3 != 1)
              {
                if (num3 == 0)
                  break;
                goto label_17;
              }
              else
                goto label_16;
          }
          gclass27_0.SleepSeconds(2.0);
        }
        while (Environment.TickCount - tickCount < 300000);
        goto label_113;
      }
    }
    else
      goto label_113;
label_17:
    return 1;
label_113:
    if (flag2)
    {
      int num4 = 0;
      int num5 = 6;
      this.method_184(int_4, string_0_16 + GClass35.smethod_0("Cập nhật") + " Work...");
      int num6;
      do
      {
        if (gclass27_0.method_146("", "Edit Profile", "Edit Details") || this.method_215(gclass27_0, int_4, string_0_16, "fb://profile_edit"))
        {
          bool flag12 = false;
          int tickCount = Environment.TickCount;
          do
          {
            string str5 = gclass27_0.method_53();
            string string_11 = gclass27_0.method_29(0, str5, new List<string>()
            {
              "//android.widget.ProgressBar",
              "//*[@text='Tap to retry']",
              "//*[@text='Edit']",
              "//*[@text='Add']",
              "//*[@text='Add work']",
              "//*[@text='Workplace Name']",
              "//android.widget.EditText[@text='Select workplace']",
              "//*[@text='Edit Details']",
              "//*[@text='Save' or @content-desc='Save'][@enabled='true']"
            });
            string s = string_11;
            // ISSUE: reference to a compiler-generated method
            uint num7 = Class206.smethod_0(s);
            if (num7 > 1021549810U)
            {
              if (num7 <= 1252544463U)
              {
                if (num7 != 1087892284U)
                {
                  if (num7 != 1252544463U || !(s == "//*[@text='Add work']"))
                    goto label_149;
                }
                else if (s == "//*[@text='Save' or @content-desc='Save'][@enabled='true']")
                {
                  gclass27_0.method_60(string_11, str5);
                  flag12 = true;
                  goto label_150;
                }
                else
                  goto label_149;
              }
              else if (num7 != 1391936344U)
              {
                if (num7 != 1810015401U)
                {
                  if (num7 != 3204427031U || !(s == "//*[@text='Edit']"))
                    goto label_149;
                }
                else if (s == "//android.widget.EditText[@text='Select workplace']")
                {
                  gclass27_0.method_50(string_11, source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).First<string>());
                  gclass27_0.SleepSeconds(2.0);
                  List<string> source10 = gclass27_0.method_37(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
                  if (source10.Count > 0)
                  {
                    int num8;
                    if (source10.Count == 1)
                      num8 = gclass27_0.method_146("", "No Results Found") ? 1 : 0;
                    else
                      num8 = 0;
                    if (num8 == 0)
                    {
                      gclass27_0.method_66(source10.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_4 => Guid.NewGuid())).First<string>());
                      goto label_150;
                    }
                    else
                      break;
                  }
                  else
                    goto label_150;
                }
                else
                  goto label_149;
              }
              else if (!(s == "//*[@text='Workplace Name']"))
                goto label_149;
            }
            else if (num7 <= 532719482U)
            {
              if (num7 != 281629319U)
              {
                if (num7 == 532719482U && s == "//android.widget.ProgressBar")
                {
                  this.method_184(int_4, string_0_16 + "Loading...");
                  goto label_150;
                }
                else
                  goto label_149;
              }
              else if (s == "//*[@text='Tap to retry']")
              {
                if (num4 < num5)
                {
                  ++num4;
                  gclass27_0.method_78(-1);
                  goto label_150;
                }
                else
                  goto label_17;
              }
              else
                goto label_149;
            }
            else
            {
              if (num7 != 872652337U)
              {
                if (num7 == 1021549810U && s == "//*[@text='Add']")
                  goto label_143;
              }
              else if (!(s == "//*[@text='Edit Details']"))
                ;
              goto label_149;
            }
label_143:
            if ((!flag10 || !(string_11 == "//*[@text='Add work']") || !gclass27_0.method_31(0, str5, "//*[starts-with(@text,'Works at')]")) && !flag12)
            {
              if (string_11 == "//*[@text='Edit']" || string_11 == "//*[@text='Add']")
              {
                Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str5, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str5, "//*[@text='Edit']")) ?? Class77.smethod_0(gclass27_0.method_37(0, str5, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str5, "//*[@text='Add']"));
                if (class77 != null)
                {
                  gclass27_0.method_66(class77.method_0());
                  goto label_150;
                }
                else
                {
                  gclass27_0.method_76();
                  goto label_150;
                }
              }
              else
              {
                gclass27_0.method_60(string_11, str5);
                goto label_150;
              }
            }
            else
              break;
label_149:
            if (gclass27_0.method_78())
              goto label_152;
label_150:
            gclass27_0.SleepSeconds(2.0);
          }
          while (Environment.TickCount - tickCount < 300000);
          goto label_155;
label_152:
          num6 = this.method_32(gclass27_0, int_4, string_0_16);
        }
        else
          goto label_17;
      }
      while (num6 == 1);
      if (num6 != 0)
        goto label_17;
    }
label_155:
    if (flag3)
    {
      int num9 = 0;
      int num10 = 6;
      this.method_184(int_4, string_0_16 + GClass35.smethod_0("Cập nhật") + " High School...");
      int num11;
      do
      {
        if (gclass27_0.method_146("", "Edit Profile", "Edit Details") || this.method_215(gclass27_0, int_4, string_0_16, "fb://profile_edit"))
        {
          bool flag13 = false;
          int tickCount = Environment.TickCount;
          do
          {
            string str6 = gclass27_0.method_53();
            string string_11 = gclass27_0.method_29(0, str6, new List<string>()
            {
              "//android.widget.ProgressBar",
              "//*[@text='Tap to retry']",
              "//*[@text='Edit']",
              "//*[@text='Add']",
              "//*[@text='High School Name (Required)']",
              "//*[@text='Add a high school' or @text='Add high school']",
              "//android.widget.EditText[@text='Select school']",
              "//*[@text='Edit Details']",
              "//*[@text='Save' or @content-desc='Save'][@enabled='true']"
            });
            string s = string_11;
            // ISSUE: reference to a compiler-generated method
            uint num12 = Class206.smethod_0(s);
            if (num12 > 872652337U)
            {
              if (num12 <= 1087892284U)
              {
                if (num12 != 1021549810U)
                {
                  if (num12 == 1087892284U && s == "//*[@text='Save' or @content-desc='Save'][@enabled='true']")
                  {
                    gclass27_0.method_60(string_11, str6);
                    flag13 = true;
                    goto label_185;
                  }
                }
                else if (s == "//*[@text='Add']")
                  goto label_186;
              }
              else if (num12 != 2331951731U)
              {
                if (num12 != 2980637099U)
                {
                  if (num12 == 3204427031U && s == "//*[@text='Edit']")
                    goto label_186;
                }
                else if (s == "//*[@text='Add a high school' or @text='Add high school']")
                  goto label_186;
              }
              else if (s == "//android.widget.EditText[@text='Select school']")
              {
                gclass27_0.method_50(string_11, source3.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_5 => Guid.NewGuid())).First<string>());
                gclass27_0.SleepSeconds(2.0);
                List<string> source11 = gclass27_0.method_37(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
                if (source11.Count > 0)
                {
                  int num13;
                  if (source11.Count == 1)
                    num13 = gclass27_0.method_146("", "No Results Found") ? 1 : 0;
                  else
                    num13 = 0;
                  if (num13 == 0)
                  {
                    gclass27_0.method_66(source11.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_6 => Guid.NewGuid())).First<string>());
                    goto label_185;
                  }
                  else
                    break;
                }
                else
                  goto label_185;
              }
            }
            else if (num12 <= 281629319U)
            {
              if (num12 != 187204304U)
              {
                if (num12 == 281629319U && s == "//*[@text='Tap to retry']")
                {
                  if (num9 < num10)
                  {
                    ++num9;
                    gclass27_0.method_78(-1);
                    goto label_185;
                  }
                  else
                    goto label_17;
                }
              }
              else if (s == "//*[@text='High School Name (Required)']")
                goto label_186;
            }
            else if (num12 != 532719482U)
            {
              if (num12 != 872652337U || !(s == "//*[@text='Edit Details']"))
                ;
            }
            else if (s == "//android.widget.ProgressBar")
            {
              this.method_184(int_4, string_0_16 + "Loading...");
              goto label_185;
            }
            if (gclass27_0.method_78())
              goto label_193;
label_185:
            gclass27_0.SleepSeconds(2.0);
            continue;
label_186:
            if ((!flag10 || !(string_11 == "//*[@text='Add a high school' or @text='Add high school']") || !gclass27_0.method_31(0, str6, "//*[starts-with(@text,'Studied at')]")) && !flag13)
            {
              if (string_11 == "//*[@text='Edit']" || string_11 == "//*[@text='Add']")
              {
                Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str6, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str6, "//*[@text='Edit']")) ?? Class77.smethod_0(gclass27_0.method_37(0, str6, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str6, "//*[@text='Add']"));
                if (class77 != null)
                {
                  gclass27_0.method_66(class77.method_0());
                  goto label_185;
                }
                else
                {
                  gclass27_0.method_76();
                  goto label_185;
                }
              }
              else
              {
                gclass27_0.method_60(string_11, str6);
                goto label_185;
              }
            }
            else
              break;
          }
          while (Environment.TickCount - tickCount < 300000);
          goto label_269;
label_193:
          num11 = this.method_32(gclass27_0, int_4, string_0_16);
        }
        else
          goto label_17;
      }
      while (num11 == 1);
      if (num11 != 0)
        goto label_17;
    }
label_269:
    if (flag4)
    {
      int num14 = 0;
      int num15 = 6;
      this.method_184(int_4, string_0_16 + GClass35.smethod_0("Cập nhật") + " College...");
      int num16;
      do
      {
        if (gclass27_0.method_146("", "Edit Profile", "Edit Details") || this.method_215(gclass27_0, int_4, string_0_16, "fb://profile_edit"))
        {
          bool flag14 = false;
          int tickCount = Environment.TickCount;
          do
          {
            string str7 = gclass27_0.method_53();
            string string_11 = gclass27_0.method_29(0, str7, new List<string>()
            {
              "//android.widget.ProgressBar",
              "//*[@text='Tap to retry']",
              "//*[@text='Edit']",
              "//*[@text='Add']",
              "//*[@text='College Name (Required)']",
              "//*[@text='Add a college' or @text='Add college']",
              "//android.widget.EditText[@text='Select school']",
              "//*[@text='Edit Details']",
              "//*[@text='Save' or @content-desc='Save'][@enabled='true']"
            });
            string s = string_11;
            // ISSUE: reference to a compiler-generated method
            uint num17 = Class206.smethod_0(s);
            if (num17 > 1021549810U)
            {
              if (num17 <= 2054847849U)
              {
                if (num17 != 1087892284U)
                {
                  if (num17 == 2054847849U && s == "//*[@text='Add a college' or @text='Add college']")
                    goto label_301;
                }
                else if (s == "//*[@text='Save' or @content-desc='Save'][@enabled='true']")
                {
                  gclass27_0.method_60(string_11, str7);
                  flag14 = true;
                  goto label_300;
                }
              }
              else if (num17 != 2331951731U)
              {
                if (num17 != 3079778049U)
                {
                  if (num17 == 3204427031U && s == "//*[@text='Edit']")
                    goto label_301;
                }
                else if (s == "//*[@text='College Name (Required)']")
                  goto label_301;
              }
              else if (s == "//android.widget.EditText[@text='Select school']")
              {
                gclass27_0.method_50(string_11, source4.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_7 => Guid.NewGuid())).First<string>());
                gclass27_0.SleepSeconds(2.0);
                List<string> source12 = gclass27_0.method_37(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
                if (source12.Count > 0)
                {
                  int num18;
                  if (source12.Count == 1)
                    num18 = gclass27_0.method_146("", "No Results Found") ? 1 : 0;
                  else
                    num18 = 0;
                  if (num18 == 0)
                  {
                    gclass27_0.method_66(source12.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_8 => Guid.NewGuid())).First<string>());
                    goto label_300;
                  }
                  else
                    break;
                }
                else
                  goto label_300;
              }
            }
            else if (num17 <= 532719482U)
            {
              if (num17 != 281629319U)
              {
                if (num17 == 532719482U && s == "//android.widget.ProgressBar")
                {
                  this.method_184(int_4, string_0_16 + "Loading...");
                  goto label_300;
                }
              }
              else if (s == "//*[@text='Tap to retry']")
              {
                if (num14 < num15)
                {
                  ++num14;
                  gclass27_0.method_78(-1);
                  goto label_300;
                }
                else
                  goto label_17;
              }
            }
            else if (num17 != 872652337U)
            {
              if (num17 == 1021549810U && s == "//*[@text='Add']")
                goto label_301;
            }
            else if (!(s == "//*[@text='Edit Details']"))
              ;
            if (gclass27_0.method_78())
              goto label_308;
label_300:
            gclass27_0.SleepSeconds(2.0);
            continue;
label_301:
            if ((!flag10 || !(string_11 == "//*[@text='Add a college' or @text='Add college']") || !gclass27_0.method_31(0, str7, "//*[starts-with(@text,'Studied at')]")) && !flag14)
            {
              if (string_11 == "//*[@text='Edit']" || string_11 == "//*[@text='Add']")
              {
                Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str7, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str7, "//*[@text='Edit']")) ?? Class77.smethod_0(gclass27_0.method_37(0, str7, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str7, "//*[@text='Add']"));
                if (class77 != null)
                {
                  gclass27_0.method_66(class77.method_0());
                  goto label_300;
                }
                else
                {
                  gclass27_0.method_76();
                  goto label_300;
                }
              }
              else
              {
                gclass27_0.method_60(string_11, str7);
                goto label_300;
              }
            }
            else
              break;
          }
          while (Environment.TickCount - tickCount < 300000);
          goto label_311;
label_308:
          num16 = this.method_32(gclass27_0, int_4, string_0_16);
        }
        else
          goto label_17;
      }
      while (num16 == 1);
      if (num16 != 0)
        goto label_17;
    }
label_311:
    if (flag5)
      goto label_312;
label_18:
    if (flag6)
    {
      int num19 = 0;
      int num20 = 6;
      this.method_184(int_4, string_0_16 + GClass35.smethod_0("Cập nhật") + " Hometown...");
      int num21;
      do
      {
        if (gclass27_0.method_146("", "Edit Profile", "Edit Details") || this.method_215(gclass27_0, int_4, string_0_16, "fb://profile_edit"))
        {
          string string_12 = "";
          bool flag15 = false;
          int tickCount = Environment.TickCount;
          do
          {
            string str8 = gclass27_0.method_53();
            string str9 = gclass27_0.method_29(0, str8, new List<string>()
            {
              "//android.widget.ProgressBar",
              "//*[@text='Tap to retry']",
              "//*[@text='Edit']",
              "//*[@text='Add']",
              "//*[@text='Add hometown']",
              "//android.widget.TextView[contains(@text,'From')]",
              "//*[@text='Edit hometown']",
              "//android.widget.EditText[@text='Select hometown']"
            });
            string s = str9;
            // ISSUE: reference to a compiler-generated method
            uint num22 = Class206.smethod_0(s);
            if (num22 > 1021549810U)
            {
              if (num22 <= 2007378049U)
              {
                if (num22 != 1134098073U)
                {
                  if (num22 != 2007378049U || !(s == "//*[@text='Add hometown']"))
                    goto label_53;
                  else
                    goto label_54;
                }
                else if (s == "//android.widget.TextView[contains(@text,'From')]")
                {
                  if (!flag10 && !flag15)
                  {
                    Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str8, str9).First<string>(), gclass27_0.method_37(0, str8, "//*[@content-desc='Edit']"));
                    if (class77 != null)
                    {
                      gclass27_0.method_66(class77.method_0());
                      goto label_52;
                    }
                    else
                      goto label_52;
                  }
                  else
                    break;
                }
                else
                  goto label_53;
              }
              else if (num22 != 2324930432U)
              {
                if (num22 != 3204427031U || !(s == "//*[@text='Edit']"))
                  goto label_53;
              }
              else if (s == "//android.widget.EditText[@text='Select hometown']")
              {
                string_12 = source6.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_9 => Guid.NewGuid())).First<string>();
                gclass27_0.method_50(str9, string_12);
                gclass27_0.SleepSeconds(2.0);
                List<string> source13 = gclass27_0.method_37(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
                if (source13.Count > 0)
                {
                  int num23;
                  if (source13.Count == 1)
                    num23 = gclass27_0.method_146("", "No Results Found") ? 1 : 0;
                  else
                    num23 = 0;
                  if (num23 == 0)
                  {
                    gclass27_0.method_66(source13.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_10 => Guid.NewGuid())).First<string>());
                    goto label_52;
                  }
                  else
                    break;
                }
                else
                  goto label_52;
              }
              else
                goto label_53;
            }
            else if (num22 <= 532719482U)
            {
              if (num22 != 281629319U)
              {
                if (num22 == 532719482U && s == "//android.widget.ProgressBar")
                {
                  this.method_184(int_4, string_0_16 + "Loading...");
                  goto label_52;
                }
                else
                  goto label_53;
              }
              else if (s == "//*[@text='Tap to retry']")
              {
                if (num19 < num20)
                {
                  ++num19;
                  gclass27_0.method_78(-1);
                  goto label_52;
                }
                else
                  goto label_17;
              }
              else
                goto label_53;
            }
            else
            {
              if (num22 != 540160250U)
              {
                if (num22 == 1021549810U && s == "//*[@text='Add']")
                  goto label_48;
              }
              else if (s == "//*[@text='Edit hometown']")
                goto label_54;
              goto label_53;
            }
label_48:
            if (!flag15)
            {
              Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str8, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str8, "//*[@text='Edit']")) ?? Class77.smethod_0(gclass27_0.method_37(0, str8, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str8, "//*[@text='Add']"));
              if (class77 != null)
                gclass27_0.method_66(class77.method_0());
              else
                gclass27_0.method_76();
            }
            else
              break;
label_52:
            gclass27_0.SleepSeconds(2.0);
            continue;
label_53:
            if (gclass27_0.method_78())
              goto label_62;
            else
              goto label_52;
label_54:
            if (string_12 != "")
            {
              gclass27_0.method_60("//*[@text='Save' or @content-desc='Save'][@enabled='true']", str8);
              flag15 = true;
              goto label_52;
            }
            else if (gclass27_0.method_31(0, str8, "//*[@text='Hometown Name (Required)']"))
            {
              gclass27_0.method_60("//*[@text='Hometown Name (Required)']", str8);
              goto label_52;
            }
            else
            {
              switch (str9)
              {
                case "//*[@text='Add hometown']":
                  gclass27_0.method_60(str9, str8);
                  goto label_52;
                case "//*[@text='Edit hometown']":
                  gclass27_0.method_60("//*[@content-desc='Remove hometown']", str8);
                  goto label_52;
                default:
                  goto label_52;
              }
            }
          }
          while (Environment.TickCount - tickCount < 300000);
          goto label_196;
label_62:
          num21 = this.method_32(gclass27_0, int_4, string_0_16);
        }
        else
          goto label_17;
      }
      while (num21 == 1);
      if (num21 != 0)
        goto label_17;
    }
label_196:
    if (flag7)
      goto label_197;
label_65:
    if (flag8 | flag9)
    {
      int num24 = 0;
      int num25 = 6;
      this.method_184(int_4, string_0_16 + GClass35.smethod_0("Cập nhật") + " Birthday/Gender...");
      while (this.method_215(gclass27_0, int_4, string_0_16, "fb://profile_edit"))
      {
        int tickCount = Environment.TickCount;
        do
        {
          string str10 = gclass27_0.method_53();
          string str11 = gclass27_0.method_29(0, str10, new List<string>()
          {
            "//android.widget.ProgressBar",
            "//*[@text='Tap to retry']",
            "//*[@text='Edit Your About Info']",
            "//*[@text='Basic info']",
            "//*[@text='Birthday']/parent::*/child::*[2]/child::*/child::*"
          });
          switch (str11)
          {
            case "//*[@text='Edit Your About Info']":
              this.method_184(int_4, string_0_16 + "Tap " + gclass27_0.method_151(str11) + "...");
              gclass27_0.method_60(str11, str10);
              break;
            case "//*[@text='Tap to retry']":
              if (num24 < num25)
              {
                ++num24;
                gclass27_0.method_78(-1);
                break;
              }
              goto label_112;
            case "//android.widget.ProgressBar":
              this.method_184(int_4, string_0_16 + "Loading...");
              break;
            case "//*[@text='Basic info']":
              Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str10, str11).First<string>(), gclass27_0.method_40(0, str10, new List<string>()
              {
                "//*[@text='Edit']"
              }));
              if (class77 != null)
              {
                gclass27_0.method_66(class77.method_0());
                break;
              }
              break;
            case "//*[@text='Birthday']/parent::*/child::*[2]/child::*/child::*":
              int num26;
              if (flag9)
                num26 = !gclass27_0.method_146(str10, "There is a limit to how many times you can change your birthday") ? 1 : 0;
              else
                num26 = 0;
              if (num26 != 0)
              {
                string string_0_17 = source8.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_11 => Guid.NewGuid())).FirstOrDefault<string>();
                if (!string.IsNullOrEmpty(string_0_17))
                {
                  gclass27_0.method_60(str11 + "[1]/child::*", str10);
                  gclass27_0.SleepSeconds(2.0);
                  string_0_17 = string_0_17.TrimStart('0');
                  if (string_0_17 == "12")
                  {
                    gclass27_0.method_78();
                    gclass27_0.SleepSeconds(2.0);
                  }
                  gclass27_0.method_60("//*[@text='" + GClass19.smethod_115(string_0_17) + "']");
                  gclass27_0.SleepSeconds(1.0);
                }
                string str12 = source7.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_12 => Guid.NewGuid())).FirstOrDefault<string>();
                if (!string.IsNullOrEmpty(str12))
                {
                  gclass27_0.method_60(str11 + "[2]/child::*");
                  gclass27_0.SleepSeconds(2.0);
                  str12 = str12.TrimStart('0');
                  if (!gclass27_0.method_60("//*[@text='" + str12 + "']"))
                  {
                    gclass27_0.method_78(-1, 3);
                    gclass27_0.SleepSeconds(2.0);
                    for (int index = 0; index < 3; ++index)
                    {
                      if (!gclass27_0.method_60("//*[@text='" + str12 + "']"))
                      {
                        gclass27_0.method_78();
                        gclass27_0.SleepSeconds(2.0);
                      }
                      else
                      {
                        gclass27_0.SleepSeconds(1.0);
                        break;
                      }
                    }
                  }
                }
                string str13 = source9.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_13 => Guid.NewGuid())).FirstOrDefault<string>();
                if (!string.IsNullOrEmpty(str13))
                {
                  gclass27_0.method_60("//*[@text='Birth Year']/parent::*/child::*[2]/child::*/child::*/child::*");
                  gclass27_0.SleepSeconds(2.0);
                  if (!gclass27_0.method_60("//*[@text='" + str13 + "']"))
                  {
                    gclass27_0.method_78(int_5: 5);
                    gclass27_0.SleepSeconds(2.0);
                    for (int index = 0; index < 5; ++index)
                    {
                      if (!gclass27_0.method_60("//*[@text='" + str13 + "']"))
                      {
                        gclass27_0.method_78(-1);
                        gclass27_0.SleepSeconds(2.0);
                      }
                      else
                      {
                        gclass27_0.SleepSeconds(1.0);
                        break;
                      }
                    }
                  }
                }
                gclass27_0.method_61(5, "//*[@text='I confirm that I am ']", "");
                this.method_187(int_4, "cBirthday", string_0_17 + "/" + str12 + "/" + str13, "birthday");
              }
              if (flag8)
                gclass27_0.method_61(5, "//*[@text='" + str2 + "']", "");
              for (int index = 0; index < 3 && !gclass27_0.method_60("//*[@text='Save']"); ++index)
              {
                gclass27_0.method_78();
                gclass27_0.SleepSeconds(2.0);
              }
              gclass27_0.method_117(60.0, "//*[@text='Cancel']");
              goto label_112;
            default:
              if (gclass27_0.method_78())
                goto label_110;
              else
                break;
          }
          gclass27_0.SleepSeconds(2.0);
        }
        while (Environment.TickCount - tickCount < 300000);
        break;
label_110:
        switch (this.method_32(gclass27_0, int_4, string_0_16))
        {
          case 1:
            continue;
          default:
            goto label_112;
        }
      }
label_112:
      goto label_17;
    }
    else
      goto label_17;
label_197:
    int num27 = 0;
    int num28 = 6;
    this.method_184(int_4, string_0_16 + GClass35.smethod_0("Cập nhật") + " Relationship...");
    int num29;
    do
    {
      if (gclass27_0.method_146("", "Edit Profile", "Edit Details") || this.method_215(gclass27_0, int_4, string_0_16, "fb://profile_edit"))
      {
        bool flag16 = false;
        bool flag17 = false;
        int tickCount = Environment.TickCount;
        do
        {
          string string_11 = gclass27_0.method_53();
          string str14 = gclass27_0.method_29(0, string_11, new List<string>()
          {
            "//android.widget.ProgressBar",
            "//*[@text='Tap to retry']",
            "//*[@text='Edit']",
            "//*[@text='Add']",
            "//*[@text='Add a relationship status']",
            "//*[@text='Relationship Status']",
            "//*[@text=\"Single\"]",
            "//*[@text=\"In a relationship\"]",
            "//*[@text=\"Engaged\"]",
            "//*[@text=\"Married\"]",
            "//*[@text=\"In a civil union\"]",
            "//*[@text=\"In a domestic partnership\"]",
            "//*[@text=\"In an open relationship\"]",
            "//*[@text=\"It's complicated\"]",
            "//*[@text=\"Separated\"]",
            "//*[@text=\"Divorced\"]",
            "//*[@text=\"Widowed\"]"
          });
          string s = str14;
          // ISSUE: reference to a compiler-generated method
          uint num30 = Class206.smethod_0(s);
          if (num30 > 1031124291U)
          {
            if (num30 <= 3204427031U)
            {
              if (num30 > 2195122918U)
              {
                int num31;
                switch (num30)
                {
                  case 2228260562:
                    if (!(s == "//*[@text=\"Widowed\"]"))
                      goto label_260;
                    else
                      goto label_252;
                  case 3204427031:
                    num31 = s == "//*[@text='Edit']" ? 1 : 0;
                    break;
                  default:
                    num31 = 0;
                    break;
                }
                if (num31 == 0)
                  goto label_260;
                else
                  goto label_261;
              }
              else
              {
                int num32;
                switch (num30)
                {
                  case 2079588125:
                    if (s == "//*[@text=\"In a civil union\"]")
                      goto label_252;
                    else
                      goto label_260;
                  case 2195122918:
                    num32 = !(s == "//*[@text=\"Separated\"]") ? 1 : 0;
                    break;
                  default:
                    num32 = 1;
                    break;
                }
                if (num32 != 0)
                  goto label_260;
              }
            }
            else if (num30 <= 3468505873U)
            {
              if (num30 != 3252945837U)
              {
                if (num30 == 3468505873U && s == "//*[@text='Add a relationship status']")
                {
                  gclass27_0.method_60(str14, string_11);
                  goto label_259;
                }
                else
                  goto label_260;
              }
              else if (!(s == "//*[@text=\"In a domestic partnership\"]"))
                goto label_260;
            }
            else if (num30 != 3876716033U)
            {
              if (num30 != 3937624089U)
              {
                if (num30 != 4217740579U || !(s == "//*[@text=\"It's complicated\"]"))
                  goto label_260;
              }
              else if (!(s == "//*[@text=\"Married\"]"))
                goto label_260;
            }
            else if (!(s == "//*[@text=\"Single\"]"))
              goto label_260;
          }
          else if (num30 <= 532719482U)
          {
            if (num30 <= 465737673U)
            {
              if (num30 != 281629319U)
              {
                if (num30 == 465737673U && s == "//*[@text='Relationship Status']")
                {
                  if (gclass27_0.method_31(0, string_11, "//*[@text='Save' or @content-desc='Save']"))
                  {
                    gclass27_0.method_60(str14, string_11);
                    goto label_259;
                  }
                  else
                  {
                    if (!gclass27_0.method_31(0, string_11, "//*[@text=\"" + str1 + "\"]"))
                    {
                      for (int index = 0; index < 5 && !gclass27_0.method_78(); ++index)
                      {
                        string_11 = "";
                        if (gclass27_0.method_33(0, ref string_11, "//*[@text=\"" + str1 + "\"]"))
                          break;
                      }
                    }
                    if (gclass27_0.method_60("//*[@text=\"" + str1 + "\"]", string_11))
                      flag17 = true;
                    goto label_259;
                  }
                }
                else
                  goto label_260;
              }
              else if (s == "//*[@text='Tap to retry']")
              {
                if (num27 < num28)
                {
                  ++num27;
                  gclass27_0.method_78(-1);
                  goto label_259;
                }
                else
                  goto label_17;
              }
              else
                goto label_260;
            }
            else if (num30 != 525520161U)
            {
              if (num30 == 532719482U && s == "//android.widget.ProgressBar")
              {
                this.method_184(int_4, string_0_16 + "Loading...");
                goto label_259;
              }
              else
                goto label_260;
            }
            else if (!(s == "//*[@text=\"In an open relationship\"]"))
              goto label_260;
          }
          else if (num30 <= 731756576U)
          {
            if (num30 != 669693435U)
            {
              if (num30 != 731756576U || !(s == "//*[@text=\"Engaged\"]"))
                goto label_260;
            }
            else if (!(s == "//*[@text=\"In a relationship\"]"))
              goto label_260;
          }
          else
          {
            if (num30 != 1021549810U)
            {
              if (num30 == 1031124291U && s == "//*[@text=\"Divorced\"]")
                goto label_252;
            }
            else if (s == "//*[@text='Add']")
              goto label_261;
            goto label_260;
          }
label_252:
          if (!flag16)
          {
            if (flag17)
            {
              gclass27_0.method_60("//*[@text='Save' or @content-desc='Save'][@enabled='true']", string_11);
              flag16 = true;
            }
            else
            {
              Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, string_11, str14).First<string>(), gclass27_0.method_37(0, string_11, "//*[@content-desc='Edit']"));
              if (class77 != null)
                gclass27_0.method_66(class77.method_0());
              else
                gclass27_0.method_60(str14, string_11);
            }
          }
          else
            break;
label_259:
          gclass27_0.SleepSeconds(2.0);
          continue;
label_260:
          if (gclass27_0.method_78())
            goto label_266;
          else
            goto label_259;
label_261:
          if (!flag16)
          {
            Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, string_11, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, string_11, "//*[@text='Edit']")) ?? Class77.smethod_0(gclass27_0.method_37(0, string_11, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, string_11, "//*[@text='Add']"));
            if (class77 != null)
            {
              gclass27_0.method_66(class77.method_0());
              goto label_259;
            }
            else
            {
              gclass27_0.method_76();
              goto label_259;
            }
          }
          else
            break;
        }
        while (Environment.TickCount - tickCount < 300000);
        goto label_65;
label_266:
        num29 = this.method_32(gclass27_0, int_4, string_0_16);
      }
      else
        goto label_17;
    }
    while (num29 == 1);
    if (num29 == 0)
      goto label_65;
    else
      goto label_17;
label_312:
    int num33 = 0;
    int num34 = 6;
    this.method_184(int_4, string_0_16 + GClass35.smethod_0("Cập nhật") + " Current City...");
    int num35;
    do
    {
      if (gclass27_0.method_146("", "Edit Profile", "Edit Details") || this.method_215(gclass27_0, int_4, string_0_16, "fb://profile_edit"))
      {
        string string_12 = "";
        bool flag18 = false;
        int tickCount = Environment.TickCount;
        do
        {
          string str15 = gclass27_0.method_53();
          string str16 = gclass27_0.method_29(0, str15, new List<string>()
          {
            "//android.widget.ProgressBar",
            "//*[@text='Tap to retry']",
            "//*[@text='Edit']",
            "//*[@text='Add']",
            "//*[@text='Add current city']",
            "//android.widget.TextView[contains(@text,'Lives in')]",
            "//*[@text='Edit current city']",
            "//android.widget.EditText[@text='Select current city']"
          });
          string s = str16;
          // ISSUE: reference to a compiler-generated method
          uint num36 = Class206.smethod_0(s);
          if (num36 > 1021549810U)
          {
            if (num36 <= 2144658411U)
            {
              if (num36 != 1715593925U)
              {
                if (num36 == 2144658411U && s == "//android.widget.TextView[contains(@text,'Lives in')]")
                {
                  if (!flag10 && !flag18)
                  {
                    Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str15, str16).First<string>(), gclass27_0.method_37(0, str15, "//*[@content-desc='Edit']"));
                    if (class77 != null)
                    {
                      gclass27_0.method_66(class77.method_0());
                      goto label_341;
                    }
                    else
                      goto label_341;
                  }
                  else
                    break;
                }
                else
                  goto label_342;
              }
              else if (!(s == "//*[@text='Edit current city']"))
                goto label_342;
            }
            else if (num36 != 2516121178U)
            {
              if (num36 != 3204427031U || !(s == "//*[@text='Edit']"))
                goto label_342;
              else
                goto label_350;
            }
            else if (!(s == "//*[@text='Add current city']"))
              goto label_342;
            if (string_12 != "")
            {
              gclass27_0.method_60("//*[@text='Save' or @content-desc='Save'][@enabled='true']", str15);
              flag18 = true;
            }
            else if (gclass27_0.method_31(0, str15, "//*[@text='Add Current City (Required)']"))
            {
              gclass27_0.method_60("//*[@text='Add Current City (Required)']", str15);
            }
            else
            {
              switch (str16)
              {
                case "//*[@text='Add current city']":
                  gclass27_0.method_60(str16, str15);
                  break;
                case "//*[@text='Edit current city']":
                  gclass27_0.method_60("//*[@content-desc='Remove current city']", str15);
                  break;
              }
            }
          }
          else if (num36 <= 532719482U)
          {
            if (num36 != 281629319U)
            {
              if (num36 == 532719482U && s == "//android.widget.ProgressBar")
                this.method_184(int_4, string_0_16 + "Loading...");
              else
                goto label_342;
            }
            else if (s == "//*[@text='Tap to retry']")
            {
              if (num33 < num34)
              {
                ++num33;
                gclass27_0.method_78(-1);
              }
              else
                goto label_17;
            }
            else
              goto label_342;
          }
          else
          {
            if (num36 != 577862615U)
            {
              if (num36 == 1021549810U && s == "//*[@text='Add']")
                goto label_350;
            }
            else if (s == "//android.widget.EditText[@text='Select current city']")
            {
              string_12 = source5.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_14 => Guid.NewGuid())).First<string>();
              gclass27_0.method_50(str16, string_12);
              gclass27_0.SleepSeconds(2.0);
              List<string> source14 = gclass27_0.method_37(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
              if (source14.Count > 0)
              {
                int num37;
                if (source14.Count == 1)
                  num37 = gclass27_0.method_146("", "No Results Found") ? 1 : 0;
                else
                  num37 = 0;
                if (num37 == 0)
                {
                  gclass27_0.method_66(source14.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_15 => Guid.NewGuid())).First<string>());
                  goto label_341;
                }
                else
                  break;
              }
              else
                goto label_341;
            }
            goto label_342;
          }
label_341:
          gclass27_0.SleepSeconds(2.0);
          continue;
label_342:
          if (gclass27_0.method_78())
            goto label_355;
          else
            goto label_341;
label_350:
          if (!flag18)
          {
            Class77 class77 = Class77.smethod_0(gclass27_0.method_37(0, str15, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str15, "//*[@text='Edit']")) ?? Class77.smethod_0(gclass27_0.method_37(0, str15, "//*[@text='Details']").FirstOrDefault<string>(), gclass27_0.method_37(0, str15, "//*[@text='Add']"));
            if (class77 != null)
            {
              gclass27_0.method_66(class77.method_0());
              goto label_341;
            }
            else
            {
              gclass27_0.method_76();
              goto label_341;
            }
          }
          else
            break;
        }
        while (Environment.TickCount - tickCount < 300000);
        goto label_18;
label_355:
        num35 = this.method_32(gclass27_0, int_4, string_0_16);
      }
      else
        goto label_17;
    }
    while (num35 == 1);
    if (num35 == 0)
      goto label_18;
    else
      goto label_17;
  }

  private int method_60(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1_1,
    string string_2)
  {
    int num1 = 0;
    string str1 = this.method_191(int_4, "cUid");
    string string_0_12 = gclass27_0.method_114().Split('|')[1];
    if (string_0_12 == "")
      string_0_12 = this.method_191(int_4, "cCookies");
    try
    {
      string string_0_13 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_2 + ": ";
      bool flag1 = gclass22_0.method_4("ckbShareBaiLenTuong");
      bool flag2 = gclass22_0.method_4("ckbShareBaiLenNhom");
      bool flag3 = gclass22_0.method_4("ckbShareNhomNangCao");
      bool flag4 = gclass22_0.method_4("ckbChiShareNhomKKD");
      bool flag5 = gclass22_0.method_4("ckbUuTienShareNhomNhieuThanhVien");
      bool flag6 = gclass22_0.method_4("ckbBackupDanhSachNhom");
      bool flag7 = gclass22_0.method_4("ckbKhongShareTrungNhom");
      bool flag8 = gclass22_0.method_4("ckbChiShareNhomThuocDanhSach");
      List<string> stringList1 = GClass19.smethod_39(gclass22_0.method_2("lstNhomTuNhap"));
      int int_4_1 = gclass22_0.method_3("nudCountGroupFrom");
      int int_5_1 = gclass22_0.method_3("nudCountGroupTo");
      int num2 = gclass27_0.method_87(int_4_1, int_5_1);
      int minValue = gclass22_0.method_3("nudDelayFrom");
      int num3 = gclass22_0.method_3("nudDelayTo");
      List<string> stringList2 = GClass19.smethod_39(gclass22_0.method_2("txtLinkChiaSe"));
      if (!this.dictionary_17.ContainsKey(string_1_1))
        this.dictionary_17.Add(string_1_1, new List<string>());
      string string_1 = stringList2[int_4 % stringList2.Count];
      int num4 = gclass22_0.method_3("typeLinkShare");
      if (num4 == 2)
        num4 = 1;
      bool flag9 = gclass22_0.method_4("ckbVanBan");
      List<string> source1 = gclass22_0.method_2("txtNoiDung");
      bool flag10 = gclass22_0.method_4("ckbTuongTacTruocKhiShare");
      int int_5_2 = gclass22_0.method_3("nudSoLuongFrom");
      int int_6 = gclass22_0.method_3("nudSoLuongTo");
      bool bool_5 = gclass22_0.method_4("ckbInteract");
      string string_2_1 = gclass22_0.method_1("typeReaction");
      bool bool_6 = gclass22_0.method_4("ckbComment");
      List<string> list_18 = gclass22_0.method_2("txtComment");
      bool bool_7 = gclass22_0.method_4("ckbBinhLuanNhieuLan");
      int int_7 = gclass22_0.method_3("nudBinhLuanNhieuLanDelayFrom");
      int int_8 = gclass22_0.method_3("nudBinhLuanNhieuLanDelayTo");
      if (flag10)
      {
        this.method_184(int_4, string_0_13 + GClass35.smethod_0("Tương tác..."));
        if (num4 == 0)
          this.method_95(int_4, string_0_13, gclass27_0, string_1, int_5_2, int_6, bool_5, string_2_1, bool_6, list_18, bool_7, int_7, int_8);
        else
          this.method_112(int_4, string_0_13, gclass27_0, string_1, int_5_2, int_6, bool_5, string_2_1, bool_6, list_18, false, false, "");
      }
      if (flag1)
      {
label_13:
        this.method_184(int_4, string_0_1 + GClass35.smethod_0("Share Wall..."));
        if (num4 != 0)
        {
          this.method_184(int_4, string_0_13 + "Open post...");
          if (this.method_76(gclass27_0, int_4, string_0_13, string_1) == 1)
          {
            bool flag11 = false;
            int num5 = 600;
            int tickCount = Environment.TickCount;
            while (Environment.TickCount - tickCount < num5 * 1000)
            {
              string string_11_1 = "";
              string string_11_2 = gclass27_0.method_30(0, ref string_11_1, new List<string>()
              {
                "//*[@text='SHARE' or @content-desc='SHARE']",
                "//android.widget.EditText",
                "//android.widget.Toast[@text=\"Posting…\"]"
              });
              switch (string_11_2)
              {
                case "//android.widget.Toast[@text=\"Posting…\"]":
                  gclass27_0.SleepSeconds(1.0);
                  break;
                case "//android.widget.EditText":
                  if (!flag11)
                  {
                    this.method_184(int_4, string_0_13 + "Scroll...");
                    if (!gclass27_0.method_78() || !gclass27_0.method_104())
                      break;
                    break;
                  }
                  if (flag9 && source1.Count > 0)
                  {
                    string string_12 = GClass19.smethod_28(source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>(), this.random_0);
                    this.method_184(int_4, string_0_13 + GClass35.smethod_0("Nhập dữ liệu..."));
                    gclass27_0.method_50(string_11_2, string_12);
                    gclass27_0.SleepSeconds(1.0);
                  }
                  string string_11_3 = gclass27_0.method_40(0, "", new List<string>()
                  {
                    "//android.widget.Button[@text='POST']",
                    "//android.view.ViewGroup[@content-desc='Share Now']"
                  }).FirstOrDefault<string>();
                  if (!string.IsNullOrEmpty(string_11_3))
                  {
                    this.method_184(int_4, string_0_13 + "Tap Share now...");
                    gclass27_0.method_66(string_11_3);
                    goto label_49;
                  }
                  else
                    break;
                case "//*[@text='SHARE' or @content-desc='SHARE']":
                  this.method_184(int_4, string_0_13 + "Tap Share...");
                  if (!flag11)
                  {
                    gclass27_0.method_60(string_11_2, string_11_1);
                    flag11 = true;
                    break;
                  }
                  goto label_49;
                default:
                  this.method_184(int_4, string_0_13 + "Scroll...");
                  if (gclass27_0.method_78() && !gclass27_0.method_104())
                  {
                    switch (this.method_32(gclass27_0, int_4, string_0_13))
                    {
                      case 0:
                        break;
                      case 1:
                        goto label_13;
                      default:
                        goto label_179;
                    }
                  }
                  else
                    break;
                  break;
              }
              gclass27_0.SleepSeconds(1.0);
            }
          }
          else
            goto label_179;
        }
        else
        {
          this.method_184(int_4, string_0_13 + "Open livestream...");
          if (this.method_75(gclass27_0, int_4, string_0_13, string_1) == 1)
          {
            int num6 = 0;
            int num7 = 10;
            int num8 = 600;
            int tickCount = Environment.TickCount;
            while (Environment.TickCount - tickCount < num8 * 1000)
            {
              string string_11_4 = "";
              string str2 = gclass27_0.method_30(0, ref string_11_4, new List<string>()
              {
                "//*[@content-desc='SHARE' or @text='SHARE']",
                "//*[@text='INVITE' or @content-desc='INVITE']",
                "//*[@content-desc='Write Post']",
                "//android.widget.EditText",
                "//*[@content-desc='Play again' or @text='Play again']",
                "//*[@text='save your login info']"
              });
              switch (str2)
              {
                case "//android.widget.EditText":
                  if (flag9 && source1.Count > 0)
                  {
                    string string_12 = GClass19.smethod_28(source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).First<string>(), this.random_0);
                    this.method_184(int_4, string_0_13 + GClass35.smethod_0("Nhập dữ liệu..."));
                    gclass27_0.method_50(str2, string_12);
                    gclass27_0.SleepSeconds(1.0);
                  }
                  string string_11_5 = gclass27_0.method_40(0, "", new List<string>()
                  {
                    "//android.widget.Button[@text='POST']",
                    "//android.view.ViewGroup[@content-desc='Share Now']"
                  }).FirstOrDefault<string>();
                  if (!string.IsNullOrEmpty(string_11_5))
                  {
                    this.method_184(int_4, string_0_13 + "Tap Share now...");
                    gclass27_0.method_66(string_11_5);
                    goto label_48;
                  }
                  else
                    break;
                case "//*[@text='save your login info']":
                  gclass27_0.method_60("//android.widget.Button[@text='OK']", string_11_4);
                  break;
                case "//*[@text='INVITE' or @content-desc='INVITE']":
                  gclass27_0.method_28();
                  break;
                case "//*[@content-desc='Write Post']":
                case "//*[@content-desc='Play again' or @text='Play again']":
                  this.method_184(int_4, string_0_13 + "Tap " + Regex.Match(str2, "'(.*?)'").Groups[1].Value + "...");
                  gclass27_0.method_60(str2, string_11_4);
                  break;
                case "//*[@content-desc='SHARE' or @text='SHARE']":
                  if (num6 < num7)
                  {
                    ++num6;
                    this.method_184(int_4, string_0_13 + "Tap " + Regex.Match(str2, "'(.*?)'").Groups[1].Value + "...");
                    gclass27_0.method_60(str2, string_11_4);
                    break;
                  }
                  goto label_48;
                default:
                  switch (this.method_32(gclass27_0, int_4, string_0_13))
                  {
                    case 0:
                      if (gclass27_0.method_35(0, string_11_4).Where<string>((System.Func<string, bool>) (string_0_4 => !string_0_4.Contains(string.Format("[{0},{1}]", (object) gclass27_0.method_21(), (object) gclass27_0.method_20())))).Count<string>() == 0)
                      {
                        if (num6 < num7)
                        {
                          ++num6;
                          gclass27_0.method_55(140, 2460);
                          break;
                        }
                        goto label_48;
                      }
                      else
                        break;
                    case 1:
                      goto label_13;
                    default:
                      goto label_179;
                  }
                  break;
              }
              gclass27_0.SleepSeconds(1.0);
            }
label_48:;
          }
          else
            goto label_179;
        }
label_49:
        this.method_184(int_4, string_0_13 + "Share wall done, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue, num3 + 1));
      }
      if (flag2)
      {
        List<string> source2 = new List<string>();
        bool flag12 = false;
        if (flag3)
        {
          int num9 = 0;
          while (true)
          {
            if (num9 < 2)
            {
              if (num9 == 1)
              {
                int num10 = this.method_32(gclass27_0, int_4, string_0_1);
                if (num10 != 0 && num10 != 1)
                  goto label_81;
              }
              bool flag13 = true;
              List<string> stringList3 = new List<string>();
              if (flag6 && File.Exists("backupgroup\\" + str1 + ".txt"))
              {
                stringList3 = GClass19.smethod_7("backupgroup\\" + str1 + ".txt");
                if (stringList3.Count > 0)
                {
                  string[] strArray = stringList3[0].Split('|');
                  int num11;
                  if (strArray.Length >= 4)
                    num11 = !((IEnumerable<string>) new string[2]
                    {
                      "true",
                      "false"
                    }).Contains<string>(strArray[3].ToLower()) ? 1 : 0;
                  else
                    num11 = 1;
                  flag13 = num11 != 0;
                }
              }
              if (flag13)
              {
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Scan group..."));
                stringList3 = Class38.smethod_1(string_0_12, gclass27_0.string_8, gclass27_0.int_1, true);
              }
              if (stringList3.Count > 0)
              {
                if (flag6)
                  File.WriteAllLines("backupgroup\\" + str1 + ".txt", (IEnumerable<string>) stringList3);
                source2 = !flag4 ? stringList3.Select<string, string>((System.Func<string, string>) (string_0_5 => string_0_5)).ToList<string>() : stringList3.Where<string>((System.Func<string, bool>) (string_0_6 => string_0_6.Split('|')[3].ToLower() == "false")).ToList<string>();
                if (flag5)
                  source2.Sort((Comparison<string>) ((string_0_7, string_1_2) => int.Parse(string_1_2.Split('|')[2]).CompareTo(int.Parse(string_0_7.Split('|')[2]))));
                else
                  source2 = source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_8 => Guid.NewGuid())).ToList<string>();
                if (source2.Count <= 0)
                {
                  if (flag8)
                  {
                    for (int index = 0; index < source2.Count; ++index)
                    {
                      string str3 = source2[index].Split('|')[0];
                      if (!stringList1.Contains(str3))
                        source2.RemoveAt(index--);
                    }
                  }
                }
                else
                  break;
              }
              ++num9;
            }
            else
              break;
          }
          if (!(flag12 = flag4 | flag5 | flag7) || source2.Count != 0)
            goto label_177;
label_81:
          goto label_179;
        }
label_177:
label_82:
        this.method_184(int_4, string_0_1 + "Share Groups...");
        if (num4 != 0)
        {
          List<string> second = new List<string>();
          this.method_184(int_4, string_0_13 + "Open post...");
          if (this.method_76(gclass27_0, int_4, string_0_13, string_1) == 1)
          {
            bool flag14 = false;
            bool flag15 = false;
            int num12 = 600;
            int tickCount = Environment.TickCount;
            while (Environment.TickCount - tickCount < num12 * 1000)
            {
              string string_11_6 = "";
              string string_11_7 = gclass27_0.method_30(0, ref string_11_6, new List<string>()
              {
                "//*[@text='SHARE' or @content-desc='SHARE']",
                "//android.view.ViewGroup[@content-desc='Share to a group']",
                "//*[@content-desc='Share to a community']",
                "//android.widget.TextView[@text='Choose group']",
                "//android.widget.EditText",
                "//android.widget.Toast[@text=\"Posting…\"]"
              });
              switch (string_11_7)
              {
                case "//android.widget.Toast[@text=\"Posting…\"]":
                  gclass27_0.SleepSeconds(1.0);
                  break;
                case "//android.widget.EditText":
                  if (!flag14)
                  {
                    this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Scroll...", (object) num1, (object) num2));
                    if (!gclass27_0.method_78() || !gclass27_0.method_104())
                      break;
                    break;
                  }
                  if (!flag15)
                  {
                    List<string> source3 = gclass27_0.method_37(0, "", "//android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup");
                    if (source3.Count > 1)
                    {
                      gclass27_0.method_75(source3.Last<string>(), source3.First<string>());
                      break;
                    }
                    break;
                  }
                  if (flag9 && source1.Count > 0)
                  {
                    string string_12 = GClass19.smethod_28(source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_9 => Guid.NewGuid())).First<string>(), this.random_0);
                    this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, ", (object) num1, (object) num2) + GClass35.smethod_0("Nhập dữ liệu..."));
                    gclass27_0.method_50(string_11_7, string_12);
                    gclass27_0.SleepSeconds(1.0);
                  }
                  string string_11_8 = gclass27_0.method_40(0, "", new List<string>()
                  {
                    "//*[@content-desc='POST']"
                  }).FirstOrDefault<string>();
                  if (!string.IsNullOrEmpty(string_11_8))
                  {
                    this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Tap Post...", (object) num1, (object) num2));
                    gclass27_0.method_66(string_11_8);
                    ++num1;
                    if (num1 < num2)
                      this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, ", (object) num1, (object) num2) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue, num3 + 1));
                    else
                      goto label_175;
                  }
                  break;
                case "//android.widget.TextView[@text='Choose group']":
                  while (flag12)
                  {
                    if (source2.Count != 0)
                    {
                      string str4 = source2[0].Split('|')[0];
                      string string_12 = source2[0].Split('|')[1];
                      source2.RemoveAt(0);
                      if (flag7)
                      {
                        lock (this.dictionary_17)
                        {
                          if (!this.dictionary_17[string_1_1].Contains(str4))
                            this.dictionary_17[string_1_1].Add(str4);
                          else
                            continue;
                        }
                      }
                      gclass27_0.method_50("//android.widget.EditText", string_12);
                      gclass27_0.SleepSeconds(2.0);
                      break;
                    }
                    goto label_175;
                  }
                  string string_11_9 = "";
                  for (int index = 0; index < 30; ++index)
                  {
                    string_11_6 = gclass27_0.method_53();
                    List<string> first = gclass27_0.method_34(string_11_6, "//android.widget.ListView/android.widget.Button/android.view.ViewGroup", "content-desc");
                    if (first.Count > 0)
                    {
                      string_11_9 = first.Except<string>((IEnumerable<string>) second).OrderBy<string, Guid>((System.Func<string, Guid>) (string_0text9 => Guid.NewGuid())).Select<string, string>((System.Func<string, string>) (string_0text9 => string_0_1)).FirstOrDefault<string>();
                      if (string.IsNullOrEmpty(string_11_9))
                      {
                        this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Scroll...", (object) num1, (object) num2));
                        if (gclass27_0.method_78() && !gclass27_0.method_104())
                          goto label_175;
                      }
                      else
                        break;
                    }
                    else if (gclass27_0.method_31(0, string_11_6, "//*[@text='No Groups']"))
                    {
                      if (flag12)
                        goto case "//android.widget.TextView[@text='Choose group']";
                      else
                        goto label_175;
                    }
                    gclass27_0.SleepSeconds(1.0);
                  }
                  if (!string.IsNullOrEmpty(string_11_9))
                  {
                    second.Add(string_11_9);
                    if (gclass27_0.method_65(0, string_11_9, string_11_6))
                    {
                      this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Tap group...", (object) num1, (object) num2));
                      break;
                    }
                    break;
                  }
                  goto label_175;
                case "//android.view.ViewGroup[@content-desc='Share to a group']":
                case "//*[@content-desc='Share to a community']":
                  this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Tap Share to group...", (object) num1, (object) num2));
                  gclass27_0.method_60(string_11_7, string_11_6);
                  flag15 = true;
                  break;
                case "//*[@text='SHARE' or @content-desc='SHARE']":
                  this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Tap Share...", (object) num1, (object) num2));
                  gclass27_0.method_60(string_11_7, string_11_6);
                  flag14 = true;
                  break;
                default:
                  this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Scroll...", (object) num1, (object) num2));
                  if (gclass27_0.method_78() && !gclass27_0.method_104())
                  {
                    switch (this.method_32(gclass27_0, int_4, string_0_13))
                    {
                      case 0:
                        break;
                      case 1:
                        goto label_82;
                      default:
                        goto label_179;
                    }
                  }
                  else
                    break;
                  break;
              }
              gclass27_0.SleepSeconds(1.0);
            }
          }
          else
            goto label_179;
        }
        else
        {
          this.method_184(int_4, string_0_13 + "Open livestream...");
          if (this.method_75(gclass27_0, int_4, string_0_13, string_1) == 1)
          {
            int num13 = 0;
            int num14 = 10;
            int num15 = 600;
            int tickCount = Environment.TickCount;
            while (Environment.TickCount - tickCount < num15 * 1000)
            {
              string string_11_10 = "";
              string str5 = gclass27_0.method_30(0, ref string_11_10, new List<string>()
              {
                "//*[@content-desc='SHARE']",
                "//*[@text='INVITE' or @content-desc='INVITE']",
                "//android.widget.ImageButton[@content-desc='Share to Group']",
                "//*[@content-desc='Share to a community']",
                "//android.widget.EditText",
                "//*[@content-desc='Play again' or @text='Play again']",
                "//*[@text='save your login info']"
              });
              string s = str5;
              // ISSUE: reference to a compiler-generated method
              uint num16 = Class206.smethod_0(s);
              if (num16 > 1835260571U)
              {
                if (num16 <= 3206045620U)
                {
                  if (num16 != 1964222373U)
                  {
                    if (num16 == 3206045620U && s == "//*[@text='INVITE' or @content-desc='INVITE']")
                    {
                      gclass27_0.method_28();
                      goto label_173;
                    }
                  }
                  else if (s == "//android.widget.EditText")
                  {
                    if (flag9 && source1.Count > 0)
                    {
                      string string_12 = GClass19.smethod_28(source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_10 => Guid.NewGuid())).First<string>(), this.random_0);
                      this.method_184(int_4, string_0_13 + string.Format("{0}/{1} ", (object) num1, (object) num2) + GClass35.smethod_0("Nhập dữ liệu..."));
                      gclass27_0.method_50(str5, string_12);
                      gclass27_0.SleepSeconds(1.0);
                    }
                    int num17 = 0;
                    while (num1 < num2)
                    {
                      ++num17;
                      if (num17 % 6 != 0 || this.method_32(gclass27_0, int_4, string_0_1) == 0)
                      {
                        if (flag12)
                        {
                          while (source2.Count != 0)
                          {
                            string str6 = source2[0].Split('|')[0];
                            string string_12 = source2[0].Split('|')[1];
                            source2.RemoveAt(0);
                            if (flag7)
                            {
                              lock (this.dictionary_17)
                              {
                                if (!this.dictionary_17[string_1_1].Contains(str6))
                                  this.dictionary_17[string_1_1].Add(str6);
                                else
                                  continue;
                              }
                            }
                            gclass27_0.method_50("(//android.widget.EditText)[2]", string_12);
                            gclass27_0.SleepSeconds(2.0);
                            goto label_148;
                          }
                          goto label_179;
                        }
label_148:
                        string string_11_11 = "";
                        List<string> list_0 = gclass27_0.method_41(0, ref string_11_11, new List<string>()
                        {
                          "//android.widget.Button[@text='SHARE']",
                          "//*[@content-desc='POST']"
                        });
                        if (list_0.Count > 0)
                        {
                          this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Tap Share...", (object) num1, (object) num2));
                          gclass27_0.method_66(list_0.smethod_10());
                          ++num1;
                          if (num1 < num2)
                            this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, ", (object) num1, (object) num2) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue, num3 + 1));
                          else
                            goto label_175;
                        }
                        else if (!gclass27_0.method_31(0, string_11_11, "//*[@text='INVITE' or @content-desc='INVITE']"))
                        {
                          if (!flag12)
                          {
                            this.method_184(int_4, string_0_13 + string.Format("{0}/{1}, Scroll...", (object) num1, (object) num2));
                            if (gclass27_0.method_78())
                            {
                              if (!gclass27_0.method_104())
                              {
                                switch (this.method_32(gclass27_0, int_4, string_0_13))
                                {
                                  case 0:
                                    goto label_175;
                                  case 1:
                                    goto label_177;
                                  default:
                                    goto label_179;
                                }
                              }
                              else
                                break;
                            }
                          }
                        }
                        else
                        {
                          gclass27_0.method_28();
                          break;
                        }
                      }
                      else
                        goto label_179;
                    }
                    goto label_173;
                  }
                }
                else if (num16 != 3477674470U)
                {
                  if (num16 == 3974476160U && s == "//*[@content-desc='Play again' or @text='Play again']")
                    goto label_172;
                }
                else if (s == "//android.widget.ImageButton[@content-desc='Share to Group']")
                  goto label_172;
              }
              else
              {
                int num18;
                switch (num16)
                {
                  case 815715068:
                    if (s == "//*[@content-desc='SHARE']")
                    {
                      if (num13 < num14)
                      {
                        ++num13;
                        this.method_184(int_4, string_0_13 + string.Format("{0}/{1} Tap {2}...", (object) num1, (object) num2, (object) Regex.Match(str5, "'(.*?)'").Groups[1].Value));
                        gclass27_0.method_60(str5, string_11_10);
                        goto label_173;
                      }
                      else
                        goto label_179;
                    }
                    else
                      goto label_169;
                  case 1094531760:
                    if (s == "//*[@text='save your login info']")
                    {
                      gclass27_0.method_60("//android.widget.Button[@text='OK']", string_11_10);
                      goto label_173;
                    }
                    else
                      goto label_169;
                  case 1835260571:
                    num18 = s == "//*[@content-desc='Share to a community']" ? 1 : 0;
                    break;
                  default:
                    num18 = 0;
                    break;
                }
                if (num18 != 0)
                  goto label_172;
              }
label_169:
              if (gclass27_0.method_35(0, string_11_10).Where<string>((System.Func<string, bool>) (string_0_11 => !string_0_11.Contains(string.Format("[{0},{1}]", (object) gclass27_0.method_21(), (object) gclass27_0.method_20())))).Count<string>() == 0)
              {
                if (num13 < num14)
                {
                  ++num13;
                  gclass27_0.method_55(140, 2460);
                  goto label_173;
                }
                else
                  goto label_179;
              }
              else
                goto label_173;
label_172:
              this.method_184(int_4, string_0_13 + string.Format("{0}/{1} Tap {2}...", (object) num1, (object) num2, (object) Regex.Match(str5, "'(.*?)'").Groups[1].Value));
              gclass27_0.method_60(str5, string_11_10);
label_173:
              gclass27_0.SleepSeconds(1.0);
            }
          }
          else
            goto label_179;
        }
label_175:
        this.method_184(int_4, string_0_13 + "Share group done, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue, num3 + 1));
      }
    }
    catch
    {
    }
label_179:
    return num1;
  }

  private int method_61(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int num1 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      List<string> stringList = gclass22_0.method_2("txtUid");
      int int_4_1 = gclass22_0.method_3("nudSoLuongFrom");
      int int_5 = gclass22_0.method_3("nudSoLuongTo");
      string str = stringList[int_4 % stringList.Count];
      int num2 = 0;
      int num3 = gclass27_0.method_87(int_4_1, int_5);
      this.method_184(int_4, string_0_1 + "Go to Page " + str + "...");
      if (this.method_215(gclass27_0, int_4, string_0_1, "fb://page/" + str + "/invite_friends_to_like_page"))
      {
        this.method_184(int_4, string_0_1 + "Find checkbox...");
        int num4 = num2 + 1;
        List<string> source = gclass27_0.method_37(0, "", "//android.widget.CheckBox[@checked='false']");
        this.method_184(int_4, string_0_1 + "Find checkbox: " + source.Count.ToString());
        if (source.Count != 0)
        {
          for (int index = 0; index < num3; ++index)
          {
            if (source.Count > 1)
            {
              string string_11 = source.First<string>();
              source.Remove(string_11);
              this.method_184(int_4, string_0_1 + string.Format("{0}/{1}, Tap checkbox...", (object) (index + 1), (object) num3));
              gclass27_0.method_66(string_11);
              gclass27_0.method_80(0.5, 1.0);
            }
            else
            {
              this.method_184(int_4, string_0_1 + string.Format("{0}/{1}, Scroll...", (object) (index + 1), (object) num3));
              if (!gclass27_0.method_78())
              {
                --index;
                this.method_184(int_4, string_0_1 + string.Format("{0}/{1}, Find checkbox...", (object) (index + 1), (object) num3));
                source = gclass27_0.method_37(0, "", "//android.widget.CheckBox[@checked='false']");
              }
              else
                break;
            }
          }
          this.method_184(int_4, string_0_1 + "Tap Invite...");
          if (gclass27_0.method_61(3, "//android.widget.ImageView[@content-desc=\"Invite selected friends\"]", ""))
          {
            this.method_184(int_4, string_0_1 + "Tap Invite, " + GClass35.smethod_0("đợi") + " {time}s...", 3);
            this.method_184(int_4, string_0_1 + "Loading...");
            gclass27_0.method_42(5);
          }
        }
      }
    }
    catch
    {
    }
    return num1;
  }

  private int method_62(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    string str = gclass22_0.method_1("txtIdGroup");
    int num1 = gclass22_0.method_3("typeInvite");
    int int_4_1 = gclass22_0.method_3("nudSoLuongFrom");
    int int_5 = gclass22_0.method_3("nudSoLuongTo");
    int minValue = gclass22_0.method_3("nudDelayFrom");
    int num2 = gclass22_0.method_3("nudDelayTo");
    int num3 = 1;
    int num4 = 0;
    int num5 = gclass27_0.method_87(int_4_1, int_5);
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_4, string_0_1 + "Go to Group " + str + "...");
      if (this.method_215(gclass27_0, int_4, string_0_1, "fb://group/" + str))
      {
        gclass27_0.method_76(-1);
        gclass27_0.SleepSeconds(1.0);
        this.method_184(int_4, string_0_1 + "Find Invite Members...");
        gclass27_0.method_61(3, "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]", "");
        this.method_184(int_4, string_0_1 + "Tap Invite Members...");
        if (num1 == 1)
        {
          this.method_184(int_4, string_0_1 + "Find Invite...");
          List<string> source = gclass27_0.method_37(3, "", "//android.view.ViewGroup[@content-desc=\"Invite\"]");
          if (source.Count > 0)
          {
            for (int index = 0; index < num5 + 10; ++index)
            {
              if (source.Count == 0)
              {
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) num4, (object) num5));
                if (!gclass27_0.method_78())
                {
                  this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Invite...", (object) num4, (object) num5));
                  source = gclass27_0.method_37(3, "", "//android.view.ViewGroup[@content-desc=\"Invite\"]");
                  if (source.Count == 0)
                    break;
                }
                else
                  break;
              }
              string string_11 = source.LastOrDefault<string>();
              source.Remove(string_11);
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Invite...", (object) num4, (object) num5));
              gclass27_0.method_66(string_11);
              ++num4;
              if (num4 < num5)
              {
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue, num2 + 1));
              }
              else
              {
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Done!", (object) num4, (object) num5));
                break;
              }
            }
          }
        }
        else
          Class38.smethod_5(gclass27_0.method_114().Split('|')[0], gclass27_0.string_8, gclass27_0.int_1);
      }
    }
    catch
    {
      num3 = 0;
    }
    return num3;
  }

  public static string smethod_0(string string_0, string string_1, string string_2, int int_4)
  {
    bool flag = false;
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string str4 = "";
    string str5 = "";
    string input1 = "";
    string str6 = "";
    string str7 = "";
    string str8 = "";
    try
    {
      string str9 = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
      GClass24 gclass24 = new GClass24(string_0, "", string_2, int_4);
      string input2 = gclass24.method_0("https://mbasic.facebook.com/friends/center/friends/?mff_nav=1");
      input1 = Regex.Match(input2, "bm bn\">(.*?)<").Groups[1].Value.Replace(",", "").Replace(".", "");
      if (input1 == "")
        input1 = Regex.Match(input2, "bm\">(.*?)<").Groups[1].Value.Replace(",", "").Replace(".", "");
      input1 = Regex.Match(input1, "\\d+").Value;
      str6 = Regex.Matches(gclass24.method_0("https://mbasic.facebook.com/groups/?seemore&refid=27"), "class=\"bl\"").Count.ToString();
      try
      {
        string input3 = gclass24.method_0("https://m.facebook.com/help/");
        string str10 = Regex.Match(input3, "dtsg\":{\"token\":\"(.*?)\"").Groups[1].Value;
        string str11 = Regex.Match(input3, "LSD\",\\[\\],{\"token\":\"(.*?)\"").Groups[1].Value;
        string_1 = Regex.Match(gclass24.method_0("https://business.facebook.com/content_management/"), "EAAG(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
        string string_1_1 = "av=" + str9 + "&__user=" + str9 + "&__a=1&__dyn=&__csr=&__req=y&__hs=18794.EXP2%3Acomet_pkg.2.1.0.0&dpr=1&__ccg=EXCELLENT&__rev=1003974565&__s=zbue97%3A5iciql%3Abxnvge&__hsi=6974199735511561326-0&__comet_req=1&fb_dtsg=" + str10 + "&jazoest=22414&lsd=" + str11 + "&__spin_r=1003974565&__spin_b=trunk&__spin_t=1623807413&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=PrivacyAccessHubYourInformationSectionQuery&variables=%7B%7D&server_timestamps=true&doc_id=3200030856767767";
        str7 = JObject.Parse(gclass24.method_1("https://web.facebook.com/api/graphql/", string_1_1))["data"][(object) "section"][(object) "tiles"][(object) 1][(object) "links"][(object) 0][(object) "non_link_content"][(object) "metadata"].ToString();
      }
      catch
      {
      }
      string[] strArray = fMain.smethod_1(string_0, string_1, string_2, int_4).Split('|');
      str1 = strArray[1];
      str2 = strArray[2];
      str3 = strArray[3];
      str5 = strArray[5];
      if (str8 == "")
        str8 = "0";
      if (input1 == "")
        input1 = "0";
      if (str6 == "")
        str6 = "0";
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex);
    }
    return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}", (object) flag, (object) str1, (object) str2, (object) str3, (object) str4, (object) str5, (object) input1, (object) str6, (object) string_1, (object) str7, (object) str8);
  }

  public static string smethod_1(string string_0, string string_1, string string_2, int int_4)
  {
    bool flag = false;
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string str4 = "";
    string str5 = "";
    string str6 = "";
    string str7 = "";
    try
    {
      JObject jobject = JObject.Parse(new GClass24(string_0, "", string_2, int_4).method_0("https://graph.facebook.com/v2.11/me?fields=name,email,gender,birthday&access_token=" + string_1));
      flag = true;
      str1 = jobject["name"].ToString();
      try
      {
        str2 = jobject["gender"].ToString();
      }
      catch
      {
      }
      try
      {
        str3 = jobject["birthday"].ToString();
      }
      catch
      {
      }
      try
      {
        str5 = jobject["email"].ToString();
      }
      catch
      {
      }
    }
    catch
    {
    }
    return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", (object) flag, (object) str1, (object) str2, (object) str3, (object) str4, (object) str5, (object) str6, (object) str7);
  }

  public int method_63(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom");
    int num1 = gclass22_0.method_3("nudSoLuongTo");
    int minValue2 = gclass22_0.method_3("nudDelayFrom");
    int num2 = gclass22_0.method_3("nudDelayTo");
    int num3 = gclass22_0.method_3("typeRoiNhom");
    bool bool_0 = gclass22_0.method_4("ckbDieuKienKiemDuyet");
    bool flag1 = gclass22_0.method_4("ckbDieuKienThanhVien");
    int int_5 = gclass22_0.method_3("nudThanhVienToiDa");
    bool flag2 = gclass22_0.method_4("ckbDieuKienTuKhoa");
    List<string> list_0 = gclass22_0.method_2("txtTuKhoa");
    List<string> second = gclass22_0.method_2("txtIDNhomGiuLai");
    int num4 = 0;
    int num5 = this.random_0.Next(minValue1, num1 + 1);
    try
    {
      string string_0 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_4, string_0 + "Scan groups...");
      List<string> source1 = Class38.smethod_1(gclass27_0.method_114().Split('|')[1], gclass27_0.string_8, gclass27_0.int_1, bool_0);
      List<string> list;
      if (num3 == 0)
      {
        list = source1.Select<string, string>((System.Func<string, string>) (string_0_2 => string_0_2.Split('|')[0])).ToList<string>();
      }
      else
      {
        List<string> source2 = new List<string>();
        if (bool_0)
          source2 = source1.Where<string>((System.Func<string, bool>) (string_0list2 => string_0_1.Split('|')[3].ToLower() == "true")).Select<string, string>((System.Func<string, string>) (string_0list2 => string_0_1.Split('|')[0])).ToList<string>();
        List<string> collection1 = new List<string>();
        if (flag1)
          collection1 = source1.Where<string>((System.Func<string, bool>) (string_0collection => Convert.ToInt32(string_0_1.Split('|')[2]) < int_5)).Select<string, string>((System.Func<string, string>) (string_0collection => string_0_1.Split('|')[0])).ToList<string>();
        List<string> collection2 = new List<string>();
        if (flag2)
        {
          list_0 = list_0.ConvertAll<string>((Converter<string, string>) (string_0_3 => string_0_3.ToLower()));
          collection2 = source1.Where<string>((System.Func<string, bool>) (string_0list_0 => this.method_71(string_0_1.Split('|')[1], list_0))).Select<string, string>((System.Func<string, string>) (string_0list_0 => string_0_1.Split('|')[0])).ToList<string>();
        }
        source2.AddRange((IEnumerable<string>) collection1);
        source2.AddRange((IEnumerable<string>) collection2);
        list = source2.Distinct<string>().ToList<string>();
      }
      if (second.Count > 0)
        list = list.Except<string>((IEnumerable<string>) second).ToList<string>();
      this.method_184(int_4, string_0 + "Scan groups: " + list.Count.ToString());
      while (num4 < num5 && list.Count != 0)
      {
        string str1 = list[this.random_0.Next(0, list.Count)];
        list.Remove(str1);
        int num6;
        do
        {
          this.method_184(int_4, string_0 + string.Format("({0}/{1}), Go to Group {2}...", (object) num4, (object) num5, (object) str1));
          if (this.method_215(gclass27_0, int_4, string_0, "fb://group/" + str1))
          {
            this.method_184(int_4, string_0 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + GClass35.smethod_0("Rời nhóm") + "...");
            int num7 = 0;
            int num8 = 6;
            int tickCount = Environment.TickCount;
            do
            {
              string str2 = gclass27_0.method_53();
              string str3 = gclass27_0.method_29(0, str2, new List<string>()
              {
                "//android.widget.ProgressBar",
                "//*[@text='Tap to retry']",
                "//*[@content-desc='Reload page']",
                "//*[@content-desc='Delete Invite' or @text='Delete Invite']",
                "//*[starts-with(@content-desc, 'joined')]",
                "//*[starts-with(@content-desc, 'followed')]",
                "//*[starts-with(@content-desc,'Leave ') or starts-with(@text,'Leave ')]",
                "//*[starts-with(@content-desc,'Unfollow ') or starts-with(@text,'Unfollow ')]",
                "//*[starts-with(@content-desc,'You have left this group')]",
                "//*[starts-with(@content-desc, 'Join ')]",
                "//*[@content-desc='Follow group']",
                "//*[@content-desc='manage group']"
              });
              string s = str3;
              // ISSUE: reference to a compiler-generated method
              uint num9 = Class206.smethod_0(s);
              if (num9 > 1390486005U)
              {
                if (num9 <= 2271211187U)
                {
                  if (num9 != 1591760391U)
                  {
                    if (num9 != 1727591820U)
                    {
                      if (num9 == 2271211187U && s == "//*[@content-desc='Reload page']")
                      {
                        if (num7 < num8)
                        {
                          ++num7;
                          this.method_184(int_4, string_0 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + "Tap " + gclass27_0.method_151(str3) + "...");
                          gclass27_0.method_60(str3, str2);
                          goto label_45;
                        }
                        else
                          break;
                      }
                    }
                    else if (s == "//*[starts-with(@content-desc,'Leave ') or starts-with(@text,'Leave ')]")
                      goto label_47;
                  }
                  else if (s == "//*[@content-desc='Follow group']")
                    break;
                }
                else if (num9 != 2686990081U)
                {
                  if (num9 != 3403591058U)
                  {
                    if (num9 == 3938925310U && s == "//*[starts-with(@content-desc, 'joined')]")
                      goto label_46;
                  }
                  else if (s == "//*[starts-with(@content-desc,'You have left this group')]")
                    break;
                }
                else if (s == "//*[starts-with(@content-desc, 'Join ')]")
                  break;
              }
              else if (num9 <= 532719482U)
              {
                if (num9 != 281629319U)
                {
                  if (num9 != 313138500U)
                  {
                    if (num9 == 532719482U && s == "//android.widget.ProgressBar")
                    {
                      this.method_184(int_4, string_0 + "Loading...");
                      goto label_45;
                    }
                  }
                  else if (s == "//*[starts-with(@content-desc,'Unfollow ') or starts-with(@text,'Unfollow ')]")
                    goto label_47;
                }
                else if (s == "//*[@text='Tap to retry']")
                {
                  if (num7 < num8)
                  {
                    ++num7;
                    gclass27_0.method_78(-1);
                    goto label_45;
                  }
                  else
                    break;
                }
              }
              else if (num9 != 643667242U)
              {
                if (num9 != 1145824053U)
                {
                  if (num9 == 1390486005U && s == "//*[starts-with(@content-desc, 'followed')]")
                    goto label_46;
                }
                else if (s == "//*[@content-desc='manage group']")
                  break;
              }
              else if (s == "//*[@content-desc='Delete Invite' or @text='Delete Invite']")
                goto label_46;
              if (!gclass27_0.method_146(str2, "An error occurred leaving this group, please try again"))
              {
                this.method_184(int_4, string_0 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + "Scroll...");
                if (gclass27_0.method_78())
                  goto label_48;
              }
              else
                goto label_56;
label_45:
              gclass27_0.SleepSeconds(2.0);
              continue;
label_46:
              this.method_184(int_4, string_0 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + "Tap " + gclass27_0.method_151(str3) + "...");
              gclass27_0.method_60(str3, str2);
              goto label_45;
label_47:
              gclass27_0.method_66(gclass27_0.method_37(0, str2, str3).Last<string>());
              goto label_45;
            }
            while (Environment.TickCount - tickCount < 60000);
            goto label_50;
label_48:
            num6 = this.method_32(gclass27_0, int_4, string_0);
          }
          else
            goto label_56;
        }
        while (num6 == 1);
        if (num6 != 0)
          break;
label_50:
        ++num4;
        if (num4 < num5)
        {
          this.method_184(int_4, string_0 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
        }
        else
        {
          this.method_184(int_4, string_0 + string.Format("({0}/{1}), Done!", (object) num4, (object) num5));
          break;
        }
      }
    }
    catch
    {
    }
label_56:
    return num4;
  }

  private List<string> method_64(
    List<string> list_18,
    string string_0,
    string string_1,
    string string_2,
    int int_4)
  {
    List<string> list_19 = new List<string>();
    try
    {
      int int_6 = 0;
      int num1 = list_18.Count < 100 ? list_18.Count : 100;
      int num2 = 0;
      while (num2 < list_18.Count)
      {
        if (int_6 < num1)
        {
          Interlocked.Increment(ref int_6);
          int int_5 = num2++;
          new Thread((ThreadStart) (() =>
          {
            try
            {
              string str = list_18[int_5].Split('|')[0];
              if (!new GClass24(string_0, string_1, string_2, int_4).method_0("https://m.facebook.com/groups/" + str + "/madminpanel").Contains("madminpanel/pending/"))
              {
                lock (list_19)
                  list_19.Add(str);
              }
            }
            catch
            {
            }
            Interlocked.Decrement(ref int_6);
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
      while (int_6 > 0)
      {
        Application.DoEvents();
        Thread.Sleep(1000);
      }
    }
    catch
    {
    }
    return list_19;
  }

  private int method_65(int int_4, string string_0, GClass22 gclass22_0, string string_1)
  {
    this.method_184(int_4, string_0 + string.Format(GClass35.smethod_0("Đang {0}, " + GClass35.smethod_0("đợi") + " {time}s..."), (object) string_1), Class54.random_0.Next(gclass22_0.method_3("nudDelayFrom"), gclass22_0.method_3("nudDelayTo") + 1));
    return 1;
  }

  private void method_66(GClass18 gclass18_0, string string_0, int int_4)
  {
    try
    {
      if (gclass18_0 == null)
        return;
      string str = Application.StartupPath + "\\log_capture";
      switch (int_4)
      {
        case 0:
          str += "\\checkpoint";
          break;
        case 1:
          str += "\\loginfail";
          break;
        case 2:
          str += "\\disconnect";
          break;
      }
      GClass19.smethod_34(str);
      gclass18_0.method_49(str, string_0);
      File.WriteAllText(str + "\\" + string_0 + ".txt", gclass18_0.method_11());
      File.WriteAllText(str + "\\" + string_0 + ".html", gclass18_0.method_1());
    }
    catch
    {
    }
  }

  private bool method_67(GClass18 gclass18_0)
  {
    bool flag = false;
    try
    {
      gclass18_0.method_12("https://www.instagram.com/");
      this.method_102();
      switch (gclass18_0.method_41(10.0, "[href=\"/accounts/activity/\"]", "form button"))
      {
        case 1:
          return true;
        case 2:
          gclass18_0.method_21(4, "form button", 1);
          switch (gclass18_0.method_41(10.0, "[href=\"/accounts/activity/\"]", "[name=\"__CONFIRM__\"]", "[name=\"username\"]"))
          {
            case 1:
            case 3:
              return flag;
            case 2:
              gclass18_0.method_56(1.0);
              gclass18_0.method_21(2, "__CONFIRM__");
              string string_8_1 = "minsoft" + GClass19.smethod_60(3, this.random_0) + GClass19.smethod_60(5, this.random_0);
              gclass18_0.method_24(2, "username", string_8_1);
              GClass19.smethod_64(1.0);
              string string_8_2 = "Minsoft_" + GClass19.smethod_60(6, this.random_0);
              gclass18_0.method_24(2, "password", string_8_2);
              this.method_102();
              gclass18_0.method_21(4, "form button[type=\"submit\"]");
              this.method_102();
              if (gclass18_0.method_38("[href=\"/accounts/activity/\"]", 10.0) == 1)
                flag = true;
              if (!flag && gclass18_0.method_38("[type=\"button\"]") == 1)
                flag = true;
              if (!flag)
                return flag;
              lock (this.object_6)
              {
                File.AppendAllText("account_ig.txt", string_8_1 + "|" + string_8_2 + Environment.NewLine);
                return flag;
              }
            default:
              return flag;
          }
        default:
          return flag;
      }
    }
    catch
    {
      return flag;
    }
  }

  private void method_68(GClass18 gclass18_0)
  {
    try
    {
      GClass20.smethod_6(gclass18_0);
      if (gclass18_0.method_38("#bookmarks_jewel a", 3.0) != 1)
        return;
      this.method_102();
      gclass18_0.method_21(4, "#bookmarks_jewel a");
      this.method_102(1);
      if (gclass18_0.method_39("document.querySelector('[data-sigil=\"logout\"]')", 3.0) != 1)
        return;
      gclass18_0.method_44("document.querySelector('[data-sigil=\"logout\"]')");
      this.method_102(1);
      gclass18_0.method_21(4, "[data-sigil=\"logout\"]");
      this.method_102();
      if (gclass18_0.method_38("[name=\"m_savepass\"]", 3.0) == 1)
      {
        gclass18_0.method_21(2, "m_savepass");
        this.method_102();
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79(gclass18_0, ex, "Logout error");
    }
  }

  private bool method_69(GClass18 gclass18_0)
  {
    bool flag = false;
    try
    {
      gclass18_0.method_12("https://m.facebook.com/settings/security_login/sessions/log_out_all/confirm/");
      gclass18_0.method_56(1.0);
      for (int index = 0; index < 10; ++index)
      {
        string str = gclass18_0.method_20("return document.documentElement.innerHTML.match(new RegExp('/security/settings/sessions/log_out_all/(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
        if (!(str != ""))
        {
          gclass18_0.method_56(1.0);
        }
        else
        {
          gclass18_0.method_12("https://m.facebook.com" + str);
          return true;
        }
      }
      return flag;
    }
    catch
    {
      return flag;
    }
  }

  private bool method_70(GClass18 gclass18_0)
  {
    bool flag = false;
    try
    {
      gclass18_0.method_12("https://m.facebook.com/settings/subscribe/");
      gclass18_0.method_56(1.0);
      return gclass18_0.method_38("[data-sigil=\"audience-options-list\"]>label", 10.0) == 1 && !Convert.ToBoolean(gclass18_0.method_20("return document.querySelector('[data-sigil=\"audience-options-list\"]>label').getAttribute('data-sigil').includes('selected')+''")) && gclass18_0.method_21(4, "[data-sigil=\"audience-options-list\"]>label") == 1 || flag;
    }
    catch
    {
      return flag;
    }
  }

  private bool method_71(string string_0, List<string> list_18)
  {
    bool flag = false;
    try
    {
      for (int index = 0; index < list_18.Count; ++index)
      {
        if (GClass19.smethod_62(string_0).ToLower().Contains(GClass19.smethod_62(list_18[index]).ToLower()))
          return true;
      }
      return flag;
    }
    catch
    {
      return flag;
    }
  }

  private List<string> method_72(
    string string_0_1,
    string string_1,
    string string_2,
    int int_4,
    int int_5,
    bool bool_5,
    int int_6,
    bool bool_6,
    List<string> list_18)
  {
    List<string> list_18_1 = new List<string>();
    try
    {
      if (int_5 == 2)
        list_18 = list_18.ConvertAll<string>((Converter<string, string>) (string_0_2 => string_0_2.ToLower()));
      GClass24 gclass24 = new GClass24(string_0_1, "", string_2, int_4);
      string str1 = Regex.Match(gclass24.method_0("https://m.facebook.com/help/"), GClass19.smethod_58("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
      string str2 = Regex.Match(string_0_1 + ";", "c_user=(.*?);").Groups[1].Value;
      string string_0_3 = "https://www.facebook.com/ajax/typeahead/first_degree.php?fb_dtsg_ag=" + str1 + "&filter%5B0%5D=group&viewer=" + str2 + "&__user=" + str2 + "&__a=1&__dyn=&__comet_req=0&jazoest=26581";
      foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(gclass24.method_0(string_0_3).Replace("for (;;);", ""))["payload"][(object) "entries"])
      {
        try
        {
          if (int_5 == 0 || int_5 == 1)
            list_18_1.Add(jtoken[(object) "uid"].ToString());
          else if (int_5 == 2)
          {
            string str3 = jtoken[(object) "uid"].ToString();
            string string_0_4 = jtoken[(object) "text"].ToString();
            string str4 = jtoken[(object) "size"].ToString();
            if (bool_5 && Convert.ToInt32(str4) < int_6 || bool_6 && this.method_71(string_0_4, list_18))
              list_18_1.Add(str3);
          }
        }
        catch
        {
        }
      }
      if (int_5 == 1)
        list_18_1 = this.method_64(list_18_1, string_0_1, string_1, string_2, int_4);
    }
    catch
    {
    }
    return list_18_1;
  }

  public int method_73(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    List<string> list_0_1 = gclass22_0.method_2("txtTuKhoa");
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom");
    int num1 = gclass22_0.method_3("nudSoLuongTo");
    int minValue2 = gclass22_0.method_3("nudDelayFrom");
    int num2 = gclass22_0.method_3("nudDelayTo");
    bool flag = gclass22_0.method_4("ckbTuDongTraLoiCauHoi");
    List<string> list_18 = gclass22_0.method_2("txtCauTraLoi");
    int num3 = 0;
    try
    {
      string str = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num4 = this.random_0.Next(minValue1, num1 + 1);
      if (num4 != 0)
      {
        List<string> stringList1 = GClass19.smethod_39(list_0_1);
        string string_11_1 = GClass19.smethod_28(stringList1[this.random_0.Next(0, stringList1.Count)], this.random_0);
label_3:
        this.method_184(int_4, str + "Search Group...");
        if (gclass27_0.method_108(string_11_1, "Groups"))
        {
          List<string> stringList2 = new List<string>();
          for (int index1 = 0; index1 < num4 + 10; ++index1)
          {
            switch (this.method_32(gclass27_0, int_4, string_0))
            {
              case 0:
                this.method_184(int_4, str + string.Format("({0}/{1}), Find Join...", (object) num3, (object) num4));
                List<string> list_0_2 = gclass27_0.method_37(5, "", "//*[starts-with(@content-desc, 'Join ')]");
                this.method_184(int_4, str + string.Format("({0}/{1}), Find Join: ", (object) num3, (object) num4) + list_0_2.Count.ToString());
                if (list_0_2.Count == 0)
                {
                  for (int index2 = 0; index2 < 10; ++index2)
                  {
                    this.method_184(int_4, str + string.Format("({0}/{1}), Scroll...", (object) num3, (object) num4));
                    if (!gclass27_0.method_78())
                    {
                      this.method_184(int_4, str + string.Format("({0}/{1}), Find Join...", (object) num3, (object) num4));
                      list_0_2 = gclass27_0.method_37(5, "", "//*[starts-with(@content-desc, 'Join ')]");
                      this.method_184(int_4, str + string.Format("({0}/{1}), Find Join: ", (object) num3, (object) num4) + list_0_2.Count.ToString());
                      if (list_0_2.Count > 0)
                        break;
                    }
                    else
                      break;
                  }
                  if (list_0_2.Count == 0)
                    goto label_31;
                }
                string string_11_2 = list_0_2.smethod_10();
                list_0_2.Remove(string_11_2);
                this.method_184(int_4, str + string.Format("({0}/{1}), Tap Join...", (object) num3, (object) num4));
                if (gclass27_0.method_66(string_11_2))
                {
                  string string_11_3 = "";
                  this.method_184(int_4, str + string.Format("({0}/{1}), Find Submit...", (object) num3, (object) num4));
                  if (gclass27_0.method_33(5, ref string_11_3, "//android.view.ViewGroup[@content-desc=\"Submit\"]"))
                  {
                    if (flag)
                    {
                      this.method_132(int_4, str + string.Format("({0}/{1}), ", (object) num3, (object) num4), gclass27_0, list_18);
                    }
                    else
                    {
                      this.method_184(int_4, str + string.Format("({0}/{1}), Back...", (object) num3, (object) num4));
                      if (!gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc=\"Back\"]", string_11_3))
                        gclass27_0.method_28();
                      string string_11_4 = "";
                      this.method_184(int_4, str + string.Format("({0}/{1}), Find Exit...", (object) num3, (object) num4));
                      if (gclass27_0.method_33(5, ref string_11_4, "//android.widget.TextView[@text=\"Exit without answering?\"]"))
                      {
                        this.method_184(int_4, str + string.Format("({0}/{1}), Tap Exit...", (object) num3, (object) num4));
                        gclass27_0.method_61(0, "//android.widget.Button[@text=\"EXIT\"]", string_11_4);
                        gclass27_0.method_80(1.0, 1.5);
                      }
                    }
                    this.method_184(int_4, str + string.Format("({0}/{1}), ", (object) num3, (object) num4) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                  }
                  if (gclass27_0.method_40(0, "", new List<string>()
                  {
                    "//android.view.ViewGroup[@content-desc=\"Cancel request\"]",
                    "//android.widget.Button[@content-desc=\"Member tools\"]"
                  }).Count > 0)
                  {
                    this.method_184(int_4, str + string.Format("({0}/{1}), Back...", (object) num3, (object) num4));
                    gclass27_0.method_28();
                  }
                  ++num3;
                  if (num3 >= num4)
                  {
                    this.method_184(int_4, str + string.Format("({0}/{1}), Done!", (object) num3, (object) num4));
                    goto label_31;
                  }
                  else
                    continue;
                }
                else
                  continue;
              case 1:
                goto label_3;
              default:
                goto label_31;
            }
          }
        }
      }
    }
    catch
    {
      num3 = -1;
    }
label_31:
    return num3;
  }

  public int method_74(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom");
    int num1 = gclass22_0.method_3("nudSoLuongTo");
    int minValue2 = gclass22_0.method_3("nudDelayFrom");
    int num2 = gclass22_0.method_3("nudDelayTo");
    bool flag = gclass22_0.method_4("ckbTuDongTraLoiCauHoi");
    List<string> list_18 = gclass22_0.method_2("txtCauTraLoi");
    int num3 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num4 = this.random_0.Next(minValue1, num1 + 1);
      if (num4 != 0)
      {
label_2:
        this.method_184(int_4, string_0_1 + "Go to " + GClass35.smethod_0("Nhóm gợi ý") + "...");
        if (this.method_215(gclass27_0, int_4, string_0_1, "fb://faceweb/f?href=https://m.facebook.com/groups_browse/see_all/?category_id=212609529249058"))
        {
          List<string> stringList = new List<string>();
          for (int index1 = 0; index1 < num4 + 10; ++index1)
          {
            switch (this.method_32(gclass27_0, int_4, string_0))
            {
              case 0:
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Join...", (object) num3, (object) num4));
                List<string> list_0 = gclass27_0.method_37(5, "", "//android.view.ViewGroup[@content-desc='Join']");
                int int_4_1 = int_4;
                string str1 = string_0_1;
                string str2 = string.Format("({0}/{1}), Find Join: ", (object) num3, (object) num4);
                int count = list_0.Count;
                string str3 = count.ToString();
                string string_0_2 = str1 + str2 + str3;
                this.method_184(int_4_1, string_0_2);
                if (list_0.Count == 0)
                {
                  for (int index2 = 0; index2 < 10; ++index2)
                  {
                    this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) num3, (object) num4));
                    if (!gclass27_0.method_78())
                    {
                      this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Join...", (object) num3, (object) num4));
                      list_0 = gclass27_0.method_37(5, "", "//android.view.ViewGroup[@content-desc='Join']");
                      int int_4_2 = int_4;
                      string str4 = string_0_1;
                      string str5 = string.Format("({0}/{1}), Find Join: ", (object) num3, (object) num4);
                      count = list_0.Count;
                      string str6 = count.ToString();
                      string string_0_3 = str4 + str5 + str6;
                      this.method_184(int_4_2, string_0_3);
                      if (list_0.Count > 0)
                        break;
                    }
                    else
                      break;
                  }
                  if (list_0.Count == 0)
                    goto label_31;
                }
                string string_11_1 = list_0.smethod_10();
                list_0.Remove(string_11_1);
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Join...", (object) num3, (object) num4));
                if (gclass27_0.method_66(string_11_1))
                {
                  string string_11_2 = "";
                  this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Submit...", (object) num3, (object) num4));
                  if (gclass27_0.method_33(5, ref string_11_2, "//android.view.ViewGroup[@content-desc=\"Submit\"]"))
                  {
                    if (flag)
                    {
                      this.method_132(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num3, (object) num4), gclass27_0, list_18);
                    }
                    else
                    {
                      this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Back...", (object) num3, (object) num4));
                      if (!gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc=\"Back\"]", string_11_2))
                        gclass27_0.method_28();
                      string string_11_3 = "";
                      this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Exit...", (object) num3, (object) num4));
                      if (gclass27_0.method_33(5, ref string_11_3, "//android.widget.TextView[@text=\"Exit without answering?\"]"))
                      {
                        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Exit...", (object) num3, (object) num4));
                        gclass27_0.method_61(0, "//android.widget.Button[@text=\"EXIT\"]", string_11_3);
                        gclass27_0.method_80(1.0, 1.5);
                      }
                    }
                    this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num3, (object) num4) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                  }
                  if (gclass27_0.method_40(0, "", new List<string>()
                  {
                    "//android.view.ViewGroup[@content-desc=\"Cancel request\"]",
                    "//android.widget.Button[@content-desc=\"Member tools\"]"
                  }).Count > 0)
                  {
                    this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Back...", (object) num3, (object) num4));
                    gclass27_0.method_28();
                  }
                  ++num3;
                  if (num3 >= num4)
                  {
                    this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Done!", (object) num3, (object) num4));
                    goto label_31;
                  }
                  else
                    continue;
                }
                else
                  continue;
              case 1:
                goto label_2;
              default:
                goto label_31;
            }
          }
        }
      }
    }
    catch
    {
      num3 = -1;
    }
label_31:
    return num3;
  }

  private int method_75(GClass27 gclass27_0, int int_4, string string_0_1, string string_1)
  {
    int num1 = 0;
    string str = GClass5.smethod_0(string_1);
    if (!(str == ""))
    {
      int num2 = 0;
      int num3 = 5;
      for (int index1 = 0; index1 < 3; ++index1)
      {
label_18:
        if (num2 < num3)
        {
          ++num2;
          if (this.method_215(gclass27_0, int_4, string_0_1, "fb://fullscreen_video/" + str + "?loop=0"))
          {
            for (int index2 = 1; index2 < 11; ++index2)
            {
              string string_11 = gclass27_0.method_53();
              if (!(gclass27_0.method_30(0, ref string_11, new List<string>()
              {
                "//*[@content-desc='SHARE' or @text='SHARE']"
              }) != ""))
              {
                if (index2 % 3 == 0)
                {
                  int num4 = this.method_32(gclass27_0, int_4, string_0_1);
                  if (num4 != 1)
                  {
                    if (num4 != 0)
                    {
                      num1 = num4;
                      goto label_22;
                    }
                  }
                  else
                    goto label_18;
                }
                if (!gclass27_0.method_22().Contains("com.facebook.video.activity.DeprecatedFullscreenVideoPlayerActivity"))
                {
                  if (num2 < num3)
                  {
                    ++num2;
                    this.method_215(gclass27_0, int_4, string_0_1, "fb://fullscreen_video/" + str + "?loop=0");
                  }
                  else
                    goto label_22;
                }
                else if (gclass27_0.method_35(0, string_11).Where<string>((System.Func<string, bool>) (string_0_2 => !string_0_2.Contains(string.Format("[{0},{1}]", (object) gclass27_0.method_21(), (object) gclass27_0.method_20())))).Count<string>() != 0)
                {
                  gclass27_0.SleepSeconds(1.0);
                }
                else
                {
                  num1 = 1;
                  goto label_22;
                }
              }
              else
              {
                num1 = 1;
                goto label_22;
              }
            }
          }
          else
            break;
        }
        else
          break;
      }
    }
label_22:
    return num1;
  }

  private int method_76(GClass27 gclass27_0, int int_4, string string_0, string string_1)
  {
    int num1 = 0;
    if (string_1.Contains("photo") || string_1.Contains("v="))
    {
      string string_0_1 = GClass5.smethod_0(string_1);
      if (GClass19.smethod_51(string_0_1))
        string_1 = "https://m.facebook.com/" + string_0_1;
    }
    else if (string_1.Contains("groups"))
    {
      string str1 = Regex.Match(string_1, "groups/(.*?)/").Groups[1].Value;
      if (str1 == "")
        str1 = Regex.Match(string_1, "groups/(.*?)\\?").Groups[1].Value;
      if (str1 != "")
      {
        string str2 = GClass5.smethod_0(string_1);
        if (str2 != "")
          string_1 = "https://m.facebook.com/groups/" + str1 + "/permalink/" + str2 + "/";
      }
    }
    else if (string_1.Contains("story_fbid"))
    {
      string str3 = Regex.Match(string_1, "id=(\\d+)").Groups[1].Value;
      if (str3 != "")
      {
        string str4 = GClass5.smethod_0(string_1);
        if (str4 != "")
          string_1 = "https://m.facebook.com/" + str3 + "/posts/" + str4 + "/";
      }
    }
    else if (!string_1.StartsWith("http"))
      string_1 = "https://m.facebook.com/" + string_1;
    string string_11_1 = gclass27_0.method_53();
    if (!gclass27_0.method_31(0, string_11_1, "//*[@content-desc=\"Make a post on Facebook\"]"))
    {
      gclass27_0.method_107();
      gclass27_0.SleepSeconds(2.0);
      string_11_1 = gclass27_0.method_53();
    }
    string str5 = gclass27_0.method_37(0, string_11_1, "//*[@content-desc=\"Make a post on Facebook\"]").FirstOrDefault<string>() ?? "";
    int num2 = 0;
    int num3 = 3;
    int num4 = 0;
    int num5 = 3;
label_44:
    while (this.method_215(gclass27_0, int_4, string_0, string_1))
    {
      for (int index = 1; index < 11; ++index)
      {
        string string_11_2 = gclass27_0.method_53();
        string str6 = gclass27_0.method_37(0, string_11_2, "//*[@content-desc=\"Make a post on Facebook\"]").FirstOrDefault<string>() ?? "";
        if (!(str6 != "") || !(str6 == str5))
        {
          string string_11_3 = gclass27_0.method_30(0, ref string_11_2, new List<string>()
          {
            "//*[@content-desc='Post Menu']",
            "//*[@content-desc='More options' or @text='More options']",
            "//*[@content-desc='More']",
            "//*[@text='Tap to retry']",
            "//*[starts-with(@content-desc,'Join ')]",
            "//*[@content-desc='See what was used to create this reel']",
            "//*[@content-desc='Reel. Swipe up to see more.']",
            "(//*[@text='Stories'])[2]",
            "//*[@content-desc='Like']"
          });
          switch (string_11_3)
          {
            case "//*[starts-with(@content-desc,'Join ')]":
              gclass27_0.method_60(string_11_3, string_11_2);
              gclass27_0.method_80(2.0, 3.0);
              goto label_43;
            case "//*[@text='Tap to retry']":
              if (num4 >= num5)
              {
                num1 = 2;
                goto label_45;
              }
              else
              {
                ++num4;
                gclass27_0.method_60("//*[@text='Tap to retry']", string_11_2);
                gclass27_0.SleepSeconds(5.0);
                break;
              }
            default:
              if (string_11_3 != "")
              {
                num1 = 1;
                goto label_45;
              }
              else if (gclass27_0.method_146(string_11_2, "The page you requested cannot be displayed right now"))
              {
                num1 = 2;
                goto label_45;
              }
              else if (gclass27_0.method_146(string_11_2, "Tap to view story"))
              {
                num1 = 1;
                goto label_45;
              }
              else
                break;
          }
          if (index % 3 == 0)
          {
            int num6 = this.method_32(gclass27_0, int_4, string_0);
            if (num6 != 1)
            {
              if (num6 != 0)
              {
                num1 = num6;
                break;
              }
            }
            else
              goto label_43;
          }
          if (!string_1.Contains("/stories/") || !gclass27_0.method_31(60, "", "(//*[@text='Stories'])[2]"))
          {
            gclass27_0.method_76(-1);
            gclass27_0.SleepSeconds(1.0);
            continue;
          }
          num1 = 1;
          break;
        }
        ++num2;
        if (num2 > num3)
        {
          num1 = 2;
          break;
        }
label_43:
        goto label_44;
      }
      break;
    }
label_45:
    return num1;
  }

  private bool method_77(GClass27 gclass27_0, string string_0_1, int int_4 = 1, bool bool_5 = false)
  {
    if (bool_5)
    {
      lock (this.object_7)
      {
        List<string> list = ((IEnumerable<string>) Directory.GetFiles(string_0_1)).ToList<string>();
        if (list.Count > 0)
        {
          List<string> list_0 = new List<string>();
          for (int index = 0; index < int_4 && list.Count != 0; ++index)
          {
            string str = list.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).FirstOrDefault<string>();
            list.Remove(str);
            list_0.Add(str);
          }
          gclass27_0.method_142(list_0);
          gclass27_0.SleepSeconds(2.0);
          for (int index = 0; index < list_0.Count; ++index)
            GClass19.smethod_98(list_0[index]);
          return true;
        }
      }
    }
    else
    {
      List<string> list = ((IEnumerable<string>) Directory.GetFiles(string_0_1)).ToList<string>();
      if (list.Count > 0)
      {
        List<string> list_0 = new List<string>();
        for (int index = 0; index < int_4 && list.Count != 0; ++index)
        {
          string str = list.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).FirstOrDefault<string>();
          list.Remove(str);
          list_0.Add(str);
        }
        gclass27_0.method_142(list_0);
        gclass27_0.SleepSeconds(2.0);
        return true;
      }
    }
    return false;
  }

  public int method_78(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2,
    string string_3)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom", 1);
    int num1 = gclass22_0.method_3("nudSoLuongTo", 1);
    int minValue2 = gclass22_0.method_3("nudKhoangCachFrom");
    int num2 = gclass22_0.method_3("nudKhoangCachTo");
    int num3 = 0;
    try
    {
      string str1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num4 = this.random_0.Next(minValue1, num1 + 1);
      for (int index = 0; index < num4 + 5 && num3 < num4; ++index)
      {
        this.method_184(int_4, str1 + string.Format("({0}/{1})...", (object) (num3 + 1), (object) num4));
        try
        {
          int num5;
          do
          {
            gclass27_0.Openreel();
            gclass27_0.method_80(2.0, 3.0);
            num5 = this.method_32(gclass27_0, int_4, string_0);
            if (num5 == 0)
              goto label_5;
          }
          while (num5 == 1);
          break;
label_5:
          int num6 = 0;
          int tickCount = Environment.TickCount;
          int num7 = 300;
          do
          {
            this.method_184(int_4, str1 + string.Format("({0}/{1})...", (object) (num3 + 1), (object) num4));
            string str2 = gclass27_0.method_53();
            string string_11 = gclass27_0.method_29(0, str2, new List<string>()
            {
              "//*[@content-desc='Navigate to your Reels profile']",
              "//*[@content-desc='View suggested entities']",
              "//*[@content-desc='Delete']",
              "//*[@text='Are you sure you want to remove your reel from Facebook?']"
            });
            switch (string_11)
            {
              case "//*[@content-desc='Navigate to your Reels profile']":
                if (num6 > 0)
                {
                  gclass27_0.method_60("//*[@content-desc='Menu']", str2);
                  break;
                }
                ++num6;
                this.method_184(int_4, str1 + "Tap " + gclass27_0.method_151(string_11) + "...");
                gclass27_0.method_60(string_11, str2);
                break;
              case "//*[@text='Are you sure you want to remove your reel from Facebook?']":
                gclass27_0.method_60("//*[@text='DELETE']", str2);
                gclass27_0.SleepSeconds(2.0);
                gclass27_0.method_42(30);
                ++num3;
                if (num3 < num4)
                {
                  this.method_184(int_4, str1 + string.Format("({0}/{1}), ", (object) num3, (object) num4) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                  break;
                }
                goto label_23;
              case "//*[@content-desc='Delete']":
                gclass27_0.method_60(string_11, str2);
                break;
              case "//*[@content-desc='View suggested entities']":
                if (!gclass27_0.method_61(10, "//*[starts-with(@content-desc,'Reel,')]", ""))
                  goto label_23;
                else
                  break;
              default:
                this.method_184(int_4, str1 + string.Format("({0}/{1}), Scroll...", (object) (num3 + 1), (object) num4));
                if (gclass27_0.method_78(-1))
                {
                  int num8 = this.method_32(gclass27_0, int_4, string_0);
                  if (num8 == 1 || num8 == 0)
                    goto label_19;
                  else
                    goto label_23;
                }
                else
                  break;
            }
            gclass27_0.SleepSeconds(1.0);
          }
          while (Environment.TickCount - tickCount < num7 * 1000);
        }
        catch
        {
          continue;
        }
label_19:;
      }
    }
    catch
    {
    }
label_23:
    return num3;
  }

  public int method_79(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2,
    string string_3)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom", 1);
    int num1 = gclass22_0.method_3("nudSoLuongTo", 1);
    int minValue2 = gclass22_0.method_3("nudKhoangCachFrom");
    int num2 = gclass22_0.method_3("nudKhoangCachTo");
    bool flag1 = gclass22_0.method_4("ckbVanBan");
    gclass22_0.method_4("ckbUseBackground");
    bool flag2 = gclass22_0.method_4("ckbXoaNguyenLieuDaDung");
    bool flag3 = gclass22_0.method_4("ckbHashtag");
    gclass22_0.method_2("txtHashtag");
    int int_2 = gclass22_0.method_3("nudSoHashtagFrom", 1);
    int int_3 = gclass22_0.method_3("nudSoHashtagTo", 1);
    bool bool_5 = gclass22_0.method_4("ckbXoaVideoDaDang");
    string string_0_5 = gclass22_0.method_1("txtPathAnh");
    int num3 = gclass22_0.method_3("typeReel");
    int int_4_1 = gclass22_0.method_3("nudTimeOutLoadVideo", 300);
    int num4 = 0;
    List<string> source1 = new List<string>();
    if (num3 == 1)
    {
      if (string_3 != "")
        source1 = Class38.smethod_0(string_3, gclass27_0.string_8, gclass27_0.int_1);
      if (source1.Count == 0)
      {
        string_3 = gclass27_0.method_114().Split('|')[1];
        source1 = Class38.smethod_0(string_3, gclass27_0.string_8, gclass27_0.int_1);
      }
      if (source1.Count == 0)
        goto label_113;
    }
    try
    {
      string string_0_6 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      if (!flag1 || this.dictionary_3[string_2].Count != 0)
      {
        List<string> source2 = new List<string>();
        if (!flag2)
          source2 = GClass19.smethod_27(this.dictionary_3[string_2]);
        int num5 = this.random_0.Next(minValue1, num1 + 1);
        for (int index1 = 0; index1 < num5 + 5 && num4 < num5; ++index1)
        {
          this.method_184(int_4, string_0_6 + string.Format("({0}/{1})...", (object) (num4 + 1), (object) num5));
          try
          {
            int num6;
            do
            {
              if (num3 == 0)
              {
                gclass27_0.Openreel();
                gclass27_0.method_80(2.0, 3.0);
                num6 = this.method_32(gclass27_0, int_4, string_0_1);
              }
              else
                goto label_15;
            }
            while (num6 == 1);
            if (num6 == 0)
              goto label_17;
            else
              break;
label_15:
            if (source1.Count != 0)
            {
              string str = source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>();
              source1.Remove(str);
              if (!this.method_215(gclass27_0, int_4, string_0_6, "fb://page/" + str))
                goto label_108;
            }
            else
              goto label_108;
label_17:
            int num7 = 0;
            int num8 = 1;
            bool flag4 = false;
            int tickCount = Environment.TickCount;
            int num9 = 300;
            string str1;
            do
            {
              str1 = gclass27_0.method_53();
              string str2 = gclass27_0.method_29(0, str1, new List<string>()
              {
                "//*[@content-desc='Create a reel']",
                "//*[@content-desc='Next']",
                "//*[@content-desc='Gallery']",
                "//*[@content-desc='Video']",
                "//*[@text='Who can see reels?']",
                "//*[@content-desc='Opens the audience picker']",
                "//*[@content-desc='Set as default audience for reels']/android.widget.CheckBox[@checked='false']",
                "//*[@content-desc='Save default audience']",
                "//*[starts-with(@content-desc, 'Public; Anyone on or off Facebook')]",
                "//*[@text='UNLOCK']",
                "//*[@text='Allow access' or @content-desc='Allow access']",
                "//*[@text='Allow']",
                "//android.widget.EditText[starts-with(@text,'Describe your reel')]",
                "//android.widget.EditText[starts-with(@text,'Write a description')]",
                "//*[@content-desc='Create Action Button']",
                "//*[@content-desc='Follow']",
                "(//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup)[last()]/child::*",
                "//*[@content-desc='Overview']",
                "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View"
              });
              string s = str2;
              // ISSUE: reference to a compiler-generated method
              uint num10 = Class206.smethod_0(s);
              if (num10 > 856161075U)
              {
                if (num10 <= 1294296500U)
                {
                  if (num10 <= 975484661U)
                  {
                    if (num10 != 940152427U)
                    {
                      if (num10 != 975484661U || !(s == "//android.widget.EditText[starts-with(@text,'Write a description')]"))
                        goto label_69;
                      else
                        goto label_74;
                    }
                    else if (!(s == "//*[@content-desc='Create Action Button']"))
                      goto label_69;
                  }
                  else if (num10 != 986644698U)
                  {
                    if (num10 != 1142163927U)
                    {
                      if (num10 != 1294296500U || !(s == "//*[@content-desc='Follow']"))
                        goto label_69;
                    }
                    else if (s == "(//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup)[last()]/child::*")
                    {
                      string string_0_7 = gclass27_0.method_37(0, str1, "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View").FirstOrDefault<string>();
                      if (!string.IsNullOrEmpty(string_0_7) && new Class77(string_0_7).int_1 < 2000)
                      {
                        Class77 class77_1 = new Class77(string_0_7);
                        Class77 class77_2 = new Class77(class77_1.int_0, 2000, class77_1.int_2, 2000);
                        gclass27_0.method_75(class77_1.method_0(), class77_2.method_0());
                        goto label_71;
                      }
                      else
                      {
                        List<Class77> source3 = Class77.smethod_1(str1, str2);
                        if (source3.Count > 1 && source3[0].int_3 < 2300)
                        {
                          if (this.method_77(gclass27_0, string_0_5, bool_5: bool_5))
                            gclass27_0.method_66(source3.Last<Class77>().method_0());
                          else
                            goto label_111;
                        }
                        else
                          gclass27_0.method_78(2);
                        goto label_71;
                      }
                    }
                    else
                      goto label_69;
                  }
                  else if (s == "//*[@content-desc='Create a reel']")
                  {
                    if (this.method_77(gclass27_0, string_0_5, bool_5: bool_5))
                    {
                      gclass27_0.method_61(0, str2, str1);
                      goto label_71;
                    }
                    else
                      goto label_111;
                  }
                  else
                    goto label_69;
                  string string_0_8 = gclass27_0.method_37(0, str1, "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View").FirstOrDefault<string>();
                  if (!string.IsNullOrEmpty(string_0_8) && new Class77(string_0_8).int_1 < 2000)
                  {
                    Class77 class77_3 = new Class77(string_0_8);
                    Class77 class77_4 = new Class77(class77_3.int_0, 2000, class77_3.int_2, 2000);
                    gclass27_0.method_75(class77_3.method_0(), class77_4.method_0());
                    goto label_71;
                  }
                  else
                  {
                    List<Class77> class77List = Class77.smethod_1(str1, str2 + "/parent::*/child::*");
                    if (class77List.Count <= 1)
                      class77List = Class77.smethod_1(str1, "(" + str2 + "/parent::*/parent::*/child::*)[last()]/child::*");
                    if (class77List.Count > 1 && class77List[0].int_3 < 2300)
                    {
                      if (this.method_77(gclass27_0, string_0_5, bool_5: bool_5))
                        gclass27_0.method_66(class77List[1].method_0());
                      else
                        goto label_111;
                    }
                    else
                      gclass27_0.method_78(2);
                    goto label_71;
                  }
                }
                else if (num10 <= 1792698548U)
                {
                  if (num10 != 1441361486U)
                  {
                    if (num10 == 1792698548U && s == "//*[@content-desc='Next']")
                      goto label_96;
                  }
                  else if (s == "//*[@content-desc='Set as default audience for reels']/android.widget.CheckBox[@checked='false']")
                    goto label_96;
                }
                else if (num10 != 2708651264U)
                {
                  if (num10 != 3347773629U)
                  {
                    if (num10 == 4070114641U && s == "//*[@content-desc='Opens the audience picker']")
                      goto label_74;
                  }
                  else if (s == "//*[@content-desc='Save default audience']")
                    goto label_96;
                }
                else if (s == "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View")
                {
                  string string_0_9 = gclass27_0.method_37(0, str1, "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View").FirstOrDefault<string>();
                  if (!string.IsNullOrEmpty(string_0_9) && new Class77(string_0_9).int_1 < 2000)
                  {
                    Class77 class77_5 = new Class77(string_0_9);
                    Class77 class77_6 = new Class77(class77_5.int_0, 2000, class77_5.int_2, 2000);
                    gclass27_0.method_75(class77_5.method_0(), class77_6.method_0());
                    goto label_71;
                  }
                  else
                    goto label_71;
                }
              }
              else
              {
                if (num10 <= 337542542U)
                {
                  if (num10 <= 82008644U)
                  {
                    if (num10 != 17785684U)
                    {
                      if (num10 != 82008644U || !(s == "//*[@text='Allow']"))
                        goto label_69;
                      else
                        goto label_96;
                    }
                    else if (!(s == "//*[@text='Allow access' or @content-desc='Allow access']"))
                      goto label_69;
                    else
                      goto label_96;
                  }
                  else if (num10 != 330244122U)
                  {
                    if (num10 != 337542542U || !(s == "//*[@text='Who can see reels?']"))
                      goto label_69;
                  }
                  else if (s == "//*[@content-desc='Overview']")
                  {
                    gclass27_0.method_78();
                    goto label_71;
                  }
                  else
                    goto label_69;
                }
                else if (num10 <= 505387006U)
                {
                  if (num10 != 413844824U)
                  {
                    if (num10 == 505387006U && s == "//*[starts-with(@content-desc, 'Public; Anyone on or off Facebook')]")
                    {
                      if (flag4)
                      {
                        gclass27_0.method_60("//*[@content-desc='Back']", str1);
                        goto label_71;
                      }
                      else
                      {
                        flag4 = true;
                        this.method_184(int_4, string_0_6 + "Tap " + gclass27_0.method_151(str2) + "...");
                        gclass27_0.method_60(str2, str1);
                        goto label_71;
                      }
                    }
                    else
                      goto label_69;
                  }
                  else if (!(s == "//*[@content-desc='Video']"))
                    goto label_69;
                  else
                    goto label_96;
                }
                else if (num10 != 507363469U)
                {
                  if (num10 != 819745119U)
                  {
                    if (num10 != 856161075U || !(s == "//*[@text='UNLOCK']"))
                      goto label_69;
                  }
                  else if (!(s == "//android.widget.EditText[starts-with(@text,'Describe your reel')]"))
                    goto label_69;
                  else
                    goto label_74;
                }
                else if (!(s == "//*[@content-desc='Gallery']"))
                  goto label_69;
                else
                  goto label_96;
                gclass27_0.method_60("//*[@text='OK']", str1);
                goto label_71;
              }
label_69:
              this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), Scroll...", (object) (num4 + 1), (object) num5));
              if (gclass27_0.method_78(-1))
                goto label_70;
label_71:
              gclass27_0.SleepSeconds(1.0);
              continue;
label_74:
              if (!gclass27_0.method_31(0, str1, "//*[@content-desc='Public']") && num7 != num8 && !(str2 == "//android.widget.EditText[starts-with(@text,'Describe your reel')]") && !(str2 == "//android.widget.EditText[starts-with(@text,'Write a description')]"))
              {
                ++num7;
                this.method_184(int_4, string_0_6 + "Tap " + gclass27_0.method_151(str2) + "...");
                gclass27_0.method_60(str2, str1);
                goto label_71;
              }
              else
                goto label_76;
label_96:
              gclass27_0.method_61(0, str2, str1);
              goto label_71;
            }
            while (Environment.TickCount - tickCount < num9 * 1000);
            goto label_108;
label_70:
            int num11 = this.method_32(gclass27_0, int_4, string_0_1);
            if (num11 != 1 && num11 != 0)
              break;
            goto label_108;
label_76:
            if (((gclass27_0.method_31(0, str1, "//android.widget.EditText[starts-with(@text,'Describe your reel')]") ? 1 : (gclass27_0.method_31(0, str1, "//android.widget.EditText[starts-with(@text,'Write a description')]") ? 1 : 0)) & (flag1 ? 1 : 0)) != 0)
              goto label_77;
label_72:
            gclass27_0.method_60("//*[@text='Share reel' or @content-desc='Share reel' or @text='Share now' or @content-desc='Share now' or @text='Share' or @content-desc='Share']");
            this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), Tap Share reel, ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(3, 6));
            this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " post success...");
            gclass27_0.method_42(int_4_1);
            ++num4;
            if (num4 < num5)
            {
              this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
              goto label_108;
            }
            else
              break;
label_77:
            string string_0_10 = "";
            if (!flag2)
            {
              if (source2.Count == 0)
                source2 = GClass19.smethod_27(this.dictionary_3[string_2]);
              string_0_10 = source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).FirstOrDefault<string>();
              source2.Remove(string_0_10);
            }
            else
            {
              lock (this.dictionary_3)
              {
                if (this.dictionary_3[string_2].Count != 0)
                {
                  int index2 = this.random_0.Next(0, this.dictionary_3[string_2].Count);
                  string_0_10 = this.dictionary_3[string_2][index2];
                  this.dictionary_3[string_2].RemoveAt(index2);
                }
                else
                  break;
              }
            }
            if (flag3)
            {
              List<string> source4 = gclass22_0.method_2("txtHashtag");
              int num12 = GClass19.smethod_100(int_2, int_3);
              for (int index3 = 0; index3 < num12 && source4.Count != 0; ++index3)
              {
                string str3 = source4.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_4 => Guid.NewGuid())).First<string>();
                source4.Remove(str3);
                string_0_10 = string_0_10 + str3 + " ";
              }
              string_0_10 = string_0_10.Trim();
            }
            string str4 = GClass19.smethod_28(string_0_10, this.random_0);
            if (str4.Trim() != "")
            {
              gclass27_0.method_80(1.0, 1.5);
              this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("Nhập dữ liệu..."));
              gclass27_0.method_50("//android.widget.EditText", str4 + "\n");
              gclass27_0.method_80(1.0, 1.5);
              goto label_72;
            }
            else
              goto label_72;
          }
          catch
          {
            continue;
          }
label_108:;
        }
label_111:;
      }
    }
    catch
    {
    }
label_113:
    return num4;
  }

  public int method_80(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom", 1);
    int num1 = gclass22_0.method_3("nudSoLuongTo", 1);
    int minValue2 = gclass22_0.method_3("nudKhoangCachFrom");
    int num2 = gclass22_0.method_3("nudKhoangCachTo");
    bool flag1 = gclass22_0.method_4("ckbVanBan");
    bool flag2 = gclass22_0.method_4("ckbUseBackground");
    bool flag3 = gclass22_0.method_4("ckbXoaNguyenLieuDaDung");
    bool flag4 = gclass22_0.method_4("ckbAnh");
    string string_0_4 = gclass22_0.method_1("txtPathAnh");
    int minValue3 = gclass22_0.method_3("nudSoLuongAnhFrom");
    int num3 = gclass22_0.method_3("nudSoLuongAnhTo");
    bool flag5 = gclass22_0.method_4("ckbDangLink");
    List<string> stringList = gclass22_0.method_2("txtLinkShare");
    bool flag6 = gclass22_0.method_4("ckbXoaLink");
    int num4 = 0;
    try
    {
      string str1 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      if (!flag1 || this.dictionary_4[string_2].Count != 0)
      {
        List<string> source1 = new List<string>();
        if (!flag3)
          source1 = GClass19.smethod_27(this.dictionary_4[string_2]);
        int num5 = this.random_0.Next(minValue1, num1 + 1);
        for (int index1 = 0; index1 < num5 + 5 && num4 < num5; ++index1)
        {
          this.method_184(int_4, str1 + string.Format("({0}/{1})...", (object) (num4 + 1), (object) num5));
          try
          {
            if (!gclass27_0.method_31(0, "", "//android.view.ViewGroup[@content-desc=\"Make a post on Facebook\"]"))
            {
              this.method_184(int_4, str1 + string.Format("({0}/{1}), Go to Home...", (object) (num4 + 1), (object) num5));
              gclass27_0.method_107();
              gclass27_0.SleepSeconds(2.0);
            }
            int tickCount = Environment.TickCount;
            int num6 = 300;
            string string_11_1;
            string string_11_2;
            do
            {
              string_11_1 = gclass27_0.method_53();
              string_11_2 = gclass27_0.method_29(0, string_11_1, new List<string>()
              {
                "//android.view.ViewGroup[@content-desc=\"Make a post on Facebook\"]",
                "//*[@content-desc='POST'][@enabled='true']",
                "//android.widget.EditText",
                "//android.view.View[@content-desc='Public']",
                "//android.widget.TextView[@text='Choose default audience']"
              });
              switch (string_11_2)
              {
                case "//android.view.ViewGroup[@content-desc=\"Make a post on Facebook\"]":
                case "//android.view.View[@content-desc='Public']":
                  this.method_184(int_4, str1 + "Tap " + gclass27_0.method_151(string_11_2) + "...");
                  gclass27_0.method_60(string_11_2, string_11_1);
                  break;
                case "//android.widget.TextView[@text='Choose default audience']":
                  bool flag7 = false;
                  if (gclass27_0.method_61(5, "//android.widget.Button[@content-desc=\"Public Anyone on or off Facebook\"]", ""))
                    flag7 = gclass27_0.method_64("", 5, "//*[@text='Done']", "//*[@text='Save']");
                  if (!flag7)
                  {
                    gclass27_0.method_61(5, "//android.widget.ImageView[@content-desc=\"Back\"]", "");
                    gclass27_0.SleepSeconds(2.0);
                    break;
                  }
                  break;
                case "//android.widget.EditText":
                  if (!gclass27_0.method_33(0, ref string_11_1, "//android.view.ViewGroup[@content-desc=\"Choose privacy Public\"]"))
                  {
                    bool flag8 = false;
                    gclass27_0.method_61(0, "//android.view.ViewGroup[contains(@content-desc,\"Choose privacy\")]", string_11_1);
                    if (gclass27_0.method_61(5, "//android.widget.Button[@content-desc=\"Public Anyone on or off Facebook\"]", ""))
                      flag8 = gclass27_0.method_61(5, "//android.widget.Button[@text='Done']", "");
                    if (!flag8)
                    {
                      gclass27_0.method_61(5, "//android.widget.ImageView[@content-desc=\"Back\"]", "");
                      gclass27_0.SleepSeconds(2.0);
                    }
                  }
                  if (flag5)
                  {
                    gclass27_0.method_80(1.0, 1.5);
                    this.method_184(int_4, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("Nhập dữ liệu..."));
                    gclass27_0.method_50("//android.widget.EditText", stringList[int_4 % stringList.Count]);
                    gclass27_0.method_80(1.0, 1.5);
                    gclass27_0.method_79(GClass27.GEnum10.const_62);
                    gclass27_0.method_80(1.0, 1.5);
                    gclass27_0.method_31(15, "", "//*[@content-desc='Remove']");
                    gclass27_0.method_80(2.0, 3.0);
                    if (flag6)
                    {
                      gclass27_0.method_46("//android.widget.EditText");
                      gclass27_0.method_80(1.0, 1.5);
                    }
                  }
                  if (flag1)
                  {
                    string string_0_5 = "";
                    if (!flag3)
                    {
                      if (source1.Count == 0)
                        source1 = GClass19.smethod_27(this.dictionary_4[string_2]);
                      string_0_5 = source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).FirstOrDefault<string>();
                      source1.Remove(string_0_5);
                    }
                    else
                    {
                      lock (this.dictionary_4)
                      {
                        if (this.dictionary_4[string_2].Count != 0)
                        {
                          int index2 = this.random_0.Next(0, this.dictionary_4[string_2].Count);
                          string_0_5 = this.dictionary_4[string_2][index2];
                          this.dictionary_4[string_2].RemoveAt(index2);
                        }
                        else
                          goto label_38;
                      }
                    }
                    string string_12 = GClass19.smethod_28(string_0_5, this.random_0);
                    if (string_12.Trim() != "")
                    {
                      gclass27_0.method_80(1.0, 1.5);
                      this.method_184(int_4, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("Nhập dữ liệu..."));
                      if (flag5 && !flag6)
                        string_12 = gclass27_0.method_34("", "//android.widget.EditText", "text").First<string>() + string_12;
                      gclass27_0.method_50("//android.widget.EditText", string_12);
                      gclass27_0.method_80(1.0, 1.5);
                      gclass27_0.method_79(GClass27.GEnum10.const_62);
                      gclass27_0.method_80(1.0, 1.5);
                      if (flag2)
                      {
                        this.method_184(int_4, str1 + string.Format("({0}/{1}), Find background...", (object) (num4 + 1), (object) num5));
                        List<string> list_0 = gclass27_0.method_37(0, "", "//android.view.ViewGroup[contains(@content-desc,\", background\")]");
                        if (list_0.Count > 2)
                        {
                          list_0.RemoveAt(list_0.Count - 1);
                          this.method_184(int_4, str1 + string.Format("({0}/{1}), Tap background...", (object) (num4 + 1), (object) num5));
                          gclass27_0.method_66(list_0.smethod_10());
                        }
                      }
                    }
                  }
                  if (flag4)
                  {
                    int int_4_1 = Class54.random_0.Next(minValue3, num3 + 1);
                    if (this.method_77(gclass27_0, string_0_4, int_4_1))
                    {
                      gclass27_0.method_61(5, "//android.view.ViewGroup[@content-desc='Photo/video']", "");
                      bool flag9 = false;
                      for (int index3 = 0; index3 < 10; ++index3)
                      {
                        string str2 = gclass27_0.method_53();
                        string string_11_3 = gclass27_0.method_29(0, str2, new List<string>()
                        {
                          "//android.widget.Button[@text='ALLOW']",
                          "//android.view.ViewGroup[@content-desc='Allow access']",
                          "//android.view.ViewGroup[@content-desc='Choose layout']",
                          "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"
                        });
                        if (!(string_11_3 == "//android.view.ViewGroup[@content-desc='Choose layout']") && !(string_11_3 == "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
                        {
                          if (string_11_3 != "")
                          {
                            this.method_184(int_4, str1 + "Tap " + gclass27_0.method_151(string_11_3) + "...");
                            gclass27_0.method_60(string_11_3, str2);
                          }
                          else
                            gclass27_0.method_78(-1);
                          gclass27_0.SleepSeconds(1.0);
                        }
                        else
                        {
                          if (gclass27_0.method_31(0, str2, "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
                          {
                            if (gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc='Select multiple']", str2))
                              gclass27_0.SleepSeconds(2.0);
                            List<string> source2 = gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
                            for (int index4 = 0; index4 < 5; ++index4)
                            {
                              for (int index5 = 0; index5 < int_4_1; ++index5)
                              {
                                for (; source2.Count == 0; source2 = gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']"))
                                {
                                  this.method_184(int_4, str1 + "Scroll...");
                                  if (gclass27_0.method_78())
                                    break;
                                }
                                if (source2.Count != 0)
                                {
                                  string string_0_6 = source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).FirstOrDefault<string>();
                                  source2.Remove(string_0_6);
                                  gclass27_0.method_54(new Class77(string_0_6).method_1());
                                }
                                else
                                  break;
                              }
                              if (source2.Count == 0 || gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='true']").Count >= int_4_1)
                                break;
                            }
                            gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc='NEXT']", "");
                            flag9 = true;
                            break;
                          }
                          break;
                        }
                      }
                      if (!flag9)
                        gclass27_0.method_28();
                    }
                    break;
                  }
                  break;
                case "//*[@content-desc='POST'][@enabled='true']":
                  goto label_39;
                default:
                  this.method_184(int_4, str1 + string.Format("({0}/{1}), Scroll...", (object) (num4 + 1), (object) num5));
                  if (!gclass27_0.method_78(-1))
                    break;
                  goto label_11;
              }
              gclass27_0.SleepSeconds(1.0);
            }
            while (Environment.TickCount - tickCount < num6 * 1000);
            continue;
label_11:
            int num7 = this.method_32(gclass27_0, int_4, string_0_1);
            if (num7 != 1 && num7 != 0)
              return num4;
            continue;
label_38:
            return num4;
label_39:
            this.method_184(int_4, str1 + "Tap " + gclass27_0.method_151(string_11_2) + "...");
            gclass27_0.method_60(string_11_2, string_11_1);
            this.method_184(int_4, str1 + string.Format("({0}/{1}), Tap Post, ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(12, 15));
            this.method_184(int_4, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " post success...");
            if (gclass27_0.method_42(flag4 ? 300 : 60))
            {
              ++num4;
              if (num4 >= num5)
                return num4;
              this.method_184(int_4, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
            }
          }
          catch
          {
          }
        }
      }
    }
    catch
    {
    }
    return num4;
  }

  public int SleepSeconds(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1_1,
    string string_2)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom", 1);
    int num1 = gclass22_0.method_3("nudSoLuongTo", 1);
    int minValue2 = gclass22_0.method_3("nudKhoangCachFrom");
    int num2 = gclass22_0.method_3("nudKhoangCachTo");
    int num3 = gclass22_0.method_3("typeNhom");
    bool bool_0 = gclass22_0.method_4("ckbChiShareNhomKKD");
    bool flag1 = gclass22_0.method_4("ckbUuTienShareNhomNhieuThanhVien");
    bool flag2 = gclass22_0.method_4("ckbBackupDanhSachNhom");
    bool flag3 = gclass22_0.method_4("ckbKhongShareTrungNhom");
    bool flag4 = gclass22_0.method_4("ckbChiShareNhomThuocDanhSach");
    List<string> second = GClass19.smethod_39(gclass22_0.method_2("lstNhomTuNhap"));
    bool flag5 = gclass22_0.method_4("ckbTuDongXoaUid");
    bool flag6 = gclass22_0.method_4("ckbVanBan");
    bool flag7 = gclass22_0.method_4("ckbUseBackground");
    bool flag8 = gclass22_0.method_4("ckbXoaNguyenLieuDaDung");
    bool flag9 = gclass22_0.method_4("ckbAnh");
    string string_0_9 = gclass22_0.method_1("txtPathAnh");
    int minValue3 = gclass22_0.method_3("nudSoLuongAnhFrom");
    int num4 = gclass22_0.method_3("nudSoLuongAnhTo");
    bool flag10 = gclass22_0.method_4("ckbDangLink");
    List<string> stringList1 = gclass22_0.method_2("txtLinkShare");
    bool flag11 = gclass22_0.method_4("ckbXoaLink");
    if (!this.dictionary_7.ContainsKey(string_2))
      this.dictionary_7.Add(string_2, new List<string>());
    int num5 = 0;
    try
    {
      string string_0_10 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1_1 + ": ";
      if (!flag6 || this.dictionary_5[string_2].Count != 0)
      {
        List<string> source1 = new List<string>();
        if (!flag8)
          source1 = GClass19.smethod_27(this.dictionary_5[string_2]);
        List<string> stringList2 = new List<string>();
        List<string> first;
        if (num3 != 0)
        {
          first = this.method_101(this.dictionary_6[string_2]);
        }
        else
        {
          this.method_184(int_4, string_0_10 + "Scan groups...");
          string str1 = gclass27_0.method_114().Split('|')[1];
          string str2 = Regex.Match(str1, "c_user=(.*?);").Groups[1].Value;
          bool flag12 = true;
          List<string> stringList3 = new List<string>();
          if (flag2 && File.Exists("backupgroup\\" + str2 + ".txt"))
          {
            stringList3 = GClass19.smethod_7("backupgroup\\" + str2 + ".txt");
            if (stringList3.Count > 0)
            {
              string[] strArray = stringList3[0].Split('|');
              int num6;
              if (strArray.Length >= 4)
                num6 = !((IEnumerable<string>) new string[2]
                {
                  "true",
                  "false"
                }).Contains<string>(strArray[3].ToLower()) ? 1 : 0;
              else
                num6 = 1;
              flag12 = num6 != 0;
            }
          }
          if (flag12)
          {
            this.method_184(int_4, string_0_1 + GClass35.smethod_0("Scan group..."));
            stringList3 = Class38.smethod_1(str1, gclass27_0.string_8, gclass27_0.int_1, bool_0);
          }
          if (stringList3.Count != 0)
          {
            if (flag2)
              File.WriteAllLines("backupgroup\\" + str2 + ".txt", (IEnumerable<string>) stringList3);
            List<string> source2 = !bool_0 ? stringList3.Select<string, string>((System.Func<string, string>) (string_0_2 => string_0_2)).ToList<string>() : stringList3.Where<string>((System.Func<string, bool>) (string_0_3 => string_0_3.Split('|')[3].ToLower() == "false")).ToList<string>();
            if (flag1)
              source2.Sort((Comparison<string>) ((string_0_4, string_1_2) => int.Parse(string_1_2.Split('|')[2]).CompareTo(int.Parse(string_0_4.Split('|')[2]))));
            else
              source2 = source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_5 => Guid.NewGuid())).ToList<string>();
            first = source2.Select<string, string>((System.Func<string, string>) (string_0_6 => string_0_6.Split('|')[0])).ToList<string>();
            if (flag4)
              first = first.Intersect<string>((IEnumerable<string>) second).ToList<string>();
          }
          else
            goto label_139;
        }
        if (first.Count != 0)
        {
          int num7 = this.random_0.Next(minValue1, num1 + 1);
          string str3 = "";
label_137:
          for (int index1 = 0; index1 < num7 + 5 && num5 < num7 && first.Count != 0; ++index1)
          {
            switch (num3)
            {
              case 0:
                if (!flag3)
                {
                  int index2 = this.random_0.Next(0, first.Count);
                  if (flag1)
                    index2 = 0;
                  str3 = first[index2];
                  first.RemoveAt(index2);
                  break;
                }
                while (first.Count != 0)
                {
                  int index3 = this.random_0.Next(0, first.Count);
                  if (flag1)
                    index3 = 0;
                  str3 = first[index3];
                  first.RemoveAt(index3);
                  lock (this.dictionary_7)
                  {
                    if (!this.dictionary_7[string_2].Contains(str3))
                    {
                      this.dictionary_7[string_2].Add(str3);
                      goto label_49;
                    }
                  }
                }
                goto label_139;
              case 1:
                if (!flag5)
                {
                  int index4 = this.random_0.Next(0, first.Count);
                  str3 = first[index4];
                  first.RemoveAt(index4);
                  break;
                }
                lock (this.dictionary_6)
                {
                  if (this.dictionary_6[string_2].Count != 0)
                  {
                    int index5 = this.random_0.Next(0, this.dictionary_6[string_2].Count);
                    str3 = this.dictionary_6[string_2][index5];
                    this.dictionary_6[string_2].RemoveAt(index5);
                    break;
                  }
                  goto label_139;
                }
            }
label_49:
            try
            {
label_51:
              this.method_184(int_4, string_0_10 + string.Format("({0}/{1}), Go to group {2}...", (object) (num5 + 1), (object) num7, (object) str3));
              if (this.method_215(gclass27_0, int_4, string_0_10, "fb://group/" + str3))
              {
                int num8 = 0;
                int tickCount = Environment.TickCount;
                int num9 = 300;
                do
                {
                  string str4 = gclass27_0.method_53();
                  string str5 = gclass27_0.method_29(0, str4, new List<string>()
                  {
                    "//android.view.ViewGroup[starts-with(@content-desc, \"Write something\")]",
                    "//android.view.ViewGroup[@content-desc='Discussion']",
                    "//android.view.ViewGroup[@content-desc='Cancel request']",
                    "//*[starts-with(@content-desc, 'Join ')]",
                    "//android.view.ViewGroup[@content-desc=\"Submit\"]",
                    "//*[@content-desc='POST'][@enabled='true']",
                    "//android.widget.EditText",
                    "//android.view.View[@content-desc='Public']"
                  });
                  string s = str5;
                  // ISSUE: reference to a compiler-generated method
                  uint num10 = Class206.smethod_0(s);
                  if (num10 > 1964222373U)
                  {
                    if (num10 <= 2686990081U)
                    {
                      if (num10 != 2593578165U)
                      {
                        if (num10 == 2686990081U && s == "//*[starts-with(@content-desc, 'Join ')]")
                        {
                          if (num8 < 2)
                          {
                            if (gclass27_0.method_37(0, str4, str5).Count == 1)
                            {
                              ++num8;
                              this.method_184(int_4, string_0_10 + "Tap " + gclass27_0.method_151(str5) + "...");
                              gclass27_0.method_60(str5, str4);
                              goto label_134;
                            }
                            else if (gclass27_0.method_31(0, str4, "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]"))
                            {
                              gclass27_0.method_78();
                              goto label_134;
                            }
                            else
                              break;
                          }
                          else
                            break;
                        }
                      }
                      else if (s == "//android.view.ViewGroup[@content-desc='Discussion']")
                        goto label_107;
                    }
                    else if (num10 != 2689758236U)
                    {
                      if (num10 == 3698172066U && s == "//android.view.ViewGroup[@content-desc='Cancel request']")
                        break;
                    }
                    else if (s == "//android.view.ViewGroup[starts-with(@content-desc, \"Write something\")]")
                      goto label_107;
                  }
                  else if (num10 <= 819242523U)
                  {
                    if (num10 != 16665493U)
                    {
                      if (num10 == 819242523U && s == "//android.view.ViewGroup[@content-desc=\"Submit\"]")
                        break;
                    }
                    else if (s == "//*[@content-desc='POST'][@enabled='true']")
                    {
                      this.method_184(int_4, string_0_10 + "Tap " + gclass27_0.method_151(str5) + "...");
                      gclass27_0.method_60(str5, str4);
                      this.method_184(int_4, string_0_10 + string.Format("({0}/{1}), Tap Post, ", (object) (num5 + 1), (object) num7) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(12, 15));
                      string string_11 = "";
                      if (gclass27_0.method_33(5, ref string_11, "//*[@content-desc='Not now']"))
                      {
                        gclass27_0.method_60("//*[@content-desc='Not now']", string_11);
                        gclass27_0.SleepSeconds(3.0);
                      }
                      this.method_184(int_4, string_0_10 + string.Format("({0}/{1}), ", (object) (num5 + 1), (object) num7) + GClass35.smethod_0("đợi") + " post success...");
                      if (gclass27_0.method_42(flag9 ? 300 : 60))
                      {
                        ++num5;
                        if (num5 >= num7)
                          return num5;
                        this.method_184(int_4, string_0_10 + string.Format("({0}/{1}), ", (object) (num5 + 1), (object) num7) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                        break;
                      }
                      break;
                    }
                  }
                  else if (num10 != 1740273391U)
                  {
                    if (num10 == 1964222373U && s == "//android.widget.EditText")
                    {
                      if (flag10)
                      {
                        gclass27_0.method_80(1.0, 1.5);
                        this.method_184(int_4, string_0_10 + string.Format("({0}/{1}), ", (object) (num5 + 1), (object) num7) + GClass35.smethod_0("Nhập dữ liệu..."));
                        gclass27_0.method_50("//android.widget.EditText", stringList1[int_4 % stringList1.Count]);
                        gclass27_0.method_80(1.0, 1.5);
                        gclass27_0.method_79(GClass27.GEnum10.const_62);
                        gclass27_0.method_80(1.0, 1.5);
                        gclass27_0.method_31(15, "", "//*[@content-desc='Remove']");
                        gclass27_0.method_80(2.0, 3.0);
                        if (flag11)
                        {
                          gclass27_0.method_46("//android.widget.EditText");
                          gclass27_0.method_80(1.0, 1.5);
                        }
                      }
                      if (flag6)
                      {
                        string string_0_11 = "";
                        if (!flag8)
                        {
                          if (source1.Count == 0)
                            source1 = GClass19.smethod_27(this.dictionary_5[string_2]);
                          string_0_11 = source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_7 => Guid.NewGuid())).FirstOrDefault<string>();
                          source1.Remove(string_0_11);
                        }
                        else
                        {
                          lock (this.dictionary_5)
                          {
                            if (this.dictionary_5[string_2].Count != 0)
                            {
                              int index6 = this.random_0.Next(0, this.dictionary_5[string_2].Count);
                              string_0_11 = this.dictionary_5[string_2][index6];
                              this.dictionary_5[string_2].RemoveAt(index6);
                              goto label_99;
                            }
                          }
                          return num5;
                        }
label_99:
                        string string_12 = GClass19.smethod_28(string_0_11, this.random_0);
                        if (string_12.Trim() != "")
                        {
                          gclass27_0.method_80(1.0, 1.5);
                          this.method_184(int_4, string_0_10 + string.Format("({0}/{1}), ", (object) (num5 + 1), (object) num7) + GClass35.smethod_0("Nhập dữ liệu..."));
                          if (flag10 && !flag11)
                            string_12 = gclass27_0.method_34("", "//android.widget.EditText", "text").First<string>() + string_12;
                          gclass27_0.method_50("//android.widget.EditText", string_12);
                          gclass27_0.method_80(1.0, 1.5);
                          gclass27_0.method_79(GClass27.GEnum10.const_62);
                          gclass27_0.method_80(1.0, 1.5);
                          if (flag7)
                          {
                            this.method_184(int_4, string_0_10 + string.Format("({0}/{1}), Tap Background...", (object) (num5 + 1), (object) num7));
                            List<string> list_0 = gclass27_0.method_37(0, "", "//android.view.ViewGroup[contains(@content-desc,\", background\")]");
                            if (list_0.Count > 2)
                            {
                              list_0.RemoveAt(list_0.Count - 1);
                              gclass27_0.method_66(list_0.smethod_10());
                            }
                          }
                        }
                      }
                      if (flag9)
                      {
                        int int_4_1 = Class54.random_0.Next(minValue3, num4 + 1);
                        if (this.method_77(gclass27_0, string_0_9, int_4_1))
                        {
                          gclass27_0.method_61(5, "//android.view.ViewGroup[@content-desc='Photo/video']", "");
                          for (int index7 = 0; index7 < 10; ++index7)
                          {
                            string str6 = gclass27_0.method_53();
                            string string_11 = gclass27_0.method_29(0, str6, new List<string>()
                            {
                              "//android.widget.Button[@text='ALLOW']",
                              "//android.view.ViewGroup[@content-desc='Allow access']",
                              "//android.view.ViewGroup[@content-desc='Choose layout']",
                              "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"
                            });
                            if (!(string_11 == "//android.view.ViewGroup[@content-desc='Choose layout']") && !(string_11 == "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
                            {
                              if (string_11 != "")
                              {
                                this.method_184(int_4, string_0_10 + "Tap " + gclass27_0.method_151(string_11) + "...");
                                gclass27_0.method_60(string_11, str6);
                              }
                              else
                                gclass27_0.method_78(-1);
                              gclass27_0.SleepSeconds(1.0);
                            }
                            else
                            {
                              if (gclass27_0.method_31(0, str6, "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
                              {
                                if (gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc='Select multiple']", str6))
                                  gclass27_0.SleepSeconds(2.0);
                                List<string> source3 = gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
                                for (int index8 = 0; index8 < 5; ++index8)
                                {
                                  for (int index9 = 0; index9 < int_4_1; ++index9)
                                  {
                                    for (; source3.Count == 0; source3 = gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']"))
                                    {
                                      this.method_184(int_4, string_0_10 + "Scroll...");
                                      if (gclass27_0.method_78())
                                        break;
                                    }
                                    if (source3.Count != 0)
                                    {
                                      string string_0_12 = source3.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_8 => Guid.NewGuid())).FirstOrDefault<string>();
                                      source3.Remove(string_0_12);
                                      gclass27_0.method_54(new Class77(string_0_12).method_1());
                                      gclass27_0.SleepSeconds(1.0);
                                    }
                                    else
                                      break;
                                  }
                                  if (source3.Count == 0 || gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='true']").Count >= int_4_1)
                                    break;
                                }
                                gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc='NEXT']", "");
                                break;
                              }
                              break;
                            }
                          }
                        }
                        goto label_134;
                      }
                      else
                        goto label_134;
                    }
                  }
                  else if (s == "//android.view.View[@content-desc='Public']")
                    goto label_107;
                  if (!gclass27_0.method_146(str4, "This content isn't available", "When this happens, it's usually because the owner only shared it with a small group of people, changed who can see it or it's been deleted.", "Reload page", "Something went wrong"))
                  {
                    this.method_184(int_4, string_0_10 + string.Format("({0}/{1}), Scroll...", (object) (num5 + 1), (object) num7));
                    if (num8 <= 0 ? gclass27_0.method_78(-1) : gclass27_0.method_78())
                    {
                      switch (this.method_32(gclass27_0, int_4, string_0_1))
                      {
                        case 0:
                          goto label_137;
                        case 1:
                          goto label_51;
                        default:
                          return num5;
                      }
                    }
                    else
                      goto label_134;
                  }
                  else
                    break;
label_107:
                  this.method_184(int_4, string_0_10 + "Tap " + gclass27_0.method_151(str5) + "...");
                  gclass27_0.method_60(str5, str4);
label_134:
                  gclass27_0.SleepSeconds(2.0);
                }
                while (Environment.TickCount - tickCount < num9 * 1000);
              }
            }
            catch
            {
            }
          }
        }
      }
    }
    catch
    {
    }
label_139:
    return num5;
  }

  private bool method_82(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    string string_1,
    string string_2)
  {
    return false;
  }

  public int method_83(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom", 1);
    int num1 = gclass22_0.method_3("nudSoLuongTo", 1);
    int minValue2 = gclass22_0.method_3("nudKhoangCachFrom");
    int num2 = gclass22_0.method_3("nudKhoangCachTo");
    int num3 = gclass22_0.method_3("typeNhom");
    bool flag1 = gclass22_0.method_4("ckbTuDongXoaUid");
    gclass22_0.method_4("ckbChiDangNhomKKD");
    bool flag2 = gclass22_0.method_4("ckbVanBan");
    bool flag3 = gclass22_0.method_4("ckbUseBackground");
    bool flag4 = gclass22_0.method_4("ckbXoaNguyenLieuDaDung");
    bool flag5 = gclass22_0.method_4("ckbHashtag");
    gclass22_0.method_2("txtHashtag");
    int int_2 = gclass22_0.method_3("nudSoHashtagFrom", 1);
    int int_3 = gclass22_0.method_3("nudSoHashtagTo", 1);
    bool flag6 = gclass22_0.method_4("ckbAnh");
    string string_0_5 = gclass22_0.method_1("txtPathAnh");
    bool bool_5 = gclass22_0.method_4("ckbXoaAnhDaDang");
    int minValue3 = gclass22_0.method_3("nudSoLuongAnhFrom");
    int num4 = gclass22_0.method_3("nudSoLuongAnhTo");
    int num5 = 0;
    try
    {
      string string_0_6 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      if (this.dictionary_8[string_2].Count != 0)
      {
        List<string> source1 = new List<string>();
        if (!flag4)
          source1 = GClass19.smethod_27(this.dictionary_8[string_2]);
        List<string> stringList1 = new List<string>();
        List<string> stringList2;
        if (num3 == 0)
        {
          this.method_184(int_4, string_0_6 + "Scan page...");
          stringList2 = Class38.smethod_0(gclass27_0.method_114().Split('|')[1], gclass27_0.string_8, gclass27_0.int_1);
        }
        else
          stringList2 = this.method_101(this.dictionary_9[string_2]);
        if (stringList2.Count != 0)
        {
          int num6 = this.random_0.Next(minValue1, num1 + 1);
          string str1 = "";
label_105:
          for (int index1 = 0; index1 < num6 + 5 && num5 < num6 && stringList2.Count != 0; ++index1)
          {
            if (num3 == 1 & flag1)
            {
              lock (this.dictionary_9)
              {
                if (this.dictionary_9[string_2].Count != 0)
                {
                  int index2 = this.random_0.Next(0, this.dictionary_9[string_2].Count);
                  str1 = this.dictionary_9[string_2][index2];
                  this.dictionary_9[string_2].RemoveAt(index2);
                }
                else
                  break;
              }
            }
            else if (stringList2.Count != 0)
            {
              int index3 = this.random_0.Next(0, stringList2.Count);
              str1 = stringList2[index3];
              stringList2.RemoveAt(index3);
            }
            else
              break;
            try
            {
label_20:
              this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), Go to page {2}...", (object) (num5 + 1), (object) num6, (object) str1));
              if (this.method_215(gclass27_0, int_4, string_0_6, "fb://page/" + str1))
              {
                bool flag7 = false;
                int tickCount = Environment.TickCount;
                int num7 = 300;
                string str2;
                string string_11_1;
                do
                {
                  str2 = gclass27_0.method_53();
                  string_11_1 = gclass27_0.method_29(0, str2, new List<string>()
                  {
                    "//*[@content-desc='Overview']",
                    "//*[@content-desc='Create a post']",
                    "//android.view.ViewGroup[starts-with(@content-desc, \"Write something\")]",
                    "//android.view.ViewGroup[@content-desc='Discussion']",
                    "//android.view.ViewGroup[@content-desc='Cancel request']",
                    "//android.view.ViewGroup[@content-desc=\"Submit\"]",
                    "//android.widget.EditText[@text='Help your video stand out with a title']",
                    "//*[@content-desc='POST'][@enabled='true']",
                    "//*[@content-desc='SHARE'][@enabled='true']",
                    "//android.widget.EditText",
                    "//android.view.View[@content-desc='Public']"
                  });
                  string s = string_11_1;
                  // ISSUE: reference to a compiler-generated method
                  uint num8 = Class206.smethod_0(s);
                  if (num8 > 1964222373U)
                  {
                    if (num8 <= 2567919276U)
                    {
                      if (num8 != 2070156739U)
                      {
                        if (num8 != 2419027548U)
                        {
                          if (num8 == 2567919276U && s == "//*[@content-desc='Create a post']")
                            goto label_102;
                        }
                        else if (s == "//*[@content-desc='SHARE'][@enabled='true']")
                          goto label_87;
                      }
                      else if (s == "//android.widget.EditText[@text='Help your video stand out with a title']")
                      {
                        gclass27_0.method_50(string_11_1, " ");
                        goto label_60;
                      }
                    }
                    else if (num8 != 2593578165U)
                    {
                      if (num8 != 2689758236U)
                      {
                        if (num8 == 3698172066U && s == "//android.view.ViewGroup[@content-desc='Cancel request']")
                          break;
                      }
                      else if (s == "//android.view.ViewGroup[starts-with(@content-desc, \"Write something\")]")
                        goto label_102;
                    }
                    else if (s == "//android.view.ViewGroup[@content-desc='Discussion']")
                      goto label_102;
                  }
                  else if (num8 <= 330244122U)
                  {
                    if (num8 != 16665493U)
                    {
                      if (num8 == 330244122U && s == "//*[@content-desc='Overview']")
                        goto label_102;
                    }
                    else if (s == "//*[@content-desc='POST'][@enabled='true']")
                      goto label_87;
                  }
                  else if (num8 != 819242523U)
                  {
                    if (num8 != 1740273391U)
                    {
                      if (num8 == 1964222373U && s == "//android.widget.EditText")
                      {
                        if (flag2)
                        {
                          string string_0_7 = "";
                          if (!flag4)
                          {
                            if (source1.Count == 0)
                              source1 = GClass19.smethod_27(this.dictionary_8[string_2]);
                            string_0_7 = source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).FirstOrDefault<string>();
                            source1.Remove(string_0_7);
                          }
                          else
                          {
                            lock (this.dictionary_8)
                            {
                              if (this.dictionary_8[string_2].Count != 0)
                              {
                                int index4 = this.random_0.Next(0, this.dictionary_8[string_2].Count);
                                string_0_7 = this.dictionary_8[string_2][index4];
                                this.dictionary_8[string_2].RemoveAt(index4);
                                goto label_91;
                              }
                            }
                            return num5;
                          }
label_91:
                          if (flag5)
                          {
                            string str3 = string_0_7 + "\n";
                            List<string> source2 = gclass22_0.method_2("txtHashtag");
                            int num9 = GClass19.smethod_100(int_2, int_3);
                            for (int index5 = 0; index5 < num9 && source2.Count != 0; ++index5)
                            {
                              string str4 = source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).First<string>();
                              source2.Remove(str4);
                              str3 = str3 + str4 + " ";
                            }
                            string_0_7 = str3.Trim();
                          }
                          string string_12 = GClass19.smethod_28(string_0_7, this.random_0);
                          if (string_12.Trim() != "")
                          {
                            gclass27_0.method_80(1.0, 1.5);
                            this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), ", (object) (num5 + 1), (object) num6) + GClass35.smethod_0("Nhập dữ liệu..."));
                            gclass27_0.method_50("//android.widget.EditText", string_12);
                            gclass27_0.method_80(1.0, 1.5);
                            gclass27_0.method_79(GClass27.GEnum10.const_62);
                            gclass27_0.method_80(1.0, 1.5);
                            if (flag3)
                            {
                              this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), Tap Background...", (object) (num5 + 1), (object) num6));
                              List<string> list_0 = gclass27_0.method_37(0, "", "//android.view.ViewGroup[contains(@content-desc,\", background\")]");
                              if (list_0.Count > 2)
                              {
                                list_0.RemoveAt(list_0.Count - 1);
                                gclass27_0.method_66(list_0.smethod_10());
                              }
                            }
                          }
                        }
                        if (flag6)
                        {
                          int int_4_1 = Class54.random_0.Next(minValue3, num4 + 1);
                          if (this.method_77(gclass27_0, string_0_5, int_4_1, bool_5))
                          {
                            gclass27_0.method_61(5, "//android.view.ViewGroup[@content-desc='Photo/video']", "");
                            for (int index6 = 0; index6 < 10; ++index6)
                            {
                              string str5 = gclass27_0.method_53();
                              string string_11_2 = gclass27_0.method_29(0, str5, new List<string>()
                              {
                                "//android.widget.Button[@text='ALLOW']",
                                "//android.view.ViewGroup[@content-desc='Allow access']",
                                "//android.view.ViewGroup[@content-desc='Choose layout']",
                                "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"
                              });
                              if (!(string_11_2 == "//android.view.ViewGroup[@content-desc='Choose layout']") && !(string_11_2 == "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
                              {
                                if (string_11_2 != "")
                                {
                                  this.method_184(int_4, string_0_6 + "Tap " + gclass27_0.method_151(string_11_2) + "...");
                                  gclass27_0.method_60(string_11_2, str5);
                                }
                                else
                                  gclass27_0.method_78(-1);
                                gclass27_0.SleepSeconds(1.0);
                              }
                              else
                              {
                                if (gclass27_0.method_31(0, str5, "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
                                {
                                  if (gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc='Select multiple']", str5))
                                    gclass27_0.SleepSeconds(2.0);
                                  List<string> source3 = gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
                                  for (int index7 = 0; index7 < 5; ++index7)
                                  {
                                    for (int index8 = 0; index8 < int_4_1; ++index8)
                                    {
                                      for (; source3.Count == 0; source3 = gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']"))
                                      {
                                        this.method_184(int_4, string_0_6 + "Scroll...");
                                        if (gclass27_0.method_78())
                                          break;
                                      }
                                      if (source3.Count != 0)
                                      {
                                        string string_0_8 = source3.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_4 => Guid.NewGuid())).FirstOrDefault<string>();
                                        source3.Remove(string_0_8);
                                        gclass27_0.method_54(new Class77(string_0_8).method_1());
                                      }
                                      else
                                        break;
                                    }
                                    if (source3.Count == 0 || gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='true']").Count >= int_4_1)
                                      break;
                                  }
                                  gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc='NEXT']", "");
                                  break;
                                }
                                break;
                              }
                            }
                          }
                          goto label_60;
                        }
                        else
                          goto label_60;
                      }
                    }
                    else if (s == "//android.view.View[@content-desc='Public']")
                      goto label_102;
                  }
                  else if (s == "//android.view.ViewGroup[@content-desc=\"Submit\"]")
                    break;
                  if (!gclass27_0.method_146(str2, "This content isn't available", "When this happens, it's usually because the owner only shared it with a small group of people, changed who can see it or it's been deleted.", "Reload page"))
                  {
                    this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), Scroll...", (object) (num5 + 1), (object) num6));
                    if (!flag7 ? gclass27_0.method_78(-1) : gclass27_0.method_78())
                    {
                      switch (this.method_32(gclass27_0, int_4, string_0_1))
                      {
                        case 0:
                          goto label_105;
                        case 1:
                          goto label_20;
                        default:
                          return num5;
                      }
                    }
                  }
                  else
                    break;
label_60:
                  gclass27_0.SleepSeconds(2.0);
                  continue;
label_102:
                  this.method_184(int_4, string_0_6 + "Tap " + gclass27_0.method_151(string_11_1) + "...");
                  gclass27_0.method_60(string_11_1, str2);
                  goto label_60;
                }
                while (Environment.TickCount - tickCount < num7 * 1000);
                continue;
label_87:
                this.method_184(int_4, string_0_6 + "Tap " + gclass27_0.method_151(string_11_1) + "...");
                gclass27_0.method_60(string_11_1, str2);
                gclass27_0.SleepSeconds(2.0);
                gclass27_0.method_61(10, string_11_1, "");
                this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), Tap Share, ", (object) (num5 + 1), (object) num6) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(3, 6));
                this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), ", (object) (num5 + 1), (object) num6) + GClass35.smethod_0("đợi") + " post success...");
                gclass27_0.method_78(-1);
                gclass27_0.SleepSeconds(2.0);
                if (gclass27_0.method_42(flag6 ? 300 : 60))
                {
                  ++num5;
                  if (num5 >= num6)
                    return num5;
                  this.method_184(int_4, string_0_6 + string.Format("({0}/{1}), ", (object) (num5 + 1), (object) num6) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                }
              }
            }
            catch
            {
            }
          }
        }
      }
    }
    catch
    {
    }
    return num5;
  }

  public int method_84(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2,
    string string_3)
  {
    int num1 = gclass22_0.method_3("typeHuyKetBan");
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom");
    int num2 = gclass22_0.method_3("nudSoLuongTo");
    List<string> list_1_1 = gclass22_0.method_2("txtUid");
    int minValue2 = gclass22_0.method_3("nudDelayFrom");
    int num3 = gclass22_0.method_3("nudDelayTo");
    List<string> list_1_2 = gclass22_0.method_2("txtUidKhongHuyKetBan");
    int num4 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_3 + ": ";
      int num5 = this.random_0.Next(minValue1, num2 + 1);
      if (num5 > 0)
      {
        if (num1 == 0 && list_1_2.Count == 0)
        {
          List<string> stringList = new List<string>();
          string str = "//*[@content-desc='More options']";
          string string_11_1 = "";
label_19:
          while (gclass27_0.method_110() || this.method_215(gclass27_0, int_4, string_0_1, "fb://friends"))
          {
            List<string> list_0 = gclass27_0.method_38(10, ref string_11_1, str);
            if (list_0.Count != 0)
            {
              for (int index = 0; index < num5 + 10; ++index)
              {
                switch (this.method_32(gclass27_0, int_4, string_0))
                {
                  case 0:
                    string string_0_2 = list_0.smethod_10();
                    this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap More options...", (object) num4, (object) num5));
                    gclass27_0.method_179(string_11_1);
                    if (string_0_2 != "" && gclass27_0.method_54(new Class77(string_0_2).method_1()))
                    {
                      string string_11_2 = "";
                      if (gclass27_0.method_180(10, ref string_11_2))
                      {
                        gclass27_0.SleepSeconds(1.0);
                        gclass27_0.method_60("//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup[last()]", string_11_2);
                        gclass27_0.SleepSeconds(1.0);
                        if (gclass27_0.method_61(10, "//android.widget.Button[@text='CONFIRM']", ""))
                        {
                          ++num4;
                          if (num4 < num5)
                          {
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num3 + 1));
                          }
                          else
                          {
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}): Done!", (object) num4, (object) num5));
                            goto label_45;
                          }
                        }
                      }
                    }
                    this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find {2}...", (object) num4, (object) num5, (object) gclass27_0.method_151(str)));
                    string_11_1 = "";
                    list_0 = gclass27_0.method_38(5, ref string_11_1, str);
                    this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find {2}: ", (object) num4, (object) num5, (object) gclass27_0.method_151(str)) + list_0.Count.ToString());
                    if (list_0.Count == 0)
                    {
                      this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) num4, (object) num5));
                      if (!gclass27_0.method_78())
                      {
                        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find {2}...", (object) num4, (object) num5, (object) gclass27_0.method_151(str)));
                        string_11_1 = "";
                        list_0 = gclass27_0.method_38(10, ref string_11_1, str);
                        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find {2}: ", (object) num4, (object) num5, (object) gclass27_0.method_151(str)) + list_0.Count.ToString());
                        if (list_0.Count == 0)
                          goto label_45;
                        else
                          continue;
                      }
                      else
                      {
                        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Can't Scroll...", (object) num4, (object) num5));
                        goto label_45;
                      }
                    }
                    else
                      continue;
                  case 1:
                    goto label_19;
                  default:
                    goto label_45;
                }
              }
              break;
            }
            break;
          }
        }
        else
        {
          if (string_2 == "")
            string_2 = gclass27_0.method_114().Split('|')[1];
          List<string> list_0 = this.method_100(string_2, "", gclass27_0.string_8, gclass27_0.int_1);
          if (num1 == 1)
            list_0 = GClass19.smethod_14(list_0, list_1_1);
          if (list_1_2.Count > 0)
            list_0 = GClass19.smethod_15(list_0, list_1_2);
          if (list_0.Count == 0)
            return num4;
          if (num1 == 1)
            num5 = list_0.Count;
          while (list_0.Count > 0)
          {
            string str = list_0.smethod_10();
            list_0.Remove(str);
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Go to Profile {2}...", (object) num4, (object) num5, (object) str));
            if (this.method_215(gclass27_0, int_4, string_0_1, "fb://profile/" + str))
            {
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Hủy kết bạn...", (object) num4, (object) num5));
              for (int index = 0; index < 4; ++index)
              {
                string string_11_3 = "";
                string string_11_4 = gclass27_0.method_30(5, ref string_11_3, new List<string>()
                {
                  "(//android.view.ViewGroup[@content-desc='Friends'])[1]",
                  "//android.view.ViewGroup[@content-desc=\"Unfriend\"]",
                  "//android.widget.Button[@text=\"CONFIRM\"]"
                });
                if (string_11_4 != "")
                {
                  gclass27_0.method_60(string_11_4, string_11_3);
                  if (string_11_4 == "//android.widget.Button[@text=\"CONFIRM\"]")
                  {
                    ++num4;
                    if (num4 < num5)
                    {
                      this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num3 + 1));
                    }
                    else
                    {
                      this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Done!", (object) num4, (object) num5));
                      goto label_45;
                    }
                  }
                }
                else
                  break;
              }
            }
            else
              break;
          }
        }
      }
    }
    catch
    {
    }
label_45:
    return num4;
  }

  public int method_85(
    int int_4,
    string string_0,
    GClass18 gclass18_0,
    int int_5,
    int int_6,
    int int_7,
    int int_8,
    Random random_1,
    string string_1 = "")
  {
    string string_0_1 = this.method_191(int_4, "cUid");
    string string_1_1 = this.method_191(int_4, "cPassword");
    string string_2 = this.method_191(int_4, "cFa2");
    int num1 = 0;
    int num2 = random_1.Next(int_7, int_8 + 1);
    int int_6_1 = 0;
    try
    {
      int num3;
      do
      {
        gclass18_0.method_12("https://m.facebook.com/friends/center/requests/outgoing/");
        this.method_102();
        num3 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2);
      }
      while (num3 == 1);
      if (new List<int>() { -3, -2, -1, 2 }.Contains(num3))
        return -1;
      if (gclass18_0.method_38("[data-sigil=\"context-layer-root content-pane\"]", 10.0) == 1)
      {
        if (Convert.ToInt32(gclass18_0.method_20("return document.querySelectorAll('[data-sigil=\"undoable-action\"]').length").ToString()) == 0)
          return num1;
        while (num1 < num2)
        {
          if (gclass18_0.method_3())
            return -2;
          if (gclass18_0.method_20("return document.querySelectorAll('[data-sigil=\"undoable-action\"]')[" + int_6_1.ToString() + "].getAttribute('data-sigil')").ToString() != null)
          {
            this.method_102();
            gclass18_0.method_44("document.querySelectorAll('[data-sigil=\"touchable check m-cancel-request\"]')[" + int_6_1.ToString() + "]");
            this.method_102();
            gclass18_0.method_21(4, "[data-sigil=\"touchable check m-cancel-request\"]", int_6_1);
            ++num1;
            ++int_6_1;
            this.method_184(int_4, string_0 + GClass35.smethod_0("Đang") + string.Format(" {0} ({1}/{2})...", (object) string_1, (object) num1, (object) num2));
            gclass18_0.method_56((double) random_1.Next(int_7, int_8 + 1));
          }
          else
            break;
        }
      }
    }
    catch
    {
    }
    return num1;
  }

  public int method_86(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int int_5 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_18 = gclass22_0.method_2("txtComment");
    int num1 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num2;
      do
      {
        gclass27_0.Openreel();
        gclass27_0.method_80(2.0, 3.0);
        num2 = this.method_32(gclass27_0, int_4, string_0);
        if (num2 == 0)
          goto label_3;
      }
      while (num2 == 1);
      goto label_6;
label_3:
      this.method_107(int_4, string_0_1, gclass27_0, int_5, int_6, bool_5, "0124", 0, 9999, bool_6, 0, 9999, list_18, bool_7, 0, 9999);
    }
    catch
    {
      num1 = -1;
    }
label_6:
    return num1;
  }

  public int method_87(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    string string_1_1 = gclass22_0.method_1("txtIdPost");
    int minValue = gclass22_0.method_3("nudTimeFrom");
    int num1 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_18 = gclass22_0.method_2("txtComment");
    int num2 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      if (this.method_215(gclass27_0, int_4, string_0_1, string_1_1))
      {
        this.method_184(int_4, string_0_1 + GClass35.smethod_0("Xem, " + GClass35.smethod_0("đợi") + " {time}s..."), Class54.random_0.Next(minValue, num1 + 1));
        this.method_184(int_4, string_0_1 + GClass35.smethod_0("Tương tác..."));
        int int_5 = 0;
        int int_6 = 0;
        int int_7 = 0;
        List<string> list_19 = new List<string>();
        for (int index = 0; index < 5; ++index)
        {
          this.method_110(int_4, string_0_1, gclass27_0, bool_5, "0", ref int_5, bool_6, ref int_6, list_18, ref list_19, bool_7, ref int_7, 1);
          if (int_5 <= 0 && int_6 <= 0)
          {
            this.method_184(int_4, string_0_1 + "Scroll...");
            if (gclass27_0.method_78() && !gclass27_0.method_104())
              break;
          }
          else
            break;
        }
      }
    }
    catch
    {
      num2 = -1;
    }
    return num2;
  }

  public int method_88(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int int_5 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    int int_7 = gclass22_0.method_3("nudCountLikeFrom");
    int int_8 = gclass22_0.method_3("nudCountLikeTo");
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    int int_11 = gclass22_0.method_3("nudCountShareFrom");
    int int_12 = gclass22_0.method_3("nudCountShareTo");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_18 = gclass22_0.method_2("txtComment");
    int int_9 = gclass22_0.method_3("nudCountCommentFrom");
    int int_10 = gclass22_0.method_3("nudCountCommentTo");
    gclass22_0.method_3("nudPercentLike", 50);
    gclass22_0.method_3("nudPercentShare", 50);
    gclass22_0.method_3("nudPercentComment", 50);
    int num = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_4, string_0_1 + "Go to Watch...");
      if (this.method_215(gclass27_0, int_4, string_0_1, "fb://watch"))
        this.method_107(int_4, string_0_1, gclass27_0, int_5, int_6, bool_5, "0124", int_7, int_8, bool_6, int_9, int_10, list_18, bool_7, int_11, int_12);
    }
    catch
    {
      num = -1;
    }
    return num;
  }

  public int method_89(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    List<string> source = gclass22_0.method_2("txtTuKhoa");
    int int_5 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    int int_7 = gclass22_0.method_3("nudCountLikeFrom");
    int int_8 = gclass22_0.method_3("nudCountLikeTo");
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    int int_11 = gclass22_0.method_3("nudCountShareFrom");
    int int_12 = gclass22_0.method_3("nudCountShareTo");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_18 = gclass22_0.method_2("txtComment");
    int int_9 = gclass22_0.method_3("nudCountCommentFrom");
    int int_10 = gclass22_0.method_3("nudCountCommentTo");
    int num = 0;
    try
    {
      string string_0 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_4, string_0 + "Go to Watch...");
      if (this.method_215(gclass27_0, int_4, string_0, "fb://watch"))
      {
        this.method_184(int_4, string_0 + "Find Search Video...");
        if (gclass27_0.method_61(5, "//android.widget.Button[@content-desc=\"Search Videos\"]", ""))
        {
          string string_12 = source.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).FirstOrDefault<string>();
          if (!string.IsNullOrEmpty(string_12))
          {
            this.method_184(int_4, string_0 + "Find " + GClass35.smethod_0("Nhập dữ liệu..."));
            if (gclass27_0.method_61(5, "//android.widget.EditText", ""))
            {
              this.method_184(int_4, string_0 + GClass35.smethod_0("Nhập dữ liệu..."));
              gclass27_0.method_50("//android.widget.EditText", string_12);
              gclass27_0.SleepSeconds(1.0);
              this.method_184(int_4, string_0 + "Search...");
              gclass27_0.method_79(GClass27.GEnum10.const_66);
              gclass27_0.method_80(2.0, 3.0);
              this.method_108(int_4, string_0, gclass27_0, int_5, int_6, bool_5, int_7, int_8, bool_6, int_9, int_10, list_18, bool_7, int_11, int_12);
            }
          }
        }
      }
    }
    catch
    {
    }
    return num;
  }

  private int method_90(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int int_4_1 = gclass22_0.method_3("nudSoLuongFrom");
    int int_5_1 = gclass22_0.method_3("nudSoLuongTo");
    int int_4_2 = gclass22_0.method_3("nudDelayFrom");
    int int_5_2 = gclass22_0.method_3("nudDelayTo");
    bool flag = gclass22_0.method_4("ckbReadRandom", true);
    int num1 = 0;
    int num2 = gclass27_0.method_87(int_4_1, int_5_1);
    try
    {
      string str = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
label_2:
      this.method_184(int_4, str + "Go to Notify...");
      if (gclass27_0.method_111())
      {
        List<string> stringList = new List<string>();
        while (num1 < num2)
        {
          switch (this.method_32(gclass27_0, int_4, string_0))
          {
            case 0:
              this.method_184(int_4, str + string.Format("({0}/{1}), Check danh sách Notify...", (object) num1, (object) num2));
              if (stringList.Count == 0)
              {
                if (num1 > 0)
                {
                  if (!gclass27_0.method_78(int_5: 2))
                    gclass27_0.method_80(2.0, 3.0);
                  else
                    goto label_14;
                }
                stringList = gclass27_0.method_37(10, "", "//androidx.recyclerview.widget.RecyclerView[@resource-id='android:id/list']/child::*");
                if (stringList.Count != 0)
                  stringList.RemoveAt(0);
                else
                  goto label_14;
              }
              string string_11 = !flag ? stringList.FirstOrDefault<string>() : stringList.smethod_10();
              stringList.Remove(string_11);
              this.method_184(int_4, str + string.Format("({0}/{1}), Tap Notify...", (object) num1, (object) num2));
              gclass27_0.method_66(string_11);
              this.method_184(int_4, str + string.Format("({0}/{1}), Tap Notify, ", (object) num1, (object) num2) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(2, 4));
              ++num1;
              this.method_184(int_4, str + string.Format("({0}/{1}), Scroll...", (object) num1, (object) num2));
              gclass27_0.method_133(int_4_2, int_5_2);
              this.method_184(int_4, str + string.Format("({0}/{1}), ", (object) num1, (object) num2) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(1, 3));
              this.method_184(int_4, str + string.Format("({0}/{1}), Back...", (object) num1, (object) num2));
              gclass27_0.method_28();
              continue;
            case 1:
              goto label_2;
            default:
              goto label_14;
          }
        }
      }
    }
    catch
    {
    }
label_14:
    return num1;
  }

  private int method_91(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    string string_0_1 = this.method_191(int_4, "cUid");
    int minValue = gclass22_0.method_3("nudDelayFrom", 3);
    int num1 = gclass22_0.method_3("nudDelayTo", 5);
    try
    {
      this.method_184(int_4, string_0 + "Get Job...");
      int num2 = 0;
      int num3 = 0;
      List<GClass32> gclass32List = GClass31.smethod_0(string_0_1);
      for (int index = 0; index < gclass32List.Count; ++index)
      {
        GClass32 gclass32_0 = gclass32List[index];
        string string_0_2 = string_0 + string.Format("Đang làm {0}/{1} -> {2}: ", (object) (index + 1), (object) gclass32List.Count, (object) gclass32_0.String_1);
        Tuple<int, string> tuple = new Tuple<int, string>(0, "");
        string string1 = gclass32_0.String_1;
        // ISSUE: reference to a compiler-generated method
        switch (Class206.smethod_0(string1))
        {
          case 119173917:
            if (string1 == "like_post")
            {
              tuple = this.method_34(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 1466588889:
            if (string1 == "view_reel")
            {
              tuple = this.method_36(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 1533824880:
            if (string1 == "follow")
            {
              tuple = this.method_40(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 1738982494:
            if (string1 == "comment")
            {
              tuple = this.method_38(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 2458671617:
            if (string1 == "review_page")
            {
              tuple = this.method_43(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 2848586808:
            if (string1 == "share")
            {
              tuple = this.method_39(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 3685020920:
            if (string1 == "view")
            {
              tuple = this.method_35(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 3717946706:
            if (string1 == "view_story")
            {
              tuple = this.method_37(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 3777140709:
            if (string1 == "join_group")
            {
              tuple = this.method_42(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
          case 3983124032:
            if (string1 == "like_page")
            {
              tuple = this.method_41(int_4, string_0_2, gclass27_0, gclass32_0);
              break;
            }
            break;
        }
        if (tuple.Item1 == 0)
        {
          ++num3;
          this.method_44(gclass32_0, tuple.Item2, gclass27_0);
        }
        else if (tuple.Item1 == 1)
          ++num2;
        GClass31.smethod_1(string_0_1, gclass32_0, tuple.Item1 == 1, tuple.Item2);
        if (index + 1 != gclass32List.Count)
        {
          this.method_184(int_4, string_0_2 + "Làm Job tiếp sau {time}s...", Class54.random_0.Next(minValue, num1 + 1));
          int num4 = this.method_32(gclass27_0, int_4, string_0);
          if (num4 != 0 && num4 != 1)
            break;
        }
        else
          break;
      }
    }
    catch
    {
    }
    return 0;
  }

  private int method_92(
    GClass18 gclass18_0,
    string string_0,
    string string_1,
    string string_2,
    bool bool_5 = false)
  {
    int num = 0;
    GClass20.smethod_44(gclass18_0, bool_5);
    switch (gclass18_0.GEnum11_0)
    {
      case GEnum11.const_1:
        num = -2;
        break;
      case GEnum11.const_2:
      case GEnum11.const_3:
        num = GClass20.smethod_31(gclass18_0, string_0, string_1, string_2, "https://m.facebook.com/", 2) == "1" ? 1 : 2;
        break;
      case GEnum11.const_4:
        num = -1;
        break;
      case GEnum11.const_6:
        num = -3;
        break;
    }
    return num;
  }

  public int method_93(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int int_4_1 = gclass22_0.method_3("nudSoLuongFrom");
    int int_5 = gclass22_0.method_3("nudSoLuongTo");
    bool flag1 = gclass22_0.method_4("ckbInteract");
    string str1 = gclass22_0.method_1("typeReaction");
    bool flag2 = gclass22_0.method_4("ckbComment");
    List<string> list_0 = gclass22_0.method_2("txtComment");
    int num1 = gclass27_0.method_87(int_4_1, int_5);
    try
    {
      string str2 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
label_22:
label_2:
      this.method_184(int_4, str2 + "Go to Home...");
      gclass27_0.method_107();
      gclass27_0.method_80(2.0, 3.0);
      switch (this.method_32(gclass27_0, int_4, string_0))
      {
        case 0:
          this.method_184(int_4, str2 + "Find Story...");
          int tickCount1 = Environment.TickCount;
          int num2 = 10;
          do
          {
            string str3 = gclass27_0.method_53();
            string string_11_1 = gclass27_0.method_29(0, str3, new List<string>()
            {
              "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]",
              "//*[contains(@content-desc,\"'s story\")]"
            });
            switch (string_11_1)
            {
              case "//*[contains(@content-desc,\"'s story\")]":
                gclass27_0.method_60(string_11_1, str3);
                int tickCount2 = Environment.TickCount;
                while (Environment.TickCount - tickCount2 < num1 * 1000)
                {
                  switch (this.method_32(gclass27_0, int_4, string_0))
                  {
                    case 0:
                      this.method_184(int_4, str2 + "Xem Story, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(4, 8));
                      string string_11_2 = gclass27_0.method_53();
                      string string_11_3 = gclass27_0.method_37(0, string_11_2, "//android.view.ViewGroup[@content-desc=\" See Video \"]").FirstOrDefault<string>();
                      if (!string.IsNullOrEmpty(string_11_3))
                      {
                        this.method_184(int_4, str2 + "Tap See Video...");
                        gclass27_0.method_66(string_11_3);
                      }
                      if (flag2)
                      {
                        this.method_184(int_4, str2 + "Find Reply to...");
                        string string_11_4 = gclass27_0.method_40(0, string_11_2, new List<string>()
                        {
                          "//*[contains(@content-desc,\"Reply to\")]",
                          "//*[contains(@content-desc,'comment on the story')]"
                        }).LastOrDefault<string>();
                        if (!string.IsNullOrEmpty(string_11_4))
                        {
                          string string_12 = GClass19.smethod_28(list_0.smethod_10(), this.random_0);
                          this.method_184(int_4, str2 + "Tap Reply to...");
                          gclass27_0.method_66(string_11_4);
                          gclass27_0.SleepSeconds(1.0);
                          this.method_184(int_4, str2 + GClass35.smethod_0("Nhập dữ liệu..."));
                          gclass27_0.method_50("//android.widget.EditText", string_12);
                          this.method_184(int_4, str2 + "Tap Send...");
                          gclass27_0.method_61(1, "//*[@content-desc=\"SEND\"]", "");
                          gclass27_0.method_80(1.0, 1.5);
                          if (gclass27_0.method_31(0, "", "//android.widget.EditText"))
                            gclass27_0.method_28(2);
                        }
                      }
                      this.method_184(int_4, str2 + "Find Like...");
                      string string_11_5 = gclass27_0.method_37(0, "", "//*[contains(@content-desc, \"Like\")]").FirstOrDefault<string>();
                      if (!string.IsNullOrEmpty(string_11_5))
                      {
                        Point point1 = gclass27_0.method_74(string_11_5);
                        Point point2 = gclass27_0.method_74("[35," + string_11_5.Split(new string[3]
                        {
                          "[",
                          ",",
                          "]"
                        }, StringSplitOptions.RemoveEmptyEntries)[1] + "][65," + string_11_5.Split(new string[3]
                        {
                          "[",
                          ",",
                          "]"
                        }, StringSplitOptions.RemoveEmptyEntries)[3] + "]");
                        if (flag1)
                        {
                          this.method_184(int_4, str2 + "Tap Rection...");
                          gclass27_0.method_73(point1.X, point1.Y, point2.X, point2.Y);
                          gclass27_0.method_80(1.0, 1.5);
                          gclass27_0.method_113((Convert.ToInt32(str1[gclass27_0.method_87(0, str1.Length - 1)].ToString()) + 1).ToString());
                          gclass27_0.method_80(1.0, 1.5);
                          gclass27_0.method_73(point2.X, point2.Y, point1.X, point1.Y);
                          gclass27_0.method_80(1.0, 1.5);
                        }
                        gclass27_0.method_73(point1.X, point1.Y / 2, point2.X, point2.Y / 2);
                        continue;
                      }
                      continue;
                    case 1:
                      goto label_2;
                    default:
                      goto label_24;
                  }
                }
                goto label_24;
              case "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]":
                gclass27_0.method_60(string_11_1, str3);
                break;
            }
          }
          while (Environment.TickCount - tickCount1 < num2 * 1000);
          break;
        case 1:
          goto label_22;
      }
    }
    catch
    {
    }
label_24:
    return num1;
  }

  public int method_94(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    string string_1_1 = gclass22_0.method_1("txtLinkVideo");
    int int_5 = gclass22_0.method_3("nudSoLuongFrom");
    int int_6 = gclass22_0.method_3("nudSoLuongTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    string string_2 = gclass22_0.method_1("typeReaction");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_18 = gclass22_0.method_2("txtComment");
    bool bool_7 = gclass22_0.method_4("ckbBinhLuanNhieuLan");
    int int_7 = gclass22_0.method_3("nudBinhLuanNhieuLanDelayFrom");
    int int_8 = gclass22_0.method_3("nudBinhLuanNhieuLanDelayTo");
    string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
    this.method_95(int_4, string_0_1, gclass27_0, string_1_1, int_5, int_6, bool_5, string_2, bool_6, list_18, bool_7, int_7, int_8);
    this.method_184(int_4, string_0_1 + GClass35.smethod_0("Xem video xong!"));
    return 0;
  }

  public int method_95(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    string string_1,
    int int_5,
    int int_6,
    bool bool_5,
    string string_2,
    bool bool_6,
    List<string> list_18,
    bool bool_7,
    int int_7,
    int int_8)
  {
    try
    {
      int int_5_1 = 0;
      int int_6_1 = 0;
      int int_7_1 = 0;
      int num1 = 1;
      list_18 = GClass19.smethod_39(list_18);
      List<string> list_19 = GClass19.smethod_27(list_18);
      int num2 = 1;
      if (bool_7)
        num2 = 100;
      int num3 = gclass27_0.method_87(int_5, int_6);
      if (this.method_75(gclass27_0, int_4, string_0, string_1) == 1)
      {
        int tickCount = Environment.TickCount;
        this.method_184(int_4, string_0 + GClass35.smethod_0("Đang xem video") + "...");
        while (Environment.TickCount - tickCount < num3 * 1000)
        {
          this.method_109(int_4, string_0, gclass27_0, bool_5 && int_5_1 < num1, string_2, ref int_5_1, bool_6 && int_6_1 < num2, ref int_6_1, list_18, ref list_19, false, ref int_7_1);
          if (bool_6 && int_6_1 < num2)
          {
            this.method_184(int_4, string_0 + GClass35.smethod_0("Đang xem video") + ", " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(int_7, int_8 + 1));
          }
          else
          {
            int num4 = (Environment.TickCount - tickCount) / 1000;
            this.method_184(int_4, string_0 + GClass35.smethod_0("Đang xem video") + ", còn " + (num3 - num4).ToString() + "s...");
            gclass27_0.SleepSeconds(1.0);
          }
        }
      }
    }
    catch
    {
    }
    return 0;
  }

  public int method_96(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom");
    int num1 = gclass22_0.method_3("nudSoLuongTo");
    int minValue2 = gclass22_0.method_3("nudDelayFrom");
    int num2 = gclass22_0.method_3("nudDelayTo");
    int num3 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num4 = this.random_0.Next(minValue1, num1 + 1);
      if (num4 != 0)
      {
label_19:
label_2:
        this.method_184(int_4, string_0_1 + "Go to Friend Accept...");
        if (this.method_215(gclass27_0, int_4, string_0_1, "fb://requests"))
        {
          this.method_184(int_4, string_0_1 + "Tap See All...");
          gclass27_0.method_61(3, "//android.view.ViewGroup[@content-desc=\"See All\"]", "");
          switch (this.method_32(gclass27_0, int_4, string_0))
          {
            case 0:
              this.method_184(int_4, string_0_1 + "Find Confirm...");
              List<string> list_0 = gclass27_0.method_37(10, "", "//android.view.ViewGroup[starts-with(@content-desc, \"Confirm\")]");
              int int_4_1 = int_4;
              string str1 = string_0_1;
              int count = list_0.Count;
              string str2 = count.ToString();
              string string_0_2 = str1 + "Find Confirm: " + str2;
              this.method_184(int_4_1, string_0_2);
              if (list_0.Count != 0)
              {
                for (int index = 0; index < num4 + 10; ++index)
                {
                  switch (this.method_32(gclass27_0, int_4, string_0))
                  {
                    case 0:
                      string string_11 = list_0.smethod_10();
                      if (string_11 != "" && gclass27_0.method_66(string_11))
                      {
                        ++num3;
                        string str3 = gclass27_0.method_53();
                        if (gclass27_0.method_31(0, str3, "//android.widget.TextView[@text='Unable to Add This Friend']") || str3.ToLower().Contains("has reached the 5,000 friend limit and can't add any more friends."))
                        {
                          gclass27_0.method_61(0, "//android.widget.TextView[@text='OK']", str3);
                          --num3;
                        }
                      }
                      if (num3 < num4)
                      {
                        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num3, (object) num4) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Confirm...", (object) num3, (object) num4));
                        list_0 = gclass27_0.method_37(10, "", "//*[starts-with(@content-desc, \"Confirm\")]");
                        int int_4_2 = int_4;
                        string str4 = string_0_1;
                        string str5 = string.Format("({0}/{1}), Find Confirm: ", (object) num3, (object) num4);
                        count = list_0.Count;
                        string str6 = count.ToString();
                        string string_0_3 = str4 + str5 + str6;
                        this.method_184(int_4_2, string_0_3);
                        if (list_0.Count == 0)
                        {
                          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) num3, (object) num4));
                          if (!gclass27_0.method_78())
                          {
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Confirm...", (object) num3, (object) num4));
                            list_0 = gclass27_0.method_37(10, "", "//*[starts-with(@content-desc, \"Confirm\")]");
                            int int_4_3 = int_4;
                            string str7 = string_0_1;
                            string str8 = string.Format("({0}/{1}), Find Confirm: ", (object) num3, (object) num4);
                            count = list_0.Count;
                            string str9 = count.ToString();
                            string string_0_4 = str7 + str8 + str9;
                            this.method_184(int_4_3, string_0_4);
                            if (list_0.Count == 0)
                              goto label_21;
                            else
                              continue;
                          }
                          else
                          {
                            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Can't Scroll!", (object) num3, (object) num4));
                            goto label_21;
                          }
                        }
                        else
                          continue;
                      }
                      else
                      {
                        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Done!", (object) num3, (object) num4));
                        goto label_21;
                      }
                    case 1:
                      goto label_2;
                    default:
                      goto label_21;
                  }
                }
                break;
              }
              break;
            case 1:
              goto label_19;
          }
        }
      }
    }
    catch
    {
      num3 = -1;
    }
label_21:
    return num3;
  }

  public int method_97(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    List<string> list_0_1 = gclass22_0.method_2("txtTuKhoa");
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom");
    int num1 = gclass22_0.method_3("nudSoLuongTo");
    int minValue2 = gclass22_0.method_3("nudDelayFrom");
    int num2 = gclass22_0.method_3("nudDelayTo");
    int minValue3 = gclass22_0.method_3("nudSoLuongKetBanMoiTuKhoaFrom", 1);
    int num3 = gclass22_0.method_3("nudSoLuongKetBanMoiTuKhoaTo", 2);
    int num4 = 0;
    try
    {
      string str1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num5 = this.random_0.Next(minValue1, num1 + 1);
      if (num5 != 0)
      {
        List<string> list_0_2 = GClass19.smethod_39(list_0_1);
        while (list_0_2.Count > 0)
        {
          string string_0_1 = list_0_2.smethod_10();
          list_0_2.Remove(string_0_1);
          string string_11_1 = GClass19.smethod_28(string_0_1, this.random_0);
          int num6 = 0;
          int num7 = Class54.random_0.Next(minValue3, num3 + 1);
label_22:
label_4:
          this.method_184(int_4, str1 + "Search People...");
          if (gclass27_0.method_108(string_11_1, "People"))
          {
            switch (this.method_32(gclass27_0, int_4, string_0))
            {
              case 0:
                this.method_184(int_4, str1 + "Find Add Friend...");
                List<string> list_0_3 = gclass27_0.method_40(5, "", new List<string>()
                {
                  "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/child::*[2]",
                  "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/child::*[3]",
                  "//android.view.ViewGroup[@content-desc=\"Add Friend\"]"
                });
                List<string> list_0_4 = gclass27_0.method_172(list_0_3);
                int int_4_1 = int_4;
                string str2 = str1;
                int count = list_0_4.Count;
                string str3 = count.ToString();
                string string_0_2 = str2 + "Search People: " + str3;
                this.method_184(int_4_1, string_0_2);
                for (int index1 = 0; index1 < num7 + 10; ++index1)
                {
                  switch (this.method_32(gclass27_0, int_4, string_0))
                  {
                    case 0:
                      if (list_0_4.Count == 0)
                      {
                        for (int index2 = 0; index2 < 5; ++index2)
                        {
                          this.method_184(int_4, str1 + string.Format("({0}/{1}), Scroll...", (object) num4, (object) num5));
                          if (!gclass27_0.method_78(int_5: 2))
                          {
                            this.method_184(int_4, str1 + string.Format("({0}/{1}), Find Add Friend...", (object) num4, (object) num5));
                            List<string> list_0_5 = gclass27_0.method_40(5, "", new List<string>()
                            {
                              "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/child::*[2]",
                              "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/child::*[3]",
                              "//android.view.ViewGroup[@content-desc=\"Add Friend\"]"
                            });
                            list_0_4 = gclass27_0.method_172(list_0_5);
                            int int_4_2 = int_4;
                            string str4 = str1;
                            string str5 = string.Format("({0}/{1}), Find Add Friend: ", (object) num4, (object) num5);
                            count = list_0_4.Count;
                            string str6 = count.ToString();
                            string string_0_3 = str4 + str5 + str6;
                            this.method_184(int_4_2, string_0_3);
                            if (list_0_4.Count > 0)
                              break;
                          }
                          else
                            break;
                        }
                        if (list_0_4.Count == 0)
                          goto label_23;
                      }
                      string string_11_2 = list_0_4.smethod_10();
                      list_0_4.Remove(string_11_2);
                      if (string_11_2 != "")
                      {
                        this.method_184(int_4, str1 + string.Format("({0}/{1}), Tap Friend...", (object) num4, (object) num5));
                        if (gclass27_0.method_66(string_11_2))
                        {
                          ++num4;
                          if (num4 < num5)
                          {
                            ++num6;
                            if (num6 < num7)
                            {
                              this.method_184(int_4, str1 + string.Format("({0}/{1}), ", (object) num4, (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                              continue;
                            }
                            goto label_23;
                          }
                          else
                            goto label_27;
                        }
                        else
                          continue;
                      }
                      else
                        continue;
                    case 1:
                      goto label_4;
                    default:
                      goto label_27;
                  }
                }
label_23:
                continue;
              case 1:
                goto label_22;
              default:
                goto label_27;
            }
          }
          else
            break;
        }
      }
    }
    catch
    {
      num4 = -1;
    }
label_27:
    return num4;
  }

  public int method_98(
    ref int int_4,
    int int_5,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int minValue1 = gclass22_0.method_3("nudSoLuongFrom");
    int num1 = gclass22_0.method_3("nudSoLuongTo");
    int minValue2 = gclass22_0.method_3("nudDelayFrom");
    int num2 = gclass22_0.method_3("nudDelayTo");
    int num3 = 0;
    try
    {
      int num4 = this.random_0.Next(minValue1, num1 + 1);
      if (num4 != 0)
      {
        string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
label_3:
        this.method_184(int_5, string_0_1 + "Goto Friend Suggest...");
        int num5 = 0;
        if (!gclass27_0.method_109())
        {
          num5 = 1;
          if (!this.method_215(gclass27_0, int_5, string_0_1, "fb://faceweb/f?href=https://m.facebook.com/friends/center/suggestions/"))
            goto label_28;
        }
        this.method_184(int_5, string_0_1 + "Find Add Friend...");
        string string_12 = "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]";
        string string_11_1 = "";
        if (num5 == 1)
        {
          int tickCount = Environment.TickCount;
          do
          {
            string_11_1 = "";
            string str = gclass27_0.method_30(0, ref string_11_1, new List<string>()
            {
              "//*[@text='No Suggestions Available']",
              string_12,
              "//*[@text='Tap to retry']"
            });
            if (!(str == string_12))
            {
              switch (str)
              {
                case "//*[@text='No Suggestions Available']":
                  goto label_10;
                case "//*[@text='Tap to retry']":
                  gclass27_0.method_60("//*[@text='Tap to retry']", string_11_1);
                  gclass27_0.SleepSeconds(5.0);
                  break;
              }
            }
            else
              break;
          }
          while (Environment.TickCount - tickCount <= 30000);
          goto label_12;
label_10:
          int_4 = 2;
          goto label_30;
label_12:;
        }
        List<string> list_0 = gclass27_0.method_37(10, string_11_1, string_12);
        this.method_184(int_5, string_0_1 + "Find Add Friend: " + list_0.Count.ToString());
        if (list_0.Count != 0)
        {
          int_4 = 1;
          for (int index = 0; index < num4 + 10; ++index)
          {
            switch (this.method_32(gclass27_0, int_5, string_0))
            {
              case 0:
                string string_0_2 = list_0.smethod_10();
                this.method_184(int_5, string_0_1 + string.Format("({0}/{1}), Tap Add Friend...", (object) num3, (object) num4));
                if (string_0_2 != "" && gclass27_0.method_54(new Class77(string_0_2).method_1()))
                  ++num3;
                if (num3 < num4)
                {
                  this.method_184(int_5, string_0_1 + string.Format("({0}/{1}), ", (object) num3, (object) num4) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue2, num2 + 1));
                  string string_11_2 = gclass27_0.method_40(0, "", new List<string>()
                  {
                    "//*[@content-desc='ok' or @text='ok']",
                    "//*[@content-desc='Cancel' or @text='Cancel']"
                  }).FirstOrDefault<string>();
                  if (!string.IsNullOrEmpty(string_11_2))
                    gclass27_0.method_66(string_11_2);
                  this.method_184(int_5, string_0_1 + string.Format("({0}/{1}), Find Add Friend...", (object) num3, (object) num4));
                  list_0 = gclass27_0.method_37(10, "", string_12);
                  this.method_184(int_5, string_0_1 + string.Format("({0}/{1}), Find Add Friend: ", (object) num3, (object) num4) + list_0.Count.ToString());
                  if (list_0.Count == 0)
                  {
                    this.method_184(int_5, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) num3, (object) num4));
                    if (!gclass27_0.method_78())
                    {
                      this.method_184(int_5, string_0_1 + string.Format("({0}/{1}), Find Add Friend...", (object) num3, (object) num4));
                      list_0 = gclass27_0.method_37(10, "", string_12);
                      this.method_184(int_5, string_0_1 + string.Format("({0}/{1}), Find Add Friend: ", (object) num3, (object) num4) + list_0.Count.ToString());
                      if (list_0.Count == 0)
                        goto label_30;
                      else
                        continue;
                    }
                    else
                    {
                      this.method_184(int_5, string_0_1 + string.Format("({0}/{1}), Can't Scroll...", (object) num3, (object) num4));
                      goto label_30;
                    }
                  }
                  else
                    continue;
                }
                else
                {
                  this.method_184(int_5, string_0_1 + string.Format("({0}/{1}): Done!", (object) num3, (object) num4));
                  goto label_30;
                }
              case 1:
                goto label_3;
              default:
                goto label_30;
            }
          }
        }
label_28:;
      }
    }
    catch
    {
      num3 = -1;
    }
label_30:
    return num3;
  }

  public List<string> method_99(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    int int_4)
  {
    List<string> stringList = new List<string>();
    try
    {
      foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(new GClass24(string_2, string_0, string_3, int_4).method_0("https://graph.facebook.com/v3.0/me/groups?access_token=" + string_1 + "&limit=5000&fields=id,name").ToString())["data"])
        stringList.Add(jtoken[(object) "id"].ToString());
    }
    catch
    {
    }
    return stringList;
  }

  public List<string> method_100(string string_0, string string_1, string string_2, int int_4)
  {
    List<string> stringList = new List<string>();
    try
    {
      GClass24 gclass24 = new GClass24(string_0, string_1, string_2, int_4);
      string propertyName = Regex.Match(string_0, "c_user=(.*?);").Groups[1].Value;
      string str = Regex.Match(gclass24.method_0("https://m.facebook.com/help"), "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
      JObject jobject = JObject.Parse(gclass24.method_1("https://www.facebook.com/api/graphql", "q=me(){friends}&fb_dtsg=" + str));
      int num = jobject[propertyName][(object) "friends"][(object) "nodes"].Count<JToken>();
      for (int key = 0; key < num; ++key)
        stringList.Add(jobject[propertyName][(object) "friends"][(object) "nodes"][(object) key][(object) "id"].ToString());
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  public List<string> method_101(List<string> list_18)
  {
    List<string> stringList = new List<string>();
    try
    {
      for (int index = 0; index < list_18.Count; ++index)
        stringList.Add(list_18[index]);
    }
    catch
    {
    }
    return stringList;
  }

  private void method_102(int int_4 = 0) => GClass19.smethod_64((double) this.random_0.Next(int_4 + 1, int_4 + 4));

  private void method_103(string string_0)
  {
    this.plTrangThai.Invoke((Delegate) (() =>
    {
      if (this.plTrangThai.Visible)
        return;
      this.plTrangThai.Visible = true;
    }));
    this.lblTrangThai.Invoke((Delegate) (() => this.lblTrangThai.Text = string_0));
    Application.DoEvents();
  }

  private void method_104()
  {
    try
    {
      this.plTrangThai.Invoke((Delegate) (() =>
      {
        if (!this.plTrangThai.Visible)
          return;
        this.plTrangThai.Visible = false;
      }));
    }
    catch
    {
    }
  }

  public int method_105(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int int_5 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    int int_7 = gclass22_0.method_3("nudCountLikeFrom", 1);
    int int_8 = gclass22_0.method_3("nudCountLikeTo", 3);
    bool bool_6 = gclass22_0.method_4("ckbComment");
    int int_9 = gclass22_0.method_3("nudCountCommentFrom", 1);
    int int_10 = gclass22_0.method_3("nudCountCommentTo", 3);
    List<string> list_18 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    int int_11 = gclass22_0.method_3("nudCountShareFrom", 1);
    int int_12 = gclass22_0.method_3("nudCountShareTo", 3);
    int num = 0;
    try
    {
      gclass27_0.method_107();
      gclass27_0.method_80(1.0, 2.0);
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_107(int_4, string_0_1, gclass27_0, int_5, int_6, bool_5, "0124", int_7, int_8, bool_6, int_9, int_10, list_18, bool_7, int_11, int_12);
    }
    catch (Exception ex)
    {
      num = -1;
    }
    return num;
  }

  public int method_106(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int int_5 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    int int_7 = gclass22_0.method_3("nudCountLikeFrom", 1);
    int int_8 = gclass22_0.method_3("nudCountLikeTo", 3);
    bool bool_6 = gclass22_0.method_4("ckbComment");
    int int_9 = gclass22_0.method_3("nudCountCommentFrom", 1);
    int int_10 = gclass22_0.method_3("nudCountCommentTo", 3);
    List<string> list_18 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    int int_11 = gclass22_0.method_3("nudCountShareFrom", 1);
    int int_12 = gclass22_0.method_3("nudCountShareTo", 3);
    int num = 0;
    try
    {
      gclass27_0.method_105("fb://profile");
      gclass27_0.method_80(1.0, 2.0);
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_107(int_4, string_0_1, gclass27_0, int_5, int_6, bool_5, "0124", int_7, int_8, bool_6, int_9, int_10, list_18, bool_7, int_11, int_12);
    }
    catch (Exception ex)
    {
      num = -1;
    }
    return num;
  }

  public int method_107(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    int int_5,
    int int_6,
    bool bool_5,
    string string_1,
    int int_7,
    int int_8,
    bool bool_6,
    int int_9,
    int int_10,
    List<string> list_18,
    bool bool_7,
    int int_11,
    int int_12,
    int int_13 = 0,
    bool bool_8 = false,
    string string_2 = "",
    int int_14 = -1,
    int int_15 = -1)
  {
    if (int_13 == 0)
    {
      int int_5_1 = 0;
      int int_6_1 = 0;
      int int_7_1 = 0;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (bool_5)
        num1 = gclass27_0.method_87(int_7, int_8);
      list_18 = GClass19.smethod_39(list_18);
      List<string> list_19 = GClass19.smethod_27(list_18);
      if (bool_6)
        num2 = gclass27_0.method_87(int_9, int_10);
      if (bool_7)
        num3 = gclass27_0.method_87(int_11, int_12);
      int num4 = gclass27_0.method_87(int_5, int_6);
      int tickCount = Environment.TickCount;
      while (Environment.TickCount - tickCount < num4 * 1000)
      {
        switch (this.method_32(gclass27_0, int_4, string_0))
        {
          case 0:
            this.method_184(int_4, string_0 + "Scroll...");
            if (gclass27_0.method_78(int_5: 2) && !gclass27_0.method_104())
            {
              if (gclass27_0.method_31(0, "", "//android.view.ViewGroup[@content-desc='Try it']"))
                gclass27_0.method_28();
              else
                goto label_32;
            }
            this.method_110(int_4, string_0, gclass27_0, bool_5 && int_5_1 < num1, string_1, ref int_5_1, bool_6 && int_6_1 < num2, ref int_6_1, list_18, ref list_19, bool_7 && int_7_1 < num3, ref int_7_1);
            this.method_184(int_4, string_0 + "Delay {time}s...", Class54.random_0.Next(2, 4));
            continue;
          case 1:
            continue;
          default:
            goto label_32;
        }
      }
    }
    else
    {
      int num5 = gclass27_0.method_87(int_5, int_6);
      int int_5_2 = 0;
      int int_6_2 = 0;
      int int_7_2 = 0;
      int num6 = 0;
      int num7 = 0;
      int num8 = 0;
      if (bool_5)
        num6 = num5;
      list_18 = GClass19.smethod_39(list_18);
      List<string> list_19 = GClass19.smethod_27(list_18);
      if (bool_6)
        num7 = num5;
      if (bool_7)
        num8 = num5;
      int num9 = 1;
      for (int index = 0; index < num5 + 5; ++index)
      {
        int num10 = this.method_32(gclass27_0, int_4, string_0);
        if (num10 == 1)
          gclass27_0.method_107();
        else if (num10 != 0)
          break;
        if (!gclass27_0.method_78(int_5: 2) || gclass27_0.method_104())
        {
          this.method_110(int_4, string_0 + string.Format("({0}/{1}) ", (object) num9, (object) num5), gclass27_0, bool_5 && int_5_2 < num6, string_1, ref int_5_2, bool_6 && int_6_2 < num7, ref int_6_2, list_18, ref list_19, bool_7 && int_7_2 < num8, ref int_7_2, int_13, bool_8, string_2);
          if (int_5_2 < num5 && int_6_2 < num5 && int_7_2 < num5)
          {
            num9 = new List<int>()
            {
              int_5_2,
              int_6_2,
              int_7_2
            }.OrderBy<int, int>((System.Func<int, int>) (int_0 => int_0)).Last<int>() + 1;
            if (int_14 > -1 && int_15 > -1)
              this.method_184(int_4, string_0 + string.Format("({0}/{1}), delay {{time}}s...", (object) num9, (object) num5), gclass27_0.method_87(int_14, int_15));
            else
              gclass27_0.method_80(1.5, 3.0);
          }
          else
            break;
        }
        else
          break;
      }
    }
label_32:
    return 0;
  }

  public int method_108(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    int int_5,
    int int_6,
    bool bool_5,
    int int_7,
    int int_8,
    bool bool_6,
    int int_9,
    int int_10,
    List<string> list_18,
    bool bool_7,
    int int_11,
    int int_12)
  {
    int int_5_1 = 0;
    int int_6_1 = 0;
    int int_7_1 = 0;
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    if (bool_5)
      num1 = gclass27_0.method_87(int_7, int_8);
    list_18 = GClass19.smethod_39(list_18);
    List<string> list_19 = GClass19.smethod_27(list_18);
    if (bool_6)
      num2 = gclass27_0.method_87(int_9, int_10);
    if (bool_7)
      num3 = gclass27_0.method_87(int_11, int_12);
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = new List<string>();
    List<string> stringList3 = new List<string>();
    int num4 = gclass27_0.method_87(int_5, int_6);
    int tickCount = Environment.TickCount;
    while (Environment.TickCount - tickCount < num4 * 1000)
    {
      int num5 = this.method_32(gclass27_0, int_4, string_0);
      if (num5 != 1 && num5 == 0)
      {
        this.method_184(int_4, string_0 + "Scroll...");
        if (!gclass27_0.method_78(int_5: 2) || gclass27_0.method_104())
        {
          this.method_184(int_4, string_0 + "Delay {time}s...", Class54.random_0.Next(3, 6));
          if (bool_5 | bool_6 | bool_7)
          {
            this.method_184(int_4, string_0 + "Tap Video...");
            if (gclass27_0.method_60("//android.view.ViewGroup[@content-desc=\"Video\"]"))
            {
              if (!gclass27_0.method_31(3, "", "//android.view.ViewGroup[@content-desc=\"More options\"]"))
              {
                this.method_109(int_4, string_0, gclass27_0, bool_5 && int_5_1 < num1, "", ref int_5_1, bool_6 && int_6_1 < num2, ref int_6_1, list_18, ref list_19, bool_7 && int_7_1 < num3, ref int_7_1);
              }
              else
              {
                gclass27_0.method_76();
                this.method_110(int_4, string_0, gclass27_0, bool_5 && int_5_1 < num1, "0124", ref int_5_1, bool_6 && int_6_1 < num2, ref int_6_1, list_18, ref list_19, bool_7 && int_7_1 < num3, ref int_7_1);
              }
              gclass27_0.method_28();
            }
          }
        }
        else
          break;
      }
      else
        break;
    }
    return 0;
  }

  public int method_109(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    bool bool_5,
    string string_1,
    ref int int_5,
    bool bool_6,
    ref int int_6,
    List<string> list_18,
    ref List<string> list_19,
    bool bool_7,
    ref int int_7)
  {
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = new List<string>();
    List<string> stringList3 = new List<string>();
    if (bool_5)
    {
      this.method_184(int_4, string_0 + "Find Like...");
      string string_11_1 = gclass27_0.method_37(0, "", "//*[contains(@content-desc, \"Like\")]").FirstOrDefault<string>();
      if (!string.IsNullOrEmpty(string_11_1))
      {
        Point point1 = gclass27_0.method_74(string_11_1);
        Point point2 = gclass27_0.method_74("[35," + string_11_1.Split(new string[3]
        {
          "[",
          ",",
          "]"
        }, StringSplitOptions.RemoveEmptyEntries)[1] + "][65," + string_11_1.Split(new string[3]
        {
          "[",
          ",",
          "]"
        }, StringSplitOptions.RemoveEmptyEntries)[3] + "]");
        this.method_184(int_4, string_0 + "Tap Reaction...");
        gclass27_0.method_73(point1.X, point1.Y, point2.X, point2.Y);
        gclass27_0.method_80(1.0, 1.5);
        string string_11_2 = "";
        if (string_1 != "")
          string_11_2 = (Convert.ToInt32(string_1[gclass27_0.method_87(0, string_1.Length - 1)].ToString()) + 1).ToString();
        gclass27_0.method_113(string_11_2);
        gclass27_0.method_80(1.0, 1.5);
        gclass27_0.method_73(point2.X, point2.Y, point1.X, point1.Y);
        gclass27_0.method_80(1.0, 1.5);
        ++int_5;
      }
    }
    if (bool_6)
    {
      this.method_184(int_4, string_0 + "Find Comment...");
      string string_11 = gclass27_0.method_53();
      List<string> source = gclass27_0.method_40(0, string_11, new List<string>()
      {
        "//*[@text=\"Write a comment…\"]"
      });
      if (source.Count > 0)
      {
        Point point = gclass27_0.method_74(source.Last<string>());
        if (list_19.Count == 0)
          list_19 = GClass19.smethod_27(list_18);
        string string_0_1 = list_19[gclass27_0.method_87(0, list_19.Count - 1)];
        list_19.Remove(string_0_1);
        string string_12 = GClass19.smethod_28(string_0_1, this.random_0);
        this.method_184(int_4, string_0 + "Tap Comment...");
        if (gclass27_0.method_55(point.X, point.Y))
        {
          gclass27_0.method_80(1.0, 2.0);
          this.method_184(int_4, string_0 + "Find EditText...");
          if (gclass27_0.method_31(5, "", "//android.widget.EditText"))
          {
            this.method_184(int_4, string_0 + GClass35.smethod_0("Nhập dữ liệu..."));
            gclass27_0.method_50("//android.widget.EditText", string_12);
            gclass27_0.method_80(1.0, 2.0);
            this.method_184(int_4, string_0 + "Tap Send...");
            if (gclass27_0.method_60("//*[@content-desc=\"Send\"]"))
              this.method_184(int_4, string_0 + "Tap Send, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(3, 6));
            ++int_6;
          }
          else
          {
            this.method_184(int_4, string_0 + "Back...");
            gclass27_0.method_28();
            gclass27_0.method_80(1.0, 2.0);
          }
        }
      }
    }
    if (bool_7)
    {
      this.method_184(int_4, string_0 + "Find Share...");
      string string_11 = gclass27_0.method_53();
      List<string> source = gclass27_0.method_40(0, string_11, new List<string>()
      {
        "//*[@content-desc=\"SHARE\"]"
      });
      if (source.Count > 0)
      {
        Point point = gclass27_0.method_74(source.Last<string>());
        this.method_184(int_4, string_0 + "Tap Share...");
        if (gclass27_0.method_55(point.X, point.Y))
        {
          gclass27_0.method_80(1.5, 2.0);
          this.method_184(int_4, string_0 + "Find Post...");
          if (gclass27_0.method_61(5, "//android.widget.ImageButton[@content-desc=\"Write Post\"]", "") && gclass27_0.method_61(5, "//android.widget.Button[@text =\"POST\"]", ""))
          {
            this.method_184(int_4, string_0 + "Tap Post, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(12, 15));
            ++int_7;
          }
          else
          {
            this.method_184(int_4, string_0 + "Back...");
            gclass27_0.method_28(double_0: 0.3);
          }
        }
      }
    }
    return 0;
  }

  public int method_110(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    bool bool_5,
    string string_1,
    ref int int_5,
    bool bool_6,
    ref int int_6,
    List<string> list_18,
    ref List<string> list_19,
    bool bool_7,
    ref int int_7,
    int int_8 = 0,
    bool bool_8 = false,
    string string_2 = "")
  {
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = new List<string>();
    List<string> stringList3 = new List<string>();
    if (bool_5)
    {
      this.method_184(int_4, string_0_1 + "Find Like...");
      string string_11_1 = gclass27_0.method_53();
      List<string> source = gclass27_0.method_40(0, string_11_1, new List<string>()
      {
        "//*[@content-desc=\"Like button. Double tap and hold to react.\"]",
        "//*[@content-desc=\"Like Button\"]",
        "//*[@content-desc='Like']"
      });
      this.method_184(int_4, string_0_1 + "Find Like: " + source.Count.ToString());
      if (source.Count > 0 && (int_8 == 1 || gclass27_0.method_87(1, 100) % 3 == 0))
      {
        Point point = gclass27_0.method_74(source.First<string>());
        string string_11_2 = "";
        if (string_1 != "")
          string_11_2 = (Convert.ToInt32(string_1[gclass27_0.method_87(0, string_1.Length - 1)].ToString()) + 1).ToString();
        this.method_184(int_4, string_0_1 + "Tap Reaction...");
        if (gclass27_0.method_146(string_11_1, "Create a reel") && gclass27_0.method_55(point.X, point.Y) || gclass27_0.method_72(point.X, point.Y) && gclass27_0.method_113(string_11_2))
        {
          ++int_5;
          this.method_184(int_4, string_0_1 + "Reaction, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(1, 3));
        }
      }
    }
    if (bool_6 | bool_8)
    {
      this.method_184(int_4, string_0_1 + "Find Comment...");
      string string_11_3 = gclass27_0.method_53();
      List<string> source1 = gclass27_0.method_40(0, string_11_3, new List<string>()
      {
        "//*[@content-desc=\"Comment Button\"]",
        "//*[@content-desc=\"Answer Button\"]",
        "//*[@text='Answer']",
        "//*[@text='Write a public comment…']",
        "//*[@text='Write a comment…']",
        "//*[@text=\"Comment\"]",
        "//*[@content-desc=\"Comment\"]",
        "//android.widget.EditText[@resource-id='composerInput']"
      });
      this.method_184(int_4, string_0_1 + "Find Comment: " + source1.Count.ToString());
      if (source1.Count > 0 && (int_8 == 1 || gclass27_0.method_87(1, 100) % 3 == 0))
      {
        Point point = gclass27_0.method_74(source1.Last<string>());
        this.method_184(int_4, string_0_1 + "Tap Comment...");
        if (gclass27_0.method_55(point.X, point.Y))
        {
          gclass27_0.method_80(3.0, 5.0);
          int num;
          for (num = 0; num < 5; ++num)
          {
            this.method_184(int_4, string_0_1 + "Find EditText...");
            if (!gclass27_0.method_31(5, "", "//android.widget.EditText"))
            {
              if (!gclass27_0.method_60("//android.widget.LinearLayout[@content-desc=\"Comment input box\"]"))
                break;
            }
            else
            {
              if (bool_6)
              {
                if (list_19.Count == 0)
                  list_19 = GClass19.smethod_27(list_18);
                string string_0 = list_19[gclass27_0.method_87(0, list_19.Count - 1)];
                list_19.Remove(string_0);
                string string_12 = GClass19.smethod_28(string_0, this.random_0);
                this.method_184(int_4, string_0_1 + GClass35.smethod_0("Nhập dữ liệu..."));
                gclass27_0.method_50("//android.widget.EditText", string_12);
                gclass27_0.method_80(5.0, 8.0);
              }
              if (bool_8)
              {
                this.method_184(int_4, string_0_1 + "Push image...");
                if (this.method_77(gclass27_0, string_2))
                {
                  this.method_184(int_4, string_0_1 + "Find Camera...");
                  if (gclass27_0.method_61(5, "//android.view.ViewGroup[@content-desc='Show photos and videos']", ""))
                  {
                    this.method_184(int_4, string_0_1 + "Select image...");
                    for (int index = 0; index < 10; ++index)
                    {
                      string str = gclass27_0.method_53();
                      string string_11_4 = gclass27_0.method_29(0, str, new List<string>()
                      {
                        "//android.widget.Button[@text='Allow']",
                        "//android.widget.Button[@text='Enable gallery access']",
                        "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"
                      });
                      if (string_11_4 == "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']")
                      {
                        List<string> source2 = gclass27_0.method_37(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
                        if (source2.Count > 1)
                          source2 = source2.GetRange(0, source2.Count - 1);
                        if (source2.Count > 0)
                        {
                          string string_0 = source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>();
                          gclass27_0.method_54(new Class77(string_0).method_1());
                          break;
                        }
                      }
                      else if (string_11_4 != "")
                      {
                        this.method_184(int_4, string_0_1 + "Tap " + gclass27_0.method_151(string_11_4) + "...");
                        gclass27_0.method_60(string_11_4, str);
                      }
                      gclass27_0.SleepSeconds(1.0);
                    }
                    gclass27_0.SleepSeconds(3.0);
                    gclass27_0.method_28();
                  }
                }
              }
              this.method_184(int_4, string_0_1 + "Tap Send...");
              string string_11_5 = "";
              string string_11_6 = gclass27_0.method_30(5, ref string_11_5, new List<string>()
              {
                "//*[@content-desc=\"Send\"]",
                "//*[@text='Post']"
              });
              if (gclass27_0.method_60(string_11_6, string_11_5))
              {
                this.method_184(int_4, string_0_1 + "Tap Send, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(10, 15));
                gclass27_0.method_42(120);
              }
              ++int_6;
              break;
            }
          }
          this.method_184(int_4, string_0_1 + "Back...");
          if (num == 1 || gclass27_0.method_22() == "com.facebook.fbshorts.viewer.activity.FbShortsViewerActivity")
            gclass27_0.method_28();
          else
            gclass27_0.method_28(2, 0.3);
          gclass27_0.method_80(1.0, 2.0);
        }
      }
    }
    if (bool_7)
    {
      List<string> list_0 = new List<string>()
      {
        "//*[@content-desc=\"Share Button\"]",
        "//*[@text=\"Share\"]"
      };
      if (gclass27_0.method_22() == "com.facebook.fbshorts.viewer.activity.FbShortsViewerActivity")
        list_0.Add("//*[@content-desc=\"Share\"]");
      this.method_184(int_4, string_0_1 + "Find Share...");
      string string_11_7 = gclass27_0.method_53();
      List<string> source = gclass27_0.method_40(0, string_11_7, list_0);
      this.method_184(int_4, string_0_1 + "Find Share: " + source.Count.ToString());
      if (source.Count > 0 && (int_8 == 1 || gclass27_0.method_87(1, 100) % 3 == 0))
      {
        Point point = gclass27_0.method_74(source.Last<string>());
        this.method_184(int_4, string_0_1 + "Tap Share...");
        if (gclass27_0.method_55(point.X, point.Y))
        {
          gclass27_0.method_80(1.5, 2.0);
          this.method_184(int_4, string_0_1 + "Find Share Now...");
          string string_11_8 = "";
          if (gclass27_0.method_33(5, ref string_11_8, "//*[@content-desc=\"Share Now\"]"))
          {
            if (!gclass27_0.method_31(0, string_11_8, "//*[@content-desc='Public']"))
            {
              gclass27_0.method_61(0, "//*[@content-desc='Write Post']/preceding-sibling::*[1]", string_11_8);
              if (gclass27_0.method_61(10, "//*[@text='Public' or starts-with(@content-desc, 'Public')]", ""))
              {
                gclass27_0.method_61(5, "//android.widget.CheckBox[@text='Set as default audience.'][@checked='false']", "");
                gclass27_0.method_61(5, "//*[@content-desc='Done' or @text='Done' or @text='CHANGE' or @text='SAVE']", "");
              }
              else
                gclass27_0.method_28();
              string_11_8 = "";
              gclass27_0.method_33(5, ref string_11_8, "//*[@content-desc=\"Share Now\"]");
            }
            if (gclass27_0.method_61(0, "//*[@content-desc=\"Share Now\"]", string_11_8))
            {
              ++int_7;
              this.method_184(int_4, string_0_1 + "Tap Share Now, " + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(1, 3));
            }
          }
          else
          {
            this.method_184(int_4, string_0_1 + "Back...");
            gclass27_0.method_28(double_0: 0.3);
          }
        }
      }
    }
    return 0;
  }

  public int method_111(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int minValue1 = gclass22_0.method_3("nudDelayFrom", 3);
    int num1 = gclass22_0.method_3("nudDelayTo", 5);
    int int_4_1 = gclass22_0.method_3("nudSoLuongUidFrom", 1);
    int int_5_1 = gclass22_0.method_3("nudSoLuongUidTo", 3);
    List<string> source = gclass22_0.method_2("txtIdPost");
    int int_5_2 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    string string_2_1 = gclass22_0.method_1("typeReaction");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_18 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_7 = gclass22_0.method_4("ckbTuDongXoaNoiDung");
    bool bool_8 = gclass22_0.method_4("ckbAnh");
    string string_3 = gclass22_0.method_1("txtPathAnh");
    bool flag = gclass22_0.method_4("ckbTuongTacVideoTrenPost");
    int minValue2 = gclass22_0.method_3("nudTuongTacVideoTrenPostFrom", 3);
    int num2 = gclass22_0.method_3("nudTuongTacVideoTrenPostTo", 5);
    int num3 = 1;
    int num4 = gclass27_0.method_87(int_4_1, int_5_1);
    string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
    for (int index = 0; index < num4 && source.Count != 0; ++index)
    {
      string string_0 = string_0_1 + GClass35.smethod_0("Đang") + string.Format(" {0} ({1}/{2}): ", (object) string_1, (object) (index + 1), (object) num4);
      string string_1_1 = source.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>();
      source.Remove(string_1_1);
      this.method_112(int_4, string_0, gclass27_0, string_1_1, int_5_2, int_6, bool_5, string_2_1, bool_6, list_18, bool_7, bool_8, string_3, string_2);
      if (flag)
      {
        this.method_184(int_4, string_0 + GClass35.smethod_0("Tap video..."));
        if (gclass27_0.method_60("//*[starts-with(@content-desc,'Shared Link:')]"))
        {
          gclass27_0.method_31(10, "", "//*[@resource-id='movie_player']");
          gclass27_0.method_58("//android.widget.Button[@text='TAP TO UNMUTE']", 10);
          this.method_184(int_4, string_0 + GClass35.smethod_0("Xem video, " + GClass35.smethod_0("đợi") + " {time}s..."), Class54.random_0.Next(minValue2, num2 + 1));
        }
      }
      this.method_184(int_4, string_0 + GClass35.smethod_0("Tương tác xong, " + GClass35.smethod_0("đợi") + " {time}s..."), Class54.random_0.Next(minValue1, num1 + 1));
    }
    return num3;
  }

  public int method_112(
    int int_4,
    string string_0_1,
    GClass27 gclass27_0,
    string string_1,
    int int_5,
    int int_6,
    bool bool_5,
    string string_2,
    bool bool_6,
    List<string> list_18,
    bool bool_7,
    bool bool_8,
    string string_3,
    string string_4 = "")
  {
    try
    {
      this.method_184(int_4, string_0_1 + GClass35.smethod_0("Mở bài viết..."));
      if (this.method_76(gclass27_0, int_4, string_0_1, string_1) == 1)
      {
        this.method_184(int_4, string_0_1 + GClass35.smethod_0("Xem bài viết, " + GClass35.smethod_0("đợi") + " {time}s..."), Class54.random_0.Next(int_5, int_6 + 1));
        this.method_184(int_4, string_0_1 + GClass35.smethod_0("Tương tác bài viết..."));
        int int_5_1 = 0;
        int int_6_1 = 0;
        int int_7 = 0;
        List<string> list_19 = new List<string>();
        for (int index1 = 0; index1 < 5; ++index1)
        {
          List<string> list_18_1 = new List<string>();
          if (string_4 == "")
            list_18_1 = GClass19.smethod_27(list_18);
          else if (this.dictionary_15[string_4].Count > 0)
          {
            string str = "";
            if (!bool_7)
            {
              str = this.dictionary_15[string_4].OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).FirstOrDefault<string>();
            }
            else
            {
              lock (this.dictionary_15)
              {
                int index2 = this.random_0.Next(0, this.dictionary_15[string_4].Count);
                str = this.dictionary_15[string_4][index2];
                this.dictionary_15[string_4].RemoveAt(index2);
              }
            }
            list_18_1.Add(str);
          }
          this.method_110(int_4, string_0_1, gclass27_0, bool_5, string_2, ref int_5_1, bool_6, ref int_6_1, list_18_1, ref list_19, false, ref int_7, 1, bool_8, string_3);
          if (int_5_1 <= 0 && int_6_1 <= 0)
          {
            this.method_184(int_4, string_0_1 + "Scroll...");
            if (gclass27_0.method_78() && !gclass27_0.method_104())
              break;
          }
          else
            break;
        }
      }
    }
    catch
    {
    }
    return 0;
  }

  public int method_113(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int minValue = gclass22_0.method_3("nudSoLuongBanBeFrom");
    int num1 = gclass22_0.method_3("nudSoLuongBanBeTo");
    int int_5 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    int int_7 = gclass22_0.method_3("nudCountLikeFrom", 1);
    int int_8 = gclass22_0.method_3("nudCountLikeTo", 3);
    bool bool_6 = gclass22_0.method_4("ckbComment");
    int int_9 = gclass22_0.method_3("nudCountCommentFrom", 1);
    int int_10 = gclass22_0.method_3("nudCountCommentTo", 3);
    List<string> list_18 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    int int_11 = gclass22_0.method_3("nudCountShareFrom", 1);
    int int_12 = gclass22_0.method_3("nudCountShareTo", 3);
    int num2 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num3 = this.random_0.Next(minValue, num1 + 1);
      if (num3 != 0)
      {
        while (num2 < num3)
        {
          ++num2;
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Go to Friend...", (object) num2, (object) num3));
          if (this.method_215(gclass27_0, int_4, string_0_1, "fb://friends"))
          {
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Friend...", (object) num2, (object) num3));
            List<string> list_0 = gclass27_0.method_37(3, "", "//android.view.View[contains(@content-desc,\", profile picture\") or contains(@text,\", profile picture\")]");
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Friend: ", (object) num2, (object) num3) + list_0.Count.ToString());
            if (list_0.Count != 0)
            {
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) num2, (object) num3));
              int num4 = 0;
              if (list_0.Count >= 6)
              {
                while (!gclass27_0.method_78())
                {
                  ++num4;
                  if (num4 >= 5)
                    break;
                }
                int num5 = gclass27_0.method_87(0, (num4 < 1 ? 1 : num4) - 1);
                int num6 = 0;
                while (num6 < num5 && !gclass27_0.method_78(-1))
                  ++num6;
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Friend...", (object) num2, (object) num3));
                list_0 = gclass27_0.method_37(3, "", "//android.view.View[contains(@content-desc,\", profile picture\") or contains(@text,\", profile picture\")]");
              }
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Friend...", (object) num2, (object) num3));
              gclass27_0.method_66(list_0.smethod_10());
              gclass27_0.method_80(2.0, 3.0);
              this.method_107(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num2, (object) num3), gclass27_0, int_5, int_6, bool_5, "0124", int_7, int_8, bool_6, int_9, int_10, list_18, bool_7, int_11, int_12);
            }
            else
              break;
          }
          else
            break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "HDTuongTacBanBe");
    }
    return num2;
  }

  public int method_114(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int minValue = gclass22_0.method_3("nudSoLuongNhomFrom");
    int num1 = gclass22_0.method_3("nudSoLuongNhomTo");
    int int_5 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    int int_7 = gclass22_0.method_3("nudCountLikeFrom", 1);
    int int_8 = gclass22_0.method_3("nudCountLikeTo", 3);
    bool bool_6 = gclass22_0.method_4("ckbComment");
    int int_9 = gclass22_0.method_3("nudCountCommentFrom", 1);
    int int_10 = gclass22_0.method_3("nudCountCommentTo", 3);
    List<string> list_18 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    int int_11 = gclass22_0.method_3("nudCountShareFrom", 1);
    int int_12 = gclass22_0.method_3("nudCountShareTo", 3);
    int num2 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num3 = this.random_0.Next(minValue, num1 + 1);
      if (num3 != 0)
      {
        while (num2 < num3)
        {
          ++num2;
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Go to Group...", (object) num2, (object) num3));
          if (this.method_215(gclass27_0, int_4, string_0_1, "fb://faceweb/f?href=https://m.facebook.com/groups_browse/your_groups/"))
          {
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Group...", (object) num2, (object) num3));
            List<string> list_0 = gclass27_0.method_37(3, "", "//android.view.View[starts-with(@content-desc,\"group image link\") or starts-with(@text,\"group image link\")]");
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Group: ", (object) num2, (object) num3) + list_0.Count.ToString());
            if (list_0.Count != 0)
            {
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) num2, (object) num3));
              int num4 = 0;
              if (list_0.Count >= 9)
              {
                while (!gclass27_0.method_78())
                {
                  ++num4;
                  if (num4 >= 5)
                    break;
                }
                int num5 = gclass27_0.method_87(0, (num4 < 1 ? 1 : num4) - 1);
                int num6 = 0;
                while (num6 < num5 && !gclass27_0.method_78(-1))
                  ++num6;
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Group...", (object) num2, (object) num3));
                list_0 = gclass27_0.method_37(3, "", "//android.view.View[starts-with(@content-desc,\"group image link\") or starts-with(@text,\"group image link\")]");
              }
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Group...", (object) num2, (object) num3));
              gclass27_0.method_66(list_0.smethod_10());
              gclass27_0.method_80(2.0, 3.0);
              this.method_107(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num2, (object) num3), gclass27_0, int_5, int_6, bool_5, "0124", int_7, int_8, bool_6, int_9, int_10, list_18, bool_7, int_11, int_12);
            }
            else
              break;
          }
          else
            break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "HDTTuongTacNhom");
    }
    return num2;
  }

  public int method_115(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int minValue = gclass22_0.method_3("nudSoLuongPageFrom");
    int num1 = gclass22_0.method_3("nudSoLuongPageTo");
    bool flag = gclass22_0.method_4("ckbTuDongXoaUid");
    int int_5 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    int int_7 = gclass22_0.method_3("nudCountLikeFrom", 1);
    int int_8 = gclass22_0.method_3("nudCountLikeTo", 3);
    bool bool_6 = gclass22_0.method_4("ckbComment");
    int int_9 = gclass22_0.method_3("nudCountCommentFrom", 1);
    int int_10 = gclass22_0.method_3("nudCountCommentTo", 3);
    List<string> list_18 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    int int_11 = gclass22_0.method_3("nudCountShareFrom", 1);
    int int_12 = gclass22_0.method_3("nudCountShareTo", 3);
    int num2 = 0;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_2 + ": ";
      int num3 = this.random_0.Next(minValue, num1 + 1);
      if (num3 != 0)
      {
        List<string> stringList = new List<string>();
        if (!flag)
          stringList = GClass19.smethod_27(this.dictionary_12[string_1]);
        string str = "";
        while (num2 < num3)
        {
          ++num2;
          if (!flag)
          {
            if (stringList.Count != 0)
            {
              str = stringList[this.random_0.Next(0, stringList.Count)];
              stringList.Remove(str);
            }
            else
              break;
          }
          else
          {
            lock (this.dictionary_12)
            {
              if (this.dictionary_12[string_1].Count != 0)
              {
                str = this.dictionary_12[string_1][this.random_0.Next(0, this.dictionary_12[string_1].Count)];
                this.dictionary_12[string_1].Remove(str);
              }
              else
                break;
            }
          }
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Go to Page {2}...", (object) num2, (object) num3, (object) str));
          if (this.method_215(gclass27_0, int_4, string_0_1, "fb://" + (str.StartsWith("1000") ? "profile" : "page") + "/" + str))
          {
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Post...", (object) num2, (object) num3));
            if (gclass27_0.method_61(5, "//*[contains(@content-desc,\"Posts, Tab\")]", ""))
            {
              gclass27_0.method_80(2.0, 3.0);
              this.method_107(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num2, (object) num3), gclass27_0, int_5, int_6, bool_5, "0124", int_7, int_8, bool_6, int_9, int_10, list_18, bool_7, int_11, int_12);
            }
          }
          else
            break;
        }
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "HDTTuongTacPage");
    }
    return num2;
  }

  public int method_116(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    string str1 = gclass22_0.method_1("txtUid");
    bool flag1 = gclass22_0.method_4("ckbInteract");
    bool flag2 = gclass22_0.method_4("ckbTuDongXoaNoiDung");
    int num1 = 1;
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_2 + ": ";
label_68:
label_2:
      this.method_184(int_4, string_0_1 + "Go to Page " + str1 + "...");
      if (this.method_215(gclass27_0, int_4, string_0_1, "fb://" + (!str1.StartsWith("1000") ? "page" : "profile") + "/" + str1))
      {
        if (flag1)
        {
          if (this.method_118(gclass27_0, int_4, string_0_1) != -1)
            flag1 = false;
          else
            goto label_68;
        }
        this.method_184(int_4, string_0_1 + "Review Page...");
        string string_11_1 = "";
        if (!(gclass27_0.method_30(0, ref string_11_1, new List<string>()
        {
          "//android.widget.TextView[contains(@content-desc,\"Reviews, Tab\")]",
          "//*[@content-desc='Posts, tab']"
        }) == "") || gclass27_0.method_60("//android.widget.Button[@content-desc=\"Cancel\"]", string_11_1))
        {
          int num2 = 0;
          int num3 = 0;
          int num4 = 0;
          int num5 = 0;
          int num6 = 1;
          int tickCount = Environment.TickCount;
          int num7 = 60;
          do
          {
            string str2 = gclass27_0.method_53();
            string str3 = gclass27_0.method_29(0, str2, new List<string>()
            {
              "//*[contains(@content-desc,\"Reviews, Tab\")]",
              "//*[contains(@content-desc, \"Home\")]",
              "//*[@content-desc='Posts, tab']",
              "//*[@content-desc='How are ratings calculated?']",
              "//*[@content-desc=\"YES\"]",
              "//android.widget.EditText[starts-with(@text,'What')]",
              "//androidx.recyclerview.widget.RecyclerView/parent::*/parent::*/child::*",
              "//androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup"
            });
            string s = str3;
            // ISSUE: reference to a compiler-generated method
            uint num8 = Class206.smethod_0(s);
            if (num8 > 3483486136U)
            {
              if (num8 <= 3976528780U)
              {
                if (num8 != 3660407778U)
                {
                  if (num8 == 3976528780U && s == "//*[@content-desc='How are ratings calculated?']")
                  {
                    if (gclass27_0.method_31(0, str2, "//*[@content-desc=\"YES\"]") && num3 < 2)
                    {
                      ++num3;
                      gclass27_0.method_60("//*[@content-desc=\"YES\"]", str2);
                    }
                    else
                      break;
                  }
                  else
                    goto label_66;
                }
                else if (s == "//*[contains(@content-desc,\"Reviews, Tab\")]")
                {
                  if (gclass27_0.method_31(0, str2, "//*[@content-desc=\"YES\"]"))
                    gclass27_0.method_60("//*[@content-desc=\"YES\"]", str2);
                  else if (num2 < 2)
                  {
                    this.method_184(int_4, string_0_1 + "Tap " + gclass27_0.method_151(str3) + "...");
                    ++num2;
                    gclass27_0.method_60(str3, str2);
                  }
                  else
                    break;
                }
                else
                  goto label_66;
              }
              else if (num8 == 4058141664U)
              {
                if (!(s == "//androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup"))
                  goto label_66;
                else
                  break;
              }
              else if (num8 != 4186682215U)
              {
                if (num8 == 4283911937U && s == "//android.widget.EditText[starts-with(@text,'What')]")
                {
                  string string_0_2 = "";
                  if (this.dictionary_14[string_1].Count != 0)
                  {
                    if (!flag2)
                    {
                      string_0_2 = this.dictionary_14[string_1][this.random_0.Next(0, this.dictionary_14[string_1].Count)];
                    }
                    else
                    {
                      lock (this.dictionary_14)
                      {
                        int index = this.random_0.Next(0, this.dictionary_14[string_1].Count);
                        string_0_2 = this.dictionary_14[string_1][index];
                        this.dictionary_14[string_1].RemoveAt(index);
                      }
                    }
                    string string_12 = GClass19.smethod_28(string_0_2, this.random_0);
                    for (int index = 0; index < 10; ++index)
                    {
                      gclass27_0.method_50("//android.widget.EditText", string_12);
                      gclass27_0.SleepSeconds(1.0);
                      if (!gclass27_0.method_60("(//androidx.viewpager.widget.ViewPager//android.view.ViewGroup)[last()]"))
                        gclass27_0.SleepSeconds(1.0);
                      else
                        break;
                    }
                  }
                  else
                    break;
                }
                else
                  goto label_66;
              }
              else if (s == "//*[contains(@content-desc, \"Home\")]")
              {
                string string_11_2 = gclass27_0.method_37(0, str2, "//*[contains(@content-desc, \"Home\")]").FirstOrDefault<string>();
                if (!string.IsNullOrEmpty(string_11_2))
                {
                  if (num4 < 2)
                  {
                    ++num4;
                    Point point = gclass27_0.method_74(string_11_2);
                    gclass27_0.method_73(point.X + gclass27_0.method_21() / 2, point.Y, point.X, point.Y);
                  }
                  else
                    break;
                }
              }
              else
                goto label_66;
            }
            else if (num8 <= 2535497917U)
            {
              if (num8 != 532719482U)
              {
                if (num8 == 2535497917U && s == "//androidx.recyclerview.widget.RecyclerView/parent::*/parent::*/child::*")
                  gclass27_0.method_66(gclass27_0.method_37(0, str2, str3).LastOrDefault<string>());
                else
                  goto label_66;
              }
              else if (s == "//android.widget.ProgressBar")
              {
                this.method_184(int_4, string_0_1 + "Loading...");
                if (!gclass27_0.method_42(60))
                {
                  if (num5 < num6)
                  {
                    int num9 = num5 + 1;
                    goto label_2;
                  }
                  else
                    break;
                }
              }
              else
                goto label_66;
            }
            else if (num8 != 2786206699U)
            {
              if (num8 == 3483486136U && s == "//*[@content-desc=\"YES\"]")
              {
                if (num3 < 2)
                {
                  ++num3;
                  gclass27_0.method_60("//*[@content-desc=\"YES\"]", str2);
                }
                else
                  break;
              }
              else
                goto label_66;
            }
            else if (s == "//*[@content-desc='Posts, tab']")
            {
              bool flag3 = false;
              int num10 = 0;
              while (true)
              {
                if (num10 < 5)
                {
                  int num11;
                  if (gclass27_0.method_123("dataimage\\rate"))
                    num11 = gclass27_0.method_147(30, "", "How are ratings calculated") ? 1 : 0;
                  else
                    num11 = 0;
                  if (num11 == 0)
                  {
                    if (!gclass27_0.method_78())
                      ++num10;
                    else
                      goto label_70;
                  }
                  else
                    break;
                }
                else
                  goto label_63;
              }
              gclass27_0.method_28();
              flag3 = true;
label_63:
              if (!flag3)
                break;
            }
            else
              goto label_66;
label_65:
            gclass27_0.SleepSeconds(1.0);
            continue;
label_66:
            this.method_184(int_4, string_0_1 + "Scroll...");
            if (gclass27_0.method_78())
            {
              switch (this.method_32(gclass27_0, int_4, string_0))
              {
                case 0:
                  goto label_65;
                case 1:
                  goto label_2;
                default:
                  goto label_70;
              }
            }
            else
              goto label_65;
          }
          while (Environment.TickCount - tickCount < num7 * 1000);
        }
        else
          goto label_68;
      }
    }
    catch
    {
      num1 = 0;
    }
label_70:
    return num1;
  }

  public int method_117(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int num = 1;
    string str = gclass22_0.method_1("txtUid");
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      do
      {
        this.method_184(int_4, string_0_1 + "Go to Page " + str + "...");
        if (!this.method_215(gclass27_0, int_4, string_0_1, "fb://" + (!str.StartsWith("1000") ? "page" : "profile") + "/" + str))
          break;
      }
      while (this.method_118(gclass27_0, int_4, string_0_1) == -1);
    }
    catch
    {
      num = 0;
    }
    return num;
  }

  public int method_118(GClass27 gclass27_0, int int_4, string string_0)
  {
    int tickCount = Environment.TickCount;
    int num = 10;
    do
    {
      this.method_184(int_4, string_0 + "Find Like...");
      string str = gclass27_0.method_53();
      string string_11 = gclass27_0.method_29(0, str, new List<string>()
      {
        "//android.view.ViewGroup[@content-desc='Liked']",
        "//android.view.ViewGroup[@content-desc='Following']",
        "//android.view.ViewGroup[@content-desc='Like']",
        "//android.view.ViewGroup[@content-desc='like button']/android.view.ViewGroup",
        "//android.view.ViewGroup[@content-desc='like button']",
        "//android.view.ViewGroup[@content-desc='Follow']"
      });
      switch (string_11)
      {
        case "//android.view.ViewGroup[@content-desc='Like']":
        case "//android.view.ViewGroup[@content-desc='like button']/android.view.ViewGroup":
        case "//android.view.ViewGroup[@content-desc='like button']":
        case "//android.view.ViewGroup[@content-desc='Follow']":
          this.method_184(int_4, string_0 + "Tap " + gclass27_0.method_151(string_11) + "...");
          gclass27_0.method_60(string_11, str);
          this.method_184(int_4, string_0 + "Tap Like, " + GClass35.smethod_0("đợi") + " {time}s...", 3);
          goto label_7;
        case "//android.view.ViewGroup[@content-desc='Liked']":
        case "//android.view.ViewGroup[@content-desc='Following']":
          goto label_7;
        default:
          this.method_184(int_4, string_0 + "Scroll...");
          if (gclass27_0.method_78(-1))
          {
            switch (this.method_32(gclass27_0, int_4, string_0))
            {
              case 0:
                break;
              case 1:
                return -1;
              default:
                goto label_7;
            }
          }
          gclass27_0.SleepSeconds(1.0);
          continue;
      }
    }
    while (Environment.TickCount - tickCount < num * 1000);
label_7:
    return 0;
  }

  public int method_119(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int num1 = 1;
    string str = gclass22_0.method_1("txtUid");
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      this.method_184(int_4, string_0_1 + "Go to Profile " + str + "...");
      if (this.method_215(gclass27_0, int_4, string_0_1, "fb://profile/" + str))
      {
        this.method_184(int_4, string_0_1 + "Follow Uid...");
        int num2 = 0;
        int tickCount = Environment.TickCount;
        string string_11_1;
        do
        {
          string_11_1 = "";
          switch (gclass27_0.method_30(10, ref string_11_1, new List<string>()
          {
            "//*[@content-desc='Follow']",
            "//*[@content-desc='Following']",
            "//*[@content-desc='More']"
          }))
          {
            case "//*[@content-desc='Follow']":
              if (num2 <= 2)
              {
                ++num2;
                gclass27_0.method_60("//*[@content-desc='Follow']", string_11_1);
                break;
              }
              goto label_17;
            case "//*[@content-desc='Following']":
              goto label_6;
            case "//*[@content-desc='More']":
              goto label_8;
          }
          gclass27_0.SleepSeconds(2.0);
        }
        while (Environment.TickCount - tickCount <= 30000);
        goto label_17;
label_6:
        if (num2 > 0)
        {
          num1 = 1;
          goto label_17;
        }
        else
          goto label_17;
label_8:
        if (gclass27_0.method_61(0, "//*[@content-desc=\"More\"]", string_11_1))
        {
          do
          {
            Bitmap bitmap_0 = (Bitmap) null;
            string string_11_2 = gclass27_0.method_128(10, ref bitmap_0, new List<string>()
            {
              "dataimage\\following",
              "dataimage\\follow"
            });
            int num3;
            switch (string_11_2)
            {
              case "dataimage\\following":
                goto label_14;
              case "dataimage\\follow":
                num3 = num2 <= 2 ? 1 : 0;
                break;
              default:
                num3 = 0;
                break;
            }
            if (num3 != 0)
            {
              ++num2;
              gclass27_0.method_123(string_11_2, bitmap_0);
              gclass27_0.SleepSeconds(2.0);
            }
            else
              break;
          }
          while (Environment.TickCount - tickCount <= 30000);
          goto label_17;
label_14:
          if (num2 > 0)
            num1 = 1;
        }
label_17:;
      }
    }
    catch
    {
      num1 = 0;
    }
    return num1;
  }

  public int method_120(
    ref int int_4,
    int int_5,
    string string_0_1,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int minValue = gclass22_0.method_3("nudSoLuongFrom");
    int num1 = gclass22_0.method_3("nudSoLuongTo");
    int num2 = gclass22_0.method_3("typeDang");
    List<string> collection = gclass22_0.method_2("txtNoiDung");
    List<string> source1 = new List<string>();
    bool flag1 = gclass22_0.method_4("ckbUseBackgroundText");
    int num3 = gclass22_0.method_3("typeBaiHat");
    bool flag2 = gclass22_0.method_4("ckbUseBackgroundNhac");
    bool flag3 = gclass22_0.method_4("ckbAnh");
    string string_0_6 = gclass22_0.method_1("txtPathAnh");
    bool bool_5_1 = gclass22_0.method_4("ckbXoaAnhDaDang");
    string string_0_7 = gclass22_0.method_1("txtChiDangAnhPathAnh");
    bool bool_5_2 = gclass22_0.method_4("ckbChiDangAnhXoaAnhDaDang");
    if (flag2 & flag3)
    {
      if (gclass27_0.method_87(1, 100) % 2 == 0)
        flag2 = false;
      else
        flag3 = false;
    }
    int num4 = 0;
    try
    {
      string str1 = string_0_1 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num5 = this.random_0.Next(minValue, num1 + 1);
      bool flag4 = false;
label_200:
      for (int index1 = 0; index1 < num5 + 5; ++index1)
      {
        int num6 = 0;
        int num7 = 1;
        while (num4 < num5)
        {
          this.method_184(int_5, str1 + string.Format("({0}/{1})...", (object) (num4 + 1), (object) num5));
          try
          {
            gclass27_0.method_107();
            int tickCount = Environment.TickCount;
            int num8 = 300;
            switch (num2)
            {
              case 0:
                List<string> list_0_1 = new List<string>()
                {
                  "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]",
                  "//*[@content-desc='Add to story']",
                  "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*",
                  "//*[@content-desc='Start a Text story']",
                  "//*[@content-desc='Select background']",
                  "//*[contains(@content-desc,', background')]",
                  "//android.widget.EditText[@content-desc='Text field']",
                  "//*[@text='Privacy']",
                  "//*[@text='Public']",
                  "//android.widget.Button[@content-desc='Share']"
                };
                if (!flag1)
                {
                  list_0_1.Remove("//*[@content-desc='Select background']");
                  list_0_1.Remove("//*[contains(@content-desc,', background')]");
                }
                do
                {
                  string str2 = gclass27_0.method_53();
                  string str3 = gclass27_0.method_29(0, str2, list_0_1);
                  string s = str3;
                  // ISSUE: reference to a compiler-generated method
                  uint num9 = Class206.smethod_0(s);
                  if (num9 > 725689854U)
                  {
                    if (num9 <= 2516125468U)
                    {
                      if (num9 != 2378966911U)
                      {
                        if (num9 == 2516125468U && s == "//*[contains(@content-desc,', background')]")
                        {
                          List<string> source2 = gclass27_0.method_37(0, str2, str3);
                          gclass27_0.method_66(source2.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_2 => Guid.NewGuid())).First<string>());
                          goto label_56;
                        }
                      }
                      else if (s == "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]")
                        goto label_52;
                    }
                    else if (num9 != 2923101247U)
                    {
                      if (num9 != 3025215824U)
                      {
                        if (num9 == 3339772369U && s == "//*[@text='Privacy']")
                          goto label_52;
                      }
                      else if (s == "//*[@content-desc='Add to story']")
                        goto label_52;
                    }
                    else if (s == "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*")
                    {
                      if ((gclass27_0.method_34(str2, "(" + str3 + ")[1]", "content-desc").FirstOrDefault<string>() ?? "").Contains("music"))
                      {
                        gclass27_0.method_60("(" + str3 + ")[last()]", str2);
                        goto label_56;
                      }
                      else
                      {
                        gclass27_0.method_60("(" + str3 + ")[1]", str2);
                        goto label_56;
                      }
                    }
                  }
                  else if (num9 <= 349629914U)
                  {
                    if (num9 != 159668279U)
                    {
                      if (num9 == 349629914U && s == "//*[@text='Public']")
                        goto label_52;
                    }
                    else if (s == "//*[@content-desc='Select background']")
                      goto label_52;
                  }
                  else if (num9 != 471470080U)
                  {
                    if (num9 != 598952663U)
                    {
                      if (num9 == 725689854U && s == "//*[@content-desc='Start a Text story']")
                        goto label_52;
                    }
                    else if (s == "//android.widget.Button[@content-desc='Share']")
                    {
                      this.method_184(int_5, str1 + "Tap " + gclass27_0.method_151(str3) + "...");
                      gclass27_0.method_60(str3, str2);
                      gclass27_0.SleepSeconds(2.0);
                      if (gclass27_0.method_61(10, "//android.widget.Button[@text='NOT NOW']", ""))
                        this.method_184(int_5, str1 + string.Format("({0}/{1}), Tap Post, ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(12, 15));
                      this.method_184(int_5, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " post success...");
                      if (flag4)
                      {
                        gclass27_0.method_107();
                        gclass27_0.SleepSeconds(3.0);
                      }
                      if (gclass27_0.method_42(flag3 ? 300 : 60))
                      {
                        ++num4;
                        if (num4 >= num5)
                          return num4;
                        break;
                      }
                      break;
                    }
                  }
                  else if (s == "//android.widget.EditText[@content-desc='Text field']")
                  {
                    if (source1.Count == 0)
                      source1 = new List<string>((IEnumerable<string>) collection);
                    string string_0_8 = source1.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_3 => Guid.NewGuid())).FirstOrDefault<string>();
                    source1.Remove(string_0_8);
                    string string_12 = GClass19.smethod_28(string_0_8, this.random_0);
                    if (string_12.Trim() != "")
                    {
                      gclass27_0.method_80(1.0, 1.5);
                      this.method_184(int_5, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("Nhập dữ liệu..."));
                      gclass27_0.method_50(str3, string_12);
                      gclass27_0.SleepSeconds(2.0);
                      gclass27_0.method_60("(//android.widget.Button[@content-desc='Back']/parent::*/child::*)[last()]", str2);
                      goto label_56;
                    }
                    else
                      goto label_56;
                  }
                  if (gclass27_0.method_31(0, str2, "//*[@content-desc='Stories']"))
                  {
                    Class77 class77 = new Class77(gclass27_0.method_37(0, str2, "//*[@content-desc='Stories']").FirstOrDefault<string>());
                    if (class77.int_3 - class77.int_1 < 200)
                    {
                      gclass27_0.method_66(class77.method_0());
                      goto label_56;
                    }
                  }
                  this.method_184(int_5, str1 + string.Format("({0}/{1}), Scroll...", (object) (num4 + 1), (object) num5));
                  if (gclass27_0.method_78(-1))
                  {
                    int num10 = this.method_32(gclass27_0, int_5, string_0_1);
                    if (num10 != 1 && num10 != 0)
                      return num4;
                    break;
                  }
                  goto label_56;
label_52:
                  this.method_184(int_5, str1 + "Tap " + gclass27_0.method_151(str3) + "...");
                  gclass27_0.method_60(str3, str2);
                  switch (str3)
                  {
                    case "//*[@content-desc='Add to story']":
                      flag4 = true;
                      break;
                    case "//*[@text='Privacy']":
                      gclass27_0.method_31(60, "", "//*[@text='Public']");
                      break;
                    case "//*[@text='Public']":
                      gclass27_0.method_61(5, "//*[@text='CHANGE' or @text='SAVE']", "");
                      gclass27_0.method_60("//*[@content-desc='Back']", str2);
                      gclass27_0.method_42(60);
                      break;
                  }
label_56:
                  if (str3 != "")
                    list_0_1.Remove(str3);
                  gclass27_0.SleepSeconds(2.0);
                }
                while (Environment.TickCount - tickCount < num8 * 1000);
                goto label_200;
              case 1:
                List<string> list_0_2 = new List<string>()
                {
                  "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]",
                  "//*[@content-desc='Add to story']",
                  "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*",
                  "//*[@content-desc='Start a Music story']",
                  "(//*[@content-desc='Photo'])[last()]",
                  "//*[@content-desc='Select background']",
                  "//*[contains(@content-desc,', background')]",
                  "//*[@content-desc='Close background styles tray']",
                  "//android.widget.EditText[starts-with(@text,'Search music')]",
                  "//*[@content-desc='Song preview']",
                  "//*[@text='Done']",
                  "//*[@text='Privacy']",
                  "//*[@text='Public']",
                  "//android.widget.Button[@content-desc='Share']",
                  "//android.widget.ProgressBar"
                };
                if (!flag2)
                {
                  list_0_2.Remove("//*[@content-desc='Select background']");
                  list_0_2.Remove("//*[contains(@content-desc,', background')]");
                }
                if (!flag3)
                  list_0_2.Remove("(//*[@content-desc='Photo'])[last()]");
                string str4;
                string str5;
                do
                {
                  str4 = gclass27_0.method_53();
                  str5 = gclass27_0.method_29(0, str4, list_0_2);
                  string s = str5;
                  // ISSUE: reference to a compiler-generated method
                  uint num11 = Class206.smethod_0(s);
                  if (num11 > 2378966911U)
                  {
                    if (num11 <= 3330475511U)
                    {
                      if (num11 <= 2923101247U)
                      {
                        if (num11 != 2516125468U)
                        {
                          if (num11 == 2923101247U && s == "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*")
                          {
                            if ((gclass27_0.method_34(str4, "(" + str5 + ")[1]", "content-desc").FirstOrDefault<string>() ?? "").Contains("music"))
                            {
                              gclass27_0.method_60("(" + str5 + ")[last()]", str4);
                              goto label_146;
                            }
                            else
                            {
                              gclass27_0.method_60("(" + str5 + ")[1]", str4);
                              goto label_146;
                            }
                          }
                          else
                            goto label_140;
                        }
                        else if (s == "//*[contains(@content-desc,', background')]")
                        {
                          List<string> source3 = gclass27_0.method_37(0, str4, str5);
                          gclass27_0.method_66(source3.OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_4 => Guid.NewGuid())).First<string>());
                          gclass27_0.SleepSeconds(2.0);
                          gclass27_0.method_60("//*[@content-desc='Close background styles tray']", str4);
                          goto label_146;
                        }
                        else
                          goto label_140;
                      }
                      else if (num11 != 3025215824U)
                      {
                        if (num11 != 3330475511U || !(s == "//*[@content-desc='Close background styles tray']"))
                          goto label_140;
                      }
                      else if (!(s == "//*[@content-desc='Add to story']"))
                        goto label_140;
                    }
                    else if (num11 > 3802764538U)
                    {
                      int num12;
                      switch (num11)
                      {
                        case 3872622007:
                          if (!(s == "//*[@text='Done']"))
                            goto label_140;
                          else
                            goto label_136;
                        case 4152636390:
                          num12 = s == "//android.widget.EditText[starts-with(@text,'Search music')]" ? 1 : 0;
                          break;
                        default:
                          num12 = 0;
                          break;
                      }
                      if (num12 != 0)
                      {
                        if (num3 == 1)
                        {
                          int num13 = 0;
                          int num14 = 3;
label_82:
                          ++num13;
                          if (num13 <= num14)
                          {
                            string string_0_9 = "";
                            lock (this.dictionary_19)
                            {
                              if (this.dictionary_19[string_2].Count == 0)
                                this.dictionary_19[string_2] = new List<string>((IEnumerable<string>) this.dictionary_18[string_2]);
                              string_0_9 = this.dictionary_19[string_2].OrderBy<string, Guid>((System.Func<string, Guid>) (string_0_5 => Guid.NewGuid())).First<string>();
                              this.dictionary_19[string_2].Remove(string_0_9);
                            }
                            string string_12 = GClass19.smethod_28(string_0_9, this.random_0);
                            if (string_12.Trim() != "")
                            {
                              gclass27_0.method_80(1.0, 1.5);
                              this.method_184(int_5, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("Nhập dữ liệu..."));
                              gclass27_0.method_51(str5, string_12);
                              gclass27_0.SleepSeconds(2.0);
                            }
                            if (!gclass27_0.method_31(30, "", "//*[@content-desc='Song preview']"))
                              goto label_82;
                            else
                              goto label_146;
                          }
                          else
                            goto label_92;
                        }
                        else
                        {
                          gclass27_0.method_31(120, "", "//*[@content-desc='Song preview']");
                          goto label_146;
                        }
                      }
                      else
                        goto label_140;
                    }
                    else
                    {
                      int num15;
                      switch (num11)
                      {
                        case 3339772369:
                          if (s == "//*[@text='Privacy']")
                            goto label_101;
                          else
                            goto label_140;
                        case 3802764538:
                          num15 = !(s == "//*[@content-desc='Start a Music story']") ? 1 : 0;
                          break;
                        default:
                          num15 = 1;
                          break;
                      }
                      if (num15 != 0)
                        goto label_140;
label_101:;
                    }
                  }
                  else if (num11 <= 532719482U)
                  {
                    if (num11 != 159668279U)
                    {
                      if (num11 != 349629914U)
                      {
                        if (num11 == 532719482U && s == "//android.widget.ProgressBar")
                        {
                          this.method_184(int_5, str1 + "Loading...");
                          if (gclass27_0.method_42(60))
                            goto label_146;
                          else
                            goto label_107;
                        }
                        else
                          goto label_140;
                      }
                      else if (!(s == "//*[@text='Public']"))
                        goto label_140;
                    }
                    else if (!(s == "//*[@content-desc='Select background']"))
                      goto label_140;
                  }
                  else if (num11 > 630380789U)
                  {
                    int num16;
                    switch (num11)
                    {
                      case 2097544948:
                        if (s == "//*[@content-desc='Song preview']")
                        {
                          if (flag3)
                          {
                            this.method_184(int_5, str1 + string.Format("({0}/{1}), Up image...", (object) (num4 + 1), (object) num5));
                            this.method_77(gclass27_0, string_0_6, bool_5: bool_5_1);
                          }
                          this.method_184(int_5, str1 + string.Format("({0}/{1}), Tap song...", (object) (num4 + 1), (object) num5));
                          Point point = new Class77(gclass27_0.method_37(0, str4, str5).First<string>()).method_4();
                          gclass27_0.method_55(point.X - 500, point.Y);
                          for (int index2 = 0; index2 < 60; ++index2)
                          {
                            gclass27_0.SleepSeconds(2.0);
                            if (gclass27_0.method_53() != str4)
                              break;
                          }
                          goto label_146;
                        }
                        else
                          goto label_140;
                      case 2378966911:
                        num16 = s == "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]" ? 1 : 0;
                        break;
                      default:
                        num16 = 0;
                        break;
                    }
                    if (num16 == 0)
                      goto label_140;
                  }
                  else
                  {
                    int num17;
                    switch (num11)
                    {
                      case 598952663:
                        if (s == "//android.widget.Button[@content-desc='Share']")
                          goto label_129;
                        else
                          goto label_140;
                      case 630380789:
                        num17 = !(s == "(//*[@content-desc='Photo'])[last()]") ? 1 : 0;
                        break;
                      default:
                        num17 = 1;
                        break;
                    }
                    if (num17 != 0)
                      goto label_140;
                  }
label_136:
                  this.method_184(int_5, str1 + "Tap " + gclass27_0.method_151(str5) + "...");
                  gclass27_0.method_60(str5, str4);
                  switch (str5)
                  {
                    case "//*[@content-desc='Add to story']":
                      flag4 = true;
                      goto label_146;
                    case "//*[@text='Privacy']":
                      gclass27_0.method_31(60, "", "//*[@text='Public']");
                      goto label_146;
                    case "//*[@text='Public']":
                      gclass27_0.method_61(5, "//*[@text='CHANGE' or @text='SAVE']", "");
                      gclass27_0.method_60("//*[@content-desc='Back']", str4);
                      gclass27_0.method_42(60);
                      goto label_146;
                    default:
                      goto label_146;
                  }
label_140:
                  if (gclass27_0.method_31(0, str4, "//*[@content-desc='Stories']"))
                  {
                    Class77 class77 = new Class77(gclass27_0.method_37(0, str4, "//*[@content-desc='Stories']").FirstOrDefault<string>());
                    if (class77.int_3 - class77.int_1 < 200)
                    {
                      gclass27_0.method_66(class77.method_0());
                      goto label_146;
                    }
                  }
                  this.method_184(int_5, str1 + string.Format("({0}/{1}), Scroll...", (object) (num4 + 1), (object) num5));
                  if (gclass27_0.method_78(-1))
                    goto label_144;
label_146:
                  if (str5 != "")
                    list_0_2.Remove(str5);
                  gclass27_0.SleepSeconds(2.0);
                }
                while (Environment.TickCount - tickCount < num8 * 1000);
                goto label_200;
label_92:
                int_4 = 2;
                return num4;
label_107:
                if (num6 >= num7)
                  return num4;
                ++num6;
                continue;
label_129:
                this.method_184(int_5, str1 + "Tap " + gclass27_0.method_151(str5) + "...");
                gclass27_0.method_60(str5, str4);
                gclass27_0.SleepSeconds(2.0);
                if (gclass27_0.method_61(10, "//android.widget.Button[@text='NOT NOW']", ""))
                  this.method_184(int_5, str1 + string.Format("({0}/{1}), Tap Post, ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(12, 15));
                this.method_184(int_5, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " post success...");
                if (flag4)
                {
                  gclass27_0.method_107();
                  gclass27_0.SleepSeconds(3.0);
                }
                if (gclass27_0.method_42(flag3 ? 300 : 60))
                {
                  ++num4;
                  if (num4 >= num5)
                    return num4;
                  goto label_200;
                }
                else
                  goto label_200;
label_144:
                int num18 = this.method_32(gclass27_0, int_5, string_0_1);
                if (num18 != 1 && num18 != 0)
                  return num4;
                goto label_200;
              default:
                List<string> list_0_3 = new List<string>()
                {
                  "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]",
                  "//*[@content-desc='Add to story']",
                  "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*",
                  "(//*[@content-desc='Photo' or @content-desc='Video'])[last()]",
                  "//*[@text='Privacy']",
                  "//*[@text='Public']",
                  "//android.widget.Button[@content-desc='Share']",
                  "//android.widget.ProgressBar"
                };
                this.method_184(int_5, str1 + string.Format("({0}/{1}), Up image...", (object) (num4 + 1), (object) num5));
                this.method_77(gclass27_0, string_0_7, bool_5: bool_5_2);
                string str6;
                string string_11;
                do
                {
                  str6 = gclass27_0.method_53();
                  string_11 = gclass27_0.method_29(0, str6, list_0_3);
                  string s = string_11;
                  // ISSUE: reference to a compiler-generated method
                  uint num19 = Class206.smethod_0(s);
                  if (num19 > 2378966911U)
                  {
                    if (num19 <= 3025215824U)
                    {
                      if (num19 != 2923101247U)
                      {
                        if (num19 != 3025215824U || !(s == "//*[@content-desc='Add to story']"))
                          goto label_190;
                      }
                      else if (s == "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*")
                      {
                        if ((gclass27_0.method_34(str6, "(" + string_11 + ")[1]", "content-desc").FirstOrDefault<string>() ?? "").Contains("music"))
                        {
                          gclass27_0.method_60("(" + string_11 + ")[last()]", str6);
                          goto label_187;
                        }
                        else
                        {
                          gclass27_0.method_60("(" + string_11 + ")[1]", str6);
                          goto label_187;
                        }
                      }
                      else
                        goto label_190;
                    }
                    else if (num19 != 3339772369U)
                    {
                      if (num19 == 3973397389U && s == "(//*[@content-desc='Photo' or @content-desc='Video'])[last()]")
                      {
                        if (gclass27_0.method_31(0, str6, "//*[@content-desc='Stories']"))
                        {
                          Class77 class77 = new Class77(gclass27_0.method_37(0, str6, "//*[@content-desc='Stories']").FirstOrDefault<string>());
                          if (class77.int_3 - class77.int_1 < 200)
                          {
                            gclass27_0.method_66(class77.method_0());
                            goto label_187;
                          }
                        }
                        this.method_184(int_5, str1 + "Tap " + gclass27_0.method_151(string_11) + "...");
                        gclass27_0.method_60(string_11, str6);
                        goto label_187;
                      }
                      else
                        goto label_190;
                    }
                    else if (!(s == "//*[@text='Privacy']"))
                      goto label_190;
                  }
                  else if (num19 <= 532719482U)
                  {
                    if (num19 != 349629914U)
                    {
                      if (num19 == 532719482U && s == "//android.widget.ProgressBar")
                      {
                        this.method_184(int_5, str1 + "Loading...");
                        if (gclass27_0.method_42(60))
                          goto label_187;
                        else
                          goto label_169;
                      }
                      else
                        goto label_190;
                    }
                    else if (!(s == "//*[@text='Public']"))
                      goto label_190;
                  }
                  else if (num19 != 598952663U)
                  {
                    if (num19 != 2378966911U || !(s == "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]"))
                      goto label_190;
                  }
                  else if (s == "//android.widget.Button[@content-desc='Share']")
                    goto label_176;
                  else
                    goto label_190;
                  this.method_184(int_5, str1 + "Tap " + gclass27_0.method_151(string_11) + "...");
                  gclass27_0.method_60(string_11, str6);
                  switch (string_11)
                  {
                    case "//*[@content-desc='Add to story']":
                      flag4 = true;
                      break;
                    case "//*[@text='Privacy']":
                      gclass27_0.method_31(60, "", "//*[@text='Public']");
                      break;
                    case "//*[@text='Public']":
                      gclass27_0.method_61(5, "//*[@text='CHANGE' or @text='SAVE']", "");
                      gclass27_0.method_60("//*[@content-desc='Back']", str6);
                      gclass27_0.method_42(60);
                      break;
                  }
label_187:
                  if (string_11 != "")
                    list_0_3.Remove(string_11);
                  gclass27_0.SleepSeconds(2.0);
                  continue;
label_190:
                  if (gclass27_0.method_31(0, str6, "//*[@content-desc='Stories']"))
                  {
                    Class77 class77 = new Class77(gclass27_0.method_37(0, str6, "//*[@content-desc='Stories']").FirstOrDefault<string>());
                    if (class77.int_3 - class77.int_1 < 200)
                    {
                      gclass27_0.method_66(class77.method_0());
                      goto label_187;
                    }
                  }
                  this.method_184(int_5, str1 + string.Format("({0}/{1}), Scroll...", (object) (num4 + 1), (object) num5));
                  if (gclass27_0.method_78(-1))
                    goto label_194;
                  else
                    goto label_187;
                }
                while (Environment.TickCount - tickCount < num8 * 1000);
                goto label_200;
label_169:
                if (num6 >= num7)
                  return num4;
                ++num6;
                continue;
label_176:
                this.method_184(int_5, str1 + "Tap " + gclass27_0.method_151(string_11) + "...");
                gclass27_0.method_60(string_11, str6);
                gclass27_0.SleepSeconds(2.0);
                if (gclass27_0.method_61(10, "//android.widget.Button[@text='NOT NOW']", ""))
                  this.method_184(int_5, str1 + string.Format("({0}/{1}), Tap Post, ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(12, 15));
                this.method_184(int_5, str1 + string.Format("({0}/{1}), ", (object) (num4 + 1), (object) num5) + GClass35.smethod_0("đợi") + " post success...");
                if (flag4)
                {
                  gclass27_0.method_107();
                  gclass27_0.SleepSeconds(3.0);
                }
                if (gclass27_0.method_42(flag3 ? 300 : 60))
                {
                  ++num4;
                  if (num4 >= num5)
                    return num4;
                  goto label_200;
                }
                else
                  goto label_200;
label_194:
                int num20 = this.method_32(gclass27_0, int_5, string_0_1);
                if (num20 != 1 && num20 != 0)
                  return num4;
                goto label_200;
            }
          }
          catch
          {
            goto label_200;
          }
        }
        break;
      }
    }
    catch
    {
    }
    return num4;
  }

  public int method_121(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int minValue = gclass22_0.method_3("nudSoLuongUidFrom");
    int num1 = gclass22_0.method_3("nudSoLuongUidTo");
    int num2 = gclass22_0.method_3("nudSoLuongBaiVietFrom");
    int num3 = gclass22_0.method_3("nudSoLuongBaiVietTo");
    int int_4_1 = gclass22_0.method_3("nudDelayFrom");
    int int_5 = gclass22_0.method_3("nudDelayTo");
    int num4 = gclass22_0.method_3("typeID");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    string string_1_1 = gclass22_0.method_1("typeReaction");
    bool bool_7 = gclass22_0.method_4("ckbShareWall");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_0 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool flag = gclass22_0.method_4("ckbTuDongXoaUid");
    bool bool_8 = gclass22_0.method_4("ckbAnh");
    string string_2_1 = gclass22_0.method_1("txtPathAnh");
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = new List<string>();
    if (!flag)
      stringList2 = this.method_101(this.dictionary_16[string_2]);
    List<string> stringList3 = new List<string>();
    List<string> list_18 = GClass19.smethod_39(list_0);
    this.method_101(list_18);
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num5 = this.random_0.Next(minValue, num1 + 1);
      for (int index1 = 0; index1 < num5; ++index1)
      {
        string str = "";
        if (flag)
        {
          lock (this.dictionary_16)
          {
            if (this.dictionary_16[string_2].Count != 0)
            {
              int index2 = this.random_0.Next(0, this.dictionary_16[string_2].Count);
              str = this.dictionary_16[string_2][index2];
              this.dictionary_16[string_2].RemoveAt(index2);
            }
            else
              break;
          }
        }
        else if (stringList2.Count != 0)
        {
          str = stringList2[this.random_0.Next(0, stringList2.Count)];
          stringList2.Remove(str);
        }
        else
          break;
        string string_1_2 = "";
        switch (num4)
        {
          case 0:
            string_1_2 = "fb://profile/" + str;
            break;
          case 1:
            string_1_2 = "fb://group/" + str;
            break;
          case 2:
            string_1_2 = str;
            break;
          case 3:
            string_1_2 = !str.StartsWith("1000") ? "fb://page/" + str : "fb://profile/" + str;
            break;
        }
        if (this.method_215(gclass27_0, int_4, string_0_1, string_1_2))
        {
          if (string_1_2.Contains("page"))
          {
            gclass27_0.method_60("//*[contains(@content-desc,\"Posts, Tab\")]");
            gclass27_0.SleepSeconds(2.0);
          }
          this.method_107(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) (index1 + 1), (object) num5), gclass27_0, num2, num3, bool_5, string_1_1, num2, num3, bool_6, num2, num3, list_18, bool_7, 0, 0, 1, bool_8, string_2_1);
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), delay {{time}}s...", (object) (index1 + 1), (object) num5), gclass27_0.method_87(int_4_1, int_5));
        }
        else
          break;
      }
    }
    catch
    {
    }
    return 0;
  }

  public int method_122(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    List<string> list_0_1 = gclass22_0.method_2("txtTuKhoa");
    int num1 = gclass22_0.method_3("nudSoLuongBaiVietFrom");
    int num2 = gclass22_0.method_3("nudSoLuongBaiVietTo");
    int int_14 = gclass22_0.method_3("nudDelayFrom");
    int int_15 = gclass22_0.method_3("nudDelayTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    string string_1_1 = gclass22_0.method_1("typeReaction");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_0_2 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_8 = gclass22_0.method_4("ckbAnh");
    string string_2_1 = gclass22_0.method_1("txtPathAnh");
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = new List<string>();
    List<string> list_18 = GClass19.smethod_39(list_0_2);
    this.method_101(list_18);
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      List<string> stringList3 = GClass19.smethod_39(list_0_1);
      string string_11 = GClass19.smethod_28(stringList3[this.random_0.Next(0, stringList3.Count)], this.random_0);
      this.method_184(int_4, string_0_1 + "Search Post...");
      if (gclass27_0.method_108(string_11, "Posts"))
        this.method_107(int_4, string_0_1, gclass27_0, num1, num2, bool_5, string_1_1, num1, num2, bool_6, num1, num2, list_18, false, 0, 0, 1, bool_8, string_2_1, int_14, int_15);
    }
    catch
    {
    }
    return 0;
  }

  public int method_123(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int minValue = gclass22_0.method_3("nudSoLuongUidFrom");
    int num1 = gclass22_0.method_3("nudSoLuongUidTo");
    int num2 = gclass22_0.method_3("nudSoLuongBaiVietFrom");
    int num3 = gclass22_0.method_3("nudSoLuongBaiVietTo");
    int int_4_1 = gclass22_0.method_3("nudDelayFrom");
    int int_5 = gclass22_0.method_3("nudDelayTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    string string_1_1 = gclass22_0.method_1("typeReaction");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_0_1 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_8 = gclass22_0.method_4("ckbAnh");
    string string_2_1 = gclass22_0.method_1("txtPathAnh");
    List<string> list_18 = GClass19.smethod_39(list_0_1);
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num4 = this.random_0.Next(minValue, num1 + 1);
      for (int index = 0; index < num4; ++index)
      {
label_12:
        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Go to Group...", (object) (index + 1), (object) num4));
        if (this.method_215(gclass27_0, int_4, string_0_1, "fb://faceweb/f?href=https://m.facebook.com/groups_browse/your_groups/"))
        {
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Group...", (object) (index + 1), (object) num4));
          List<string> list_0_2 = gclass27_0.method_37(3, "", "//android.view.View[starts-with(@content-desc,\"group image link\") or starts-with(@text,\"group image link\")]");
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Group: ", (object) (index + 1), (object) num4) + list_0_2.Count.ToString());
          if (list_0_2.Count != 0)
          {
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) (index + 1), (object) num4));
            int num5 = 0;
            if (list_0_2.Count >= 9)
            {
              while (!gclass27_0.method_78())
              {
                ++num5;
                if (num5 >= 5)
                  break;
              }
              int num6 = gclass27_0.method_87(0, (num5 < 1 ? 1 : num5) - 1);
              int num7 = 0;
              while (num7 < num6 && !gclass27_0.method_78(-1))
                ++num7;
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Group...", (object) (index + 1), (object) num4));
              list_0_2 = gclass27_0.method_37(3, "", "//android.view.View[starts-with(@content-desc,\"group image link\") or starts-with(@text,\"group image link\")]");
            }
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Group...", (object) (index + 1), (object) num4));
            gclass27_0.method_66(list_0_2.smethod_10());
            gclass27_0.method_80(2.0, 3.0);
            switch (this.method_32(gclass27_0, int_4, string_0))
            {
              case 0:
                this.method_107(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) (index + 1), (object) num4), gclass27_0, num2, num3, bool_5, string_1_1, num2, num3, bool_6, num2, num3, list_18, false, 0, 0, 1, bool_8, string_2_1);
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), delay {{time}}s...", (object) (index + 1), (object) num4), gclass27_0.method_87(int_4_1, int_5));
                continue;
              case 1:
                goto label_12;
              default:
                goto label_15;
            }
          }
          else
            break;
        }
        else
          break;
      }
    }
    catch
    {
    }
label_15:
    return 0;
  }

  public int method_124(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int minValue = gclass22_0.method_3("nudSoLuongUidFrom");
    int num1 = gclass22_0.method_3("nudSoLuongUidTo");
    int num2 = gclass22_0.method_3("nudSoLuongBaiVietFrom");
    int num3 = gclass22_0.method_3("nudSoLuongBaiVietTo");
    int int_4_1 = gclass22_0.method_3("nudDelayFrom");
    int int_5 = gclass22_0.method_3("nudDelayTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    string string_1_1 = gclass22_0.method_1("typeReaction");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_0_1 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_8 = gclass22_0.method_4("ckbAnh");
    string string_2_1 = gclass22_0.method_1("txtPathAnh");
    List<string> list_18 = GClass19.smethod_39(list_0_1);
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      int num4 = this.random_0.Next(minValue, num1 + 1);
      for (int index = 0; index < num4; ++index)
      {
label_12:
        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Go to Friend...", (object) (index + 1), (object) num4));
        if (this.method_215(gclass27_0, int_4, string_0_1, "fb://friends"))
        {
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Friend...", (object) (index + 1), (object) num4));
          List<string> list_0_2 = gclass27_0.method_37(3, "", "//android.view.View[contains(@content-desc,\", profile picture\") or contains(@text,\", profile picture\")]");
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Friend: ", (object) (index + 1), (object) num4) + list_0_2.Count.ToString());
          if (list_0_2.Count != 0)
          {
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Scroll...", (object) (index + 1), (object) num4));
            int num5 = 0;
            if (list_0_2.Count >= 6)
            {
              while (!gclass27_0.method_78())
              {
                ++num5;
                if (num5 >= 5)
                  break;
              }
              int num6 = gclass27_0.method_87(0, (num5 < 1 ? 1 : num5) - 1);
              int num7 = 0;
              while (num7 < num6 && !gclass27_0.method_78(-1))
                ++num7;
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Friend...", (object) (index + 1), (object) num4));
              list_0_2 = gclass27_0.method_37(3, "", "//android.view.View[contains(@content-desc,\", profile picture\") or contains(@text,\", profile picture\")]");
            }
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Friend...", (object) (index + 1), (object) num4));
            gclass27_0.method_66(list_0_2.smethod_10());
            gclass27_0.method_80(2.0, 3.0);
            switch (this.method_32(gclass27_0, int_4, string_0))
            {
              case 0:
                this.method_107(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) (index + 1), (object) num4), gclass27_0, num2, num3, bool_5, string_1_1, num2, num3, bool_6, num2, num3, list_18, false, 0, 0, 1, bool_8, string_2_1);
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), delay {{time}}s...", (object) (index + 1), (object) num4), gclass27_0.method_87(int_4_1, int_5));
                continue;
              case 1:
                goto label_12;
              default:
                goto label_15;
            }
          }
          else
            break;
        }
        else
          break;
      }
    }
    catch
    {
    }
label_15:
    return 0;
  }

  public int method_125(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1)
  {
    int num1 = gclass22_0.method_3("nudSoLuongBaiVietFrom");
    int num2 = gclass22_0.method_3("nudSoLuongBaiVietTo");
    int int_14 = gclass22_0.method_3("nudDelayFrom");
    int int_15 = gclass22_0.method_3("nudDelayTo");
    bool bool_5 = gclass22_0.method_4("ckbInteract");
    string string_1_1 = gclass22_0.method_1("typeReaction");
    bool bool_6 = gclass22_0.method_4("ckbComment");
    List<string> list_0 = gclass22_0.method_2("txtComment", gclass22_0.method_3("typeNganCach"));
    bool bool_8 = gclass22_0.method_4("ckbAnh");
    string string_2 = gclass22_0.method_1("txtPathAnh");
    List<string> list_18 = GClass19.smethod_39(list_0);
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_1 + ": ";
      gclass27_0.method_107();
      gclass27_0.method_80(1.0, 2.0);
      this.method_107(int_4, string_0_1, gclass27_0, num1, num2, bool_5, string_1_1, num1, num2, bool_6, num1, num2, list_18, false, 0, 0, 1, bool_8, string_2, int_14, int_15);
    }
    catch
    {
    }
    return 0;
  }

  public int method_126(
    int int_4,
    string string_0,
    GClass18 gclass18_0,
    int int_5,
    int int_6,
    int int_7,
    int int_8,
    int int_9,
    int int_10,
    bool bool_5,
    List<string> list_18,
    Random random_1,
    string string_1 = "",
    bool bool_6 = false,
    string string_2 = "",
    bool bool_7 = false,
    string string_3 = "",
    bool bool_8 = false,
    int int_11 = 0,
    bool bool_9 = false,
    bool bool_10 = false,
    List<string> list_19 = null,
    int int_12 = 0)
  {
    string string_0_1 = this.method_191(int_4, "cUid");
    string string_1_1 = this.method_191(int_4, "cPassword");
    string string_2_1 = this.method_191(int_4, "cFa2");
    int num1 = 0;
    List<string> stringList1 = new List<string>();
    list_18 = GClass19.smethod_39(list_18);
    List<string> stringList2 = this.method_101(list_18);
    List<string> list_18_1 = new List<string>();
    List<string> stringList3 = new List<string>();
    if (bool_6)
    {
      list_18_1 = ((IEnumerable<string>) Directory.GetFiles(string_2)).ToList<string>();
      stringList3 = this.method_101(list_18_1);
    }
    List<string> stringList4 = new List<string>();
    if (!bool_7)
      stringList4 = this.method_101(this.dictionary_2[string_3]);
    try
    {
      int num2 = random_1.Next(int_5, int_6 + 1);
      for (int index1 = 0; index1 < num2; ++index1)
      {
        string str1 = "";
        if (bool_7)
        {
          lock (this.dictionary_2)
          {
            if (this.dictionary_2[string_3].Count != 0)
            {
              str1 = this.dictionary_2[string_3][random_1.Next(0, this.dictionary_2[string_3].Count)];
              this.dictionary_2[string_3].Remove(str1);
            }
            else
              break;
          }
        }
        else if (stringList4.Count != 0)
        {
          str1 = stringList4[random_1.Next(0, stringList4.Count)];
          stringList4.Remove(str1);
        }
        else
          break;
        if (bool_8 && int_11 == 0)
        {
          int num3;
          do
          {
            gclass18_0.method_12("https://m.facebook.com/" + str1);
            gclass18_0.method_56(2.0);
            num3 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2_1);
          }
          while (num3 == 1);
          if (new List<int>() { -3, -2, -1, 2 }.Contains(num3))
            return -1;
          string newValue = gclass18_0.method_20("return document.documentElement.innerHTML.match(new RegExp('<title>(.*?)</title>'))[1]").ToString().Split('-')[0].Trim();
          int num4 = 0;
          int int_6_1 = 0;
          if (gclass18_0.method_39(string.Format("document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}]", (object) 0)) == 1)
          {
            int num5 = 0;
            if (Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')!=null)+''", (object) int_6_1))) || Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''", (object) int_6_1))) || Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-sigil=\"share-popup\"]')!=null)+''", (object) int_6_1))))
              ++num5;
            if (gclass18_0.method_3())
              return -2;
            gclass18_0.method_44("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + int_6_1.ToString() + "]");
            this.method_102(3);
            if (bool_9 && Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')!=null)+''", (object) int_6_1))))
            {
              gclass18_0.method_44("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + int_6_1.ToString() + "].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')");
              ++num5;
              if (Convert.ToBoolean(gclass18_0.method_20(string.Format("var output='false';var x=document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a');  if(x!=null) output=(JSON.parse(x.getAttribute('data-store')).reaction==0)+''; return output;", (object) int_6_1)).ToString()))
              {
                this.method_102();
                gclass18_0.method_21(4, "[data-store*=\"linkdata\"]", int_6_1, 4, "[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a");
                this.method_102();
              }
            }
            if (bool_10 && Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''", (object) int_6_1))))
            {
              num4 = num5 + 1;
              gclass18_0.method_21(4, "[data-store*=\"linkdata\"]", int_6_1, 4, "[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]");
              this.method_102();
              if (gclass18_0.method_38("[data-sigil=\"textarea mufi-composer m-textarea-input\"]", 5.0) == 1)
              {
                this.method_102();
                gclass18_0.method_44("document.querySelector('[data-sigil =\"textarea mufi-composer m-textarea-input\"]')");
                this.method_102();
                List<string> stringList5 = new List<string>();
                if (stringList5.Count == 0)
                  stringList5 = this.method_101(list_19);
                string string_0_2 = stringList5[random_1.Next(0, stringList5.Count)];
                stringList5.Remove(string_0_2);
                string str2 = GClass19.smethod_28(string_0_2, random_1).Replace("[u]", newValue);
                gclass18_0.method_26(4, "[data-sigil =\"textarea mufi-composer m-textarea-input\"]", str2 + " ", 0.1);
                this.method_102(3);
                for (int index2 = 0; index2 < 10 && gclass18_0.method_21(2, "submit") != 1; ++index2)
                  GClass19.smethod_64(1.0);
                this.method_102(2);
              }
              gclass18_0.method_16();
              this.method_102();
            }
          }
        }
        int num6;
        do
        {
          gclass18_0.method_12("https://m.facebook.com/messages/read/?fbid=" + str1);
          this.method_102();
          num6 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2_1);
        }
        while (num6 == 1);
        if (new List<int>() { -3, -2, -1, 2 }.Contains(num6))
          return -1;
        if (gclass18_0.method_38("[name=\"body\"]", 10.0) == 1)
        {
          if (bool_6)
          {
            int num7 = random_1.Next(int_7, int_8 + 1);
            int int32 = Convert.ToInt32(gclass18_0.method_20("return document.querySelectorAll('[data-sigil=\"touchable\"]>img').length"));
            if (gclass18_0.method_38("[data-sigil=\"m-raw-file-input\"]") == 1)
            {
              for (int index3 = 0; index3 < num7; ++index3)
              {
                if (stringList3.Count == 0)
                  stringList3 = this.method_101(list_18_1);
                string string_8 = stringList3[random_1.Next(0, stringList3.Count)];
                stringList3.Remove(string_8);
                gclass18_0.method_24(4, "[data-sigil=\"m-raw-file-input\"]", string_8);
                gclass18_0.method_56(1.0);
              }
            }
            for (int index4 = 0; index4 < 60 && Convert.ToInt32(gclass18_0.method_20("return document.querySelectorAll('[data-sigil=\"touchable\"]>img').length")) < num7 + int32; ++index4)
              gclass18_0.method_56(1.0);
            this.method_102();
          }
          if (bool_5)
          {
            if (stringList2.Count == 0)
              stringList2 = this.method_101(list_18);
            string string_0_3 = stringList2[random_1.Next(0, stringList2.Count)];
            stringList2.Remove(string_0_3);
            string string_8 = GClass19.smethod_28(string_0_3, random_1).Replace("[u]", gclass18_0.method_20("return document.querySelector('[data-sigil=\" token\"]').innerText.replace('×','').trim()").ToString());
            gclass18_0.method_29(GClass33.smethod_0("configGeneral").method_3("tocDoGoVanBan"), 4, "[name=\"body\"]", string_8, 0.1);
            this.method_102();
          }
          if (gclass18_0.method_41(5.0, "[name=\"Send\"]", "[name=\"send\"]") == 1)
            gclass18_0.method_21(4, "[name=\"Send\"]");
          else
            gclass18_0.method_21(4, "[name=\"send\"]");
          this.method_102();
          ++num1;
          this.method_184(int_4, string_0 + GClass35.smethod_0("Đang") + string.Format(" {0} ({1}/{2})...", (object) string_1, (object) num1, (object) num2));
          if (gclass18_0.method_3())
            return -2;
          gclass18_0.method_56((double) random_1.Next(int_9, int_10 + 1));
          if (bool_8 && int_11 == 1)
          {
            int num8;
            do
            {
              gclass18_0.method_12("https://m.facebook.com/" + str1);
              gclass18_0.method_56(2.0);
              num8 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2_1);
            }
            while (num8 == 1);
            if (new List<int>() { -3, -2, -1, 2 }.Contains(num8))
              return -1;
            string newValue = gclass18_0.method_20("return document.documentElement.innerHTML.match(new RegExp('<title>(.*?)</title>'))[1]").ToString().Split('-')[0].Trim();
            int num9 = 0;
            int int_6_2 = 0;
            if (gclass18_0.method_39(string.Format("document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}]", (object) 0)) == 1)
            {
              int num10 = 0;
              if (Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')!=null)+''", (object) int_6_2))) || Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''", (object) int_6_2))) || Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-sigil=\"share-popup\"]')!=null)+''", (object) int_6_2))))
                ++num10;
              if (gclass18_0.method_3())
                return -2;
              gclass18_0.method_44("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + int_6_2.ToString() + "]");
              this.method_102(3);
              if (bool_9 && Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')!=null)+''", (object) int_6_2))))
              {
                gclass18_0.method_44("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + int_6_2.ToString() + "].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')");
                ++num10;
                if (Convert.ToBoolean(gclass18_0.method_20(string.Format("var output='false';var x=document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a');  if(x!=null) output=(JSON.parse(x.getAttribute('data-store')).reaction==0)+''; return output;", (object) int_6_2)).ToString()))
                {
                  this.method_102();
                  gclass18_0.method_21(4, "[data-store*=\"linkdata\"]", int_6_2, 4, "[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a");
                  this.method_102();
                }
              }
              if (bool_10 && Convert.ToBoolean(gclass18_0.method_20(string.Format("return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''", (object) int_6_2))))
              {
                num9 = num10 + 1;
                gclass18_0.method_21(4, "[data-store*=\"linkdata\"]", int_6_2, 4, "[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]");
                this.method_102();
                if (gclass18_0.method_38("[data-sigil=\"textarea mufi-composer m-textarea-input\"]", 5.0) == 1)
                {
                  this.method_102();
                  gclass18_0.method_44("document.querySelector('[data-sigil =\"textarea mufi-composer m-textarea-input\"]')");
                  this.method_102();
                  List<string> stringList6 = new List<string>();
                  if (stringList6.Count == 0)
                    stringList6 = this.method_101(list_19);
                  string string_0_4 = stringList6[random_1.Next(0, stringList6.Count)];
                  stringList6.Remove(string_0_4);
                  string str3 = GClass19.smethod_28(string_0_4, random_1).Replace("[u]", newValue);
                  gclass18_0.method_26(4, "[data-sigil =\"textarea mufi-composer m-textarea-input\"]", str3 + " ", 0.1);
                  this.method_102(3);
                  for (int index5 = 0; index5 < 10 && gclass18_0.method_21(2, "submit") != 1; ++index5)
                    GClass19.smethod_64(1.0);
                  this.method_102(2);
                }
                gclass18_0.method_16();
                this.method_102();
              }
            }
          }
        }
      }
    }
    catch
    {
      num1 = -1;
    }
    return num1;
  }

  public int method_127(
    int int_4,
    string string_0,
    GClass18 gclass18_0,
    int int_5,
    int int_6,
    List<string> list_18,
    int int_7,
    int int_8,
    Random random_1,
    string string_1 = "")
  {
    string string_0_1 = this.method_191(int_4, "cUid");
    string string_1_1 = this.method_191(int_4, "cPassword");
    string string_2 = this.method_191(int_4, "cFa2");
    int num1 = 0;
    try
    {
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = this.method_101(list_18);
      int num2 = random_1.Next(int_5, int_6 + 1);
      if (num2 != 0)
      {
label_29:
        int num3;
        do
        {
          if (GClass20.smethod_7(gclass18_0) != -2)
            num3 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2);
          else
            goto label_28;
        }
        while (num3 == 1);
        if (new List<int>() { -3, -2, -1, 2 }.Contains(num3))
          return -1;
        GClass20.smethod_21(gclass18_0);
        while (true)
        {
          int num4 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2);
          if (num4 != 1)
          {
            if (!new List<int>() { -3, -2, -1, 2 }.Contains(num4))
            {
              int maxValue = gclass18_0.method_37("[data-sigil=\"undoable-action\"]");
              if (maxValue > 0)
              {
                int int_6_1 = Class54.random_0.Next(0, maxValue);
                gclass18_0.method_44("document.querySelectorAll('[data-sigil=\"undoable-action\"]>div:nth-child(1)>a')[" + int_6_1.ToString() + "]");
                this.method_102();
                gclass18_0.method_21(4, "[data-sigil=\"undoable-action\"]>div:nth-child(1)>a", int_6_1);
                this.method_102(2);
                if (gclass18_0.method_38("[data-sigil=\"hq-profile-logging-action-bar-button\"]>a", 3.0) == 1)
                {
                  GClass20.smethod_21(gclass18_0);
                  gclass18_0.method_44("document.querySelector('[data-sigil=\"hq-profile-logging-action-bar-button\"]>a')");
                  this.method_102();
                  gclass18_0.method_21(4, "[data-sigil=\"hq-profile-logging-action-bar-button\"]>a");
                  this.method_102(2);
                  if (gclass18_0.method_38("[name=\"body\"]", 5.0) == 1)
                  {
                    if (stringList2.Count == 0)
                      stringList2 = this.method_101(list_18);
                    string string_0_2 = stringList2[random_1.Next(0, stringList2.Count)];
                    stringList2.Remove(string_0_2);
                    string string_8 = GClass19.smethod_28(string_0_2, random_1).Replace("[u]", gclass18_0.method_20("return document.querySelector('[data-sigil=\" token\"]').innerText.replace('×','').trim()").ToString());
                    this.method_102();
                    switch (GClass33.smethod_0("configGeneral").method_3("tocDoGoVanBan"))
                    {
                      case 0:
                        gclass18_0.method_28(Class54.random_0, 4, "[name=\"body\"]", string_8, 0.1);
                        break;
                      case 1:
                        gclass18_0.method_26(4, "[name=\"body\"]", string_8, 0.1);
                        break;
                      case 2:
                        gclass18_0.method_24(4, "[name=\"body\"]", string_8);
                        break;
                    }
                    this.method_102();
                    if (gclass18_0.method_41(5.0, "[name=\"Send\"]", "[name=\"send\"]") == 1)
                      gclass18_0.method_21(4, "[name=\"Send\"]");
                    else
                      gclass18_0.method_21(4, "[name=\"send\"]");
                    this.method_102();
                    ++num1;
                    this.method_184(int_4, string_0 + GClass35.smethod_0("Đang") + string.Format(" {0} ({1}/{2})...", (object) string_1, (object) num1, (object) num2));
                    if (!gclass18_0.method_3())
                    {
                      gclass18_0.method_56((double) random_1.Next(int_7, int_8 + 1));
                      if (num1 >= num2)
                        goto label_22;
                    }
                    else
                      goto label_20;
                  }
                  gclass18_0.method_16();
                  gclass18_0.method_31();
                  gclass18_0.method_16();
                  gclass18_0.method_31();
                  if (gclass18_0.method_38("[data-sigil=\"undoable-action\"]") != 1)
                  {
                    gclass18_0.method_16();
                    gclass18_0.method_31();
                    if (gclass18_0.method_38("[data-sigil=\"undoable-action\"]") != 1)
                      goto label_29;
                  }
                }
                else
                  goto label_22;
              }
              else
                goto label_31;
            }
            else
              break;
          }
          else
            goto label_29;
        }
        return -1;
label_20:
        return -2;
label_22:
        goto label_31;
label_28:
        return -2;
      }
    }
    catch
    {
      num1 = -1;
    }
label_31:
    return num1;
  }

  public int method_128(
    int int_4,
    string string_0,
    GClass18 gclass18_0,
    string string_1,
    string string_2,
    int int_5,
    int int_6,
    List<string> list_18,
    int int_7,
    int int_8,
    string string_3,
    int int_9,
    Random random_1,
    string string_4 = "",
    int int_10 = 0,
    List<string> list_19 = null)
  {
    string string_0_1 = this.method_191(int_4, "cUid");
    string string_1_1 = this.method_191(int_4, "cPassword");
    string string_2_1 = this.method_191(int_4, "cFa2");
    int num1 = 0;
    try
    {
      List<string> stringList1 = new List<string>();
      if (int_10 == 0)
      {
        this.method_127(int_4, string_0, gclass18_0, int_5, int_6, list_18, int_7, int_8, random_1, string_4);
      }
      else
      {
        List<string> stringList2 = this.method_101(list_19);
        List<string> stringList3 = new List<string>();
        List<string> stringList4 = this.method_101(list_18);
        int count = stringList2.Count;
        int num2 = 0;
        int num3 = random_1.Next(int_5, int_6 + 1);
        for (int index = 0; index < count && num2 != num3; ++index)
        {
          ++num2;
          if (stringList4.Count == 0)
            stringList4 = this.method_101(list_18);
          string string_0_2 = stringList4[random_1.Next(0, stringList4.Count)];
          string str = stringList2[random_1.Next(0, stringList2.Count)];
          stringList2.Remove(str);
          stringList4.Remove(string_0_2);
          string string_8 = GClass19.smethod_28(string_0_2, random_1);
          int num4;
          do
          {
            gclass18_0.method_12("https://m.facebook.com/messages/read/?fbid=" + str);
            this.method_102(2);
            num4 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2_1);
          }
          while (num4 == 1);
          if (new List<int>() { -3, -2, -1, 2 }.Contains(num4))
            return -1;
          if (gclass18_0.method_38("[name=\"body\"]", 5.0) == 1)
          {
            this.method_102();
            gclass18_0.method_29(GClass33.smethod_0("configGeneral").method_3("tocDoGoVanBan"), 4, "[name=\"body\"]", string_8, 0.1);
            this.method_102();
            if (gclass18_0.method_41(5.0, "[name=\"Send\"]", "[name=\"send\"]") == 1)
              gclass18_0.method_21(4, "[name=\"Send\"]");
            else
              gclass18_0.method_21(4, "[name=\"send\"]");
            this.method_102();
            if (string_4 == "")
              this.method_184(int_4, string_0 + GClass35.smethod_0("Đang nhắn tin bạn bè") + string.Format(" ({0}/{1})...", (object) num2, (object) num3));
            else
              this.method_184(int_4, string_0 + GClass35.smethod_0("Đang") + string.Format(" {0} ({1}/{2})...", (object) string_4, (object) num2, (object) num3));
            gclass18_0.method_56((double) random_1.Next(int_7, int_8 + 1));
          }
        }
      }
    }
    catch
    {
      num1 = -1;
    }
    return num1;
  }

  public int method_129(
    int int_4,
    string string_0,
    GClass18 gclass18_0,
    int int_5,
    int int_6,
    int int_7,
    int int_8,
    Random random_1,
    string string_1 = "")
  {
    string string_0_1 = this.method_191(int_4, "cUid");
    string string_1_1 = this.method_191(int_4, "cPassword");
    string string_2 = this.method_191(int_4, "cFa2");
    int num1 = 0;
    int num2 = 0;
    try
    {
label_18:
label_2:
      while (GClass20.smethod_20(gclass18_0) != -2)
      {
        int num3 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2);
        if (num3 != 1)
        {
          if (new List<int>() { -3, -2, -1, 2 }.Contains(num3))
            return -1;
          int num4 = random_1.Next(int_5, int_6 + 1);
          while (num1 < num4)
          {
            int num5 = this.method_92(gclass18_0, string_0_1, string_1_1, string_2);
            if (num5 != 1)
            {
              if (new List<int>() { -3, -2, -1, 2 }.Contains(num5))
                return -1;
              if (gclass18_0.method_38("[data-sigil=\"touchable ajaxify\"]", 5.0) == 1)
              {
                num2 = 0;
                gclass18_0.method_44("document.querySelector('[data-sigil=\"touchable ajaxify\"]')");
                this.method_102();
                gclass18_0.method_21(4, "[data-sigil=\"touchable ajaxify\"]");
                ++num1;
                this.method_102(2);
                if (string_1 == "")
                  this.method_184(int_4, string_0 + GClass35.smethod_0("Đang chọc bạn bè") + string.Format(" ({0}/{1})...", (object) num1, (object) num4));
                else
                  this.method_184(int_4, string_0 + GClass35.smethod_0("Đang") + string.Format(" {0} ({1}/{2})...", (object) string_1, (object) num1, (object) num4));
                gclass18_0.method_56((double) random_1.Next(int_7, int_8 + 1));
              }
              else
              {
                gclass18_0.method_15();
                ++num2;
                if (num2 == 2)
                  break;
              }
            }
            else
              goto label_2;
          }
          goto label_20;
        }
        else
          goto label_18;
      }
      return -2;
    }
    catch
    {
      num1 = -1;
    }
label_20:
    return num1;
  }

  private int method_130(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int int_4_1 = gclass22_0.method_3("nudSoLuongFrom");
    int int_5_1 = gclass22_0.method_3("nudSoLuongTo");
    int minValue = gclass22_0.method_3("nudDelayFrom");
    int num1 = gclass22_0.method_3("nudDelayTo");
    bool flag1 = gclass22_0.method_4("ckbTuongTac");
    int int_5_2 = gclass22_0.method_3("nudTimeFrom");
    int int_6 = gclass22_0.method_3("nudTimeTo");
    bool bool_5 = gclass22_0.method_4("ckbTuongTacLike");
    int int_7 = gclass22_0.method_3("nudCountLikeFrom");
    int int_8 = gclass22_0.method_3("nudCountLikeTo");
    bool bool_6 = gclass22_0.method_4("ckbTuongTacComment");
    List<string> list_18 = gclass22_0.method_2("txtComment");
    int int_9 = gclass22_0.method_3("nudCountCommentFrom");
    int int_10 = gclass22_0.method_3("nudCountCommentTo");
    bool flag2 = gclass22_0.method_4("ckbTuDongXoaUid");
    int num2 = 0;
    int num3 = gclass27_0.method_87(int_4_1, int_5_1);
    string str1 = "";
    List<string> stringList = new List<string>();
    if (!flag2)
      stringList = GClass19.smethod_27(this.dictionary_1[string_1]);
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_2 + ": ";
      int num4 = 0;
      int num5 = 0;
      int num6 = 3;
      for (int index = 0; index < num3 + 10; ++index)
      {
        if (!flag2)
        {
          if (stringList.Count != 0)
          {
            str1 = stringList[this.random_0.Next(0, stringList.Count)];
            stringList.Remove(str1);
          }
          else
            break;
        }
        else
        {
          lock (this.dictionary_1)
          {
            if (this.dictionary_1[string_1].Count != 0)
            {
              str1 = this.dictionary_1[string_1][this.random_0.Next(0, this.dictionary_1[string_1].Count)];
              this.dictionary_1[string_1].Remove(str1);
            }
            else
              break;
          }
        }
        bool flag3 = false;
label_61:
        while (true)
        {
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Go to Profile {2}...", (object) num4, (object) num3, (object) str1));
          if (this.method_215(gclass27_0, int_4, string_0_1, "fb://profile/" + str1))
          {
            int num7 = 0;
            int num8 = 6;
            int tickCount1 = Environment.TickCount;
            do
            {
              string str2 = gclass27_0.method_53();
              string string_11_1 = gclass27_0.method_29(0, str2, new List<string>()
              {
                "//android.widget.ProgressBar",
                "//*[@text='Find More Friends']",
                "//*[@text='Tap to retry']",
                "//*[@content-desc='Reload page']",
                "//*[@content-desc='Add Friend']",
                "//*[@text='Does this person know you?']",
                "//*[@content-desc='Requested']",
                "//*[@content-desc='Respond']",
                "//*[@content-desc='Friends']",
                "//*[@text='Your friend request is on the way!']"
              });
              string s = string_11_1;
              // ISSUE: reference to a compiler-generated method
              uint num9 = Class206.smethod_0(s);
              if (num9 > 1346668722U)
              {
                if (num9 > 2271211187U)
                {
                  int num10;
                  switch (num9)
                  {
                    case 2497527736:
                      if (s == "//*[@content-desc='Add Friend']")
                      {
                        if (!flag1)
                        {
                          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3) + "Tap " + gclass27_0.method_151(string_11_1) + "...");
                          gclass27_0.method_60(string_11_1, str2);
                          flag3 = true;
                          goto label_52;
                        }
                        else
                          goto label_59;
                      }
                      else
                        goto label_50;
                    case 2820186270:
                      if (!(s == "//*[@content-desc='Respond']"))
                        goto label_50;
                      else
                        goto label_54;
                    case 3367448010:
                      num10 = s == "//*[@text='Does this person know you?']" ? 1 : 0;
                      break;
                    default:
                      num10 = 0;
                      break;
                  }
                  if (num10 != 0)
                  {
                    string string_11_2 = "//*[@text='CONFIRM']";
                    this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3) + "Tap " + gclass27_0.method_151(string_11_2) + "...");
                    gclass27_0.method_60(string_11_2, str2);
                    goto label_52;
                  }
                }
                else
                {
                  int num11;
                  switch (num9)
                  {
                    case 1601492691:
                      if (s == "//*[@text='Your friend request is on the way!']")
                      {
                        string string_11_3 = "//*[@content-desc='Close']";
                        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3) + "Tap " + gclass27_0.method_151(string_11_3) + "...");
                        gclass27_0.method_60(string_11_3, str2);
                        goto label_52;
                      }
                      else
                        goto label_50;
                    case 2271211187:
                      num11 = !(s == "//*[@content-desc='Reload page']") ? 1 : 0;
                      break;
                    default:
                      num11 = 1;
                      break;
                  }
                  if (num11 == 0)
                  {
                    if (num7 < num8)
                    {
                      ++num7;
                      this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3) + "Tap " + gclass27_0.method_151(string_11_1) + "...");
                      gclass27_0.method_60(string_11_1, str2);
                      goto label_52;
                    }
                    else
                      break;
                  }
                }
              }
              else if (s == "//*[@text='Find More Friends']")
              {
                string string_11_4 = "//*[@content-desc='Close']";
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3) + "Tap " + gclass27_0.method_151(string_11_4) + "...");
                gclass27_0.method_60(string_11_4, str2);
                flag3 = true;
                goto label_52;
              }
              else if (num9 > 532719482U)
              {
                int num12;
                switch (num9)
                {
                  case 641677479:
                    if (s == "//*[@content-desc='Requested']")
                      goto label_54;
                    else
                      goto label_50;
                  case 1346668722:
                    num12 = !(s == "//*[@content-desc='Friends']") ? 1 : 0;
                    break;
                  default:
                    num12 = 1;
                    break;
                }
                if (num12 == 0)
                  break;
              }
              else
              {
                int num13;
                switch (num9)
                {
                  case 281629319:
                    if (s == "//*[@text='Tap to retry']")
                    {
                      if (num7 < num8)
                      {
                        ++num7;
                        gclass27_0.method_78(-1);
                        goto label_49;
                      }
                      else
                        goto label_64;
                    }
                    else
                      goto label_50;
                  case 532719482:
                    num13 = !(s == "//android.widget.ProgressBar") ? 1 : 0;
                    break;
                  default:
                    num13 = 1;
                    break;
                }
                if (num13 == 0)
                  this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3) + "Loading...");
                else
                  goto label_50;
label_49:
                goto label_52;
              }
label_50:
              if (!gclass27_0.method_146(str2, "There was a problem sending your friend request. Please try again later"))
              {
                this.method_184(int_4, string_0_1 + string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3) + "Scroll...");
                if (gclass27_0.method_78())
                  goto label_60;
              }
              else
                break;
label_52:
              gclass27_0.SleepSeconds(2.0);
            }
            while (Environment.TickCount - tickCount1 < 45000);
            break;
label_59:
            this.method_107(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3), gclass27_0, int_5_2, int_6, bool_5, "0124", int_7, int_8, bool_6, int_9, int_10, list_18, false, 0, 0);
            flag1 = false;
            int tickCount2 = Environment.TickCount;
          }
          else
            goto label_64;
        }
label_54:
        if (flag3)
        {
          ++num4;
          if (num4 < num3)
          {
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num4, (object) num3) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue, num1 + 1));
            num5 = 0;
            continue;
          }
          break;
        }
        ++num5;
        if (num5 < num6)
          continue;
        break;
label_60:
        switch (this.method_32(gclass27_0, int_4, string_0_1))
        {
          case 0:
            goto label_54;
          case 1:
            goto label_61;
          default:
            goto label_64;
        }
      }
    }
    catch
    {
    }
label_64:
    return num2;
  }

  private int method_131(
    int int_4,
    string string_0,
    GClass27 gclass27_0,
    GClass22 gclass22_0,
    string string_1,
    string string_2)
  {
    int int_4_1 = gclass22_0.method_3("nudSoLuongFrom");
    int int_5 = gclass22_0.method_3("nudSoLuongTo");
    int minValue = gclass22_0.method_3("nudDelayFrom");
    int num1 = gclass22_0.method_3("nudDelayTo");
    bool flag1 = gclass22_0.method_4("ckbTuDongTraLoiCauHoi");
    List<string> list_18 = gclass22_0.method_2("txtCauTraLoi");
    bool flag2 = gclass22_0.method_4("ckbTuDongXoaUid");
    int num2 = 0;
    int num3 = gclass27_0.method_87(int_4_1, int_5);
    string str1 = "";
    List<string> list_0 = new List<string>();
    if (!flag2)
      list_0 = GClass19.smethod_27(this.dictionary_0[string_1]);
    try
    {
      string string_0_1 = string_0 + GClass35.smethod_0("Đang") + " " + string_2 + ": ";
      for (int index1 = 0; index1 < num3 + 10; ++index1)
      {
        if (!flag2)
        {
          if (list_0.Count != 0)
          {
            str1 = list_0.smethod_10();
            list_0.Remove(str1);
          }
          else
            break;
        }
        else
        {
          lock (this.dictionary_0)
          {
            if (this.dictionary_0[string_1].Count != 0)
            {
              str1 = this.dictionary_0[string_1].smethod_10();
              this.dictionary_0[string_1].Remove(str1);
            }
            else
              break;
          }
        }
        this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Go to Group {2}...", (object) num2, (object) num3, (object) str1));
        if (this.method_215(gclass27_0, int_4, string_0_1, "fb://group/" + str1))
        {
          this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Find Join...", (object) num2, (object) num3));
          string string_11_1 = "";
          string str2 = "";
          for (int index2 = 0; index2 < 2; ++index2)
          {
            str2 = gclass27_0.method_30(5, ref string_11_1, new List<string>()
            {
              "//android.view.ViewGroup[@content-desc=\"Cancel Request\"]",
              "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]",
              "//*[starts-with(@content-desc, 'Join ')]"
            });
            if (!(str2 != ""))
            {
              gclass27_0.method_76(-1);
              gclass27_0.SleepSeconds(1.0);
            }
            else
              break;
          }
          if (str2 == "//*[starts-with(@content-desc, 'Join ')]")
          {
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Join...", (object) num2, (object) num3));
            gclass27_0.method_61(0, "//*[starts-with(@content-desc, 'Join ')]", string_11_1);
            string string_11_2 = "";
            string string_11_3 = gclass27_0.method_30(5, ref string_11_2, new List<string>()
            {
              "//android.view.ViewGroup[@content-desc=\"Answer Questions\"]",
              "//android.view.ViewGroup[@content-desc=\"Cancel Request\"]",
              "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]",
              "//android.view.ViewGroup[@content-desc=\"Submit\"]",
              "//*[starts-with(@content-desc,'followed')]"
            });
            if (flag1 && (string_11_3 == "//android.view.ViewGroup[@content-desc=\"Answer Questions\"]" || string_11_3 == "//android.view.ViewGroup[@content-desc=\"Submit\"]"))
            {
              if (string_11_3 == "//android.view.ViewGroup[@content-desc=\"Answer Questions\"]")
              {
                this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Tap Answer...", (object) num2, (object) num3));
                gclass27_0.method_61(0, string_11_3, string_11_2);
                gclass27_0.SleepSeconds(2.0);
              }
              this.method_132(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num2, (object) num3), gclass27_0, list_18);
            }
            ++num2;
            if (num2 >= num3)
            {
              this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), Done!", (object) num2, (object) num3));
              break;
            }
            this.method_184(int_4, string_0_1 + string.Format("({0}/{1}), ", (object) num2, (object) num3) + GClass35.smethod_0("đợi") + " {time}s...", Class54.random_0.Next(minValue, num1 + 1));
          }
        }
        else
          break;
      }
    }
    catch
    {
    }
    return num2;
  }

  private void method_132(int int_4, string string_0, GClass27 gclass27_0, List<string> list_18)
  {
    bool flag = false;
    int num = 0;
    while (true)
    {
      if (num < 10)
      {
        string string_11_1 = "";
        this.method_184(int_4, string_0 + "Find EditText...");
        List<string> stringList1 = gclass27_0.method_37(0, string_11_1, "//android.widget.EditText[@text=\"Write your answer...\"]");
        if (stringList1.Count > 0)
        {
          this.method_184(int_4, string_0 + GClass35.smethod_0("Nhập dữ liệu..."));
          for (int index = 0; index < stringList1.Count; ++index)
          {
            gclass27_0.method_50("(//android.widget.EditText[@text=\"Write your answer...\"])[1]", list_18.smethod_10());
            gclass27_0.method_80(1.0, 1.5);
          }
        }
        string_11_1 = "";
        this.method_184(int_4, string_0 + "Find checkbox...");
        List<string> stringList2 = gclass27_0.method_38(0, ref string_11_1, "//android.view.ViewGroup[@content-desc=\"You can choose multiple options\"]/parent::*/child::*");
        if (stringList2.Count > 0)
        {
          this.method_184(int_4, string_0 + "Check checkbox...");
          foreach (string string_11_2 in stringList2)
            gclass27_0.method_66(string_11_2);
        }
        string_11_1 = "";
        this.method_184(int_4, string_0 + "Find radio...");
        List<string> stringList3 = gclass27_0.method_38(0, ref string_11_1, "//android.view.ViewGroup[@content-desc=\"You can choose one option\"]/parent::*/child::*");
        if (stringList3.Count > 0)
        {
          this.method_184(int_4, string_0 + "Check radio...");
          foreach (string string_11_3 in stringList3)
            gclass27_0.method_66(string_11_3);
        }
        if (!flag)
        {
          string_11_1 = "";
          this.method_184(int_4, string_0 + "Find Agree...");
          List<string> stringList4 = gclass27_0.method_38(0, ref string_11_1, "//android.view.ViewGroup[starts-with(@content-desc,\"I agree to the group rules\")]");
          if (stringList4.Count > 0)
          {
            flag = true;
            this.method_184(int_4, string_0 + "Check Agree...");
            foreach (string string_11_4 in stringList4)
              gclass27_0.method_66(string_11_4);
          }
        }
        this.method_184(int_4, string_0 + "Scroll...");
        if (!gclass27_0.method_78())
          ++num;
        else
          goto label_30;
      }
      else
        break;
    }
    return;
label_30:
    this.method_184(int_4, string_0 + "Tap Submit...");
    if (!gclass27_0.method_61(0, "//android.view.ViewGroup[@content-desc='Submit'][@clickable='true']", ""))
      return;
    gclass27_0.method_117(10.0, "//android.view.ViewGroup[@content-desc='Submit'][@clickable='true']");
  }

  private void method_133()
  {
    try
    {
      this.dtgvAcc.Invoke((Delegate) (() =>
      {
        foreach (DataGridViewColumn column in (BaseCollection) this.dtgvAcc.Columns)
          column.SortMode = DataGridViewColumnSortMode.NotSortable;
      }));
    }
    catch (Exception ex)
    {
    }
  }

  private void method_134()
  {
    try
    {
      this.dtgvAcc.Invoke((Delegate) (() =>
      {
        foreach (DataGridViewColumn column in (BaseCollection) this.dtgvAcc.Columns)
          column.SortMode = DataGridViewColumnSortMode.Automatic;
      }));
    }
    catch
    {
    }
  }

  private void method_135(string string_0) => this.Invoke((Delegate) (() =>
  {
    try
    {
      switch (string_0)
      {
        case "start":
          this.btnInteract.Enabled = false;
          this.plQuanLyThuMuc.Enabled = false;
          this.btnPause.Enabled = true;
          this.method_133();
          break;
        case "stop":
          this.method_2(0);
          this.btnPause.Text = GClass35.smethod_0("Dừng Tương Tác");
          this.btnInteract.Enabled = true;
          this.plQuanLyThuMuc.Enabled = true;
          this.btnPause.Enabled = false;
          this.method_134();
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
      this.method_138();
    }
    catch
    {
    }
  }

  private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyValue != 32)
      return;
    this.method_10("ToggleCheck");
  }

  private void method_136(string string_0)
  {
    try
    {
      List<string> stringList = new List<string>();
      for (int int_4 = 0; int_4 < this.dtgvAcc.Rows.Count; ++int_4)
      {
        if (Convert.ToBoolean(this.method_191(int_4, "cChose")))
          stringList.Add(this.method_191(int_4, "cId"));
      }
      if (stringList.Count == 0)
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn tài khoản cần cập nhật!"), 3);
      else
        GClass19.smethod_35((Form) new fUpdateData(this, string_0));
    }
    catch
    {
    }
  }

  private void toolStripMenuItem_11_Click(object sender, EventArgs e) => this.method_136("Password");

  private void tokenToolStripMenuItem2_Click(object sender, EventArgs e) => this.method_136("Token");

  private void cookieToolStripMenuItem3_Click(object sender, EventArgs e) => this.method_136("Cookie");

  private void toolStripMenuItem_15_Click(object sender, EventArgs e) => this.method_136("Mail|pass");

  private void toolStripMenuItem_20_Click(object sender, EventArgs e) => this.method_136("2FA");

  private void btnPause_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.bool_0)
      {
        if (GClass14.smethod_1("Bạn có muốn phần mềm dừng ngay lập tức?") != DialogResult.Yes)
          return;
        this.btnPause.Enabled = false;
        new Thread((ThreadStart) (() => this.method_28()))
        {
          IsBackground = true
        }.Start();
      }
      else
      {
        this.bool_0 = true;
        this.btnPause.Text = GClass35.smethod_0("Đang dừng...");
      }
    }
    catch
    {
    }
  }

  private void toolStripMenuItem_9_Click(object sender, EventArgs e) => this.btnLoadAcc_Click((object) null, (EventArgs) null);

  private void btnDeleteFile_Click(object sender, EventArgs e)
  {
    int selectedIndex = this.cbbThuMuc.SelectedIndex;
    if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có thực sự muốn xóa thư mục [{0}] không?"), (object) this.cbbThuMuc.Text)) != DialogResult.Yes)
      return;
    if (Class42.smethod_5(this.cbbThuMuc.SelectedValue.ToString()))
    {
      GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Xoá thành công thư mục [{0}] !"), (object) this.cbbThuMuc.Text));
      this.method_4();
      this.cbbThuMuc.SelectedIndex = selectedIndex - 1;
    }
    else
      GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Không thể xóa thư mục [{0}] !"), (object) this.cbbThuMuc.Text), 2);
  }

  private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!this.bool_2 || this.cbbThuMuc.SelectedValue == null || !GClass15.smethod_0(this.cbbThuMuc.SelectedValue.ToString()) || this.cbbThuMuc.SelectedValue.ToString() != "999999" && this.int_1 == this.cbbThuMuc.SelectedIndex)
      return;
    switch (this.cbbThuMuc.SelectedValue.ToString())
    {
      case "-1":
        this.method_5();
        break;
      case "999999":
        GClass19.smethod_35((Form) new fChonThuMuc());
        if (!fChonThuMuc.bool_1 || fChonThuMuc.list_0 == null || fChonThuMuc.list_0.Count == 0)
        {
          this.bool_2 = false;
          this.cbbThuMuc.SelectedIndex = this.int_1 != -1 ? this.int_1 : 0;
          this.bool_2 = true;
        }
        else
          this.method_5(fChonThuMuc.list_0);
        break;
      default:
        this.method_5(this.method_6());
        break;
    }
    this.int_1 = this.cbbThuMuc.SelectedIndex;
    if (this.cbbThuMuc.SelectedValue == null)
      return;
    string str = this.cbbThuMuc.SelectedValue.ToString();
    if (str == "-1" || str == "999999")
    {
      this.btnDeleteFile.BackColor = Color.Gray;
      this.btnDeleteFile.Enabled = false;
      this.btnEditFile.BackColor = Color.Gray;
      this.btnEditFile.Enabled = false;
    }
    else
    {
      this.btnDeleteFile.BackColor = Color.White;
      this.btnDeleteFile.Enabled = true;
      this.btnEditFile.BackColor = Color.White;
      this.btnEditFile.Enabled = true;
    }
  }

  private void mailPassMailToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("mail|passmail");

  private void uidPassTokenCookieMailPassMailToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("uid|pass|token|cookie|mail|passmail");

  private void method_137()
  {
    try
    {
      this.lblCountTotal.Text = this.dtgvAcc.Rows.Count.ToString();
    }
    catch
    {
    }
  }

  private void method_138(int int_4 = -1)
  {
    if (int_4 == -1)
    {
      int_4 = 0;
      for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          ++int_4;
      }
    }
    this.lblCountSelect.Text = int_4.ToString();
  }

  private void method_139(int int_4)
  {
    int int_5 = 0;
    int int_6 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    string string_0 = GClass33.smethod_0("configGeneral").method_1("token");
    this.bool_0 = false;
    new Thread((ThreadStart) (() =>
    {
      this.method_135("start");
      switch (int_4)
      {
        case 0:
          int index1 = 0;
          while (index1 < this.dtgvAcc.Rows.Count && !this.bool_0)
          {
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index1].Cells["cChose"].Value))
            {
              if (int_5 < int_6)
              {
                Interlocked.Increment(ref int_5);
                int int_9 = index1++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_184(int_9, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_142(int_9, string_0);
                  Interlocked.Decrement(ref int_5);
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
              if (int_5 < int_6)
              {
                Interlocked.Increment(ref int_5);
                int int_7 = index2++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_184(int_7, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_143(int_7);
                  Interlocked.Decrement(ref int_5);
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
              if (int_5 < int_6)
              {
                Interlocked.Increment(ref int_5);
                int int_11 = index3++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_184(int_11, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_144(int_11);
                  Interlocked.Decrement(ref int_5);
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
              if (int_5 < int_6)
              {
                Interlocked.Increment(ref int_5);
                int int_8 = index4++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_184(int_8, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_145(int_8);
                  Interlocked.Decrement(ref int_5);
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
              if (int_5 < int_6)
              {
                Interlocked.Increment(ref int_5);
                int int_10 = index5++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_184(int_10, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_141(int_10);
                  Interlocked.Decrement(ref int_5);
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
              if (int_5 < int_6)
              {
                Interlocked.Increment(ref int_5);
                int int_12 = index6++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_184(int_12, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_140(int_12);
                  Interlocked.Decrement(ref int_5);
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
      while (int_5 > 0 && Environment.TickCount - tickCount <= 60000)
        GClass19.smethod_64(1.0);
      this.method_135("stop");
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_140(int int_4)
  {
    try
    {
      string string_0_1 = this.method_191(int_4, "cId");
      string string_0_2 = this.method_191(int_4, "cUid");
      if (!this.method_21(string_0_2))
      {
        this.method_184(int_4, GClass35.smethod_0("Uid không hợp lệ!"));
      }
      else
      {
        string str = Class38.smethod_19(string_0_2);
        if (str.StartsWith("0|"))
        {
          if (Class38.smethod_17(string_0_2).StartsWith("0|"))
          {
            this.method_184(int_4, GClass35.smethod_0("Tài khoản Die!"));
            this.method_185(int_4, "Die");
          }
          else
            this.method_184(int_4, GClass35.smethod_0("Không check được!"));
        }
        else if (str.StartsWith("1|"))
        {
          string[] strArray = str.Split('|');
          string object_17_1 = strArray[1];
          string object_17_2 = strArray[2];
          string object_17_3 = strArray[3];
          Class42.smethod_14(string_0_1, "name|friends|dateCreateAcc", object_17_1 + "|" + object_17_2 + "|" + object_17_3);
          this.method_186(int_4, "cName", (object) object_17_1);
          this.method_186(int_4, "cFriend", (object) object_17_2);
          this.method_186(int_4, "cdateCreateAcc", (object) object_17_3);
          this.method_185(int_4, "Live");
          string string_0_3 = GClass35.smethod_0("Cập nhật thông tin thành công!");
          this.method_184(int_4, string_0_3);
        }
        else
          this.method_184(int_4, GClass35.smethod_0("Không check được!"));
      }
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không check được!"));
    }
  }

  private void method_141(int int_4)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_4].Cells["cEmail"].Value.ToString();
      string string_1 = this.dtgvAcc.Rows[int_4].Cells["cPassMail"].Value.ToString();
      if (string_0 == "" || string_1 == "")
        this.method_184(int_4, GClass35.smethod_0("Không tìm thấy mail!"));
      else if (string_0.EndsWith("@hotmail.com") || string_0.EndsWith("@outlook.com"))
      {
        if (GClass19.smethod_21(string_0, string_1).Equals("1"))
          this.method_184(int_4, GClass35.smethod_0("Tài khoản mail: live!"));
        else
          this.method_184(int_4, GClass35.smethod_0("Tài khoản mail: die!"));
      }
      else if (string_0.EndsWith("@yandex.com"))
      {
        if (GClass19.smethod_22(string_0, string_1, "imap.yandex.com").Equals("1"))
          this.method_184(int_4, GClass35.smethod_0("Tài khoản mail: live!"));
        else
          this.method_184(int_4, GClass35.smethod_0("Tài khoản mail: die!"));
      }
      else
        this.method_184(int_4, GClass35.smethod_0("Mail chưa hỗ trợ!"));
    }
    catch
    {
      this.method_184(int_4, "Error!");
    }
  }

  private void method_142(int int_4, string string_0)
  {
    try
    {
      this.method_191(int_4, "cId");
      string string_0_1 = this.method_191(int_4, "cUid");
      if (!this.method_21(string_0_1))
      {
        this.method_184(int_4, GClass35.smethod_0("Uid không hợp lệ!"));
      }
      else
      {
        string string_0_2 = "";
        string str = Class38.smethod_17(string_0_1);
        string string_0_3;
        if (str.StartsWith("0|"))
        {
          string_0_2 = "Die";
          string_0_3 = "Wall die";
        }
        else if (str.StartsWith("1|"))
        {
          string_0_2 = "Live";
          string_0_3 = "Wall live";
        }
        else
          string_0_3 = GClass35.smethod_0("Không check được!");
        this.method_184(int_4, string_0_3);
        if (!(string_0_2 != ""))
          return;
        this.method_185(int_4, string_0_2);
      }
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không check được!"));
    }
  }

  private void method_143(int int_4)
  {
    try
    {
      string string_0_1 = "";
      this.method_191(int_4, "cId");
      string string_0_2 = this.method_191(int_4, "cCookies");
      string string_1 = this.method_191(int_4, "cToken");
      if (string_1.Trim() == "")
      {
        this.method_184(int_4, GClass35.smethod_0("Token trống!"));
      }
      else
      {
        string string_2 = this.method_191(int_4, "cUseragent");
        string string_3 = "";
        int int_0 = 0;
        if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
        {
          string_3 = this.method_191(int_4, "cProxy");
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
        if (!Class38.smethod_21(string_0_2, string_1, string_2, string_3, int_0))
        {
          string_0_3 = "Token die";
        }
        else
        {
          string_0_1 = "Live";
          string_0_3 = "Token live";
        }
        this.method_184(int_4, string_0_3);
        if (!(string_0_1 != ""))
          return;
        this.method_185(int_4, string_0_1);
      }
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không check được!"));
    }
  }

  private void method_144(int int_4)
  {
    try
    {
      string string_0_1 = "";
      this.method_191(int_4, "cId");
      string string_0_2 = this.method_191(int_4, "cCookies");
      if (string_0_2.Trim() == "")
      {
        this.method_184(int_4, GClass35.smethod_0("Cookie trống!"));
      }
      else
      {
        string string_1 = this.method_191(int_4, "cUseragent");
        string string_2 = "";
        int int_0 = 0;
        if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
        {
          string_2 = this.method_191(int_4, "cProxy");
          int_0 = string_2.EndsWith("*1") ? 1 : 0;
          if (string_2.EndsWith("*0") || string_2.EndsWith("*1"))
            string_2 = string_2.Substring(0, string_2.Length - 2);
        }
        int num;
        if (string_1 == "")
          num = string_2.Split(':').Length == 4 ? 1 : 0;
        else
          num = 0;
        if (num != 0)
          string_1 = Class54.string_5;
        string string_0_3;
        if (!Class38.smethod_4(string_0_2, string_1, string_2, int_0).StartsWith("1|"))
        {
          string_0_3 = "Cookie die";
        }
        else
        {
          string_0_1 = "Live";
          string_0_3 = "Cookie live";
        }
        this.method_184(int_4, string_0_3);
        if (!(string_0_1 != ""))
          return;
        this.method_185(int_4, string_0_1);
      }
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không check được!"));
    }
  }

  private void method_145(int int_4)
  {
    string string_0_1 = this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
    string string_0_2 = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
    string string_1 = this.dtgvAcc.Rows[int_4].Cells["cPassword"].Value.ToString();
    string str1 = this.method_191(int_4, "cUseragent");
    string string_3 = "";
    int int_0 = 0;
    if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
    {
      string_3 = this.method_191(int_4, "cProxy");
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
    string string_0_3 = "";
    string string_0_4 = "";
    string str2 = "";
    string str3 = Class38.smethod_24(string_0_2, string_1, "", string_3, int_0);
    switch (str3.Split('|')[0])
    {
      case "3":
        string_0_3 = "Changed pass";
        break;
      case "2":
        string str4;
        if (str3.Split('|')[1].Trim() != "")
          str4 = "Checkpoint: " + str3.Split('|')[1];
        else
          str4 = GClass35.smethod_0("Checkpoint");
        string_0_3 = str4;
        break;
      case "1":
        str2 = str3.Split('|')[1];
        string_0_3 = "Live";
        break;
      case "5":
        string_0_4 = GClass35.smethod_0("Không check được (Có 2fa)!");
        break;
      case "0":
      case "4":
        string_0_4 = GClass35.smethod_0("Không check được!");
        break;
    }
    if (string_0_4 == "")
      string_0_4 = GClass35.smethod_0("Đã check Done!");
    if (str2 != "")
    {
      this.method_186(int_4, "cCookies", (object) str2);
      Class42.smethod_13(string_0_1, "cookie1", str2);
    }
    if (string_0_3 != "")
      this.method_185(int_4, string_0_3);
    this.method_184(int_4, string_0_4);
  }

  private void toolStripMenuItem_14_Click(object sender, EventArgs e) => this.method_139(0);

  private void toolStripMenuItem_8_Click(object sender, EventArgs e)
  {
    if (GClass14.smethod_1(GClass35.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) != DialogResult.Yes)
      return;
    this.method_139(1);
  }

  private void toolStripMenuItem_7_Click(object sender, EventArgs e) => this.method_139(2);

  private void method_146(object sender, EventArgs e) => this.method_139(3);

  private void mailToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("mail");

  private void BtnSearch_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.cbbSearch.SelectedIndex == -1)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn kiểu tìm kiếm!"), 3);
      }
      else
      {
        string columnName = this.cbbSearch.SelectedValue.ToString();
        string str1 = this.txbSearch.Text.Trim();
        if (str1 == "")
        {
          GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập nội dung tìm kiếm!"), 3);
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
          int num;
          try
          {
            num = this.dtgvAcc.CurrentRow.Index;
          }
          catch
          {
            num = -1;
          }
          if (intList.Count <= 0)
            return;
          if (num >= intList[intList.Count - 1])
          {
            index1 = 0;
          }
          else
          {
            for (int index2 = 0; index2 < intList.Count; ++index2)
            {
              if (num < intList[index2])
              {
                index1 = index2;
                break;
              }
            }
          }
          int index3 = intList[index1];
          this.dtgvAcc.CurrentCell = this.dtgvAcc.Rows[index3].Cells[columnName];
          this.dtgvAcc.ClearSelection();
          this.dtgvAcc.Rows[index3].Selected = true;
        }
      }
    }
    catch (Exception ex)
    {
    }
  }

  private void uidPassTokenCookieMailPassMail2faToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("uid|pass|token|cookie|mail|passmail|fa2");

  private void toolStripStatusLabel9_Click(object sender, EventArgs e)
  {
    this.Hide();
    Settings.Default.UserName = "";
    Settings.Default.PassWord = "";
    Settings.Default.Save();
    fActive fActive = new fActive(0);
    fActive.ShowInTaskbar = true;
    int num = (int) fActive.ShowDialog();
  }

  private void method_147()
  {
    for (int int_4 = 0; int_4 < this.dtgvAcc.RowCount; ++int_4)
      this.method_186(int_4, "cSTT", (object) (int_4 + 1));
  }

  private void fAToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("2fa");

  private void checkAvatarToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    this.bool_0 = false;
    new Thread((ThreadStart) (() =>
    {
      this.method_135("start");
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
                this.method_184(int_2, GClass35.smethod_0("Đang kiểm tra..."));
                this.method_148(int_2);
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
      this.method_135("stop");
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_148(int int_4)
  {
    try
    {
      string string_0_1 = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      string string_0_2 = this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
      if (Class38.smethod_12(string_0_1))
      {
        this.method_184(int_4, GClass35.smethod_0("Đã có avatar!"));
        this.method_186(int_4, "cAvatar", (object) "Yes");
        Class42.smethod_13(string_0_2, "avatar", "Yes");
      }
      else
      {
        this.method_184(int_4, GClass35.smethod_0("Không có avatar!"));
        this.method_186(int_4, "cAvatar", (object) "No");
        Class42.smethod_13(string_0_2, "avatar", "No");
      }
    }
    catch
    {
      this.method_184(int_4, "Error!");
    }
  }

  private void locTrungToolStripMenuItem_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> list_0 = new List<string>();
      List<string> stringList = new List<string>();
      for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        {
          string str = this.method_191(index, "cUid");
          if (stringList.Contains(str))
            list_0.Add(str);
          else
            stringList.Add(str);
        }
      }
      if (list_0.Count == 0)
      {
        GClass14.smethod_0((object) "Không có tài khoản trùng nhau!");
      }
      else
      {
        DataTable dataTable = Class42.smethod_20(GClass19.smethod_27(list_0));
        dataTable.DefaultView.Sort = "uid ASC";
        DataTable table = dataTable.DefaultView.ToTable();
        this.dtgvAcc.Rows.Clear();
        this.method_8(table);
      }
    }
    catch (Exception ex)
    {
    }
  }

  private void method_149(object sender, EventArgs e)
  {
  }

  private void method_150(object sender, EventArgs e)
  {
  }

  private void method_151(int int_4)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
      string str1 = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      string str2 = GClass13.smethod_0() + "\\profile\\" + str1;
      string path1 = str2 + "\\data.tar.gz";
      string path2 = str2 + ".zip";
      if (str1.Trim() == "")
      {
        this.method_184(int_4, GClass35.smethod_0("Chưa tạo profile!"));
        this.method_186(int_4, "cProfile", (object) "No");
        Class42.smethod_13(string_0, "profile", "No");
      }
      else if (File.Exists(path1))
      {
        try
        {
          File.Delete(path1);
          this.method_184(int_4, GClass35.smethod_0("Xóa profile thành công!"));
          this.method_186(int_4, "cProfile", (object) "No");
          Class42.smethod_13(string_0, "profile", "No");
        }
        catch
        {
          this.method_184(int_4, GClass35.smethod_0("Xóa profile thất bại!"));
        }
      }
      else if (File.Exists(path2))
      {
        try
        {
          File.Delete(path2);
          this.method_184(int_4, GClass35.smethod_0("Xóa profile thành công!"));
          this.method_186(int_4, "cProfile", (object) "No");
          Class42.smethod_13(string_0, "profile", "No");
        }
        catch
        {
          this.method_184(int_4, GClass35.smethod_0("Xóa profile thất bại!"));
        }
      }
      else
        this.method_184(int_4, GClass35.smethod_0("Chưa tạo profile!"));
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Xóa profile thất bại!"));
    }
  }

  private void method_152(int int_4, string string_0)
  {
    try
    {
      string string_0_1 = this.method_191(int_4, "cId");
      string str = this.method_191(int_4, "cUid");
      string_0 = string_0 + "\\" + str + ".tar.gz";
      if (File.Exists(string_0))
      {
        this.method_184(int_4, GClass35.smethod_0("Đã backup data Fb!"));
        this.method_186(int_4, "cProfile", (object) "Yes");
        Class42.smethod_13(string_0_1, "profile", "Yes");
      }
      else
      {
        this.method_184(int_4, GClass35.smethod_0("Chưa backup data Fb!"));
        this.method_186(int_4, "cProfile", (object) "No");
        Class42.smethod_13(string_0_1, "profile", "No");
      }
    }
    catch
    {
    }
  }

  public void method_153(string string_0)
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

  private void pictureBox1_DoubleClick(object sender, EventArgs e) => this.method_153("Chrome");

  private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
  {
  }

  private void uidPass2FaToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("uid|pass|2fa");

  private void toolStripMenuItem_0_Click(object sender, EventArgs e)
  {
    Dictionary<string, bool> dictionary_1 = new Dictionary<string, bool>();
    dictionary_1.Add("isChangePathDatabase", false);
    GClass19.smethod_35((Form) new fCauHinhChung(ref dictionary_1));
    if (!dictionary_1["isChangePathDatabase"])
      return;
    this.method_4();
    this.int_1 = -1;
    this.cbbThuMuc.SelectedIndex = -1;
    this.cbbThuMuc.SelectedIndex = 0;
  }

  private void toolStripMenuItem_16_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> list_2 = new List<string>();
      for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          list_2.Add(this.method_191(index, "cUid") + "|" + this.method_191(index, "cPassword") + "|" + this.method_191(index, "cToken") + "|" + this.method_191(index, "cCookies") + "|" + this.method_191(index, "cEmail") + "|" + this.method_191(index, "cPassMail") + "|" + this.method_191(index, "cFa2") + "|" + this.method_191(index, "cUseragent") + "|" + this.method_191(index, "cProxy").Split('*')[0] + "|" + this.method_191(index, "cName") + "|" + this.method_191(index, "cGender") + "|" + this.method_191(index, "cFollow") + "|" + this.method_191(index, "cFriend") + "|" + this.method_191(index, "cGroup") + "|" + this.method_191(index, "cBirthday") + "|" + this.method_191(index, "cDateCreateAcc") + "|" + this.method_191(index, "cGhiChu") + "|" + this.method_191(index, "cMailRecovery") + "|" + this.method_191(index, "cInteractEnd"));
      }
      if (list_2.Count <= 0)
        GClass14.smethod_0((object) "Vui lòng chọn danh sách tài khoản muốn copy thông tin!", 3);
      else
        GClass19.smethod_35((Form) new fCopy(list_2));
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Error Copy");
    }
  }

  private void toolStripMenuItem_19_Click(object sender, EventArgs e) => this.method_11("ma2fa");

  private void toolStripMenuItem_13_Click(object sender, EventArgs e)
  {
  }

  private void method_154(int int_4)
  {
    int int_5 = 0;
    int int_6 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    string string_0 = GClass33.smethod_0("configGeneral").method_1("token");
    string string_1 = GClass33.smethod_0("configGeneral").method_1("cookie");
    if (int_4 == 0 && !Class38.smethod_21("", string_0, "", ""))
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng kiểm tra lại token trung gian!"), 3);
    else if (int_4 == 4 && Class38.smethod_4(string_1, "", "", 0).StartsWith("0|"))
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng kiểm tra lại cookie trung gian!"), 3);
    }
    else
    {
      this.bool_0 = false;
      bool bool_0 = false;
      bool bool_1 = false;
      bool bool_2 = false;
      int int_7 = 0;
      new Thread((ThreadStart) (() =>
      {
        this.method_135("start");
        switch (int_4)
        {
          case 0:
            int index1 = 0;
            while (index1 < this.dtgvAcc.Rows.Count && !this.bool_0)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index1].Cells["cChose"].Value))
              {
                if (int_5 < int_6)
                {
                  Interlocked.Increment(ref int_5);
                  int int_9 = index1++;
                  new Thread((ThreadStart) (() =>
                  {
                    this.method_184(int_9, GClass35.smethod_0("Đang kiểm tra..."));
                    if (!this.method_155(int_9, string_0, true))
                    {
                      this.bool_0 = true;
                      bool_0 = true;
                    }
                    Interlocked.Decrement(ref int_5);
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
            goto default;
          case 1:
            int index2 = 0;
            while (index2 < this.dtgvAcc.Rows.Count && !this.bool_0)
            {
              if (!Convert.ToBoolean(this.dtgvAcc.Rows[index2].Cells["cChose"].Value))
                ++index2;
              else if (int_5 < int_6)
              {
                Interlocked.Increment(ref int_5);
                int int_8 = index2++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_184(int_8, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_158(int_8);
                  Interlocked.Decrement(ref int_5);
                }))
                {
                  IsBackground = true
                }.Start();
              }
              else if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 0 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 7 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 8 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 10 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 11 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 12 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 13 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 14)
              {
                GClass19.smethod_64(1.0);
              }
              else
              {
                while (int_5 > 0)
                  GClass19.smethod_64(1.0);
                if (!this.bool_0)
                {
                  Interlocked.Increment(ref int_7);
                  if (int_7 >= Convert.ToInt32(GClass33.smethod_0("configGeneral").method_1("ip_nudChangeIpCount") == "" ? "1" : GClass33.smethod_0("configGeneral").method_1("ip_nudChangeIpCount")))
                  {
                    for (int index3 = 0; index3 < 3; ++index3)
                    {
                      bool_2 = GClass19.smethod_82(GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp"), GClass33.smethod_0("configGeneral").method_3("typeDcom"), GClass33.smethod_0("configGeneral").method_1("ip_txtProfileNameDcom"), GClass33.smethod_0("configGeneral").method_1("txtUrlHilink"), GClass33.smethod_0("configGeneral").method_3("ip_cbbHostpot"), GClass33.smethod_0("configGeneral").method_1("ip_txtNordVPN"));
                      if (bool_2)
                        break;
                    }
                    if (bool_2)
                    {
                      int_7 = 0;
                    }
                    else
                    {
                      GClass14.smethod_0((object) GClass35.smethod_0("Không thể đổi ip!"), 3);
                      goto label_59;
                    }
                  }
                }
                else
                  break;
              }
            }
            goto default;
          case 2:
            int index4 = 0;
            while (index4 < this.dtgvAcc.Rows.Count && !this.bool_0)
            {
              if (!Convert.ToBoolean(this.dtgvAcc.Rows[index4].Cells["cChose"].Value))
                ++index4;
              else if (int_5 < int_6)
              {
                Interlocked.Increment(ref int_5);
                int int_10 = index4++;
                new Thread((ThreadStart) (() =>
                {
                  this.method_184(int_10, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_156(int_10);
                  Interlocked.Decrement(ref int_5);
                }))
                {
                  IsBackground = true
                }.Start();
              }
              else if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 0 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 7 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 8 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 10 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 11 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 12 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 13 || GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 14)
              {
                GClass19.smethod_64(1.0);
              }
              else
              {
                while (int_5 > 0)
                  GClass19.smethod_64(1.0);
                if (!this.bool_0)
                {
                  Interlocked.Increment(ref int_7);
                  if (int_7 >= Convert.ToInt32(GClass33.smethod_0("configGeneral").method_1("ip_nudChangeIpCount") == "" ? "1" : GClass33.smethod_0("configGeneral").method_1("ip_nudChangeIpCount")))
                  {
                    for (int index5 = 0; index5 < 3; ++index5)
                    {
                      bool_2 = GClass19.smethod_82(GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp"), GClass33.smethod_0("configGeneral").method_3("typeDcom"), GClass33.smethod_0("configGeneral").method_1("ip_txtProfileNameDcom"), GClass33.smethod_0("configGeneral").method_1("txtUrlHilink"), GClass33.smethod_0("configGeneral").method_3("ip_cbbHostpot"), GClass33.smethod_0("configGeneral").method_1("ip_txtNordVPN"));
                      if (bool_2)
                        break;
                    }
                    if (bool_2)
                    {
                      int_7 = 0;
                    }
                    else
                    {
                      GClass14.smethod_0((object) GClass35.smethod_0("Không thể đổi ip!"), 3);
                      goto label_59;
                    }
                  }
                }
                else
                  break;
              }
            }
            goto default;
          case 4:
            int index6 = 0;
            while (index6 < this.dtgvAcc.Rows.Count && !this.bool_0)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index6].Cells["cChose"].Value))
              {
                if (int_5 < int_6)
                {
                  Interlocked.Increment(ref int_5);
                  int int_11 = index6++;
                  new Thread((ThreadStart) (() =>
                  {
                    this.method_184(int_11, GClass35.smethod_0("Đang kiểm tra..."));
                    if (!this.method_157(int_11, string_1))
                    {
                      this.bool_0 = true;
                      bool_1 = true;
                    }
                    Interlocked.Decrement(ref int_5);
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
            goto default;
          default:
            int tickCount = Environment.TickCount;
            while (int_5 > 0 && Environment.TickCount - tickCount <= 60000)
              GClass19.smethod_64(1.0);
            break;
        }
label_59:
        this.method_135("stop");
        if (bool_0)
          GClass14.smethod_0((object) GClass35.smethod_0("Token trung gian die!"));
        if (!bool_1)
          return;
        GClass14.smethod_0((object) GClass35.smethod_0("Cookie trung gian die!"));
      }))
      {
        IsBackground = true
      }.Start();
    }
  }

  private bool method_155(int int_4, string string_0, bool bool_5)
  {
    try
    {
      string string_0_1 = this.method_191(int_4, "cId");
      string string_1 = this.method_191(int_4, "cUid");
      string string_2 = this.method_191(int_4, "cUseragent");
      string string_3 = "";
      int int_0 = 0;
      if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
      {
        string_3 = this.method_191(int_4, "cProxy");
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
      if (bool_5)
      {
        string_2 = "";
        string_3 = "";
        int_0 = 0;
      }
      string string_0_2 = "";
      string string_0_3;
      if (string_1 == "")
      {
        string_0_3 = GClass35.smethod_0("Không có uid!");
      }
      else
      {
        string str = Class38.smethod_25(string_0, string_1, string_2, string_3, int_0);
        if (str == "-1")
        {
          this.method_184(int_4, GClass35.smethod_0("Không check được!"));
          return false;
        }
        string[] strArray = str.Split('|');
        if (Convert.ToBoolean(strArray[0]))
        {
          string_0_2 = "Live";
          Class42.smethod_14(string_0_1, "name|gender|birthday|friends|groups" + (strArray[5] != "" ? "|email" : ""), strArray[1] + "|" + strArray[2] + "|" + strArray[3] + "|" + strArray[6] + "|" + strArray[7] + (strArray[5] != "" ? "|" + strArray[5] : ""));
          this.method_186(int_4, "cName", (object) strArray[1]);
          this.method_186(int_4, "cGender", (object) strArray[2]);
          this.method_186(int_4, "cBirthday", (object) strArray[3]);
          if (strArray[5] != "")
            this.method_186(int_4, "cEmail", (object) strArray[5]);
          this.method_186(int_4, "cFriend", (object) strArray[6]);
          this.method_186(int_4, "cGroup", (object) strArray[7]);
          string_0_3 = "Cập nhật thông tin thành công!";
        }
        else
        {
          string_0_2 = "Die";
          string_0_3 = GClass35.smethod_0("Tài khoản die!");
        }
      }
      this.method_184(int_4, string_0_3);
      if (string_0_2 != "")
        this.method_185(int_4, string_0_2);
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không check được!"));
    }
    return true;
  }

  private void method_156(int int_4)
  {
    try
    {
      string string_0_1 = this.method_191(int_4, "cId");
      string string_0_2 = this.method_191(int_4, "cCookies");
      this.method_191(int_4, "cToken");
      string string_1 = this.method_191(int_4, "cUseragent");
      string string_2 = "";
      int int_0 = 0;
      if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
      {
        string_2 = this.method_191(int_4, "cProxy");
        int_0 = string_2.EndsWith("*1") ? 1 : 0;
        if (string_2.EndsWith("*0") || string_2.EndsWith("*1"))
          string_2 = string_2.Substring(0, string_2.Length - 2);
      }
      int num;
      if (string_1 == "")
        num = string_2.Split(':').Length == 4 ? 1 : 0;
      else
        num = 0;
      if (num != 0)
        string_1 = Class54.string_5;
      string string_0_3 = "";
      string string_0_4;
      if (string_0_2 == "")
      {
        string_0_4 = GClass35.smethod_0("Cookie trống");
      }
      else
      {
        string str = Class38.smethod_26(string_0_2, string_1, string_2, int_0);
        if (str == "-1")
        {
          string_0_4 = "Cookie die";
        }
        else
        {
          string[] strArray = str.Split('|');
          if (Convert.ToBoolean(strArray[0]))
          {
            string_0_3 = "Live";
            Class42.smethod_14(string_0_1, "name|gender|birthday|friends|groups" + (strArray[5] != "" ? "|email" : ""), strArray[1] + "|" + strArray[2] + "|" + strArray[3] + "|" + strArray[6] + "|" + strArray[7] + (strArray[5] != "" ? "|" + strArray[5] : ""));
            this.method_186(int_4, "cName", (object) strArray[1]);
            this.method_186(int_4, "cGender", (object) strArray[2]);
            this.method_186(int_4, "cBirthday", (object) strArray[3]);
            if (strArray[5] != "")
              this.method_186(int_4, "cEmail", (object) strArray[5]);
            this.method_186(int_4, "cFriend", (object) strArray[6]);
            this.method_186(int_4, "cGroup", (object) strArray[7]);
            string_0_4 = GClass35.smethod_0("Cập nhật thông tin thành công!");
          }
          else
          {
            string_0_3 = "Die";
            string_0_4 = GClass35.smethod_0("Tài khoản die!");
          }
        }
      }
      this.method_184(int_4, string_0_4);
      if (!(string_0_3 != ""))
        return;
      this.method_185(int_4, string_0_3);
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không check được!"));
    }
  }

  private bool method_157(int int_4, string string_0)
  {
    try
    {
      string string_0_1 = this.method_191(int_4, "cId");
      string str = Class38.smethod_27(this.method_191(int_4, "cUid"), string_0);
      if (str == "-1")
      {
        this.method_184(int_4, GClass35.smethod_0("Không check được!"));
        return false;
      }
      string[] strArray = str.Split('|');
      string string_0_2;
      if (Convert.ToBoolean(strArray[0]))
      {
        Class42.smethod_14(string_0_1, "name|gender", strArray[1] + "|" + strArray[2]);
        this.method_186(int_4, "cName", (object) strArray[1]);
        this.method_186(int_4, "cGender", (object) strArray[2]);
        if (strArray[6] != "")
        {
          this.method_186(int_4, "cFriend", (object) strArray[6]);
          Class42.smethod_13(string_0_1, "friends", strArray[6]);
        }
        if (strArray[7] != "")
        {
          this.method_186(int_4, "cGroup", (object) strArray[7]);
          Class42.smethod_13(string_0_1, "groups", strArray[7]);
        }
        this.method_185(int_4, "Live");
        string_0_2 = GClass35.smethod_0("Cập nhật thông tin thành công!");
      }
      else
      {
        this.method_185(int_4, "Die");
        string_0_2 = GClass35.smethod_0("Tài khoản Die!");
      }
      this.method_184(int_4, string_0_2);
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không check được!"));
    }
    return true;
  }

  private void method_158(int int_4)
  {
    try
    {
      string string_0_1 = this.method_191(int_4, "cId");
      string string_0_2 = this.method_191(int_4, "cToken");
      string string_2 = this.method_191(int_4, "cUseragent");
      string string_3 = "";
      int int_0 = 0;
      if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 9)
      {
        string_3 = this.method_191(int_4, "cProxy");
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
      string string_0_3 = "";
      string string_0_4;
      if (string_0_2 == "")
      {
        string_0_4 = GClass35.smethod_0("Token trống");
      }
      else
      {
        string str = Class38.smethod_25(string_0_2, "", string_2, string_3, int_0);
        if (str == "-1")
        {
          string_0_4 = "Token die";
        }
        else
        {
          string[] strArray = str.Split('|');
          if (Convert.ToBoolean(strArray[0]))
          {
            string_0_3 = "Live";
            Class42.smethod_14(string_0_1, "name|gender|birthday|friends|groups" + (strArray[5] != "" ? "|email" : ""), strArray[1] + "|" + strArray[2] + "|" + strArray[3] + "|" + strArray[6] + "|" + strArray[7] + (strArray[5] != "" ? "|" + strArray[5] : ""));
            this.method_186(int_4, "cName", (object) strArray[1]);
            this.method_186(int_4, "cGender", (object) strArray[2]);
            this.method_186(int_4, "cBirthday", (object) strArray[3]);
            if (strArray[5] != "")
              this.method_186(int_4, "cEmail", (object) strArray[5]);
            this.method_186(int_4, "cFriend", (object) strArray[6]);
            this.method_186(int_4, "cGroup", (object) strArray[7]);
          }
          else
            string_0_3 = "Die";
          string_0_4 = GClass35.smethod_0("Cập nhật thông tin thành công!");
        }
      }
      this.method_184(int_4, string_0_4);
      if (!(string_0_3 != ""))
        return;
      this.method_185(int_4, string_0_3);
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không check được!"));
    }
  }

  private void toolStripMenuItem_18_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fNhapTokenTrungGian());
    if (!fNhapTokenTrungGian.bool_0)
      return;
    this.method_154(0);
  }

  private void method_159(object sender, EventArgs e) => this.method_154(1);

  private void method_160(object sender, EventArgs e)
  {
    if (GClass14.smethod_1(GClass35.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) != DialogResult.Yes)
      return;
    this.method_154(2);
  }

  private List<string> method_161(List<string> list_18, int int_4 = 50, string string_0 = ",")
  {
    int int32 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double) list_18.Count * 1.0 / (double) int_4)));
    List<string> stringList = new List<string>();
    for (int index = 0; index < int32; ++index)
      stringList.Add(string.Join(string_0, (IEnumerable<string>) list_18.GetRange(int_4 * index, int_4 * index + int_4 <= list_18.Count ? int_4 : list_18.Count % int_4)));
    return stringList;
  }

  private void method_162(object sender, EventArgs e)
  {
    string string_0 = Class54.string_6;
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
                  this.method_163(int_2, string_0);
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

  private void method_163(int int_4, string string_0, bool bool_5 = false, string string_1 = "")
  {
    try
    {
      string str1 = Class14.smethod_3(this.dtgvAcc, int_4, "cCookie");
      string newValue1 = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      if (newValue1 == "")
        newValue1 = Regex.Match(str1 + ";", "c_user=(.*?);").Groups[1].Value;
      string str2 = !File.Exists("backup\\" + newValue1 + "\\ngaysinh.txt") ? "||" : File.ReadAllText("backup\\" + newValue1 + "\\ngaysinh.txt");
      Class14.Status(this.dtgvAcc, int_4, "cStatus", (object) GClass35.smethod_0("Đang tạo file Html..."));
      if (newValue1 != "")
      {
        string newValue2 = str2.Split('|')[2].Replace("\"", "\\\"").Replace("'", "\\'");
        string newValue3 = str2.Split('|')[1];
        if (newValue2 == "")
          newValue2 = "NoName";
        if (newValue3 == "")
          newValue3 = "00/00/0000";
        string_0 = string_0.Replace("{{uid}}", newValue1).Replace("{{birthday}}", newValue3).Replace("{{name}}", newValue2);
        string path = "backup\\" + newValue1;
        if (!Directory.Exists(path))
          return;
        if (File.Exists(path + "\\lscomment.txt"))
        {
          string str3 = "";
          List<string> list = ((IEnumerable<string>) File.ReadAllLines(path + "\\lscomment.txt")).ToList<string>();
          int count = list.Count;
          for (int index = 0; index < count; ++index)
            str3 = str3 + "\"" + list[index].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
          if (str3 != "")
          {
            string newValue4 = str3.Remove(str3.Length - 1, 1);
            string_0 = string_0.Replace("{comments}", newValue4);
          }
          else
            string_0 = string_0.Replace("{comments}", "");
        }
        else
          string_0 = string_0.Replace("{comments}", "");
        if (File.Exists(path + "\\banbeinbox.txt"))
        {
          string str4 = "";
          List<string> list = ((IEnumerable<string>) File.ReadAllLines(path + "\\banbeinbox.txt")).ToList<string>();
          int count = list.Count;
          for (int index = 0; index < count; ++index)
            str4 = str4 + "\"" + list[index].Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
          if (str4 != "")
          {
            string newValue5 = str4.Remove(str4.Length - 1, 1);
            string_0 = string_0.Replace("{messages}", newValue5);
          }
          else
            string_0 = string_0.Replace("{messages}", "");
        }
        else
          string_0 = string_0.Replace("{messages}", "");
        if (File.Exists(path + "\\" + newValue1 + ".txt"))
        {
          string str5 = "";
          string str6 = File.ReadAllText(path + "\\" + newValue1 + ".txt");
          string[] separator1 = new string[1]
          {
            Environment.NewLine + Environment.NewLine
          };
          foreach (string str7 in str6.Split(separator1, StringSplitOptions.RemoveEmptyEntries))
          {
            string[] separator2 = new string[1]
            {
              Environment.NewLine
            };
            string[] strArray1 = str7.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
            if (strArray1.Length != 0)
            {
              string str8 = "";
              for (int index = 0; index < strArray1.Length; ++index)
              {
                string[] strArray2 = strArray1[index].Split('*');
                str8 = str8 + "\"" + strArray2[2].Split('|')[0] + "\",";
              }
              string str9 = str8.Remove(str8.Length - 1, 1);
              str5 = str5 + "{\"uid\":\"" + strArray1[0].Split('*')[0] + "\",\"name\":\"" + strArray1[0].Split('*')[1] + "\",\"photos\":[" + str9 + "],\"show\":true},";
            }
          }
          string newValue6 = str5.Remove(str5.Length - 1, 1);
          string_0 = string_0.Replace("{photos}", newValue6);
        }
        else
          string_0 = string_0.Replace("{photos}", "");
        File.WriteAllText(path + "\\" + newValue1 + ".html", string_0);
        Class14.Status(this.dtgvAcc, int_4, "cStatus", (object) GClass35.smethod_0("Tạo thành công!"));
      }
      else
        Class14.Status(this.dtgvAcc, int_4, "cStatus", (object) GClass35.smethod_0("Không có uid!"));
    }
    catch
    {
      Class14.Status(this.dtgvAcc, int_4, "cStatus", (object) GClass35.smethod_0("Lỗi tạo file!"));
    }
  }

  private bool method_164(string string_0, string string_1, string string_2 = "backup\\")
  {
    bool flag = false;
    try
    {
      string str1 = !File.Exists(string_2 + "\\" + string_0 + "\\ngaysinh.txt") ? "||" : File.ReadAllText(string_2 + "\\" + string_0 + "\\ngaysinh.txt");
      if (!(string_0 != ""))
        return flag;
      string newValue1 = str1.Split('|')[2].Replace("\"", "\\\"").Replace("'", "\\'");
      string newValue2 = str1.Split('|')[1];
      if (newValue1 == "")
        newValue1 = "NoName";
      if (newValue2 == "")
        newValue2 = "00/00/0000";
      string_1 = string_1.Replace("{{uid}}", string_0).Replace("{{birthday}}", newValue2).Replace("{{name}}", newValue1);
      string path = string_2 + "\\" + string_0;
      if (!Directory.Exists(path))
        return flag;
      if (File.Exists(path + "\\lscomment.txt"))
      {
        string str2 = "";
        List<string> list = ((IEnumerable<string>) File.ReadAllLines(path + "\\lscomment.txt")).ToList<string>();
        int count = list.Count;
        for (int index = 0; index < count; ++index)
          str2 = str2 + "\"" + list[index].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
        if (str2 != "")
        {
          string newValue3 = str2.Remove(str2.Length - 1, 1);
          string_1 = string_1.Replace("{comments}", newValue3);
        }
        else
          string_1 = string_1.Replace("{comments}", "");
      }
      else
        string_1 = string_1.Replace("{comments}", "");
      if (File.Exists(path + "\\banbeinbox.txt"))
      {
        string str3 = "";
        List<string> list = ((IEnumerable<string>) File.ReadAllLines(path + "\\banbeinbox.txt")).ToList<string>();
        int count = list.Count;
        for (int index = 0; index < count; ++index)
          str3 = str3 + "\"" + list[index].Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
        if (str3 != "")
        {
          string newValue4 = str3.Remove(str3.Length - 1, 1);
          string_1 = string_1.Replace("{messages}", newValue4);
        }
        else
          string_1 = string_1.Replace("{messages}", "");
      }
      else
        string_1 = string_1.Replace("{messages}", "");
      if (File.Exists(path + "\\" + string_0 + ".txt"))
      {
        string str4 = "";
        string str5 = File.ReadAllText(path + "\\" + string_0 + ".txt");
        string[] separator1 = new string[1]
        {
          Environment.NewLine + Environment.NewLine
        };
        foreach (string str6 in str5.Split(separator1, StringSplitOptions.RemoveEmptyEntries))
        {
          string[] separator2 = new string[1]
          {
            Environment.NewLine
          };
          string[] strArray1 = str6.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
          if (strArray1.Length != 0)
          {
            string str7 = "";
            for (int index = 0; index < strArray1.Length; ++index)
            {
              string[] strArray2 = strArray1[index].Split('*');
              str7 = str7 + "\"" + strArray2[2].Split('|')[0] + "\",";
            }
            string str8 = str7.Remove(str7.Length - 1, 1);
            str4 = str4 + "{\"uid\":\"" + strArray1[0].Split('*')[0] + "\",\"name\":\"" + strArray1[0].Split('*')[1] + "\",\"photos\":[" + str8 + "],\"show\":true},";
          }
        }
        string newValue5 = str4.Remove(str4.Length - 1, 1);
        string_1 = string_1.Replace("{photos}", newValue5);
      }
      else
        string_1 = string_1.Replace("{photos}", "");
      File.WriteAllText(path + "\\" + string_0 + ".html", string_1);
      return true;
    }
    catch
    {
      return flag;
    }
  }

  private void method_165(object sender, EventArgs e)
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
                  string str3 = Class14.smethod_3(this.dtgvAcc, int_2, "cCookies");
                  string str4 = Class14.smethod_3(this.dtgvAcc, int_2, "cUid");
                  if (str4 == "")
                    str4 = Regex.Match(str3 + ";", "c_user=(.*?);").Groups[1].Value;
                  if (File.Exists("backup\\" + str4 + "\\" + str4 + ".html"))
                    Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + str4 + "\\" + str4 + ".html");
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

  private void method_166(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fSelectFolder());
    string string0 = fSelectFolder.string_0;
    if (string0 == "")
      return;
    int num = 0;
    for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
    {
      try
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        {
          string str = this.dtgvAcc.Rows[index].Cells["cUid"].Value.ToString();
          try
          {
            if (File.Exists(GClass13.smethod_0() + "\\backup\\" + str + "\\" + str + ".html"))
            {
              File.Copy("backup\\" + str + "\\" + str + ".html", string0 + "\\" + str + ".html");
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

  private void method_167(object sender, EventArgs e) => this.method_196(GClass12.smethod_1());

  private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
  {
    try
    {
      if (new List<string>()
      {
        "cStt",
        "cFriend",
        "cGroup",
        "cFollow"
      }.Contains(e.Column.Name))
      {
        string s1 = e.CellValue1.ToString().Trim() == "" ? "-2" : (!GClass19.smethod_51(e.CellValue1.ToString()) ? "-1" : e.CellValue1.ToString());
        string s2 = e.CellValue2.ToString().Trim() == "" ? "-2" : (!GClass19.smethod_51(e.CellValue2.ToString()) ? "-1" : e.CellValue2.ToString());
        e.SortResult = int.Parse(s1).CompareTo(int.Parse(s2));
        e.Handled = true;
      }
      else if (e.Column.Name == "cInteractEnd")
      {
        e.SortResult = !(e.CellValue1.ToString() == "") && !(e.CellValue2.ToString() == "") ? GClass19.smethod_84(e.CellValue1.ToString()).CompareTo(GClass19.smethod_84(e.CellValue2.ToString())) : (e.CellValue1.ToString() == "" ? "" : e.CellValue1.ToString()).CompareTo(e.CellValue2.ToString() == "" ? "" : e.CellValue2.ToString());
        e.Handled = true;
      }
      else if (e.Column.Name == "cStatus")
      {
        string str1 = e.CellValue1.ToString();
        string str2 = e.CellValue2.ToString();
        string str3 = !str1.StartsWith("(") ? str1 : str1.Substring(str1.IndexOf(")") + 1).Trim();
        string strB = !str2.StartsWith("(") ? str2 : str2.Substring(str2.IndexOf(")") + 1).Trim();
        e.SortResult = str3.CompareTo(strB);
        e.Handled = true;
      }
      else if (e.Column.Name == "cBirthday")
      {
        string str4 = e.CellValue1.ToString();
        string str5 = e.CellValue2.ToString();
        string s3;
        if (!(str4 == ""))
        {
          if (str4.Split('/').Length < 3)
            s3 = "-1";
          else
            s3 = str4.Split('/')[2];
        }
        else
          s3 = "-1";
        int num1 = int.Parse(s3);
        string s4;
        if (!(str5 == ""))
        {
          if (str5.Split('/').Length < 3)
            s4 = "-1";
          else
            s4 = str5.Split('/')[2];
        }
        else
          s4 = "-1";
        int num2 = int.Parse(s4);
        e.SortResult = num1.CompareTo(num2);
        e.Handled = true;
      }
      else if (e.Column.Name == "cDateCreateAcc")
      {
        string str6 = e.CellValue1.ToString();
        string str7 = e.CellValue2.ToString();
        string s5;
        if (!(str6 == ""))
        {
          if (str6.Split(',').Length < 2)
            s5 = "-1";
          else
            s5 = str6.Split(',')[1];
        }
        else
          s5 = "-1";
        int num3 = int.Parse(s5);
        string s6;
        if (!(str7 == ""))
        {
          if (str7.Split(',').Length < 2)
            s6 = "-1";
          else
            s6 = str7.Split(',')[1];
        }
        else
          s6 = "-1";
        int num4 = int.Parse(s6);
        e.SortResult = num3.CompareTo(num4);
        e.Handled = true;
      }
      else
      {
        e.SortResult = (e.CellValue1.ToString() == "" ? "" : e.CellValue1.ToString()).CompareTo(e.CellValue2.ToString() == "" ? "" : e.CellValue2.ToString());
        e.Handled = true;
      }
    }
    catch (Exception ex)
    {
      e.SortResult = -1.CompareTo(-1);
      e.Handled = true;
    }
  }

  private void toolStripMenuItem_21_Click(object sender, EventArgs e)
  {
    string str = GClass33.smethod_0("configDatagridview").method_11();
    GClass19.smethod_35((Form) new fCauHinhHienThi());
    if (!(str != GClass33.smethod_0("configDatagridview").method_11()))
      return;
    this.method_195();
  }

  private void useragentToolStripMenuItem_Click(object sender, EventArgs e) => this.method_136("Useragent");

  private void method_168(object sender, EventArgs e)
  {
    if (this.method_176() == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn những tài khoản muốn nhập Proxy!"), 3);
    else
      GClass19.smethod_35((Form) new fImportProxy());
  }

  private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    this.bool_0 = false;
    new Thread((ThreadStart) (() =>
    {
      this.method_135("start");
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
                this.method_184(int_2, GClass35.smethod_0("Đang kiểm tra..."));
                this.method_169(int_2);
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
      this.method_135("stop");
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_169(int int_4)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_4].Cells["cProxy"].Value.ToString();
      if (string_0.Trim() == "")
      {
        this.method_184(int_4, GClass35.smethod_0("Proxy trống!"));
      }
      else
      {
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
          this.method_184(int_4, "Proxy Die!");
        else
          this.method_184(int_4, "Proxy Live!");
      }
    }
    catch
    {
      this.method_184(int_4, "Error!");
    }
  }

  private void proxyToolStripMenuItem_Click(object sender, EventArgs e) => this.method_136("Proxy");

  private void useragentToolStripMenuItem1_Click(object sender, EventArgs e) => this.method_11("useragent");

  private void proxyToolStripMenuItem1_Click(object sender, EventArgs e) => this.method_11("proxy");

  private void ghiChuToolStripMenuItem_Click(object sender, EventArgs e) => this.method_136("Notes");

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
    {
      try
      {
        Process.Start(Path.GetDirectoryName(Application.ExecutablePath));
      }
      catch
      {
      }
    }
    else
    {
      if ((e as MouseEventArgs).Button != MouseButtons.Left || Control.ModifierKeys != Keys.Control)
        return;
      new Thread((ThreadStart) (() =>
      {
        try
        {
          GClass19.smethod_63(Application.ExecutablePath + " a");
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

  private void toolStripMenuItem_22_Click(object sender, EventArgs e) => this.method_136("Birthday");

  private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!this.bool_3 || this.cbbTinhTrang.SelectedValue == null || !GClass15.smethod_0(this.cbbTinhTrang.SelectedValue.ToString()) || this.cbbTinhTrang.SelectedValue.ToString() != "-1" && this.int_2 == this.cbbTinhTrang.SelectedIndex)
      return;
    switch (this.cbbThuMuc.SelectedValue.ToString())
    {
      case "-1":
        this.method_7(string_0: this.cbbTinhTrang.Text);
        break;
      case "999999":
        this.method_7(fChonThuMuc.list_0, this.cbbTinhTrang.Text);
        break;
      default:
        this.method_7(this.method_6(), this.cbbTinhTrang.Text);
        break;
    }
    this.int_2 = this.cbbTinhTrang.SelectedIndex;
  }

  private bool method_170(string string_0, string string_1)
  {
    try
    {
      string_1 = GClass19.smethod_62(string_1);
      if (string_0.StartsWith("profiles\\"))
        string_0 = Application.StartupPath + "\\" + string_0;
      string str = Application.StartupPath + "\\images\\chrome.ico";
      if (!File.Exists(str))
      {
        using (FileStream outputStream = new FileStream(str, FileMode.Create))
          Resource.Icon_0.Save((Stream) outputStream);
      }
      if (GClass19.smethod_24(string_1, GClass33.smethod_0("configInteractGeneral").method_1("txtPathShortcut"), string_0, str, GClass33.smethod_0("configInteractGeneral").method_1("txtPathChromeOrigin")))
        return true;
    }
    catch
    {
    }
    return false;
  }

  private void toolStripMenuItem_3_Click(object sender, EventArgs e) => this.method_19(false);

  private void toolStripMenuItem_23_Click(object sender, EventArgs e) => this.method_139(4);

  private void method_171(object sender, EventArgs e)
  {
  }

  private void loginHotmailToolStripMenuItem_Click(object sender, EventArgs e) => this.method_172();

  private void method_172()
  {
    List<int> list_0 = new List<int>();
    for (int index = 0; index < this.method_176(); ++index)
      list_0.Add(0);
    this.list_0 = new List<Thread>();
    new Thread((ThreadStart) (() =>
    {
      try
      {
        int index = 0;
        while (index < this.dtgvAcc.Rows.Count)
        {
          if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          {
            int int_0 = index++;
            Thread thread = new Thread((ThreadStart) (() => this.method_173(int_0, GClass19.smethod_72(ref list_0))))
            {
              Name = int_0.ToString()
            };
            this.list_0.Add(thread);
            thread.IsBackground = true;
            thread.Start();
          }
          else
            ++index;
        }
      }
      catch (Exception ex)
      {
        GClass19.smethod_79((GClass18) null, ex, "LoginHotmail()");
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_173(int int_4, int int_5)
  {
    GClass18 gclass18_0 = (GClass18) null;
    string string_8_1 = this.method_191(int_4, "cEmail");
    string string_8_2 = this.method_191(int_4, "cPassMail");
    string str = Class44.smethod_12(this.random_0);
    try
    {
      this.method_184(int_4, GClass35.smethod_0("Đang mở trình duyệt..."));
      Point point1 = GClass19.smethod_71(int_5, 5, 2);
      Point point2 = GClass19.smethod_70(5, 2);
      bool flag = false;
      try
      {
        gclass18_0 = new GClass18()
        {
          Boolean_2 = false,
          Point_0 = point2,
          Point_1 = point1,
          Int32_1 = 3,
          Int32_2 = 60,
          String_0 = str
        };
        if (GClass33.smethod_0("configGeneral").method_3("typeBrowser") != 0)
          gclass18_0.String_4 = GClass33.smethod_0("configGeneral").method_1("txtLinkToOtherBrowser");
        if (!gclass18_0.method_0())
        {
          this.method_184(int_4, GClass35.smethod_0("Lỗi mở trình duyệt!"));
        }
        else
        {
          this.method_184(int_4, GClass35.smethod_0("Đang đăng nhập..."));
          if (string_8_1.Contains("hotmail") || string_8_1.Contains("outlook"))
          {
            gclass18_0.method_12("https://login.live.com/login.srf");
            gclass18_0.method_56(1.0);
            if (gclass18_0.method_38("[name=\"loginfmt\"]", 10.0) == 1)
            {
              gclass18_0.method_24(2, "loginfmt", string_8_1);
              gclass18_0.method_56(0.1);
              gclass18_0.method_21(1, "idSIButton9");
              if (gclass18_0.method_38("[name=\"passwd\"]", 10.0) == 1)
              {
                gclass18_0.method_56(2.0);
                gclass18_0.method_24(2, "passwd", string_8_2);
                gclass18_0.method_56(2.0);
                gclass18_0.method_21(1, "idSIButton9", int_9: 10);
                for (int index = 0; index < 10; ++index)
                {
                  switch (gclass18_0.method_41(0.0, "[name=\"DontShowAgain\"]", "#O365_MainLink_NavMenu"))
                  {
                    case 1:
                      gclass18_0.method_21(2, "DontShowAgain");
                      gclass18_0.method_56(0.1);
                      gclass18_0.method_21(1, "idSIButton9");
                      goto label_19;
                    case 2:
                      goto label_19;
                    default:
                      switch (gclass18_0.method_41(0.0, "#idA_IL_ForgotPassword0", "[name=\"passwd\"]"))
                      {
                        case 1:
                          this.method_184(int_4, GClass35.smethod_0("Mail sai pass!"));
                          return;
                        case 2:
                          this.method_184(int_4, GClass35.smethod_0("Không có pass mail!"));
                          return;
                        default:
                          if (gclass18_0.method_11().Contains("https://account.live.com/Abuse"))
                          {
                            this.method_184(int_4, GClass35.smethod_0("Mail đã bị khóa!"));
                            return;
                          }
                          gclass18_0.method_56(1.0);
                          continue;
                      }
                  }
                }
label_19:
                if (!gclass18_0.method_11().StartsWith("https://outlook.live.com"))
                  gclass18_0.method_12("https://outlook.live.com/mail/0/");
                flag = true;
              }
            }
          }
          else if (string_8_1.Contains("yandex"))
          {
            gclass18_0.method_12("https://passport.yandex.com/auth?from=mail&origin=hostroot_homer_auth_com&retpath=https%3A%2F%2Fmail.yandex.com%2F&backpath=https%3A%2F%2Fmail.yandex.com%3Fnoretpath%3D1");
            gclass18_0.method_56(1.0);
            if (gclass18_0.method_38("#passp-field-login", 10.0) == 1)
            {
              gclass18_0.method_24(1, "passp-field-login", string_8_1);
              gclass18_0.method_56(0.1);
              gclass18_0.method_21(4, ".Button2_type_submit");
              if (gclass18_0.method_38("#passp-field-passwd", 10.0) == 1)
              {
                gclass18_0.method_24(1, "passp-field-passwd", string_8_2);
                gclass18_0.method_56(0.1);
                gclass18_0.method_21(4, ".Button2_type_submit");
                while (true)
                {
                  switch (gclass18_0.method_41(10.0, ".mail-ComposeButton", ".Textinput-Hint_state_error", "[data-t=\"phone_skip\"]"))
                  {
                    case 1:
                      goto label_28;
                    case 3:
                      gclass18_0.method_56(1.0);
                      gclass18_0.method_21(4, "[data-t=\"phone_skip\"]");
                      gclass18_0.method_56(2.0);
                      continue;
                    default:
                      goto label_31;
                  }
                }
label_28:
                flag = true;
label_31:;
              }
            }
          }
          else
          {
            gclass18_0.method_12("https://outlook.office.com/mail/inbox");
            gclass18_0.method_56(1.0);
            if (gclass18_0.method_38("[name=\"loginfmt\"]", 10.0) == 1)
            {
              gclass18_0.method_24(2, "loginfmt", string_8_1);
              gclass18_0.method_56(0.1);
              gclass18_0.method_21(1, "idSIButton9");
              if (gclass18_0.method_38("[name=\"passwd\"]", 10.0) == 1)
              {
                gclass18_0.method_24(2, "passwd", string_8_2);
                gclass18_0.method_56(2.0);
                gclass18_0.method_21(1, "idSIButton9", int_9: 10);
                if (gclass18_0.method_41(10.0, "[name=\"DontShowAgain\"]", "#O365_MainLink_NavMenu") == 1)
                {
                  gclass18_0.method_21(2, "DontShowAgain");
                  gclass18_0.method_56(0.1);
                  gclass18_0.method_21(1, "idSIButton9");
                }
                gclass18_0.method_14("https://outlook.office.com/mail/inbox");
                flag = true;
              }
            }
          }
          if (!flag)
            return;
          this.method_184(int_4, GClass35.smethod_0("Đăng nhập thành công!"));
        }
      }
      catch (Exception ex)
      {
        this.method_184(int_4, GClass35.smethod_0("Lỗi đăng nhập!"));
        GClass19.smethod_79(gclass18_0, ex, "Login Error!");
      }
    }
    catch (Exception ex)
    {
      this.method_184(int_4, GClass35.smethod_0("Lỗi không xác định!"));
      GClass19.smethod_79(gclass18_0, ex);
    }
  }

  private void method_174(object sender, EventArgs e) => this.method_175();

  private void method_175(int int_4 = 1)
  {
    try
    {
      for (int index1 = 0; index1 < int_4; ++index1)
      {
        if (this.dtgvAcc.RowCount > 1)
        {
          List<DataGridViewRow> dataGridViewRowList = new List<DataGridViewRow>();
          foreach (DataGridViewRow row in (IEnumerable) this.dtgvAcc.Rows)
            dataGridViewRowList.Add(row);
          int count = dataGridViewRowList.Count;
          while (count > 1)
          {
            --count;
            int index2 = Class54.random_0.Next(count + 1);
            DataGridViewRow dataGridViewRow = dataGridViewRowList[index2];
            dataGridViewRowList[index2] = dataGridViewRowList[count];
            dataGridViewRowList[count] = dataGridViewRow;
          }
          this.dtgvAcc.Rows.Clear();
          foreach (DataGridViewRow dataGridViewRow in dataGridViewRowList)
            this.dtgvAcc.Rows.Add(dataGridViewRow);
        }
      }
    }
    catch
    {
    }
  }

  public int method_176()
  {
    int num = 0;
    try
    {
      num = Convert.ToInt32(this.lblCountSelect.Text);
    }
    catch
    {
    }
    return num;
  }

  private void method_177(object sender, EventArgs e)
  {
    if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có chắc muốn xóa dữ liệu backup của {0} tài khoản?"), (object) this.method_176())) != DialogResult.Yes)
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
              this.method_184(int_2, GClass35.smethod_0("Đang xóa dữ liệu backup..."));
              this.method_178(int_2);
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

  private void method_178(int int_4)
  {
    try
    {
      string string_0 = this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
      string str = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      if (str.Trim() == "")
      {
        this.method_184(int_4, GClass35.smethod_0("Chưa backup!"));
      }
      else
      {
        string path = "backup\\" + str;
        if (Directory.Exists(path))
        {
          Directory.Delete(path, true);
          this.method_184(int_4, GClass35.smethod_0("Xóa dữ liệu backup thành công!"));
          this.method_186(int_4, "cBackup", (object) "");
          Class42.smethod_13(string_0, "backup", "");
        }
        else
          this.method_184(int_4, GClass35.smethod_0("Chưa backup!"));
      }
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Xóa dữ liệu backup thất bại!"));
    }
  }

  private void method_179(object sender, EventArgs e)
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
              this.method_184(int_2, "Check backup...");
              this.method_180(int_2, string_0);
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

  private void method_180(int int_4, string string_0)
  {
    try
    {
      string string_0_1 = this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
      string str = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      string_0 = string_0 + "\\" + str + "\\" + str + ".txt";
      if (File.Exists(string_0))
      {
        this.method_184(int_4, GClass35.smethod_0("Đã backup!"));
        this.method_186(int_4, "cBackup", (object) GClass19.smethod_19(string_0));
        Class42.smethod_13(string_0_1, "backup", GClass19.smethod_19(string_0));
      }
      else
      {
        this.method_184(int_4, GClass35.smethod_0("Chưa backup!"));
        this.method_186(int_4, "cBackup", (object) "");
        Class42.smethod_13(string_0_1, "backup", "");
      }
    }
    catch
    {
    }
  }

  private void checkInfoUIDToolStripMenuItem_Click(object sender, EventArgs e) => this.method_139(5);

  private void toolStripMenuItem_24_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fNhapTokenTrungGian_DownAvatar());
    if (!fNhapTokenTrungGian_DownAvatar.bool_0)
      return;
    string string_0 = GClass33.smethod_0("configGeneral").method_1("pathFolderAvatar");
    if (!Directory.Exists(string_0))
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng kiểm tra lại Nơi lưu Avatar!"), 2);
    }
    else
    {
      int int_0 = 0;
      int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
      this.bool_0 = false;
      new Thread((ThreadStart) (() =>
      {
        this.method_135("start");
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
                  this.method_184(int_2, GClass35.smethod_0("Đang kiểm tra..."));
                  this.method_181(int_2, string_0);
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
        this.method_135("stop");
      }))
      {
        IsBackground = true
      }.Start();
    }
  }

  private void method_181(int int_4, string string_0)
  {
    try
    {
      string string_0_1 = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
      if (Class38.smethod_28(string_0_1, string_0))
        this.method_184(int_4, GClass35.smethod_0("Tải xuống thành công!"));
      else
        this.method_184(int_4, GClass35.smethod_0("Tải xuống thất bại!"));
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "DownloadAvatar");
      this.method_184(int_4, GClass35.smethod_0("Tải xuống thất bại!"));
    }
  }

  private void method_182(int int_4, string string_0, string string_1)
  {
    try
    {
      string string_0_1 = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
      if (Class38.smethod_15(string_0_1, string_0, string_1))
        this.method_184(int_4, GClass35.smethod_0("Tải xuống thành công!"));
      else
        this.method_184(int_4, GClass35.smethod_0("Tải xuống thất bại!"));
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "DownloadAvatar");
      this.method_184(int_4, GClass35.smethod_0("Tải xuống thất bại!"));
    }
  }

  private void toolStripMenuItem_25_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fBin());

  private void method_183(int int_4)
  {
    try
    {
      this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
      string str = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      if (str.Trim() == "")
      {
        this.method_184(int_4, GClass35.smethod_0("Chưa tạo profile!"));
      }
      else
      {
        string path = GClass33.smethod_0("configGeneral").method_1("txbPathProfile") + "\\" + str;
        if (Directory.Exists(path))
        {
          Directory.Delete(path + "\\Default\\Cache", true);
          this.method_184(int_4, GClass35.smethod_0("Xóa Cache Profile thành công!"));
        }
        else
          this.method_184(int_4, GClass35.smethod_0("Chưa tạo profile!"));
      }
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Xóa Cache Profile thất bại!"));
    }
  }

  private void toolStripMenuItem_27_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fTienIchLocTrung());

  private void toolStripMenuItem_28_Click(object sender, EventArgs e)
  {
    try
    {
      Process.Start("chrome.exe", "http://app.minsoftware.xyz/textfree.html");
    }
    catch
    {
      Process.Start("http://app.minsoftware.xyz/textfree.html");
    }
  }

  private void checkCookieToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void checkHotmailToolStripMenuItem_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fTienIchCheckImapHotmail());

  private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    try
    {
      this.dtgvAcc.CurrentRow.Cells["cChose"].Value = (object) !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value);
      this.method_138();
    }
    catch
    {
    }
  }

  private void btnEditFile_Click(object sender, EventArgs e)
  {
    List<string> stringList = this.method_6();
    if (stringList == null || stringList.Count != 1)
      return;
    fEditFile fEditFile = new fEditFile(stringList[0], this.cbbThuMuc.Text);
    fEditFile.ShowInTaskbar = false;
    int num = (int) fEditFile.ShowDialog();
    int selectedIndex = this.cbbThuMuc.SelectedIndex;
    if (fEditFile.bool_0)
    {
      this.method_4();
      this.int_1 = -1;
      this.cbbThuMuc.SelectedIndex = selectedIndex;
    }
  }

  private void checkProxyToolStripMenuItem1_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fTienIchCheckProxy());

  private void toolStripMenuItem_29_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fNhapCookieTrungGian());
    if (!fNhapCookieTrungGian.bool_0)
      return;
    this.method_154(4);
  }

  private void lToolStripMenuItem_Click(object sender, EventArgs e)
  {
    fLocTheoDanhSachUid form_0 = new fLocTheoDanhSachUid();
    GClass19.smethod_35((Form) form_0);
    if (form_0.list_0.Count <= 0)
      return;
    DataTable dataTable_0 = Class42.smethod_34(GClass19.smethod_27(form_0.list_0));
    this.dtgvAcc.Rows.Clear();
    this.method_8(dataTable_0);
  }

  private void toolStripMenuItem_1_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fCauHinhTuongTac());

  public void method_184(int int_4, string string_0, int int_5 = 0, GClass27 gclass27_0 = null)
  {
    if (gclass27_0 != null)
    {
      bool flag;
      if (!(flag = GClass33.smethod_0("configDebug").method_4("ckbLoginFail") && (string_0.Contains(GClass35.smethod_0("Đăng nhập thất bại!")) || string_0.Contains("Login fail"))))
        flag = GClass33.smethod_0("configDebug").method_4("ckbCheckSpam") && string_0.Contains("Facebook Spam");
      if (flag)
        gclass27_0.method_178();
    }
    if (int_5 > 0)
      Class14.smethod_0(this.dtgvAcc, int_4, "cStatus", int_5, string_0);
    else
      Class14.Status(this.dtgvAcc, int_4, "cStatus", (object) string_0);
  }

  public void method_185(int int_4, string string_0, GClass27 gclass27_0 = null)
  {
    if (gclass27_0 != null)
    {
      bool flag;
      if (!(flag = string_0.Contains("Checkpoint") && GClass33.smethod_0("configDebug").method_4("ckbCheckpoint")))
        flag = string_0.Contains("Changed pass") && GClass33.smethod_0("configDebug").method_4("ckbChangedPass");
      if (flag)
        gclass27_0.method_178();
    }
    Class14.Status(this.dtgvAcc, int_4, "cInfo", (object) string_0);
    this.method_193(int_4);
    Class42.smethod_13(this.method_191(int_4, "cId"), "info", string_0);
  }

  public void method_186(int int_4, string string_0, object object_17, bool bool_5 = true)
  {
    if (!bool_5 && object_17.ToString().Trim() == "")
      return;
    Class14.Status(this.dtgvAcc, int_4, string_0, object_17);
  }

  public void method_187(
    int int_4,
    string string_0,
    string string_1,
    string string_2,
    bool bool_5 = true)
  {
    if (!bool_5 && string_1.ToString().Trim() == "")
      return;
    Class14.Status(this.dtgvAcc, int_4, string_0, (object) string_1);
    Class42.smethod_13(this.method_191(int_4, "cId"), string_2, string_1);
  }

  public void method_188(int int_4, int int_5, object object_17) => Class14.smethod_4(this.dtgvAcc, int_4, int_5, object_17);

  public string method_189(int int_4)
  {
    string str = Class14.smethod_3(this.dtgvAcc, int_4, "cStatus");
    return str.StartsWith("(") ? str.Substring(str.IndexOf(')') + 1).Trim() : str;
  }

  public string method_190(int int_4) => Class14.smethod_3(this.dtgvAcc, int_4, "cInfo");

  public string method_191(int int_4, string string_0) => Class14.smethod_3(this.dtgvAcc, int_4, string_0);

  public string method_192(int int_4, int int_5) => Class14.smethod_2(this.dtgvAcc, int_4, int_5);

  private void method_193(int int_4 = -1)
  {
    if (GClass33.smethod_0("configGeneral").method_3("typePhanBietMau") == 0)
    {
      if (int_4 == -1)
      {
        for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
        {
          string str = this.method_190(index);
          if (str == "Live")
            this.dtgvAcc.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
          else if (str.Contains("Die") || str.Contains("Checkpoint") || str.Contains("Changed pass"))
            this.dtgvAcc.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
        }
      }
      else
      {
        string str = this.method_190(int_4);
        if (str == "Live")
          this.dtgvAcc.Rows[int_4].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
        else if (str.Contains("Die") || str.Contains("Checkpoint") || str.Contains("Changed pass"))
          this.dtgvAcc.Rows[int_4].DefaultCellStyle.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
      }
    }
    else if (int_4 == -1)
    {
      for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      {
        string str = this.method_190(index);
        if (str == "Live")
          this.dtgvAcc.Rows[index].DefaultCellStyle.ForeColor = Color.Green;
        else if (str.Contains("Die") || str.Contains(GClass35.smethod_0("Checkpoint")) || str.Contains("Changed pass"))
          this.dtgvAcc.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
      }
    }
    else
    {
      string str = this.method_190(int_4);
      if (str == "Live")
        this.dtgvAcc.Rows[int_4].DefaultCellStyle.ForeColor = Color.Green;
      else if (str.Contains("Die") || str.Contains(GClass35.smethod_0("Checkpoint")) || str.Contains("Changed pass"))
        this.dtgvAcc.Rows[int_4].DefaultCellStyle.ForeColor = Color.Red;
    }
  }

  private void method_194(int int_4, int int_5)
  {
    switch (int_5)
    {
      case 1:
        this.dtgvAcc.Rows[int_4].DefaultCellStyle.BackColor = Color.FromArgb((int) byte.MaxValue, 182, 193);
        break;
      case 2:
        this.dtgvAcc.Rows[int_4].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
        break;
    }
  }

  private void method_195()
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
    this.dtgvAcc.Columns["cPhone"].Visible = GClass33.smethod_0("configDatagridview").method_4("ckbPhone");
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

  private void toolStripMenuItem_30_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fCapNhatDuLieu());
    if (!fCapNhatDuLieu.bool_0)
      return;
    this.btnLoadAcc_Click((object) null, (EventArgs) null);
  }

  private void loginYandexToolStripMenuItem_Click(object sender, EventArgs e) => this.method_172();

  private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
  {
    if (!this.bool_4 || e.ColumnIndex != 0)
      return;
    this.method_138();
  }

  private void method_196(string string_0)
  {
    GClass19.smethod_35((Form) new fSelectFolder());
    string string0 = fSelectFolder.string_0;
    if (string0 == "")
      return;
    List<string> list_1 = new List<string>();
    for (int int_4 = 0; int_4 < this.dtgvAcc.Rows.Count; ++int_4)
    {
      try
      {
        if (Convert.ToBoolean(this.method_191(int_4, "cChose")))
        {
          string str = this.method_191(int_4, "cUid");
          list_1.Add(string_0 + "\\" + str + "|" + string0 + "\\" + str);
        }
      }
      catch
      {
      }
    }
    if (list_1.Count <= 0)
      return;
    GClass19.smethod_35((Form) new fShowProgressBar(list_1));
    GClass14.smethod_0((object) GClass35.smethod_0("Đã copy dữ liệu xong!"));
  }

  private void checkLiveUidToolStripMenuItem_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fTienIchCheckLiveUid());

  private void method_197(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = 10;
    new Thread((ThreadStart) (() =>
    {
      int int_4 = 0;
      while (int_4 < this.dtgvAcc.RowCount)
      {
        if (Convert.ToBoolean(this.method_191(int_4, "cChose")))
        {
          if (int_0 < int_1)
          {
            Interlocked.Increment(ref int_0);
            int int_2 = int_4++;
            new Thread((ThreadStart) (() =>
            {
              this.method_184(int_2, "Check profile LD...");
              this.method_198(int_2);
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
          ++int_4;
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_198(int int_4)
  {
    try
    {
      string string_0 = this.method_191(int_4, "cId");
      string str1 = this.method_191(int_4, "cUid");
      string str2 = GClass13.smethod_0() + "\\profile\\" + str1;
      string path1 = str2 + "\\data.tar.gz";
      string path2 = str2 + ".zip";
      if (File.Exists(path1) || File.Exists(path2))
      {
        this.method_184(int_4, GClass35.smethod_0("Đã backup LD!"));
        this.method_186(int_4, "cProfile", (object) "Yes");
        Class42.smethod_13(string_0, "profile", "Yes");
      }
      else
      {
        this.method_184(int_4, GClass35.smethod_0("Chưa backup LD!"));
        this.method_186(int_4, "cProfile", (object) "No");
        Class42.smethod_13(string_0, "profile", "No");
      }
    }
    catch
    {
    }
  }

  private void method_199(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = 10;
    string string_0 = GClass12.smethod_2(1);
    new Thread((ThreadStart) (() =>
    {
      int int_4 = 0;
      while (int_4 < this.dtgvAcc.RowCount)
      {
        if (Convert.ToBoolean(this.method_191(int_4, "cChose")))
        {
          if (int_0 < int_1)
          {
            Interlocked.Increment(ref int_0);
            int int_2 = int_4++;
            new Thread((ThreadStart) (() =>
            {
              this.method_184(int_2, "Check...");
              this.method_200(int_2, string_0);
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
          ++int_4;
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_200(int int_4, string string_0)
  {
    try
    {
      string string_0_1 = this.method_191(int_4, "cId");
      this.method_191(int_4, "cUid");
      string str1 = this.method_191(int_4, "cDevice");
      string str2 = string_0 + "\\vms\\leidian" + str1;
      if (str1 == "" || !Directory.Exists(str2))
      {
        this.method_184(int_4, GClass35.smethod_0("Tài khoản này chưa tạo LD!"));
      }
      else
      {
        this.method_184(int_4, "Get token/cookie...");
        string str3 = this.method_201(str2);
        if (str3 != "|")
        {
          string str4 = str3.Split('|')[0];
          string str5 = str3.Split('|')[1];
          if (str4 != "")
          {
            this.method_186(int_4, "cToken", (object) str4);
            Class42.smethod_13(string_0_1, "token", str4);
          }
          if (str5 != "")
          {
            this.method_186(int_4, "cCookies", (object) str5);
            Class42.smethod_13(string_0_1, "cookie1", str5);
          }
          this.method_184(int_4, GClass35.smethod_0("Đã cập nhật token/cookie!"));
          this.method_194(int_4, 2);
        }
        else
          this.method_184(int_4, GClass35.smethod_0("Không lấy được token/cookie!"));
      }
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Không lấy được token/cookie!"));
    }
  }

  public string method_201(string string_0)
  {
    string path = Path.Combine(string_0, "data.vmdk");
    string str1 = "";
    string str2 = "";
    string str3 = "";
    if (File.Exists(path))
    {
      using (FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
      {
        using (BufferedStream bufferedStream = new BufferedStream((Stream) fileStream))
        {
          using (StreamReader streamReader = new StreamReader((Stream) bufferedStream))
          {
            string input;
            while ((input = streamReader.ReadLine()) != null)
            {
              if (!input.Contains("access_token\":\""))
              {
                if (input.Contains("accessToken\":\""))
                {
                  string str4 = Regex.Split(input, "accessToken\":\"")[1].Split('"')[0];
                  Console.WriteLine(str4);
                  str1 = str4;
                  if (str2 != "" && str1 != "")
                    break;
                }
                else if (input.Contains("[{\"name\":\"c_user\""))
                {
                  JArray jarray = JArray.Parse("[{\"name\":\"c_user\"" + input.Split(new string[1]
                  {
                    "[{\"name\":\"c_user\""
                  }, StringSplitOptions.None)[1].Split(']')[0].Replace("\\\"", "\"") + "]");
                  List<string> values = new List<string>();
                  foreach (JToken jtoken in jarray)
                    values.Add(jtoken[(object) "name"].ToString() + "=" + jtoken[(object) "value"].ToString());
                  str2 = string.Join("; ", (IEnumerable<string>) values);
                  if (str2 != "" && str1 != "")
                    break;
                }
              }
              else
              {
                str1 = Regex.Split(input, "access_token\":\"")[1].Split('"')[0];
                JArray jarray = JArray.Parse(Regex.Split(input, "session_cookie_string\":\"")[1].Split(']')[0].Replace("\\\"", "\"") + "]");
                List<string> values = new List<string>();
                foreach (JToken jtoken in jarray)
                  values.Add(jtoken[(object) "name"].ToString() + "=" + jtoken[(object) "value"].ToString());
                str2 = string.Join("; ", (IEnumerable<string>) values);
                break;
              }
            }
          }
        }
      }
      str3 = str1 + "|" + str2;
    }
    return str3;
  }

  private void method_202(object sender, EventArgs e)
  {
    try
    {
      if (this.method_176() == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn tài khoản muốn chạy!"), 3);
      }
      else
      {
        string string_0 = GClass12.smethod_2(1);
        if (string_0 == "")
          GClass14.smethod_0((object) GClass35.smethod_0("Đường dẫn LDPlayer trống!"), 3);
        else if (!Directory.Exists(string_0))
        {
          GClass14.smethod_0((object) GClass35.smethod_0("Đường dẫn LDPlayer không hợp lệ!"), 3);
        }
        else
        {
          this.method_135("start");
          int int_0 = 0;
          int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
          this.bool_0 = false;
          new Thread((ThreadStart) (() =>
          {
            int index = 0;
            while (index < this.dtgvAcc.Rows.Count && !this.bool_0)
            {
              if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
              {
                if (int_0 < int_1)
                {
                  Interlocked.Increment(ref int_0);
                  int int_2 = index++;
                  new Thread((ThreadStart) (() =>
                  {
                    this.method_184(int_2, GClass35.smethod_0("Đang check..."));
                    this.method_203(int_2, string_0);
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
            this.method_135("stop");
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
  }

  private void method_203(int int_4, string string_0)
  {
    string string_0_1 = this.method_191(int_4, "cId");
    string str = this.method_191(int_4, "cDevice");
    if (str != "" && Directory.Exists(string_0 + "\\vms\\leidian" + str))
    {
      try
      {
        this.method_184(int_4, GClass35.smethod_0("Đang xóa LDPlayer..."));
        Directory.Delete(string_0 + "\\vms\\leidian" + str, true);
        this.method_186(int_4, "cDevice", (object) "");
        Class42.smethod_14(string_0_1, "device", "");
        this.method_184(int_4, GClass35.smethod_0("Xóa LDPlayer thành công!"));
      }
      catch
      {
        this.method_184(int_4, GClass35.smethod_0("Xóa LDPlayer thất bại!"));
      }
    }
    else
      this.method_184(int_4, GClass35.smethod_0("Chưa tạo LDPlayer!"));
  }

  private void toolStripStatusLabel4_Click(object sender, EventArgs e)
  {
  }

  private void dtgvAcc_SelectionChanged(object sender, EventArgs e) => this.lblCountHighline.Text = this.dtgvAcc.SelectedRows.Count.ToString();

  private void checkStatusXproxyToolStripMenuItem_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fTienIchCheckStatusXProxy());

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
  }

  private void method_204(object sender, EventArgs e)
  {
    if (GClass14.smethod_1(string.Format(GClass35.smethod_0("Bạn có chắc muốn xóa file backup info device của {0} tài khoản?"), (object) this.method_176())) != DialogResult.Yes)
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
              this.method_184(int_2, GClass35.smethod_0("Đang xóa backup device..."));
              this.method_205(int_2);
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

  private void method_205(int int_4)
  {
    try
    {
      this.dtgvAcc.Rows[int_4].Cells["cId"].Value.ToString();
      string str = this.dtgvAcc.Rows[int_4].Cells["cUid"].Value.ToString();
      string path = GClass13.smethod_0() + "\\device\\" + str;
      if (str.Trim() == "")
        this.method_184(int_4, GClass35.smethod_0("Chưa backup device!"));
      else if (Directory.Exists(path))
      {
        try
        {
          Directory.Delete(path, true);
          this.method_184(int_4, GClass35.smethod_0("Xóa backup device thành công!"));
        }
        catch
        {
          this.method_184(int_4, GClass35.smethod_0("Xóa backup device thất bại!"));
        }
      }
      else
        this.method_184(int_4, GClass35.smethod_0("Chưa backup device!"));
    }
    catch
    {
      this.method_184(int_4, GClass35.smethod_0("Xóa backup device thất bại!"));
    }
  }

  private void method_206(object sender, EventArgs e) => this.method_207("CheckBackupDataFb");

  private void method_207(string string_0)
  {
    int int_0 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    string string_1 = "";
    if (string_0 == "CopyBackupDataFb" || string_0 == "CopyDataDevice")
    {
      string_1 = GClass19.smethod_45();
      if (string_1 == "")
        return;
    }
    new Thread((ThreadStart) (() =>
    {
      List<Thread> threadList1 = new List<Thread>();
      int index1 = 0;
      while (index1 < this.dtgvAcc.RowCount)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index1].Cells["cChose"].Value))
        {
          while (threadList1.Count >= int_0)
          {
            GClass19.smethod_64(1.0);
            int num;
            for (int index2 = 0; index2 < threadList1.Count; index2 = num + 1)
            {
              threadList1[index2].Join();
              List<Thread> threadList2 = threadList1;
              int index3 = index2;
              num = index3 - 1;
              threadList2.RemoveAt(index3);
            }
          }
          int int_ = index1++;
          Thread thread = new Thread((ThreadStart) (() =>
          {
            string s = string_0;
            // ISSUE: reference to a compiler-generated method
            switch (Class206.smethod_0(s))
            {
              case 149233318:
                if (!(s == "CopyDataDevice"))
                  break;
                this.method_214(int_, string_1);
                break;
              case 1214579449:
                if (!(s == "CheckBackupDataFb"))
                  break;
                this.method_208(int_);
                break;
              case 1338799404:
                if (!(s == "DeleteDataDevice"))
                  break;
                this.method_212(int_);
                break;
              case 1827507468:
                if (!(s == "DeleteBackupDataFb"))
                  break;
                this.method_209(int_);
                break;
              case 2616307503:
                if (!(s == "DeleteBackupGroup"))
                  break;
                this.method_211(int_);
                break;
              case 2851902418:
                if (!(s == "CopyBackupDataFb"))
                  break;
                this.method_213(int_, string_1);
                break;
              case 3276978916:
                if (!(s == "CheckBackupGroup"))
                  break;
                this.method_210(int_);
                break;
            }
          }));
          threadList1.Add(thread);
          thread.IsBackground = true;
          thread.Start();
        }
        else
          ++index1;
      }
      for (int index4 = 0; index4 < threadList1.Count; ++index4)
        threadList1[index4].Join();
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_208(int int_4)
  {
    string string_0 = this.method_191(int_4, "cId");
    string str = this.method_191(int_4, "cUid");
    if (File.Exists(GClass13.smethod_0() + "\\profile\\" + str + ".tar.gz"))
    {
      this.method_184(int_4, GClass35.smethod_0("Đã backup data app Fb!"));
      this.method_186(int_4, "cProfile", (object) "Yes");
      Class42.smethod_13(string_0, "profile", "Yes");
    }
    else
    {
      this.method_184(int_4, GClass35.smethod_0("Chưa backup data app Fb!"));
      this.method_186(int_4, "cProfile", (object) "No");
      Class42.smethod_13(string_0, "profile", "No");
    }
  }

  private void method_209(int int_4)
  {
    string string_0 = this.method_191(int_4, "cId");
    string str1 = this.method_191(int_4, "cUid");
    string str2 = GClass13.smethod_0() + "\\profile\\" + str1 + ".tar.gz";
    if (File.Exists(str2))
    {
      if (GClass19.smethod_98(str2))
      {
        this.method_184(int_4, GClass35.smethod_0("Xóa data app Fb thành công!"));
        this.method_186(int_4, "cProfile", (object) "No");
        Class42.smethod_13(string_0, "profile", "No");
      }
      else
        this.method_184(int_4, GClass35.smethod_0("Xóa data app Fb thất bại!"));
    }
    else
    {
      this.method_184(int_4, GClass35.smethod_0("Chưa backup data app Fb!"));
      this.method_186(int_4, "cProfile", (object) "No");
      Class42.smethod_13(string_0, "profile", "No");
    }
  }

  private void method_210(int int_4)
  {
    this.method_191(int_4, "cId");
    string str = this.method_191(int_4, "cUid");
    if (File.Exists(GClass13.smethod_0() + "\\backupgroup\\" + str + ".txt"))
      this.method_184(int_4, GClass35.smethod_0("Đã backup group!"));
    else
      this.method_184(int_4, GClass35.smethod_0("Chưa backup group!"));
  }

  private void method_211(int int_4)
  {
    this.method_191(int_4, "cId");
    string str1 = this.method_191(int_4, "cUid");
    string str2 = GClass13.smethod_0() + "\\backupgroup\\" + str1 + ".txt";
    if (File.Exists(str2))
    {
      if (GClass19.smethod_98(str2))
        this.method_184(int_4, GClass35.smethod_0("Xóa data backup group thành công!"));
      else
        this.method_184(int_4, GClass35.smethod_0("Xóa data backup group thất bại!"));
    }
    else
      this.method_184(int_4, GClass35.smethod_0("Chưa backup group!"));
  }

  private void method_212(int int_4)
  {
    this.method_191(int_4, "cId");
    string str1 = this.method_191(int_4, "cUid");
    string str2 = GClass13.smethod_0() + "\\device\\" + str1 + ".tar.gz";
    if (File.Exists(str2))
    {
      if (GClass19.smethod_98(str2))
        this.method_184(int_4, GClass35.smethod_0("Đã xóa data device!"));
      else
        this.method_184(int_4, GClass35.smethod_0("Xóa data device thất bại!"));
    }
    else
      this.method_184(int_4, GClass35.smethod_0("Chưa có data device!"));
  }

  private void method_213(int int_4, string string_0)
  {
    this.method_191(int_4, "cId");
    string str1 = this.method_191(int_4, "cUid");
    string str2 = GClass13.smethod_0() + "\\profile\\" + str1 + ".tar.gz";
    string string_1 = string_0 + "\\" + str1 + ".tar.gz";
    if (File.Exists(str2))
    {
      if (GClass19.smethod_95(str2, string_1))
        this.method_184(int_4, "Copy data app Fb " + GClass35.smethod_0("thành công") + "!");
      else
        this.method_184(int_4, "Copy data app Fb " + GClass35.smethod_0("thất bại") + "!");
    }
    else
    {
      this.method_184(int_4, GClass35.smethod_0("Chưa backup data app Fb!"));
      this.method_187(int_4, "cProfile", "No", "profile");
    }
  }

  private void method_214(int int_4, string string_0)
  {
    this.method_191(int_4, "cId");
    string str1 = this.method_191(int_4, "cUid");
    string str2 = GClass13.smethod_0() + "\\device\\" + str1 + ".tar.gz";
    string string_1 = string_0 + "\\" + str1 + ".tar.gz";
    if (File.Exists(str2))
    {
      if (GClass19.smethod_95(str2, string_1))
        this.method_184(int_4, "Copy data device " + GClass35.smethod_0("thành công") + "!");
      else
        this.method_184(int_4, "Copy data device " + GClass35.smethod_0("thất bại") + "!");
    }
    else
      this.method_184(int_4, GClass35.smethod_0("Chưa có data device!"));
  }

  private void toolStripMenuItem_32_Click(object sender, EventArgs e)
  {
    if (this.method_176() == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn những tài khoản muốn nhập Proxy!"), 3);
    else
      GClass19.smethod_35((Form) new fImportProxy());
  }

  private void toolStripMenuItem_33_Click(object sender, EventArgs e)
  {
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        this.dtgvAcc.Rows.RemoveAt(index--);
    }
    this.method_147();
    this.method_137();
    this.method_138(0);
  }

  public bool method_215(GClass27 gclass27_0, int int_4, string string_0, string string_1)
  {
label_16:
    gclass27_0.method_105(string_1);
    gclass27_0.SleepSeconds(2.0);
    if (string_1.StartsWith("fb://page/") && !string_1.Contains("invite_friends_to_like_page"))
    {
      gclass27_0.SleepSeconds(3.0);
      for (int index = 0; index < 5; ++index)
      {
        string string_11 = "";
        string str = gclass27_0.method_30(5, ref string_11, new List<string>()
        {
          "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View",
          "//*[@content-desc='Create Action Button']",
          "//*[@content-desc='Follow']",
          "(//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup)[last()]/child::*",
          "//*[@content-desc='page cover photo']"
        });
        if (str == "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View")
        {
          string string_0_1 = gclass27_0.method_37(0, string_11, "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View").FirstOrDefault<string>();
          if (new Class77(string_0_1).int_1 < 2000)
          {
            Class77 class77_1 = new Class77(string_0_1);
            Class77 class77_2 = new Class77(class77_1.int_0, 2000, class77_1.int_2, 2000);
            gclass27_0.method_75(class77_1.method_0(), class77_2.method_0());
          }
          else
            break;
        }
        else if (!(str != ""))
        {
          if (gclass27_0.method_150(string_11).Count != 2 || !gclass27_0.method_150(string_11).Contains("Back".ToLower()) || !gclass27_0.method_150(string_11).Contains("Search".ToLower()))
          {
            if (gclass27_0.method_78())
              break;
          }
          else
          {
            gclass27_0.method_28();
            gclass27_0.SleepSeconds(2.0);
            goto label_16;
          }
        }
        else
          break;
      }
    }
    if (string_1.Contains("/stories/") && gclass27_0.method_31(150, "", "(//*[@text='Stories'])[2]"))
      return true;
    switch (this.method_32(gclass27_0, int_4, string_0))
    {
      case 0:
        return true;
      case 1:
        goto label_16;
      default:
        return false;
    }
  }

  private void toolStripMenuItem3_Click(object sender, EventArgs e) => this.method_27(2);

  private void picLanguage_Click(object sender, EventArgs e)
  {
    if (this.picLanguage.Image == this.bitmap_0)
    {
      this.picLanguage.Image = (Image) this.bitmap_1;
      Class54.smethod_3();
      GClass14.smethod_0((object) "Vui lòng mở lại phần mềm để cập nhật ngôn ngữ!");
    }
    else
    {
      this.picLanguage.Image = (Image) this.bitmap_0;
      Class54.smethod_3("EN");
    }
    Class54.smethod_2();
    this.method_0();
  }

  private void copyDataDeviceToolStripMenuItem_Click(object sender, EventArgs e) => this.method_207("CopyDataDevice");

  private void toolStripMenuItem_34_Click(object sender, EventArgs e) => this.method_207("DeleteDataDevice");

  private void method_216(object sender, EventArgs e)
  {
    try
    {
      GClass19.smethod_35((Form) new fClearProfile());
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) ex.ToString(), 3);
    }
  }

  private void regAccTiktokToolStripMenuItem_Click(object sender, EventArgs e) => this.method_27(3);

  private void toolStripMenuItem4_Click(object sender, EventArgs e) => this.method_27(4);

  private void toolStripMenuItem_36_Click(object sender, EventArgs e)
  {
    int int_0 = 0;
    int int_1 = GClass33.smethod_0("configGeneral").method_3("nudHideThread", 10);
    this.bool_0 = false;
    new Thread((ThreadStart) (() =>
    {
      this.method_135("start");
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
                string string_0 = this.method_191(int_2, "cBirthday");
                string string_1 = GClass19.smethod_113(string_0);
                if (string_1 != "")
                {
                  if (string_1 != string_0)
                    this.method_187(int_2, "cBirthday", string_1, "birthday");
                  this.method_184(int_2, "Convert success!");
                }
                else
                  this.method_184(int_2, "Convert fail!");
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
      this.method_135("stop");
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void bunifuCustomLabel1_DoubleClick(object sender, EventArgs e)
  {
    ++this.int_3;
    if (this.int_3 < 3)
      return;
    this.int_3 = 0;
    int num = (int) new fCauHinhDebug().ShowDialog();
  }

  private void unlockCheckpointToolStripMenuItem_Click(object sender, EventArgs e) => this.method_27(5);

  private void checkFileBackupGroupToolStripMenuItem_Click(object sender, EventArgs e) => this.method_207("CheckBackupGroup");

  private void toolStripMenuItem_35_Click(object sender, EventArgs e) => this.method_207("DeleteBackupGroup");

  private void backupGroupToolStripMenuItem_Click(object sender, EventArgs e)
  {
    fCauHinhBackupGroup form_0 = new fCauHinhBackupGroup();
    GClass19.smethod_35((Form) form_0);
    if (!form_0.bool_0)
      return;
    if (GClass33.smethod_0("configBackupGroup").method_3("typeRun") == 0)
      this.method_27(6, gclass22_0: GClass33.smethod_0("configBackupGroup"));
    else if (GClass33.smethod_0("configBackupGroup").method_3("typeRun") != 1)
      ;
  }

  private void toolStripMenuItem_37_Click(object sender, EventArgs e)
  {
    fLocTheoDanhSachUid form_0 = new fLocTheoDanhSachUid();
    GClass19.smethod_35((Form) form_0);
    if (form_0.list_0.Count <= 0)
      return;
    List<string> stringList = GClass19.smethod_27(form_0.list_0);
    for (int int_4 = 0; int_4 < this.dtgvAcc.RowCount; ++int_4)
    {
      string str1 = this.method_191(int_4, "cUid");
      string str2 = this.method_191(int_4, "cEmail");
      this.method_186(int_4, "cChose", (object) (bool) (stringList.Contains(str1) ? 1 : (stringList.Contains(str2) ? 1 : 0)));
    }
    this.method_138();
  }

  private void toolStripMenuItem_38_Click(object sender, EventArgs e)
  {
    List<string> list_0 = new List<string>();
    List<string> stringList = new List<string>();
    int num = 0;
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
      {
        try
        {
          string str = this.method_191(index, "cUid");
          if (stringList.Contains(str))
          {
            list_0.Add(this.dtgvAcc.Rows[index].Cells["cId"].Value.ToString());
            this.dtgvAcc.Rows.RemoveAt(index);
            --index;
            ++num;
          }
          else
            stringList.Add(str);
        }
        catch
        {
        }
      }
    }
    Class42.smethod_25(list_0);
    this.method_147();
    this.method_137();
    this.method_138();
    GClass14.smethod_0((object) string.Format("Đã loại bỏ {0} tài khoản bị trùng!", (object) num));
  }

  private void txbSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.BtnSearch_Click((object) null, (EventArgs) null);
  }

  private void toolStripMenuItem5_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
      GClass14.smethod_0((object) Class76.int_0);
    else
      new fDeviceList().Show();
  }

  private void toolStripMenuItem_39_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fQuanLyNhom());

  private void testSpinTextToolStripMenuItem_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fTienIchTestSpinContent());

  private void toolStripMenuItem_40_Click(object sender, EventArgs e)
  {
    if (this.method_176() == 0)
    {
      GClass14.smethod_0((object) "Vui lòng chọn tài khoản muốn sử dụng chức năng này!", 3);
    }
    else
    {
      try
      {
        List<string> list_0 = new List<string>();
        for (int index = 0; index < this.dtgvAcc.Rows.Count; ++index)
        {
          if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
            list_0.Add(this.method_191(index, "cId"));
        }
        if (Class42.smethod_35(list_0))
        {
          this.btnLoadAcc_Click((object) null, (EventArgs) null);
          GClass19.smethod_36((object) "Khôi phục thành công!", 1);
        }
        else
          GClass19.smethod_36((object) "Khôi phục thất bại!", 2);
      }
      catch (Exception ex)
      {
      }
    }
  }

  private void loginPhoneToolStripMenuItem_Click(object sender, EventArgs e) => this.method_27(1);

  private void toolStripMenuItem6_Click(object sender, EventArgs e) => this.method_207("CheckBackupDataFb");

  private void toolStripMenuItem7_Click(object sender, EventArgs e) => this.method_207("CheckBackupDataFb");

  private void toolStripMenuItem9_Click(object sender, EventArgs e) => this.method_207("CopyBackupDataFb");

  private void toolStripMenuItem8_Click(object sender, EventArgs e) => this.method_207("DeleteBackupDataFb");

  private void donDepProfileToolStripMenuItem_Click(object sender, EventArgs e)
  {
    try
    {
      GClass19.smethod_35((Form) new fClearProfile());
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) ex.ToString(), 3);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fMain));
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    this.dtgvAcc = new DataGridView();
    this.ctmsAcc = new MetroContextMenu(this.components);
    this.toolStripMenuItem_2 = new ToolStripMenuItem();
    this.toolStripMenuItem_5 = new ToolStripMenuItem();
    this.liveToolStripMenuItem = new ToolStripMenuItem();
    this.tinhTrangToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_13 = new ToolStripMenuItem();
    this.toolStripMenuItem_37 = new ToolStripMenuItem();
    this.toolStripMenuItem_6 = new ToolStripMenuItem();
    this.toolStripMenuItem_33 = new ToolStripMenuItem();
    this.toolStripMenuItem_32 = new ToolStripMenuItem();
    this.copyToolStripMenuItem = new ToolStripMenuItem();
    this.uidToolStripMenuItem = new ToolStripMenuItem();
    this.passToolStripMenuItem = new ToolStripMenuItem();
    this.tokenToolStripMenuItem = new ToolStripMenuItem();
    this.cookieToolStripMenuItem = new ToolStripMenuItem();
    this.mailToolStripMenuItem = new ToolStripMenuItem();
    this.fAToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_19 = new ToolStripMenuItem();
    this.uidPassToolStripMenuItem = new ToolStripMenuItem();
    this.uidPass2FaToolStripMenuItem = new ToolStripMenuItem();
    this.mailPassMailToolStripMenuItem = new ToolStripMenuItem();
    this.uidPassTokenCookieToolStripMenuItem = new ToolStripMenuItem();
    this.uidPassTokenCookieMailPassMailToolStripMenuItem = new ToolStripMenuItem();
    this.uidPassTokenCookieMailPassMail2faToolStripMenuItem = new ToolStripMenuItem();
    this.useragentToolStripMenuItem1 = new ToolStripMenuItem();
    this.proxyToolStripMenuItem1 = new ToolStripMenuItem();
    this.devicesToolStripMenuItem = new ToolStripMenuItem();
    this.phoneToolStripMenuItem1 = new ToolStripMenuItem();
    this.toolStripMenuItem_16 = new ToolStripMenuItem();
    this.loginPhoneToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_3 = new ToolStripMenuItem();
    this.checkCookieToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_14 = new ToolStripMenuItem();
    this.checkInfoUIDToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_8 = new ToolStripMenuItem();
    this.toolStripMenuItem_7 = new ToolStripMenuItem();
    this.checkAvatarToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem6 = new ToolStripMenuItem();
    this.toolStripMenuItem_23 = new ToolStripMenuItem();
    this.checkProxyToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_17 = new ToolStripMenuItem();
    this.toolStripMenuItem_18 = new ToolStripMenuItem();
    this.toolStripMenuItem_29 = new ToolStripMenuItem();
    this.toolStripMenuItem_10 = new ToolStripMenuItem();
    this.toolStripMenuItem_30 = new ToolStripMenuItem();
    this.toolStripMenuItem_11 = new ToolStripMenuItem();
    this.tokenToolStripMenuItem2 = new ToolStripMenuItem();
    this.cookieToolStripMenuItem3 = new ToolStripMenuItem();
    this.toolStripMenuItem_15 = new ToolStripMenuItem();
    this.toolStripMenuItem_20 = new ToolStripMenuItem();
    this.useragentToolStripMenuItem = new ToolStripMenuItem();
    this.proxyToolStripMenuItem = new ToolStripMenuItem();
    this.phoneToolStripMenuItem = new ToolStripMenuItem();
    this.ghiChuToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_22 = new ToolStripMenuItem();
    this.toolStripMenuItem_4 = new ToolStripMenuItem();
    this.profileToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem7 = new ToolStripMenuItem();
    this.toolStripMenuItem8 = new ToolStripMenuItem();
    this.toolStripMenuItem9 = new ToolStripMenuItem();
    this.donDepProfileToolStripMenuItem = new ToolStripMenuItem();
    this.copyDataDeviceToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_34 = new ToolStripMenuItem();
    this.dataBackupGroupToolStripMenuItem = new ToolStripMenuItem();
    this.backupGroupToolStripMenuItem = new ToolStripMenuItem();
    this.checkFileBackupGroupToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_35 = new ToolStripMenuItem();
    this.toolStripMenuItem_39 = new ToolStripMenuItem();
    this.toolStripMenuItem_12 = new ToolStripMenuItem();
    this.lToolStripMenuItem = new ToolStripMenuItem();
    this.locTrungToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_38 = new ToolStripMenuItem();
    this.toolStripMenuItem_24 = new ToolStripMenuItem();
    this.loginHotmailToolStripMenuItem = new ToolStripMenuItem();
    this.loginYandexToolStripMenuItem = new ToolStripMenuItem();
    this.unlockCheckpointToolStripMenuItem = new ToolStripMenuItem();
    this.regAccTiktokToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem4 = new ToolStripMenuItem();
    this.toolStripMenuItem3 = new ToolStripMenuItem();
    this.toolStripMenuItem_36 = new ToolStripMenuItem();
    this.toolStripMenuItem_40 = new ToolStripMenuItem();
    this.toolStripMenuItem_9 = new ToolStripMenuItem();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.picLanguage = new PictureBox();
    this.pictureBox1 = new PictureBox();
    this.button2 = new Button();
    this.button1 = new Button();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuCards1 = new BunifuCards();
    this.menuStrip1 = new MenuStrip();
    this.toolStripMenuItem_0 = new ToolStripMenuItem();
    this.toolStripMenuItem_1 = new ToolStripMenuItem();
    this.toolStripMenuItem5 = new ToolStripMenuItem();
    this.toolStripMenuItem_21 = new ToolStripMenuItem();
    this.toolStripMenuItem_25 = new ToolStripMenuItem();
    this.toolStripMenuItem_26 = new ToolStripMenuItem();
    this.checkLiveUidToolStripMenuItem = new ToolStripMenuItem();
    this.checkProxyToolStripMenuItem1 = new ToolStripMenuItem();
    this.checkHotmailToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_27 = new ToolStripMenuItem();
    this.checkStatusXproxyToolStripMenuItem = new ToolStripMenuItem();
    this.testSpinTextToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_31 = new ToolStripMenuItem();
    this.cbbTinhTrang = new MetroComboBox();
    this.cbbThuMuc = new MetroComboBox();
    this.label2 = new Label();
    this.label1 = new Label();
    this.cbbSearch = new ComboBox();
    this.txbSearch = new BunifuCustomTextbox();
    this.statusStrip1 = new StatusStrip();
    this.toolStripStatusLabel1 = new ToolStripStatusLabel();
    this.lblStatus = new ToolStripStatusLabel();
    this.toolStripStatusLabel3 = new ToolStripStatusLabel();
    this.lblKey = new ToolStripStatusLabel();
    this.toolStripStatusLabel8 = new ToolStripStatusLabel();
    this.txbUid = new ToolStripStatusLabel();
    this.lblUser = new ToolStripStatusLabel();
    this.toolStripStatusLabel9 = new ToolStripStatusLabel();
    this.toolStripStatusLabel10 = new ToolStripStatusLabel();
    this.lblDateExpried = new ToolStripStatusLabel();
    this.toolStripStatusLabel4 = new ToolStripStatusLabel();
    this.lblCountHighline = new ToolStripStatusLabel();
    this.toolStripStatusLabel5 = new ToolStripStatusLabel();
    this.lblCountSelect = new ToolStripStatusLabel();
    this.toolStripStatusLabel2 = new ToolStripStatusLabel();
    this.lblCountTotal = new ToolStripStatusLabel();
    this.toolStripStatusLabel7 = new ToolStripStatusLabel();
    this.lblCountDeviceRunning = new ToolStripStatusLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.btnLoadAcc = new MetroButton();
    this.btnEditFile = new MetroButton();
    this.btnDeleteFile = new MetroButton();
    this.btnAddFile = new MetroButton();
    this.btnPause = new Button();
    this.btnInteract = new Button();
    this.plTrangThai = new Panel();
    this.lblTrangThai = new Label();
    this.panel1 = new Panel();
    this.button7 = new Button();
    this.button6 = new Button();
    this.button5 = new Button();
    this.button4 = new Button();
    this.button3 = new Button();
    this.plQuanLyThuMuc = new Panel();
    this.button9 = new Button();
    this.panel2 = new Panel();
    this.BtnSearch = new MetroButton();
    this.notifyIcon_0 = new NotifyIcon(this.components);
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
    this.cDeviceId = new DataGridViewTextBoxColumn();
    this.cIp = new DataGridViewTextBoxColumn();
    this.cStatus = new DataGridViewTextBoxColumn();
    ((ISupportInitialize) this.dtgvAcc).BeginInit();
    this.ctmsAcc.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    ((ISupportInitialize) this.picLanguage).BeginInit();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.bunifuCards1.SuspendLayout();
    this.menuStrip1.SuspendLayout();
    this.statusStrip1.SuspendLayout();
    this.plTrangThai.SuspendLayout();
    this.panel1.SuspendLayout();
    this.plQuanLyThuMuc.SuspendLayout();
    this.panel2.SuspendLayout();
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
    this.dtgvAcc.Columns.AddRange((DataGridViewColumn) this.cChose, (DataGridViewColumn) this.cStt, (DataGridViewColumn) this.cId, (DataGridViewColumn) this.cUid, (DataGridViewColumn) this.cToken, (DataGridViewColumn) this.cCookies, (DataGridViewColumn) this.cEmail, (DataGridViewColumn) this.cPhone, (DataGridViewColumn) this.cName, (DataGridViewColumn) this.cFollow, (DataGridViewColumn) this.cFriend, (DataGridViewColumn) this.cGroup, (DataGridViewColumn) this.cBirthday, (DataGridViewColumn) this.cGender, (DataGridViewColumn) this.cPassword, (DataGridViewColumn) this.cMailRecovery, (DataGridViewColumn) this.cPassMail, (DataGridViewColumn) this.cBackup, (DataGridViewColumn) this.cFa2, (DataGridViewColumn) this.cUseragent, (DataGridViewColumn) this.cProxy, (DataGridViewColumn) this.cDateCreateAcc, (DataGridViewColumn) this.cAvatar, (DataGridViewColumn) this.cProfile, (DataGridViewColumn) this.cThuMuc, (DataGridViewColumn) this.cInteractEnd, (DataGridViewColumn) this.cDevice, (DataGridViewColumn) this.cInfo, (DataGridViewColumn) this.cGhiChu, (DataGridViewColumn) this.cDeviceId, (DataGridViewColumn) this.cIp, (DataGridViewColumn) this.cStatus);
    this.dtgvAcc.ContextMenuStrip = (ContextMenuStrip) this.ctmsAcc;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.dtgvAcc.DefaultCellStyle = gridViewCellStyle2;
    this.dtgvAcc.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.dtgvAcc.Location = new Point(9, 108);
    this.dtgvAcc.Name = "dtgvAcc";
    this.dtgvAcc.RowHeadersVisible = false;
    this.dtgvAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvAcc.Size = new Size(1693, 642);
    this.dtgvAcc.TabIndex = 0;
    this.dtgvAcc.CellClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellClick);
    this.dtgvAcc.CellDoubleClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
    this.dtgvAcc.CellValueChanged += new DataGridViewCellEventHandler(this.dtgvAcc_CellValueChanged);
    this.dtgvAcc.SelectionChanged += new EventHandler(this.dtgvAcc_SelectionChanged);
    this.dtgvAcc.SortCompare += new DataGridViewSortCompareEventHandler(this.dtgvAcc_SortCompare);
    this.dtgvAcc.KeyDown += new KeyEventHandler(this.dtgvAcc_KeyDown);
    this.ctmsAcc.Items.AddRange(new ToolStripItem[15]
    {
      (ToolStripItem) this.toolStripMenuItem_2,
      (ToolStripItem) this.toolStripMenuItem_6,
      (ToolStripItem) this.toolStripMenuItem_33,
      (ToolStripItem) this.toolStripMenuItem_32,
      (ToolStripItem) this.copyToolStripMenuItem,
      (ToolStripItem) this.loginPhoneToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_3,
      (ToolStripItem) this.checkCookieToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_17,
      (ToolStripItem) this.toolStripMenuItem_10,
      (ToolStripItem) this.toolStripMenuItem_4,
      (ToolStripItem) this.profileToolStripMenuItem,
      (ToolStripItem) this.dataBackupGroupToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_12,
      (ToolStripItem) this.toolStripMenuItem_9
    });
    this.ctmsAcc.Name = "ctmsAcc";
    this.ctmsAcc.Size = new Size(203, 334);
    this.ctmsAcc.Opening += new CancelEventHandler(this.ctmsAcc_Opening);
    this.toolStripMenuItem_2.DropDownItems.AddRange(new ToolStripItem[5]
    {
      (ToolStripItem) this.toolStripMenuItem_5,
      (ToolStripItem) this.liveToolStripMenuItem,
      (ToolStripItem) this.tinhTrangToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_13,
      (ToolStripItem) this.toolStripMenuItem_37
    });
    this.toolStripMenuItem_2.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_2.Image");
    this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
    this.toolStripMenuItem_2.Size = new Size(202, 22);
    this.toolStripMenuItem_2.Text = "Chọn";
    this.toolStripMenuItem_5.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_5.Image");
    this.toolStripMenuItem_5.Name = "toolStripMenuItem_5";
    this.toolStripMenuItem_5.Size = new Size(209, 22);
    this.toolStripMenuItem_5.Text = "Tất cả";
    this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripMenuItem_5_Click);
    this.liveToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("liveToolStripMenuItem.Image");
    this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
    this.liveToolStripMenuItem.Size = new Size(209, 22);
    this.liveToolStripMenuItem.Text = "Bôi đen";
    this.liveToolStripMenuItem.Click += new EventHandler(this.liveToolStripMenuItem_Click);
    this.tinhTrangToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("tinhTrangToolStripMenuItem.Image");
    this.tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
    this.tinhTrangToolStripMenuItem.Size = new Size(209, 22);
    this.tinhTrangToolStripMenuItem.Text = "Tình trạng";
    this.toolStripMenuItem_13.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_13.Image");
    this.toolStripMenuItem_13.Name = "toolStripMenuItem_13";
    this.toolStripMenuItem_13.Size = new Size(209, 22);
    this.toolStripMenuItem_13.Text = "Trạng thái";
    this.toolStripMenuItem_13.Click += new EventHandler(this.toolStripMenuItem_13_Click);
    this.toolStripMenuItem_37.Image = (Image) Resources.icons8_mail_filter_24px1;
    this.toolStripMenuItem_37.Name = "toolStripMenuItem_37";
    this.toolStripMenuItem_37.Size = new Size(209, 22);
    this.toolStripMenuItem_37.Text = "Chọn danh sách theo UID";
    this.toolStripMenuItem_37.Click += new EventHandler(this.toolStripMenuItem_37_Click);
    this.toolStripMenuItem_6.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_6.Image");
    this.toolStripMenuItem_6.Name = "toolStripMenuItem_6";
    this.toolStripMenuItem_6.Size = new Size(202, 22);
    this.toolStripMenuItem_6.Text = "Bỏ chọn tất cả";
    this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
    this.toolStripMenuItem_33.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_33.Image");
    this.toolStripMenuItem_33.Name = "toolStripMenuItem_33";
    this.toolStripMenuItem_33.Size = new Size(202, 22);
    this.toolStripMenuItem_33.Text = "Ẩn khỏi danh sách";
    this.toolStripMenuItem_33.Click += new EventHandler(this.toolStripMenuItem_33_Click);
    this.toolStripMenuItem_32.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_32.Image");
    this.toolStripMenuItem_32.Name = "toolStripMenuItem_32";
    this.toolStripMenuItem_32.Size = new Size(202, 22);
    this.toolStripMenuItem_32.Text = "Gán Proxy cho tài khoản";
    this.toolStripMenuItem_32.Click += new EventHandler(this.toolStripMenuItem_32_Click);
    this.copyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[18]
    {
      (ToolStripItem) this.uidToolStripMenuItem,
      (ToolStripItem) this.passToolStripMenuItem,
      (ToolStripItem) this.tokenToolStripMenuItem,
      (ToolStripItem) this.cookieToolStripMenuItem,
      (ToolStripItem) this.mailToolStripMenuItem,
      (ToolStripItem) this.fAToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_19,
      (ToolStripItem) this.uidPassToolStripMenuItem,
      (ToolStripItem) this.uidPass2FaToolStripMenuItem,
      (ToolStripItem) this.mailPassMailToolStripMenuItem,
      (ToolStripItem) this.uidPassTokenCookieToolStripMenuItem,
      (ToolStripItem) this.uidPassTokenCookieMailPassMailToolStripMenuItem,
      (ToolStripItem) this.uidPassTokenCookieMailPassMail2faToolStripMenuItem,
      (ToolStripItem) this.useragentToolStripMenuItem1,
      (ToolStripItem) this.proxyToolStripMenuItem1,
      (ToolStripItem) this.devicesToolStripMenuItem,
      (ToolStripItem) this.phoneToolStripMenuItem1,
      (ToolStripItem) this.toolStripMenuItem_16
    });
    this.copyToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("copyToolStripMenuItem.Image");
    this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
    this.copyToolStripMenuItem.Size = new Size(202, 22);
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
    this.toolStripMenuItem_19.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_19.Image");
    this.toolStripMenuItem_19.Name = "toolStripMenuItem_19";
    this.toolStripMenuItem_19.Size = new Size(290, 22);
    this.toolStripMenuItem_19.Text = "Mã bảo mật 6 số từ 2FA";
    this.toolStripMenuItem_19.Click += new EventHandler(this.toolStripMenuItem_19_Click);
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
    this.devicesToolStripMenuItem.Image = (Image) Resources.icons8_refresh_23px;
    this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
    this.devicesToolStripMenuItem.Size = new Size(290, 22);
    this.devicesToolStripMenuItem.Text = "Device";
    this.devicesToolStripMenuItem.Click += new EventHandler(this.devicesToolStripMenuItem_Click);
    this.phoneToolStripMenuItem1.Image = (Image) Resources.icons8_phone;
    this.phoneToolStripMenuItem1.Name = "phoneToolStripMenuItem1";
    this.phoneToolStripMenuItem1.Size = new Size(290, 22);
    this.phoneToolStripMenuItem1.Text = "Phone";
    this.phoneToolStripMenuItem1.Click += new EventHandler(this.phoneToolStripMenuItem1_Click);
    this.toolStripMenuItem_16.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_16.Image");
    this.toolStripMenuItem_16.Name = "toolStripMenuItem_16";
    this.toolStripMenuItem_16.Size = new Size(290, 22);
    this.toolStripMenuItem_16.Text = "Other...";
    this.toolStripMenuItem_16.Click += new EventHandler(this.toolStripMenuItem_16_Click);
    this.loginPhoneToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("loginPhoneToolStripMenuItem.Image");
    this.loginPhoneToolStripMenuItem.Name = "loginPhoneToolStripMenuItem";
    this.loginPhoneToolStripMenuItem.Size = new Size(202, 22);
    this.loginPhoneToolStripMenuItem.Text = "Login phone";
    this.loginPhoneToolStripMenuItem.Click += new EventHandler(this.loginPhoneToolStripMenuItem_Click);
    this.toolStripMenuItem_3.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_3.Image");
    this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
    this.toolStripMenuItem_3.Size = new Size(202, 22);
    this.toolStripMenuItem_3.Text = "Xóa tài khoản";
    this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
    this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[8]
    {
      (ToolStripItem) this.toolStripMenuItem_14,
      (ToolStripItem) this.checkInfoUIDToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_8,
      (ToolStripItem) this.toolStripMenuItem_7,
      (ToolStripItem) this.checkAvatarToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem6,
      (ToolStripItem) this.toolStripMenuItem_23,
      (ToolStripItem) this.checkProxyToolStripMenuItem
    });
    this.checkCookieToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("checkCookieToolStripMenuItem.Image");
    this.checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
    this.checkCookieToolStripMenuItem.Size = new Size(202, 22);
    this.checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
    this.checkCookieToolStripMenuItem.Click += new EventHandler(this.checkCookieToolStripMenuItem_Click);
    this.toolStripMenuItem_14.Name = "toolStripMenuItem_14";
    this.toolStripMenuItem_14.Size = new Size(153, 22);
    this.toolStripMenuItem_14.Text = "Check Wall";
    this.toolStripMenuItem_14.ToolTipText = "Không cần dùng token";
    this.toolStripMenuItem_14.Click += new EventHandler(this.toolStripMenuItem_14_Click);
    this.checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
    this.checkInfoUIDToolStripMenuItem.Size = new Size(153, 22);
    this.checkInfoUIDToolStripMenuItem.Text = "Check Info UID";
    this.checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCập nhật thông tin: Họ tên, Giớ́i tính, [Email], [Bạn bè], [Nhóm], [Ngày sinh]";
    this.checkInfoUIDToolStripMenuItem.Click += new EventHandler(this.checkInfoUIDToolStripMenuItem_Click);
    this.toolStripMenuItem_8.Name = "toolStripMenuItem_8";
    this.toolStripMenuItem_8.Size = new Size(153, 22);
    this.toolStripMenuItem_8.Text = "Check Token";
    this.toolStripMenuItem_8.Click += new EventHandler(this.toolStripMenuItem_8_Click);
    this.toolStripMenuItem_7.Name = "toolStripMenuItem_7";
    this.toolStripMenuItem_7.Size = new Size(153, 22);
    this.toolStripMenuItem_7.Text = "Check Cookie";
    this.toolStripMenuItem_7.Click += new EventHandler(this.toolStripMenuItem_7_Click);
    this.checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
    this.checkAvatarToolStripMenuItem.Size = new Size(153, 22);
    this.checkAvatarToolStripMenuItem.Text = "Check Avatar";
    this.checkAvatarToolStripMenuItem.Click += new EventHandler(this.checkAvatarToolStripMenuItem_Click);
    this.toolStripMenuItem6.Name = "toolStripMenuItem6";
    this.toolStripMenuItem6.Size = new Size(153, 22);
    this.toolStripMenuItem6.Text = "Check Profile";
    this.toolStripMenuItem6.Click += new EventHandler(this.toolStripMenuItem6_Click);
    this.toolStripMenuItem_23.Name = "toolStripMenuItem_23";
    this.toolStripMenuItem_23.Size = new Size(153, 22);
    this.toolStripMenuItem_23.Text = "Mail|pass Mail";
    this.toolStripMenuItem_23.Click += new EventHandler(this.toolStripMenuItem_23_Click);
    this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
    this.checkProxyToolStripMenuItem.Size = new Size(153, 22);
    this.checkProxyToolStripMenuItem.Text = "Check Proxy";
    this.checkProxyToolStripMenuItem.Click += new EventHandler(this.checkProxyToolStripMenuItem_Click);
    this.toolStripMenuItem_17.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.toolStripMenuItem_18,
      (ToolStripItem) this.toolStripMenuItem_29
    });
    this.toolStripMenuItem_17.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_17.Image");
    this.toolStripMenuItem_17.Name = "toolStripMenuItem_17";
    this.toolStripMenuItem_17.Size = new Size(202, 22);
    this.toolStripMenuItem_17.Text = "Cập nhật thông tin";
    this.toolStripMenuItem_18.Name = "toolStripMenuItem_18";
    this.toolStripMenuItem_18.Size = new Size(216, 22);
    this.toolStripMenuItem_18.Text = "Sử dụng Token trung gian";
    this.toolStripMenuItem_18.ToolTipText = "Cập nhật thông tin: Họ tên, Giớ́i tính, [Email], [Bạn bè], [Nhóm], [Ngày sinh]";
    this.toolStripMenuItem_18.Click += new EventHandler(this.toolStripMenuItem_18_Click);
    this.toolStripMenuItem_29.Name = "toolStripMenuItem_29";
    this.toolStripMenuItem_29.Size = new Size(216, 22);
    this.toolStripMenuItem_29.Text = "Sử dụng Cookie trung gian";
    this.toolStripMenuItem_29.Click += new EventHandler(this.toolStripMenuItem_29_Click);
    this.toolStripMenuItem_10.DropDownItems.AddRange(new ToolStripItem[11]
    {
      (ToolStripItem) this.toolStripMenuItem_30,
      (ToolStripItem) this.toolStripMenuItem_11,
      (ToolStripItem) this.tokenToolStripMenuItem2,
      (ToolStripItem) this.cookieToolStripMenuItem3,
      (ToolStripItem) this.toolStripMenuItem_15,
      (ToolStripItem) this.toolStripMenuItem_20,
      (ToolStripItem) this.useragentToolStripMenuItem,
      (ToolStripItem) this.proxyToolStripMenuItem,
      (ToolStripItem) this.phoneToolStripMenuItem,
      (ToolStripItem) this.ghiChuToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_22
    });
    this.toolStripMenuItem_10.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_10.Image");
    this.toolStripMenuItem_10.Name = "toolStripMenuItem_10";
    this.toolStripMenuItem_10.Size = new Size(202, 22);
    this.toolStripMenuItem_10.Text = "Cập nhật dữ liệu";
    this.toolStripMenuItem_30.Image = (Image) Resources.icons8_menu_48px_1;
    this.toolStripMenuItem_30.Name = "toolStripMenuItem_30";
    this.toolStripMenuItem_30.Size = new Size(175, 22);
    this.toolStripMenuItem_30.Text = "Cập nhật hàng loạt";
    this.toolStripMenuItem_30.Click += new EventHandler(this.toolStripMenuItem_30_Click);
    this.toolStripMenuItem_11.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_11.Image");
    this.toolStripMenuItem_11.Name = "toolStripMenuItem_11";
    this.toolStripMenuItem_11.Size = new Size(175, 22);
    this.toolStripMenuItem_11.Text = "Password";
    this.toolStripMenuItem_11.Click += new EventHandler(this.toolStripMenuItem_11_Click);
    this.tokenToolStripMenuItem2.Image = (Image) componentResourceManager.GetObject("tokenToolStripMenuItem2.Image");
    this.tokenToolStripMenuItem2.Name = "tokenToolStripMenuItem2";
    this.tokenToolStripMenuItem2.Size = new Size(175, 22);
    this.tokenToolStripMenuItem2.Text = "Token";
    this.tokenToolStripMenuItem2.Click += new EventHandler(this.tokenToolStripMenuItem2_Click);
    this.cookieToolStripMenuItem3.Image = (Image) componentResourceManager.GetObject("cookieToolStripMenuItem3.Image");
    this.cookieToolStripMenuItem3.Name = "cookieToolStripMenuItem3";
    this.cookieToolStripMenuItem3.Size = new Size(175, 22);
    this.cookieToolStripMenuItem3.Text = "Cookie";
    this.cookieToolStripMenuItem3.Click += new EventHandler(this.cookieToolStripMenuItem3_Click);
    this.toolStripMenuItem_15.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_15.Image");
    this.toolStripMenuItem_15.Name = "toolStripMenuItem_15";
    this.toolStripMenuItem_15.Size = new Size(175, 22);
    this.toolStripMenuItem_15.Text = "Email|Pass Email";
    this.toolStripMenuItem_15.Click += new EventHandler(this.toolStripMenuItem_15_Click);
    this.toolStripMenuItem_20.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_20.Image");
    this.toolStripMenuItem_20.Name = "toolStripMenuItem_20";
    this.toolStripMenuItem_20.Size = new Size(175, 22);
    this.toolStripMenuItem_20.Text = "Mã 2FA";
    this.toolStripMenuItem_20.Click += new EventHandler(this.toolStripMenuItem_20_Click);
    this.useragentToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("useragentToolStripMenuItem.Image");
    this.useragentToolStripMenuItem.Name = "useragentToolStripMenuItem";
    this.useragentToolStripMenuItem.Size = new Size(175, 22);
    this.useragentToolStripMenuItem.Text = "Useragent";
    this.useragentToolStripMenuItem.Click += new EventHandler(this.useragentToolStripMenuItem_Click);
    this.proxyToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("proxyToolStripMenuItem.Image");
    this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
    this.proxyToolStripMenuItem.Size = new Size(175, 22);
    this.proxyToolStripMenuItem.Text = "Proxy";
    this.proxyToolStripMenuItem.Click += new EventHandler(this.proxyToolStripMenuItem_Click);
    this.phoneToolStripMenuItem.Image = (Image) Resources.icons8_phone;
    this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
    this.phoneToolStripMenuItem.Size = new Size(175, 22);
    this.phoneToolStripMenuItem.Text = "Phone";
    this.phoneToolStripMenuItem.Click += new EventHandler(this.phoneToolStripMenuItem_Click);
    this.ghiChuToolStripMenuItem.Image = (Image) Resources.icons8_property_script_48px;
    this.ghiChuToolStripMenuItem.Name = "ghiChuToolStripMenuItem";
    this.ghiChuToolStripMenuItem.Size = new Size(175, 22);
    this.ghiChuToolStripMenuItem.Text = "Ghi chú";
    this.ghiChuToolStripMenuItem.Click += new EventHandler(this.ghiChuToolStripMenuItem_Click);
    this.toolStripMenuItem_22.Image = (Image) Resources.icons8_verified_account_64px;
    this.toolStripMenuItem_22.Name = "toolStripMenuItem_22";
    this.toolStripMenuItem_22.Size = new Size(175, 22);
    this.toolStripMenuItem_22.Text = "Ngày sinh";
    this.toolStripMenuItem_22.Click += new EventHandler(this.toolStripMenuItem_22_Click);
    this.toolStripMenuItem_4.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_4.Image");
    this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
    this.toolStripMenuItem_4.Size = new Size(202, 22);
    this.toolStripMenuItem_4.Text = "Chuyển thư mục";
    this.profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[6]
    {
      (ToolStripItem) this.toolStripMenuItem7,
      (ToolStripItem) this.toolStripMenuItem8,
      (ToolStripItem) this.toolStripMenuItem9,
      (ToolStripItem) this.donDepProfileToolStripMenuItem,
      (ToolStripItem) this.copyDataDeviceToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_34
    });
    this.profileToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("profileToolStripMenuItem.Image");
    this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
    this.profileToolStripMenuItem.Size = new Size(202, 22);
    this.profileToolStripMenuItem.Text = "Profile Phone";
    this.profileToolStripMenuItem.Click += new EventHandler(this.profileToolStripMenuItem_Click);
    this.toolStripMenuItem7.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem7.Image");
    this.toolStripMenuItem7.Name = "toolStripMenuItem7";
    this.toolStripMenuItem7.Size = new Size(163, 22);
    this.toolStripMenuItem7.Text = "Check profile";
    this.toolStripMenuItem7.Click += new EventHandler(this.toolStripMenuItem7_Click);
    this.toolStripMenuItem8.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem8.Image");
    this.toolStripMenuItem8.Name = "toolStripMenuItem8";
    this.toolStripMenuItem8.Size = new Size(163, 22);
    this.toolStripMenuItem8.Text = "Xóa profile";
    this.toolStripMenuItem8.Click += new EventHandler(this.toolStripMenuItem8_Click);
    this.toolStripMenuItem9.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem9.Image");
    this.toolStripMenuItem9.Name = "toolStripMenuItem9";
    this.toolStripMenuItem9.Size = new Size(163, 22);
    this.toolStripMenuItem9.Text = "Copy profile";
    this.toolStripMenuItem9.Click += new EventHandler(this.toolStripMenuItem9_Click);
    this.donDepProfileToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("donDepProfileToolStripMenuItem.Image");
    this.donDepProfileToolStripMenuItem.Name = "donDepProfileToolStripMenuItem";
    this.donDepProfileToolStripMenuItem.Size = new Size(163, 22);
    this.donDepProfileToolStripMenuItem.Text = "Dọn dẹp";
    this.donDepProfileToolStripMenuItem.Click += new EventHandler(this.donDepProfileToolStripMenuItem_Click);
    this.copyDataDeviceToolStripMenuItem.Image = (Image) Resources.icons8_android_1;
    this.copyDataDeviceToolStripMenuItem.Name = "copyDataDeviceToolStripMenuItem";
    this.copyDataDeviceToolStripMenuItem.Size = new Size(163, 22);
    this.copyDataDeviceToolStripMenuItem.Text = "Copy info device";
    this.copyDataDeviceToolStripMenuItem.Click += new EventHandler(this.copyDataDeviceToolStripMenuItem_Click);
    this.toolStripMenuItem_34.Image = (Image) Resources.delete_sign_25px;
    this.toolStripMenuItem_34.Name = "toolStripMenuItem_34";
    this.toolStripMenuItem_34.Size = new Size(163, 22);
    this.toolStripMenuItem_34.Text = "Xóa info device";
    this.toolStripMenuItem_34.Click += new EventHandler(this.toolStripMenuItem_34_Click);
    this.dataBackupGroupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.backupGroupToolStripMenuItem,
      (ToolStripItem) this.checkFileBackupGroupToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_35,
      (ToolStripItem) this.toolStripMenuItem_39
    });
    this.dataBackupGroupToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("dataBackupGroupToolStripMenuItem.Image");
    this.dataBackupGroupToolStripMenuItem.Name = "dataBackupGroupToolStripMenuItem";
    this.dataBackupGroupToolStripMenuItem.Size = new Size(202, 22);
    this.dataBackupGroupToolStripMenuItem.Text = "Data Backup Group";
    this.backupGroupToolStripMenuItem.Name = "backupGroupToolStripMenuItem";
    this.backupGroupToolStripMenuItem.Size = new Size(168, 22);
    this.backupGroupToolStripMenuItem.Text = "Backup group";
    this.backupGroupToolStripMenuItem.Click += new EventHandler(this.backupGroupToolStripMenuItem_Click);
    this.checkFileBackupGroupToolStripMenuItem.Name = "checkFileBackupGroupToolStripMenuItem";
    this.checkFileBackupGroupToolStripMenuItem.Size = new Size(168, 22);
    this.checkFileBackupGroupToolStripMenuItem.Text = "Check data group";
    this.checkFileBackupGroupToolStripMenuItem.Click += new EventHandler(this.checkFileBackupGroupToolStripMenuItem_Click);
    this.toolStripMenuItem_35.Name = "toolStripMenuItem_35";
    this.toolStripMenuItem_35.Size = new Size(168, 22);
    this.toolStripMenuItem_35.Text = "Xóa data group";
    this.toolStripMenuItem_35.Click += new EventHandler(this.toolStripMenuItem_35_Click);
    this.toolStripMenuItem_39.Name = "toolStripMenuItem_39";
    this.toolStripMenuItem_39.Size = new Size(168, 22);
    this.toolStripMenuItem_39.Text = "Mở form quản lý";
    this.toolStripMenuItem_39.Click += new EventHandler(this.toolStripMenuItem_39_Click);
    this.toolStripMenuItem_12.DropDownItems.AddRange(new ToolStripItem[12]
    {
      (ToolStripItem) this.lToolStripMenuItem,
      (ToolStripItem) this.locTrungToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_38,
      (ToolStripItem) this.toolStripMenuItem_24,
      (ToolStripItem) this.loginHotmailToolStripMenuItem,
      (ToolStripItem) this.loginYandexToolStripMenuItem,
      (ToolStripItem) this.unlockCheckpointToolStripMenuItem,
      (ToolStripItem) this.regAccTiktokToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem4,
      (ToolStripItem) this.toolStripMenuItem3,
      (ToolStripItem) this.toolStripMenuItem_36,
      (ToolStripItem) this.toolStripMenuItem_40
    });
    this.toolStripMenuItem_12.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_12.Image");
    this.toolStripMenuItem_12.Name = "toolStripMenuItem_12";
    this.toolStripMenuItem_12.Size = new Size(202, 22);
    this.toolStripMenuItem_12.Text = "Chức năng";
    this.lToolStripMenuItem.Image = (Image) Resources.icons8_mail_filter_24px1;
    this.lToolStripMenuItem.Name = "lToolStripMenuItem";
    this.lToolStripMenuItem.Size = new Size(253, 22);
    this.lToolStripMenuItem.Text = "Lọc tài khoản theo UID/Email";
    this.lToolStripMenuItem.Click += new EventHandler(this.lToolStripMenuItem_Click);
    this.locTrungToolStripMenuItem.Image = (Image) Resources.icons8_mail_filter_24px;
    this.locTrungToolStripMenuItem.Name = "locTrungToolStripMenuItem";
    this.locTrungToolStripMenuItem.Size = new Size(253, 22);
    this.locTrungToolStripMenuItem.Text = "Lọc tài khoản trùng nhau";
    this.locTrungToolStripMenuItem.Click += new EventHandler(this.locTrungToolStripMenuItem_Click);
    this.toolStripMenuItem_38.Image = (Image) Resources.icons8_delete_bin;
    this.toolStripMenuItem_38.Name = "toolStripMenuItem_38";
    this.toolStripMenuItem_38.Size = new Size(253, 22);
    this.toolStripMenuItem_38.Text = "Xóa tài khoản trùng nhau";
    this.toolStripMenuItem_38.Click += new EventHandler(this.toolStripMenuItem_38_Click);
    this.toolStripMenuItem_24.Image = (Image) Resources.client_management_25px1;
    this.toolStripMenuItem_24.Name = "toolStripMenuItem_24";
    this.toolStripMenuItem_24.Size = new Size(253, 22);
    this.toolStripMenuItem_24.Text = "Tải xuống avatar";
    this.toolStripMenuItem_24.Click += new EventHandler(this.toolStripMenuItem_24_Click);
    this.loginHotmailToolStripMenuItem.Name = "loginHotmailToolStripMenuItem";
    this.loginHotmailToolStripMenuItem.Size = new Size(253, 22);
    this.loginHotmailToolStripMenuItem.Text = "Login Hotmail (ẩn)";
    this.loginHotmailToolStripMenuItem.Click += new EventHandler(this.loginHotmailToolStripMenuItem_Click);
    this.loginYandexToolStripMenuItem.Name = "loginYandexToolStripMenuItem";
    this.loginYandexToolStripMenuItem.Size = new Size(253, 22);
    this.loginYandexToolStripMenuItem.Text = "Login Yandex (ẩn)";
    this.loginYandexToolStripMenuItem.Click += new EventHandler(this.loginYandexToolStripMenuItem_Click);
    this.unlockCheckpointToolStripMenuItem.Name = "unlockCheckpointToolStripMenuItem";
    this.unlockCheckpointToolStripMenuItem.Size = new Size(253, 22);
    this.unlockCheckpointToolStripMenuItem.Text = "Unlock Checkpoint (ẩn)";
    this.unlockCheckpointToolStripMenuItem.Click += new EventHandler(this.unlockCheckpointToolStripMenuItem_Click);
    this.regAccTiktokToolStripMenuItem.Name = "regAccTiktokToolStripMenuItem";
    this.regAccTiktokToolStripMenuItem.Size = new Size(253, 22);
    this.regAccTiktokToolStripMenuItem.Text = "Reg Acc Tiktok (ẩn)";
    this.regAccTiktokToolStripMenuItem.Click += new EventHandler(this.regAccTiktokToolStripMenuItem_Click);
    this.toolStripMenuItem4.Name = "toolStripMenuItem4";
    this.toolStripMenuItem4.Size = new Size(253, 22);
    this.toolStripMenuItem4.Text = "Reg Acc Instagram (ẩn)";
    this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
    this.toolStripMenuItem3.Name = "toolStripMenuItem3";
    this.toolStripMenuItem3.Size = new Size(253, 22);
    this.toolStripMenuItem3.Text = "Login App Fb Clone (ẩn)";
    this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
    this.toolStripMenuItem_36.Name = "toolStripMenuItem_36";
    this.toolStripMenuItem_36.Size = new Size(253, 22);
    this.toolStripMenuItem_36.Text = "Convert format birthday (ẩn)";
    this.toolStripMenuItem_36.Click += new EventHandler(this.toolStripMenuItem_36_Click);
    this.toolStripMenuItem_40.Name = "toolStripMenuItem_40";
    this.toolStripMenuItem_40.Size = new Size(253, 22);
    this.toolStripMenuItem_40.Text = "Khôi phục mật khẩu trước đó (ẩn)";
    this.toolStripMenuItem_40.Click += new EventHandler(this.toolStripMenuItem_40_Click);
    this.toolStripMenuItem_9.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_9.Image");
    this.toolStripMenuItem_9.Name = "toolStripMenuItem_9";
    this.toolStripMenuItem_9.Size = new Size(202, 22);
    this.toolStripMenuItem_9.Text = "Tải lại danh sách";
    this.toolStripMenuItem_9.Click += new EventHandler(this.toolStripMenuItem_9_Click);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_0.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.picLanguage);
    this.pnlHeader.Controls.Add((Control) this.pictureBox1);
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.button1);
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(1712, 29);
    this.pnlHeader.TabIndex = 0;
    this.pnlHeader.Paint += new PaintEventHandler(this.pnlHeader_Paint);
    this.picLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.picLanguage.Cursor = Cursors.Hand;
    this.picLanguage.Location = new Point(1585, 2);
    this.picLanguage.Name = "picLanguage";
    this.picLanguage.Size = new Size(25, 25);
    this.picLanguage.SizeMode = PictureBoxSizeMode.StretchImage;
    this.picLanguage.TabIndex = 10;
    this.picLanguage.TabStop = false;
    this.picLanguage.Click += new EventHandler(this.picLanguage_Click);
    this.pictureBox1.Cursor = Cursors.Arrow;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, 3);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(35, 26);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    this.pictureBox1.TabIndex = 12;
    this.pictureBox1.TabStop = false;
    this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
    this.pictureBox1.DoubleClick += new EventHandler(this.pictureBox1_DoubleClick);
    this.button2.Cursor = Cursors.Hand;
    this.button2.Dock = DockStyle.Right;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) componentResourceManager.GetObject("button2.Image");
    this.button2.Location = new Point(1616, 0);
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
    this.button1.Location = new Point(1648, 0);
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
    this.btnMinimize.Location = new Point(1680, 0);
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
    this.bunifuCustomLabel1.Location = new Point(32, 7);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(719, 16);
    this.bunifuCustomLabel1.TabIndex = 3;
    this.bunifuCustomLabel1.Text = "MAX FARM - Phần Mềm Quản Lý  Và Chăm Sóc  Tài Khoản Facebook Trên Phone - 038.472.1090 ( 999 Devices )";
    this.bunifuCustomLabel1.Click += new EventHandler(this.bunifuCustomLabel1_Click);
    this.bunifuCustomLabel1.DoubleClick += new EventHandler(this.bunifuCustomLabel1_DoubleClick);
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.RoyalBlue;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(1, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(1713, 38);
    this.bunifuCards1.TabIndex = 0;
    this.menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.menuStrip1.AutoSize = false;
    this.menuStrip1.Dock = DockStyle.None;
    this.menuStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.menuStrip1.Items.AddRange(new ToolStripItem[7]
    {
      (ToolStripItem) this.toolStripMenuItem_0,
      (ToolStripItem) this.toolStripMenuItem_1,
      (ToolStripItem) this.toolStripMenuItem5,
      (ToolStripItem) this.toolStripMenuItem_21,
      (ToolStripItem) this.toolStripMenuItem_25,
      (ToolStripItem) this.toolStripMenuItem_26,
      (ToolStripItem) this.toolStripMenuItem_31
    });
    this.menuStrip1.Location = new Point(1, 37);
    this.menuStrip1.Name = "menuStrip1";
    this.menuStrip1.RenderMode = ToolStripRenderMode.Professional;
    this.menuStrip1.Size = new Size(1712, 25);
    this.menuStrip1.Stretch = false;
    this.menuStrip1.TabIndex = 1;
    this.menuStrip1.Text = "menuStrip1";
    this.toolStripMenuItem_0.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_0.Image");
    this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
    this.toolStripMenuItem_0.Size = new Size(123, 21);
    this.toolStripMenuItem_0.Text = "Cấu hình chung";
    this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
    this.toolStripMenuItem_1.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_1.Image");
    this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
    this.toolStripMenuItem_1.Size = new Size(143, 21);
    this.toolStripMenuItem_1.Text = "Cấu hình tương tác";
    this.toolStripMenuItem_1.TextDirection = ToolStripTextDirection.Horizontal;
    this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
    this.toolStripMenuItem5.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem5.Image");
    this.toolStripMenuItem5.Name = "toolStripMenuItem5";
    this.toolStripMenuItem5.Size = new Size(117, 21);
    this.toolStripMenuItem5.Text = "Quản lý phone";
    this.toolStripMenuItem5.TextDirection = ToolStripTextDirection.Horizontal;
    this.toolStripMenuItem5.Click += new EventHandler(this.toolStripMenuItem5_Click);
    this.toolStripMenuItem5.MouseDown += new MouseEventHandler(this.toolStripMenuItem5_MouseDown);
    this.toolStripMenuItem_21.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_21.Image");
    this.toolStripMenuItem_21.Name = "toolStripMenuItem_21";
    this.toolStripMenuItem_21.Size = new Size(131, 21);
    this.toolStripMenuItem_21.Text = "Cấu hình hiển thị";
    this.toolStripMenuItem_21.Click += new EventHandler(this.toolStripMenuItem_21_Click);
    this.toolStripMenuItem_25.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_25.Image");
    this.toolStripMenuItem_25.Name = "toolStripMenuItem_25";
    this.toolStripMenuItem_25.Size = new Size(133, 21);
    this.toolStripMenuItem_25.Text = "Tài khoản đã xóa";
    this.toolStripMenuItem_25.Click += new EventHandler(this.toolStripMenuItem_25_Click);
    this.toolStripMenuItem_26.DropDownItems.AddRange(new ToolStripItem[6]
    {
      (ToolStripItem) this.checkLiveUidToolStripMenuItem,
      (ToolStripItem) this.checkProxyToolStripMenuItem1,
      (ToolStripItem) this.checkHotmailToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_27,
      (ToolStripItem) this.checkStatusXproxyToolStripMenuItem,
      (ToolStripItem) this.testSpinTextToolStripMenuItem
    });
    this.toolStripMenuItem_26.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_26.Image");
    this.toolStripMenuItem_26.Name = "toolStripMenuItem_26";
    this.toolStripMenuItem_26.Size = new Size(80, 21);
    this.toolStripMenuItem_26.Text = "Tiện ích";
    this.toolStripMenuItem_26.Click += new EventHandler(this.toolStripMenuItem_26_Click);
    this.checkLiveUidToolStripMenuItem.Name = "checkLiveUidToolStripMenuItem";
    this.checkLiveUidToolStripMenuItem.Size = new Size(240, 22);
    this.checkLiveUidToolStripMenuItem.Text = "Check Live Uid";
    this.checkLiveUidToolStripMenuItem.Click += new EventHandler(this.checkLiveUidToolStripMenuItem_Click);
    this.checkProxyToolStripMenuItem1.Name = "checkProxyToolStripMenuItem1";
    this.checkProxyToolStripMenuItem1.Size = new Size(240, 22);
    this.checkProxyToolStripMenuItem1.Text = "Check Proxy";
    this.checkProxyToolStripMenuItem1.Click += new EventHandler(this.checkProxyToolStripMenuItem1_Click);
    this.checkHotmailToolStripMenuItem.Name = "checkHotmailToolStripMenuItem";
    this.checkHotmailToolStripMenuItem.Size = new Size(240, 22);
    this.checkHotmailToolStripMenuItem.Text = "Check Imap Hotmail";
    this.checkHotmailToolStripMenuItem.Click += new EventHandler(this.checkHotmailToolStripMenuItem_Click);
    this.toolStripMenuItem_27.Name = "toolStripMenuItem_27";
    this.toolStripMenuItem_27.Size = new Size(240, 22);
    this.toolStripMenuItem_27.Text = "Lọc trùng dữ liệu";
    this.toolStripMenuItem_27.Click += new EventHandler(this.toolStripMenuItem_27_Click);
    this.checkStatusXproxyToolStripMenuItem.Name = "checkStatusXproxyToolStripMenuItem";
    this.checkStatusXproxyToolStripMenuItem.Size = new Size(240, 22);
    this.checkStatusXproxyToolStripMenuItem.Text = "Check status Xproxy/ProxyV6";
    this.checkStatusXproxyToolStripMenuItem.Click += new EventHandler(this.checkStatusXproxyToolStripMenuItem_Click);
    this.testSpinTextToolStripMenuItem.Name = "testSpinTextToolStripMenuItem";
    this.testSpinTextToolStripMenuItem.Size = new Size(240, 22);
    this.testSpinTextToolStripMenuItem.Text = "Test Spin Content";
    this.testSpinTextToolStripMenuItem.Click += new EventHandler(this.testSpinTextToolStripMenuItem_Click);
    this.toolStripMenuItem_31.Name = "toolStripMenuItem_31";
    this.toolStripMenuItem_31.Size = new Size(12, 21);
    this.cbbTinhTrang.Cursor = Cursors.Hand;
    this.cbbTinhTrang.DropDownHeight = 200;
    this.cbbTinhTrang.DropDownWidth = 300;
    this.cbbTinhTrang.FontSize = MetroComboBoxSize.Small;
    this.cbbTinhTrang.FormattingEnabled = true;
    this.cbbTinhTrang.IntegralHeight = false;
    this.cbbTinhTrang.ItemHeight = 19;
    this.cbbTinhTrang.Items.AddRange(new object[1]
    {
      (object) "[Tất cả tình trạng]"
    });
    this.cbbTinhTrang.Location = new Point(271, 2);
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
    this.cbbThuMuc.Location = new Point(67, 2);
    this.cbbThuMuc.Name = "cbbThuMuc";
    this.cbbThuMuc.Size = new Size(167, 25);
    this.cbbThuMuc.TabIndex = 1;
    this.cbbThuMuc.UseSelectable = true;
    this.cbbThuMuc.SelectedIndexChanged += new EventHandler(this.cbbThuMuc_SelectedIndexChanged);
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label2.Location = new Point(235, 5);
    this.label2.Name = "label2";
    this.label2.Size = new Size(31, 16);
    this.label2.TabIndex = 2;
    this.label2.Text = "Lọc:";
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(4, 6);
    this.label1.Name = "label1";
    this.label1.Size = new Size(63, 16);
    this.label1.TabIndex = 0;
    this.label1.Text = "Thư mục:";
    this.cbbSearch.Cursor = Cursors.Hand;
    this.cbbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbSearch.DropDownWidth = 100;
    this.cbbSearch.FormattingEnabled = true;
    this.cbbSearch.Location = new Point(3, 2);
    this.cbbSearch.Name = "cbbSearch";
    this.cbbSearch.Size = new Size(86, 24);
    this.cbbSearch.TabIndex = 0;
    this.txbSearch.BorderColor = Color.SeaGreen;
    this.txbSearch.Location = new Point(95, 3);
    this.txbSearch.Name = "txbSearch";
    this.txbSearch.Size = new Size(144, 23);
    this.txbSearch.TabIndex = 1;
    this.txbSearch.KeyDown += new KeyEventHandler(this.txbSearch_KeyDown);
    this.statusStrip1.BackColor = SystemColors.Control;
    this.statusStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.statusStrip1.Items.AddRange(new ToolStripItem[18]
    {
      (ToolStripItem) this.toolStripStatusLabel1,
      (ToolStripItem) this.lblStatus,
      (ToolStripItem) this.toolStripStatusLabel3,
      (ToolStripItem) this.lblKey,
      (ToolStripItem) this.toolStripStatusLabel8,
      (ToolStripItem) this.txbUid,
      (ToolStripItem) this.lblUser,
      (ToolStripItem) this.toolStripStatusLabel9,
      (ToolStripItem) this.toolStripStatusLabel10,
      (ToolStripItem) this.lblDateExpried,
      (ToolStripItem) this.toolStripStatusLabel4,
      (ToolStripItem) this.lblCountHighline,
      (ToolStripItem) this.toolStripStatusLabel5,
      (ToolStripItem) this.lblCountSelect,
      (ToolStripItem) this.toolStripStatusLabel2,
      (ToolStripItem) this.lblCountTotal,
      (ToolStripItem) this.toolStripStatusLabel7,
      (ToolStripItem) this.lblCountDeviceRunning
    });
    this.statusStrip1.Location = new Point(0, 754);
    this.statusStrip1.Name = "statusStrip1";
    this.statusStrip1.Size = new Size(1712, 22);
    this.statusStrip1.SizingGrip = false;
    this.statusStrip1.TabIndex = 9;
    this.statusStrip1.Text = "statusStrip1";
    this.statusStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
    this.toolStripStatusLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
    this.toolStripStatusLabel1.Size = new Size(78, 17);
    this.toolStripStatusLabel1.Text = "Trạng thái:";
    this.lblStatus.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.ForeColor = Color.Green;
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(97, 17);
    this.lblStatus.Text = "Đang kiểm tra...";
    this.toolStripStatusLabel3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
    this.toolStripStatusLabel3.Size = new Size(81, 17);
    this.toolStripStatusLabel3.Text = "Mã thiết bị:";
    this.lblKey.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblKey.ForeColor = Color.Teal;
    this.lblKey.Name = "lblKey";
    this.lblKey.Size = new Size(49, 17);
    this.lblKey.Text = "******";
    this.toolStripStatusLabel8.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
    this.toolStripStatusLabel8.Size = new Size(41, 17);
    this.toolStripStatusLabel8.Text = "User:";
    this.txbUid.Name = "txbUid";
    this.txbUid.Size = new Size(0, 17);
    this.lblUser.Name = "lblUser";
    this.lblUser.Size = new Size(55, 17);
    this.lblUser.Text = "******";
    this.toolStripStatusLabel9.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel9.IsLink = true;
    this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
    this.toolStripStatusLabel9.Size = new Size(66, 17);
    this.toolStripStatusLabel9.Text = "Đăng xuất";
    this.toolStripStatusLabel9.Visible = false;
    this.toolStripStatusLabel9.Click += new EventHandler(this.toolStripStatusLabel9_Click);
    this.toolStripStatusLabel10.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
    this.toolStripStatusLabel10.Size = new Size(98, 17);
    this.toolStripStatusLabel10.Text = "Ngày hết hạn:";
    this.lblDateExpried.Name = "lblDateExpried";
    this.lblDateExpried.Size = new Size(73, 17);
    this.lblDateExpried.Text = "20/10/2020";
    this.toolStripStatusLabel4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
    this.toolStripStatusLabel4.Size = new Size(59, 17);
    this.toolStripStatusLabel4.Text = "Bôi đen:";
    this.toolStripStatusLabel4.Click += new EventHandler(this.toolStripStatusLabel4_Click);
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
    this.toolStripStatusLabel7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
    this.toolStripStatusLabel7.Size = new Size(111, 17);
    this.toolStripStatusLabel7.Text = "Device Running:";
    this.lblCountDeviceRunning.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCountDeviceRunning.ForeColor = Color.DarkGreen;
    this.lblCountDeviceRunning.Name = "lblCountDeviceRunning";
    this.lblCountDeviceRunning.Size = new Size(15, 17);
    this.lblCountDeviceRunning.Text = "0";
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_1.Vertical = true;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 30000;
    this.toolTip_0.InitialDelay = 0;
    this.toolTip_0.ReshowDelay = 40;
    this.btnLoadAcc.BackgroundImage = (Image) componentResourceManager.GetObject("btnLoadAcc.BackgroundImage");
    this.btnLoadAcc.BackgroundImageLayout = ImageLayout.Center;
    this.btnLoadAcc.Cursor = Cursors.Hand;
    this.btnLoadAcc.Location = new Point(492, 2);
    this.btnLoadAcc.Name = "btnLoadAcc";
    this.btnLoadAcc.Size = new Size(25, 25);
    this.btnLoadAcc.TabIndex = 6;
    this.toolTip_0.SetToolTip((Control) this.btnLoadAcc, "Load lại danh sách");
    this.btnLoadAcc.UseSelectable = true;
    this.btnLoadAcc.Click += new EventHandler(this.btnLoadAcc_Click);
    this.btnEditFile.BackColor = Color.Gray;
    this.btnEditFile.BackgroundImage = (Image) componentResourceManager.GetObject("btnEditFile.BackgroundImage");
    this.btnEditFile.BackgroundImageLayout = ImageLayout.None;
    this.btnEditFile.Cursor = Cursors.Hand;
    this.btnEditFile.Enabled = false;
    this.btnEditFile.Location = new Point(429, 2);
    this.btnEditFile.Name = "btnEditFile";
    this.btnEditFile.Size = new Size(25, 25);
    this.btnEditFile.TabIndex = 5;
    this.toolTip_0.SetToolTip((Control) this.btnEditFile, "Sửa tên thư mục");
    this.btnEditFile.UseSelectable = true;
    this.btnEditFile.UseVisualStyleBackColor = false;
    this.btnEditFile.Click += new EventHandler(this.btnEditFile_Click);
    this.btnDeleteFile.BackColor = Color.Gray;
    this.btnDeleteFile.BackgroundImage = (Image) componentResourceManager.GetObject("btnDeleteFile.BackgroundImage");
    this.btnDeleteFile.BackgroundImageLayout = ImageLayout.None;
    this.btnDeleteFile.Cursor = Cursors.Hand;
    this.btnDeleteFile.Enabled = false;
    this.btnDeleteFile.Location = new Point(460, 2);
    this.btnDeleteFile.Name = "btnDeleteFile";
    this.btnDeleteFile.Size = new Size(25, 25);
    this.btnDeleteFile.TabIndex = 5;
    this.toolTip_0.SetToolTip((Control) this.btnDeleteFile, "Xóa thư mục");
    this.btnDeleteFile.UseSelectable = true;
    this.btnDeleteFile.UseVisualStyleBackColor = false;
    this.btnDeleteFile.Click += new EventHandler(this.btnDeleteFile_Click);
    this.btnAddFile.BackgroundImage = (Image) componentResourceManager.GetObject("btnAddFile.BackgroundImage");
    this.btnAddFile.BackgroundImageLayout = ImageLayout.None;
    this.btnAddFile.Cursor = Cursors.Hand;
    this.btnAddFile.Location = new Point(398, 2);
    this.btnAddFile.Name = "btnAddFile";
    this.btnAddFile.Size = new Size(25, 25);
    this.btnAddFile.TabIndex = 4;
    this.toolTip_0.SetToolTip((Control) this.btnAddFile, "Thêm thư mục");
    this.btnAddFile.UseSelectable = true;
    this.btnAddFile.Click += new EventHandler(this.btnAddFile_Click);
    this.btnPause.BackColor = Color.White;
    this.btnPause.Cursor = Cursors.Hand;
    this.btnPause.Enabled = false;
    this.btnPause.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnPause.Image = (Image) componentResourceManager.GetObject("btnPause.Image");
    this.btnPause.ImageAlign = ContentAlignment.MiddleRight;
    this.btnPause.Location = new Point(139, 69);
    this.btnPause.Name = "btnPause";
    this.btnPause.Size = new Size(134, 32);
    this.btnPause.TabIndex = 3;
    this.btnPause.Text = "Dừng Tương Tác      ";
    this.btnPause.TextAlign = ContentAlignment.MiddleLeft;
    this.toolTip_0.SetToolTip((Control) this.btnPause, "Dừng tương tác");
    this.btnPause.UseVisualStyleBackColor = true;
    this.btnPause.Click += new EventHandler(this.btnPause_Click);
    this.btnInteract.Cursor = Cursors.Hand;
    this.btnInteract.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnInteract.Image = (Image) componentResourceManager.GetObject("btnInteract.Image");
    this.btnInteract.ImageAlign = ContentAlignment.MiddleRight;
    this.btnInteract.Location = new Point(8, 69);
    this.btnInteract.Name = "btnInteract";
    this.btnInteract.Size = new Size(125, 32);
    this.btnInteract.TabIndex = 2;
    this.btnInteract.Text = "Chạy Tương Tác      ";
    this.btnInteract.TextAlign = ContentAlignment.MiddleLeft;
    this.toolTip_0.SetToolTip((Control) this.btnInteract, "Bắt đầu chạy tương tác");
    this.btnInteract.UseVisualStyleBackColor = false;
    this.btnInteract.Click += new EventHandler(this.btnInteract_Click);
    this.plTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.plTrangThai.BackColor = Color.Gainsboro;
    this.plTrangThai.Controls.Add((Control) this.lblTrangThai);
    this.plTrangThai.Location = new Point(1338, 36);
    this.plTrangThai.Name = "plTrangThai";
    this.plTrangThai.Size = new Size(373, 26);
    this.plTrangThai.TabIndex = 10;
    this.plTrangThai.Visible = false;
    this.lblTrangThai.Dock = DockStyle.Fill;
    this.lblTrangThai.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTrangThai.Location = new Point(0, 0);
    this.lblTrangThai.Name = "lblTrangThai";
    this.lblTrangThai.Size = new Size(373, 26);
    this.lblTrangThai.TabIndex = 0;
    this.lblTrangThai.TextAlign = ContentAlignment.MiddleRight;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.button7);
    this.panel1.Controls.Add((Control) this.button6);
    this.panel1.Controls.Add((Control) this.button5);
    this.panel1.Controls.Add((Control) this.button4);
    this.panel1.Controls.Add((Control) this.button3);
    this.panel1.Controls.Add((Control) this.plQuanLyThuMuc);
    this.panel1.Controls.Add((Control) this.panel2);
    this.panel1.Controls.Add((Control) this.btnPause);
    this.panel1.Controls.Add((Control) this.statusStrip1);
    this.panel1.Controls.Add((Control) this.btnInteract);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(1714, 778);
    this.panel1.TabIndex = 11;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.button7.BackColor = Color.White;
    this.button7.Cursor = Cursors.Hand;
    this.button7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button7.Image = (Image) Resources.icons8_multiply_20px;
    this.button7.ImageAlign = ContentAlignment.MiddleLeft;
    this.button7.Location = new Point(1318, 72);
    this.button7.Name = "button7";
    this.button7.Size = new Size(77, 27);
    this.button7.TabIndex = 12;
    this.button7.Text = "Kill ADB";
    this.button7.TextAlign = ContentAlignment.MiddleRight;
    this.button7.UseVisualStyleBackColor = true;
    this.button7.Click += new EventHandler(this.button7_Click);
    this.button6.BackColor = Color.White;
    this.button6.Cursor = Cursors.Hand;
    this.button6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button6.Image = (Image) componentResourceManager.GetObject("button6.Image");
    this.button6.ImageAlign = ContentAlignment.MiddleLeft;
    this.button6.Location = new Point(818, 383);
    this.button6.Name = "button6";
    this.button6.Size = new Size(92, 27);
    this.button6.TabIndex = 13;
    this.button6.Text = "Open File";
    this.button6.TextAlign = ContentAlignment.MiddleRight;
    this.button6.UseVisualStyleBackColor = true;
    this.button5.BackColor = Color.White;
    this.button5.Cursor = Cursors.Hand;
    this.button5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button5.Image = (Image) Resources.change_25px;
    this.button5.ImageAlign = ContentAlignment.MiddleLeft;
    this.button5.Location = new Point(1220, 72);
    this.button5.Name = "button5";
    this.button5.Size = new Size(92, 27);
    this.button5.TabIndex = 12;
    this.button5.Text = "Random";
    this.button5.TextAlign = ContentAlignment.MiddleRight;
    this.button5.UseVisualStyleBackColor = true;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.button4.BackColor = Color.White;
    this.button4.Cursor = Cursors.Hand;
    this.button4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button4.Image = (Image) componentResourceManager.GetObject("button4.Image");
    this.button4.ImageAlign = ContentAlignment.MiddleLeft;
    this.button4.Location = new Point(810, 375);
    this.button4.Name = "button4";
    this.button4.Size = new Size(92, 27);
    this.button4.TabIndex = 11;
    this.button4.Text = "Open File";
    this.button4.TextAlign = ContentAlignment.MiddleRight;
    this.button4.UseVisualStyleBackColor = true;
    this.button3.BackColor = Color.White;
    this.button3.Cursor = Cursors.Hand;
    this.button3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.Image = (Image) componentResourceManager.GetObject("button3.Image");
    this.button3.ImageAlign = ContentAlignment.MiddleLeft;
    this.button3.Location = new Point(1401, 72);
    this.button3.Name = "button3";
    this.button3.Size = new Size(92, 27);
    this.button3.TabIndex = 8;
    this.button3.Text = "Open File";
    this.button3.TextAlign = ContentAlignment.MiddleRight;
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.plQuanLyThuMuc.BorderStyle = BorderStyle.FixedSingle;
    this.plQuanLyThuMuc.Controls.Add((Control) this.cbbThuMuc);
    this.plQuanLyThuMuc.Controls.Add((Control) this.cbbTinhTrang);
    this.plQuanLyThuMuc.Controls.Add((Control) this.btnLoadAcc);
    this.plQuanLyThuMuc.Controls.Add((Control) this.label1);
    this.plQuanLyThuMuc.Controls.Add((Control) this.btnEditFile);
    this.plQuanLyThuMuc.Controls.Add((Control) this.button9);
    this.plQuanLyThuMuc.Controls.Add((Control) this.btnDeleteFile);
    this.plQuanLyThuMuc.Controls.Add((Control) this.label2);
    this.plQuanLyThuMuc.Controls.Add((Control) this.btnAddFile);
    this.plQuanLyThuMuc.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.plQuanLyThuMuc.Location = new Point(559, 69);
    this.plQuanLyThuMuc.Name = "plQuanLyThuMuc";
    this.plQuanLyThuMuc.Size = new Size(657, 31);
    this.plQuanLyThuMuc.TabIndex = 10;
    this.button9.BackColor = Color.White;
    this.button9.Cursor = Cursors.Hand;
    this.button9.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button9.Image = (Image) componentResourceManager.GetObject("button9.Image");
    this.button9.ImageAlign = ContentAlignment.MiddleLeft;
    this.button9.Location = new Point(524, 1);
    this.button9.Name = "button9";
    this.button9.Size = new Size(130, 27);
    this.button9.TabIndex = 7;
    this.button9.Text = "Nhập tài khoản";
    this.button9.TextAlign = ContentAlignment.MiddleRight;
    this.button9.UseVisualStyleBackColor = true;
    this.button9.Click += new EventHandler(this.button9_Click);
    this.panel2.BorderStyle = BorderStyle.FixedSingle;
    this.panel2.Controls.Add((Control) this.BtnSearch);
    this.panel2.Controls.Add((Control) this.cbbSearch);
    this.panel2.Controls.Add((Control) this.txbSearch);
    this.panel2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.panel2.Location = new Point(279, 69);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(274, 31);
    this.panel2.TabIndex = 10;
    this.BtnSearch.BackgroundImage = (Image) componentResourceManager.GetObject("BtnSearch.BackgroundImage");
    this.BtnSearch.BackgroundImageLayout = ImageLayout.None;
    this.BtnSearch.Cursor = Cursors.Hand;
    this.BtnSearch.Location = new Point(245, 3);
    this.BtnSearch.Name = "BtnSearch";
    this.BtnSearch.Size = new Size(24, 23);
    this.BtnSearch.TabIndex = 4;
    this.BtnSearch.UseSelectable = true;
    this.BtnSearch.Click += new EventHandler(this.BtnSearch_Click);
    this.notifyIcon_0.Text = "notifyIcon1";
    this.notifyIcon_0.Visible = true;
    this.cChose.HeaderText = "Chọn";
    this.cChose.Name = "cChose";
    this.cChose.SortMode = DataGridViewColumnSortMode.Automatic;
    this.cChose.Width = 40;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.cStt.DefaultCellStyle = gridViewCellStyle3;
    this.cStt.HeaderText = "STT";
    this.cStt.Name = "cStt";
    this.cStt.Width = 35;
    this.cId.HeaderText = "Id";
    this.cId.Name = "cId";
    this.cId.Visible = false;
    this.cId.Width = 90;
    this.cUid.HeaderText = "UID";
    this.cUid.Name = "cUid";
    this.cToken.HeaderText = "Token";
    this.cToken.Name = "cToken";
    this.cToken.Width = 70;
    this.cCookies.HeaderText = "Cookie";
    this.cCookies.Name = "cCookies";
    this.cCookies.Width = 70;
    this.cEmail.HeaderText = "Email";
    this.cEmail.Name = "cEmail";
    this.cEmail.Width = 60;
    this.cPhone.HeaderText = "Phone";
    this.cPhone.Name = "cPhone";
    this.cPhone.Visible = false;
    this.cPhone.Width = 60;
    this.cName.HeaderText = "Tên";
    this.cName.Name = "cName";
    this.cName.Width = 70;
    this.cFollow.HeaderText = "Theo dõi";
    this.cFollow.Name = "cFollow";
    this.cFollow.Width = 80;
    this.cFriend.FillWeight = 70f;
    this.cFriend.HeaderText = "Bạn bè";
    this.cFriend.Name = "cFriend";
    this.cFriend.Width = 70;
    this.cGroup.HeaderText = "Nhóm";
    this.cGroup.Name = "cGroup";
    this.cGroup.Width = 60;
    this.cBirthday.HeaderText = "Ngày sinh";
    this.cBirthday.Name = "cBirthday";
    this.cBirthday.Width = 90;
    this.cGender.HeaderText = "Giới Tính";
    this.cGender.Name = "cGender";
    this.cGender.Width = 80;
    this.cPassword.HeaderText = "Mật khẩu";
    this.cPassword.Name = "cPassword";
    this.cPassword.Visible = false;
    this.cPassword.Width = 70;
    this.cMailRecovery.HeaderText = "Email khôi phục";
    this.cMailRecovery.Name = "cMailRecovery";
    this.cMailRecovery.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.cMailRecovery.Visible = false;
    this.cMailRecovery.Width = 120;
    this.cPassMail.HeaderText = "Mật khẩu mail";
    this.cPassMail.Name = "cPassMail";
    this.cPassMail.Visible = false;
    this.cPassMail.Width = 120;
    this.cBackup.HeaderText = "Backup";
    this.cBackup.Name = "cBackup";
    this.cBackup.Width = 70;
    this.cFa2.HeaderText = "Mã 2FA";
    this.cFa2.Name = "cFa2";
    this.cFa2.Width = 80;
    this.cUseragent.HeaderText = "Useragent";
    this.cUseragent.Name = "cUseragent";
    this.cUseragent.Width = 70;
    this.cProxy.HeaderText = "Proxy";
    this.cProxy.Name = "cProxy";
    this.cProxy.Width = 55;
    this.cDateCreateAcc.HeaderText = "Ngày tạo";
    this.cDateCreateAcc.Name = "cDateCreateAcc";
    this.cDateCreateAcc.Width = 85;
    this.cAvatar.FillWeight = 50f;
    this.cAvatar.HeaderText = "Avatar";
    this.cAvatar.Name = "cAvatar";
    this.cAvatar.Width = 50;
    this.cProfile.FillWeight = 50f;
    this.cProfile.HeaderText = "Profile";
    this.cProfile.Name = "cProfile";
    this.cProfile.Width = 50;
    this.cThuMuc.HeaderText = "Thư mục";
    this.cThuMuc.Name = "cThuMuc";
    this.cInteractEnd.FillWeight = 1300f;
    this.cInteractEnd.HeaderText = "Lần tương tác cuối";
    this.cInteractEnd.Name = "cInteractEnd";
    this.cInteractEnd.Width = 150;
    this.cDevice.HeaderText = "Device Info";
    this.cDevice.Name = "cDevice";
    this.cInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
    this.cInfo.FillWeight = 90f;
    this.cInfo.HeaderText = "Tình Trạng";
    this.cInfo.Name = "cInfo";
    this.cInfo.Width = 90;
    this.cGhiChu.HeaderText = "Ghi Chú";
    this.cGhiChu.Name = "cGhiChu";
    this.cDeviceId.HeaderText = "Thiết bị";
    this.cDeviceId.Name = "cDeviceId";
    this.cIp.HeaderText = "IP";
    this.cIp.Name = "cIp";
    this.cIp.Visible = false;
    this.cStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cStatus.HeaderText = "Trạng Thái";
    this.cStatus.MinimumWidth = 450;
    this.cStatus.Name = "cStatus";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1714, 778);
    this.Controls.Add((Control) this.plTrangThai);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Controls.Add((Control) this.menuStrip1);
    this.Controls.Add((Control) this.dtgvAcc);
    this.Controls.Add((Control) this.panel1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MainMenuStrip = this.menuStrip1;
    this.Name = nameof (fMain);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "PHONE FARM";
    this.Load += new EventHandler(this.fMain_Load);
    ((ISupportInitialize) this.dtgvAcc).EndInit();
    this.ctmsAcc.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.pnlHeader.PerformLayout();
    ((ISupportInitialize) this.picLanguage).EndInit();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.bunifuCards1.ResumeLayout(false);
    this.menuStrip1.ResumeLayout(false);
    this.menuStrip1.PerformLayout();
    this.statusStrip1.ResumeLayout(false);
    this.statusStrip1.PerformLayout();
    this.plTrangThai.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.plQuanLyThuMuc.ResumeLayout(false);
    this.plQuanLyThuMuc.PerformLayout();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.ResumeLayout(false);
  }

  private void bunifuCustomLabel1_Click(object sender, EventArgs e)
  {
  }

  private void pnlHeader_Paint(object sender, PaintEventArgs e)
  {
  }

  private void button3_Click(object sender, EventArgs e) => Process.Start(Application.StartupPath + "\\");

  private void toolStripMenuItem5_Click(object sender, EventArgs e) => GClass19.smethod_35((Form) new fDeviceList());

  private void button5_Click(object sender, EventArgs e)
  {
    int num = 1;
    try
    {
      for (int index1 = 0; index1 < num; ++index1)
      {
        if (this.dtgvAcc.RowCount > 1)
        {
          List<DataGridViewRow> dataGridViewRowList = new List<DataGridViewRow>();
          foreach (DataGridViewRow row in (IEnumerable) this.dtgvAcc.Rows)
            dataGridViewRowList.Add(row);
          int count = dataGridViewRowList.Count;
          while (count > 1)
          {
            --count;
            int index2 = this.random_0.Next(count + 1);
            DataGridViewRow dataGridViewRow = dataGridViewRowList[index2];
            dataGridViewRowList[index2] = dataGridViewRowList[count];
            dataGridViewRowList[count] = dataGridViewRow;
          }
          this.dtgvAcc.Rows.Clear();
          foreach (DataGridViewRow dataGridViewRow in dataGridViewRowList)
            this.dtgvAcc.Rows.Add(dataGridViewRow);
        }
      }
    }
    catch
    {
    }
  }

  private void phoneToolStripMenuItem_Click(object sender, EventArgs e) => this.method_136("Phone");

  private void profileToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void button7_Click(object sender, EventArgs e) => GClass7.smethod_3();

  private void toolStripMenuItem_26_Click(object sender, EventArgs e)
  {
  }

  private void devicesToolStripMenuItem_Click(object sender, EventArgs e) => this.method_11("device");

  private void phoneToolStripMenuItem1_Click(object sender, EventArgs e) => this.method_11("phone");
}
