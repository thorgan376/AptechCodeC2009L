using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWinform02.Repositories
{
    public class Database
    {
        //private const string SERVER_NAME = "DESKTOP-7PS7HG8";        
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunli\Documents\code\Aptech\C2009L\WFPC#\12-11-2021\ExamWinform02\ExamWinform02\Database.mdf;MultipleActiveResultSets=true;Integrated Security=True";        
        private SqlConnection connection = null;
        //singleton object
        private static Database instance;

        private Database()
        {
        }
        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        public SqlConnection GetConnection()
        {                        
            try
            {
                connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();
                SqlCommand command = new SqlCommand("USE employeeManagement;", connection);
                command.ExecuteReader();
                command.Dispose();

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
