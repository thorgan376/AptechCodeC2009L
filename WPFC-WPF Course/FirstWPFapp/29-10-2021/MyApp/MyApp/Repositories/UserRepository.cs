using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Repositories
{
    public class UserRepository
    {
        public Student Login(String username, String password)
        {
            try { 
                Database database = new Database();
                OdbcConnection connection = database.GetConnection();                
                string sql = @"SELECT * FROM tblStudent WHERE UserNm = @username AND Password=@password";
                OdbcCommand command = new OdbcCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    Student student = new Student();
                    //student.Id = 
                    //debug here
                    return student;                    
                }
                return null;
            }
            catch (Exception e) {
                return null;
                throw e;
            }
        }
    }
}
