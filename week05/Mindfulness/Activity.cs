using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration of this activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        Stopwatch timer = new Stopwatch();
        timer.Start();

        int i = 0;
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.Write(frames[i]);
            System.Threading.Thread.Sleep(200);
            Console.Write("\b");
            i = (i + 1) % frames.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
