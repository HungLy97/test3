namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_LoaiViecLamTrong
    {
        [Key]
        public int LoaiVLT_ID { get; set; }

        [StringLength(200)]
        public string LoaiVLT_Ten { get; set; }

        public DateTime? LoaiVLT_NgayTao { get; set; }

        [StringLength(50)]
        public string LoaiVLT_NguoiTao { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }
    }
}
