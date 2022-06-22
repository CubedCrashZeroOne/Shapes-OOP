using System;

namespace Shapes
{
    internal class Trapezoid : Shape
    {

        private readonly double _base1;
        private readonly double _base2;
        private readonly double _leg1;
        private readonly double _leg2;
        // Angle between base 1 and leg 1.
        private readonly double _angle1;

        public double Base1
        {
            get { return _base1; }
        }

        public double Base2
        {
            get { return _base2; }
        }

        public double Leg1
        {
            get { return _leg1; }
        }

        public double Leg2
        {
            get { return _leg2; }
        }


        public Trapezoid(double base1, double base2, double leg1, double leg2, double angle1)
        {
            _base1 = base1;
            _base2 = base2;
            _leg1 = leg1;
            _leg2 = leg2;
            _angle1 = angle1;
        }
        
        public override double GetArea()
        {
            return _leg1 * Math.Sin(_angle1) * (_base1 + _base2) / 2;
        }

        public override double GetPerimeter()
        {
            return _base1 + _base2 + _leg1 + _leg2;
        }
    }
}