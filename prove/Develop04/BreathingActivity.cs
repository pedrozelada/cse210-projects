public class BreathingActivity : Activity
{
    
    public BreathingActivity()
    {
        _name = "Breathing Activity.";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"Get ready... ");
        ShowSpinner(3);
        
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            // Console.Write("\nBreathe in...");
            // ShowCountDown(4);
            // Console.WriteLine("");
            // Console.Write("Now breathe out...");
            // ShowCountDown(6);
            // Console.WriteLine("");
            Console.WriteLine("\nBreathe in...");
            AnimationBreatheIn(4);
            
            Console.WriteLine("\nNow breathe out...");
            AnimationBreatheOut(6);
        }
        Console.WriteLine("");
        DisplayEndingMessage();
    }
    
    private void AnimationBreatheIn(int durationSeconds)
    {
        int maxBars = 10;
        for (int i = 1; i <= durationSeconds; i++)
        {
            int currentBars = (i * maxBars) / durationSeconds; 
            string bars = new string('|', currentBars);
            Console.WriteLine($"[{bars.PadRight(maxBars)}] {i}");
            System.Threading.Thread.Sleep(1000);
        }
    }
    private void AnimationBreatheOut(int durationSeconds)
{
    int maxBars = 10;
    for (int i = durationSeconds; i > 0; i--)
    {
        int currentBars = (i * maxBars) / durationSeconds;
        string bars = new string('|', currentBars);
        Console.WriteLine($"[{bars.PadRight(maxBars)}] {i}");
        System.Threading.Thread.Sleep(1000);
    }
}



}