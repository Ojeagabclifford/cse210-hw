using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // building a program that ask the user their grade numer and displaying to them if they have pass or not
        //  Asking user for a propmt
        string gradeLetter ="";
        Console.Write("What is your grade Number? ");
        // gettng the user respone and saveing it in a variable name userGrade
        string userGrade = Console.ReadLine();
        // converting the varible value to string to int 
        int userGradeNumber = int.Parse(userGrade);

        // getting the user last digit number
        int lastDigit = userGradeNumber % 10;
        // setting the variable to put my grade sign
        string latterSign = "";

        
        // starting up the conditional statement to see if the user input hads pass

        if (userGradeNumber >= 90)
        {
            gradeLetter ="A";
        }
        else if (userGradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (userGradeNumber >= 70)
        {
           gradeLetter = "C";
        }
        else if (userGradeNumber >= 60)
        {
           gradeLetter ="D";
        }
       else if (userGradeNumber < 60)
        {
           gradeLetter = "F";
        }
        else 
        {
           Console.WriteLine("You have enter the wrong grade");
        }
    //  setting the condition to get the sign
       if (lastDigit >= 7 || userGradeNumber == 100)
       {
        latterSign = "+";

       }
       else if (lastDigit >=3)
       {
        latterSign = "-";
       }
       else if ( userGradeNumber < 60)
       {
        latterSign ="";
       }
       
        
        // display the grade letter in the console
        Console.WriteLine(gradeLetter + latterSign);
    }
}