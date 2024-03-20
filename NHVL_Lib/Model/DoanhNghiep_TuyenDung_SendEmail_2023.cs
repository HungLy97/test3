namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNghiep_TuyenDung_SendEmail_2023
    {
        public int ID { get; set; }

        public int? DN_ID { get; set; }

        [StringLength(500)]
        public string GuiId { get; set; }

        [StringLength(100)]
        public string LoaiEmail { get; set; }

        public bool? TinhTrangGui { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }
    }
}
