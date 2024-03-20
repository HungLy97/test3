namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_YeuCauThem_2022
    {
        [Key]
        public int YeuCauThem_ID { get; set; }

        [StringLength(2000)]
        public string TenYeuCau { get; set; }

        public bool? KichHoat { get; set; }
    }
}
