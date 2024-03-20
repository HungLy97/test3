namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loaihoso")]
    public partial class loaihoso
    {
        public int id { get; set; }

        [StringLength(100)]
        public string tenhoso { get; set; }

        [StringLength(50)]
        public string ghichu { get; set; }

        public DateTime? ngaytao { get; set; }

        [StringLength(50)]
        public string nguoitao { get; set; }

        public bool? kickhoat { get; set; }
    }
}
