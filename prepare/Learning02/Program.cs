using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Senior Solutions Architect";
        job1._company = "IBM";
        job1._startYear = 2009;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Staf Integration Engineer";
        job2._company = "FactoryFix";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Anderson Nascimento";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();
        myResume.DisplayResumeDetails();
    }
}