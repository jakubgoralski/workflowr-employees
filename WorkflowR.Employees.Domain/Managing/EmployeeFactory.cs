namespace WorkflowR.Employees.Domain.Managing
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee Create(Guid id, string firstName, string lastName, string email, Guid managerId)
        {
            Fullname name = new Fullname(firstName, lastName);
            Email emailAddress = new Email(email);

            return new Employee(id, name, emailAddress, managerId);
        }
    }
}
