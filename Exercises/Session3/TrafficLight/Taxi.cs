namespace TrafficLight;

public class Taxi:Car
{
    public Taxi(TrafficLights t1, int id):base(t1, id) {}

    protected override void ReactToLight(string color)
    {
        string result = $"Taxi {id} ";
        switch (color)
        {
            case "GREEN":
                result += " races across";
                break;
            case "YELLOW":
                result += " speeds up, crosses while yelling TAXI GREEN";
                break;
            case "RED":
                result += " slams the breaks and comes to a screeching halt";
                break;
        }
        Console.WriteLine(result);
    }
}