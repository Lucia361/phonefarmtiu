// Decompiled with JetBrains decompiler
// Type: GInterface2
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[TypeIdentifier]
[CompilerGenerated]
[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
[ComImport]
public interface GInterface2 : GInterface1, GInterface0
{
  [SpecialName]
  void _VtblGap1_4();

  [DispId(1002)]
  [MethodImpl(MethodImplOptions.InternalCall)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object imethod_0([MarshalAs(UnmanagedType.BStr), In] string string_0);
}
