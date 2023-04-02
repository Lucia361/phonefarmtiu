// Decompiled with JetBrains decompiler
// Type: GClass4
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class GClass4 : GClass2
{
  private GEnum0 genum0_0 = GEnum0.const_2;

  public string method_9(string string_0, string string_1)
  {
    try
    {
      return GClass4.smethod_0(this.method_10(string_0, string_1, this.genum0_0));
    }
    catch
    {
      return "null";
    }
  }

  public static string smethod_0(string string_0) => Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));

  public string method_10(string string_0, string string_1, GEnum0 genum0_1)
  {
    this.method_0(genum0_1);
    byte[] bytes = this.Encoding_0.GetBytes(string_0);
    GStruct0 gstruct0_0 = new GStruct0();
    gstruct0_0.byte_0 = new byte[1]{ (byte) genum0_1 };
    gstruct0_0.byte_1 = new byte[1]{ (byte) this.genum5_0 };
    gstruct0_0.byte_2 = this.method_12(8);
    gstruct0_0.byte_3 = this.method_12(8);
    gstruct0_0.byte_4 = this.method_12(16);
    byte[] byte_1 = this.method_3(gstruct0_0.byte_2, string_1);
    switch (this.genum1_0)
    {
      case GEnum1.const_0:
        gstruct0_0.byte_6 = this.method_4(bytes, byte_1, gstruct0_0.byte_4);
        break;
      case GEnum1.const_1:
        gstruct0_0.byte_6 = this.method_11(bytes, byte_1, gstruct0_0.byte_4);
        break;
    }
    gstruct0_0.byte_5 = this.method_1(gstruct0_0, string_1);
    List<byte> byteList = new List<byte>();
    byteList.AddRange((IEnumerable<byte>) this.method_2(gstruct0_0));
    byteList.AddRange((IEnumerable<byte>) gstruct0_0.byte_6);
    byteList.AddRange((IEnumerable<byte>) gstruct0_0.byte_5);
    return Convert.ToBase64String(byteList.ToArray());
  }

  private byte[] method_11(byte[] byte_0, byte[] byte_1, byte[] byte_2)
  {
    Aes aes = Aes.Create();
    aes.Mode = CipherMode.CBC;
    aes.Padding = PaddingMode.PKCS7;
    ICryptoTransform encryptor = aes.CreateEncryptor(byte_1, byte_2);
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
        cryptoStream.Write(byte_0, 0, byte_0.Length);
      return memoryStream.ToArray();
    }
  }

  private byte[] method_12(int int_1)
  {
    byte[] data = new byte[int_1];
    new RNGCryptoServiceProvider().GetBytes(data);
    return data;
  }
}
