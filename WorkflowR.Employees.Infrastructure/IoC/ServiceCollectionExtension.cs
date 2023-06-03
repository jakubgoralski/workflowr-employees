using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorkflowR.Employees.Infrastructure.EF.Contexts;
using WorkflowR.Employees.Infrastructure.Options;
using WorkflowR.Employees.Infrastructure.EF.Repositories.Interfaces;
using WorkflowR.Workflows.Infrastructure.EF.Repositories;
using WorkflowR.Employees.Infrastructure.EF.Repositories;
using Microsoft.EntityFrameworkCore;

namespace WorkflowR.Employees.Infrastructure.IoC
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionStringOption = configuration.GetSection(nameof(ConnectionStringOption)).Value;
            services.AddDbContext<EmployeeReadDbContext>(x =>
            {
                x.UseSqlServer(connectionStringOption);
            });
            services.AddDbContext<EmployeesWriteDbContext>(x =>
            {
                x.UseSqlServer(connectionStringOption);
            });
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();

            return services;
        }
    }
}