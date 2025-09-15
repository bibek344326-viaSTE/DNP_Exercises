// See https://aka.ms/new-console-template for more information

using System.Text.Json;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public bool IsMarried { get; set; }
    public char Sex { get; set; }
    public string[] Hobbies { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create 3 person objects
        var person1 = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 30,
            Height = 5.9,
            IsMarried = true,
            Sex = 'M',
            Hobbies = new string[] { "Reading", "Traveling", "Gaming" }
        };

        var person2 = new Person
        {
            FirstName = "Jane",
            LastName = "Smith",
            Age = 28,
            Height = 5.6,
            IsMarried = false,
            Sex = 'F',
            Hobbies = new string[] { "Cooking", "Yoga", "Gardening" }
        };

        var person3 = new Person
        {
            FirstName = "Emily",
            LastName = "Brown",
            Age = 35,
            Height = 5.8,
            IsMarried = true,
            Sex = 'F',
            Hobbies = new string[] { "Swimming", "Painting", "Cycling" }
        };

        // Add them to a list
        var persons = new List<Person> { person1, person2, person3 };

        // Serialize without formatting
        string jsonUnformatted = JsonSerializer.Serialize(persons);
        Console.WriteLine("Unformatted JSON:");
        Console.WriteLine(jsonUnformatted);

        // Serialize with formatting
        string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("\nFormatted JSON:");
        Console.WriteLine(jsonFormatted);
    }
}