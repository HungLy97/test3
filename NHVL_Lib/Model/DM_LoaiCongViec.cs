namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiCongViec
    {
        [Key]
        public int LoaiCongViec_ID { get; set; }

        [StringLength(150)]
        public string TenLoaiCongViec { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(150)]
        public string GhiChu { get; set; }
    }
}
