namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_SignlR
    {
        public int Id { get; set; }

        public int User_id { get; set; }

        [StringLength(200)]
        public string User_Name { get; set; }

        [StringLength(100)]
        public string Pass { get; set; }

        [StringLength(100)]
        public string PasswordSalt { get; set; }

        public int Loai_id { get; set; }

        public int? Loai_HSMax_id { get; set; }

        public DateTime? Ngayhethan { get; set; }

        [Required]
        [StringLength(20)]
        public string LoaiUser { get; set; }

        public bool Online { get; set; }

        [StringLength(500)]
        public string Ghichu { get; set; }

        public string GioiThieu { get; set; }

        public bool? Active { get; set; }

        public Guid msrepl_tran_version { get; set; }

        public DateTime? NgayLogin { get; set; }
    }
}
