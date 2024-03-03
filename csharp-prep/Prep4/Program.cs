using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        int sum = 0;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberAdd = Console.ReadLine();
            number = int.Parse(numberAdd);
            numbers.Add(number);
            sum = sum + number;
        }
        double avg = (double)sum / (double)(numbers.Count-1);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {numbers.AsQueryable().Max()}");
    }
}