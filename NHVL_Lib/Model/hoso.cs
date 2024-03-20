namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hoso")]
    public partial class hoso
    {
        public int id { get; set; }

        public int? loaihoso_id { get; set; }

        [StringLength(50)]
        public string khachhang_id { get; set; }

        [StringLength(50)]
        public string MCTH_HS_id { get; set; }

        public int? nguoinhan { get; set; }

        public DateTime? ngaynhan { get; set; }

        public DateTime? ngaytra { get; set; }

        [StringLength(50)]
        public string ghichu { get; set; }

        [StringLength(200)]
        public string nganhang { get; set; }

        [StringLength(30)]
        public string Chinhanh { get; set; }
    }
}
