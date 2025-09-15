using TrafficLight;

class Program
{
    static void Main(string[] args)
    {
        // Create a TrafficLight object
        TrafficLights tl = new TrafficLights();

        // Create Car objects
        new Car(tl, 1);
        new Car(tl, 2);
        new Car(tl, 3);

        // Create Taxi objects
        new Taxi(tl, 4);
        new Taxi(tl, 5);

        // Create Pedestrian object
        Pedestrian pedestrian = new Pedestrian();
        tl.OnLightChanged += pedestrian.ReactToLight;  // Pedestrian reacts to light changes

        // Run the TrafficLight simulation
        tl.RunTrafficLight();
    }
}