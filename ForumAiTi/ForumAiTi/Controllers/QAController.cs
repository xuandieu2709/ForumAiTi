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
using static System.Net.WebRequestMethods;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
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


        // [HttpGet("/qa/{page}")]
        // public IActionResult qa(int page = 1)
        // {
        //     var list = _context.HoiDap.ToList();
        // const int pageSize = 10;
        // if(page <1)
        // {
        //     page =1;
        // }
        // int recsCount = list.Count();
        // var paper = new Pager(recsCount,page,pageSize);
        // int recSkip = (page -1)*pageSize;
        // var data = list.Skip(recSkip).Take(paper.PageSize).ToList();
        // this.ViewBag.Pager = paper;
        // return View(data);
        // }
        [HttpGet("/qa")]
        public IActionResult qa(int page = 1)
        {
            var list = _context.HoiDap.Where(x => x.TrangThai == true).ToList();
            const int pageSize = 5;
            if (page < 1)
            {
                page = 1;
            }
            int recsCount = list.Count();
            var paper = new Pager(recsCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var data = list.Skip(recSkip).Take(paper.PageSize).ToList();
            this.ViewBag.Pager = paper;
            return View(data);
        }

        [Authorize(Roles = "USER")]
        [HttpGet("/ask_question")]
        public IActionResult ask_question()
        {
            return View();
        }

        [Authorize(Roles = "USER")]
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
                if (files.Count() == 1)
                {
                    if (files[0] != null && files[0] == file)
                    {
                        file.CopyTo(ms);
                        hoidap.TenHinh1 = file.FileName;
                        hoidap.HinhAnh1 = ms.ToArray();
                    }
                }
                if (files.Count() == 2)
                {
                    if (files[0] != null && files[0] == file)
                    {
                        file.CopyTo(ms);
                        hoidap.TenHinh1 = file.FileName;
                        hoidap.HinhAnh1 = ms.ToArray();
                    }
                    if (files[1] != null && files[1] == file)
                    {
                        file.CopyTo(ms);
                        hoidap.TenHinh2 = file.FileName;
                        hoidap.HinhAnh2 = ms.ToArray();
                    }
                }
                if (files.Count() == 3)
                {
                    if (files[0] != null && files[0] == file)
                    {
                        file.CopyTo(ms);
                        hoidap.TenHinh1 = file.FileName;
                        hoidap.HinhAnh1 = ms.ToArray();
                    }
                    if (files[1] != null && files[1] == file)
                    {
                        file.CopyTo(ms);
                        hoidap.TenHinh2 = file.FileName;
                        hoidap.HinhAnh2 = ms.ToArray();
                    }
                    if (files[2] != null && files[2] == file)
                    {
                        file.CopyTo(ms);
                        hoidap.TenHinh3 = file.FileName;
                        hoidap.HinhAnh3 = ms.ToArray();
                    }
                }


                var file1 = Path.Combine(_environment.ContentRootPath, "wwwroot/images/HoiDap", file.FileName);
                var fileStream = new FileStream(file1, FileMode.Create);
                file.CopyToAsync(fileStream);
            }
            hoidap.NguoiDang = tk;
            hoidap.LuotXem = 0;
            _context.Add(hoidap);
            int check = _context.SaveChanges();
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
            if (check > 0)
            {
                ViewBag.MessSUc = "1";
            }
            else
            {
                ViewBag.MessSUc = "2";
            }
            return View("ask_question");
        }
        [HttpGet("/details_qa/{MaHoiDap}")]
        public IActionResult details_qa(int MaHoiDap)
        {
            var hd = _context.HoiDap.Where(x => x.MaHoiDap == MaHoiDap).FirstOrDefault();
            hd.CthoiDap = _context.CthoiDap.Where(x => x.MaHoiDap == MaHoiDap).ToList();
            int number = 0;
            number = (int)(hd.LuotXem) + 1;
            string sql = "Update HoiDap set LuotXem = " + number + " Where MaHoiDap = {0}";
            _context.Database.ExecuteSqlRaw(sql, hd.MaHoiDap);
            return View(hd);
        }
        [Authorize(Roles = "USER")]
        [HttpPost("/comment_qa")]
        public IActionResult ReplaceView(CommentModel commentModel)
        {
            BinhLuan bl = new BinhLuan();
            if (commentModel.file != null)
            {
                MemoryStream ms = new MemoryStream();
                commentModel.file.CopyTo(ms);
                var file1 = Path.Combine(_environment.ContentRootPath, "wwwroot/images/BinhLuan", commentModel.file.FileName);
                using (var fileStream = new FileStream(file1, FileMode.Create))
                {
                    commentModel.file.CopyTo(fileStream);
                }
                bl.File = ms.ToArray();
                bl.TenFile = commentModel.file.FileName;
                bl.LoaiFile = commentModel.file.ContentType;
            }
            bl.NoiDung = commentModel.comment;
            bl.MaHoiDap = commentModel.ma;
            bl.TaiKhoan = User.FindFirst("TaiKhoan").Value.Trim();
            bl.ThoiGianBinhLuan = DateTime.Now;
            bl.TrangThai = true;
            _context.Add(bl);
            int x = _context.SaveChanges();
            if (x > 0)
            {
                _logger.LogInformation("Da insert");
            }
            else
            {
                _logger.LogInformation("Loi insert");
            }
            var hd = _context.HoiDap.Where(x => x.MaHoiDap == commentModel.ma).FirstOrDefault();
            ViewBag.HD = hd;
            return PartialView("ReplaceView");
        }
        //
        [Authorize(Roles = "USER")]
        [HttpPost("/comment_qaa")]
        public IActionResult ReplacePersonalComment(CommentModel commentModel)
        {
            BinhLuan bl = new BinhLuan();
            if (commentModel.file != null)
            {
                MemoryStream ms = new MemoryStream();
                commentModel.file.CopyTo(ms);
                var file1 = Path.Combine(_environment.ContentRootPath, "wwwroot/images/BinhLuan", commentModel.file.FileName);
                using (var fileStream = new FileStream(file1, FileMode.Create))
                {
                    commentModel.file.CopyTo(fileStream);
                }
                bl.File = ms.ToArray();
                bl.TenFile = commentModel.file.FileName;
                bl.LoaiFile = commentModel.file.ContentType;
            }
            bl.NoiDung = commentModel.comment;
            bl.MaHoiDap = commentModel.ma;
            bl.TaiKhoan = User.FindFirst("TaiKhoan").Value.Trim();
            bl.ThoiGianBinhLuan = DateTime.Now;
            bl.TrangThai = true;
            _context.Add(bl);
            int x = _context.SaveChanges();
            if (x > 0)
            {
                _logger.LogInformation("Da insert");
            }
            else
            {
                _logger.LogInformation("Loi insert");
            }
            var hd = _context.HoiDap.Where(x => x.MaHoiDap == commentModel.ma).FirstOrDefault();
            ViewBag.HD = hd;
            ViewBag.MaQA = commentModel.ma;
            return PartialView();
        }
        //
        [HttpGet("/delete")]
        public IActionResult delete(CommentModel commentModel)
        {
            for (int i = 39; i <= 40; i++)
            {
                _context.Database.ExecuteSqlRaw("Delete From BinhLuan Where MaBinhLuan = {0}",i);
                // _context.Database.ExecuteSqlRaw("Delete From CTTinTuc Where MaTinTuc = {0}", i);
                // _context.Database.ExecuteSqlRaw("Delete From TinTuc Where MaTinTuc = {0}",i);
            }
            return View("index");
        }

        [HttpPost("/replacewithDM")]
        public IActionResult ReplacewithDM(ModelMa listModelMa)
        {
            int page = 1;
            if(listModelMa.sotrang != 0)
            {
                page = listModelMa.sotrang;
            }
            // Console.WriteLine("Value"+listModelMa.Ma1 +listModelMa.Ma2+listModelMa.Ma3 +"...."+listModelMa.sapxep);
            var list = _context.HoiDap.Where(x => x.TrangThai == true).OrderBy(x => x.NgayDang).ToList();

            if (listModelMa.Ma1 == 0 && listModelMa.Ma2 == 0 && listModelMa.Ma3 == 0)
            {
                if (listModelMa.sapxep == 1)
                {
                    list = _context.HoiDap.Where(x => x.TrangThai == true).OrderBy(x => x.NgayDang).ToList();
                }
                else if(listModelMa.sapxep == 2)
                {
                    list = _context.HoiDap.Where(x => x.TrangThai == true).OrderByDescending(x => x.NgayDang).ToList();
                }
            }
            if (listModelMa.Ma1 != 0 && listModelMa.Ma2 == 0 && listModelMa.Ma3 == 0)
            {
                if (listModelMa.sapxep == 1)
                {
                    list = (from hd in _context.HoiDap
                    join ct in _context.CthoiDap on hd.MaHoiDap equals ct.MaHoiDap
                    where (ct.MaDanhMuc == listModelMa.Ma1)
                    select new HoiDap
                    {
                        MaHoiDap = hd.MaHoiDap,
                        TieuDe = hd.TieuDe,
                        NoiDung = hd.NoiDung,
                        HinhAnh1 = hd.HinhAnh1,
                        TenHinh1 = hd.TenHinh1,
                        HinhAnh2 = hd.HinhAnh2,
                        TenHinh2 = hd.TenHinh2,
                        HinhAnh3 = hd.HinhAnh3,
                        TenHinh3 = hd.TenHinh3,
                        TrangThai = hd.TrangThai,
                        NgayDang = hd.NgayDang,
                        NguoiDang = hd.NguoiDang,
                        LuotXem = hd.LuotXem
                    }).Where(x => x.TrangThai == true).Distinct().OrderBy(x =>x.NgayDang).ToList();
                }
                else if(listModelMa.sapxep == 2)
                {
                    list = (from hd in _context.HoiDap
                    join ct in _context.CthoiDap on hd.MaHoiDap equals ct.MaHoiDap
                    where (ct.MaDanhMuc == listModelMa.Ma1)
                    select new HoiDap
                    {
                        MaHoiDap = hd.MaHoiDap,
                        TieuDe = hd.TieuDe,
                        NoiDung = hd.NoiDung,
                        HinhAnh1 = hd.HinhAnh1,
                        TenHinh1 = hd.TenHinh1,
                        HinhAnh2 = hd.HinhAnh2,
                        TenHinh2 = hd.TenHinh2,
                        HinhAnh3 = hd.HinhAnh3,
                        TenHinh3 = hd.TenHinh3,
                        TrangThai = hd.TrangThai,
                        NgayDang = hd.NgayDang,
                        NguoiDang = hd.NguoiDang,
                        LuotXem = hd.LuotXem
                    }).Where(x => x.TrangThai == true).Distinct().OrderByDescending(x =>x.NgayDang).ToList();
                }

            }
            if (listModelMa.Ma1 != 0 && listModelMa.Ma2 != 0 && listModelMa.Ma3 == 0)
            {
                if (listModelMa.sapxep == 1)
                {
                    list = (from hd in _context.HoiDap
                    join ct in _context.CthoiDap on hd.MaHoiDap equals ct.MaHoiDap
                    where (ct.MaDanhMuc == listModelMa.Ma1 || ct.MaDanhMuc == listModelMa.Ma2)
                    select new HoiDap
                    {
                        MaHoiDap = hd.MaHoiDap,
                        TieuDe = hd.TieuDe,
                        NoiDung = hd.NoiDung,
                        HinhAnh1 = hd.HinhAnh1,
                        TenHinh1 = hd.TenHinh1,
                        HinhAnh2 = hd.HinhAnh2,
                        TenHinh2 = hd.TenHinh2,
                        HinhAnh3 = hd.HinhAnh3,
                        TenHinh3 = hd.TenHinh3,
                        TrangThai = hd.TrangThai,
                        NgayDang = hd.NgayDang,
                        NguoiDang = hd.NguoiDang,
                        LuotXem = hd.LuotXem
                    }).Where(x => x.TrangThai == true).Distinct().OrderBy(x =>x.NgayDang).ToList();
                }
                else if(listModelMa.sapxep == 2)
                {
                    list = (from hd in _context.HoiDap
                    join ct in _context.CthoiDap on hd.MaHoiDap equals ct.MaHoiDap
                    where (ct.MaDanhMuc == listModelMa.Ma1 || ct.MaDanhMuc == listModelMa.Ma2)
                    select new HoiDap
                    {
                        MaHoiDap = hd.MaHoiDap,
                        TieuDe = hd.TieuDe,
                        NoiDung = hd.NoiDung,
                        HinhAnh1 = hd.HinhAnh1,
                        TenHinh1 = hd.TenHinh1,
                        HinhAnh2 = hd.HinhAnh2,
                        TenHinh2 = hd.TenHinh2,
                        HinhAnh3 = hd.HinhAnh3,
                        TenHinh3 = hd.TenHinh3,
                        TrangThai = hd.TrangThai,
                        NgayDang = hd.NgayDang,
                        NguoiDang = hd.NguoiDang,
                        LuotXem = hd.LuotXem
                    }).Where(x => x.TrangThai == true).Distinct().OrderByDescending(x =>x.NgayDang).ToList();
                }

            }
            if (listModelMa.Ma1 != 0 && listModelMa.Ma2 != 0 && listModelMa.Ma3 != 0)
            {
                if (listModelMa.sapxep == 1)
                {
                    list = (from hd in _context.HoiDap
                    join ct in _context.CthoiDap on hd.MaHoiDap equals ct.MaHoiDap
                    where (ct.MaDanhMuc == listModelMa.Ma1 || ct.MaDanhMuc == listModelMa.Ma2 || ct.MaDanhMuc == listModelMa.Ma3)
                    select new HoiDap
                    {
                        MaHoiDap = hd.MaHoiDap,
                        TieuDe = hd.TieuDe,
                        NoiDung = hd.NoiDung,
                        HinhAnh1 = hd.HinhAnh1,
                        TenHinh1 = hd.TenHinh1,
                        HinhAnh2 = hd.HinhAnh2,
                        TenHinh2 = hd.TenHinh2,
                        HinhAnh3 = hd.HinhAnh3,
                        TenHinh3 = hd.TenHinh3,
                        TrangThai = hd.TrangThai,
                        NgayDang = hd.NgayDang,
                        NguoiDang = hd.NguoiDang,
                        LuotXem = hd.LuotXem
                    }).Where(x => x.TrangThai == true).Distinct().OrderBy(x =>x.NgayDang).ToList();
                }
                else if(listModelMa.sapxep == 2)
                {
                    list = (from hd in _context.HoiDap
                    join ct in _context.CthoiDap on hd.MaHoiDap equals ct.MaHoiDap
                    where (ct.MaDanhMuc == listModelMa.Ma1 || ct.MaDanhMuc == listModelMa.Ma2 || ct.MaDanhMuc == listModelMa.Ma3)
                    select new HoiDap
                    {
                        MaHoiDap = hd.MaHoiDap,
                        TieuDe = hd.TieuDe,
                        NoiDung = hd.NoiDung,
                        HinhAnh1 = hd.HinhAnh1,
                        TenHinh1 = hd.TenHinh1,
                        HinhAnh2 = hd.HinhAnh2,
                        TenHinh2 = hd.TenHinh2,
                        HinhAnh3 = hd.HinhAnh3,
                        TenHinh3 = hd.TenHinh3,
                        TrangThai = hd.TrangThai,
                        NgayDang = hd.NgayDang,
                        NguoiDang = hd.NguoiDang,
                        LuotXem = hd.LuotXem
                    }).Where(x => x.TrangThai == true).Distinct().OrderByDescending(x =>x.NgayDang).ToList();
                }

            }
            const int pageSize = 5;
            if (page < 1)
            {
                page = 1;
            }
            int recsCount = list.Count();
            Console.WriteLine("rec "+recsCount+"number page"+page);
            var paper = new Pager(recsCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var data = list.Skip(recSkip).Take(paper.PageSize).ToList();
            this.ViewBag.Pager = paper;
            return PartialView(data);
        }

        // [HttpGet("/qa")]
        // public IActionResult qaa(int page = 1)
        // {
        //     var list = _context.HoiDap.ToList();
        //     const int pageSize = 5;
        //     if (page < 1)
        //     {
        //         page = 1;
        //     }
        //     int recsCount = list.Count();
        //     var paper = new Pager(recsCount, page, pageSize);
        //     int recSkip = (page - 1) * pageSize;
        //     var data = list.Skip(recSkip).Take(paper.PageSize).ToList();
        //     this.ViewBag.Pager = paper;
        //     return View(data);
        // }
    }
}
