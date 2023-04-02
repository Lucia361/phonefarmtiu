// Decompiled with JetBrains decompiler
// Type: GClass2
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public abstract class GClass2
{
  protected GEnum1 genum1_0;
  protected GEnum5 genum5_0;
  protected bool bool_0;
  protected bool bool_1;
  protected GEnum3 genum3_0;
  protected const GEnum4 genum4_0 = GEnum4.const_0;
  protected const short short_0 = 8;
  protected const short short_1 = 16;
  protected const GEnum2 genum2_0 = GEnum2.const_0;
  protected const int int_0 = 10000;
  protected const short short_2 = 32;
  protected const short short_3 = 32;

  public Encoding Encoding_0 { get; set; }

  public GClass2() => this.Encoding_0 = Encoding.UTF8;

  protected void method_0(GEnum0 genum0_0)
  {
    switch (genum0_0)
    {
      case GEnum0.const_0:
        this.genum1_0 = GEnum1.const_0;
        this.genum5_0 = GEnum5.const_0;
        this.bool_0 = false;
        this.bool_1 = true;
        this.genum3_0 = GEnum3.const_0;
        break;
      case GEnum0.const_1:
        this.genum1_0 = GEnum1.const_1;
        this.genum5_0 = GEnum5.const_1;
        this.bool_0 = false;
        this.bool_1 = false;
        this.genum3_0 = GEnum3.const_1;
        break;
      case GEnum0.const_2:
      case GEnum0.const_3:
        this.genum1_0 = GEnum1.const_1;
        this.genum5_0 = GEnum5.const_1;
        this.bool_0 = true;
        this.bool_1 = false;
        this.genum3_0 = GEnum3.const_1;
        break;
    }
  }

  protected byte[] method_1(GStruct0 gstruct0_0, string string_0)
  {
    List<byte> byteList1 = new List<byte>();
    if (this.bool_0)
      byteList1.AddRange((IEnumerable<byte>) this.method_2(gstruct0_0));
    byteList1.AddRange((IEnumerable<byte>) gstruct0_0.byte_6);
    byte[] key = this.method_3(gstruct0_0.byte_3, string_0);
    HMAC hmac = (HMAC) null;
    switch (this.genum3_0)
    {
      case GEnum3.const_0:
        hmac = (HMAC) new HMACSHA1(key);
        break;
      case GEnum3.const_1:
        hmac = (HMAC) new HMACSHA256(key);
        break;
    }
    List<byte> byteList2 = new List<byte>();
    byteList2.AddRange((IEnumerable<byte>) hmac.ComputeHash(byteList1.ToArray()));
    if (this.bool_1)
    {
      for (int count = byteList2.Count; count < 32; ++count)
        byteList2.Add((byte) 0);
    }
    return byteList2.ToArray();
  }

  protected byte[] method_2(GStruct0 gstruct0_0)
  {
    List<byte> byteList = new List<byte>();
    byteList.AddRange((IEnumerable<byte>) gstruct0_0.byte_0);
    byteList.AddRange((IEnumerable<byte>) gstruct0_0.byte_1);
    byteList.AddRange((IEnumerable<byte>) gstruct0_0.byte_2);
    byteList.AddRange((IEnumerable<byte>) gstruct0_0.byte_3);
    byteList.AddRange((IEnumerable<byte>) gstruct0_0.byte_4);
    return byteList.ToArray();
  }

  protected byte[] method_3(byte[] byte_0, string string_0) => new Rfc2898DeriveBytes(string_0, byte_0, 10000).GetBytes(32);

  protected byte[] method_4(byte[] byte_0, byte[] byte_1, byte[] byte_2)
  {
    byte[] byte_1_1 = this.method_6(this.method_5(byte_0.Length, byte_2), byte_1);
    return this.method_7(byte_0, byte_1_1);
  }

  private byte[] method_5(int int_1, byte[] byte_0)
  {
    byte[] collection = new byte[byte_0.Length];
    byte_0.CopyTo((Array) collection, 0);
    int num = (int) Math.Ceiling((Decimal) int_1 / (Decimal) byte_0.Length);
    List<byte> byteList = new List<byte>();
    for (int index = 0; index < num; ++index)
    {
      byteList.AddRange((IEnumerable<byte>) collection);
      ++collection[0];
    }
    return byteList.ToArray();
  }

  private byte[] method_6(byte[] byte_0, byte[] byte_1)
  {
    Aes aes = Aes.Create();
    aes.Mode = CipherMode.ECB;
    aes.Padding = PaddingMode.None;
    ICryptoTransform encryptor = aes.CreateEncryptor(byte_1, (byte[]) null);
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
        cryptoStream.Write(byte_0, 0, byte_0.Length);
      return memoryStream.ToArray();
    }
  }

  private byte[] method_7(byte[] byte_0, byte[] byte_1)
  {
    byte[] numArray = new byte[byte_0.Length];
    ulong length1 = (ulong) byte_1.Length;
    ulong length2 = (ulong) byte_0.Length;
    ulong index1 = 0;
    for (ulong index2 = 0; index2 < length2; ++index2)
    {
      numArray[index2] = (byte) ((uint) byte_0[index2] ^ (uint) byte_1[index1]);
      ulong num;
      index1 = (num = index1 + 1UL) < length1 ? num : 0UL;
    }
    return numArray;
  }

  protected string method_8(byte[] byte_0)
  {
    string str = "";
    foreach (byte num in byte_0)
      str += string.Format("{0:x2}", (object) num);
    return str;
  }
}
