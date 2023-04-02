// Decompiled with JetBrains decompiler
// Type: Class38
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

internal class Class38
{
  public static List<string> smethod_0(string string_0, string string_1, int int_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      string input = new GClass24(string_0, "", string_1, int_0).method_0("https://mbasic.facebook.com/pages/?viewallpywo=1");
      List<string> first = new List<string>();
      foreach (Match match in Regex.Matches(input, "page_suggestion_(\\d+)\""))
        first.Add(match.Groups[1].Value);
      List<string> second = new List<string>();
      foreach (Match match in Regex.Matches(input, "id=(\\d+)&"))
        second.Add(match.Groups[1].Value);
      stringList = first.Except<string>((IEnumerable<string>) second).ToList<string>();
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  public static List<string> smethod_1(string string_0, string string_1, int int_0, bool bool_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      string propertyName = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
      GClass24 gclass24 = new GClass24(string_0, "", string_1, int_0);
      if (bool_0)
      {
        string str = Regex.Match(gclass24.method_0("https://mobile.facebook.com/help/"), "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
        foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(gclass24.method_1("https://www.facebook.com/api/graphql/", "q=nodes(" + propertyName + "){groups{nodes{id,name,viewer_post_status,visibility,group_member_profiles{count}}}}&fb_dtsg=" + str).Replace("for (;;);", ""))[propertyName][(object) "groups"][(object) "nodes"])
        {
          try
          {
            stringList.Add(string.Format("{0}|{1}|{2}|{3}", (object) jtoken[(object) "id"], (object) jtoken[(object) "name"], (object) jtoken[(object) "group_member_profiles"][(object) "count"], jtoken[(object) "viewer_post_status"].ToString() == "CAN_POST_AFTER_APPROVAL" ? (object) "True" : (object) "False"));
          }
          catch (Exception ex)
          {
          }
        }
      }
      else
      {
        string string_0_1 = "https://www.facebook.com/ajax/typeahead/first_degree.php?fb_dtsg_ag=" + Regex.Match(gclass24.method_0("https://mobile.facebook.com/help/"), GClass19.smethod_58("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value + "&filter%5B0%5D=group&viewer=" + propertyName + "&__user=" + propertyName + "&__a=1&__dyn=&__comet_req=0&jazoest=26581";
        foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(gclass24.method_0(string_0_1).Replace("for (;;);", ""))["payload"][(object) "entries"])
        {
          try
          {
            stringList.Add(string.Format("{0}|{1}|{2}", (object) jtoken[(object) "uid"], (object) jtoken[(object) "text"], (object) jtoken[(object) "size"]));
          }
          catch
          {
          }
        }
      }
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  private static List<string> smethod_2(
    List<string> list_0,
    string string_0,
    string string_1,
    string string_2,
    int int_0)
  {
    try
    {
      int int_2 = 0;
      int num1 = list_0.Count < 100 ? list_0.Count : 100;
      int num2 = 0;
      while (num2 < list_0.Count)
      {
        if (int_2 < num1)
        {
          Interlocked.Increment(ref int_2);
          int int_ = num2++;
          new Thread((ThreadStart) (() =>
          {
            string str1 = list_0[int_];
            bool flag = true;
            try
            {
              string str2 = str1;
              char[] chArray = new char[1]{ '|' };
              flag = new GClass24(string_0, string_1, string_2, int_0).method_0("https://mobile.facebook.com/groups/" + str2.Split(chArray)[0] + "/madminpanel").Contains("madminpanel/pending/");
            }
            catch
            {
            }
            list_0[int_] = string.Format("{0}|{1}", (object) str1, (object) flag);
            Interlocked.Decrement(ref int_2);
          }))
          {
            IsBackground = true
          }.Start();
        }
        else
        {
          Application.DoEvents();
          Thread.Sleep(200);
        }
      }
      while (int_2 > 0)
      {
        Application.DoEvents();
        Thread.Sleep(100);
      }
    }
    catch
    {
    }
    return list_0;
  }

  public static string smethod_3(int int_0 = 16)
  {
    Random random = new Random();
    string str1 = "abcdef1234567890";
    string str2 = "";
    for (int index = 0; index < int_0; ++index)
      str2 += Convert.ToString(str1[random.Next(0, str1.Length)]);
    return str2;
  }

  public static string smethod_4(string string_0, string string_1, string string_2, int int_0)
  {
    string str1 = "0|0";
    string str2 = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
    if (str2 != "")
    {
      try
      {
        GClass24 gclass24 = new GClass24(string_0, string_1, string_2, int_0);
        if (str2 != "")
        {
          if (GClass20.smethod_45(gclass24.method_0("https://m.facebook.com/home.php").ToString(), new List<string>()
          {
            "/friends/",
            "/logout.php?button_location=settings&amp;button_name=logout"
          }))
            str1 = "1|1";
        }
      }
      catch
      {
      }
    }
    return str1;
  }

  public static List<string> smethod_5(string string_0, string string_1, int int_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      foreach (JToken jtoken in (IEnumerable<JToken>) JObject.Parse(new GClass24("", "", string_1, int_0).method_0("https://graph.facebook.com/v3.0/me/friends?access_token=" + string_0 + "&limit=5000&fields=id,name"))["data"])
        stringList.Add(jtoken[(object) "name"].ToString());
    }
    catch
    {
    }
    return stringList;
  }

  public static List<string> smethod_6(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    int int_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      string propertyName = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
      GClass24 gclass24 = new GClass24(string_0, string_2, string_3, int_0);
      gclass24.httpRequest_0.AddHeader("Authorization", "OAuth " + string_1);
      JToken jtoken = JObject.Parse(gclass24.method_0("https://graph.facebook.com/?ids=" + propertyName + "&fields=friends{id,name}"))[propertyName][(object) "friends"];
      if (jtoken[(object) "data"].Count<JToken>() > 0)
      {
        for (int key = 0; key < jtoken[(object) "data"].Count<JToken>(); ++key)
        {
          string str = jtoken[(object) "data"][(object) key][(object) "id"].ToString();
          stringList.Add(str);
        }
      }
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  public static List<string> smethod_7(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    string string_4,
    int int_0,
    int int_1 = 20,
    bool bool_0 = false)
  {
    List<string> stringList = new List<string>();
    try
    {
      Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
      string str1 = string_0;
      char[] chArray1 = new char[1]{ ',' };
      foreach (string key in str1.Split(chArray1))
        dictionary.Add(key, new List<string>());
      GClass24 gclass24_1 = new GClass24(string_1, string_3, string_4, int_0);
      gclass24_1.httpRequest_0.AddHeader("Authorization", "OAuth " + string_2);
      string string_0_1 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=id,name,photos.limit(" + int_1.ToString() + "){images}";
      string json1 = gclass24_1.method_0(string_0_1);
      JObject jobject1 = JObject.Parse(json1);
      if (jobject1 != null && json1.Contains("images"))
      {
        string str2 = string_0;
        char[] chArray2 = new char[1]{ ',' };
        foreach (string str3 in str2.Split(chArray2))
        {
          string str4 = jobject1[str3][(object) "name"].ToString();
          try
          {
            foreach (JToken jtoken in (IEnumerable<JToken>) jobject1[str3][(object) "photos"][(object) "data"])
            {
              try
              {
                int key = jtoken[(object) "images"].ToList<JToken>().Count - 1;
                dictionary[str3].Add(str3 + "*" + str4 + "*" + jtoken[(object) "images"][(object) key][(object) "source"]?.ToString() + "|" + jtoken[(object) "images"][(object) key][(object) "width"]?.ToString() + "|" + jtoken[(object) "images"][(object) key][(object) "height"]?.ToString());
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
      }
      if (bool_0)
      {
        GClass24 gclass24_2 = new GClass24(string_1, string_3, string_4, int_0);
        gclass24_2.httpRequest_0.AddHeader("Authorization", "OAuth " + string_2);
        string string_0_2 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=name,albums.limit(3){photos.limit(10){width,height,images}}";
        string json2 = gclass24_2.method_0(string_0_2);
        JObject jobject2 = JObject.Parse(json2);
        if (jobject2 != null && json2.Contains("images"))
        {
          string[] strArray = string_0.Split(',');
label_43:
          for (int index = 0; index < strArray.Length; ++index)
          {
            string str5 = strArray[index];
            string str6 = jobject2[str5][(object) "name"].ToString();
            foreach (JToken jtoken1 in (IEnumerable<JToken>) jobject2[str5][(object) "albums"][(object) "data"])
            {
              try
              {
                foreach (JToken jtoken2 in (IEnumerable<JToken>) jtoken1[(object) "photos"][(object) "data"])
                {
                  try
                  {
                    int key = jtoken2[(object) "images"].ToList<JToken>().Count - 1;
                    if (dictionary[str5].Count < int_1)
                      dictionary[str5].Add(str5 + "*" + str6 + "*" + jtoken2[(object) "images"][(object) key][(object) "source"]?.ToString() + "|" + jtoken2[(object) "images"][(object) key][(object) "width"]?.ToString() + "|" + jtoken2[(object) "images"][(object) key][(object) "height"]?.ToString());
                    else
                      goto label_43;
                  }
                  catch (Exception ex)
                  {
                  }
                }
              }
              catch (Exception ex)
              {
              }
            }
          }
        }
      }
      foreach (KeyValuePair<string, List<string>> keyValuePair in dictionary)
      {
        if (keyValuePair.Value.Count > 0)
        {
          stringList.AddRange((IEnumerable<string>) keyValuePair.Value);
          stringList.Add("");
        }
      }
    }
    catch (Exception ex)
    {
    }
    return stringList;
  }

  public static List<string> smethod_8(
    string string_0,
    string string_1,
    string string_2,
    int int_0)
  {
    List<string> stringList1 = new List<string>();
    try
    {
      GClass24 gclass24 = new GClass24(string_0, string_1, string_2, int_0);
      string str1 = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
      string format = "https://mbasic.facebook.com/{0}/allactivity/?category_key=commentscluster&timestart={1}&timeend={2}";
      List<string> stringList2 = new List<string>();
      for (int index = 0; index < 5; ++index)
      {
        DateTime now = DateTime.Now;
        DateTime dateTime1 = now.AddMonths(2 - index);
        now = DateTime.Now;
        DateTime dateTime2 = now.AddMonths(1 - index);
        double num = GClass19.smethod_74(new DateTime(dateTime1.Year, dateTime1.Month, 1));
        string str2 = num.ToString();
        num = GClass19.smethod_74(new DateTime(dateTime2.Year, dateTime2.Month, 1));
        string str3 = num.ToString();
        string str4 = string.Format(format, (object) str1, (object) str2, (object) str3);
        stringList2.Add(str4);
      }
      for (int index = 0; index < stringList2.Count; ++index)
      {
        string string_0_1 = stringList2[index];
        bool flag;
        do
        {
          flag = false;
          string input1 = WebUtility.HtmlDecode(gclass24.method_0(string_0_1));
          MatchCollection matchCollection1 = Regex.Matches(input1, "<span>(.*?)</h4>");
          for (int i1 = 0; i1 < matchCollection1.Count; ++i1)
          {
            string str5 = matchCollection1[i1].Groups[1].Value;
            string input2 = str5.Substring(0, str5.LastIndexOf('<'));
            MatchCollection matchCollection2 = Regex.Matches(input2, "<(.*?)>");
            for (int i2 = 0; i2 < matchCollection2.Count; ++i2)
              input2 = input2.Replace(matchCollection2[i2].Value, "");
            if (input2 != "" && !stringList1.Contains(input2))
              stringList1.Add(input2);
          }
          if (Regex.IsMatch(input1, "/" + str1 + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\""))
          {
            string_0_1 = "https://mbasic.facebook.com" + Regex.Match(input1, "/" + str1 + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\"").Value.Replace("\"", "");
            flag = true;
          }
        }
        while (flag);
      }
    }
    catch
    {
    }
    return stringList1;
  }

  public static List<string> smethod_9(
    string string_0,
    string string_1,
    string string_2,
    int int_0)
  {
    List<string> stringList = new List<string>();
    try
    {
      GClass24 gclass24 = new GClass24(string_0, string_1, string_2, int_0);
      int num = 1;
      string input = gclass24.method_0("https://mbasic.facebook.com/messages/");
      string str1;
      do
      {
        MatchCollection matchCollection = Regex.Matches(input, "#fua\">(.*?)<");
        for (int i = 0; i < matchCollection.Count; ++i)
        {
          try
          {
            string str2 = GClass19.smethod_65(matchCollection[i].Groups[1].Value.Replace("\"", ""));
            if (!stringList.Contains(str2))
              stringList.Add(str2);
          }
          catch
          {
          }
        }
        str1 = Regex.Match(input, "/messages/.pageNum=(.*?)\"").Value.Replace("amp;", "");
        input = gclass24.method_0("https://mbasic.facebook.com" + str1);
        ++num;
      }
      while (num < 5 && str1 != "");
    }
    catch
    {
    }
    return stringList;
  }

  public static string smethod_10(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    int int_0)
  {
    string str = "";
    try
    {
      JObject jobject = JObject.Parse(new GClass24(string_0, string_2, string_3, int_0).method_0("https://graph.facebook.com/me?fields=id,name,birthday&access_token=" + string_1));
      return jobject["id"].ToString() + "|" + jobject["birthday"].ToString() + "|" + jobject["name"].ToString();
    }
    catch
    {
      if (!Class38.smethod_21(string_0, string_1, string_2, string_3, int_0))
        str = "-1";
    }
    return str;
  }

  public static string smethod_11(string string_0, string string_1, string string_2, int int_0)
  {
    try
    {
      return Regex.Match(new GClass24(string_0, string_1, string_2, int_0).method_0("https://m.facebook.com/help/"), GClass19.smethod_58("ZHRzZyI6eyJ0b2tlbiI6IiguKj8pIg==")).Groups[1].Value;
    }
    catch
    {
      return "";
    }
  }

  public static bool smethod_12(string string_0, string string_1 = "mau.jpg")
  {
    bool flag = false;
    try
    {
      return (double) (Class38.smethod_16(new Bitmap(string_1)).Zip<bool, bool, bool>((IEnumerable<bool>) Class38.smethod_16(Class38.smethod_13(string_0)), (Func<bool, bool, bool>) ((bool_0, bool_1) => bool_0 == bool_1)).Count<bool>((Func<bool, bool>) (bool_0 => bool_0)) / 256) == 0.0;
    }
    catch
    {
      return flag;
    }
  }

  private static Bitmap smethod_13(string string_0)
  {
    byte[] buffer = new GClass24("", "", "", 0).method_3("https://graph.facebook.com/" + string_0 + "/picture?access_token=6628568379|c1e620fa708a1d5696fb991c1bde5662");
    MemoryStream memoryStream = new MemoryStream();
    memoryStream.Write(buffer, 0, Convert.ToInt32(buffer.Length));
    Bitmap bitmap = new Bitmap((Stream) memoryStream, false);
    memoryStream.Dispose();
    return bitmap;
  }

  private static Bitmap smethod_14(string string_0, string string_1)
  {
    byte[] buffer = new GClass24("", "", "", 0).method_3("https://graph.facebook.com/" + string_0 + "/picture?access_token=" + string_1);
    MemoryStream memoryStream = new MemoryStream();
    memoryStream.Write(buffer, 0, Convert.ToInt32(buffer.Length));
    Bitmap bitmap = new Bitmap((Stream) memoryStream, false);
    memoryStream.Dispose();
    return bitmap;
  }

  public static bool smethod_15(string string_0, string string_1, string string_2)
  {
    try
    {
      string address = "https://graph.facebook.com/" + string_0 + "/picture?width=736&access_token=" + string_1;
      using (WebClient webClient = new WebClient())
      {
        using (MemoryStream memoryStream = new MemoryStream(webClient.DownloadData(address)))
        {
          using (Image image = Image.FromStream((Stream) memoryStream))
          {
            string str = string_2 + "\\" + string_0;
            try
            {
              image.Save(str + ".png", ImageFormat.Png);
            }
            catch
            {
              image.Save(str + ".jpg", ImageFormat.Jpeg);
            }
          }
        }
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Error DownLoadImageByUid");
      return false;
    }
  }

  private static List<bool> smethod_16(Bitmap bitmap_0)
  {
    List<bool> boolList = new List<bool>();
    Bitmap bitmap = new Bitmap((Image) bitmap_0, new Size(16, 16));
    for (int y = 0; y < bitmap.Height; ++y)
    {
      for (int x = 0; x < bitmap.Width; ++x)
        boolList.Add((double) bitmap.GetPixel(x, y).GetBrightness() < 0.5);
    }
    return boolList;
  }

  public static string smethod_17(string string_0)
  {
    GClass24 gclass24 = new GClass24("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.0.0 Safari/537.36", "", 0);
    try
    {
      for (int index = 0; index < 3; ++index)
      {
        try
        {
          string str1 = gclass24.method_0("https://graph.facebook.com/" + string_0 + "/picture?type=normal&redirect=false");
          if (!string.IsNullOrEmpty(str1))
          {
            if (str1.Contains("height") && str1.Contains("width"))
              return "1|";
            try
            {
              string str2 = gclass24.method_0("https://graph.facebook.com/" + string_0 + "/picture?width=500&access_token=6628568379%7Cc1e620fa708a1d5696fb991c1bde5662&redirect=false");
              return str2.Contains("error") || str2.Contains(".gif") ? "0|" : "1|";
            }
            catch
            {
              return string.IsNullOrEmpty(JObject.Parse(gclass24.method_1("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){name}"))[string_0].ToString()) ? "0|" : "1|";
            }
          }
        }
        catch (Exception ex)
        {
        }
      }
    }
    catch
    {
    }
    return "2|";
  }

  public static string smethod_18(string string_0)
  {
    try
    {
      JObject jobject = JObject.Parse(new GClass23(string_3: "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_2 like Mac OS X) AppleWebKit/603.2.4 (KHTML, like Gecko) Mobile/14F89").method_1("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){name}"));
      return string.IsNullOrEmpty(jobject[string_0].ToString()) ? "" : jobject[string_0][(object) "name"].ToString();
    }
    catch
    {
    }
    return "";
  }

  public static string smethod_19(string string_0)
  {
    GClass23 gclass23 = new GClass23(string_3: "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_2 like Mac OS X) AppleWebKit/603.2.4 (KHTML, like Gecko) Mobile/14F89");
    try
    {
      JObject jobject1 = JObject.Parse(gclass23.method_1("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){name}"));
      if (string.IsNullOrEmpty(jobject1[string_0].ToString()))
        return "0|";
      string str1 = jobject1[string_0][(object) "name"].ToString();
      JObject jobject2 = JObject.Parse(gclass23.method_1("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){friends{count}}"));
      if (string.IsNullOrEmpty(jobject2[string_0].ToString()))
        return "0|";
      string str2 = jobject2[string_0][(object) "friends"][(object) "count"].ToString();
      JObject jobject3 = JObject.Parse(gclass23.method_1("https://www.facebook.com/api/graphql", "q=node(" + string_0 + "){created_time}"));
      if (string.IsNullOrEmpty(jobject3[string_0].ToString()))
        return "0|";
      string str3 = Class38.smethod_20(Convert.ToDouble(jobject3[string_0][(object) "created_time"].ToString())).ToString();
      return "1|" + str1 + "|" + str2 + "|" + str3;
    }
    catch (Exception ex)
    {
    }
    return "2|";
  }

  public static DateTime smethod_20(double double_0)
  {
    DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
    dateTime = dateTime.AddSeconds(double_0);
    return dateTime.ToLocalTime();
  }

  public static bool smethod_21(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    int int_0 = 0)
  {
    bool flag = false;
    try
    {
      return !new GClass24(string_0, string_2, string_3, int_0).method_0("https://graph.facebook.com/me?access_token=" + string_1).Contains("error");
    }
    catch
    {
      return flag;
    }
  }

  public static string smethod_22(string string_0, string string_1, string string_2, int int_0)
  {
    string str = "";
    try
    {
      str = Regex.Match(new GClass24(string_0, "", string_2, int_0).method_0("https://business.facebook.com/content_management/"), "EAAG(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
    }
    catch
    {
      if (!Class38.smethod_4(string_0, string_1, string_2, int_0).StartsWith("1|"))
        return "-1";
    }
    return str == "" && !Class38.smethod_4(string_0, string_1, string_2, int_0).StartsWith("1|") ? "-1" : str;
  }

  public static string smethod_23(string string_0)
  {
    string str = "";
    int num1 = 0;
    // ISSUE: reference to a compiler-generated method
    uint num2 = Class206.smethod_0(string_0);
    if (num2 <= 1315429348U)
    {
      if (num2 <= 822911587U)
      {
        if (num2 != 334175660U)
        {
          if (num2 != 401286136U)
          {
            if (num2 != 822911587U || !(string_0 == "4"))
              goto label_41;
          }
          else if (string_0 == "14")
          {
            str = num1 != 0 ? "device" : "Thiết bị";
            goto label_42;
          }
          else
            goto label_41;
        }
        else if (string_0 == "18")
        {
          str = num1 != 0 ? "comment" : "Bình luận";
          goto label_42;
        }
        else
          goto label_41;
      }
      else if (num2 <= 923577301U)
      {
        if (num2 != 906799682U)
        {
          if (num2 == 923577301U && string_0 == "2")
          {
            str = num1 != 0 ? "Birthday" : "Ngày sinh";
            goto label_42;
          }
          else
            goto label_41;
        }
        else if (string_0 == "3")
        {
          str = num1 != 0 ? "Image" : "Ảnh";
          goto label_42;
        }
        else
          goto label_41;
      }
      else if (num2 != 1153637868U)
      {
        if (num2 == 1315429348U && string_0 == "id_upload")
        {
          str = "Up ảnh";
          goto label_42;
        }
        else
          goto label_41;
      }
      else if (string_0 == "72h")
      {
        str = num1 != 0 ? "72 hours" : "72h";
        goto label_42;
      }
      else
        goto label_41;
    }
    else if (num2 <= 2347784130U)
    {
      if (num2 != 1718322808U)
      {
        if (num2 != 2331006511U)
        {
          if (num2 != 2347784130U || !(string_0 == "34"))
            goto label_41;
        }
        else if (string_0 == "37")
        {
          str = "Gửi OTP về mail";
          goto label_42;
        }
        else
          goto label_41;
      }
      else if (string_0 == "2fa")
      {
        str = "Có 2fa";
        goto label_42;
      }
      else
        goto label_41;
    }
    else
    {
      if (num2 <= 2364561749U)
      {
        if (num2 != 2347931225U)
        {
          if (num2 == 2364561749U && string_0 == "35")
            str = "Login Google";
          else
            goto label_41;
        }
        else if (string_0 == "26")
          str = num1 != 0 ? "Friend" : "Nhờ bạn bè";
        else
          goto label_41;
      }
      else if (num2 != 2381486463U)
      {
        if (num2 == 2517938561U && string_0 == "vhh")
          str = num1 != 0 ? "disable" : "Vô hiệu hóa";
        else
          goto label_41;
      }
      else if (string_0 == "20")
        str = num1 != 0 ? "Message" : "Tin nhắn";
      else
        goto label_41;
      goto label_42;
    }
    str = "Otp";
    goto label_42;
label_41:
    System.IO.File.AppendAllText("data\\dangcp.txt", string_0);
label_42:
    return str;
  }

  public static string smethod_24(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    int int_0)
  {
    string str1 = "";
    string str2;
    try
    {
      string string_1_1 = "email=" + WebUtility.UrlEncode(string_0) + "&pass=" + WebUtility.UrlEncode(string_1);
      GClass24 gclass24_1 = new GClass24("", string_2, string_3, int_0);
      string str3 = gclass24_1.method_1("https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", string_1_1).ToString();
      if (str3.Contains("id=\"checkpointSubmitButton\""))
      {
        if (str3.Contains("id=\"approvals_code\""))
        {
          str2 = "5|";
        }
        else
        {
          str2 = "2|";
          GClass24 gclass24_2 = new GClass24("", string_2, string_3, int_0);
          gclass24_2.method_0("https://www.facebook.com").ToString();
          string input1 = gclass24_2.method_1("https://www.facebook.com/login/device-based/regular/login/?login_attempt=1&lwv=100", string_1_1).ToString();
          string str4 = Regex.Match(input1, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
          string str5 = Regex.Match(input1, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
          string str6 = Regex.Match(input1, "name=\"nh\" value=\"(.*?)\"").Groups[1].Value;
          string str7 = Regex.Match(input1, "\"__spin_r\":(.*?),").Groups[1].Value;
          string str8 = Regex.Match(input1, "\"__spin_t\":(.*?),").Groups[1].Value;
          string string_1_2 = "jazoest=" + str5 + "&fb_dtsg=" + str4 + "&nh=" + str6 + "&submit[Continue]=Ti%E1%BA%BFp%20t%E1%BB%A5c&__user=0&__a=1&__dyn=7xe6Fo4OQ1PyUhxOnFwn84a2i5U4e1Fx-ewSwMxW0DUeUhw5cx60Vo1upE4W0OE2WxO0SobEa87i0n2US1vw4Ugao881FU3rw&__csr=&__req=5&__beoa=0&__pc=PHASED%3ADEFAULT&dpr=1&__rev=" + str7 + "&__s=op5tkm%3A2d4a9m%3A37z92b&__hsi=6789153697588537525-0&__spin_r=" + str7 + "&__spin_b=trunk&__spin_t=" + str8;
          gclass24_2.method_1("https://www.facebook.com/checkpoint/async?next=https%3A%2F%2Fwww.facebook.com%2F", string_1_2);
          string input2 = gclass24_2.method_0("https://www.facebook.com/checkpoint/?next");
          MatchCollection matchCollection = Regex.Matches(input2, "verification_method\" value=\"(.*?)\"");
          if (matchCollection.Count > 0)
          {
            for (int i = 0; i < matchCollection.Count; ++i)
              str2 = str2 + Class38.smethod_23(matchCollection[i].Groups[1].Value) + "-";
            str2 = str2.TrimEnd('-');
          }
          else if (input2.Contains("/checkpoint/dyi/?referrer=disabled_checkpoint"))
            str2 += Class38.smethod_23("vhh");
          else if (input2.Contains("captcha-recaptcha"))
            str2 += Class38.smethod_23("72h");
          else if (input2.Contains("name=\"submit[Log Out]\"") || input2.Contains("name=\"submit[__placeholder__]\""))
            str2 += "không thể xmdt";
          else if (input2.Contains("name=\"submit[Continue]\""))
            str2 += "Thiết bị";
        }
      }
      else if (str3.Contains("login_error"))
        str2 = !str3.Contains("m_login_email") ? "0|" : "3|";
      else if (str3.Contains("action_set_contact_point"))
      {
        str2 = "2|" + Class38.smethod_23("34");
      }
      else
      {
        string string_0_1 = gclass24_1.method_5();
        str2 = !Class38.smethod_4(string_0_1, string_2, string_3, int_0).StartsWith("1|") ? "2|" : str1 + "1|" + string_0_1;
      }
    }
    catch
    {
      str2 = "0|";
    }
    return str2;
  }

  public static string smethod_25(
    string string_0,
    string string_1,
    string string_2,
    string string_3,
    int int_0)
  {
    bool flag = false;
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string str4 = "";
    string str5 = "";
    string str6 = "";
    string str7 = "";
    try
    {
      GClass24 gclass24 = new GClass24("", string_2, string_3, int_0);
      if (string_1 == "")
        string_1 = "me";
      JObject jobject1 = JObject.Parse(gclass24.method_0("https://graph.facebook.com/v2.11/" + string_1 + "?fields=name,email,gender,birthday,friends.limit(0)&access_token=" + string_0));
      flag = true;
      str1 = jobject1["name"].ToString();
      try
      {
        str2 = jobject1["gender"].ToString();
      }
      catch
      {
      }
      try
      {
        str3 = jobject1["birthday"].ToString();
      }
      catch
      {
      }
      try
      {
        str5 = jobject1["email"].ToString();
      }
      catch
      {
      }
      try
      {
        str6 = jobject1["friends"][(object) "summary"][(object) "total_count"].ToString();
      }
      catch
      {
      }
      if (str6 == "")
        str6 = "0";
      JObject jobject2 = JObject.Parse(gclass24.method_0("https://graph.facebook.com/v2.11/" + string_1 + "/groups?fields=id&limit=5000&access_token=" + string_0));
      try
      {
        str7 = jobject2["data"].Count<JToken>().ToString() ?? "";
      }
      catch
      {
      }
      if (str7 == "")
        str7 = "0";
    }
    catch
    {
      if (!Class38.smethod_21("", string_0, "", ""))
        return "-1";
    }
    return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}", (object) flag, (object) str1, (object) str2, (object) str3, (object) str4, (object) str5, (object) str6, (object) str7);
  }

  public static string smethod_26(string string_0, string string_1, string string_2, int int_0)
  {
    bool flag = false;
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string str4 = "";
    string str5 = "";
    string str6 = "";
    string str7 = "";
    string str8 = "";
    try
    {
      string str9 = Regex.Match(string_0 + ";", "c_user=(.*?);").Groups[1].Value;
      GClass24 gclass24 = new GClass24(string_0, string_1, string_2, int_0);
      string string_0_1 = "https://m.facebook.com/help/";
      string input = gclass24.method_0(string_0_1);
      string newValue = Regex.Match(input, "dtsg\":{\"token\":\"(.*?)\"").Groups[1].Value;
      str1 = Regex.Match(input, "\"NAME\":\"(.*?)\"").Groups[1].Value;
      str1 = WebUtility.HtmlDecode(str1);
      string string_1_1 = GClass19.smethod_58("LS0tLS0tV2ViS2l0Rm9ybUJvdW5kYXJ5MnlnMEV6RHBTWk9DWGdCUgpDb250ZW50LURpc3Bvc2l0aW9uOiBmb3JtLWRhdGE7IG5hbWU9ImZiX2R0c2ciCgp7e2ZiX2R0c2d9fQotLS0tLS1XZWJLaXRGb3JtQm91bmRhcnkyeWcwRXpEcFNaT0NYZ0JSCkNvbnRlbnQtRGlzcG9zaXRpb246IGZvcm0tZGF0YTsgbmFtZT0icSIKCm5vZGUoe3t1aWR9fSl7ZnJpZW5kc3tjb3VudH0sc3Vic2NyaWJlcnN7Y291bnR9LGdyb3VwcyxjcmVhdGVkX3RpbWV9Ci0tLS0tLVdlYktpdEZvcm1Cb3VuZGFyeTJ5ZzBFekRwU1pPQ1hnQlItLQ==").Replace("{{fb_dtsg}}", newValue).Replace("{{uid}}", str9);
      JObject jobject = JObject.Parse(gclass24.method_1("https://www.facebook.com/api/graphql/", string_1_1, "multipart/form-data; boundary=----WebKitFormBoundary2yg0EzDpSZOCXgBR"));
      str6 = jobject[str9][(object) "friends"][(object) "count"].ToString();
      str7 = jobject[str9][(object) "groups"][(object) "count"].ToString();
      str8 = jobject[str9][(object) "created_time"].ToString();
      if (str6 == "")
        str6 = "0";
      if (str7 == "")
        str7 = "0";
    }
    catch
    {
      if (!Class38.smethod_4(string_0, string_1, string_2, int_0).Contains("1|"))
        return "-1";
    }
    return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}||{8}", (object) flag, (object) str1, (object) str2, (object) str3, (object) str4, (object) str5, (object) str6, (object) str7, (object) str8);
  }

  public static string smethod_27(string string_0, string string_1)
  {
    string str1 = "";
    string str2 = "";
    string str3 = "";
    string str4 = "";
    string str5 = "";
    string str6 = "";
    string str7 = "";
    string str8 = "";
    string str9 = "";
    bool flag;
    try
    {
      JObject jobject = JObject.Parse(new GClass24("c_user=" + Regex.Match(string_1 + ";", "c_user=(.*?);").Groups[1].Value + "; xs=xs=" + Regex.Match(string_1 + ";", "xs=(.*?);").Groups[1].Value + ";" + " useragent=TW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzc0LjAuMjMwMi42MSBTYWZhcmkvNTM3LjM2", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:50.0) Gecko/20100101 Firefox/50.0", "", 0).method_1("https://www.facebook.com/api/graphql", "q=user(" + string_0 + ")%7Bfriends%7Bcount%7D%2Cgroups%7Bcount%7D%2Cid%2Cname%2Cgender%2Cbirthday%2Cemail_addresses%2Cusername%7D"));
      str6 = jobject[string_0][(object) "friends"][(object) "count"].ToString();
      str7 = jobject[string_0][(object) "groups"][(object) "count"].ToString();
      str1 = jobject[string_0][(object) "name"].ToString();
      str3 = jobject[string_0][(object) "birthday"] != null ? jobject[string_0][(object) "birthday"].ToString() : "";
      str2 = jobject[string_0][(object) "gender"].ToString().ToLower();
      if (str6 == "")
        str6 = "0";
      if (str7 == "")
        str7 = "0";
      flag = true;
    }
    catch
    {
      if (!Class38.smethod_4(string_1, "", "", 0).StartsWith("1|"))
        return "-1";
      flag = false;
    }
    return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}", (object) flag, (object) str1, (object) str2, (object) str3, (object) str4, (object) str5, (object) str6, (object) str7, (object) str8, (object) str9);
  }

  public static bool smethod_28(string string_0, string string_1)
  {
    try
    {
      string address = "https://graph.facebook.com/" + string_0 + "/picture?width=736&access_token=6628568379|c1e620fa708a1d5696fb991c1bde5662";
      using (WebClient webClient = new WebClient())
      {
        using (MemoryStream memoryStream = new MemoryStream(webClient.DownloadData(address)))
        {
          using (Image image = Image.FromStream((Stream) memoryStream))
          {
            string str = string_1 + "\\" + string_0;
            try
            {
              image.Save(str + ".png", ImageFormat.Png);
            }
            catch
            {
              image.Save(str + ".jpg", ImageFormat.Jpeg);
            }
          }
        }
      }
      return true;
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex, "Error DownLoadImageByUid");
      return false;
    }
  }
}
