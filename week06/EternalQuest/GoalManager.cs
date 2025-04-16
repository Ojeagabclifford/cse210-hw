
using System.Drawing;

public class GoalManager
{

    private List<Goal> _goals = new List<Goal>();
    private List<Goal> _goalsRevert = new List<Goal>();

    private int _score;
     private int _scoreRevert;


    public GoalManager(){

    }
    public void Start()
    {
       
        int choice = 0;
    
       

       do {
        try {
      
       DisplayPlayerinfo();
       

   
        Console.WriteLine("Menu Options:");

        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");

        Console.WriteLine("   5. Record EVent");
        Console.WriteLine("   6. Clear goals list");
        Console.WriteLine("   7. Revert the list");
         Console.WriteLine("  8. Quit");
        Console.Write("Select a choice from the menu: ");
         
        choice = int.Parse(Console.ReadLine());
   

   
         switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDtails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                ClearList();
                break;
                case 7:
                RevertList();
                break;
                case 8:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
               }
   catch (FormatException ex)
   {
    Console.WriteLine(ex.Message);
   }


        }while(choice !=8);
     
          
        




    }

    
    public void DisplayPlayerinfo()
    {
         Console.WriteLine($"You have {_score} points");
         Console.WriteLine();

    }

    public void ListGoalNames()
    {      
        int i = 1;
         foreach(Goal goal in _goals)
            {
                Console.WriteLine($"{i}.{goal.GetName()}");

                i++;
            }
    }
    
     public void ListGoalDtails()
     {
        Console.WriteLine();
        Console.WriteLine("The goals are:");
           int i=1;
         foreach(Goal goal in _goals)
            {
                Console.WriteLine($"{i}. {goal.GetDetailsString()}");
                i++;
            }
            Console.WriteLine();

     }
      public void CreateGoal()
      {

        Console.WriteLine("The types of Goals are:");
            Console.WriteLine("   1. Simple Goal");
            Console.WriteLine("   2. Eternal Goals");
            Console.WriteLine("   3. CheckList Goal");
            Console.WriteLine("   4. Nagative Goal");
            Console.Write("Which type of gaol would you like to create? ");
            int choice = int.Parse(Console.ReadLine());
        try{

       
            if(choice == 1){
                try{

                Console.Write("What is the name your of goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string point = Console.ReadLine();
                SimpleGoal simpleGoal = new SimpleGoal(name,description,point);

                _goals.Add(simpleGoal);


            }
                   catch(Exception ex)
            {
                Console.WriteLine(ex);
            }}

            else if(choice == 2){
                try {

                

                Console.Write("What is the name your of goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string point = Console.ReadLine();
                EternalGoal eternalGoal = new EternalGoal(name,description,point);

                _goals.Add(eternalGoal);


            }       catch(Exception ex)
            {
                Console.WriteLine(ex);
            }}
        
            
              else if(choice == 3){
                try{
                

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string point = Console.ReadLine();
                Console.Write("How many times does this goal need to accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("WHat is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                
                ChechListGoal chechListGoal = new ChechListGoal(name,description,point,target,bonus);

                _goals.Add(chechListGoal);}
                  catch(Exception ex)
            {
                Console.WriteLine(ex);
            }


            }
          
            else if (choice == 4)
            {
                try{
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points that will be remove when you did this nagative goal? ");
                string point1 = Console.ReadLine();
                string point= $"-{point1}";

                NegativeGoals  negativeGoals = new NegativeGoals(name,description,point);

                _goals.Add(negativeGoals);



            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            }
            else
            {
                Console.WriteLine("wrong typo");
            } }
            catch (FormatException ex)
             {
            Console.WriteLine($"Invalid input format. Please enter the correct data type.{ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message} ");
        }
            

      }
      
       public void RecordEvent()
      { 

        Console.WriteLine("The goals Are:");
        ListGoalNames();

        Console.Write("Which goal will you like to accomplish? ");

       // int goalSelected = int.Parse(Console.ReadLine());

        if(int.TryParse(Console.ReadLine(),out int goalSelected) && goalSelected > 0 && goalSelected <= _goals.Count )
        {
            
          Goal goal = _goals[goalSelected -1];

          goal.RecordEvent();
         

          
           
         _score += int.Parse(goal.GetPoints());
         Console.WriteLine();

         Console.WriteLine($"You now have {_score} points");
         Console.WriteLine();
            
        
        }
        






      }

       public void SaveGoals()
      {
         try{
    //   create a function to save the entrys to a file
    // create a if statement to check if the file is a csv file
    Console.Write("What is the name of the file? ");
    string fileName = Console.ReadLine();
      
        using  StreamWriter writer = new StreamWriter($"{fileName}.txt");
        writer.WriteLine(_score);
        {foreach(Goal goal in _goals){
            
            writer.WriteLine($"{goal.GetStringRepresentation()}");
        }}
        Console.WriteLine("Goal hads been save");
        
        }
        

            catch (FormatException ex)
        {
            Console.WriteLine($"Invalid input format. Please enter the correct data type.{ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message} ");
        }}

        
        // create a if statement to check if the file is a txt file
     
       
    


      

       public void LoadGoals()
      { try{
        _goals.Clear();
         Console.Write("What is the name of the file you want to Load from? ");
              string fileName = Console.ReadLine();
        using StreamReader reader = new StreamReader($"{fileName}.txt");
        string socre = reader.ReadLine();
       

        _score= int.Parse(socre);

            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    
                    string[] parts = line.Split(':');
                    string goalName = parts[0];
                    string[] getItems = parts[1].Split(',');

                    
        

         
                    if(goalName =="SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(getItems[0],getItems[1],getItems[2]);
                        simpleGoal.SetComplete(getItems[3]);
                        _goals.Add(simpleGoal);
                    }


                    else if(goalName =="EnternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(getItems[0],getItems[1],getItems[2]);
                        _goals.Add(eternalGoal);
                    }

                    else if(goalName == "ChechListGoal")
                    {
                        ChechListGoal chechListGoal = new ChechListGoal(getItems[0],getItems[1],getItems[2],int.Parse(getItems[4]),int.Parse(getItems[3]));
                        chechListGoal.SetAmountCompleted(getItems[5]);
                        _goals.Add(chechListGoal);


                    }
                      else if(goalName == "NegativeGoals")
                    {
                        NegativeGoals  negativeGoals = new NegativeGoals(getItems[0],getItems[1],getItems[2]);
                        
                        _goals.Add(negativeGoals);


                    }
                    // Goal goal = new Goal(,parts[1]);
                    // entry._date = parts[0];
                    // entry._prompt = parts[1];
                    // entry._entryText = parts[2];
                    // _enteries.Add(entry);

        
                
        }}
        
                }

            catch (FormatException ex)
        {
            Console.WriteLine($"Invalid input format. Please enter the correct data type.{ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message} ");
        }}
        public void ClearList()
        {
           _goalsRevert.Clear();
           _scoreRevert =+ _score;
            foreach(Goal goal in _goals)
            {
                _goalsRevert.Add(goal);
            }
            _goals.Clear();
            _score = 0;
        }

        public void RevertList()
        {
             foreach(Goal goal in _goalsRevert)
            {
                _goals.Add(goal);
            }

         _score =+ _scoreRevert;
        }
        


      }




