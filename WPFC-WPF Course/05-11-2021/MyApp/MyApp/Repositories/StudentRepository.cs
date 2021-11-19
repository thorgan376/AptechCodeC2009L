using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Repositories
{
    public class StudentRepository
    {

        public void DeleteStudentByID(int studentID)
        {

        }
        public void InsertStudent(string tenLop, string tenSV, string userNm, string diachi)
        {
            try
            {
                //using (SqlConnection openCon = new SqlConnection("your_connection_String"))
                using (SqlConnection connection = Database.getInstance().GetConnection())
                {
                    string sqlStatement = "INSERT into tblStudent (TenSV,GioiTinh,NSinh,DiaChi,MaLop,UserNm)" +
                        "VALUES (@TenSV,@GioiTinh,@NSinh,@DiaChi,@MaLop,@UserNm)";

                    using SqlCommand commandInsert = new(sqlStatement);
                    commandInsert.Connection = connection;
                    commandInsert.Parameters.Add("@TenSV", SqlDbType.VarChar, 30).Value = tenSV;
                    commandInsert.Parameters.Add("@TenLop", SqlDbType.VarChar, 30).Value = tenLop;
                    commandInsert.Parameters.Add("@UserNm", SqlDbType.VarChar, 30).Value = userNm;
                    commandInsert.Parameters.Add("@DiaChi", SqlDbType.VarChar, 30).Value = diachi;

                    commandInsert.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet GetStudentsDataSet()
        {
            try
            {

                SqlConnection connection = Database.getInstance().GetConnection();
                string sql = "SELECT " +
                                "	tblClass.TenLop," +
                                "	tblStudent.TenSV," +
                                "	tblStudent.UserNm," +
                                "	tblStudent.DiaChi " +
                                "FROM tblStudent " +
                                "INNER JOIN tblClass " +
                                "ON tblStudent.MaLop=tblClass.MaLop;";
                SqlCommand command = new(sql, connection);
                command.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new(command);
                DataSet dataSet = new();
                sqlDataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                throw ;
            }
        }

    }
}
