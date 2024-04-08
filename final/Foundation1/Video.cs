using System;
using System.Collections.Generic;

public class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;
    public List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}