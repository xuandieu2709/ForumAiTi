using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class HoiDap
    {
        public HoiDap()
        {
            BinhLuan = new HashSet<BinhLuan>();
            CthoiDap = new HashSet<CthoiDap>();
            NoiDungHoiDap = new HashSet<NoiDungHoiDap>();
        }

        public int MaHoiDap { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public byte[] HinhAnh1 { get; set; }
        public string TenHinh1 { get; set; }
        public byte[] HinhAnh2 { get; set; }
        public string TenHinh2 { get; set; }
        public byte[] HinhAnh3 { get; set; }
        public string TenHinh3 { get; set; }
        public bool? TrangThai { get; set; }
        public string NguoiDang { get; set; }
        public DateTime? NgayDang { get; set; }
        public int? LuotXem { get; set; }

        public virtual ICollection<BinhLuan> BinhLuan { get; set; }
        public virtual ICollection<CthoiDap> CthoiDap { get; set; }
        public virtual ICollection<NoiDungHoiDap> NoiDungHoiDap { get; set; }
    }
}
