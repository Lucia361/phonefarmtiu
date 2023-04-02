// Decompiled with JetBrains decompiler
// Type: Class201
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

internal class Class201
{
  private static string string_0 = "\uD83D\uDE42|\uD83D\uDE00|\uD83D\uDE04|\uD83D\uDE06|\uD83D\uDE05|\uD83D\uDE02|\uD83E\uDD23|\uD83D\uDE0A|\uD83D\uDE0C|\uD83D\uDE09|\uD83D\uDE0F|\uD83D\uDE0D|\uD83D\uDE18|\uD83D\uDE17|\uD83D\uDE19|\uD83D\uDE1A|\uD83E\uDD17|\uD83D\uDE33|\uD83D\uDE43|\uD83D\uDE07|\uD83D\uDE08|\uD83D\uDE1B|\uD83D\uDE1D|\uD83D\uDE1C|\uD83D\uDE0B|\uD83E\uDD24|\uD83E\uDD13|\uD83D\uDE0E|\uD83E\uDD11|\uD83D\uDE12|\uD83D\uDE41|☹️|\uD83D\uDE1E|\uD83D\uDE14|\uD83D\uDE16|\uD83D\uDE13|\uD83D\uDE22|\uD83D\uDE22|\uD83D\uDE2D|\uD83D\uDE1F|\uD83D\uDE23|\uD83D\uDE29|\uD83D\uDE2B|\uD83D\uDE15|\uD83E\uDD14|\uD83D\uDE44|\uD83D\uDE24|\uD83D\uDE20|\uD83D\uDE21|\uD83D\uDE36|\uD83E\uDD10|\uD83D\uDE10|\uD83D\uDE11|\uD83D\uDE2F|\uD83D\uDE32|\uD83D\uDE27|\uD83D\uDE28|\uD83D\uDE30|\uD83D\uDE31|\uD83D\uDE2A|\uD83D\uDE34|\uD83D\uDE2C|\uD83E\uDD25|\uD83E\uDD27|\uD83E\uDD12|\uD83D\uDE37|\uD83E\uDD15|\uD83D\uDE35|\uD83E\uDD22|\uD83E\uDD20|\uD83E\uDD21|\uD83D\uDC7F|\uD83D\uDC79|\uD83D\uDC7A|\uD83D\uDC7B|\uD83D\uDC80|\uD83D\uDC7D|\uD83D\uDC7E|\uD83E\uDD16|\uD83D\uDCA9|��";
  private static string string_1 = "♥️|❤️|\uD83D\uDC9B|\uD83D\uDC9A|\uD83D\uDC99|\uD83D\uDC9C|\uD83D\uDDA4|\uD83D\uDC96|\uD83D\uDC9D|\uD83D\uDC94|❣️|\uD83D\uDC95|\uD83D\uDC9E|\uD83D\uDC93|\uD83D\uDC97|\uD83D\uDC98|\uD83D\uDC9F|\uD83D\uDC8C|\uD83D\uDC8B|\uD83D\uDC44|\uD83D\uDC84|\uD83D\uDC8D|\uD83D\uDCFF|\uD83C\uDF81|\uD83D\uDC59|\uD83D\uDC57|\uD83D\uDC5A|\uD83D\uDC55|\uD83D\uDC58|\uD83C\uDFBD|\uD83D\uDC58|\uD83D\uDC56|\uD83D\uDC60|\uD83D\uDC61|\uD83D\uDC62|\uD83D\uDC5F|\uD83D\uDC5E|\uD83D\uDC52|\uD83C\uDFA9|\uD83C\uDF93|\uD83D\uDC51|⛑️|\uD83D\uDC53|\uD83D\uDD76️|\uD83C\uDF02|\uD83D\uDC5B|\uD83D\uDC5D|\uD83D\uDC5C|\uD83D\uDCBC|\uD83C\uDF92|\uD83D\uDECD️|\uD83D\uDED2|\uD83C\uDFAD|\uD83C\uDFA6|\uD83C\uDFA8|\uD83E\uDD39|\uD83C\uDF8A|\uD83C\uDF89|\uD83C\uDF88|\uD83C\uDFA7|\uD83C\uDFB7|\uD83C\uDFBA|\uD83C\uDFB8|\uD83C\uDFBB|\uD83E\uDD41|\uD83C\uDFB9|\uD83C\uDFA4|\uD83C\uDFB5|\uD83C\uDFB6|\uD83C\uDFBC|⚽|\uD83C\uDFC0|\uD83C\uDFC8|⚾|\uD83C\uDFD0|\uD83C\uDFC9|\uD83C\uDFB1|\uD83C\uDFBE|\uD83C\uDFF8|\uD83C\uDFD3|\uD83C\uDFCF|\uD83C\uDFD1|\uD83C\uDFD2|\uD83E\uDD45|⛸️|\uD83C\uDFBF|\uD83E\uDD4A|\uD83E\uDD4B|⛳|\uD83C\uDFB3|\uD83C\uDFF9|\uD83C\uDFA3|\uD83C\uDFAF|\uD83D\uDEB5|\uD83C\uDF96️|\uD83C\uDFC5|\uD83E\uDD47|\uD83E\uDD48|\uD83E\uDD49|��";
  private static string string_2 = "\uD83C\uDF4F|\uD83C\uDF4E|\uD83C\uDF50|\uD83C\uDF4A|\uD83C\uDF4B|\uD83C\uDF4C|\uD83C\uDF49|\uD83C\uDF47|\uD83C\uDF53|\uD83C\uDF48|\uD83E\uDD5D|\uD83E\uDD51|\uD83C\uDF4D|\uD83C\uDF52|\uD83C\uDF51|\uD83C\uDF46|\uD83E\uDD52|\uD83E\uDD55|\uD83C\uDF36|\uD83C\uDF3D|\uD83C\uDF45|\uD83E\uDD54|\uD83C\uDF60|\uD83C\uDF30|\uD83E\uDD5C|\uD83C\uDF6F|\uD83E\uDD50|\uD83C\uDF5E|\uD83E\uDD56|\uD83E\uDDC0|\uD83E\uDD5A|\uD83C\uDF73|\uD83E\uDD53|\uD83C\uDF64|\uD83C\uDF57|\uD83C\uDF56|\uD83C\uDF55|\uD83C\uDF2D|\uD83C\uDF54|\uD83C\uDF5F|\uD83E\uDD59|\uD83C\uDF2E|\uD83C\uDF2F|\uD83E\uDD57|\uD83E\uDD58|\uD83C\uDF5D|\uD83C\uDF5C|\uD83C\uDF72|\uD83C\uDF63|\uD83C\uDF71|\uD83C\uDF5B|\uD83C\uDF5A|\uD83C\uDF59|\uD83C\uDF58|\uD83C\uDF62|\uD83C\uDF61|\uD83C\uDF67|\uD83C\uDF68|\uD83C\uDF66|\uD83E\uDD5E|\uD83C\uDF70|\uD83C\uDF82|\uD83C\uDF6E|\uD83C\uDF6D|\uD83C\uDF65|\uD83C\uDF6C|\uD83C\uDF6B|\uD83C\uDF7F|\uD83C\uDF69|\uD83C\uDF6A|\uD83C\uDF7C|\uD83E\uDD5B|☕|\uD83C\uDF75|\uD83C\uDF76|\uD83C\uDF7A|\uD83C\uDF7B|\uD83E\uDD42|\uD83C\uDF77|\uD83E\uDD43|\uD83C\uDF78|\uD83C\uDF79|\uD83C\uDF7E|\uD83E\uDD44|\uD83C\uDF74|��";
  private static string string_3 = "\uD83D\uDE3A|\uD83D\uDE38|\uD83D\uDE39|\uD83D\uDE3B|\uD83D\uDE3C|\uD83D\uDE3D|\uD83D\uDE40|\uD83D\uDE3F|\uD83D\uDE3E|\uD83D\uDC31|\uD83D\uDC36|\uD83D\uDC30|\uD83D\uDC2D|\uD83D\uDC39|\uD83E\uDD8A|\uD83D\uDC3B|\uD83D\uDC3C|\uD83D\uDC28|\uD83D\uDC2F|\uD83E\uDD81|\uD83D\uDC2E|\uD83D\uDC17|\uD83D\uDC37|\uD83D\uDC3D|\uD83D\uDC38|\uD83D\uDC35|\uD83D\uDE48|\uD83D\uDE49|\uD83D\uDE4A|\uD83E\uDD8D|\uD83D\uDC3A|\uD83D\uDC11|\uD83D\uDC10|\uD83D\uDC0F|\uD83D\uDC34|\uD83E\uDD84|\uD83E\uDD8C|\uD83E\uDD8F|\uD83E\uDD85|\uD83D\uDC24|\uD83D\uDC23|\uD83D\uDC25|\uD83D\uDC14|\uD83D\uDC13|\uD83E\uDD83|\uD83D\uDC26|\uD83E\uDD86|\uD83E\uDD87|\uD83E\uDD89|\uD83D\uDD4A️|\uD83D\uDC27|\uD83D\uDC15|\uD83D\uDC29|\uD83D\uDC08|\uD83D\uDC07|\uD83D\uDC01|\uD83D\uDC00|\uD83D\uDC3F|\uD83D\uDC12|\uD83D\uDC16|\uD83D\uDC06|\uD83D\uDC05|\uD83D\uDC03|\uD83D\uDC02|\uD83D\uDC04|\uD83D\uDC0E|\uD83D\uDC2A|\uD83D\uDC2B|\uD83D\uDC18|\uD83D\uDC0A|\uD83D\uDC22|\uD83D\uDC20|\uD83D\uDC1F|\uD83D\uDC21|\uD83D\uDC2C|\uD83E\uDD88|\uD83D\uDC33|\uD83D\uDC0B|\uD83E\uDD91|\uD83D\uDC19|\uD83E\uDD90|\uD83D\uDC1A|\uD83E\uDD80|\uD83E\uDD82|\uD83E\uDD8E|\uD83D\uDC0D|\uD83D\uDC1B|\uD83D\uDC1C|\uD83D\uDD77️|\uD83D\uDD78️|\uD83D\uDC1E|\uD83E\uDD8B|\uD83D\uDC1D|\uD83D\uDC0C|\uD83D\uDC32|\uD83D\uDC09|��";
  private static string string_4 = "\uD83C\uDF3C|\uD83C\uDF38|\uD83C\uDF3A|\uD83C\uDFF5️|\uD83C\uDF3B|\uD83C\uDF37|\uD83C\uDF39|\uD83E\uDD40|\uD83D\uDC90|\uD83C\uDF3E|\uD83C\uDF8B|☘|\uD83C\uDF40|\uD83C\uDF43|\uD83C\uDF42|\uD83C\uDF41|\uD83C\uDF31|\uD83C\uDF3F|\uD83C\uDF8D|\uD83C\uDF35|\uD83C\uDF34|\uD83C\uDF33|\uD83C\uDF33|\uD83C\uDF84|\uD83C\uDF44|\uD83C\uDF0E|\uD83C\uDF0D|\uD83C\uDF0F|\uD83C\uDF1C|\uD83C\uDF1B|\uD83C\uDF15|\uD83C\uDF16|\uD83C\uDF17|\uD83C\uDF18|\uD83C\uDF11|\uD83C\uDF12|\uD83C\uDF13|\uD83C\uDF14|\uD83C\uDF1A|\uD83C\uDF1D|\uD83C\uDF19|\uD83D\uDCAB|⭐|\uD83C\uDF1F|✨|⚡|\uD83D\uDD25|\uD83D\uDCA5|☄️|\uD83C\uDF1E|☀️|\uD83C\uDF24️|⛅|\uD83C\uDF25️|\uD83C\uDF26️|☁️|\uD83C\uDF27️|⛈️|\uD83C\uDF29️|\uD83C\uDF28️|\uD83C\uDF08|\uD83D\uDCA7|\uD83D\uDCA6|☂️|☔|\uD83C\uDF0A|\uD83C\uDF2B|\uD83C\uDF2A|\uD83D\uDCA8|❄|\uD83C\uDF2C|⛄|☃️";
  private static string string_5 = "\uD83D\uDE97|\uD83D\uDE95|\uD83D\uDE99|\uD83D\uDE8C|\uD83D\uDE8E|\uD83C\uDFCE|\uD83D\uDE93|\uD83D\uDE91|\uD83D\uDE92|\uD83D\uDE90|\uD83D\uDE9A|\uD83D\uDE9B|\uD83D\uDE9C|\uD83D\uDEF4|\uD83D\uDEB2|\uD83D\uDEF5|\uD83C\uDFCD|\uD83D\uDE98|\uD83D\uDE96|\uD83D\uDE8D|\uD83D\uDE94|\uD83D\uDEA8|\uD83D\uDCBA|✈|\uD83D\uDEEB|\uD83D\uDEEC|\uD83D\uDEE9|\uD83D\uDE81|\uD83D\uDE80|\uD83D\uDEF0|\uD83D\uDEA1|\uD83D\uDEA0|\uD83D\uDE9F|\uD83D\uDE83|\uD83D\uDE8B|\uD83D\uDE9E|\uD83D\uDE9D|\uD83D\uDE84|\uD83D\uDE85|\uD83D\uDE88|\uD83D\uDE82|\uD83D\uDE86|\uD83D\uDE8A|\uD83D\uDE87|\uD83D\uDE89|\uD83D\uDEF6|⛵|\uD83D\uDEE5|\uD83D\uDEA4|\uD83D\uDEA2|⛴|\uD83D\uDEF3|⚓|\uD83D\uDEA7|⛽|\uD83D\uDE8F|\uD83D\uDEA6|\uD83D\uDEA5|\uD83D\uDEE3|\uD83D\uDEE4|\uD83C\uDFD7|\uD83C\uDFED|\uD83C\uDFE0|\uD83C\uDFE1|\uD83C\uDFD8|\uD83C\uDFDA|\uD83C\uDFE2|\uD83C\uDFEC|\uD83C\uDFE4|\uD83C\uDFE3|\uD83C\uDFE5|\uD83C\uDFE6|\uD83C\uDFEA|\uD83C\uDFEB|\uD83C\uDFE8|\uD83C\uDFE9|\uD83C\uDFDB|\uD83C\uDFF0|\uD83C\uDFEF|\uD83C\uDFDF️|⛪|\uD83D\uDC92|\uD83D\uDD4C|\uD83D\uDD4D|\uD83D\uDD4B|⛩|\uD83D\uDDFC|\uD83D\uDDFF|\uD83D\uDDFD|\uD83D\uDDFA|\uD83C\uDFAA|\uD83C\uDFA0|\uD83C\uDFA1|\uD83C\uDFA2|⛲|⛱|\uD83C\uDFD6|\uD83C\uDFDD|\uD83C\uDFD5|⛺|\uD83D\uDDFE|⛰|\uD83C\uDFD4|\uD83D\uDDFB|\uD83C\uDF0B|\uD83C\uDFDE|\uD83C\uDFDC|\uD83C\uDF05|\uD83C\uDF04|\uD83C\uDF91|\uD83C\uDF20|\uD83C\uDF87|\uD83C\uDF86|\uD83C\uDFD9|\uD83C\uDF07|\uD83C\uDF06|\uD83C\uDF03|\uD83C\uDF0C|\uD83C\uDF09|��";
  private static string string_6 = "\uD83D\uDCF1|\uD83D\uDCF2|\uD83D\uDCBB|\uD83D\uDDA5|⌨|\uD83D\uDDA8|\uD83D\uDDB1|\uD83D\uDDB2|\uD83D\uDD79|\uD83C\uDFAE|\uD83D\uDCBD|\uD83D\uDCBE|\uD83D\uDCBF|\uD83D\uDCC0|\uD83D\uDCFC|\uD83D\uDCF7|\uD83D\uDCF8|\uD83D\uDCF9|\uD83C\uDFA5|\uD83D\uDCFD|\uD83C\uDF9E|\uD83C\uDFAC|\uD83D\uDCDE|☎|\uD83D\uDCDF|\uD83D\uDCE0|\uD83D\uDCFA|\uD83D\uDCFB|\uD83C\uDF99|\uD83C\uDF9A|\uD83C\uDF9B|\uD83D\uDCE1|\uD83D\uDCE2|\uD83D\uDCE3|\uD83D\uDD14|\uD83D\uDCA1|\uD83D\uDD6F|\uD83D\uDD26|\uD83D\uDD0B|\uD83D\uDD0C|⌚|⏱|⏲|⏰|\uD83D\uDD70|⌛|⏳|\uD83D\uDD2E|\uD83D\uDC8E|\uD83C\uDFB2|\uD83C\uDFB0|\uD83D\uDCB8|\uD83D\uDCB5|\uD83D\uDCB4|\uD83D\uDCB6|\uD83D\uDCB7|\uD83D\uDCB0|\uD83D\uDCB3|\uD83D\uDCB2|\uD83D\uDCB1|⚖|\uD83D\uDD2B|\uD83D\uDCA3|\uD83D\uDD2A|\uD83D\uDDE1|⚔|\uD83D\uDEE1|\uD83D\uDEAC|⚰|⚱|\uD83D\uDDDC️|\uD83D\uDD27|\uD83D\uDD28|⚒|\uD83D\uDEE0|⛏|\uD83D\uDD29|⚙|⛓|\uD83D\uDC88|\uD83C\uDF21|\uD83D\uDC8A|\uD83D\uDC89|⚗|\uD83D\uDD2C|\uD83D\uDD2D|\uD83D\uDEBF|\uD83D\uDEC1|\uD83D\uDEBD|\uD83D\uDECE|\uD83D\uDD11|\uD83D\uDDDD|\uD83D\uDEAA|\uD83D\uDECB|\uD83D\uDECF|\uD83D\uDDBC|\uD83C\uDFFA|\uD83D\uDDD1|\uD83D\uDEE2|\uD83D\uDD73|\uD83C\uDFEE|\uD83C\uDF8F|\uD83C\uDF8E|\uD83C\uDF90|\uD83C\uDFAB|\uD83C\uDF9F️|\uD83C\uDF80|\uD83C\uDF97️|\uD83D\uDCEF|✉|\uD83D\uDCE9|\uD83D\uDCE8|\uD83D\uDCE7|\uD83D\uDCE6|\uD83D\uDCEA|\uD83D\uDCEB|\uD83D\uDCEC|\uD83D\uDCED|\uD83D\uDCEE|\uD83D\uDCE5|\uD83D\uDCE4|\uD83D\uDCDC|\uD83D\uDCC3|\uD83D\uDCC4|\uD83D\uDCD1|\uD83D\uDCCA|\uD83D\uDCC8|\uD83D\uDCC9|\uD83D\uDDD2|\uD83D\uDCC5|\uD83D\uDCC6|\uD83D\uDDD3|\uD83D\uDCC7|\uD83D\uDDC3|\uD83D\uDDF3|\uD83D\uDDC4|\uD83D\uDCCB|\uD83D\uDCC1|\uD83D\uDCC2|\uD83D\uDDC2|\uD83D\uDCD3|\uD83D\uDCD4|\uD83D\uDCD2|\uD83D\uDCD5|\uD83D\uDCD7|\uD83D\uDCD8|\uD83D\uDCD9|\uD83D\uDCDA|\uD83D\uDCD6|\uD83D\uDDDE|\uD83D\uDCF0|\uD83D\uDCDD|✏|\uD83D\uDD8A|\uD83D\uDD8D|\uD83D\uDD8C|\uD83D\uDD8B|✒|\uD83D\uDCCC|\uD83D\uDCCD|\uD83D\uDCCE|\uD83D\uDD87|\uD83D\uDD16|\uD83C\uDFF7|\uD83D\uDD17|\uD83D\uDD0D|\uD83D\uDD0E|\uD83D\uDCD0|\uD83D\uDCCF|✂|\uD83D\uDD12|\uD83D\uDD13|\uD83D\uDD0F|��";
  private static string string_7 = "\uD83D\uDE42|\uD83D\uDE00|\uD83D\uDE04|\uD83D\uDE06|\uD83D\uDE05|\uD83D\uDE02|\uD83E\uDD23|\uD83D\uDE0A|\uD83D\uDE0C|\uD83D\uDE09|\uD83D\uDE0D|\uD83D\uDE18|\uD83D\uDE17|\uD83D\uDE19|\uD83D\uDE1A|\uD83E\uDD17|\uD83D\uDE33|\uD83D\uDE43|\uD83D\uDE1B|\uD83D\uDE1D|\uD83D\uDE1C|\uD83D\uDE0B|\uD83E\uDD24|\uD83E\uDD13|��";
  private static string string_8 = "0️⃣|1️⃣|2️⃣|3️⃣|4️⃣|5️⃣|6️⃣|7️⃣|8️⃣|9️⃣";
  private static List<string> list_0 = new List<string>()
  {
    "[r1]",
    "[r2]",
    "[r3]",
    "[r4]",
    "[r5]",
    "[r6]",
    "[r7]",
    "[r8]",
    "[d]",
    "[t]"
  };

