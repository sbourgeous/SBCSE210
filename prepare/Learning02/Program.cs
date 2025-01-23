using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Lanscaper";
        job1._company = "Yellowstone Bear World";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Customer Service Representative";
        job2._company = "The Occasions Group";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Samuel Bourgeous";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}