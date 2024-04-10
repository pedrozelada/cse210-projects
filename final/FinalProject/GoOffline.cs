public class GoOffline : Habit
{
    private Dictionary<string, string> _offlineHabits = new Dictionary<string, string>
    {
        { "Go for a bike ride", "Hit the trails, or even just the sidewalk, for a fun day of exercise and fresh air sans internet. " },
        { "Meditate", "Ever heard of a silent retreat? It’s a rejuvenating experience that can bring you back to harmony with yourself and your inner thoughts." },
        { "Gather some friends", "What could be more fun than gathering around the table playing a game and laughing the night away." },
        { "Go for a hike", " Lace up those sneakers and hit the trails for a challenging hike." },
        { "Get outside and walk", "It might seem like a no-brainer, but one of the easiest (and cheapest) things you can do when you’re sick of being on your phone or computer." },
        { "Daily Reading", "The practice of reading every day expands your knowledge and improves mental agility." },
        { "Plant something", "Houseplants can naturally purify the air in your apartment and give you a fun excuse to stay off your smartphone." },
        { "Write in a journal", "Journaling is a great tech-free way to channel your energy and organize your daily to-dos and ideas." }
    };
    public GoOffline()
    {
    }
    public GoOffline(string name, string description, int time) : base(name, description)
    {
        
    }

    public override void GenerateRandom()
    {
        Random rand = new Random();
        int index = rand.Next(_offlineHabits.Count);

        string selectedHabit = _offlineHabits.Keys.ElementAt(index);

        _name = selectedHabit;
        _description = _offlineHabits[selectedHabit];
    }

    public override void SelectOne()
    {
        Console.WriteLine("Select one of the healthy habits:");
        int count = 1;
        foreach (var habit in _offlineHabits)
        {
            Console.WriteLine($"  {count}. {habit.Key} - {habit.Value}");
            count++;
        }

        Console.Write("Enter the number of the habit you want to select: ");
        string inputUser = Console.ReadLine();
        string selectedKey = _offlineHabits.Keys.ElementAt(int.Parse(inputUser) - 1);
        _name = selectedKey;
        _description = _offlineHabits[selectedKey];
    }

  
}