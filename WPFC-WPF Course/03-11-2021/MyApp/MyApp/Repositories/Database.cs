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
        //private const string SERVER_NAME = "localhost";
        //bây h mình sẽ dùng SQL Sever MSSQL => tìm đến phần Sever Name trong Properties
        private const string SERVER_NAME = "DESKTOP-KCDQ3PV\\SQLEXPRESS";
        private const string PORT = "1433";
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
            //Nếu như mật khẩu của Database connection string có dấu ; hoặc kí tự đặc biệt thì phải có dấu ''  VD: 'Ghjkl;1234' 
            //lấy connection string bằng cách => chọn view->Sever Explorer->Connect To Database->Property-> Connection String
            /*string connectionString = $"Data Source={SERVER_NAME},{PORT};Initial Catalog={DB_NAME};" +
                $"Persist Security Info=True;User ID={USERNAME};Password='{PASSWORD}'"; */ // This is for Docker, Azure Data Studio
            string connectionString = $"Server = {SERVER_NAME}; Trusted_Connection=True; Database = {DB_NAME}; User Id = {USERNAME}; Password = '{PASSWORD}';";
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
