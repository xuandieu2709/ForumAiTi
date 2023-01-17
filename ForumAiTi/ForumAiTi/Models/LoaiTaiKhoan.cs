using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class LoaiTaiKhoan
    {
        public LoaiTaiKhoan()
        {
            NguoiDung = new HashSet<NguoiDung>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<NguoiDung> NguoiDung { get; set; }
    }
}
