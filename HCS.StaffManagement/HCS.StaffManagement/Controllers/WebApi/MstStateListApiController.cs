using Dapper;
using HCS.StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HCS.StaffManagement.Repositories;

namespace HCS.StaffManagement.Controllers.WebApi
{
    [RoutePrefix("Api/WebApi")]
    public class MstStateListApiController : ApiController
    {
        [Route("GetStateList")]
        [HttpGet]
        public HttpResponseMessage GetStateList([FromBody]MstStateModel objState)
        {
            try
            {
                GetStateListContext objStateContext = new GetStateListContext();
               
                IEnumerable<MstStateModel>GetStateList = objStateContext.GetMstStateList(objState);

                return Request.CreateResponse(HttpStatusCode.OK, GetStateList);
            }
            catch (Exception ex)
            {
                //objErrorLogServices.LogError("Client", "GetClient", "", "", ex.Message.ToString());
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Internal Server Error");
            }

        }
    }
}