using API.DTOs;
using API.Entities;
using API.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzasController
{
    private readonly IPizzaRepository pizzaRepo;
    

    public PizzasController(IPizzaRepository pizzaRepo)
    {
        this.pizzaRepo = pizzaRepo;
    }

    //POST https://localhost:7080/pizzas
    [HttpPost]
    public async Task<IResult> CreatePizza([FromBody] CreatePizzaDto request)
    {
        Pizza pizza = new Pizza
        {
            Name = request.Name,
            IsVegetarian = request.IsVegetarian
        };
        await pizzaRepo.AddAsync(pizza);
        return Results.Created($"pizzas/{pizza.Id}", pizza);
    }

    [HttpGet("{id}")] // GET https://localhost:7080/pizzas/{id}
    public async Task<IResult> GetSinglePizza([FromRoute] int id)
    {
        Pizza pizza = await pizzaRepo.GetSingleAsync(id);
        return Results.Ok(pizza);
    }
    
    
    [HttpDelete("{id}")] // DELETE https://localhost:7080/pizzas/{id}
    public async Task<IResult> DeletePizza([FromRoute] int id)
    {
        // await pizzaRepo.DeleteAsync(id);
        return Results.NoContent();
    }

    [HttpPut("{id}")] // PUT https://localhost:7080/pizzas/{id}
    public async Task<IResult> UpdatePizza([FromRoute] int id, [FromBody] ReplacePizzaDto request)
    {
        // await pizzaRepo.UpdateAsync(id, request);
        return Results.NoContent();
    }

    // GET https://localhost:7080/pizzas?isVegetarian=true&nameContains=a
    [HttpGet]
    public async Task<IResult> GetPizzas([FromQuery] bool? isVegetarian, [FromQuery] string? nameContains)
    {
        List<Pizza> pizzas = pizzaRepo.GetAll();
        if (isVegetarian.HasValue)
        {
            pizzas = pizzas.Where(p => p.IsVegetarian == isVegetarian).ToList();
        }

        if (!string.IsNullOrWhiteSpace(nameContains))
        {
            pizzas = pizzas.Where(p => p.Name.ToLower().Contains(nameContains.ToLower())).ToList();
        }

        return Results.Ok(pizzas);
    }
}