using System;

namespace Shapes
{
    internal class Triangle : Shape
    {

        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get { return _a; }
        }
        
        public double B
        {
            get { return _b; }
        }
        
        public double C
        {
            get { return _c; }
        }

        public double AngleA
        {
            // cosine rule
            get { return Math.Acos((_b * _b + _c * _c - _a * _a) / (2 * _b * _c)); }
        }
        
        public double AngleB
        {
            // cosine rule
            get { return Math.Acos((_a * _a + _c * _c - _b * _b) / (2 * _a * _c)); }
        }
        
        public double AngleC
        {
            // cosine rule
            get { return Math.Acos((_b * _b + _a * _a - _c * _c) / (2 * _b * _a)); }
        }

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetArea()
        {
            return 0.5 * _a * _b * Math.Sin(AngleC);
        }

        public override double GetPerimeter()
        {
            return _a + _b + _c;
        }
    }
}