using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        

        Square square = new Square(5);
        square.SetColor("Red");
        square.AreaOfShape();

        Rectangle rectangle = new Rectangle(7, 9);
        rectangle.SetColor("Blue");
        rectangle.AreaOfShape();

        Circle circle = new Circle(9);
        circle.SetColor("Green");
        circle.AreaOfShape();

        List<Shapes> _shapes = new List<Shapes>();
        _shapes.Add(square);
        _shapes.Add(rectangle);
        _shapes.Add(circle);

        foreach(Shapes shape in _shapes)
        {
            if (shape == square)
            {
               double area = shape.AreaOfShape();
               Console.WriteLine($"The square is {square.GetColor()}, and the area of this shape is: {area}");
            }
            else if (shape == rectangle)
            {
               double area = shape.AreaOfShape();
               Console.WriteLine($"The rectangle is {rectangle.GetColor()}, and the area of this shape is: {area}");
            }
            else if (shape == circle)
            {
               double area = shape.AreaOfShape();
               Console.WriteLine($"The circle is {circle.GetColor()}, and the area of this shape is: {area}");
            }
            
        }
    

    }
}


