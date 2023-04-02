// Decompiled with JetBrains decompiler
// Type: GClass19
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using AE.Net.Mail;
using Ionic.Zip;
using Microsoft.CSharp.RuntimeBinder;
using minhelper;
using Newtonsoft.Json.Linq;
using OpenCvSharp;
using OtpNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public class GClass19
{
  private static Random random_0 = new Random();
  private static int int_0 = Screen.PrimaryScreen.WorkingArea.Width;
  private static int int_1 = Screen.PrimaryScreen.WorkingArea.Height;
  private static object object_0 = new object();

  [DllImport("main", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
  private static extern IntPtr GetDeviceId();

  [DllImport("main", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
  private static extern IntPtr CheckLicensePro(byte[] byte_0, byte[] byte_1, byte[] byte_2);

  [DllImport("main", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
  private static extern IntPtr GetApiToken(byte[] byte_0, byte[] byte_1, byte[] byte_2);

  [DllImport("main", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
  private static extern IntPtr GetTotp(byte[] byte_0);

  public static string smethod_0(IntPtr intptr_0)
  {
    try
    {
      return Encoding.UTF8.GetString(Encoding.Default.GetBytes(Marshal.PtrToStringAnsi(intptr_0)));
    }
    catch (Exception ex)
    {
    }
    return "";
  }

  public static string smethod_1() => GClass19.smethod_0(GClass19.GetDeviceId());

  public static string smethod_2(string string_0, string string_1) => GClass19.smethod_0(GClass19.CheckLicensePro(Encoding.UTF8.GetBytes(Class54.string_0), Encoding.UTF8.GetBytes(string_0), Encoding.UTF8.GetBytes(string_1)));

  public static string smethod_3(string string_0, string string_1) => GClass19.smethod_0(GClass19.GetApiToken(Encoding.UTF8.GetBytes(Class54.string_0), Encoding.UTF8.GetBytes(string_0), Encoding.UTF8.GetBytes(string_1)));

  public static void smethod_4(string string_0)
  {
    int num = (int) new fDownloadFile(string_0).ShowDialog();
  }

  public static void smethod_5(RichTextBox richTextBox_0, Control control_0, int int_2 = 0)
  {
    try
    {
      string text = control_0.Text;
      List<string> stringList1 = new List<string>();
      List<string> list;
      if (int_2 == 0)
        list = ((IEnumerable<string>) richTextBox_0.Lines).ToList<string>();
      else
        list = ((IEnumerable<string>) richTextBox_0.Text.Split(new string[1]
        {
          "\n|\n"
        }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();
      List<string> stringList2 = GClass19.smethod_39(list);
      control_0.Text = text.Replace(Regex.Match(text, "\\((.*?)\\)").Value, "(" + stringList2.Count.ToString() + ")");
    }
    catch
    {
    }
  }

  public static void smethod_6(Control control_0, int int_2)
  {
    try
    {
      string text = control_0.Text;
      control_0.Text = text.Replace(Regex.Match(text, "\\((.*?)\\)").Value, "(" + int_2.ToString() + ")");
    }
    catch
    {
    }
  }

  public static List<string> smethod_7(string string_0) => ((IEnumerable<string>) System.IO.File.ReadAllText(string_0).Split(new string[2]
  {
    "\n",
    "\r"
  }, StringSplitOptions.RemoveEmptyEntries)).ToList<string>();

  public static bool smethod_8(int int_2) => Class54.random_0.Next(1, 101) <= int_2;

  public static void smethod_9(string string_0, string string_1, string string_2 = "tungmin")
  {
    try
    {
      using (ZipFile zipFile = new ZipFile())
      {
        if (string_2 != "")
          zipFile.Password = string_2;
        zipFile.AddDirectory(string_0);
        zipFile.Save(string_1);
      }
    }
    catch (Exception ex)
    {
    }
  }

  public static void smethod_10(string string_0, string string_1, string string_2 = "tungmin")
  {
    try
    {
      using (ZipFile zipFile = new ZipFile(string_0, Encoding.UTF8))
      {
        if (string_2 != "")
          zipFile.Password = string_2;
        zipFile.ExtractAll(string_1, ExtractExistingFileAction.OverwriteSilently);
      }
    }
    catch (Exception ex)
    {
    }
  }

  public static bool smethod_11(string string_0)
  {
    try
    {
      foreach (Control openForm in (ReadOnlyCollectionBase) Application.OpenForms)
      {
        if (openForm.Name == string_0)
          return true;
      }
    }
    catch
    {
    }
    return false;
  }

  public static bool smethod_12(string string_0)
  {
    try
    {
      foreach (Form openForm in (ReadOnlyCollectionBase) Application.OpenForms)
      {
        Form form_0 = openForm;
        if (form_0.Name == string_0)
        {
          form_0.Invoke((Delegate) (() => form_0.Close()));
          break;
        }
      }
    }
    catch
    {
    }
    return false;
  }

  public static string smethod_13(object object_1)
  {
    string str = "";
    try
    {
      foreach (PropertyInfo property in object_1.GetType().GetProperties())
        str = str + property.GetValue(object_1)?.ToString() + ",";
      str = str.TrimEnd(',');
    }
    catch
    {
    }
    return str;
  }

  public static List<string> smethod_14(List<string> list_0, List<string> list_1)
  {
    List<string> stringList = new List<string>();
    try
    {
      stringList = list_0.Intersect<string>((IEnumerable<string>) list_1).ToList<string>();
    }
    catch
    {
    }
    return stringList;
  }

  public static List<string> smethod_15(List<string> list_0, List<string> list_1)
  {
    List<string> stringList = new List<string>();
    try
    {
      stringList = list_0.Except<string>((IEnumerable<string>) list_1).ToList<string>();
    }
    catch
    {
    }
    return stringList;
  }

  private static void smethod_16(string string_0)
  {
    ProcessStartInfo processStartInfo = new ProcessStartInfo("netsh", "interface set interface \"" + string_0 + "\" enable");
    new Process() { StartInfo = processStartInfo }.Start();
  }

  private static void smethod_17(string string_0)
  {
    ProcessStartInfo processStartInfo = new ProcessStartInfo("netsh", "interface set interface \"" + string_0 + "\" disable");
    new Process() { StartInfo = processStartInfo }.Start();
  }

  public static string smethod_18(string string_0)
  {
    try
    {
      return Directory.GetCreationTime(string_0).ToString("yyyy/MM/dd HH:mm:ss");
    }
    catch (Exception ex)
    {
    }
    return "";
  }

  public static string smethod_19(string string_0)
  {
    try
    {
      return System.IO.File.GetCreationTime(string_0).ToString("yyyy/MM/dd HH:mm:ss");
    }
    catch (Exception ex)
    {
    }
    return "";
  }

  public static string smethod_20(ref List<string> list_0, Random random_1)
  {
    string str;
    try
    {
      int index = random_1.Next(0, list_0.Count);
      str = list_0[index];
      list_0.RemoveAt(index);
    }
    catch (Exception ex)
    {
      throw;
    }
    return str;
  }

  public static string smethod_21(string string_0, string string_1)
  {
    int num = 0;
label_11:
    try
    {
      string host = "";
      if (string_0.EndsWith("@hotmail.com") || string_0.EndsWith("@outlook.com") || string_0.EndsWith("@nickpromail.com"))
        host = "outlook.office365.com";
      else if (string_0.EndsWith("@yandex.com"))
        host = "imap.yandex.com";
      if (host == "")
        return "0";
      new ImapClient(host, string_0, string_1, port: 993, secure: true).Dispose();
      return "1";
    }
    catch (Exception ex)
    {
      if (ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
      {
        ++num;
        if (num < 10)
          goto label_11;
      }
      return "0";
    }
  }

  public static string smethod_22(string string_0, string string_1, string string_2)
  {
    int num = 0;
label_5:
    try
    {
      new ImapClient(string_2, string_0, string_1, port: 993, secure: true).Dispose();
      return "1";
    }
    catch (Exception ex)
    {
      if (ex.ToString().Contains("The remote certificate is invalid according to the validation procedure"))
      {
        ++num;
        if (num < 10)
          goto label_5;
      }
      return "0";
    }
  }

  public static string smethod_23(int int_2)
  {
    try
    {
      TimeSpan.FromSeconds((double) int_2);
      if (int_2 < 60)
        return TimeSpan.FromSeconds((double) int_2).ToString("ss");
      return int_2 < 3600 ? TimeSpan.FromSeconds((double) int_2).ToString("mm\\:ss") : TimeSpan.FromSeconds((double) int_2).ToString("hh\\:mm\\:ss");
    }
    catch
    {
      return "";
    }
  }

  public static bool smethod_24(
    string string_0,
    string string_1,
    string string_2,
    string string_3 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico",
    string string_4 = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
  {
    bool flag = false;
    try
    {
      GClass19.smethod_25(string_0, string_1, string_4, "--user-data-dir=\"" + string_2 + "\"", string_4.Substring(0, string_4.LastIndexOf("\\")), string_3);
      return true;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "chrome.CreateShortcut(" + string_0 + "," + string_1 + "," + string_4 + ")select");
      return flag;
    }
  }

  public static void smethod_25(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    string string_4 = "C:\\Program Files (x86)\\Google\\Chrome\\Application",
    string string_5 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico")
  {
    string string_0_1 = Path.Combine(string_1, string_0 + ".lnk");
    // ISSUE: variable of a compiler-generated type
    GInterface4 instance = (GInterface4) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
    // ISSUE: reference to a compiler-generated field
    if (GClass19.\u003C\u003Eo__45.\u003C\u003Ep__0 == null)
    {
      // ISSUE: reference to a compiler-generated field
      GClass19.\u003C\u003Eo__45.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, GInterface3>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (GInterface3), typeof (GClass19)));
    }
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    // ISSUE: variable of a compiler-generated type
    GInterface3 ginterface3 = GClass19.\u003C\u003Eo__45.\u003C\u003Ep__0.Target((CallSite) GClass19.\u003C\u003Eo__45.\u003C\u003Ep__0, instance.imethod_0(string_0_1));
    ginterface3.String_2 = "Shortcut Chrome MIN Software";
    ginterface3.String_5 = string_4;
    ginterface3.String_3 = string_5;
    ginterface3.String_4 = string_2;
    ginterface3.String_1 = string_3;
    // ISSUE: reference to a compiler-generated method
    ginterface3.imethod_0();
  }

  public static bool smethod_26(string string_0)
  {
    bool bool_0 = false;
    try
    {
      Thread thread = new Thread((ThreadStart) (() =>
      {
        try
        {
          Clipboard.SetText(string_0);
          bool_0 = true;
        }
        catch
        {
        }
      }));
      thread.SetApartmentState(ApartmentState.STA);
      thread.IsBackground = true;
      thread.Start();
      thread.Join();
    }
    catch
    {
    }
    return bool_0;
  }

  public static List<string> smethod_27(List<string> list_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      for (int index = 0; index < list_0.Count; ++index)
        stringList.Add(list_0[index]);
    }
    catch
    {
    }
    return stringList;
  }

  public static string smethod_28(string string_0, Random random_1 = null)
  {
    int num1 = -1;
    char[] anyOf = new char[2]{ '{', '}' };
    string_0 += "~";
    int num2;
    do
    {
      int startIndex = num1;
      int num3 = -1;
      while ((startIndex = string_0.IndexOf('{', startIndex + 1)) != -1)
      {
        int index = startIndex;
        while ((index = string_0.IndexOfAny(anyOf, index + 1)) != -1 && string_0[index] != '}')
        {
          if (num3 == -1)
            num3 = startIndex;
          startIndex = index;
        }
        if (index != -1)
        {
          string[] strArray = string_0.Substring(startIndex + 1, index - 1 - (startIndex + 1 - 1)).Split('|');
          string_0 = string_0.Remove(startIndex, index - (startIndex - 1)).Insert(startIndex, strArray[Class54.random_0.Next(strArray.Length)]);
        }
      }
      num2 = num3;
      num1 = num2 - 1;
    }
    while (num2 != -1);
    return Class201.smethod_2(string_0.Remove(string_0.Length - 1), GClass19.random_0);
  }

  public static void smethod_29(
    string string_0,
    string string_1 = "Nhập danh sách Uid cần clone",
    string string_2 = "Danh sách Uid",
    string string_3 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
  {
    try
    {
      if (!System.IO.File.Exists(string_0))
        GClass19.smethod_32(string_0);
      GClass19.smethod_35((Form) new fNhapDuLieu1(string_0, string_1, string_2, string_3));
    }
    catch
    {
    }
  }

  public static DateTime smethod_30(double double_0)
  {
    DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
    dateTime = dateTime.AddSeconds(double_0);
    return dateTime.ToLocalTime();
  }

  public static Form smethod_31(string string_0, string string_1)
  {
    System.Type[] types = Assembly.GetExecutingAssembly().GetTypes();
    int index = 0;
    while (true)
    {
      if (index < types.Length)
      {
        System.Type type = types[index];
        if (!(type.BaseType != (System.Type) null) || !(type.BaseType.FullName == "System.Windows.Forms.Form") || !(type.FullName == string_0))
          ++index;
        else
          goto label_5;
      }
      else
        break;
    }
    return (Form) null;
label_5:
    return Activator.CreateInstance(System.Type.GetType(string_0), (object) "", (object) 1, (object) string_1) as Form;
  }

  public static void smethod_32(string string_0)
  {
    try
    {
      if (System.IO.File.Exists(string_0))
        return;
      System.IO.File.AppendAllText(string_0, "");
    }
    catch
    {
    }
  }

  public static void smethod_33(DataGridView dataGridView_0)
  {
    for (int index = 0; index < dataGridView_0.RowCount; ++index)
      dataGridView_0.Rows[index].Selected = false;
  }

  public static void smethod_34(string string_0)
  {
    try
    {
      if (Directory.Exists(string_0))
        return;
      Directory.CreateDirectory(string_0);
    }
    catch
    {
    }
  }

  public static void smethod_35(Form form_0)
  {
    try
    {
      form_0.ShowInTaskbar = false;
      int num = (int) form_0.ShowDialog();
    }
    catch
    {
    }
  }

  public static void smethod_36(object object_1, int int_2)
  {
    switch (int_2)
    {
      case 1:
        int num1 = (int) MessageBox.Show(object_1.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        break;
      case 2:
        int num2 = (int) MessageBox.Show(object_1.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        break;
      case 3:
        int num3 = (int) MessageBox.Show(object_1.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        break;
    }
  }

  public static List<int> smethod_37(List<int> list_0)
  {
    int count = list_0.Count;
    while (count != 0)
    {
      int index = Class54.random_0.Next(0, list_0.Count);
      --count;
      int num = list_0[count];
      list_0[count] = list_0[index];
      list_0[index] = num;
    }
    return list_0;
  }

  public static List<string> smethod_38(List<string> list_0)
  {
    int count = list_0.Count;
    while (count != 0)
    {
      int index = Class54.random_0.Next(0, list_0.Count);
      --count;
      string str = list_0[count];
      list_0[count] = list_0[index];
      list_0[index] = str;
    }
    return list_0;
  }

  public static List<string> smethod_39(List<string> list_0)
  {
    List<string> stringList = new List<string>();
    for (int index = 0; index < list_0.Count; ++index)
    {
      string str = list_0[index].Trim();
      if (str != "")
        stringList.Add(str);
    }
    return stringList;
  }

  public static string smethod_40(string string_0, string string_1, int int_2 = 10)
  {
    Process process = new Process();
    process.StartInfo.FileName = string_0;
    process.StartInfo.Arguments = string_1;
    process.StartInfo.CreateNoWindow = true;
    process.StartInfo.UseShellExecute = false;
    process.StartInfo.RedirectStandardError = true;
    process.StartInfo.RedirectStandardOutput = true;
    process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
    process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
    StringBuilder stringBuilder_0 = new StringBuilder();
    process.OutputDataReceived += (DataReceivedEventHandler) ((sender, e) =>
    {
      if (string.IsNullOrEmpty(e.Data))
        return;
      stringBuilder_0.Append(e.Data + "\n");
    });
    process.Start();
    process.BeginOutputReadLine();
    if (int_2 < 0)
      process.WaitForExit();
    else
      process.WaitForExit(int_2 * 1000);
    process.Close();
    return stringBuilder_0.ToString();
  }

  public static bool smethod_41(string string_0)
  {
    bool flag = false;
    string str = GClass19.smethod_40("rasdial.exe", "\"" + string_0 + "\"", 3);
    if (str.Contains("Successfully connected to "))
      flag = true;
    else if (str.Contains("You are already connected to "))
    {
      for (int index = 0; index < 3; ++index)
      {
        if (!(GClass19.smethod_40("rasdial.exe", "\"" + string_0 + "\" /disconnect", 3).Trim() == "Command completed successfully."))
        {
          GClass19.smethod_64(1.0);
        }
        else
        {
          flag = true;
          break;
        }
      }
      GClass19.smethod_64(1.0);
      if (flag)
      {
        for (int index = 0; index < 3; ++index)
        {
          if (!GClass19.smethod_40("rasdial.exe", "\"" + string_0 + "\"", 3).Contains("Successfully connected to "))
          {
            GClass19.smethod_64(1.0);
          }
          else
          {
            flag = true;
            break;
          }
        }
      }
      GClass19.smethod_64(1.0);
    }
    else
      flag = false;
    return flag;
  }

  public static string smethod_42(string string_0, string string_1) => !string_0.EndsWith(string_1) ? string_0 : string_0.Remove(string_0.LastIndexOf(string_1));

  public static void smethod_43(DataGridView dataGridView_0, string string_0, char char_0 = '|')
  {
    List<string> contents = new List<string>();
    for (int index1 = 0; index1 < dataGridView_0.RowCount; ++index1)
    {
      string str1 = "";
      for (int index2 = 0; index2 < dataGridView_0.ColumnCount; ++index2)
      {
        object obj = dataGridView_0.Rows[index1].Cells[index2].Value;
        str1 += obj == null ? char_0.ToString() : obj?.ToString() + char_0.ToString();
      }
      string str2 = str1.TrimEnd(char_0);
      contents.Add(str2);
    }
    System.IO.File.WriteAllLines(string_0, (IEnumerable<string>) contents);
  }

  public static void smethod_44(DataGridView dataGridView_0, string string_0, char char_0 = '|')
  {
    if (!System.IO.File.Exists(string_0))
      GClass19.smethod_32(string_0);
    List<string> list = ((IEnumerable<string>) System.IO.File.ReadAllLines(string_0)).ToList<string>();
    if (list.Count <= 0)
      return;
    for (int index = 0; index < list.Count; ++index)
    {
      string str = list[index];
      dataGridView_0.Rows.Add((object[]) str.Split(char_0));
    }
  }

  public static string smethod_45(string string_0 = "") => Helper.SelectFolder();

  public static string smethod_46(string string_0 = "Chọn File txt", string string_1 = "txt Files (*.txt)|*.txt|")
  {
    string str = "";
    try
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = string_1 + "All files (*.*)|*.*";
        openFileDialog.Title = string_0;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
          str = openFileDialog.FileName;
      }
    }
    catch
    {
    }
    return str;
  }

  public static void smethod_47(string string_0)
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

  public static bool smethod_48(string string_0)
  {
    bool flag = true;
    foreach (char ch in string_0)
    {
      if ((ch < 'a' || ch > 'z') && (ch < 'A' || ch > 'Z') && ch != '.')
      {
        flag = false;
        break;
      }
    }
    return flag;
  }

  public static string smethod_49(string string_0)
  {
    string str = "";
    for (int index = 0; index < string_0.Length; ++index)
    {
      char ch = string_0[index];
      if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
        str += ch.ToString();
    }
    return str;
  }

  public static string smethod_50(string string_0)
  {
    string_0 = Encoding.UTF8.GetString(Encoding.Default.GetBytes(string_0));
    return string_0;
  }

  public static bool smethod_51(string string_0)
  {
    if (string_0 == "")
      return false;
    int index = 0;
    while (true)
    {
      if (index < string_0.Length)
      {
        if (char.IsDigit(string_0[index]))
          ++index;
        else
          goto label_7;
      }
      else
        break;
    }
    return true;
label_7:
    return false;
  }

  public static bool smethod_52(string string_0)
  {
    int index = 0;
    while (true)
    {
      if (index < string_0.Length)
      {
        if (!char.IsDigit(string_0[index]))
          ++index;
        else
          goto label_5;
      }
      else
        break;
    }
    return false;
label_5:
    return true;
  }

  public static void smethod_53(string string_0)
  {
    string str = "zzz999.html";
    System.IO.File.WriteAllText(str, string_0);
    Process.Start(str);
  }

  public static string smethod_54(string string_0)
  {
    try
    {
      return new GClass24("", "", "", 0).method_0(string_0);
    }
    catch
    {
      return (string) null;
    }
  }

  public static bool smethod_55(string string_0)
  {
    try
    {
      MailAddress mailAddress = new MailAddress(string_0);
      return true;
    }
    catch (FormatException ex)
    {
      return false;
    }
  }

  public static string smethod_56(string string_0, string string_1 = "X2")
  {
    byte[] hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(string_0));
    StringBuilder stringBuilder = new StringBuilder();
    for (int index = 0; index < hash.Length; ++index)
      stringBuilder.Append(hash[index].ToString(string_1));
    return stringBuilder.ToString();
  }

  public static string smethod_57(string string_0) => Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));

  public static string smethod_58(string string_0) => Encoding.UTF8.GetString(Convert.FromBase64String(string_0));

  public static string smethod_59(int int_2, Random random_1 = null)
  {
    string str1 = "";
    if (random_1 == null)
      random_1 = new Random();
    string str2 = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    for (int index = 0; index < int_2; ++index)
      str1 += str2[random_1.Next(0, str2.Length)].ToString();
    return str1;
  }

  public static string smethod_60(int int_2, Random random_1 = null)
  {
    string str1 = "";
    if (random_1 == null)
      random_1 = new Random();
    string str2 = "abcdefghijklmnopqrstuvwxyz";
    for (int index = 0; index < int_2; ++index)
      str1 += str2[random_1.Next(0, str2.Length)].ToString();
    return str1;
  }

  public static string smethod_61(int int_2, Random random_1 = null)
  {
    string str1 = "";
    if (random_1 == null)
      random_1 = new Random();
    string str2 = "0123456789";
    for (int index = 0; index < int_2; ++index)
      str1 += str2[random_1.Next(0, str2.Length)].ToString();
    return str1;
  }

  public static string smethod_62(string string_0) => new Regex("\\p{IsCombiningDiacriticalMarks}+").Replace(string_0.Normalize(NormalizationForm.FormD), string.Empty).Replace('đ', 'd').Replace('Đ', 'D');

  public static string smethod_63(string string_0, int int_2 = 10)
  {
    string str = "";
    try
    {
      Process process = new Process();
      process.StartInfo.FileName = "cmd.exe";
      process.StartInfo.Arguments = "/c " + string_0;
      process.StartInfo.Verb = "runas";
      process.StartInfo.CreateNoWindow = true;
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.RedirectStandardError = true;
      process.StartInfo.RedirectStandardOutput = true;
      process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
      process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
      StringBuilder stringBuilder_0 = new StringBuilder();
      process.OutputDataReceived += (DataReceivedEventHandler) ((sender, e) =>
      {
        if (string.IsNullOrEmpty(e.Data))
          return;
        stringBuilder_0.Append(e.Data + "\n");
      });
      process.Start();
      process.BeginOutputReadLine();
      process.WaitForExit(int_2 < 0 ? -1 : int_2 * 1000);
      process.Close();
      str = stringBuilder_0.ToString().Trim();
    }
    catch
    {
    }
    return str;
  }

  public static void smethod_64(double double_0)
  {
    Application.DoEvents();
    Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
  }

  public static string smethod_65(string string_0) => WebUtility.HtmlDecode(string_0);

  public static string smethod_66(string string_0) => WebUtility.HtmlEncode(string_0);

  public static string smethod_67(string string_0) => WebUtility.UrlDecode(string_0);

  public static string smethod_68(string string_0) => WebUtility.UrlEncode(string_0);

  public static System.Drawing.Point smethod_69()
  {
    if (GClass33.smethod_0("configChrome").method_3("width") == 0)
    {
      GClass33.smethod_0("configChrome").method_6("width", (object) GClass19.int_0);
      GClass33.smethod_0("configChrome").method_6("heigh", (object) GClass19.int_1);
      GClass33.smethod_2("configChrome");
    }
    GClass19.int_0 = GClass33.smethod_0("configChrome").method_3("width");
    GClass19.int_1 = GClass33.smethod_0("configChrome").method_3("heigh");
    return new System.Drawing.Point(GClass19.int_0, GClass19.int_1);
  }

  public static System.Drawing.Point smethod_70(int int_2, int int_3)
  {
    System.Drawing.Point point = GClass19.smethod_69();
    GClass19.int_0 = point.X;
    GClass19.int_1 = point.Y;
    return new System.Drawing.Point(GClass19.int_0 / int_2 + 15, GClass19.int_1 / int_3 + 10);
  }

  public static System.Drawing.Point smethod_71(int int_2, int int_3, int int_4)
  {
    System.Drawing.Point point1 = GClass19.smethod_69();
    GClass19.int_0 = point1.X;
    GClass19.int_1 = point1.Y;
    System.Drawing.Point point2 = new System.Drawing.Point();
    while (int_2 >= int_3 * int_4)
      int_2 -= int_3 * int_4;
    switch (int_4)
    {
      case 1:
        point2.Y = 0;
        break;
      case 2:
        if (int_2 < int_3)
        {
          point2.Y = 0;
          break;
        }
        if (int_2 < int_3 * 2)
        {
          point2.Y = GClass19.int_1 / 2;
          int_2 -= int_3;
          break;
        }
        break;
      case 3:
        if (int_2 < int_3)
        {
          point2.Y = 0;
          break;
        }
        if (int_2 < int_3 * 2)
        {
          point2.Y = GClass19.int_1 / 3;
          int_2 -= int_3;
          break;
        }
        if (int_2 < int_3 * 3)
        {
          point2.Y = GClass19.int_1 / 3 * 2;
          int_2 -= int_3 * 2;
          break;
        }
        break;
      case 4:
        if (int_2 < int_3)
        {
          point2.Y = 0;
          break;
        }
        if (int_2 < int_3 * 2)
        {
          point2.Y = GClass19.int_1 / 4;
          int_2 -= int_3;
          break;
        }
        if (int_2 < int_3 * 3)
        {
          point2.Y = GClass19.int_1 / 4 * 2;
          int_2 -= int_3 * 2;
          break;
        }
        if (int_2 < int_3 * 4)
        {
          point2.Y = GClass19.int_1 / 4 * 3;
          int_2 -= int_3 * 3;
          break;
        }
        break;
      case 5:
        if (int_2 < int_3)
        {
          point2.Y = 0;
          break;
        }
        if (int_2 < int_3 * 2)
        {
          point2.Y = GClass19.int_1 / 5;
          int_2 -= int_3;
          break;
        }
        if (int_2 < int_3 * 3)
        {
          point2.Y = GClass19.int_1 / 5 * 2;
          int_2 -= int_3 * 2;
          break;
        }
        if (int_2 < int_3 * 4)
        {
          point2.Y = GClass19.int_1 / 5 * 3;
          int_2 -= int_3 * 3;
          break;
        }
        point2.Y = GClass19.int_1 / 5 * 4;
        int_2 -= int_3 * 4;
        break;
    }
    int num = GClass19.int_0 / int_3;
    point2.X = int_2 * num - 10;
    return point2;
  }

  public static int smethod_72(ref List<int> list_0)
  {
    int num = 0;
    lock (list_0)
    {
      for (int index = 0; index < list_0.Count; ++index)
      {
        if (list_0[index] == 0)
        {
          num = index;
          list_0[index] = 1;
          break;
        }
      }
    }
    return num;
  }

  public static void smethod_73(ref List<int> list_0, int int_2)
  {
    lock (list_0)
      list_0[int_2] = 0;
  }

  public static double smethod_74(DateTime dateTime_0) => (dateTime_0 - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;

  public static string smethod_75(string string_0, int int_2, int int_3 = 0)
  {
    string string_2 = "";
    List<string> stringList = new List<string>()
    {
      "https://icanhazip.com",
      "https://api.myip.com/",
      "https://api64.ipify.org/",
      "http://v4v6.ipv6-test.com/api/myip.php/"
    };
    try
    {
      int int_4 = 0;
      int count = stringList.Count;
      List<Thread> threadList = new List<Thread>();
      for (int index = 0; index < count; ++index)
      {
        string string_ = stringList[index];
        Thread thread = new Thread((ThreadStart) (() =>
        {
          int tickCount = Environment.TickCount;
          while (Environment.TickCount - tickCount < 60000)
          {
            string str = GClass19.smethod_76(string_, string_0, int_2);
            if (str.Contains("html") || str.Contains("cannot_connect") || str.ToLower().Contains("maximum"))
            {
              string_2 = "";
              break;
            }
            if (str != "")
            {
              string_2 = str;
              break;
            }
          }
          Interlocked.Increment(ref int_4);
        }));
        threadList.Add(thread);
        thread.IsBackground = true;
        thread.Start();
      }
      while (int_4 < count && string_2 == "")
        Thread.Sleep(1000);
      foreach (Thread thread in threadList)
      {
        try
        {
          thread.Abort();
        }
        catch (Exception ex)
        {
        }
      }
    }
    catch
    {
    }
    return string_2.Trim();
  }

  private static string smethod_76(string string_0, string string_1, int int_2)
  {
    string input = "";
    try
    {
      GClass24 gclass24 = new GClass24("", "", string_1, int_2);
      if (string_1 != "")
        gclass24.httpRequest_0.Proxy.ConnectTimeout = 5000;
      input = gclass24.method_0(string_0);
      if (string_0 == "https://api.myip.com/")
        input = Regex.Match(input, "ip\":\"(.*?)\"").Groups[1].Value;
    }
    catch (Exception ex)
    {
    }
    return input;
  }

  public static string smethod_77(string string_0, int int_2)
  {
    string str = "";
    try
    {
      str = JObject.Parse(new GClass24("", "", string_0, int_2).method_0("http://lumtest.com/myip.json"))["ip"].ToString();
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Check Proxy");
    }
    return str;
  }

  public static string smethod_78()
  {
    string str = "";
    try
    {
      str = JObject.Parse(new GClass24("", "", "", 0).method_0("http://lumtest.com/myip.json"))["ip"].ToString();
    }
    catch
    {
    }
    return str;
  }

  public static void smethod_79(GClass18 gclass18_0, Exception exception_0, string string_0 = "")
  {
    try
    {
      if (!Directory.Exists("log"))
        Directory.CreateDirectory("log");
      if (!Directory.Exists("log\\html"))
        Directory.CreateDirectory("log\\html");
      if (!Directory.Exists("log\\images"))
        Directory.CreateDirectory("log\\images");
      Random random = new Random();
      string[] strArray = new string[13];
      DateTime now = DateTime.Now;
      strArray[0] = now.Day.ToString();
      strArray[1] = "_";
      now = DateTime.Now;
      int num = now.Month;
      strArray[2] = num.ToString();
      strArray[3] = "_";
      now = DateTime.Now;
      num = now.Year;
      strArray[4] = num.ToString();
      strArray[5] = "_";
      now = DateTime.Now;
      num = now.Hour;
      strArray[6] = num.ToString();
      strArray[7] = "_";
      now = DateTime.Now;
      num = now.Minute;
      strArray[8] = num.ToString();
      strArray[9] = "_";
      now = DateTime.Now;
      num = now.Second;
      strArray[10] = num.ToString();
      strArray[11] = "_";
      num = random.Next(1000, 9999);
      strArray[12] = num.ToString();
      string string_8 = string.Concat(strArray);
      if (gclass18_0 != null)
      {
        string contents = gclass18_0.method_20("var markup = document.documentElement.innerHTML;return markup;").ToString();
        gclass18_0.method_49("log\\images\\", string_8);
        System.IO.File.WriteAllText("log\\html\\" + string_8 + ".html", contents);
      }
      using (StreamWriter streamWriter1 = new StreamWriter("log\\log.txt", true))
      {
        streamWriter1.WriteLine("-----------------------------------------------------------------------------");
        StreamWriter streamWriter2 = streamWriter1;
        now = DateTime.Now;
        string str = "Date: " + now.ToString("dd/MM/yyyy HH:mm:ss");
        streamWriter2.WriteLine(str);
        streamWriter1.WriteLine("File: " + string_8);
        if (string_0 != "")
          streamWriter1.WriteLine("Error: " + string_0);
        streamWriter1.WriteLine();
        if (exception_0 == null)
          return;
        streamWriter1.WriteLine("Type: " + exception_0.GetType().FullName);
        streamWriter1.WriteLine("Message: " + exception_0.Message);
        streamWriter1.WriteLine("StackTrace: " + exception_0.StackTrace);
        exception_0 = exception_0.InnerException;
      }
    }
    catch
    {
    }
  }

  public static int smethod_80(DateTime dateTime_0)
  {
    DateTime now = DateTime.Now;
    return Convert.ToInt32((dateTime_0 - now).TotalSeconds);
  }

  public static void smethod_81(Exception exception_0, string string_0 = "")
  {
    try
    {
      using (StreamWriter streamWriter = new StreamWriter("log\\log.txt", true))
      {
        streamWriter.WriteLine("-----------------------------------------------------------------------------");
        streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        if (string_0 != "")
          streamWriter.WriteLine("Error: " + string_0);
        streamWriter.WriteLine();
        if (exception_0 == null)
          return;
        streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
        streamWriter.WriteLine("Message: " + exception_0.Message);
        streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
        exception_0 = exception_0.InnerException;
      }
    }
    catch
    {
    }
  }

  public static bool smethod_82(
    int int_2,
    int int_3,
    string string_0,
    string string_1,
    int int_4,
    string string_2)
  {
    bool flag = false;
    try
    {
      switch (int_2)
      {
        case 0:
          return true;
        case 1:
          string str1 = GClass19.smethod_78();
          IntPtr intptr_0 = GClass16.smethod_3((string) null, "HMA VPN");
          GClass16.smethod_1(intptr_0);
          GClass16.smethod_17(GClass16.smethod_12(intptr_0, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
          Thread.Sleep(5000);
          string str2 = GClass19.smethod_78();
          GClass16.smethod_17(GClass16.smethod_12(intptr_0, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
          int tickCount = Environment.TickCount;
          string str3;
          do
          {
            str3 = GClass19.smethod_78();
          }
          while (Environment.TickCount - tickCount <= 20000 && (str3 == str1 || str3 == str2));
          if (str3 != str1)
          {
            flag = true;
            break;
          }
          break;
        case 2:
          if (int_3 == 0)
          {
            flag = GClass19.smethod_41(string_0);
            break;
          }
          int num = GClass19.smethod_83(string_1);
          if (num == 0)
          {
            Thread.Sleep(2000);
            num = GClass19.smethod_83(string_1);
          }
          flag = num == 1;
          break;
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Error ChangeIP");
    }
    return flag;
  }

  public static int smethod_83(string string_0)
  {
    int num = -1;
    try
    {
      string str1 = "http" + Regex.Match(string_0, "http(.*?)/html").Groups[1].Value;
      GClass23 gclass23 = new GClass23(string_3: "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36");
      string input1 = gclass23.method_0(string_0);
      string str2;
      try
      {
        str2 = Regex.Matches(input1, "csrf_token\" content=\"(.*?)\"")[1].Groups[1].Value;
      }
      catch
      {
        str2 = Regex.Match(gclass23.method_0(str1 + "/api/webserver/token"), "<token>(.*?)</token>").Groups[1].Value;
      }
      string str3 = gclass23.method_0(str1 + "/api/dialup/mobile-dataswitch");
      gclass23.requestHTTP_0.SetDefaultHeaders(new string[8]
      {
        "__RequestVerificationToken: " + str2,
        "Accept: */*",
        "Accept-Encoding: gzip, deflate",
        "Accept-Language: vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5",
        "Content-Type: application/x-www-form-urlencoded; charset=UTF-8",
        "X-Requested-With: XMLHttpRequest",
        "content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
        "user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36"
      });
      string string_3;
      if (str3.Contains("dataswitch>1"))
      {
        string_3 = str3.Replace("response", "request").Replace("dataswitch>1", "dataswitch>0");
      }
      else
      {
        if (!str3.Contains("dataswitch>0"))
          return -1;
        string_3 = str3.Replace("response", "request").Replace("dataswitch>0", "dataswitch>1");
      }
      if (gclass23.method_1(str1 + "/api/dialup/mobile-dataswitch", string_3).Contains("OK"))
      {
        string input2 = gclass23.method_0(str1 + "/api/dialup/mobile-dataswitch");
        if (input2.Contains("dataswitch>1<"))
        {
          for (int index = 0; index < 10 && gclass23.method_0(str1 + "/api/monitoring/traffic-statistics").Contains("<CurrentUpload>0"); ++index)
            Thread.Sleep(1000);
        }
        return Convert.ToInt32(Regex.Match(input2, "dataswitch>(.*?)<").Groups[1].Value);
      }
      num = -1;
    }
    catch
    {
    }
    return num;
  }

  public static DateTime smethod_84(string string_0, string string_1 = "dd/MM/yyyy HH:mm:ss") => DateTime.ParseExact(string_0, string_1, (IFormatProvider) CultureInfo.InvariantCulture);

  public static string smethod_85(string string_0) => GClass19.smethod_86(string_0);

  public static string smethod_86(string string_0)
  {
    string string_0_1 = "";
    try
    {
      string_0 = string_0.Replace(" ", "").Trim();
      string string_0_2 = "http://app.minsoftware.xyz/api/2fa1?secret=" + string_0;
      string string_0_3 = "http://2fa.live/tok/" + string_0;
      for (int index = 0; index < 5; ++index)
      {
        string_0_1 = "";
        try
        {
          string json = GClass19.smethod_54(string_0_3);
          if (json.Contains("token"))
            string_0_1 = JObject.Parse(json)["token"].ToString().Trim();
        }
        catch (Exception ex)
        {
          GClass19.smethod_81(ex, string_0_3);
        }
        try
        {
          if (string_0_1.Trim() == "")
            string_0_1 = GClass19.smethod_54(string_0_2);
        }
        catch (Exception ex)
        {
          GClass19.smethod_81(ex, string_0_2);
        }
        if (!(string_0_1 != "") || !GClass19.smethod_51(string_0_1))
        {
          GClass19.smethod_64(1.0);
        }
        else
        {
          for (int length = string_0_1.Length; length < 6; ++length)
            string_0_1 = "0" + string_0_1;
          break;
        }
      }
    }
    catch
    {
    }
    return string_0_1;
  }

  public static string smethod_87(string string_0)
  {
    try
    {
      return new Totp(Base32Encoding.ToBytes(string_0.Trim().Replace(" ", ""))).ComputeTotp(DateTime.UtcNow);
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "GetTotp(" + string_0 + ")");
    }
    return "";
  }

  private static int smethod_88() => 30 - (int) ((DateTime.UtcNow.Ticks - 621355968000000000L) / 10000000L % 30L);

  private static byte[] smethod_89(long long_0)
  {
    byte[] bytes = BitConverter.GetBytes(long_0);
    Array.Reverse((Array) bytes);
    return bytes;
  }

  private static long smethod_90(DateTime dateTime_0) => (dateTime_0.Ticks - 621355968000000000L) / 10000000L / 30L;

  private static string smethod_91(long long_0, int int_2) => ((int) long_0 % (int) Math.Pow(10.0, (double) int_2)).ToString().PadLeft(int_2, '0');

  private static byte[] smethod_92(string string_0)
  {
    string_0 = !string.IsNullOrEmpty(string_0) ? string_0.TrimEnd('=') : throw new ArgumentNullException("input");
    int length = string_0.Length * 5 / 8;
    byte[] numArray = new byte[length];
    byte num1 = 0;
    byte num2 = 8;
    int index = 0;
    foreach (char char_0 in string_0)
    {
      int num3 = GClass19.smethod_93(char_0);
      if (num2 > (byte) 5)
      {
        int num4 = num3 << (int) num2 - 5;
        num1 |= (byte) num4;
        num2 -= (byte) 5;
      }
      else
      {
        int num5 = num3 >> 5 - (int) num2;
        byte num6 = (byte) ((uint) num1 | (uint) num5);
        numArray[index++] = num6;
        num1 = (byte) (num3 << 3 + (int) num2);
        num2 += (byte) 3;
      }
    }
    if (index != length)
      numArray[index] = num1;
    return numArray;
  }

  private static int smethod_93(char char_0)
  {
    if (char_0 < '[' && char_0 > '@')
      return (int) char_0 - 65;
    if (char_0 < '8' && char_0 > '1')
      return (int) char_0 - 24;
    if (char_0 < '{' && char_0 > '`')
      return (int) char_0 - 97;
    throw new ArgumentException("Character is not a Base32 character.", "c");
  }

  public static DataTable smethod_94(DataTable dataTable_0, int int_2 = 1)
  {
    try
    {
      for (int index = 0; index < int_2; ++index)
        dataTable_0 = dataTable_0.Rows.Cast<DataRow>().OrderBy<DataRow, Guid>((System.Func<DataRow, Guid>) (dataRow_0 => Guid.NewGuid())).CopyToDataTable<DataRow>();
    }
    catch
    {
    }
    return dataTable_0;
  }

  public static bool smethod_95(string string_0, string string_1)
  {
    try
    {
      System.IO.File.Copy(string_0, string_1, true);
      return true;
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  public static bool smethod_96(string string_0, string string_1)
  {
    try
    {
      GClass19.smethod_34(string_1);
      foreach (string directory in Directory.GetDirectories(string_0, "*", SearchOption.AllDirectories))
        Directory.CreateDirectory(directory.Replace(string_0, string_1));
      foreach (string file in Directory.GetFiles(string_0, "*.*", SearchOption.AllDirectories))
        System.IO.File.Copy(file, file.Replace(string_0, string_1), true);
      return true;
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  public static bool smethod_97(string string_0, string string_1)
  {
    try
    {
      Directory.Move(string_0, string_1);
      return true;
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  public static bool smethod_98(string string_0)
  {
    try
    {
      if (System.IO.File.Exists(string_0))
        System.IO.File.Delete(string_0);
      return true;
    }
    catch
    {
    }
    return false;
  }

  public static bool smethod_99(string string_0)
  {
    try
    {
      Directory.Delete(string_0, true);
      return true;
    }
    catch
    {
    }
    return false;
  }

  public static int smethod_100(int int_2, int int_3)
  {
    if (int_2 > int_3)
      int_3 = int_2;
    return new Random().Next(int_2, int_3);
  }

  public static string smethod_101(string string_0, int int_2, int int_3 = 30)
  {
    string input = "";
    int tickCount = Environment.TickCount;
    List<string> stringList = new List<string>()
    {
      "https://api64.ipify.org/",
      "http://v4v6.ipv6-test.com/api/myip.php/",
      "https://api.myip.com/"
    };
    while (Environment.TickCount - tickCount < int_3 * 1000)
    {
      for (int index = 0; index < stringList.Count; ++index)
      {
        try
        {
          GClass24 gclass24 = new GClass24("", "", string_0, int_2);
          if (string_0 != "")
            gclass24.httpRequest_0.Proxy.ConnectTimeout = 5000;
          input = gclass24.method_0(stringList[index]);
          if (index == 2)
            input = Regex.Match(input, "ip\":\"(.*?)\"").Groups[1].Value;
          return input;
        }
        catch (Exception ex)
        {
        }
        if (Environment.TickCount - tickCount >= int_3 * 1000)
          break;
      }
      GClass19.smethod_64(1.0);
    }
    return input;
  }

  internal static void smethod_102(string string_0, string string_1)
  {
    try
    {
      GClass19.smethod_98(string_1);
      System.IO.File.Move(string_0, string_1);
    }
    catch
    {
    }
  }

  public static System.Drawing.Point smethod_103(Process process_0)
  {
    IntPtr mainWindowHandle = process_0.MainWindowHandle;
    Rect rect_0 = new Rect();
    GClass8.GetWindowRect(mainWindowHandle, ref rect_0);
    return new System.Drawing.Point(rect_0.Width, rect_0.Height);
  }

  public static void smethod_104(List<Process> list_0, int int_2)
  {
    int x = GClass19.smethod_69().X;
    int int_0 = -5;
    int int_1 = 0;
    for (int index = 0; index < list_0.Count; ++index)
    {
      try
      {
        IntPtr mainWindowHandle = list_0[index].MainWindowHandle;
        string str = list_0[index].MainWindowTitle.Split('|')[2];
        System.Drawing.Point point = new System.Drawing.Point(int.Parse(str.Split('x')[0]), int.Parse(str.Split('x')[1]));
        int int_2_1 = (int) Math.Round((double) x / (double) int_2);
        int int_3 = (int) Math.Round((double) ((int_2_1 - 34) * point.Y) * 1.0 / (double) point.X + 70.0);
        GClass8.MoveWindow(mainWindowHandle, int_0, int_1, int_2_1, int_3, true);
        GClass8.SetForegroundWindow(mainWindowHandle);
        int_0 += int_2_1 - 15;
        if ((index + 1) % int_2 == 0)
        {
          int_0 = -5;
          int_1 += int_3 - 10;
        }
      }
      catch
      {
      }
    }
  }

  public static List<Form> smethod_105(string string_0)
  {
    List<Form> formList = new List<Form>();
    foreach (Form openForm in (ReadOnlyCollectionBase) Application.OpenForms)
    {
      if (openForm.Name == string_0)
        formList.Add(openForm);
    }
    return formList;
  }

  public static List<Form> smethod_106() => GClass19.smethod_105("fView");

  public static void smethod_107(fMain fMain_0 = null, bool bool_0 = true)
  {
    List<Form> list_0 = GClass19.smethod_106();
    if (bool_0)
    {
      if (list_0.Count == 0)
        new fView().Show();
      else
        list_0[0].Invoke((Delegate) (() =>
        {
          list_0[0].Show();
          list_0[0].BringToFront();
        }));
    }
    else
    {
      fView fView = new fView();
      fView.Text = "View Phone - MIN SOFTWARE";
      fView.Show();
    }
  }

  public static void smethod_108(Form form_0 = null)
  {
    if (form_0 == null)
    {
      foreach (Form form in GClass19.smethod_106())
      {
        Form form_ = form;
        form_.Invoke((Delegate) (() =>
        {
          form_.Close();
          form_.Dispose();
        }));
      }
    }
    else
      form_0.Invoke((Delegate) (() => form_0.Close()));
  }

  public static void smethod_109(IntPtr intptr_0, string string_0) => (GClass19.smethod_106()[0] as fView).method_1(intptr_0, string_0);

  public static void smethod_110(int int_2, Form form_0 = null)
  {
    if (form_0 == null)
      (GClass19.smethod_106()[0] as fView).method_2(int_2);
    else
      (form_0 as fView).method_2(int_2);
  }

  internal static bool smethod_111(string string_0) => string_0.Length != Regex.Replace(string_0, "\\p{Cs}", "").Length;

  internal static void smethod_112(string string_0, string string_1)
  {
    byte[] buffer = Convert.FromBase64String(string_0);
    using (MemoryStream memoryStream = new MemoryStream(buffer, 0, buffer.Length))
      Image.FromStream((Stream) memoryStream, true).Save(string_1);
  }

  internal static string smethod_113(string string_0)
  {
    try
    {
      if (string_0.Split('/').Length == 3 && GClass19.smethod_51(string_0.Replace("/", "")))
        return string_0;
      Dictionary<string, string> dictionary = new Dictionary<string, string>()
      {
        {
          "january",
          "1"
        },
        {
          "february",
          "2"
        },
        {
          "march",
          "3"
        },
        {
          "april",
          "4"
        },
        {
          "may",
          "5"
        },
        {
          "june",
          "6"
        },
        {
          "july",
          "7"
        },
        {
          "august",
          "8"
        },
        {
          "september",
          "9"
        },
        {
          "october",
          "10"
        },
        {
          "november",
          "11"
        },
        {
          "december",
          "12"
        }
      };
      string[] strArray = string_0.Split(new char[2]
      {
        ' ',
        ','
      }, StringSplitOptions.RemoveEmptyEntries);
      if (strArray.Length > 2)
      {
        string str1 = dictionary[strArray[0]];
        if (str1 != "")
        {
          string str2 = strArray[1];
          string str3 = strArray[2];
          string str4 = str1 + "/" + str2 + "/" + str3;
          if (str4.Split('/').Length == 3 && GClass19.smethod_51(str4.Replace("/", "")))
            return str4;
        }
      }
    }
    catch
    {
    }
    return "";
  }

  internal static string smethod_114(string string_0)
  {
    try
    {
      if (string_0.Split('/').Length == 3 && GClass19.smethod_51(string_0.Replace("/", "")))
        return string_0;
      Dictionary<string, string> dictionary = new Dictionary<string, string>()
      {
        {
          "january".Substring(0, 3),
          "1"
        },
        {
          "february".Substring(0, 3),
          "2"
        },
        {
          "march".Substring(0, 3),
          "3"
        },
        {
          "april".Substring(0, 3),
          "4"
        },
        {
          "may".Substring(0, 3),
          "5"
        },
        {
          "june".Substring(0, 3),
          "6"
        },
        {
          "july".Substring(0, 3),
          "7"
        },
        {
          "august".Substring(0, 3),
          "8"
        },
        {
          "september".Substring(0, 3),
          "9"
        },
        {
          "october".Substring(0, 3),
          "10"
        },
        {
          "november".Substring(0, 3),
          "11"
        },
        {
          "december".Substring(0, 3),
          "12"
        }
      };
      string[] strArray = string_0.Split(new char[2]
      {
        ' ',
        ','
      }, StringSplitOptions.RemoveEmptyEntries);
      if (strArray.Length > 2)
      {
        string str1 = dictionary[strArray[0]];
        if (str1 != "")
        {
          string str2 = strArray[1];
          string str3 = strArray[2];
          string str4 = str1 + "/" + str2 + "/" + str3;
          if (str4.Split('/').Length == 3 && GClass19.smethod_51(str4.Replace("/", "")))
            return str4;
        }
      }
    }
    catch
    {
    }
    return "";
  }

  internal static string smethod_115(string string_0)
  {
    try
    {
      return new Dictionary<string, string>()
      {
        {
          "1",
          "january"
        },
        {
          "2",
          "february"
        },
        {
          "3",
          "march"
        },
        {
          "4",
          "april"
        },
        {
          "5",
          "may"
        },
        {
          "6",
          "june"
        },
        {
          "7",
          "july"
        },
        {
          "8",
          "august"
        },
        {
          "9",
          "september"
        },
        {
          "10",
          "october"
        },
        {
          "11",
          "november"
        },
        {
          "12",
          "december"
        }
      }[string_0.TrimStart('0')];
    }
    catch
    {
    }
    return "";
  }

  public static void smethod_116(ComboBox comboBox_0, List<string> list_0)
  {
    Dictionary<string, string> dataSource = new Dictionary<string, string>();
    for (int index = 0; index < list_0.Count; ++index)
      dataSource.Add(index.ToString() ?? "", GClass35.smethod_0(list_0[index]));
    comboBox_0.DataSource = (object) new BindingSource((object) dataSource, (string) null);
    comboBox_0.DisplayMember = "Value";
    comboBox_0.ValueMember = "Key";
  }

  public static void smethod_117(ComboBox comboBox_0, Dictionary<string, string> dictionary_0)
  {
    Dictionary<string, string> dataSource = new Dictionary<string, string>();
    foreach (KeyValuePair<string, string> keyValuePair in dictionary_0)
      dataSource.Add(keyValuePair.Key, GClass35.smethod_0(keyValuePair.Value));
    comboBox_0.DataSource = (object) new BindingSource((object) dataSource, (string) null);
    comboBox_0.DisplayMember = "Value";
    comboBox_0.ValueMember = "Key";
  }
}
