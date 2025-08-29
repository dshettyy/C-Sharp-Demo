using System;
using System.Xml.Serialization;

namespace sub
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape");
        }
          public virtual void Erase()
        {
            Console.WriteLine("Erasing a Shape");
        }  
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
        public override void Erase()
        {
            Console.WriteLine("Erasing a circle");
        }

    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
        public override void Erase()
        {
            Console.WriteLine("Erasing a Triangle");
        }
    }
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
        public override void Erase()
        {
            Console.WriteLine("Erasing a Square");
        }

    }
    class main
    {
        public static void Main(string[] args)
        {
            Shape[] shape = { new Circle(), new Triangle(), new Square() };

            foreach (Shape s in shape)
            {
                s.Draw();
                s.Erase();
            }
        }
    }

}