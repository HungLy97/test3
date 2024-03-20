namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Videos
    {
        [Key]
        public int VideoId { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }

        [Required]
        [StringLength(500)]
        public string VideoPath { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserId { get; set; }

        public int PortalId { get; set; }

        public int OrderNumber { get; set; }

        public bool IsVisible { get; set; }

        public Guid msrepl_tran_version { get; set; }

        public DateTime? Fixdate { get; set; }

        public int? FixUser { get; set; }
    }
}
