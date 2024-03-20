namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_QuaTrinhHocNghe
    {
        [Key]
        public int QuaTrinhHocNghe_ID { get; set; }

        public int? KH_ID { get; set; }

        public int? HosoHN_ID { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
