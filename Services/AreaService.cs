using Microsoft.EntityFrameworkCore;
using webapi.Models;
namespace webapi.Services;

public class AreaService : IAreaService
{
    EmployeesContext context;


    public AreaService(EmployeesContext dbcontext)
    {
        context = dbcontext;
    }
    public IEnumerable<tblArea> Get()
    {
        return context.Areas;
    }
    public async Task Save(tblArea Area)
    {
        Area.id = Guid.NewGuid();
        Area.CreationDate = DateTime.Now;
        context.Add(Area);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, tblArea Area)
    {
        var AreaUpdate = await context.Areas.FindAsync(id);

        if(AreaUpdate != null)
        {
            AreaUpdate.status = Area.status;
            
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        var AreaDelete = await context.Areas.FindAsync(id);
        if(AreaDelete != null)
        {
            context.Remove(AreaDelete);
            await context.SaveChangesAsync();
        }
    }
}
public interface IAreaService
{
    IEnumerable<tblArea> Get();
    
    Task Save(tblArea Area);

    Task Update(Guid id, tblArea Area);

    Task Delete(Guid id);
}