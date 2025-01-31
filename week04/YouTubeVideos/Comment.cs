// Comment.cs
public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize a Comment object
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

