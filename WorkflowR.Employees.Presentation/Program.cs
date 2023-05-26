using WorkflowR.Employees.Domain.Managing;
using WorkflowR.Employees.Infrastructure.EF.ReadModels;
using WorkflowR.Employees.Infrastructure.EF.Repositories.Interfaces;
using WorkflowR.Employees.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPresentation();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapGet("/employee", (Guid id, IEmployeeReadRepository _repository) =>
{
    EmployeeReadModel employee = _repository.ReadAsync(id);
    return employee;
})
.WithName("ReadEmployee");

app.MapGet("/employees", (IEmployeeReadRepository _repository) =>
{
    List<EmployeeReadModel> employees = _repository.ReadAsync();
    return employees;
})
.WithName("ReadEmployees");

app.MapPost("/employee", (string firstname, string lastname, string email, Guid managerId, IEmployeeRepository _repository, IEmployeeFactory _employeeFactory) =>
{
    Employee employee = _employeeFactory.Create(Guid.NewGuid(), firstname, lastname, email, managerId);
    _repository.Create(employee);
})
.WithName("CreateEmployee");

app.MapPut("/employee", async (Guid id, string firstname, string lastname, string email, Guid managerId, IEmployeeRepository _repository, IEmployeeFactory _employeeFactory) =>
{
    Employee employee = _employeeFactory.Create(id, firstname, lastname, email, managerId);
    await _repository.UpdateAsync(employee);
})
.WithName("UpdateEmployee");

app.MapDelete("/employee", async (Guid id, IEmployeeRepository _repository) =>
{
    await _repository.DeleteAsync(id);
})
.WithName("DeleteEmployee");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.Run();
