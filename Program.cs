using System;
using System.Linq;

namespace Shapes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var shapes = new Shape[]
            {
                new Rectangle(2, 6.6),
                new Circle(3),
                new Circle(2.55), 
                new Rectangle(5, 1),
                new Triangle(3, 4, 5),
                new Triangle(6, 7, 12),
                new Square(3),
                new Square(8.9),
                new Trapezoid(6, 8, 4, 7, Math.PI/3), 
            };
            
            Console.WriteLine("Area: " + shapes.Sum(s => s.GetArea()));
            Console.WriteLine("Perimeter:" + shapes.Sum(s => s.GetPerimeter()));
        }
    }
}