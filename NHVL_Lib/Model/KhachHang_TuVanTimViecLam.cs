namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_TuVanTimViecLam
    {
        [Key]
        public int TuVanTVL_ID { get; set; }

        public int? KH_ID { get; set; }

        public int? HSTV_ID { get; set; }

        public int? DN_ID { get; set; }

        public int? TuyenDung_ID { get; set; }

        public int? NguonViecLamTrong_ID { get; set; }

        public int? LoaiTuVan_ID { get; set; }

        public int? GuiHSTDChoKHQuaMail { get; set; }

        public string NoiDungTuVan { get; set; }

        public string KH_PhanHoiYKien { get; set; }

        public bool? DongYGTVL { get; set; }

        public int? ChiNhanh_ID { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}
