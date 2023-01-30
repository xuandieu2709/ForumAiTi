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
    [Authorize(Roles = "USER")]
    public class ChatController : Controller
    {
        private readonly ILogger<ChatController> _logger;

        public ChatController(ILogger<ChatController> logger)
        {
            _logger = logger;
        }
        private ForumAiTiContext _context = new ForumAiTiContext();
        [HttpGet("/chat")]
        public IActionResult chat()
        {
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            // var listchat = _context.TroChuyen.FromSqlRaw("select distinct tc.MaTroChuyen,tc.BDNguoiGui,tc.BDNguoiNhan,tc.ThoiGianTao,tc.ThanhVien1,tc.ThanhVien2 from TroChuyen tc join CTTroChuyen ctt on ctt.MaTroChuyen = tc.MaTroChuyen where ctt.NguoiNhan = '{0}';",tk).ToList();
            var listchat = _context.TroChuyen.Where(x => x.ThanhVien1 == tk || x.ThanhVien2 == tk).ToList();
            foreach(var item in listchat)
            {
                var ct = _context.CttroChuyen.OrderByDescending(x => x.ThoiGianGui).FirstOrDefault(x => x.MaTroChuyen == item.MaTroChuyen);
                if(ct != null)
                {
                    item.TGTinNhanCuoi = ct.ThoiGianGui;
                }
            }
            listchat = listchat.OrderByDescending(x => x.TGTinNhanCuoi).ToList();
            var listgroupchat = _context.ThanhVienNhomTc.Where(x => x.ThanhVien == tk).ToList();
            ViewBag.ListChat = listchat;
            ViewBag.ListGroup = listgroupchat;
            return View();
        }

        [HttpGet("/chatt")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/searchChat")]
        public IActionResult searchChat(string search )
        {
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            var listUser = _context.NguoiDung.Where(x => x.HoTen!.Contains(search) || x.Nickname!.Contains(search)|| x.TaiKhoan!.Contains(search)).ToList();
            // var listUser = _context.NguoiDung.FromSqlRaw("Select distinct nd.[HoTen],nd.[SinhNhat],nd.[Nickname],nd.[GTBanThan],nd.[NgheNghiep],nd.[HinhAnh],nd.[Email],nd.[GioiTinh],nd.[TaiKhoan],nd.[MatKhau],nd.[MaLoai],nd.[VaiTro]  from NguoiDung nd join TheoDoi td on nd.TaiKhoan = td.MaNguoiDuocTD where td.MaNguoiTD = {0} and CONCAT_WS(nd.TaiKhoan,nd.Nickname,nd.HoTen) like '%{0}%';",User.FindFirst("TaiKhoan").Value.Trim(),search).ToList();
            var listFollow = _context.TheoDoi.Where(x => (x.MaNguoiTd == tk && x.MaNguoiDuocTd != tk) || (x.MaNguoiDuocTd == tk && x.MaNguoiTd != tk)).ToList();
            var newlist = new List<NguoiDung>(); 
            foreach(var item in listFollow)
            {
                foreach(var itemt in listUser)
                {
                    if((itemt.TaiKhoan.Equals(item.MaNguoiDuocTd) && itemt.TaiKhoan != tk) || (itemt.TaiKhoan.Equals(item.MaNguoiTd) && itemt.TaiKhoan != tk))
                    {
                        newlist.Add(itemt);
                    }
                }
            }
            var listchat = _context.TroChuyen.Where(x => x.ThanhVien1 == tk || x.ThanhVien2 == tk).ToList();
            foreach(var item in listchat)
            {
                var ct = _context.CttroChuyen.OrderByDescending(x => x.ThoiGianGui).FirstOrDefault(x => x.MaTroChuyen == item.MaTroChuyen);
                if(ct != null)
                {
                    item.TGTinNhanCuoi = ct.ThoiGianGui;
                }
            }
            listchat = listchat.OrderByDescending(x => x.TGTinNhanCuoi).ToList();
            ViewBag.ListChat = listchat;
            Console.WriteLine("key"+search);
            if(search == null)
            {
                ViewBag.textSearch = "1";
            }else{
                ViewBag.textSearch = "2";
            }
        return PartialView(newlist);
        }

        [HttpPost("/sendChat")]
        public IActionResult ReplaceChat()
        {
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            // var listchat = _context.TroChuyen.FromSqlRaw("select distinct tc.MaTroChuyen,tc.BDNguoiGui,tc.BDNguoiNhan,tc.ThoiGianTao,tc.ThanhVien1,tc.ThanhVien2 from TroChuyen tc join CTTroChuyen ctt on ctt.MaTroChuyen = tc.MaTroChuyen where ctt.NguoiNhan = '{0}';",tk).ToList();
            var listchat = _context.TroChuyen.Where(x => x.ThanhVien1 == tk || x.ThanhVien2 == tk).ToList();
            foreach(var item in listchat)
            {
                var ct = _context.CttroChuyen.OrderByDescending(x => x.ThoiGianGui).FirstOrDefault(x => x.MaTroChuyen == item.MaTroChuyen);
                if(ct != null)
                {
                    item.TGTinNhanCuoi = ct.ThoiGianGui;
                }
            }
            listchat = listchat.OrderByDescending(x => x.TGTinNhanCuoi).ToList();
            var listgroupchat = _context.ThanhVienNhomTc.Where(x => x.ThanhVien == tk).ToList();
            ViewBag.ListChat = listchat;
            ViewBag.ListGroup = listgroupchat;
            return PartialView();
        }

        [HttpPost("/chat/{TaiKhoan}")]
        public IActionResult ReplaceDivDetails(string TaiKhoan)
        {
            Console.WriteLine("TK"+TaiKhoan);
            string tk = User.FindFirst("TaiKhoan").Value.Trim();
            // var listchat = _context.TroChuyen.FromSqlRaw("select distinct tc.MaTroChuyen,tc.BDNguoiGui,tc.BDNguoiNhan,tc.ThoiGianTao,tc.ThanhVien1,tc.ThanhVien2 from TroChuyen tc join CTTroChuyen ctt on ctt.MaTroChuyen = tc.MaTroChuyen where ctt.NguoiNhan = '{0}';",tk).ToList();
            var listchat = _context.TroChuyen.Where(x => (x.ThanhVien1 == tk && x.ThanhVien2 == TaiKhoan) ||  (x.ThanhVien1 == TaiKhoan && x.ThanhVien2 == tk)).FirstOrDefault();
            Console.WriteLine(listchat.ThanhVien1 + listchat.ThanhVien2);
            ViewBag.ListChat = listchat;
            return PartialView();
        }
    }
}
