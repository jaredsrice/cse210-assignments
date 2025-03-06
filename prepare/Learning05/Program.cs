using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Blue", 2);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Red", 2, 3);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Green", 2);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();  
            double area = shape.GetArea();    

            area = Math.Round(area,2);

            Console.WriteLine($"Color: {color}, Area: {area}");
        }
    }
}