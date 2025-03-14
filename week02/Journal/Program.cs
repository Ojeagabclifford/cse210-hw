using System;
// In my program to exced the program requrement i save the file as csv file or
//  as a text file accodring to the user input

class Program
{
    static void Main(string[] args)
    {

        
        Console.WriteLine("Hello World! This is the Journal Project.");
        // create a journal object
        Journal journal = new Journal();
        
        // create a loop to display the menu
        while(true){
    
        Console.WriteLine("1.Add Entry");
        Console.WriteLine("2.Display Entry");
        Console.WriteLine("3.Save to file");
        Console.WriteLine("4.Load from file");
        Console.WriteLine("5.Exit");
        Console.Write("Enter your choice: ");

        // get the user input for their menu choice
        string choice = Console.ReadLine();
//    create a if statement to call the functions based on the user input
        if (choice == "1")
        {
            AddEntry(journal);
        }
        else if (choice == "2")
        {
            DisplayEntrys(journal);
        }
        else if (choice == "3")
        {
            SaveToFiles(journal);
        }
        else if (choice == "4")
        {
            LoadFromFiles(journal);
        }
        else if (choice == "5")
        {
            Environment.Exit(0);
            
        }
        else
        {
            Console.WriteLine("Invalid choice");
            
        }    
    }
// create a function to add entry to the journal
        static void AddEntry(Journal journal){
        PromptGenerator promptGenerator = new PromptGenerator();
        string promt = promptGenerator.GeneratePrompt();

        DateTime time = DateTime.Now;
        string date = time.ToString("MM/dd/yyyy");
        
        Entry entry = new Entry();
        entry._date = date;
        entry._prompt = promt;
        Console.Write($"{promt} ");

        string entryText = Console.ReadLine();
        entry._entryText = entryText;

        // Journal journal = new Journal();
        journal.addEntry(entry);

        }
//   create a function to display the entrys in the journal
        static void DisplayEntrys(Journal journal){
            // Journal journal = new Journal();
            journal.DisplayEntry();
        }
// create a function to save the entrys to a file
        static void SaveToFiles(Journal journal)
        {
            //Journal journal = new Journal();
            Console.Write("Enter the file name: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
        }
// create a function to load the entrys from a file
        static void LoadFromFiles(Journal journal)
        {
            //Journal journal = new Journal();
            Console.Write("Enter the file name:");
            string filename = Console.ReadLine();
            journal.Loadfromfile(filename);
            Console.Write("File loaded successfully");
        }

        

    }
}