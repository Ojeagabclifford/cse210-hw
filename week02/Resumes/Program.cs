using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // creating a job object
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._companyName = "Microsoft";
        job1._startDate = "2021";
        job1._endDate = "2023";

        job1.DisplayJobInformation();

        // creating another instance of the job object
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Google";
        job2._startDate = "2023";
        job2._endDate = "2025";

        // Console.WriteLine(job2._companyName);

        job2.DisplayJobInformation();

        // creating a resume object
        // this resume contain a list of jobs and the name of the person who own the resume

       Resume resume = new Resume();
    //    creating an instance of the resume object

       resume._name = "Ojeaga B Clifford";
    //    adding the job object to the list of jobs in the resume object
       resume._jobs.Add(job1);
       resume._jobs.Add(job2);
    //   displaying the resume information
       resume.DisplayResumeInformation();

       


    }
}