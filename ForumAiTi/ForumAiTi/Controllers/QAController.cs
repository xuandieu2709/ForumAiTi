using ForumAiTi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAiTi.Controllers
{
    public class QAController : Controller
    {
        private readonly ILogger<QAController> _logger;

        public QAController(IHostingEnvironment environment, ILogger<QAController> logger)
        {
            _logger = logger;
            _environment = environment;

        }
        private ForumAiTiContext _context = new ForumAiTiContext();
        private IHostingEnvironment _environment;


        [HttpGet("/qa")]
        public IActionResult qa()
        {
            return View();
        }

        [HttpGet("/ask_question")]
        public IActionResult ask_question()
        {
            return View();
        }

        [HttpPost("/ask_question")]
        public IActionResult ask_questionn(HoiDap hoidap, IFormCollection form, IFormFile[] files)
        {
            Console.WriteLine(hoidap.TieuDe + hoidap.NoiDung);
            hoidap.TrangThai = true;
            hoidap.NgayDang = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            var tk = User.FindFirst("TaiKhoan").Value.Trim();
            foreach (var file in files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                if (files[0] != null)
                {
                    hoidap.TenHinh1 = file.FileName;
                    hoidap.HinhAnh1 = ms.ToArray();
                }
                if (files[1] != null)
                {
                    hoidap.TenHinh2 = file.FileName;
                    hoidap.HinhAnh2 = ms.ToArray();
                }
                if (files[2] != null)
                {
                    hoidap.TenHinh3 = file.FileName;
                    hoidap.HinhAnh3 = ms.ToArray();
                }
                var file1 = Path.Combine(_environment.ContentRootPath, "wwwroot/images", file.FileName);
                var fileStream = new FileStream(file1, FileMode.Create);
                file.CopyToAsync(fileStream);
            }
            hoidap.NguoiDang = tk;
            _context.Add(hoidap);
            _context.SaveChanges();
            var hd = _context.HoiDap.FirstOrDefault(x => x.NguoiDang == hoidap.NguoiDang && x.NgayDang == hoidap.NgayDang);
            var listDM = form["states[]"];
            foreach (var item in listDM)
            {
                CthoiDap ct = new CthoiDap();
                ct.MaDanhMuc = Int32.Parse(item);
                ct.MaHoiDap = hd.MaHoiDap;
                _context.Add(ct);
                _context.SaveChanges();
            }
            return View("ask_question");
        }
    }
}
