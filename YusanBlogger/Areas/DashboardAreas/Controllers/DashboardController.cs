using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YusanBlogger.Areas.DashboardAreas.Controllers
{
    public class DashboardController : Controller
    {
        // GET /Dashboard/DashboardIndex/
        [HttpGet]
        public IActionResult DashboardIndex()
        {
            return View();
        }

        // GET /Dashboard/MakeArticles/
        [HttpGet]
        public IActionResult MakeArticles()
        {
            return View();
        }

        // POST Dashboard/MakeArticles/
        [HttpPost]
        public IActionResult MakeArticles(object data)
        {
            return View();
        }
    }
}