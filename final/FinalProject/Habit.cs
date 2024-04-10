public abstract class Habit
{
    protected string _name;
    protected string _description;
    protected int _week = 1;
    protected char[] _track;
     private List<string> _congratulatoryMessages = new List<string>
    {
        "Congratulations on successfully fulfilling your habit!",
        "Well done! You've fulfilled your habit. Keep up the good work!",
        "Great job on completing your habit. Your dedication is paying off!",
        "You did it! Celebrate your accomplishment and keep striving for more.",
        "Fantastic job on fulfilling your habit. Your consistency is admirable!",
        "Way to go! Your commitment to fulfilling your habit is truly commendable.",
        "Congratulations! Your hard work and perseverance have led to success.",
        "Amazing job on fulfilling your habit. Keep up the momentum!",
        "Bravo! You've accomplished your habit. Keep setting and achieving new goals.",
        "Excellent work! Your commitment to fulfilling your habits is inspiring."
    };
    private List<string> _supportMessages = new List<string>
    {
        "It's okay, everyone has off days. Tomorrow is a new opportunity to try again.",
        "Don't be too hard on yourself. Progress is not always linear, and setbacks are a part of the journey.",
        "Remember, one setback does not define your success. Keep pushing forward!",
        "Even the smallest step forward is still progress. Take it one day at a time.",
        "You're doing great! Remember to focus on your accomplishments, no matter how small.",
        "It's important to be kind to yourself during setbacks. Take some time to rest and recharge.",
        "Every journey has its bumps in the road. Keep moving forward, and you'll reach your goals.",
        "You're capable of overcoming any obstacle that comes your way. Keep believing in yourself.",
        "Your efforts are not wasted. Use this setback as motivation to come back even stronger.",
        "Remember, setbacks are just temporary roadblocks on the path to success. Keep pushing forward!"
    };

    public Habit()
    {
        _track = new char[14]; 
        _track[0] = '[';
        _track[13] = ']'; 
        
    }

    public Habit(string name, string description)
    {
        _name= name;
        _description = description;
        _track = new char[14]; 
        _track[0] = '['; 
        _track[13] = ']'; 
    }

    public void  Tracking()
    {
        if (_week > 12)
        {
            Console.Write($"Error, already finished this.");
        }
        else
        {
            char checkSymbol = '\u2713';

            Console.Write($"Week {_week }: Did you fulfill the habit? (yes/no): ");
            string response = Console.ReadLine();
                if (response == "yes")
                {
                    _track[_week] = checkSymbol; 
                    CongratulatoryMessages();
                }
                else
                {
                    _track[_week] = 'X';
                    SupportMessages();
                }
            _week ++;
        }
    }

    public abstract void GenerateRandom();

    public abstract void SelectOne();

    public string ShowHabbit()
    {
        return $"{_name} ({_description})";
    }

    public string ShowHabbitTrack()
    {
        for (int i = 0; i < _track.Length; i++)
        {
            if (_track[i] == '\0')
            {
                _track[i] = ' ';
            }
        }

    string result = new string(_track);

    return $"{_name} ({_description}) \n {result}";
    }
    

    public string Representation()
    {
        for (int i = 0; i < _track.Length; i++)
        {
            if (_track[i] == '\0')
            {
                _track[i] = ' ';
            }
        }

        string result = new string(_track);
        return $"{_name}:{_description}:{_week}:{result}";
    }

    public string GetHabit ()
    {
        return _name;
    }
    
    public void SupportMessages()
    {
        Random rand = new Random();
        int index = rand.Next(_supportMessages.Count);
        Console.WriteLine(_supportMessages[index]);
    }

    public void CongratulatoryMessages()
    {
        Random rand = new Random();
        int index = rand.Next(_congratulatoryMessages.Count);
        Console.WriteLine(_congratulatoryMessages[index]);

    }




    
}