using ForumAiTi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Facebook;

namespace ForumAiTi.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        private ForumAiTiContext _context = new ForumAiTiContext();


        [HttpGet]
        [Route("/login")]
        public IActionResult Index(string returnUrl)
        {
            if (HttpContext.User.Identity.Name == null)
                return View("login");
            else
            {
                if (string.IsNullOrWhiteSpace(returnUrl) || !returnUrl.StartsWith("/"))
                {
                    returnUrl = "/";
                }
                return this.Redirect(returnUrl);
            }
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> LoginUser(NguoiDung user, string returnUrl)
        {
            NguoiDung us1 = _context.NguoiDung.Find(user.TaiKhoan);
            if (us1 == null)
            {
                return Redirect("/login");
            }
            if (us1.MatKhau.Trim().Equals(user.MatKhau.Trim()))
            {
                await SignInUser(us1);
                if (string.IsNullOrWhiteSpace(returnUrl) || !returnUrl.StartsWith("/"))
                {
                    returnUrl = "/home";
                }
                return this.Redirect(returnUrl);
            }
            else
            {
                TempData["StatusLogin"] = "1";
                return RedirectToAction("Index");
            }
        }
        [HttpGet("/loginWithgoogle")]
        public async Task LoginGoogle()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties()
            {
                RedirectUri = Url.Action("GoogleResponse")
            });
        }
        public async Task<IActionResult> GoogleResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var Claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new
            {
                claim.Issuer,
                claim.OriginalIssuer,
                claim.Type,
                claim.Value
            });
            var user = new NguoiDung();
            int count = 0;
            foreach (var value in Claims)
            {
                Console.WriteLine(value.Value);
                if (count == 1)
                {
                    user.HoTen = value.Value;
                }
                if (count == 4)
                {
                    user.TaiKhoan = value.Value;
                    user.Email = value.Value;
                }
                count++;
            }
            Console.WriteLine(user.TaiKhoan);
            var userCheck = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan.Trim() == user.TaiKhoan);
            if (userCheck == null)
            {
                user.VaiTro = "USER";
                user.MaLoai = 2;
                string filepath = @".\wwwroot\images\noneavatar.jpg";
                byte[] uploadedImage = System.IO.File.ReadAllBytes(filepath);
                user.HinhAnh = uploadedImage;
                _context.Add(user);
                _context.SaveChanges();
            }
            else
            {
            }
            return Redirect("/home");

        }
        [HttpGet("/loginWithfacebook")]
        public async Task LoginFacebook()
        {
            await HttpContext.ChallengeAsync(FacebookDefaults.AuthenticationScheme, new AuthenticationProperties()
            {
                RedirectUri = Url.Action("FacebookResponse")
            });
        }
        public async Task<IActionResult> FacebookResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var Claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new
            {
                claim.Issuer,
                claim.OriginalIssuer,
                claim.Type,
                claim.Value
            });
            var user = new NguoiDung();
            int count = 0;
            foreach (var value in Claims)
            {
                Console.WriteLine(value.Value);
                if (count == 0)
                {
                    user.TaiKhoan = value.Value;
                }
                if (count == 1)
                {
                    user.Email = value.Value;
                }
                if (count == 2)
                {
                    user.HoTen = value.Value;
                }
                count++;
            }
            Console.WriteLine(user.TaiKhoan);
            var userCheck = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan.Trim() == user.TaiKhoan);
            if (userCheck == null)
            {
                user.VaiTro = "USER";
                user.MaLoai = 3;
                string filepath = @".\wwwroot\images\noneavatar.jpg";
                byte[] uploadedImage = System.IO.File.ReadAllBytes(filepath);
                user.HinhAnh = uploadedImage;
                _context.Add(user);
                _context.SaveChanges();
            }
            else
            {
            }
            return Redirect("/home");

        }

        private async Task SignInUser(NguoiDung user)
        {
            NguoiDung newUser = _context.NguoiDung.Where(x => x.TaiKhoan == user.TaiKhoan).FirstOrDefault();
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, newUser.TaiKhoan),
                new Claim(ClaimTypes.Role, newUser.VaiTro),
            };
            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity));
        }
        [HttpGet("logout")]
        public async Task<IActionResult> logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index");
        }

        [HttpPost("/signup")]
        public IActionResult signupp(NguoiDung user)
        {
            var user1 = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan.Trim() == user.TaiKhoan);
            if (user1 == null)
            {
                user.MaLoai = 1;
                user.VaiTro = "USER";
                string filepath = @".\wwwroot\images\noneavatar.jpg";
                byte[] uploadedImage = System.IO.File.ReadAllBytes(filepath);
                user.HinhAnh = uploadedImage;
                _context.Add(user);
                _context.SaveChanges();
                TempData["StatusLogin"] = "2";
                return View("login");
            }
            else
            {
                ViewBag.MessSignUp = "1";
                return View("signup");
            }
        }
        [HttpGet("/signup")]
        public IActionResult signup()
        {
            // List<NguoiDung> list = _context.NguoiDung.ToList();
            // foreach (var i in list)
            // {
            //     string filepath = @".\wwwroot\images\noneavatar.jpg";
            //     byte[] uploadedImage = System.IO.File.ReadAllBytes(filepath);
            //     i.HinhAnh = uploadedImage;
            //     _context.Update(i);
            //     _context.SaveChanges();
            // }
            return View();
        }
    }
}
