namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aspnet_getmba
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string AID { get; set; }

        [StringLength(10)]
        public string ADate { get; set; }

        public DateTime? ADateTime { get; set; }
    }
}
