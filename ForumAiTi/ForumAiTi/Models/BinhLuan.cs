using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class BinhLuan
    {
        public int MaBinhLuan { get; set; }
        public string TaiKhoan { get; set; }
        public string NoiDung { get; set; }
        public byte[] File { get; set; }
        public string TenFile { get; set; }
        public string LoaiFile { get; set; }
        public DateTime? ThoiGianBinhLuan { get; set; }
        public int? MaHoiDap { get; set; }
        public bool? TrangThai { get; set; }

        public virtual HoiDap MaHoiDapNavigation { get; set; }
        public virtual NguoiDung TaiKhoanNavigation { get; set; }
    }
}
