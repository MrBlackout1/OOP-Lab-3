using OOP_Laba3._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static void First()
    {
        double side1 = 0;
        Console.Write("Input side1:");
        side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input side2:");
        Rectangle rect = new Rectangle(side1, Convert.ToDouble(Console.ReadLine()));
        rect.AreaCalulator();
        rect.PerimeterCalulator();
        Console.WriteLine("Area: " + rect.Area);
        Console.WriteLine("Perimeter: " + rect.Perimeter);
    }
    public static void Second()
    {
        Book book = new Book();
        book.Show();
    }
    public static void Third()
    {
        Figure figure = new Figure(new Point() { X = 12, Y = 12 },
                                  new Point() { X = 16, Y = 18 },
                                  new Point() { X = 21, Y = 10 });
        figure.Show();
    }
    public static void Fourth()
    {
        Invoice inv = new Invoice(12, "customer1", "provider1");
        inv.Show();
    }
}
