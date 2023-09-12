using SOAP_WSDL.Models;
using System.ServiceModel;

namespace SOAP_WSDL.Services
{
    [ServiceContract]
    public interface IAccelerationService
    {
        [OperationContract]
        string Speed(string s);
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        MachineModel TestMachine(MachineModel machine);
    }
}
