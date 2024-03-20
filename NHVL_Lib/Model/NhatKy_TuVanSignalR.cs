namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NhatKy_TuVanSignalR
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string NV_TuVan { get; set; }

        [Required]
        [StringLength(100)]
        public string IDKhachHang { get; set; }

        [Required]
        [StringLength(300)]
        public string TenKhachHang { get; set; }

        [Required]
        [StringLength(20)]
        public string LoaiUser { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public DateTime NgayTuvan { get; set; }
    }
}
