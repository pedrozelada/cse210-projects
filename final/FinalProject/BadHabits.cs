public class BadHabits : Habit
{
   
    private Dictionary<string, string> _badHabits = new Dictionary<string, string>
    {
        { "No Smoking", "Smoking kills cells in the respiratory system and weakens it against environmental pathogens. Additionally, smoking significantly increases the risk of developing respiratory diseases such as lung cancer, chronic cough, and difficulty breathing." },
        { "Not to drink alcohol.", "Almost as serious as tobacco, alcohol has been associated not only with liver problems and the potential risk of addiction but also with an increased risk of developing cancerous diseases." },
        { "Avoid Too Much Screen Time Before Bed", "Some research has shown that light from electronics such as TVs, tablets, and smartphones can mess with the hormones that help us to go to sleep." },
        { "Avoid Slouching", " Slouching or hunching can happen too often and lead to lower back pain." },
        { "Avoid ", "It can easily lead to people developing debt if unchecked." },
        { "Don't procrastinate", "Procrastination is the act of unnecessarily and voluntarily delaying or postponing something despite knowing that there will be negative consequences for doing so. " },
        { "Don't watch much television", "Too much screen time can lead to obesity, sleep problems, chronic neck and back problems, depression, anxiety and lower test scores in children." },
        { "No lies", "Lying is bad for everyone's health." }
    };

    public BadHabits()
    {
    }

    public BadHabits(string name, string description, int time) : base(name, description)
    {
        
    }

    public override void GenerateRandom()
    {
        Random rand = new Random();
        int index = rand.Next(_badHabits.Count);

        string selectedHabit = _badHabits.Keys.ElementAt(index);

        _name = selectedHabit;
        _description = _badHabits[selectedHabit];
    }

    public override void SelectOne()
    {
        Console.WriteLine("Select one of the healthy habits:");
        int count = 1;
        foreach (var habit in _badHabits)
        {
            Console.WriteLine($"  {count}. {habit.Key} - {habit.Value}");
            count++;
        }

        Console.Write("Enter the number of the habit you want to select: ");
        string inputUser = Console.ReadLine();
        string selectedKey = _badHabits.Keys.ElementAt(int.Parse(inputUser) - 1);
        _name = selectedKey;
        _description = _badHabits[selectedKey];
    }

}