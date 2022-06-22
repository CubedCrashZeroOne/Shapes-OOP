using System;

namespace Shapes
{
    internal class Circle : Shape
    {
        private readonly double _radius;

        public double Radius
        {
            get { return _radius; }
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
        
        public override double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}