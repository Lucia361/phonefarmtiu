// Decompiled with JetBrains decompiler
// Type: fCheckAppium
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

public class fCheckAppium : Form
{
  private string string_0 = "";
  private Bitmap bitmap_0;
  private string string_1;
  private List<string> list_0 = new List<string>();
  private Bitmap bitmap_1 = (Bitmap) null;
  private Random random_0 = new Random();
  private IContainer icontainer_0 = (IContainer) null;
  private Button button2;
  private GroupBox groupBox2;
  private Button button8;
  private TextBox txtContent;
  private Label label1;
  private TextBox txtBoundToDraw;
  private TextBox txtMouseX;
  private Button button1;
  private TextBox txtMouseY;
  private Label label13;
  private PictureBox pictureBox1;
  private Button button12;
  private Button button19;
  private Button button18;
  private GroupBox groupBox7;
  private TextBox txtFolderPathToCropImage;
  private Label label3;
  private TextBox txtFolderPathToSaveImage;
  private Label label12;
  private TextBox txtTextToDraw;
  private Label label16;
  private Button button20;
  private Button button22;
  private Button button21;
  private Button button23;
  private TextBox txtFile;
  private GroupBox groupBox3;
  private Label label2;
  private Button button14;
  private TextBox txtResultCmd;
  private TextBox txtCommand;
  private GroupBox groupBox8;
  private GClass34 treeView1;
  public DataGridView dtgvAttribute;
  private DataGridViewTextBoxColumn cAttribute;
  private DataGridViewTextBoxColumn cValue;
  private TextBox txtXPath;
  private TextBox txtValue;
  private TextBox txtAttribute;
  private Label label18;
  private Label label19;
  private Label label17;
  private Button button25;
  private Button button4;
  private Button button3;
  private ComboBox cbbDevice;
  private PictureBox pictureBox2;
  private Label label4;
  private Label label5;
  private TextBox txtPathImage;
  private TextBox txtPathXml;
  private Button button5;
  private TextBox txtSearchXpath;
  private Label label6;
  private Button button6;
  private Button button7;
  private Button button9;
  private Label label7;
  private TextBox txtActivity;
  private Button button29;
  private Button button30;
  private Button button10;
  private TextBox txtImage;
  private Label label8;
  private Button button11;
  private Button button13;

  public fCheckAppium(string string_2 = "")
  {
    this.InitializeComponent();
    this.string_0 = string_2;
  }

