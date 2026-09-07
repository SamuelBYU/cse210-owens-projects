using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = 0;
        while (userNumber == 0)
        {
            Console.Write("Give me a whole number. Type 0 if you want to quit: ");
            string number = Console.ReadLine();
            int numbersInList = int.Parse(number);
            if (numbersInList == 0)
            {
                break;
            }
            if (numbersInList != 0)
            {
                numbers.Add(numbersInList);
            }
            

            
        }
        int total = 0;
        double average = 0;
        Console.WriteLine("Numbers entered:");
        foreach (int value in numbers)
        {
            Console.WriteLine(value);
            total += value;
        }
        Console.WriteLine($"The sum is: {total}");
        if (numbers.Count > 0)
        {
            average = (double)total / numbers.Count;
        }
        int max = numbers.Max();
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        
        
    }
}