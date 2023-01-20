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
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
        }
        private ForumAiTiContext _context = new ForumAiTiContext();

        [HttpGet("/news")]
        public IActionResult news()
        {
            return View();
        }

        [HttpGet("/details_news/{MaTinTuc}")]
        public IActionResult details_news(int MaTinTuc)
        {
            var tt = _context.TinTuc.Where(x => x.MaTinTuc == MaTinTuc).FirstOrDefault();
            tt.CttinTuc = _context.CttinTuc.Where(x => x.MaTinTuc == MaTinTuc).ToList();
            tt.NoiDungTinTuc = _context.NoiDungTinTuc.Where(x => x.MaTinTuc == MaTinTuc).ToList();
            return View(tt);
        }
    }
}
