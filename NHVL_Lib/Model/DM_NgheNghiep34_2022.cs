namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_NgheNghiep34_2022
    {
        public int ID { get; set; }

        public double? Cap_1 { get; set; }

        public double? Cap_2 { get; set; }

        public double? Cap_3 { get; set; }

        public double? Cap_4 { get; set; }

        public double? Cap_5 { get; set; }

        [StringLength(255)]
        public string TenNgheNghiep34 { get; set; }
    }
}
