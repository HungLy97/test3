namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoaDaoTao")]
    public partial class KhoaDaoTao
    {
        public int Id { get; set; }

        public int Id_Nghe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKhaiGiang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public int? MaPhongHoc { get; set; }

        [StringLength(50)]
        public string NgayHoc_TrongTuan { get; set; }

        public TimeSpan? GioBatDau { get; set; }

        public TimeSpan? GioKetThuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKiemTraDuKien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThiDuKien { get; set; }

        public int? LichHoc_Nam { get; set; }

        public int? TinhTrang { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public bool? Isdelete { get; set; }

        public int? MaGiaoVien { get; set; }
    }
}
