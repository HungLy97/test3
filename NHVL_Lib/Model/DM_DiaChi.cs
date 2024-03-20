namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_DiaChi
    {
        public int Id { get; set; }

        [StringLength(2000)]
        public string TenDiaChi { get; set; }

        public string MoTa { get; set; }

        public int? ParentId { get; set; }

        public int? MaQuocGia { get; set; }

        public int? Level { get; set; }

        public DateTime? NgayTao { get; set; }

        public bool? KichHoat { get; set; }
    }
}
