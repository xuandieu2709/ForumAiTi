using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace ForumAiTi.Models
{
    public partial class FileToForm
    {

        public int STT { get; set; }
        public IFormFile File { get; set; }
    }
}