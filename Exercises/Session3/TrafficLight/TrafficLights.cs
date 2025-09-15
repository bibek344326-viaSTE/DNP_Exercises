namespace TrafficLight;

public class TrafficLights
{
    public Action<string> OnLightChanged { get; set; }
    private string[] colors = {"GREEN", "YELLOW", "RED"};
    public void RunTrafficLight()
    {
        for (int i = 0; i < 12; i++)
        {
            int idx = i% colors.Length;
            string currentColor = colors[idx];
            Console.WriteLine("Light is: " + currentColor);
            OnLightChanged?.Invoke(currentColor);
            System.Threading.Thread.Sleep(1000);
        }
    }

}