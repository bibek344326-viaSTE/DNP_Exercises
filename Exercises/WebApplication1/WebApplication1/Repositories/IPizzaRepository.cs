using API.Entities;


namespace API.Repositories;

public interface IPizzaRepository
{
    Task<Pizza> AddAsync(Pizza pizza);
    List<Pizza> GetAll();
    Task GetSingleAsync(int id);
}