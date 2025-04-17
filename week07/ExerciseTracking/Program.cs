using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        DateTime dateTime = new DateTime(2025, 04, 16);
        ActivityList activityList = new ActivityList();


        SwimmingActivity swimmingActivity = new SwimmingActivity(2,30,dateTime);
        activityList.AddActivity(swimmingActivity);
        
        RunningActivity runningActivity = new RunningActivity(4.8,30,dateTime);
        activityList.AddActivity(runningActivity);

    

        CyclingActivity cyclingActivity = new CyclingActivity(3.3,30,dateTime);
       activityList.AddActivity(cyclingActivity);

       activityList.DisplayDetials();
        
    }
}