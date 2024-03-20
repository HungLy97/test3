namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNgiep_TuyenDung_DieKienLamViec_2022
    {
        [Key]
        public int TuyenDung_DieuKienLamViec_ID { get; set; }

        public int? TuyenDung_ID { get; set; }

        public int? NoiLamViec_ID { get; set; }

        public int? TrongLuongNang_ID { get; set; }

        public int? DungDiLai_ID { get; set; }

        public int? NgheNoi_ID { get; set; }

        public int? ThiLuc_ID { get; set; }

        public int? ThaoTacBangTay_ID { get; set; }

        public int? Dung2Tay_ID { get; set; }

        [StringLength(500)]
        public string MoTaDieuKienLamViec { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}
