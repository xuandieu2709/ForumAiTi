using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class TinTuc
    {
        public TinTuc()
        {
            CttinTuc = new HashSet<CttinTuc>();
            NoiDungTinTuc = new HashSet<NoiDungTinTuc>();
        }

        public int MaTinTuc { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public byte[] HinhAnh { get; set; }
        public string TenFile { get; set; }
        public bool? TrangThai { get; set; }
        public string NguoiDang { get; set; }
        public DateTime? NgayDang { get; set; }

        public virtual NguoiDung NguoiDangNavigation { get; set; }
        public virtual ICollection<CttinTuc> CttinTuc { get; set; }
        public virtual ICollection<NoiDungTinTuc> NoiDungTinTuc { get; set; }
    }
}
