using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class ChatModel
    {
        public string userReceive { get; set; }
        public string userSend { get; set; }
        public int idChat { get; set; }
        public string message { get; set; }
        public IFormFile file { get; set; }
        public DateTime? timeSend { get; set; }
    }
}
