public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _answers;

    public ListingActivity()
    {
        _name = "Listing Activity.";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        List <string> answers = new List<string>();
        _answers = answers;
        DisplayStartingMessage();
        Console.WriteLine($"Get ready... ");
        ShowSpinner(3);
        Console.WriteLine($"List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            string answer = Console.ReadLine();
            answers.Add(answer);
            _count ++;
        }
        Console.WriteLine($"You listed {_count} items");
        Console.WriteLine($"");
        DisplayEndingMessage();


    }

    public void GetRandomPrompt()
    {
        List <string> prompts = new List<string> 
         {
            "Who are people that you appreciate?", 
            "What are personal strengths of yours?", 
            "Who are people that you have helped this week?", 
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",  
        };
        _prompts = prompts;
         Random rnd = new Random();
        int index = rnd.Next(prompts.Count);
        string randomPrompt = prompts[index];
        Console.WriteLine($" ---{randomPrompt} ---");

    }

    public List <string> GetListFromUser() {
        List <string> list = new List<string>();
        Console.Write(">");
        string response = Console.ReadLine();
        list.Add(response);
        return list;

    }


}