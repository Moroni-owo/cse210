using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one activity of each type
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycling = new Cycling("03 Nov 2022", 45, 20.0);
        Swimming swimming = new Swimming("03 Nov 2022", 25, 40);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Show summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
