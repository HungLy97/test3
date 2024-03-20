namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiCoViecLam
    {
        [Key]
        public int LoaiCoViecLam_ID { get; set; }

        [StringLength(50)]
        public string TenLoaiCoViecLam { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
