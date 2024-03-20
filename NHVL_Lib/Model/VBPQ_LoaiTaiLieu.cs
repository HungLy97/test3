namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VBPQ_LoaiTaiLieu
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string TenLoaiTaiLieu { get; set; }

        public int NguoiNhap { get; set; }

        public DateTime NgayNhap { get; set; }

        public bool IsActive { get; set; }

        public int OrderNumber { get; set; }

        [StringLength(2000)]
        public string MoTa { get; set; }

        public int PortalId { get; set; }

        public int ModuleId { get; set; }

        public Guid msrepl_tran_version { get; set; }
    }
}
