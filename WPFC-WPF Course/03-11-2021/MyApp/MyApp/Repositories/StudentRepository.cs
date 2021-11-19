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
        /*public DataSet GetStudentsDataSet()
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
                using SqlCommand command = new SqlCommand(sql, connection);
                command.CommandType = CommandType.Text;
                using SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                using DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        */
        public DataSet GetStudentDataSet()
        {
            try
            {
                SqlConnection conn = Database.getInstance().GetConnection();
                string sql = "SELECT " +
                    "	tblClass.TenLop," +
                    "	tblStudent.TenSV," +
                    "	tblStudent.UserNm," +
                    "	tblStudent.DiaChi " +
                    "FROM tblStudent " +
                                "INNER JOIN tblClass " +
                                "ON tblStudent.MaLop=tblClass.MaLop;";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
