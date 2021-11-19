using ExamWinform02.Models;
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
        private SqlConnection connection;
        public List<Employee> GetEmployees()        
        {
            try
            {
                connection = Database.GetInstance().GetConnection();
                string sql = @"SELECT * FROM Employees";                
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                    Employee employee = new Employee();
                    //student.Id = Convert.ToInt32(reader[0]);                                        
                    //return employee;
                }
                return null;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Insert(Employee employee)
        {
            try
            {
                connection = Database.GetInstance().GetConnection();
                string sql = @"INSERT INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel)" +
                    @"VALUES(@EmployeeName, @DeptID, @Gender, @BirthDate, @Tel)";
                //"Insert into xx values("+ employee.EmployeeName+")"+ => ko can dung SQLCommand
                //SQL Injection
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                command.Parameters.AddWithValue("@DeptID", employee.DeptID);
                command.Parameters.AddWithValue("@Gender", employee.Gender);
                command.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                command.Parameters.AddWithValue("@Tel", employee.Tel);
                command.ExecuteNonQuery();                
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
