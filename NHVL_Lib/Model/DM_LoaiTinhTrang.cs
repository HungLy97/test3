namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiTinhTrang
    {
        [Key]
        [StringLength(50)]
        public string LoaiTinhTrang_ID { get; set; }

        [StringLength(50)]
        public string TenTinhTrang { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
