using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Repositories
{
    public class Database
    {
        private const string SEVER_NAME = "DESKTOP-KCDQ3PV";
        private const string SEVER_PORT = "1435";
        private const string USERNAME = "sa";
        private const string PASSWORD = "Ghjkl;1234";
        private const string DB_NAME = "master";
        private OdbcConnection connection = null;
        //singleton object
        private static Database instance;

        public Database() {
            }
        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public OdbcConnection GetConnection()
        {
            string connectionString = $"Sever = {SEVER_NAME},{SEVER_PORT}\\SQLEXPRESS;" +
            $"Network Library=DBMSSOCN;Initial Catalog={DB_NAME};" +
            $"Database={DB_NAME}" +
            $";User Id={USERNAME};Password={PASSWORD};";

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
