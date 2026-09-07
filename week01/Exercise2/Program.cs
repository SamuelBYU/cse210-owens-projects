using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int percentage = int.Parse(valueFromUser);

        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine(letter);
            if (percentage >= 70)
        {
                Console.WriteLine("Congratulations, you passed the class!");
            }
            else
        {
            Console.WriteLine("You did not pass this time. I know you will next time!");
        }
    }
}
//Ran out of time, will do stretch goals ASAP.