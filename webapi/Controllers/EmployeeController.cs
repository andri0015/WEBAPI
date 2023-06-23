using Microsoft.AspNetCore.Mvc;
using webapi.Services;
using webapi.Models;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController:  ControllerBase
{
    IEmployeeService employeeService;

    public EmployeeController(IEmployeeService employee)
    {
        employeeService = employee;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(employeeService.Get());
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] tblEmployee employee)
    {
        employeeService.Save(employee);
        return Ok();
    }


    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] tblEmployee employee)
    {
        
        try
        {
            employeeService.Update(id, employee);
            return Ok();

        }
        catch  (Exception ex)
        {
            Console.WriteLine(ex);

            throw new Exception("Solo se permite actualizar los campos: ");
        }

    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        employeeService.Delete(id);
        return Ok();
    }  
}