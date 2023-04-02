// Decompiled with JetBrains decompiler
// Type: fDeviceList
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

public class fDeviceList : Form
{
  private GClass22 gclass22_0;
  private object object_0 = new object();
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuDragControl bunifuDragControl_0;
  private Panel panel1;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private Button btnClose;
  private BunifuCustomLabel bunifuCustomLabel1;
  private GroupBox groupBox1;
  private Button btnUpdateDeviceName;
  private TextBox txtDeviceName;
  private TextBox txtDeviceId;
  private Label label2;
  private Label label1;
  public DataGridView dtgvAcc;
  private Button button3;
  private Button btnLoadDevice;
  private StatusStrip statusStrip1;
  private ToolStripStatusLabel toolStripStatusLabel4;
  private ToolStripStatusLabel lblCountHighline;
  private ToolStripStatusLabel toolStripStatusLabel5;
  private ToolStripStatusLabel lblCountSelect;
  private ToolStripStatusLabel toolStripStatusLabel7;
  private ToolStripStatusLabel lblCountTotal;
  private MetroContextMenu ctmsAcc;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem liveToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem toolStripMenuItem1;
  private ToolStripMenuItem toolStripMenuItem_3;
  private ToolStripMenuItem toolStripMenuItem_4;
  private Button btnCancel;
  private Button btnSave;
  private Button button4;
  private ToolStripMenuItem closeScreenToolStripMenuItem;
  private NumericUpDown nudSort;
  private ToolStripMenuItem toolStripMenuItem_5;
  private ToolStripMenuItem rebootPhoneToolStripMenuItem;
  private Button button5;
  private TextBox txtCmd;
  private Button button6;
  private Button button7;
  private DataGridViewCheckBoxColumn cChose;
  private DataGridViewTextBoxColumn cStt;
  private DataGridViewTextBoxColumn cDeviceId;
  private DataGridViewTextBoxColumn cOs;
  private DataGridViewTextBoxColumn cDeviceName;
  private DataGridViewTextBoxColumn cStatus;
  private DataGridViewTextBoxColumn cPort;
  private DataGridViewTextBoxColumn cSystemPort;
  private DataGridViewTextBoxColumn cSize;
  private ToolStripMenuItem toolStripMenuItem6;
  private MetroButton BtnSearch;
  private BunifuCustomTextbox txbSearch;
  private ToolStripMenuItem toolStripMenuItem8;
  private ToolStripMenuItem toolStripMenuItem_6;
  private ToolStripMenuItem setScreeToolStripMenuItem;
  private ToolStripMenuItem setScreenBrightness100ToolStripMenuItem;
  private ToolStripMenuItem lockScreenToolStripMenuItem;
  private ToolStripMenuItem unlockScreenToolStripMenuItem;
  private ToolStripMenuItem sleepDEviceToolStripMenuItem;
  private ToolStripMenuItem gPSToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem4;
  private ToolStripMenuItem toolStripMenuItem5;
  private ToolStripMenuItem wifiToolStripMenuItem;
  private ToolStripMenuItem connectWifiToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem3;
  private ToolStripMenuItem toolStripMenuItem_7;
  private ToolStripMenuItem setMediaVolumn0ToolStripMenuItem;
  private ToolStripMenuItem disableBluetoothToolStripMenuItem;
  private ToolStripMenuItem disableRotateScreenToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_8;
  private GroupBox groupBox2;
  private CheckBox ckbSwitchADBKeyboard;
  private Button btnSetupPhone;
  private CheckBox ckbReboot;
  private CheckBox ckbSetupMaxChange;
  private CheckBox ckbSetupMaxHelper;
  private CheckBox ckbInstallFacebook;
  private CheckBox ckbSetupLanguageEnglish;
  private CheckBox ckbSetupPhone;
  private GroupBox groupBox3;
  private Button button2;
  private Button button1;
  private ToolStripMenuItem toolStripMenuItem_9;
  private ToolStripMenuItem toolStripMenuItem_10;
  private ToolStripMenuItem grantShellMagiskToolStripMenuItem;
  private NumericUpDown nudThreadPhone;
  private Label label6;
  private ToolStripMenuItem checkAboutPhoneToolStripMenuItem;
  private CheckBox ckbChinhAmThanh0;
  private CheckBox ckbTatBluetooth;
  private CheckBox ckbTatGPS;
  private CheckBox ckbChinhDoSang0;
  private Label label3;
  private CheckBox ckbTatWifi;
  private ToolStripMenuItem toolStripMenuItem9;
  private ToolStripMenuItem setupIPChoSim4GToolStripMenuItem;
  private ToolStripMenuItem iPv4ToolStripMenuItem;
  private ToolStripMenuItem iPv6ToolStripMenuItem;
  private ToolStripMenuItem iPv4IPv6ToolStripMenuItem;
  private ToolStripMenuItem facebookToolStripMenuItem;
  private ToolStripMenuItem maxHelperToolStripMenuItem;
  private ToolStripMenuItem maxChangeToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_11;
  private ToolStripMenuItem facebookToolStripMenuItem1;
  private ToolStripMenuItem maxChangeToolStripMenuItem1;
  private ToolStripMenuItem shutdownPhoneToolStripMenuItem;
  private ToolStripMenuItem facebookToolStripMenuItem2;
  private ToolStripMenuItem backupDataToolStripMenuItem;
  private ToolStripMenuItem getTokenToolStripMenuItem;
  private ToolStripMenuItem getCookieToolStripMenuItem;
  private ToolStripMenuItem getUidToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_12;
  private ToolStripMenuItem appiumToolStripMenuItem;
  private ToolStripMenuItem connectAppiumToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem11;
  private ToolStripMenuItem toolStripMenuItem_13;
  private ToolStripMenuItem switchADBKeyboardToolStripMenuItem;
  private ToolStripMenuItem setupLanguageEnglishToolStripMenuItem;
  private ToolStripMenuItem clearDataAppFbToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_14;
  private ToolStripMenuItem toolStripMenuItem_15;
  private ToolStripMenuItem toolStripMenuItem_16;
  private ToolStripMenuItem collectProxyToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_17;
  private NumericUpDown nudPercentDoSang;
  private Label lblPercentDoSang;
  private ToolStripMenuItem tCPIPToolStripMenuItem;
  private ToolStripMenuItem proxyToolStripMenuItem;
  private ToolStripMenuItem xToolStripMenuItem;
  private ToolStripMenuItem removeProxyToolStripMenuItem;
  private ToolStripMenuItem checkIPToolStripMenuItem;
  private ToolStripMenuItem checkProxyToolStripMenuItem;
  private ToolStripMenuItem toolStripMenuItem_18;
  private IContainer components;
  private CheckBox ckbonflashlightsuper;
  private CheckBox ckboffflashlightsuper;
  private CheckBox ckbPowerpin;
  private CheckBox ckbIpcheck;
  private CheckBox ckbOffmaybay;
  private CheckBox ckbOnmaybay;
  private ToolStripMenuItem toolStripMenuItem2;
  private GroupBox groupBox4;
  private Button button10;
  private Button button9;
  private Button button8;
  private Button button11;
  private Button button14;
  private Button button13;
  private Button button12;
  private Button button16;
  private Button button15;
  private Button button17;
  private Button button19;
  private Button button18;
  private CheckBox ckbGotoHome;
  private CheckBox ckbCloseAllApp;
  private NumericUpDown numdelayluong;
  private Label label4;
  private Label label5;
  private Button button20;
  private Button button25;
  private Button button24;
  private Button button23;
  private Button button22;
  private Button button21;
  private ToolStripMenuItem getInfoAccToolStripMenuItem;

