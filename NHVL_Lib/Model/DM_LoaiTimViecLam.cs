namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiTimViecLam
    {
        [Key]
        public int LoaiTimViecLam_ID { get; set; }

        [StringLength(50)]
        public string TenLoaiTimViecLam { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
