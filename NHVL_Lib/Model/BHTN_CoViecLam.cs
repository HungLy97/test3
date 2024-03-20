namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BHTN_CoViecLam
    {
        public int ID { get; set; }

        [StringLength(17)]
        public string IDBHTN { get; set; }

        public int? IDDN { get; set; }

        public DateTime? NgayKhaiBao { get; set; }

        public DateTime? NgayBatDauLV { get; set; }

        public DateTime? NgayHieuLucHD { get; set; }

        [StringLength(256)]
        public string FlieDinhKem { get; set; }

        [StringLength(256)]
        public string FileDinhKem_Save { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
