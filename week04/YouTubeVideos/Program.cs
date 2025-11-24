using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // --- Video 1 ---
        Video video1 = new Video
        {
            Title = "Learning C# Basics",
            Author = "Tech Academy",
            LengthSeconds = 600
        };

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Super helpful, thanks."));
        video1.AddComment(new Comment("Carlos", "I finally understand classes!"));

        videos.Add(video1);

        // --- Video 2 ---
        Video video2 = new Video
        {
            Title = "How to Cook Pasta",
            Author = "Chef Mario",
            LengthSeconds = 420
        };

        video2.AddComment(new Comment("Laura", "Delicious recipe!"));
        video2.AddComment(new Comment("Daniel", "I tried it today, amazing."));
        video2.AddComment(new Comment("Mike", "Simple and tasty!"));

        videos.Add(video2);

        // --- Video 3 ---
        Video video3 = new Video
        {
            Title = "Travel Guide: Machu Picchu",
            Author = "Peru Adventures",
            LengthSeconds = 890
        };

        video3.AddComment(new Comment("Rosa", "Beautiful place!"));
        video3.AddComment(new Comment("James", "I want to visit someday."));
        video3.AddComment(new Comment("Emily", "Great information!"));

        videos.Add(video3);

        // --- Display all videos ---
        foreach ( Video video in videos )
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("\nComments:");

            foreach ( Comment c in video.GetComments() )
            {
                Console.WriteLine($" - {c.CommenterName}: {c.Text}");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Program finished.");
    }
}
