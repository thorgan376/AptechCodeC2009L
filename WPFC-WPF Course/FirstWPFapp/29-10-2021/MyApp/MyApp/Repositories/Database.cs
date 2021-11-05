using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Repositories
{
    public class Database
    {
        private const string SERVER_NAME = "localhost";
        private const string PORT = "1435";
        private const string USERNAME = "sa";
        private const string PASSWORD = "Abc123456789";
        private const string DB_NAME = "master";
        private OdbcConnection connection = null;

        
        public OdbcConnection GetConnection()
        {                        
            string connetionString = $"Data Source={SERVER_NAME},{PORT};" +
                $"Network Library=DBMSSOCN;Initial Catalog={DB_NAME};" +
                $"User ID={USERNAME};Password={PASSWORD};";
            connection = new OdbcConnection(connetionString);
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
