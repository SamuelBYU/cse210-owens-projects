using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool playAgain = true;
        while (playAgain)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int userGuess = 0;
            while (userGuess != magicNumber)
            {
                Console.Write("What is the magic number? ");
                string number = Console.ReadLine();
                userGuess = int.Parse(number);

                    if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                    if (userGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                    
            }
            Console.Write("Would you like to play again? ");
            string response = Console.ReadLine(); 

            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing!");
            }  
        }
        
        
    }
}