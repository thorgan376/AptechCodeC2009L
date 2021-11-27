using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Database
{
    public class DatabaseConn
    {
        /*Cách tạo Database cho ứng dụng:
        B1: Trong thư mục này (Database), add New Item "Service-based Database"
        B2: Mở Sever Explorer trong mục View và add thêm Data Connection
        B3: Trong dòng Data Source, đổi Microsoft SQL Sever thành Microsoft SQL Sever Database File
        B4: Trong dòng Database File Name (new or existing), tìm đến và chọn file .mdf vừa tạo trong thư mục này
        B5: Cuối cùng, thêm new query và chạy phần CODE SQL có sẵn,
        And Run this app -You are done ~ NICE- và nếu có lỗi thêm thì thêm vào Connection String  "MultipleActiveResultSet=True"*/

        private const string CONNECTIONSTRING = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=C:\Users\Thai Son\Desktop\Aptech\AptechCodeC2009L\AptechCodeC2009L\WPFC-WPF Course\05-11-2021\MyApp\MyApp\Database\Database.mdf;"+
            @"Integrated Security=True;Connect Timeout= 30; MultipleActiveResultSets=True;";
        private SqlConnection conn = null;
        //singleton object
        private static DatabaseConn instance;

        private DatabaseConn()
        {
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
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = new SqlConnection(CONNECTIONSTRING);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from tblClass;", conn);
                cmd.ExecuteReader();
                cmd.Dispose();
                return conn;
            }
            catch (Exception ex)
            {
                conn = null;
                Console.WriteLine($"Can not open connection: {ex}");
                return conn;
            }

        }
    }
}
