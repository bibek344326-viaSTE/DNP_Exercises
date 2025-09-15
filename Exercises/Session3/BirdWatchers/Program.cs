using System;
using System.Collections.Generic;
using BirdWatchers;

class Program
{
    public static void Main(string[] args)
    {
        // Create a Bird
        Bird bird = new Bird();

        // Create different BirdWatchers with different reactions
        BirdWatcher birdWatcher = new BirdWatcher((behavior) => 
        {
            Console.WriteLine("Wow, look at that! " + behavior);
        });

        DeafBirdWatcher deafBirdWatcher = new DeafBirdWatcher();
        BlindBirdWatcher blindBirdWatcher = new BlindBirdWatcher();
        WesternJutlandBirdWatcher westernJutlandBirdWatcher = new WesternJutlandBirdWatcher();

        // Run the example and pass the reactions of each watcher
        Console.WriteLine("Standard BirdWatcher reaction:");
        bird.RunExample(birdWatcher.ReactToBirdBehavior);

        Console.WriteLine("\nDeaf BirdWatcher reaction:");
        bird.RunExample(deafBirdWatcher.ReactToBirdBehavior);

        Console.WriteLine("\nBlind BirdWatcher reaction:");
        bird.RunExample(blindBirdWatcher.ReactToBirdBehavior);

        Console.WriteLine("\nWestern Jutland BirdWatcher reaction:");
        bird.RunExample(westernJutlandBirdWatcher.ReactToBirdBehavior);

    }
}