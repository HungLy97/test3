namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_QuaTrinhMau2829
    {
        [Key]
        public int QuaTrinhTangGiam_ID { get; set; }

        public int? DN_QuaTrinh2829_ID { get; set; }

        public int? KH_ID { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        public int? LoaiKhaiBao { get; set; }

        public int? TrinhDoCMKT { get; set; }

        public int? LoaiHDLD { get; set; }

        public DateTime? NgayHDLD { get; set; }

        public int? ViTriCongViec { get; set; }

        public int? MucLuongBHTN { get; set; }

        public int? SoThangBHTN { get; set; }

        public DateTime? NgayChamDutHDLD { get; set; }

        public int? LyDoChamDutHDLD { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
