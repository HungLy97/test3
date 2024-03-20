namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Video_SanOnline
    {
        [Key]
        public int ID_Video { get; set; }

        public string TinNhan_File { get; set; }

        public int User_Gui { get; set; }

        public int User_Nhan { get; set; }

        public int? PhienId { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string Chat_Type { get; set; }

        [StringLength(100)]
        public string KetQua_PV { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(61)]
        public string group_chat { get; set; }

        public int? Status { get; set; }

        [StringLength(100)]
        public string uid { get; set; }
    }
}
