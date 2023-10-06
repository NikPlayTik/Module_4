using System;
using System.Collections.Generic;
using System.Linq;
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
}
