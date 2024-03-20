namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KetQua_Thi
    {
        public int Id { get; set; }

        public int? MaHocVien { get; set; }

        public int? MaLichHoc { get; set; }

        public int? MaNgheHoc { get; set; }

        public int? MaGiaoVien { get; set; }

        public double? DiemLyThuyet { get; set; }

        public int? SoMonDat { get; set; }

        public int? DiemThiLuatGTDB { get; set; }

        public double? DiemThucHanh { get; set; }

        public int? DiemThiDuongTruong { get; set; }

        public int? DiemThiChuChi { get; set; }

        public double? DiemKiemTra { get; set; }

        public double? Mo_dun_1 { get; set; }

        public double? Mo_dun_2 { get; set; }

        public double? Mo_dun_3 { get; set; }

        public double? Mo_dun_4 { get; set; }

        public double? Mo_dun_5 { get; set; }

        [StringLength(50)]
        public string XepLoai { get; set; }

        [StringLength(50)]
        public string KetQua { get; set; }

        public int? NamHoc { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }
    }
}
