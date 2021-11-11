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
        private const string SERVER_NAME = "localhost";
        private const string SERVER_PORT = "1435";
        private const string USERNAME = "sa";
        private const string PASSWORD = "Ghjkl;1234";
        private const string DB_NAME = "master";
        private SqlConnection connection = null;
        //singleton object
        private static Database instance;

        private Database() {           
        }
        public static Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }
        
        public SqlConnection GetConnection()
        {            
              string connectionString = $"Server={SERVER_NAME},{SERVER_PORT};" +
                $"Database={DB_NAME}" +
                $";User Id={USERNAME}; Password='{PASSWORD}';";            
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Can not open connection due to: {ex}");
                return connection;
            }
            
        }
            
    }
}
