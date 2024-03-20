namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chinhanh")]
    public partial class chinhanh
    {
        public int id { get; set; }

        [StringLength(200)]
        public string tenchinhanh { get; set; }

        public DateTime? ngaytao { get; set; }

        [StringLength(50)]
        public string nguoitao { get; set; }

        [StringLength(500)]
        public string ghichu { get; set; }

        [StringLength(50)]
        public string MaCN { get; set; }
    }
}
