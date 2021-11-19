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
                /*SqlConnection connection = Database.getInstance().GetConnection();                      
                string sql = @"SELECT * FROM tblStudent WHERE UserNm = @username AND Password=@password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = command.ExecuteReader();
               */
                SqlConnection conn = Database.getInstance().GetConnection();
                string sql = @"SELECT * FROM tblStudent WHERE UserNm = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}",reader[0]));
                    //Console.WriteLine(String.Format("{0}", reader[0]));
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader[0]);
                    student.Name = Convert.ToString(reader[1]);
                    student.Gender = Convert.ToString(reader[2]);
                    student.DateOfBirth = Convert.ToDateTime(reader[3]);
                    student.Address = Convert.ToString(reader[4]);  
                    student.UserName = Convert.ToString(reader[5]);
                    student.Password = Convert.ToString(reader[6]);
                    return student;
                    /*Student student = new Student();                    
                    student.Id = Convert.ToInt32(reader[0]);
                    student.Name = Convert.ToString(reader[1]);
                    student.Gender = Convert.ToString(reader[2]);
                    student.DateOfBirth = Convert.ToDateTime(reader[3]);
                    student.Address = Convert.ToString(reader[4]);
                    student.UserName = Convert.ToString(reader[6]);                    
                    //debug here
                    return student;*/                    
                }
                return null;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw;                                
            }
        }
    }
}
