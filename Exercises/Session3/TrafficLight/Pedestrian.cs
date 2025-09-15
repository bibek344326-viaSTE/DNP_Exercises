namespace TrafficLight;

public class Pedestrian
{
    public void ReactToLight(string color)
    {
        if (color == "RED")
        {
            Console.WriteLine("Pedestrian crosses the road");
        }
        else
        {
            Console.WriteLine("Pedestrian waits for the light to turn red");
        }
    }
}