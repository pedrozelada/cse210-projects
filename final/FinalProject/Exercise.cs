using System.Reflection;

public class Exercise : Habit
{
    private Dictionary<string, string> _exerciseHabits = new Dictionary<string, string>
    {
        { "Regular Cardiovascular Exercise", "Incorporate activities like brisk walking, running, cycling, or swimming to improve heart health and endurance." },
        { "Strength Training", "Include resistance exercises using weights, resistance bands, or bodyweight exercises to build muscle strength and bone density." },
        { "Flexibility and Stretching", "Perform stretching exercises to improve flexibility, prevent injuries, and enhance mobility." },
        { "Balance and Stability Training", "Practice exercises such as yoga or tai chi to improve balance, coordination, and stability." },
        { "Core Strengthening", "Engage in exercises targeting the core muscles (abdominals, lower back, and pelvis) to improve posture and stability." },
        { "Functional Training", "Incorporate movements that mimic everyday activities to improve overall functional fitness and reduce the risk of injury." },
        { "Interval Training", "Alternate between periods of high-intensity exercise and rest or low-intensity recovery to improve cardiovascular fitness and burn calories more efficiently." },
        { "Active Lifestyle", "Incorporate physical activity into daily routines, such as taking the stairs instead of the elevator, walking or biking instead of driving short distances, or participating in recreational sports or outdoor activities." }
    };

    public Exercise()
    {

    }
    public Exercise(string name, string description, int week) : base(name, description)
    {
        _name = name;
        _description = description;
        _week = week;

        
    }

    public override void GenerateRandom()
    {
        Random rand = new Random();
        int index = rand.Next(_exerciseHabits.Count);

        string selectedHabit = _exerciseHabits.Keys.ElementAt(index);

        _name = selectedHabit;
        _description = _exerciseHabits[selectedHabit];
    }

    public override void SelectOne()
    {
        Console.WriteLine("Select one of the healthy habits:");
        int count = 1;
        foreach (var habit in _exerciseHabits)
        {
            Console.WriteLine($"  {count}. {habit.Key} - {habit.Value}");
            count++;
        }

        Console.Write("Enter the number of the habit you want to select: ");
        string inputUser = Console.ReadLine();
        string selectedKey = _exerciseHabits.Keys.ElementAt(int.Parse(inputUser) - 1);
        _name = selectedKey;
        _description = _exerciseHabits[selectedKey];
    }

    
}