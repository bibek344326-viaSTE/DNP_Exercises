namespace CarAndPredicates;

public class CarFilter
{
    // Method to filter cars by a single color
    public static void PrintCarsByColor(List<Car> cars, string color)
    {
        var filteredCars = cars.Where(car => car.Color.Equals(color, StringComparison.OrdinalIgnoreCase)).ToList();
        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
    }

    // Method to filter cars by two colors
    public static void PrintCarsByTwoColors(List<Car> cars, string color1, string color2)
    {
        var filteredCars = cars.Where(car => car.Color.Equals(color1, StringComparison.OrdinalIgnoreCase) ||
                                              car.Color.Equals(color2, StringComparison.OrdinalIgnoreCase)).ToList();
        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
    }

    // Method to filter cars by horse power greater than a given value
    public static void PrintCarsByHorsePower(List<Car> cars, int minHorsePower)
    {
        var filteredCars = cars.Where(car => car.HorsePower > minHorsePower).ToList();
        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
    }

    // Method to filter cars by horse power within a range
    public static void PrintCarsByHorsePowerRange(List<Car> cars, int minHorsePower, int maxHorsePower)
    {
        var filteredCars = cars.Where(car => car.HorsePower >= minHorsePower && car.HorsePower <= maxHorsePower).ToList();
        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
    }

    // Method to filter cars by fuel economy lower than a given value
    public static void PrintCarsByFuelEconomy(List<Car> cars, double maxFuelEconomy)
    {
        var filteredCars = cars.Where(car => car.FuelEconomy < maxFuelEconomy).ToList();
        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
    }

    // Method to filter cars by a specific number of doors
    public static void PrintCarsByDoors(List<Car> cars, int numberOfDoors)
    {
        var filteredCars = cars.Where(car => car.Doors == numberOfDoors).ToList();
        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
    }

    // Method to filter cars based on two conditions (using Func)
    public static void PrintCarsByConditions(List<Car> cars, Func<Car, bool> condition1, Func<Car, bool> condition2)
    {
        var filteredCars = cars.Where(car => condition1(car) && condition2(car)).ToList();
        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
    }
    
}