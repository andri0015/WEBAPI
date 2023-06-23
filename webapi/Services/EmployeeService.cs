using Microsoft.EntityFrameworkCore;
using webapi.Models;
namespace webapi.Services;

public class EmployeeService : IEmployeeService
{
    EmployeesContext context;


    public EmployeeService(EmployeesContext dbcontext)
    {
        context = dbcontext;
    }
    public IEnumerable<tblEmployee> Get()
    {
        return context.Employees;
    }
    public async Task Save(tblEmployee Employee)
    {
        Employee.id = Guid.NewGuid();
        Employee.CreationDate = DateTime.Now;
        context.Add(Employee);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, tblEmployee Employee)
    {
        try{
            var employeeUpdate = context.Employees.Find(id);

            if(employeeUpdate != null)
            {
                employeeUpdate.address = Employee.address;
                employeeUpdate.phone = Employee.address;
                employeeUpdate.age = Employee.age;
                
                await context.SaveChangesAsync();
            }
        }
        catch  (Exception ex)
        {
            Console.WriteLine(ex);

            throw new Exception("Solo se permite actualizar los campos: ");
        }

    }

    public async Task Delete(Guid id)
    {
        var employeeDelete = context.Employees.Find(id);

        if(employeeDelete != null)
        {
            context.Remove(employeeDelete);
            await context.SaveChangesAsync();
        }
    }
}
public interface IEmployeeService
{
    IEnumerable<tblEmployee> Get();
    Task Save(tblEmployee Employee);

    Task Update(Guid id, tblEmployee Employee);

    Task Delete(Guid id);
}