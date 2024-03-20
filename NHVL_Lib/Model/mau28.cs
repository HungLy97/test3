namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mau28
    {
        public int ID { get; set; }

        public int? ID_congty { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        public bool? gioitinh { get; set; }

        [StringLength(50)]
        public string dantoc { get; set; }

        [StringLength(50)]
        public string cmnd { get; set; }

        [StringLength(50)]
        public string so_bhxh { get; set; }

        public int? CMKT_ID { get; set; }

        public int? LoaiHDLD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HD_Ngayhieuluc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HD_NgayKetThuc { get; set; }

        public int? vitri { get; set; }

        public int? BHTN_mucdong { get; set; }

        public int? BHTN_thoigianthamgia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaytao { get; set; }

        [StringLength(50)]
        public string nguoitao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_khaibaotang { get; set; }

        [StringLength(50)]
        public string nguoi_khaibaotang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_khaibaogiam { get; set; }

        [StringLength(50)]
        public string nguoi_khaibaogiam { get; set; }

        public int? Lydogiam_ID { get; set; }

        public DateTime? ngay_capnhat { get; set; }

        [StringLength(50)]
        public string nguoi_capnhat { get; set; }
    }
}
