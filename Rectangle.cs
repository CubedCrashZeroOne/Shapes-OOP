namespace Shapes
{
    internal class Rectangle : Shape
    {
        private readonly double _a;
        private readonly double _b;

        public double LongerSide
        {
            get
            {
                return _a > _b ? _a : _b;
            }
        }
        
        public double ShorterSide
        {
            get
            {
                return _a > _b ? _b : _a;
            }
        }

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double GetArea()
        {
            return _a * _b;
        }

        public override double GetPerimeter()
        {
            return 2 * (_a + _b);
        }
    }
}