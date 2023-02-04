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
        public IActionResult news(int page = 1)
        {
            var list = _context.TinTuc.Where(x => x.TrangThai == true).OrderByDescending(x => x.NgayDang).ToList();
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

        [HttpGet("/details_news/{MaTinTuc}")]
        public IActionResult details_news(int MaTinTuc)
        {
            var tt = _context.TinTuc.Where(x => x.MaTinTuc == MaTinTuc).FirstOrDefault();
            tt.CttinTuc = _context.CttinTuc.Where(x => x.MaTinTuc == MaTinTuc).ToList();
            tt.NoiDungTinTuc = _context.NoiDungTinTuc.Where(x => x.MaTinTuc == MaTinTuc).ToList();
            return View(tt);
        }
        //
        [HttpPost("/replacewithCD")]
        public IActionResult ReplacewithCD(ModelMa listModelMa)
        {
            int page = 1;
            if(listModelMa.sotrang != 0)
            {
                page = listModelMa.sotrang;
            }
            // Console.WriteLine("Value"+listModelMa.Ma1 +listModelMa.Ma2+listModelMa.Ma3 +"...."+listModelMa.sapxep);
            var list = _context.TinTuc.Where(x => x.TrangThai == true).OrderBy(x => x.NgayDang).ToList();

            if (listModelMa.Ma1 == 0 && listModelMa.Ma2 == 0 && listModelMa.Ma3 == 0)
            {
                if (listModelMa.sapxep == 1)
                {
                    list = _context.TinTuc.Where(x => x.TrangThai == true).OrderBy(x => x.NgayDang).ToList();
                }
                else if(listModelMa.sapxep == 2)
                {
                    list = _context.TinTuc.Where(x => x.TrangThai == true).OrderByDescending(x => x.NgayDang).ToList();
                }

            }
            if (listModelMa.Ma1 != 0 && listModelMa.Ma2 == 0 && listModelMa.Ma3 == 0)
            {
                if (listModelMa.sapxep == 1)
                {
                    list = (from tt in _context.TinTuc
                    join ct in _context.CttinTuc on tt.MaTinTuc equals ct.MaTinTuc
                    where (ct.MaChuDe == listModelMa.Ma1)
                    select new TinTuc
                    {
                        MaTinTuc = tt.MaTinTuc,
                        TieuDe = tt.TieuDe,
                        NoiDung = tt.NoiDung,
                        TenFile = tt.TenFile,
                        HinhAnh = tt.HinhAnh,
                        TrangThai = tt.TrangThai,
                        NgayDang = tt.NgayDang,
                        NguoiDang = tt.NguoiDang
                    }).Where(x => x.TrangThai == true).Distinct().OrderBy(x =>x.NgayDang).ToList();
                }
                else if(listModelMa.sapxep == 2)
                {
                    list = (from tt in _context.TinTuc
                    join ct in _context.CttinTuc on tt.MaTinTuc equals ct.MaTinTuc
                    where (ct.MaChuDe == listModelMa.Ma1)
                    select new TinTuc
                    {
                        MaTinTuc = tt.MaTinTuc,
                        TieuDe = tt.TieuDe,
                        NoiDung = tt.NoiDung,
                        TenFile = tt.TenFile,
                        HinhAnh = tt.HinhAnh,
                        TrangThai = tt.TrangThai,
                        NgayDang = tt.NgayDang,
                        NguoiDang = tt.NguoiDang
                    }).Where(x => x.TrangThai == true).Distinct().OrderByDescending(x =>x.NgayDang).ToList();
                }

            }
            if (listModelMa.Ma1 != 0 && listModelMa.Ma2 != 0 && listModelMa.Ma3 == 0)
            {
                if (listModelMa.sapxep == 1)
                {
                    list = (from tt in _context.TinTuc
                    join ct in _context.CttinTuc on tt.MaTinTuc equals ct.MaTinTuc
                    where (ct.MaChuDe == listModelMa.Ma1 || ct.MaChuDe == listModelMa.Ma2)
                    select new TinTuc
                    {
                        MaTinTuc = tt.MaTinTuc,
                        TieuDe = tt.TieuDe,
                        NoiDung = tt.NoiDung,
                        TenFile = tt.TenFile,
                        HinhAnh = tt.HinhAnh,
                        TrangThai = tt.TrangThai,
                        NgayDang = tt.NgayDang,
                        NguoiDang = tt.NguoiDang
                    }).Where(x => x.TrangThai == true).Distinct().OrderBy(x =>x.NgayDang).ToList();
                }
                else if(listModelMa.sapxep == 2)
                {
                    list = (from tt in _context.TinTuc
                    join ct in _context.CttinTuc on tt.MaTinTuc equals ct.MaTinTuc
                    where (ct.MaChuDe == listModelMa.Ma1 || ct.MaChuDe == listModelMa.Ma2)
                    select new TinTuc
                    {
                        MaTinTuc = tt.MaTinTuc,
                        TieuDe = tt.TieuDe,
                        NoiDung = tt.NoiDung,
                        TenFile = tt.TenFile,
                        HinhAnh = tt.HinhAnh,
                        TrangThai = tt.TrangThai,
                        NgayDang = tt.NgayDang,
                        NguoiDang = tt.NguoiDang
                    }).Where(x => x.TrangThai == true).Distinct().OrderByDescending(x =>x.NgayDang).ToList();
                }

            }
            if (listModelMa.Ma1 != 0 && listModelMa.Ma2 != 0 && listModelMa.Ma3 != 0)
            {
                if (listModelMa.sapxep == 1)
                {
                    list = (from tt in _context.TinTuc
                    join ct in _context.CttinTuc on tt.MaTinTuc equals ct.MaTinTuc
                    where (ct.MaChuDe == listModelMa.Ma1 || ct.MaChuDe == listModelMa.Ma2 || ct.MaChuDe == listModelMa.Ma3)
                    select new TinTuc
                    {
                        MaTinTuc = tt.MaTinTuc,
                        TieuDe = tt.TieuDe,
                        NoiDung = tt.NoiDung,
                        TenFile = tt.TenFile,
                        HinhAnh = tt.HinhAnh,
                        TrangThai = tt.TrangThai,
                        NgayDang = tt.NgayDang,
                        NguoiDang = tt.NguoiDang
                    }).Where(x => x.TrangThai == true).Distinct().OrderBy(x =>x.NgayDang).ToList();
                }
                else if(listModelMa.sapxep == 2)
                {
                    list = (from tt in _context.TinTuc
                    join ct in _context.CttinTuc on tt.MaTinTuc equals ct.MaTinTuc
                    where (ct.MaChuDe == listModelMa.Ma1 || ct.MaChuDe == listModelMa.Ma2 || ct.MaChuDe == listModelMa.Ma3)
                    select new TinTuc
                    {
                        MaTinTuc = tt.MaTinTuc,
                        TieuDe = tt.TieuDe,
                        NoiDung = tt.NoiDung,
                        TenFile = tt.TenFile,
                        HinhAnh = tt.HinhAnh,
                        TrangThai = tt.TrangThai,
                        NgayDang = tt.NgayDang,
                        NguoiDang = tt.NguoiDang
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
    }
}
