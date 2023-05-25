namespace WorkflowR.Employees.Domain.Managing
{
    public interface IEmployeeRepository
    {
        void Create(Employee employee);
        Employee Read(Guid id);
        string GetEmailOf(Guid id);
        void Update(Employee employee);
        void Delete(Guid id);
    }
}
