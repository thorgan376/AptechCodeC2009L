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
        //cách làm khi có SQL Sever SSMS ở bên ngoài
        
        //private const string CONNECTIONSTRING = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Thai Son\\Desktop\\Aptech\\AptechCodeC2009L\\AptechCodeC2009L\\WPFC-WPF Course\\05-11-2021\\MyApp\\MyApp\\Database\\StudentManagement.mdf;Integrated Security=True";
        private const string CONNECTIONSTRING = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thai Son\Desktop\Aptech\AptechCodeC2009L\AptechCodeC2009L\WPFC-WPF Course\05-11-2021\MyApp\MyApp\Database\StudentManagement.mdf;Integrated Security = True";
        //"C:\Users\Thai Son\Desktop\Aptech\AptechCodeC2009L\AptechCodeC2009L\WPFC-WPF Course\05-11-2021\MyApp\MyApp\Database\StudentManagement.mdf";
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
            if (conn != null)
            {
                conn.Close();
            }
            conn = new SqlConnection(CONNECTIONSTRING);
            try
            {
                conn.Open();
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
