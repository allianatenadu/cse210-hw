using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Red", 4),
            new Rectangle("Blue", 5, 10),
            new Circle("Green", 7)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.Color}, Area: {shape.GetArea():F2}");
        }
    }
}
