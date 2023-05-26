using WorkflowR.Employees.Domain.Abstractions;

namespace WorkflowR.Employees.Domain.Managing
{
    public class Employee : Entity
    {
        public Guid Id { get; set; }
        private Fullname Name { get; set; }
        private Email EmailAddress { get; set; }
        private Guid ManagerId { get; set; }

        public Employee(Guid id, Fullname name, Email emailAddress, Guid managerId)
        {
            Id = id;
            Name = name;
            EmailAddress = emailAddress;
            ManagerId = managerId;
        }
    }
}