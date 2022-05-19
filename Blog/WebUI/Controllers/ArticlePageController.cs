using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ArticlePageController : Controller
    {
        public IActionResult Adding()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Reading()
        {
            return View();
        }
    }
}
