using System;

// creating a class to store the job information
public class Job{
//   creating memebers vaiables for title of the job, company name, start date and end date

    public string _jobTitle;
    public string _companyName;
    public string _startDate;
    public string _endDate;

    // creating a function to display the job information
    public void DisplayJobInformation(){

        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate}-{_endDate}");
        

    }
}