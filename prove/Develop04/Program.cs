using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Welcome to the Journal Program!");
        while (!quit) 
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1.Start Breathing Activity\n2.Start Reflecting Activity\n3.Start Listing Activity\n4.Quit");
            Console.Write("Select a choise from the menu: ");
            string user_respons = Console.ReadLine();
            
            Activity activity = new Activity();
            Console.Clear();
            switch (user_respons) 
            {
                case "1": {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                };
                case "2": {
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                };
                case "3": {
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                };
                case "4": {
                    quit = true;
                    break;
                };
            }
        }
    }

}