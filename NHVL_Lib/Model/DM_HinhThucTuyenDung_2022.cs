namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_HinhThucTuyenDung_2022
    {
        [Key]
        public int HinhThucTuyenDung_ID { get; set; }

        [StringLength(2000)]
        public string HinhThucTuyenDung_Ten { get; set; }

        public bool? KichHoat { get; set; }
    }
}
