namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SVL_UngVien
    {
        public int Id { get; set; }

        public int NguoiTimViecId { get; set; }

        public int? LoaiUngVien { get; set; }

        [StringLength(500)]
        public string Ho_Dem { get; set; }

        [StringLength(500)]
        public string Ten { get; set; }

        [StringLength(500)]
        public string TenDayDu { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(500)]
        public string NoiSinh { get; set; }

        public string DiaChi { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Tel { get; set; }

        public int? NganhNghe { get; set; }

        public int? TrinhDoChuyenMon { get; set; }

        public int? NamKinhNghiem { get; set; }

        public int? ViTriUngTuyen { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        public int? PhienId { get; set; }

        public Guid msrepl_tran_version { get; set; }
    }
}
