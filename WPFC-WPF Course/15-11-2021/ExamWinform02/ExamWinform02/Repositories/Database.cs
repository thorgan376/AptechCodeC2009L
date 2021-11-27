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
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                                                 @"AttachDbFilename=C:\Users\Thai Son\Desktop\Aptech\AptechCodeC2009L\AptechCodeC2009L\WPFC-WPF Course\15-11-2021\ExamWinform02\ExamWinform02\Database.mdf;" +
                                                 @"Integrated Security=True; MultipleActiveResultSets=True;";        
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
                if (connection != null)
                {
                    connection.Close();
                }
                connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();
                SqlCommand command = new SqlCommand(@"USE master;", connection);
                command.ExecuteReader();
                command.Dispose();

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
