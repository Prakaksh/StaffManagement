using Dapper;
using HCS.StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Repositories
{
    public class GetStateListContext
    {
        private SqlConnection sqlConnection;

        public IEnumerable<MstStateModel> GetMstStateList(MstStateModel objOrg)
        {

            using (sqlConnection = SqlUtility.GetConnection())
            {

                IEnumerable<MstStateModel> GetMstStateList = sqlConnection.Query<MstStateModel>("Usp_GetMstStateList", commandType: CommandType.StoredProcedure).ToList();
                return GetMstStateList;

            }

        }

    }
}