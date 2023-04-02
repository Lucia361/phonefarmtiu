// Decompiled with JetBrains decompiler
// Type: GClass13
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.IO;
using System.Windows.Forms;

public class GClass13
{
  public static string smethod_0() => Path.GetDirectoryName(Application.ExecutablePath);

  public static string smethod_1()
  {
    string str = "";
    try
    {
      using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
      {
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
          str = folderBrowserDialog.SelectedPath;
      }
    }
    catch
    {
    }
    return str;
  }

  public static string smethod_2(string string_0 = "Chọn File txt", string string_1 = "C:\\", string string_2 = "txt Files (*.txt)|*.txt|All files (*.*)|*.*")
  {
    string str = "";
    try
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = string_2;
        openFileDialog.InitialDirectory = string_1;
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

  public static bool smethod_3(string string_0, string string_1, bool bool_0)
  {
    try
    {
      DirectoryInfo directoryInfo1 = new DirectoryInfo(string_0);
      if (!directoryInfo1.Exists)
        return false;
      DirectoryInfo[] directories = directoryInfo1.GetDirectories();
      Directory.CreateDirectory(string_1);
      foreach (FileInfo file in directoryInfo1.GetFiles())
      {
        string destFileName = Path.Combine(string_1, file.Name);
        file.CopyTo(destFileName, true);
      }
      if (bool_0)
      {
        foreach (DirectoryInfo directoryInfo2 in directories)
        {
          string string_1_1 = Path.Combine(string_1, directoryInfo2.Name);
          GClass13.smethod_3(directoryInfo2.FullName, string_1_1, bool_0);
        }
      }
      return true;
    }
    catch (Exception ex)
    {
    }
    return false;
  }

  public static void smethod_4(string string_0)
  {
    try
    {
      File.AppendAllText(string_0, "");
    }
    catch
    {
    }
  }

  public static void smethod_5(string string_0)
  {
    try
    {
      Directory.CreateDirectory(string_0);
    }
    catch
    {
    }
  }
}
