namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNghiep_TuVanTimUngVien
    {
        [Key]
        public int TuVanTUV_ID { get; set; }

        public int? DN_ID { get; set; }

        public int? TuyenDung_ID { get; set; }

        public int? KH_ID { get; set; }

        public int? TimViec_ID { get; set; }

        public int? LoaiTuVan_ID { get; set; }

        public int? GuiHSTVChoDNQuaMail { get; set; }

        public string NoiDungTuVan { get; set; }

        public string DN_PhanHoiYKien { get; set; }

        public bool? DongYGTUV { get; set; }

        public int? ChiNhanh_ID { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}
