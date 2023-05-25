using Microsoft.EntityFrameworkCore;
using WorkflowR.Employees.Infrastructure.EF.Configs;
using WorkflowR.Employees.Infrastructure.EF.ReadModels;

namespace WorkflowR.Employees.Infrastructure.EF.Contexts
{
    public sealed class EmployeeReadDbContext : DbContext
    {
        public DbSet<EmployeeReadModel> Employees { get; set; }

        public EmployeeReadDbContext(DbContextOptions<EmployeeReadDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("employees");

            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<EmployeeReadModel>(configuration);
        }
    }
}