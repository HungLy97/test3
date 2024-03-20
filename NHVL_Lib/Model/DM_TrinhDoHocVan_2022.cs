namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TrinhDoHocVan_2022
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TenHocVan { get; set; }

        public bool? KichHoat { get; set; }
    }
}
