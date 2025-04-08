using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Squre squre = new Squre("black",30,"Squre");
        // squre.DisplayColor();
        // Console.WriteLine($"{squre.GetArea()} {squre.GetColor()}");

        Rectangle rectangle = new Rectangle("white", 20,23,"Rectangle");

        Cicle cicle =  new Cicle("Green",30,"Cicle");

        List<Shape> shapesList = new List<Shape>();

        shapesList.Add(squre);
        shapesList.Add(rectangle);
        shapesList.Add(cicle);

        foreach(Shape shape in shapesList)
        {
            Console.WriteLine($"The Area of {shape.GetName()} the shape is: {shape.GetArea()} The color is:{shape.GetColor()}");
           

        }

    }
}