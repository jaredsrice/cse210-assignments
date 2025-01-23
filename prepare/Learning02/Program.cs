using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1. _startYear = 2005;
        job1. _endYear = 2017;

         Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Hardware Engineer";
        job2. _startYear = 2006;
        job2. _endYear = 2018;

        Resume resume = new Resume(); 
        resume._name = "Shrek Ogre";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
    }
}

