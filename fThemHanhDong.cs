// Decompiled with JetBrains decompiler
// Type: fThemHanhDong
// Assembly: MaxFarm_5_T3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27A477F0-955B-4C2D-A912-D8E1FD81A934
// Assembly location: C:\Users\Admin\Desktop\New folder\maxphonefarm_fb\maxphonefarm_fb\MaxFarm_5_T3.exe

using Bunifu.Framework.UI;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fThemHanhDong : Form
{
  private string string_0;
  private IContainer icontainer_0 = (IContainer) null;
  private BunifuDragControl bunifuDragControl_0;
  private BunifuDragControl bunifuDragControl_1;
  private BunifuCards bunifuCards1;
  private Panel pnlHeader;
  private BunifuCustomLabel bunifuCustomLabel1;
  private Button button1;
  private GroupBox groupBox2;
  private MetroButton metroButton3;
  private MetroButton metroButton2;
  private MetroButton btnDocThongBao;
  private GroupBox groupBox1;
  private GroupBox groupBox4;
  private MetroButton metroButton18;
  private MetroButton metroButton9;
  private MetroButton metroButton17;
  private MetroButton metroButton13;
  private MetroButton metroButton14;
  private MetroButton metroButton22;
  private MetroButton metroButton23;
  private PictureBox pictureBox2;
  private PictureBox pictureBox3;
  private PictureBox pictureBox5;
  private MetroButton metroButton21;
  private Panel panel1;
  private GroupBox groupBox3;
  private PictureBox pictureBox6;
  private ToolTip toolTip_0;
  private MetroButton metroButton29;
  private MetroButton metroButton34;
  private MetroButton metroButton35;
  private MetroButton metroButton38;
  private MetroButton metroButton41;
  private MetroButton metroButton40;
  private MetroButton metroButton39;
  private MetroButton metroButton43;
  private MetroButton metroButton42;
  private MetroButton metroButton5;
  private GroupBox groupBox7;
  private PictureBox pictureBox8;
  private MetroButton metroButton8;
  private MetroButton metroButton12;
  private MetroButton metroButton15;
  private MetroButton metroButton16;
  private MetroButton metroButton19;
  private MetroButton metroButton1;
  private MetroButton metroButton20;
  private MetroButton metroButton24;
  private MetroButton metroButton25;
  private MetroButton metroButton4;
  private MetroButton metroButton7;
  private MetroButton metroButton26;
  private MetroButton metroButton28;
  private MetroButton metroButton27;
  private MetroButton metroButton30;
  private MetroButton metroButton31;
  private MetroButton metroButton32;
  private MetroButton metroButton33;
  private MetroButton metroButton36;
  private MetroButton metroButton6;
  private MetroButton metroButton10;
  private MetroButton metroButton11;
  private MetroButton metroButton37;
  private MetroButton metroButton44;
  private MetroButton metroButton45;
  private MetroButton metroButton46;
  private MetroButton metroButton47;
  private MetroButton metroButton48;
  private MetroButton metroButton49;
  private MetroButton metroButton50;
  private MetroButton metroButton51;
  private MetroButton metroButton52;
  private MetroButton metroButton53;
  private MetroButton metroButton54;
  private MetroButton metroButton55;
  private MetroButton metroButton56;
  private IContainer components;
  private MetroButton metroButton57;

  public fThemHanhDong(string string_1)
  {
    this.InitializeComponent();
    GClass35.smethod_5((Control) this);
    this.string_0 = string_1;
  }

  private void fThemHanhDong_Load(object sender, EventArgs e)
  {
  }

  private void button1_Click(object sender, EventArgs e) => this.Close();

  private void btnDocThongBao_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDocThongBao(this.string_0));
    if (!fHDDocThongBao.bool_0)
      return;
    this.Close();
  }

  private void metroButton2_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDXemStory(this.string_0));
    if (!fHDXemStory.bool_0)
      return;
    this.Close();
  }

  private void metroButton3_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDXemWatch(this.string_0));
    if (!fHDXemWatch.bool_0)
      return;
    this.Close();
  }

  private void method_0(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDNhanTinBanBe(this.string_0));
    if (!fHDNhanTinBanBe.bool_0)
      return;
    this.Close();
  }

  private void method_1(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDChocBanBe(this.string_0));
    if (!fHDChocBanBe.bool_0)
      return;
    this.Close();
  }

  private void method_2(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDChucMungSinhNhat(this.string_0));
    if (!fHDChucMungSinhNhat.bool_0)
      return;
    this.Close();
  }

  private void method_3(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDPhanHoiTinNhan(this.string_0));
    if (!fHDPhanHoiTinNhan.bool_0)
      return;
    this.Close();
  }

  private void method_4(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDBaiVietNewsfeed(this.string_0));
    if (!fHDBaiVietNewsfeed.bool_0)
      return;
    this.Close();
  }

  private void method_5(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDBaiVietBanBe(this.string_0));
    if (!fHDBaiVietBanBe.bool_0)
      return;
    this.Close();
  }

  private void method_6(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDBaiVietNhom(this.string_0));
    if (!fHDBaiVietNhom.bool_0)
      return;
    this.Close();
  }

  private void method_7(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDBaiVietFanpage(this.string_0));
    if (!fHDBaiVietFanpage.bool_0)
      return;
    this.Close();
  }

  private void metroButton14_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKetBanTheoTuKhoa(this.string_0));
    if (!fHDKetBanTheoTuKhoa.bool_0)
      return;
    this.Close();
  }

  private void metroButton13_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKetBanGoiY(this.string_0));
    if (!fHDKetBanGoiY.bool_0)
      return;
    this.Close();
  }

  private void groupBox3_Enter(object sender, EventArgs e)
  {
  }

  private void metroButton18_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDXacNhanKetBan(this.string_0));
    if (!fHDXacNhanKetBan.bool_0)
      return;
    this.Close();
  }

  private void metroButton9_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKetBanTepUid(this.string_0));
    if (!fHDKetBanTepUid.bool_0)
      return;
    this.Close();
  }

  private void method_8(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKetBanThanhVienNhom(this.string_0));
    if (!fHDKetBanThanhVienNhom.bool_0)
      return;
    this.Close();
  }

  private void method_9(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDHuyLoiMoiKetBan(this.string_0));
    if (!fHDHuyLoiMoiKetBan.bool_0)
      return;
    this.Close();
  }

  private void metroButton17_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDHuyKetBan(this.string_0));
    if (!fHDHuyKetBan.bool_0)
      return;
    this.Close();
  }

  private void metroButton21_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDThamGiaNhomUid(this.string_0));
    if (!fHDThamGiaNhomUid.bool_0)
      return;
    this.Close();
  }

  private void metroButton23_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDThamGiaNhomTuKhoa(this.string_0));
    if (!fHDThamGiaNhomTuKhoa.bool_0)
      return;
    this.Close();
  }

  private void metroButton22_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDRoiNhom(this.string_0));
    if (!fHDRoiNhom.bool_0)
      return;
    this.Close();
  }

  private void method_10(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDMoiBanBeVaoNhom(this.string_0));
    if (!fHDMoiBanBeVaoNhom.bool_0)
      return;
    this.Close();
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

  private void metroButton29_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacNewsfeed(this.string_0));
    if (!fHDTuongTacNewsfeed.bool_0)
      return;
    this.Close();
  }

  private void method_11(object sender, EventArgs e)
  {
    try
    {
      GClass19.smethod_35((Form) new fHDBuffLikeComment(this.string_0));
      if (!fHDBuffLikeComment.bool_0)
        return;
      this.Close();
    }
    catch (Exception ex)
    {
      GClass19.smethod_81(ex, "metroButton26_Click");
      GClass14.smethod_0((object) GClass35.smethod_0("Đã có lỗi xảy ra, vui lòng liên hệ Admin!"), 2);
    }
  }

  private void method_12(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDBuffFollowLikePage(this.string_0));
    if (!fHDBuffFollowLikePage.bool_0)
      return;
    this.Close();
  }

  private void method_13(object sender, EventArgs e)
  {
  }

  private void method_14(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDBuffTinNhanProfile(this.string_0));
    if (!fHDBuffTinNhanProfile.bool_0)
      return;
    this.Close();
  }

  private void method_15(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDSeedingByVideo(this.string_0));
    if (!fHDSeedingByVideo.bool_0)
      return;
    this.Close();
  }

  private void method_16(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTruyCapWebsite(this.string_0));
    if (!fHDTruyCapWebsite.bool_0)
      return;
    this.Close();
  }

  private void method_17(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTimKiemGoogle(this.string_0));
    if (!fHDTimKiemGoogle.bool_0)
      return;
    this.Close();
  }

  private void metroButton34_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacBanBe(this.string_0));
    if (!fHDTuongTacBanBe.bool_0)
      return;
    this.Close();
  }

  private void method_18(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKetBanTepUidNew(this.string_0));
    if (!fHDKetBanTepUidNew.bool_0)
      return;
    this.Close();
  }

  private void metroButton35_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDNghiGiaiLao(this.string_0));
    if (!fHDNghiGiaiLao.bool_0)
      return;
    this.Close();
  }

  private void metroButton38_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDThamGiaNhomGoiY(this.string_0));
    if (!fHDThamGiaNhomGoiY.bool_0)
      return;
    this.Close();
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {
    if ((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control)
      return;
    this.Height = 508;
  }

  private void metroButton40_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKetBanNewfeed(this.string_0));
    if (!fHDKetBanNewfeed.bool_0)
      return;
    this.Close();
  }

  private void metroButton41_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKetBanVoiBanCuaBanBe(this.string_0));
    if (!fHDKetBanVoiBanCuaBanBe.bool_0)
      return;
    this.Close();
  }

  private void metroButton39_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKetBanVoiBanBeCuaUid(this.string_0));
    if (!fHDKetBanVoiBanBeCuaUid.bool_0)
      return;
    this.Close();
  }

  private void metroButton43_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacNhom_1(this.string_0));
    if (!fHDTuongTacNhom_1.bool_0)
      return;
    this.Close();
  }

  private void metroButton42_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacPage(this.string_0));
    if (!fHDTuongTacPage.bool_0)
      return;
    this.Close();
  }

  private void metroButton5_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDongBoDanhBa(this.string_0));
    if (!fHDDongBoDanhBa.bool_0)
      return;
    this.Close();
  }

  private void metroButton8_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDangBaiTuong(this.string_0));
    if (!fHDDangBaiTuong.bool_0)
      return;
    this.Close();
  }

  private void metroButton12_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacVideo(this.string_0));
    if (!fHDTuongTacVideo.bool_0)
      return;
    this.Close();
  }

  private void metroButton15_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDanhGiaPage(this.string_0));
    if (!fHDDanhGiaPage.bool_0)
      return;
    this.Close();
  }

  private void metroButton16_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacBaiVietChiDinh(this.string_0));
    if (!fHDTuongTacBaiVietChiDinh.bool_0)
      return;
    this.Close();
  }

  private void metroButton19_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDSpamBaiViet(this.string_0));
    if (!fHDSpamBaiViet.bool_0)
      return;
    this.Close();
  }

  private void metroButton1_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDBuffLikePage(this.string_0));
    if (!fHDBuffLikePage.bool_0)
      return;
    this.Close();
  }

  private void metroButton20_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDBuffFollowUID(this.string_0));
    if (!fHDBuffFollowUID.bool_0)
      return;
    this.Close();
  }

  private void metroButton24_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDangStory(this.string_0));
    if (!fHDDangStory.bool_0)
      return;
    this.Close();
  }

  private void metroButton25_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDangBaiNhom(this.string_0));
    if (!fHDDangBaiNhom.bool_0)
      return;
    this.Close();
  }

  private void metroButton4_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDXemWatchTheoTuKhoa(this.string_0));
    if (!fHDXemWatchTheoTuKhoa.bool_0)
      return;
    this.Close();
  }

  private void metroButton7_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDShareBaiNangCao(this.string_0));
    if (!fHDShareBaiNangCao.bool_0)
      return;
    this.Close();
  }

  private void metroButton26_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacBaiVietIA(this.string_0));
    if (!fHDTuongTacBaiVietIA.bool_0)
      return;
    this.Close();
  }

  private void metroButton28_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDMoiBanBeVaoNhom(this.string_0));
    if (!fHDMoiBanBeVaoNhom.bool_0)
      return;
    this.Close();
  }

  private void metroButton27_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDMoiBanBeLikePage(this.string_0));
    if (!fHDMoiBanBeLikePage.bool_0)
      return;
    this.Close();
  }

  private void metroButton32_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDoiMatKhau(this.string_0));
    if (!fHDDoiMatKhau.bool_0)
      return;
    this.Close();
  }

  private void metroButton31_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDangXuatThietBiCu(this.string_0));
    if (!fHDDangXuatThietBiCu.bool_0)
      return;
    this.Close();
  }

  private void metroButton30_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDOnOff2FA(this.string_0));
    if (!fHDOnOff2FA.bool_0)
      return;
    this.Close();
  }

  private void metroButton33_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDKhangSpam(this.string_0));
    if (!fHDKhangSpam.bool_0)
      return;
    this.Close();
  }

  private void metroButton36_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDXoaSdt(this.string_0));
    if (!fHDXoaSdt.bool_0)
      return;
    this.Close();
  }

  private void metroButton6_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDXemReel(this.string_0));
    if (!fHDXemReel.bool_0)
      return;
    this.Close();
  }

  private void metroButton10_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDUpAvatar(this.string_0));
    if (!fHDUpAvatar.bool_0)
      return;
    this.Close();
  }

  private void metroButton11_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDUpCover(this.string_0));
    if (!fHDUpCover.bool_0)
      return;
    this.Close();
  }

  private void metroButton37_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDCauHinhTaiKhoan(this.string_0));
    if (!fHDCauHinhTaiKhoan.bool_0)
      return;
    this.Close();
  }

  private void metroButton45_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDSpamBanBe(this.string_0));
    if (!fHDSpamBanBe.bool_0)
      return;
    this.Close();
  }

  private void metroButton44_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDSpamNhom(this.string_0));
    if (!fHDSpamNhom.bool_0)
      return;
    this.Close();
  }

  private void metroButton46_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDangReel(this.string_0));
    if (!fHDDangReel.bool_0)
      return;
    this.Close();
  }

  private void metroButton47_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacReelChiDinh(this.string_0));
    if (!fHDTuongTacReelChiDinh.bool_0)
      return;
    this.Close();
  }

  private void metroButton48_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDAddMail(this.string_0));
    if (!fHDAddMail.bool_0)
      return;
    this.Close();
  }

  private void metroButton49_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDoiTen(this.string_0));
    if (!fHDDoiTen.bool_0)
      return;
    this.Close();
  }

  private void metroButton50_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDCapNhatThongTin(this.string_0));
    if (!fHDCapNhatThongTin.bool_0)
      return;
    this.Close();
  }

  private void metroButton51_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDDangBaiPage(this.string_0));
    if (!fHDDangBaiPage.bool_0)
      return;
    this.Close();
  }

  private void metroButton52_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDVerifyAccount(this.string_0));
    if (!fHDVerifyAccount.bool_0)
      return;
    this.Close();
  }

  private void metroButton53_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDSpamNewfeed(this.string_0));
    if (!fHDSpamNewfeed.bool_0)
      return;
    this.Close();
  }

  private void metroButton54_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacWall(this.string_0));
    if (!fHDTuongTacWall.bool_0)
      return;
    this.Close();
  }

  private void metroButton55_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDChaySeeding(this.string_0));
    if (!fHDChaySeeding.bool_0)
      return;
    this.Close();
  }

  private void metroButton56_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDTuongTacBaiVietTuKhoa(this.string_0));
    if (!fHDTuongTacBaiVietTuKhoa.bool_0)
      return;
    this.Close();
  }

  private void metroButton57_Click(object sender, EventArgs e)
  {
    GClass19.smethod_35((Form) new fHDXoaReel(this.string_0));
    if (!fHDXoaReel.bool_0)
      return;
    this.Close();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fThemHanhDong));
    this.bunifuDragControl_0 = new BunifuDragControl(this.components);
    this.bunifuCustomLabel1 = new BunifuCustomLabel();
    this.bunifuDragControl_1 = new BunifuDragControl(this.components);
    this.pnlHeader = new Panel();
    this.button1 = new Button();
    this.bunifuCards1 = new BunifuCards();
    this.groupBox2 = new GroupBox();
    this.pictureBox2 = new PictureBox();
    this.metroButton6 = new MetroButton();
    this.metroButton43 = new MetroButton();
    this.metroButton4 = new MetroButton();
    this.metroButton3 = new MetroButton();
    this.metroButton42 = new MetroButton();
    this.metroButton2 = new MetroButton();
    this.metroButton54 = new MetroButton();
    this.metroButton29 = new MetroButton();
    this.metroButton34 = new MetroButton();
    this.btnDocThongBao = new MetroButton();
    this.metroButton24 = new MetroButton();
    this.metroButton8 = new MetroButton();
    this.groupBox1 = new GroupBox();
    this.pictureBox3 = new PictureBox();
    this.metroButton14 = new MetroButton();
    this.metroButton22 = new MetroButton();
    this.metroButton18 = new MetroButton();
    this.metroButton21 = new MetroButton();
    this.metroButton9 = new MetroButton();
    this.metroButton23 = new MetroButton();
    this.metroButton38 = new MetroButton();
    this.metroButton13 = new MetroButton();
    this.metroButton17 = new MetroButton();
    this.metroButton40 = new MetroButton();
    this.metroButton39 = new MetroButton();
    this.metroButton41 = new MetroButton();
    this.metroButton57 = new MetroButton();
    this.metroButton12 = new MetroButton();
    this.metroButton16 = new MetroButton();
    this.groupBox4 = new GroupBox();
    this.metroButton7 = new MetroButton();
    this.pictureBox5 = new PictureBox();
    this.metroButton51 = new MetroButton();
    this.metroButton25 = new MetroButton();
    this.metroButton19 = new MetroButton();
    this.metroButton46 = new MetroButton();
    this.metroButton45 = new MetroButton();
    this.metroButton53 = new MetroButton();
    this.metroButton44 = new MetroButton();
    this.panel1 = new Panel();
    this.groupBox7 = new GroupBox();
    this.pictureBox8 = new PictureBox();
    this.metroButton31 = new MetroButton();
    this.metroButton11 = new MetroButton();
    this.metroButton37 = new MetroButton();
    this.metroButton26 = new MetroButton();
    this.metroButton35 = new MetroButton();
    this.metroButton48 = new MetroButton();
    this.metroButton50 = new MetroButton();
    this.metroButton10 = new MetroButton();
    this.metroButton33 = new MetroButton();
    this.metroButton32 = new MetroButton();
    this.metroButton30 = new MetroButton();
    this.metroButton36 = new MetroButton();
    this.metroButton49 = new MetroButton();
    this.groupBox3 = new GroupBox();
    this.metroButton47 = new MetroButton();
    this.pictureBox6 = new PictureBox();
    this.metroButton56 = new MetroButton();
    this.metroButton20 = new MetroButton();
    this.metroButton28 = new MetroButton();
    this.metroButton5 = new MetroButton();
    this.metroButton27 = new MetroButton();
    this.metroButton1 = new MetroButton();
    this.metroButton15 = new MetroButton();
    this.metroButton52 = new MetroButton();
    this.metroButton55 = new MetroButton();
    this.toolTip_0 = new ToolTip(this.components);
    this.pnlHeader.SuspendLayout();
    this.bunifuCards1.SuspendLayout();
    this.groupBox2.SuspendLayout();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    this.groupBox1.SuspendLayout();
    ((ISupportInitialize) this.pictureBox3).BeginInit();
    this.groupBox4.SuspendLayout();
    ((ISupportInitialize) this.pictureBox5).BeginInit();
    this.panel1.SuspendLayout();
    this.groupBox7.SuspendLayout();
    ((ISupportInitialize) this.pictureBox8).BeginInit();
    this.groupBox3.SuspendLayout();
    ((ISupportInitialize) this.pictureBox6).BeginInit();
    this.SuspendLayout();
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
    this.bunifuCustomLabel1.Size = new Size(1039, 31);
    this.bunifuCustomLabel1.TabIndex = 12;
    this.bunifuCustomLabel1.Text = "Danh sách hành động";
    this.bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
    this.bunifuDragControl_1.Fixed = true;
    this.bunifuDragControl_1.Horizontal = true;
    this.bunifuDragControl_1.TargetControl = (Control) this.pnlHeader;
    this.bunifuDragControl_1.Vertical = true;
    this.pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.pnlHeader.BackColor = Color.White;
    this.pnlHeader.Controls.Add((Control) this.button1);
    this.pnlHeader.Controls.Add((Control) this.bunifuCustomLabel1);
    this.pnlHeader.Cursor = Cursors.SizeAll;
    this.pnlHeader.Location = new Point(0, 3);
    this.pnlHeader.Name = "pnlHeader";
    this.pnlHeader.Size = new Size(1039, 31);
    this.pnlHeader.TabIndex = 9;
    this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.button1.Cursor = Cursors.Hand;
    this.button1.FlatAppearance.BorderSize = 0;
    this.button1.FlatStyle = FlatStyle.Flat;
    this.button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.button1.ForeColor = Color.White;
    this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
    this.button1.Location = new Point(1007, 1);
    this.button1.Name = "button1";
    this.button1.Size = new Size(30, 30);
    this.button1.TabIndex = 77;
    this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new EventHandler(this.button1_Click);
    this.bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
    this.bunifuCards1.Size = new Size(1039, 37);
    this.bunifuCards1.TabIndex = 1;
    this.groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.groupBox2.Controls.Add((Control) this.pictureBox2);
    this.groupBox2.Controls.Add((Control) this.metroButton6);
    this.groupBox2.Controls.Add((Control) this.metroButton43);
    this.groupBox2.Controls.Add((Control) this.metroButton4);
    this.groupBox2.Controls.Add((Control) this.metroButton3);
    this.groupBox2.Controls.Add((Control) this.metroButton42);
    this.groupBox2.Controls.Add((Control) this.metroButton2);
    this.groupBox2.Controls.Add((Control) this.metroButton54);
    this.groupBox2.Controls.Add((Control) this.metroButton29);
    this.groupBox2.Controls.Add((Control) this.metroButton34);
    this.groupBox2.Controls.Add((Control) this.btnDocThongBao);
    this.groupBox2.Location = new Point(9, 43);
    this.groupBox2.Name = "groupBox2";
    this.groupBox2.Size = new Size(200, 427);
    this.groupBox2.TabIndex = 0;
    this.groupBox2.TabStop = false;
    this.groupBox2.Text = "Tương tác";
    this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(14, 34);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(171, 83);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox2.TabIndex = 1;
    this.pictureBox2.TabStop = false;
    this.metroButton6.Cursor = Cursors.Hand;
    this.metroButton6.Location = new Point(14, 165);
    this.metroButton6.Name = "metroButton6";
    this.metroButton6.Size = new Size(171, 23);
    this.metroButton6.TabIndex = 2;
    this.metroButton6.Text = "Xem Reel";
    this.metroButton6.UseSelectable = true;
    this.metroButton6.Click += new EventHandler(this.metroButton6_Click);
    this.metroButton43.Cursor = Cursors.Hand;
    this.metroButton43.Location = new Point(14, 339);
    this.metroButton43.Name = "metroButton43";
    this.metroButton43.Size = new Size(171, 23);
    this.metroButton43.TabIndex = 6;
    this.metroButton43.Text = "Tương tác Nhóm";
    this.metroButton43.UseSelectable = true;
    this.metroButton43.Click += new EventHandler(this.metroButton43_Click);
    this.metroButton4.Cursor = Cursors.Hand;
    this.metroButton4.Location = new Point(14, 252);
    this.metroButton4.Name = "metroButton4";
    this.metroButton4.Size = new Size(171, 23);
    this.metroButton4.TabIndex = 3;
    this.metroButton4.Text = "Xem Watch theo từ khóa";
    this.metroButton4.UseSelectable = true;
    this.metroButton4.Click += new EventHandler(this.metroButton4_Click);
    this.metroButton3.Cursor = Cursors.Hand;
    this.metroButton3.Location = new Point(14, 223);
    this.metroButton3.Name = "metroButton3";
    this.metroButton3.Size = new Size(171, 23);
    this.metroButton3.TabIndex = 2;
    this.metroButton3.Text = "Xem Watch";
    this.metroButton3.UseSelectable = true;
    this.metroButton3.Click += new EventHandler(this.metroButton3_Click);
    this.metroButton42.Cursor = Cursors.Hand;
    this.metroButton42.Location = new Point(14, 368);
    this.metroButton42.Name = "metroButton42";
    this.metroButton42.Size = new Size(171, 23);
    this.metroButton42.TabIndex = 7;
    this.metroButton42.Text = "Tương tác Page";
    this.metroButton42.UseSelectable = true;
    this.metroButton42.Click += new EventHandler(this.metroButton42_Click);
    this.metroButton2.Cursor = Cursors.Hand;
    this.metroButton2.Location = new Point(14, 194);
    this.metroButton2.Name = "metroButton2";
    this.metroButton2.Size = new Size(171, 23);
    this.metroButton2.TabIndex = 1;
    this.metroButton2.Text = "Xem Story";
    this.metroButton2.UseSelectable = true;
    this.metroButton2.Click += new EventHandler(this.metroButton2_Click);
    this.metroButton54.Cursor = Cursors.Hand;
    this.metroButton54.Location = new Point(14, 398);
    this.metroButton54.Name = "metroButton54";
    this.metroButton54.Size = new Size(171, 23);
    this.metroButton54.TabIndex = 4;
    this.metroButton54.Text = "Tương tác Wall";
    this.metroButton54.UseSelectable = true;
    this.metroButton54.Click += new EventHandler(this.metroButton54_Click);
    this.metroButton29.Cursor = Cursors.Hand;
    this.metroButton29.Location = new Point(14, 281);
    this.metroButton29.Name = "metroButton29";
    this.metroButton29.Size = new Size(171, 23);
    this.metroButton29.TabIndex = 4;
    this.metroButton29.Text = "Tương tác Newsfeed";
    this.metroButton29.UseSelectable = true;
    this.metroButton29.Click += new EventHandler(this.metroButton29_Click);
    this.metroButton34.Cursor = Cursors.Hand;
    this.metroButton34.Location = new Point(14, 310);
    this.metroButton34.Name = "metroButton34";
    this.metroButton34.Size = new Size(171, 23);
    this.metroButton34.TabIndex = 5;
    this.metroButton34.Text = "Tương tác Bạn bè";
    this.metroButton34.UseSelectable = true;
    this.metroButton34.Click += new EventHandler(this.metroButton34_Click);
    this.btnDocThongBao.BackColor = SystemColors.Control;
    this.btnDocThongBao.Cursor = Cursors.Hand;
    this.btnDocThongBao.ForeColor = Color.Black;
    this.btnDocThongBao.Location = new Point(14, 136);
    this.btnDocThongBao.Name = "btnDocThongBao";
    this.btnDocThongBao.Size = new Size(171, 23);
    this.btnDocThongBao.TabIndex = 0;
    this.btnDocThongBao.Text = "Đọc thông báo";
    this.btnDocThongBao.UseSelectable = true;
    this.btnDocThongBao.UseVisualStyleBackColor = false;
    this.btnDocThongBao.Click += new EventHandler(this.btnDocThongBao_Click);
    this.metroButton24.Cursor = Cursors.Hand;
    this.metroButton24.Location = new Point(14, 397);
    this.metroButton24.Name = "metroButton24";
    this.metroButton24.Size = new Size(171, 23);
    this.metroButton24.TabIndex = 0;
    this.metroButton24.Text = "Đăng Story";
    this.metroButton24.UseSelectable = true;
    this.metroButton24.Click += new EventHandler(this.metroButton24_Click);
    this.metroButton8.Cursor = Cursors.Hand;
    this.metroButton8.Location = new Point(14, 136);
    this.metroButton8.Name = "metroButton8";
    this.metroButton8.Size = new Size(171, 23);
    this.metroButton8.TabIndex = 1;
    this.metroButton8.Text = "Đăng bài lên tường";
    this.metroButton8.UseSelectable = true;
    this.metroButton8.Click += new EventHandler(this.metroButton8_Click);
    this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.groupBox1.Controls.Add((Control) this.pictureBox3);
    this.groupBox1.Controls.Add((Control) this.metroButton14);
    this.groupBox1.Controls.Add((Control) this.metroButton22);
    this.groupBox1.Controls.Add((Control) this.metroButton18);
    this.groupBox1.Controls.Add((Control) this.metroButton21);
    this.groupBox1.Controls.Add((Control) this.metroButton9);
    this.groupBox1.Controls.Add((Control) this.metroButton23);
    this.groupBox1.Controls.Add((Control) this.metroButton38);
    this.groupBox1.Controls.Add((Control) this.metroButton13);
    this.groupBox1.Controls.Add((Control) this.metroButton17);
    this.groupBox1.Controls.Add((Control) this.metroButton40);
    this.groupBox1.Controls.Add((Control) this.metroButton39);
    this.groupBox1.Controls.Add((Control) this.metroButton41);
    this.groupBox1.Location = new Point(215, 43);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(200, 427);
    this.groupBox1.TabIndex = 1;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Kết bạn - Tham gia nhóm";
    this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
    this.pictureBox3.Location = new Point(14, 34);
    this.pictureBox3.Name = "pictureBox3";
    this.pictureBox3.Size = new Size(171, 83);
    this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox3.TabIndex = 1;
    this.pictureBox3.TabStop = false;
    this.metroButton14.Cursor = Cursors.Hand;
    this.metroButton14.Location = new Point(14, 136);
    this.metroButton14.Name = "metroButton14";
    this.metroButton14.Size = new Size(171, 23);
    this.metroButton14.TabIndex = 0;
    this.metroButton14.Text = "Kết bạn theo từ khóa";
    this.metroButton14.UseSelectable = true;
    this.metroButton14.Click += new EventHandler(this.metroButton14_Click);
    this.metroButton22.Cursor = Cursors.Hand;
    this.metroButton22.Location = new Point(14, 368);
    this.metroButton22.Name = "metroButton22";
    this.metroButton22.Size = new Size(171, 23);
    this.metroButton22.TabIndex = 7;
    this.metroButton22.Text = "Rời nhóm";
    this.metroButton22.UseSelectable = true;
    this.metroButton22.Click += new EventHandler(this.metroButton22_Click);
    this.metroButton18.Cursor = Cursors.Hand;
    this.metroButton18.Location = new Point(14, 223);
    this.metroButton18.Name = "metroButton18";
    this.metroButton18.Size = new Size(171, 23);
    this.metroButton18.TabIndex = 2;
    this.metroButton18.Text = "Xác nhận kết bạn";
    this.metroButton18.UseSelectable = true;
    this.metroButton18.Click += new EventHandler(this.metroButton18_Click);
    this.metroButton21.Cursor = Cursors.Hand;
    this.metroButton21.Location = new Point(14, 310);
    this.metroButton21.Name = "metroButton21";
    this.metroButton21.Size = new Size(171, 23);
    this.metroButton21.TabIndex = 6;
    this.metroButton21.Text = "Tham gia nhóm theo tệp UID";
    this.metroButton21.UseSelectable = true;
    this.metroButton21.Click += new EventHandler(this.metroButton21_Click);
    this.metroButton9.Cursor = Cursors.Hand;
    this.metroButton9.Location = new Point(14, 165);
    this.metroButton9.Name = "metroButton9";
    this.metroButton9.Size = new Size(171, 23);
    this.metroButton9.TabIndex = 3;
    this.metroButton9.Text = "Kết bạn theo tệp UID";
    this.metroButton9.UseSelectable = true;
    this.metroButton9.Click += new EventHandler(this.metroButton9_Click);
    this.metroButton23.Cursor = Cursors.Hand;
    this.metroButton23.Location = new Point(14, 281);
    this.metroButton23.Name = "metroButton23";
    this.metroButton23.Size = new Size(171, 23);
    this.metroButton23.TabIndex = 5;
    this.metroButton23.Text = "Tham gia nhóm theo từ khóa";
    this.metroButton23.UseSelectable = true;
    this.metroButton23.Click += new EventHandler(this.metroButton23_Click);
    this.metroButton38.Cursor = Cursors.Hand;
    this.metroButton38.Location = new Point(14, 339);
    this.metroButton38.Name = "metroButton38";
    this.metroButton38.Size = new Size(171, 23);
    this.metroButton38.TabIndex = 3;
    this.metroButton38.Text = "Tham gia nhóm theo gợi ý";
    this.metroButton38.UseSelectable = true;
    this.metroButton38.Click += new EventHandler(this.metroButton38_Click);
    this.metroButton13.Cursor = Cursors.Hand;
    this.metroButton13.Location = new Point(14, 194);
    this.metroButton13.Name = "metroButton13";
    this.metroButton13.Size = new Size(171, 23);
    this.metroButton13.TabIndex = 1;
    this.metroButton13.Text = "Kết bạn theo gợi ý";
    this.metroButton13.UseSelectable = true;
    this.metroButton13.Click += new EventHandler(this.metroButton13_Click);
    this.metroButton17.Cursor = Cursors.Hand;
    this.metroButton17.Location = new Point(14, 252);
    this.metroButton17.Name = "metroButton17";
    this.metroButton17.Size = new Size(171, 23);
    this.metroButton17.TabIndex = 4;
    this.metroButton17.Text = "Hủy kết bạn";
    this.metroButton17.UseSelectable = true;
    this.metroButton17.Click += new EventHandler(this.metroButton17_Click);
    this.metroButton40.Cursor = Cursors.Hand;
    this.metroButton40.Enabled = false;
    this.metroButton40.Location = new Point(14, 194);
    this.metroButton40.Name = "metroButton40";
    this.metroButton40.Size = new Size(171, 23);
    this.metroButton40.TabIndex = 6;
    this.metroButton40.Text = "Kết bạn Newfeed (ẩn)";
    this.metroButton40.UseSelectable = true;
    this.metroButton40.Visible = false;
    this.metroButton40.Click += new EventHandler(this.metroButton40_Click);
    this.metroButton39.Cursor = Cursors.Hand;
    this.metroButton39.Enabled = false;
    this.metroButton39.Location = new Point(14, 252);
    this.metroButton39.Name = "metroButton39";
    this.metroButton39.Size = new Size(171, 23);
    this.metroButton39.TabIndex = 6;
    this.metroButton39.Text = "Kết bạn với bạn bè của Uid (ẩn)";
    this.metroButton39.UseSelectable = true;
    this.metroButton39.Visible = false;
    this.metroButton39.Click += new EventHandler(this.metroButton39_Click);
    this.metroButton41.Cursor = Cursors.Hand;
    this.metroButton41.Enabled = false;
    this.metroButton41.Location = new Point(14, 223);
    this.metroButton41.Name = "metroButton41";
    this.metroButton41.Size = new Size(171, 23);
    this.metroButton41.TabIndex = 6;
    this.metroButton41.Text = "Kết bạn với bạn của bạn bè (ẩn)";
    this.metroButton41.UseSelectable = true;
    this.metroButton41.Visible = false;
    this.metroButton41.Click += new EventHandler(this.metroButton41_Click);
    this.metroButton57.Cursor = Cursors.Hand;
    this.metroButton57.Location = new Point(14, 368);
    this.metroButton57.Name = "metroButton57";
    this.metroButton57.Size = new Size(171, 23);
    this.metroButton57.TabIndex = 4;
    this.metroButton57.Text = "Xóa Reel";
    this.metroButton57.UseSelectable = true;
    this.metroButton57.Click += new EventHandler(this.metroButton57_Click);
    this.metroButton12.Cursor = Cursors.Hand;
    this.metroButton12.Location = new Point(14, 281);
    this.metroButton12.Name = "metroButton12";
    this.metroButton12.Size = new Size(171, 23);
    this.metroButton12.TabIndex = 6;
    this.metroButton12.Text = "Tương tác Video, Livestream";
    this.metroButton12.UseSelectable = true;
    this.metroButton12.Click += new EventHandler(this.metroButton12_Click);
    this.metroButton16.Cursor = Cursors.Hand;
    this.metroButton16.Location = new Point(14, 252);
    this.metroButton16.Name = "metroButton16";
    this.metroButton16.Size = new Size(171, 23);
    this.metroButton16.TabIndex = 1;
    this.metroButton16.Text = "Tương tác Bài viết chỉ định";
    this.metroButton16.UseSelectable = true;
    this.metroButton16.Click += new EventHandler(this.metroButton16_Click);
    this.groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.groupBox4.Controls.Add((Control) this.metroButton7);
    this.groupBox4.Controls.Add((Control) this.pictureBox5);
    this.groupBox4.Controls.Add((Control) this.metroButton51);
    this.groupBox4.Controls.Add((Control) this.metroButton25);
    this.groupBox4.Controls.Add((Control) this.metroButton8);
    this.groupBox4.Controls.Add((Control) this.metroButton24);
    this.groupBox4.Controls.Add((Control) this.metroButton19);
    this.groupBox4.Controls.Add((Control) this.metroButton46);
    this.groupBox4.Controls.Add((Control) this.metroButton45);
    this.groupBox4.Controls.Add((Control) this.metroButton53);
    this.groupBox4.Controls.Add((Control) this.metroButton44);
    this.groupBox4.Controls.Add((Control) this.metroButton57);
    this.groupBox4.Location = new Point(421, 43);
    this.groupBox4.Name = "groupBox4";
    this.groupBox4.Size = new Size(200, 427);
    this.groupBox4.TabIndex = 2;
    this.groupBox4.TabStop = false;
    this.groupBox4.Text = "Đăng bài - Share bài - Spam";
    this.metroButton7.Cursor = Cursors.Hand;
    this.metroButton7.Location = new Point(14, 223);
    this.metroButton7.Name = "metroButton7";
    this.metroButton7.Size = new Size(171, 23);
    this.metroButton7.TabIndex = 5;
    this.metroButton7.Text = "Share bài";
    this.metroButton7.UseSelectable = true;
    this.metroButton7.Click += new EventHandler(this.metroButton7_Click);
    this.pictureBox5.Image = (Image) componentResourceManager.GetObject("pictureBox5.Image");
    this.pictureBox5.Location = new Point(14, 34);
    this.pictureBox5.Name = "pictureBox5";
    this.pictureBox5.Size = new Size(171, 83);
    this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox5.TabIndex = 1;
    this.pictureBox5.TabStop = false;
    this.metroButton51.Cursor = Cursors.Hand;
    this.metroButton51.Location = new Point(14, 194);
    this.metroButton51.Name = "metroButton51";
    this.metroButton51.Size = new Size(171, 23);
    this.metroButton51.TabIndex = 2;
    this.metroButton51.Text = "Đăng bài lên page";
    this.metroButton51.UseSelectable = true;
    this.metroButton51.Click += new EventHandler(this.metroButton51_Click);
    this.metroButton25.Cursor = Cursors.Hand;
    this.metroButton25.Location = new Point(14, 165);
    this.metroButton25.Name = "metroButton25";
    this.metroButton25.Size = new Size(171, 23);
    this.metroButton25.TabIndex = 2;
    this.metroButton25.Text = "Đăng bài lên nhóm";
    this.metroButton25.UseSelectable = true;
    this.metroButton25.Click += new EventHandler(this.metroButton25_Click);
    this.metroButton19.Cursor = Cursors.Hand;
    this.metroButton19.Location = new Point(14, 339);
    this.metroButton19.Name = "metroButton19";
    this.metroButton19.Size = new Size(171, 23);
    this.metroButton19.TabIndex = 1;
    this.metroButton19.Text = "Spam bài viết";
    this.metroButton19.UseSelectable = true;
    this.metroButton19.Click += new EventHandler(this.metroButton19_Click);
    this.metroButton46.Cursor = Cursors.Hand;
    this.metroButton46.Location = new Point(14, 368);
    this.metroButton46.Name = "metroButton46";
    this.metroButton46.Size = new Size(171, 23);
    this.metroButton46.TabIndex = 4;
    this.metroButton46.Text = "Đăng Reel";
    this.metroButton46.UseSelectable = true;
    this.metroButton46.Click += new EventHandler(this.metroButton46_Click);
    this.metroButton45.Cursor = Cursors.Hand;
    this.metroButton45.Location = new Point(14, 281);
    this.metroButton45.Name = "metroButton45";
    this.metroButton45.Size = new Size(171, 23);
    this.metroButton45.TabIndex = 1;
    this.metroButton45.Text = "Spam bạn bè";
    this.metroButton45.UseSelectable = true;
    this.metroButton45.Click += new EventHandler(this.metroButton45_Click);
    this.metroButton53.Cursor = Cursors.Hand;
    this.metroButton53.Location = new Point(14, 252);
    this.metroButton53.Name = "metroButton53";
    this.metroButton53.Size = new Size(171, 23);
    this.metroButton53.TabIndex = 1;
    this.metroButton53.Text = "Spam Newfeed";
    this.metroButton53.UseSelectable = true;
    this.metroButton53.Click += new EventHandler(this.metroButton53_Click);
    this.metroButton44.Cursor = Cursors.Hand;
    this.metroButton44.Location = new Point(14, 310);
    this.metroButton44.Name = "metroButton44";
    this.metroButton44.Size = new Size(171, 23);
    this.metroButton44.TabIndex = 1;
    this.metroButton44.Text = "Spam nhóm";
    this.metroButton44.UseSelectable = true;
    this.metroButton44.Click += new EventHandler(this.metroButton44_Click);
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.groupBox7);
    this.panel1.Controls.Add((Control) this.groupBox3);
    this.panel1.Controls.Add((Control) this.bunifuCards1);
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(1042, 479);
    this.panel1.TabIndex = 0;
    this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
    this.groupBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.groupBox7.Controls.Add((Control) this.pictureBox8);
    this.groupBox7.Controls.Add((Control) this.metroButton31);
    this.groupBox7.Controls.Add((Control) this.metroButton11);
    this.groupBox7.Controls.Add((Control) this.metroButton37);
    this.groupBox7.Controls.Add((Control) this.metroButton26);
    this.groupBox7.Controls.Add((Control) this.metroButton35);
    this.groupBox7.Controls.Add((Control) this.metroButton48);
    this.groupBox7.Controls.Add((Control) this.metroButton50);
    this.groupBox7.Controls.Add((Control) this.metroButton10);
    this.groupBox7.Controls.Add((Control) this.metroButton33);
    this.groupBox7.Controls.Add((Control) this.metroButton32);
    this.groupBox7.Controls.Add((Control) this.metroButton30);
    this.groupBox7.Controls.Add((Control) this.metroButton36);
    this.groupBox7.Controls.Add((Control) this.metroButton49);
    this.groupBox7.Location = new Point(832, 43);
    this.groupBox7.Name = "groupBox7";
    this.groupBox7.Size = new Size(200, 426);
    this.groupBox7.TabIndex = 2;
    this.groupBox7.TabStop = false;
    this.groupBox7.Text = "Đổi thông tin";
    this.groupBox7.Enter += new EventHandler(this.groupBox3_Enter);
    this.pictureBox8.Image = (Image) componentResourceManager.GetObject("pictureBox8.Image");
    this.pictureBox8.Location = new Point(14, 33);
    this.pictureBox8.Name = "pictureBox8";
    this.pictureBox8.Size = new Size(171, 83);
    this.pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox8.TabIndex = 1;
    this.pictureBox8.TabStop = false;
    this.metroButton31.Cursor = Cursors.Hand;
    this.metroButton31.Location = new Point(14, 251);
    this.metroButton31.Name = "metroButton31";
    this.metroButton31.Size = new Size(171, 23);
    this.metroButton31.TabIndex = 1;
    this.metroButton31.Text = "Đăng xuất thiết bị cũ";
    this.metroButton31.UseSelectable = true;
    this.metroButton31.Click += new EventHandler(this.metroButton31_Click);
    this.metroButton11.Cursor = Cursors.Hand;
    this.metroButton11.Location = new Point(14, 193);
    this.metroButton11.Name = "metroButton11";
    this.metroButton11.Size = new Size(171, 23);
    this.metroButton11.TabIndex = 1;
    this.metroButton11.Text = "Up Cover";
    this.metroButton11.UseSelectable = true;
    this.metroButton11.Click += new EventHandler(this.metroButton11_Click);
    this.metroButton37.Cursor = Cursors.Hand;
    this.metroButton37.Location = new Point(14, 426);
    this.metroButton37.Name = "metroButton37";
    this.metroButton37.Size = new Size(171, 23);
    this.metroButton37.TabIndex = 1;
    this.metroButton37.Text = "Cấu hình tài khoản";
    this.metroButton37.UseSelectable = true;
    this.metroButton37.Visible = false;
    this.metroButton37.Click += new EventHandler(this.metroButton37_Click);
    this.metroButton26.Cursor = Cursors.Hand;
    this.metroButton26.Location = new Point(14, 426);
    this.metroButton26.Name = "metroButton26";
    this.metroButton26.Size = new Size(171, 23);
    this.metroButton26.TabIndex = 0;
    this.metroButton26.Text = "Tương tác bài viết IA";
    this.metroButton26.UseSelectable = true;
    this.metroButton26.Visible = false;
    this.metroButton26.Click += new EventHandler(this.metroButton26_Click);
    this.metroButton35.Cursor = Cursors.Hand;
    this.metroButton35.Location = new Point(14, 396);
    this.metroButton35.Name = "metroButton35";
    this.metroButton35.Size = new Size(171, 23);
    this.metroButton35.TabIndex = 0;
    this.metroButton35.Text = "Nghỉ giải lao";
    this.metroButton35.UseSelectable = true;
    this.metroButton35.Click += new EventHandler(this.metroButton35_Click);
    this.metroButton48.Cursor = Cursors.Hand;
    this.metroButton48.Location = new Point(14, 309);
    this.metroButton48.Name = "metroButton48";
    this.metroButton48.Size = new Size(171, 23);
    this.metroButton48.TabIndex = 4;
    this.metroButton48.Text = "Add mail";
    this.metroButton48.UseSelectable = true;
    this.metroButton48.Click += new EventHandler(this.metroButton48_Click);
    this.metroButton50.Cursor = Cursors.Hand;
    this.metroButton50.Location = new Point(14, 367);
    this.metroButton50.Name = "metroButton50";
    this.metroButton50.Size = new Size(171, 23);
    this.metroButton50.TabIndex = 4;
    this.metroButton50.Text = "Cập nhật thông tin";
    this.metroButton50.UseSelectable = true;
    this.metroButton50.Click += new EventHandler(this.metroButton50_Click);
    this.metroButton10.Cursor = Cursors.Hand;
    this.metroButton10.Location = new Point(14, 164);
    this.metroButton10.Name = "metroButton10";
    this.metroButton10.Size = new Size(171, 23);
    this.metroButton10.TabIndex = 1;
    this.metroButton10.Text = "Up Avatar";
    this.metroButton10.UseSelectable = true;
    this.metroButton10.Click += new EventHandler(this.metroButton10_Click);
    this.metroButton33.Cursor = Cursors.Hand;
    this.metroButton33.Location = new Point(14, 426);
    this.metroButton33.Name = "metroButton33";
    this.metroButton33.Size = new Size(171, 23);
    this.metroButton33.TabIndex = 4;
    this.metroButton33.Text = "Kháng Spam";
    this.metroButton33.UseSelectable = true;
    this.metroButton33.Visible = false;
    this.metroButton33.Click += new EventHandler(this.metroButton33_Click);
    this.metroButton32.Cursor = Cursors.Hand;
    this.metroButton32.Location = new Point(14, 135);
    this.metroButton32.Name = "metroButton32";
    this.metroButton32.Size = new Size(171, 23);
    this.metroButton32.TabIndex = 1;
    this.metroButton32.Text = "Đổi mật khẩu";
    this.metroButton32.UseSelectable = true;
    this.metroButton32.Click += new EventHandler(this.metroButton32_Click);
    this.metroButton30.Cursor = Cursors.Hand;
    this.metroButton30.Location = new Point(14, 280);
    this.metroButton30.Name = "metroButton30";
    this.metroButton30.Size = new Size(171, 23);
    this.metroButton30.TabIndex = 1;
    this.metroButton30.Text = "Bật - Tắt 2FA";
    this.metroButton30.UseSelectable = true;
    this.metroButton30.Click += new EventHandler(this.metroButton30_Click);
    this.metroButton36.Cursor = Cursors.Hand;
    this.metroButton36.Location = new Point(14, 222);
    this.metroButton36.Name = "metroButton36";
    this.metroButton36.Size = new Size(171, 23);
    this.metroButton36.TabIndex = 4;
    this.metroButton36.Text = "Xóa Sđt";
    this.metroButton36.UseSelectable = true;
    this.metroButton36.Click += new EventHandler(this.metroButton36_Click);
    this.metroButton49.Cursor = Cursors.Hand;
    this.metroButton49.Location = new Point(14, 338);
    this.metroButton49.Name = "metroButton49";
    this.metroButton49.Size = new Size(171, 23);
    this.metroButton49.TabIndex = 4;
    this.metroButton49.Text = "Đổi tên";
    this.metroButton49.UseSelectable = true;
    this.metroButton49.Click += new EventHandler(this.metroButton49_Click);
    this.groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.groupBox3.Controls.Add((Control) this.metroButton47);
    this.groupBox3.Controls.Add((Control) this.pictureBox6);
    this.groupBox3.Controls.Add((Control) this.metroButton56);
    this.groupBox3.Controls.Add((Control) this.metroButton16);
    this.groupBox3.Controls.Add((Control) this.metroButton20);
    this.groupBox3.Controls.Add((Control) this.metroButton28);
    this.groupBox3.Controls.Add((Control) this.metroButton12);
    this.groupBox3.Controls.Add((Control) this.metroButton5);
    this.groupBox3.Controls.Add((Control) this.metroButton27);
    this.groupBox3.Controls.Add((Control) this.metroButton1);
    this.groupBox3.Controls.Add((Control) this.metroButton15);
    this.groupBox3.Controls.Add((Control) this.metroButton52);
    this.groupBox3.Controls.Add((Control) this.metroButton55);
    this.groupBox3.Location = new Point(626, 42);
    this.groupBox3.Name = "groupBox3";
    this.groupBox3.Size = new Size(200, 427);
    this.groupBox3.TabIndex = 1;
    this.groupBox3.TabStop = false;
    this.groupBox3.Text = "Seeding";
    this.groupBox3.Enter += new EventHandler(this.groupBox3_Enter);
    this.metroButton47.Cursor = Cursors.Hand;
    this.metroButton47.Location = new Point(14, 368);
    this.metroButton47.Name = "metroButton47";
    this.metroButton47.Size = new Size(171, 23);
    this.metroButton47.TabIndex = 7;
    this.metroButton47.Text = "Tương tác Reel chỉ định";
    this.metroButton47.UseSelectable = true;
    this.metroButton47.Click += new EventHandler(this.metroButton47_Click);
    this.pictureBox6.Image = (Image) componentResourceManager.GetObject("pictureBox6.Image");
    this.pictureBox6.Location = new Point(14, 34);
    this.pictureBox6.Name = "pictureBox6";
    this.pictureBox6.Size = new Size(171, 83);
    this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox6.TabIndex = 1;
    this.pictureBox6.TabStop = false;
    this.metroButton56.Cursor = Cursors.Hand;
    this.metroButton56.Location = new Point(14, 223);
    this.metroButton56.Name = "metroButton56";
    this.metroButton56.Size = new Size(171, 23);
    this.metroButton56.TabIndex = 1;
    this.metroButton56.Text = "Tương tác Bài viết từ khóa";
    this.metroButton56.UseSelectable = true;
    this.metroButton56.Click += new EventHandler(this.metroButton56_Click);
    this.metroButton20.Cursor = Cursors.Hand;
    this.metroButton20.Location = new Point(14, 194);
    this.metroButton20.Name = "metroButton20";
    this.metroButton20.Size = new Size(171, 23);
    this.metroButton20.TabIndex = 6;
    this.metroButton20.Text = "Buff Follow UID";
    this.metroButton20.UseSelectable = true;
    this.metroButton20.Click += new EventHandler(this.metroButton20_Click);
    this.metroButton28.Cursor = Cursors.Hand;
    this.metroButton28.Location = new Point(14, 339);
    this.metroButton28.Name = "metroButton28";
    this.metroButton28.Size = new Size(171, 23);
    this.metroButton28.TabIndex = 1;
    this.metroButton28.Text = "Mời bạn bè vào nhóm";
    this.metroButton28.UseSelectable = true;
    this.metroButton28.Click += new EventHandler(this.metroButton28_Click);
    this.metroButton5.Cursor = Cursors.Hand;
    this.metroButton5.Location = new Point(14, 397);
    this.metroButton5.Name = "metroButton5";
    this.metroButton5.Size = new Size(171, 23);
    this.metroButton5.TabIndex = 4;
    this.metroButton5.Text = "Đồng bộ danh bạ";
    this.metroButton5.UseSelectable = true;
    this.metroButton5.Click += new EventHandler(this.metroButton5_Click);
    this.metroButton27.Cursor = Cursors.Hand;
    this.metroButton27.Location = new Point(14, 310);
    this.metroButton27.Name = "metroButton27";
    this.metroButton27.Size = new Size(171, 23);
    this.metroButton27.TabIndex = 1;
    this.metroButton27.Text = "Mời bạn bè like page";
    this.metroButton27.UseSelectable = true;
    this.metroButton27.Click += new EventHandler(this.metroButton27_Click);
    this.metroButton1.Cursor = Cursors.Hand;
    this.metroButton1.Location = new Point(14, 165);
    this.metroButton1.Name = "metroButton1";
    this.metroButton1.Size = new Size(171, 23);
    this.metroButton1.TabIndex = 6;
    this.metroButton1.Text = "Buff Like Page";
    this.metroButton1.UseSelectable = true;
    this.metroButton1.Click += new EventHandler(this.metroButton1_Click);
    this.metroButton15.Cursor = Cursors.Hand;
    this.metroButton15.Location = new Point(14, 136);
    this.metroButton15.Name = "metroButton15";
    this.metroButton15.Size = new Size(171, 23);
    this.metroButton15.TabIndex = 6;
    this.metroButton15.Text = "Đánh giá Page";
    this.metroButton15.UseSelectable = true;
    this.metroButton15.Click += new EventHandler(this.metroButton15_Click);
    this.metroButton52.Cursor = Cursors.Hand;
    this.metroButton52.Location = new Point(14, 397);
    this.metroButton52.Name = "metroButton52";
    this.metroButton52.Size = new Size(171, 23);
    this.metroButton52.TabIndex = 4;
    this.metroButton52.Text = "Verify Account (ẩn)";
    this.metroButton52.UseSelectable = true;
    this.metroButton52.Click += new EventHandler(this.metroButton52_Click);
    this.metroButton55.Cursor = Cursors.Hand;
    this.metroButton55.Location = new Point(14, 397);
    this.metroButton55.Name = "metroButton55";
    this.metroButton55.Size = new Size(171, 23);
    this.metroButton55.TabIndex = 0;
    this.metroButton55.Text = "Chạy Job Seeding (ẩn)";
    this.metroButton55.UseSelectable = true;
    this.metroButton55.Click += new EventHandler(this.metroButton55_Click);
    this.toolTip_0.AutomaticDelay = 0;
    this.toolTip_0.AutoPopDelay = 0;
    this.toolTip_0.InitialDelay = 500;
    this.toolTip_0.ReshowDelay = 0;
    this.AutoScaleDimensions = new SizeF(7f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1042, 479);
    this.Controls.Add((Control) this.groupBox4);
    this.Controls.Add((Control) this.groupBox1);
    this.Controls.Add((Control) this.groupBox2);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Margin = new Padding(3, 4, 3, 4);
    this.Name = nameof (fThemHanhDong);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Cấu hình tương tác";
    this.Load += new EventHandler(this.fThemHanhDong_Load);
    this.pnlHeader.ResumeLayout(false);
    this.bunifuCards1.ResumeLayout(false);
    this.groupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox2).EndInit();
    this.groupBox1.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox3).EndInit();
    this.groupBox4.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox5).EndInit();
    this.panel1.ResumeLayout(false);
    this.groupBox7.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox8).EndInit();
    this.groupBox3.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox6).EndInit();
    this.ResumeLayout(false);
  }
}
