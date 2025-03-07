using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        // creating a program that store a list of numbers and display it total sum and average find the maximum or largest number in the list.

        // creating an object of a new list to store the user numbers with data type is int

        List<int> numbers = new List<int>();

        int stopNumbers;

        //  creating a while loop to stop when every a user type O
        Console.WriteLine("Enter a list of number, type ) when finished.");

        do
        {
            // creating a prompt 
            Console.Write("Enter number: ");
            
            stopNumbers = int.Parse(Console.ReadLine());
            numbers.Add(stopNumbers);
            if(stopNumbers == 0)
            {
                // this will remove the number 0 in my list 
                numbers.Remove(0);
            }
            
            
        }
        while (stopNumbers != 0 );
        numbers.Sort();

        

        //  creating some variable to stror my totalnumber averagenumber
        int totalNumbers = 0;
        float averageNumber = 0;
        // this variable we help out in checking the number maximu number in the list
         int maxNumber =0;
            double closeToZero = 0;


        // creating a forech loop to loop through all the items in the list of number
        foreach(int number in numbers)
        {

            // calculating the total number to gether 
            totalNumbers += number;
            // getting the averageNumber by diving the totalnumbers with the total numbers int the list
            averageNumber = ((float)totalNumbers) / numbers.Count;
            // closeToZero = Math.Abs(closeToZero);
            // closeToZero = double.MaxValue;

           

          
            // creating a conditional statement to check the highs number
            if (maxNumber < number)
            {
                maxNumber = number;

            }

             if( number > 0 && number < maxNumber)    
            {
                closeToZero = number;
            }
            // int highest = number.Sort;
            
            
           

            // Console.WriteLine(number);

        }
        // Console.WriteLine(numbers.First());
            
         // displaying the total numbers and the average
            Console.WriteLine($"The sum is: {totalNumbers}");
            Console.WriteLine($"the average Number is: {averageNumber}");
            Console.WriteLine($"The largest number is:{maxNumber}");
            Console.WriteLine($"The smallest positive number is:{closeToZero}");
            foreach(int number in numbers){
                Console.WriteLine(number);
            }

        


        // prompting the user to add to the number list



    }
}