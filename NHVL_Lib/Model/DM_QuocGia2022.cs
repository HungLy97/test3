namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_QuocGia2022
    {
        [Key]
        public double STT { get; set; }

        [StringLength(255)]
        public string TenQuocGia { get; set; }
    }
}
