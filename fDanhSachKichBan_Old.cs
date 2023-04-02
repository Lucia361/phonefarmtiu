// Decompiled with JetBrains decompiler
// Type: fDanhSachKichBan_Old
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class fDanhSachKichBan_Old : Form
{
  private string string_0 = "";
  private IContainer icontainer_0 = (IContainer) null;
  private ToolTip toolTip_0;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private GroupBox groupBox1;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button button1;
  private GroupBox groupBox2;
  public DataGridView dtgvKichBan;
  public DataGridView dtgvHanhDong;
  private ContextMenuStrip contextMenuStrip1;
  private ToolStripMenuItem toolStripMenuItem_0;
  private ToolStripMenuItem toolStripMenuItem_1;
  private ToolStripMenuItem toolStripMenuItem_2;
  private ToolStripMenuItem toolStripMenuItem_3;
  private Button button3;
  private Button button2;
  private ContextMenuStrip contextMenuStrip1_1;
  private ToolStripMenuItem toolStripMenuItem1;
  private ToolStripMenuItem toolStripMenuItem3;
  private ToolStripMenuItem toolStripMenuItem4;
  private ToolStripMenuItem toolStripMenuItem2;
  private Panel panel1;
  private SplitContainer splitContainer1;
  private DataGridViewTextBoxColumn cStt;
  private DataGridViewTextBoxColumn cId_KichBan;
  private DataGridViewTextBoxColumn cTenKichBan;
  private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
  private DataGridViewTextBoxColumn cId_HanhDong;
  private DataGridViewTextBoxColumn cTenHanhDong;
  private IContainer components;
  private Button button4;
  private Button button5;
  private DataGridViewTextBoxColumn cTheLoai;

  public fDanhSachKichBan_Old(string string_1)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    GClass35.smethod_6(this.contextMenuStrip1);
    GClass35.smethod_6(this.contextMenuStrip1_1);
    this.string_0 = string_1;
  }

  private void fDanhSachKichBan_Old_Load(object sender, EventArgs e) => this.method_6(this.string_0);

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void toolStripMenuItem_1_Click(object sender, EventArgs e) => this.method_8();

  private void toolStripMenuItem_2_Click(object sender, EventArgs e) => this.method_7();

  private void toolStripMenuItem4_Click(object sender, EventArgs e) => this.method_3();

  public void method_0(ref DataGridView dataGridView_0, int int_0, int int_1)
  {
    for (int int_1_1 = 1; int_1_1 < dataGridView_0.Columns.Count; ++int_1_1)
    {
      string object_0 = Class14.smethod_2(dataGridView_0, int_0, int_1_1);
      Class14.smethod_4(dataGridView_0, int_0, int_1_1, (object) Class14.smethod_2(dataGridView_0, int_1, int_1_1));
      Class14.smethod_4(dataGridView_0, int_1, int_1_1, (object) object_0);
    }
  }

  private void button2_Click(object sender, EventArgs e)
  {
    int index = this.dtgvHanhDong.SelectedRows[0].Index;
    if (index == 0)
      return;
    string string_0 = Class14.smethod_3(this.dtgvHanhDong, index - 1, "cId_HanhDong");
    string string_1 = Class14.smethod_3(this.dtgvHanhDong, index, "cId_HanhDong");
    if (!(string_0 + string_1 != ""))
      return;
    if (Class205.smethod_22(string_0, string_1))
    {
      this.method_0(ref this.dtgvHanhDong, index, index - 1);
      this.dtgvHanhDong.Rows[index - 1].Selected = true;
    }
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
  }

  private void button3_Click(object sender, EventArgs e)
  {
    int index = this.dtgvHanhDong.SelectedRows[0].Index;
    if (index == this.dtgvHanhDong.RowCount - 1)
      return;
    string string_0 = Class14.smethod_3(this.dtgvHanhDong, index + 1, "cId_HanhDong");
    string string_1 = Class14.smethod_3(this.dtgvHanhDong, index, "cId_HanhDong");
    if (!(string_0 + string_1 != ""))
      return;
    if (Class205.smethod_22(string_0, string_1))
    {
      this.method_0(ref this.dtgvHanhDong, index, index + 1);
      this.dtgvHanhDong.Rows[index + 1].Selected = true;
    }
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
  }

  private void toolStripMenuItem_0_Click(object sender, EventArgs e) => this.method_9();

  private void toolStripMenuItem1_Click(object sender, EventArgs e) => this.method_4();

  private void toolStripMenuItem_3_Click(object sender, EventArgs e) => this.method_10();

  private void dtgvKichBan_CellClick(object sender, DataGridViewCellEventArgs e)
  {
    if (e.RowIndex <= -1)
      return;
    this.method_2();
  }

  private void toolStripMenuItem3_Click(object sender, EventArgs e) => this.method_5();

  private void toolStripMenuItem2_Click(object sender, EventArgs e) => this.method_1();

  private void dtgvHanhDong_KeyDown(object sender, KeyEventArgs e)
  {
    switch (e.KeyCode)
    {
      case Keys.Insert:
      case Keys.F1:
        this.method_4();
        break;
      case Keys.Delete:
        this.method_3();
        break;
      case Keys.D:
        if (e.Modifiers != Keys.Control)
          break;
        this.method_1();
        break;
      case Keys.F2:
        this.method_5();
        break;
      case Keys.F5:
        this.method_2();
        break;
    }
  }

  private void method_1()
  {
    try
    {
      if (this.dtgvHanhDong.RowCount == 0)
      {
        GClass14.smethod_0((object) "Vui lòng thêm hành động trước!", 3);
      }
      else
      {
        DataGridViewRow selectedRow = this.dtgvHanhDong.SelectedRows[0];
        string string_0 = selectedRow.Cells["cId_HanhDong"].Value.ToString();
        string str1 = selectedRow.Cells["cTenHanhDong"].Value.ToString();
        string str2 = str1 + " - Copy";
        int num = 2;
        while (Class205.smethod_17(str2))
          str2 = str1 + string.Format(" - Copy ({0})", (object) num++);
        if (Class205.smethod_20(string_0, str2))
        {
          DataTable dataTable = Class205.smethod_16();
          this.dtgvHanhDong.Rows.Add((object) (this.dtgvHanhDong.RowCount + 1), dataTable.Rows[0]["Id_HanhDong"], dataTable.Rows[0]["TenHanhDong"], dataTable.Rows[0]["MoTa"]);
          this.dtgvHanhDong.Rows[this.dtgvHanhDong.RowCount - 1].Selected = true;
          this.dtgvHanhDong.CurrentCell = this.dtgvHanhDong.Rows[this.dtgvHanhDong.RowCount - 1].Cells["cTenHanhDong"];
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
      }
    }
    catch
    {
    }
  }

  private void method_2()
  {
    try
    {
      this.dtgvHanhDong.Rows.Clear();
      if (this.dtgvKichBan.RowCount == 0)
        return;
      DataTable dataTable = Class205.smethod_14(this.dtgvKichBan.SelectedRows[0].Cells["cId_KichBan"].Value.ToString());
      for (int index = 0; index < dataTable.Rows.Count; ++index)
        this.dtgvHanhDong.Rows.Add((object) (this.dtgvHanhDong.RowCount + 1), dataTable.Rows[index]["Id_HanhDong"], dataTable.Rows[index]["TenHanhDong"], dataTable.Rows[index]["MoTa"]);
    }
    catch
    {
    }
  }

  private void method_3()
  {
    try
    {
      if (this.dtgvHanhDong.RowCount == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng thêm hành động trước!"), 3);
      }
      else
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có chắc muốn xóa hoạt động này?")) != DialogResult.Yes)
          return;
        DataGridViewRow selectedRow = this.dtgvHanhDong.SelectedRows[0];
        if (Class205.smethod_23(selectedRow.Cells["cId_HanhDong"].Value.ToString()))
        {
          for (int index = selectedRow.Index; index < this.dtgvHanhDong.Rows.Count - 1; ++index)
            this.method_0(ref this.dtgvHanhDong, index, index + 1);
          this.dtgvHanhDong.Rows.RemoveAt(this.dtgvHanhDong.Rows.Count - 1);
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
    }
  }

  private void method_4()
  {
    try
    {
      if (this.dtgvKichBan.RowCount == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng thêm kịch bản trước!"), 3);
      }
      else
      {
        string str = this.dtgvKichBan.SelectedRows[0].Cells["cId_KichBan"].Value.ToString();
        int count1 = Class205.smethod_14(str).Rows.Count;
        GClass19.smethod_35((Form) new fThemHanhDong(str));
        DataTable dataTable = Class205.smethod_14(str);
        int count2 = dataTable.Rows.Count;
        if (count2 <= count1)
          return;
        this.dtgvHanhDong.Rows.Add((object) (this.dtgvHanhDong.RowCount + 1), dataTable.Rows[count2 - 1]["Id_HanhDong"], dataTable.Rows[count2 - 1]["TenHanhDong"], dataTable.Rows[count2 - 1]["MoTa"]);
        this.dtgvHanhDong.Rows[this.dtgvHanhDong.RowCount - 1].Selected = true;
        this.dtgvHanhDong.CurrentCell = this.dtgvHanhDong.Rows[this.dtgvHanhDong.RowCount - 1].Cells["cTenHanhDong"];
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
    }
  }

  private void method_5()
  {
    try
    {
      if (this.dtgvHanhDong.RowCount == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng thêm hành động trước!"), 3);
      }
      else
      {
        DataGridViewRow selectedRow = this.dtgvHanhDong.SelectedRows[0];
        string str = selectedRow.Cells["cId_HanhDong"].Value.ToString();
        DataTable dataTable1 = Class205.smethod_15(str);
        Form form_0 = (Form) null;
        string s = dataTable1.Rows[0]["TenTuongTac"].ToString();
        // ISSUE: reference to a compiler-generated method
        switch (Class206.smethod_0(s))
        {
          case 18769620:
            if (s == "HDNhanTinPage")
            {
              form_0 = (Form) new fHDNhanTinPage("", 1, str);
              break;
            }
            break;
          case 34992592:
            if (s == "HDXemWatchTheoTuKhoa")
            {
              form_0 = (Form) new fHDXemWatchTheoTuKhoa("", 1, str);
              break;
            }
            break;
          case 105160162:
            if (s == "HDDangBaiTuong")
            {
              form_0 = (Form) new fHDDangBaiTuong("", 1, str);
              break;
            }
            break;
          case 115118702:
            if (s == "HDSpamNhom")
            {
              form_0 = (Form) new fHDSpamNhom("", 1, str);
              break;
            }
            break;
          case 152310871:
            if (s == "HDUpCover")
            {
              form_0 = (Form) new fHDUpCover("", 1, str);
              break;
            }
            break;
          case 155455705:
            if (s == "HDDangBaiNhom")
            {
              form_0 = (Form) new fHDDangBaiNhom("", 1, str);
              break;
            }
            break;
          case 167896116:
            if (s == "HDTuongTacBaiVietTuKhoa")
            {
              form_0 = (Form) new fHDTuongTacBaiVietTuKhoa("", 1, str);
              break;
            }
            break;
          case 183716342:
            if (s == "HDTuongTacBaiVietIA")
            {
              form_0 = (Form) new fHDTuongTacBaiVietIA("", 1, str);
              break;
            }
            break;
          case 271171672:
            if (s == "HDTruyCapWebsite")
            {
              form_0 = (Form) new fHDTruyCapWebsite("", 1, str);
              break;
            }
            break;
          case 311671696:
            if (s == "HDKetBanGoiY")
            {
              form_0 = (Form) new fHDKetBanGoiY("", 1, str);
              break;
            }
            break;
          case 327820411:
            if (s == "HDBuffTinNhanProfile")
            {
              form_0 = (Form) new fHDBuffTinNhanProfile("", 1, str);
              break;
            }
            break;
          case 444757497:
            if (s == "HDKetBanTepUidNew")
            {
              form_0 = (Form) new fHDKetBanTepUidNew("", 1, str);
              break;
            }
            break;
          case 516966741:
            if (s == "HDDangReel")
            {
              form_0 = (Form) new fHDDangReel("", 1, str);
              break;
            }
            break;
          case 523366477:
            if (s == "HDBuffFollowUID")
            {
              form_0 = (Form) new fHDBuffFollowUID("", 1, str);
              break;
            }
            break;
          case 532292684:
            if (s == "HDBuffLikeComment")
            {
              form_0 = (Form) new fHDBuffLikeComment("", 1, str);
              break;
            }
            break;
          case 551470432:
            if (s == "HDSpamBanBe")
            {
              form_0 = (Form) new fHDSpamBanBe("", 1, str);
              break;
            }
            break;
          case 582938346:
            if (s == "HDXemStory")
            {
              form_0 = (Form) new fHDXemStory("", 1, str);
              break;
            }
            break;
          case 745266353:
            if (s == "HDXemReel")
            {
              form_0 = (Form) new fHDXemReel("", 1, str);
              break;
            }
            break;
          case 786238800:
            if (s == "HDXemWatch")
            {
              form_0 = (Form) new fHDXemWatch("", 1, str);
              break;
            }
            break;
          case 852508141:
            if (s == "HDKetBanTepUid")
            {
              form_0 = (Form) new fHDKetBanTepUid("", 1, str);
              break;
            }
            break;
          case 894688135:
            if (s == "HDTuongTacReelChiDinh")
            {
              form_0 = (Form) new fHDTuongTacReelChiDinh("", 1, str);
              break;
            }
            break;
          case 1526944464:
            if (s == "HDTuongTacBanBe")
            {
              form_0 = (Form) new fHDTuongTacBanBe("", 1, str);
              break;
            }
            break;
          case 1577102954:
            if (s == "HDSpamNewfeed")
            {
              form_0 = (Form) new fHDSpamNewfeed("", 1, str);
              break;
            }
            break;
          case 1613435342:
            if (s == "HDChiaSeLivestream")
            {
              form_0 = (Form) new fHDChiaSeLivestream("", 1, str);
              break;
            }
            break;
          case 1640113110:
            if (s == "HDKetBanVoiBanCuaBanBe")
            {
              form_0 = (Form) new fHDKetBanVoiBanCuaBanBe("", 1, str);
              break;
            }
            break;
          case 1653385921:
            if (s == "HDNghiGiaiLao")
            {
              form_0 = (Form) new fHDNghiGiaiLao("", 1, str);
              break;
            }
            break;
          case 1697418988:
            if (s == "HDTimKiemGoogle")
            {
              form_0 = (Form) new fHDTimKiemGoogle("", 1, str);
              break;
            }
            break;
          case 1780458336:
            if (s == "HDDangBaiPage")
            {
              form_0 = (Form) new fHDDangBaiPage("", 1, str);
              break;
            }
            break;
          case 1807592900:
            if (s == "HDSeedingByVideo")
            {
              form_0 = (Form) new fHDSeedingByVideo("", 1, str);
              break;
            }
            break;
          case 1810740917:
            if (s == "HDNhanTinBanBe")
            {
              form_0 = (Form) new fHDNhanTinBanBe("", 1, str);
              break;
            }
            break;
          case 1823818229:
            if (s == "HDUpAvatar")
            {
              form_0 = (Form) new fHDUpAvatar("", 1, str);
              break;
            }
            break;
          case 1884305945:
            if (s == "HDDocThongBao")
            {
              form_0 = (Form) new fHDDocThongBao("", 1, str);
              break;
            }
            break;
          case 1906272025:
            if (s == "HDKetBanVoiBanBeCuaUid")
            {
              form_0 = (Form) new fHDKetBanVoiBanBeCuaUid("", 1, str);
              break;
            }
            break;
          case 1952866892:
            if (s == "HDKetBanTheoTuKhoa")
            {
              form_0 = (Form) new fHDKetBanTheoTuKhoa("", 1, str);
              break;
            }
            break;
          case 1984335833:
            if (s == "HDBaiVietBanBe")
            {
              form_0 = (Form) new fHDBaiVietBanBe("", 1, str);
              break;
            }
            break;
          case 2004466602:
            if (s == "HDDoiTen")
            {
              form_0 = (Form) new fHDDoiTen("", 1, str);
              break;
            }
            break;
          case 2030328732:
            if (s == "HDOnOff2FA")
            {
              form_0 = (Form) new fHDOnOff2FA("", 1, str);
              break;
            }
            break;
          case 2065195933:
            if (s == "HDBuffFollowLikePage")
            {
              form_0 = (Form) new fHDBuffFollowLikePage("", 1, str);
              break;
            }
            break;
          case 2081285240:
            if (s == "HDChocBanBe")
            {
              form_0 = (Form) new fHDChocBanBe("", 1, str);
              break;
            }
            break;
          case 2117563667:
            if (s == "HDKhangSpam")
            {
              form_0 = (Form) new fHDKhangSpam("", 1, str);
              break;
            }
            break;
          case 2149398608:
            if (s == "HDBuffLikePage")
            {
              form_0 = (Form) new fHDBuffLikePage("", 1, str);
              break;
            }
            break;
          case 2277183375:
            if (s == "HDRoiNhom")
            {
              form_0 = (Form) new fHDRoiNhom("", 1, str);
              break;
            }
            break;
          case 2421286761:
            if (s == "HDBaiVietNhom")
            {
              form_0 = (Form) new fHDBaiVietNhom("", 1, str);
              break;
            }
            break;
          case 2433475627:
            if (s == "HDChaySeeding")
            {
              form_0 = (Form) new fHDChaySeeding("", 1, str);
              break;
            }
            break;
          case 2437988220:
            if (s == "HDMoiBanBeLikePage")
            {
              form_0 = (Form) new fHDMoiBanBeLikePage("", 1, str);
              break;
            }
            break;
          case 2540878680:
            if (s == "HDThamGiaNhomTuKhoa")
            {
              form_0 = (Form) new fHDThamGiaNhomTuKhoa("", 1, str);
              break;
            }
            break;
          case 2550743232:
            if (s == "HDTuongTacWall")
            {
              form_0 = (Form) new fHDTuongTacWall("", 1, str);
              break;
            }
            break;
          case 2553440797:
            if (s == "HDCapNhatThongTin")
            {
              form_0 = (Form) new fHDCapNhatThongTin("", 1, str);
              break;
            }
            break;
          case 2703861858:
            if (s == "HDChucMungSinhNhat")
            {
              form_0 = (Form) new fHDChucMungSinhNhat("", 1, str);
              break;
            }
            break;
          case 2735851020:
            if (s == "HDBaiVietNewsfeedv2")
            {
              form_0 = (Form) new fHDBaiVietNewsfeedv2("", 1, str);
              break;
            }
            break;
          case 2821037716:
            if (s == "HDHuyKetBan")
            {
              form_0 = (Form) new fHDHuyKetBan("", 1, str);
              break;
            }
            break;
          case 2837141903:
            if (s == "HDBaiVietFanpage")
            {
              form_0 = (Form) new fHDBaiVietFanpage("", 1, str);
              break;
            }
            break;
          case 2862981448:
            if (s == "HDCauHinhTaiKhoan")
            {
              form_0 = (Form) new fHDCauHinhTaiKhoan("", 1, str);
              break;
            }
            break;
          case 2887418612:
            if (s == "HDDangStory_Old")
            {
              form_0 = (Form) new fHDDangStory("", 1, str);
              break;
            }
            break;
          case 2889092958:
            if (s == "HDXemWatch_Old")
            {
              form_0 = (Form) new fHDXemWatch_Old("", 1, str);
              break;
            }
            break;
          case 2924758840:
            if (s == "HDMoiBanBeVaoNhom")
            {
              form_0 = (Form) new fHDMoiBanBeVaoNhom("", 1, str);
              break;
            }
            break;
          case 2944435598:
            if (s == "HDThamGiaNhomUid")
            {
              form_0 = (Form) new fHDThamGiaNhomUid("", 1, str);
              break;
            }
            break;
          case 3010844127:
            if (s == "HDXoaReel")
            {
              form_0 = (Form) new fHDXoaReel("", 1, str);
              break;
            }
            break;
          case 3035546143:
            if (s == "HDTuongTacNewsfeed")
            {
              form_0 = (Form) new fHDTuongTacNewsfeed("", 1, str);
              break;
            }
            break;
          case 3094399544:
            if (s == "HDDongBoDanhBa")
            {
              form_0 = (Form) new fHDDongBoDanhBa("", 1, str);
              break;
            }
            break;
          case 3099572506:
            if (s == "HDDangXuatThietBiCu")
            {
              form_0 = (Form) new fHDDangXuatThietBiCu("", 1, str);
              break;
            }
            break;
          case 3102074063:
            if (s == "HDTuongTacVideo")
            {
              form_0 = (Form) new fHDTuongTacVideo("", 1, str);
              break;
            }
            break;
          case 3182739171:
            if (s == "HDTuongTacBaiVietChiDinh")
            {
              form_0 = (Form) new fHDTuongTacBaiVietChiDinh("", 1, str);
              break;
            }
            break;
          case 3255732838:
            if (s == "HDDoiMatKhau")
            {
              form_0 = (Form) new fHDDoiMatKhau("", 1, str);
              break;
            }
            break;
          case 3375859832:
            if (s == "HDDanhGiaPage")
            {
              form_0 = (Form) new fHDDanhGiaPage("", 1, str);
              break;
            }
            break;
          case 3495710863:
            if (s == "HDShareBaiNangCao")
            {
              form_0 = (Form) new fHDShareBaiNangCao("", 1, str);
              break;
            }
            break;
          case 3503341118:
            if (s == "HDTuongTacNhom")
            {
              form_0 = (Form) new fHDTuongTacNhom_1("", 1, str);
              break;
            }
            break;
          case 3550581772:
            if (s == "HDPhanHoiTinNhan")
            {
              form_0 = (Form) new fHDPhanHoiTinNhan("", 1, str);
              break;
            }
            break;
          case 3598280146:
            if (s == "HDKetBanNewfeed")
            {
              form_0 = (Form) new fHDKetBanNewfeed("", 1, str);
              break;
            }
            break;
          case 3609367991:
            if (s == "HDAddMail")
            {
              form_0 = (Form) new fHDAddMail("", 1, str);
              break;
            }
            break;
          case 3671364376:
            if (s == "HDThamGiaNhomGoiY")
            {
              form_0 = (Form) new fHDThamGiaNhomGoiY("", 1, str);
              break;
            }
            break;
          case 3677432718:
            if (s == "HDDangStory")
            {
              form_0 = (Form) new fHDDangStory("", 1, str);
              break;
            }
            break;
          case 3742679556:
            if (s == "HDBaiVietNewsfeed")
            {
              form_0 = (Form) new fHDBaiVietNewsfeed("", 1, str);
              break;
            }
            break;
          case 3744161854:
            if (s == "HDTuongTacNhomV2")
            {
              form_0 = (Form) new fHDTuongTacNhom("", 1, str);
              break;
            }
            break;
          case 3779638787:
            if (s == "HDBackupData")
            {
              form_0 = (Form) new fHDBackupData("", 1, str);
              break;
            }
            break;
          case 3877387086:
            if (s == "HDTuongTacLivestream")
            {
              form_0 = (Form) new fHDTuongTacLivestream("", 1, str);
              break;
            }
            break;
          case 3917587807:
            if (s == "HDHuyLoiMoiKetBan")
            {
              form_0 = (Form) new fHDHuyLoiMoiKetBan("", 1, str);
              break;
            }
            break;
          case 4033341327:
            if (s == "HDVerifyAccount")
            {
              form_0 = (Form) new fHDVerifyAccount("", 1, str);
              break;
            }
            break;
          case 4062736188:
            if (s == "HDXoaSdt")
            {
              form_0 = (Form) new fHDXoaSdt("", 1, str);
              break;
            }
            break;
          case 4080982511:
            if (s == "HDTuongTacPage")
            {
              form_0 = (Form) new fHDTuongTacPage("", 1, str);
              break;
            }
            break;
          case 4095834327:
            if (s == "HDXacNhanKetBan")
            {
              form_0 = (Form) new fHDXacNhanKetBan("", 1, str);
              break;
            }
            break;
          case 4189681400:
            if (s == "HDSpamBaiViet")
            {
              form_0 = (Form) new fHDSpamBaiViet("", 1, str);
              break;
            }
            break;
          case 4226158249:
            if (s == "HDKetBanThanhVienNhom")
            {
              form_0 = (Form) new fHDKetBanThanhVienNhom("", 1, str);
              break;
            }
            break;
        }
        if (form_0 != null)
          GClass19.smethod_35(form_0);
        DataTable dataTable2 = Class205.smethod_15(str);
        Class14.Status(this.dtgvHanhDong, selectedRow.Index, "cTenHanhDong", (object) dataTable2.Rows[0]["TenHanhDong"].ToString());
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
    }
  }

  private void dtgvKichBan_KeyDown(object sender, KeyEventArgs e)
  {
    switch (e.KeyCode)
    {
      case Keys.Insert:
      case Keys.F1:
        this.method_9();
        break;
      case Keys.Delete:
        this.method_7();
        break;
      case Keys.D:
        if (e.Modifiers != Keys.Control)
          break;
        this.method_10();
        break;
      case Keys.F2:
        this.method_8();
        break;
      case Keys.F5:
        this.method_6();
        break;
    }
  }

  private void method_6(string string_1 = "")
  {
    try
    {
      this.dtgvKichBan.Rows.Clear();
      DataTable dataTable = Class205.smethod_4();
      if (dataTable.Rows.Count > 0)
      {
        for (int index = 0; index < dataTable.Rows.Count; ++index)
        {
          DataRow row = dataTable.Rows[index];
          this.dtgvKichBan.Rows.Add((object) (index + 1), row["Id_KichBan"], row["TenKichBan"]);
        }
      }
      if (string_1 != "")
      {
        for (int index = 0; index < this.dtgvKichBan.RowCount; ++index)
        {
          if (Class14.smethod_3(this.dtgvKichBan, index, "cId_KichBan") == string_1)
          {
            this.dtgvKichBan.Rows[index].Selected = true;
            break;
          }
        }
      }
      this.method_2();
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
    }
  }

  private void method_7()
  {
    try
    {
      if (this.dtgvKichBan.RowCount == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng thêm kịch bản trước!"), 3);
      }
      else
      {
        if (GClass14.smethod_1(GClass35.smethod_0("Bạn có chắc muốn xóa kịch bản này?")) != DialogResult.Yes)
          return;
        DataGridViewRow selectedRow = this.dtgvKichBan.SelectedRows[0];
        if (Class205.smethod_11(selectedRow.Cells["cId_KichBan"].Value.ToString()))
        {
          for (int index = selectedRow.Index; index < this.dtgvKichBan.Rows.Count - 1; ++index)
            this.method_0(ref this.dtgvKichBan, index, index + 1);
          this.dtgvKichBan.Rows.RemoveAt(this.dtgvKichBan.Rows.Count - 1);
          this.method_2();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
    }
  }

  private void method_8()
  {
    try
    {
      if (this.dtgvKichBan.RowCount == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng thêm kịch bản trước!"), 3);
      }
      else
      {
        DataGridViewRow selectedRow = this.dtgvKichBan.SelectedRows[0];
        string str = selectedRow.Cells["cId_KichBan"].Value.ToString();
        GClass19.smethod_35((Form) new fThemKichBan(1, str));
        string object_0 = Class205.smethod_2(str).Rows[0]["TenKichBan"].ToString();
        Class14.Status(this.dtgvKichBan, selectedRow.Index, "cTenKichBan", (object) object_0);
      }
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
    }
  }

  private void method_9()
  {
    try
    {
      string str1 = "";
      try
      {
        str1 = Class205.smethod_5().Rows[0]["Id_KichBan"].ToString();
      }
      catch
      {
      }
      GClass19.smethod_35((Form) new fThemKichBan(0));
      DataTable dataTable = Class205.smethod_5();
      string str2 = "";
      try
      {
        str2 = dataTable.Rows[0]["Id_KichBan"].ToString();
      }
      catch
      {
      }
      if (!(str1 != str2))
        return;
      this.dtgvKichBan.Rows.Add((object) (this.dtgvKichBan.RowCount + 1), dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
      this.dtgvKichBan.Rows[this.dtgvKichBan.RowCount - 1].Selected = true;
      this.dtgvKichBan.CurrentCell = this.dtgvKichBan.Rows[this.dtgvKichBan.RowCount - 1].Cells["cTenKichBan"];
      this.method_2();
    }
    catch (Exception ex)
    {
      GClass19.smethod_79((GClass18) null, ex);
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
    }
  }

  private void method_10()
  {
    try
    {
      if (this.dtgvKichBan.RowCount == 0)
      {
        GClass14.smethod_0((object) GClass35.smethod_0("Vui lòng thêm kịch bản trước!"), 3);
      }
      else
      {
        DataGridViewRow selectedRow = this.dtgvKichBan.SelectedRows[0];
        string string_0 = selectedRow.Cells["cId_KichBan"].Value.ToString();
        string str1 = selectedRow.Cells["cTenKichBan"].Value.ToString();
        string str2 = str1 + " - Copy";
        int num = 2;
        while (Class205.smethod_8(str2))
          str2 = str1 + string.Format(" - Copy ({0})", (object) num++);
        if (Class205.smethod_12(string_0, str2))
        {
          DataTable dataTable = Class205.smethod_5();
          this.dtgvKichBan.Rows.Add((object) (this.dtgvKichBan.RowCount + 1), dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
          this.dtgvKichBan.Rows[this.dtgvKichBan.RowCount - 1].Selected = true;
          this.dtgvKichBan.CurrentCell = this.dtgvKichBan.Rows[this.dtgvKichBan.RowCount - 1].Cells["cTenKichBan"];
          this.method_2();
        }
        else
          GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi, vui lòng thử lại sau!"), 2);
      }
    }
    catch
    {
    }
  }

  private void dtgvKichBan_KeyUp(object sender, KeyEventArgs e)
  {
    Keys keyCode = e.KeyCode;
    if (keyCode != Keys.Up && keyCode != Keys.Down)
      return;
    this.method_2();
  }

  private void fDanhSachKichBan_Old_Paint(object sender, PaintEventArgs e)
  {
  }

  private void panel1_Paint(object sender, PaintEventArgs e)
  {
    if (this.panel1.BorderStyle != BorderStyle.FixedSingle)
      return;
    int num1 = 1;
    int num2 = 0;
    using (Pen pen1 = new Pen(Color.DarkViolet, 1f))
    {
      Graphics graphics = e.Graphics;
      Pen pen2 = pen1;
      int x = num2;
      int y = num2;
      Size clientSize = this.panel1.ClientSize;
      int width = clientSize.Width - num1;
      clientSize = this.panel1.ClientSize;
      int height = clientSize.Height - num1;
      Rectangle rect = new Rectangle(x, y, width, height);
      graphics.DrawRectangle(pen2, rect);
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.icontainer_0 != null)
      this.icontainer_0.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fDanhSachKichBan_Old));
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    this.toolTip_0 = new ToolTip(this.components);
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.groupBox1 = new GroupBox();
    this.button4 = new Button();
    this.dtgvKichBan = new DataGridView();
    this.cStt = new DataGridViewTextBoxColumn();
    this.cId_KichBan = new DataGridViewTextBoxColumn();
    this.cTenKichBan = new DataGridViewTextBoxColumn();
    this.contextMenuStrip1 = new ContextMenuStrip(this.components);
    this.toolStripMenuItem_0 = new ToolStripMenuItem();
    this.toolStripMenuItem_1 = new ToolStripMenuItem();
    this.toolStripMenuItem_2 = new ToolStripMenuItem();
    this.toolStripMenuItem_3 = new ToolStripMenuItem();
    this.button5 = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.groupBox2 = new GroupBox();
    this.button3 = new Button();
    this.button2 = new Button();
    this.dtgvHanhDong = new DataGridView();
    this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    this.cId_HanhDong = new DataGridViewTextBoxColumn();
    this.cTenHanhDong = new DataGridViewTextBoxColumn();
    this.cTheLoai = new DataGridViewTextBoxColumn();
    this.contextMenuStrip1_1 = new ContextMenuStrip(this.components);
    this.toolStripMenuItem1 = new ToolStripMenuItem();
    this.toolStripMenuItem3 = new ToolStripMenuItem();
    this.toolStripMenuItem4 = new ToolStripMenuItem();
    this.toolStripMenuItem2 = new ToolStripMenuItem();
    this.panel1 = new Panel();
    this.splitContainer1 = new SplitContainer();
    this.pnlHeader.SuspendLayout();
    this.groupBox1.SuspendLayout();
    ((ISupportInitialize) this.dtgvKichBan).BeginInit();
    this.contextMenuStrip1.SuspendLayout();
    this.bunifuCards1.SuspendLayout();
    this.groupBox2.SuspendLayout();
    ((ISupportInitialize) this.dtgvHanhDong).BeginInit();
    this.contextMenuStrip1_1.SuspendLayout();
    this.panel1.SuspendLayout();
    this.splitContainer1.BeginInit();
    this.splitContainer1.Panel1.SuspendLayout();
    this.splitContainer1.Panel2.SuspendLayout();
    this.splitContainer1.SuspendLayout();
    this.SuspendLayout();
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 10000;
    this.toolTip_0.InitialDelay = 200;
    this.toolTip_0.ReshowDelay = 40;
    this.toolTip_0.ToolTipTitle = "Chú thích";
    this.bunifuDragControl_0.Fixed = true;
    this.bunifuDragControl_0.Horizontal = true;
    this.bunifuDragControl_0.TargetControl = (Control) this.bunifuCustomLabel1;
    this.bunifuDragControl_0.Vertical = true;
    this.bunifuCustomLabel1.BackColor = Color.Transparent;
    this.bunifuCustomLabel1.Cursor = Cursors.SizeAll;
    this.bunifuCustomLabel1.Dock = DockStyle.Fill;
    this.bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.bunifuCustomLabel1.ForeColor = Color.Black;
    this.bunifuCustomLabel1.Location = new Point(0, 0);
    this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
    this.bunifuCustomLabel1.Size = new Size(894, 37);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Quản lý kịch bản";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuCustomLabel1.Click += new EventHandler(this.bunifuCustomLabel1_Click);
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button1);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Dock = DockStyle.Fill;
    this.pnlHeader.Location = new Point(0, 0);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(894, 37);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(861, 4);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.groupBox1.BackColor = Color.White;
    this.groupBox1.Controls.Add((Control) this.button4);
    this.groupBox1.Controls.Add((Control) this.dtgvKichBan);
    this.groupBox1.Controls.Add((Control) this.button5);
    this.groupBox1.Dock = DockStyle.Fill;
    this.groupBox1.Location = new Point(0, 0);
    this.groupBox1.Margin = new Padding(3, 4, 3, 4);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Padding = new Padding(3, 4, 3, 4);
    this.groupBox1.Size = new Size(301, 610);
    this.groupBox1.TabIndex = 1;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Danh sách kịch bản";
    this.button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button4.Cursor = Cursors.Hand;
    this.button4.Image = (Image) Resources.icons8_down_arrow_32px1;
    this.button4.Location = new Point(257, 64);
    this.button4.Name = "button4";
    this.button4.Size = new Size(41, 38);
    this.button4.TabIndex = 79;
    this.button4.UseVisualStyleBackColor = true;
    this.button4.Click += new EventHandler(this.button4_Click);
    this.dtgvKichBan.AllowUserToAddRows = false;
    this.dtgvKichBan.AllowUserToDeleteRows = false;
    this.dtgvKichBan.AllowUserToResizeRows = false;
    this.dtgvKichBan.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = Color.Teal;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.dtgvKichBan.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.dtgvKichBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgvKichBan.Columns.AddRange((DataGridViewColumn) this.cStt, (DataGridViewColumn) this.cId_KichBan, (DataGridViewColumn) this.cTenKichBan);
    this.dtgvKichBan.ContextMenuStrip = this.contextMenuStrip1;
    this.dtgvKichBan.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.dtgvKichBan.Location = new Point(3, 20);
    this.dtgvKichBan.MultiSelect = false;
    this.dtgvKichBan.Name = "dtgvKichBan";
    this.dtgvKichBan.RowHeadersVisible = false;
    this.dtgvKichBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvKichBan.Size = new Size(248, 587);
    this.dtgvKichBan.TabIndex = 76;
    this.dtgvKichBan.CellClick += new DataGridViewCellEventHandler(this.dtgvKichBan_CellClick);
    this.dtgvKichBan.CellContentClick += new DataGridViewCellEventHandler(this.dtgvKichBan_CellContentClick);
    this.dtgvKichBan.KeyDown += new KeyEventHandler(this.dtgvKichBan_KeyDown);
    this.dtgvKichBan.KeyUp += new KeyEventHandler(this.dtgvKichBan_KeyUp);
    this.cStt.HeaderText = "STT";
    this.cStt.Name = "cStt";
    this.cStt.Width = 35;
    this.cId_KichBan.HeaderText = "Column1";
    this.cId_KichBan.Name = "cId_KichBan";
    this.cId_KichBan.Visible = false;
    this.cTenKichBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cTenKichBan.HeaderText = "Tên kịch bản";
    this.cTenKichBan.Name = "cTenKichBan";
    this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.toolStripMenuItem_0,
      (ToolStripItem) this.toolStripMenuItem_1,
      (ToolStripItem) this.toolStripMenuItem_2,
      (ToolStripItem) this.toolStripMenuItem_3
    });
    this.contextMenuStrip1.Name = "contextMenuStrip1";
    this.contextMenuStrip1.Size = new Size(162, 92);
    this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
    this.toolStripMenuItem_0.Size = new Size(161, 22);
    this.toolStripMenuItem_0.Text = "Thêm kịch bản";
    this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
    this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
    this.toolStripMenuItem_1.Size = new Size(161, 22);
    this.toolStripMenuItem_1.Text = "Sửa tên kịch bản";
    this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
    this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
    this.toolStripMenuItem_2.Size = new Size(161, 22);
    this.toolStripMenuItem_2.Text = "Xóa kịch bản";
    this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
    this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
    this.toolStripMenuItem_3.Size = new Size(161, 22);
    this.toolStripMenuItem_3.Text = "Nhân bản";
    this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
    this.button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button5.Cursor = Cursors.Hand;
    this.button5.Image = (Image) Resources.icons8_up_32px1;
    this.button5.Location = new Point(257, 19);
    this.button5.Name = "button5";
    this.button5.Size = new Size(41, 38);
    this.button5.TabIndex = 80;
    this.button5.UseVisualStyleBackColor = true;
    this.button5.Click += new EventHandler(this.button5_Click);
    this.bunifuCards1.BackColor = Color.White;
    this.bunifuCards1.BorderRadius = 0;
    this.bunifuCards1.BottomSahddow = true;
    this.bunifuCards1.color = Color.DarkViolet;
    this.bunifuCards1.Controls.Add((Control) this.pnlHeader);
    this.bunifuCards1.LeftSahddow = false;
    this.bunifuCards1.Location = new Point(1, 0);
    this.bunifuCards1.Name = "bunifuCards1";
    this.bunifuCards1.RightSahddow = true;
    this.bunifuCards1.ShadowDepth = 20;
    this.bunifuCards1.Size = new Size(894, 37);
    this.bunifuCards1.TabIndex = 12;
    this.groupBox2.AutoSize = true;
    this.groupBox2.BackColor = Color.White;
    this.groupBox2.Controls.Add((Control) this.button3);
    this.groupBox2.Controls.Add((Control) this.button2);
    this.groupBox2.Controls.Add((Control) this.dtgvHanhDong);
    this.groupBox2.Dock = DockStyle.Fill;
    this.groupBox2.Location = new Point(0, 0);
    this.groupBox2.Margin = new Padding(3, 4, 3, 4);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Padding = new Padding(3, 4, 3, 4);
    this.groupBox2.Size = new Size(572, 610);
    this.groupBox2.TabIndex = 1;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Danh sách hành động";
    this.groupBox2.Enter += new EventHandler(this.groupBox2_Enter);
    this.button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button3.Cursor = Cursors.Hand;
    this.button3.Image = (Image) Resources.icons8_down_arrow_32px1;
    this.button3.Location = new Point(528, 64);
    this.button3.Name = "button3";
    this.button3.Size = new Size(41, 38);
    this.button3.TabIndex = 78;
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new EventHandler(this.button3_Click);
    this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button2.Cursor = Cursors.Hand;
    this.button2.Image = (Image) Resources.icons8_up_32px1;
    this.button2.Location = new Point(528, 19);
    this.button2.Name = "button2";
    this.button2.Size = new Size(41, 38);
    this.button2.TabIndex = 78;
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new EventHandler(this.button2_Click);
    this.dtgvHanhDong.AllowUserToAddRows = false;
    this.dtgvHanhDong.AllowUserToDeleteRows = false;
    this.dtgvHanhDong.AllowUserToResizeRows = false;
    this.dtgvHanhDong.BackgroundColor = SystemColors.ButtonHighlight;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = Color.Teal;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.dtgvHanhDong.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.dtgvHanhDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dtgvHanhDong.Columns.AddRange((DataGridViewColumn) this.dataGridViewTextBoxColumn1, (DataGridViewColumn) this.cId_HanhDong, (DataGridViewColumn) this.cTenHanhDong, (DataGridViewColumn) this.cTheLoai);
    this.dtgvHanhDong.ContextMenuStrip = this.contextMenuStrip1_1;
    this.dtgvHanhDong.EditMode = DataGridViewEditMode.EditProgrammatically;
    this.dtgvHanhDong.Location = new Point(3, 20);
    this.dtgvHanhDong.MultiSelect = false;
    this.dtgvHanhDong.Name = "dtgvHanhDong";
    this.dtgvHanhDong.RowHeadersVisible = false;
    this.dtgvHanhDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    this.dtgvHanhDong.Size = new Size(531, 587);
    this.dtgvHanhDong.TabIndex = 77;
    this.dtgvHanhDong.CellContentClick += new DataGridViewCellEventHandler(this.dtgvHanhDong_CellContentClick);
    this.dtgvHanhDong.KeyDown += new KeyEventHandler(this.dtgvHanhDong_KeyDown);
    this.dataGridViewTextBoxColumn1.HeaderText = "STT";
    this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
    this.dataGridViewTextBoxColumn1.Width = 35;
    this.cId_HanhDong.HeaderText = "Column1";
    this.cId_HanhDong.Name = "cId_HanhDong";
    this.cId_HanhDong.Visible = false;
    this.cTenHanhDong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cTenHanhDong.HeaderText = "Tên hành động";
    this.cTenHanhDong.Name = "cTenHanhDong";
    this.cTheLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    this.cTheLoai.HeaderText = "Loại tương tác";
    this.cTheLoai.Name = "cTheLoai";
    this.contextMenuStrip1_1.Items.AddRange(new ToolStripItem[4]
    {
      (ToolStripItem) this.toolStripMenuItem1,
      (ToolStripItem) this.toolStripMenuItem3,
      (ToolStripItem) this.toolStripMenuItem4,
      (ToolStripItem) this.toolStripMenuItem2
    });
    this.contextMenuStrip1_1.Name = "contextMenuStrip1";
    this.contextMenuStrip1_1.Size = new Size(167, 92);
    this.toolStripMenuItem1.Name = "toolStripMenuItem1";
    this.toolStripMenuItem1.Size = new Size(166, 22);
    this.toolStripMenuItem1.Text = "Thêm hành động";
    this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
    this.toolStripMenuItem3.Name = "toolStripMenuItem3";
    this.toolStripMenuItem3.Size = new Size(166, 22);
    this.toolStripMenuItem3.Text = "Sửa hành động";
    this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
    this.toolStripMenuItem4.Name = "toolStripMenuItem4";
    this.toolStripMenuItem4.Size = new Size(166, 22);
    this.toolStripMenuItem4.Text = "Xóa hành động";
    this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
    this.toolStripMenuItem2.Name = "toolStripMenuItem2";
    this.toolStripMenuItem2.Size = new Size(166, 22);
    this.toolStripMenuItem2.Text = "Nhân bản";
    this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
    this.panel1.BackColor = Color.White;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.splitContainer1);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(897, 658);
    this.panel1.TabIndex = 13;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.splitContainer1.Location = new Point(4, 43);
    this.splitContainer1.Name = "splitContainer1";
    this.splitContainer1.Panel1.Controls.Add((Control) this.groupBox1);
    this.splitContainer1.Panel2.Controls.Add((Control) this.groupBox2);
    this.splitContainer1.Size = new Size(888, 610);
    this.splitContainer1.SplitterDistance = 301;
    this.splitContainer1.SplitterWidth = 15;
    this.splitContainer1.TabIndex = 14;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(897, 658);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fDanhSachKichBan_Old);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fDanhSachKichBan_Old_Load);
    this.Paint += new PaintEventHandler(this.fDanhSachKichBan_Old_Paint);
    this.pnlHeader.ResumeLayout(false);
    this.groupBox1.ResumeLayout(false);
    ((ISupportInitialize) this.dtgvKichBan).EndInit();
    this.contextMenuStrip1.ResumeLayout(false);
    this.bunifuCards1.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.dtgvHanhDong).EndInit();
    this.contextMenuStrip1_1.ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.splitContainer1.Panel1.ResumeLayout(false);
    this.splitContainer1.Panel2.ResumeLayout(false);
    this.splitContainer1.Panel2.PerformLayout();
    this.splitContainer1.EndInit();
    this.splitContainer1.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void groupBox2_Enter(object sender, EventArgs e)
  {
  }

  private void button5_Click(object sender, EventArgs e)
  {
    int index = this.dtgvKichBan.SelectedRows[0].Index;
    if (index == 0)
      return;
    string string_0 = Class14.smethod_3(this.dtgvKichBan, index - 1, "cTenKichBan");
    string string_1 = Class14.smethod_3(this.dtgvKichBan, index, "cTenKichBan");
    if (!(string_0 + string_1 != ""))
      return;
    if (Class205.KichBan_ds(string_0, string_1))
    {
      this.method_0(ref this.dtgvKichBan, index, index - 1);
      this.dtgvKichBan.Rows[index - 1].Selected = true;
    }
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
  }

  private void button4_Click(object sender, EventArgs e)
  {
    int index = this.dtgvKichBan.SelectedRows[0].Index;
    if (index == this.dtgvKichBan.RowCount - 1)
      return;
    string string_0 = Class14.smethod_3(this.dtgvKichBan, index + 1, "cId_HanhDong");
    string string_1 = Class14.smethod_3(this.dtgvKichBan, index, "cId_HanhDong");
    if (!(string_0 + string_1 != ""))
      return;
    if (Class205.smethod_22(string_0, string_1))
    {
      this.method_0(ref this.dtgvKichBan, index, index + 1);
      this.dtgvKichBan.Rows[index + 1].Selected = true;
    }
    else
      GClass14.smethod_0((object) GClass35.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
  }

  private void dtgvHanhDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }

  private void dtgvKichBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }

  private void bunifuCustomLabel1_Click(object sender, EventArgs e)
  {
  }
}
