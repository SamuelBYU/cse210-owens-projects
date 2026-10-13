using System;

class Program
{
    static void Main(string[] args)
    {
        

        
        
        Cycling cycling = new Cycling(5, 19930301, 60);
        Console.WriteLine(cycling.Summary());

        Running running = new Running(4, 20231013, 120);
        Console.WriteLine(running.Summary());

        Swimming swimming = new Swimming(8, 20191231, 45);
        Console.WriteLine(swimming.Summary());
    }
}