using API.Entities;


namespace API.Repositories;

public class PizzaRepo : IPizzaRepository
{
    // making this static is a bit of a hack, which shouldn't generally be done.
    private static List<Pizza> pizzas = new List<Pizza>();

    public PizzaRepo()
    {
        pizzas =
        [
            new Pizza()
            {
                Id = 1,
                Name = "Margherita",
                IsVegetarian = true
            },
            new Pizza()
            {
                Id = 2,
                Name = "Pepperoni",
                IsVegetarian = false
            },
            new Pizza()
            {
                Id = 3,
                Name = "Hawaiian",
                IsVegetarian = false
            },
            new Pizza()
            {
                Id = 4,
                Name = "Meat Feast",
                IsVegetarian = false
            },
            new Pizza()
            {
                Id = 5,
                Name = "Veggie Supreme",
                IsVegetarian = true
            },
            new Pizza()
            {
                Id = 6,
                Name = "Vegan Margherita",
                IsVegetarian = true
            },
            new Pizza()
            {
                Id = 7,
                Name = "Vegan Veggie Supreme",
                IsVegetarian = true
            },
            new Pizza()
            {
                Id = 8,
                Name = "Vegan Hawaiian",
                IsVegetarian = true
            },
            new Pizza()
            {
                Id = 9,
                Name = "Vegan Meat Feast",
                IsVegetarian = true
            }
        ];
    }


    public Task<Pizza> AddAsync(Pizza pizza)
    {
        throw new NotImplementedException();
    }

    public List<Pizza> GetAll()
    {
        throw new NotImplementedException();
    }

    Task IPizzaRepository.GetSingleAsync(int id)
    {
        return GetSingleAsync(id);
    }

   
    public Task<Pizza> GetSingleAsync(int id)
    {
        Pizza? pizza = pizzas.SingleOrDefault(p => p.Id == id);
        if (pizza is null)
        {
            throw new Exception("Pizza not found");
        }
        return Task.FromResult(pizza);
    }
}