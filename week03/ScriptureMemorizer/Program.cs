using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        

        while(true)
        {
            Reference reference = new Reference("Matht",2,2);

        string text = "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God. And the peace of God, which transcends all understanding, will guard your hearts and your minds in Christ Jesus.";
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
        Scripture scripture = new Scripture(reference,text);
        scripture.HideRandomWords(1);

        scripture.Displaytext();
        
        
        }
       


        
    }
}