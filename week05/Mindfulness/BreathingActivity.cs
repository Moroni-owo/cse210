using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by guiding you through deep breathing.")
    {
    }

    public void Run()
    {
        StartActivity();

        int cycles = _duration / 8;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
            Console.WriteLine();
        }

        EndActivity();
    }
}