  public fDeviceList()
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    GClass35.smethod_7(this.ctmsAcc);
    this.btnSave.Visible = false;
    this.btnCancel.Visible = false;
  }

  public fDeviceList(ref GClass22 gclass22_1)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.gclass22_0 = gclass22_1;
    GClass35.smethod_5((Control) this);
    GClass35.smethod_7(this.ctmsAcc);
  }

  private void method_0()
  {
    for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
      this.method_3(int_0, "cStt", (object) (int_0 + 1));
  }

  private void method_1()
  {
    try
    {
      this.lblCountTotal.Text = this.dtgvAcc.RowCount.ToString();
    }
    catch
    {
    }
  }

  private void method_2(int int_0 = -1)
  {
    if (int_0 == -1)
    {
      int_0 = 0;
      for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
      {
        if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
          ++int_0;
      }
    }
    this.lblCountSelect.Text = int_0.ToString();
  }

  public void method_3(int int_0, string string_0, object object_1, bool bool_0 = true)
  {
    if (!bool_0 && object_1.ToString().Trim() == "")
      return;
    Class14.Status(this.dtgvAcc, int_0, string_0, object_1);
  }

  public string method_4(int int_0, string string_0) => Class14.smethod_3(this.dtgvAcc, int_0, string_0);

  private void method_5(string string_0)
  {
    switch (string_0)
    {
      case "ToggleCheck":
        for (int index1 = 0; index1 < this.dtgvAcc.SelectedRows.Count; ++index1)
        {
          int index2 = this.dtgvAcc.SelectedRows[index1].Index;
          this.method_3(index2, "cChose", (object) !Convert.ToBoolean(this.method_4(index2, "cChose")));
        }
        this.method_2();
        break;
      case "SelectHighline":
        DataGridViewSelectedRowCollection selectedRows = this.dtgvAcc.SelectedRows;
        for (int index = 0; index < selectedRows.Count; ++index)
          this.method_3(selectedRows[index].Index, "cChose", (object) true);
        this.method_2();
        break;
      case "UnAll":
        for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
          this.method_3(int_0, "cChose", (object) false);
        this.method_2(0);
        break;
      case "All":
        for (int int_0 = 0; int_0 < this.dtgvAcc.RowCount; ++int_0)
          this.method_3(int_0, "cChose", (object) true);
        this.method_2(this.dtgvAcc.RowCount);
        break;
    }
  }

  private void btnClose_Click(object sender, EventArgs e)
  {
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      DataGridViewRow row = this.dtgvAcc.Rows[index];
      string string_1 = row.Cells["cDeviceId"].Value.ToString();
      string object_0 = row.Cells["cDeviceName"].Value.ToString();
      GClass33.smethod_0("device").method_6(string_1, (object) object_0);
    }
    GClass33.smethod_2("device");
    this.Close();
  }

  protected override void OnLoad(EventArgs e) => Application.Idle += new EventHandler(this.method_6);

  private void method_6(object sender, EventArgs e)
  {
    Application.Idle -= new EventHandler(this.method_6);
    this.btnSave.Enabled = false;
    this.btnCancel.Enabled = false;
    this.method_7();
  }

  private void method_7()
  {
    GClass7.smethod_1("adb devices", 5);
    List<string> stringList = GClass7.smethod_0();
    List<string> range = stringList.GetRange(0, Class54.int_1 > stringList.Count ? stringList.Count : Class54.int_1);
    this.dtgvAcc.Rows.Clear();
    string string_0 = "";
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string string_2 = "";
    string string_1 = "";
    foreach (string string_1_1 in range)
    {
      string_0 = GClass33.smethod_0("device").method_1(string_1_1);
      this.dtgvAcc.Rows.Add((object) true, (object) (this.dtgvAcc.RowCount + 1), (object) string_1_1, (object) string_1, (object) string_0, (object) str1, (object) str2, (object) str3, (object) string_2);
    }
    this.method_1();
    this.method_2(this.dtgvAcc.RowCount);
    new Thread((ThreadStart) (() =>
    {
      try
      {
        List<Thread> threadList = new List<Thread>();
        for (int index1 = 0; index1 < this.dtgvAcc.RowCount; ++index1)
        {
          int int_0 = index1;
          Thread thread = new Thread((ThreadStart) (() =>
          {
            Class14.Status(this.dtgvAcc, int_0, "cStatus", (object) "Load info...");
            string str5 = Class14.smethod_3(this.dtgvAcc, int_0, "cDeviceId");
            for (int index2 = 0; index2 < 10; ++index2)
            {
              string input = GClass7.smethod_1("adb -s " + str5 + " shell \"settings get global device_name && getprop ro.build.version.release && dumpsys display\"");
              if (input != "")
              {
                try
                {
                  string_0 = Class14.smethod_3(this.dtgvAcc, int_0, "cDeviceName");
                  if (string_0 == "")
                  {
                    string_0 = input.Split('\n')[0];
                    Class14.Status(this.dtgvAcc, int_0, "cDeviceName", (object) string_0);
                  }
                  string_1 = input.Split('\n')[1];
                  string_2 = Regex.Match(Regex.Match(input, "deviceWidth=\\d+").Value, "\\d+").Value + "x" + Regex.Match(Regex.Match(input, "deviceHeight=\\d+").Value, "\\d+").Value;
                  Class14.Status(this.dtgvAcc, int_0, "cOs", (object) string_1);
                  Class14.Status(this.dtgvAcc, int_0, "cSize", (object) string_2);
                  break;
                }
                catch (Exception ex)
                {
                  break;
                }
              }
              else
                Thread.Sleep(1000);
            }
            Class14.Status(this.dtgvAcc, int_0, "cStatus", (object) "");
          }));
          lock (threadList)
            threadList.Add(thread);
          thread.IsBackground = true;
          thread.Start();
        }
        for (int index = 0; index < threadList.Count; ++index)
          threadList[index].Join();
        this.Invoke((Delegate) (() =>
        {
          this.btnSave.Enabled = true;
          this.btnCancel.Enabled = true;
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

  private void btnLoadDevice_Click(object sender, EventArgs e) => this.method_7();

  private void btnUpdateDeviceName_Click(object sender, EventArgs e)
  {
    string string_1 = this.txtDeviceId.Text.Trim();
    if (string_1 == "")
    {
      GClass14.smethod_0((object) "Vui lòng chọn Device!");
    }
    else
    {
      string object_0 = this.txtDeviceName.Text.Trim();
      if (object_0 == "")
      {
        GClass14.smethod_0((object) "Vui lòng nhập Device Name!");
      }
      else
      {
        GClass33.smethod_0("device").method_6(string_1, (object) object_0);
        GClass33.smethod_2("device");
        GClass7.smethod_1("adb -s " + string_1 + " shell settings put global device_name \"" + object_0 + "\"");
        foreach (DataGridViewRow row in (IEnumerable) this.dtgvAcc.Rows)
        {
          if (row.Cells["cDeviceId"].Value.ToString() == string_1)
          {
            row.Cells["cDeviceName"].Value = (object) object_0;
            break;
          }
        }
      }
    }
  }

  private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (this.dtgvAcc.RowCount == 0 || this.dtgvAcc.SelectedRows.Count == 0)
      return;
    if (e.ColumnIndex == 0)
    {
      try
      {
        this.dtgvAcc.CurrentRow.Cells["cChose"].Value = (object) !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells["cChose"].Value);
      }
      catch
      {
      }
      this.method_2();
    }
    else
    {
      DataGridViewRow selectedRow = this.dtgvAcc.SelectedRows[0];
      string str1 = selectedRow.Cells["cDeviceId"].Value.ToString();
      string str2 = selectedRow.Cells["cDeviceName"].Value.ToString();
      this.txtDeviceId.Text = str1;
      this.txtDeviceName.Text = str2;
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
    this.method_2();
  }

  private void dtgvAcc_SelectionChanged(object sender, EventArgs e) => this.lblCountHighline.Text = this.dtgvAcc.SelectedRows.Count.ToString();

  private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyValue != 32)
      return;
    this.method_5("ToggleCheck");
  }

  private void toolStripMenuItem_1_Click(object sender, EventArgs e) => this.method_5("All");

  private void liveToolStripMenuItem_Click(object sender, EventArgs e) => this.method_5("SelectHighline");

  private void toolStripMenuItem_2_Click(object sender, EventArgs e) => this.method_5("UnAll");

  private void toolStripMenuItem_4_Click(object sender, EventArgs e) => this.method_7();

  private void toolStripMenuItem_3_Click(object sender, EventArgs e)
  {
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        this.dtgvAcc.Rows.RemoveAt(index--);
    }
    this.method_0();
    this.method_1();
    this.method_2(0);
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    List<string> list_0 = new List<string>();
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        list_0.Add(this.method_4(index, "cDeviceId"));
    }
    this.gclass22_0.method_8("lstDeviceId", list_0);
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void method_8(object sender, EventArgs e)
  {
  }

  private void toolStripMenuItem1_Click(object sender, EventArgs e) => new Thread((ThreadStart) (() =>
  {
    List<string> list_0 = this.method_15().Select<Process, string>((Func<Process, string>) (process_0 => process_0.MainWindowTitle.Split('|')[1])).ToList<string>();
    List<Thread> threadList = new List<Thread>();
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
      {
        int int_0 = index;
        Thread thread = new Thread((ThreadStart) (() =>
        {
          string string_0 = this.method_4(int_0, "cDeviceId");
          if (!list_0.Contains(string_0))
          {
            this.method_10(int_0, "Show screen...");
            this.method_9(int_0, string_0);
          }
          this.method_10(int_0, "Show screen done!");
        }));
        threadList.Add(thread);
        thread.IsBackground = true;
        thread.Start();
      }
    }
    foreach (Thread thread in threadList)
      thread.Join();
    this.button4_Click((object) null, (EventArgs) null);
  }))
  {
    IsBackground = true
  }.Start();

  private void method_9(int int_0, string string_0 = "", string string_1 = "")
  {
    string str1 = this.method_4(int_0, "cSize");
    if (string_0 == "")
      string_0 = this.method_4(int_0, "cDeviceId");
    string str2 = "MaxFarm|" + string_0 + "|" + str1 + "|" + string_1;
    string string_0_1 = "scrcpy -s " + string_0 + " --window-title=\"" + str2 + "\"";
    lock (this.object_0)
      GClass7.smethod_1(string_0_1, 1);
    for (int index = 0; index < 30 && ((IEnumerable<Process>) Process.GetProcessesByName("scrcpy")).Where<Process>((Func<Process, bool>) (process_0 => process_0.MainWindowTitle.Contains(string_0))).Count<Process>() <= 0; ++index)
      GClass19.smethod_64(1.0);
  }

  public void method_10(int int_0, string string_0) => Class14.Status(this.dtgvAcc, int_0, "cStatus", (object) string_0);

  private void button4_Click(object sender, EventArgs e) => this.method_11();

  private void method_11(int int_0 = 0)
  {
    List<Process> list_0 = this.method_15();
    if (int_0 == 0)
      int_0 = Convert.ToInt32(this.nudSort.Value);
    GClass19.smethod_104(list_0, int_0);
  }

  private void closeScreenToolStripMenuItem_Click(object sender, EventArgs e)
  {
    List<int> intList = this.method_12();
    List<Process> processList = this.method_15();
    foreach (int int_0 in intList)
    {
      this.method_10(int_0, "Close screen...");
      string str = this.method_4(int_0, "cDeviceId");
      for (int index = 0; index < processList.Count; ++index)
      {
        if (processList[index].MainWindowTitle.Split('|')[1] == str)
        {
          processList[index].Kill();
          break;
        }
      }
      this.method_10(int_0, "Close screen done!");
    }
  }

  public List<int> method_12()
  {
    List<int> intList = new List<int>();
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
        intList.Add(index);
    }
    return intList;
  }

  private void method_13(List<string> list_0)
  {
    try
    {
      Queue<string> queue_0 = new Queue<string>();
      Queue<string> queue_1 = new Queue<string>();
      string string_1 = "";
      int int_0 = 0;
      if (list_0.Contains("ConnectWifi"))
      {
        fNhapWifi fNhapWifi = new fNhapWifi();
        int num = (int) fNhapWifi.ShowDialog();
        List<string> stringList = new List<string>((IEnumerable<string>) fNhapWifi.list_0);
        int int0 = fNhapWifi.int_0;
        for (int index1 = 0; index1 < stringList.Count; ++index1)
        {
          for (int index2 = 0; index2 < int0; ++index2)
            queue_1.Enqueue(stringList[index1]);
        }
        if (queue_1.Count == 0)
          return;
      }
      if (list_0.Contains("ConnectProxy"))
      {
        fNhapProxy fNhapProxy = new fNhapProxy();
        int num = (int) fNhapProxy.ShowDialog();
        List<string> stringList = new List<string>((IEnumerable<string>) fNhapProxy.list_0);
        int int0 = fNhapProxy.int_0;
        for (int index3 = 0; index3 < stringList.Count; ++index3)
        {
          for (int index4 = 0; index4 < int0; ++index4)
            queue_0.Enqueue(stringList[index3]);
        }
        if (queue_0.Count == 0)
          return;
      }
      else if (list_0.Contains("InstallAppApk"))
      {
        string_1 = GClass19.smethod_46("Select apk file", "apk Files (*.apk)|*.apk|");
        if (string.IsNullOrEmpty(string_1))
          return;
      }
      else if (list_0.Contains("SetScreenBrightness"))
        int_0 = Convert.ToInt32(this.nudPercentDoSang.Value);
      else if (list_0.Contains("CaiRoom") && string.IsNullOrEmpty(GClass19.smethod_45("Vui lòng chọn thư mục chức các file cài rom!")))
      {
        GClass14.smethod_0((object) "Folder chứa file cài rom không hợp lệ!", 3);
        return;
      }
      List<string> list_2 = new List<string>();
      List<string> list_ = new List<string>();
      List<string> list_3 = new List<string>();
      List<string> list_4 = new List<string>();
      new Thread((ThreadStart) (() =>
      {
        try
        {
          this.btnSetupPhone.Invoke((Delegate) (() => this.btnSetupPhone.Enabled = false));
          int int32_1 = Convert.ToInt32(this.nudThreadPhone.Value);
          int int32_2 = Convert.ToInt32(this.numdelayluong.Value);
          List<Thread> threadList = new List<Thread>();
          int index5 = 0;
          while (index5 < this.dtgvAcc.RowCount)
          {
            Thread.Sleep(int32_2);
            if (Convert.ToBoolean(this.dtgvAcc.Rows[index5].Cells["cChose"].Value))
            {
              if (threadList.Count < int32_1)
              {
                int int_ = index5++;
                Thread thread = new Thread((ThreadStart) (() =>
                {
                  try
                  {
                    string string_11_5 = Class14.smethod_3(this.dtgvAcc, int_, "cDeviceId");
                    GClass27 gclass27 = new GClass27(string_11_5);
                    if (!list_0.Contains("CaiRoom"))
                      gclass27.method_69();
                    foreach (string s in list_0)
                    {
                      // ISSUE: reference to a compiler-generated method
                      switch (Class206.smethod_0(s))
                      {
                        case 167256686:
                          if (s == "TurnOnDoNotDisturb")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Turn On Do Not Disturb...");
                              if (!gclass27.method_171())
                                this.method_10(int_, "Turn On Do Not Disturb error!");
                              else
                                this.method_10(int_, "Turn On Do Not Disturb success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 182041460:
                          if (s == "InstallFacebook")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Install App Facebook...");
                            gclass27.method_177(GClass13.smethod_0() + "\\app\\facebook.apk");
                            this.method_10(int_, "Install App Facebook done!");
                            break;
                          }
                          break;
                        case 233719247:
                          if (s == "ConnectProxy")
                          {
                            string string_11_6 = "";
                            lock (queue_0)
                            {
                              if (queue_0.Count > 0)
                                string_11_6 = queue_0.Dequeue();
                            }
                            int num;
                            if (!string.IsNullOrEmpty(string_11_6))
                              num = string_11_6.Split(':').Length < 2 ? 1 : 0;
                            else
                              num = 1;
                            if (num != 0)
                            {
                              this.method_10(int_, "Empty Proxy!");
                            }
                            else
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect Proxy...");
                              gclass27.method_3(0, string_11_6);
                              gclass27.method_5();
                              this.method_10(int_, "Connect Proxy done!");
                            }
                            break;
                          }
                          break;
                        case 235936044:
                          if (s == "SetImageScreen")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Set Image Screen...");
                              string string_11_7 = GClass13.smethod_0() + "\\screen.jpg";
                              if (gclass27.method_70(string_11_7))
                                this.method_10(int_, "Set Image Screen success!");
                              else
                                this.method_10(int_, "Set Image Screen fail!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 246580341:
                          if (s == "ClearDataAppFb")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Clear Data App Fb...");
                            gclass27.Cleardata("com.facebook.katana");
                            this.method_10(int_, "Clear Data App Fb done!");
                            break;
                          }
                          break;
                        case 302565059:
                          if (s == "CaiRoom")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Format data...");
                            gclass27.CMD_Recovery("shell reboot recovery");
                            gclass27.CMD_Recovery("wait-for-recovery");
                            gclass27.CMD_Recovery("shell twrp format data");
                            gclass27.CMD_Recovery("shell twrp wipe data");
                            Thread.Sleep(2000);
                            gclass27.CMD_Recovery("shell twrp wipe cache");
                            Thread.Sleep(2000);
                            gclass27.CMD_Recovery("shell twrp wipe dalvik");
                            Thread.Sleep(2000);
                            gclass27.CMD_Recovery("shell twrp wipe system");
                            Thread.Sleep(2000);
                            gclass27.CMD_Recovery("shell reboot -p");
                            break;
                          }
                          break;
                        case 405494823:
                          if (s == "Offflashlightsuper")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Off Flashlight success");
                            gclass27.CMD("shell pm clear -p com.flashlightsuper.tung.flashlight -c android.intent.category.LAUNCHER 1");
                            break;
                          }
                          break;
                        case 534342326:
                          if (s == "SetupAPNIpv64")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Setup APN IPv4/IPv6...");
                              if (!gclass27.method_169(3))
                                this.method_10(int_, "Setup APN IPv4/IPv6 error!");
                              else
                                this.method_10(int_, "Setup APN IPv4/IPv6 success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 559028923:
                          if (s == "TestChangeDevice")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Test Change Info Device...");
                            if (!gclass27.method_83())
                              this.method_10(int_, "Test Change Info Device error!");
                            else
                              this.method_10(int_, "Test Change Info Device success: " + gclass27.string_9 + "!");
                            break;
                          }
                          break;
                        case 608371527:
                          if (s == "BackupData")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Backup data...");
                            string string_11_8 = Regex.Match(gclass27.method_114().Split('|')[1] + ";", "c_user=(.*?);").Groups[1].Value;
                            if (!string.IsNullOrEmpty(string_11_8))
                            {
                              gclass27.method_96(string_11_8);
                              gclass27.method_94(string_11_8);
                              this.method_10(int_, "Backup data done!");
                            }
                            else
                              this.method_10(int_, "Chưa có dữ liệu app!");
                            break;
                          }
                          break;
                        case 800854409:
                          if (s == "GotoHome")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Back to Home...");
                            gclass27.CMD("shell input keyevent 3");
                            this.method_10(int_, "Back to Home done!");
                            break;
                          }
                          break;
                        case 806866399:
                          if (s == "SwitchADBKeyboard")
                          {
                            if (!gclass27.method_175().Contains("com.android.adbkeyboard"))
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Install ADBKeyboard...");
                              gclass27.method_177(GClass13.smethod_0() + "\\app\\ADBKeyboard.apk");
                              gclass27.SleepSeconds(3.0);
                            }
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Switch ADBKeyboard...");
                            gclass27.method_43();
                            this.method_10(int_, "Switch ADBKeyboard done!");
                            break;
                          }
                          break;
                        case 956551262:
                          if (s == "InstallCollectProxy")
                          {
                            if (!gclass27.method_175().Contains("com.cell47.College_Proxy"))
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Install Collect Proxy...");
                              gclass27.method_177(GClass13.smethod_0() + "\\app\\collegeproxy.apk");
                              gclass27.SleepSeconds(3.0);
                            }
                            this.method_10(int_, "Install Collect Proxy done!");
                            break;
                          }
                          break;
                        case 1047122316:
                          if (s == "GetToken")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Get token...");
                            list_.Add(gclass27.method_114().Split('|')[0]);
                            this.method_10(int_, "Get token done!");
                            break;
                          }
                          break;
                        case 1235976407:
                          if (s == "RunAdb")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Run CMD...");
                            this.method_10(int_, "Run CMD done: " + GClass7.smethod_1(this.txtCmd.Text.Trim().Replace("adb shell", "adb -s " + string_11_5 + " shell")));
                            break;
                          }
                          break;
                        case 1262234977:
                          if (s == "UnlockScreen")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Unlock Screen...");
                            gclass27.method_69();
                            this.method_10(int_, "Unlock Screen done!");
                            break;
                          }
                          break;
                        case 1277276552:
                          if (s == "OpenLinkRegFbApp")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Open Link App Fb Reg...");
                            gclass27.method_105("fb://registration com.facebook.katana");
                            this.method_10(int_, "Open Link App Fb Reg done!");
                            break;
                          }
                          break;
                        case 1307834249:
                          if (s == "OnSleepDevice")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Bật màn hình...");
                            gclass27.bật_màn_hình();
                            this.method_10(int_, "Bật màn hình xong!");
                            break;
                          }
                          break;
                        case 1322488540:
                          if (s == "SetupLanguageEnglish")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Setup Language English...");
                              if (!gclass27.method_148())
                                this.method_10(int_, "Setup Language English error!");
                              else
                                this.method_10(int_, "Setup Language English success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 1397455650:
                          if (s == "SleepDevice")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Tắt màn hình...");
                            gclass27.method_59();
                            this.method_10(int_, "Tắt màn hình xong");
                            break;
                          }
                          break;
                        case 1551546560:
                          if (s == "SetupMaxChange")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Setup MaxChange...");
                              if (!gclass27.method_143())
                                this.method_10(int_, "Setup MaxChange error!");
                              else
                                this.method_10(int_, "Setup MaxChange success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 1572897075:
                          if (s == "InstallAppApk")
                          {
                            string withoutExtension = Path.GetFileNameWithoutExtension(string_1);
                            this.method_10(int_, "Install app " + withoutExtension + "...");
                            string str = gclass27.method_177(string_1) ? "success!" : "fail!";
                            this.method_10(int_, "Install app " + withoutExtension + " " + str);
                            break;
                          }
                          break;
                        case 1705577625:
                          if (s == "ShutdownPhone")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Shutdown phone...");
                            gclass27.method_45();
                            this.method_10(int_, "Shutdown phone done!");
                            break;
                          }
                          break;
                        case 1729695734:
                          if (s == "GetInfoAccount")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Get info account...");
                            list_2.Add(gclass27.method_115());
                            this.method_10(int_, "Get info account done!");
                            break;
                          }
                          break;
                        case 1729794211:
                          if (s == "DisableBluetooth")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Disable Bluetooth...");
                            gclass27.CMD("shell content insert --uri content://settings/global --bind name:s:bluetooth_disabled_profiles --bind value:s:1 --user 0");
                            gclass27.CMD("shell content insert --uri content://settings/global --bind name:s:bluetooth_disabled_profiles --bind value:s:0 --user 0");
                            this.method_10(int_, "Disable Bluetooth done!");
                            break;
                          }
                          break;
                        case 1775679933:
                          if (s == "CloseAllApp")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Close All App...");
                            gclass27.CloseAllApp();
                            this.method_10(int_, "Close All App done!");
                            break;
                          }
                          break;
                        case 1940586651:
                          if (s == "GetUid")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Get uid...");
                            list_4.Add(gclass27.method_116());
                            this.method_10(int_, "Get uid done!");
                            break;
                          }
                          break;
                        case 1975013645:
                          if (s == "SwitchAndroidKeyboard")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Switch Android Keyboard...");
                            gclass27.CMD("shell ime reset");
                            this.method_10(int_, "Switch Android Keyboard done!");
                            break;
                          }
                          break;
                        case 2145994693:
                          if (s == "ConnectTCPIP")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Open port 5555...");
                            gclass27.CMD("tcpip 5555");
                            gclass27.SleepSeconds(1.0);
                            string str = Regex.Match(gclass27.CMD("shell ip -f inet addr show wlan0"), "inet (192.168.*?)/").Groups[1].Value;
                            if (str == "")
                              str = Regex.Match(gclass27.CMD("shell ip addr show wlan0"), "inet (192.168.*?)/").Groups[1].Value;
                            if (str.StartsWith("192.168"))
                            {
                              GClass7.smethod_1("adb connect " + str + ":5555");
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect TCP/IP success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect TCP/IP fail!");
                            break;
                          }
                          break;
                        case 2292505168:
                          if (s == "CheckAboutPhone")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Check About Phone...");
                            gclass27.CMD("shell am start -a android.settings.DEVICE_INFO_SETTINGS");
                            this.method_10(int_, "Check About Phone done!");
                            break;
                          }
                          break;
                        case 2384903374:
                          if (s == "CheckIP")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Checking...");
                            this.method_10(int_, "IP: " + gclass27.method_162());
                            break;
                          }
                          break;
                        case 2405539795:
                          if (s == "Onmaybay")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "On AIRPLANE success");
                            gclass27.CMD("shell su -c 'input keyevent KEYCODE_WAKEUP;input keyevent KEYCODE_MOVE_HOME;settings put global airplane_mode_on 1;am broadcast -a android.intent.action.AIRPLANE_MODE --ez state true'");
                            break;
                          }
                          break;
                        case 2436690727:
                          if (s == "DisconnectAppium")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Disconnect Appium...");
                            if (gclass27.method_17())
                              this.method_10(int_, "Disconnect Appium success!");
                            else
                              this.method_10(int_, "Disconnect Appium error!");
                            break;
                          }
                          break;
                        case 2448776107:
                          if (s == "SetupDarkTheme")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Set Dark Theme...");
                              if (gclass27.method_173())
                                this.method_10(int_, "Set Dark Theme success!");
                              else
                                this.method_10(int_, "Set Dark Theme fail!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 2498704372:
                          if (s == "DisableRotateScreen")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Disable Rotate Screen...");
                            gclass27.CMD("shell content insert --uri content://settings/system --bind name:s:accelerometer_rotation --bind value:i:0");
                            this.method_10(int_, "Disable Rotate Screen done!");
                            break;
                          }
                          break;
                        case 2503827719:
                          if (s == "SetScreenBrightness100")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Set Screen Brightness 100...");
                            gclass27.CMD("shell settings put system screen_brightness 100");
                            this.method_10(int_, "Set Screen Brightness 100 done!");
                            break;
                          }
                          break;
                        case 2510216622:
                          if (s == "DisconnectWifi")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Disconnect Wifi...");
                            gclass27.method_156();
                            this.method_10(int_, "Disconnect Wifi done!");
                            break;
                          }
                          break;
                        case 2511328770:
                          if (s == "CheckIPBrowser")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Checking...");
                            gclass27.method_164("https://whoer.net/");
                            this.method_10(int_, "Done!");
                            break;
                          }
                          break;
                        case 2620050926:
                          if (s == "SetMediaVolumn0")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Set Volumn 0...");
                            gclass27.method_39();
                            this.method_10(int_, "Set Volumn 0 done!");
                            break;
                          }
                          break;
                        case 2626442577:
                          if (s == "SetupLTE")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Setup LTE...");
                              if (!gclass27.method_170())
                                this.method_10(int_, "Setup LTE error!");
                              else
                                this.method_10(int_, "Setup LTE success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 2657326995:
                          if (s == "RemoveProxy")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Remove Proxy...");
                            gclass27.RemoveProxy();
                            this.method_10(int_, "Remove Proxy done!");
                            break;
                          }
                          break;
                        case 2768609833:
                          if (s == "GrantShellMagisk")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Grant Shell Magisk...");
                              if (!gclass27.method_144())
                                this.method_10(int_, "Grant Shell Magisk error!");
                              else
                                this.method_10(int_, "Grant Shell Magisk success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 2838707365:
                          if (s == "UninstallFacebook")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Uninstall Facebook...");
                            gclass27.method_49("com.facebook.katana");
                            this.method_10(int_, "Uninstall Facebook done!");
                            break;
                          }
                          break;
                        case 3152277728:
                          if (s == "SetupAPNIpv4")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Setup APN IPv4...");
                              if (!gclass27.method_169(1))
                                this.method_10(int_, "Setup APN IPv4 error!");
                              else
                                this.method_10(int_, "Setup APN IPv4 success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 3182348741:
                          if (s == "UninstallMaxChange")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Uninstall MaxChange...");
                            gclass27.method_49("com.minsoftware.maxchanger");
                            this.method_10(int_, "Uninstall MaxChange done!");
                            break;
                          }
                          break;
                        case 3185832966:
                          if (s == "SetupAPNIpv6")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Setup APN IPv6...");
                              if (!gclass27.method_169(2))
                                this.method_10(int_, "Setup APN IPv6 error!");
                              else
                                this.method_10(int_, "Setup APN IPv6 success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 3197447325:
                          if (s == "OpenLink")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Open Link...");
                            gclass27.method_105("");
                            this.method_10(int_, "Open Link done!");
                            break;
                          }
                          break;
                        case 3253004420:
                          if (s == "SetScreenBrightness")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) string.Format("Set Screen Brightness {0}...", (object) int_0));
                            gclass27.CMD("shell settings put system screen_brightness " + int_0.ToString());
                            this.method_10(int_, string.Format("Set Screen Brightness {0} done!", (object) int_0));
                            break;
                          }
                          break;
                        case 3290444158:
                          if (s == "LockScreen")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Lock Screen...");
                            gclass27.method_71();
                            this.method_10(int_, "Lock Screen done!");
                            break;
                          }
                          break;
                        case 3360347734:
                          if (s == "EnableGPS")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Enable GPS...");
                            gclass27.method_159();
                            this.method_10(int_, "Enable GPS done!");
                            break;
                          }
                          break;
                        case 3409819269:
                          if (s == "DisableGPS")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Disable GPS...");
                            gclass27.method_158();
                            this.method_10(int_, "Disable GPS done!");
                            break;
                          }
                          break;
                        case 3467468877:
                          if (s == "ConnectAppium")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect Appium...");
                            if (gclass27.method_1() != "")
                              this.method_10(int_, "Connect Appium success!");
                            else
                              this.method_10(int_, "Connect Appium error!");
                            break;
                          }
                          break;
                        case 3592550948:
                          if (s == "TestChange4G")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Test Change 4G...");
                            if (!gclass27.method_160())
                              this.method_10(int_, "Test Change 4G error!");
                            else
                              this.method_10(int_, "Test Change 4G success (IP: " + gclass27.method_162() + ")!");
                            break;
                          }
                          break;
                        case 3596430294:
                          if (s == "TurnOnWifi")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Turn on Wifi...");
                            gclass27.method_157();
                            this.method_10(int_, "Turn on done!");
                            break;
                          }
                          break;
                        case 3742098196:
                          if (s == "RebootPhone")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Reboot...");
                            gclass27.method_44();
                            this.method_10(int_, "Reboot done!");
                            break;
                          }
                          break;
                        case 3747044426:
                          if (s == "SetPin")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Set pin success");
                            gclass27.CMD("shell dumpsys battery set level 100");
                            break;
                          }
                          break;
                        case 3829046025:
                          if (s == "GetCookie")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Get cookie...");
                            list_3.Add(gclass27.method_114().Split('|')[1]);
                            this.method_10(int_, "Get cookie done!");
                            break;
                          }
                          break;
                        case 4005589112:
                          if (s == "SetupMaxHelper")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone...");
                            if (gclass27.method_1() != "")
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Setup MaxHelper...");
                              if (!gclass27.method_145())
                                this.method_10(int_, "Setup MaxHelper error!");
                              else
                                this.method_10(int_, "Setup MaxHelper success!");
                            }
                            else
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect phone fail!");
                            break;
                          }
                          break;
                        case 4015674204:
                          if (s == "SetScreenBrightness0")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Set Screen Brightness 0...");
                            gclass27.CMD("shell settings put system screen_brightness 0");
                            this.method_10(int_, "Set Screen Brightness 0 done!");
                            break;
                          }
                          break;
                        case 4153227429:
                          if (s == "Onflashlightsuper")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "On Flashlight success");
                            gclass27.CMD("shell monkey -p com.flashlightsuper.tung.flashlight -c android.intent.category.LAUNCHER 1");
                            break;
                          }
                          break;
                        case 4233484065:
                          if (s == "Offmaybay")
                          {
                            Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Off AIRPLANE success");
                            gclass27.CMD("shell su -c 'input keyevent KEYCODE_WAKEUP;input keyevent KEYCODE_MOVE_HOME;settings put global airplane_mode_on 0;am broadcast -a android.intent.action.AIRPLANE_MODE --ez state true'");
                            break;
                          }
                          break;
                        case 4276991948:
                          if (s == "ConnectWifi")
                          {
                            string str = "";
                            lock (queue_1)
                            {
                              if (queue_1.Count > 0)
                                str = queue_1.Dequeue();
                            }
                            int num;
                            if (!string.IsNullOrEmpty(str))
                              num = str.Split('|').Length < 2 ? 1 : 0;
                            else
                              num = 1;
                            if (num != 0)
                            {
                              this.method_10(int_, "Empty Wifi!");
                            }
                            else
                            {
                              Class14.Status(this.dtgvAcc, int_, "cStatus", (object) "Connect Wifi...");
                              if (!gclass27.method_132(str.Split('|')[0], str.Split('|')[1]))
                                this.method_10(int_, "Connect Wifi error!");
                              else
                                this.method_10(int_, "Connect Wifi success!");
                            }
                            break;
                          }
                          break;
                      }
                    }
                  }
                  catch (Exception ex)
                  {
                  }
                }));
                lock (threadList)
                  threadList.Add(thread);
                thread.IsBackground = true;
                thread.Start();
              }
              else
              {
                for (int index6 = 0; index6 < threadList.Count; ++index6)
                {
                  if (!threadList[index6].IsAlive)
                    threadList.RemoveAt(index6--);
                }
              }
            }
            else
              ++index5;
          }
          for (int index7 = 0; index7 < threadList.Count; ++index7)
            threadList[index7].Join();
          this.btnSetupPhone.Invoke((Delegate) (() => this.btnSetupPhone.Enabled = true));
          if (list_0.Contains("GetInfoAccount"))
          {
            GClass19.smethod_26(string.Join("\n", (IEnumerable<string>) list_2));
            GClass14.smethod_0((object) "Dữ liệu info account đã được copy vào Clipboard!");
          }
          if (list_0.Contains("GetToken"))
          {
            GClass19.smethod_26(string.Join("\n", (IEnumerable<string>) list_));
            GClass14.smethod_0((object) "Dữ liệu token đã được copy vào Clipboard!");
          }
          if (list_0.Contains("GetCookie"))
          {
            GClass19.smethod_26(string.Join("\n", (IEnumerable<string>) list_3));
            GClass14.smethod_0((object) "Dữ liệu cookie đã được copy vào Clipboard!");
          }
          if (!list_0.Contains("GetUid"))
            return;
          GClass19.smethod_26(string.Join("\n", (IEnumerable<string>) list_4));
          GClass14.smethod_0((object) "Dữ liệu uid đã được copy vào Clipboard!");
        }
        catch
        {
        }
      }))
      {
        IsBackground = true
      }.Start();
    }
    catch (Exception ex)
    {
    }
  }

  private void rebootPhoneToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "RebootPhone"
  });

  private void method_14(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SwitchADBKeyboard"
  });

  private void clearDataAppFbToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "ClearDataAppFb"
  });

  private void toolStripMenuItem2_Click(object sender, EventArgs e)
  {
    GClass19.smethod_107();
    List<string> collection = (GClass19.smethod_106()[0] as fView).method_16();
    List<string> list = this.method_15().Select<Process, string>((Func<Process, string>) (process_0 => process_0.MainWindowTitle.Split('|')[1])).ToList<string>();
    list.AddRange((IEnumerable<string>) collection);
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      if (Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells["cChose"].Value))
      {
        int int_0 = index;
        string string_0 = this.method_4(int_0, "cDeviceId");
        if (!list.Contains(string_0))
        {
          this.method_10(int_0, "Show screen...");
          this.method_9(int_0, string_0);
        }
        this.method_10(int_0, "Show screen done!");
      }
    }
    List<Process> processList = this.method_15();
    for (int index = 0; index < processList.Count; ++index)
    {
      IntPtr mainWindowHandle = processList[index].MainWindowHandle;
      string string_0 = processList[index].MainWindowTitle.Split('|')[1];
      if (!collection.Contains(string_0))
        GClass19.smethod_109(mainWindowHandle, string_0);
    }
  }

  private List<Process> method_15() => ((IEnumerable<Process>) Process.GetProcessesByName("scrcpy")).Where<Process>((Func<Process, bool>) (process_0 => process_0.MainWindowTitle.StartsWith("MaxFarm|"))).ToList<Process>();

  private void maxChangeToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetupMaxChange"
  });

  private void button5_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "RunAdb"
  });

  private void setupLanguageEnglishToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetupLanguageEnglish"
  });

  private void button6_Click(object sender, EventArgs e)
  {
    int num1 = 1;
    for (int index = 0; index < this.dtgvAcc.RowCount; ++index)
    {
      DataGridViewRow row = this.dtgvAcc.Rows[index];
      int num2 = num1++;
      string string_1 = row.Cells["cDeviceId"].Value.ToString();
      string object_0 = "MaxFarm-" + num2.ToString();
      GClass7.smethod_1("adb -s " + string_1 + " shell settings put global device_name \"" + object_0 + "\"");
      GClass33.smethod_0("device").method_6(string_1, (object) object_0);
      row.Cells["cDeviceName"].Value = (object) object_0;
    }
    GClass33.smethod_2("device");
  }

  private void button3_Click(object sender, EventArgs e) => Class76.smethod_2();

  private void button7_Click(object sender, EventArgs e) => GClass7.smethod_3();

  private void toolStripMenuItem_11_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "InstallAppApk"
  });

  private void facebookToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "InstallFacebook"
  });

  private void BtnSearch_Click(object sender, EventArgs e)
  {
    try
    {
      string columnName = "cDeviceId";
      string str1 = this.txbSearch.Text.Trim();
      if (str1 == "")
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập deviceId cần tìm kiếm!"), 3);
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
    catch (Exception ex)
    {
    }
  }

  private void txbSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.BtnSearch_Click((object) null, (EventArgs) null);
  }

  private void maxHelperToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetupMaxHelper"
  });

  private void facebookToolStripMenuItem1_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "UninstallFacebook"
  });

  private void setScreeToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetScreenBrightness0"
  });

  private void setScreenBrightness100ToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetScreenBrightness100"
  });

  private void lockScreenToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "LockScreen"
  });

  private void unlockScreenToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "UnlockScreen"
  });

  private void sleepDEviceToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SleepDevice"
  });

  private void toolStripMenuItem4_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "DisableGPS"
  });

  private void toolStripMenuItem5_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "EnableGPS"
  });

  private void connectWifiToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "ConnectWifi"
  });

  private void toolStripMenuItem3_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "DisconnectWifi"
  });

  private void setMediaVolumn0ToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetMediaVolumn0"
  });

  private void disableBluetoothToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "DisableBluetooth"
  });

  private void disableRotateScreenToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "DisableRotateScreen"
  });

  private void connectAppiumToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "ConnectAppium"
  });

  private void toolStripMenuItem_14_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "GotoHome"
  });

  private void toolStripMenuItem_8_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "CloseAllApp"
  });

  private void ckbSetupMaxChange_CheckedChanged(object sender, EventArgs e)
  {
    this.ckbReboot.Enabled = !this.ckbSetupMaxChange.Checked;
    this.ckbReboot.Checked = this.ckbSetupMaxChange.Checked;
  }

  private void btnSetupPhone_Click(object sender, EventArgs e)
  {
    List<string> list_0 = new List<string>();
    if (this.ckbSwitchADBKeyboard.Checked)
      list_0.Add("SwitchADBKeyboard");
    if (this.ckbOnmaybay.Checked)
      list_0.Add("Onmaybay");
    if (this.ckbOffmaybay.Checked)
      list_0.Add("Offmaybay");
    if (this.ckbSetupLanguageEnglish.Checked)
      list_0.Add("SetupLanguageEnglish");
    if (this.ckbInstallFacebook.Checked)
      list_0.Add("InstallFacebook");
    if (this.ckbSetupMaxHelper.Checked)
      list_0.Add("SetupMaxHelper");
    if (this.ckbSetupMaxChange.Checked)
      list_0.Add("SetupMaxChange");
    if (this.ckbChinhDoSang0.Checked)
      list_0.Add("SetScreenBrightness");
    if (this.ckbPowerpin.Checked)
      list_0.Add("SetPin");
    if (this.ckbIpcheck.Checked)
      list_0.Add("CheckIP");
    if (this.ckbChinhAmThanh0.Checked)
      list_0.Add("SetMediaVolumn0");
    if (this.ckbTatWifi.Checked)
      list_0.Add("DisconnectWifi");
    if (this.ckbTatGPS.Checked)
      list_0.Add("DisableGPS");
    if (this.ckbTatBluetooth.Checked)
      list_0.Add("DisableBluetooth");
    if (this.ckbReboot.Checked)
      list_0.Add("RebootPhone");
    if (this.ckbonflashlightsuper.Checked)
      list_0.Add("Onflashlightsuper");
    if (this.ckboffflashlightsuper.Checked)
      list_0.Add("Offflashlightsuper");
    if (this.ckbCloseAllApp.Checked)
      list_0.Add("CloseAllApp");
    if (this.ckbGotoHome.Checked)
      list_0.Add("GotoHome");
    if (list_0.Count == 0)
      GClass14.smethod_0((object) "Vui lòng chọn ít nhất 1 chức năng!", 3);
    else
      this.method_13(list_0);
  }

  private void ckbSetupPhone_CheckedChanged(object sender, EventArgs e)
  {
    this.ckbSwitchADBKeyboard.Checked = this.ckbSetupPhone.Checked;
    this.ckbSetupLanguageEnglish.Checked = this.ckbSetupPhone.Checked;
    this.ckbInstallFacebook.Checked = this.ckbSetupPhone.Checked;
    this.ckbSetupMaxHelper.Checked = this.ckbSetupPhone.Checked;
    this.ckbSetupMaxChange.Checked = this.ckbSetupPhone.Checked;
    this.ckbSetupMaxChange.Checked = this.ckbSetupPhone.Checked;
    this.ckbReboot.Checked = this.ckbSetupPhone.Checked;
  }

  private void method_16(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "TestChange4G"
  });

  private void button1_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "TestChange4G"
  });

  private void button2_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "TestChangeDevice"
  });

  private void toolStripMenuItem_9_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetImageScreen"
  });

  private void toolStripMenuItem_10_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "CheckIPBrowser"
  });

  private void grantShellMagiskToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "GrantShellMagisk"
  });

  private void checkAboutPhoneToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "CheckAboutPhone"
  });

  private void toolStripMenuItem9_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "TurnOnWifi"
  });

  private void toolStripMenuItem_6_Click(object sender, EventArgs e)
  {
  }

  private void iPv4ToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetupAPNIpv4"
  });

  private void iPv6ToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetupAPNIpv6"
  });

  private void iPv4IPv6ToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetupAPNIpv64"
  });

  private void maxChangeToolStripMenuItem1_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "UninstallMaxChange"
  });

  private void toolStripMenuItem11_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "DisconnectAppium"
  });

  private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
  {
    if (new List<string>() { "cStt" }.Contains(e.Column.Name))
    {
      e.SortResult = int.Parse(e.CellValue1.ToString() == "" ? "-1" : e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString() == "" ? "-1" : e.CellValue2.ToString()));
      e.Handled = true;
    }
    else if (e.Column.Name == "cDeviceName")
    {
      try
      {
        string str1 = e.CellValue1.ToString();
        string str2 = e.CellValue2.ToString();
        int num1 = int.Parse(str1.StartsWith("MIN-") ? str1.Replace("MIN-", "") : "-1");
        int num2 = int.Parse(str2.StartsWith("MIN-") ? str2.Replace("MIN-", "") : "-1");
        e.SortResult = num1.CompareTo(num2);
        e.Handled = true;
      }
      catch (Exception ex)
      {
        e.SortResult = -1.CompareTo(-1);
        e.Handled = true;
      }
    }
    else
    {
      e.SortResult = (e.CellValue1.ToString() == "" ? "" : e.CellValue1.ToString()).CompareTo(e.CellValue2.ToString() == "" ? "" : e.CellValue2.ToString());
      e.Handled = true;
    }
  }

  private void shutdownPhoneToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "ShutdownPhone"
  });

  private void getTokenToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "GetToken"
  });

  private void getCookieToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "GetCookie"
  });

  private void backupDataToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "BackupData"
  });

  private void getUidToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "GetUid"
  });

  private void toolStripMenuItem_12_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SwitchAndroidKeyboard"
  });

  private void toolStripMenuItem_15_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetupDarkTheme"
  });

  private void switchADBKeyboardToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SwitchADBKeyboard"
  });

  private void toolStripMenuItem_16_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "TurnOnDoNotDisturb"
  });

  private void collectProxyToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "InstallCollectProxy"
  });

  private void ckbInstallFacebook_CheckedChanged(object sender, EventArgs e)
  {
    this.ckbSetupMaxChange.Enabled = !this.ckbInstallFacebook.Checked;
    this.ckbSetupMaxChange.Checked = this.ckbInstallFacebook.Checked;
  }

  private void toolStripMenuItem_17_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "CaiRoom"
  });

  private void ckbChinhDoSang0_CheckedChanged(object sender, EventArgs e)
  {
    this.nudPercentDoSang.Enabled = this.ckbChinhDoSang0.Checked;
    this.lblPercentDoSang.Enabled = this.ckbChinhDoSang0.Checked;
  }

  private void tCPIPToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "ConnectTCPIP"
  });

  private void removeProxyToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "RemoveProxy"
  });

  private void xToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "ConnectProxy"
  });

  private void checkIPToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "CheckIP"
  });

  private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (this.dtgvAcc.RowCount == 0)
      return;
    int int_0 = 0;
    if (this.dtgvAcc.SelectedRows.Count > 0)
      int_0 = this.dtgvAcc.SelectedRows[0].Index;
    string string_11 = Class14.smethod_3(this.dtgvAcc, int_0, "cDeviceId");
    if (string.IsNullOrEmpty(string_11))
    {
      GClass14.smethod_0((object) "Can't find device!", 3);
    }
    else
    {
      int num = (int) new fCheckProxy(new GClass27(string_11)).ShowDialog();
    }
  }

  private void toolStripMenuItem6_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "InstallAppApk"
  });

  private void toolStripMenuItem8_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "UninstallFacebook"
  });

  private void toolStripMenuItem_18_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetupLTE"
  });

  private void method_17(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "OpenLink"
  });

  private void getInfoAccToolStripMenuItem_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "GetInfoAccount"
  });

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fDeviceList));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.panel1 = new Panel();
    this.groupBox3 = new GroupBox();
    this.button2 = new Button();
    this.button1 = new Button();
    this.label3 = new Label();
    this.groupBox2 = new GroupBox();
    this.button25 = new Button();
    this.button24 = new Button();
    this.button23 = new Button();
    this.button22 = new Button();
    this.button21 = new Button();
    this.label5 = new Label();
    this.ckbGotoHome = new CheckBox();
    this.ckbCloseAllApp = new CheckBox();
    this.button19 = new Button();
    this.button18 = new Button();
    this.button17 = new Button();
    this.button16 = new Button();
    this.button15 = new Button();
    this.button14 = new Button();
    this.button13 = new Button();
    this.button12 = new Button();
    this.groupBox4 = new GroupBox();
    this.button20 = new Button();
    this.button10 = new Button();
    this.button9 = new Button();
    this.button8 = new Button();
    this.numdelayluong = new NumericUpDown();
    this.label4 = new Label();
    this.ckbOffmaybay = new CheckBox();
    this.ckbOnmaybay = new CheckBox();
    this.ckbIpcheck = new CheckBox();
    this.ckbPowerpin = new CheckBox();
    this.ckboffflashlightsuper = new CheckBox();
    this.ckbonflashlightsuper = new CheckBox();
    this.nudPercentDoSang = new NumericUpDown();
    this.nudThreadPhone = new NumericUpDown();
    this.lblPercentDoSang = new Label();
    this.label6 = new Label();
    this.ckbSetupPhone = new CheckBox();
    this.ckbReboot = new CheckBox();
    this.ckbSetupMaxChange = new CheckBox();
    this.ckbSetupMaxHelper = new CheckBox();
    this.ckbInstallFacebook = new CheckBox();
    this.ckbSetupLanguageEnglish = new CheckBox();
    this.ckbChinhAmThanh0 = new CheckBox();
    this.ckbTatBluetooth = new CheckBox();
    this.ckbTatWifi = new CheckBox();
    this.ckbTatGPS = new CheckBox();
    this.ckbChinhDoSang0 = new CheckBox();
    this.ckbSwitchADBKeyboard = new CheckBox();
    this.btnSetupPhone = new Button();
    this.groupBox1 = new GroupBox();
    this.button6 = new Button();
    this.btnUpdateDeviceName = new Button();
    this.txtDeviceName = new TextBox();
    this.txtDeviceId = new TextBox();
    this.label2 = new Label();
    this.label1 = new Label();
    this.BtnSearch = new MetroButton();
    this.txbSearch = new BunifuCustomTextbox();
    this.btnLoadDevice = new Button();
    this.button5 = new Button();
    this.nudSort = new NumericUpDown();
    this.txtCmd = new TextBox();
    this.btnCancel = new Button();
    this.btnSave = new Button();
    this.statusStrip1 = new StatusStrip();
    this.toolStripStatusLabel4 = new ToolStripStatusLabel();
    this.lblCountHighline = new ToolStripStatusLabel();
    this.toolStripStatusLabel5 = new ToolStripStatusLabel();
    this.lblCountSelect = new ToolStripStatusLabel();
    this.toolStripStatusLabel7 = new ToolStripStatusLabel();
    this.lblCountTotal = new ToolStripStatusLabel();
    this.button4 = new Button();
    this.button7 = new Button();
    this.button3 = new Button();
    this.dtgvAcc = new DataGridView();
    this.cChose = new DataGridViewCheckBoxColumn();
    this.cStt = new DataGridViewTextBoxColumn();
    this.cDeviceId = new DataGridViewTextBoxColumn();
    this.cOs = new DataGridViewTextBoxColumn();
    this.cDeviceName = new DataGridViewTextBoxColumn();
    this.cStatus = new DataGridViewTextBoxColumn();
    this.cPort = new DataGridViewTextBoxColumn();
    this.cSystemPort = new DataGridViewTextBoxColumn();
    this.cSize = new DataGridViewTextBoxColumn();
    this.ctmsAcc = new MetroContextMenu(this.components);
    this.toolStripMenuItem_0 = new ToolStripMenuItem();
    this.toolStripMenuItem_1 = new ToolStripMenuItem();
    this.liveToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_2 = new ToolStripMenuItem();
    this.toolStripMenuItem1 = new ToolStripMenuItem();
    this.closeScreenToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_5 = new ToolStripMenuItem();
    this.appiumToolStripMenuItem = new ToolStripMenuItem();
    this.connectAppiumToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem11 = new ToolStripMenuItem();
    this.toolStripMenuItem_13 = new ToolStripMenuItem();
    this.switchADBKeyboardToolStripMenuItem = new ToolStripMenuItem();
    this.setupLanguageEnglishToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem6 = new ToolStripMenuItem();
    this.facebookToolStripMenuItem = new ToolStripMenuItem();
    this.maxHelperToolStripMenuItem = new ToolStripMenuItem();
    this.maxChangeToolStripMenuItem = new ToolStripMenuItem();
    this.collectProxyToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_11 = new ToolStripMenuItem();
    this.rebootPhoneToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_8 = new ToolStripMenuItem();
    this.toolStripMenuItem8 = new ToolStripMenuItem();
    this.facebookToolStripMenuItem1 = new ToolStripMenuItem();
    this.maxChangeToolStripMenuItem1 = new ToolStripMenuItem();
    this.toolStripMenuItem_6 = new ToolStripMenuItem();
    this.toolStripMenuItem_14 = new ToolStripMenuItem();
    this.setScreeToolStripMenuItem = new ToolStripMenuItem();
    this.setScreenBrightness100ToolStripMenuItem = new ToolStripMenuItem();
    this.lockScreenToolStripMenuItem = new ToolStripMenuItem();
    this.unlockScreenToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem2 = new ToolStripMenuItem();
    this.sleepDEviceToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_9 = new ToolStripMenuItem();
    this.toolStripMenuItem_15 = new ToolStripMenuItem();
    this.gPSToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem4 = new ToolStripMenuItem();
    this.toolStripMenuItem5 = new ToolStripMenuItem();
    this.wifiToolStripMenuItem = new ToolStripMenuItem();
    this.connectWifiToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem3 = new ToolStripMenuItem();
    this.toolStripMenuItem9 = new ToolStripMenuItem();
    this.facebookToolStripMenuItem2 = new ToolStripMenuItem();
    this.backupDataToolStripMenuItem = new ToolStripMenuItem();
    this.getUidToolStripMenuItem = new ToolStripMenuItem();
    this.getCookieToolStripMenuItem = new ToolStripMenuItem();
    this.getTokenToolStripMenuItem = new ToolStripMenuItem();
    this.getInfoAccToolStripMenuItem = new ToolStripMenuItem();
    this.clearDataAppFbToolStripMenuItem = new ToolStripMenuItem();
    this.setupIPChoSim4GToolStripMenuItem = new ToolStripMenuItem();
    this.iPv4ToolStripMenuItem = new ToolStripMenuItem();
    this.iPv6ToolStripMenuItem = new ToolStripMenuItem();
    this.iPv4IPv6ToolStripMenuItem = new ToolStripMenuItem();
    this.proxyToolStripMenuItem = new ToolStripMenuItem();
    this.xToolStripMenuItem = new ToolStripMenuItem();
    this.removeProxyToolStripMenuItem = new ToolStripMenuItem();
    this.checkIPToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_7 = new ToolStripMenuItem();
    this.checkAboutPhoneToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_12 = new ToolStripMenuItem();
    this.toolStripMenuItem_16 = new ToolStripMenuItem();
    this.setMediaVolumn0ToolStripMenuItem = new ToolStripMenuItem();
    this.disableBluetoothToolStripMenuItem = new ToolStripMenuItem();
    this.disableRotateScreenToolStripMenuItem = new ToolStripMenuItem();
    this.grantShellMagiskToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_10 = new ToolStripMenuItem();
    this.shutdownPhoneToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_18 = new ToolStripMenuItem();
    this.toolStripMenuItem_17 = new ToolStripMenuItem();
    this.tCPIPToolStripMenuItem = new ToolStripMenuItem();
    this.checkProxyToolStripMenuItem = new ToolStripMenuItem();
    this.toolStripMenuItem_3 = new ToolStripMenuItem();
    this.toolStripMenuItem_4 = new ToolStripMenuItem();
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.button11 = new Button();
    this.btnClose = new Button();
    this.panel1.SuspendLayout();
    this.groupBox3.SuspendLayout();
    this.groupBox2.SuspendLayout();
    this.groupBox4.SuspendLayout();
    this.numdelayluong.BeginInit();
    this.nudPercentDoSang.BeginInit();
    this.nudThreadPhone.BeginInit();
    this.groupBox1.SuspendLayout();
    this.nudSort.BeginInit();
    this.statusStrip1.SuspendLayout();
    ((ISupportInitialize) this.dtgvAcc).BeginInit();
    this.ctmsAcc.SuspendLayout();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(1435, 32);
    this.bunifuCustomLabel1.TabIndex = 1;
    this.bunifuCustomLabel1.Text = "Device List";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuCustomLabel1.Click += new EventHandler(this.bunifuCustomLabel1_Click);
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.groupBox3);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.groupBox2);
    this.panel1.Controls.Add((Control) this.groupBox1);
    this.panel1.Controls.Add((Control) this.BtnSearch);
    this.panel1.Controls.Add((Control) this.txbSearch);
    this.panel1.Controls.Add((Control) this.btnLoadDevice);
    this.panel1.Controls.Add((Control) this.button5);
    this.panel1.Controls.Add((Control) this.nudSort);
    this.panel1.Controls.Add((Control) this.txtCmd);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnSave);
    this.panel1.Controls.Add((Control) this.statusStrip1);
    this.panel1.Controls.Add((Control) this.button4);
    this.panel1.Controls.Add((Control) this.button7);
    this.panel1.Controls.Add((Control) this.button3);
    this.panel1.Controls.Add((Control) this.dtgvAcc);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Location = new Point(0, 0);
    this.panel1.Margin = new Padding(3, 4, 3, 4);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(1436, 881);
    this.panel1.TabIndex = 0;
    this.groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox3.Controls.Add((Control) this.button2);
    this.groupBox3.Controls.Add((Control) this.button1);
    this.groupBox3.Location = new Point(1072, 612);
    this.groupBox3.Name = "groupBox3";
    this.groupBox3.Size = new Size(357, 61);
    this.groupBox3.TabIndex = 16;
    this.groupBox3.TabStop = false;
    this.groupBox3.Text = "Test Change";
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.Location = new Point(10, 22);
    this.button2.Name = "button2";
    this.button2.Size = new Size(161, 29);
    this.button2.TabIndex = 2;
    this.button2.Text = "Info Device";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.Location = new Point(187, 22);
    this.button1.Name = "button1";
    this.button1.Size = new Size(164, 29);
    this.button1.TabIndex = 2;
    this.button1.Text = "4G Mobile";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.label3.AutoSize = true;
    this.label3.Cursor = Cursors.Help;
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(1072, 82);
    this.label3.Name = "label3";
    this.label3.Size = new Size(109, 16);
    this.label3.TabIndex = 28;
    this.label3.Text = "Search Device ID:";
    this.groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox2.Controls.Add((Control) this.button25);
    this.groupBox2.Controls.Add((Control) this.button24);
    this.groupBox2.Controls.Add((Control) this.button23);
    this.groupBox2.Controls.Add((Control) this.button22);
    this.groupBox2.Controls.Add((Control) this.button21);
    this.groupBox2.Controls.Add((Control) this.label5);
    this.groupBox2.Controls.Add((Control) this.ckbGotoHome);
    this.groupBox2.Controls.Add((Control) this.ckbCloseAllApp);
    this.groupBox2.Controls.Add((Control) this.button19);
    this.groupBox2.Controls.Add((Control) this.button18);
    this.groupBox2.Controls.Add((Control) this.button17);
    this.groupBox2.Controls.Add((Control) this.button16);
    this.groupBox2.Controls.Add((Control) this.button15);
    this.groupBox2.Controls.Add((Control) this.button14);
    this.groupBox2.Controls.Add((Control) this.button13);
    this.groupBox2.Controls.Add((Control) this.button12);
    this.groupBox2.Controls.Add((Control) this.groupBox4);
    this.groupBox2.Controls.Add((Control) this.numdelayluong);
    this.groupBox2.Controls.Add((Control) this.label4);
    this.groupBox2.Controls.Add((Control) this.ckbOffmaybay);
    this.groupBox2.Controls.Add((Control) this.ckbOnmaybay);
    this.groupBox2.Controls.Add((Control) this.ckbIpcheck);
    this.groupBox2.Controls.Add((Control) this.ckbPowerpin);
    this.groupBox2.Controls.Add((Control) this.ckboffflashlightsuper);
    this.groupBox2.Controls.Add((Control) this.ckbonflashlightsuper);
    this.groupBox2.Controls.Add((Control) this.nudPercentDoSang);
    this.groupBox2.Controls.Add((Control) this.nudThreadPhone);
    this.groupBox2.Controls.Add((Control) this.lblPercentDoSang);
    this.groupBox2.Controls.Add((Control) this.label6);
    this.groupBox2.Controls.Add((Control) this.ckbSetupPhone);
    this.groupBox2.Controls.Add((Control) this.ckbReboot);
    this.groupBox2.Controls.Add((Control) this.ckbSetupMaxChange);
    this.groupBox2.Controls.Add((Control) this.ckbSetupMaxHelper);
    this.groupBox2.Controls.Add((Control) this.ckbInstallFacebook);
    this.groupBox2.Controls.Add((Control) this.ckbSetupLanguageEnglish);
    this.groupBox2.Controls.Add((Control) this.ckbChinhAmThanh0);
    this.groupBox2.Controls.Add((Control) this.ckbTatBluetooth);
    this.groupBox2.Controls.Add((Control) this.ckbTatWifi);
    this.groupBox2.Controls.Add((Control) this.ckbTatGPS);
    this.groupBox2.Controls.Add((Control) this.ckbChinhDoSang0);
    this.groupBox2.Controls.Add((Control) this.ckbSwitchADBKeyboard);
    this.groupBox2.Controls.Add((Control) this.btnSetupPhone);
    this.groupBox2.Location = new Point(1075, 143);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(354, 463);
    this.groupBox2.TabIndex = 4;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "     Setup Phone";
    this.button25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button25.Cursor = Cursors.Hand;
    this.button25.Font = new Font("Tahoma", 9f);
    this.button25.Location = new Point(26, 201);
    this.button25.Name = "button25";
    this.button25.Size = new Size(132, 21);
    this.button25.TabIndex = 53;
    this.button25.Text = "Tắt Wifi";
    this.button25.UseVisualStyleBackColor = true;
    this.button25.Click += new EventHandler(this.button25_Click);
    this.button24.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button24.Cursor = Cursors.Hand;
    this.button24.Font = new Font("Tahoma", 9f);
    this.button24.Location = new Point(26, 228);
    this.button24.Name = "button24";
    this.button24.Size = new Size(132, 21);
    this.button24.TabIndex = 52;
    this.button24.Text = "Tắt GPS";
    this.button24.UseVisualStyleBackColor = true;
    this.button24.Click += new EventHandler(this.button24_Click);
    this.button23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button23.Cursor = Cursors.Hand;
    this.button23.Font = new Font("Tahoma", 9f);
    this.button23.Location = new Point(26, 254);
    this.button23.Name = "button23";
    this.button23.Size = new Size(132, 21);
    this.button23.TabIndex = 51;
    this.button23.Text = "Tắt Bluetooth";
    this.button23.UseVisualStyleBackColor = true;
    this.button23.Click += new EventHandler(this.button23_Click);
    this.button22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button22.Cursor = Cursors.Hand;
    this.button22.Font = new Font("Tahoma", 9f);
    this.button22.Location = new Point(26, 279);
    this.button22.Name = "button22";
    this.button22.Size = new Size(132, 21);
    this.button22.TabIndex = 50;
    this.button22.Text = "Bật máy bay";
    this.button22.UseVisualStyleBackColor = true;
    this.button22.Click += new EventHandler(this.button22_Click);
    this.button21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button21.Cursor = Cursors.Hand;
    this.button21.Font = new Font("Tahoma", 9f);
    this.button21.Location = new Point(26, 305);
    this.button21.Name = "button21";
    this.button21.Size = new Size(132, 21);
    this.button21.TabIndex = 49;
    this.button21.Text = "Tắt máy bay";
    this.button21.UseVisualStyleBackColor = true;
    this.button21.Click += new EventHandler(this.button21_Click_1);
    this.label5.AutoSize = true;
    this.label5.Cursor = Cursors.Help;
    this.label5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label5.Location = new Point(308, 22);
    this.label5.Name = "label5";
    this.label5.Size = new Size(24, 16);
    this.label5.TabIndex = 48;
    this.label5.Text = "ms";
    this.ckbGotoHome.AutoSize = true;
    this.ckbGotoHome.Cursor = Cursors.Hand;
    this.ckbGotoHome.Location = new Point(184, 309);
    this.ckbGotoHome.Name = "ckbGotoHome";
    this.ckbGotoHome.Size = new Size(15, 14);
    this.ckbGotoHome.TabIndex = 47;
    this.ckbGotoHome.UseVisualStyleBackColor = true;
    this.ckbCloseAllApp.AutoSize = true;
    this.ckbCloseAllApp.Cursor = Cursors.Hand;
    this.ckbCloseAllApp.Location = new Point(184, 283);
    this.ckbCloseAllApp.Name = "ckbCloseAllApp";
    this.ckbCloseAllApp.Size = new Size(15, 14);
    this.ckbCloseAllApp.TabIndex = 46;
    this.ckbCloseAllApp.UseVisualStyleBackColor = true;
    this.button19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button19.Cursor = Cursors.Hand;
    this.button19.Font = new Font("Tahoma", 9f);
    this.button19.Location = new Point(200, 305);
    this.button19.Name = "button19";
    this.button19.Size = new Size(132, 21);
    this.button19.TabIndex = 45;
    this.button19.Text = "Go to Home";
    this.button19.UseVisualStyleBackColor = true;
    this.button19.Click += new EventHandler(this.button19_Click);
    this.button18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button18.Cursor = Cursors.Hand;
    this.button18.Font = new Font("Tahoma", 9f);
    this.button18.Location = new Point(200, 279);
    this.button18.Name = "button18";
    this.button18.Size = new Size(132, 21);
    this.button18.TabIndex = 44;
    this.button18.Text = "Close all app";
    this.button18.UseVisualStyleBackColor = true;
    this.button18.Click += new EventHandler(this.button18_Click);
    this.button17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button17.Cursor = Cursors.Hand;
    this.button17.Font = new Font("Tahoma", 9f);
    this.button17.Location = new Point(200, 254);
    this.button17.Name = "button17";
    this.button17.Size = new Size(132, 21);
    this.button17.TabIndex = 43;
    this.button17.Text = "Chỉnh âm thanh 0%";
    this.button17.UseVisualStyleBackColor = true;
    this.button17.Click += new EventHandler(this.button17_Click);
    this.button16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button16.Cursor = Cursors.Hand;
    this.button16.Font = new Font("Tahoma", 9f);
    this.button16.Location = new Point(200, 228);
    this.button16.Name = "button16";
    this.button16.Size = new Size(132, 21);
    this.button16.TabIndex = 42;
    this.button16.Text = "Tắt Flashlightsuper";
    this.button16.UseVisualStyleBackColor = true;
    this.button16.Click += new EventHandler(this.button16_Click);
    this.button15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button15.Cursor = Cursors.Hand;
    this.button15.Font = new Font("Tahoma", 9f);
    this.button15.Location = new Point(200, 201);
    this.button15.Name = "button15";
    this.button15.Size = new Size(132, 21);
    this.button15.TabIndex = 41;
    this.button15.Text = "Bật Flashlightsuper";
    this.button15.UseVisualStyleBackColor = true;
    this.button15.Click += new EventHandler(this.button15_Click);
    this.button14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button14.Cursor = Cursors.Hand;
    this.button14.Font = new Font("Tahoma", 9f);
    this.button14.Location = new Point(200, 175);
    this.button14.Name = "button14";
    this.button14.Size = new Size(132, 21);
    this.button14.TabIndex = 40;
    this.button14.Text = "Reset phone";
    this.button14.UseVisualStyleBackColor = true;
    this.button14.Click += new EventHandler(this.button14_Click);
    this.button13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button13.Cursor = Cursors.Hand;
    this.button13.Font = new Font("Tahoma", 9f);
    this.button13.Location = new Point(200, 149);
    this.button13.Name = "button13";
    this.button13.Size = new Size(132, 21);
    this.button13.TabIndex = 39;
    this.button13.Text = "IP check";
    this.button13.UseVisualStyleBackColor = true;
    this.button13.Click += new EventHandler(this.button13_Click);
    this.button12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button12.Cursor = Cursors.Hand;
    this.button12.Font = new Font("Tahoma", 9f);
    this.button12.Location = new Point(200, 122);
    this.button12.Name = "button12";
    this.button12.Size = new Size(132, 21);
    this.button12.TabIndex = 10;
    this.button12.Text = "Set pin";
    this.button12.UseVisualStyleBackColor = true;
    this.button12.Click += new EventHandler(this.button12_Click);
    this.groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox4.Controls.Add((Control) this.button20);
    this.groupBox4.Controls.Add((Control) this.button10);
    this.groupBox4.Controls.Add((Control) this.button9);
    this.groupBox4.Controls.Add((Control) this.button8);
    this.groupBox4.Location = new Point(12, 336);
    this.groupBox4.Name = "groupBox4";
    this.groupBox4.Size = new Size(336, 86);
    this.groupBox4.TabIndex = 5;
    this.groupBox4.TabStop = false;
    this.groupBox4.Text = "Facebook app";
    this.groupBox4.Visible = false;
    this.button20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button20.Cursor = Cursors.Hand;
    this.button20.Location = new Point(14, 49);
    this.button20.Name = "button20";
    this.button20.Size = new Size(147, 25);
    this.button20.TabIndex = 6;
    this.button20.Text = "Open link registration";
    this.button20.UseVisualStyleBackColor = true;
    this.button20.Click += new EventHandler(this.button20_Click);
    this.button10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button10.Cursor = Cursors.Hand;
    this.button10.Location = new Point(172, 18);
    this.button10.Name = "button10";
    this.button10.Size = new Size(158, 25);
    this.button10.TabIndex = 5;
    this.button10.Text = "Backup data";
    this.button10.UseVisualStyleBackColor = true;
    this.button10.Click += new EventHandler(this.button10_Click);
    this.button9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button9.Cursor = Cursors.Hand;
    this.button9.Location = new Point(172, 49);
    this.button9.Name = "button9";
    this.button9.Size = new Size(158, 25);
    this.button9.TabIndex = 4;
    this.button9.Text = "Get uid";
    this.button9.UseVisualStyleBackColor = true;
    this.button9.Click += new EventHandler(this.button9_Click);
    this.button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button8.Cursor = Cursors.Hand;
    this.button8.Location = new Point(14, 18);
    this.button8.Name = "button8";
    this.button8.Size = new Size(147, 25);
    this.button8.TabIndex = 3;
    this.button8.Text = "Clear facebook data";
    this.button8.UseVisualStyleBackColor = true;
    this.button8.Click += new EventHandler(this.button8_Click);
    this.numdelayluong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.numdelayluong.Location = new Point(251, 20);
    this.numdelayluong.Maximum = new Decimal(new int[4]
    {
      1410065407,
      2,
      0,
      0
    });
    this.numdelayluong.Name = "numdelayluong";
    this.numdelayluong.Size = new Size(56, 23);
    this.numdelayluong.TabIndex = 38;
    this.numdelayluong.Value = new Decimal(new int[4]
    {
      350,
      0,
      0,
      0
    });
    this.numdelayluong.ValueChanged += new EventHandler(this.numdelayluong_ValueChanged);
    this.label4.AutoSize = true;
    this.label4.Cursor = Cursors.Help;
    this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label4.Location = new Point(202, 23);
    this.label4.Name = "label4";
    this.label4.Size = new Size(43, 16);
    this.label4.TabIndex = 37;
    this.label4.Text = "Delay:";
    this.ckbOffmaybay.AutoSize = true;
    this.ckbOffmaybay.Cursor = Cursors.Hand;
    this.ckbOffmaybay.Location = new Point(12, 306);
    this.ckbOffmaybay.Name = "ckbOffmaybay";
    this.ckbOffmaybay.Size = new Size(97, 20);
    this.ckbOffmaybay.TabIndex = 36;
    this.ckbOffmaybay.Text = "Tắt máy bay";
    this.ckbOffmaybay.UseVisualStyleBackColor = true;
    this.ckbOnmaybay.AutoSize = true;
    this.ckbOnmaybay.Cursor = Cursors.Hand;
    this.ckbOnmaybay.Location = new Point(12, 280);
    this.ckbOnmaybay.Name = "ckbOnmaybay";
    this.ckbOnmaybay.Size = new Size(96, 20);
    this.ckbOnmaybay.TabIndex = 35;
    this.ckbOnmaybay.Text = "Bật máy bay";
    this.ckbOnmaybay.UseVisualStyleBackColor = true;
    this.ckbIpcheck.AutoSize = true;
    this.ckbIpcheck.Cursor = Cursors.Hand;
    this.ckbIpcheck.Location = new Point(184, 149);
    this.ckbIpcheck.Name = "ckbIpcheck";
    this.ckbIpcheck.Size = new Size(73, 20);
    this.ckbIpcheck.TabIndex = 34;
    this.ckbIpcheck.Text = "Ip check";
    this.ckbIpcheck.UseVisualStyleBackColor = true;
    this.ckbPowerpin.AutoSize = true;
    this.ckbPowerpin.Cursor = Cursors.Hand;
    this.ckbPowerpin.Location = new Point(184, 123);
    this.ckbPowerpin.Name = "ckbPowerpin";
    this.ckbPowerpin.Size = new Size(66, 20);
    this.ckbPowerpin.TabIndex = 33;
    this.ckbPowerpin.Text = "Set pin";
    this.ckbPowerpin.UseVisualStyleBackColor = true;
    this.ckbPowerpin.CheckedChanged += new EventHandler(this.ckbPowerpin_CheckedChanged);
    this.ckboffflashlightsuper.AutoSize = true;
    this.ckboffflashlightsuper.Cursor = Cursors.Hand;
    this.ckboffflashlightsuper.Location = new Point(184, 229);
    this.ckboffflashlightsuper.Name = "ckboffflashlightsuper";
    this.ckboffflashlightsuper.Size = new Size(135, 20);
    this.ckboffflashlightsuper.TabIndex = 32;
    this.ckboffflashlightsuper.Text = "Tắt Flashlightsuper";
    this.ckboffflashlightsuper.UseVisualStyleBackColor = true;
    this.ckboffflashlightsuper.CheckedChanged += new EventHandler(this.ckboffflashlightsuper_CheckedChanged);
    this.ckbonflashlightsuper.AutoSize = true;
    this.ckbonflashlightsuper.Cursor = Cursors.Hand;
    this.ckbonflashlightsuper.Location = new Point(184, 202);
    this.ckbonflashlightsuper.Name = "ckbonflashlightsuper";
    this.ckbonflashlightsuper.Size = new Size(134, 20);
    this.ckbonflashlightsuper.TabIndex = 31;
    this.ckbonflashlightsuper.Text = "Bật Flashlightsuper";
    this.ckbonflashlightsuper.UseVisualStyleBackColor = true;
    this.ckbonflashlightsuper.CheckedChanged += new EventHandler(this.ckbonflashlightsuper_CheckedChanged);
    this.nudPercentDoSang.Enabled = false;
    this.nudPercentDoSang.Location = new Point(115, 175);
    this.nudPercentDoSang.Name = "nudPercentDoSang";
    this.nudPercentDoSang.Size = new Size(40, 23);
    this.nudPercentDoSang.TabIndex = 30;
    this.nudPercentDoSang.Value = new Decimal(new int[4]
    {
      100,
      0,
      0,
      0
    });
    this.nudThreadPhone.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.nudThreadPhone.Location = new Point(134, 20);
    this.nudThreadPhone.Maximum = new Decimal(new int[4]
    {
      1410065407,
      2,
      0,
      0
    });
    this.nudThreadPhone.Name = "nudThreadPhone";
    this.nudThreadPhone.Size = new Size(46, 23);
    this.nudThreadPhone.TabIndex = 29;
    this.nudThreadPhone.Value = new Decimal(new int[4]
    {
      999,
      0,
      0,
      0
    });
    this.nudThreadPhone.ValueChanged += new EventHandler(this.nudThreadPhone_ValueChanged);
    this.lblPercentDoSang.AutoSize = true;
    this.lblPercentDoSang.Cursor = Cursors.Help;
    this.lblPercentDoSang.Enabled = false;
    this.lblPercentDoSang.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblPercentDoSang.Location = new Point(161, 178);
    this.lblPercentDoSang.Name = "lblPercentDoSang";
    this.lblPercentDoSang.Size = new Size(19, 16);
    this.lblPercentDoSang.TabIndex = 28;
    this.lblPercentDoSang.Text = "%";
    this.label6.AutoSize = true;
    this.label6.Cursor = Cursors.Help;
    this.label6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label6.Location = new Point(9, 23);
    this.label6.Name = "label6";
    this.label6.Size = new Size(123, 16);
    this.label6.TabIndex = 28;
    this.label6.Text = "Số phone chạy/lượt:";
    this.ckbSetupPhone.AutoSize = true;
    this.ckbSetupPhone.Cursor = Cursors.Hand;
    this.ckbSetupPhone.Location = new Point(12, 1);
    this.ckbSetupPhone.Name = "ckbSetupPhone";
    this.ckbSetupPhone.Size = new Size(15, 14);
    this.ckbSetupPhone.TabIndex = 13;
    this.ckbSetupPhone.UseVisualStyleBackColor = true;
    this.ckbSetupPhone.CheckedChanged += new EventHandler(this.ckbSetupPhone_CheckedChanged);
    this.ckbReboot.AutoSize = true;
    this.ckbReboot.Cursor = Cursors.Hand;
    this.ckbReboot.Location = new Point(184, 174);
    this.ckbReboot.Name = "ckbReboot";
    this.ckbReboot.Size = new Size((int) sbyte.MaxValue, 20);
    this.ckbReboot.TabIndex = 12;
    this.ckbReboot.Text = "Khởi động lại máy";
    this.ckbReboot.UseVisualStyleBackColor = true;
    this.ckbSetupMaxChange.AutoSize = true;
    this.ckbSetupMaxChange.Cursor = Cursors.Hand;
    this.ckbSetupMaxChange.Location = new Point(12, 150);
    this.ckbSetupMaxChange.Name = "ckbSetupMaxChange";
    this.ckbSetupMaxChange.Size = new Size(139, 20);
    this.ckbSetupMaxChange.TabIndex = 12;
    this.ckbSetupMaxChange.Text = "Cài app MaxChange";
    this.ckbSetupMaxChange.UseVisualStyleBackColor = true;
    this.ckbSetupMaxChange.CheckedChanged += new EventHandler(this.ckbSetupMaxChange_CheckedChanged);
    this.ckbSetupMaxHelper.AutoSize = true;
    this.ckbSetupMaxHelper.Cursor = Cursors.Hand;
    this.ckbSetupMaxHelper.Location = new Point(12, 124);
    this.ckbSetupMaxHelper.Name = "ckbSetupMaxHelper";
    this.ckbSetupMaxHelper.Size = new Size(133, 20);
    this.ckbSetupMaxHelper.TabIndex = 12;
    this.ckbSetupMaxHelper.Text = "Cài app MaxHelper";
    this.ckbSetupMaxHelper.UseVisualStyleBackColor = true;
    this.ckbInstallFacebook.AutoSize = true;
    this.ckbInstallFacebook.Cursor = Cursors.Hand;
    this.ckbInstallFacebook.Location = new Point(12, 98);
    this.ckbInstallFacebook.Name = "ckbInstallFacebook";
    this.ckbInstallFacebook.Size = new Size((int) sbyte.MaxValue, 20);
    this.ckbInstallFacebook.TabIndex = 12;
    this.ckbInstallFacebook.Text = "Cài app Facebook";
    this.ckbInstallFacebook.UseVisualStyleBackColor = true;
    this.ckbInstallFacebook.CheckedChanged += new EventHandler(this.ckbInstallFacebook_CheckedChanged);
    this.ckbSetupLanguageEnglish.AutoSize = true;
    this.ckbSetupLanguageEnglish.Cursor = Cursors.Hand;
    this.ckbSetupLanguageEnglish.Location = new Point(12, 72);
    this.ckbSetupLanguageEnglish.Name = "ckbSetupLanguageEnglish";
    this.ckbSetupLanguageEnglish.Size = new Size(146, 20);
    this.ckbSetupLanguageEnglish.TabIndex = 12;
    this.ckbSetupLanguageEnglish.Text = "Cài ngôn ngữ English";
    this.ckbSetupLanguageEnglish.UseVisualStyleBackColor = true;
    this.ckbChinhAmThanh0.AutoSize = true;
    this.ckbChinhAmThanh0.Cursor = Cursors.Hand;
    this.ckbChinhAmThanh0.Location = new Point(184, (int) byte.MaxValue);
    this.ckbChinhAmThanh0.Name = "ckbChinhAmThanh0";
    this.ckbChinhAmThanh0.Size = new Size(104, 20);
    this.ckbChinhAmThanh0.TabIndex = 12;
    this.ckbChinhAmThanh0.Text = "Âm thanh 0%";
    this.ckbChinhAmThanh0.UseVisualStyleBackColor = true;
    this.ckbChinhAmThanh0.CheckedChanged += new EventHandler(this.ckbChinhAmThanh0_CheckedChanged);
    this.ckbTatBluetooth.AutoSize = true;
    this.ckbTatBluetooth.Cursor = Cursors.Hand;
    this.ckbTatBluetooth.Location = new Point(12, 254);
    this.ckbTatBluetooth.Name = "ckbTatBluetooth";
    this.ckbTatBluetooth.Size = new Size(102, 20);
    this.ckbTatBluetooth.TabIndex = 12;
    this.ckbTatBluetooth.Text = "Tắt Bluetooth";
    this.ckbTatBluetooth.UseVisualStyleBackColor = true;
    this.ckbTatBluetooth.CheckedChanged += new EventHandler(this.ckbTatBluetooth_CheckedChanged);
    this.ckbTatWifi.AutoSize = true;
    this.ckbTatWifi.Cursor = Cursors.Hand;
    this.ckbTatWifi.Location = new Point(12, 202);
    this.ckbTatWifi.Name = "ckbTatWifi";
    this.ckbTatWifi.Size = new Size(71, 20);
    this.ckbTatWifi.TabIndex = 12;
    this.ckbTatWifi.Text = "Tắt Wifi";
    this.ckbTatWifi.UseVisualStyleBackColor = true;
    this.ckbTatWifi.CheckedChanged += new EventHandler(this.ckbTatWifi_CheckedChanged);
    this.ckbTatGPS.AutoSize = true;
    this.ckbTatGPS.Cursor = Cursors.Hand;
    this.ckbTatGPS.Location = new Point(12, 228);
    this.ckbTatGPS.Name = "ckbTatGPS";
    this.ckbTatGPS.Size = new Size(72, 20);
    this.ckbTatGPS.TabIndex = 12;
    this.ckbTatGPS.Text = "Tắt GPS";
    this.ckbTatGPS.UseVisualStyleBackColor = true;
    this.ckbChinhDoSang0.AutoSize = true;
    this.ckbChinhDoSang0.Cursor = Cursors.Hand;
    this.ckbChinhDoSang0.Location = new Point(12, 176);
    this.ckbChinhDoSang0.Name = "ckbChinhDoSang0";
    this.ckbChinhDoSang0.Size = new Size(107, 20);
    this.ckbChinhDoSang0.TabIndex = 12;
    this.ckbChinhDoSang0.Text = "Chỉnh độ sáng";
    this.ckbChinhDoSang0.UseVisualStyleBackColor = true;
    this.ckbChinhDoSang0.CheckedChanged += new EventHandler(this.ckbChinhDoSang0_CheckedChanged);
    this.ckbSwitchADBKeyboard.AutoSize = true;
    this.ckbSwitchADBKeyboard.Cursor = Cursors.Hand;
    this.ckbSwitchADBKeyboard.Location = new Point(12, 46);
    this.ckbSwitchADBKeyboard.Name = "ckbSwitchADBKeyboard";
    this.ckbSwitchADBKeyboard.Size = new Size(124, 20);
    this.ckbSwitchADBKeyboard.TabIndex = 12;
    this.ckbSwitchADBKeyboard.Text = "Cài ADBKeyboard";
    this.ckbSwitchADBKeyboard.UseVisualStyleBackColor = true;
    this.btnSetupPhone.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnSetupPhone.BackColor = Color.FromArgb(53, 120, 229);
    this.btnSetupPhone.Cursor = Cursors.Hand;
    this.btnSetupPhone.FlatAppearance.BorderSize = 0;
    this.btnSetupPhone.FlatStyle = FlatStyle.Flat;
    this.btnSetupPhone.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnSetupPhone.ForeColor = Color.White;
    this.btnSetupPhone.Location = new Point(7, 428);
    this.btnSetupPhone.Name = "btnSetupPhone";
    this.btnSetupPhone.Size = new Size(341, 29);
    this.btnSetupPhone.TabIndex = 11;
    this.btnSetupPhone.Text = "Bắt đầu";
    this.btnSetupPhone.UseVisualStyleBackColor = false;
    this.btnSetupPhone.Click += new EventHandler(this.btnSetupPhone_Click);
    this.groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox1.Controls.Add((Control) this.button6);
    this.groupBox1.Controls.Add((Control) this.btnUpdateDeviceName);
    this.groupBox1.Controls.Add((Control) this.txtDeviceName);
    this.groupBox1.Controls.Add((Control) this.txtDeviceId);
    this.groupBox1.Controls.Add((Control) this.label2);
    this.groupBox1.Controls.Add((Control) this.label1);
    this.groupBox1.Location = new Point(1075, 679);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(354, 112);
    this.groupBox1.TabIndex = 4;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Update Device Name";
    this.button6.Cursor = Cursors.Hand;
    this.button6.Location = new Point(10, 78);
    this.button6.Name = "button6";
    this.button6.Size = new Size(163, 29);
    this.button6.TabIndex = 2;
    this.button6.Text = "Auto Index";
    this.button6.UseVisualStyleBackColor = true;
    this.button6.Click += new EventHandler(this.button6_Click);
    this.btnUpdateDeviceName.Cursor = Cursors.Hand;
    this.btnUpdateDeviceName.Location = new Point(189, 78);
    this.btnUpdateDeviceName.Name = "btnUpdateDeviceName";
    this.btnUpdateDeviceName.Size = new Size(164, 29);
    this.btnUpdateDeviceName.TabIndex = 2;
    this.btnUpdateDeviceName.Text = "Update";
    this.btnUpdateDeviceName.UseVisualStyleBackColor = true;
    this.btnUpdateDeviceName.Click += new EventHandler(this.btnUpdateDeviceName_Click);
    this.txtDeviceName.Location = new Point(78, 49);
    this.txtDeviceName.Name = "txtDeviceName";
    this.txtDeviceName.Size = new Size(275, 23);
    this.txtDeviceName.TabIndex = 1;
    this.txtDeviceId.Location = new Point(78, 20);
    this.txtDeviceId.Name = "txtDeviceId";
    this.txtDeviceId.ReadOnly = true;
    this.txtDeviceId.Size = new Size(275, 23);
    this.txtDeviceId.TabIndex = 1;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(7, 52);
    this.label2.Name = "label2";
    this.label2.Size = new Size(45, 16);
    this.label2.TabIndex = 0;
    this.label2.Text = "Name:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(7, 23);
    this.label1.Name = "label1";
    this.label1.Size = new Size(64, 16);
    this.label1.TabIndex = 0;
    this.label1.Text = "Device Id:";
    this.BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.BtnSearch.BackgroundImageLayout = ImageLayout.None;
    this.BtnSearch.Cursor = Cursors.Hand;
    this.BtnSearch.Location = new Point(1405, 79);
    this.BtnSearch.Name = "BtnSearch";
    this.BtnSearch.Size = new Size(24, 24);
    this.BtnSearch.TabIndex = 15;
    this.BtnSearch.UseSelectable = true;
    this.BtnSearch.Click += new EventHandler(this.BtnSearch_Click);
    this.txbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txbSearch.BorderColor = Color.SeaGreen;
    this.txbSearch.Location = new Point(1182, 79);
    this.txbSearch.Name = "txbSearch";
    this.txbSearch.Size = new Size(218, 23);
    this.txbSearch.TabIndex = 14;
    this.txbSearch.KeyDown += new KeyEventHandler(this.txbSearch_KeyDown);
    this.btnLoadDevice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnLoadDevice.Cursor = Cursors.Hand;
    this.btnLoadDevice.Location = new Point(1070, 44);
    this.btnLoadDevice.Name = "btnLoadDevice";
    this.btnLoadDevice.Size = new Size(359, 29);
    this.btnLoadDevice.TabIndex = 2;
    this.btnLoadDevice.Text = "Load Device";
    this.btnLoadDevice.UseVisualStyleBackColor = true;
    this.btnLoadDevice.Click += new EventHandler(this.btnLoadDevice_Click);
    this.button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button5.Cursor = Cursors.Hand;
    this.button5.Location = new Point(1354, 767);
    this.button5.Name = "button5";
    this.button5.Size = new Size(75, 25);
    this.button5.TabIndex = 2;
    this.button5.Text = "Run ADB";
    this.button5.UseVisualStyleBackColor = true;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.nudSort.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.nudSort.Location = new Point(1075, 796);
    this.nudSort.Name = "nudSort";
    this.nudSort.Size = new Size(173, 23);
    this.nudSort.TabIndex = 13;
    this.nudSort.Value = new Decimal(new int[4]
    {
      10,
      0,
      0,
      0
    });
    this.txtCmd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.txtCmd.Location = new Point(1198, 768);
    this.txtCmd.Name = "txtCmd";
    this.txtCmd.Size = new Size(150, 23);
    this.txtCmd.TabIndex = 1;
    this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(1259, 825);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(170, 29);
    this.btnCancel.TabIndex = 12;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnSave.BackColor = Color.FromArgb(53, 120, 229);
    this.btnSave.Cursor = Cursors.Hand;
    this.btnSave.FlatAppearance.BorderSize = 0;
    this.btnSave.FlatStyle = FlatStyle.Flat;
    this.btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnSave.ForeColor = Color.White;
    this.btnSave.Location = new Point(1075, 825);
    this.btnSave.Name = "btnSave";
    this.btnSave.Size = new Size(173, 29);
    this.btnSave.TabIndex = 11;
    this.btnSave.Text = "Lưu";
    this.btnSave.UseVisualStyleBackColor = false;
    this.btnSave.Click += new EventHandler(this.btnSave_Click);
    this.statusStrip1.BackColor = SystemColors.Control;
    this.statusStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.statusStrip1.Items.AddRange(new ToolStripItem[6]
    {
      (ToolStripItem) this.toolStripStatusLabel4,
      (ToolStripItem) this.lblCountHighline,
      (ToolStripItem) this.toolStripStatusLabel5,
      (ToolStripItem) this.lblCountSelect,
      (ToolStripItem) this.toolStripStatusLabel7,
      (ToolStripItem) this.lblCountTotal
    });
    this.statusStrip1.Location = new Point(0, 857);
    this.statusStrip1.Name = "statusStrip1";
    this.statusStrip1.Size = new Size(1434, 22);
    this.statusStrip1.SizingGrip = false;
    this.statusStrip1.TabIndex = 10;
    this.statusStrip1.Text = "statusStrip1";
    this.toolStripStatusLabel4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
    this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
    this.toolStripStatusLabel4.Size = new Size(59, 17);
    this.toolStripStatusLabel4.Text = "Bôi đen:";
    this.lblCountHighline.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
    this.lblCountHighline.ForeColor = Color.Blue;
    this.lblCountHighline.Name = "lblCountHighline";
    this.lblCountHighline.Size = new Size(15, 17);
    this.lblCountHighline.Text = "0";
    this.toolStripStatusLabel5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
    this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
    this.toolStripStatusLabel5.Size = new Size(65, 17);
    this.toolStripStatusLabel5.Text = "Đã chọn:";
    this.lblCountSelect.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCountSelect.ForeColor = Color.FromArgb(0, 64, 0);
    this.lblCountSelect.Name = "lblCountSelect";
    this.lblCountSelect.Size = new Size(15, 17);
    this.lblCountSelect.Text = "0";
    this.toolStripStatusLabel7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
    this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
    this.toolStripStatusLabel7.Size = new Size(52, 17);
    this.toolStripStatusLabel7.Text = "Tất cả:";
    this.lblCountTotal.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
    this.lblCountTotal.ForeColor = Color.Maroon;
    this.lblCountTotal.Name = "lblCountTotal";
    this.lblCountTotal.Size = new Size(15, 17);
    this.lblCountTotal.Text = "0";
    this.button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button4.Cursor = Cursors.Hand;
    this.button4.Location = new Point(1259, 796);
    this.button4.Name = "button4";
    this.button4.Size = new Size(170, 26);
    this.button4.TabIndex = 2;
    this.button4.Text = "Sắp xếp phone";
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button7.Cursor = Cursors.Hand;
    this.button7.Location = new Point(1070, 108);
    this.button7.Name = "button7";
    this.button7.Size = new Size(173, 29);
    this.button7.TabIndex = 2;
    this.button7.Text = "Kill ADB";
    this.button7.UseVisualStyleBackColor = true;
    this.button7.Click += new EventHandler(this.button7_Click);
    this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button3.Cursor = Cursors.Hand;
    this.button3.Location = new Point(1259, 108);
    this.button3.Name = "button3";
    this.button3.Size = new Size(170, 29);
    this.button3.TabIndex = 2;
    this.button3.Text = "Kill Appium";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.dtgvAcc.AllowUserToAddRows = false;
    this.dtgvAcc.AllowUserToDeleteRows = false;
    this.dtgvAcc.AllowUserToResizeRows = false;
    this.dtgvAcc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
    this.dtgvAcc.Columns.AddRange((DataGridViewColumn) this.cChose, (DataGridViewColumn) this.cStt, (DataGridViewColumn) this.cDeviceId, (DataGridViewColumn) this.cOs, (DataGridViewColumn) this.cDeviceName, (DataGridViewColumn) this.cStatus, (DataGridViewColumn) this.cPort, (DataGridViewColumn) this.cSystemPort, (DataGridViewColumn) this.cSize);
    this.dtgvAcc.ContextMenuStrip = (ContextMenuStrip) this.ctmsAcc;
    this.dtgvAcc.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.dtgvAcc.Location = new Point(4, 44);
    this.dtgvAcc.Name = "dtgvAcc";
    this.dtgvAcc.RowHeadersVisible = false;
    this.dtgvAcc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvAcc.Size = new Size(1062, 810);
    this.dtgvAcc.TabIndex = 3;
    this.dtgvAcc.CellClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellClick);
    this.dtgvAcc.CellDoubleClick += new DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
    this.dtgvAcc.SelectionChanged += new EventHandler(this.dtgvAcc_SelectionChanged);
    this.dtgvAcc.SortCompare += new DataGridViewSortCompareEventHandler(this.dtgvAcc_SortCompare);
    this.dtgvAcc.KeyDown += new KeyEventHandler(this.dtgvAcc_KeyDown);
    this.cChose.HeaderText = "Chọn";
    this.cChose.Name = "cChose";
    this.cChose.SortMode = DataGridViewColumnSortMode.Automatic;
    this.cChose.Width = 40;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.cStt.DefaultCellStyle = gridViewCellStyle2;
    this.cStt.HeaderText = "STT";
    this.cStt.Name = "cStt";
    this.cStt.Width = 35;
    this.cDeviceId.HeaderText = "Device Id";
    this.cDeviceId.Name = "cDeviceId";
    this.cDeviceId.Width = 150;
    this.cOs.HeaderText = "OS";
    this.cOs.Name = "cOs";
    this.cOs.Width = 50;
    this.cDeviceName.HeaderText = "Device Name";
    this.cDeviceName.Name = "cDeviceName";
    this.cDeviceName.Width = 110;
    this.cStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cStatus.HeaderText = "Status";
    this.cStatus.Name = "cStatus";
    this.cPort.HeaderText = "Port";
    this.cPort.Name = "cPort";
    this.cPort.Visible = false;
    this.cPort.Width = 70;
    this.cSystemPort.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cSystemPort.HeaderText = "System Port";
    this.cSystemPort.Name = "cSystemPort";
    this.cSystemPort.Visible = false;
    this.cSize.HeaderText = "Size";
    this.cSize.Name = "cSize";
    this.cSize.Visible = false;
    this.ctmsAcc.Items.AddRange(new ToolStripItem[7]
    {
      (ToolStripItem) this.toolStripMenuItem_0,
      (ToolStripItem) this.toolStripMenuItem_2,
      (ToolStripItem) this.toolStripMenuItem1,
      (ToolStripItem) this.closeScreenToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_5,
      (ToolStripItem) this.toolStripMenuItem_3,
      (ToolStripItem) this.toolStripMenuItem_4
    });
    this.ctmsAcc.Name = "ctmsAcc";
    this.ctmsAcc.Size = new Size(151, 158);
    this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.toolStripMenuItem_1,
      (ToolStripItem) this.liveToolStripMenuItem
    });
    this.toolStripMenuItem_0.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_0.Image");
    this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
    this.toolStripMenuItem_0.Size = new Size(150, 22);
    this.toolStripMenuItem_0.Text = "Chọn";
    this.toolStripMenuItem_1.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_1.Image");
    this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
    this.toolStripMenuItem_1.Size = new Size(114, 22);
    this.toolStripMenuItem_1.Text = "Tất cả";
    this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
    this.liveToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("liveToolStripMenuItem.Image");
    this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
    this.liveToolStripMenuItem.Size = new Size(114, 22);
    this.liveToolStripMenuItem.Text = "Bôi đen";
    this.liveToolStripMenuItem.Click += new EventHandler(this.liveToolStripMenuItem_Click);
    this.toolStripMenuItem_2.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_2.Image");
    this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
    this.toolStripMenuItem_2.Size = new Size(150, 22);
    this.toolStripMenuItem_2.Text = "Bỏ chọn tất cả";
    this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
    this.toolStripMenuItem1.Image = (Image) Resources.visible_25px;
    this.toolStripMenuItem1.Name = "toolStripMenuItem1";
    this.toolStripMenuItem1.Size = new Size(150, 22);
    this.toolStripMenuItem1.Text = "Show Screen";
    this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
    this.closeScreenToolStripMenuItem.Image = (Image) Resources.icons8_hide;
    this.closeScreenToolStripMenuItem.Name = "closeScreenToolStripMenuItem";
    this.closeScreenToolStripMenuItem.Size = new Size(150, 22);
    this.closeScreenToolStripMenuItem.Text = "Close Screen";
    this.closeScreenToolStripMenuItem.Click += new EventHandler(this.closeScreenToolStripMenuItem_Click);
    this.toolStripMenuItem_5.DropDownItems.AddRange(new ToolStripItem[16]
    {
      (ToolStripItem) this.appiumToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_13,
      (ToolStripItem) this.toolStripMenuItem6,
      (ToolStripItem) this.rebootPhoneToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_8,
      (ToolStripItem) this.toolStripMenuItem8,
      (ToolStripItem) this.toolStripMenuItem_6,
      (ToolStripItem) this.gPSToolStripMenuItem,
      (ToolStripItem) this.wifiToolStripMenuItem,
      (ToolStripItem) this.facebookToolStripMenuItem2,
      (ToolStripItem) this.setupIPChoSim4GToolStripMenuItem,
      (ToolStripItem) this.proxyToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_7,
      (ToolStripItem) this.toolStripMenuItem_17,
      (ToolStripItem) this.tCPIPToolStripMenuItem,
      (ToolStripItem) this.checkProxyToolStripMenuItem
    });
    this.toolStripMenuItem_5.Image = (Image) Resources.icons8_change_30px_1;
    this.toolStripMenuItem_5.Name = "toolStripMenuItem_5";
    this.toolStripMenuItem_5.Size = new Size(150, 22);
    this.toolStripMenuItem_5.Text = "Chức năng";
    this.appiumToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.connectAppiumToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem11
    });
    this.appiumToolStripMenuItem.Name = "appiumToolStripMenuItem";
    this.appiumToolStripMenuItem.Size = new Size(214, 22);
    this.appiumToolStripMenuItem.Text = "Appium";
    this.connectAppiumToolStripMenuItem.Name = "connectAppiumToolStripMenuItem";
    this.connectAppiumToolStripMenuItem.Size = new Size(179, 22);
    this.connectAppiumToolStripMenuItem.Text = "Connect Appium";
    this.connectAppiumToolStripMenuItem.Click += new EventHandler(this.connectAppiumToolStripMenuItem_Click);
    this.toolStripMenuItem11.Name = "toolStripMenuItem11";
    this.toolStripMenuItem11.Size = new Size(179, 22);
    this.toolStripMenuItem11.Text = "Disconnect Appium";
    this.toolStripMenuItem11.Click += new EventHandler(this.toolStripMenuItem11_Click);
    this.toolStripMenuItem_13.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.switchADBKeyboardToolStripMenuItem,
      (ToolStripItem) this.setupLanguageEnglishToolStripMenuItem
    });
    this.toolStripMenuItem_13.Name = "toolStripMenuItem_13";
    this.toolStripMenuItem_13.Size = new Size(214, 22);
    this.toolStripMenuItem_13.Text = "Setup ban đầu (ẩn)";
    this.switchADBKeyboardToolStripMenuItem.Name = "switchADBKeyboardToolStripMenuItem";
    this.switchADBKeyboardToolStripMenuItem.Size = new Size(187, 22);
    this.switchADBKeyboardToolStripMenuItem.Text = "Cài ADB Keyboard";
    this.switchADBKeyboardToolStripMenuItem.Click += new EventHandler(this.switchADBKeyboardToolStripMenuItem_Click);
    this.setupLanguageEnglishToolStripMenuItem.Name = "setupLanguageEnglishToolStripMenuItem";
    this.setupLanguageEnglishToolStripMenuItem.Size = new Size(187, 22);
    this.setupLanguageEnglishToolStripMenuItem.Text = "Cài ngôn ngữ English";
    this.setupLanguageEnglishToolStripMenuItem.Click += new EventHandler(this.setupLanguageEnglishToolStripMenuItem_Click);
    this.toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[5]
    {
      (ToolStripItem) this.facebookToolStripMenuItem,
      (ToolStripItem) this.maxHelperToolStripMenuItem,
      (ToolStripItem) this.maxChangeToolStripMenuItem,
      (ToolStripItem) this.collectProxyToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_11
    });
    this.toolStripMenuItem6.Name = "toolStripMenuItem6";
    this.toolStripMenuItem6.Size = new Size(214, 22);
    this.toolStripMenuItem6.Text = "Cài app bằng file apk";
    this.toolStripMenuItem6.Click += new EventHandler(this.toolStripMenuItem6_Click);
    this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
    this.facebookToolStripMenuItem.Size = new Size(183, 22);
    this.facebookToolStripMenuItem.Text = "Facebook (ẩn)";
    this.facebookToolStripMenuItem.Click += new EventHandler(this.facebookToolStripMenuItem_Click);
    this.maxHelperToolStripMenuItem.Name = "maxHelperToolStripMenuItem";
    this.maxHelperToolStripMenuItem.Size = new Size(183, 22);
    this.maxHelperToolStripMenuItem.Text = "MaxHelper (ẩn)";
    this.maxHelperToolStripMenuItem.Click += new EventHandler(this.maxHelperToolStripMenuItem_Click);
    this.maxChangeToolStripMenuItem.Name = "maxChangeToolStripMenuItem";
    this.maxChangeToolStripMenuItem.Size = new Size(183, 22);
    this.maxChangeToolStripMenuItem.Text = "MaxChange (ẩn)";
    this.maxChangeToolStripMenuItem.Click += new EventHandler(this.maxChangeToolStripMenuItem_Click);
    this.collectProxyToolStripMenuItem.Name = "collectProxyToolStripMenuItem";
    this.collectProxyToolStripMenuItem.Size = new Size(183, 22);
    this.collectProxyToolStripMenuItem.Text = "Collect Proxy (ẩn)";
    this.collectProxyToolStripMenuItem.Click += new EventHandler(this.collectProxyToolStripMenuItem_Click);
    this.toolStripMenuItem_11.Name = "toolStripMenuItem_11";
    this.toolStripMenuItem_11.Size = new Size(183, 22);
    this.toolStripMenuItem_11.Text = "Sử dụng file apk (ẩn)";
    this.toolStripMenuItem_11.Click += new EventHandler(this.toolStripMenuItem_11_Click);
    this.rebootPhoneToolStripMenuItem.Name = "rebootPhoneToolStripMenuItem";
    this.rebootPhoneToolStripMenuItem.Size = new Size(214, 22);
    this.rebootPhoneToolStripMenuItem.Text = "Khởi động lại phone";
    this.rebootPhoneToolStripMenuItem.Click += new EventHandler(this.rebootPhoneToolStripMenuItem_Click);
    this.toolStripMenuItem_8.Name = "toolStripMenuItem_8";
    this.toolStripMenuItem_8.Size = new Size(214, 22);
    this.toolStripMenuItem_8.Text = "Tắt các app đang chạy";
    this.toolStripMenuItem_8.Click += new EventHandler(this.toolStripMenuItem_8_Click);
    this.toolStripMenuItem8.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.facebookToolStripMenuItem1,
      (ToolStripItem) this.maxChangeToolStripMenuItem1
    });
    this.toolStripMenuItem8.Name = "toolStripMenuItem8";
    this.toolStripMenuItem8.Size = new Size(214, 22);
    this.toolStripMenuItem8.Text = "Gỡ app facebook";
    this.toolStripMenuItem8.Click += new EventHandler(this.toolStripMenuItem8_Click);
    this.facebookToolStripMenuItem1.Name = "facebookToolStripMenuItem1";
    this.facebookToolStripMenuItem1.Size = new Size(161, 22);
    this.facebookToolStripMenuItem1.Text = "Facebook (ẩn)";
    this.facebookToolStripMenuItem1.Click += new EventHandler(this.facebookToolStripMenuItem1_Click);
    this.maxChangeToolStripMenuItem1.Name = "maxChangeToolStripMenuItem1";
    this.maxChangeToolStripMenuItem1.Size = new Size(161, 22);
    this.maxChangeToolStripMenuItem1.Text = "MaxChange (ẩn)";
    this.maxChangeToolStripMenuItem1.Click += new EventHandler(this.maxChangeToolStripMenuItem1_Click);
    this.toolStripMenuItem_6.DropDownItems.AddRange(new ToolStripItem[9]
    {
      (ToolStripItem) this.toolStripMenuItem_14,
      (ToolStripItem) this.setScreeToolStripMenuItem,
      (ToolStripItem) this.setScreenBrightness100ToolStripMenuItem,
      (ToolStripItem) this.lockScreenToolStripMenuItem,
      (ToolStripItem) this.unlockScreenToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem2,
      (ToolStripItem) this.sleepDEviceToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_9,
      (ToolStripItem) this.toolStripMenuItem_15
    });
    this.toolStripMenuItem_6.Name = "toolStripMenuItem_6";
    this.toolStripMenuItem_6.Size = new Size(214, 22);
    this.toolStripMenuItem_6.Text = "Màn hình";
    this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
    this.toolStripMenuItem_14.Name = "toolStripMenuItem_14";
    this.toolStripMenuItem_14.Size = new Size(175, 22);
    this.toolStripMenuItem_14.Text = "Về màn hình chính";
    this.toolStripMenuItem_14.Click += new EventHandler(this.toolStripMenuItem_14_Click);
    this.setScreeToolStripMenuItem.Name = "setScreeToolStripMenuItem";
    this.setScreeToolStripMenuItem.Size = new Size(175, 22);
    this.setScreeToolStripMenuItem.Text = "Chỉnh độ sáng 0";
    this.setScreeToolStripMenuItem.Click += new EventHandler(this.setScreeToolStripMenuItem_Click);
    this.setScreenBrightness100ToolStripMenuItem.Name = "setScreenBrightness100ToolStripMenuItem";
    this.setScreenBrightness100ToolStripMenuItem.Size = new Size(175, 22);
    this.setScreenBrightness100ToolStripMenuItem.Text = "Chỉnh độ sáng 100";
    this.setScreenBrightness100ToolStripMenuItem.Click += new EventHandler(this.setScreenBrightness100ToolStripMenuItem_Click);
    this.lockScreenToolStripMenuItem.Name = "lockScreenToolStripMenuItem";
    this.lockScreenToolStripMenuItem.Size = new Size(175, 22);
    this.lockScreenToolStripMenuItem.Text = "Khóa màn hình";
    this.lockScreenToolStripMenuItem.Click += new EventHandler(this.lockScreenToolStripMenuItem_Click);
    this.unlockScreenToolStripMenuItem.Name = "unlockScreenToolStripMenuItem";
    this.unlockScreenToolStripMenuItem.Size = new Size(175, 22);
    this.unlockScreenToolStripMenuItem.Text = "Mở khóa màn hình";
    this.unlockScreenToolStripMenuItem.Click += new EventHandler(this.unlockScreenToolStripMenuItem_Click);
    this.toolStripMenuItem2.Name = "toolStripMenuItem2";
    this.toolStripMenuItem2.Size = new Size(175, 22);
    this.toolStripMenuItem2.Text = "Bật màn hình";
    this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click_1);
    this.sleepDEviceToolStripMenuItem.Name = "sleepDEviceToolStripMenuItem";
    this.sleepDEviceToolStripMenuItem.Size = new Size(175, 22);
    this.sleepDEviceToolStripMenuItem.Text = "Tắt màn hình";
    this.sleepDEviceToolStripMenuItem.Click += new EventHandler(this.sleepDEviceToolStripMenuItem_Click);
    this.toolStripMenuItem_9.Name = "toolStripMenuItem_9";
    this.toolStripMenuItem_9.Size = new Size(175, 22);
    this.toolStripMenuItem_9.Text = "Cài hình nền";
    this.toolStripMenuItem_9.Click += new EventHandler(this.toolStripMenuItem_9_Click);
    this.toolStripMenuItem_15.Name = "toolStripMenuItem_15";
    this.toolStripMenuItem_15.Size = new Size(175, 22);
    this.toolStripMenuItem_15.Text = "Cài Dark theme";
    this.toolStripMenuItem_15.Click += new EventHandler(this.toolStripMenuItem_15_Click);
    this.gPSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.toolStripMenuItem4,
      (ToolStripItem) this.toolStripMenuItem5
    });
    this.gPSToolStripMenuItem.Name = "gPSToolStripMenuItem";
    this.gPSToolStripMenuItem.Size = new Size(214, 22);
    this.gPSToolStripMenuItem.Text = "GPS";
    this.toolStripMenuItem4.Name = "toolStripMenuItem4";
    this.toolStripMenuItem4.Size = new Size(115, 22);
    this.toolStripMenuItem4.Text = "Tắt GPS";
    this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
    this.toolStripMenuItem5.Name = "toolStripMenuItem5";
    this.toolStripMenuItem5.Size = new Size(115, 22);
    this.toolStripMenuItem5.Text = "Bật GPS";
    this.toolStripMenuItem5.Click += new EventHandler(this.toolStripMenuItem5_Click);
    this.wifiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.connectWifiToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem3,
      (ToolStripItem) this.toolStripMenuItem9
    });
    this.wifiToolStripMenuItem.Name = "wifiToolStripMenuItem";
    this.wifiToolStripMenuItem.Size = new Size(214, 22);
    this.wifiToolStripMenuItem.Text = "Wifi";
    this.connectWifiToolStripMenuItem.Name = "connectWifiToolStripMenuItem";
    this.connectWifiToolStripMenuItem.Size = new Size(135, 22);
    this.connectWifiToolStripMenuItem.Text = "Kết nối Wifi";
    this.connectWifiToolStripMenuItem.Click += new EventHandler(this.connectWifiToolStripMenuItem_Click);
    this.toolStripMenuItem3.Name = "toolStripMenuItem3";
    this.toolStripMenuItem3.Size = new Size(135, 22);
    this.toolStripMenuItem3.Text = "Tắt Wifi";
    this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
    this.toolStripMenuItem9.Name = "toolStripMenuItem9";
    this.toolStripMenuItem9.Size = new Size(135, 22);
    this.toolStripMenuItem9.Text = "Bật Wifi";
    this.toolStripMenuItem9.Click += new EventHandler(this.toolStripMenuItem9_Click);
    this.facebookToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[6]
    {
      (ToolStripItem) this.backupDataToolStripMenuItem,
      (ToolStripItem) this.getUidToolStripMenuItem,
      (ToolStripItem) this.getCookieToolStripMenuItem,
      (ToolStripItem) this.getTokenToolStripMenuItem,
      (ToolStripItem) this.getInfoAccToolStripMenuItem,
      (ToolStripItem) this.clearDataAppFbToolStripMenuItem
    });
    this.facebookToolStripMenuItem2.Name = "facebookToolStripMenuItem2";
    this.facebookToolStripMenuItem2.Size = new Size(214, 22);
    this.facebookToolStripMenuItem2.Text = "Facebook";
    this.backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
    this.backupDataToolStripMenuItem.Size = new Size(164, 22);
    this.backupDataToolStripMenuItem.Text = "Backup data";
    this.backupDataToolStripMenuItem.Click += new EventHandler(this.backupDataToolStripMenuItem_Click);
    this.getUidToolStripMenuItem.Name = "getUidToolStripMenuItem";
    this.getUidToolStripMenuItem.Size = new Size(164, 22);
    this.getUidToolStripMenuItem.Text = "Get Uid";
    this.getUidToolStripMenuItem.Click += new EventHandler(this.getUidToolStripMenuItem_Click);
    this.getCookieToolStripMenuItem.Name = "getCookieToolStripMenuItem";
    this.getCookieToolStripMenuItem.Size = new Size(164, 22);
    this.getCookieToolStripMenuItem.Text = "Get Cookie";
    this.getCookieToolStripMenuItem.Click += new EventHandler(this.getCookieToolStripMenuItem_Click);
    this.getTokenToolStripMenuItem.Name = "getTokenToolStripMenuItem";
    this.getTokenToolStripMenuItem.Size = new Size(164, 22);
    this.getTokenToolStripMenuItem.Text = "Get Token";
    this.getTokenToolStripMenuItem.Click += new EventHandler(this.getTokenToolStripMenuItem_Click);
    this.getInfoAccToolStripMenuItem.Name = "getInfoAccToolStripMenuItem";
    this.getInfoAccToolStripMenuItem.Size = new Size(164, 22);
    this.getInfoAccToolStripMenuItem.Text = "Get Info Account";
    this.getInfoAccToolStripMenuItem.Click += new EventHandler(this.getInfoAccToolStripMenuItem_Click);
    this.clearDataAppFbToolStripMenuItem.Name = "clearDataAppFbToolStripMenuItem";
    this.clearDataAppFbToolStripMenuItem.Size = new Size(164, 22);
    this.clearDataAppFbToolStripMenuItem.Text = "Xóa dữ liệu App";
    this.clearDataAppFbToolStripMenuItem.Click += new EventHandler(this.clearDataAppFbToolStripMenuItem_Click);
    this.setupIPChoSim4GToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.iPv4ToolStripMenuItem,
      (ToolStripItem) this.iPv6ToolStripMenuItem,
      (ToolStripItem) this.iPv4IPv6ToolStripMenuItem
    });
    this.setupIPChoSim4GToolStripMenuItem.Name = "setupIPChoSim4GToolStripMenuItem";
    this.setupIPChoSim4GToolStripMenuItem.Size = new Size(214, 22);
    this.setupIPChoSim4GToolStripMenuItem.Text = "Tùy chọn IP cho sim 4G";
    this.iPv4ToolStripMenuItem.Name = "iPv4ToolStripMenuItem";
    this.iPv4ToolStripMenuItem.Size = new Size(123, 22);
    this.iPv4ToolStripMenuItem.Text = "IPv4";
    this.iPv4ToolStripMenuItem.Click += new EventHandler(this.iPv4ToolStripMenuItem_Click);
    this.iPv6ToolStripMenuItem.Name = "iPv6ToolStripMenuItem";
    this.iPv6ToolStripMenuItem.Size = new Size(123, 22);
    this.iPv6ToolStripMenuItem.Text = "IPv6";
    this.iPv6ToolStripMenuItem.Click += new EventHandler(this.iPv6ToolStripMenuItem_Click);
    this.iPv4IPv6ToolStripMenuItem.Name = "iPv4IPv6ToolStripMenuItem";
    this.iPv4IPv6ToolStripMenuItem.Size = new Size(123, 22);
    this.iPv4IPv6ToolStripMenuItem.Text = "IPv4/IPv6";
    this.iPv4IPv6ToolStripMenuItem.Click += new EventHandler(this.iPv4IPv6ToolStripMenuItem_Click);
    this.proxyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.xToolStripMenuItem,
      (ToolStripItem) this.removeProxyToolStripMenuItem,
      (ToolStripItem) this.checkIPToolStripMenuItem
    });
    this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
    this.proxyToolStripMenuItem.Size = new Size(214, 22);
    this.proxyToolStripMenuItem.Text = "Proxy";
    this.xToolStripMenuItem.Name = "xToolStripMenuItem";
    this.xToolStripMenuItem.Size = new Size(151, 22);
    this.xToolStripMenuItem.Text = "Connect Proxy";
    this.xToolStripMenuItem.Click += new EventHandler(this.xToolStripMenuItem_Click);
    this.removeProxyToolStripMenuItem.Name = "removeProxyToolStripMenuItem";
    this.removeProxyToolStripMenuItem.Size = new Size(151, 22);
    this.removeProxyToolStripMenuItem.Text = "Xóa Proxy";
    this.removeProxyToolStripMenuItem.Click += new EventHandler(this.removeProxyToolStripMenuItem_Click);
    this.checkIPToolStripMenuItem.Name = "checkIPToolStripMenuItem";
    this.checkIPToolStripMenuItem.Size = new Size(151, 22);
    this.checkIPToolStripMenuItem.Text = "Check IP";
    this.checkIPToolStripMenuItem.Click += new EventHandler(this.checkIPToolStripMenuItem_Click);
    this.toolStripMenuItem_7.DropDownItems.AddRange(new ToolStripItem[10]
    {
      (ToolStripItem) this.checkAboutPhoneToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_12,
      (ToolStripItem) this.toolStripMenuItem_16,
      (ToolStripItem) this.setMediaVolumn0ToolStripMenuItem,
      (ToolStripItem) this.disableBluetoothToolStripMenuItem,
      (ToolStripItem) this.disableRotateScreenToolStripMenuItem,
      (ToolStripItem) this.grantShellMagiskToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_10,
      (ToolStripItem) this.shutdownPhoneToolStripMenuItem,
      (ToolStripItem) this.toolStripMenuItem_18
    });
    this.toolStripMenuItem_7.Name = "toolStripMenuItem_7";
    this.toolStripMenuItem_7.Size = new Size(214, 22);
    this.toolStripMenuItem_7.Text = "Khác";
    this.checkAboutPhoneToolStripMenuItem.Name = "checkAboutPhoneToolStripMenuItem";
    this.checkAboutPhoneToolStripMenuItem.Size = new Size(239, 22);
    this.checkAboutPhoneToolStripMenuItem.Text = "Check About Phone";
    this.checkAboutPhoneToolStripMenuItem.Click += new EventHandler(this.checkAboutPhoneToolStripMenuItem_Click);
    this.toolStripMenuItem_12.Name = "toolStripMenuItem_12";
    this.toolStripMenuItem_12.Size = new Size(239, 22);
    this.toolStripMenuItem_12.Text = "Chuyển sang bàn phím thường";
    this.toolStripMenuItem_12.Click += new EventHandler(this.toolStripMenuItem_12_Click);
    this.toolStripMenuItem_16.Name = "toolStripMenuItem_16";
    this.toolStripMenuItem_16.Size = new Size(239, 22);
    this.toolStripMenuItem_16.Text = "Bật chế độ Không làm phiền";
    this.toolStripMenuItem_16.Click += new EventHandler(this.toolStripMenuItem_16_Click);
    this.setMediaVolumn0ToolStripMenuItem.Name = "setMediaVolumn0ToolStripMenuItem";
    this.setMediaVolumn0ToolStripMenuItem.Size = new Size(239, 22);
    this.setMediaVolumn0ToolStripMenuItem.Text = "Chỉnh âm thanh 0 (ẩn)";
    this.setMediaVolumn0ToolStripMenuItem.Click += new EventHandler(this.setMediaVolumn0ToolStripMenuItem_Click);
    this.disableBluetoothToolStripMenuItem.Name = "disableBluetoothToolStripMenuItem";
    this.disableBluetoothToolStripMenuItem.Size = new Size(239, 22);
    this.disableBluetoothToolStripMenuItem.Text = "Tắt Bluetooth";
    this.disableBluetoothToolStripMenuItem.Click += new EventHandler(this.disableBluetoothToolStripMenuItem_Click);
    this.disableRotateScreenToolStripMenuItem.Name = "disableRotateScreenToolStripMenuItem";
    this.disableRotateScreenToolStripMenuItem.Size = new Size(239, 22);
    this.disableRotateScreenToolStripMenuItem.Text = "Tắt xoay màn hình";
    this.disableRotateScreenToolStripMenuItem.Click += new EventHandler(this.disableRotateScreenToolStripMenuItem_Click);
    this.grantShellMagiskToolStripMenuItem.Name = "grantShellMagiskToolStripMenuItem";
    this.grantShellMagiskToolStripMenuItem.Size = new Size(239, 22);
    this.grantShellMagiskToolStripMenuItem.Text = "Grant Shell Magisk";
    this.grantShellMagiskToolStripMenuItem.Click += new EventHandler(this.grantShellMagiskToolStripMenuItem_Click);
    this.toolStripMenuItem_10.Name = "toolStripMenuItem_10";
    this.toolStripMenuItem_10.Size = new Size(239, 22);
    this.toolStripMenuItem_10.Text = "Check IP bằng browser";
    this.toolStripMenuItem_10.Click += new EventHandler(this.toolStripMenuItem_10_Click);
    this.shutdownPhoneToolStripMenuItem.Name = "shutdownPhoneToolStripMenuItem";
    this.shutdownPhoneToolStripMenuItem.Size = new Size(239, 22);
    this.shutdownPhoneToolStripMenuItem.Text = "Shutdown phone";
    this.shutdownPhoneToolStripMenuItem.Click += new EventHandler(this.shutdownPhoneToolStripMenuItem_Click);
    this.toolStripMenuItem_18.Name = "toolStripMenuItem_18";
    this.toolStripMenuItem_18.Size = new Size(239, 22);
    this.toolStripMenuItem_18.Text = "Setup LTE";
    this.toolStripMenuItem_18.Click += new EventHandler(this.toolStripMenuItem_18_Click);
    this.toolStripMenuItem_17.Name = "toolStripMenuItem_17";
    this.toolStripMenuItem_17.Size = new Size(214, 22);
    this.toolStripMenuItem_17.Text = "Cài Room Fomat Recovery";
    this.toolStripMenuItem_17.Click += new EventHandler(this.toolStripMenuItem_17_Click);
    this.tCPIPToolStripMenuItem.Name = "tCPIPToolStripMenuItem";
    this.tCPIPToolStripMenuItem.Size = new Size(214, 22);
    this.tCPIPToolStripMenuItem.Text = "Connect TCP/IP";
    this.tCPIPToolStripMenuItem.Click += new EventHandler(this.tCPIPToolStripMenuItem_Click);
    this.checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
    this.checkProxyToolStripMenuItem.Size = new Size(214, 22);
    this.checkProxyToolStripMenuItem.Text = "Check Proxy";
    this.checkProxyToolStripMenuItem.Click += new EventHandler(this.checkProxyToolStripMenuItem_Click);
    this.toolStripMenuItem_3.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_3.Image");
    this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
    this.toolStripMenuItem_3.Size = new Size(150, 22);
    this.toolStripMenuItem_3.Text = "Xóa dòng";
    this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
    this.toolStripMenuItem_4.Image = (Image) componentResourceManager.GetObject("toolStripMenuItem_4.Image");
    this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
    this.toolStripMenuItem_4.Size = new Size(150, 22);
    this.toolStripMenuItem_4.Text = "Load Device";
    this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.SaddleBrown;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(1, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(1434, 38);
    this.bunifuCards1.TabIndex = 2;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button11);
    this.pnlHeader.Controls.Add((Control) this.btnClose);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Location = new Point(0, 5);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(1435, 32);
    this.pnlHeader.TabIndex = 9;
    this.button11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button11.Cursor = Cursors.Hand;
    this.button11.Location = new Point(3, 3);
    this.button11.Name = "button11";
    this.button11.Size = new Size(67, 26);
    this.button11.TabIndex = 3;
    this.button11.Text = "Bỏ all";
    this.button11.UseVisualStyleBackColor = true;
    this.button11.Click += new EventHandler(this.button11_Click);
    this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnClose.Cursor = Cursors.Hand;
    this.btnClose.FlatAppearance.BorderSize = 0;
    this.btnClose.FlatStyle = FlatStyle.Flat;
    this.btnClose.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnClose.ForeColor = Color.White;
    this.btnClose.Image = (Image) componentResourceManager.GetObject("btnClose.Image");
    this.btnClose.Location = new Point(1401, -1);
    this.btnClose.Name = "btnClose";
    this.btnClose.Size = new Size(32, 32);
    this.btnClose.TabIndex = 9;
    this.btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnClose.UseVisualStyleBackColor = true;
    this.btnClose.Click += new EventHandler(this.btnClose_Click);
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1439, 884);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fDeviceList);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Quản lý phone";
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.groupBox3.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    this.groupBox4.ResumeLayout(false);
    this.numdelayluong.EndInit();
    this.nudPercentDoSang.EndInit();
    this.nudThreadPhone.EndInit();
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    this.nudSort.EndInit();
    this.statusStrip1.ResumeLayout(false);
    this.statusStrip1.PerformLayout();
    ((ISupportInitialize) this.dtgvAcc).EndInit();
    this.ctmsAcc.ResumeLayout(false);
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void bunifuCustomLabel1_Click(object sender, EventArgs e)
  {
  }

  private void nudThreadPhone_ValueChanged(object sender, EventArgs e)
  {
  }

  private void bToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void ckbTatBluetooth_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void ckbonflashlightsuper_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void ckbTatWifi_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void ckbPowerpin_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void ckboffflashlightsuper_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void toolStripMenuItem2_Click_1(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "OnSleepDevice"
  });

  private void checkBox1_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void button8_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "ClearDataAppFb"
  });

  private void button9_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "GetUid"
  });

  private void button10_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "BackupData"
  });

  private void button11_Click(object sender, EventArgs e) => this.method_5("UnAll");

  private void button12_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetPin"
  });

  private void button13_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "CheckIP"
  });

  private void button14_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "RebootPhone"
  });

  private void button15_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "Onflashlightsuper"
  });

  private void button16_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "Offflashlightsuper"
  });

  private void button17_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "SetMediaVolumn0"
  });

  private void button18_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "CloseAllApp"
  });

  private void button19_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "GotoHome"
  });

  private void ckbChinhAmThanh0_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void numdelayluong_ValueChanged(object sender, EventArgs e)
  {
  }

  private void button20_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "OpenLinkRegFbApp"
  });

  private void button21_Click(object sender, EventArgs e)
  {
  }

  private void button21_Click_1(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "Offmaybay"
  });

  private void button22_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "Onmaybay"
  });

  private void button23_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "DisableBluetooth"
  });

  private void button24_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "DisableGPS"
  });

  private void button25_Click(object sender, EventArgs e) => this.method_13(new List<string>()
  {
    "DisconnectWifi"
  });
}
