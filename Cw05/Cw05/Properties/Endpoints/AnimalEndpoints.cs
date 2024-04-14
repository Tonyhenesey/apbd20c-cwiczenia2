using Cw05.Properties.Database;
using Cw05.Properties.Models;

namespace Cw05.Properties.Endpoints;


public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            // 200 - Ok
            // 201 - Created
            // 400 - Bad Request
            // 404 - Not Found
            var animals = StaticData.animals;
            return Results.Ok(animals);
        });

        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(id);
        });

        app.MapPost("/animals", (Animal animal) =>
        {
            return Results.Created("", animal);
        });
    }
}