using Microsoft.EntityFrameworkCore;
using WorkflowR.Employees.Domain.Managing;
using WorkflowR.Workflows.Infrastructure.EF.Configs;

namespace WorkflowR.Employees.Infrastructure.EF.Contexts
{
    public sealed class EmployeesWriteDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeesWriteDbContext(
            DbContextOptions<EmployeesWriteDbContext> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("employees");

            var configuration = new WriteConfiguration();
            modelBuilder.ApplyConfiguration<Employee>(configuration);
        }
    }
}