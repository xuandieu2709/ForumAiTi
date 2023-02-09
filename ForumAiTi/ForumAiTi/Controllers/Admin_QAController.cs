using ForumAiTi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            var hd = _context.HoiDap.ToList();
            return View(hd);
        }
        [HttpPost("/changeStatusQA")]
        public bool changeStatusQA(bool status,int Mahoidap)
        {
            var hd = _context.HoiDap.FirstOrDefault(x =>x.MaHoiDap == Mahoidap);
            hd.TrangThai = status;
            string sql = "Update HoiDap set TrangThai = {0} Where MaHoiDap = {1}";
            int x = _context.Database.ExecuteSqlRaw(sql,hd.TrangThai,hd.MaHoiDap);
            if(x > 0)
            {
                _logger.LogInformation("Thay đổi HD Thành công!");
                return true;
            }else{
                _logger.LogInformation("Thay đổi HD Thất bại!");
                return false;
            }
        }

        [HttpPost("/showDetailsQA")]
        public IActionResult ReplaceDetailsQA(int MaHD)
        {
            var hd = _context.HoiDap.FirstOrDefault(x =>x.MaHoiDap == MaHD);
            return PartialView(hd);
        }

        [HttpPost("/removeQA")]
        public bool removeQA(int Mahoidap)
        {
                // Console.WriteLine("Ma hoi dap"+Mahoidap);
            var hd = _context.HoiDap.FirstOrDefault(x =>x.MaHoiDap == Mahoidap);
            var listdt = _context.CthoiDap.Where(x =>x.MaHoiDap == Mahoidap).ToList();
            var listnd = _context.NoiDungHoiDap.Where(x=>x.MaHoiDap == Mahoidap).ToList();
            var bl = _context.BinhLuan.Where(x =>x.MaHoiDap == Mahoidap).ToList();
            if(bl.Count() > 0)
            {
                foreach(var item in bl)
                {
                _context.Remove(item);
                _context.SaveChanges();
                }
            }
            if(listdt.Count() > 0)
            {
                foreach(var item in listdt)
                {
                _context.Remove(item);
                _context.SaveChanges();
                }
            }
            if(listnd.Count() > 0)
            {
                foreach(var item in listnd)
                {
                _context.Remove(item);
                _context.SaveChanges();
                }
            }
            _context.Remove(hd);
            int x = _context.SaveChanges();
            if(x > 0)
            {
                _logger.LogInformation("Xoa HD Thành công!");
                return true;
            }else{
                _logger.LogInformation("Xoa HD Thất bại!");
                return false;
            }
        }
        
    }
}
