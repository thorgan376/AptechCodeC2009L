using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MyApp.Models;

//docker pull mcr.microsoft.com/mssql/server
//docker run -d --name SQL-Server-2019-C2009L -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Ghjkl;1234" -p 1435:1433 mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04
namespace MyApp.Repositories
{
    public class UserRepository
    {
        public Student Login(String username, String password)
        {
            try
            {
                OdbcConnection connection = Database.getInstance().GetConnection();
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
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}