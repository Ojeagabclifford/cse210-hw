using System;

//  creating a resume class to store the resume information

public class Resume
{
    // creating memebrs variables for name, and list of jobs job
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // creating a function to display the resume information
    // public
     public void DisplayResumeInformation()
     {
        Console.WriteLine($"Resume of {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            
            job.DisplayJobInformation();
        }
    }


}