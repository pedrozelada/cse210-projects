public class HabitManager
{
    private List<Habit> _habits;

    public HabitManager()
    {
        _habits = new List<Habit> ();

    }

    public void Start()
    {
        bool quit = false;
        Console.WriteLine("This program will help you establish healthy habits.");
        while (!quit) 
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New Habit\n  2. List Habits\n  3. Save Habits\n  4. Load Habits\n  5. Track Habits\n  6. Quit");
            Console.Write("Please Select a choise from the menu: ");
            string user_respons = Console.ReadLine();
            
            //Activity activity = new Activity();
            Console.Clear();
            switch (user_respons) 
            {
                case "1": { 
                    CreateHabit();
                    break;
                };
                case "2": {
                    ListHabits();
                    break;
                };
                case "3": {
                    SaveHabits();
                    break;
                };
                case "4": {
                    LoadHabits();
                    break;
                };
                case "5": {
                    TrackHabits();
                    break;
                };
                
                
                case "6": {
                    quit = true;
                    break;
                };

            }
        }
    }

    public void ListHabits()
    {
         int i = 1;
        Console.WriteLine("The goals are: ");
        foreach (Habit habit in _habits)
        {
            Console.WriteLine($"{i}. {habit.ShowHabbit()}");
            i++;
        }

    }

    public void CreateHabit()
    {
        Console.WriteLine("The types of Habits are: ");
        Console.WriteLine(" 1. Healthy Diet\n  2. Exercise\n  3. Prioritaze Sleep\n  4. Go Offline\n  5. Learn Something New\n  6. Bad Habits");
        Console.Write("Which type of Habit would you like to create? ");
        string usergoal = Console.ReadLine();  
        if (usergoal == "1")
        {
            optionHabits();
            string type = Console.ReadLine();
            if (type == "1")
            {
                HealthyDiet healthyDiet = new HealthyDiet();
                healthyDiet.GenerateRandom();
                _habits.Add(healthyDiet);
            }
            else if (type == "2")
            {
                HealthyDiet healthyDiet = new HealthyDiet();
                healthyDiet.SelectOne();
                _habits.Add(healthyDiet);

            }
            else if (type == "3")
            {
                Console.Write("What is the name of the habit ");
                string name = Console.ReadLine();
                Console.Write("what is the description of the habit ");
                string description = Console.ReadLine();
                HealthyDiet healthyDiet = new HealthyDiet(name, description,3);
                _habits.Add(healthyDiet);
            }


            
        }           

    }

    public void optionHabits()
    {
        Console.WriteLine("Would you like to ");
        Console.WriteLine(" 1. Generate Random Habit\n 2. Select a habit from the list\n 3. Create your own Habit");
    }

    public void SaveHabits()
    {

    }
    
    public void LoadHabits()
    {

    }

    public void TrackHabits()
    {

    }

    public void SupportMessages()
    {

    }

    public void CongratulatoryMessages()
    {

    }

    public void ShowAnimation()
    {

    }
}