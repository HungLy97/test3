namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserSignIR_TuVan
    {
        [Key]
        [StringLength(100)]
        public string UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(30)]
        public string Pass { get; set; }

        [Required]
        [StringLength(20)]
        public string LoaiUser { get; set; }

        [Required]
        [StringLength(300)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(200)]
        public string TrinhDoBanThan { get; set; }

        [Required]
        [StringLength(300)]
        public string NgheMongMuon { get; set; }

        [StringLength(500)]
        public string GioiThieu { get; set; }

        [Required]
        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public bool Online { get; set; }

        [StringLength(150)]
        public string SDT { get; set; }

        public DateTime? NgayTuvan { get; set; }

        public Guid msrepl_tran_version { get; set; }
    }
}
