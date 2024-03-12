using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction first = new Fraction();
        Fraction second = new Fraction(5);
        Fraction third = new Fraction(3, 4);
        Fraction forth = new Fraction(1, 3);
        

        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
        
        Console.WriteLine(forth.GetFractionString());
        Console.WriteLine(forth.GetDecimalValue());



    }
}