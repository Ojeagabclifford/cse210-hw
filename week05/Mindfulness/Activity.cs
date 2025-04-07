

public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration =0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");

        Console.WriteLine();
        Console.WriteLine(_description);
        Thread.Sleep(1000);
        
        
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");

        int timefriam = int.Parse(Console.ReadLine());
        _duration = timefriam;
         Console.WriteLine();

        Console.WriteLine("Getting ready...");
        ShowSpinner(4);
        



        
    }

   
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
         ShowSpinner(4);
        Console.WriteLine($"Weldone you have completed another {_duration} secounds of {_name}.");

        

    }

    public void ShowSpinner(int secounds)
    {
        // Console.WriteLine();
       
       List<string> items = new List<string>();
        
           items.Add("|");
            items.Add("/");
            items.Add("-");
           items.Add( "\\");
           items.Add( "|");
           items.Add( "/");
           items.Add( "-");
           items.Add( "\\");
           
       
    

       


     DateTime dateTime = DateTime.Now;
        DateTime furtueDateTime = dateTime.AddSeconds(secounds);

        int i = 0;

        while(DateTime.Now <furtueDateTime)
        {
            String item = items[i];

            Console.Write(item);
             Thread.Sleep(1000);
            Console.Write("\b \b");
           

            i++;

            if(i >= items.Count)
            {
                i=0;
            }

            
        }
        
    }

    public void ShowCountDown(int secounds)
    {

        for(int i =secounds; i>0; i-- )
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        Console.WriteLine();
        

    }



}