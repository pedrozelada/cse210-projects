using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Samuel Bennett", "Multlpication");

        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fraction", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WrittingAssignment writtingAssignment = new WrittingAssignment("Maru Waters" , "European History", "The causes of World War II");
        Console.WriteLine(writtingAssignment.GetSummary());
        Console.WriteLine(writtingAssignment.GetWritingInformation());
        

    }
    
}