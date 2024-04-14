using Cw05.Properties.Models;

namespace Cw05.Properties;

public class DataService
{
    private List<Animal> Animals = new List<Animal>();
    private List<Visit> Visits = new List<Visit>();

    public IEnumerable<Animal> GetAllAnimals() => Animals;
    public Animal GetAnimalById(int id) => Animals.FirstOrDefault(a => a.Id == id);
    public void AddAnimal(Animal animal) { animal.Id = Animals.Count + 1; Animals.Add(animal); }
    public void UpdateAnimal(Animal animal) { var index = Animals.FindIndex(a => a.Id == animal.Id); if (index != -1) Animals[index] = animal; }
    public void DeleteAnimal(int id) { Animals.RemoveAll(a => a.Id == id); }

    public IEnumerable<Visit> GetVisitsForAnimal(int animalId) => Visits.Where(v => v.AnimalId == animalId);
    public void AddVisit(Visit visit) { visit.Id = Visits.Count + 1; Visits.Add(visit); }
}