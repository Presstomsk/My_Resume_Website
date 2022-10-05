using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using My_Resume_Website.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace My_Resume_Website.Controllers
{
    public class ResumeWebsiteController : Controller
    {
        private readonly ILogger<ResumeWebsiteController> _logger;

        public ResumeWebsiteController(ILogger<ResumeWebsiteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Main()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacts(string name, string email, string comments)
        {
            ViewBag.FormMessage = new FormMessage
            {
                Name = name,
                Email = email,
                Comments = comments
            };
            return View("MessageRegistration");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
