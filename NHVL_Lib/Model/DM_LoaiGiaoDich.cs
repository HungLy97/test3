namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiGiaoDich
    {
        [Key]
        public int LoaiGiaoDich_ID { get; set; }

        [StringLength(500)]
        public string TenLoaiGiaoDich { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public bool? KichHoat { get; set; }
    }
}
