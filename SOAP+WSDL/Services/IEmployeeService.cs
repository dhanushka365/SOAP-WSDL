using SOAP_WSDL.Models;
using System.ServiceModel;

namespace SOAP_WSDL.Services
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Task<List<EmployeeModel>> GetAllAsync();

        [OperationContract]
        Task<EmployeeModel> GetByIdAsync(Guid id);

        [OperationContract]
        Task<EmployeeModel> CreateAsync(EmployeeModel employee);

        [OperationContract]
        Task<EmployeeModel> UpdateAsync(EmployeeModel employee);

        [OperationContract]
        Task<EmployeeModel> DeleteAsync(Guid id);
    }
}
