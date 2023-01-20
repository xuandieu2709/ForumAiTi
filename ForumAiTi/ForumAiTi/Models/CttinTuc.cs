using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class CttinTuc
    {
        public int MaCt { get; set; }
        public int? MaChuDe { get; set; }
        public int? MaTinTuc { get; set; }

        public virtual ChuDe MaChuDeNavigation { get; set; }
        public virtual TinTuc MaTinTucNavigation { get; set; }
    }
}
