using WorkflowR.Employees.Infrastructure.EF.ReadModels;

namespace WorkflowR.Employees.Infrastructure.EF.Repositories.Interfaces
{
    public interface IEmployeeReadRepository
    {
        List<EmployeeReadModel> ReadAsync();
        EmployeeReadModel ReadAsync(Guid guid);
    }
}