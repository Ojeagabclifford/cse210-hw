using System;

class Program
{
    
    // Working on a program that display a name of a person and it favour number and give the number again an integer value
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

           
        // stroing the user name in a variable
        string userName = PromptUserName();
        // // storing the user number in a variable
        int userNumber = PromptUserNumber();
         // storing the square number in a variable
        int squareNumber = SquareNumber(userNumber);

        // welcome message
        DisplayWelcomeMessage();
         DisplayResult(userName, userNumber, squareNumber);
    }

    // function to display welcome message
    static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
           
        }
    // creating the funttion to ask user their name
        static string PromptUserName()
            {
                // promting a user for his name and number
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            return name;

            }

                // gettting the number from the user
            static int PromptUserNumber(){
                Console.Write("What is your favourite number: ");
                int number = int.Parse(Console.ReadLine());
                return number;
            }
        
        //  creating a function that get user number and reture squre of thst number
        static int SquareNumber(int number)
        {
            return number * number;

        }

            // creating a function to display the result
            static void DisplayResult(string name, int number, int squareNumber)
        {
            Console.WriteLine($"Hello {name}, your favourite number is {number} and the square of {number} is {squareNumber}");
        }
}