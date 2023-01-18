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
    [Authorize(Roles = "ADMIN")]
    public class Admin_QAController : Controller
    {
        private readonly ILogger<Admin_QAController> _logger;

        public Admin_QAController(ILogger<Admin_QAController> logger)
        {
            _logger = logger;
        }
        private ForumAiTiContext _context = new ForumAiTiContext();
        // [HttpGet("/add_news")]
        // public IActionResult add_news()
        // {
        //     return View("add_edit_news");
        // }
        [HttpGet("/admin_qa")]
        public IActionResult admin_qa()
        {
            return View();
        }

    }
}
