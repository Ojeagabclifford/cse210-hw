

public class ReflectingActivity : Activity
{

    protected List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
     }
    ;
     protected List<string> _questions = new List<string>()
     {
           "Why was this experience meaningful to you?",  
            "Have you ever done anything like this before?",  
            "How did you get started?",  
            "How did you feel when it was complete?",  
            "What made this time different than other times when you were not as successful?",  
            "What is your favorite thing about this experience?",  
            "What could you learn from this experience that applies to other situations?",  
            "What did you learn about yourself through this experience?",  
            "How can you keep this experience in mind in the future?"  
     };

     public ReflectingActivity() :base()
     {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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
         DisplayPrompt();

         Console.Write("When you have something in mind, press enter to continue. ");
         Console.ReadLine();

         Console.WriteLine("Now ponder on each of the following questions as they related to this experince.");
         Console.Write("You may begin in: ");
         ShowCountDown(3);

          while(DateTime.Now <furtueDateTime){
             DisplayQuestions();
             ShowSpinner(5);
            Console.WriteLine();
         
         }

        




           

           
           
            
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


          public string GetRamdomQuestion()
     {
         Random random = new Random();
        // create a random index to select a random prompt
        int index = random.Next(_questions.Count);
        // create a return statement to return the random prompt
        return _questions[index];
     }

     public void DisplayPrompt()
     {
        Console.WriteLine("Consider the following Prompt");
        Console.WriteLine();
        Console.WriteLine($"----{GetRamdomPrompt()}----");
         Console.WriteLine();
     }

     public void DisplayQuestions()
     {
        Console.Write($">{GetRamdomQuestion()}");
        
        

        

     }


}