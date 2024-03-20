namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HocVien_BoHoc
    {
        public int Id { get; set; }

        public int? MaNgheHoc { get; set; }

        public int? MaHocVien { get; set; }

        public int? MaLichHoc { get; set; }

        public DateTime? NgayThaoTac { get; set; }

        [StringLength(50)]
        public string NguoiThaoTac { get; set; }

        public int? TinhTrang { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
