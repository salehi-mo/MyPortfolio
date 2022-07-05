using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {


        private readonly List<Portfolio> _portfolios = new List<Portfolio>
        {
            new Portfolio
            {
                Id = 1, Title = "KATANA", Image = "01.jpg", Description = "این اولین پروژه من بود!!!"
            },
            new Portfolio
            {
                Id = 2, Title = "پیام رسان", Image = "02.jpg", Description = "پیام رسان اختصاصی گروه برنامه نویسان"
            },
            new Portfolio
            {
                Id = 3, Title = "شبکه اجتماعی", Image = "03.jpg",
                Description = "شبکه اجتماعی ملی در راستای حمایت از تولید ملی"
            },
            new Portfolio
            {
                Id = 4, Title = "درخواست غذا", Image = "04.jpg",
                Description = "اپلیکیشن درخواست آنلاین غذای نیمه آماده و آماده طبخ"
            }
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی مصطفی صالحی خوش آمدید";

            ViewBag.headingText =
                "این سایت به جهت معرفی من به مشتریان و کسانی که می خواهند از خدمات سایت بهره مند شوند طراحی و پیاده سازی شده است";
            //return View();
            return View(_portfolios);
            //return View("Index");
            //return View("Index", _portfolios);
        }

        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "mostafa.salehei@outlook.com",
                Mobile = "09128099518",
                Github = "github.com/atriya"
            };
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

      
    }
}
