using System;


class Program
{
    static void Main(string[] args)
    {
    
    Job job1 = new Job();
    Job job2 = new Job();

    job1._company = "(Microsoft)";
    job1._jobTitle = "Software Engineer";
    job1._startYear = 2019;
    job1._endYear = 2022;

    job2._company = "(Apple)";
    job2._jobTitle = "Manager";
    job2._startYear = 2022;
    job2._endYear = 2023;

  

    Resume myResume = new Resume();
    myResume._name = "Allison Rose";
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.Display();
    }
    
}
//Create a program that contains 2 classes one for Job and one for the Resume itself.

//Create Class Job. 
//Responsibilities are to: 
//Keep track of the company, job title, start year and end year.
//Behaviors are to:
//Display job information in the format "Job Title (Company) StartYear-EndYear"



//Create Class Resume.
//Responsibilities are to:
//Keep track of the person's name and a list of their jobs.
//Behaviors are to:
//Display the resume, which shows the name first, followed by displaying one on of the jobs.

