using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Cycling cycling = new Cycling(5.0, 19930301, 60);
        Console.WriteLine(cycling.Summary());

        Running running = new Running(4.0, 20231013, 120);
        Console.WriteLine(running.Summary());

        Swimming swimming = new Swimming(15.0, 20191231, 45);
        Console.WriteLine(swimming.Summary());
       
    }
}