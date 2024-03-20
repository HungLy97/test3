namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SVL_PhienGiaoDich
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string TenPhien { get; set; }

        public string DiaDiem { get; set; }

        public DateTime? ThoiGian_BatDau { get; set; }

        public DateTime? ThoiGian_KetThuc { get; set; }

        public bool? IsActive { get; set; }

        public int? LoaiPhien { get; set; }

        [StringLength(50)]
        public string Hotline { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public string MoTa { get; set; }

        public string KetQua { get; set; }

        public string FileDinhKem { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        public int? PortalId { get; set; }

        public Guid msrepl_tran_version { get; set; }
    }
}
