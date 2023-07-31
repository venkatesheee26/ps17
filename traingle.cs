using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_17
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            ShapeType = "Triangle";
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        public override double Perimeter
        {
            get { return SideA + SideB + SideC; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Side A: {SideA}");
            Console.WriteLine($"Side B: {SideB}");
            Console.WriteLine($"Side C: {SideC}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
