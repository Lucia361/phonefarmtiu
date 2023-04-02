// Decompiled with JetBrains decompiler
// Type: fDownloadFile
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;

public class fDownloadFile : Form
{
  private string string_0 = "";
  private string string_1 = "";
  private IContainer icontainer_0 = (IContainer) null;
  private Label lblproccess;
  private MetroProgressBar progressBar1;

  public fDownloadFile(string string_2)
  {
    this.InitializeComponent();
    this.method_0();
    this.string_0 = string_2;
    this.string_1 = Path.GetFileName(this.string_0);
  }

  private void method_0() => GClass35.smethod_1((Control) this.lblproccess);

  private void fDownloadFile_Load(object sender, EventArgs e)
  {
    try
    {
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
      string str = Class54.string_2 + Class54.string_1;
      if (Class65.smethod_0())
      {
        Uri uri_0 = new Uri(this.string_0);
        GClass19.smethod_99("download");
        GClass19.smethod_34("download");
        this.method_3(uri_0, "download\\" + this.string_1);
      }
      else
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Không có kết nối Internet, vui lòng kiểm tra lại!"));
        this.Close();
      }
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) ("Error: " + ex.Message), 2);
      this.Close();
    }
  }

  public void method_1(string string_2, string string_3) => this.method_2(new DirectoryInfo(string_2), new DirectoryInfo(string_3));

  public void method_2(DirectoryInfo directoryInfo_0, DirectoryInfo directoryInfo_1)
  {
    Directory.CreateDirectory(directoryInfo_1.FullName);
    int num = 1;
    foreach (FileInfo file in directoryInfo_0.GetFiles())
    {
      Application.DoEvents();
      file.CopyTo(Path.Combine(directoryInfo_1.FullName, file.Name), true);
      ++num;
    }
    foreach (DirectoryInfo directory in directoryInfo_0.GetDirectories())
    {
      DirectoryInfo subdirectory = directoryInfo_1.CreateSubdirectory(directory.Name);
      this.method_2(directory, subdirectory);
    }
  }

  private void method_3(Uri uri_0, string string_2) => new Thread((ThreadStart) (() =>
  {
    WebClient webClient = new WebClient();
    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.method_4);
    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(this.method_5);
    webClient.DownloadFileAsync(uri_0, string_2);
  }))
  {
    IsBackground = true
  }.Start();

  private void method_4(object sender, DownloadProgressChangedEventArgs e) => this.BeginInvoke((Delegate) (() =>
  {
    double d = double.Parse(e.BytesReceived.ToString()) / double.Parse(e.TotalBytesToReceive.ToString()) * 100.0;
    this.lblproccess.Text = string.Format("Downloading ({0}%)...", (object) int.Parse(Math.Truncate(d).ToString()));
    this.progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
  }));

  private void method_5(object sender, AsyncCompletedEventArgs e)
  {
    this.BeginInvoke((Delegate) (() => this.lblproccess.Text = GClass35.smethod_0("Unzip file...")));
    try
    {
      ZipFile.ExtractToDirectory("./download/" + this.string_1, "./download/");
      GClass19.smethod_98("./download/" + this.string_1);
      this.method_1("download", "./");
      GClass19.smethod_99("download");
      this.BeginInvoke((Delegate) (() => this.Close()));
    }
    catch (Exception ex)
    {
      GClass14.smethod_0((object) ("Error: " + ex.Message), 2);
      this.BeginInvoke((Delegate) (() => this.Close()));
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
    this.lblproccess = new Label();
    this.progressBar1 = new MetroProgressBar();
    this.SuspendLayout();
    this.lblproccess.AutoSize = true;
    this.lblproccess.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblproccess.Location = new Point(34, 22);
    this.lblproccess.Name = "lblproccess";
    this.lblproccess.Size = new Size(125, 16);
    this.lblproccess.TabIndex = 1;
    this.lblproccess.Text = "Downloading (0%)...";
    this.progressBar1.Location = new Point(37, 52);
    this.progressBar1.Name = "progressBar1";
    this.progressBar1.Size = new Size(219, 23);
    this.progressBar1.TabIndex = 2;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(224, 224, 224);
    this.ClientSize = new Size(294, 104);
    this.Controls.Add((Control) this.progressBar1);
    this.Controls.Add((Control) this.lblproccess);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fDownloadFile);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "frm_progress";
    this.Load += new EventHandler(this.fDownloadFile_Load);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
