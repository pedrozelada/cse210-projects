public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity()
    {
        _name = "Reflection Activity.";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
   
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"Get ready... ");
        ShowSpinner(3);
        Console.WriteLine($"Consider the following prompt:\n ");
        DisplayPrompt();
        Console.WriteLine($"When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(15);
            Console.WriteLine("");
        }
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        List <string> prompts = new List<string> 
         {
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless.", 
        };
        _prompts = prompts;
        Random rnd = new Random();
        int index = rnd.Next(prompts.Count);
        string randomPrompt = prompts[index];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
         List <string> questions = new List<string> 
         {
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?", 
            "What could you learn from this experience that applies to other situations?", 
            "What did you learn about yourself through this experience?", 
            "How can you keep this experience in mind in the future?", 
        };
        _questions = questions;
        Random rnd = new Random();
        int index = rnd.Next(questions.Count);
        string randomPrompt = questions[index];
        return randomPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} --- \n");

    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion() }");
    }
}