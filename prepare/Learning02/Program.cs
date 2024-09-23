using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Engineer";
        job1._jobCompany = "Apple";
        job1._startYear = 2012;
        job1._endYear = 2018;

        

        Job job2 = new Job();
        job2._jobTitle = "Electrical Engineering";
        job2._jobCompany = "Amazon";
        job2._startYear = 2012;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        myResume._name = ($"{name}");
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayNames();
    }
}