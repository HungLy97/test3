namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_DonViDaoTao
    {
        public int Id { get; set; }

        [StringLength(6)]
        public string MaDV { get; set; }

        [StringLength(100)]
        public string TenDV { get; set; }

        [StringLength(20)]
        public string DienThoai { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string LanhDao { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(30)]
        public string NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(300)]
        public string DiaDiemDaoTao { get; set; }
    }
}
