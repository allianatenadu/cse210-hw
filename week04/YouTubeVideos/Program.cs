// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Comment objects
        Comment comment1 = new Comment("Alice", "Great video! Very informative.");
        Comment comment2 = new Comment("Bob", "I learned a lot from this tutorial.");
        Comment comment3 = new Comment("Charlie", "Thanks for the tips!");
        Comment comment4 = new Comment("Diana", "Really helpful, but could use more examples.");

        // Create Video objects
        Video video1 = new Video("Learn C# Programming", "John Doe", 300);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Mastering Algorithms", "Jane Smith", 400);
        video2.AddComment(comment2);
        video2.AddComment(comment4);

        Video video3 = new Video("Introduction to Data Science", "Mark Lee", 350);
        video3.AddComment(comment1);
        video3.AddComment(comment4);

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details for each video
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
