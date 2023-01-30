
using ForumAiTi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using static System.Net.WebRequestMethods;

namespace ForumAiTi.Controllers
{
public class ErrorController : Controller
{
    [Route("Error/{statusCode}")]
    public IActionResult HttpStatusCodeHandler(int statusCode)
    {
        switch (statusCode)
        {
            case 404:
                return View("404");
            case 405:
                return View("405");
            case 401:
                ViewBag.ErrorMessage = "You do not have acccess to this page. Please make sure you are logged in, or contact your administrator.";
                ViewBag.ErrorNumber = "401";
                break;
            case 500:
                return View("500");
            case 403:
                ViewBag.ErrorMessage = "Forbidden. Please contact administrator.";
                ViewBag.ErrorNumber = "403";
                break;
            case 503:
                ViewBag.ErrorMessage = "Service unavailable. Please contact administrator";
                ViewBag.ErrorNumber = "503";
                break;
            case 504:
                ViewBag.ErrorMessage = "Gateway Timeout. Please contact administrator";
                ViewBag.ErrorNumber = "504";
                break;
            case 001:
                ViewBag.ErrorMessage = "This link has expired.";
                ViewBag.ErrorNumber = "Oh no!";
                break;

        }
        return View("NotFound");
    }
}
}