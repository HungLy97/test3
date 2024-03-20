namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BHTN_XacNhanThangHuong
    {
        public int ID { get; set; }

        [StringLength(17)]
        public string IDBHTN { get; set; }

        [StringLength(15)]
        public string CMND { get; set; }

        public DateTime? NgayDeNghi { get; set; }

        public DateTime? NgayGui { get; set; }

        public DateTime? NgayXacNhan { get; set; }

        public int? SoThangXacNhan { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        [StringLength(50)]
        public string SoCVChuyenTinh { get; set; }

        [StringLength(50)]
        public string SoCVXacNhan { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
