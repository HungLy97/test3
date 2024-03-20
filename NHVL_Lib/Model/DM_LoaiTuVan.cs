namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiTuVan
    {
        [Key]
        public int LoaiTuVan_ID { get; set; }

        [StringLength(50)]
        public string TenLoaiTuVan { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(150)]
        public string GhiChu { get; set; }
    }
}
