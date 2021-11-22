using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Repositories
{
    public class DatabaseConn
    {
        //cách làm khi có SQL Sever SSMS ở bên ngoài
        private const string SERVER_NAME = "LAPTOP-O9O0F0II";
        //dòng dưới của PC, dòng trên của Laptop
        //private const string SERVER_NAME = "DESKTOP-KCDQ3PV\\SQLEXPRESS";
        private const string PORT = "1433";
        private const string USERNAME = "sa";
        private const string PASSWORD = "Ghjkl;1234";
        private const string DB_NAME = "master";
        private SqlConnection connection = null;
        //singleton object
        private static DatabaseConn instance;

        private DatabaseConn() {           
        }
        public static DatabaseConn getInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConn();
            }
            return instance;
        }
        
        public SqlConnection GetConnection()
        {
        // connection string Máy PC: 
        string connectionString = $"Server = {SERVER_NAME}; Trusted_Connection=True;" +
                $" Database = {DB_NAME}; User Id = {USERNAME}; Password = '{PASSWORD}';";
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
