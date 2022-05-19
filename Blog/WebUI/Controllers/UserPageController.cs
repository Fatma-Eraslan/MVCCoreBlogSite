using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class UserPageController : Controller
    {
        public IActionResult AuthorDetail()
        {
            return View();
        }

        public IActionResult UserSettings()
        {
            return View();
        }
    }
}
