namespace NHVL_Lib.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NHVL : DbContext
    {
        public NHVL()
            : base("name=NHVL")
        {
        }

        public virtual DbSet<aspnet_getmba> aspnet_getmba { get; set; }
        public virtual DbSet<aspnet_getVisitors> aspnet_getVisitors { get; set; }
        public virtual DbSet<BHTN_CoViecLam> BHTN_CoViecLam { get; set; }
        public virtual DbSet<BHTN_XacNhanThangHuong> BHTN_XacNhanThangHuong { get; set; }
        public virtual DbSet<Chan_SignlR> Chan_SignlR { get; set; }
        public virtual DbSet<DanhGia_VoidChat> DanhGia_VoidChat { get; set; }
        public virtual DbSet<DiemDanh> DiemDanh { get; set; }
        public virtual DbSet<DM_CheDoPhucLoi_2022> DM_CheDoPhucLoi_2022 { get; set; }
        public virtual DbSet<DM_ChucDanh> DM_ChucDanh { get; set; }
        public virtual DbSet<DM_ChucVu_2022> DM_ChucVu_2022 { get; set; }
        public virtual DbSet<DM_DanToc> DM_DanToc { get; set; }
        public virtual DbSet<DM_DichVu2022> DM_DichVu2022 { get; set; }
        public virtual DbSet<DM_DoiTuong> DM_DoiTuong { get; set; }
        public virtual DbSet<DM_DoiTuongChinhSach> DM_DoiTuongChinhSach { get; set; }
        public virtual DbSet<DM_DoiTuongUuTien_2022> DM_DoiTuongUuTien_2022 { get; set; }
        public virtual DbSet<DM_DonViDaoTao> DM_DonViDaoTao { get; set; }
        public virtual DbSet<DM_Dung2Tay_2022> DM_Dung2Tay_2022 { get; set; }
        public virtual DbSet<DM_DungDiLai_2022> DM_DungDiLai_2022 { get; set; }
        public virtual DbSet<DM_GioiTinh> DM_GioiTinh { get; set; }
        public virtual DbSet<DM_HinhThucLamViec_2022> DM_HinhThucLamViec_2022 { get; set; }
        public virtual DbSet<DM_HinhThucTuyenDung_2022> DM_HinhThucTuyenDung_2022 { get; set; }
        public virtual DbSet<DM_HocPhi> DM_HocPhi { get; set; }
        public virtual DbSet<DM_HocVan> DM_HocVan { get; set; }
        public virtual DbSet<DM_KinhNghiem_2022> DM_KinhNghiem_2022 { get; set; }
        public virtual DbSet<DM_KyNangMem_2022> DM_KyNangMem_2022 { get; set; }
        public virtual DbSet<DM_KhuCongNghiep> DM_KhuCongNghiep { get; set; }
        public virtual DbSet<DM_LoaiCongViec> DM_LoaiCongViec { get; set; }
        public virtual DbSet<DM_LoaiCoViecLam> DM_LoaiCoViecLam { get; set; }
        public virtual DbSet<DM_LoaiGiaoDich> DM_LoaiGiaoDich { get; set; }
        public virtual DbSet<DM_LoaiHinhDoanhNghiep> DM_LoaiHinhDoanhNghiep { get; set; }
        public virtual DbSet<DM_LoaiHopDong_2022> DM_LoaiHopDong_2022 { get; set; }
        public virtual DbSet<DM_LoaiTimViecLam> DM_LoaiTimViecLam { get; set; }
        public virtual DbSet<DM_LoaiTinhTrang> DM_LoaiTinhTrang { get; set; }
        public virtual DbSet<DM_LoaiTuVan> DM_LoaiTuVan { get; set; }
        public virtual DbSet<DM_LoaiViecLamTrong> DM_LoaiViecLamTrong { get; set; }
        public virtual DbSet<DM_LocTenDoanhNghiep> DM_LocTenDoanhNghiep { get; set; }
        public virtual DbSet<DM_LyDoHuyC> DM_LyDoHuyC { get; set; }
        public virtual DbSet<DM_LyDoNghiViec> DM_LyDoNghiViec { get; set; }
        public virtual DbSet<DM_MongMuonDN_2022> DM_MongMuonDN_2022 { get; set; }
        public virtual DbSet<DM_MucDichLamViec_2022> DM_MucDichLamViec_2022 { get; set; }
        public virtual DbSet<DM_MucLuong2022> DM_MucLuong2022 { get; set; }
        public virtual DbSet<DM_NoiCapGPLX> DM_NoiCapGPLX { get; set; }
        public virtual DbSet<DM_NoiLamViec_2022> DM_NoiLamViec_2022 { get; set; }
        public virtual DbSet<DM_NganHang> DM_NganHang { get; set; }
        public virtual DbSet<DM_NganhKinhDoanh> DM_NganhKinhDoanh { get; set; }
        public virtual DbSet<DM_NganhKinhTe2022> DM_NganhKinhTe2022 { get; set; }
        public virtual DbSet<DM_NganhLaoDong> DM_NganhLaoDong { get; set; }
        public virtual DbSet<DM_NgheHoc> DM_NgheHoc { get; set; }
        public virtual DbSet<DM_NgheKinhDoanh> DM_NgheKinhDoanh { get; set; }
        public virtual DbSet<DM_NgheLaoDong> DM_NgheLaoDong { get; set; }
        public virtual DbSet<DM_NgheNoi_2022> DM_NgheNoi_2022 { get; set; }
        public virtual DbSet<DM_NgheNghiep34_2022> DM_NgheNghiep34_2022 { get; set; }
        public virtual DbSet<DM_NghiepVu> DM_NghiepVu { get; set; }
        public virtual DbSet<DM_QuocGia> DM_QuocGia { get; set; }
        public virtual DbSet<DM_QuocGia2022> DM_QuocGia2022 { get; set; }
        public virtual DbSet<DM_TinhTrangHSHocNghe> DM_TinhTrangHSHocNghe { get; set; }
        public virtual DbSet<DM_TinhTrangPheDuyetHoSo> DM_TinhTrangPheDuyetHoSo { get; set; }
        public virtual DbSet<DM_TinhTrangViecLam> DM_TinhTrangViecLam { get; set; }
        public virtual DbSet<DM_TonGiao> DM_TonGiao { get; set; }
        public virtual DbSet<DM_ThaoTacBangTay_2022> DM_ThaoTacBangTay_2022 { get; set; }
        public virtual DbSet<DM_ThiLuc_2022> DM_ThiLuc_2022 { get; set; }
        public virtual DbSet<DM_ThoiGianLamViec> DM_ThoiGianLamViec { get; set; }
        public virtual DbSet<DM_TrinhDoChuyenMon> DM_TrinhDoChuyenMon { get; set; }
        public virtual DbSet<DM_TrinhDoHocVan_2022> DM_TrinhDoHocVan_2022 { get; set; }
        public virtual DbSet<DM_TrongLuongNang_2022> DM_TrongLuongNang_2022 { get; set; }
        public virtual DbSet<DM_YeuCauThem_2022> DM_YeuCauThem_2022 { get; set; }
        public virtual DbSet<DoanhNghiep> DoanhNghiep { get; set; }
        public virtual DbSet<DoanhNghiep_DangKyPhongVan_2022> DoanhNghiep_DangKyPhongVan_2022 { get; set; }
        public virtual DbSet<DoanhNghiep_QuaTrinhGiaoDich> DoanhNghiep_QuaTrinhGiaoDich { get; set; }
        public virtual DbSet<DoanhNghiep_QuaTrinhMau2829> DoanhNghiep_QuaTrinhMau2829 { get; set; }
        public virtual DbSet<DoanhNghiep_QuaTrinhTuyenDung> DoanhNghiep_QuaTrinhTuyenDung { get; set; }
        public virtual DbSet<DoanhNghiep_TuVanTimUngVien> DoanhNghiep_TuVanTimUngVien { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung> DoanhNghiep_TuyenDung { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_DiaDiemLamViec2023> DoanhNghiep_TuyenDung_LaoDongNuocNgoai_DiaDiemLamViec2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_MoTaKinhNghiem2023> DoanhNghiep_TuyenDung_LaoDongNuocNgoai_MoTaKinhNghiem2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_MoTaLuong2023> DoanhNghiep_TuyenDung_LaoDongNuocNgoai_MoTaLuong2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_ThoiGianLamViec2023> DoanhNghiep_TuyenDung_LaoDongNuocNgoai_ThoiGianLamViec2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_NghiepVu> DoanhNghiep_TuyenDung_NghiepVu { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_NgoaiNgu> DoanhNghiep_TuyenDung_NgoaiNgu { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_TinHoc> DoanhNghiep_TuyenDung_TinHoc { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_ThamGiaSan_2022> DoanhNghiep_TuyenDung_ThamGiaSan_2022 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_TrinhDoCMKT_2022> DoanhNghiep_TuyenDung_TrinhDoCMKT_2022 { get; set; }
        public virtual DbSet<DoanhNgiep_TuyenDung_CheDoPhucLoi_2022> DoanhNgiep_TuyenDung_CheDoPhucLoi_2022 { get; set; }
        public virtual DbSet<DoanhNgiep_TuyenDung_DieKienLamViec_2022> DoanhNgiep_TuyenDung_DieKienLamViec_2022 { get; set; }
        public virtual DbSet<DoanhNgiep_TuyenDung_KyNangMem_2022> DoanhNgiep_TuyenDung_KyNangMem_2022 { get; set; }
        public virtual DbSet<Friends_SanOnline> Friends_SanOnline { get; set; }
        public virtual DbSet<GiamThi> GiamThi { get; set; }
        public virtual DbSet<GiaoVien> GiaoVien { get; set; }
        public virtual DbSet<HocNghe_FileDinhKem> HocNghe_FileDinhKem { get; set; }
        public virtual DbSet<HocVien> HocVien { get; set; }
        public virtual DbSet<HocVien_BoHoc> HocVien_BoHoc { get; set; }
        public virtual DbSet<HocVienTotNghiep> HocVienTotNghiep { get; set; }
        public virtual DbSet<hoso> hoso { get; set; }
        public virtual DbSet<Hoso_BHTN> Hoso_BHTN { get; set; }
        public virtual DbSet<HoSo_GioiThieuViecLam> HoSo_GioiThieuViecLam { get; set; }
        public virtual DbSet<KetQua_Thi> KetQua_Thi { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KhachHang_DangKyPhongVan_2022> KhachHang_DangKyPhongVan_2022 { get; set; }
        public virtual DbSet<KhachHang_HocNghe> KhachHang_HocNghe { get; set; }
        public virtual DbSet<KhachHang_KinhNghiem_LamViec_2022> KhachHang_KinhNghiem_LamViec_2022 { get; set; }
        public virtual DbSet<KhachHang_NghiepVu> KhachHang_NghiepVu { get; set; }
        public virtual DbSet<KhachHang_QuaTrinhBHTN> KhachHang_QuaTrinhBHTN { get; set; }
        public virtual DbSet<KhachHang_QuaTrinhHocNghe> KhachHang_QuaTrinhHocNghe { get; set; }
        public virtual DbSet<KhachHang_QuaTrinhLamViec> KhachHang_QuaTrinhLamViec { get; set; }
        public virtual DbSet<KhachHang_QuaTrinhMau2829> KhachHang_QuaTrinhMau2829 { get; set; }
        public virtual DbSet<KhachHang_TimViec_CheDoPhucLoi_2022> KhachHang_TimViec_CheDoPhucLoi_2022 { get; set; }
        public virtual DbSet<KhachHang_TimViec_KinhNghiem_2022> KhachHang_TimViec_KinhNghiem_2022 { get; set; }
        public virtual DbSet<KhachHang_TimViec_KyNangMem_2022> KhachHang_TimViec_KyNangMem_2022 { get; set; }
        public virtual DbSet<KhachHang_TimViec_NgoaiNgu_2022> KhachHang_TimViec_NgoaiNgu_2022 { get; set; }
        public virtual DbSet<KhachHang_TimViec_TinHoc> KhachHang_TimViec_TinHoc { get; set; }
        public virtual DbSet<KhachHang_TimViec_TrinhDoCMKT_2022> KhachHang_TimViec_TrinhDoCMKT_2022 { get; set; }
        public virtual DbSet<KhachHang_TimViecLam> KhachHang_TimViecLam { get; set; }
        public virtual DbSet<KhachHang_TimViecLam_FileDinhKem> KhachHang_TimViecLam_FileDinhKem { get; set; }
        public virtual DbSet<KhachHang_TinhTrang> KhachHang_TinhTrang { get; set; }
        public virtual DbSet<KhachHang_TuVanTimViecLam> KhachHang_TuVanTimViecLam { get; set; }
        public virtual DbSet<KhachHang_TrinhDo> KhachHang_TrinhDo { get; set; }
        public virtual DbSet<KhoaDaoTao> KhoaDaoTao { get; set; }
        public virtual DbSet<KhoaDaoTao_FileDinhKem> KhoaDaoTao_FileDinhKem { get; set; }
        public virtual DbSet<LaoDong_BHTN_TuVanTimViecLam> LaoDong_BHTN_TuVanTimViecLam { get; set; }
        public virtual DbSet<LaoDong_TimViecLam> LaoDong_TimViecLam { get; set; }
        public virtual DbSet<LaoDong_TuVanTimViecLam> LaoDong_TuVanTimViecLam { get; set; }
        public virtual DbSet<LaoDongTimViec_FileDinhKem> LaoDongTimViec_FileDinhKem { get; set; }
        public virtual DbSet<m_gioithieu> m_gioithieu { get; set; }
        public virtual DbSet<mau28> mau28 { get; set; }
        public virtual DbSet<mau28_congty> mau28_congty { get; set; }
        public virtual DbSet<mau28_ChuyenMonKyThuat> mau28_ChuyenMonKyThuat { get; set; }
        public virtual DbSet<mau28_DM_ChucDanh> mau28_DM_ChucDanh { get; set; }
        public virtual DbSet<mau28_DM_DanToc> mau28_DM_DanToc { get; set; }
        public virtual DbSet<mau28_DM_LoaiHDLD> mau28_DM_LoaiHDLD { get; set; }
        public virtual DbSet<mau28_DM_LoaiKhaiBao> mau28_DM_LoaiKhaiBao { get; set; }
        public virtual DbSet<mau28_DM_LyDoChamDutHD> mau28_DM_LyDoChamDutHD { get; set; }
        public virtual DbSet<Mau2829> Mau2829 { get; set; }
        public virtual DbSet<Message_SanOnline> Message_SanOnline { get; set; }
        public virtual DbSet<Message_VoidChat> Message_VoidChat { get; set; }
        public virtual DbSet<MessageVoidChat_TuVan> MessageVoidChat_TuVan { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCategories> NewsCategories { get; set; }
        public virtual DbSet<NTV_SanOnline> NTV_SanOnline { get; set; }
        public virtual DbSet<NhanVien_LoaiTaiKhoan> NhanVien_LoaiTaiKhoan { get; set; }
        public virtual DbSet<NhanVien_TaiKhoan> NhanVien_TaiKhoan { get; set; }
        public virtual DbSet<NhatKy_Admin> NhatKy_Admin { get; set; }
        public virtual DbSet<NhatKy_TuVanSignalR> NhatKy_TuVanSignalR { get; set; }
        public virtual DbSet<NhatKyDangNhap2> NhatKyDangNhap2 { get; set; }
        public virtual DbSet<PhongHoc> PhongHoc { get; set; }
        public virtual DbSet<PHU_HSTD_Luu> PHU_HSTD_Luu { get; set; }
        public virtual DbSet<PHU_HSTV_Luu> PHU_HSTV_Luu { get; set; }
        public virtual DbSet<QRCode> QRCode { get; set; }
        public virtual DbSet<SVL_PhienGiaoDich> SVL_PhienGiaoDich { get; set; }
        public virtual DbSet<SVL_TuyenDung> SVL_TuyenDung { get; set; }
        public virtual DbSet<SVL_UngVien> SVL_UngVien { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TuVanHocNgheBHTN> TuVanHocNgheBHTN { get; set; }
        public virtual DbSet<ThongKe_DN_SanOnline_Online> ThongKe_DN_SanOnline_Online { get; set; }
        public virtual DbSet<ThongKe_NTV_SanOnline_Online> ThongKe_NTV_SanOnline_Online { get; set; }
        public virtual DbSet<User_SignlR> User_SignlR { get; set; }
        public virtual DbSet<UserSignIR_TuVan> UserSignIR_TuVan { get; set; }
        public virtual DbSet<UserWeb> UserWeb { get; set; }
        public virtual DbSet<VBPQ_DonVi> VBPQ_DonVi { get; set; }
        public virtual DbSet<VBPQ_LoaiTaiLieu> VBPQ_LoaiTaiLieu { get; set; }
        public virtual DbSet<VBPQ_TaiLieu> VBPQ_TaiLieu { get; set; }
        public virtual DbSet<Video_SanOnline> Video_SanOnline { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }
        public virtual DbSet<ViecLam_DaoTao> ViecLam_DaoTao { get; set; }
        public virtual DbSet<chinhanh> chinhanh { get; set; }
        public virtual DbSet<DM_DiaChi> DM_DiaChi { get; set; }
        public virtual DbSet<DM_NgheHocCND> DM_NgheHocCND { get; set; }
        public virtual DbSet<DN_SanOnline> DN_SanOnline { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_CongVan_List_2023> DoanhNghiep_TuyenDung_CongVan_List_2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_SendEmail_2023> DoanhNghiep_TuyenDung_SendEmail_2023 { get; set; }
        public virtual DbSet<ErrorPheDuyetTuyenDung_2023> ErrorPheDuyetTuyenDung_2023 { get; set; }
        public virtual DbSet<loaihoso> loaihoso { get; set; }
        public virtual DbSet<NewsStatus> NewsStatus { get; set; }
        public virtual DbSet<NgheNghiep34_2022Short> NgheNghiep34_2022Short { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aspnet_getmba>()
                .Property(e => e.AID)
                .IsUnicode(false);

            modelBuilder.Entity<aspnet_getmba>()
                .Property(e => e.ADate)
                .IsUnicode(false);

            modelBuilder.Entity<BHTN_CoViecLam>()
                .Property(e => e.IDBHTN)
                .IsUnicode(false);

            modelBuilder.Entity<BHTN_XacNhanThangHuong>()
                .Property(e => e.IDBHTN)
                .IsUnicode(false);

            modelBuilder.Entity<BHTN_XacNhanThangHuong>()
                .Property(e => e.CMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DM_CheDoPhucLoi_2022>()
                .Property(e => e.IconShow)
                .IsUnicode(false);

            modelBuilder.Entity<DM_ChucDanh>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_DonViDaoTao>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<DM_DonViDaoTao>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<DM_KhuCongNghiep>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LoaiHinhDoanhNghiep>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LoaiTinhTrang>()
                .Property(e => e.LoaiTinhTrang_ID)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LoaiViecLamTrong>()
                .Property(e => e.LoaiVLT_NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LyDoNghiViec>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_NgheHoc>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_QuocGia>()
                .Property(e => e.QuocGia_NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TinhTrangPheDuyetHoSo>()
                .Property(e => e.TinhTrangHoSo_NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_ThoiGianLamViec>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TrinhDoChuyenMon>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.MaVach)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.Skype)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.NguoiDaiDien_DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.MaSoThue)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.LoaiChuTheTuyenDung)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.MaChuTheTuyenDung)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_DangKyPhongVan_2022>()
                .Property(e => e.DienThoaiLD)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_DangKyPhongVan_2022>()
                .Property(e => e.DienThoaiDN)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_QuaTrinhMau2829>()
                .Property(e => e.MaSoThue)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung>()
                .Property(e => e.XoaHoSo)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung>()
                .Property(e => e.YeuCauNganhNghe_34_2022)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung>()
                .Property(e => e.MongMuonDN_2022)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung>()
                .Property(e => e.YeuCauThem_2022)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_ThoiGianLamViec2023>()
                .Property(e => e.ThoiGianTu)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_ThoiGianLamViec2023>()
                .Property(e => e.ThoiGianDen)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_ThamGiaSan_2022>()
                .Property(e => e.NgayThamGiaSan)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<HocNghe_FileDinhKem>()
                .Property(e => e.TenFileMaHoa)
                .IsUnicode(false);

            modelBuilder.Entity<HocNghe_FileDinhKem>()
                .Property(e => e.NguoiUpFile)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.MaHocVien)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.SoCMND)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.SoBHXH)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.MaVach)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.ThuongTruId)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien>()
                .Property(e => e.TamTruId)
                .IsUnicode(false);

            modelBuilder.Entity<HocVien_BoHoc>()
                .Property(e => e.NguoiThaoTac)
                .IsUnicode(false);

            modelBuilder.Entity<HocVienTotNghiep>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<hoso>()
                .Property(e => e.khachhang_id)
                .IsUnicode(false);

            modelBuilder.Entity<hoso>()
                .Property(e => e.MCTH_HS_id)
                .IsUnicode(false);

            modelBuilder.Entity<Hoso_BHTN>()
                .Property(e => e.BHTN_tc_chedohuong)
                .IsUnicode(false);

            modelBuilder.Entity<Hoso_BHTN>()
                .Property(e => e.BHTN_tc_kieu)
                .IsUnicode(false);

            modelBuilder.Entity<Hoso_BHTN>()
                .Property(e => e.BHTN_Trungtam)
                .IsUnicode(false);

            modelBuilder.Entity<Hoso_BHTN>()
                .Property(e => e.BHTN_Nguoidua)
                .IsUnicode(false);

            modelBuilder.Entity<Hoso_BHTN>()
                .Property(e => e.hdld_hdlv)
                .IsUnicode(false);

            modelBuilder.Entity<HoSo_GioiThieuViecLam>()
                .Property(e => e.SoGiayGTVL)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaVach)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoGiayPhepLaiXe)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.HangGPLX)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoBHXH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Sotaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Skype)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_DangKyPhongVan_2022>()
                .Property(e => e.DienThoaiDN)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_DangKyPhongVan_2022>()
                .Property(e => e.DienThoaiLD)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_KinhNghiem_LamViec_2022>()
                .Property(e => e.TuThang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_KinhNghiem_LamViec_2022>()
                .Property(e => e.DenThang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_QuaTrinhMau2829>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViec_KinhNghiem_2022>()
                .Property(e => e.TuThang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViec_KinhNghiem_2022>()
                .Property(e => e.DenThang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.DiemHoSo)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.NganhNghe34_2022)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.MucLuong_2022)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.KhaNangDapUng_2022)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.SanSangLamViec_2022)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam_FileDinhKem>()
                .Property(e => e.NguoiUpload)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TrinhDo>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<KhoaDaoTao>()
                .Property(e => e.NgayHoc_TrongTuan)
                .IsUnicode(false);

            modelBuilder.Entity<KhoaDaoTao_FileDinhKem>()
                .Property(e => e.TenFileMaHoa)
                .IsUnicode(false);

            modelBuilder.Entity<KhoaDaoTao_FileDinhKem>()
                .Property(e => e.DuongDanFile)
                .IsUnicode(false);

            modelBuilder.Entity<KhoaDaoTao_FileDinhKem>()
                .Property(e => e.NguoiUpFile)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDong_BHTN_TuVanTimViecLam>()
                .Property(e => e.BHTN_ID)
                .IsFixedLength();

            modelBuilder.Entity<LaoDong_TimViecLam>()
                .Property(e => e.BHTN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDong_TimViecLam>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDong_TimViecLam>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDong_TimViecLam>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDong_TimViecLam>()
                .Property(e => e.MaDiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDong_TimViecLam>()
                .Property(e => e.NgaySinh)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDongTimViec_FileDinhKem>()
                .Property(e => e.TenFileMaHoa)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDongTimViec_FileDinhKem>()
                .Property(e => e.DuongDanFile)
                .IsUnicode(false);

            modelBuilder.Entity<LaoDongTimViec_FileDinhKem>()
                .Property(e => e.NguoiUpFile)
                .IsUnicode(false);

            modelBuilder.Entity<mau28>()
                .Property(e => e.cmnd)
                .IsUnicode(false);

            modelBuilder.Entity<mau28>()
                .Property(e => e.so_bhxh)
                .IsUnicode(false);

            modelBuilder.Entity<mau28>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<mau28>()
                .Property(e => e.nguoi_khaibaotang)
                .IsUnicode(false);

            modelBuilder.Entity<mau28>()
                .Property(e => e.nguoi_khaibaogiam)
                .IsUnicode(false);

            modelBuilder.Entity<mau28>()
                .Property(e => e.nguoi_capnhat)
                .IsUnicode(false);

            modelBuilder.Entity<mau28_congty>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<mau28_DM_LoaiHDLD>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<Message_SanOnline>()
                .Property(e => e.TinNhan_File)
                .IsUnicode(false);

            modelBuilder.Entity<Message_SanOnline>()
                .Property(e => e.group_chat)
                .IsUnicode(false);

            modelBuilder.Entity<Message_VoidChat>()
                .Property(e => e.TinNhan_File)
                .IsUnicode(false);

            modelBuilder.Entity<Message_VoidChat>()
                .Property(e => e.group_chat)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.msrepl_tran_version1)
                .IsUnicode(false);

            modelBuilder.Entity<NTV_SanOnline>()
                .Property(e => e.NguoiTimViecId)
                .IsUnicode(false);

            modelBuilder.Entity<NTV_SanOnline>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien_TaiKhoan>()
                .Property(e => e.TenTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien_TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhatKy_TuVanSignalR>()
                .Property(e => e.IDKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<NhatKyDangNhap2>()
                .Property(e => e.IpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<NhatKyDangNhap2>()
                .Property(e => e.MacAddress)
                .IsUnicode(false);

            modelBuilder.Entity<SVL_UngVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SVL_UngVien>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<TuVanHocNgheBHTN>()
                .Property(e => e.NgheTuVan)
                .IsUnicode(false);

            modelBuilder.Entity<ThongKe_DN_SanOnline_Online>()
                .Property(e => e.DoanhNghiep_Id)
                .IsUnicode(false);

            modelBuilder.Entity<ThongKe_DN_SanOnline_Online>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<ThongKe_NTV_SanOnline_Online>()
                .Property(e => e.NguoiTimViec_Id)
                .IsUnicode(false);

            modelBuilder.Entity<ThongKe_NTV_SanOnline_Online>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<UserSignIR_TuVan>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<UserSignIR_TuVan>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserSignIR_TuVan>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<Video_SanOnline>()
                .Property(e => e.TinNhan_File)
                .IsUnicode(false);

            modelBuilder.Entity<Video_SanOnline>()
                .Property(e => e.Chat_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Video_SanOnline>()
                .Property(e => e.group_chat)
                .IsUnicode(false);

            modelBuilder.Entity<Video_SanOnline>()
                .Property(e => e.uid)
                .IsUnicode(false);

            modelBuilder.Entity<ViecLam_DaoTao>()
                .Property(e => e.BHTN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ViecLam_DaoTao>()
                .Property(e => e.MucLuong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ViecLam_DaoTao>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<chinhanh>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);

            modelBuilder.Entity<chinhanh>()
                .Property(e => e.MaCN)
                .IsUnicode(false);

            modelBuilder.Entity<DM_NgheHocCND>()
                .Property(e => e.SoThangHoc)
                .IsUnicode(false);

            modelBuilder.Entity<DM_NgheHocCND>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DN_SanOnline>()
                .Property(e => e.DoanhNghiep_Id)
                .IsUnicode(false);

            modelBuilder.Entity<DN_SanOnline>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_CongVan_List_2023>()
                .Property(e => e.GuiId)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_CongVan_List_2023>()
                .Property(e => e.SoCongVan)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_CongVan_List_2023>()
                .Property(e => e.NgayCongVan)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_SendEmail_2023>()
                .Property(e => e.GuiId)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorPheDuyetTuyenDung_2023>()
                .Property(e => e.ThoiGianTuE)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorPheDuyetTuyenDung_2023>()
                .Property(e => e.ThoiGianDenE)
                .IsUnicode(false);

            modelBuilder.Entity<loaihoso>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);
        }
    }
}
