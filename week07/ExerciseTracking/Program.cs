using System;

class Program
{
    static void Main(string[] args)
    {
        

        
        
        Cycling cycling = new Cycling(5, 03/01/1993, 60);
        cycling.Summary();

        Running running = new Running(4, 10/13/2023, 120);
        running.Summary();

        Swimming swimming = new Swimming(8, 12/31/2019, 45);
        swimming.Summary();
    }
}