namespace NHVL_Lib.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HocNghe_FileDinhKem
    {
        public int Id { get; set; }

        public int? HocVienId { get; set; }

        public string TenFile { get; set; }

        public string TenFileMaHoa { get; set; }

        [StringLength(1000)]
        public string DuongDanFile { get; set; }

        public int? TinhTrang { get; set; }

        public DateTime? NgayUpFile { get; set; }

        [StringLength(50)]
        public string NguoiUpFile { get; set; }
    }
}
