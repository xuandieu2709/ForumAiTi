using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class DanhMucHoiDap
    {
        public DanhMucHoiDap()
        {
            CthoiDap = new HashSet<CthoiDap>();
        }

        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        public virtual ICollection<CthoiDap> CthoiDap { get; set; }
    }
}
