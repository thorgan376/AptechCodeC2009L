using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary.Models;
namespace WcfServiceLibrary.Services
{
    [ServiceContract]
    interface IStudentService
    {
        [OperationContract]
        IEnumerable<Student> GetAll();

        [OperationContract]
        Student Get(int studentId);
    }
}
