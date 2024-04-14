using Cw05.Properties.Database;
using Cw05.Properties.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw05.Properties.Contollers;
[ApiController]
[Route("/animals-controller")]
// [Route("[controller]")]

public class AnimalsController : ControllerBase
{
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        return Ok(id);
    }
    
    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();
    }
}