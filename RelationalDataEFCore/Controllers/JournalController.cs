using RelationalDataEFCore.Services;
using RelationalDataEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace RelationalDataEFCore.Controllers;

[ApiController]
[Route("[controller]")]
public class JournalController : ControllerBase
{
    JournalService _service;
    
    public JournalController(JournalService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Journal> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Journal> GetById(int id)
    {
        var Journal = _service.GetById(id);

        if(Journal is not null)
        {
            return Journal;
        }
        else
        {
            return NotFound();
        }
    }


    [HttpPost]
    public IActionResult Create(Journal newJournal)
    {
        var Journal = _service.Create(newJournal);
        return CreatedAtAction(nameof(GetById), new { id = Journal!.Id }, Journal);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var Journal = _service.GetById(id);

        if(Journal is not null)
        {
            _service.DeleteById(id);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}