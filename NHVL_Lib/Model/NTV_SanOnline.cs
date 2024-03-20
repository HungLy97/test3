namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NTV_SanOnline
    {
        [Key]
        [StringLength(100)]
        public string NguoiTimViecId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserId { get; set; }

        public int PhienId { get; set; }

        public int TinhTrang { get; set; }

        public DateTime NgayThamGia { get; set; }

        public int DangNhap_Status { get; set; }

        public int? Hoso_id { get; set; }
    }
}
