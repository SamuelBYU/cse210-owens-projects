using System;


class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        

        while(true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Please select an option(Numbers only): ");
            string choice = Console.ReadLine();
            int userChoice = int.Parse(choice);
            
            if (userChoice == 1)
            {
                Entry aPrompt = new Entry();
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();
        
                aPrompt._promptText = prompt;
                aPrompt.Display();

                Console.WriteLine();//Just to add space.
                Console.WriteLine("Your Response: ");
                string response = Console.ReadLine();
                
                aPrompt._date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                aPrompt._entryText = response;
                theJournal.AddEntry(aPrompt);
                
                Console.WriteLine("Entry added to journal...");

            }
            else if (userChoice == 2)
            {
                //Journal display = new Journal();
                theJournal.DisplayAll();
                
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("What is the filename you would like to load?");
                string response = Console.ReadLine();
                if (response == "myJournal.txt")
                {
                    theJournal.LoadFromFile(response);
                }
                
                else
                {
                    Console.WriteLine("The filename you have chosen does not exist.");
                }   
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("What is the filename you would like to save?");
                string response = Console.ReadLine();
                if (response == "myJournal.txt")
                {
                    theJournal.SaveToFile(response);
                }
               
            }
            else if (userChoice == 5)
            {
                Console.Write("Good job journaling today!");
                break;
            }
            else
            {
                Console.WriteLine("Please select an option 1-5");
            }

        }
        
        
        
  
        
        
        
        

        
        
    }
}