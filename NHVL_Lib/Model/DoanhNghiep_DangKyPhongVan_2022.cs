namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DoanhNghiep_DangKyPhongVan_2022
    {
        [Key]
        public int ID_DangKy_PhongVan { get; set; }

        public int? KH_Id { get; set; }

        public int? TimViec_Id { get; set; }

        public string TenLaoDong { get; set; }

        [StringLength(15)]
        public string DienThoaiLD { get; set; }

        public string TimViecViTri { get; set; }

        [StringLength(100)]
        public string TenCongTy { get; set; }

        [StringLength(15)]
        public string DienThoaiDN { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public string GhiChu { get; set; }

        public int? IsUser { get; set; }

        public int? XuLy { get; set; }
    }
}
