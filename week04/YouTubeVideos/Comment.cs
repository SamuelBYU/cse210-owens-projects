//A comment should be defined by the Comment class which has the responisbility for tracking both the 
//name of the person who made the comment and the text of the comment.

using System;

public class Comment
{
    private string _name;
    private string _text;


    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void Display()//I think I should replace this with code that passes the _name/_text over to Videos.cs...
    {
        Console.WriteLine($"@{_name} \nComment: {_text}");
    }
}