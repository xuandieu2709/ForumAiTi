using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class CthoiDap
    {
        public int MaCt { get; set; }
        public int? MaDanhMuc { get; set; }
        public int? MaHoiDap { get; set; }

        public virtual DanhMucHoiDap MaDanhMucNavigation { get; set; }
        public virtual HoiDap MaHoiDapNavigation { get; set; }
    }
}
