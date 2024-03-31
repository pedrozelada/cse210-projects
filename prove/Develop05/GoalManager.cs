
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    
    public GoalManager()
    {   
        
        _goals = new List<Goal> ();

    }

    public void Start()
    {
        bool quit = false;
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        while (!quit) 
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {_score} points\n");
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choise from the menu: ");
            string user_respons = Console.ReadLine();
            
            //Activity activity = new Activity();
            Console.Clear();
            switch (user_respons) 
            {
                case "1": { 
                    CreateGoal();
                    break;
                };
                case "2": {
                    ListGoalDetails();
                    break;
                };
                case "3": {
                    SaveGoals();
                    break;
                };
                case "4": {
                    LoadGoals();
                    break;
                };
                case "5": {
                    RecordEvent();
                    break;
                };
                case "6": {
                    quit = true;
                    break;
                };

            }
        }

    } 

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You now have {_score} points.");
    }

    public void ListGoalDetails()
    {
        int i = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string usergoal = Console.ReadLine();            

        if (usergoal == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(name, description, int.Parse(points));
            _goals.Add(simpleGoal);
        } 
        else if (usergoal == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name, description, int.Parse(points));
            _goals.Add(eternalGoal);
        }
        if (usergoal == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal needs to be accomplished for a bonus? ");
            string target = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, int.Parse(points), int.Parse(target), int.Parse(bonus));
            _goals.Add(checklistGoal);
        }
        


    }

    public void RecordEvent()
    {
        int i = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
        Console.Write("Wich goal did you accomplish? ");
        string selectionIndex= Console.ReadLine();
        Goal goalevent = _goals[int.Parse(selectionIndex) -1];
        goalevent.RecordEvent();
        _score += goalevent.GetPoints();
        DisplayPlayerInfo();
        

    }

    public  void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename= Console.ReadLine();

        using (StreamWriter outPutFile = new StreamWriter(filename)) 
        {
            outPutFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outPutFile.WriteLine(goal.GetStringRepresentation());
            }       
        }


    }

    public  void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename= Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
         _score = int.Parse(lines[0]);
         for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string nameObject = parts[0];
            string values = parts[1];
            if ( nameObject == "SimpleGoal")
            {
                string[] partsGoal = values.Split(",");
                string name = partsGoal[0];
                string description = partsGoal[1];
                string points = partsGoal[2];
                string completed = partsGoal[3];
                SimpleGoal simpleGoal = new SimpleGoal(name, description, int.Parse(points), bool.Parse(completed));
                _goals.Add(simpleGoal);
            }
            else if(nameObject == "EternalGoal")
            {
                string[] partsGoal = values.Split(",");
                string name = partsGoal[0];
                string description = partsGoal[1];
                string points = partsGoal[2];
                EternalGoal eternalGoal = new EternalGoal(name, description, int.Parse(points));
                _goals.Add(eternalGoal);
            }
            else if(nameObject == "ChecklistGoal")
            {
                string[] partsGoal = values.Split(",");
                string name = partsGoal[0];
                string description = partsGoal[1];
                string points = partsGoal[2];
                string bonus = partsGoal[3];
                string target = partsGoal[4];
                string amount = partsGoal[5];
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, int.Parse(points), int.Parse(target), int.Parse(bonus), int.Parse(amount));
                _goals.Add(checklistGoal);
            }

        }
    }
}