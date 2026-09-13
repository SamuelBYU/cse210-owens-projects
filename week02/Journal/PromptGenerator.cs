using System;

public class PromptGenerator
{
    
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What moment from today do I want to remember?",
        "Did today turn out differently than I expected? How?",
        "What emotions did I experience most strongly today? And Why?",
        "Did I react to anything today in a way I wish I could change?",
        "What was I avoiding today, and why?",
        "When did I feel most like myself today?",
        "What did I do today that I'm proud of?",
        "What could I have handled better today?",
        "Did I make progress toward something that matters to me today?",
        "What mistake did I make today, and what can I learn from it?",
        "What is one thing I would do differently if I could relive today?",
        "Did I step outside my comfort zone today?",
        "What did today teach me that I can use tomorrow?",
        "Who made my day better today?",
        "Did I make someone else's day better? If so, how?",
        "Is there someone I should have listened to more carefully today?",
        "Did I communicate what I really meant today?",
        "Is there anything I need to say to someone that I've been holding back?",
        "Did I spend my time today on things that actually matter to me?",
        "What distracted me the most today?",
        "What did I spend too much energy worrying about?",
        "What deserves more of my attention tomorrow?",
        "Did my actions today reflect the person I want to become?",
        "If I repeated today for an entire year, where would I end up?",
        "What am I grateful for today?",
        "What can I let go of before I go to sleep?",
    };
    //Create a list.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

        
    }
    //Iterate through the list.
   
}