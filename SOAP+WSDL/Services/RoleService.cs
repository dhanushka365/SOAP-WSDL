using Microsoft.EntityFrameworkCore;
using REST_Practise.Data;
using SOAP_WSDL.Models;

namespace SOAP_WSDL.Services
{
    public class RoleService :IRoleService
    {
        private readonly ERPContext dbContext;

        public RoleService(ERPContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<RoleModel> CreateAsync(RoleModel roleModel)
        {
            dbContext.Roles.Add(roleModel);
            await dbContext.SaveChangesAsync();
            return roleModel;
        }

        public async Task<RoleModel> DeleteAsync(Guid id)
        {
            var role = await dbContext.Roles.FindAsync(id); // Find the department by ID

            if (role != null)
            {
                dbContext.Roles.Remove(role); // Mark the department for deletion
                await dbContext.SaveChangesAsync(); // Delete the department from the database
            }

            return role; // Return the deleted department or null if not found
        }

        public async Task<List<RoleModel>> GetAllAsync()
        {
            return await dbContext.Roles.ToListAsync();
        }

        public async Task<RoleModel> GetByIdAsync(Guid id)
        {
            return await dbContext.Roles.FindAsync(id);
        }

        public async Task<RoleModel> UpdateAsync(RoleModel roleModel)
        {
            dbContext.Entry(roleModel).State = EntityState.Modified; // Mark the department as modified
            await dbContext.SaveChangesAsync();
            return roleModel;
        }
   
 
    }
}
