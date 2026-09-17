using System;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        Fraction f2 = new Fraction();
        f2.SetTop(5);
        f2.GetTop();
        f2.GetBottom();
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        
        


        Fraction f3 = new Fraction();
        f3.SetTop(3);
        f3.SetBottom(4);
        
        f3.GetTop();
        f3.GetBottom();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        Fraction f4 = new Fraction();
        f4.SetTop(1);
        f4.SetBottom(3);
        f4.GetTop();
        f4.GetBottom();
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


    }
    
}