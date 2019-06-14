using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YusanBlogger.Areas.DashboardAreas.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult DashboardIndex()
        {
            return View();
        }
    }
}