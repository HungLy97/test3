namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MessageVoidChat_TuVan
    {
        public int ID { get; set; }

        public string TinNhan_Text { get; set; }

        [StringLength(200)]
        public string TinNhan_File { get; set; }

        [Required]
        [StringLength(100)]
        public string User_Gui { get; set; }

        [Required]
        [StringLength(100)]
        public string User_Nhan { get; set; }

        public DateTime NgayTao { get; set; }

        public bool? Status { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }
    }
}
