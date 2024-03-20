namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LyDoHuyC
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string LyDo { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
