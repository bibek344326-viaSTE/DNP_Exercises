using API.DTOs;
using API.Entities;
using API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class MenusController
{
    private readonly IMenuRepository menuRepository;
    private readonly IPizzaRepository pizzaRepository;

    public MenusController(IMenuRepository menuRepository, IPizzaRepository pizzaRepository)
    {
        this.menuRepository = menuRepository;
        this.pizzaRepository = pizzaRepository;
    }

    // POST localhost:7080/menus - creates a new menu
    [HttpPost]
    public async Task<IResult> CreateMenu([FromBody] CreateMenuDto menu)
    {
        Menu newMenu = new()
        {
            Name = menu.Name
        };
        Menu created = await menuRepository.AddAsync(newMenu);
        return Results.Created($"/{created.Id}", created);
    }

    // POST localhost:7080/menus/{id}/pizzas - adds a pizza to the menu
    [HttpPost("{id}/pizzas")]
    public async Task<IResult> AddPizzaToMenu(
        [FromRoute] int id,
        [FromBody] AddPizzaToMenuDto dto)
    {
        Menu menu = await menuRepository.GetSingleAsync(id);
        // verify pizza with id exists
        menu.PizzaIds.Add(dto.PizzaId);
        
        return Results.Ok();
    }
}