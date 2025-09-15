using CarAndPredicates;

class Program
{
    public static void Main(string[] args)
    {
        // Create a list of cars with varying properties
        List<Car> cars = new List<Car>
        {
            new Car("Red", 150, 8.5, true, 4),
            new Car("Blue", 180, 7.2, false, 4),
            new Car("Green", 250, 10.0, true, 2),
            new Car("Red", 220, 9.5, true, 4),
            new Car("Black", 300, 12.0, false, 4),
            new Car("Blue", 160, 7.8, true, 4),
        };

        // Example of filtering and printing cars by color
        Console.WriteLine("Cars of color 'Red':");
        CarFilter.PrintCarsByColor(cars, "Red");

        Console.WriteLine("\nCars of color 'Red' or 'Blue':");
        CarFilter.PrintCarsByTwoColors(cars, "Red", "Blue");

        Console.WriteLine("\nCars with HorsePower > 200:");
        CarFilter.PrintCarsByHorsePower(cars, 200);

        Console.WriteLine("\nCars with HorsePower between 150 and 250:");
        CarFilter.PrintCarsByHorsePowerRange(cars, 150, 250);

        Console.WriteLine("\nCars with Fuel Economy < 9.0:");
        CarFilter.PrintCarsByFuelEconomy(cars, 9.0);

        Console.WriteLine("\nCars with 4 doors:");
        CarFilter.PrintCarsByDoors(cars, 4);

        // Example of combining two conditions using Func
        Console.WriteLine("\nCars with HorsePower > 150 and Fuel Economy < 9.0:");
        CarFilter.PrintCarsByConditions(cars, 
            car => car.HorsePower > 150, 
            car => car.FuelEconomy < 9.0);
    }
    
}