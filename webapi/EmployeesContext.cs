using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi;

public class EmployeesContext: DbContext
{
    public DbSet<tblProfession> Professions {get;set;}
    public DbSet<tblArea> Areas {get;set;}
    public DbSet<tblCostCenter> CostCenters {get;set;}
    public DbSet<tblEmployee> Employees {get;set;}

    public EmployeesContext(DbContextOptions<EmployeesContext> options) :base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<tblProfession> prefessionInit = new List<tblProfession>();
        prefessionInit.Add(new tblProfession() {id = Guid.Parse("d241691c-112e-11ee-be56-0242ac120002"), name = "Desarrollador", code = "Aut1234", status = true, CreationDate = DateTime.Now});
        prefessionInit.Add(new tblProfession() {id = Guid.Parse("d241691c-112e-11ee-be56-0242ac120003"), name = "Coordinador", code = "Aut1235", status = true, CreationDate = DateTime.Now});
        prefessionInit.Add(new tblProfession() {id = Guid.Parse("d241691c-112e-11ee-be56-0242ac120004"), name = "Analista", code = "Aut1234", status = true, CreationDate = DateTime.Now});
        prefessionInit.Add(new tblProfession() {id = Guid.Parse("d241691c-112e-11ee-be56-0242ac120005"), name = "Ingeniero", code = "Aut1233", status = true, CreationDate = DateTime.Now});
        prefessionInit.Add(new tblProfession() {id = Guid.Parse("d241691c-112e-11ee-be56-0242ac120006"), name = "Gerente", code = "Aut1233", status = true, CreationDate = DateTime.Now});


        modelBuilder.Entity<tblProfession>(profession=>{
            profession.ToTable("Prefesion");
            profession.HasKey(p=> p.id);
            profession.Property(p=> p.name).IsRequired().HasMaxLength(150);
            profession.Property(p=> p.code).IsRequired().HasMaxLength(20);
            profession.Property(p=> p.status).IsRequired();
            profession.Property(p=> p.CreationDate).IsRequired();
            profession.HasData(prefessionInit);

        });

        List<tblCostCenter> costcenterInit = new List<tblCostCenter>();
        costcenterInit.Add(new tblCostCenter() {id = Guid.Parse("d141691c-112e-11ee-be56-0242ac120002"), name = "Gerencia TI", code = "Cc1234", status = true, CreationDate = DateTime.Now});
        costcenterInit.Add(new tblCostCenter() {id = Guid.Parse("d141691c-112e-11ee-be56-0242ac120003"), name = "Gerencia Financier", code = "Cc1235", status = true, CreationDate = DateTime.Now});
        costcenterInit.Add(new tblCostCenter() {id = Guid.Parse("d141691c-112e-11ee-be56-0242ac120004"), name = "Gerencia Logistica", code = "Cc1234", status = true, CreationDate = DateTime.Now});


        modelBuilder.Entity<tblCostCenter>(costcenter=>{
            costcenter.ToTable("CentrCostos");
            costcenter.HasKey(p=> p.id);
            costcenter.Property(p=> p.name).IsRequired().HasMaxLength(150);
            costcenter.Property(p=> p.code).IsRequired().HasMaxLength(20);
            costcenter.Property(p=> p.status).IsRequired();
            costcenter.Property(p=> p.CreationDate).IsRequired();
            costcenter.HasData(costcenterInit);


        });
        List<tblArea> areaInit = new List<tblArea>();
        areaInit.Add(new tblArea() {id = Guid.Parse("d341691c-112e-11ee-be56-0242ac120002"), name = "Tecnología", code = "Aut1234", costcenterId = Guid.Parse("d141691c-112e-11ee-be56-0242ac120002"), status = true, CreationDate = DateTime.Now});
        areaInit.Add(new tblArea() {id = Guid.Parse("d341691c-112e-11ee-be56-0242ac120004"), name = "Nomina", code = "Aut1234", costcenterId = Guid.Parse("d141691c-112e-11ee-be56-0242ac120003"), status = true, CreationDate = DateTime.Now});
        areaInit.Add(new tblArea() {id = Guid.Parse("d341691c-112e-11ee-be56-0242ac120005"), name = "Logistica", code = "Aut1233", costcenterId = Guid.Parse("d141691c-112e-11ee-be56-0242ac120004"), status = true, CreationDate = DateTime.Now});

