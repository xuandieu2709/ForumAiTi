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

        [HttpPost("/search")]
        public IActionResult search(string search)
        {
            // var list = _context.HoiDap.FromSqlRaw("")
            // var list = _context.HoiDap.FromSqlRaw($"Select * from TinTuc where CONCAT_WS(TieuDe,NoiDung,NguoiDang) like N'%"+search+"%'").ToList();
            // var list1 = _context.TinTuc.FromSqlRaw($"Select * from HoiDap where CONCAT_WS(TieuDe,NoiDung,NguoiDang) like N'%"+search+"%'").ToList();
            var list1 = _context.HoiDap.Where(x => x.TieuDe!.Contains(search) || x.NoiDung!.Contains(search)|| x.NguoiDang!.Contains(search)).ToList();
            var list = _context.TinTuc.Where(x => x.TieuDe!.Contains(search) || x.NoiDung!.Contains(search)|| x.NguoiDang!.Contains(search)).ToList();
            var listUser = new List<NguoiDung>();
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
            var listU = _context.NguoiDung.Where(x => (x.TaiKhoan!.Contains(search) && x.VaiTro == "USER") || (x.HoTen!.Contains(search)&& x.VaiTro == "USER") || (x.Nickname!.Contains(search)&& x.VaiTro == "USER")).ToList();
            if(listU != null)
            {
                foreach(var item in listU)
                {
                    listUser.Add(item);
                }
            }
            // var listnew = new List<NguoiDung>();
            Console.WriteLine(listUser.Count());
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
            ViewBag.ListUSER = listUser;
            ViewBag.ListHD = list1;
            ViewBag.ListTT = list;
            ViewBag.Keyword = search;
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
