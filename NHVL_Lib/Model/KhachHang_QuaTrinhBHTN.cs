namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_QuaTrinhBHTN
    {
        [Key]
        public int QuaTrinhBHTN_ID { get; set; }

        public int? KH_ID { get; set; }

        public int? BHTN_ID { get; set; }

        public int? TinhTrangBHTN_ID { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
