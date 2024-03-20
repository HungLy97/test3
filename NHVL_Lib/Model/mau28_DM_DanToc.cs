namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mau28_DM_DanToc
    {
        [Key]
        public int DanToc_ID { get; set; }

        [StringLength(50)]
        public string TenDanToc { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
