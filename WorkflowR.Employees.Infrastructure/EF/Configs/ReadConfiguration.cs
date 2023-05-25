using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkflowR.Employees.Infrastructure.EF.ReadModels;

namespace WorkflowR.Employees.Infrastructure.EF.Configs
{
    internal class ReadConfiguration
        : IEntityTypeConfiguration<EmployeeReadModel>
    {
        public void Configure(EntityTypeBuilder<EmployeeReadModel> builder)
        {
            builder.ToTable("employee");
        }
    }
}