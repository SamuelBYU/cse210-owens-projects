using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, SquareNumber(userNumber));
    }
    
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name; 
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int input = Convert.ToInt32(Console.ReadLine());
        return input;
    }
    static int SquareNumber( int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}