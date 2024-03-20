namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mau2829
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Months { get; set; }

        public int CNKT_Giam { get; set; }

        public int CCNduoi3_Giam { get; set; }

        public int CCNduoi12_Giam { get; set; }

        public int TC_Giam { get; set; }

        public int CĐ_Giam { get; set; }

        public int ĐH_Giam { get; set; }

        public int LaoDongGiam { get; set; }

        [StringLength(2000)]
        public string GhichuGiam { get; set; }

        public int CNKT_Tang { get; set; }

        public int CCNduoi3_Tang { get; set; }

        public int CCNduoi12_Tang { get; set; }

        public int TC_Tang { get; set; }

        public int CĐ_Tang { get; set; }

        public int ĐH_Tang { get; set; }

        public int LaoDongTang { get; set; }

        [StringLength(2000)]
        public string GhichuTang { get; set; }

        public DateTime NgayCapNhat { get; set; }
    }
}
