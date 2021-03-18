using System;

namespace SquareCalculator
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double Radius { get; set; }

        public double Area => Math.PI * Math.Pow(Radius, 2);
    }
}