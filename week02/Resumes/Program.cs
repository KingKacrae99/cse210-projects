using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "microsoft";
        job1._jobTitle ="Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Open AI";
        job2._jobTitle = "AI Developer";
        job2._startYear = 2025;
        job2._endYear = 2027;

        // Resume instance
        Resume myResume = new Resume();
        myResume._name = "King Kacrae";
        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume.Display();
        //job2.DisplayJobDetails();
    }
}