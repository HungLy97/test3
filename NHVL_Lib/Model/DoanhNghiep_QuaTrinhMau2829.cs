namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNghiep_QuaTrinhMau2829
    {
        [Key]
        public int QuaTrinhKhaiBao_ID { get; set; }

        public int? DN_ID { get; set; }

        [StringLength(50)]
        public string MaSoThue { get; set; }

        public int? LoaiKhaiBao { get; set; }

        public int? SoLuongKhaiBao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
