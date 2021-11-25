using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DatabaseConnection
    {
        public SqlConnection Connection;

        private static DatabaseConnection instance;
        private static object obj = new object();

        private DatabaseConnection()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
            Connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection GetInstance()
        {
            lock (obj)
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
            }
            return instance;
        }
    }
}
