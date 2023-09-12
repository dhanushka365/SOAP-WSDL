using Microsoft.EntityFrameworkCore;
using REST_Practise.Data;
using SOAP_WSDL.Models;

namespace SOAP_WSDL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ERPContext dbContext;

        public EmployeeService(ERPContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<EmployeeModel> CreateAsync(EmployeeModel employeeModel)
        {
            dbContext.Employees.Add(employeeModel);
            await dbContext.SaveChangesAsync();
            return employeeModel;
        }

        public async Task<EmployeeModel> DeleteAsync(Guid id)
        {
            var employee = await dbContext.Employees.FindAsync(id); // Find the department by ID

            if (employee != null)
            {
                dbContext.Employees.Remove(employee); // Mark the department for deletion
                await dbContext.SaveChangesAsync(); // Delete the department from the database
            }

            return employee; // Return the deleted department or null if not found
        }

        public async Task<List<EmployeeModel>> GetAllAsync()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<EmployeeModel> GetByIdAsync(Guid id)
        {
            return await dbContext.Employees.FindAsync(id);
        }

        public async Task<EmployeeModel> UpdateAsync(EmployeeModel employeeModel)
        {
            dbContext.Entry(employeeModel).State = EntityState.Modified; // Mark the department as modified
            await dbContext.SaveChangesAsync();
            return employeeModel;
        }
    }
}
