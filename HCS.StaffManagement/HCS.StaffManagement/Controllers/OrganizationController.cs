using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HCS.StaffManagement.Controllers.WebApi;
using HCS.StaffManagement.Models;

namespace HCS.StaffManagement.Controllers
{
    public class OrganizationController : Controller
    {
        //OrganizationApi api = new OrganizationApi();
        
        // GET: Organization
        [HttpGet]
        public ActionResult CreateOrganizationPage()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateOrganizationPage(OrganizationModel objOrgModel)
        {

            return View();
        }


    }
}