//Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each
// one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

//Then, have your program iterate through the list of videos and for each one, display the title, author, length, number
// of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video
// in the list.


using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Bread Making Tutorial", "@Mr Bean", 180);
        Video video2 = new Video("MAPHRA-Doomed", "@MAPHRAMusic", 266);
        Video video3 = new Video("DIY Garage Shelf", "@Greg's Garage", 1440);
        Video video4 = new Video("New Set Just Dropped", "@GameKinghts", 3120);
       
        Comment commentBread1 = new Comment("Sam Owens", "Video was very instructive, can't wait to make bread!");
        Comment commentBread2 = new Comment("Hazel", "Bread time!");
        Comment commentBread3 = new Comment("Brinley", "Can't wait to make dough!");

        Comment commentVoice1 = new Comment("Billy Bob", "She has such an extraordinary voice!");
        Comment commentVoice2 = new Comment("Bob Thornton", "Best voice I've heard in ages!");
        Comment commentVoice3 = new Comment("Jim Stix", "Wish I could hear this every day!");

        Comment commentShelf1 = new Comment("Bob's Basement", "I think I could make a much better shelf in my basement!");
        Comment commentShelf2 = new Comment("Larry's Ladders", "Need a shelf like this!");
        Comment commentShelf3 = new Comment("Tim's Tools", "This shelf will hold all my tools!");

        Comment commentMTG1 = new Comment("MTG Nerd", "Can't wait to get this set, it looks so cool!");
        Comment commentMTG2 = new Comment("JaxStax", "My play group is going to love this!");
        Comment commentMTG3 = new Comment("River Strixhaven", "Has some amazing synergies!");

        video1.AddComment(commentBread1);
        video1.AddComment(commentBread2);
        video1.AddComment(commentBread3);

        video2.AddComment(commentVoice1);
        video2.AddComment(commentVoice2);
        video2.AddComment(commentVoice3);

        video3.AddComment(commentShelf1);
        video3.AddComment(commentShelf2);
        video3.AddComment(commentShelf3);

        video4.AddComment(commentMTG1);
        video4.AddComment(commentMTG2);
        video4.AddComment(commentMTG3);
        
        Console.Clear();

        video1.DisplayAll();
        video2.DisplayAll();
        video3.DisplayAll();
        video4.DisplayAll();
    }
}