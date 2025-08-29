using System;
class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing a shape");
    public virtual void erase() => Console.WriteLine("eraase a shape");

}
class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a circle");
    public override void erase() => Console.WriteLine("erase a circle");
}
class Triangle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a triangle");
    public override void erase() => Console.WriteLine("erase a triangle");
}
class square : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a square");
    public override void erase() => Console.WriteLine("erase a square");
}
class Program
    { public static void Main(string[] args)
        {
        Shape[] shapes ={ new Circle(), new Triangle(), new square() } ;
        foreach (Shape s in shapes)
            {
            s.Draw();
            s.erase();
        }
    }
}
