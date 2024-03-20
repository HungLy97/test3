namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_Dung2Tay_2022
    {
        [Key]
        public int Dung2Tay_ID { get; set; }

        [StringLength(2000)]
        public string Dung2Tay_Ten { get; set; }

        public bool? KichHoat { get; set; }
    }
}
