// Decompiled with JetBrains decompiler
// Type: fCauHinhChung
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class fCauHinhChung : Form
{
  private Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();
  private string string_0 = "";
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Label label5;
  private NumericUpDown nudHideThread;
  private Label label6;
  private Panel panel1;
  private GroupBox groupBox2;
  private GroupBox groupBox3;
  private ComboBox cbbHostpot;
  private Button button5;
  private Panel plNordVPN;
  private Label label14;
  private TextBox txtNordVPN;
  private Button btnSSH;
  private Label label26;
  private Label label27;
  private RadioButton rbSSH;
  private RadioButton rbExpressVPN;
  private NumericUpDown nudChangeIpCount;
  private RadioButton rbNordVPN;
  private RadioButton rbHotspot;
  private RadioButton rbDcom;
  private RadioButton rbHma;
  private BunifuDragControl bunifuDragControl_0;
  private ToolTip toolTip_0;
  private Button btnCancel;
  private Button btnSave;
  private BunifuCards bunifuCards2;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button button2;
  private Panel plTinsoft;
  private ComboBox cbbLocationTinsoft;
  private Label label7;
  private Label label1;
  private TextBox txtApiUser;
  private Label label8;
  private NumericUpDown nudLuongPerIPTinsoft;
  private RadioButton rbTinsoft;
  private Button button3;
  private Panel panel2;
  private Label label12;
  private TextBox textBox1;
  private RadioButton radioButton5;
  private RadioButton radioButton4;
  private RadioButton radioButton3;
  private RadioButton radioButton2;
  private Panel plXproxy;
  private Label label17;
  private Label label13;
  private TextBox txtServiceURLXProxy;
  private RadioButton rbXproxy;
  private RichTextBox txtListProxy;
  private Panel plCheckDoiIP;
  private RadioButton rbProxy;
  private Panel plTMProxy;
  private RichTextBox txtApiKeyTMProxy;
  private Label label24;
  private Label label25;
  private NumericUpDown nudLuongPerIPTMProxy;
  private RadioButton rbTMProxy;
  private GroupBox groupBox1;
  private RadioButton rbPhanBietMauChu;
  private RadioButton rbPhanBietMauNen;
  private Label label23;
  private LinkLabel linkLabel3;
  private Panel plApiProxy;
  private Label lblCountApiProxy;
  private Label label28;
  private TextBox txtApiProxy;
  private Button button7;
  private Panel plApiUser;
  private RadioButton rbApiProxy;
  private RadioButton rbApiUser;
  private CheckBox ckbWaitDoneAllTinsoft;
  private CheckBox ckbWaitDoneAllTMProxy;
  private Button button8;
  private Panel panel4;
  private CheckBox ckbKhongCheckIP;
  private RadioButton rbNone;
  private Panel plDongBoMaxCare;
  private Label label15;
  private TextBox txtPathMaxCare;
  private CheckBox ckbDongBoMaxCare;
  private Panel plDcom;
  private Button button4;
  private TextBox txtUrlHilink;
  private TextBox txtProfileNameDcom;
  private RadioButton rbDcomHilink;
  private Label label19;
  private RadioButton rbDcomThuong;
  private Panel plShopLike;
  private RichTextBox txtApiShopLike;
  private Label label47;
  private Label label48;
  private NumericUpDown nudLuongPerIPShopLike;
  private RadioButton rbShopLike;
  private Panel plProxyv6;
  private RichTextBox txtListProxyv6;
  private Label label43;
  private Label label44;
  private NumericUpDown nudLuongPerIPProxyv6;
  private Label label45;
  private TextBox txtApiProxyv6;
  private RadioButton rbProxyv6;
  private CheckBox ckbLuuTrangThai;
  private Label label37;
  private NumericUpDown nudDelayCheckIP;
  private Label label38;
  private Panel plObcProxy;
  private Label label33;
  private RadioButton rbObcResetDaiIP;
  private RadioButton rbObcResetTungIP;
  private RichTextBox txtListObcProxy;
  private Label label34;
  private Label label35;
  private Label label40;
  private NumericUpDown nudLuongPerIPObcProxy;
  private Label label39;
  private Label label41;
  private NumericUpDown nudDelayCheckIPObcProxy;
  private TextBox txtLinkWebObcProxy;
  private RadioButton rbObcProxy;
  private TabControl tabChangeIP;
  private TabPage tabDcom;
  private TabPage tabTinsoft;
  private TabPage tabXProxy;
  private TabPage tabObcProxy;
  private TabPage tabProxyV6;
  private TabPage tabProxyShopLike;
  private TabPage tabTMProxy;
  private TabPage tabNone;
  private Panel panel5;
  private RadioButton rbMinProxy;
  private TabPage tabMinProxy;
  private Panel panel6;
  private Panel plTypeProxy;
  private RadioButton rbHttpv6;
  private RadioButton rbHttpv4;
  private Label label56;
  private RadioButton rbProxyDanCu;
  private RadioButton rbProxyDong;
  private Button button10;
  private RichTextBox txtApiKeyMinProxy;
  private Label label49;
  private NumericUpDown nudLuongPerIPMinProxy;
  private Label label42;
  private RadioButton rb4G;
  private Label label2;
  private Label label3;
  private NumericUpDown nudDelayConnectXproxy;
  private CheckBox ckbTatADBKhiDungTool;
  private CheckBox ckbKhongChangeDevice;
  private GroupBox groupBox4;
  private Label label9;
  private Panel plChangeDevice;
  private Button button1;
  private TextBox txtBrandDevice;
  private CheckBox ckbShowProxy;
  private Label label4;
  private Panel plTypeConnectProxy;
  private RadioButton rbConnectProxyCollectProxy;
  private RadioButton rbConnectProxyADB;
  private IContainer components;
  private NumericUpDown nudDelayThread;
  private Label label16;
  private Label label11;
  private Label label10;

  public fCauHinhChung()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
  }

  public fCauHinhChung(ref Dictionary<string, bool> dictionary_1)
  {
    this.InitializeComponent();
    this.dictionary_0 = dictionary_1;
    GClass35.smethod_5((Control) this);
  }

  private void method_0()
  {
    this.cbbLocationTinsoft.DataSource = (object) new BindingSource((object) this.method_1(), (string) null);
    this.cbbLocationTinsoft.ValueMember = "Key";
    this.cbbLocationTinsoft.DisplayMember = "Value";
  }

  public Dictionary<string, string> method_1()
  {
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    List<string> stringList = Class44.smethod_1();
    for (int index = 0; index < stringList.Count; ++index)
    {
      string[] strArray = stringList[index].Split('|');
      dictionary.Add(strArray[0], strArray[1]);
    }
    return dictionary;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void fCauHinhChung_Load(object sender, EventArgs e)
  {
    this.method_0();
    this.nudHideThread.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudHideThread", 5);
    this.nudDelayThread.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudDelayThread", 5);
    this.ckbDongBoMaxCare.Checked = GClass33.smethod_0("configGeneral").method_4("ckbDongBoMaxCare");
    this.txtPathMaxCare.Text = GClass33.smethod_0("configGeneral").method_1("txtPathMaxCare");
    this.string_0 = !this.ckbDongBoMaxCare.Checked ? "" : this.txtPathMaxCare.Text;
    this.txtBrandDevice.Text = GClass33.smethod_0("configGeneral").method_1("txtBrandDevice", "Random");
    this.ckbKhongChangeDevice.Checked = GClass33.smethod_0("configGeneral").method_4("ckbKhongChangeDevice");
    this.ckbKhongCheckIP.Checked = GClass33.smethod_0("configGeneral").method_4("ckbKhongCheckIP");
    this.nudChangeIpCount.Value = (Decimal) Convert.ToInt32(GClass33.smethod_0("configGeneral").method_1("ip_nudChangeIpCount") == "" ? "1" : GClass33.smethod_0("configGeneral").method_1("ip_nudChangeIpCount"));
    this.nudDelayCheckIP.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudDelayCheckIP");
    switch (Convert.ToInt32(GClass33.smethod_0("configGeneral").method_1("ip_iTypeChangeIp") == "" ? "0" : GClass33.smethod_0("configGeneral").method_1("ip_iTypeChangeIp")))
    {
      case 0:
        this.rbNone.Checked = true;
        break;
      case 1:
        this.rbHma.Checked = true;
        break;
      case 2:
        this.rbDcom.Checked = true;
        break;
      case 3:
        this.rbSSH.Checked = true;
        break;
      case 4:
        this.rbExpressVPN.Checked = true;
        break;
      case 5:
        this.rbHotspot.Checked = true;
        break;
      case 6:
        this.rbNordVPN.Checked = true;
        break;
      case 7:
        this.rbTinsoft.Checked = true;
        break;
      case 8:
        this.rbXproxy.Checked = true;
        break;
      case 9:
        this.rbProxy.Checked = true;
        break;
      case 10:
        this.rbTMProxy.Checked = true;
        break;
      case 11:
        this.rbProxyv6.Checked = true;
        break;
      case 12:
        this.rbShopLike.Checked = true;
        break;
      case 13:
        this.rbMinProxy.Checked = true;
        break;
      case 14:
        this.rbObcProxy.Checked = true;
        break;
      case 15:
        this.rb4G.Checked = true;
        break;
    }
    if (GClass33.smethod_0("configGeneral").method_3("typeDcom") == 0)
      this.rbDcomThuong.Checked = true;
    else
      this.rbDcomHilink.Checked = true;
    this.txtProfileNameDcom.Text = GClass33.smethod_0("configGeneral").method_1("ip_txtProfileNameDcom");
    this.txtUrlHilink.Text = GClass33.smethod_0("configGeneral").method_1("txtUrlHilink", "http://192.168.1.1/html/home.html");
    this.txtNordVPN.Text = GClass33.smethod_0("configGeneral").method_1("ip_txtNordVPN");
    this.cbbHostpot.SelectedIndex = Convert.ToInt32(GClass33.smethod_0("configGeneral").method_1("ip_cbbHostpot") == "" ? "0" : GClass33.smethod_0("configGeneral").method_1("ip_cbbHostpot"));
    if (GClass33.smethod_0("configGeneral").method_3("typeApiTinsoft") == 0)
      this.rbApiUser.Checked = true;
    else
      this.rbApiProxy.Checked = true;
    this.txtApiUser.Text = GClass33.smethod_0("configGeneral").method_1("txtApiUser");
    this.txtApiProxy.Text = GClass33.smethod_0("configGeneral").method_1("txtApiProxy");
    this.cbbLocationTinsoft.SelectedValue = GClass33.smethod_0("configGeneral").method_1("cbbLocationTinsoft") == "" ? (object) "0" : (object) GClass33.smethod_0("configGeneral").method_1("cbbLocationTinsoft");
    this.nudLuongPerIPTinsoft.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPTinsoft");
    this.ckbWaitDoneAllTinsoft.Checked = GClass33.smethod_0("configGeneral").method_4("ckbWaitDoneAllTinsoft");
    this.txtServiceURLXProxy.Text = GClass33.smethod_0("configGeneral").method_1("txtServiceURLXProxy");
    this.txtListProxy.Text = GClass33.smethod_0("configGeneral").method_1("txtListProxy");
    this.ckbShowProxy.Checked = GClass33.smethod_0("configGeneral").method_4("ckbShowProxy");
    this.nudDelayConnectXproxy.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudDelayConnectXproxy", 5);
    this.txtApiKeyTMProxy.Text = GClass33.smethod_0("configGeneral").method_1("txtApiKeyTMProxy");
    this.nudLuongPerIPTMProxy.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPTMProxy", 1);
    this.ckbWaitDoneAllTMProxy.Checked = GClass33.smethod_0("configGeneral").method_4("ckbWaitDoneAllTMProxy");
    this.txtApiProxyv6.Text = GClass33.smethod_0("configGeneral").method_1("txtApiProxyv6");
    this.txtListProxyv6.Text = GClass33.smethod_0("configGeneral").method_1("txtListProxyv6");
    this.nudLuongPerIPProxyv6.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPProxyv6", 1);
    this.txtApiShopLike.Text = GClass33.smethod_0("configGeneral").method_1("txtApiShopLike");
    this.nudLuongPerIPShopLike.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPShopLike", 1);
    if (GClass33.smethod_0("configGeneral").method_3("typeMin") == 0)
      this.rbProxyDong.Checked = true;
    else
      this.rbProxyDanCu.Checked = true;
    switch (GClass33.smethod_0("configGeneral").method_3("typeProxyMin"))
    {
      case 0:
        this.rbHttpv4.Checked = true;
        break;
      case 1:
        this.rbHttpv6.Checked = true;
        break;
    }
    this.txtApiKeyMinProxy.Text = GClass33.smethod_0("configGeneral").method_1("txtApiKeyMinProxy");
    this.nudLuongPerIPMinProxy.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPMinProxy");
    this.txtLinkWebObcProxy.Text = GClass33.smethod_0("configGeneral").method_1("txtLinkWebObcProxy");
    this.txtListObcProxy.Text = GClass33.smethod_0("configGeneral").method_1("txtListObcProxy");
    this.nudLuongPerIPObcProxy.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudLuongPerIPObcProxy", 1);
    if (GClass33.smethod_0("configGeneral").method_3("typeRunObcProxy") == 0)
      this.rbObcResetTungIP.Checked = true;
    else
      this.rbObcResetDaiIP.Checked = true;
    this.nudDelayCheckIPObcProxy.Value = (Decimal) GClass33.smethod_0("configGeneral").method_3("nudDelayCheckIPObcProxy", 1);
    if (GClass33.smethod_0("configGeneral").method_3("typeConnectProxy") == 0)
      this.rbConnectProxyADB.Checked = true;
    else
      this.rbConnectProxyCollectProxy.Checked = true;
    if (GClass33.smethod_0("configGeneral").method_3("typePhanBietMau") == 0)
      this.rbPhanBietMauNen.Checked = true;
    else
      this.rbPhanBietMauChu.Checked = true;
    this.ckbLuuTrangThai.Checked = GClass33.smethod_0("configGeneral").method_4("ckbLuuTrangThai");
    this.ckbTatADBKhiDungTool.Checked = GClass33.smethod_0("configGeneral").method_4("ckbTatADBKhiDungTool");
    this.ckbKhongChangeDevice.Checked = GClass33.smethod_0("configGeneral").method_4("ckbKhongChangeDevice");
    this.method_4();
    this.method_2();
  }

  private void method_2()
  {
    this.txtApiProxy_TextChanged((object) null, (EventArgs) null);
    this.txtListProxy_TextChanged((object) null, (EventArgs) null);
    this.txtListObcProxy_TextChanged((object) null, (EventArgs) null);
    this.txtApiKeyMinProxy_TextChanged((object) null, (EventArgs) null);
    this.txtApiKeyTMProxy_TextChanged((object) null, (EventArgs) null);
    this.txtApiShopLike_TextChanged((object) null, (EventArgs) null);
    this.txtListProxyv6_TextChanged((object) null, (EventArgs) null);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    try
    {
      GClass33.smethod_0("configGeneral").method_6("nudHideThread", (object) this.nudHideThread.Value);
      GClass33.smethod_0("configGeneral").method_6("nudDelayThread", (object) this.nudDelayThread.Value);
      GClass33.smethod_0("configGeneral").method_6("ckbDongBoMaxCare", (object) this.ckbDongBoMaxCare.Checked);
      string object_0_1 = this.txtPathMaxCare.Text.Trim();
      if (this.ckbDongBoMaxCare.Checked && !File.Exists(object_0_1 + "\\database\\db_maxcare.sqlite"))
      {
        GClass14.smethod_0((object) "Đường dẫn MaxCare không hợp lệ!", 3);
      }
      else
      {
        GClass33.smethod_0("configGeneral").method_6("txtPathMaxCare", (object) object_0_1);
        if (!this.ckbDongBoMaxCare.Checked)
          object_0_1 = "";
        GClass33.smethod_0("configGeneral").method_6("txtBrandDevice", (object) this.txtBrandDevice.Text);
        Class54.string_7 = this.txtBrandDevice.Text;
        GClass33.smethod_0("configGeneral").method_6("ckbKhongChangeDevice", (object) this.ckbKhongChangeDevice.Checked);
        GClass33.smethod_0("configGeneral").method_6("ckbKhongCheckIP", (object) this.ckbKhongCheckIP.Checked);
        GClass33.smethod_0("configGeneral").method_6("ip_nudChangeIpCount", (object) this.nudChangeIpCount.Value);
        GClass33.smethod_0("configGeneral").method_6("nudDelayCheckIP", (object) this.nudDelayCheckIP.Value);
        int object_0_2 = 0;
        if (this.rbNone.Checked)
          object_0_2 = 0;
        else if (this.rbHma.Checked)
          object_0_2 = 1;
        else if (this.rbDcom.Checked)
          object_0_2 = 2;
        else if (this.rbSSH.Checked)
          object_0_2 = 3;
        else if (this.rbExpressVPN.Checked)
          object_0_2 = 4;
        else if (this.rbHotspot.Checked)
          object_0_2 = 5;
        else if (this.rbNordVPN.Checked)
          object_0_2 = 6;
        else if (this.rbTinsoft.Checked)
          object_0_2 = 7;
        else if (this.rbXproxy.Checked)
          object_0_2 = 8;
        else if (this.rbProxy.Checked)
          object_0_2 = 9;
        else if (this.rbTMProxy.Checked)
          object_0_2 = 10;
        else if (this.rbProxyv6.Checked)
          object_0_2 = 11;
        else if (this.rbShopLike.Checked)
          object_0_2 = 12;
        else if (this.rbMinProxy.Checked)
          object_0_2 = 13;
        else if (this.rbObcProxy.Checked)
          object_0_2 = 14;
        else if (this.rb4G.Checked)
          object_0_2 = 15;
        GClass33.smethod_0("configGeneral").method_6("ip_iTypeChangeIp", (object) object_0_2);
        if (this.rbDcomThuong.Checked)
          GClass33.smethod_0("configGeneral").method_6("typeDcom", (object) 0);
        else
          GClass33.smethod_0("configGeneral").method_6("typeDcom", (object) 1);
        GClass33.smethod_0("configGeneral").method_6("txtUrlHilink", (object) this.txtUrlHilink.Text);
        GClass33.smethod_0("configGeneral").method_6("ip_txtProfileNameDcom", (object) this.txtProfileNameDcom.Text);
        GClass33.smethod_0("configGeneral").method_6("ip_txtNordVPN", (object) this.txtNordVPN.Text);
        GClass33.smethod_0("configGeneral").method_6("ip_cbbHostpot", (object) this.cbbHostpot.SelectedIndex);
        if (this.rbApiUser.Checked)
          GClass33.smethod_0("configGeneral").method_6("typeApiTinsoft", (object) 0);
        else
          GClass33.smethod_0("configGeneral").method_6("typeApiTinsoft", (object) 1);
        GClass33.smethod_0("configGeneral").method_6("txtApiUser", (object) this.txtApiUser.Text);
        GClass33.smethod_0("configGeneral").method_6("txtApiProxy", (object) this.txtApiProxy.Text);
        GClass33.smethod_0("configGeneral").method_6("cbbLocationTinsoft", this.cbbLocationTinsoft.SelectedValue);
        GClass33.smethod_0("configGeneral").method_6("nudLuongPerIPTinsoft", (object) this.nudLuongPerIPTinsoft.Value);
        GClass33.smethod_0("configGeneral").method_6("ckbWaitDoneAllTinsoft", (object) this.ckbWaitDoneAllTinsoft.Checked);
        GClass33.smethod_0("configGeneral").method_6("txtServiceURLXProxy", (object) this.txtServiceURLXProxy.Text);
        GClass33.smethod_0("configGeneral").method_6("txtListProxy", (object) this.txtListProxy.Text);
        GClass33.smethod_0("configGeneral").method_6("ckbShowProxy", (object) this.ckbShowProxy.Checked);
        GClass33.smethod_0("configGeneral").method_6("nudDelayConnectXproxy", (object) this.nudDelayConnectXproxy.Value);
        GClass33.smethod_0("configGeneral").method_6("txtApiKeyTMProxy", (object) this.txtApiKeyTMProxy.Text);
        GClass33.smethod_0("configGeneral").method_6("nudLuongPerIPTMProxy", (object) this.nudLuongPerIPTMProxy.Value);
        GClass33.smethod_0("configGeneral").method_6("ckbWaitDoneAllTMProxy", (object) this.ckbWaitDoneAllTMProxy.Checked);
        GClass33.smethod_0("configGeneral").method_6("txtApiProxyv6", (object) this.txtApiProxyv6.Text);
        GClass33.smethod_0("configGeneral").method_6("txtListProxyv6", (object) this.txtListProxyv6.Text);
        GClass33.smethod_0("configGeneral").method_6("nudLuongPerIPProxyv6", (object) this.nudLuongPerIPProxyv6.Value);
        GClass33.smethod_0("configGeneral").method_6("txtApiShopLike", (object) this.txtApiShopLike.Text);
        GClass33.smethod_0("configGeneral").method_6("nudLuongPerIPShopLike", (object) this.nudLuongPerIPShopLike.Value);
        int object_0_3 = 0;
        if (this.rbProxyDanCu.Checked)
          object_0_3 = 1;
        GClass33.smethod_0("configGeneral").method_6("typeMin", (object) object_0_3);
        int object_0_4 = 0;
        if (this.rbHttpv6.Checked)
          object_0_4 = 1;
        GClass33.smethod_0("configGeneral").method_6("typeProxyMin", (object) object_0_4);
        GClass33.smethod_0("configGeneral").method_6("txtApiKeyMinProxy", (object) this.txtApiKeyMinProxy.Text);
        GClass33.smethod_0("configGeneral").method_6("nudLuongPerIPMinProxy", (object) this.nudLuongPerIPMinProxy.Value);
        GClass33.smethod_0("configGeneral").method_6("txtLinkWebObcProxy", (object) this.txtLinkWebObcProxy.Text);
        GClass33.smethod_0("configGeneral").method_6("txtListObcProxy", (object) this.txtListObcProxy.Text);
        GClass33.smethod_0("configGeneral").method_6("nudLuongPerIPObcProxy", (object) this.nudLuongPerIPObcProxy.Value);
        if (this.rbObcResetTungIP.Checked)
          GClass33.smethod_0("configGeneral").method_6("typeRunObcProxy", (object) 0);
        else
          GClass33.smethod_0("configGeneral").method_6("typeRunObcProxy", (object) 1);
        GClass33.smethod_0("configGeneral").method_6("nudDelayCheckIPObcProxy", (object) this.nudDelayCheckIPObcProxy.Value);
        if (this.rbConnectProxyADB.Checked)
          GClass33.smethod_0("configGeneral").method_6("typeConnectProxy", (object) 0);
        else
          GClass33.smethod_0("configGeneral").method_6("typeConnectProxy", (object) 1);
        if (this.rbPhanBietMauNen.Checked)
          GClass33.smethod_0("configGeneral").method_6("typePhanBietMau", (object) 0);
        else
          GClass33.smethod_0("configGeneral").method_6("typePhanBietMau", (object) 1);
        GClass33.smethod_0("configGeneral").method_6("ckbLuuTrangThai", (object) this.ckbLuuTrangThai.Checked);
        GClass33.smethod_0("configGeneral").method_6("ckbTatADBKhiDungTool", (object) this.ckbTatADBKhiDungTool.Checked);
        GClass33.smethod_0("configGeneral").method_6("ckbKhongChangeDevice", (object) this.ckbKhongChangeDevice.Checked);
        Class121.bool_0 = this.ckbLuuTrangThai.Checked;
        GClass33.smethod_2("configGeneral");
        if (GClass14.smethod_1(GClass35.smethod_0("Lưu thành công, bạn có muốn đóng cửa sổ?")) == DialogResult.Yes)
          this.Close();
        if (!(this.string_0 != object_0_1))
          return;
        Class54.string_4 = Class54.smethod_1();
        this.dictionary_0["isChangePathDatabase"] = true;
      }
    }
    catch
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Lỗi!"));
    }
  }

  private void button5_Click(object sender, EventArgs e)
  {
    if (GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp") == 0)
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn loại đổi IP"), 3);
    else if (GClass19.smethod_82(GClass33.smethod_0("configGeneral").method_3("ip_iTypeChangeIp"), GClass33.smethod_0("configGeneral").method_3("typeDcom"), GClass33.smethod_0("configGeneral").method_1("ip_txtProfileNameDcom"), GClass33.smethod_0("configGeneral").method_1("txtUrlHilink"), GClass33.smethod_0("configGeneral").method_3("ip_cbbHostpot"), GClass33.smethod_0("configGeneral").method_1("ip_txtNordVPN")))
      GClass14.smethod_0((object) GClass35.smethod_0("Đổi IP thành công!"));
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Đổi IP thất bại!"), 2);
  }

  private void btnSSH_Click(object sender, EventArgs e) => Process.Start("changeip\\ssh.txt");

  private void method_3(object sender, EventArgs e)
  {
    if (!GClass20.smethod_25())
      GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng cập nhật chromedriver!"), 3);
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Phiên bản chromedriver khả dụng!"));
  }

  private void rbTinsoft_CheckedChanged(object sender, EventArgs e)
  {
    this.plTinsoft.Enabled = this.rbTinsoft.Checked;
    this.method_5(this.rbTinsoft);
  }

  private void radioButton3_CheckedChanged(object sender, EventArgs e) => this.panel2.Enabled = this.rbNordVPN.Checked;

  private void method_4()
  {
    this.method_8((object) null, (EventArgs) null);
    this.method_9((object) null, (EventArgs) null);
    this.method_10((object) null, (EventArgs) null);
    this.rbTinsoft_CheckedChanged((object) null, (EventArgs) null);
    this.radioButton3_CheckedChanged((object) null, (EventArgs) null);
    this.rbDcom_CheckedChanged((object) null, (EventArgs) null);
    this.rbXproxy_CheckedChanged((object) null, (EventArgs) null);
    this.rbHma_CheckedChanged((object) null, (EventArgs) null);
    this.rbTMProxy_CheckedChanged((object) null, (EventArgs) null);
    this.rbApiUser_CheckedChanged((object) null, (EventArgs) null);
    this.rbApiProxy_CheckedChanged((object) null, (EventArgs) null);
    this.ckbDongBoMaxCare_CheckedChanged((object) null, (EventArgs) null);
    this.rbProxyv6_CheckedChanged((object) null, (EventArgs) null);
    this.rbShopLike_CheckedChanged((object) null, (EventArgs) null);
    this.method_13((object) null, (EventArgs) null);
    this.rbObcProxy_CheckedChanged((object) null, (EventArgs) null);
    this.rbDcomThuong_CheckedChanged((object) null, (EventArgs) null);
    this.rbDcomHilink_CheckedChanged((object) null, (EventArgs) null);
    this.rbMinProxy_CheckedChanged((object) null, (EventArgs) null);
    this.rbNone_CheckedChanged((object) null, (EventArgs) null);
    this.rbProxy_CheckedChanged((object) null, (EventArgs) null);
    this.rbProxyDanCu_CheckedChanged((object) null, (EventArgs) null);
    this.rb4G_CheckedChanged((object) null, (EventArgs) null);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    List<string> stringList = Class46.smethod_2(this.txtApiUser.Text.Trim());
    if (stringList.Count > 0)
      GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Đang có {0} proxy khả dụng!"), (object) stringList.Count));
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Không có proxy khả dụng!"), 2);
  }

  private void rbDcom_CheckedChanged(object sender, EventArgs e)
  {
    this.plDcom.Enabled = this.rbDcom.Checked;
    this.method_6();
    this.method_5(this.rbDcom);
  }

  private void method_5(RadioButton radioButton_0)
  {
    if (radioButton_0 == null || !radioButton_0.Checked)
      return;
    this.tabChangeIP.SelectedTab = !(radioButton_0.Name == this.rbDcom.Name) ? (!(radioButton_0.Name == this.rbXproxy.Name) ? (!(radioButton_0.Name == this.rbTinsoft.Name) ? (!(radioButton_0.Name == this.rbTMProxy.Name) ? (!(radioButton_0.Name == this.rbObcProxy.Name) ? (!(radioButton_0.Name == this.rbProxyv6.Name) ? (!(radioButton_0.Name == this.rbShopLike.Name) ? (!(radioButton_0.Name == this.rbMinProxy.Name) ? this.tabNone : this.tabMinProxy) : this.tabProxyShopLike) : this.tabProxyV6) : this.tabObcProxy) : this.tabTMProxy) : this.tabTinsoft) : this.tabXProxy) : this.tabDcom;
  }

  private void rbXproxy_CheckedChanged(object sender, EventArgs e)
  {
    this.plXproxy.Enabled = this.rbXproxy.Checked;
    this.method_5(this.rbXproxy);
  }

  private void method_6() => this.plCheckDoiIP.Enabled = this.rbDcom.Checked || this.rbHma.Checked;

  private void rbHma_CheckedChanged(object sender, EventArgs e)
  {
    this.method_6();
    this.method_5(this.rbHma);
  }

  private void button4_Click(object sender, EventArgs e)
  {
    try
    {
      string end = Process.Start(new ProcessStartInfo("rasdial.exe")
      {
        UseShellExecute = false,
        RedirectStandardOutput = true,
        CreateNoWindow = true
      }).StandardOutput.ReadToEnd();
      if (end.Split('\n').Length <= 3)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng kết nối Dcom trước!"), 2);
      }
      else
      {
        this.txtProfileNameDcom.Text = ((IEnumerable<string>) end.Split('\n')).ToList<string>()[1];
        GClass14.smethod_0((object) GClass35.smethod_0("Lấy tên cấu hình Dcom thành công!"));
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "change ip dcom");
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
    }
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
  }

  private void rbTMProxy_CheckedChanged(object sender, EventArgs e)
  {
    this.plTMProxy.Enabled = this.rbTMProxy.Checked;
    this.method_5(this.rbTMProxy);
  }

  private void method_7(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      Process.Start("https://youtu.be/eexEDCyPbR8");
    }
    catch
    {
    }
  }

  private void txtApiProxy_TextChanged(object sender, EventArgs e)
  {
    try
    {
      this.lblCountApiProxy.Text = "(" + GClass19.smethod_39(((IEnumerable<string>) this.txtApiProxy.Lines).ToList<string>()).Count.ToString() + ")";
    }
    catch
    {
    }
  }

  private void rbApiUser_CheckedChanged(object sender, EventArgs e) => this.plApiUser.Enabled = this.rbApiUser.Checked;

  private void rbApiProxy_CheckedChanged(object sender, EventArgs e) => this.plApiProxy.Enabled = this.rbApiProxy.Checked;

  private void button7_Click(object sender, EventArgs e)
  {
    List<string> stringList = new List<string>();
    foreach (string string_5 in GClass19.smethod_39(((IEnumerable<string>) this.txtApiProxy.Lines).ToList<string>()))
    {
      if (Class46.smethod_1(string_5))
        stringList.Add(string_5);
    }
    this.txtApiProxy.Lines = stringList.ToArray();
    if (stringList.Count > 0)
      GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Đang có {0} proxy khả dụng!"), (object) stringList.Count));
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Không có proxy khả dụng!"), 2);
  }

  private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      Process.Start("https://www.youtube.com/watch?v=XZTveKk-utY");
    }
    catch
    {
    }
  }

  private void plObcProxy_Click(object sender, EventArgs e)
  {
  }

  private void plTinsoft_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.ckbWaitDoneAllTinsoft.Visible = true;
  }

  private void plTMProxy_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.ckbWaitDoneAllTMProxy.Visible = true;
  }

  private void button8_Click(object sender, EventArgs e)
  {
    List<string> stringList = new List<string>();
    foreach (string string_3 in GClass19.smethod_39(((IEnumerable<string>) this.txtApiKeyTMProxy.Lines).ToList<string>()))
    {
      if (Class47.smethod_0(string_3))
        stringList.Add(string_3);
    }
    this.txtApiKeyTMProxy.Lines = stringList.ToArray();
    if (stringList.Count > 0)
      GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Đang có {0} proxy khả dụng!"), (object) stringList.Count));
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Không có proxy khả dụng!"), 2);
  }

  private void txtApiKeyTMProxy_TextChanged(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtApiKeyTMProxy.Lines).ToList<string>());
      this.label24.Text = string.Format(GClass35.smethod_0("Nhập API KEY ({0}):"), (object) stringList.Count.ToString());
    }
    catch
    {
    }
  }

  private void txtListProxy_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtListProxy, (Control) this.label17);

  private void method_8(object sender, EventArgs e)
  {
  }

  private void method_9(object sender, EventArgs e)
  {
  }

  private void method_10(object sender, EventArgs e)
  {
  }

  private void ckbDongBoMaxCare_CheckedChanged(object sender, EventArgs e) => this.plDongBoMaxCare.Enabled = this.ckbDongBoMaxCare.Checked;

  private void rbDcomThuong_CheckedChanged(object sender, EventArgs e)
  {
    this.button4.Enabled = this.rbDcomThuong.Checked;
    this.txtProfileNameDcom.Enabled = this.rbDcomThuong.Checked;
  }

  private void rbDcomHilink_CheckedChanged(object sender, EventArgs e)
  {
    this.txtUrlHilink.Enabled = this.rbDcomHilink.Checked;
    this.label19.Enabled = this.rbDcomHilink.Checked;
  }

  private void txtApiShopLike_TextChanged(object sender, EventArgs e)
  {
    List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtApiShopLike.Lines).ToList<string>());
    this.label47.Text = string.Format(GClass35.smethod_0("Nhập API KEY ({0}):"), (object) stringList.Count.ToString());
  }

  private void txtListProxyv6_TextChanged(object sender, EventArgs e)
  {
    List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txtListProxyv6.Lines).ToList<string>());
    this.label43.Text = string.Format(GClass35.smethod_0("Nhập Proxy ({0}):"), (object) stringList.Count.ToString());
  }

  private void rbShopLike_CheckedChanged(object sender, EventArgs e)
  {
    this.plShopLike.Enabled = this.rbShopLike.Checked;
    this.method_5(this.rbShopLike);
  }

  private void rbProxyv6_CheckedChanged(object sender, EventArgs e)
  {
    this.plProxyv6.Enabled = this.rbProxyv6.Checked;
    this.method_5(this.rbProxyv6);
  }

  private void method_11(object sender, EventArgs e)
  {
  }

  private void method_12(object sender, EventArgs e)
  {
    if (this.plXproxy.Height == 242)
    {
      this.plXproxy.Height = 170;
      (sender as Button).BackgroundImage = (Image) Resource.Bitmap_132;
    }
    else
    {
      this.plXproxy.Height = 242;
      (sender as Button).BackgroundImage = (Image) Resource.Bitmap_109;
    }
  }

  private void method_13(object sender, EventArgs e)
  {
  }

  private void txtListObcProxy_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtListObcProxy, (Control) this.label34);

  private void rbObcProxy_CheckedChanged(object sender, EventArgs e)
  {
    this.plObcProxy.Enabled = this.rbObcProxy.Checked;
    this.method_5(this.rbObcProxy);
  }

  private void rbNone_CheckedChanged(object sender, EventArgs e) => this.method_5(this.rbNone);

  private void rbProxy_CheckedChanged(object sender, EventArgs e) => this.method_5(this.rbProxy);

  private void rbMinProxy_CheckedChanged(object sender, EventArgs e)
  {
    this.panel5.Enabled = this.rbMinProxy.Checked;
    this.method_5(this.rbMinProxy);
  }

  private void txtApiKeyMinProxy_TextChanged(object sender, EventArgs e) => GClass19.smethod_5(this.txtApiKeyMinProxy, (Control) this.label49);

  private void button10_Click(object sender, EventArgs e)
  {
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = GClass19.smethod_39(((IEnumerable<string>) this.txtApiKeyMinProxy.Lines).ToList<string>());
    int int_9 = 0;
    if (this.rbProxyDanCu.Checked)
      int_9 = 1;
    foreach (string string_5 in stringList2)
    {
      if (Class4.smethod_0(int_9, string_5))
        stringList1.Add(string_5);
    }
    this.txtApiKeyMinProxy.Lines = stringList1.ToArray();
    if (stringList1.Count > 0)
      GClass14.smethod_0((object) string.Format(GClass35.smethod_0("Đang có {0} proxy khả dụng!"), (object) stringList1.Count));
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Không có proxy khả dụng!"), 2);
  }

  private void rbProxyDanCu_CheckedChanged(object sender, EventArgs e) => this.plTypeProxy.Enabled = this.rbProxyDanCu.Checked;

  private void rb4G_CheckedChanged(object sender, EventArgs e) => this.method_5(this.rb4G);

  private void ckbShowProxy_CheckedChanged(object sender, EventArgs e) => this.plChangeDevice.Enabled = !this.ckbKhongChangeDevice.Checked;

  private void button1_Click(object sender, EventArgs e)
  {
    fChonBrandDevice fChonBrandDevice = new fChonBrandDevice(((IEnumerable<string>) this.txtBrandDevice.Text.Split('|')).ToList<string>());
    int num = (int) fChonBrandDevice.ShowDialog();
    if (fChonBrandDevice.list_0.Count == 0)
      this.txtBrandDevice.Text = "Random";
    else
      this.txtBrandDevice.Text = string.Join("|", (IEnumerable<string>) fChonBrandDevice.list_0);
  }

  private void txtBrandDevice_TextChanged(object sender, EventArgs e) => GClass19.smethod_6((Control) this.label9, this.txtBrandDevice.Text.Split('|').Length);

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCauHinhChung));
    this.bunifuCards1 = new BunifuCards();
    this.label5 = new Label();
    this.nudHideThread = new NumericUpDown();
    this.label6 = new Label();
    this.panel1 = new Panel();
    this.groupBox4 = new GroupBox();
    this.plChangeDevice = new Panel();
    this.button1 = new Button();
    this.txtBrandDevice = new TextBox();
    this.label9 = new Label();
    this.ckbKhongChangeDevice = new CheckBox();
    this.label37 = new Label();
    this.rbMinProxy = new RadioButton();
    this.cbbHostpot = new ComboBox();
    this.plCheckDoiIP = new Panel();
    this.button5 = new Button();
    this.label26 = new Label();
    this.nudChangeIpCount = new NumericUpDown();
    this.label27 = new Label();
    this.bunifuCards2 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button2 = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnCancel = new Button();
    this.panel2 = new Panel();
    this.label12 = new Label();
    this.textBox1 = new TextBox();
    this.btnSave = new Button();
    this.rbShopLike = new RadioButton();
    this.rbObcProxy = new RadioButton();
    this.plNordVPN = new Panel();
    this.label14 = new Label();
    this.txtNordVPN = new TextBox();
    this.rbProxyv6 = new RadioButton();
    this.groupBox1 = new GroupBox();
    this.panel4 = new Panel();
    this.rbPhanBietMauNen = new RadioButton();
    this.rbPhanBietMauChu = new RadioButton();
    this.label23 = new Label();
    this.linkLabel3 = new LinkLabel();
    this.groupBox2 = new GroupBox();
    this.nudDelayThread = new NumericUpDown();
    this.plDongBoMaxCare = new Panel();
    this.label15 = new Label();
    this.txtPathMaxCare = new TextBox();
    this.ckbDongBoMaxCare = new CheckBox();
    this.ckbTatADBKhiDungTool = new CheckBox();
    this.ckbLuuTrangThai = new CheckBox();
    this.btnSSH = new Button();
    this.rbTMProxy = new RadioButton();
    this.radioButton4 = new RadioButton();
    this.rbDcom = new RadioButton();
    this.rbTinsoft = new RadioButton();
    this.rbHotspot = new RadioButton();
    this.radioButton5 = new RadioButton();
    this.rbNordVPN = new RadioButton();
    this.radioButton2 = new RadioButton();
    this.rbSSH = new RadioButton();
    this.rbHma = new RadioButton();
    this.radioButton3 = new RadioButton();
    this.rbExpressVPN = new RadioButton();
    this.groupBox3 = new GroupBox();
    this.plTypeConnectProxy = new Panel();
    this.rbConnectProxyCollectProxy = new RadioButton();
    this.rbConnectProxyADB = new RadioButton();
    this.label10 = new Label();
    this.nudDelayCheckIP = new NumericUpDown();
    this.label38 = new Label();
    this.rb4G = new RadioButton();
    this.tabChangeIP = new TabControl();
    this.tabDcom = new TabPage();
    this.plDcom = new Panel();
    this.button4 = new Button();
    this.txtUrlHilink = new TextBox();
    this.txtProfileNameDcom = new TextBox();
    this.rbDcomHilink = new RadioButton();
    this.label19 = new Label();
    this.rbDcomThuong = new RadioButton();
    this.tabTinsoft = new TabPage();
    this.plTinsoft = new Panel();
    this.ckbWaitDoneAllTinsoft = new CheckBox();
    this.plApiProxy = new Panel();
    this.lblCountApiProxy = new Label();
    this.label28 = new Label();
    this.txtApiProxy = new TextBox();
    this.button7 = new Button();
    this.plApiUser = new Panel();
    this.label1 = new Label();
    this.txtApiUser = new TextBox();
    this.button3 = new Button();
    this.cbbLocationTinsoft = new ComboBox();
    this.rbApiProxy = new RadioButton();
    this.rbApiUser = new RadioButton();
    this.label7 = new Label();
    this.label8 = new Label();
    this.nudLuongPerIPTinsoft = new NumericUpDown();
    this.tabXProxy = new TabPage();
    this.plXproxy = new Panel();
    this.label3 = new Label();
    this.ckbShowProxy = new CheckBox();
    this.nudDelayConnectXproxy = new NumericUpDown();
    this.label4 = new Label();
    this.txtListProxy = new RichTextBox();
    this.label17 = new Label();
    this.label2 = new Label();
    this.label13 = new Label();
    this.txtServiceURLXProxy = new TextBox();
    this.tabObcProxy = new TabPage();
    this.plObcProxy = new Panel();
    this.label33 = new Label();
    this.rbObcResetDaiIP = new RadioButton();
    this.rbObcResetTungIP = new RadioButton();
    this.txtListObcProxy = new RichTextBox();
    this.label34 = new Label();
    this.label35 = new Label();
    this.label40 = new Label();
    this.nudLuongPerIPObcProxy = new NumericUpDown();
    this.label39 = new Label();
    this.label41 = new Label();
    this.nudDelayCheckIPObcProxy = new NumericUpDown();
    this.txtLinkWebObcProxy = new TextBox();
    this.tabProxyV6 = new TabPage();
    this.plProxyv6 = new Panel();
    this.txtListProxyv6 = new RichTextBox();
    this.label43 = new Label();
    this.label44 = new Label();
    this.nudLuongPerIPProxyv6 = new NumericUpDown();
    this.label45 = new Label();
    this.txtApiProxyv6 = new TextBox();
    this.tabProxyShopLike = new TabPage();
    this.plShopLike = new Panel();
    this.txtApiShopLike = new RichTextBox();
    this.label47 = new Label();
    this.label48 = new Label();
    this.nudLuongPerIPShopLike = new NumericUpDown();
    this.tabTMProxy = new TabPage();
    this.plTMProxy = new Panel();
    this.ckbWaitDoneAllTMProxy = new CheckBox();
    this.txtApiKeyTMProxy = new RichTextBox();
    this.label24 = new Label();
    this.button8 = new Button();
    this.label25 = new Label();
    this.nudLuongPerIPTMProxy = new NumericUpDown();
    this.tabNone = new TabPage();
    this.panel5 = new Panel();
    this.tabMinProxy = new TabPage();
    this.panel6 = new Panel();
    this.label42 = new Label();
    this.plTypeProxy = new Panel();
    this.rbHttpv6 = new RadioButton();
    this.rbHttpv4 = new RadioButton();
    this.label56 = new Label();
    this.rbProxyDanCu = new RadioButton();
    this.rbProxyDong = new RadioButton();
    this.button10 = new Button();
    this.txtApiKeyMinProxy = new RichTextBox();
    this.label49 = new Label();
    this.nudLuongPerIPMinProxy = new NumericUpDown();
    this.rbProxy = new RadioButton();
    this.rbNone = new RadioButton();
    this.ckbKhongCheckIP = new CheckBox();
    this.rbXproxy = new RadioButton();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.toolTip_0 = new ToolTip(this.components);
    this.label11 = new Label();
    this.label16 = new Label();
    this.nudHideThread.BeginInit();
    this.panel1.SuspendLayout();
    this.groupBox4.SuspendLayout();
    this.plChangeDevice.SuspendLayout();
    this.plCheckDoiIP.SuspendLayout();
    this.nudChangeIpCount.BeginInit();
    this.bunifuCards2.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.panel2.SuspendLayout();
    this.plNordVPN.SuspendLayout();
    this.groupBox1.SuspendLayout();
    this.panel4.SuspendLayout();
    this.groupBox2.SuspendLayout();
    this.nudDelayThread.BeginInit();
    this.plDongBoMaxCare.SuspendLayout();
    this.groupBox3.SuspendLayout();
    this.plTypeConnectProxy.SuspendLayout();
    this.nudDelayCheckIP.BeginInit();
    this.tabChangeIP.SuspendLayout();
    this.tabDcom.SuspendLayout();
    this.plDcom.SuspendLayout();
    this.tabTinsoft.SuspendLayout();
    this.plTinsoft.SuspendLayout();
    this.plApiProxy.SuspendLayout();
    this.plApiUser.SuspendLayout();
    this.nudLuongPerIPTinsoft.BeginInit();
    this.tabXProxy.SuspendLayout();
    this.plXproxy.SuspendLayout();
    this.nudDelayConnectXproxy.BeginInit();
    this.tabObcProxy.SuspendLayout();
    this.plObcProxy.SuspendLayout();
    this.nudLuongPerIPObcProxy.BeginInit();
    this.nudDelayCheckIPObcProxy.BeginInit();
    this.tabProxyV6.SuspendLayout();
    this.plProxyv6.SuspendLayout();
    this.nudLuongPerIPProxyv6.BeginInit();
    this.tabProxyShopLike.SuspendLayout();
    this.plShopLike.SuspendLayout();
    this.nudLuongPerIPShopLike.BeginInit();
    this.tabTMProxy.SuspendLayout();
    this.plTMProxy.SuspendLayout();
    this.nudLuongPerIPTMProxy.BeginInit();
    this.tabNone.SuspendLayout();
    this.tabMinProxy.SuspendLayout();
    this.panel6.SuspendLayout();
    this.plTypeProxy.SuspendLayout();
    this.nudLuongPerIPMinProxy.BeginInit();
    this.SuspendLayout();
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 5;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(14, 38);
    this.bunifuCards1.TabIndex = 12;
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label5.Location = new Point(245, 76);
    this.label5.Name = "label5";
    this.label5.Size = new Size(41, 16);
    this.label5.TabIndex = 28;
    this.label5.Text = "Luồng";
    this.nudHideThread.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.nudHideThread.Location = new Point(186, 73);
    this.nudHideThread.Maximum = new Decimal(new int[4]
    {
      1410065407,
      2,
      0,
      0
    });
    this.nudHideThread.Name = "nudHideThread";
    this.nudHideThread.Size = new Size(56, 23);
    this.nudHideThread.TabIndex = 27;
    this.nudHideThread.ValueChanged += new EventHandler(this.nudHideThread_ValueChanged);
    this.label6.AutoSize = true;
    this.label6.Cursor = Cursors.Help;
    this.label6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label6.Location = new Point(18, 76);
    this.label6.Name = "label6";
    this.label6.Size = new Size(152, 16);
    this.label6.TabIndex = 26;
    this.label6.Text = "Số luồng check thông tin:";
    this.toolTip_0.SetToolTip((Control) this.label6, "Là số luồng khi chạy các chức năng không liên quan gì đến trình duyệt.\r\nVí dụ như: Check wall, Check Avatar,...\r\n(Khuyến cáo nên để 10 luồng)");
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.groupBox4);
    this.panel1.Controls.Add((Control) this.label37);
    this.panel1.Controls.Add((Control) this.rbMinProxy);
    this.panel1.Controls.Add((Control) this.cbbHostpot);
    this.panel1.Controls.Add((Control) this.plCheckDoiIP);
    this.panel1.Controls.Add((Control) this.bunifuCards2);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.panel2);
    this.panel1.Controls.Add((Control) this.btnSave);
    this.panel1.Controls.Add((Control) this.rbShopLike);
    this.panel1.Controls.Add((Control) this.rbObcProxy);
    this.panel1.Controls.Add((Control) this.plNordVPN);
    this.panel1.Controls.Add((Control) this.rbProxyv6);
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.linkLabel3);
    this.panel1.Controls.Add((Control) this.groupBox2);
    this.panel1.Controls.Add((Control) this.btnSSH);
    this.panel1.Controls.Add((Control) this.rbTMProxy);
    this.panel1.Controls.Add((Control) this.radioButton4);
    this.panel1.Controls.Add((Control) this.rbDcom);
    this.panel1.Controls.Add((Control) this.rbTinsoft);
    this.panel1.Controls.Add((Control) this.rbHotspot);
    this.panel1.Controls.Add((Control) this.radioButton5);
    this.panel1.Controls.Add((Control) this.rbNordVPN);
    this.panel1.Controls.Add((Control) this.radioButton2);
    this.panel1.Controls.Add((Control) this.rbSSH);
    this.panel1.Controls.Add((Control) this.rbHma);
    this.panel1.Controls.Add((Control) this.radioButton3);
    this.panel1.Controls.Add((Control) this.rbExpressVPN);
    this.panel1.Controls.Add((Control) this.groupBox3);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(551, 654);
    this.panel1.TabIndex = 37;
    this.groupBox4.Controls.Add((Control) this.plChangeDevice);
    this.groupBox4.Controls.Add((Control) this.ckbKhongChangeDevice);
    this.groupBox4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.groupBox4.Location = new Point(7, 176);
    this.groupBox4.Name = "groupBox4";
    this.groupBox4.Size = new Size(536, 77);
    this.groupBox4.TabIndex = 162;
    this.groupBox4.TabStop = false;
    this.groupBox4.Text = "Cấu hình change device";
    this.plChangeDevice.Controls.Add((Control) this.button1);
    this.plChangeDevice.Controls.Add((Control) this.txtBrandDevice);
    this.plChangeDevice.Controls.Add((Control) this.label9);
    this.plChangeDevice.Location = new Point(17, 22);
    this.plChangeDevice.Name = "plChangeDevice";
    this.plChangeDevice.Size = new Size(495, 28);
    this.plChangeDevice.TabIndex = 116;
    this.button1.Cursor = Cursors.Hand;
    this.button1.Location = new Point(423, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(69, 25);
    this.button1.TabIndex = 115;
    this.button1.Text = "Chọn";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.txtBrandDevice.Location = new Point(153, 2);
    this.txtBrandDevice.Name = "txtBrandDevice";
    this.txtBrandDevice.ReadOnly = true;
    this.txtBrandDevice.Size = new Size(264, 23);
    this.txtBrandDevice.TabIndex = 114;
    this.txtBrandDevice.TextChanged += new EventHandler(this.txtBrandDevice_TextChanged);
    this.label9.AutoSize = true;
    this.label9.Location = new Point(1, 5);
    this.label9.Name = "label9";
    this.label9.Size = new Size(139, 16);
    this.label9.TabIndex = 113;
    this.label9.Text = "Chọn brand device (0):";
    this.ckbKhongChangeDevice.AutoSize = true;
    this.ckbKhongChangeDevice.Cursor = Cursors.Hand;
    this.ckbKhongChangeDevice.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbKhongChangeDevice.Location = new Point(21, 52);
    this.ckbKhongChangeDevice.Name = "ckbKhongChangeDevice";
    this.ckbKhongChangeDevice.Size = new Size(149, 20);
    this.ckbKhongChangeDevice.TabIndex = 112;
    this.ckbKhongChangeDevice.Text = "Không Change Device";
    this.ckbKhongChangeDevice.UseVisualStyleBackColor = true;
    this.ckbKhongChangeDevice.CheckedChanged += new EventHandler(this.ckbShowProxy_CheckedChanged);
    this.label37.AutoSize = true;
    this.label37.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label37.Location = new Point(552, 257);
    this.label37.Name = "label37";
    this.label37.Size = new Size(123, 16);
    this.label37.TabIndex = 158;
    this.label37.Text = "Delay sau khi đổi IP:";
    this.rbMinProxy.AutoSize = true;
    this.rbMinProxy.Cursor = Cursors.Hand;
    this.rbMinProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbMinProxy.Location = new Point(549, 344);
    this.rbMinProxy.Margin = new Padding(3, 4, 3, 4);
    this.rbMinProxy.Name = "rbMinProxy";
    this.rbMinProxy.Size = new Size(142, 20);
    this.rbMinProxy.TabIndex = 161;
    this.rbMinProxy.Text = "https://minproxy.vn/";
    this.rbMinProxy.UseVisualStyleBackColor = true;
    this.rbMinProxy.CheckedChanged += new EventHandler(this.rbMinProxy_CheckedChanged);
    this.cbbHostpot.Cursor = Cursors.Hand;
    this.cbbHostpot.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbHostpot.Enabled = false;
    this.cbbHostpot.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.cbbHostpot.ForeColor = Color.Black;
    this.cbbHostpot.FormattingEnabled = true;
    this.cbbHostpot.Items.AddRange(new object[2]
    {
      (object) "Chỉ trong quốc gia đang chọn",
      (object) "Toàn bộ quốc gia"
    });
    this.cbbHostpot.Location = new Point(1177, 563);
    this.cbbHostpot.Name = "cbbHostpot";
    this.cbbHostpot.Size = new Size(229, 24);
    this.cbbHostpot.TabIndex = 144;
    this.plCheckDoiIP.Controls.Add((Control) this.button5);
    this.plCheckDoiIP.Controls.Add((Control) this.label26);
    this.plCheckDoiIP.Controls.Add((Control) this.nudChangeIpCount);
    this.plCheckDoiIP.Controls.Add((Control) this.label27);
    this.plCheckDoiIP.Location = new Point(549, 222);
    this.plCheckDoiIP.Name = "plCheckDoiIP";
    this.plCheckDoiIP.Size = new Size(302, 27);
    this.plCheckDoiIP.TabIndex = 146;
    this.button5.Cursor = Cursors.Hand;
    this.button5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.button5.ForeColor = Color.Black;
    this.button5.Location = new Point(220, 0);
    this.button5.Name = "button5";
    this.button5.Size = new Size(77, 27);
    this.button5.TabIndex = 143;
    this.button5.Text = "Test";
    this.button5.UseVisualStyleBackColor = true;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.label26.AutoSize = true;
    this.label26.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label26.Location = new Point(3, 5);
    this.label26.Name = "label26";
    this.label26.Size = new Size(100, 16);
    this.label26.TabIndex = 139;
    this.label26.Text = "Thay đổi IP sau:";
    this.nudChangeIpCount.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudChangeIpCount.Location = new Point(133, 3);
    this.nudChangeIpCount.Name = "nudChangeIpCount";
    this.nudChangeIpCount.Size = new Size(46, 23);
    this.nudChangeIpCount.TabIndex = 140;
    this.nudChangeIpCount.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.label27.AutoSize = true;
    this.label27.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label27.Location = new Point(181, 5);
    this.label27.Name = "label27";
    this.label27.Size = new Size(29, 16);
    this.label27.TabIndex = 141;
    this.label27.Text = "lượt";
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
    this.bunifuCards2.Size = new Size(549, 37);
    this.bunifuCards2.TabIndex = 40;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button2);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(549, 31);
    this.pnlHeader.TabIndex = 9;
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Image = (Image) componentResourceManager.GetObject("button2.Image");
    this.button2.Location = new Point(518, 1);
    this.button2.Name = "button2";
    this.button2.Size = new Size(30, 30);
    this.button2.TabIndex = 77;
    this.button2.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.btnCancel_Click);
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(549, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Cấu hình chung";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(279, 612);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(92, 29);
    this.btnCancel.TabIndex = 20;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.panel2.BorderStyle = BorderStyle.FixedSingle;
    this.panel2.Controls.Add((Control) this.label12);
    this.panel2.Controls.Add((Control) this.textBox1);
    this.panel2.Enabled = false;
    this.panel2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.panel2.Location = new Point(1176, 475);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(232, 30);
    this.panel2.TabIndex = 142;
    this.label12.AutoSize = true;
    this.label12.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label12.Location = new Point(3, 5);
    this.label12.Name = "label12";
    this.label12.Size = new Size(75, 16);
    this.label12.TabIndex = 82;
    this.label12.Text = "Đường dẫn:";
    this.textBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.textBox1.ForeColor = Color.Black;
    this.textBox1.Location = new Point(87, 2);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new Size(142, 23);
    this.textBox1.TabIndex = 83;
    this.btnSave.Anchor = AnchorStyles.Bottom;
    this.btnSave.BackColor = Color.FromArgb(53, 120, 229);
    this.btnSave.Cursor = Cursors.Hand;
    this.btnSave.FlatAppearance.BorderSize = 0;
    this.btnSave.FlatStyle = FlatStyle.Flat;
    this.btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnSave.ForeColor = Color.White;
    this.btnSave.Location = new Point(179, 612);
    this.btnSave.Name = "btnSave";
    this.btnSave.Size = new Size(92, 29);
    this.btnSave.TabIndex = 19;
    this.btnSave.Text = "Lưu";
    this.btnSave.UseVisualStyleBackColor = false;
    this.btnSave.Click += new EventHandler(this.btnSave_Click);
    this.rbShopLike.AutoSize = true;
    this.rbShopLike.Cursor = Cursors.Hand;
    this.rbShopLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbShopLike.Location = new Point(840, 344);
    this.rbShopLike.Margin = new Padding(3, 4, 3, 4);
    this.rbShopLike.Name = "rbShopLike";
    this.rbShopLike.Size = new Size(165, 20);
    this.rbShopLike.TabIndex = 156;
    this.rbShopLike.Text = "http://proxy.shoplike.vn/";
    this.rbShopLike.UseVisualStyleBackColor = true;
    this.rbShopLike.CheckedChanged += new EventHandler(this.rbShopLike_CheckedChanged);
    this.rbObcProxy.AutoSize = true;
    this.rbObcProxy.Cursor = Cursors.Hand;
    this.rbObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbObcProxy.Location = new Point(840, 297);
    this.rbObcProxy.Margin = new Padding(3, 4, 3, 4);
    this.rbObcProxy.Name = "rbObcProxy";
    this.rbObcProxy.Size = new Size(84, 20);
    this.rbObcProxy.TabIndex = 138;
    this.rbObcProxy.Text = "OBC Proxy";
    this.rbObcProxy.UseVisualStyleBackColor = true;
    this.rbObcProxy.CheckedChanged += new EventHandler(this.rbObcProxy_CheckedChanged);
    this.plNordVPN.BorderStyle = BorderStyle.FixedSingle;
    this.plNordVPN.Controls.Add((Control) this.label14);
    this.plNordVPN.Controls.Add((Control) this.txtNordVPN);
    this.plNordVPN.Enabled = false;
    this.plNordVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plNordVPN.Location = new Point(1176, 475);
    this.plNordVPN.Name = "plNordVPN";
    this.plNordVPN.Size = new Size(232, 30);
    this.plNordVPN.TabIndex = 142;
    this.label14.AutoSize = true;
    this.label14.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label14.Location = new Point(3, 5);
    this.label14.Name = "label14";
    this.label14.Size = new Size(75, 16);
    this.label14.TabIndex = 82;
    this.label14.Text = "Đường dẫn:";
    this.txtNordVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.txtNordVPN.ForeColor = Color.Black;
    this.txtNordVPN.Location = new Point(87, 2);
    this.txtNordVPN.Name = "txtNordVPN";
    this.txtNordVPN.Size = new Size(142, 23);
    this.txtNordVPN.TabIndex = 83;
    this.rbProxyv6.AutoSize = true;
    this.rbProxyv6.Cursor = Cursors.Hand;
    this.rbProxyv6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbProxyv6.Location = new Point(840, 321);
    this.rbProxyv6.Margin = new Padding(3, 4, 3, 4);
    this.rbProxyv6.Name = "rbProxyv6";
    this.rbProxyv6.Size = new Size(139, 20);
    this.rbProxyv6.TabIndex = 154;
    this.rbProxyv6.Text = "https://proxyv6.net/";
    this.rbProxyv6.UseVisualStyleBackColor = true;
    this.rbProxyv6.CheckedChanged += new EventHandler(this.rbProxyv6_CheckedChanged);
    this.groupBox1.Controls.Add((Control) this.panel4);
    this.groupBox1.Controls.Add((Control) this.label23);
    this.groupBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.groupBox1.Location = new Point(1111, 493);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(568, 49);
    this.groupBox1.TabIndex = 38;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Cấu hình khác";
    this.panel4.Controls.Add((Control) this.rbPhanBietMauNen);
    this.panel4.Controls.Add((Control) this.rbPhanBietMauChu);
    this.panel4.Location = new Point(239, 17);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(309, 25);
    this.panel4.TabIndex = 156;
    this.rbPhanBietMauNen.AutoSize = true;
    this.rbPhanBietMauNen.Checked = true;
    this.rbPhanBietMauNen.Cursor = Cursors.Hand;
    this.rbPhanBietMauNen.Location = new Point(3, 3);
    this.rbPhanBietMauNen.Name = "rbPhanBietMauNen";
    this.rbPhanBietMauNen.Size = new Size(130, 20);
    this.rbPhanBietMauNen.TabIndex = 34;
    this.rbPhanBietMauNen.TabStop = true;
    this.rbPhanBietMauNen.Text = "Đổi màu nền dòng";
    this.rbPhanBietMauNen.UseVisualStyleBackColor = true;
    this.rbPhanBietMauChu.AutoSize = true;
    this.rbPhanBietMauChu.Cursor = Cursors.Hand;
    this.rbPhanBietMauChu.Location = new Point(190, 3);
    this.rbPhanBietMauChu.Name = "rbPhanBietMauChu";
    this.rbPhanBietMauChu.Size = new Size(98, 20);
    this.rbPhanBietMauChu.TabIndex = 34;
    this.rbPhanBietMauChu.Text = "Đổi màu chữ";
    this.rbPhanBietMauChu.UseVisualStyleBackColor = true;
    this.label23.AutoSize = true;
    this.label23.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label23.Location = new Point(18, 20);
    this.label23.Name = "label23";
    this.label23.Size = new Size(223, 16);
    this.label23.TabIndex = 33;
    this.label23.Text = "Phân biệt màu [Tình trạng tài khoản]:";
    this.linkLabel3.AutoSize = true;
    this.linkLabel3.Cursor = Cursors.Hand;
    this.linkLabel3.Location = new Point(727, 369);
    this.linkLabel3.Name = "linkLabel3";
    this.linkLabel3.Size = new Size(72, 13);
    this.linkLabel3.TabIndex = 147;
    this.linkLabel3.TabStop = true;
    this.linkLabel3.Text = "Hướng dẫn(?)";
    this.linkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
    this.groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox2.Controls.Add((Control) this.label16);
    this.groupBox2.Controls.Add((Control) this.label11);
    this.groupBox2.Controls.Add((Control) this.nudDelayThread);
    this.groupBox2.Controls.Add((Control) this.plDongBoMaxCare);
    this.groupBox2.Controls.Add((Control) this.ckbDongBoMaxCare);
    this.groupBox2.Controls.Add((Control) this.ckbTatADBKhiDungTool);
    this.groupBox2.Controls.Add((Control) this.ckbLuuTrangThai);
    this.groupBox2.Controls.Add((Control) this.label5);
    this.groupBox2.Controls.Add((Control) this.nudHideThread);
    this.groupBox2.Controls.Add((Control) this.label6);
    this.groupBox2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.groupBox2.Location = new Point(7, 39);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(536, 130);
    this.groupBox2.TabIndex = 38;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Cấu hình chung";
    this.nudDelayThread.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.nudDelayThread.Location = new Point(429, 73);
    this.nudDelayThread.Maximum = new Decimal(new int[4]
    {
      1410065407,
      2,
      0,
      0
    });
    this.nudDelayThread.Name = "nudDelayThread";
    this.nudDelayThread.Size = new Size(56, 23);
    this.nudDelayThread.TabIndex = 165;
    this.nudDelayThread.Value = new Decimal(new int[4]
    {
      1000,
      0,
      0,
      0
    });
    this.plDongBoMaxCare.Controls.Add((Control) this.label15);
    this.plDongBoMaxCare.Controls.Add((Control) this.txtPathMaxCare);
    this.plDongBoMaxCare.Location = new Point(34, 40);
    this.plDongBoMaxCare.Name = "plDongBoMaxCare";
    this.plDongBoMaxCare.Size = new Size(478, 29);
    this.plDongBoMaxCare.TabIndex = 164;
    this.label15.AutoSize = true;
    this.label15.Location = new Point(3, 6);
    this.label15.Name = "label15";
    this.label15.Size = new Size(129, 16);
    this.label15.TabIndex = 158;
    this.label15.Text = "Đường dẫn MaxCare:";
    this.txtPathMaxCare.Location = new Point(152, 3);
    this.txtPathMaxCare.Name = "txtPathMaxCare";
    this.txtPathMaxCare.Size = new Size(323, 23);
    this.txtPathMaxCare.TabIndex = 159;
    this.ckbDongBoMaxCare.AutoSize = true;
    this.ckbDongBoMaxCare.Cursor = Cursors.Hand;
    this.ckbDongBoMaxCare.Location = new Point(21, 22);
    this.ckbDongBoMaxCare.Name = "ckbDongBoMaxCare";
    this.ckbDongBoMaxCare.Size = new Size(191, 20);
    this.ckbDongBoMaxCare.TabIndex = 29;
    this.ckbDongBoMaxCare.Text = "Đồng bộ dữ liệu với MaxCare";
    this.ckbDongBoMaxCare.UseVisualStyleBackColor = true;
    this.ckbDongBoMaxCare.CheckedChanged += new EventHandler(this.ckbDongBoMaxCare_CheckedChanged);
    this.ckbTatADBKhiDungTool.AutoSize = true;
    this.ckbTatADBKhiDungTool.Cursor = Cursors.Hand;
    this.ckbTatADBKhiDungTool.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbTatADBKhiDungTool.Location = new Point(366, 103);
    this.ckbTatADBKhiDungTool.Name = "ckbTatADBKhiDungTool";
    this.ckbTatADBKhiDungTool.Size = new Size(150, 20);
    this.ckbTatADBKhiDungTool.TabIndex = 112;
    this.ckbTatADBKhiDungTool.Text = "Kill ADB khi chạy xong";
    this.ckbTatADBKhiDungTool.UseVisualStyleBackColor = true;
    this.ckbLuuTrangThai.AutoSize = true;
    this.ckbLuuTrangThai.Cursor = Cursors.Hand;
    this.ckbLuuTrangThai.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbLuuTrangThai.Location = new Point(21, 103);
    this.ckbLuuTrangThai.Name = "ckbLuuTrangThai";
    this.ckbLuuTrangThai.Size = new Size(184, 20);
    this.ckbLuuTrangThai.TabIndex = 112;
    this.ckbLuuTrangThai.Text = "Lưu dữ liệu cột [Trạng thái]";
    this.ckbLuuTrangThai.UseVisualStyleBackColor = true;
    this.btnSSH.Cursor = Cursors.Hand;
    this.btnSSH.Enabled = false;
    this.btnSSH.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.btnSSH.ForeColor = Color.Black;
    this.btnSSH.Location = new Point(1263, 508);
    this.btnSSH.Margin = new Padding(3, 4, 3, 4);
    this.btnSSH.Name = "btnSSH";
    this.btnSSH.Size = new Size(106, 26);
    this.btnSSH.TabIndex = 130;
    this.btnSSH.Text = "Nhập IP SSH";
    this.btnSSH.UseVisualStyleBackColor = true;
    this.btnSSH.Click += new EventHandler(this.btnSSH_Click);
    this.rbTMProxy.AutoSize = true;
    this.rbTMProxy.Cursor = Cursors.Hand;
    this.rbTMProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbTMProxy.Location = new Point(840, 367);
    this.rbTMProxy.Margin = new Padding(3, 4, 3, 4);
    this.rbTMProxy.Name = "rbTMProxy";
    this.rbTMProxy.Size = new Size(147, 20);
    this.rbTMProxy.TabIndex = 145;
    this.rbTMProxy.Text = "https://tmproxy.com/";
    this.rbTMProxy.UseVisualStyleBackColor = true;
    this.rbTMProxy.CheckedChanged += new EventHandler(this.rbTMProxy_CheckedChanged);
    this.radioButton4.AutoSize = true;
    this.radioButton4.Cursor = Cursors.Hand;
    this.radioButton4.Enabled = false;
    this.radioButton4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.radioButton4.Location = new Point(1162, 426);
    this.radioButton4.Margin = new Padding(3, 4, 3, 4);
    this.radioButton4.Name = "radioButton4";
    this.radioButton4.Size = new Size(130, 20);
    this.radioButton4.TabIndex = 133;
    this.radioButton4.Text = "Đổi IP ExpressVPN";
    this.radioButton4.UseVisualStyleBackColor = true;
    this.rbDcom.AutoSize = true;
    this.rbDcom.Cursor = Cursors.Hand;
    this.rbDcom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbDcom.Location = new Point(549, 321);
    this.rbDcom.Margin = new Padding(3, 4, 3, 4);
    this.rbDcom.Name = "rbDcom";
    this.rbDcom.Size = new Size(95, 20);
    this.rbDcom.TabIndex = 137;
    this.rbDcom.Text = "Đổi IP Dcom";
    this.rbDcom.UseVisualStyleBackColor = true;
    this.rbDcom.CheckedChanged += new EventHandler(this.rbDcom_CheckedChanged);
    this.rbTinsoft.AutoSize = true;
    this.rbTinsoft.Cursor = Cursors.Hand;
    this.rbTinsoft.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbTinsoft.Location = new Point(549, 367);
    this.rbTinsoft.Margin = new Padding(3, 4, 3, 4);
    this.rbTinsoft.Name = "rbTinsoft";
    this.rbTinsoft.Size = new Size(167, 20);
    this.rbTinsoft.TabIndex = 134;
    this.rbTinsoft.Text = "https://tinsoftproxy.com/";
    this.rbTinsoft.UseVisualStyleBackColor = true;
    this.rbTinsoft.CheckedChanged += new EventHandler(this.rbTinsoft_CheckedChanged);
    this.rbHotspot.AutoSize = true;
    this.rbHotspot.Enabled = false;
    this.rbHotspot.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbHotspot.Location = new Point(1162, 539);
    this.rbHotspot.Margin = new Padding(3, 4, 3, 4);
    this.rbHotspot.Name = "rbHotspot";
    this.rbHotspot.Size = new Size(145, 20);
    this.rbHotspot.TabIndex = 135;
    this.rbHotspot.Text = "Đổi IP Hotspot Shield";
    this.rbHotspot.UseVisualStyleBackColor = true;
    this.radioButton5.AutoSize = true;
    this.radioButton5.Cursor = Cursors.Hand;
    this.radioButton5.Enabled = false;
    this.radioButton5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.radioButton5.Location = new Point(1162, 511);
    this.radioButton5.Margin = new Padding(3, 4, 3, 4);
    this.radioButton5.Name = "radioButton5";
    this.radioButton5.Size = new Size(87, 20);
    this.radioButton5.TabIndex = 132;
    this.radioButton5.Text = "Đổi IP SSH";
    this.radioButton5.UseVisualStyleBackColor = true;
    this.rbNordVPN.AutoSize = true;
    this.rbNordVPN.Enabled = false;
    this.rbNordVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbNordVPN.Location = new Point(1162, 451);
    this.rbNordVPN.Margin = new Padding(3, 4, 3, 4);
    this.rbNordVPN.Name = "rbNordVPN";
    this.rbNordVPN.Size = new Size(113, 20);
    this.rbNordVPN.TabIndex = 134;
    this.rbNordVPN.Text = "Đổi IP NordVPN";
    this.rbNordVPN.UseVisualStyleBackColor = true;
    this.rbNordVPN.CheckedChanged += new EventHandler(this.radioButton3_CheckedChanged);
    this.radioButton2.AutoSize = true;
    this.radioButton2.Cursor = Cursors.Hand;
    this.radioButton2.Enabled = false;
    this.radioButton2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.radioButton2.Location = new Point(1162, 539);
    this.radioButton2.Margin = new Padding(3, 4, 3, 4);
    this.radioButton2.Name = "radioButton2";
    this.radioButton2.Size = new Size(145, 20);
    this.radioButton2.TabIndex = 135;
    this.radioButton2.Text = "Đổi IP Hotspot Shield";
    this.radioButton2.UseVisualStyleBackColor = true;
    this.rbSSH.AutoSize = true;
    this.rbSSH.Enabled = false;
    this.rbSSH.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbSSH.Location = new Point(1162, 511);
    this.rbSSH.Margin = new Padding(3, 4, 3, 4);
    this.rbSSH.Name = "rbSSH";
    this.rbSSH.Size = new Size(87, 20);
    this.rbSSH.TabIndex = 132;
    this.rbSSH.Text = "Đổi IP SSH";
    this.rbSSH.UseVisualStyleBackColor = true;
    this.rbHma.AutoSize = true;
    this.rbHma.Cursor = Cursors.Hand;
    this.rbHma.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbHma.Location = new Point(676, 321);
    this.rbHma.Margin = new Padding(3, 4, 3, 4);
    this.rbHma.Name = "rbHma";
    this.rbHma.Size = new Size(89, 20);
    this.rbHma.TabIndex = 138;
    this.rbHma.Text = "Đổi IP HMA";
    this.rbHma.UseVisualStyleBackColor = true;
    this.rbHma.CheckedChanged += new EventHandler(this.rbHma_CheckedChanged);
    this.radioButton3.AutoSize = true;
    this.radioButton3.Cursor = Cursors.Hand;
    this.radioButton3.Enabled = false;
    this.radioButton3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.radioButton3.Location = new Point(1162, 451);
    this.radioButton3.Margin = new Padding(3, 4, 3, 4);
    this.radioButton3.Name = "radioButton3";
    this.radioButton3.Size = new Size(113, 20);
    this.radioButton3.TabIndex = 134;
    this.radioButton3.Text = "Đổi IP NordVPN";
    this.radioButton3.UseVisualStyleBackColor = true;
    this.radioButton3.CheckedChanged += new EventHandler(this.radioButton3_CheckedChanged);
    this.rbExpressVPN.AutoSize = true;
    this.rbExpressVPN.Enabled = false;
    this.rbExpressVPN.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbExpressVPN.Location = new Point(1162, 426);
    this.rbExpressVPN.Margin = new Padding(3, 4, 3, 4);
    this.rbExpressVPN.Name = "rbExpressVPN";
    this.rbExpressVPN.Size = new Size(130, 20);
    this.rbExpressVPN.TabIndex = 133;
    this.rbExpressVPN.Text = "Đổi IP ExpressVPN";
    this.rbExpressVPN.UseVisualStyleBackColor = true;
    this.groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox3.Controls.Add((Control) this.plTypeConnectProxy);
    this.groupBox3.Controls.Add((Control) this.nudDelayCheckIP);
    this.groupBox3.Controls.Add((Control) this.label38);
    this.groupBox3.Controls.Add((Control) this.rb4G);
    this.groupBox3.Controls.Add((Control) this.tabChangeIP);
    this.groupBox3.Controls.Add((Control) this.rbProxy);
    this.groupBox3.Controls.Add((Control) this.rbNone);
    this.groupBox3.Controls.Add((Control) this.ckbKhongCheckIP);
    this.groupBox3.Controls.Add((Control) this.rbXproxy);
    this.groupBox3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.groupBox3.Location = new Point(7, 259);
    this.groupBox3.Name = "groupBox3";
    this.groupBox3.Size = new Size(536, 347);
    this.groupBox3.TabIndex = 39;
    this.groupBox3.TabStop = false;
    this.groupBox3.Text = "Cấu hình đổi IP";
    this.plTypeConnectProxy.BorderStyle = BorderStyle.FixedSingle;
    this.plTypeConnectProxy.Controls.Add((Control) this.rbConnectProxyCollectProxy);
    this.plTypeConnectProxy.Controls.Add((Control) this.rbConnectProxyADB);
    this.plTypeConnectProxy.Controls.Add((Control) this.label10);
    this.plTypeConnectProxy.Location = new Point(319, 50);
    this.plTypeConnectProxy.Name = "plTypeConnectProxy";
    this.plTypeConnectProxy.Size = new Size(193, 49);
    this.plTypeConnectProxy.TabIndex = 161;
    this.plTypeConnectProxy.Visible = false;
    this.rbConnectProxyCollectProxy.AutoSize = true;
    this.rbConnectProxyCollectProxy.Cursor = Cursors.Hand;
    this.rbConnectProxyCollectProxy.Location = new Point(96, 26);
    this.rbConnectProxyCollectProxy.Name = "rbConnectProxyCollectProxy";
    this.rbConnectProxyCollectProxy.Size = new Size(98, 20);
    this.rbConnectProxyCollectProxy.TabIndex = 0;
    this.rbConnectProxyCollectProxy.TabStop = true;
    this.rbConnectProxyCollectProxy.Text = "Collect Proxy";
    this.rbConnectProxyCollectProxy.UseVisualStyleBackColor = true;
    this.rbConnectProxyADB.AutoSize = true;
    this.rbConnectProxyADB.Cursor = Cursors.Hand;
    this.rbConnectProxyADB.Location = new Point(96, 4);
    this.rbConnectProxyADB.Name = "rbConnectProxyADB";
    this.rbConnectProxyADB.Size = new Size(48, 20);
    this.rbConnectProxyADB.TabIndex = 0;
    this.rbConnectProxyADB.TabStop = true;
    this.rbConnectProxyADB.Text = "ADB";
    this.rbConnectProxyADB.UseVisualStyleBackColor = true;
    this.label10.AutoSize = true;
    this.label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label10.Location = new Point(1, 6);
    this.label10.Name = "label10";
    this.label10.Size = new Size(93, 16);
    this.label10.TabIndex = 28;
    this.label10.Text = "Connect Proxy:";
    this.nudDelayCheckIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudDelayCheckIP.Location = new Point(674, 80);
    this.nudDelayCheckIP.Maximum = new Decimal(new int[4]
    {
      99999999,
      0,
      0,
      0
    });
    this.nudDelayCheckIP.Name = "nudDelayCheckIP";
    this.nudDelayCheckIP.Size = new Size(46, 23);
    this.nudDelayCheckIP.TabIndex = 159;
    this.label38.AutoSize = true;
    this.label38.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label38.Location = new Point(722, 84);
    this.label38.Name = "label38";
    this.label38.Size = new Size(30, 16);
    this.label38.TabIndex = 160;
    this.label38.Text = "giây";
    this.rb4G.AutoSize = true;
    this.rb4G.Cursor = Cursors.Hand;
    this.rb4G.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rb4G.Location = new Point(21, 51);
    this.rb4G.Margin = new Padding(3, 4, 3, 4);
    this.rb4G.Name = "rb4G";
    this.rb4G.Size = new Size(81, 20);
    this.rb4G.TabIndex = 136;
    this.rb4G.Text = "4G Mobile";
    this.rb4G.UseVisualStyleBackColor = true;
    this.rb4G.CheckedChanged += new EventHandler(this.rb4G_CheckedChanged);
    this.tabChangeIP.Alignment = TabAlignment.Bottom;
    this.tabChangeIP.Controls.Add((Control) this.tabDcom);
    this.tabChangeIP.Controls.Add((Control) this.tabTinsoft);
    this.tabChangeIP.Controls.Add((Control) this.tabXProxy);
    this.tabChangeIP.Controls.Add((Control) this.tabObcProxy);
    this.tabChangeIP.Controls.Add((Control) this.tabProxyV6);
    this.tabChangeIP.Controls.Add((Control) this.tabProxyShopLike);
    this.tabChangeIP.Controls.Add((Control) this.tabTMProxy);
    this.tabChangeIP.Controls.Add((Control) this.tabNone);
    this.tabChangeIP.Controls.Add((Control) this.tabMinProxy);
    this.tabChangeIP.Cursor = Cursors.Hand;
    this.tabChangeIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.tabChangeIP.Location = new Point(21, 133);
    this.tabChangeIP.Name = "tabChangeIP";
    this.tabChangeIP.SelectedIndex = 0;
    this.tabChangeIP.Size = new Size(495, 238);
    this.tabChangeIP.TabIndex = 145;
    this.tabDcom.Controls.Add((Control) this.plDcom);
    this.tabDcom.Location = new Point(4, 4);
    this.tabDcom.Name = "tabDcom";
    this.tabDcom.Padding = new Padding(3);
    this.tabDcom.Size = new Size(487, 209);
    this.tabDcom.TabIndex = 0;
    this.tabDcom.Text = "Dcom";
    this.tabDcom.UseVisualStyleBackColor = true;
    this.plDcom.BorderStyle = BorderStyle.FixedSingle;
    this.plDcom.Controls.Add((Control) this.button4);
    this.plDcom.Controls.Add((Control) this.txtUrlHilink);
    this.plDcom.Controls.Add((Control) this.txtProfileNameDcom);
    this.plDcom.Controls.Add((Control) this.rbDcomHilink);
    this.plDcom.Controls.Add((Control) this.label19);
    this.plDcom.Controls.Add((Control) this.rbDcomThuong);
    this.plDcom.Dock = DockStyle.Fill;
    this.plDcom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plDcom.Location = new Point(3, 3);
    this.plDcom.Name = "plDcom";
    this.plDcom.Size = new Size(481, 203);
    this.plDcom.TabIndex = 148;
    this.button4.Anchor = AnchorStyles.None;
    this.button4.Cursor = Cursors.Hand;
    this.button4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.button4.ForeColor = Color.Black;
    this.button4.Location = new Point(301, 61);
    this.button4.Name = "button4";
    this.button4.Size = new Size(93, 25);
    this.button4.TabIndex = 143;
    this.button4.Text = "Lấy tên Dcom";
    this.toolTip_0.SetToolTip((Control) this.button4, "Lấy tên dcom");
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.txtUrlHilink.Anchor = AnchorStyles.None;
    this.txtUrlHilink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.txtUrlHilink.ForeColor = Color.Black;
    this.txtUrlHilink.Location = new Point(175, 109);
    this.txtUrlHilink.Name = "txtUrlHilink";
    this.txtUrlHilink.Size = new Size(219, 23);
    this.txtUrlHilink.TabIndex = 81;
    this.txtProfileNameDcom.Anchor = AnchorStyles.None;
    this.txtProfileNameDcom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.txtProfileNameDcom.ForeColor = Color.Black;
    this.txtProfileNameDcom.Location = new Point(107, 62);
    this.txtProfileNameDcom.Name = "txtProfileNameDcom";
    this.txtProfileNameDcom.Size = new Size(189, 23);
    this.txtProfileNameDcom.TabIndex = 81;
    this.rbDcomHilink.Anchor = AnchorStyles.None;
    this.rbDcomHilink.AutoSize = true;
    this.rbDcomHilink.Cursor = Cursors.Hand;
    this.rbDcomHilink.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbDcomHilink.Location = new Point(88, 88);
    this.rbDcomHilink.Margin = new Padding(3, 4, 3, 4);
    this.rbDcomHilink.Name = "rbDcomHilink";
    this.rbDcomHilink.Size = new Size(55, 20);
    this.rbDcomHilink.TabIndex = 136;
    this.rbDcomHilink.Text = "Hilink";
    this.rbDcomHilink.UseVisualStyleBackColor = true;
    this.rbDcomHilink.CheckedChanged += new EventHandler(this.rbDcomHilink_CheckedChanged);
    this.label19.Anchor = AnchorStyles.None;
    this.label19.AutoSize = true;
    this.label19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label19.Location = new Point(104, 112);
    this.label19.Name = "label19";
    this.label19.Size = new Size(64, 16);
    this.label19.TabIndex = 79;
    this.label19.Text = "Link Web:";
    this.rbDcomThuong.Anchor = AnchorStyles.None;
    this.rbDcomThuong.AutoSize = true;
    this.rbDcomThuong.Cursor = Cursors.Hand;
    this.rbDcomThuong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbDcomThuong.Location = new Point(88, 41);
    this.rbDcomThuong.Margin = new Padding(3, 4, 3, 4);
    this.rbDcomThuong.Name = "rbDcomThuong";
    this.rbDcomThuong.Size = new Size(69, 20);
    this.rbDcomThuong.TabIndex = 136;
    this.rbDcomThuong.Text = "Thường";
    this.rbDcomThuong.UseVisualStyleBackColor = true;
    this.rbDcomThuong.CheckedChanged += new EventHandler(this.rbDcomThuong_CheckedChanged);
    this.tabTinsoft.Controls.Add((Control) this.plTinsoft);
    this.tabTinsoft.Location = new Point(4, 4);
    this.tabTinsoft.Name = "tabTinsoft";
    this.tabTinsoft.Padding = new Padding(3);
    this.tabTinsoft.Size = new Size(487, 209);
    this.tabTinsoft.TabIndex = 1;
    this.tabTinsoft.Text = "https://tinsoftproxy.com/";
    this.tabTinsoft.UseVisualStyleBackColor = true;
    this.plTinsoft.BorderStyle = BorderStyle.FixedSingle;
    this.plTinsoft.Controls.Add((Control) this.ckbWaitDoneAllTinsoft);
    this.plTinsoft.Controls.Add((Control) this.plApiProxy);
    this.plTinsoft.Controls.Add((Control) this.plApiUser);
    this.plTinsoft.Controls.Add((Control) this.cbbLocationTinsoft);
    this.plTinsoft.Controls.Add((Control) this.rbApiProxy);
    this.plTinsoft.Controls.Add((Control) this.rbApiUser);
    this.plTinsoft.Controls.Add((Control) this.label7);
    this.plTinsoft.Controls.Add((Control) this.label8);
    this.plTinsoft.Controls.Add((Control) this.nudLuongPerIPTinsoft);
    this.plTinsoft.Dock = DockStyle.Fill;
    this.plTinsoft.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plTinsoft.Location = new Point(3, 3);
    this.plTinsoft.Name = "plTinsoft";
    this.plTinsoft.Size = new Size(481, 203);
    this.plTinsoft.TabIndex = 142;
    this.plTinsoft.Click += new EventHandler(this.plTinsoft_Click);
    this.ckbWaitDoneAllTinsoft.Anchor = AnchorStyles.None;
    this.ckbWaitDoneAllTinsoft.AutoSize = true;
    this.ckbWaitDoneAllTinsoft.Cursor = Cursors.Hand;
    this.ckbWaitDoneAllTinsoft.Location = new Point(221, 48);
    this.ckbWaitDoneAllTinsoft.Name = "ckbWaitDoneAllTinsoft";
    this.ckbWaitDoneAllTinsoft.Size = new Size(128, 20);
    this.ckbWaitDoneAllTinsoft.TabIndex = 145;
    this.ckbWaitDoneAllTinsoft.Text = "Đợi chạy xong hết";
    this.ckbWaitDoneAllTinsoft.UseVisualStyleBackColor = true;
    this.ckbWaitDoneAllTinsoft.Visible = false;
    this.plApiProxy.Anchor = AnchorStyles.None;
    this.plApiProxy.BorderStyle = BorderStyle.FixedSingle;
    this.plApiProxy.Controls.Add((Control) this.lblCountApiProxy);
    this.plApiProxy.Controls.Add((Control) this.label28);
    this.plApiProxy.Controls.Add((Control) this.txtApiProxy);
    this.plApiProxy.Controls.Add((Control) this.button7);
    this.plApiProxy.Location = new Point(95, 122);
    this.plApiProxy.Name = "plApiProxy";
    this.plApiProxy.Size = new Size(292, 58);
    this.plApiProxy.TabIndex = 35;
    this.lblCountApiProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.lblCountApiProxy.Location = new Point(1, 24);
    this.lblCountApiProxy.Name = "lblCountApiProxy";
    this.lblCountApiProxy.Size = new Size(32, 16);
    this.lblCountApiProxy.TabIndex = 82;
    this.lblCountApiProxy.Text = "(0)";
    this.lblCountApiProxy.TextAlign = ContentAlignment.MiddleCenter;
    this.label28.AutoSize = true;
    this.label28.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label28.Location = new Point(1, 5);
    this.label28.Name = "label28";
    this.label28.Size = new Size(31, 16);
    this.label28.TabIndex = 82;
    this.label28.Text = "API:";
    this.txtApiProxy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtApiProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.txtApiProxy.ForeColor = Color.Black;
    this.txtApiProxy.Location = new Point(35, 2);
    this.txtApiProxy.Multiline = true;
    this.txtApiProxy.Name = "txtApiProxy";
    this.txtApiProxy.Size = new Size(200, 51);
    this.txtApiProxy.TabIndex = 83;
    this.txtApiProxy.WordWrap = false;
    this.txtApiProxy.TextChanged += new EventHandler(this.txtApiProxy_TextChanged);
    this.button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button7.Cursor = Cursors.Hand;
    this.button7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.button7.ForeColor = Color.Black;
    this.button7.Location = new Point(238, 1);
    this.button7.Name = "button7";
    this.button7.Size = new Size(52, 27);
    this.button7.TabIndex = 143;
    this.button7.Text = "Check";
    this.button7.UseVisualStyleBackColor = true;
    this.button7.Click += new EventHandler(this.button7_Click);
    this.plApiUser.Anchor = AnchorStyles.None;
    this.plApiUser.BorderStyle = BorderStyle.FixedSingle;
    this.plApiUser.Controls.Add((Control) this.label1);
    this.plApiUser.Controls.Add((Control) this.txtApiUser);
    this.plApiUser.Controls.Add((Control) this.button3);
    this.plApiUser.Location = new Point(95, 69);
    this.plApiUser.Name = "plApiUser";
    this.plApiUser.Size = new Size(292, 29);
    this.plApiUser.TabIndex = 35;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label1.Location = new Point(1, 5);
    this.label1.Name = "label1";
    this.label1.Size = new Size(31, 16);
    this.label1.TabIndex = 82;
    this.label1.Text = "API:";
    this.txtApiUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.txtApiUser.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.txtApiUser.ForeColor = Color.Black;
    this.txtApiUser.Location = new Point(35, 2);
    this.txtApiUser.Name = "txtApiUser";
    this.txtApiUser.Size = new Size(200, 23);
    this.txtApiUser.TabIndex = 83;
    this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button3.Cursor = Cursors.Hand;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.button3.ForeColor = Color.Black;
    this.button3.Location = new Point(238, 0);
    this.button3.Name = "button3";
    this.button3.Size = new Size(52, 27);
    this.button3.TabIndex = 143;
    this.button3.Text = "Check";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.cbbLocationTinsoft.Anchor = AnchorStyles.None;
    this.cbbLocationTinsoft.Cursor = Cursors.Hand;
    this.cbbLocationTinsoft.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbLocationTinsoft.DropDownWidth = 120;
    this.cbbLocationTinsoft.FormattingEnabled = true;
    this.cbbLocationTinsoft.Location = new Point(150, 186);
    this.cbbLocationTinsoft.Name = "cbbLocationTinsoft";
    this.cbbLocationTinsoft.Size = new Size(104, 24);
    this.cbbLocationTinsoft.TabIndex = 84;
    this.rbApiProxy.Anchor = AnchorStyles.None;
    this.rbApiProxy.AutoSize = true;
    this.rbApiProxy.Cursor = Cursors.Hand;
    this.rbApiProxy.Location = new Point(92, 101);
    this.rbApiProxy.Name = "rbApiProxy";
    this.rbApiProxy.Size = new Size(135, 20);
    this.rbApiProxy.TabIndex = 34;
    this.rbApiProxy.Text = "Sử dụng Api Proxy:";
    this.rbApiProxy.UseVisualStyleBackColor = true;
    this.rbApiProxy.CheckedChanged += new EventHandler(this.rbApiProxy_CheckedChanged);
    this.rbApiUser.Anchor = AnchorStyles.None;
    this.rbApiUser.AutoSize = true;
    this.rbApiUser.Checked = true;
    this.rbApiUser.Cursor = Cursors.Hand;
    this.rbApiUser.Location = new Point(92, 48);
    this.rbApiUser.Name = "rbApiUser";
    this.rbApiUser.Size = new Size(130, 20);
    this.rbApiUser.TabIndex = 34;
    this.rbApiUser.TabStop = true;
    this.rbApiUser.Text = "Sử dụng Api User:";
    this.rbApiUser.UseVisualStyleBackColor = true;
    this.rbApiUser.CheckedChanged += new EventHandler(this.rbApiUser_CheckedChanged);
    this.label7.Anchor = AnchorStyles.None;
    this.label7.AutoSize = true;
    this.label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label7.Location = new Point(92, 189);
    this.label7.Name = "label7";
    this.label7.Size = new Size(59, 16);
    this.label7.TabIndex = 82;
    this.label7.Text = "Location:";
    this.label8.Anchor = AnchorStyles.None;
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label8.Location = new Point(259, 189);
    this.label8.Name = "label8";
    this.label8.Size = new Size(78, 16);
    this.label8.TabIndex = 139;
    this.label8.Text = "Số luồng/IP:";
    this.toolTip_0.SetToolTip((Control) this.label8, "Là số tài khoản cùng chạy trên 1 Proxy (hay 1 IP)");
    this.nudLuongPerIPTinsoft.Anchor = AnchorStyles.None;
    this.nudLuongPerIPTinsoft.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudLuongPerIPTinsoft.Location = new Point(341, 187);
    this.nudLuongPerIPTinsoft.Name = "nudLuongPerIPTinsoft";
    this.nudLuongPerIPTinsoft.Size = new Size(46, 23);
    this.nudLuongPerIPTinsoft.TabIndex = 140;
    this.nudLuongPerIPTinsoft.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.tabXProxy.Controls.Add((Control) this.plXproxy);
    this.tabXProxy.Location = new Point(4, 4);
    this.tabXProxy.Name = "tabXProxy";
    this.tabXProxy.Padding = new Padding(3);
    this.tabXProxy.Size = new Size(487, 209);
    this.tabXProxy.TabIndex = 2;
    this.tabXProxy.Text = "Xproxy";
    this.tabXProxy.UseVisualStyleBackColor = true;
    this.plXproxy.BorderStyle = BorderStyle.FixedSingle;
    this.plXproxy.Controls.Add((Control) this.label3);
    this.plXproxy.Controls.Add((Control) this.ckbShowProxy);
    this.plXproxy.Controls.Add((Control) this.nudDelayConnectXproxy);
    this.plXproxy.Controls.Add((Control) this.label4);
    this.plXproxy.Controls.Add((Control) this.txtListProxy);
    this.plXproxy.Controls.Add((Control) this.label17);
    this.plXproxy.Controls.Add((Control) this.label2);
    this.plXproxy.Controls.Add((Control) this.label13);
    this.plXproxy.Controls.Add((Control) this.txtServiceURLXProxy);
    this.plXproxy.Dock = DockStyle.Fill;
    this.plXproxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plXproxy.Location = new Point(3, 3);
    this.plXproxy.Name = "plXproxy";
    this.plXproxy.Size = new Size(481, 203);
    this.plXproxy.TabIndex = 142;
    this.plXproxy.Click += new EventHandler(this.plObcProxy_Click);
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(274, 156);
    this.label3.Name = "label3";
    this.label3.Size = new Size(30, 16);
    this.label3.TabIndex = 147;
    this.label3.Text = "giây";
    this.ckbShowProxy.AutoSize = true;
    this.ckbShowProxy.Cursor = Cursors.Hand;
    this.ckbShowProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbShowProxy.Location = new Point(16, 178);
    this.ckbShowProxy.Name = "ckbShowProxy";
    this.ckbShowProxy.Size = new Size(208, 20);
    this.ckbShowProxy.TabIndex = 112;
    this.ckbShowProxy.Text = "Hiển thị thông tin proxy khi chạy";
    this.ckbShowProxy.UseVisualStyleBackColor = true;
    this.ckbShowProxy.CheckedChanged += new EventHandler(this.ckbShowProxy_CheckedChanged);
    this.nudDelayConnectXproxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.nudDelayConnectXproxy.Location = new Point(217, 154);
    this.nudDelayConnectXproxy.Maximum = new Decimal(new int[4]
    {
      1410065407,
      2,
      0,
      0
    });
    this.nudDelayConnectXproxy.Name = "nudDelayConnectXproxy";
    this.nudDelayConnectXproxy.Size = new Size(56, 23);
    this.nudDelayConnectXproxy.TabIndex = 146;
    this.label4.AutoSize = true;
    this.label4.Cursor = Cursors.Arrow;
    this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label4.Location = new Point(13, 156);
    this.label4.Name = "label4";
    this.label4.Size = new Size(203, 16);
    this.label4.TabIndex = 145;
    this.label4.Text = "Delay connect proxy sau khi reset:";
    this.txtListProxy.Anchor = AnchorStyles.None;
    this.txtListProxy.BorderStyle = BorderStyle.FixedSingle;
    this.txtListProxy.Location = new Point(16, 49);
    this.txtListProxy.Name = "txtListProxy";
    this.txtListProxy.Size = new Size(447, 80);
    this.txtListProxy.TabIndex = 144;
    this.txtListProxy.Text = "";
    this.txtListProxy.WordWrap = false;
    this.txtListProxy.TextChanged += new EventHandler(this.txtListProxy_TextChanged);
    this.label17.Anchor = AnchorStyles.None;
    this.label17.AutoSize = true;
    this.label17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label17.Location = new Point(13, 30);
    this.label17.Name = "label17";
    this.label17.Size = new Size(159, 16);
    this.label17.TabIndex = 79;
    this.label17.Text = "Nhập danh sách Proxy (0):";
    this.label2.Anchor = AnchorStyles.None;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label2.Location = new Point(13, 132);
    this.label2.Name = "label2";
    this.label2.Size = new Size(385, 16);
    this.label2.TabIndex = 79;
    this.label2.Text = "(Mỗi phone sẽ sử dụng 1 proxy riêng - Chỉ sử dụng với Http Proxy)";
    this.label13.Anchor = AnchorStyles.None;
    this.label13.AutoSize = true;
    this.label13.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label13.Location = new Point(13, 8);
    this.label13.Name = "label13";
    this.label13.Size = new Size(80, 16);
    this.label13.TabIndex = 79;
    this.label13.Text = "Service URL:";
    this.txtServiceURLXProxy.Anchor = AnchorStyles.None;
    this.txtServiceURLXProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.txtServiceURLXProxy.ForeColor = Color.Black;
    this.txtServiceURLXProxy.Location = new Point(100, 5);
    this.txtServiceURLXProxy.Name = "txtServiceURLXProxy";
    this.txtServiceURLXProxy.Size = new Size(363, 23);
    this.txtServiceURLXProxy.TabIndex = 81;
    this.tabObcProxy.Controls.Add((Control) this.plObcProxy);
    this.tabObcProxy.Location = new Point(4, 4);
    this.tabObcProxy.Name = "tabObcProxy";
    this.tabObcProxy.Padding = new Padding(3);
    this.tabObcProxy.Size = new Size(487, 209);
    this.tabObcProxy.TabIndex = 3;
    this.tabObcProxy.Text = "OBC Proxy";
    this.tabObcProxy.UseVisualStyleBackColor = true;
    this.plObcProxy.BorderStyle = BorderStyle.FixedSingle;
    this.plObcProxy.Controls.Add((Control) this.label33);
    this.plObcProxy.Controls.Add((Control) this.rbObcResetDaiIP);
    this.plObcProxy.Controls.Add((Control) this.rbObcResetTungIP);
    this.plObcProxy.Controls.Add((Control) this.txtListObcProxy);
    this.plObcProxy.Controls.Add((Control) this.label34);
    this.plObcProxy.Controls.Add((Control) this.label35);
    this.plObcProxy.Controls.Add((Control) this.label40);
    this.plObcProxy.Controls.Add((Control) this.nudLuongPerIPObcProxy);
    this.plObcProxy.Controls.Add((Control) this.label39);
    this.plObcProxy.Controls.Add((Control) this.label41);
    this.plObcProxy.Controls.Add((Control) this.nudDelayCheckIPObcProxy);
    this.plObcProxy.Controls.Add((Control) this.txtLinkWebObcProxy);
    this.plObcProxy.Dock = DockStyle.Fill;
    this.plObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plObcProxy.Location = new Point(3, 3);
    this.plObcProxy.Name = "plObcProxy";
    this.plObcProxy.Size = new Size(481, 203);
    this.plObcProxy.TabIndex = 142;
    this.plObcProxy.Click += new EventHandler(this.plObcProxy_Click);
    this.label33.Anchor = AnchorStyles.None;
    this.label33.AutoSize = true;
    this.label33.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label33.Location = new Point(251, 115);
    this.label33.Name = "label33";
    this.label33.Size = new Size(82, 16);
    this.label33.TabIndex = 151;
    this.label33.Text = "Chế độ chạy:";
    this.rbObcResetDaiIP.Anchor = AnchorStyles.None;
    this.rbObcResetDaiIP.AutoSize = true;
    this.rbObcResetDaiIP.Cursor = Cursors.Hand;
    this.rbObcResetDaiIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbObcResetDaiIP.Location = new Point(336, 137);
    this.rbObcResetDaiIP.Margin = new Padding(3, 4, 3, 4);
    this.rbObcResetDaiIP.Name = "rbObcResetDaiIP";
    this.rbObcResetDaiIP.Size = new Size(110, 20);
    this.rbObcResetDaiIP.TabIndex = 149;
    this.rbObcResetDaiIP.Text = "Reset cả dải IP";
    this.rbObcResetDaiIP.UseVisualStyleBackColor = true;
    this.rbObcResetTungIP.Anchor = AnchorStyles.None;
    this.rbObcResetTungIP.AutoSize = true;
    this.rbObcResetTungIP.Checked = true;
    this.rbObcResetTungIP.Cursor = Cursors.Hand;
    this.rbObcResetTungIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbObcResetTungIP.Location = new Point(336, 113);
    this.rbObcResetTungIP.Margin = new Padding(3, 4, 3, 4);
    this.rbObcResetTungIP.Name = "rbObcResetTungIP";
    this.rbObcResetTungIP.Size = new Size(102, 20);
    this.rbObcResetTungIP.TabIndex = 150;
    this.rbObcResetTungIP.TabStop = true;
    this.rbObcResetTungIP.Text = "Reset từng IP";
    this.rbObcResetTungIP.UseVisualStyleBackColor = true;
    this.txtListObcProxy.Anchor = AnchorStyles.None;
    this.txtListObcProxy.BorderStyle = BorderStyle.FixedSingle;
    this.txtListObcProxy.Location = new Point(16, 84);
    this.txtListObcProxy.Name = "txtListObcProxy";
    this.txtListObcProxy.Size = new Size(229, 115);
    this.txtListObcProxy.TabIndex = 144;
    this.txtListObcProxy.Text = "";
    this.txtListObcProxy.WordWrap = false;
    this.txtListObcProxy.TextChanged += new EventHandler(this.txtListObcProxy_TextChanged);
    this.label34.Anchor = AnchorStyles.None;
    this.label34.AutoSize = true;
    this.label34.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label34.Location = new Point(13, 62);
    this.label34.Name = "label34";
    this.label34.Size = new Size(97, 16);
    this.label34.TabIndex = 79;
    this.label34.Text = "Nhập Proxy (0):";
    this.label35.Anchor = AnchorStyles.None;
    this.label35.AutoSize = true;
    this.label35.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label35.Location = new Point(430, 161);
    this.label35.Name = "label35";
    this.label35.Size = new Size(32, 16);
    this.label35.TabIndex = 139;
    this.label35.Text = "phút";
    this.label40.Anchor = AnchorStyles.None;
    this.label40.AutoSize = true;
    this.label40.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label40.Location = new Point(251, 86);
    this.label40.Name = "label40";
    this.label40.Size = new Size(78, 16);
    this.label40.TabIndex = 139;
    this.label40.Text = "Số luồng/IP:";
    this.nudLuongPerIPObcProxy.Anchor = AnchorStyles.None;
    this.nudLuongPerIPObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudLuongPerIPObcProxy.Location = new Point(336, 85);
    this.nudLuongPerIPObcProxy.Name = "nudLuongPerIPObcProxy";
    this.nudLuongPerIPObcProxy.Size = new Size(67, 23);
    this.nudLuongPerIPObcProxy.TabIndex = 140;
    this.nudLuongPerIPObcProxy.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.label39.Anchor = AnchorStyles.None;
    this.label39.AutoSize = true;
    this.label39.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label39.Location = new Point(251, 161);
    this.label39.Name = "label39";
    this.label39.Size = new Size(123, 16);
    this.label39.TabIndex = 139;
    this.label39.Text = "Chờ Check IP tối đa:";
    this.label41.Anchor = AnchorStyles.None;
    this.label41.AutoSize = true;
    this.label41.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label41.Location = new Point(13, 38);
    this.label41.Name = "label41";
    this.label41.Size = new Size(64, 16);
    this.label41.TabIndex = 79;
    this.label41.Text = "Link Web:";
    this.nudDelayCheckIPObcProxy.Anchor = AnchorStyles.None;
    this.nudDelayCheckIPObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudDelayCheckIPObcProxy.Location = new Point(377, 159);
    this.nudDelayCheckIPObcProxy.Name = "nudDelayCheckIPObcProxy";
    this.nudDelayCheckIPObcProxy.Size = new Size(50, 23);
    this.nudDelayCheckIPObcProxy.TabIndex = 140;
    this.nudDelayCheckIPObcProxy.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.txtLinkWebObcProxy.Anchor = AnchorStyles.None;
    this.txtLinkWebObcProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.txtLinkWebObcProxy.ForeColor = Color.Black;
    this.txtLinkWebObcProxy.Location = new Point(100, 35);
    this.txtLinkWebObcProxy.Name = "txtLinkWebObcProxy";
    this.txtLinkWebObcProxy.Size = new Size(363, 23);
    this.txtLinkWebObcProxy.TabIndex = 81;
    this.tabProxyV6.Controls.Add((Control) this.plProxyv6);
    this.tabProxyV6.Location = new Point(4, 4);
    this.tabProxyV6.Name = "tabProxyV6";
    this.tabProxyV6.Padding = new Padding(3);
    this.tabProxyV6.Size = new Size(487, 209);
    this.tabProxyV6.TabIndex = 4;
    this.tabProxyV6.Text = "https://proxyv6.net/vi";
    this.tabProxyV6.UseVisualStyleBackColor = true;
    this.plProxyv6.BorderStyle = BorderStyle.FixedSingle;
    this.plProxyv6.Controls.Add((Control) this.txtListProxyv6);
    this.plProxyv6.Controls.Add((Control) this.label43);
    this.plProxyv6.Controls.Add((Control) this.label44);
    this.plProxyv6.Controls.Add((Control) this.nudLuongPerIPProxyv6);
    this.plProxyv6.Controls.Add((Control) this.label45);
    this.plProxyv6.Controls.Add((Control) this.txtApiProxyv6);
    this.plProxyv6.Dock = DockStyle.Fill;
    this.plProxyv6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plProxyv6.Location = new Point(3, 3);
    this.plProxyv6.Name = "plProxyv6";
    this.plProxyv6.Size = new Size(481, 203);
    this.plProxyv6.TabIndex = 155;
    this.txtListProxyv6.Anchor = AnchorStyles.None;
    this.txtListProxyv6.BorderStyle = BorderStyle.FixedSingle;
    this.txtListProxyv6.Location = new Point(88, 93);
    this.txtListProxyv6.Name = "txtListProxyv6";
    this.txtListProxyv6.Size = new Size(309, 92);
    this.txtListProxyv6.TabIndex = 144;
    this.txtListProxyv6.Text = "";
    this.txtListProxyv6.WordWrap = false;
    this.txtListProxyv6.TextChanged += new EventHandler(this.txtListProxyv6_TextChanged);
    this.label43.Anchor = AnchorStyles.None;
    this.label43.AutoSize = true;
    this.label43.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label43.Location = new Point(85, 74);
    this.label43.Name = "label43";
    this.label43.Size = new Size(97, 16);
    this.label43.TabIndex = 79;
    this.label43.Text = "Nhập Proxy (0):";
    this.label44.Anchor = AnchorStyles.None;
    this.label44.AutoSize = true;
    this.label44.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label44.Location = new Point(87, 189);
    this.label44.Name = "label44";
    this.label44.Size = new Size(78, 16);
    this.label44.TabIndex = 139;
    this.label44.Text = "Số luồng/IP:";
    this.nudLuongPerIPProxyv6.Anchor = AnchorStyles.None;
    this.nudLuongPerIPProxyv6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudLuongPerIPProxyv6.Location = new Point(172, 188);
    this.nudLuongPerIPProxyv6.Name = "nudLuongPerIPProxyv6";
    this.nudLuongPerIPProxyv6.Size = new Size(67, 23);
    this.nudLuongPerIPProxyv6.TabIndex = 140;
    this.nudLuongPerIPProxyv6.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.label45.Anchor = AnchorStyles.None;
    this.label45.AutoSize = true;
    this.label45.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label45.Location = new Point(85, 51);
    this.label45.Name = "label45";
    this.label45.Size = new Size(55, 16);
    this.label45.TabIndex = 79;
    this.label45.Text = "API Key:";
    this.txtApiProxyv6.Anchor = AnchorStyles.None;
    this.txtApiProxyv6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.txtApiProxyv6.ForeColor = Color.Black;
    this.txtApiProxyv6.Location = new Point(157, 48);
    this.txtApiProxyv6.Name = "txtApiProxyv6";
    this.txtApiProxyv6.Size = new Size(240, 23);
    this.txtApiProxyv6.TabIndex = 81;
    this.tabProxyShopLike.Controls.Add((Control) this.plShopLike);
    this.tabProxyShopLike.Location = new Point(4, 4);
    this.tabProxyShopLike.Name = "tabProxyShopLike";
    this.tabProxyShopLike.Padding = new Padding(3);
    this.tabProxyShopLike.Size = new Size(487, 209);
    this.tabProxyShopLike.TabIndex = 5;
    this.tabProxyShopLike.Text = "http://proxy.shoplike.vn/";
    this.tabProxyShopLike.UseVisualStyleBackColor = true;
    this.plShopLike.BorderStyle = BorderStyle.FixedSingle;
    this.plShopLike.Controls.Add((Control) this.txtApiShopLike);
    this.plShopLike.Controls.Add((Control) this.label47);
    this.plShopLike.Controls.Add((Control) this.label48);
    this.plShopLike.Controls.Add((Control) this.nudLuongPerIPShopLike);
    this.plShopLike.Dock = DockStyle.Fill;
    this.plShopLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plShopLike.Location = new Point(3, 3);
    this.plShopLike.Name = "plShopLike";
    this.plShopLike.Size = new Size(481, 203);
    this.plShopLike.TabIndex = 157;
    this.txtApiShopLike.Anchor = AnchorStyles.None;
    this.txtApiShopLike.BorderStyle = BorderStyle.FixedSingle;
    this.txtApiShopLike.Location = new Point(93, 75);
    this.txtApiShopLike.Name = "txtApiShopLike";
    this.txtApiShopLike.Size = new Size(309, 100);
    this.txtApiShopLike.TabIndex = 144;
    this.txtApiShopLike.Text = "";
    this.txtApiShopLike.WordWrap = false;
    this.txtApiShopLike.TextChanged += new EventHandler(this.txtApiShopLike_TextChanged);
    this.label47.Anchor = AnchorStyles.None;
    this.label47.AutoSize = true;
    this.label47.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label47.Location = new Point(90, 55);
    this.label47.Name = "label47";
    this.label47.Size = new Size(110, 16);
    this.label47.TabIndex = 79;
    this.label47.Text = "Nhập API KEY (0):";
    this.label48.Anchor = AnchorStyles.None;
    this.label48.AutoSize = true;
    this.label48.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label48.Location = new Point(91, 182);
    this.label48.Name = "label48";
    this.label48.Size = new Size(78, 16);
    this.label48.TabIndex = 139;
    this.label48.Text = "Số luồng/IP:";
    this.nudLuongPerIPShopLike.Anchor = AnchorStyles.None;
    this.nudLuongPerIPShopLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudLuongPerIPShopLike.Location = new Point(176, 179);
    this.nudLuongPerIPShopLike.Name = "nudLuongPerIPShopLike";
    this.nudLuongPerIPShopLike.Size = new Size(67, 23);
    this.nudLuongPerIPShopLike.TabIndex = 140;
    this.nudLuongPerIPShopLike.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.tabTMProxy.Controls.Add((Control) this.plTMProxy);
    this.tabTMProxy.Location = new Point(4, 4);
    this.tabTMProxy.Name = "tabTMProxy";
    this.tabTMProxy.Padding = new Padding(3);
    this.tabTMProxy.Size = new Size(487, 209);
    this.tabTMProxy.TabIndex = 6;
    this.tabTMProxy.Text = "https://tmproxy.com/";
    this.tabTMProxy.UseVisualStyleBackColor = true;
    this.plTMProxy.BorderStyle = BorderStyle.FixedSingle;
    this.plTMProxy.Controls.Add((Control) this.ckbWaitDoneAllTMProxy);
    this.plTMProxy.Controls.Add((Control) this.txtApiKeyTMProxy);
    this.plTMProxy.Controls.Add((Control) this.label24);
    this.plTMProxy.Controls.Add((Control) this.button8);
    this.plTMProxy.Controls.Add((Control) this.label25);
    this.plTMProxy.Controls.Add((Control) this.nudLuongPerIPTMProxy);
    this.plTMProxy.Dock = DockStyle.Fill;
    this.plTMProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.plTMProxy.Location = new Point(3, 3);
    this.plTMProxy.Name = "plTMProxy";
    this.plTMProxy.Size = new Size(481, 203);
    this.plTMProxy.TabIndex = 146;
    this.plTMProxy.Click += new EventHandler(this.plTMProxy_Click);
    this.ckbWaitDoneAllTMProxy.Anchor = AnchorStyles.None;
    this.ckbWaitDoneAllTMProxy.AutoSize = true;
    this.ckbWaitDoneAllTMProxy.Cursor = Cursors.Hand;
    this.ckbWaitDoneAllTMProxy.Location = new Point(229, 54);
    this.ckbWaitDoneAllTMProxy.Name = "ckbWaitDoneAllTMProxy";
    this.ckbWaitDoneAllTMProxy.Size = new Size(128, 20);
    this.ckbWaitDoneAllTMProxy.TabIndex = 145;
    this.ckbWaitDoneAllTMProxy.Text = "Đợi chạy xong hết";
    this.ckbWaitDoneAllTMProxy.UseVisualStyleBackColor = true;
    this.ckbWaitDoneAllTMProxy.Visible = false;
    this.txtApiKeyTMProxy.Anchor = AnchorStyles.None;
    this.txtApiKeyTMProxy.BorderStyle = BorderStyle.FixedSingle;
    this.txtApiKeyTMProxy.Location = new Point(61, 75);
    this.txtApiKeyTMProxy.Name = "txtApiKeyTMProxy";
    this.txtApiKeyTMProxy.Size = new Size(363, 100);
    this.txtApiKeyTMProxy.TabIndex = 144;
    this.txtApiKeyTMProxy.Text = "";
    this.txtApiKeyTMProxy.WordWrap = false;
    this.txtApiKeyTMProxy.TextChanged += new EventHandler(this.txtApiKeyTMProxy_TextChanged);
    this.label24.Anchor = AnchorStyles.None;
    this.label24.AutoSize = true;
    this.label24.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label24.Location = new Point(58, 55);
    this.label24.Name = "label24";
    this.label24.Size = new Size(110, 16);
    this.label24.TabIndex = 79;
    this.label24.Text = "Nhập API KEY (0):";
    this.button8.Anchor = AnchorStyles.None;
    this.button8.Cursor = Cursors.Hand;
    this.button8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.button8.ForeColor = Color.Black;
    this.button8.Location = new Point(372, 177);
    this.button8.Name = "button8";
    this.button8.Size = new Size(52, 27);
    this.button8.TabIndex = 143;
    this.button8.Text = "Check";
    this.button8.UseVisualStyleBackColor = true;
    this.button8.Click += new EventHandler(this.button8_Click);
    this.label25.Anchor = AnchorStyles.None;
    this.label25.AutoSize = true;
    this.label25.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label25.Location = new Point(59, 182);
    this.label25.Name = "label25";
    this.label25.Size = new Size(78, 16);
    this.label25.TabIndex = 139;
    this.label25.Text = "Số luồng/IP:";
    this.nudLuongPerIPTMProxy.Anchor = AnchorStyles.None;
    this.nudLuongPerIPTMProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudLuongPerIPTMProxy.Location = new Point(144, 181);
    this.nudLuongPerIPTMProxy.Name = "nudLuongPerIPTMProxy";
    this.nudLuongPerIPTMProxy.Size = new Size(67, 23);
    this.nudLuongPerIPTMProxy.TabIndex = 140;
    this.nudLuongPerIPTMProxy.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.tabNone.Controls.Add((Control) this.panel5);
    this.tabNone.Location = new Point(4, 4);
    this.tabNone.Name = "tabNone";
    this.tabNone.Padding = new Padding(3);
    this.tabNone.Size = new Size(487, 209);
    this.tabNone.TabIndex = 7;
    this.tabNone.Text = "tabPage1";
    this.tabNone.UseVisualStyleBackColor = true;
    this.panel5.BorderStyle = BorderStyle.FixedSingle;
    this.panel5.Dock = DockStyle.Fill;
    this.panel5.Location = new Point(3, 3);
    this.panel5.Name = "panel5";
    this.panel5.Size = new Size(481, 203);
    this.panel5.TabIndex = 0;
    this.tabMinProxy.Controls.Add((Control) this.panel6);
    this.tabMinProxy.Location = new Point(4, 4);
    this.tabMinProxy.Name = "tabMinProxy";
    this.tabMinProxy.Padding = new Padding(3);
    this.tabMinProxy.Size = new Size(487, 209);
    this.tabMinProxy.TabIndex = 8;
    this.tabMinProxy.Text = "https://minproxy.vn/";
    this.tabMinProxy.UseVisualStyleBackColor = true;
    this.panel6.BorderStyle = BorderStyle.FixedSingle;
    this.panel6.Controls.Add((Control) this.label42);
    this.panel6.Controls.Add((Control) this.plTypeProxy);
    this.panel6.Controls.Add((Control) this.label56);
    this.panel6.Controls.Add((Control) this.rbProxyDanCu);
    this.panel6.Controls.Add((Control) this.rbProxyDong);
    this.panel6.Controls.Add((Control) this.button10);
    this.panel6.Controls.Add((Control) this.txtApiKeyMinProxy);
    this.panel6.Controls.Add((Control) this.label49);
    this.panel6.Controls.Add((Control) this.nudLuongPerIPMinProxy);
    this.panel6.Dock = DockStyle.Fill;
    this.panel6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.panel6.Location = new Point(3, 3);
    this.panel6.Name = "panel6";
    this.panel6.Size = new Size(481, 203);
    this.panel6.TabIndex = 154;
    this.label42.Anchor = AnchorStyles.None;
    this.label42.AutoSize = true;
    this.label42.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label42.Location = new Point(86, 202);
    this.label42.Name = "label42";
    this.label42.Size = new Size(78, 16);
    this.label42.TabIndex = 166;
    this.label42.Text = "Số luồng/IP:";
    this.plTypeProxy.Controls.Add((Control) this.rbHttpv6);
    this.plTypeProxy.Controls.Add((Control) this.rbHttpv4);
    this.plTypeProxy.Enabled = false;
    this.plTypeProxy.Location = new Point(149, 24);
    this.plTypeProxy.Name = "plTypeProxy";
    this.plTypeProxy.Size = new Size(142, 25);
    this.plTypeProxy.TabIndex = 165;
    this.rbHttpv6.AutoSize = true;
    this.rbHttpv6.Cursor = Cursors.Hand;
    this.rbHttpv6.Location = new Point(74, 2);
    this.rbHttpv6.Name = "rbHttpv6";
    this.rbHttpv6.Size = new Size(63, 20);
    this.rbHttpv6.TabIndex = 161;
    this.rbHttpv6.Text = "HttpV6";
    this.rbHttpv6.UseVisualStyleBackColor = true;
    this.rbHttpv4.AutoSize = true;
    this.rbHttpv4.Checked = true;
    this.rbHttpv4.Cursor = Cursors.Hand;
    this.rbHttpv4.Location = new Point(2, 2);
    this.rbHttpv4.Name = "rbHttpv4";
    this.rbHttpv4.Size = new Size(63, 20);
    this.rbHttpv4.TabIndex = 160;
    this.rbHttpv4.TabStop = true;
    this.rbHttpv4.Text = "HttpV4";
    this.rbHttpv4.UseVisualStyleBackColor = true;
    this.label56.AutoSize = true;
    this.label56.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label56.Location = new Point(76, 28);
    this.label56.Name = "label56";
    this.label56.Size = new Size(70, 16);
    this.label56.TabIndex = 155;
    this.label56.Text = "Loại Proxy:";
    this.rbProxyDanCu.AutoSize = true;
    this.rbProxyDanCu.Cursor = Cursors.Hand;
    this.rbProxyDanCu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbProxyDanCu.Location = new Point(198, 4);
    this.rbProxyDanCu.Margin = new Padding(3, 4, 3, 4);
    this.rbProxyDanCu.Name = "rbProxyDanCu";
    this.rbProxyDanCu.Size = new Size(99, 20);
    this.rbProxyDanCu.TabIndex = 164;
    this.rbProxyDanCu.Text = "Proxy dân cư";
    this.rbProxyDanCu.UseVisualStyleBackColor = true;
    this.rbProxyDanCu.CheckedChanged += new EventHandler(this.rbProxyDanCu_CheckedChanged);
    this.rbProxyDong.AutoSize = true;
    this.rbProxyDong.Checked = true;
    this.rbProxyDong.Cursor = Cursors.Hand;
    this.rbProxyDong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbProxyDong.Location = new Point(79, 4);
    this.rbProxyDong.Margin = new Padding(3, 4, 3, 4);
    this.rbProxyDong.Name = "rbProxyDong";
    this.rbProxyDong.Size = new Size(107, 20);
    this.rbProxyDong.TabIndex = 163;
    this.rbProxyDong.TabStop = true;
    this.rbProxyDong.Text = "Proxy V6 động";
    this.rbProxyDong.UseVisualStyleBackColor = true;
    this.button10.Anchor = AnchorStyles.None;
    this.button10.Cursor = Cursors.Hand;
    this.button10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.button10.ForeColor = Color.Black;
    this.button10.Location = new Point(346, 198);
    this.button10.Name = "button10";
    this.button10.Size = new Size(52, 27);
    this.button10.TabIndex = 162;
    this.button10.Text = "Check";
    this.button10.UseVisualStyleBackColor = true;
    this.button10.Click += new EventHandler(this.button10_Click);
    this.txtApiKeyMinProxy.Anchor = AnchorStyles.None;
    this.txtApiKeyMinProxy.BorderStyle = BorderStyle.FixedSingle;
    this.txtApiKeyMinProxy.Location = new Point(89, 101);
    this.txtApiKeyMinProxy.Name = "txtApiKeyMinProxy";
    this.txtApiKeyMinProxy.Size = new Size(309, 95);
    this.txtApiKeyMinProxy.TabIndex = 161;
    this.txtApiKeyMinProxy.Text = "";
    this.txtApiKeyMinProxy.WordWrap = false;
    this.txtApiKeyMinProxy.TextChanged += new EventHandler(this.txtApiKeyMinProxy_TextChanged);
    this.label49.Anchor = AnchorStyles.None;
    this.label49.AutoSize = true;
    this.label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.label49.Location = new Point(86, 82);
    this.label49.Name = "label49";
    this.label49.Size = new Size(110, 16);
    this.label49.TabIndex = 159;
    this.label49.Text = "Nhập API KEY (0):";
    this.nudLuongPerIPMinProxy.Anchor = AnchorStyles.None;
    this.nudLuongPerIPMinProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.nudLuongPerIPMinProxy.Location = new Point(171, 200);
    this.nudLuongPerIPMinProxy.Name = "nudLuongPerIPMinProxy";
    this.nudLuongPerIPMinProxy.Size = new Size(67, 23);
    this.nudLuongPerIPMinProxy.TabIndex = 160;
    this.nudLuongPerIPMinProxy.Value = new Decimal(new int[4]
    {
      1,
      0,
      0,
      0
    });
    this.rbProxy.AutoSize = true;
    this.rbProxy.Cursor = Cursors.Hand;
    this.rbProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbProxy.Location = new Point(21, 79);
    this.rbProxy.Margin = new Padding(3, 4, 3, 4);
    this.rbProxy.Name = "rbProxy";
    this.rbProxy.Size = new Size(266, 20);
    this.rbProxy.TabIndex = 136;
    this.rbProxy.Text = "Sử dụng Proxy (đã gán cho mỗi tài khoản)";
    this.rbProxy.UseVisualStyleBackColor = true;
    this.rbProxy.CheckedChanged += new EventHandler(this.rbProxy_CheckedChanged);
    this.rbNone.AutoSize = true;
    this.rbNone.Checked = true;
    this.rbNone.Cursor = Cursors.Hand;
    this.rbNone.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbNone.Location = new Point(21, 23);
    this.rbNone.Margin = new Padding(3, 4, 3, 4);
    this.rbNone.Name = "rbNone";
    this.rbNone.Size = new Size(96, 20);
    this.rbNone.TabIndex = 136;
    this.rbNone.TabStop = true;
    this.rbNone.Text = "Không đổi IP";
    this.rbNone.UseVisualStyleBackColor = true;
    this.rbNone.CheckedChanged += new EventHandler(this.rbNone_CheckedChanged);
    this.ckbKhongCheckIP.AutoSize = true;
    this.ckbKhongCheckIP.Cursor = Cursors.Hand;
    this.ckbKhongCheckIP.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ckbKhongCheckIP.Location = new Point(319, 24);
    this.ckbKhongCheckIP.Name = "ckbKhongCheckIP";
    this.ckbKhongCheckIP.Size = new Size(198, 20);
    this.ckbKhongCheckIP.TabIndex = 112;
    this.ckbKhongCheckIP.Text = "Không Check IP trước khi chạy";
    this.ckbKhongCheckIP.UseVisualStyleBackColor = true;
    this.rbXproxy.AutoSize = true;
    this.rbXproxy.Cursor = Cursors.Hand;
    this.rbXproxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
    this.rbXproxy.Location = new Point(21, 107);
    this.rbXproxy.Margin = new Padding(3, 4, 3, 4);
    this.rbXproxy.Name = "rbXproxy";
    this.rbXproxy.Size = new Size(64, 20);
    this.rbXproxy.TabIndex = 138;
    this.rbXproxy.Text = "Xproxy";
    this.rbXproxy.UseVisualStyleBackColor = true;
    this.rbXproxy.CheckedChanged += new EventHandler(this.rbXproxy_CheckedChanged);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 10000;
    this.toolTip_0.InitialDelay = 200;
    this.toolTip_0.ReshowDelay = 40;
    this.label11.AutoSize = true;
    this.label11.Cursor = Cursors.Help;
    this.label11.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label11.Location = new Point(345, 75);
    this.label11.Name = "label11";
    this.label11.Size = new Size(78, 16);
    this.label11.TabIndex = 166;
    this.label11.Text = "Delay luồng:";
    this.toolTip_0.SetToolTip((Control) this.label11, "Là số luồng khi chạy các chức năng không liên quan gì đến trình duyệt.\r\nVí dụ như: Check wall, Check Avatar,...\r\n(Khuyến cáo nên để 10 luồng)");
    this.label16.AutoSize = true;
    this.label16.Cursor = Cursors.Help;
    this.label16.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label16.Location = new Point(488, 76);
    this.label16.Name = "label16";
    this.label16.Size = new Size(24, 16);
    this.label16.TabIndex = 167;
    this.label16.Text = "ms";
    this.toolTip_0.SetToolTip((Control) this.label16, "Là số luồng khi chạy các chức năng không liên quan gì đến trình duyệt.\r\nVí dụ như: Check wall, Check Avatar,...\r\n(Khuyến cáo nên để 10 luồng)");
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(551, 654);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.bunifuCards1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fCauHinhChung);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình chung";
    this.Load += new EventHandler(this.fCauHinhChung_Load);
    this.nudHideThread.EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.groupBox4.ResumeLayout(false);
    this.groupBox4.PerformLayout();
    this.plChangeDevice.ResumeLayout(false);
    this.plChangeDevice.PerformLayout();
    this.plCheckDoiIP.ResumeLayout(false);
    this.plCheckDoiIP.PerformLayout();
    this.nudChangeIpCount.EndInit();
    this.bunifuCards2.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.plNordVPN.ResumeLayout(false);
    this.plNordVPN.PerformLayout();
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.panel4.ResumeLayout(false);
    this.panel4.PerformLayout();
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    this.nudDelayThread.EndInit();
    this.plDongBoMaxCare.ResumeLayout(false);
    this.plDongBoMaxCare.PerformLayout();
    this.groupBox3.ResumeLayout(false);
    this.groupBox3.PerformLayout();
    this.plTypeConnectProxy.ResumeLayout(false);
    this.plTypeConnectProxy.PerformLayout();
    this.nudDelayCheckIP.EndInit();
    this.tabChangeIP.ResumeLayout(false);
    this.tabDcom.ResumeLayout(false);
    this.plDcom.ResumeLayout(false);
    this.plDcom.PerformLayout();
    this.tabTinsoft.ResumeLayout(false);
    this.plTinsoft.ResumeLayout(false);
    this.plTinsoft.PerformLayout();
    this.plApiProxy.ResumeLayout(false);
    this.plApiProxy.PerformLayout();
    this.plApiUser.ResumeLayout(false);
    this.plApiUser.PerformLayout();
    this.nudLuongPerIPTinsoft.EndInit();
    this.tabXProxy.ResumeLayout(false);
    this.plXproxy.ResumeLayout(false);
    this.plXproxy.PerformLayout();
    this.nudDelayConnectXproxy.EndInit();
    this.tabObcProxy.ResumeLayout(false);
    this.plObcProxy.ResumeLayout(false);
    this.plObcProxy.PerformLayout();
    this.nudLuongPerIPObcProxy.EndInit();
    this.nudDelayCheckIPObcProxy.EndInit();
    this.tabProxyV6.ResumeLayout(false);
    this.plProxyv6.ResumeLayout(false);
    this.plProxyv6.PerformLayout();
    this.nudLuongPerIPProxyv6.EndInit();
    this.tabProxyShopLike.ResumeLayout(false);
    this.plShopLike.ResumeLayout(false);
    this.plShopLike.PerformLayout();
    this.nudLuongPerIPShopLike.EndInit();
    this.tabTMProxy.ResumeLayout(false);
    this.plTMProxy.ResumeLayout(false);
    this.plTMProxy.PerformLayout();
    this.nudLuongPerIPTMProxy.EndInit();
    this.tabNone.ResumeLayout(false);
    this.tabMinProxy.ResumeLayout(false);
    this.panel6.ResumeLayout(false);
    this.panel6.PerformLayout();
    this.plTypeProxy.ResumeLayout(false);
    this.plTypeProxy.PerformLayout();
    this.nudLuongPerIPMinProxy.EndInit();
    this.ResumeLayout(false);
  }

  private void nudHideThread_ValueChanged(object sender, EventArgs e)
  {
  }
}
