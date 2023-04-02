// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using xNet;

internal static class Program
{
  private static string publicKey = "-----BEGIN PUBLIC KEY-----\r\n\t\t\t\t\t\tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAwBFbFetbRguRNSjvJCEI\r\n\t\t\t\t\t\tm81O7/0i8Pd0GHB3Jv4cudEuFR61uTh15i1L7oponqS42GsAkPdgydebsD/G/hHI\r\n\t\t\t\t\t\tFo5PHVmZkc0sRr/rYtEH4y3cJjfP6EtUqYRZwQJtUhoBf4zAo8HaBWbXD7+H8XXq\r\n\t\t\t\t\t\tm3bZh3FNTFa5i2l5ds31dc7qsPyN3w3SKIOFXbGY+fHFo2j4vXCCY+E6G088katU\r\n\t\t\t\t\t\tB6urVxXSbuWvu00Vj+XyNEUGN9f9VqG/0lmoabKJIYb+T3Obn+3Q/3nduR2WEkt1\r\n\t\t\t\t\t\tPsMHnqvaqoinIE/bc3ncnsFwPHIwptLJlQGpxa0oPT/ShZo0oBrEmJ3pJhrKtwsr\r\n\t\t\t\t\t\tbwIDAQAB\r\n\t\t\t\t\t\t-----END PUBLIC KEY-----";
  private static readonly Random _random = new Random();

  [STAThread]
  private static void Main()
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    try
    {
      if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
      {
        int num = (int) MessageBox.Show("Vui lòng chạy bằng quyền Admin!\r\nPlease Run Aplication As Administrator!");
        Environment.Exit(0);
      }
      string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
      if (File.Exists(path))
      {
        try
        {
          List<string> stringList = new List<string>()
          {
            "longphamphonefarm"
          };
          using (StreamReader streamReader = new StreamReader(path))
          {
            string empty = string.Empty;
            string str1;
            while ((str1 = streamReader.ReadLine()) != null)
            {
              foreach (string str2 in stringList)
              {
                if (str1.ToLower().Contains(str2))
                {
                  int num = (int) MessageBox.Show("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!");
                  Environment.Exit(0);
                }
              }
            }
          }
        }
        catch
        {
          int num = (int) MessageBox.Show("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!");
          Environment.Exit(0);
        }
      }
      string diskDserialNumber = Program.GetHardDiskDSerialNumber("C");
      string biosInformation = Program.GetBiosInformation();
      if (diskDserialNumber == null && biosInformation == null)
      {
        int num = (int) MessageBox.Show("Không thể lấy được thông tin để kích hoạt phần mềm. Vui lòng kiểm tra lại hoặc liên hệ Admin!");
        Environment.Exit(0);
      }
      string str3 = Program.RandomString(32);
      string str4 = Program.RandomString(16);
      string str5 = Program.EncryptAes(diskDserialNumber + biosInformation, str3, str4);
      string s = JsonConvert.SerializeObject((object) new JsonClass()
      {
        keyAes = Program.EncryptionRsa(str3),
        ivAes = Program.EncryptionRsa(str4),
        data = str5
      }, Formatting.Indented);
      HttpRequest httpRequest = new HttpRequest();
      httpRequest.KeepAlive = true;
      httpRequest.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
      string base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes(s));
      httpRequest.AddParam("data", (object) base64String);
      string str6 = Program.DecryptAes(httpRequest.Post("https://apimaxfarm.longphamphonefarm.com/api.php").ToString(), str3, str4);
      if (!str6.Contains("checked"))
      {
        int num = (int) MessageBox.Show("Có lỗi xảy ra, vui lòng liên hệ Admin để được hỗ trợ!");
        Environment.Exit(0);
      }
      JsonDataClass jsonDataClass = JsonConvert.DeserializeObject<JsonDataClass>(str6);
      if (!jsonDataClass.Checked)
      {
        int num = (int) MessageBox.Show(jsonDataClass.status);
        Environment.Exit(0);
      }
      Application.Run((Form) new fIntro());
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show("Có lỗi xảy ra, vui lòng liên hệ Admin để được hỗ trợ!");
      Environment.Exit(0);
    }
  }

  private static string GetBiosInformation()
  {
    string biosInformation = "";
    try
    {
      foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS").Get())
        biosInformation = (string) managementBaseObject["SerialNumber"];
      return biosInformation;
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.ToString());
      return (string) null;
    }
  }

  public static string GetHardDiskDSerialNumber(string drive)
  {
    if (string.IsNullOrEmpty(drive) || drive == null)
      drive = "C";
    ManagementObject managementObject = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
    managementObject.Get();
    return managementObject["VolumeSerialNumber"].ToString();
  }

  public static RSACryptoServiceProvider ImportPublicKey(RSACryptoServiceProvider csp, string pem)
  {
    RSAParameters rsaParameters = DotNetUtilities.ToRSAParameters((RsaKeyParameters) new PemReader((TextReader) new StringReader(pem)).ReadObject());
    csp.ImportParameters(rsaParameters);
    return csp;
  }

  public static string EncryptionRsa(string plaintext)
  {
    try
    {
      RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
      byte[] bytes = Encoding.ASCII.GetBytes(plaintext);
      return Convert.ToBase64String(Program.ImportPublicKey(csp, Program.publicKey).Encrypt(bytes, true));
    }
    catch (CryptographicException ex)
    {
      Console.WriteLine(ex.Message);
      return (string) null;
    }
  }

  private static string EncryptAes(string plainText, string Key, string IV)
  {
    try
    {
      byte[] bytes1 = Encoding.ASCII.GetBytes(Key);
      byte[] bytes2 = Encoding.ASCII.GetBytes(IV);
      byte[] array;
      using (AesManaged aesManaged = new AesManaged())
      {
        aesManaged.Mode = System.Security.Cryptography.CipherMode.CBC;
        ICryptoTransform encryptor = aesManaged.CreateEncryptor(bytes1, bytes2);
        using (MemoryStream memoryStream = new MemoryStream())
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
          {
            using (StreamWriter streamWriter = new StreamWriter((Stream) cryptoStream))
              streamWriter.Write(plainText);
            array = memoryStream.ToArray();
          }
        }
      }
      return Convert.ToBase64String(array);
    }
    catch (CryptographicException ex)
    {
      Console.WriteLine(ex.Message);
      return (string) null;
    }
  }

  private static string DecryptAes(string cipherText, string Key, string IV)
  {
    try
    {
      string str = (string) null;
      byte[] bytes1 = Encoding.ASCII.GetBytes(Key);
      byte[] bytes2 = Encoding.ASCII.GetBytes(IV);
      using (AesManaged aesManaged = new AesManaged())
      {
        ICryptoTransform decryptor = aesManaged.CreateDecryptor(bytes1, bytes2);
        using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cipherText)))
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
          {
            using (StreamReader streamReader = new StreamReader((Stream) cryptoStream))
              str = streamReader.ReadToEnd();
          }
        }
      }
      return str;
    }
    catch (CryptographicException ex)
    {
      Console.WriteLine(ex.Message);
      return (string) null;
    }
  }

  public static int RandomNumber(int min, int max) => Program._random.Next(min, max);

  public static string RandomString(int size, bool lowerCase = false)
  {
    StringBuilder stringBuilder = new StringBuilder(size);
    char minValue = lowerCase ? 'a' : 'A';
    for (int index = 0; index < size; ++index)
    {
      char ch = (char) Program._random.Next((int) minValue, (int) minValue + 26);
      stringBuilder.Append(ch);
    }
    return lowerCase ? stringBuilder.ToString().ToLower() : stringBuilder.ToString();
  }
}
