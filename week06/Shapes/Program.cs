using System;

class Program
{
    static void Main(string[] args)
    {
        

        Square square = new Square(5);
        square.GetColor();
        square.AreaOfShape();

        Rectangle rectangle = new Rectangle(7, 9);
        rectangle.GetColor();
        rectangle.AreaOfShape();

        Circle circle = new Circle(9);
        circle.GetColor();
        circle.AreaOfShape();

        List<Shapes> _shapes = new List<Shapes>();
        _shapes.Add(square);
        _shapes.Add(rectangle);
        _shapes.Add(circle);

        foreach(Shapes shape in _shapes)
        {
            Console.WriteLine($"The color is: {shape}");
        }
        
        // Console.WriteLine($"The color is: {square.GetColor()} and the area of the shape is: {square.AreaOfShape()}");
        // Console.WriteLine($"The color is: {rectangle.GetColor()} and the area of the shape is: {rectangle.AreaOfShape()}");
        // Console.WriteLine($"The color is: {circle.GetColor()} and the area of the shape is: {circle.AreaOfShape()}");

    }
}