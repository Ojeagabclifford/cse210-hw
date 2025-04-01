using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        MathAssignment mathAssignment = new MathAssignment("Ojeaga Clifford","Fractions","Section 7.3","Problems 8-19");
      
 


        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II by Mary Waters","Ojeaga Clifford","European History");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

        
    }
}