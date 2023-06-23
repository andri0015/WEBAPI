using Microsoft.EntityFrameworkCore;
using webapi.Models;
namespace webapi.Services;

public class ProfessionService : IProfessionService
{
    EmployeesContext context;


    public ProfessionService(EmployeesContext dbcontext)
    {
        context = dbcontext;
    }
    public IEnumerable<tblProfession> Get()
    {
        return context.Professions;
    }

    public async Task Save(tblProfession Profession)
    {
        Profession.id = Guid.NewGuid();
        Profession.CreationDate = DateTime.Now;
        context.Add(Profession);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, tblProfession Profession)
    {
        var Profess = context.Professions.Find(id);

        if(Profess != null)
        {
            Profess.status = Profession.status;
            
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        var Profess = context.Professions.Find(id);

        if(Profess != null)
        {
            context.Remove(Profess);
            await context.SaveChangesAsync();
        }
    }
}
public interface IProfessionService
{
    IEnumerable<tblProfession> Get();
    Task Save(tblProfession Profession);

    Task Update(Guid id, tblProfession Profession);

    Task Delete(Guid id);
}

