using ExamWinform02.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWinform02.Repositories
{
    class DepartmentRepository
    {
        private SqlConnection connection;
        public List<Department> GetAllDepartments()
        {
            List<Department> result = new List<Department>();
            try
            {
                connection = Database.GetInstance().GetConnection();
                string sql = @"SELECT * FROM Department";
                SqlCommand command = new SqlCommand(sql, connection);
                //SQL injection
                //command.Parameters.AddWithValue("@DeptID", departmentID);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    Department department = new Department();
                    //student.Id = Convert.ToInt32(reader[0]);                                        
                    //return employee;
                    result.Add(department);
                }
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
