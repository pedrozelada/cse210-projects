public class LearnSomethingNew : Habit
{
    private Dictionary<string, string> _learnSomethingNew = new Dictionary<string, string>
    {
        { "Foreign language", "Learning a new foreign language can provide a number of amazing results in your life." },
        { "Cooking", "Cooking is not only meditative, but it also offers health benefits and can even save you money." },
        { "Public speaking", "Public speaking can be daunting, but it's a useful skill to have" },
        { "An instrument", "Play an instrument. Whether you can already play an instrument or not, there's never a bad time to learn a new one." },
        { "Speed reading", "When people speed read, they can understand large paragraphs and chunks of information instead of going word-by-word to slowly process each phrase." },
        { "Communication", "Communication is a set of skills, Speaking clearly, Actively listening, Observation, Writing" },
        { "Master origami", "It can help reduce stress, improve hand-eye coordination, boost creativity, enhance patience and persistence, and promote learning and education." },
        { "Self defense", "It can help you feel more confident and safe in public and at home." }
    };

    public LearnSomethingNew()
    {
    }
    public LearnSomethingNew(string name, string description) : base(name, description)
    {
        
    }

    public override void GenerateRandom()
    {
        Random rand = new Random();
        int index = rand.Next(_learnSomethingNew.Count);

        string selectedHabit = _learnSomethingNew.Keys.ElementAt(index);

        _name = selectedHabit;
        _description = _learnSomethingNew[selectedHabit];
    }

    public override void SelectOne()
    {
        Console.WriteLine("Select one of the healthy habits:");
        int count = 1;
        foreach (var habit in _learnSomethingNew)
        {
            Console.WriteLine($"  {count}. {habit.Key} - {habit.Value}");
            count++;
        }

        Console.Write("Enter the number of the habit you want to select: ");
        string inputUser = Console.ReadLine();
        string selectedKey = _learnSomethingNew.Keys.ElementAt(int.Parse(inputUser) - 1);
        _name = selectedKey;
        _description = _learnSomethingNew[selectedKey];
    }

    

}