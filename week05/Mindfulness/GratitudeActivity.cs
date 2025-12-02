using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude", "This activity helps you acknowledge positive things happening in your life.")
    {
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine("\nWrite three things you feel grateful for:");
        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"{i}. ");
            Console.ReadLine();
        }

        Console.WriteLine("\nThank you for sharing gratitude today!");
        EndActivity();
    }
}
