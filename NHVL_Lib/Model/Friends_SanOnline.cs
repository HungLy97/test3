namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Friends_SanOnline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STT { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoanhNghiepId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NguoiTimViecId { get; set; }

        public bool? Status { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhienId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string KetQuaPhongVan { get; set; }
    }
}
