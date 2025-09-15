namespace SimplePersonExample;

public class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I a am {Name}");
    }
}