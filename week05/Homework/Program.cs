using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Owens", "Trial & Error");

        MathAssignment mathAssignment = new MathAssignment("Joyze Owens", "Keeping A Happy Home", "1", "1-99");

        Writing writing = new Writing("Jaxson Owens", "Psycological Warfare", "The Great War On Dad's Sanity");
        
        Console.Clear();
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}