namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TinhTrangPheDuyetHoSo
    {
        [Key]
        public int TinhTrangHoSo_ID { get; set; }

        [StringLength(50)]
        public string TinhTrangHoSo_Ten { get; set; }

        public bool? TinhTrangHoSo_KichHoat { get; set; }

        public DateTime? TinhTrangHoSo_NgayTao { get; set; }

        [StringLength(50)]
        public string TinhTrangHoSo_NguoiTao { get; set; }
    }
}
