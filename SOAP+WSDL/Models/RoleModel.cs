using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SOAP_WSDL.Models
{
    [DataContract]
    public class RoleModel : IdentityRole<Guid>
    {
        [DataMember]
        [Required]
        public override Guid Id { get; set; }
        [DataMember]
        [Required]
        public override string Name { get; set; }
    }
}
