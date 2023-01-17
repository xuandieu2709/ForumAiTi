using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class MangXaHoi
    {
        public MangXaHoi()
        {
            ChiTietMxh = new HashSet<ChiTietMxh>();
        }

        public int MaMxh { get; set; }
        public string TenMxh { get; set; }

        public virtual ICollection<ChiTietMxh> ChiTietMxh { get; set; }
    }
}
