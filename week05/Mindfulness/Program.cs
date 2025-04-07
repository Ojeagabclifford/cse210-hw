using System;

   // Please greader please note i added another activity the grounding activity to the activity to show creativity 
class Program
{
    static void Main(string[] args)
    {
        // Please greader please note i added another activity the grounding activity to the activity to show creativity 
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice;


       do {

   
        Console.WriteLine("Menu Options:");

        Console.WriteLine("   1. Start breathering activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Start grounding activity");

        Console.WriteLine("   5. Quit");
        Console.Write("Select a choice from the menu: ");

        choice = int.Parse(Console.ReadLine());

        if(choice == 1){

       
             BreathingActivity breathing = new BreathingActivity();
             breathing.Run(); 
             }
           

           else if(choice ==2){
            ReflectingActivity reflectingActivity = new ReflectingActivity();

            reflectingActivity.Run();

           }
            
            
            else if(choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();

            listingActivity.Run();

            }
            else if (choice==4){
                GroundingActivity groundingActivity = new GroundingActivity();
                groundingActivity.Run();
            }


        }while(choice !=5);
          




       


       

       


    }
}