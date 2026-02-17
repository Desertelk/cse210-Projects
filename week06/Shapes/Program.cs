using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square(5, "blue");

        Rectangle r = new Rectangle("Red", 3.5, 2);

        Circle c = new Circle("Purple", 2);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape);
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}