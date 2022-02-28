using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary.Models;

namespace WcfServiceLibrary.Services
{
    public class StudentService : IStudentService
    {
        private IEnumerable<Student> students = new List<Student>() { 
            new Student(){ 
                Id = 1,
                Name = "nguyen van a",
                DOB = new DateTime(1997, 12, 30)
            },
            new Student(){
                Id = 2,
                Name = "nguyen van b",
                DOB = new DateTime(1998, 08, 15)
            },
            new Student(){
                Id = 2,
                Name = "nguyen van b",
                DOB = new DateTime(1998, 08, 15)
            },
        };
        public Student Get(int studentId) 
            => students.Where(student => student.Id == studentId).FirstOrDefault();

        public IEnumerable<Student> GetAll()
        {
            return students;
        }
    }
}
