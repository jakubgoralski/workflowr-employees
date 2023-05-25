using WorkflowR.Employees.Domain.Abstractions;

namespace WorkflowR.Employees.Domain.Managing
{
    public class Email : ValueObject
    {
        private readonly string _email;
        public string Value { get { return _email; } }

        public Email(string email)
        {
            if (!EmailAddressValidatorService.IsValidEmail(email))
                throw new ArgumentException("Email address is wrong.");

            _email = email;
        }
    }
}
