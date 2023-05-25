using WorkflowR.Employees.Infrastructure.EF.Contexts;
using WorkflowR.Employees.Infrastructure.EF.ReadModels;
using WorkflowR.Employees.Infrastructure.EF.Repositories.Interfaces;

namespace WorkflowR.Employees.Infrastructure.EF.Repositories
{
    public class EmployeeReadRepository : IEmployeeReadRepository
    {
        private readonly EmployeeReadDbContext _employeeReadDbContext;

        public EmployeeReadRepository(
            EmployeeReadDbContext employeeReadDbContext)
        {
            _employeeReadDbContext = employeeReadDbContext;
        }

        public List<EmployeeReadModel> ReadAsync()
        {
            return _employeeReadDbContext.Employees.ToList();
        }

        public EmployeeReadModel ReadAsync(Guid guid)
        {
            return _employeeReadDbContext.Employees.First(x => x.Id.Equals(guid));
        }
    }
}