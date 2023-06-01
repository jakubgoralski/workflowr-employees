using employees;
using Grpc.Core;
using WorkflowR.Employees.Infrastructure.EF.ReadModels;
using WorkflowR.Employees.Infrastructure.EF.Repositories.Interfaces;

namespace WorkflowR.Employees.Presentation.Services
{
    public class EmployeesService : EmployeesGrpcService.EmployeesGrpcServiceBase
    {
        private readonly IEmployeeReadRepository _employeeReadRepository;

        public EmployeesService(IEmployeeReadRepository employeeReadRepository)
        {
            _employeeReadRepository = employeeReadRepository;
        }

        public override Task<GetEmailReply> GetEmail(GetEmailRequest request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
            EmployeeReadModel employee = _employeeReadRepository.ReadAsync(id);

            return Task.FromResult(new GetEmailReply
            {
                Email = employee.EmailAddress
            });
        }

        public override Task<GetEmailReply> GetManagersEmail(GetEmailRequest request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
            EmployeeReadModel employee = _employeeReadRepository.ReadAsync(id);
            EmployeeReadModel manager = _employeeReadRepository.ReadAsync(employee.ManagerId);

            return Task.FromResult(new GetEmailReply
            {
                Email = manager.EmailAddress
            });
        }
    }
}
