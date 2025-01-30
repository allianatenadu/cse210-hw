// Program.cs
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# in 30 minutes", 19.99m, "A quick and comprehensive introduction to C# programming.");
        Video video2 = new Video("C# Tutorial for Beginners", 29.99m, "Perfect for those new to C#, covering fundamentals and basic syntax.");

        // Add comments to video1
        
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned so much!"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "I’m new to C# and this helped me a lot."));
        video2.AddComment(new Comment("Eve", "More advanced examples would be nice."));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2 };

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayDetails();
        }
    }
}

