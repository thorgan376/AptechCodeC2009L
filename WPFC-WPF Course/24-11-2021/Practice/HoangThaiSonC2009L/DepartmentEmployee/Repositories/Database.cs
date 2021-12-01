using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DepartmentEmployee.Repositories
{
    public class Database
    {
        private const string DATA_SOURCE = @"DESKTOP-KCDQ3PV\SQLEXPRESS";
        private const string Initial_Catalog = "master";
        private const string USER_ID = "sa";
        private const string PASSWORD = "Ghjkl;1234";
        private SqlConnection connection = null;

        private static Database instance;

        private Database()
        {
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
            string connectionString = $"Data Source = {DATA_SOURCE};" +
                $"Initial Catalog = {Initial_Catalog}; User ID = {USER_ID}; Password = {PASSWORD};";
            if (connection != null)
            {
                connection.Close();
            }
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                connection = null;
                Console.WriteLine($"Can not open connection: {ex}");
                return connection;
            }

        }
    }
}
