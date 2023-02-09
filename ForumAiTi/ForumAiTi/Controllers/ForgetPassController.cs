using ForumAiTi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;

namespace ForumAiTi.Controllers
{
    public class ForgetPassController : Controller
    {
        private readonly ILogger<ForgetPassController> _logger;

        public ForgetPassController(ILogger<ForgetPassController> logger)
        {
            _logger = logger;
        }
        private static Random random = new Random();

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private ForumAiTiContext _context = new ForumAiTiContext();
        [HttpGet("/forgetpass")]
        public IActionResult forgetpass()
        {
            return View();
        }

        [HttpPost("/forgetpass")]
        public IActionResult forgetpasss(NguoiDung user)
        {
            var user1 = _context.NguoiDung.FirstOrDefault(x => x.Email.Trim() == user.Email);
            if (user1 == null)
            {
                ViewBag.MessForget = "1";
            }
            else
            {
                ViewBag.MessForget = "2";
                bool checkmail = SendEmail(user.Email);
                if (checkmail == true)
                {
                    HttpContext.Session.Remove("Email");
                    HttpContext.Session.SetString("Email", user.Email);
                    ViewBag.MessSendMail = "1";
                }
                else
                {
                    ViewBag.MessSendMail = "1";
                }
            }
            return View("forgetpass");
        }
        [HttpPost("/confirmcode")]
        public IActionResult confirmcode(string Code)
        {
            if (Code.Equals(HttpContext.Session.GetString("CODE")))
            {
                ViewBag.MessConfirmCode = "1";
                Console.WriteLine("Ma dung");
            }
            else
            {
                ViewBag.MessConfirmCode = "2";
                Console.WriteLine("Ma sai");
            }
            return View("forgetpass");
        }

        [HttpPost("/changepass")]
        public RedirectToActionResult  changepass(string MatKhau)
        {
            var user = _context.NguoiDung.FirstOrDefault(x => x.Email.Trim() == HttpContext.Session.GetString("Email"));
            user.MatKhau = MatKhau;
            _context.Update(user);
            _context.SaveChanges();
            ViewBag.StatusLogin = "3";

            return RedirectToAction("Index","Login");
        }
        public bool SendEmail(String Email)
        {
            var user = _context.NguoiDung.Where(k => k.Email.Trim() == Email).ToList();
            if (user.Count() != 0)
            {
                var email = new MimeMessage();
                Random random = new Random();
                string code = RandomString();
                HttpContext.Session.Remove("CODE");
                HttpContext.Session.SetString("CODE", code);
                email.From.Add(MailboxAddress.Parse("xuandieu27092001@gmail.com"));
                email.To.Add(MailboxAddress.Parse(Email));
                email.Subject = "FORUM AITI - MÃ XÁC NHẬN CẤP LẠI MẬT KHẨU";
                email.Body = new TextPart(TextFormat.Plain) { Text = "Mã xác nhận của bạn là: " + code };
                // send email
                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("xuandieu27092001@gmail.com", "ttyqrtfjgudozrei");
                smtp.Send(email);
                smtp.Disconnect(true);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
