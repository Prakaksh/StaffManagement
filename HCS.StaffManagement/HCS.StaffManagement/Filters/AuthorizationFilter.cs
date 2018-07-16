using System.Web.Mvc;
using System.Configuration;
using HCS.StaffManagement.Models;

namespace HCS.StaffManagement.Filter
{
    public class AuthorizationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {

                Repositories.AuthorizationContext objAuthorization = new Repositories.AuthorizationContext();
                AuthorizationModel Result = objAuthorization.GetAuthorization();
                string ProductKey = ConfigurationManager.AppSettings["ScreteKey"];
                if (Result.AuthorizationID == ProductKey.ToLower())
                {
                    base.OnActionExecuting(filterContext);
                }
                else
                {
                    filterContext.Result = new RedirectResult("~/Home/Unauthorized");
                }
            }
            catch { }
            
        }
    } 
}