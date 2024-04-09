public class HealthyDiet : Habit
{
    private int _weeks; 
    private Dictionary<string, string> _healthyHabits = new Dictionary<string, string>
    {
        { "Control portions", "Each body needs a different amount of calories, so it is crucial to consume portions adapted to each person's characteristics." },
        { "Eat Fruits and Vegetables", "Include at least 5 portions of fruits and vegetables in your diet. They are rich in fiber, vitamins, and antioxidants." },
        { "Distribute daily meals properly", "Ideally, have 5 meals a day (breakfast, snack, lunch, afternoon snack, and dinner), taking care of the portions of carbohydrates and fats." },
        { "Drink Water", "Drink a minimum of two liters of water a day to maintain proper hydration. Good hydration aids in digestion and toxin elimination." },
        { "Eat slowly and chew food well", "Eating slowly promotes a feeling of satiety and facilitates digestion." },
        { "Avoid junk food consumption", "Junk foods are rich in saturated fats and sugars, increasing the risk of diabetes, obesity, and cardiovascular diseases." },
        { "Consume fish at least twice a week", "Fish, especially oily fish like sardines and salmon, provide high-quality proteins, vitamins, minerals, and Omega-3 fatty acids." },
        { "EXTRA: Consume legumes once a week", "Legumes are a good source of protein and iron. Drink orange juice or lemon juice with legumes to enhance their nutritional value." }
    };

    public HealthyDiet()
    {
        
    }
    public HealthyDiet(string name, string description, int time) : base(name, description)
    {
        _name = name;
        _description = description;
        _weeks = time;
    }

    public override void GenerateRandom()
    {
        Random rand = new Random();
        int index = rand.Next(_healthyHabits.Count);

        string selectedHabit = _healthyHabits.Keys.ElementAt(index);

        _name = selectedHabit;
        _description = _healthyHabits[selectedHabit];
    }

    public override void SelectOne()
    {
        Console.WriteLine("Select one of the healthy habits:");
        int count = 1;
        foreach (var habit in _healthyHabits)
        {
            Console.WriteLine($"  {count}. {habit.Key} - {habit.Value}");
            count++;
        }

        Console.Write("Enter the number of the habit you want to select: ");
        string inputUser = Console.ReadLine();
        string selectedKey = _healthyHabits.Keys.ElementAt(int.Parse(inputUser) - 1);
        _name = selectedKey;
        _description = _healthyHabits[selectedKey];

    }

    public override void Tracking()
    {
        throw new NotImplementedException();
    }
}