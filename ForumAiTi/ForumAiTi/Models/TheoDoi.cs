using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class TheoDoi
    {
        public int MaTheoDoi { get; set; }
        public string MaNguoiTd { get; set; }
        public string MaNguoiDuocTd { get; set; }
        public DateTime? ThoiGianTd { get; set; }
        public bool? TrangThai { get; set; }

        public virtual NguoiDung MaNguoiDuocTdNavigation { get; set; }
        public virtual NguoiDung MaNguoiTdNavigation { get; set; }
    }
}
