namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_DoiTuongChinhSach
    {
        [Key]
        public int DoiTuongChinhSach_ID { get; set; }

        [StringLength(200)]
        public string TenDoiTuongChinhSach { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}
