

namespace Area.Lib.Classes
{
    public class Circle : Figure
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                Area = CalculateArea();
            }
        }

        protected override double CalculateArea()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
