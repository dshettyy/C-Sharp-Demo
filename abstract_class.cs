using System;
abstract class Shape
{
    public abstract double
        calculateArea();
    public abstract double
        calculatePerimeter();
}
 class Circle : Shape
{
    private double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public override double calculateArea()
    {
        return Math.PI * radius * radius;
    }
    public override double calculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

}
class triangle : Shape
{
    private double side1, side2, side3;
    public triangle(double s1, double s2, double s3)
    {
        side1 = s1;
        side2 = s2;
        side3 = s3;
    }
    public override double calculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
    public override double calculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}
class PROGRAM
{
    static void Main(string[] args)
    {
        Shape c = new Circle(5);
        Console.WriteLine("Circle Area: " + c.calculateArea());
        Console.WriteLine("Circle Perimeter: " + c.calculatePerimeter());
        Shape t = new triangle(3, 4, 5);
        Console.WriteLine("Triangle Area: " + t.calculateArea());
        Console.WriteLine("Triangle Perimeter: " + t.calculatePerimeter());
    }
}
