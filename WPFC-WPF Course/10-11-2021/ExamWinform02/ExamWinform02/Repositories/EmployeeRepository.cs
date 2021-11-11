using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWinform02.Repositories
{
    class EmployeeRepository
    {
        public void Insert(Employee employee)
        {
            try
            {
                SqlConnection connection = Database.getInstance().GetConnection();
                string sql = @"SELECT * FROM tblStudent WHERE UserNm = @username AND Password=@password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
