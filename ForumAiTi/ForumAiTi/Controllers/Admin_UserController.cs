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
            var nd = _context.NguoiDung.ToList();
            return View(nd);
        }

        [HttpPost("/repalceDataUSER")]
        public IActionResult ReplaceEdit(string tk)
        {
            var nd = _context.NguoiDung.Where(x => x.TaiKhoan == tk).FirstOrDefault();
            return View(nd);
        }

        [HttpPost("/insertUser")]
        public string insertUser(NguoiDung nd)
        {
            nd.MaLoai = 1;
            string sql = "Insert into NguoiDung(TaiKhoan,MatKhau,HoTen,SinhNhat,GioiTinh,NgheNghiep,MaLoai,VaiTro) Values ({0},{1},{2},{3},{4},{5},{6},{7})";
            var user = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan == nd.TaiKhoan);
            if(user != null) { return "0"; }
            int x = _context.Database.ExecuteSqlRaw(sql,nd.TaiKhoan,nd.MatKhau,nd.HoTen,nd.SinhNhat,nd.GioiTinh,nd.NgheNghiep,nd.MaLoai,nd.VaiTro);
            
            if(x > 0)
            {
                _logger.LogInformation("Đã insert");
                return "1";
            }else{
                _logger.LogInformation("Lỗi insert");
                return "2";
            }
        }
        [HttpPost("/updateUser")]
        public string updateUser(NguoiDung nd)
        {
            nd.MaLoai = 1;
            string sql = "Update NguoiDung set MatKhau = {0},HoTen = {1},SinhNhat = {2}, GioiTinh = {3},NgheNghiep = {4}, MaLoai = {5}, VaiTro = {6} where TaiKhoan = {7}";
            var user = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan == nd.TaiKhoan);
            int x = _context.Database.ExecuteSqlRaw(sql,nd.MatKhau,nd.HoTen,nd.SinhNhat,nd.GioiTinh,nd.NgheNghiep,nd.MaLoai,nd.VaiTro,nd.TaiKhoan);
            if(x > 0)
            {
                _logger.LogInformation("Đã update");
                return "1";
            }else{
                _logger.LogInformation("Lỗi update");
                return "2";
            }

        }
        [HttpPost("/removeUser")]
        public Boolean removeUser(string TaiKhoan)
        {
            var td = _context.TheoDoi.Where(x =>x.MaNguoiDuocTd == TaiKhoan || x.MaNguoiTd == TaiKhoan).ToList();
            var ctmxh = _context.ChiTietMxh.Where(x =>x.TaiKhoan == TaiKhoan).ToList();
            var tb = _context.ThongBao.Where(x =>x.NguoiTao == TaiKhoan).ToList();
            var gy = _context.GopY.Where(x =>x.NguoiGui == TaiKhoan).ToList();
            var cttb = _context.CtthongBao.Where(x =>x.NguoiNhan == TaiKhoan).ToList();
            var tvnhom = _context.ThanhVienNhomTc.Where(x =>x.ThanhVien == TaiKhoan).ToList();
            var ctntc = _context.CtntroChuyen.Where(x =>x.NguoiGui == TaiKhoan).ToList();
            var bl = _context.BinhLuan.Where(x =>x.TaiKhoan == TaiKhoan).ToList();
            var cttc = _context.CttroChuyen.Where(x =>x.NguoiGui == TaiKhoan || x.NguoiNhan == TaiKhoan).ToList();
            var tc = _context.TroChuyen.Where(x =>x.ThanhVien1 == TaiKhoan || x.ThanhVien2 == TaiKhoan).ToList();
            //
            var tt = _context.TinTuc.Where(x =>x.NguoiDang == TaiKhoan).ToList();
            foreach (var item in tt)
            {
                var ndtt = _context.NoiDungTinTuc.Where(x => x.MaTinTuc == item.MaTinTuc).ToList();
                var cttt = _context.CttinTuc.Where(x => x.MaTinTuc == item.MaTinTuc).ToList();
                if(ndtt.Count() > 0)
                {
                _context.Remove(ndtt);
                }
                if(cttt.Count() > 0)
                {
                _context.Remove(cttt);
                }
                int checkk = _context.SaveChanges();
                if(checkk > 0)
                {
                    _logger.LogInformation("Xoa TC");
                }else{
                    _logger.LogInformation("Xoa TB");
                }

            }
            //
            var hd = _context.HoiDap.Where(x =>x.NguoiDang == TaiKhoan).ToList();
            foreach (var item in hd)
            {
                var ndhd = _context.NoiDungHoiDap.Where(x => x.MaHoiDap == item.MaHoiDap).ToList();
                var cthd = _context.CthoiDap.Where(x => x.MaHoiDap == item.MaHoiDap).ToList();
                if(ndhd.Count() > 0)
                {
                    foreach(var item1 in ndhd)
                {
                _context.Remove(item);
                _context.SaveChanges();
                }
                }
                if(cthd.Count() > 0)
                {
                    foreach(var item1 in cthd)
                {
                _context.Remove(item);
                _context.SaveChanges();
                }
                }
                int checkk = _context.SaveChanges();
                if(checkk > 0)
                {
                    _logger.LogInformation("Xoa TC");
                }else{
                    _logger.LogInformation("Xoa TB");
                }

            }
            //
            var user = _context.NguoiDung.Where(x => x.TaiKhoan == TaiKhoan).FirstOrDefault();
            if(td.Count() > 0)
            {
            foreach(var item1 in td)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(ctmxh.Count() > 0)
            {
                foreach(var item1 in ctmxh)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(tb.Count() > 0)
            {
                foreach(var item1 in tb)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(gy.Count() > 0)
            {
                foreach(var item1 in gy)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(cttb.Count() > 0)
            {
                foreach(var item1 in cttb)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(tvnhom.Count() > 0)
            {
                foreach(var item1 in tvnhom)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(ctntc.Count() > 0)
            {
                foreach(var item1 in ctntc)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(bl.Count() > 0)
            {
                foreach(var item1 in bl)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(cttc.Count() > 0)
            {
                foreach(var item1 in cttc)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(tc.Count() > 0)
            {
                foreach(var item1 in tc)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(tt.Count() > 0)
            {
                foreach(var item1 in tt)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            if(hd.Count() > 0)
            {
                foreach(var item1 in hd)
                {
                _context.Remove(item1);
                _context.SaveChanges();
                }
            }
            _context.Remove(user);
            int x = _context.SaveChanges();
            if(x > 0)
            {
                _logger.LogInformation("Đã remove");
                return true;
            }else{
                _logger.LogInformation("Lỗi remove");
                return false;
            }

        }

    }
}
