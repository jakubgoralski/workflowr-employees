namespace WorkflowR.Employees.Domain.Managing
{
    public interface IEmployeeFactory
    {
        Employee Create(Guid id, string firstName, string lastName, string email, Guid managerId);
    }
}