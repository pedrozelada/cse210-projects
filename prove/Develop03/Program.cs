using System;

class Program
{
    static void Main(string[] args)
    {
       
    /*  Reference reference = new Reference("Moses", 1, 39);
        string text = "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.";
        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine(scripture.GetDisplayText());
    */ 
        Console.WriteLine("This program will generate one of the 100 Scripture Mastery Passages.");
        Scripture scriptureRandom = new Scripture();
        Scripture scripture = scriptureRandom.GenerateRandom("scriptures.txt");
        Console.WriteLine(scripture.GetDisplayText());
     
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string quit = Console.ReadLine();
       
        while (quit != "quit" ) {
            Console.Clear();
            scripture.HideRandomWords(2);
            if (scripture.IsCompletelyHidden()) break;
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            quit = Console.ReadLine();
           
        }
        
    }
}