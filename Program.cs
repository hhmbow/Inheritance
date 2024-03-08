
using System;

// Base class
public class Shape
{
    // Fields
    protected double width;
    protected double height;

    // Constructor
    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Method to calculate area
    public virtual double CalculateArea()
    {
        return width * height;
    }
}

// Derived class (inherits from Shape)
public class Rectangle : Shape
{
    // Constructor
    public Rectangle(double width, double height) : base(width, height)
    {
    }

    // Override CalculateArea method
    public override double CalculateArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Rectangle
        Rectangle rectangle = new Rectangle(5, 10);

        // Calculate area of the rectangle
        double area = rectangle.CalculateArea();
        Console.WriteLine("Area of the rectangle: " + area);
    }
}
