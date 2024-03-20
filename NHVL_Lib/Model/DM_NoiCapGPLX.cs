namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_NoiCapGPLX
    {
        [Key]
        public int NoiCapGPLX_ID { get; set; }

        [StringLength(500)]
        public string TenNoiCapGPLX { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}
