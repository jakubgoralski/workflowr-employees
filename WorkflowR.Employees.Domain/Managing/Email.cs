using WorkflowR.Employees.Domain.Abstractions;

namespace WorkflowR.Employees.Domain.Managing
{
    public record Email(string Value) : ValueObject
    {
        public static Email Create(string email)
        {
            if (!EmailAddressValidatorService.IsValidEmail(email))
                throw new ArgumentException("Email address is wrong.");

            return new Email(email);
        }

        public override string ToString()
            => $"{Value}";
    }
}
