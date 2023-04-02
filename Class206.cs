// Decompiled with JetBrains decompiler
// Type: Class206
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class Class206
{
  internal static uint smethod_0(string s)
  {
    uint num = 0;
    if (s != null)
    {
      num = 2166136261U;
      for (int index = 0; index < s.Length; ++index)
        num = (uint) (((int) s[index] ^ (int) num) * 16777619);
    }
    return num;
  }
}
