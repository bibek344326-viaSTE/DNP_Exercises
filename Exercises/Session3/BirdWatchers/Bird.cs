namespace BirdWatchers;

public class Bird
{
    private Random _random = new Random();

    private string[] _behaviors =
    {
        "Bird flaps wings",
        "Bird sings",
        "Bird does mating dance",
        "Bird flies in circles",
        "Bird perches on a tree"
    };
    
    public string PerformBehavior()
    {
        int index = _random.Next(_behaviors.Length);
        return _behaviors[index];
    }
    
    // Method to run the example, printing random behaviors
    public void RunExample(Action<string> observer)
    {
        for (int i = 0; i < 5; i++)
        {
            string behavior = PerformBehavior();
            observer(behavior);
        }
    }
}