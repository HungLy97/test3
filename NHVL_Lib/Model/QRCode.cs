namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QRCode")]
    public partial class QRCode
    {
        [Key]
        public int QRCode_ID { get; set; }

        public int? QRCode_KH { get; set; }

        public int? QRCode_DN { get; set; }
    }
}
