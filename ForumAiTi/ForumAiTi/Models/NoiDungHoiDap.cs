using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class NoiDungHoiDap
    {
        public int MaNoiDungHd { get; set; }
        public int? MaHoiDap { get; set; }
        public string NoiDung { get; set; }
        public byte[] File { get; set; }
        public string TenFile { get; set; }
        public string LoaiFile { get; set; }

        public virtual HoiDap MaHoiDapNavigation { get; set; }
    }
}
