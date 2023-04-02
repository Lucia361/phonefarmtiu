// Decompiled with JetBrains decompiler
// Type: GClass32
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Newtonsoft.Json;

public class GClass32
{
  [JsonProperty("id")]
  public int Int32_0 { get; set; }

  [JsonProperty("object_id")]
  public string String_0 { get; set; }

  [JsonProperty("type")]
  public string String_1 { get; set; }

  [JsonProperty("quantity")]
  private int Int32_1 { get; set; }

  [JsonProperty("count_is_run")]
  private int Int32_2 { get; set; }

  [JsonProperty("reaction")]
  public string String_2 { get; set; }

  [JsonProperty("comment")]
  public string String_3 { get; set; }

  [JsonProperty("created_at")]
  private string String_4 { get; set; }

  [JsonProperty("updated_at")]
  private string String_5 { get; set; }
}
