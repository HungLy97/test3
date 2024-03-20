namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_NganhKinhTe2022
    {
        [Key]
        public double STT { get; set; }

        [StringLength(255)]
        public string Cap_1 { get; set; }

        [StringLength(255)]
        public string Cap_2 { get; set; }

        [StringLength(255)]
        public string Cap_3 { get; set; }

        [StringLength(255)]
        public string Cap_4 { get; set; }

        [StringLength(255)]
        public string Cap_5 { get; set; }

        [StringLength(255)]
        public string TenNganh { get; set; }
    }
}
