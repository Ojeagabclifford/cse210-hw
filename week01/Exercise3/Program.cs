using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
       
  
       

       string respone = "";
       

        // adding a while loops to amke to run as long as the user didnot get it
        do
        {
            
            // setting a variable to put the count of the guess
            int count = 0;

                //   creating a variable to store my respose
                    string guessResuilt ="";
                    int magicNumber;
            
            
            //    string userGuessNumberText = Console.ReadLine();
            //   userGuessNumber = int.Parse(userGuessNumberText);
            int userGuessNumber =0 ;
    //    getting random number for my magic number
        Random randomGenerator = new Random();

        magicNumber = randomGenerator.Next(1,100);

       while (userGuessNumber != magicNumber)
       {
        Console.Write("What is your guess? ");
            string userGuessNumberText = Console.ReadLine();
            userGuessNumber = int.Parse(userGuessNumberText);
        
            
                // conditional statement to check the magicNumber with userGussNumebr
            
            {
                if (userGuessNumber > magicNumber)
                {
                guessResuilt = "higher";
                }
                else if (userGuessNumber< magicNumber)
                {
                    guessResuilt ="lower";
                }
                else
                {
                    guessResuilt = "you guess it!";
                    
                }
                count += 1;

                // displaying the resuilt
                Console.WriteLine(guessResuilt);
            }
                
        }  
        Console.WriteLine($"This is your gust count: {count}");

            
            

        //     asking the user if they want to continue
           Console.Write("Do you want to continue? ");
            respone = Console.ReadLine();
            
        }
         while (respone.ToLower() == "yes" );
           

         
        }
}