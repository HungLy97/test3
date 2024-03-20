namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ThongKe_NTV_SanOnline_Online
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string NguoiTimViec_Id { get; set; }

        [StringLength(100)]
        public string UserId { get; set; }

        public DateTime? NgayOnline { get; set; }

        public int? PhienId { get; set; }

        public bool? IsOnline { get; set; }
    }
}
