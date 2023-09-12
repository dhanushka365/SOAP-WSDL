using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SOAP_WSDL.Models
{
    [DataContract]
    public class DepartmentModel
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string? DepartmentName { get; set; }
    }
}
