using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class NoiDungTinTuc
    {
        public int MaNoiDungTt { get; set; }
        public int? MaTinTuc { get; set; }
        public string NoiDung { get; set; }
        public byte[] File { get; set; }
        public string TenFile { get; set; }
        public string LoaiFile { get; set; }
        public string ChuThich { get; set; }

        public virtual TinTuc MaTinTucNavigation { get; set; }
    }
}
