using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SOAP_WSDL.Models
{
    [DataContract]
    public class SalaryModel
    {
        [DataMember]
        [Required]
        public Guid Id { get; set; }
        [DataMember]
        [Required]
        public double BasicSalary { get; set; }
        [DataMember]
        [Required]
        public double Bonus { get; set; }
        [DataMember]
        [Required]
        public Guid EmployeeId { get; set; }

        public EmployeeModel EmployeeModel { get; set; }
    }
}