        modelBuilder.Entity<tblArea>(area=>{
            area.ToTable("Area");
            area.HasKey(p=> p.id);
            area.Property(p=> p.name).IsRequired().HasMaxLength(150);
            area.Property(p=> p.code).IsRequired().HasMaxLength(20);
            area.Property(p=> p.status).IsRequired();
            area.HasOne(p=> p.costcenter).WithMany(p=> p.area).HasForeignKey(p=> p.costcenterId);
            area.Property(p=> p.CreationDate).IsRequired();
            area.HasData(areaInit);


        });

        List<tblEmployee> employeeInit = new List<tblEmployee>();
        employeeInit.Add(new tblEmployee() {id = Guid.Parse("d441691c-112e-11ee-be56-0242ac120002"), name = "pepito Perez", identification = "12365487", age = 29, phone = "3016590141", address = "Carrera 54# 34-25", user = "user1", areaId = Guid.Parse("d341691c-112e-11ee-be56-0242ac120002"), professionId = Guid.Parse("d241691c-112e-11ee-be56-0242ac120002"), CreationDate = DateTime.Now});
        employeeInit.Add(new tblEmployee() {id = Guid.Parse("d441691c-112e-11ee-be56-0242ac120003"), name = "Monica Tamayo", identification = "32554544", age = 30, phone = "3016590141", address = "Carrera 54# 34-25", user = "user2", areaId = Guid.Parse("d341691c-112e-11ee-be56-0242ac120004"), professionId = Guid.Parse("d241691c-112e-11ee-be56-0242ac120004"), CreationDate = DateTime.Now});
        employeeInit.Add(new tblEmployee() {id = Guid.Parse("d441691c-112e-11ee-be56-0242ac120004"), name = "Carlos Perez", identification = "32774544", age = 25, phone = "3016590141", address = "Carrera 54# 34-25", user = "user3", areaId = Guid.Parse("d341691c-112e-11ee-be56-0242ac120005"), professionId = Guid.Parse("d241691c-112e-11ee-be56-0242ac120004"), CreationDate = DateTime.Now});
        employeeInit.Add(new tblEmployee() {id = Guid.Parse("d441691c-112e-11ee-be56-0242ac120005"), name = "Mario Castro", identification = "125554544", age = 40, phone = "3016590141", address = "Carrera 54# 34-25", user = "user4", areaId = Guid.Parse("d341691c-112e-11ee-be56-0242ac120004"), professionId = Guid.Parse("d241691c-112e-11ee-be56-0242ac120004"), CreationDate = DateTime.Now});
        employeeInit.Add(new tblEmployee() {id = Guid.Parse("d441691c-112e-11ee-be56-0242ac120006"), name = "Jose Peña", identification = "1254895444", age = 20, phone = "3016590141", address = "Carrera 54# 34-25", user = "user5", areaId = Guid.Parse("d341691c-112e-11ee-be56-0242ac120005"), professionId = Guid.Parse("d241691c-112e-11ee-be56-0242ac120004"), CreationDate = DateTime.Now});


        modelBuilder.Entity<tblEmployee>(employee=>{
            employee.ToTable("Empelados");
            employee.HasKey(p=> p.id);
            employee.Property(p=> p.identification).IsRequired().HasMaxLength(10);
            employee.Property(p=> p.name).IsRequired().HasMaxLength(150);
            employee.Property(p=> p.age).IsRequired();
            employee.Property(p=> p.phone).IsRequired().HasMaxLength(10);
            employee.Property(p=> p.address).IsRequired().HasMaxLength(50);
            employee.Property(p=> p.user).IsRequired().HasMaxLength(8);
            employee.HasOne(p=> p.area).WithMany(p=> p.employee).HasForeignKey(p=> p.areaId);
            employee.HasOne(p=> p.profession).WithMany(p=> p.employee).HasForeignKey(p=> p.professionId);
            employee.Property(p=> p.CreationDate).IsRequired();
            employee.HasData(employeeInit);


        });
    }
}