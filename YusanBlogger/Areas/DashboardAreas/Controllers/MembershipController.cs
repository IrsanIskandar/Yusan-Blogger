using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YusanBlogger.Areas.DashboardAreas.Controllers
{
    public class MembershipController : Controller
    {
        // GET /Membership/LoginSystem/
        [HttpGet]
        public IActionResult LoginSystem()
        {
            return View();
        }

        // POST /Membership/LoginSystem/Object
        [HttpPost]
        public IActionResult LoginSystem(object data)
        {
            return View();
        }

        // GET /Membership/LoginSystem/
        [HttpGet]
        public IActionResult RegisterSystem()
        {
            return View();
        }

        // POST /Membership/RegisterSystem/Object
        [HttpPost]
        public IActionResult RegisterSystem(object data)
        {
            return View();
        }
    }
}