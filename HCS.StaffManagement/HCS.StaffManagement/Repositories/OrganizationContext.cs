using HCS.StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Reflection.Emit;

namespace HCS.StaffManagement.Repositories
{
    public class OrganizationContext
    {
        private SqlConnection sqlConnection;

        public List<OrganizationModel> getOrganization(OrganizationModel objOrg)
        {
            using (sqlConnection = SqlUtility.GetConnection())
            {
                try
                {
                    var com = new DynamicParameters();
                    var Id = objOrg != null ? objOrg : null;
                    com.Add("@OrganizationID", objOrg.OrganizationID);
                    //com.Add("@UserID", userId.UserID);

                    List<OrganizationModel> GetOrgList = sqlConnection.Query<OrganizationModel>("usp_GetOrgList", com, commandType: CommandType.StoredProcedure).ToList();
                    return GetOrgList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

       
        public string CreateOrganization(OrganizationModel objOrg)
        {
            string status = string.Empty;

            try
            {

                var com = new DynamicParameters();

                com.Add("@OrganizationID", objOrg.OrganizationID);
                com.Add("@OrganizationName", objOrg.OrganizationName);
                com.Add("@GSTIN", objOrg.GSTIN);
                com.Add("@ESCINO", objOrg.ESCINO);
                com.Add("@EPFNO", objOrg.EPFNO);
                com.Add("@OrganizationAddr1", objOrg.OrganizationAddr1);
                com.Add("@OrganizationAddr2", objOrg.OrganizationAddr2);
                com.Add("@State", objOrg.State);
                com.Add("@City", objOrg.City);
                com.Add("@ContactNO", objOrg.ContactNO);
                com.Add("@MobileNO", objOrg.MobileNO);
                com.Add("@EmailID", objOrg.EmailID);
                com.Add("@InvoicePrefix", objOrg.InvoicePrefix);
                com.Add("@IsActive", objOrg.IsActive);
                com.Add("@CreatedBy", objOrg.CreatedBy);
                com.Add("@UpdatedBy", objOrg.UpdatedBy);
                
                    
                using (sqlConnection = SqlUtility.GetConnection())
                {
                   // var result = sqlConnection.Query<int>("usp_OrganizationInsertUpdate", com, commandType: CommandType.StoredProcedure).FirstOrDefault();
                   // status = AppUtility.getStatus(Convert.ToInt32(result));

                    var queryValues = sqlConnection.QueryMultiple("ExpenseTrakcer",  commandType: CommandType.StoredProcedure);


                    ExpenseTracker objExpesnse = queryValues.Read<ExpenseTracker>().FirstOrDefault();
                    List<ExpenseTrackModel> objExpens = queryValues.Read<ExpenseTrackModel>().ToList();

                    //ExpenseTracker obj = new ExpenseTracker();
                    //obj.Expense.a
                    
                   // TypeBuilder.SetParent((typeof)ExpenseTracker);
                    //TypeBuilder.DefineProperty

                    //for(var i = 0; i < objExpens.Count; i++)
                    //   {
                    //    objExpens[i].ExpenseName,

                    //}

                }

                

              

              

            }
            catch (Exception ex)
            {
                ErrorLogModel.ErrorLog("Organization", ex.Message.ToString());

               // return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return status;
        }































    }
}