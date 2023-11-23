using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace HiTechDistributionInc.DAL
{
    public static class UtilityDb
    {
        public static SqlConnection OpenConnection()
        {
            var sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["EntityFrameworkDbContext"].ConnectionString;
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
