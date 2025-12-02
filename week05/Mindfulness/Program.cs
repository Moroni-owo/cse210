using System;
using System.IO;
using System.Collections.Generic;

// EXTRA CREDIT INCLUDED:
// 1. Added GratitudeActivity (a 4th unique activity).
// 2. Program saves a history log of every activity performed in history.txt.

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Gratitude Activity (Extra)");
            Console.WriteLine("5. Quit");
            Console.Write("\nChoose an option: ");

            choice = int.Parse(Console.ReadLine());
            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    ((BreathingActivity)activity).Run();
                    LogHistory("Breathing Activity");
                    break;

                case 2:
                    activity = new ListingActivity();
                    ((ListingActivity)activity).Run();
                    LogHistory("Listing Activity");
                    break;

                case 3:
                    activity = new ReflectingActivity();
                    ((ReflectingActivity)activity).Run();
                    LogHistory("Reflecting Activity");
                    break;

                case 4:
                    activity = new GratitudeActivity();
                    ((GratitudeActivity)activity).Run();
                    LogHistory("Gratitude Activity");
                    break;

                case 5:
                    Console.WriteLine("\nGoodbye!");
                    break;

                default:
                    Console.WriteLine("\nInvalid option.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    static void LogHistory(string activityName)
    {
        using (StreamWriter writer = new StreamWriter("history.txt", true))
        {
            writer.WriteLine($"{DateTime.Now}: Completed {activityName}");
        }
    }
}
