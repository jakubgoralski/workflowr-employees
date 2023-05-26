namespace WorkflowR.Employees.Domain.Managing
{
    public interface IEmployeeRepository
    {
        void Create(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(Guid id);
    }
}
