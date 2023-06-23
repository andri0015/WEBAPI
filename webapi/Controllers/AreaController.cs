using Microsoft.AspNetCore.Mvc;
using webapi.Services;
using webapi.Models;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AreaController:  ControllerBase
{
    IAreaService areaService;

    public AreaController(IAreaService area)
    {
        areaService = area;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(areaService.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] tblArea area)
    {
        areaService.Save(area);
        return Ok();
    }


    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] tblArea area)
    {
        areaService.Update(id, area);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        areaService.Delete(id);
        return Ok();
    }  
}