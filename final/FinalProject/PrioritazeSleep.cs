public class PrioritazeSleep : Habit
{
    private Dictionary<string, string> _sleepHabits = new Dictionary<string, string>
    {
        { "Set a consistent sleep schedule", "Go to bed at the same time and wake up at the same time." },
        { "Create regular bedtime rituals", " Do the same thing every night before bedtime, like take a warm bath, read or listen to music." },
        { "Limit caffeine and avoid nicotine", "Caffeine and nicotine are stimulants that interfere with sleep. Regular users also may experience withdrawal symptoms at night, leading to restless sleep." },
        { "Get regular exercise", "Make sure you exercise at least two hours before bedtime though, or it may be difficult to fall asleep." },
        { "Keep a healthy diet", "Meals just before bedtime may make it difficult to fall asleep and stay asleep. But, a small snack just before bedtime tends to promote sleep." },
        { "Keep naps short", "If you need to nap, limit it to less than 30 minutes." },
        { "Turn off electronic devices before you go to sleep", "Electronic devices like your phone emit blue light, which can reduce melatonin levels in your body." },
        { "Don't Clock-watch", "If you cannot sleep, do not keep lying in bed checking the time on your clock or watch. This may make you more anxious and may make it harder to fall." }
    };

    public PrioritazeSleep()
    {
    }
    public PrioritazeSleep(string name, string description) : base(name, description)
    {
        
    }

    public override void GenerateRandom()
    {
        Random rand = new Random();
        int index = rand.Next(_sleepHabits.Count);

        string selectedHabit = _sleepHabits.Keys.ElementAt(index);

        _name = selectedHabit;
        _description = _sleepHabits[selectedHabit];
    }

    public override void SelectOne()
    {
        Console.WriteLine("Select one of the healthy habits:");
        int count = 1;
        foreach (var habit in _sleepHabits)
        {
            Console.WriteLine($"  {count}. {habit.Key} - {habit.Value}");
            count++;
        }

        Console.Write("Enter the number of the habit you want to select: ");
        string inputUser = Console.ReadLine();
        string selectedKey = _sleepHabits.Keys.ElementAt(int.Parse(inputUser) - 1);
        _name = selectedKey;
        _description = _sleepHabits[selectedKey];
    }

}