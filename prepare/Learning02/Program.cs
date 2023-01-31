using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Relocite Martin";
        job1._startYear = 2008;
        job1._endYear = 2028;

        job1.Display();

        Job job2 = new Job();

        job2._jobTitle = "Manager/CEO";
        job2._company = "Chimeratech";
        job2._startYear = 2018;
        job2._endYear = 2022;

        job2.Display();

        Resume resume = new Resume();

        resume._name = "Howard";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}