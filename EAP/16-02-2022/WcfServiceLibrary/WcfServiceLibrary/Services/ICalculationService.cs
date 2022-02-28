using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary.Services
{
    [ServiceContract]
    interface ICalculationService
    {
        [OperationContract]
        int Add(int x, int y);
        [OperationContract]
        int Sub(int x, int y);
        [OperationContract]
        int Multiply(int x, int y);
        [OperationContract]
        int Divide(int x, int y);
    }
}
