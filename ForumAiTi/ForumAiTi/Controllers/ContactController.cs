using ForumAiTi.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ForumAiTi.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }
        private ForumAiTiContext _context = new ForumAiTiContext();
        [HttpGet("/contact")]
        public IActionResult contact()
        {
            return View("contact");
        }

        [Authorize(Roles = "USER")]
        [HttpPost("/sendSupport")]
        public IActionResult sendSupport(GopY gopy)
        {
            gopy.NguoiGui = User.FindFirst("TaiKhoan").Value.Trim();
            gopy.ThoiGianGui = DateTime.Now;
            // var list = _context.GopY.FirstOrDefault(x => EntityFunctions.TruncateTime(x.ThoiGianGui) == )
            var sum = _context.GopY.FromSqlRaw("Select * from GopY where CONVERT(date,ThoiGianGui) = CONVERT(date,GETDATE()) and NguoiGui = {0}",gopy.NguoiGui).ToList().Count;
            Console.WriteLine(sum);
            if(sum >= 3)
            {
                ViewBag.MessSUcc = "3";
                return View("contact");
            }else{
            _context.Add(gopy);
            }
            int check = _context.SaveChanges();
            if(check > 0)
            {
                ViewBag.MessSUcc = "1";
                bool che = SendEmailTo(gopy.Email);
                if(che == true)
                {
                    _logger.LogInformation("send mail success");
                }
                else{
                    _logger.LogInformation("send mail failure");
                }
            }
            else{
                ViewBag.MessSUcc = "2";
            }
            return View("contact");
        }
        public bool SendEmailTo(String Email)
        {
            var user = _context.NguoiDung.Where(k => k.Email.Trim() == Email).ToList();
            if (user.Count() != 0)
            {
                var email = new MimeMessage();
                Random random = new Random();
                email.From.Add(MailboxAddress.Parse("xuandieu27092001@gmail.com"));
                email.To.Add(MailboxAddress.Parse(Email));
                email.Subject = "Forum AiTi - Phản hồi góp ý";
                email.Body = new TextPart(TextFormat.Plain) { 
                    Text = "FORUM AITI xin ghi nhận ý kiến đóng góp của bạn."+
                 "\nChúng tôi sẽ cố gắng cải thiện chất lượng của forum để mọi người có thể có trải nghiệm tuyệt vời nhất."};
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
