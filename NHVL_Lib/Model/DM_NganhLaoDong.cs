namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_NganhLaoDong
    {
        [Key]
        public int NganhLaoDong_ID { get; set; }

        [StringLength(500)]
        public string TenNganhLaoDong { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        public bool? KichHoat { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }
    }
}
