using SOAP_WSDL.Models;
using System.ServiceModel;

namespace SOAP_WSDL.Services
{
    [ServiceContract]
    public interface IDepartmentService
    {
        [OperationContract]
        Task<List<DepartmentModel>> GetAllAsync();

        [OperationContract]
        Task<DepartmentModel> GetByIdAsync(Guid id);

        [OperationContract]
        Task<DepartmentModel> UpdateAsync(DepartmentModel departmentModel);

        [OperationContract]
        Task<DepartmentModel> CreateAsync(DepartmentModel departmentModel);

        [OperationContract]
        Task<DepartmentModel> DeleteAsync(Guid id);
    }
}
