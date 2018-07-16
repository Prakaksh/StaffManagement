using Dapper;
using HCS.StaffManagement;
using HCS.StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Repositories
{
    public class AuthorizationContext
    {
        private SqlConnection sqlConnection;

        public AuthorizationModel GetAuthorization()
        {
            try
            {

                using (sqlConnection = SqlUtility.GetConnection())
                {
                    dynamic Authorization = sqlConnection.Query<dynamic>("usp_GetAuthorization", commandType: CommandType.StoredProcedure).FirstOrDefault();

                    return new AuthorizationModel()
                    {
                        AuthorizationID = Convert.ToString(Authorization.AuthorizationID),
                        
                    };
            
                }
            }
            catch(Exception ex) {
                //ErrorLogModel.ErrorLog("AuthorizationContext", ex.Message.ToString());

                throw ex;
            }

        }
    }
}