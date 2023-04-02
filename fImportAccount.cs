// Decompiled with JetBrains decompiler
// Type: fImportAccount
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
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public class fImportAccount : Form
{
  public static bool bool_0 = false;
  public static int int_0 = -1;
  public static bool bool_1 = false;
  private List<ComboBox> list_0;
  private int int_1 = 0;
  private List<string> list_1 = new List<string>();
  private List<Thread> list_2 = (List<Thread>) null;
  private object object_0 = new object();
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button btnAdd;
  private Button btnCancel;
  private Label lblSuccess;
  private Label lblError;
  private Label lblWallDie;
  private Label lblTotal;
  private Label lblWallLive;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label7;
  private Label lblStatus;
  private Label label8;
  private ComboBox cbbDinhDangNhap;
  private ComboBox cbbDinhDang1;
  private Label label9;
  private ComboBox cbbDinhDang2;
  private Label label10;
  private ComboBox cbbDinhDang3;
  private Label label11;
  private ComboBox cbbDinhDang4;
  private Label label12;
  private ComboBox cbbDinhDang5;
  private Label label13;
  private ComboBox cbbDinhDang6;
  private Label label14;
  private ComboBox cbbDinhDang7;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private Panel plDinhDangNhap;
  private Label label16;
  private ComboBox cbbThuMuc;
  private Button button1;
  private RichTextBox txbAccount;
  private Label label18;
  private Label label17;
  private ComboBox cbbDinhDang8;
  private ComboBox cbbDinhDang9;
  private Button btnMinimize;
  private Label lblKhongCheckDuoc;
  private IContainer components;
  private Button button2;
  private Button button3;
  private Label label2;

  public fImportAccount(string string_0)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.method_0();
    if (string_0 != "" && string_0 != "-1" && string_0 != "999999")
      this.cbbThuMuc.SelectedValue = (object) string_0;
    this.cbbDinhDangNhap.SelectedIndex = 0;
    this.list_0 = new List<ComboBox>()
    {
      this.cbbDinhDang1,
      this.cbbDinhDang2,
      this.cbbDinhDang3,
      this.cbbDinhDang4,
      this.cbbDinhDang5,
      this.cbbDinhDang6,
      this.cbbDinhDang7,
      this.cbbDinhDang8,
      this.cbbDinhDang9
    };
    fImportAccount.bool_1 = false;
    fImportAccount.bool_0 = false;
    fImportAccount.int_0 = -1;
  }

  private void method_0()
  {
    this.int_1 = this.cbbThuMuc.SelectedIndex;
    DataTable dataTable = Class42.smethod_1();
    if (dataTable.Rows.Count <= 0)
      return;
    this.cbbThuMuc.DataSource = (object) dataTable;
    this.cbbThuMuc.ValueMember = "id";
    this.cbbThuMuc.DisplayMember = "name";
    if (this.int_1 == -1)
      this.int_1 = 0;
    this.cbbThuMuc.SelectedIndex = this.int_1;
  }

  private void method_1()
  {
    GClass35.smethod_1((Control) this.bunifuCustomLabel1);
    GClass35.smethod_1((Control) this.label3);
    GClass35.smethod_1((Control) this.label4);
    GClass35.smethod_1((Control) this.label5);
    GClass35.smethod_1((Control) this.label6);
    GClass35.smethod_1((Control) this.label2);
    GClass35.smethod_1((Control) this.label7);
    GClass35.smethod_1((Control) this.label16);
    GClass35.smethod_1((Control) this.button1);
    GClass35.smethod_1((Control) this.label8);
    GClass35.smethod_1((Control) this.btnAdd);
    GClass35.smethod_1((Control) this.btnCancel);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    try
    {
      List<string> stringList = GClass19.smethod_39(((IEnumerable<string>) this.txbAccount.Lines).ToList<string>());
      if (stringList.Count == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng nhập thông tin tài khoản!"), 3);
        this.txbAccount.Focus();
      }
      else if (this.cbbThuMuc.SelectedValue == null)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn thư mục!"), 3);
      }
      else
      {
        string string_1 = this.cbbThuMuc.SelectedValue.ToString();
        bool bool_0 = false;
        int selectedIndex = this.cbbDinhDangNhap.SelectedIndex;
        if (selectedIndex == 6)
        {
          bool flag = false;
          for (int index = 0; index < this.list_0.Count; ++index)
          {
            if (this.list_0[index].SelectedIndex > -1)
            {
              flag = true;
              break;
            }
          }
          if (!flag)
          {
            GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng chọn định dạng tài khoản!"), 3);
            return;
          }
        }
        int int_0 = 100;
        if (stringList.Count < 100)
          int_0 = stringList.Count;
        this.lblSuccess.Text = "0";
        this.lblError.Text = "0";
        this.lblWallDie.Text = "0";
        this.lblKhongCheckDuoc.Text = "0";
        this.lblWallLive.Text = "0";
        this.list_1 = new List<string>();
        string[] string_0;
        switch (selectedIndex)
        {
          case 0:
            int num1 = 3;
            for (int index = 0; index < stringList.Count; ++index)
            {
              string_0 = stringList[index].Split('|');
              if (((IEnumerable<string>) string_0).Count<string>() >= num1)
                this.list_1.Add(string_0[0] + "|" + string_0[1] + "|||||" + string_0[2] + "||||");
              else
                this.method_3(this.lblError);
            }
            break;
          case 1:
            for (int index = 0; index < stringList.Count; ++index)
              this.list_1.Add("|||" + stringList[index] + "|||||||");
            break;
          case 2:
            int num2 = 2;
            for (int index = 0; index < stringList.Count; ++index)
            {
              string_0 = stringList[index].Split('|');
              if (((IEnumerable<string>) string_0).Count<string>() >= num2)
                this.list_1.Add(string_0[0] + "|" + string_0[1] + "|||||||||");
              else
                this.method_3(this.lblError);
            }
            break;
          case 3:
            int num3 = 4;
            for (int index = 0; index < stringList.Count; ++index)
            {
              string_0 = stringList[index].Split('|');
              if (((IEnumerable<string>) string_0).Count<string>() >= num3)
                this.list_1.Add(string_0[0] + "|" + string_0[1] + "|" + string_0[2] + "|" + string_0[3] + "|||||||");
              else
                this.method_3(this.lblError);
            }
            break;
          case 4:
            int num4 = 6;
            for (int index = 0; index < stringList.Count; ++index)
            {
              string_0 = stringList[index].Split('|');
              if (((IEnumerable<string>) string_0).Count<string>() >= num4)
                this.list_1.Add(string_0[0] + "|" + string_0[1] + "|" + string_0[2] + "|" + string_0[3] + "|" + string_0[4] + "|" + string_0[5] + "|||||");
              else
                this.method_3(this.lblError);
            }
            break;
          case 5:
            int num5 = 7;
            for (int index = 0; index < stringList.Count; ++index)
            {
              string_0 = stringList[index].Split('|');
              if (((IEnumerable<string>) string_0).Count<string>() >= num5)
                this.list_1.Add(string_0[0] + "|" + string_0[1] + "|" + string_0[2] + "|" + string_0[3] + "|" + string_0[4] + "|" + string_0[5] + "|" + string_0[6] + "||||");
              else
                this.method_3(this.lblError);
            }
            break;
          case 6:
            for (int index1 = 0; index1 < stringList.Count; ++index1)
            {
              string_0 = stringList[index1].Split('|');
              string str1 = "";
              string str2 = "";
              string str3 = "";
              string str4 = "";
              string str5 = "";
              string str6 = "";
              string str7 = "";
              string str8 = "";
              string str9 = "";
              string str10 = "";
              string str11 = "";
              try
              {
                for (int index2 = 0; index2 < this.list_0.Count; ++index2)
                {
                  switch (this.list_0[index2].SelectedIndex)
                  {
                    case 0:
                      str1 = string_0[index2];
                      break;
                    case 1:
                      str2 = string_0[index2];
                      break;
                    case 2:
                      str3 = string_0[index2];
                      break;
                    case 3:
                      str4 = string_0[index2];
                      break;
                    case 4:
                      str5 = string_0[index2];
                      break;
                    case 5:
                      str6 = string_0[index2];
                      break;
                    case 6:
                      str7 = string_0[index2];
                      break;
                    case 7:
                      str8 = string_0[index2];
                      break;
                    case 8:
                      str9 = !(string_0[index2].Trim() == "") ? string_0[index2] + "*0" : "";
                      break;
                    case 9:
                      str10 = string_0[index2];
                      break;
                    case 10:
                      str11 = string_0[index2];
                      break;
                  }
                }
                this.list_1.Add(str1 + "|" + str2 + "|" + str3 + "|" + str4 + "|" + str5 + "|" + str6 + "|" + str7 + "|" + str8 + "|" + str9 + "|" + str10 + "|" + str11);
              }
              catch
              {
                this.method_3(this.lblError);
              }
            }
            break;
        }
        List<string> list_0 = new List<string>();
        this.list_2 = new List<Thread>();
        new Thread((ThreadStart) (() =>
        {
          try
          {
            this.btnAdd.Invoke((Delegate) (() => this.btnAdd.Enabled = false));
            this.method_2(GClass35.smethod_0("Chuẩn bị thêm tài khoản..."), this.lblStatus);
            if (bool_0)
            {
              int num6 = 0;
              while (num6 < this.list_1.Count)
              {
                if (this.list_2.Count < int_0)
                {
                  int int_ = num6++;
                  this.method_2(string.Format(GClass35.smethod_0("Đang check thông tin {0}/{1}..."), (object) num6, (object) this.list_1.Count), this.lblStatus);
                  Thread thread = new Thread((ThreadStart) (() =>
                  {
                    try
                    {
                      string str15 = this.list_1[int_];
                      if (str15.Trim() == "")
                        return;
                      string[] strArray = str15.Split('|');
                      string string_0_2 = strArray[0];
                      string string_1_2 = strArray[1];
                      string string_2 = strArray[2];
                      string str16 = strArray[3];
                      string string_4 = strArray[4];
                      string string_13 = strArray[5];
                      string string_11 = strArray[6];
                      string string_14 = strArray[7];
                      string string_15 = strArray[8];
                      string string_8 = strArray[9];
                      string string_16 = strArray[10];
                      string string_5 = "";
                      string string_6 = "";
                      string string_7 = "";
                      string string_9 = "";
                      string string_10 = "unknow";
                      if (string_0_2 == "")
                        string_0_2 = Regex.Match(str16, "c_user=(.*?);").Groups[1].Value;
                      if (string_0_2 == "")
                      {
                        string_10 = "Die";
                      }
                      else
                      {
                        string str17 = Class38.smethod_19(string_0_2);
                        if (str17.StartsWith("0|"))
                        {
                          if (Class38.smethod_17(string_0_2).StartsWith("0|"))
                            string_10 = "Die";
                        }
                        else if (str17.StartsWith("1|"))
                        {
                          string_0 = str17.Split('|');
                          string_5 = string_0[2];
                          string_9 = string_0[3].ToLower();
                          string_8 = string_0[4];
                          string_6 = string_0[5];
                          string_7 = string_0[6];
                          string_10 = "Live";
                        }
                      }
                      switch (string_10)
                      {
                        case "Live":
                          this.method_3(this.lblWallLive);
                          break;
                        case "Die":
                          this.method_3(this.lblWallDie);
                          break;
                        default:
                          this.method_3(this.lblKhongCheckDuoc);
                          break;
                      }
                      list_0.Add(Class42.smethod_12(string_0_2, string_1_2, string_2, str16, string_4, string_5, string_6, string_7, string_8, string_9, string_10, string_11, string_1, string_13, string_14, string_15, string_16));
                    }
                    catch
                    {
                    }
                  }));
                  this.list_2.Add(thread);
                  thread.IsBackground = true;
                  thread.Start();
                }
                else
                {
                  for (int index = 0; index < this.list_2.Count; ++index)
                  {
                    if (!this.list_2[index].IsAlive)
                      this.list_2.RemoveAt(index--);
                  }
                }
              }
              for (int index = 0; index < this.list_2.Count; ++index)
                this.list_2[index].Join();
            }
            else
            {
              for (int index = 0; index < this.list_1.Count; ++index)
              {
                try
                {
                  string str18 = this.list_1[index];
                  if (str18.Trim() == "")
                    return;
                  string[] strArray = str18.Split('|');
                  string string_0_3 = strArray[0];
                  string string_1_3 = strArray[1];
                  string string_2 = strArray[2];
                  string str19 = strArray[3];
                  string string_4 = strArray[4];
                  string string_13 = strArray[5];
                  string string_11 = strArray[6];
                  string string_14 = strArray[7];
                  string string_15 = strArray[8];
                  string string_8 = strArray[9];
                  string string_16 = strArray[10];
                  string string_5 = "";
                  string string_6 = "";
                  string string_7 = "";
                  string string_9 = "";
                  string string_10 = "unknow";
                  if (string_0_3 == "")
                    string_0_3 = Regex.Match(str19, "c_user=(.*?);").Groups[1].Value;
                  list_0.Add(Class42.smethod_12(string_0_3, string_1_3, string_2, str19, string_4, string_5, string_6, string_7, string_8, string_9, string_10, string_11, string_1, string_13, string_14, string_15, string_16));
                }
                catch
                {
                }
              }
            }
            this.method_2(GClass35.smethod_0("Đang thêm tài khoản..."), this.lblStatus);
            if (list_0.Count >= 0)
            {
              list_0 = Class42.smethod_11(list_0);
              for (int index = 0; index < list_0.Count; ++index)
                this.method_3(this.lblSuccess, GClass17.GClass17_0.method_4(list_0[index]));
            }
            this.method_2((Convert.ToInt32(this.lblTotal.Text) - Convert.ToInt32(this.lblSuccess.Text)).ToString() ?? "", this.lblError);
            this.btnAdd.Invoke((Delegate) (() => this.btnAdd.Enabled = true));
            GClass14.smethod_0((object) GClass35.smethod_0("Thêm tài khoản thành công!"));
            this.method_2(GClass35.smethod_0("Thêm tài khoản thành công!"), this.lblStatus);
            fImportAccount.bool_0 = true;
            fImportAccount.int_0 = Convert.ToInt32(string_1);
          }
          catch (Exception ex)
          {
            GClass19.smethod_79((GClass18) null, ex, "AddAccount");
          }
        }))
        {
          IsBackground = true
        }.Start();
      }
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
      GClass19.smethod_79((GClass18) null, ex, "AddAccount");
    }
  }

  private void method_2(string string_0, Label label_0) => label_0.Invoke((Delegate) (() =>
  {
    Application.DoEvents();
    label_0.Text = string_0;
  }));

  private void txbAccount_TextChanged(object sender, EventArgs e)
  {
    try
    {
      this.lblTotal.Text = GClass19.smethod_39(((IEnumerable<string>) this.txbAccount.Lines).ToList<string>()).Count.ToString();
    }
    catch
    {
    }
  }

  private void method_3(Label label_0, int int_2 = -1)
  {
    if (int_2 == -1)
      label_0.Invoke((Delegate) (() =>
      {
        Application.DoEvents();
        label_0.Text = (Convert.ToInt32(label_0.Text) + (int_2 == -1 ? 1 : int_2)).ToString();
      }));
    else
      label_0.Invoke((Delegate) (() =>
      {
        Application.DoEvents();
        label_0.Text = (Convert.ToInt32(label_0.Text) + int_2).ToString();
      }));
  }

  private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
  {
    this.plDinhDangNhap.Visible = this.cbbDinhDangNhap.SelectedIndex == this.cbbDinhDangNhap.Items.Count - 1;
    if (!this.plDinhDangNhap.Visible)
      return;
    this.method_71();
  }

  private void button1_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fAddFile());
    if (!fAddFile.bool_0)
      return;
    this.method_0();
    this.cbbThuMuc.SelectedIndex = this.cbbThuMuc.Items.Count - 1;
    fImportAccount.bool_1 = true;
  }

  private bool method_4()
  {
    bool flag = false;
    List<int> intList = new List<int>();
    for (int index = 0; index < this.list_0.Count; ++index)
    {
      int selectedIndex = this.list_0[index].SelectedIndex;
      if (selectedIndex != -1)
      {
        if (intList.Contains(selectedIndex))
        {
          flag = true;
          break;
        }
        intList.Add(selectedIndex);
      }
    }
    return flag;
  }

  private void cbbDinhDang9_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (!this.method_4())
      return;
    GClass14.smethod_0((object) GClass35.smethod_0("Tùy chọn này đã tồn tại, vui lòng chọn tùy chọn khác!"), 3);
    (sender as ComboBox).SelectedIndex = -1;
  }

  private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
  {
  }

  private void method_5(object sender, EventArgs e)
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fImportAccount));
    this.bunifuCards1 = new BunifuCards();
    this.pnlHeader = new Panel();
    this.btnMinimize = new Button();
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.btnAdd = new Button();
    this.btnCancel = new Button();
    this.lblSuccess = new Label();
    this.lblError = new Label();
    this.lblWallDie = new Label();
    this.lblTotal = new Label();
    this.lblWallLive = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.lblStatus = new Label();
    this.label8 = new Label();
    this.cbbDinhDangNhap = new ComboBox();
    this.cbbDinhDang1 = new ComboBox();
    this.label9 = new Label();
    this.cbbDinhDang2 = new ComboBox();
    this.label10 = new Label();
    this.cbbDinhDang3 = new ComboBox();
    this.label11 = new Label();
    this.cbbDinhDang4 = new ComboBox();
    this.label12 = new Label();
    this.cbbDinhDang5 = new ComboBox();
    this.label13 = new Label();
    this.cbbDinhDang6 = new ComboBox();
    this.label14 = new Label();
    this.cbbDinhDang7 = new ComboBox();
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.plDinhDangNhap = new Panel();
    this.button3 = new Button();
    this.button2 = new Button();
    this.label18 = new Label();
    this.label17 = new Label();
    this.cbbDinhDang8 = new ComboBox();
    this.cbbDinhDang9 = new ComboBox();
    this.label16 = new Label();
    this.cbbThuMuc = new ComboBox();
    this.button1 = new Button();
    this.txbAccount = new RichTextBox();
    this.lblKhongCheckDuoc = new Label();
    this.label2 = new Label();
    this.bunifuCards1.SuspendLayout();
    this.pnlHeader.SuspendLayout();
    this.plDinhDangNhap.SuspendLayout();
    this.SuspendLayout();
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.DarkViolet;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.Dock = DockStyle.Top;
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(0, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(953, 37);
    this.bunifuCards1.TabIndex = 11;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.btnMinimize);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(953, 31);
    this.pnlHeader.TabIndex = 9;
    this.btnMinimize.Cursor = Cursors.Hand;
    this.btnMinimize.FlatAppearance.BorderSize = 0;
    this.btnMinimize.FlatStyle = FlatStyle.Flat;
    this.btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.btnMinimize.ForeColor = Color.White;
    this.btnMinimize.Image = (Image) componentResourceManager.GetObject("btnMinimize.Image");
    this.btnMinimize.Location = new Point(921, 1);
    this.btnMinimize.Name = "btnMinimize";
    this.btnMinimize.Size = new Size(30, 30);
    this.btnMinimize.TabIndex = 9;
    this.btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.btnMinimize.UseVisualStyleBackColor = true;
    this.btnMinimize.Click += new EventHandler(this.btnCancel_Click);
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(953, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Nhập Tài Khoản";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.btnAdd.Anchor = AnchorStyles.Bottom;
    this.btnAdd.BackColor = Color.FromArgb(53, 120, 229);
    this.btnAdd.Cursor = Cursors.Hand;
    this.btnAdd.FlatAppearance.BorderSize = 0;
    this.btnAdd.FlatStyle = FlatStyle.Flat;
    this.btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnAdd.ForeColor = Color.White;
    this.btnAdd.Location = new Point(364, 503);
    this.btnAdd.Name = "btnAdd";
    this.btnAdd.Size = new Size(107, 31);
    this.btnAdd.TabIndex = 13;
    this.btnAdd.Text = "Thêm";
    this.btnAdd.UseVisualStyleBackColor = false;
    this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
    this.btnCancel.Anchor = AnchorStyles.Bottom;
    this.btnCancel.BackColor = Color.Maroon;
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatAppearance.BorderSize = 0;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCancel.ForeColor = Color.White;
    this.btnCancel.Location = new Point(478, 503);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(107, 31);
    this.btnCancel.TabIndex = 14;
    this.btnCancel.Text = "Đóng";
    this.btnCancel.UseVisualStyleBackColor = false;
    this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    this.lblSuccess.AutoSize = true;
    this.lblSuccess.BackColor = SystemColors.Control;
    this.lblSuccess.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblSuccess.ForeColor = Color.FromArgb(53, 120, 229);
    this.lblSuccess.Location = new Point(106, 51);
    this.lblSuccess.Name = "lblSuccess";
    this.lblSuccess.Size = new Size(19, 19);
    this.lblSuccess.TabIndex = 23;
    this.lblSuccess.Text = "0";
    this.lblError.AutoSize = true;
    this.lblError.BackColor = SystemColors.Control;
    this.lblError.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblError.ForeColor = Color.FromArgb(192, 64, 0);
    this.lblError.Location = new Point(218, 51);
    this.lblError.Name = "lblError";
    this.lblError.Size = new Size(19, 19);
    this.lblError.TabIndex = 24;
    this.lblError.Text = "0";
    this.lblWallDie.AutoSize = true;
    this.lblWallDie.BackColor = SystemColors.Control;
    this.lblWallDie.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblWallDie.ForeColor = Color.FromArgb(192, 0, 0);
    this.lblWallDie.Location = new Point(498, 51);
    this.lblWallDie.Name = "lblWallDie";
    this.lblWallDie.Size = new Size(19, 19);
    this.lblWallDie.TabIndex = 25;
    this.lblWallDie.Text = "0";
    this.lblTotal.AutoSize = true;
    this.lblTotal.BackColor = SystemColors.Control;
    this.lblTotal.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTotal.ForeColor = Color.Teal;
    this.lblTotal.Location = new Point(842, 51);
    this.lblTotal.Name = "lblTotal";
    this.lblTotal.Size = new Size(19, 19);
    this.lblTotal.TabIndex = 26;
    this.lblTotal.Text = "0";
    this.lblWallLive.AutoSize = true;
    this.lblWallLive.BackColor = SystemColors.Control;
    this.lblWallLive.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblWallLive.ForeColor = Color.Green;
    this.lblWallLive.Location = new Point(361, 51);
    this.lblWallLive.Name = "lblWallLive";
    this.lblWallLive.Size = new Size(19, 19);
    this.lblWallLive.TabIndex = 29;
    this.lblWallLive.Text = "0";
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label3.Location = new Point(22, 53);
    this.label3.Name = "label3";
    this.label3.RightToLeft = RightToLeft.No;
    this.label3.Size = new Size(87, 16);
    this.label3.TabIndex = 34;
    this.label3.Text = "Thành công:";
    this.label3.TextAlign = ContentAlignment.MiddleRight;
    this.label4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label4.Location = new Point(170, 53);
    this.label4.Name = "label4";
    this.label4.RightToLeft = RightToLeft.No;
    this.label4.Size = new Size(52, 16);
    this.label4.TabIndex = 35;
    this.label4.Text = "Lỗi:";
    this.label4.TextAlign = ContentAlignment.MiddleRight;
    this.label5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label5.Location = new Point(295, 53);
    this.label5.Name = "label5";
    this.label5.RightToLeft = RightToLeft.No;
    this.label5.Size = new Size(70, 16);
    this.label5.TabIndex = 36;
    this.label5.Text = "Wall Live:";
    this.label5.TextAlign = ContentAlignment.MiddleRight;
    this.label6.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label6.Location = new Point(438, 53);
    this.label6.Name = "label6";
    this.label6.RightToLeft = RightToLeft.No;
    this.label6.Size = new Size(64, 16);
    this.label6.TabIndex = 37;
    this.label6.Text = "Wall Die:";
    this.label6.TextAlign = ContentAlignment.MiddleRight;
    this.label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label7.Location = new Point(783, 53);
    this.label7.Name = "label7";
    this.label7.RightToLeft = RightToLeft.No;
    this.label7.Size = new Size(63, 16);
    this.label7.TabIndex = 38;
    this.label7.Text = "Tổng số:";
    this.label7.TextAlign = ContentAlignment.MiddleRight;
    this.lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStatus.Location = new Point(15, 75);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(924, 28);
    this.lblStatus.TabIndex = 27;
    this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;
    this.label8.AutoSize = true;
    this.label8.Location = new Point(14, 397);
    this.label8.Name = "label8";
    this.label8.Size = new Size(97, 14);
    this.label8.TabIndex = 39;
    this.label8.Text = "Định dạng nhập:";
    this.cbbDinhDangNhap.Cursor = Cursors.Hand;
    this.cbbDinhDangNhap.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDangNhap.FormattingEnabled = true;
    this.cbbDinhDangNhap.Items.AddRange(new object[7]
    {
      (object) "Uid|Pass|2FA",
      (object) "Cookie",
      (object) "Uid|Pass",
      (object) "Uid|Pass|Token|Cookie",
      (object) "Uid|Pass|Token|Cookie|Email|Pass Email",
      (object) "Uid|Pass|Token|Cookie|Email|Pass Email|2FA",
      (object) "Other..."
    });
    this.cbbDinhDangNhap.Location = new Point(117, 394);
    this.cbbDinhDangNhap.Name = "cbbDinhDangNhap";
    this.cbbDinhDangNhap.Size = new Size(269, 22);
    this.cbbDinhDangNhap.TabIndex = 40;
    this.cbbDinhDangNhap.SelectedIndexChanged += new EventHandler(this.cbbDinhDangNhap_SelectedIndexChanged);
    this.cbbDinhDang1.Cursor = Cursors.Hand;
    this.cbbDinhDang1.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang1.FormattingEnabled = true;
    this.cbbDinhDang1.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang1.Location = new Point(3, 3);
    this.cbbDinhDang1.Name = "cbbDinhDang1";
    this.cbbDinhDang1.Size = new Size(78, 22);
    this.cbbDinhDang1.TabIndex = 40;
    this.cbbDinhDang1.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.label9.AutoSize = true;
    this.label9.Font = new Font("Tahoma", 12f);
    this.label9.Location = new Point(81, 3);
    this.label9.Name = "label9";
    this.label9.Size = new Size(15, 19);
    this.label9.TabIndex = 41;
    this.label9.Text = "|";
    this.cbbDinhDang2.Cursor = Cursors.Hand;
    this.cbbDinhDang2.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang2.FormattingEnabled = true;
    this.cbbDinhDang2.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang2.Location = new Point(96, 3);
    this.cbbDinhDang2.Name = "cbbDinhDang2";
    this.cbbDinhDang2.Size = new Size(78, 22);
    this.cbbDinhDang2.TabIndex = 40;
    this.cbbDinhDang2.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.label10.AutoSize = true;
    this.label10.Font = new Font("Tahoma", 12f);
    this.label10.Location = new Point(174, 3);
    this.label10.Name = "label10";
    this.label10.Size = new Size(15, 19);
    this.label10.TabIndex = 41;
    this.label10.Text = "|";
    this.cbbDinhDang3.Cursor = Cursors.Hand;
    this.cbbDinhDang3.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang3.FormattingEnabled = true;
    this.cbbDinhDang3.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang3.Location = new Point(189, 3);
    this.cbbDinhDang3.Name = "cbbDinhDang3";
    this.cbbDinhDang3.Size = new Size(78, 22);
    this.cbbDinhDang3.TabIndex = 40;
    this.cbbDinhDang3.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.label11.AutoSize = true;
    this.label11.Font = new Font("Tahoma", 12f);
    this.label11.Location = new Point(267, 3);
    this.label11.Name = "label11";
    this.label11.Size = new Size(15, 19);
    this.label11.TabIndex = 41;
    this.label11.Text = "|";
    this.cbbDinhDang4.Cursor = Cursors.Hand;
    this.cbbDinhDang4.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang4.FormattingEnabled = true;
    this.cbbDinhDang4.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang4.Location = new Point(282, 3);
    this.cbbDinhDang4.Name = "cbbDinhDang4";
    this.cbbDinhDang4.Size = new Size(78, 22);
    this.cbbDinhDang4.TabIndex = 40;
    this.cbbDinhDang4.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.label12.AutoSize = true;
    this.label12.Font = new Font("Tahoma", 12f);
    this.label12.Location = new Point(360, 3);
    this.label12.Name = "label12";
    this.label12.Size = new Size(15, 19);
    this.label12.TabIndex = 41;
    this.label12.Text = "|";
    this.cbbDinhDang5.Cursor = Cursors.Hand;
    this.cbbDinhDang5.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang5.FormattingEnabled = true;
    this.cbbDinhDang5.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang5.Location = new Point(375, 3);
    this.cbbDinhDang5.Name = "cbbDinhDang5";
    this.cbbDinhDang5.Size = new Size(78, 22);
    this.cbbDinhDang5.TabIndex = 40;
    this.cbbDinhDang5.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.label13.AutoSize = true;
    this.label13.Font = new Font("Tahoma", 12f);
    this.label13.Location = new Point(453, 3);
    this.label13.Name = "label13";
    this.label13.Size = new Size(15, 19);
    this.label13.TabIndex = 41;
    this.label13.Text = "|";
    this.cbbDinhDang6.Cursor = Cursors.Hand;
    this.cbbDinhDang6.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang6.FormattingEnabled = true;
    this.cbbDinhDang6.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang6.Location = new Point(468, 3);
    this.cbbDinhDang6.Name = "cbbDinhDang6";
    this.cbbDinhDang6.Size = new Size(78, 22);
    this.cbbDinhDang6.TabIndex = 40;
    this.cbbDinhDang6.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.label14.AutoSize = true;
    this.label14.Font = new Font("Tahoma", 12f);
    this.label14.Location = new Point(546, 3);
    this.label14.Name = "label14";
    this.label14.Size = new Size(15, 19);
    this.label14.TabIndex = 41;
    this.label14.Text = "|";
    this.cbbDinhDang7.Cursor = Cursors.Hand;
    this.cbbDinhDang7.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang7.FormattingEnabled = true;
    this.cbbDinhDang7.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang7.Location = new Point(561, 3);
    this.cbbDinhDang7.Name = "cbbDinhDang7";
    this.cbbDinhDang7.Size = new Size(78, 22);
    this.cbbDinhDang7.TabIndex = 40;
    this.cbbDinhDang7.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.plDinhDangNhap.BorderStyle = BorderStyle.FixedSingle;
    this.plDinhDangNhap.Controls.Add((Control) this.button3);
    this.plDinhDangNhap.Controls.Add((Control) this.button2);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang1);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang2);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang3);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang4);
    this.plDinhDangNhap.Controls.Add((Control) this.label18);
    this.plDinhDangNhap.Controls.Add((Control) this.label14);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang5);
    this.plDinhDangNhap.Controls.Add((Control) this.label17);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang8);
    this.plDinhDangNhap.Controls.Add((Control) this.label13);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang6);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang9);
    this.plDinhDangNhap.Controls.Add((Control) this.label12);
    this.plDinhDangNhap.Controls.Add((Control) this.cbbDinhDang7);
    this.plDinhDangNhap.Controls.Add((Control) this.label11);
    this.plDinhDangNhap.Controls.Add((Control) this.label9);
    this.plDinhDangNhap.Controls.Add((Control) this.label10);
    this.plDinhDangNhap.Location = new Point(114, 420);
    this.plDinhDangNhap.Name = "plDinhDangNhap";
    this.plDinhDangNhap.Size = new Size(834, 74);
    this.plDinhDangNhap.TabIndex = 46;
    this.button3.Anchor = AnchorStyles.Bottom;
    this.button3.BackColor = Color.FromArgb(53, 120, 229);
    this.button3.Cursor = Cursors.Hand;
    this.button3.FlatAppearance.BorderSize = 0;
    this.button3.FlatStyle = FlatStyle.Flat;
    this.button3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button3.ForeColor = Color.White;
    this.button3.Location = new Point(365, 40);
    this.button3.Name = "button3";
    this.button3.Size = new Size(120, 29);
    this.button3.TabIndex = 49;
    this.button3.Text = "Lưu định dạng";
    this.button3.UseVisualStyleBackColor = false;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button2.Anchor = AnchorStyles.Bottom;
    this.button2.BackColor = Color.DarkOrange;
    this.button2.Cursor = Cursors.Hand;
    this.button2.FlatAppearance.BorderSize = 0;
    this.button2.FlatStyle = FlatStyle.Flat;
    this.button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.button2.ForeColor = Color.White;
    this.button2.Location = new Point(238, 40);
    this.button2.Name = "button2";
    this.button2.Size = new Size(121, 29);
    this.button2.TabIndex = 49;
    this.button2.Text = "Reset định dạng";
    this.button2.UseVisualStyleBackColor = false;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.label18.AutoSize = true;
    this.label18.Font = new Font("Tahoma", 12f);
    this.label18.Location = new Point(732, 3);
    this.label18.Name = "label18";
    this.label18.Size = new Size(15, 19);
    this.label18.TabIndex = 41;
    this.label18.Text = "|";
    this.label17.AutoSize = true;
    this.label17.Font = new Font("Tahoma", 12f);
    this.label17.Location = new Point(639, 3);
    this.label17.Name = "label17";
    this.label17.Size = new Size(15, 19);
    this.label17.TabIndex = 41;
    this.label17.Text = "|";
    this.cbbDinhDang8.Cursor = Cursors.Hand;
    this.cbbDinhDang8.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang8.FormattingEnabled = true;
    this.cbbDinhDang8.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang8.Location = new Point(654, 3);
    this.cbbDinhDang8.Name = "cbbDinhDang8";
    this.cbbDinhDang8.Size = new Size(78, 22);
    this.cbbDinhDang8.TabIndex = 40;
    this.cbbDinhDang8.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.cbbDinhDang9.Cursor = Cursors.Hand;
    this.cbbDinhDang9.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbDinhDang9.FormattingEnabled = true;
    this.cbbDinhDang9.Items.AddRange(new object[11]
    {
      (object) "Uid",
      (object) "Pass",
      (object) "Token",
      (object) "Cookie",
      (object) "Email",
      (object) "Pass Email",
      (object) "2FA",
      (object) "Useragent",
      (object) "Proxy",
      (object) "Birthday",
      (object) "LD Index"
    });
    this.cbbDinhDang9.Location = new Point(747, 3);
    this.cbbDinhDang9.Name = "cbbDinhDang9";
    this.cbbDinhDang9.Size = new Size(78, 22);
    this.cbbDinhDang9.TabIndex = 40;
    this.cbbDinhDang9.SelectedIndexChanged += new EventHandler(this.cbbDinhDang9_SelectedIndexChanged);
    this.label16.AutoSize = true;
    this.label16.Location = new Point(14, 368);
    this.label16.Name = "label16";
    this.label16.Size = new Size(90, 14);
    this.label16.TabIndex = 39;
    this.label16.Text = "Chọn thư mục:";
    this.cbbThuMuc.Cursor = Cursors.Hand;
    this.cbbThuMuc.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cbbThuMuc.DropDownWidth = 269;
    this.cbbThuMuc.FormattingEnabled = true;
    this.cbbThuMuc.Location = new Point(117, 365);
    this.cbbThuMuc.Name = "cbbThuMuc";
    this.cbbThuMuc.Size = new Size(201, 22);
    this.cbbThuMuc.TabIndex = 40;
    this.cbbThuMuc.SelectedIndexChanged += new EventHandler(this.cbbThuMuc_SelectedIndexChanged);
    this.button1.Cursor = Cursors.Hand;
    this.button1.Location = new Point(324, 364);
    this.button1.Name = "button1";
    this.button1.Size = new Size(62, 25);
    this.button1.TabIndex = 45;
    this.button1.Text = "Thêm";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.txbAccount.BorderStyle = BorderStyle.FixedSingle;
    this.txbAccount.Location = new Point(15, 120);
    this.txbAccount.Name = "txbAccount";
    this.txbAccount.Size = new Size(924, 238);
    this.txbAccount.TabIndex = 48;
    this.txbAccount.Text = "";
    this.txbAccount.WordWrap = false;
    this.txbAccount.TextChanged += new EventHandler(this.txbAccount_TextChanged);
    this.lblKhongCheckDuoc.AutoSize = true;
    this.lblKhongCheckDuoc.BackColor = SystemColors.Control;
    this.lblKhongCheckDuoc.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblKhongCheckDuoc.ForeColor = Color.Maroon;
    this.lblKhongCheckDuoc.Location = new Point(705, 51);
    this.lblKhongCheckDuoc.Name = "lblKhongCheckDuoc";
    this.lblKhongCheckDuoc.Size = new Size(19, 19);
    this.lblKhongCheckDuoc.TabIndex = 25;
    this.lblKhongCheckDuoc.Text = "0";
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
    this.label2.Location = new Point(578, 53);
    this.label2.Name = "label2";
    this.label2.RightToLeft = RightToLeft.No;
    this.label2.Size = new Size(131, 16);
    this.label2.TabIndex = 37;
    this.label2.Text = "Không Check được:";
    this.label2.TextAlign = ContentAlignment.MiddleRight;
    this.AutoScaleDimensions = new SizeF(7f, 14f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(953, 547);
    this.Controls.Add((Control) this.txbAccount);
    this.Controls.Add((Control) this.plDinhDangNhap);
    this.Controls.Add((Control) this.button1);
    this.Controls.Add((Control) this.cbbThuMuc);
    this.Controls.Add((Control) this.cbbDinhDangNhap);
    this.Controls.Add((Control) this.label16);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.lblWallLive);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.lblKhongCheckDuoc);
    this.Controls.Add((Control) this.lblTotal);
    this.Controls.Add((Control) this.lblWallDie);
    this.Controls.Add((Control) this.lblError);
    this.Controls.Add((Control) this.lblSuccess);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.bunifuCards1);
    this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = nameof (fImportAccount);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Nhập tài khoản";
    this.bunifuCards1.ResumeLayout(false);
    this.pnlHeader.ResumeLayout(false);
    this.plDinhDangNhap.ResumeLayout(false);
    this.plDinhDangNhap.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void button2_Click(object sender, EventArgs e) => this.method_5();

  private void method_5()
  {
    try
    {
      for (int index = 0; index < this.list_0.Count; ++index)
        this.list_0[index].SelectedIndex = -1;
    }
    catch
    {
    }
  }

  private void button3_Click(object sender, EventArgs e) => this.method_61();

  private void method_61()
  {
    try
    {
      string str = "";
      for (int index = 0; index < this.list_0.Count; ++index)
        str = str + this.list_0[index].SelectedIndex.ToString() + "|";
      File.WriteAllText("settings\\format_paste.txt", str.TrimEnd('|'));
    }
    catch
    {
    }
  }

  private void method_71()
  {
    try
    {
      if (!File.Exists("settings\\format_paste.txt"))
        return;
      string str = File.ReadAllText("settings\\format_paste.txt");
      for (int index = 0; index < this.list_0.Count; ++index)
        this.list_0[index].SelectedIndex = Convert.ToInt32(str.Split('|')[index]);
    }
    catch
    {
    }
  }
}
