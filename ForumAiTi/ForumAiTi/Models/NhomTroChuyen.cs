using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class NhomTroChuyen
    {
        public NhomTroChuyen()
        {
            CtntroChuyen = new HashSet<CtntroChuyen>();
            ThanhVienNhomTc = new HashSet<ThanhVienNhomTc>();
        }

        public int MaNhom { get; set; }
        public string TenNhom { get; set; }
        public DateTime? ThoiGianTao { get; set; }

        public virtual ICollection<CtntroChuyen> CtntroChuyen { get; set; }
        public virtual ICollection<ThanhVienNhomTc> ThanhVienNhomTc { get; set; }
    }
}
