using ForumAiTi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAiTi.Controllers
{
    public class QAController : Controller
    {
        private readonly ILogger<QAController> _logger;

        public QAController(ILogger<QAController> logger)
        {
            _logger = logger;
        }


        [HttpGet("/qa")]
        public IActionResult qa()
        {
            return View();
        }
    }
}
