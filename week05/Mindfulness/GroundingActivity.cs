
using System;
using System.Collections.Generic;
using System.IO;

public class GroundingActivity : Activity
{
 

    

    protected List<string> _prompts =new List<string>(){
            "Name five things you see around you.",
            "Name four things you feel (e.g., the chair you are sitting on).",
            "Name three things you hear.",
            "Name two things you smell.",
            "Name one thing you taste or imagine tasting."

    };

   public GroundingActivity() : base()
   {
    _name ="Grounding Activity";
    _description = "This Grounding Activity will help the you to engage in senses and reconnect with the present moment. ";
   }


    public void Run()
     {
         DisplayStartingMessage();
         int check = _duration;

        DateTime dateTime = DateTime.Now;
        DateTime furtueDateTime = dateTime.AddSeconds(check);
        ShowSpinner(4);
       

        while(DateTime.Now <furtueDateTime)
        {
      

         Console.WriteLine("ponder on each of the following questions as they related to this experince.");
         Console.Write("You may begin in: ");
         ShowCountDown(3);
         

        Console.WriteLine("Consider the following Prompt ");
         
        while(DateTime.Now <furtueDateTime){
            
           
            DisplayPrompt();}

           

           
           
            
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



     public void DisplayPrompt()
     {  string UserRespones;
        Console.WriteLine($"{GetRamdomPrompt()}---, Type (next) when finsh");
        do{
            UserRespones = Console.ReadLine();
            //  userResponsenList.Add($"{GetRamdomPrompt}:")
        }while(UserRespones != "next" );
        
         Console.WriteLine();
     }






}