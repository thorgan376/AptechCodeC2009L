using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace MyApp.Repositories
{
    public class Database
    {
        private const string SEVER_NAME = "localhost";
        private const string SEVER_PORT = "1435";
        private const string USERNAME = "sa";
        private const string PASSWORD = "Ghjkl;1234";
        private const string DB_NAME = "Student_Management";
        private OdbcConnection connection = null;
        
        public OdbcConnection GetConnection()
        {
            string connectionString = $"Data Source = {SEVER_NAME},{SEVER_PORT};" +
            $"Network Library=DBMSSOCN;Initial Catalog={DB_NAME};" +
            $"User ID={USERNAME};Password={PASSWORD};";

            connection = new OdbcConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                connection = null;
                Console.WriteLine($"Cannot open a connection to database: {e.ToString()}");
                return connection;
            }
        }
    }
}
