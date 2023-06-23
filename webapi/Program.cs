using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi;
using webapi.Models;
using webapi.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddDbContext<EmployeesContext>(p => p.UseInMemoryDatabase("DBEmpleyees"));
builder.Services.AddSqlServer<EmployeesContext>(builder.Configuration.GetConnectionString("cnEmployees"));
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IProfessionService, ProfessionService>();
builder.Services.AddScoped<IAreaService, AreaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGet("/dbconexion", async ([FromServices] EmployeesContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base dedatos en memoria: " + dbContext.Database.IsInMemory());
});


// // app.MapGet("api/employee/{identification}", async ([FromServices] EmployeesContext dbContext, string identification) => {
// //     var data = dbContext.Employees.Include(p=> p.profession).Where(p => (string)p.identification == identification);
// //     return Results.Ok(data);
// // });

// app.MapGet("api/employee/", async ([FromServices] EmployeesContext dbContext) => 
// {
//     // var message ="";
//     // try
//     // {
//         var data = dbContext.Employees.Include(p=> p.profession);
        
//         // message = data;
//     // }
//     // catch(Exception)
//     // {
//     //     var message = "Se presentaron fallas al consultar los registros";
//     //     return Results.NotFound();
//     // }
//     // return Results.Ok(0);
// });

// app.MapPost("api/employee", async ([FromServices] EmployeesContext dbContext, [FromBody] tblEmployee employee) =>
// {
//     employee.id = Guid.NewGuid();
//     employee.CreationDate = DateTime.Now;
//     // await dbContext.AddAsync(employee);
//     await dbContext.Employees.AddAsync(employee);

//     await dbContext.SaveChangesAsync();

//     return Results.Ok();
// });

// app.MapPut("api/employees/{id}", async ([FromServices] EmployeesContext dbContext, [FromBody] tblEmployee employee, [FromRoute] Guid id) =>
// {
//     var employeeUpdate = dbContext.Employees.Find(id);

//     if (employeeUpdate!=null)
//     {
//         employeeUpdate.address = employee.address;
//         employeeUpdate.phone = employee.phone;

//         await dbContext.SaveChangesAsync();

//         return Results.Ok();
//     }


//     return Results.NotFound();
// });

// app.MapDelete("api/employee/{id}", async ([FromServices] EmployeesContext dbContext, [FromRoute] Guid id) =>
// {
//     var employeeUpdate = dbContext.Employees.Find(id);

//     if (employeeUpdate!=null)
//     {
//         dbContext.Remove(employeeUpdate);
//         await dbContext.SaveChangesAsync();
//         return Results.Ok();
//     }

//     return Results.NotFound();
// });

app.Run();
