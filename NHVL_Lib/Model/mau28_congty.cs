namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mau28_congty
    {
        [Key]
        public int ID_congty { get; set; }

        [Required]
        [StringLength(500)]
        public string tencongty { get; set; }

        public string diachi { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        public int? tongsold { get; set; }

        public DateTime? ngaytao { get; set; }

        [StringLength(50)]
        public string nguoitao { get; set; }

        public DateTime? ngay_khaibao { get; set; }

        [StringLength(50)]
        public string nguoi_khaibao { get; set; }
    }
}
