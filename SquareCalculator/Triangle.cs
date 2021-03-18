using System;

namespace SquareCalculator
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        private double SideA { get; }

        private double SideB { get; }

        private double SideC { get; }

        public double Area
        {
            get
            {
                var p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }
        
        public bool IsRight => SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
    }
}