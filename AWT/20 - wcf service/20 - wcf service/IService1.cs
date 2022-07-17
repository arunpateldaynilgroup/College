using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _20___wcf_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double add(double a, double b); 
        [OperationContract]
        double sub(double a, double b); 
        [OperationContract]
        double mul(double a, double b); 
        [OperationContract]
        double div(double a, double b);
    }
}
