using Microsoft.AspNetCore.Mvc;
using webapi.Services;
using webapi.Models;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfessionController:  ControllerBase
{
    IProfessionService professionService;

    public ProfessionController(IProfessionService profession)
    {
        professionService = profession;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(professionService.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] tblProfession profession)
    {
        professionService.Save(profession);
        return Ok();
    }


    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] tblProfession profession)
    {
        professionService.Update(id, profession);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        professionService.Delete(id);
        return Ok();
    }  
}