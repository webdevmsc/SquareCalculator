using System;
using Xunit;

namespace SquareCalculator.Tests
{
    public class Tests
    {
        [Fact]
        public void Triangle_Area_Should_Be_Correct()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.Area);
            var triangle2 = new Triangle(6, 9, 12);
            Assert.Equal(26.142637586900065, triangle2.Area);
        }

        [Fact]
        public void Triangle_Definition_Should_Be_Correct()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight);
            var triangle2 = new Triangle(5, 7, 9);
            Assert.False(triangle2.IsRight);
        }

        [Fact]
        public void Circle_Area_Should_Be_Correct()
        {
            var circle = new Circle(23);
            Assert.Equal(1661.9025137490005, circle.Area);
            var circle2 = new Circle(41);
            Assert.Equal(5281.017250684442, circle2.Area);
            var circle3 = new Circle(0);
            Assert.Equal(0, circle3.Area);
        }
    }
}