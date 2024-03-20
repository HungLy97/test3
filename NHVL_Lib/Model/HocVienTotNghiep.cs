namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocVienTotNghiep")]
    public partial class HocVienTotNghiep
    {
        public int id { get; set; }

        public int? KhachHangId { get; set; }

        public int? MaHocVien { get; set; }

        public int? IdNghe { get; set; }

        public int? SoChungChi { get; set; }

        public DateTime? NgayTotNghiep { get; set; }

        public DateTime? NgayXetTotNghiep { get; set; }

        public int? TotNghiep { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        public int? IsDelete { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }
    }
}
