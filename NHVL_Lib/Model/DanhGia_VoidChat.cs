namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DanhGia_VoidChat
    {
        public int ID { get; set; }

        public int IDDanhGia { get; set; }

        [StringLength(500)]
        public string TenDanhGia { get; set; }

        public int IDNhan { get; set; }

        [StringLength(500)]
        public string TenNhan { get; set; }

        public int MucDanhGia { get; set; }

        public string LyDoDanhGia { get; set; }

        public DateTime? Ngay { get; set; }
    }
}
