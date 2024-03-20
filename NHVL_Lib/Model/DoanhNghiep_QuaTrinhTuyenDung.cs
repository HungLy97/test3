namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNghiep_QuaTrinhTuyenDung
    {
        [Key]
        public int QuaTrinhTuyenDung_ID { get; set; }

        public int? HSTD_ID { get; set; }

        public int? SoLuongTuyen { get; set; }

        public int? SoLuongDaTuyen { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? NguoiTao { get; set; }

        public int? NguoiCapNhat { get; set; }

        public string GhiChu { get; set; }
    }
}
