using Microsoft.AspNetCore.Identity;
using System.Data;

namespace SOAP_WSDL.Models
{
    public class ProfileModel : IdentityUser<Guid>
    {
        public Guid RoleId { get; set; }

        public Guid EmployeeId { get; set; }

        public RoleModel RoleModel { get; set; }

        public EmployeeModel EmployeeModel { get; set; }
    }
}
