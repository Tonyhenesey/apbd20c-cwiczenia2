using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Cw05.Properties.Models;
using Cw05.Properties.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<MockDb>(); // Using a mock database for demonstration

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Map animal endpoints
app.MapGet("/animals", (MockDb db) => Results.Ok(db.Animals));
app.MapGet("/animals/{id}", (int id, MockDb db) => 
    db.Animals.FirstOrDefault(a => a.Id == id) is Animal animal ? Results.Ok(animal) : Results.NotFound());
app.MapPost("/animals", (Animal animal, MockDb db) => 
{
    db.Animals.Add(animal);
    return Results.Created($"/animals/{animal.Id}", animal);
});
app.MapPut("/animals/{id}", (int id, Animal updateAnimal, MockDb db) =>
{
    var animal = db.Animals.FirstOrDefault(a => a.Id == id);
    if (animal == null) return Results.NotFound();
    animal.Name = updateAnimal.Name;
    animal.Category = updateAnimal.Category;
    animal.Weight = updateAnimal.Weight;
    animal.FurColor = updateAnimal.FurColor;
    return Results.Ok(animal);
});
app.MapDelete("/animals/{id}", (int id, MockDb db) =>
{
    var animal = db.Animals.FirstOrDefault(a => a.Id == id);
    if (animal == null) return Results.NotFound();
    db.Animals.Remove(animal);
    return Results.NoContent();
});

app.Run();