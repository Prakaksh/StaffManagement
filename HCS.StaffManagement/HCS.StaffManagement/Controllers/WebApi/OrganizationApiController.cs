using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HCS.StaffManagement.Models;
using HCS.StaffManagement.Repositories;
using System.Data.Entity;
namespace HCS.StaffManagement.Controllers.WebApi
{
   

    public class OrganizationApiController: ApiController
    {
        

        [Route("Api/WebApi/OraganizationApi")]
        [HttpGet]
        public HttpResponseMessage GetOrganization([FromBody]OrganizationModel objOrg)
        {
           
            try
            {

                OrganizationContext objOrgContext = new OrganizationContext();
                List<OrganizationModel> GetOrgList = new List<OrganizationModel>();
                GetOrgList = objOrgContext.getOrganization(objOrg);
              
                return Request.CreateResponse(HttpStatusCode.OK, GetOrgList);
            }
            catch (Exception ex)
            {
                //objErrorLogServices.LogError("Client", "GetClient", "", "", ex.Message.ToString());
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Internal Server Error");
            }

        }


        [Route("Api/WebApi/OraganizationApi")]
        [HttpPost]
        public HttpResponseMessage CreateOrganization([FromBody]OrganizationModel objOrg)
        {

            try
            {

                OrganizationContext objOrgContext = new OrganizationContext();
                List<OrganizationModel> GetOrgList = new List<OrganizationModel>();
                string result= objOrgContext.CreateOrganization(objOrg);

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                //objErrorLogServices.LogError("Client", "GetClient", "", "", ex.Message.ToString());
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Internal Server Error");
            }

        }




        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}