using WorkflowR.Employees.Domain.Managing;
using WorkflowR.Employees.Infrastructure.EF.Contexts;

namespace WorkflowR.Workflows.Infrastructure.EF.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeesWriteDbContext _employeeDbContext;

        public EmployeeRepository(
            EmployeesWriteDbContext workflowsDbContext)
        {
            _employeeDbContext = workflowsDbContext;
        }

        public void Create(Employee employee)
        {
            _employeeDbContext.Employees.Add(employee);
            _employeeDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _employeeDbContext.Employees.Update(employee);
            await _employeeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid guid)
        {
            var employee = _employeeDbContext.Employees.FirstOrDefault(x => x.Id.Equals(guid));

            if (employee is null)
                return;

            _employeeDbContext.Employees.Remove(employee);
            await _employeeDbContext.SaveChangesAsync();
        }
    }
}