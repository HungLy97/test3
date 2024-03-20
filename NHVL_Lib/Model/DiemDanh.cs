namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemDanh")]
    public partial class DiemDanh
    {
        public int Id { get; set; }

        public int? MaNgheHoc { get; set; }

        public int? MaHocVien { get; set; }

        public int? MaLichHoc { get; set; }

        public int? MaGiaoVien { get; set; }

        public DateTime? NgayDiemDanh { get; set; }

        public int? MaPhongHoc { get; set; }

        public int? NguoiDiemDanh { get; set; }

        public int? TinhTrang { get; set; }
    }
}
