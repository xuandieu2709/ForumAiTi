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
        [Authorize(Roles = "ADMIN")]
        [HttpPost("/add_news_admin")]
        public IActionResult admin_news(TinTuc tinTuc, IFormFile FileND, IFormCollection form)
        {
            tinTuc.NguoiDang = User.FindFirst("TaiKhoan").Value.Trim();
            tinTuc.TrangThai = true;
            if (FileND != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    FileND.CopyTo(ms);
                    tinTuc.HinhAnh = ms.ToArray();
                    ms.SetLength(0);
                    ms.Close();
                    Console.WriteLine(ms.ToString());
                }
                tinTuc.TenFile = FileND.FileName;
                var file = Path.Combine(_environment.ContentRootPath, "wwwroot/images/TinTuc", FileND.FileName);
                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    FileND.CopyTo(fileStream);
                }
            }
            List<NoiDungTinTuc> list = tinTuc.NoiDungTinTuc.ToList();
            tinTuc.NoiDungTinTuc = null;
            _context.Add(tinTuc);
            int check = _context.SaveChanges();
            var tt = _context.TinTuc.FromSqlRaw("SELECT * from TinTuc where MaTinTuc = IDENT_CURRENT('TinTuc')").FirstOrDefault();
            Console.WriteLine(tt.MaTinTuc);
            if (check > 0 && tt.NguoiDang.Trim().Equals(User.FindFirst("TaiKhoan").Value.Trim()))
            {
                // foreach (var item in tinTuc.FileToForm.Select((value, i) => new { i, value }))
                // {
                //     var index = item.i;
                //     // STT check xem có hinh hay k 1 co 0 la k co
                //     if (item.value.STT == 1)
                //     {
                //         var newnd = new NoiDungTinTuc();
                //         using (var ms1 = new MemoryStream())
                //         {
                //             // Console.WriteLine(ms.ToString());
                //             // ms1.SetLength(0);
                //             item.value.File.CopyTo(ms1);
                //             newnd.File = ms1.ToArray();
                //             newnd.TenFile = item.value.File.FileName;
                //             newnd.LoaiFile = item.value.File.ContentType;
                //             newnd.NoiDung = tinTuc.NoiDungTinTuc.ToList()[item.i].NoiDung;
                //             newnd.ChuThich = tinTuc.NoiDungTinTuc.ToList()[item.i].ChuThich;
                //             string sql = "INSERT INTO [dbo].[NoiDungTinTuc] ([MaTinTuc],[NoiDung],[File],[TenFile],[LoaiFile],[ChuThich]) VALUES({0},{1},{2},{3},{4},{5})";
                //             _context.Database.ExecuteSqlRaw(sql, tt.MaTinTuc, newnd.NoiDung, newnd.File, newnd.TenFile, newnd.LoaiFile, newnd.ChuThich);
                //             var file1 = Path.Combine(_environment.ContentRootPath, "wwwroot/images/TinTuc", FileND.FileName);
                //             using (var fileStream1 = new FileStream(file1, FileMode.Create))
                //             {
                //                 item.value.File.CopyTo(fileStream1);
                //             }
                //         }
                //     }
                //     else
                //     {
                //         Console.WriteLine("Hinh k có = 0" + item.value.STT);
                //     }
                // }
                int count = 0;
                foreach (var item in tinTuc.FileToForm)
                {
                    // STT check xem có hinh hay k 1 co 0 la k co
                    if (item.STT == 1)
                    {
                        var newnd = new NoiDungTinTuc();
                        using (var ms1 = new MemoryStream())
                        {
                            // Console.WriteLine(ms.ToString());
                            // ms1.SetLength(0);
                            item.File.CopyTo(ms1);
                            newnd.MaTinTuc = tt.MaTinTuc;
                            newnd.File = ms1.ToArray();
                            newnd.TenFile = item.File.FileName;
                            newnd.LoaiFile = item.File.ContentType;
                            newnd.NoiDung = list[count].NoiDung;
                            newnd.ChuThich = list[count].ChuThich;
                            string sql = "INSERT INTO [dbo].[NoiDungTinTuc] ([MaTinTuc],[NoiDung],[File],[TenFile],[LoaiFile],[ChuThich]) VALUES({0},{1},{2},{3},{4},{5})";
                            _context.Database.ExecuteSqlRaw(sql, newnd.MaTinTuc, newnd.NoiDung, newnd.File, newnd.TenFile, newnd.LoaiFile, newnd.ChuThich);
                        }
                        var file1 = Path.Combine(_environment.ContentRootPath, "wwwroot/images/TinTuc", FileND.FileName);
                        using (var fileStream1 = new FileStream(file1, FileMode.Create))
                        {
                            item.File.CopyTo(fileStream1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hinh k có = 0" + item.STT);
                    }
                    count++;
                }
                var listDM = form["states[]"];
                // int count = listDM.Count;
                foreach (var item in listDM)
                {
                    string sql = "INSERT INTO [dbo].[CTTinTuc] ([MaChuDe],[MaTinTuc]) VALUES({0},{1})";
                    _context.Database.ExecuteSqlRaw(sql, Int32.Parse(item), tt.MaTinTuc);
                }
            }

            if (check > 0)
            {
                _logger.LogInformation("Thêm Tin thành công!");
                ViewBag.MESSSUCCESS = "1";
            }
            else
            {
                _logger.LogInformation("Thêm Thất bại!");
                ViewBag.MESSSUCCESS = "2";
            }
            return View("add_edit_news_admin");
        }

    }
}
