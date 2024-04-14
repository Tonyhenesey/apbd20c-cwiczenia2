using Cw05.Properties;
using Cw05.Properties.Database;
using Cw05.Properties.Endpoints;
using Cw05.Properties.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<MockDb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Minimal API
app.MapAnimalEndpoints();

// Controllers
app.MapControllers();

app.Run();

// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
//
// var dataService = new DataService();
//
// app.MapGet("/animals", () => dataService.GetAllAnimals());
// app.MapGet("/animals/{id}", (int id) => dataService.GetAnimalById(id));
// app.MapPost("/animals", (Animal animal) => dataService.AddAnimal(animal));
// app.MapPut("/animals", (Animal animal) => dataService.UpdateAnimal(animal));
// app.MapDelete("/animals/{id}", (int id) => dataService.DeleteAnimal(id));
//
// app.MapGet("/visits/animal/{animalId}", (int animalId) => dataService.GetVisitsForAnimal(animalId));
// app.MapPost("/visits", (Visit visit) => dataService.AddVisit(visit));
//
// app.Run();