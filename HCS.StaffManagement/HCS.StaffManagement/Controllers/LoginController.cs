using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HCS.StaffManagement.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        [Authorize]
        public ActionResult Login()
        {
            return View();
        }
        [Authorize]
        public ActionResult LoginPage()
        {
            return View();
        }

        public ActionResult DashBorad()
        {
            return View();
        }

        public ActionResult sample()
        {
            return View();
        }
    }
}