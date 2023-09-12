using SOAP_WSDL.Models;
using System.ServiceModel;

namespace SOAP_WSDL.Services
{
    [ServiceContract]
    public interface IProfileService
    {
        [OperationContract]
        Task<List<ProfileModel>> GetAllAsync();

        [OperationContract]
        Task<ProfileModel> GetByIdAsync(Guid id);

        [OperationContract]
        Task<ProfileModel> CreateAsync(ProfileModel profiles);

        [OperationContract]
        Task<ProfileModel> UpdateAsync(ProfileModel profile);

        [OperationContract]
        Task<ProfileModel> DeleteAsync(Guid id);
    }
}
