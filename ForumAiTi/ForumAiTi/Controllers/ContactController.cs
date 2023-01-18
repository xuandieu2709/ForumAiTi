using ForumAiTi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAiTi.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }
        private ForumAiTiContext _context = new ForumAiTiContext();
        [HttpGet("/contact")]
        public IActionResult contact()
        {
            return View("contact");
        }

        [Authorize(Roles = "USER")]
        [HttpPost("/sendSupport")]
        public IActionResult sendSupport(GopY gopy)
        {
            gopy.NguoiGui = User.FindFirst("TaiKhoan").Value.Trim();
            _context.Add(gopy);
            int check = _context.SaveChanges();
            if(check > 0)
            {
                ViewBag.MessSUcc = "1";
            }
            else{
                ViewBag.MessSUcc = "2";
            }
            return View("contact");
        }
    }
}
