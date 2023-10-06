using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    interface IFigure
    {
        double CalculateArea();
        double CalculatePerimetr();
    }

    public class Rectangle : IFigure
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return width * length;
        }
        public double CalculatePerimetr() 
        {
            return 2 * (width + length);
        }
    }

    public class Circle : IFigure
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculatePerimetr()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Triangle : IFigure
    {
        private double side_1;
        private double side_2;
        private double side_3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side_1 = side1;
            this.side_2 = side2;
            this.side_3 = side3;
        }

        public double CalculateArea()
        {
            // формула Герона для вычисление площади
            double s = (side_1 + side_2 + side_3) / 2;
            return Math.Sqrt(s * (s - side_1) * (s - side_2) * (s - side_3));
        }

        public double CalculatePerimetr()
        {
            return side_1 + side_2 + side_3;
        }
    }
}
