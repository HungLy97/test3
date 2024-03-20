namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhachHang_DangKyPhongVan_2022
    {
        [Key]
        public int ID_DanKy_PhongVan { get; set; }

        public int? DN_Id { get; set; }

        public int? TuyenDung_Id { get; set; }

        public string TenCongTy { get; set; }

        [StringLength(200)]
        public string DienThoaiDN { get; set; }

        public string TuyenDungViTri { get; set; }

        [StringLength(100)]
        public string TenLaoDong { get; set; }

        [StringLength(15)]
        public string DienThoaiLD { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public string GhiChu { get; set; }

        public int? IsUser { get; set; }

        public int? XuLy { get; set; }
    }
}
