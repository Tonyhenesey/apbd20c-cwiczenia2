using Microsoft.AspNetCore.Mvc;
using Cw05.Properties.Models;
using Cw05.Properties.Database;

namespace Cw05.Properties.Controllers;

[ApiController]
[Route("[" +
       "Animalscontroller]")]
public class AnimalsController : ControllerBase
{
    private readonly MockDb _db;

    public AnimalsController(MockDb db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetAnimals() => Ok(_db.Animals);

    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _db.Animals.FirstOrDefault(a => a.Id == id);
        return animal != null ? Ok(animal) : NotFound();
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        _db.Animals.Add(animal);
        return CreatedAtAction(nameof(GetAnimal), new { id = animal.Id }, animal);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal updateAnimal)
    {
        var animal = _db.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null) return NotFound();
        animal.Name = updateAnimal.Name;
        animal.Category = updateAnimal.Category;
        animal.Weight = updateAnimal.Weight;
        animal.FurColor = updateAnimal.FurColor;
        return Ok(animal);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _db.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null) return NotFound();
        _db.Animals.Remove(animal);
        return NoContent();
    }
}