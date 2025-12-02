using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are you grateful for today?",
        "What are some personal strengths you have?",
        "Who has helped you recently?"
    };

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on positive things in your life.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nPrompt:\n--- {prompt} ---");
        Console.WriteLine("You may begin listing in: ");
        ShowCountdown(5);

        List<string> items = new List<string>();
        Console.WriteLine("\nStart listing:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndActivity();
    }
}
