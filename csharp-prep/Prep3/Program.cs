using System;

class Program
{
    static void Main(string[] args)
    {      
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = 0;
        int guesses = 0;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string guessc = Console.ReadLine();
            guess = int.Parse(guessc);

            if (number > guess)
            {
            Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
            Console.WriteLine("Lower");
            }
        guesses++;
        
        }
        Console.Write($"You guessed it! it took you {guesses} attempts.");

    }
}