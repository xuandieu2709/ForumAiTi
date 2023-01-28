using ForumAiTi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
    public class PersonalController : Controller
    {
        private readonly ILogger<PersonalController> _logger;
        private IHostingEnvironment _environment;
        public PersonalController(IHostingEnvironment environment, ILogger<PersonalController> logger)
        {
            _logger = logger;
            _environment = environment;

        }
        private ForumAiTiContext _context = new ForumAiTiContext();

        [Authorize(Roles = "USER")]
        [HttpGet("/personal")]
        public IActionResult personal()
        {
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            var infor = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan == tk);
            return View(infor);
        }

        [HttpGet("/personal/{TaiKhoan}")]
        public IActionResult personal(string TaiKhoan)
        {
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            var infor = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan == TaiKhoan);
            return View(infor);
        }


        [HttpGet("/qa_personal")]
        public IActionResult qa_personal(string TaiKhoan)
        {
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            var hd = _context.HoiDap.FirstOrDefault(x => x.NguoiDang == tk);
            return View(hd);
        }

        [Authorize(Roles = "USER")]
        [HttpPost("/follow")]
        public Boolean follow(string TaiKhoan)
        {
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            TheoDoi td = new TheoDoi();
            td.MaNguoiTd = tk;
            td.MaNguoiDuocTd = TaiKhoan;
            td.TrangThai = true;
            td.ThoiGianTd = DateTime.Now;
            TroChuyen tc = new TroChuyen();
            tc.ThanhVien1 = tk;
            tc.ThanhVien2 =TaiKhoan;
            tc.ThoiGianTao = DateTime.Now;
            // TV1 : USER theo doi , TV2  : USER dc theo doi
            _context.Add(td);
            _context.Add(tc);
            var check = _context.SaveChanges();

            if (check > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [Authorize(Roles = "USER")]
        [HttpPost("/unfollow")]
        public Boolean unfollow(string TaiKhoan)
        {
            // TV1 : USER theo doi , TV2  : USER dc theo doi
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            var chat  = _context.TroChuyen.Where(x => x.ThanhVien1 == tk && x.ThanhVien2 == TaiKhoan).FirstOrDefault();
            _context.CttroChuyen.FromSqlRaw("DELETE FROM CTTroChuyen WHERE MaTroChuyen = {0}",chat.MaTroChuyen);
            _context.Remove(chat);
            var td = _context.TheoDoi.Where(x => x.MaNguoiTd.Trim() == tk && x.MaNguoiDuocTd.Trim() == TaiKhoan).FirstOrDefault();
            _context.Remove(td);
            var check = _context.SaveChanges();
            if (check > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
