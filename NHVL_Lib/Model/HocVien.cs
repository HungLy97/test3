namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocVien")]
    public partial class HocVien
    {
        public int Id { get; set; }

        public int MaKH { get; set; }

        [StringLength(25)]
        public string MaHocVien { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public int? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(15)]
        public string SoCMND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCap { get; set; }

        [StringLength(50)]
        public string NoiCap { get; set; }

        public int? MaDinhDanh { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string DiaChi_ThuongTru { get; set; }

        [StringLength(200)]
        public string DiaChi_TamTru { get; set; }

        public int? DoiTuongId { get; set; }

        public int? NgheHocId { get; set; }

        public int? DonViDaoTaoId { get; set; }

        public int? LichHocId { get; set; }

        public int? HocPhiId { get; set; }

        public int? DTGiamHocPhiId { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public bool? NhanKetQua { get; set; }

        public int? HocNgheNam { get; set; }

        public int? HocNghe_SQD { get; set; }

        [StringLength(50)]
        public string SoBHXH { get; set; }

        public DateTime? HocNghe_NgayDuyet { get; set; }

        [StringLength(50)]
        public string MaVach { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string ThuongTruId { get; set; }

        [StringLength(50)]
        public string TamTruId { get; set; }

        public bool? IsDelete { get; set; }

        [StringLength(500)]
        public string LyDo_Xoa { get; set; }
    }
}
