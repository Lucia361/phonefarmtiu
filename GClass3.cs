// Decompiled with JetBrains decompiler
// Type: GClass3
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class GClass3 : GClass2
{
  public string method_9(string string_0, string string_1)
  {
    try
    {
      GStruct0 gstruct0_0 = this.method_11(string_0);
      if (!this.method_12(gstruct0_0, string_1))
        return "";
      byte[] byte_1 = this.method_3(gstruct0_0.byte_2, string_1);
      byte[] bytes = new byte[0];
      switch (this.genum1_0)
      {
        case GEnum1.const_0:
          bytes = this.method_4(gstruct0_0.byte_6, byte_1, gstruct0_0.byte_4);
          break;
        case GEnum1.const_1:
          bytes = this.method_10(gstruct0_0.byte_6, byte_1, gstruct0_0.byte_4);
          break;
      }
      return Encoding.UTF8.GetString(bytes);
    }
    catch
    {
      return "null";
    }
  }

  private byte[] method_10(byte[] byte_0, byte[] byte_1, byte[] byte_2)
  {
    Aes aes = Aes.Create();
    aes.Mode = CipherMode.CBC;
    aes.Padding = PaddingMode.PKCS7;
    ICryptoTransform decryptor = aes.CreateDecryptor(byte_1, byte_2);
    string end;
    using (MemoryStream memoryStream = new MemoryStream(byte_0))
    {
      using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
      {
        using (StreamReader streamReader = new StreamReader((Stream) cryptoStream))
          end = streamReader.ReadToEnd();
      }
    }
    return this.Encoding_0.GetBytes(end);
  }

  private GStruct0 method_11(string string_0)
  {
    List<byte> byteList = new List<byte>();
    byteList.AddRange((IEnumerable<byte>) Convert.FromBase64String(string_0));
    int num = 0;
    GStruct0 gstruct0 = new GStruct0();
    gstruct0.byte_0 = byteList.GetRange(0, 1).ToArray();
    num = 1;
    this.method_0((GEnum0) byteList[0]);
    gstruct0.byte_1 = byteList.GetRange(1, 1).ToArray();
    num = 2;
    gstruct0.byte_2 = byteList.GetRange(2, 8).ToArray();
    int index1 = 2 + gstruct0.byte_2.Length;
    gstruct0.byte_3 = byteList.GetRange(index1, 8).ToArray();
    int index2 = index1 + gstruct0.byte_3.Length;
    gstruct0.byte_4 = byteList.GetRange(index2, 16).ToArray();
    int index3 = gstruct0.int_0 = index2 + gstruct0.byte_4.Length;
    gstruct0.byte_6 = byteList.GetRange(index3, byteList.Count - 32 - gstruct0.int_0).ToArray();
    int index4 = index3 + gstruct0.byte_6.Length;
    gstruct0.byte_5 = byteList.GetRange(index4, 32).ToArray();
    return gstruct0;
  }

  private bool method_12(GStruct0 gstruct0_0, string string_0)
  {
    byte[] numArray = this.method_1(gstruct0_0, string_0);
    if (numArray.Length != gstruct0_0.byte_5.Length)
      return false;
    int index = 0;
    while (true)
    {
      if (index < gstruct0_0.byte_5.Length)
      {
        if ((int) numArray[index] == (int) gstruct0_0.byte_5[index])
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
}
