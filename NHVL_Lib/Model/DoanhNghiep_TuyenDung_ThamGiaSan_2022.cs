namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNghiep_TuyenDung_ThamGiaSan_2022
    {
        [Key]
        public int TuyenDung_SanGDVL_ID { get; set; }

        public int? TuyenDung_ID { get; set; }

        [StringLength(10)]
        public string NgayThamGiaSan { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        public int? KichHoat { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
