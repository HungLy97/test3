namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mau28_ChuyenMonKyThuat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CMKT_Id { get; set; }

        [StringLength(50)]
        public string ChuyenMonKyThuat { get; set; }
    }
}
