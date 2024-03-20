namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LocTenDoanhNghiep
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string NoiDung { get; set; }

        [StringLength(150)]
        public string GhiChu { get; set; }
    }
}
