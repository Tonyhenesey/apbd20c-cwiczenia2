using Cw05.Properties.Models;

namespace Cw05.Properties.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDb()
    {
        Animal _animal = new Animal { Id = 1, Category = "Pies", FurColor = "Szary", Name = "Rysio", Weight = 30.5 };

        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}