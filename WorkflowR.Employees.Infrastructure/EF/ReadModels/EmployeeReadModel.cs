namespace WorkflowR.Employees.Infrastructure.EF.ReadModels
{
    public class EmployeeReadModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Guid? ManagerId { get; set; }
    }
}
