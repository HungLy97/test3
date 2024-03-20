namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_KinhNghiem_LamViec_2022
    {
        [Key]
        public int KhachHang_KinhNghiem_LamViec_ID { get; set; }

        public int? KH_ID { get; set; }

        [StringLength(2000)]
        public string TenCongTy { get; set; }

        [StringLength(2000)]
        public string ChucVu { get; set; }

        [StringLength(8)]
        public string TuThang { get; set; }

        [StringLength(8)]
        public string DenThang { get; set; }

        [StringLength(2000)]
        public string CongViecChinh { get; set; }

        [StringLength(2000)]
        public string DaLamViecNuocNgoai { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}
