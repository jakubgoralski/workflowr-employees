using WorkflowR.Employees.Domain.Managing;

namespace WorkflowR.Employees.Infrastructure.IoC
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddSingleton<IEmployeeFactory, EmployeeFactory>();

            return services;
        }
    }
}