using WorkflowR.Employees.Domain.Abstractions;

namespace WorkflowR.Employees.Domain.Managing
{
    public class Employee : Entity
    {
        public Guid Id { get; set; }
        private Fullname Name { get; set; }
        private Email EmailAddress { get; set; }
        private Guid? ManagerId { get; set; }

        public Employee(Guid id, string firstName, string lastName, string email, Guid? managerId = null)
        {
            Id = id;
            Name = new Fullname(firstName, lastName);
            EmailAddress = new Email(email);
            ManagerId = managerId;
        }
    }
}