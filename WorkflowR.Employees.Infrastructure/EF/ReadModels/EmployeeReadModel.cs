namespace WorkflowR.Employees.Infrastructure.EF.ReadModels
{
    public class EmployeeReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public Guid? ManagerId { get; set; }
    }
}
