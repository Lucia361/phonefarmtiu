// Decompiled with JetBrains decompiler
// Type: GClass14
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System.Windows.Forms;

public class GClass14
{
  public static void smethod_0(object object_0, int int_0 = 1)
  {
    MessageBoxIcon icon = MessageBoxIcon.None;
    switch (int_0)
    {
      case 1:
        icon = MessageBoxIcon.Asterisk;
        break;
      case 2:
        icon = MessageBoxIcon.Hand;
        break;
      case 3:
        icon = MessageBoxIcon.Exclamation;
        break;
      case 4:
        icon = MessageBoxIcon.Exclamation;
        break;
    }
    int num = (int) MessageBox.Show(GClass35.smethod_0(object_0.ToString()), "MaxFarm", MessageBoxButtons.OK, icon);
  }

  public static DialogResult smethod_1(string string_0) => MessageBox.Show(GClass35.smethod_0(string_0), "MaxFarm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
}
