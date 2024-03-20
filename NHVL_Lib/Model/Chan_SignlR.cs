namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Chan_SignlR
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int UserId_bichan { get; set; }

        public DateTime? Ngay { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
