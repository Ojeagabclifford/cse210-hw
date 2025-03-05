using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // Writting and display my code which will display first name, last name and first name.
        

        // Giving a user prompt What is your Frist Name?
        Console.Write("What is your Frist Name? ");
        // getting the user first name from the console
        string fName = Console.ReadLine();

        // Giving a user prompt What is your Last Name?
        Console.Write("What is your Last Name? ");

        // getting the user last name from the console
        string lName = Console.ReadLine();
        
        // displaying the user name to the console 
        Console.WriteLine($"your name is {fName},{lName} {fName}.");




    }
}