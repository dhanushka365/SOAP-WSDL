using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SOAP_WSDL.Models
{
    [DataContract]
    public class EmployeeModel
    {
        [DataMember]
        [Required]
        public Guid Id { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        [DataType(DataType.Date)]
        public DateTime BOD { get; set; }
        [DataMember]
        [Required]
        public string Address { get; set; }
        [DataMember]
        [Required]
        public string Position { get; set; }
        [DataMember]
        public string ProfileImage { get; set; }
        [DataMember]
        [Required]
        public Guid DepartmentId { get; set; }

        public DepartmentModel DepartmentModel { get; set; }
    }
}
