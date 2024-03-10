using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        Journal journal = new Journal();
 
        Console.WriteLine("Welcome to the Journal Program!");
        while (!quit) {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.Write("What would you like to do? ");
            string user_respons = Console.ReadLine();
            switch (user_respons) {
                case "1": {
                    journal.WriteLog();
                    break;
                };
                case "2": {
                    journal.DisplayAll();
                    break;
                };
                case "3": {
                    Console.Write("What is the file name: ");
                    string filename = Console.ReadLine();
                    journal.Load(filename);
                    break;
                };
                case "4": {
                    Console.Write("What is the file name: ");
                    string filename = Console.ReadLine();
                    journal.Save(filename);
                    break;
                };
                case "5": {
                    quit = true;
                    break;
                };
            }
        }
    }
}
    