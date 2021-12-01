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
        //cách làm khi có SQL Sever SSMS ở bên ngoài
        //test cho hoạt động bằng cách dùng SQL Sever 201X, đăng nhập bằng SQL Authentication
        //Bật enable Both Window Authentication và SQL Sever Authentication trong Sever Property
        //Tên SEVER Và các phần khác có thể thay đổi tùy theo tên sever và database sử dụng.
        //Lưu ý, nên add thêm data Connection trong phần View => Sever Explorer 
        //tên sever các thứ đã có ở dưới
        private const string SERVER_NAME = @"DESKTOP-KCDQ3PV\SQLEXPRESS";
        private const string USERNAME = "sa";
        private const string PASSWORD = "Ghjkl;1234";
        private const string DB_NAME = "master";
        private SqlConnection connection = null;

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
        string connectionString = $"Data Source = {SERVER_NAME}; Trusted_Connection=True;" +
                $"Initial Catalog = {DB_NAME}; User ID = {USERNAME}; Password = '{PASSWORD}';";
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
