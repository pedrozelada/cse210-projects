using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int numberGradePercentage = int.Parse(gradePercentage);
        string letterGrade = "";

        if (numberGradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGradePercentage >= 80)
        {
            letterGrade = "B";
        }
         else if (numberGradePercentage >= 70)
        {
            letterGrade = "C";
        }
         else if (numberGradePercentage >= 60)
        {
            letterGrade = "D";
        }
         else if (numberGradePercentage < 60)
        {
            letterGrade = "F";
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        Console.WriteLine($"Your grade is {letterGrade}.");

        if(numberGradePercentage > 70)
        {   
            Console.WriteLine("Congratulations.");
        }
        
        else
        {
            Console.WriteLine("Good luck next time.");
        }

            }
}