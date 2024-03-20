namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiamThi")]
    public partial class GiamThi
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string TenGiamThi { get; set; }

        public int? TinhTrang { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }
    }
}
