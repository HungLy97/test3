namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TrinhDoChuyenMon
    {
        [Key]
        public int TrinhDoChuyenMon_ID { get; set; }

        [Required]
        [StringLength(2000)]
        public string TenChuyenMon { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        public bool? KichHoat { get; set; }

        public int? OrderTopTrinhDo { get; set; }
    }
}
