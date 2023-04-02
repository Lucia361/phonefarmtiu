// Decompiled with JetBrains decompiler
// Type: GInterface3
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[TypeIdentifier]
[CompilerGenerated]
[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
[DefaultMember("FullName")]
[ComImport]
public interface GInterface3
{
  [DispId(0)]
  string String_0 { [DispId(0), MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1000)]
  string String_1 { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1000), MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1001)]
  string String_2 { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1001), MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1003)]
  string String_3 { [DispId(1003), MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1003), MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1005)]
  string String_4 { [DispId(1005), MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1005), MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1007)]
  string String_5 { [DispId(1007), MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1007), MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [SpecialName]
  void _VtblGap1_2();

  [SpecialName]
  void _VtblGap2_1();

  [SpecialName]
  void _VtblGap3_2();

  [SpecialName]
  void _VtblGap4_1();

  [DispId(2001)]
  [MethodImpl(MethodImplOptions.InternalCall)]
  void imethod_0();
}
