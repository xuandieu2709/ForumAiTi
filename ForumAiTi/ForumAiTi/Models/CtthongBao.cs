using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class CtthongBao
    {
        public int MaChiTiet { get; set; }
        public int? MaThongBao { get; set; }
        public string NguoiNhan { get; set; }

        public virtual ThongBao MaThongBaoNavigation { get; set; }
        public virtual NguoiDung NguoiNhanNavigation { get; set; }
    }
}
