namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_NgheHocCND
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string TenNgheHoc { get; set; }

        [StringLength(4)]
        public string SoThangHoc { get; set; }

        [StringLength(200)]
        public string Img { get; set; }

        [StringLength(200)]
        public string Link { get; set; }

        public bool? TrangThai { get; set; }

        public string NoiDung { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }
    }
}