  private static string smethod_0(string string_9)
  {
    string str = "";
    try
    {
      List<string> list = ((IEnumerable<string>) Class201.string_8.Split('|')).ToList<string>();
      for (int index = 0; index < string_9.Length; ++index)
      {
        string string_0 = string_9[index].ToString();
        if (GClass19.smethod_51(string_0))
          string_0 = list[Convert.ToInt32(string_0)];
        str += string_0;
      }
    }
    catch
    {
    }
    return str;
  }

  private static string smethod_1(string string_9, Random random_0)
  {
    string str = "";
    List<string> stringList = new List<string>();
    try
    {
      // ISSUE: reference to a compiler-generated method
      switch (Class206.smethod_0(string_9))
      {
        case 311070023:
          if (string_9 == "[r8]")
          {
            List<string> list = ((IEnumerable<string>) Class201.string_7.Split('|')).ToList<string>();
            str = list[random_0.Next(0, list.Count)];
            break;
          }
          break;
        case 312791236:
          if (string_9 == "[r3]")
          {
            List<string> list = ((IEnumerable<string>) Class201.string_2.Split('|')).ToList<string>();
            str = list[random_0.Next(0, list.Count)];
            break;
          }
          break;
        case 313482784:
          if (string_9 == "[r7]")
          {
            List<string> list = ((IEnumerable<string>) Class201.string_6.Split('|')).ToList<string>();
            str = list[random_0.Next(0, list.Count)];
            break;
          }
          break;
        case 380446165:
          if (string_9 == "[r6]")
          {
            List<string> list = ((IEnumerable<string>) Class201.string_5.Split('|')).ToList<string>();
            str = list[random_0.Next(0, list.Count)];
            break;
          }
          break;
        case 2059200309:
          if (string_9 == "[t]")
          {
            str = DateTime.Now.ToString("HH:mm:ss");
            break;
          }
          break;
        case 3135527781:
          if (string_9 == "[d]")
          {
            str = DateTime.Now.ToString("dd/MM/yyyy");
            break;
          }
          break;
        case 3534241179:
          if (string_9 == "[r4]")
          {
            List<string> list = ((IEnumerable<string>) Class201.string_3.Split('|')).ToList<string>();
            str = list[random_0.Next(0, list.Count)];
            break;
          }
          break;
        case 3600807202:
          if (string_9 == "[r1]")
          {
            List<string> list = ((IEnumerable<string>) Class201.string_0.Split('|')).ToList<string>();
            str = list[random_0.Next(0, list.Count)];
            break;
          }
          break;
        case 3600954297:
          if (string_9 == "[r2]")
          {
            List<string> list = ((IEnumerable<string>) Class201.string_1.Split('|')).ToList<string>();
            str = list[random_0.Next(0, list.Count)];
            break;
          }
          break;
        case 3601498750:
          if (string_9 == "[r5]")
          {
            List<string> list = ((IEnumerable<string>) Class201.string_4.Split('|')).ToList<string>();
            str = list[random_0.Next(0, list.Count)];
            break;
          }
          break;
      }
    }
    catch
    {
    }
    return str;
  }

