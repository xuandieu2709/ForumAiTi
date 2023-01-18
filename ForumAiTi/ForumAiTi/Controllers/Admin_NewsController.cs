using ForumAiTi.Models;
using Microsoft.AspNetCore.Authorization;
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
using Microsoft.EntityFrameworkCore;

namespace ForumAiTi.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class Admin_NewsController : Controller
    {
        private readonly ILogger<Admin_NewsController> _logger;
        private IHostingEnvironment _environment;
        public Admin_NewsController(IHostingEnvironment environment, ILogger<Admin_NewsController> logger)
        {
            _logger = logger;
            _environment = environment;

        }
        private ForumAiTiContext _context = new ForumAiTiContext();
        [HttpGet("/add_news")]
        public IActionResult add_news()
        {
            return View("add_edit_news_admin");
        }
        [HttpGet("/admin_news")]
        public IActionResult admin_news()
        {
            return View();
        }

        [HttpPost("/add_news_admin")]
        public IActionResult admin_news(TinTuc tinTuc, IFormFile FileND, IFormCollection form)
        {
            tinTuc.NguoiDang = User.FindFirst("TaiKhoan").Value.Trim();
            tinTuc.TrangThai = true;
            MemoryStream ms = new MemoryStream();
            FileND.CopyTo(ms);
            tinTuc.HinhAnh = ms.ToArray();
            tinTuc.TenFile = FileND.FileName;
            var file1 = Path.Combine(_environment.ContentRootPath, "wwwroot/images/TinTuc", FileND.FileName);
            using (var fileStream = new FileStream(file1, FileMode.Create))
                    {
                        FileND.CopyTo(fileStream);
                    }

            _context.Add(tinTuc);
            int check = _context.SaveChanges();
            var tt = _context.TinTuc.FirstOrDefault(x => x.NguoiDang == tinTuc.NguoiDang && x.NgayDang == tinTuc.NgayDang);
            foreach (var item in tinTuc.FileToForm.Select((value, i) => new { i, value }))
            {
                // var value = item.value;
                var index = item.i;
                if (item.value.STT == 1)
                {
                    Console.WriteLine(index);
                    MemoryStream ms1 = new MemoryStream();
                    item.value.File.CopyTo(ms1);
                    tinTuc.HinhAnh = ms1.ToArray();
                    var file = Path.Combine(_environment.ContentRootPath, "wwwroot/images/TinTuc", item.value.File.FileName);
                    using (var fileStream1 = new FileStream(file, FileMode.Create))
                    {
                        item.value.File.CopyTo(fileStream1);
                    }
                    tinTuc.NoiDungTinTuc.ToList()[item.i].TenFile = item.value.File.FileName;
                    tinTuc.NoiDungTinTuc.ToList()[item.i].File = ms1.ToArray();
                    tinTuc.NoiDungTinTuc.ToList()[item.i].LoaiFile = item.value.File.ContentType;
                    tinTuc.NoiDungTinTuc.ToList()[item.i].MaTinTuc = tt.MaTinTuc;
                    var newnd = tinTuc.NoiDungTinTuc.ToList()[item.i];
                    string sql = "INSERT INTO [dbo].[NoiDungTinTuc] ([MaTinTuc],[NoiDung],[File],[TenFile],[LoaiFile],[ChuThich]) VALUES({0},{1},{2},{3},{4},{5})";
                    _context.Database.ExecuteSqlRaw(sql, newnd.MaTinTuc, newnd.NoiDung, newnd.File, newnd.TenFile, newnd.LoaiFile, newnd.ChuThich);
                }
                else
                {
                    Console.WriteLine("LAG a stt = 0" + item.value.STT);
                }
            }
            var listDM = form["states[]"];
            // int count = listDM.Count;
            foreach (var item in listDM)
            {
                CttinTuc ct = new CttinTuc();
                ct.MaChuDe = Int32.Parse(item);
                ct.MaTinTuc = tt.MaTinTuc;
                string sql = "INSERT INTO [dbo].[CTTinTuc] ([MaChuDe],[MaTinTuc]) VALUES({0},{1})";
                    _context.Database.ExecuteSqlRaw(sql, ct.MaChuDe,ct.MaTinTuc);
            }
            if (check > 0)
            {
                _logger.LogInformation("Thêm Tin thành công!");
            }
            else
            {
                _logger.LogInformation("Thêm Thất bại!");
            }
            return View("add_edit_news_admin");
        }

    }
}
