using Area.Lib.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Area.Lib.Tests
{
    public class TriangleTest
    {

        //Arrange = Act

        [Fact]
        public void isRightCheckTest()
        {
            Triangle triangle = new Triangle(new List<double>() { 3, 4, 5});

            Assert.True(triangle.isRight);
        }

        [Fact]
        public void CalculateAreaTest()
        {
            Triangle triangle = new Triangle(new List<double>() { 3, 4, 5 });

            Assert.Equal(6, triangle.Area);
        }

        [Fact]
        public void CalculatePerimetrTest()
        {
            Triangle triangle = new Triangle(new List<double>() { 3, 4, 5 });

            Assert.Equal(12, triangle.Perimeter);
        }
    }
}
