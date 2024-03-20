namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NhatKyDangNhap2
    {
        [Key]
        public int NhatKyDangNhap_ID { get; set; }

        public int? TaiKhoanID { get; set; }

        public int? LoaiTaiKhoanID { get; set; }

        [StringLength(200)]
        public string ComputerName { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(200)]
        public string Country { get; set; }

        [StringLength(200)]
        public string MacAddress { get; set; }

        public DateTime? ThoiGianDangNhap { get; set; }
    }
}
