namespace API.Entities;

public class Menu
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> PizzaIds { get; set; }
}