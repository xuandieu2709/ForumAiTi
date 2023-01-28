using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class ThanhVienNhomTc
    {
        public int MaNhomTv { get; set; }
        public int? MaNhom { get; set; }
        public string ThanhVien { get; set; }

        public virtual NhomTroChuyen MaNhomNavigation { get; set; }
        public virtual NguoiDung ThanhVienNavigation { get; set; }
    }
}
