namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_DoiTuongUuTien_2022
    {
        [Key]
        public int DoiTuongUuTien_ID { get; set; }

        [StringLength(2000)]
        public string DoiTuongUuTien_Ten { get; set; }

        public bool? KichHoat { get; set; }
    }
}
