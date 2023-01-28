using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class GopY
    {
        public int MaGopY { get; set; }
        public string HoTen { get; set; }
        public string NoiDung { get; set; }
        public string TieuDe { get; set; }
        public string Email { get; set; }
        public string NguoiGui { get; set; }
        public DateTime? ThoiGianGui { get; set; }

        public virtual NguoiDung NguoiGuiNavigation { get; set; }
    }
}
