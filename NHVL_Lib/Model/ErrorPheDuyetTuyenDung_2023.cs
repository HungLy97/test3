namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ErrorPheDuyetTuyenDung_2023
    {
        public int ID { get; set; }

        public int? TuyenDung_ID { get; set; }

        [StringLength(2000)]
        public string ViTriTuyenE { get; set; }

        [StringLength(2000)]
        public string ChucDanhTuyenE { get; set; }

        [StringLength(10)]
        public string ThoiGianTuE { get; set; }

        [StringLength(10)]
        public string ThoiGianDenE { get; set; }

        public bool? TinhTrang { get; set; }

        [StringLength(2000)]
        public string GhiChu { get; set; }
    }
}
