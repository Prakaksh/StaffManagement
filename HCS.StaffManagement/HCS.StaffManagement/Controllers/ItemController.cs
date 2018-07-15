using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HCS.StaffManagement.Models;

namespace HCS.StaffManagement.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        [HttpGet]
        public ActionResult CreateItemPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateItemPage(ItemModel objItem)
        {
            try
            {
                // Verification  
                if (ModelState.IsValid)
                {

                    // Info.  
                    return this.Json(new
                    {
                        EnableSuccess = true,
                        SuccessTitle = "Success",
                        SuccessMsg = objItem.ItemName
                    });
                }
            }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }
            // Info  
            return this.Json(new
            {
                EnableError = true,
                ErrorTitle = "Error",
                ErrorMsg = "Something goes wrong, please try again later"
            });
        }
    }
}