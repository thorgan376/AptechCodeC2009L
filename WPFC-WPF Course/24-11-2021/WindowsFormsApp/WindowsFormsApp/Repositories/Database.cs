using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    public class Database
    {
        private const string DATA_SOURCE = @"DESKTOP-KCDQ3PV\SQLEXPRESS";
        private const string Initial_Catalog ="master";
        private const string USER_ID = "sa";
        private const string PASSWORD = "Ghjkl;1234";
        private static Database instance;
        public static Database GetInstance() {
            if (instance == null) {
                instance = new Database();
                instance.GetConnection();
            }
            return instance;
        }
        private SqlConnection connection = null;
        public SqlConnection GetConnection()
        {
            string connectionString = $"Data Source={DATA_SOURCE};Initial Catalog={Initial_Catalog};User ID={USER_ID};Password='{PASSWORD}'";
            if (connection != null)
            {
                connection.Close();
            }
            connection = new SqlConnection(connectionString);
            try
            {
                return connection;
            }
            catch (SqlException e)
            {
                Console.WriteLine($"exception = {e.Message}");
                connection = null;
                return connection;
            }            
        }
        public Department GetDepartmentById(int departmentId)
        {
            Department department = null;
            try
            {
                string sql = $"SELECT * FROM Departments WHERE DeptID = {departmentId}";
                SqlCommand command = new SqlCommand(sql, GetConnection());
                connection.Open();
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        return new Department()
                        {
                            DepartmentID = Convert.ToInt32(sqlDataReader["DeptID"]),
                            DepartmentName = sqlDataReader["DeptName"].ToString()
                        };
                        
                    }
                }
                return department;
            }
            catch (Exception e)
            {
                Console.WriteLine($"exception = {e.Message}");
                return department;
            }
            finally
            {
                connection.Close();                
            }
        }
        public void DeleteEmployeeById(int employeeId)
        {            
            try
            {
                string sql = $"DELETE FROM Employees WHERE EmployeeID = '@employeeId'";
                SqlCommand command = new SqlCommand(sql, GetConnection());
                command.Parameters.AddWithValue("@employeeId", employeeId);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot delete Employee: ${employeeId}, exception = {e.Message}");                
            }
            finally
            {
                connection.Close();
            }
        }
        public void insertEmployee(Employee employee)
        {
            try
            {
                string sql = $"INSERT INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel, Address) " +
                    $"VALUES(@employeeName, @deptID, @gender, @birthDate, @telephone,@address)";
                SqlCommand command = new SqlCommand(sql, GetConnection());
                command.Parameters.AddWithValue("@employeeName", employee.EmployeeName);
                command.Parameters.AddWithValue("@deptID", employee.DepartmentID);
                command.Parameters.AddWithValue("@gender", employee.Gender);                
                command.Parameters.AddWithValue("@birthDate",employee.BirthDate);
                command.Parameters.AddWithValue("@telephone", employee.Telephone);
                command.Parameters.AddWithValue("@address", employee.Address);                
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot insert Employee, exception = {e.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Employee> GetEmployees(int departmentId) {
            List<Employee> employees = new List<Employee>();
            try
            {
                string sql = $"SELECT * FROM Employees WHERE DeptID = {departmentId}";
                SqlCommand command = new SqlCommand(sql, GetConnection());                
                connection.Open();
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {                        
                        employees.Add(new Employee()
                        {
                            EmployeeID = Convert.ToInt32(sqlDataReader["EmployeeID"]),
                            EmployeeName = sqlDataReader["EmployeeName"].ToString(),
                            DepartmentID = Convert.ToInt32(sqlDataReader["DeptID"]),
                            Gender = sqlDataReader["Gender"].ToString(),
                            BirthDate = Convert.ToDateTime(sqlDataReader["BirthDate"]),
                            Telephone = sqlDataReader["Tel"].ToString(),
                            Address = sqlDataReader["Address"].ToString(),                            
                        });
                        Console.WriteLine("Hello");
                    }
                }
                return employees;
            }
            catch (Exception e)
            {
                Console.WriteLine($"exception = {e.Message}");
                return employees;
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Department> GetAllDepartments() {
            List<Department> departments = new List<Department>();            
            try
            {
                string sql = "SELECT * FROM Departments";
                SqlCommand command = new SqlCommand(sql, GetConnection());
                connection.Open();
                using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        departments.Add(new Department()
                        {
                            DepartmentID = Convert.ToInt32(sqlDataReader["DeptID"]),
                            DepartmentName = sqlDataReader["DeptName"].ToString(),
                        });                        
                    }
                }
                return departments;
            }
            catch (Exception e)
            {
                Console.WriteLine($"exception = {e.Message}");
                return departments;
            }
            finally {
                connection.Close();
            }
        }
        

    }
}
