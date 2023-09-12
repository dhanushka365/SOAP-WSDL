using Microsoft.EntityFrameworkCore;
using REST_Practise.Data;
using SOAP_WSDL.Models;

namespace SOAP_WSDL.Services
{
    public class ProfileService :IProfileService
    {
        private readonly ERPContext dbContext;
        
        public ProfileService(ERPContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ProfileModel> CreateAsync(ProfileModel profileModel)
        {
            dbContext.Profiles.Add(profileModel);
            await dbContext.SaveChangesAsync();
            return profileModel;
        }

        public async Task<ProfileModel> DeleteAsync(Guid id)
        {
            var profile = await dbContext.Profiles.FindAsync(id); // Find the department by ID

            if (profile != null)
            {
                dbContext.Profiles.Remove(profile); // Mark the department for deletion
                await dbContext.SaveChangesAsync(); // Delete the department from the database
            }

            return profile; // Return the deleted department or null if not found
        }

        public async Task<List<ProfileModel>> GetAllAsync()
        {
            return await dbContext.Profiles.ToListAsync();
        }

        public async Task<ProfileModel> GetByIdAsync(Guid id)
        {
            return await dbContext.Profiles.FindAsync(id);
        }

        public async Task<ProfileModel> UpdateAsync(ProfileModel profileModel)
        {
            dbContext.Entry(profileModel).State = EntityState.Modified; // Mark the department as modified
            await dbContext.SaveChangesAsync();
            return profileModel;
        }
    
    }
}
