// Decompiled with JetBrains decompiler
// Type: GClass7
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class GClass7
{
  public static List<string> smethod_0()
  {
    List<string> stringList = new List<string>();
    Process process = new Process();
    try
    {
      process.StartInfo = new ProcessStartInfo()
      {
        FileName = Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\adb.exe",
        Arguments = " devices",
        UseShellExecute = false,
        WindowStyle = ProcessWindowStyle.Hidden,
        RedirectStandardError = true,
        RedirectStandardOutput = true,
        CreateNoWindow = true
      };
      process.Start();
      foreach (string input in process.StandardOutput.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
      {
        if (!input.Contains("offline"))
        {
          Regex regex = new Regex("([^/]+) device product:([^/]+) model");
          if (regex.Match(input).Success)
          {
            Match match = regex.Match(input);
            stringList.Add(match.Groups[1].Value.ToString().Trim());
          }
          else if (string.Compare(input.Trim(), "", false) != 0 && !input.Contains("List of devices attached"))
          {
            input.Split("\\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            stringList.Add(input.Replace("device", "").Trim());
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  public static string smethod_1(string string_0, int int_0 = 10)
  {
    int num1 = 0;
    int num2 = 3;
    string str = "";
    try
    {
      string string_;
      string string_2;
      while (true)
      {
        do
        {
          Process process = new Process();
          process.StartInfo.FileName = "cmd.exe";
          process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\" + string_0;
          process.StartInfo.Verb = "runas";
          process.StartInfo.CreateNoWindow = true;
          process.StartInfo.UseShellExecute = false;
          process.StartInfo.RedirectStandardError = true;
          process.StartInfo.RedirectStandardOutput = true;
          process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
          process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
          string_ = "";
          process.OutputDataReceived += (DataReceivedEventHandler) ((sender, e) =>
          {
            if (string.IsNullOrEmpty(e.Data))
              return;
            string_ = string_ + e.Data + "\n";
          });
          string_2 = "";
          process.ErrorDataReceived += (DataReceivedEventHandler) ((sender, e) =>
          {
            if (string.IsNullOrEmpty(e.Data))
              return;
            string_2 = string_2 + e.Data + "\n";
          });
          process.Start();
          process.BeginOutputReadLine();
          process.BeginErrorReadLine();
          bool flag = !process.WaitForExit(int_0 >= 0 ? int_0 * 1000 : -1);
          process.Close();
          if (!flag || string_0.StartsWith("scrcpy"))
          {
            if (!(string_2 != ""))
              goto label_9;
          }
          else
            goto label_2;
        }
        while (string_2.Contains("daemon not running") && !string_2.Contains("daemon started successfully"));
        break;
label_2:
        if (num1 > 0 && num1 % num2 == 0)
          GClass7.smethod_3();
        ++num1;
      }
      if (!(Regex.Match(string_2, "device (.*?) not found").Groups[1].Value != ""))
        ;
label_9:
      str = string_.Trim();
    }
    catch
    {
    }
    return str;
  }

  public static Bitmap smethod_2(string string_0)
  {
    string str = "adb shell screencap -p";
    if (!string.IsNullOrEmpty(string_0))
    {
      string newValue = "adb -s " + string_0;
      str = str.StartsWith("adb") ? str.Replace("adb", newValue) : "adb -s " + string_0 + " " + str;
    }
    Process process = new Process();
    process.StartInfo.FileName = "cmd.exe";
    process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME") + "\\platform-tools\\" + str;
    process.StartInfo.CreateNoWindow = true;
    process.StartInfo.UseShellExecute = false;
    process.StartInfo.RedirectStandardOutput = true;
    process.Start();
    Stream baseStream = process.StandardOutput.BaseStream;
    process.Close();
    List<byte> byteList = new List<byte>(1024);
    bool flag = false;
    int num;
    do
    {
      byte[] buffer = new byte[1024];
      num = baseStream.Read(buffer, 0, buffer.Length);
      for (int index = 0; index < num; ++index)
      {
        if (flag && buffer[index] == (byte) 10)
        {
          flag = false;
          byteList.RemoveAt(byteList.Count - 1);
          byteList.Add(buffer[index]);
        }
        else
        {
          flag = buffer[index] == (byte) 13;
          byteList.Add(buffer[index]);
        }
      }
    }
    while (num > 0);
    Bitmap bitmap = (Bitmap) null;
    if (byteList.Count > 0)
      bitmap = new Bitmap((Stream) new MemoryStream(byteList.ToArray()));
    return bitmap;
  }

  public static void smethod_3()
  {
    try
    {
      GClass19.smethod_63("taskkill /f /im adb.exe");
    }
    catch
    {
    }
  }

  public static void smethod_4()
  {
    try
    {
      GClass7.smethod_1("adb start-server");
    }
    catch
    {
    }
  }
}
