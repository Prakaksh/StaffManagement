using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HCS.StaffManagement.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult CreateInvoicePage()
        {
            return View();
        }
    }
}