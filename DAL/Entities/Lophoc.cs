using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Lophoc
    {
        [Key]
        public string MaLop { get; set; }

        public string TenLop { get; set; }

        // Foreign key to Khoahoc
        public string MaKhoaHoc { get; set; }

        public int SiSoHienTai { get; set; }

        public int SiSoToiDa { get; set; }

        public DateTime NgayKhaiGiang { get; set; }

        public string TrangThai { get; set; }

        // Navigation property
        [ForeignKey("MaKhoaHoc")]
        public virtual Khoahoc Khoahoc { get; set; }
    }
}
