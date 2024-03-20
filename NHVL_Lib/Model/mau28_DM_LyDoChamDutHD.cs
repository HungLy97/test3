namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mau28_DM_LyDoChamDutHD
    {
        [Key]
        public int LyDoChamDutHD_ID { get; set; }

        [StringLength(500)]
        public string TenLyDo { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
