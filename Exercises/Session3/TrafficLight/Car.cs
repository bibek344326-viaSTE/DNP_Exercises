namespace TrafficLight;

public class Car
{
    protected int id;

    public Car(TrafficLights tl, int id)
    {
        this.id = id;
        tl.OnLightChanged += ReactToLight;
    }

    protected virtual void ReactToLight(string color)
    {
        string result = $"Car {id} ";
        switch (color)
        {
            case "GREEN":
                result += "drives";
                break;
            case "YELLOW":
                result += "slows";
                break;
            case "RED":
                result += "stops";
                break;
        }
        Console.WriteLine(result);
    }
}