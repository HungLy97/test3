namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TuVanHocNgheBHTN")]
    public partial class TuVanHocNgheBHTN
    {
        public int Id { get; set; }

        public int? MaHocVien { get; set; }

        [StringLength(100)]
        public string NgheTuVan { get; set; }

        public DateTime? NgayTuVan { get; set; }

        [StringLength(50)]
        public string NguoiTuVan { get; set; }
    }
}
