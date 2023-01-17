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
    public class PersonalController : Controller
    {
        private readonly ILogger<PersonalController> _logger;

        public PersonalController(ILogger<PersonalController> logger)
        {
            _logger = logger;
        }


        [HttpGet("/personal")]
        public IActionResult personal()
        {
            return View();
        }
    }
}