  private void button2_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.cbbDevice.Text.Trim() == "")
        return;
      this.pictureBox1.Image = (Image) new Bitmap((Image) this.bitmap_1);
      this.list_0.Clear();
    }
    catch
    {
    }
  }

  private void button1_Click(object sender, EventArgs e)
  {
    List<string> list = ((IEnumerable<string>) this.txtBoundToDraw.Lines).ToList<string>();
    Bitmap bitmap_2 = (Bitmap) this.pictureBox1.Image;
    for (int index = 0; index < list.Count; ++index)
    {
      if (list[index] != "")
      {
        try
        {
          bitmap_2 = this.method_2(bitmap_2, list[index]);
          this.list_0.Add(list[index]);
        }
        catch
        {
        }
      }
    }
    this.pictureBox1.Image = (Image) bitmap_2;
  }

  private bool method_0(string string_2)
  {
    if (string_2 == "")
      return false;
    int index = 0;
    while (true)
    {
      if (index < string_2.Length)
      {
        if (char.IsDigit(string_2[index]))
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

  private int method_1(params int[] int_0)
  {
    if (int_0.Length == 0)
      return 0;
    int num = int_0[0];
    for (int index = 1; index < int_0.Length; ++index)
    {
      if (int_0[index] > num)
        num = int_0[index];
    }
    return num;
  }

  private void button12_Click(object sender, EventArgs e)
  {
    List<string> stringList = this.method_5(this.list_0);
    if (stringList.Count == 0 || this.bitmap_1 == null)
      return;
    string str = this.txtFolderPathToCropImage.Text.Trim();
    try
    {
      Bitmap bitmap1 = this.bitmap_1;
      List<int> intList = new List<int>();
      foreach (string file in Directory.GetFiles(str))
      {
        string withoutExtension = Path.GetFileNameWithoutExtension(file);
        if (this.method_0(withoutExtension))
          intList.Add(Convert.ToInt32(withoutExtension));
      }
      int num = this.method_1(intList.ToArray()) + 1;
      for (int index = 0; index < stringList.Count; ++index)
      {
        try
        {
          this.method_4(bitmap1, stringList[index], Path.Combine(str, num++.ToString() + ".png"));
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

  private Bitmap method_2(Bitmap bitmap_2, string string_2)
  {
    string[] strArray = string_2.Split('[', ',', ']');
    Pen pen = new Pen(Color.Red, 2f);
    Graphics.FromImage((Image) bitmap_2).DrawRectangle(pen, Convert.ToInt32(strArray[1]) - 1, Convert.ToInt32(strArray[2]) - 1, Convert.ToInt32(strArray[4]) - Convert.ToInt32(strArray[1]) + 2, Convert.ToInt32(strArray[5]) - Convert.ToInt32(strArray[2]) + 2);
    return bitmap_2;
  }

  private Bitmap method_3(Bitmap bitmap_2, Rect rect_0)
  {
    Pen pen = new Pen(Color.Red, 2f);
    Graphics.FromImage((Image) bitmap_2).DrawRectangle(pen, rect_0.X - 1, rect_0.Y - 1, rect_0.Width + 2, rect_0.Height + 2);
    return bitmap_2;
  }

  private void method_4(Bitmap bitmap_2, string string_2, string string_3)
  {
    string[] strArray = string_2.Split('[', ',', ']');
    bitmap_2.Clone(new Rectangle(Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[2]), Convert.ToInt32(strArray[4]) - Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[5]) - Convert.ToInt32(strArray[2])), bitmap_2.PixelFormat).Save(string_3);
  }

  private void button8_Click(object sender, EventArgs e)
  {
    if (this.cbbDevice.Text.Trim() == "")
      return;
    GClass27 gclass27 = this.method_14();
    if (gclass27 != null)
    {
      gclass27.method_50(this.txtXPath.Text.Trim(), this.txtContent.Text.Trim());
      this.button25_Click((object) null, (EventArgs) null);
    }
  }

  public List<string> method_5(List<string> list_1) => list_1.Where<string>((Func<string, bool>) (string_0 => !string.IsNullOrWhiteSpace(string_0))).ToList<string>();

  private void button14_Click(object sender, EventArgs e) => this.cbbDevice.Text.Trim();

  private void button19_Click(object sender, EventArgs e) => this.pictureBox1.Image.Save(Path.Combine(this.txtFolderPathToCropImage.Text.Trim(), "_.png"));

  private string method_6(int int_0, int int_1)
  {
    try
    {
      if (this.pictureBox1.Image != null)
      {
        int width1 = this.pictureBox1.Image.Width;
        int height1 = this.pictureBox1.Image.Height;
        Rectangle clientRectangle = this.pictureBox1.ClientRectangle;
        int width2 = clientRectangle.Width;
        clientRectangle = this.pictureBox1.ClientRectangle;
        int height2 = clientRectangle.Height;
        double val1 = (double) width2 / (double) width1;
        double val2 = (double) height2 / (double) height1;
        double num1 = Math.Min(val1, val2);
        double num2 = num1 == val1 ? 0.0 : ((double) width2 - num1 * (double) width1) / 2.0;
        double num3 = num1 == val2 ? 0.0 : ((double) height2 - num1 * (double) height1) / 2.0;
        int num4 = (int) (((double) int_0 - num2) / num1);
        int num5 = (int) (((double) int_1 - num3) / num1);
        return (num4 < 0 || num4 > width1 ? "-" : num4.ToString()) + "|" + (num5 < 0 || num5 > height1 ? "-" : num5.ToString());
      }
    }
    catch
    {
    }
    return "0|0";
  }

  private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
  {
    string str = this.method_6(e.X, e.Y);
    this.txtMouseX.Text = str.Split('|')[0];
    this.txtMouseY.Text = str.Split('|')[1];
  }

  private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
  {
    int length = this.txtBoundToDraw.Lines.Length;
    string str = "";
    if (length > 0)
      str = this.txtBoundToDraw.Lines[length - 1];
    if (str.Contains("]["))
    {
      TextBox txtBoundToDraw = this.txtBoundToDraw;
      txtBoundToDraw.Text = txtBoundToDraw.Text + "\r\n[" + this.txtMouseX.Text + "," + this.txtMouseY.Text + "]";
    }
    else
    {
      TextBox txtBoundToDraw = this.txtBoundToDraw;
      txtBoundToDraw.Text = txtBoundToDraw.Text + "[" + this.txtMouseX.Text + "," + this.txtMouseY.Text + "]";
    }
  }

  private void button18_Click(object sender, EventArgs e)
  {
    if (!(this.cbbDevice.Text.Trim() == ""))
      ;
  }

  private void label19_Click(object sender, EventArgs e)
  {
  }

  private void txtFolderPathToCropImage_TextChanged(object sender, EventArgs e)
  {
  }

  private void button20_Click(object sender, EventArgs e)
  {
    if (!(this.cbbDevice.Text.Trim() == ""))
      ;
  }

  private void button21_Click(object sender, EventArgs e) => this.txtBoundToDraw.Clear();

  private void button22_Click(object sender, EventArgs e) => this.txtTextToDraw.Clear();

  private void button23_Click(object sender, EventArgs e)
  {
    try
    {
      this.bitmap_1 = new Bitmap(this.txtFile.Text.Trim());
      this.pictureBox1.Image = (Image) new Bitmap((Image) this.bitmap_1);
      this.list_0.Clear();
    }
    catch
    {
    }
  }

  private void button25_Click(object sender, EventArgs e)
  {
    bool bool_2 = true;
    bool bool_1 = true;
    bool bool_0 = true;
    if (e != null && (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
    {
      bool_1 = false;
      bool_0 = false;
    }
    new Thread((ThreadStart) (() =>
    {
      try
      {
        this.Invoke((Delegate) (() =>
        {
          GClass27 gclass27 = this.method_14();
          if (gclass27 == null)
            return;
          if (bool_0)
            this.txtActivity.Text = gclass27.method_22();
          if (bool_1)
          {
            try
            {
              this.string_1 = gclass27.method_53();
              this.method_7(this.string_1);
            }
            catch
            {
            }
          }
          if (bool_2)
          {
            try
            {
              this.bitmap_0 = gclass27.method_130();
              this.pictureBox1.Image = (Image) new Bitmap((Image) this.bitmap_0);
            }
            catch
            {
            }
          }
        }));
      }
      catch (Exception ex)
      {
        GClass14.smethod_0((object) ("Erorr: " + ex.ToString()), 2);
      }
    }))
    {
      IsBackground = true
    }.Start();
  }

  private void method_7(string string_2)
  {
    try
    {
      if (string_2 == "")
      {
        this.treeView1.Nodes.Clear();
      }
      else
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(string_2);
        this.treeView1.Nodes.Clear();
        foreach (XmlNode childNode in xmlDocument.DocumentElement.ChildNodes)
          this.method_10(this.treeView1.Nodes, childNode);
        this.treeView1.ExpandAll();
        foreach (TreeNode node in this.treeView1.Nodes)
          this.method_8(node);
      }
    }
    catch (Exception ex)
    {
    }
  }

  private void method_8(TreeNode treeNode_0)
  {
    string text = treeNode_0.Text;
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.LoadXml(text);
    foreach (XmlAttribute attribute in (XmlNamedNodeMap) xmlDocument.DocumentElement.Attributes)
    {
      if ((attribute.Name == "text" || attribute.Name == "content-desc") && attribute.Value != "")
      {
        treeNode_0.BackColor = Color.FromArgb(212, 237, 182);
        break;
      }
    }
    foreach (TreeNode node in treeNode_0.Nodes)
      this.method_8(node);
  }

  private void method_9(TreeNode treeNode_0)
  {
    treeNode_0.ForeColor = Color.Black;
    foreach (TreeNode node in treeNode_0.Nodes)
      this.method_9(node);
  }

  private void method_10(TreeNodeCollection treeNodeCollection_0, XmlNode xmlNode_0)
  {
    if (xmlNode_0.HasChildNodes)
    {
      string outerXml = xmlNode_0.OuterXml;
      TreeNode treeNode = treeNodeCollection_0.Add(outerXml);
      XmlNodeList childNodes = xmlNode_0.ChildNodes;
      for (int i = 0; i <= childNodes.Count - 1; ++i)
      {
        XmlNode childNode = xmlNode_0.ChildNodes[i];
        this.method_10(treeNode.Nodes, childNode);
      }
    }
    else
    {
      string text = xmlNode_0.OuterXml.Trim();
      treeNodeCollection_0.Add(text);
    }
  }

  private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
  {
    this.dtgvAttribute.Rows.Clear();
    this.method_11(-1);
    try
    {
      string text = this.treeView1.SelectedNode.Text;
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(text);
      XmlElement documentElement = xmlDocument.DocumentElement;
      foreach (XmlAttribute attribute in (XmlNamedNodeMap) documentElement.Attributes)
      {
        DataGridViewRow row = this.dtgvAttribute.Rows[this.dtgvAttribute.Rows.Add()];
        row.Cells["cAttribute"].Value = (object) attribute.Name;
        row.Cells["cValue"].Value = (object) attribute.Value;
        if ((attribute.Name == "text" || attribute.Name == "content-desc") && attribute.Value != "")
        {
          row.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
          this.method_11(row.Index);
        }
      }
      this.pictureBox1.Image = (Image) this.method_2(new Bitmap((Image) this.bitmap_0), documentElement.Attributes["bounds"].Value);
    }
    catch (Exception ex)
    {
    }
  }

  private void dtgvAttribute_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex <= 0)
      return;
    this.method_11(e.RowIndex);
  }

  private void method_11(int int_0)
  {
    if (int_0 < 0)
    {
      this.txtAttribute.Text = "";
      this.txtValue.Text = "";
      this.txtXPath.Text = "";
    }
    else
    {
      DataGridViewRow row = this.dtgvAttribute.Rows[int_0];
      string str1 = row.Cells["cAttribute"].Value.ToString();
      string str2 = row.Cells["cValue"].Value.ToString();
      DataGridViewRowCollection rows = this.dtgvAttribute.Rows;
      string str3 = "";
      for (int index = 0; index < rows.Count; ++index)
      {
        if (rows[index].Cells["cAttribute"].Value.ToString() == "class")
        {
          str3 = rows[index].Cells["cValue"].Value.ToString();
          break;
        }
      }
      this.txtAttribute.Text = str1;
      this.txtValue.Text = str2;
      this.txtXPath.Text = "//" + str3 + "[@" + str1 + "='" + str2 + "']";
    }
  }

  private void pictureBox2_Click(object sender, EventArgs e)
  {
    this.cbbDevice.Items.Clear();
    List<string> stringList = this.method_13();
    if (stringList.Count == 0)
      return;
    for (int index = 0; index < stringList.Count; ++index)
      this.cbbDevice.Items.Add((object) stringList[index]);
    this.cbbDevice.SelectedIndex = 0;
  }

  public string method_12(string string_2, int int_0 = 10)
  {
    string str = "";
    try
    {
      Process process = new Process();
      process.StartInfo.FileName = "cmd.exe";
      int num = string_2.StartsWith("adb") ? 0 : (!string_2.StartsWith("scrcpy") ? 1 : 0);
      process.StartInfo.Arguments = num == 0 ? "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\" + string_2 : "/c " + string_2;
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
      if (int_0 < 0)
        process.WaitForExit();
      else
        process.WaitForExit(int_0 * 1000);
      process.Close();
      str = stringBuilder_0.ToString().Trim();
      if (str.Contains("daemon not running") && !str.Contains("daemon started successfully"))
      {
        Thread.Sleep(1000);
        this.method_12(string_2, int_0);
      }
    }
    catch
    {
    }
    return str;
  }

  public List<string> method_13()
  {
    List<string> stringList = new List<string>();
    string[] strArray = this.method_12("adb devices", 5).Replace("List of devices attached", "").Trim().Split(new string[1]
    {
      "\n"
    }, StringSplitOptions.RemoveEmptyEntries);
    for (int index = 0; index < strArray.Length; ++index)
    {
      if (!strArray[index].Contains("offline") && strArray[index].Contains("device"))
        stringList.Add(strArray[index].Trim().Split('\t')[0]);
    }
    return stringList;
  }

  private void button3_Click(object sender, EventArgs e)
  {
    DataGridViewRowCollection rows = this.dtgvAttribute.Rows;
    string string_11 = "";
    for (int index = 0; index < rows.Count; ++index)
    {
      if (rows[index].Cells["cAttribute"].Value.ToString() == "bounds")
      {
        string_11 = rows[index].Cells["cValue"].Value.ToString();
        break;
      }
    }
    if (string.IsNullOrEmpty(string_11))
      return;
    GClass27 gclass27 = this.method_14();
    if (gclass27 != null)
    {
      gclass27.method_66(string_11);
      this.button25_Click((object) null, (EventArgs) null);
    }
  }

  private void button4_Click(object sender, EventArgs e)
  {
    string string_11 = this.txtXPath.Text.Trim();
    if (string.IsNullOrEmpty(string_11))
      return;
    GClass27 gclass27 = this.method_14();
    if (gclass27 != null)
    {
      gclass27.method_58(string_11);
      this.button25_Click((object) null, (EventArgs) null);
    }
  }

  private GClass27 method_14()
  {
    string string_11 = this.cbbDevice.Text.Trim();
    if (!string.IsNullOrEmpty(string_11))
    {
      GClass27 gclass27 = new GClass27(string_11);
      if (gclass27.method_1() != "")
        return gclass27;
    }
    return (GClass27) null;
  }

  private void button5_Click(object sender, EventArgs e)
  {
    try
    {
      string path = this.txtPathXml.Text.Trim();
      if (!string.IsNullOrEmpty(path))
      {
        this.string_1 = !File.Exists(path) ? path : File.ReadAllText(path);
        this.string_1 = Regex.Match(this.string_1, "<\\?xml(.*?)</hierarchy>", RegexOptions.Singleline).Value;
        this.method_7(this.string_1);
      }
      string filename = this.txtPathImage.Text.Trim();
      if (string.IsNullOrEmpty(filename))
        return;
      this.bitmap_0 = new Bitmap(filename);
      this.pictureBox1.Image = (Image) new Bitmap((Image) this.bitmap_0);
    }
    catch (Exception ex)
    {
    }
  }

  private void button7_Click(object sender, EventArgs e) => this.txtPathImage.Text = this.method_15("Chọn File png", "png Files (*.png)|*.png|");

  private string method_15(string string_2 = "Chọn File txt", string string_3 = "txt Files (*.txt)|*.txt|")
  {
    string str = "";
    try
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = string_3 + "All files (*.*)|*.*";
        openFileDialog.Title = string_2;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
          str = openFileDialog.FileName;
      }
    }
    catch
    {
    }
    return str;
  }

  private void button9_Click(object sender, EventArgs e) => this.txtPathXml.Text = this.method_15();

  private void button6_Click(object sender, EventArgs e)
  {
    TreeNodeCollection nodes = this.treeView1.Nodes;
    foreach (TreeNode treeNode_0 in nodes)
      this.method_9(treeNode_0);
    List<string> list_1 = this.method_17(this.string_1, this.txtSearchXpath.Text.Trim());
    this.label6.Text = string.Format("({0})", (object) list_1.Count);
    if (list_1.Count == 0)
      return;
    List<TreeNode> list_2 = new List<TreeNode>();
    foreach (TreeNode treeNode_0 in nodes)
      this.method_16(treeNode_0, list_1, ref list_2);
    if (list_2.Count <= 0)
      return;
    foreach (TreeNode treeNode in list_2)
      treeNode.ForeColor = Color.Red;
    this.treeView1.SelectedNode = list_2[0];
  }

  private void method_16(TreeNode treeNode_0, List<string> list_1, ref List<TreeNode> list_2)
  {
    // ISSUE: explicit non-virtual call
    if (list_1 != null && __nonvirtual (list_1.Contains(treeNode_0.Text.ToLower())))
      list_2.Add(treeNode_0);
    foreach (TreeNode node in treeNode_0.Nodes)
      this.method_16(node, list_1, ref list_2);
  }

  private List<string> method_17(string string_2, string string_3)
  {
    List<string> stringList = new List<string>();
    try
    {
      string_2 = string_2.ToLower();
      string_3 = string_3.ToLower();
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(string_2.ToLower());
      XmlNodeList xmlNodeList = xmlDocument.SelectNodes(string_3);
      for (int i = 0; i < xmlNodeList.Count; ++i)
        stringList.Add(xmlNodeList[i].OuterXml);
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  private void button29_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(this.cbbDevice.Text.Trim()))
      return;
    GClass27 gclass27 = this.method_14();
    if (gclass27 != null)
    {
      gclass27.method_27(this.txtActivity.Text.Trim());
      this.button25_Click((object) null, (EventArgs) null);
    }
  }

  private void pictureBox1_Click(object sender, EventArgs e) => GClass19.smethod_26(this.txtMouseX.Text + " " + this.txtMouseY.Text);

  private void method_18(object sender, EventArgs e)
  {
  }

  private void fCheckAppium_Load(object sender, EventArgs e)
  {
    if (!(this.string_0 != ""))
      return;
    this.cbbDevice.Text = this.string_0;
    this.button25_Click((object) null, (EventArgs) null);
  }

  private void button30_Click(object sender, EventArgs e) => this.method_19();

  private void method_19(bool bool_0 = false)
  {
    try
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "png files (*.png) | *.png";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      string fileName = saveFileDialog.FileName;
      this.bitmap_0.Save(fileName);
      if (bool_0)
        Process.Start(new ProcessStartInfo()
        {
          FileName = "mspaint.exe",
          Arguments = "\"" + fileName + "\""
        });
    }
    catch (Exception ex)
    {
    }
  }

  private void button10_Click(object sender, EventArgs e) => this.method_19(true);

  private void button13_Click(object sender, EventArgs e)
  {
    this.string_1 = this.string_1.Replace("\r\n", " ");
    GClass19.smethod_26(this.string_1);
  }

  private void button11_Click(object sender, EventArgs e)
  {
    try
    {
      string str = this.txtImage.Text.Trim();
      List<Bitmap> bitmapList = new List<Bitmap>();
      if (Directory.Exists(str))
      {
        foreach (FileSystemInfo file in new DirectoryInfo(str).GetFiles())
        {
          Bitmap bitmap = (Bitmap) Image.FromFile(file.FullName);
          bitmapList.Add(bitmap);
        }
      }
      else if (File.Exists(str))
        bitmapList.Add((Bitmap) Image.FromFile(str));
      List<Rect> rectList = new List<Rect>();
      for (int index = 0; index < bitmapList.Count; ++index)
        rectList.AddRange((IEnumerable<Rect>) new GClass27("").method_119(this.bitmap_0, bitmapList[index], 0.99));
      this.label8.Text = string.Format("({0})", (object) rectList.Count);
      if (rectList.Count == 0)
        return;
      for (int index = 0; index < rectList.Count; ++index)
        this.bitmap_0 = this.method_3(this.bitmap_0, rectList[index]);
      this.pictureBox1.Image = (Image) new Bitmap((Image) this.bitmap_0);
    }
    catch (Exception ex)
    {
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
    DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fCheckAppium));
    this.button2 = new Button();
    this.groupBox2 = new GroupBox();
    this.txtImage = new TextBox();
    this.label8 = new Label();
    this.button11 = new Button();
    this.pictureBox1 = new PictureBox();
    this.groupBox7 = new GroupBox();
    this.txtTextToDraw = new TextBox();
    this.txtBoundToDraw = new TextBox();
    this.txtFolderPathToSaveImage = new TextBox();
    this.txtFolderPathToCropImage = new TextBox();
    this.button12 = new Button();
    this.button19 = new Button();
    this.label16 = new Label();
    this.label12 = new Label();
    this.label13 = new Label();
    this.button20 = new Button();
    this.label3 = new Label();
    this.button22 = new Button();
    this.button21 = new Button();
    this.button1 = new Button();
    this.txtMouseX = new TextBox();
    this.groupBox3 = new GroupBox();
    this.label2 = new Label();
    this.button14 = new Button();
    this.txtResultCmd = new TextBox();
    this.txtCommand = new TextBox();
    this.button23 = new Button();
    this.button18 = new Button();
    this.txtFile = new TextBox();
    this.button10 = new Button();
    this.button30 = new Button();
    this.txtMouseY = new TextBox();
    this.button8 = new Button();
    this.txtContent = new TextBox();
    this.label1 = new Label();
    this.groupBox8 = new GroupBox();
    this.button13 = new Button();
    this.treeView1 = new GClass34();
    this.dtgvAttribute = new DataGridView();
    this.cAttribute = new DataGridViewTextBoxColumn();
    this.cValue = new DataGridViewTextBoxColumn();
    this.txtSearchXpath = new TextBox();
    this.txtXPath = new TextBox();
    this.label6 = new Label();
    this.label17 = new Label();
    this.label19 = new Label();
    this.button6 = new Button();
    this.txtValue = new TextBox();
    this.label18 = new Label();
    this.txtAttribute = new TextBox();
    this.button4 = new Button();
    this.button3 = new Button();
    this.button25 = new Button();
    this.cbbDevice = new ComboBox();
    this.pictureBox2 = new PictureBox();
    this.label4 = new Label();
    this.label5 = new Label();
    this.txtPathImage = new TextBox();
    this.txtPathXml = new TextBox();
    this.button5 = new Button();
    this.button7 = new Button();
    this.button9 = new Button();
    this.label7 = new Label();
    this.txtActivity = new TextBox();
    this.button29 = new Button();
    this.groupBox2.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.groupBox7.SuspendLayout();
    this.groupBox3.SuspendLayout();
    this.groupBox8.SuspendLayout();
    ((ISupportInitialize) this.dtgvAttribute).BeginInit();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    this.SuspendLayout();
    this.button2.Cursor = Cursors.Hand;
    this.button2.Location = new System.Drawing.Point(332, 54);
    this.button2.Margin = new Padding(3, 4, 3, 4);
    this.button2.Name = "button2";
    this.button2.Size = new System.Drawing.Size(106, 26);
    this.button2.TabIndex = 0;
    this.button2.Text = "Screen Shot";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.groupBox2.Controls.Add((Control) this.txtImage);
    this.groupBox2.Controls.Add((Control) this.label8);
    this.groupBox2.Controls.Add((Control) this.button11);
    this.groupBox2.Controls.Add((Control) this.pictureBox1);
    this.groupBox2.Controls.Add((Control) this.groupBox7);
    this.groupBox2.Controls.Add((Control) this.txtMouseX);
    this.groupBox2.Controls.Add((Control) this.groupBox3);
    this.groupBox2.Controls.Add((Control) this.button23);
    this.groupBox2.Controls.Add((Control) this.button18);
    this.groupBox2.Controls.Add((Control) this.txtFile);
    this.groupBox2.Controls.Add((Control) this.button10);
    this.groupBox2.Controls.Add((Control) this.button30);
    this.groupBox2.Controls.Add((Control) this.button2);
    this.groupBox2.Controls.Add((Control) this.txtMouseY);
    this.groupBox2.Location = new System.Drawing.Point(15, 122);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new System.Drawing.Size(332, 655);
    this.groupBox2.TabIndex = 2;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Xử lý Ảnh";
    this.txtImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtImage.Location = new System.Drawing.Point(41, 625);
    this.txtImage.Name = "txtImage";
    this.txtImage.Size = new System.Drawing.Size(223, 23);
    this.txtImage.TabIndex = 13;
    this.label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label8.AutoSize = true;
    this.label8.Location = new System.Drawing.Point(2, 628);
    this.label8.Name = "label8";
    this.label8.Size = new System.Drawing.Size(37, 16);
    this.label8.TabIndex = 15;
    this.label8.Text = "Path:";
    this.button11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button11.Cursor = Cursors.Hand;
    this.button11.Location = new System.Drawing.Point(268, 624);
    this.button11.Name = "button11";
    this.button11.Size = new System.Drawing.Size(58, 25);
    this.button11.TabIndex = 14;
    this.button11.Text = "Search";
    this.button11.UseVisualStyleBackColor = true;
    this.button11.Click += new EventHandler(this.button11_Click);
    this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
    this.pictureBox1.Cursor = Cursors.Cross;
    this.pictureBox1.Location = new System.Drawing.Point(6, 22);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new System.Drawing.Size(320, 569);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    this.pictureBox1.TabIndex = 5;
    this.pictureBox1.TabStop = false;
    this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
    this.pictureBox1.MouseMove += new MouseEventHandler(this.pictureBox1_MouseMove);
    this.pictureBox1.MouseUp += new MouseEventHandler(this.pictureBox1_MouseUp);
    this.groupBox7.Controls.Add((Control) this.txtTextToDraw);
    this.groupBox7.Controls.Add((Control) this.txtBoundToDraw);
    this.groupBox7.Controls.Add((Control) this.txtFolderPathToSaveImage);
    this.groupBox7.Controls.Add((Control) this.txtFolderPathToCropImage);
    this.groupBox7.Controls.Add((Control) this.button12);
    this.groupBox7.Controls.Add((Control) this.button19);
    this.groupBox7.Controls.Add((Control) this.label16);
    this.groupBox7.Controls.Add((Control) this.label12);
    this.groupBox7.Controls.Add((Control) this.label13);
    this.groupBox7.Controls.Add((Control) this.button20);
    this.groupBox7.Controls.Add((Control) this.label3);
    this.groupBox7.Controls.Add((Control) this.button22);
    this.groupBox7.Controls.Add((Control) this.button21);
    this.groupBox7.Controls.Add((Control) this.button1);
    this.groupBox7.Location = new System.Drawing.Point(332, 87);
    this.groupBox7.Name = "groupBox7";
    this.groupBox7.Size = new System.Drawing.Size(278, 241);
    this.groupBox7.TabIndex = 10;
    this.groupBox7.TabStop = false;
    this.groupBox7.Text = "Draw, Crop";
    this.txtTextToDraw.Location = new System.Drawing.Point(70, 99);
    this.txtTextToDraw.Multiline = true;
    this.txtTextToDraw.Name = "txtTextToDraw";
    this.txtTextToDraw.ScrollBars = ScrollBars.Both;
    this.txtTextToDraw.Size = new System.Drawing.Size(147, 71);
    this.txtTextToDraw.TabIndex = 1;
    this.txtTextToDraw.WordWrap = false;
    this.txtBoundToDraw.Location = new System.Drawing.Point(70, 22);
    this.txtBoundToDraw.Multiline = true;
    this.txtBoundToDraw.Name = "txtBoundToDraw";
    this.txtBoundToDraw.ScrollBars = ScrollBars.Vertical;
    this.txtBoundToDraw.Size = new System.Drawing.Size(147, 71);
    this.txtBoundToDraw.TabIndex = 1;
    this.txtBoundToDraw.WordWrap = false;
    this.txtFolderPathToSaveImage.Location = new System.Drawing.Point(103, 209);
    this.txtFolderPathToSaveImage.Name = "txtFolderPathToSaveImage";
    this.txtFolderPathToSaveImage.Size = new System.Drawing.Size(114, 23);
    this.txtFolderPathToSaveImage.TabIndex = 1;
    this.txtFolderPathToSaveImage.TextChanged += new EventHandler(this.txtFolderPathToCropImage_TextChanged);
    this.txtFolderPathToCropImage.Location = new System.Drawing.Point(103, 178);
    this.txtFolderPathToCropImage.Name = "txtFolderPathToCropImage";
    this.txtFolderPathToCropImage.Size = new System.Drawing.Size(114, 23);
    this.txtFolderPathToCropImage.TabIndex = 1;
    this.txtFolderPathToCropImage.TextChanged += new EventHandler(this.txtFolderPathToCropImage_TextChanged);
    this.button12.Cursor = Cursors.Hand;
    this.button12.Location = new System.Drawing.Point(223, 176);
    this.button12.Margin = new Padding(3, 4, 3, 4);
    this.button12.Name = "button12";
    this.button12.Size = new System.Drawing.Size(49, 26);
    this.button12.TabIndex = 0;
    this.button12.Text = "Crop";
    this.button12.UseVisualStyleBackColor = true;
    this.button12.Click += new EventHandler(this.button12_Click);
    this.button19.Cursor = Cursors.Hand;
    this.button19.Location = new System.Drawing.Point(223, 207);
    this.button19.Margin = new Padding(3, 4, 3, 4);
    this.button19.Name = "button19";
    this.button19.Size = new System.Drawing.Size(49, 26);
    this.button19.TabIndex = 0;
    this.button19.Text = "Save";
    this.button19.UseVisualStyleBackColor = true;
    this.button19.Click += new EventHandler(this.button19_Click);
    this.label16.AutoSize = true;
    this.label16.Location = new System.Drawing.Point(10, 99);
    this.label16.Name = "label16";
    this.label16.Size = new System.Drawing.Size(37, 16);
    this.label16.TabIndex = 3;
    this.label16.Text = "Text:";
    this.label12.AutoSize = true;
    this.label12.Location = new System.Drawing.Point(10, 212);
    this.label12.Name = "label12";
    this.label12.Size = new System.Drawing.Size(95, 16);
    this.label12.TabIndex = 3;
    this.label12.Text = "Folder lưu ảnh:";
    this.label12.Click += new EventHandler(this.label19_Click);
    this.label13.AutoSize = true;
    this.label13.Location = new System.Drawing.Point(10, 22);
    this.label13.Name = "label13";
    this.label13.Size = new System.Drawing.Size(53, 16);
    this.label13.TabIndex = 3;
    this.label13.Text = "Bounds:";
    this.button20.Cursor = Cursors.Hand;
    this.button20.Location = new System.Drawing.Point(223, 99);
    this.button20.Margin = new Padding(3, 4, 3, 4);
    this.button20.Name = "button20";
    this.button20.Size = new System.Drawing.Size(49, 26);
    this.button20.TabIndex = 0;
    this.button20.Text = "Draw";
    this.button20.UseVisualStyleBackColor = true;
    this.button20.Click += new EventHandler(this.button20_Click);
    this.label3.AutoSize = true;
    this.label3.Location = new System.Drawing.Point(10, 181);
    this.label3.Name = "label3";
    this.label3.Size = new System.Drawing.Size(95, 16);
    this.label3.TabIndex = 3;
    this.label3.Text = "Folder lưu ảnh:";
    this.label3.Click += new EventHandler(this.label19_Click);
    this.button22.Cursor = Cursors.Hand;
    this.button22.Location = new System.Drawing.Point(223, 130);
    this.button22.Margin = new Padding(3, 4, 3, 4);
    this.button22.Name = "button22";
    this.button22.Size = new System.Drawing.Size(49, 26);
    this.button22.TabIndex = 0;
    this.button22.Text = "Clear";
    this.button22.UseVisualStyleBackColor = true;
    this.button22.Click += new EventHandler(this.button22_Click);
    this.button21.Cursor = Cursors.Hand;
    this.button21.Location = new System.Drawing.Point(223, 53);
    this.button21.Margin = new Padding(3, 4, 3, 4);
    this.button21.Name = "button21";
    this.button21.Size = new System.Drawing.Size(49, 26);
    this.button21.TabIndex = 0;
    this.button21.Text = "Clear";
    this.button21.UseVisualStyleBackColor = true;
    this.button21.Click += new EventHandler(this.button21_Click);
    this.button1.Cursor = Cursors.Hand;
    this.button1.Location = new System.Drawing.Point(223, 22);
    this.button1.Margin = new Padding(3, 4, 3, 4);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(49, 26);
    this.button1.TabIndex = 0;
    this.button1.Text = "Draw";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.txtMouseX.Location = new System.Drawing.Point(6, 597);
    this.txtMouseX.Name = "txtMouseX";
    this.txtMouseX.ReadOnly = true;
    this.txtMouseX.Size = new System.Drawing.Size(64, 23);
    this.txtMouseX.TabIndex = 4;
    this.txtMouseX.Text = "0";
    this.txtMouseX.TextAlign = HorizontalAlignment.Center;
    this.groupBox3.Controls.Add((Control) this.label2);
    this.groupBox3.Controls.Add((Control) this.button14);
    this.groupBox3.Controls.Add((Control) this.txtResultCmd);
    this.groupBox3.Controls.Add((Control) this.txtCommand);
    this.groupBox3.Location = new System.Drawing.Point(332, 334);
    this.groupBox3.Name = "groupBox3";
    this.groupBox3.Size = new System.Drawing.Size(278, 193);
    this.groupBox3.TabIndex = 9;
    this.groupBox3.TabStop = false;
    this.groupBox3.Text = "Run CMD";
    this.label2.AutoSize = true;
    this.label2.Location = new System.Drawing.Point(6, 19);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(70, 16);
    this.label2.TabIndex = 3;
    this.label2.Text = "Command:";
    this.button14.Cursor = Cursors.Hand;
    this.button14.Location = new System.Drawing.Point(223, 16);
    this.button14.Name = "button14";
    this.button14.Size = new System.Drawing.Size(50, 25);
    this.button14.TabIndex = 2;
    this.button14.Text = "Run";
    this.button14.UseVisualStyleBackColor = true;
    this.button14.Click += new EventHandler(this.button14_Click);
    this.txtResultCmd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtResultCmd.Location = new System.Drawing.Point(9, 46);
    this.txtResultCmd.Multiline = true;
    this.txtResultCmd.Name = "txtResultCmd";
    this.txtResultCmd.ScrollBars = ScrollBars.Both;
    this.txtResultCmd.Size = new System.Drawing.Size(263, 141);
    this.txtResultCmd.TabIndex = 1;
    this.txtResultCmd.WordWrap = false;
    this.txtCommand.Location = new System.Drawing.Point(83, 17);
    this.txtCommand.Name = "txtCommand";
    this.txtCommand.Size = new System.Drawing.Size(134, 23);
    this.txtCommand.TabIndex = 1;
    this.button23.Cursor = Cursors.Hand;
    this.button23.Location = new System.Drawing.Point(555, 20);
    this.button23.Margin = new Padding(3, 4, 3, 4);
    this.button23.Name = "button23";
    this.button23.Size = new System.Drawing.Size(55, 26);
    this.button23.TabIndex = 0;
    this.button23.Text = "Open";
    this.button23.UseVisualStyleBackColor = true;
    this.button23.Click += new EventHandler(this.button23_Click);
    this.button18.Cursor = Cursors.Hand;
    this.button18.Location = new System.Drawing.Point(445, 54);
    this.button18.Margin = new Padding(3, 4, 3, 4);
    this.button18.Name = "button18";
    this.button18.Size = new System.Drawing.Size(165, 26);
    this.button18.TabIndex = 0;
    this.button18.Text = "Screen Shot + Open Paint";
    this.button18.UseVisualStyleBackColor = true;
    this.button18.Click += new EventHandler(this.button18_Click);
    this.txtFile.Location = new System.Drawing.Point(332, 22);
    this.txtFile.Name = "txtFile";
    this.txtFile.Size = new System.Drawing.Size(217, 23);
    this.txtFile.TabIndex = 1;
    this.button10.Cursor = Cursors.Hand;
    this.button10.Location = new System.Drawing.Point(246, 596);
    this.button10.Name = "button10";
    this.button10.Size = new System.Drawing.Size(80, 24);
    this.button10.TabIndex = 12;
    this.button10.Text = "Save + Edit";
    this.button10.UseVisualStyleBackColor = true;
    this.button10.Click += new EventHandler(this.button10_Click);
    this.button30.Cursor = Cursors.Hand;
    this.button30.Location = new System.Drawing.Point(197, 596);
    this.button30.Name = "button30";
    this.button30.Size = new System.Drawing.Size(43, 24);
    this.button30.TabIndex = 12;
    this.button30.Text = "Save";
    this.button30.UseVisualStyleBackColor = true;
    this.button30.Click += new EventHandler(this.button30_Click);
    this.txtMouseY.Location = new System.Drawing.Point(76, 597);
    this.txtMouseY.Name = "txtMouseY";
    this.txtMouseY.ReadOnly = true;
    this.txtMouseY.Size = new System.Drawing.Size(64, 23);
    this.txtMouseY.TabIndex = 4;
    this.txtMouseY.Text = "0";
    this.txtMouseY.TextAlign = HorizontalAlignment.Center;
    this.button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button8.Cursor = Cursors.Hand;
    this.button8.Location = new System.Drawing.Point(773, 743);
    this.button8.Name = "button8";
    this.button8.Size = new System.Drawing.Size(84, 25);
    this.button8.TabIndex = 2;
    this.button8.Text = "InputText";
    this.button8.UseVisualStyleBackColor = true;
    this.button8.Click += new EventHandler(this.button8_Click);
    this.txtContent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.txtContent.Location = new System.Drawing.Point(557, 744);
    this.txtContent.Name = "txtContent";
    this.txtContent.Size = new System.Drawing.Size(210, 23);
    this.txtContent.TabIndex = 1;
    this.label1.AutoSize = true;
    this.label1.Location = new System.Drawing.Point(12, 9);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(65, 16);
    this.label1.TabIndex = 3;
    this.label1.Text = "Device ID:";
    this.groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.groupBox8.Controls.Add((Control) this.button13);
    this.groupBox8.Controls.Add((Control) this.treeView1);
    this.groupBox8.Controls.Add((Control) this.dtgvAttribute);
    this.groupBox8.Controls.Add((Control) this.txtSearchXpath);
    this.groupBox8.Controls.Add((Control) this.txtXPath);
    this.groupBox8.Controls.Add((Control) this.label6);
    this.groupBox8.Controls.Add((Control) this.label17);
    this.groupBox8.Controls.Add((Control) this.label19);
    this.groupBox8.Controls.Add((Control) this.button6);
    this.groupBox8.Controls.Add((Control) this.button8);
    this.groupBox8.Controls.Add((Control) this.txtValue);
    this.groupBox8.Controls.Add((Control) this.label18);
    this.groupBox8.Controls.Add((Control) this.txtContent);
    this.groupBox8.Controls.Add((Control) this.txtAttribute);
    this.groupBox8.Controls.Add((Control) this.button4);
    this.groupBox8.Controls.Add((Control) this.button3);
    this.groupBox8.Location = new System.Drawing.Point(353, 4);
    this.groupBox8.Name = "groupBox8";
    this.groupBox8.Size = new System.Drawing.Size(863, 774);
    this.groupBox8.TabIndex = 11;
    this.groupBox8.TabStop = false;
    this.button13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button13.Cursor = Cursors.Hand;
    this.button13.Location = new System.Drawing.Point(504, 743);
    this.button13.Name = "button13";
    this.button13.Size = new System.Drawing.Size(43, 24);
    this.button13.TabIndex = 12;
    this.button13.Text = "Copy";
    this.button13.UseVisualStyleBackColor = true;
    this.button13.Click += new EventHandler(this.button13_Click);
    this.treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.treeView1.Location = new System.Drawing.Point(7, 21);
    this.treeView1.Name = "treeView1";
    this.treeView1.ShowNodeToolTips = true;
    this.treeView1.Size = new System.Drawing.Size(541, 747);
    this.treeView1.TabIndex = 9;
    this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
    this.dtgvAttribute.AllowUserToAddRows = false;
    this.dtgvAttribute.AllowUserToDeleteRows = false;
    this.dtgvAttribute.AllowUserToResizeRows = false;
    this.dtgvAttribute.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    this.dtgvAttribute.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle.BackColor = SystemColors.Control;
    gridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle.ForeColor = SystemColors.WindowText;
    gridViewCellStyle.SelectionBackColor = Color.Teal;
    gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle.WrapMode = DataGridViewTriState.True;
    this.dtgvAttribute.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.dtgvAttribute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgvAttribute.Columns.AddRange((DataGridViewColumn) this.cAttribute, (DataGridViewColumn) this.cValue);
    this.dtgvAttribute.Location = new System.Drawing.Point(557, 51);
    this.dtgvAttribute.MultiSelect = false;
    this.dtgvAttribute.Name = "dtgvAttribute";
    this.dtgvAttribute.ReadOnly = true;
    this.dtgvAttribute.RowHeadersVisible = false;
    this.dtgvAttribute.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvAttribute.Size = new System.Drawing.Size(300, 564);
    this.dtgvAttribute.TabIndex = 8;
    this.dtgvAttribute.CellClick += new DataGridViewCellEventHandler(this.dtgvAttribute_CellClick);
    this.cAttribute.HeaderText = "Attribute";
    this.cAttribute.Name = "cAttribute";
    this.cAttribute.ReadOnly = true;
    this.cValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cValue.HeaderText = "Value";
    this.cValue.Name = "cValue";
    this.cValue.ReadOnly = true;
    this.txtSearchXpath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.txtSearchXpath.Location = new System.Drawing.Point(599, 22);
    this.txtSearchXpath.Name = "txtSearchXpath";
    this.txtSearchXpath.Size = new System.Drawing.Size(194, 23);
    this.txtSearchXpath.TabIndex = 1;
    this.txtXPath.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.txtXPath.Location = new System.Drawing.Point(616, 679);
    this.txtXPath.Name = "txtXPath";
    this.txtXPath.Size = new System.Drawing.Size(241, 23);
    this.txtXPath.TabIndex = 1;
    this.label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label6.AutoSize = true;
    this.label6.Location = new System.Drawing.Point(554, 25);
    this.label6.Name = "label6";
    this.label6.Size = new System.Drawing.Size(45, 16);
    this.label6.TabIndex = 3;
    this.label6.Text = "XPath:";
    this.label6.Click += new EventHandler(this.label19_Click);
    this.label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label17.AutoSize = true;
    this.label17.Location = new System.Drawing.Point(554, 653);
    this.label17.Name = "label17";
    this.label17.Size = new System.Drawing.Size(44, 16);
    this.label17.TabIndex = 3;
    this.label17.Text = "Value:";
    this.label17.Click += new EventHandler(this.label19_Click);
    this.label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label19.AutoSize = true;
    this.label19.Location = new System.Drawing.Point(554, 682);
    this.label19.Name = "label19";
    this.label19.Size = new System.Drawing.Size(45, 16);
    this.label19.TabIndex = 3;
    this.label19.Text = "XPath:";
    this.label19.Click += new EventHandler(this.label19_Click);
    this.button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button6.Cursor = Cursors.Hand;
    this.button6.Location = new System.Drawing.Point(799, 21);
    this.button6.Name = "button6";
    this.button6.Size = new System.Drawing.Size(58, 25);
    this.button6.TabIndex = 2;
    this.button6.Text = "Search";
    this.button6.UseVisualStyleBackColor = true;
    this.button6.Click += new EventHandler(this.button6_Click);
    this.txtValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.txtValue.Location = new System.Drawing.Point(616, 650);
    this.txtValue.Name = "txtValue";
    this.txtValue.Size = new System.Drawing.Size(241, 23);
    this.txtValue.TabIndex = 1;
    this.label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.label18.AutoSize = true;
    this.label18.Location = new System.Drawing.Point(554, 624);
    this.label18.Name = "label18";
    this.label18.Size = new System.Drawing.Size(61, 16);
    this.label18.TabIndex = 3;
    this.label18.Text = "Attribute:";
    this.txtAttribute.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.txtAttribute.Location = new System.Drawing.Point(616, 621);
    this.txtAttribute.Name = "txtAttribute";
    this.txtAttribute.Size = new System.Drawing.Size(241, 23);
    this.txtAttribute.TabIndex = 1;
    this.button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button4.Cursor = Cursors.Hand;
    this.button4.Location = new System.Drawing.Point(713, 708);
    this.button4.Name = "button4";
    this.button4.Size = new System.Drawing.Size(144, 30);
    this.button4.TabIndex = 2;
    this.button4.Text = "Tap By Element";
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.button3.Cursor = Cursors.Hand;
    this.button3.Location = new System.Drawing.Point(557, 708);
    this.button3.Name = "button3";
    this.button3.Size = new System.Drawing.Size(150, 30);
    this.button3.TabIndex = 2;
    this.button3.Text = "Tap By Bound";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button25.Cursor = Cursors.Hand;
    this.button25.Location = new System.Drawing.Point(285, 5);
    this.button25.Name = "button25";
    this.button25.Size = new System.Drawing.Size(62, 24);
    this.button25.TabIndex = 12;
    this.button25.Text = "Check";
    this.button25.UseVisualStyleBackColor = true;
    this.button25.Click += new EventHandler(this.button25_Click);
    this.cbbDevice.Cursor = Cursors.Hand;
    this.cbbDevice.DropDownWidth = 300;
    this.cbbDevice.FormattingEnabled = true;
    this.cbbDevice.Location = new System.Drawing.Point(76, 5);
    this.cbbDevice.Name = "cbbDevice";
    this.cbbDevice.Size = new System.Drawing.Size(175, 24);
    this.cbbDevice.TabIndex = 13;
    this.pictureBox2.Cursor = Cursors.Hand;
    this.pictureBox2.Image = (Image) Resource.Bitmap_225;
    this.pictureBox2.Location = new System.Drawing.Point(254, 5);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new System.Drawing.Size(25, 25);
    this.pictureBox2.TabIndex = 11;
    this.pictureBox2.TabStop = false;
    this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
    this.label4.AutoSize = true;
    this.label4.Location = new System.Drawing.Point(12, 66);
    this.label4.Name = "label4";
    this.label4.Size = new System.Drawing.Size(34, 16);
    this.label4.TabIndex = 3;
    this.label4.Text = "Xml:";
    this.label5.AutoSize = true;
    this.label5.Location = new System.Drawing.Point(12, 39);
    this.label5.Name = "label5";
    this.label5.Size = new System.Drawing.Size(48, 16);
    this.label5.TabIndex = 3;
    this.label5.Text = "Image:";
    this.txtPathImage.AllowDrop = true;
    this.txtPathImage.Location = new System.Drawing.Point(76, 36);
    this.txtPathImage.Name = "txtPathImage";
    this.txtPathImage.Size = new System.Drawing.Size(175, 23);
    this.txtPathImage.TabIndex = 14;
    this.txtPathXml.Location = new System.Drawing.Point(76, 63);
    this.txtPathXml.Name = "txtPathXml";
    this.txtPathXml.Size = new System.Drawing.Size(175, 23);
    this.txtPathXml.TabIndex = 14;
    this.button5.Cursor = Cursors.Hand;
    this.button5.Location = new System.Drawing.Point(285, 35);
    this.button5.Name = "button5";
    this.button5.Size = new System.Drawing.Size(62, 51);
    this.button5.TabIndex = 12;
    this.button5.Text = "Check";
    this.button5.UseVisualStyleBackColor = true;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.button7.Cursor = Cursors.Hand;
    this.button7.Location = new System.Drawing.Point(253, 35);
    this.button7.Name = "button7";
    this.button7.Size = new System.Drawing.Size(28, 25);
    this.button7.TabIndex = 12;
    this.button7.Text = "...";
    this.button7.UseVisualStyleBackColor = true;
    this.button7.Click += new EventHandler(this.button7_Click);
    this.button9.Cursor = Cursors.Hand;
    this.button9.Location = new System.Drawing.Point(253, 62);
    this.button9.Name = "button9";
    this.button9.Size = new System.Drawing.Size(28, 25);
    this.button9.TabIndex = 12;
    this.button9.Text = "...";
    this.button9.UseVisualStyleBackColor = true;
    this.button9.Click += new EventHandler(this.button9_Click);
    this.label7.AutoSize = true;
    this.label7.Location = new System.Drawing.Point(12, 95);
    this.label7.Name = "label7";
    this.label7.Size = new System.Drawing.Size(52, 16);
    this.label7.TabIndex = 3;
    this.label7.Text = "Activity:";
    this.txtActivity.Location = new System.Drawing.Point(76, 92);
    this.txtActivity.Name = "txtActivity";
    this.txtActivity.Size = new System.Drawing.Size(175, 23);
    this.txtActivity.TabIndex = 14;
    this.button29.Cursor = Cursors.Hand;
    this.button29.Location = new System.Drawing.Point(253, 91);
    this.button29.Name = "button29";
    this.button29.Size = new System.Drawing.Size(94, 25);
    this.button29.TabIndex = 12;
    this.button29.Text = "Open";
    this.button29.UseVisualStyleBackColor = true;
    this.button29.Click += new EventHandler(this.button29_Click);
    this.AllowDrop = true;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(1225, 783);
    this.Controls.Add((Control) this.txtActivity);
    this.Controls.Add((Control) this.txtPathXml);
    this.Controls.Add((Control) this.txtPathImage);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.pictureBox2);
    this.Controls.Add((Control) this.cbbDevice);
    this.Controls.Add((Control) this.button5);
    this.Controls.Add((Control) this.button9);
    this.Controls.Add((Control) this.button29);
    this.Controls.Add((Control) this.button7);
    this.Controls.Add((Control) this.button25);
    this.Controls.Add((Control) this.groupBox8);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.groupBox2);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fCheckAppium);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "ToolCheckAppium";
    this.Load += new EventHandler(this.fCheckAppium_Load);
    this.groupBox2.ResumeLayout(false);
    this.groupBox2.PerformLayout();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.groupBox7.ResumeLayout(false);
    this.groupBox7.PerformLayout();
    this.groupBox3.ResumeLayout(false);
    this.groupBox3.PerformLayout();
    this.groupBox8.ResumeLayout(false);
    this.groupBox8.PerformLayout();
    ((ISupportInitialize) this.dtgvAttribute).EndInit();
    ((ISupportInitialize) this.pictureBox2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