  public static string smethod_2(string string_9, Random random_0)
  {
    string str = "";
    try
    {
      for (int index1 = 0; index1 < Class201.list_0.Count; ++index1)
      {
        string string_9_1 = Class201.list_0[index1];
        if (string_9.Contains(string_9_1))
        {
          List<string> list = ((IEnumerable<string>) string_9.Split(new string[1]
          {
            string_9_1
          }, StringSplitOptions.None)).ToList<string>();
          for (int index2 = 0; index2 < list.Count - 1; ++index2)
            str = str + list[index2] + Class201.smethod_1(string_9_1, random_0);
          string_9 = str + list[list.Count - 1];
          str = "";
        }
      }
      MatchCollection matchCollection1 = Regex.Matches(string_9, "\\[n(.*?)\\]");
      for (int i = 0; i < matchCollection1.Count; ++i)
      {
        List<string> list = ((IEnumerable<string>) string_9.Split(new string[1]
        {
          matchCollection1[i].Value
        }, StringSplitOptions.None)).ToList<string>();
        for (int index = 0; index < list.Count - 1; ++index)
          str = str + list[index] + GClass19.smethod_61(Convert.ToInt32(matchCollection1[i].Groups[1].Value), random_0);
        string_9 = str + list[list.Count - 1];
        str = "";
      }
      MatchCollection matchCollection2 = Regex.Matches(string_9, "\\[s(.*?)\\]");
      for (int i = 0; i < matchCollection2.Count; ++i)
      {
        List<string> list = ((IEnumerable<string>) string_9.Split(new string[1]
        {
          matchCollection2[i].Value
        }, StringSplitOptions.None)).ToList<string>();
        for (int index = 0; index < list.Count - 1; ++index)
          str = str + list[index] + GClass19.smethod_60(Convert.ToInt32(matchCollection2[i].Groups[1].Value), random_0);
        string_9 = str + list[list.Count - 1];
        str = "";
      }
      MatchCollection matchCollection3 = Regex.Matches(string_9, "\\[q(.*?)\\]");
      for (int i = 0; i < matchCollection3.Count; ++i)
      {
        List<string> list = ((IEnumerable<string>) string_9.Split(new string[1]
        {
          matchCollection3[i].Value
        }, StringSplitOptions.None)).ToList<string>();
        for (int index = 0; index < list.Count - 1; ++index)
          str = str + list[index] + Class201.smethod_0(matchCollection3[i].Groups[1].Value);
        string_9 = str + list[list.Count - 1];
        str = "";
      }
    }
    catch
    {
    }
    return string_9;
  }
}
