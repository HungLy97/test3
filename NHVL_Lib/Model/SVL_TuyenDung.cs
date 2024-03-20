namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SVL_TuyenDung
    {
        public int id { get; set; }

        public int DoanhNghiepId { get; set; }

        public int TuyenDungId { get; set; }

        public int PhienId { get; set; }

        public DateTime? NgayTao { get; set; }

        public Guid msrepl_tran_version { get; set; }
    }
}
