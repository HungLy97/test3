namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Ten_GV { get; set; }

        public int? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(15)]
        public string CMND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCap { get; set; }

        [StringLength(100)]
        public string NoiCap { get; set; }

        public int? MaDinhDanh { get; set; }

        [StringLength(15)]
        public string DienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string TrinhDoChuyenMon { get; set; }

        [StringLength(100)]
        public string NganhNgheChuyenMon { get; set; }

        public int? KinhNghiem_GiangDay { get; set; }

        [Column("LoaiGiangDay(LT/TH)")]
        public int? LoaiGiangDay_LT_TH_ { get; set; }

        public int? TinhTrang { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(100)]
        public string FileType { get; set; }

        public byte[] Anh { get; set; }
    }
}
