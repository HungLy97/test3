namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongHoc")]
    public partial class PhongHoc
    {
        [Key]
        public int MaPhongHoc { get; set; }

        [StringLength(100)]
        public string TenPhongHoc { get; set; }

        public int? TinhTrang { get; set; }

        public int? MaChiNhanh { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }
    }
}
