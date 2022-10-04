using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3._1
{
    internal class Figure
    {
        public List<Point> Points { get; set; } = new List<Point>();
        public double Perimeter { get; set; } = 0;
        public string Name { get; set; } = "Figureeee";
        public Figure(Point a, Point b, Point c)
        {
            Points.Add(a);
            Points.Add(b);
            Points.Add(c);
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            Points.Add(a);
            Points.Add(b);
            Points.Add(c);
            Points.Add(d);
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            Points.Add(a);
            Points.Add(b);
            Points.Add(c);
            Points.Add(d);
            Points.Add(e);
        }
        public static double LengthSide(Point a, Point b) =>
            Math.Round(
                Math.Abs(
                    Math.Sqrt(
                        Math.Pow(b.X - a.X, 2)
                        + Math.Pow(b.Y - a.Y, 2)))
                , 2);
        public void PerimetrCalculate()
        {
            Perimeter = 0;
            for (int i = 0; i < Points.Count - 1; i++)
                Perimeter += LengthSide(Points[i], Points[i + 1]);
            Perimeter += LengthSide(Points[0], Points.Last());
        }
        public void Show()
        {
            Console.WriteLine($"Figure name: {Name}");
            PerimetrCalculate();
            Console.WriteLine($"Figure perimeter: {Perimeter}");
        }
    }
}
