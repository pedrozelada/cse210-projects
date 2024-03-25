public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());
        Console.Clear();

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
        Console.Clear();

    }

    public void ShowSpinner(int seconds) 
    {
        List <string> simbolSpinner = new List<string> {"|", "/", "—", "\\", "|", "/", "—", "\\"};
        int i = 0;
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            string s = simbolSpinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i ++;
            if (i >= simbolSpinner.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine("");

    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    

    
}
