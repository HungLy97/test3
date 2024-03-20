namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LaoDong_TimViecLam
    {
        [Key]
        public int TimViec_ID { get; set; }

        public int? KH_ID { get; set; }

        public int? HocNghe_ID { get; set; }

        [StringLength(50)]
        public string BHTN_ID { get; set; }

        [StringLength(300)]
        public string TenHoSo { get; set; }

        public int? ChucDanhMongMuon { get; set; }

        public int? MucLuongMongMuonTu { get; set; }

        public int? MucLuongMongMuonDen { get; set; }

        public int? ThoiGianLamViecMongMuon { get; set; }

        public bool? CoTheDiCongTac { get; set; }

        public int? NganhMongMuon_ID { get; set; }

        public int? NgheMongMuon_ID { get; set; }

        public int? LoaiHinhDNMongMuon_ID { get; set; }

        public int? NoiLamViecMongMuon_ID { get; set; }

        public int? MucLuongCu { get; set; }

        public int? LyDoNghiViec_ID { get; set; }

        public int? CongTyNghiViec_ID { get; set; }

        public string MoTaKinhNghiemLamViec { get; set; }

        public int? SoNamKinhNghiem { get; set; }

        public string KhaNangNoiTroi { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public DateTime? NgayCoTheLamViec { get; set; }

        public DateTime? NgayHoSoHetHan { get; set; }

        public bool? HienThiTrenWeb { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [StringLength(15)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        public int? TrinhDoChuyenMon { get; set; }

        public int? TrinhDoHocVan { get; set; }

        public int? NghiepVu { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(100)]
        public string MaDiaChi { get; set; }

        public int? GioiTinh { get; set; }

        [StringLength(10)]
        public string NgaySinh { get; set; }

        public DateTime? NgayCapCMND { get; set; }

        [StringLength(100)]
        public string NoiCap { get; set; }
    }
}
