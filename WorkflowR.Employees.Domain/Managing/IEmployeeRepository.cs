namespace WorkflowR.Employees.Domain.Managing
{
    public interface IEmployeeRepository
    {
        Task CreateAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(Guid id);
    }
}
