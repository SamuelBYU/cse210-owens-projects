using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine();
            Console.Write("Please select an option to relax: ");
            string choice = Console.ReadLine();
            int userChoice = int.Parse(choice);

            if (userChoice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }

            else if (userChoice == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }

            else if (userChoice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("Hope you have a relaxing day!");
                break;
            }
            else
            {
                Console.WriteLine("Please select an option 1-4");
            }
        }
    }
}