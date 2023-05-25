using WorkflowR.Employees.Domain.Abstractions;

namespace WorkflowR.Employees.Domain.Managing
{
    public class Fullname : ValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Fullname(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Firstname and lastname cannot be empty");

            FirstName = firstName;
            LastName = lastName;
        }
    }
}
