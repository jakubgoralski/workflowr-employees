using System.Diagnostics.Metrics;
using WorkflowR.Employees.Domain.Abstractions;

namespace WorkflowR.Employees.Domain.Managing
{
    public record Fullname(string FirstName, string LastName) : ValueObject
    {
        public static Fullname Create(string fullname)
        {
            var splitFullName = fullname.Split(' ');

            if (String.IsNullOrWhiteSpace(splitFullName.First()) || String.IsNullOrWhiteSpace(splitFullName.Last()))
                throw new ArgumentException("Firstname and lastname cannot be empty");

            return new Fullname(splitFullName.First(), splitFullName.Last());
        }

        public override string ToString()
            => $"{FirstName} {LastName}";
    }
}
