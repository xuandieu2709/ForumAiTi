using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class CommentModel
    {
        public int ma { get; set; }
        public string comment { get; set; }
        public IFormFile file { get; set; }
       
    }
}
