namespace Shapes
{
    internal class Square : Shape
    {
        
        private readonly double _a;

        public double A
        {
            get { return _a; }
        }

        public Square(double a)
        {
            _a = a;
        }
        
        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return _a * 4;
        }
    }
}