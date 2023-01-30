using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using ForumAiTi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Globalization;

namespace SignalRChat.Hubs
{
    
    public class ChatHub : Hub
    {
        private readonly ILogger<ChatHub> _logger;

        public ChatHub(ILogger<ChatHub> logger)
        {
            _logger = logger;
        }
        private ForumAiTiContext _context = new ForumAiTiContext();
        public async Task SendMessage1(string idChat,string userReceive,string message)
        {
            // Console.WriteLine(message+"file"+imageData);
            // insert
            var chat = _context.TroChuyen.Where(x =>x.MaTroChuyen == Int32.Parse(idChat)).FirstOrDefault();
            Console.WriteLine(userReceive);
            string userSend;
            if(chat.ThanhVien1 == userReceive)
            {
                userSend = chat.ThanhVien2;
            }
            else{
                userSend = chat.ThanhVien1;
            }
            // MemoryStream ms = new MemoryStream();
            // file.CopyTo(ms);
            CttroChuyen ct = new CttroChuyen();
            // ct.File = ms.ToArray();
            ct.NoiDung = message;
            ct.NguoiGui = userSend;
            ct.NguoiNhan = userReceive;
            ct.MaTroChuyen = chat.MaTroChuyen;
            ct.ThoiGianGui = DateTime.Now;
            // ct.ThoiGianGui = DateTime.ParseExact(timeSend, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            // ct.TenFile = file.FileName;
            // ct.LoaiFile = file.ContentType;
            _context.Add(ct);
            var check = _context.SaveChanges();
            if(check > 0)
            {
                _logger.LogInformation("Đã thêm");
            }
            else{
                _logger.LogInformation("Thêm lỗi");
            }
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}