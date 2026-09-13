using System;

public class Entry
{
    //DateTime now = DateTime.Now;
    public string _date;
    public string _promptText = "";
    public string _entryText = "";

    
    public void Display()
    {
        //Console.WriteLine($"Date: {now}");
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);

    }
}