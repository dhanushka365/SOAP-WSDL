using Microsoft.EntityFrameworkCore;
using REST_Practise.Data;
using SOAP_WSDL.Models;

namespace SOAP_WSDL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ERPContext dbContext;

        public DepartmentService(ERPContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<DepartmentModel> CreateAsync(DepartmentModel departmentModel)
        {
            dbContext.Departments.Add(departmentModel);
            await dbContext.SaveChangesAsync();
            return departmentModel;
        }

        public async Task<DepartmentModel> DeleteAsync(Guid id)
        {
            var department = await dbContext.Departments.FindAsync(id); // Find the department by ID

            if (department != null)
            {
                dbContext.Departments.Remove(department); // Mark the department for deletion
                await dbContext.SaveChangesAsync(); // Delete the department from the database
            }

            return department; // Return the deleted department or null if not found
        }

        public async Task<List<DepartmentModel>> GetAllAsync()
        {
            return await dbContext.Departments.ToListAsync();
        }

        public async Task<DepartmentModel> GetByIdAsync(Guid id)
        {
            return await dbContext.Departments.FindAsync(id);
        }

        public async Task<DepartmentModel> UpdateAsync(DepartmentModel departmentModel)
        {
            dbContext.Entry(departmentModel).State = EntityState.Modified; // Mark the department as modified
            await dbContext.SaveChangesAsync();
            return departmentModel;
        }
    }
}
