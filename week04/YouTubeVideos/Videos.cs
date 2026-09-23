//This class has the responsibility to track the title, author, and length(in seconds) of the video.
//Each Video also has the responsibility to store a list of comments, 
//and should have a method to return the number of comments.

using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private double _length;

    private List<Comment> _comments = new List<Comment>();
    
    

    public Video(string title, string author, double length, string comment)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comment;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title} \nAuthor: {_author} \nLength: {_length} Seconds");
    }
    
    public void DisplayAll()
    {
        foreach (Comment comment in _comments)
        {
            Console.Clear();
            comment.Display();
            Console.WriteLine();
        }
    }
}