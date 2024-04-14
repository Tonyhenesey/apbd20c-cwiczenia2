using Cw05.Properties.Models;
using System.Collections.Generic;
using System;

namespace Cw05.Properties.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; }
    public List<Visit> Visits { get; set; }

    public MockDb()
    {
        Animals = new List<Animal>
        {
            new Animal { Id = 1, Name = "Rex", Category = "Pies", Weight = 25.5, FurColor = "Czarny" },
            new Animal { Id = 2, Name = "Miau", Category = "Kot", Weight = 5.0, FurColor = "Biały" },
            new Animal { Id = 3, Name = "Burek", Category = "Pies", Weight = 15.3, FurColor = "Brązowy" }
        };

        Visits = new List<Visit>
        {
            new Visit { Id = 1, AnimalId = 1, VisitDate = DateTime.Now.AddDays(-1), Description = "Szczepienie roczne", VisitCost = 100.00m },
            new Visit { Id = 2, AnimalId = 2, VisitDate = DateTime.Now.AddDays(-10), Description = "Ocena zdrowia", VisitCost = 150.00m },
            new Visit { Id = 3, AnimalId = 3, VisitDate = DateTime.Now.AddDays(-30), Description = "Leczenie choroby skóry", VisitCost = 200.00m }
        };
    }
}