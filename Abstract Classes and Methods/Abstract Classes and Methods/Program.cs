using System;

abstract class Shape
{
    // Abstract method to be implemented by derived classes
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;

    // Constructor to initialize radius
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementing the GetArea method for Circle
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    // Constructor to initialize width and height
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Implementing the GetArea method for Rectangle
    public override double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Circle and Rectangle
        Circle circle = new Circle(4.0);
        Rectangle rectangle = new Rectangle(7.0, 5.0);

        // Displaying the areas of the Circle and Rectangle
        Console.WriteLine("Area of the circle: " + circle.GetArea());  // Output: Area of the circle: 78.53981633974483
        Console.WriteLine("Area of the rectangle: " + rectangle.GetArea());  // Output: Area of the rectangle: 24.0
    }
}
