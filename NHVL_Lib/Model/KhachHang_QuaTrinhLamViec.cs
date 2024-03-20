namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_QuaTrinhLamViec
    {
        [Key]
        public int QuaTrinhLamViec_ID { get; set; }

        public int? KH_ID { get; set; }

        public int? TimViec_ID { get; set; }

        public int? LoaiCoViecLam_ID { get; set; }

        public int? GTVL_ID { get; set; }

        public int? LoaiCongViec_ID { get; set; }

        [StringLength(500)]
        public string TenCongViec { get; set; }

        [StringLength(1000)]
        public string MoTaCongViec { get; set; }

        public int? ChucVu_ID { get; set; }

        public int? Nganh_ID { get; set; }

        public int? Nghe_ID { get; set; }

        public int? MucLuong { get; set; }

        public int? DN_ID { get; set; }

        public DateTime? NgayLamViec { get; set; }

        public DateTime? NgayKetThucHDLD { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }
    }
}
