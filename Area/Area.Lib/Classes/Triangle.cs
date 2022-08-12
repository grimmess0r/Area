using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area.Lib.Classes
{
    public class Triangle : Figure
    {
        public bool isRight { get; private set; }
         
        public List<double> Sides
        {
           get { return this.sides; }
           set
           {
               if (value.Count == 3 && !value.Any(x => x < 0))
               {
                   this.sides = value;
                   this.Perimeter = CalculatePerimeter();
                   this.isRight = isRightCheck();
                   this.Area = CalculateArea();
               }
               else
               {
                   throw new Exception("Triangle must have 3 positive sides");
               }
            }
        }

        public Triangle(List<double> sides)
        {
            Sides = sides;
        }

        private bool isRightCheck()
        {
            double hypotenuse = sides.Max();
            List<double> legs = sides.Where(x => x < hypotenuse).ToList();

            if (legs.Count() < 2)
            {
                return false;
            }
            else
            {
                return Math.Pow(legs[0], 2) + Math.Pow(legs[1], 2) == Math.Pow(hypotenuse, 2);
            }
        }

        protected override double CalculateArea()
        {
            var p = Perimeter / 2;

            return Math.Pow(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]), 0.5);
        }





    }
}
