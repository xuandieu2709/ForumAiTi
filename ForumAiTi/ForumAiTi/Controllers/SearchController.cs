using ForumAiTi.Models;
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
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private ForumAiTiContext _context = new ForumAiTiContext();

        public SearchController(ILogger<SearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/search")]
        public IActionResult search(string search,int page =1,int page1 = 1,int page2 = 1)
        {
            // var list = _context.HoiDap.FromSqlRaw("")
            // var list = _context.HoiDap.FromSqlRaw($"Select * from TinTuc where CONCAT_WS(TieuDe,NoiDung,NguoiDang) like N'%"+search+"%'").ToList();
            // var list1 = _context.TinTuc.FromSqlRaw($"Select * from HoiDap where CONCAT_WS(TieuDe,NoiDung,NguoiDang) like N'%"+search+"%'").ToList();
            var list1 = _context.HoiDap.Where(x => (x.TieuDe!.Contains(search) || x.NoiDung!.Contains(search)|| x.NguoiDang!.Contains(search) && x.TrangThai == true )).OrderByDescending(x => x.NgayDang).ToList();
            var list = _context.TinTuc.Where(x => (x.TieuDe!.Contains(search) || x.NoiDung!.Contains(search)|| x.NguoiDang!.Contains(search) && x.TrangThai == true )).OrderByDescending(x => x.NgayDang).ToList();
            // var listUser = new List<NguoiDung>();
            // foreach(var item in list1)
            // {
            //     var user = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan == item.NguoiDang && x.VaiTro == "USER");
            //     listUser.Add(user);
            // }
            // foreach(var item in list)
            // {
            //     var user = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan == item.NguoiDang && x.VaiTro == "USER");
            //     listUser.Add(user);
            // }
            // var listUser = _context.NguoiDung.Where(x => EF.Functions.Like(x.TaiKhoan, "%"+search+"%") || EF.Functions.Like(x.HoTen, "%"+search+"%")
            //  || EF.Functions.Like(x.Nickname, " %"+search+"%") && x.VaiTro == "USER").ToList();
            // string sql = "Select * from NguoiDung where  HoTen like N'%{0}%' or TaiKhoan like N'%{0}%' or Nickname like N'%{0}%' and VaiTro = 'USER';";
            // var listUser = _context.NguoiDung.FromSqlRaw(sql,search).ToList();
            var listUser = _context.NguoiDung.Where(x => (x.HoTen!.Contains(search) && x.VaiTro == "USER") || (x.Nickname!.Contains(search) && x.VaiTro == "USER")|| (x.TaiKhoan!.Contains(search) && x.VaiTro == "USER")).ToList();
            // var listUser = (from hd in _context.HoiDap   
            //         join nd in _context.NguoiDung on hd.NguoiDang equals nd.TaiKhoan
            //         join tt in _context.TinTuc on nd.TaiKhoan equals tt.NguoiDang
            //         where (
            //         (nd.TaiKhoan!.Contains(search) && nd.VaiTro == "USER") || (nd.HoTen!.Contains(search)&& nd.VaiTro == "USER")
            //         )
            //         select new NguoiDung
            //         {
            //             HoTen = nd.HoTen,
            //             Nickname = nd.Nickname,
            //             SinhNhat = nd.SinhNhat,
            //             GioiTinh = nd.GioiTinh,
            //             HinhAnh = nd.HinhAnh,
            //             GtbanThan = nd.GtbanThan,
            //             Email = nd.Email,
            //             TaiKhoan = nd.TaiKhoan,
            //             VaiTro = nd.VaiTro,
            //             MaLoai = nd.MaLoai,
            //             MatKhau = nd.MatKhau,
            //             NgheNghiep = nd.NgheNghiep
            //         }).Where(x => x.VaiTro == "USER").ToList();
            // if(listU != null)
            // {
            //     foreach(var item in listU)
            //     {
            //         listUser.Add(item);
            //     }
            // }
            // var listnew = new List<NguoiDung>();
            // if(listUser.Count != 0)
            // {
            //     // IEnumerable<NguoiDung> listnew = 
            // foreach(var item in listUser)
            // {
            //     Console.WriteLine(item);
            //  } 
            // // ViewBag.ListUSER = listnew;
            // // Console.WriteLine(listnew.Count());
            // }else{
            //     var listnew = new List<NguoiDung>();
            // ViewBag.ListUSER = listnew;
            // }
            ViewBag.Keyword = search;
             // ##################
            const int pageSize = 5;
            if (page < 1)
            {
                page = 1;
            }
            int recsCount = list1.Count();
            Console.WriteLine("page"+page+"\tpage1"+page1+"\tpage2"+page2);
            var paper = new Pager(recsCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var data = list1.Skip(recSkip).Take(paper.PageSize).ToList();
            this.ViewBag.Pager = paper;
            // ##################
            if (page1 < 1)
            {
                page1 = 1;
            }
            int recsCount1 = list.Count();
            var paper1 = new Pager(recsCount1, page1, pageSize);
            int recSkip1 = (page1 - 1) * pageSize;
            var data1 = list.Skip(recSkip1).Take(paper1.PageSize).ToList();
            this.ViewBag.Pager1 = paper1;
            // ##################
            const int pageSize1 = 3;
            if (page2 < 1)
            {
                page2 = 1;
            }
            int recsCount2 = listUser.Count();
            var paper2 = new Pager(recsCount2, page2, pageSize1);
            int recSkip2 = (page2 - 1) * pageSize1;
            var data2 = listUser.Skip(recSkip2).Take(paper2.PageSize).ToList();
            this.ViewBag.Pager2 = paper2;
            // ############ //
            ViewBag.ListUSER = data2;
            ViewBag.ListHD = data;
            ViewBag.ListTT = data1;
            return View();
        }



        // public string utf8Convert(string s)
        // {
        //     string stFormD = s.Normalize(NormalizationForm.FormD);
        //     StringBuilder sb = new StringBuilder();
        //     for (int ich = 0; ich < stFormD.Length; ich++)
        //     {
        //         System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
        //         if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
        //         {
        //             sb.Append(stFormD[ich]);
        //         }
        //     }
        //     sb = sb.Replace('Đ', 'D');
        //     sb = sb.Replace('đ', 'd');
        //     return (sb.ToString().Normalize(NormalizationForm.FormD));
        // }
    }
}
