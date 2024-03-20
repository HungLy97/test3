namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ViecLam_DaoTao
    {
        public int Id { get; set; }

        public int? MaKH { get; set; }

        public int? MaHocVien { get; set; }

        [StringLength(17)]
        public string BHTN_ID { get; set; }

        [StringLength(200)]
        public string TenCty { get; set; }

        [Column(TypeName = "money")]
        public decimal? MucLuong { get; set; }

        public int? NgheHocId { get; set; }

        public int? KhoaDaoTaoId { get; set; }

        public DateTime? NgayBatDauLamViec { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }
    }
}
