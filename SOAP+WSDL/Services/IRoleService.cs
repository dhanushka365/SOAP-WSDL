using SOAP_WSDL.Models;
using System.Data;
using System.ServiceModel;

namespace SOAP_WSDL.Services
{
    [ServiceContract]
    public interface IRoleService
    {
        [OperationContract]
        Task<List<RoleModel>> GetAllAsync();

        [OperationContract]
        Task<RoleModel> GetByIdAsync(Guid id);

        [OperationContract]
        Task<RoleModel> CreateAsync(RoleModel roles);

        [OperationContract]
        Task<RoleModel> UpdateAsync(RoleModel roles);

        [OperationContract]
        Task<RoleModel> DeleteAsync(Guid id);
    }
}
