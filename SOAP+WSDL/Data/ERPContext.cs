using Microsoft.EntityFrameworkCore;
using SOAP_WSDL.Models;
using System.Data;


namespace REST_Practise.Data
{
    public class ERPContext : DbContext
    {
        public ERPContext(DbContextOptions <ERPContext> options) : base(options)
        {

        }

        

        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<RoleModel> Roles { get; set; }

        public DbSet<SalaryModel> Salarys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var roles = new List<RoleModel>()
            {
                new RoleModel
                {
                    Id = Guid.NewGuid(),
                    Name= "admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp= ""

                },
                new RoleModel
                {
                    Id = Guid.NewGuid(),
                    Name= "user",
                    NormalizedName = "USER",
                    ConcurrencyStamp= ""
                },
            };
            //Seed difficulties to the database
            modelBuilder.Entity<RoleModel>().HasData(roles);


            // Seed data for Regions
            var departments = new List<DepartmentModel>
            {
                new DepartmentModel
                {
                    Id = Guid.NewGuid(),
                    DepartmentName = "Engineering"
                   
                },
                new DepartmentModel
                {
                    Id = Guid.NewGuid(),
                    DepartmentName = "Quality Assuarance"

                },
                new DepartmentModel
                {
                    Id = Guid.NewGuid(),
                    DepartmentName = "Human Resource"

                },
                new DepartmentModel  
                {
                    Id = Guid.NewGuid(),
                    DepartmentName = "Support"

                },
                new DepartmentModel
                {
                    Id = Guid.NewGuid(),
                    DepartmentName = "Managed Services"

                },
            };
            modelBuilder.Entity<DepartmentModel>().HasData(departments);
        }
        }
}
