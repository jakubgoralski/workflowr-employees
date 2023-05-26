using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkflowR.Employees.Domain.Managing;

namespace WorkflowR.Workflows.Infrastructure.EF.Configs
{
    internal class WriteConfiguration
        : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var fullnameConverter = new ValueConverter<Fullname, string>(
               x => x.ToString(),
               x => Fullname.Create(x));

            var emailConverter = new ValueConverter<Email, string>(
               x => x.ToString(),
               x => Email.Create(x));

            builder.Property(typeof(Fullname), "Name")
                .HasConversion(fullnameConverter)
                .HasColumnName("Name");
            builder.Property(typeof(Email), "EmailAddress")
                .HasConversion(emailConverter)
                .HasColumnName("EmailAddress");
            builder.Property(typeof(Guid), "ManagerId")
                .HasColumnName("ManagerId");

            builder.ToTable("employee");
        }
    }
}