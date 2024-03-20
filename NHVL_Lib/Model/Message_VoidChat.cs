namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message_VoidChat
    {
        [Key]
        public int ID_TinNhan { get; set; }

        public string TinNhan_Text { get; set; }

        public string TinNhan_File { get; set; }

        public int User_Gui { get; set; }

        public int User_Nhan { get; set; }

        public int? PhienId { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(61)]
        public string group_chat { get; set; }

        public bool? Status { get; set; }

        [StringLength(100)]
        public string Duyet { get; set; }

        [StringLength(100)]
        public string NguoiUpdate { get; set; }
    }
}
