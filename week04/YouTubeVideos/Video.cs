// Video.cs
using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, decimal price, string description)
    {
        Title = title;
        Price = price;
        Description = description;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Video Title: {Title}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}\n");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}
