//Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each
// one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

//Then, have your program iterate through the list of videos and for each one, display the title, author, length, number
// of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video
// in the list.


using System;
using system.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Bread Making Tutorial", "@Jim Bean", 180);
        Video video2 = new Video("MAPHRA-Doomed", "@MAPHRAMusic", 266);
        Video video3 = new Video("DIY Garage Shelf", "@Greg's Garage", 1440);
        Video video4 = new Video("New Set Just Dropped", "@GameKinghts", 3120);
       
        Comment comment1 = new Comment("Sam Owens", "Video was very instructive, can't wait to make bread!");
        Comment comment2 = new Comment("Billy Bob", "She has such an extraordinary voice!");
        Comment comment3 = new Comment("Bob's Basement", "I think I could make a much better shelf in my basement!");
        Comment comment4 = new Comment("MTG Nerd", "Can't wait to get this set, it looks so cool!");

        video1.AddComment(comment1);
        video2.AddComment(comment2);
        video3.AddComment(comment3);
        video4.AddComment(comment4);
        
        Console.writeline(video1);
    }
}