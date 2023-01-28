using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class ThongBao
    {
        public ThongBao()
        {
            CtthongBao = new HashSet<CtthongBao>();
        }

        public int MaThongBao { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public byte[] File { get; set; }
        public string TenFile { get; set; }
        public string LoaiFile { get; set; }
        public bool? TrangThai { get; set; }
        public string NguoiTao { get; set; }

        public virtual NguoiDung NguoiTaoNavigation { get; set; }
        public virtual ICollection<CtthongBao> CtthongBao { get; set; }
    }
}
