namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mau28_DM_ChucDanh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChucDanh_ID { get; set; }

        [Required]
        [StringLength(500)]
        public string TenChucDanh { get; set; }

        public DateTime? NgayTao { get; set; }
    }
}
