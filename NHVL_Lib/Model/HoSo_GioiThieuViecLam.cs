namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HoSo_GioiThieuViecLam
    {
        [Key]
        public int GTVL_ID { get; set; }

        public int? TuVanTVL_ID { get; set; }

        public int? TuVanTUV_ID { get; set; }

        public int? LoaiGTVL_ID { get; set; }

        [StringLength(50)]
        public string SoGiayGTVL { get; set; }

        public DateTime? NgayHetHan { get; set; }

        [StringLength(1000)]
        public string NoiDungPhongVan { get; set; }

        public DateTime? NgayPhongVan { get; set; }

        public bool? KetQuaPhongVan { get; set; }

        [StringLength(1000)]
        public string DN_PhanHoiYKien { get; set; }

        public bool? DN_DongY { get; set; }

        [StringLength(1000)]
        public string KH_PhanHoiYKien { get; set; }

        public bool? KH_DongY { get; set; }

        public int? ChiNhanh_ID { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? NguoiCapNhat { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
