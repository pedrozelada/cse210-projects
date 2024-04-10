using System.Formats.Tar;

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
                    ListHabitsTrack();
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
        Console.WriteLine("The habits are: ");
        foreach (Habit habit in _habits)
        {
            Console.WriteLine($"{i}. {habit.ShowHabbit()}");
            i++;
        }

    }

    public void ListHabitsTrack()
    {
        int i = 1;
        Console.WriteLine("The habits are: ");
        foreach (Habit habit in _habits)
        {
            Console.WriteLine($"{i}. {habit.ShowHabbitTrack()}");
            i++;
        }

    }

    public void CreateHabit()
    {
        Console.WriteLine("The types of Habits are: ");
        Console.WriteLine("  1. Healthy Diet\n  2. Exercise\n  3. Prioritaze Sleep\n  4. Go Offline\n  5. Learn Something New\n  6. Bad Habits");
        Console.Write("Which type of Habit would you like to create? ");
        string usergoal = Console.ReadLine(); 
        // Healthy Diet 
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

        // Exercise Habit
        else if (usergoal == "2")
        {
            optionHabits();
            string type = Console.ReadLine();
            if (type == "1")
            {
                Exercise exercise = new Exercise();
                exercise.GenerateRandom();
                _habits.Add(exercise);
            }
            else if (type == "2")
            {
                Exercise exercise = new Exercise();
                exercise.SelectOne();
                _habits.Add(exercise);

            }
            else if (type == "3")
            {
                Console.Write("What is the name of the habit ");
                string name = Console.ReadLine();
                Console.Write("what is the description of the habit ");
                string description = Console.ReadLine();
                Exercise exercise = new Exercise(name, description);
                _habits.Add(exercise);
            }
        }

        //Sleep Habit
        else if (usergoal == "3")
        {
            optionHabits();
            string type = Console.ReadLine();
            if (type == "1")
            {
                PrioritazeSleep prioritazeSleep = new PrioritazeSleep();
                prioritazeSleep.GenerateRandom();
                _habits.Add(prioritazeSleep);
            }
            else if (type == "2")
            {
                PrioritazeSleep prioritazeSleep = new PrioritazeSleep();
                prioritazeSleep.SelectOne();
                _habits.Add(prioritazeSleep);
            }
            else if (type == "3")
            {
                Console.Write("What is the name of the habit ");
                string name = Console.ReadLine();
                Console.Write("what is the description of the habit ");
                string description = Console.ReadLine();
                PrioritazeSleep prioritazeSleep = new PrioritazeSleep(name, description);
                _habits.Add(prioritazeSleep);
            }
        }

        //habit Go Ofline
        if (usergoal == "4")
        {
            optionHabits();
            string type = Console.ReadLine();
            if (type == "1")
            {
                GoOffline goOffline = new GoOffline();
                goOffline.GenerateRandom();
                _habits.Add(goOffline);
            }
            else if (type == "2")
            {
                GoOffline goOffline = new GoOffline();
                goOffline.SelectOne();
                _habits.Add(goOffline);

            }
            else if (type == "3")
            {
                Console.Write("What is the name of the habit ");
                string name = Console.ReadLine();
                Console.Write("what is the description of the habit ");
                string description = Console.ReadLine();
                GoOffline goOffline = new GoOffline(name, description,3);
                _habits.Add(goOffline);
            }
        }

        //Habit Learn Something New
        if (usergoal == "5")
        {
            optionHabits();
            string type = Console.ReadLine();
            if (type == "1")
            {
                LearnSomethingNew learnSomethingNew = new LearnSomethingNew();
                learnSomethingNew.GenerateRandom();
                _habits.Add(learnSomethingNew);
            }
            else if (type == "2")
            {
                LearnSomethingNew learnSomethingNew = new LearnSomethingNew();
                learnSomethingNew.SelectOne();
                _habits.Add(learnSomethingNew);

            }
            else if (type == "3")
            {
                Console.Write("What is the name of the habit ");
                string name = Console.ReadLine();
                Console.Write("what is the description of the habit ");
                string description = Console.ReadLine();
                LearnSomethingNew learnSomethingNew = new LearnSomethingNew(name, description);
                _habits.Add(learnSomethingNew);
            }
        }

        // bad habits
        if (usergoal == "6")
        {
            optionHabits();
            string type = Console.ReadLine();
            if (type == "1")
            {
                BadHabits badHabits = new BadHabits();
                badHabits.GenerateRandom();
                _habits.Add(badHabits);
            }
            else if (type == "2")
            {
                BadHabits badHabits = new BadHabits();
                badHabits.SelectOne();
                _habits.Add(badHabits);
            }
            else if (type == "3")
            {
                Console.Write("What is the name of the habit ");
                string name = Console.ReadLine();
                Console.Write("what is the description of the habit ");
                string description = Console.ReadLine();
                BadHabits badHabits = new BadHabits(name, description,3);
                _habits.Add(badHabits);
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
        Console.Write("Enter the name of the file where you would like to save your habits: ");
        string filename= Console.ReadLine();

        using (StreamWriter outPutFile = new StreamWriter(filename)) 
        {
            foreach (Habit habit in _habits)
            {
                outPutFile.WriteLine(habit.Representation());
            }       
        }

    }
    
    public void LoadHabits()
    {
        Console.Write("Enter the name of your habits file: ");
        string filename= Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string nameHabit = parts[0];
            string descriptionHabit = parts[1];
            string week = parts[2];
            string track = parts[3];
            char[] trackArray = track.ToCharArray();
            Exercise habit = new Exercise(nameHabit, descriptionHabit, int.Parse(week), trackArray);
            _habits.Add(habit);
        }            

           
    }

    public void TrackHabits()
    {
        int i = 1;
        Console.WriteLine("The goals are: ");
        foreach (Habit habit in _habits)
        {
            Console.WriteLine($"{i}. {habit.GetHabit()}");
            i++;
        }
        Console.Write("Wich Habit did you accomplish? ");
        string selectionIndex= Console.ReadLine();
        Habit habitevent = _habits[int.Parse(selectionIndex) -1];
        habitevent.Tracking();

    }

    public void ShowAnimation()
    {

    }
}