namespace BirdWatchers;

public class BirdWatcher
{
    public Action<string> ReactToBirdBehavior { get; set; }
    
    public BirdWatcher(Action<string> reactToBirdBehavior)
    {
        ReactToBirdBehavior = reactToBirdBehavior;
    }
    
}

public class DeafBirdWatcher : BirdWatcher
{
    public DeafBirdWatcher() : base((behavior) => 
    {
        if (behavior != "Bird sings")
        {
            Console.WriteLine("Oh, I see! " + behavior);
        }
    }) { }
}

public class BlindBirdWatcher : BirdWatcher
{
    public BlindBirdWatcher() : base((behavior) => 
    {
        if (behavior == "Bird sings")
        {
            Console.WriteLine("Oh, I hear it singing!");
        }
    }) { }
}

public class WesternJutlandBirdWatcher : BirdWatcher
{
    public WesternJutlandBirdWatcher() : base((behavior) => { Console.WriteLine("Eh, that's okay, I guess..."); })
    {
    }
}