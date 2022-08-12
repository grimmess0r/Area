using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area.Lib.Classes
{
    public class Figure
    {
        protected List<double> sides { get; set; } = new List<double>();

        public double Area { get; protected set; }

        public double Perimeter { get; protected set; }

        protected virtual double CalculateArea() { return 0; }

        protected virtual double CalculatePerimeter() { return sides.Sum(); }

    }
}
