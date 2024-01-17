using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp.DBAccess
{
    public class WorkerDB
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["WorkerDB"].ConnectionString;

        SqlConnection sqlConnection = new SqlConnection(connStr);
    }
}
