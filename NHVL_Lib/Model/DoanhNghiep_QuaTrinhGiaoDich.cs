namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNghiep_QuaTrinhGiaoDich
    {
        [Key]
        public int QuaTrinhGiaoDich_ID { get; set; }

        public int? DN_ID { get; set; }

        public int? LoaiGiaoDich_ID { get; set; }

        [StringLength(1000)]
        public string NoiDungGiaoDich { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
