namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NhanVien_TaiKhoan
    {
        [Key]
        public int NhanVien_TaiKhoan_ID { get; set; }

        public int? LoaiTaiKhoan { get; set; }

        [StringLength(50)]
        public string TenTaiKhoan { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(500)]
        public string TenHienThi { get; set; }

        public bool? KichHoat { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
