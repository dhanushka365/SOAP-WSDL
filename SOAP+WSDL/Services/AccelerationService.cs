using SOAP_WSDL.Models;
using System.Xml.Linq;

namespace SOAP_WSDL.Services
{
    public class AccelerationService : IAccelerationService
    {
        public string Speed(string s)
        {
            Console.WriteLine(s + " MPH");
            return s;
        }
        public MachineModel TestMachine(MachineModel machine)
        {
            return machine;
        }
        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
    }
}
