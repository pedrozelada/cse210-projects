using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("red", 6);
        Rectangle rectangle = new Rectangle("blue", 6, 9);
        Circle circle = new Circle("yellow", 4);
        
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
        


    }
}