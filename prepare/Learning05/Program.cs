using System;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new("green", 2);
        Rectangle rectangle = new("red",4,5);
        Circle circle = new("almond",2.5);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        square.Setcolor("black");
        rectangle.Setcolor("yellow");
        circle.Setcolor("orange");
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"{color} {area}");
        }
        
    }
}