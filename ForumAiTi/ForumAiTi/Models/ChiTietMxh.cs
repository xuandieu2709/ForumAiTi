using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class ChiTietMxh
    {
        public int MaCt { get; set; }
        public int? MaMxh { get; set; }
        public string HoTenMxh { get; set; }
        public string Link { get; set; }
        public string TaiKhoan { get; set; }

        public virtual MangXaHoi MaMxhNavigation { get; set; }
        public virtual NguoiDung TaiKhoanNavigation { get; set; }
    }
}
