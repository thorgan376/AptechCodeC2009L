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
        //private const string SERVER_NAME = "DESKTOP-7PS7HG8";
        private const string SERVER_NAME = "localhost";
        private const string PORT = "1435";
        private const string USERNAME = "sa";
        private const string PASSWORD = "Abc123456789";
        private const string DB_NAME = "c2009l";
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
            //string connectionString = $"Server={SERVER_NAME},{PORT}\\SQLEXPRESS;" +
            string connectionString = $"Server=(localdb)\\mssqllocaldb;" +
              $"Database={DB_NAME}" +
                $";User Id={USERNAME};Password={PASSWORD};";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();                
                return connection;
            }
            catch (Exception ex)
            {
                connection = null;
                Console.WriteLine($"Can not open connection: {ex.ToString()}");
                return connection;
            }
            
        }
            
    }
}
