namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hoso_BHTN
    {
        [Key]
        public int BHTN_ID { get; set; }

        public int? KH_ID { get; set; }

        public int? BHTN_Thangdong { get; set; }

        public int? BHTN_Mucdong { get; set; }

        public int? BHTN_Thanghuong { get; set; }

        public int? BHTN_Muchuong { get; set; }

        public DateTime? BHTN_Ngaydang { get; set; }

        public DateTime? BHTN_Ngayduyet { get; set; }

        public DateTime? BHTN_Ngaychamdut { get; set; }

        public DateTime? BHTN_Ngaynop { get; set; }

        public DateTime? BHTN_Ngayhuong { get; set; }

        public DateTime? BHTN_NgaytraHoso { get; set; }

        public int? DoanhNghiep_ID { get; set; }

        [StringLength(50)]
        public string BHTN_tc_chedohuong { get; set; }

        [StringLength(50)]
        public string BHTN_tc_kieu { get; set; }

        public int? BHTN_phong { get; set; }

        public int? BHTN_tinhtrang { get; set; }

        [StringLength(50)]
        public string BHTN_Trungtam { get; set; }

        public int? BHTN_Soquyetdinh { get; set; }

        [StringLength(50)]
        public string BHTN_NoiNhan { get; set; }

        [StringLength(50)]
        public string BHTN_Nguoidua { get; set; }

        [StringLength(50)]
        public string BHTN_Congviecdalam { get; set; }

        public int? BHTN_loai_hopdong { get; set; }

        public bool? BHTN_DaNhanKetQua { get; set; }

        [StringLength(50)]
        public string BHTN_tinhtrang_ten { get; set; }

        [StringLength(50)]
        public string BHTN_kiemtrahoso { get; set; }

        [StringLength(50)]
        public string BHTN_Nguyennhanthatnghiep { get; set; }

        [StringLength(50)]
        public string hdld_hdlv { get; set; }

        public int? ChiNhanh_ID { get; set; }

        public DateTime? Ngaytao { get; set; }

        public int? Nguoitao { get; set; }

        public DateTime? Ngaycapnhat { get; set; }

        public int? Nguoicapnhat { get; set; }

        public bool Kichhoat { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
