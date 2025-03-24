using System;


// For me to Excel requirement i added a program that will get RandomScitures from a file and then display it.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string doYou = "";


        while (doYou != "no"){

        
       
       
        string quite ="";
         
        GetRandomScritures getRandomScritures = new GetRandomScritures();
        getRandomScritures.GetreferenNmae();
        (Reference reference, string scriptureText) = getRandomScritures.display();

        string text = $"{scriptureText}.";

       
        Scripture scripture = new Scripture(reference,scriptureText);
          

        while(quite != "quit")
        {
             scripture.HideRandomWords(1);
        Console.Clear();
       Console.WriteLine("Press any key to continue");
        
        
   

        scripture.Displaytext();
        bool completelyHidden = scripture.IsCompletelyHidden();
        Console.Write("Type quit to quit or any key to continue ");
        quite = Console.ReadLine();
        
        if (completelyHidden)
        {
            Console.WriteLine("Congratulations! You have successfully memorized the scripture!");
            quite = "quit";
        
        }
        
        }

        Console.Write("Do you want to load another scriture? ");
        doYou = Console.ReadLine();
        }


        
    }
}