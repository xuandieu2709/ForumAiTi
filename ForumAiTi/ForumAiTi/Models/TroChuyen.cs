using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class TroChuyen
    {
        public TroChuyen()
        {
            CttroChuyen = new HashSet<CttroChuyen>();
        }

        public int MaTroChuyen { get; set; }
        public string BdnguoiGui { get; set; }
        public string BdnguoiNhan { get; set; }
        public DateTime? ThoiGianTao { get; set; }

        public virtual ICollection<CttroChuyen> CttroChuyen { get; set; }
    }
}
