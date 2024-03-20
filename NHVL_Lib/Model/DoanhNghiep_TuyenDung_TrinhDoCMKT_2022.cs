namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNghiep_TuyenDung_TrinhDoCMKT_2022
    {
        [Key]
        public int TuyenDung_TrinhDo_ID { get; set; }

        public int? TuyenDung_ID { get; set; }

        public int? TrinhDoCMKT_ID { get; set; }

        public string MoTaChuyenNganh { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}
