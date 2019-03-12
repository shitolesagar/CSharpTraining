using System;
public abstract  class Figure
    {
      public double width, Height, Radius;
      public const float pi = 3.14f;
      public abstract double GetArea();
      public abstract double GetPerimeter();
    }
    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            // here this and base will be same
            this.width = width;
            base.Height = height;
        }
        public override double GetArea()
        {
           // throw new NotImplementedException();
            return width * Height;
        }
        public override double GetPerimeter()
        {
            //throw new NotImplementedException();
            return 2 * (width + Height);
        }
    }
    
public class Circle: Figure
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double GetArea()
        {
            return pi * Radius * Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * pi * Radius;
        }
    }
    class TestFigure
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.34, 56.78);
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r.GetPerimeter());

            Circle c = new Circle(34.56);
            Console.WriteLine(c.GetArea());
            Console.WriteLine(c.GetPerimeter());
            Console.ReadLine();
        }
    }