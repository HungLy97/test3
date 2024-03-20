namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DN_SanOnline
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string DoanhNghiep_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhienId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TinhTrang { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime NgayThamGia { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DangNhap_Status { get; set; }
    }
}
