using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class ThongBao
    {
        public int MaThongBao { get; set; }
        public string NoiDung { get; set; }
        public bool? TrangThai { get; set; }
        public string TaiKhoan { get; set; }

        public virtual NguoiDung TaiKhoanNavigation { get; set; }
    }
}
