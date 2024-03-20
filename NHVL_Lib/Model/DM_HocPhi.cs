namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_HocPhi
    {
        public int id { get; set; }

        [StringLength(300)]
        public string HocPhi_Ten { get; set; }

        public int? Tien_HocPhi { get; set; }

        public int? TinhTrang { get; set; }

        public DateTime? NgayHieuLuc { get; set; }

        public int? HocPhi_Nam { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }
    }
}
