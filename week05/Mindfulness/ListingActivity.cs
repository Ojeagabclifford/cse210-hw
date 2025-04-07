

public class ListingActivity: Activity
{
   
    protected List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
     }
    ;

    protected int _count;

   public  ListingActivity(): base()
   {
    _name ="Listing Activity";
    _description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

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
         

         Console.WriteLine("List as many responses you can to the following prompt:");
         Console.WriteLine($"----{GetRamdomPrompt()}----");
         Console.Write("You may begin in:"); ShowCountDown(5);
          while(DateTime.Now <furtueDateTime)
           {GetListFromUser();
           }
            Console.WriteLine($"You Listed {_count} items");

            
        }
       

        DisplayEndingMessage();

     }

   public string GetRamdomPrompt()
     {
         Random random = new Random();
        // create a random index to select a random prompt
        int index = random.Next(_prompts.Count);
        // create a return statement to return the random prompt
        return _prompts[index];
     }

    


     public List<string> GetListFromUser()
     {
        List<string> items = new List<string>();

        Console.Write(">");

        string input= Console.ReadLine();
        

            items.Add(input);
            
       


        
        _count += items.Count();

        

        return items;

     }
}