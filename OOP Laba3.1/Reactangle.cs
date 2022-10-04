using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3._1
{
    internal class Rectangle
    {
        public double side1;
        public double side2;
        double area;
        public double Area { get => area; }
        double perimeter;
        public double Perimeter { get => perimeter; }
        public void AreaCalulator() => area = side1 * side2;
        public void PerimeterCalulator() => perimeter = (2 * side1) + (2 * side2);
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
    }
}
