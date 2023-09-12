using System.Runtime.Serialization;

namespace SOAP_WSDL.Models
{
    [DataContract]
    public class MachineModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string? MachineName { get; set; }
        [DataMember]
        public string? HorsePower { get; set; }
    }
}
