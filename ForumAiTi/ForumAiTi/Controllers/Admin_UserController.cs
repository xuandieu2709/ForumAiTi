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
    public class Admin_UserController : Controller
    {
        private readonly ILogger<Admin_UserController> _logger;

        public Admin_UserController(ILogger<Admin_UserController> logger)
        {
            _logger = logger;
        }
        private ForumAiTiContext _context = new ForumAiTiContext();
        [HttpGet("/admin_user")]
        public IActionResult admin_user()
        {
            return View();
        }

    }
}
