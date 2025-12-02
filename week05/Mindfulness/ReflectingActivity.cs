using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a moment when you overcame a challenge.",
        "Recall a time when you felt truly at peace."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "How did you feel during this moment?",
        "What did you learn from it?",
        "How can you apply this experience today?"
    };

    public ReflectingActivity()
        : base("Reflecting", "This activity guides you through deep personal reflection.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt:\n--- {prompt} ---");
        ShowSpinner(4);

        int cycles = _duration / 8;
        for (int i = 0; i < cycles; i++)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
        }

        EndActivity();
    }
}
