﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HCS.StaffManagement.Controllers
{
    public class CustomerDetailsController : Controller
    {
        // GET: CustomerDetail
        public ActionResult CreateCustomerPage()
        {
            return View();
        }
    }
}