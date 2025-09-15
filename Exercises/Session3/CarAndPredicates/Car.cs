namespace CarAndPredicates;

public class Car
{
    public string? Color { get; set; }
    public int HorsePower { get; set; }
    public double FuelEconomy { get; set; } //in Liters per 100 km
    public bool IsManualShift { get; set; }
    public int Doors { get; set; }
    
    public Car(string color, int horsePower, double fuelEconomy, bool isManualShift, int doors)
    {
        Color = color;
        HorsePower = horsePower;
        FuelEconomy = fuelEconomy;
        IsManualShift = isManualShift;
        Doors = doors;
    }
    
    public override string ToString()
    {
        return $"Color: {Color}, HorsePower: {HorsePower}, FuelEconomy: {FuelEconomy}, IsManualShift: {IsManualShift}, Doors: {Doors}";
    }
}