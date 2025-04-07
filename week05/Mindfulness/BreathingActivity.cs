

public class BreathingActivity: Activity
{

    public BreathingActivity() : base()
    {
        _name ="Breathing Activity";
        _description= "This activity help you relax by walking througg breating in and out slowly. clear your mind and focus on your breathing.";

    }


    public void Run()
    {
         DisplayStartingMessage();
         int check = _duration;

        DateTime dateTime = DateTime.Now;
        DateTime furtueDateTime = dateTime.AddSeconds(check);
        // ShowSpinner(4);

        while(DateTime.Now <furtueDateTime)
        {
         

            Console.Write($"breathe in...");
             ShowCountDown(3);
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();

           
           
            
        }

        DisplayEndingMessage();
        
        
    }
}