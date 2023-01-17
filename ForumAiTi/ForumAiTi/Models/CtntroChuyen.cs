using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class CtntroChuyen
    {
        public int MaCt { get; set; }
        public string NguoiGui { get; set; }
        public string NoiDung { get; set; }
        public byte[] File { get; set; }
        public string TenFile { get; set; }
        public string LoaiFile { get; set; }
        public DateTime? ThoiGianGui { get; set; }
        public int? MaNhom { get; set; }
        public bool? TinhTrang { get; set; }

        public virtual NhomTroChuyen MaNhomNavigation { get; set; }
        public virtual NguoiDung NguoiGuiNavigation { get; set; }
    }
}
