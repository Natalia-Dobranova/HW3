using System;

namespace Homework3
{
    public class Shape
    {
       public void Area (double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of circle is equal to {area} ");


        }

        public void Area (double a, double h)
        {
            double area = 0.5 * a * h;

            Console.WriteLine($"The area of triangle is equal to {area} ");


        }

        public void Area (double side1, double side2, double h)

        {
            double area = 0.5 * (side1 + side2) * h;

            Console.WriteLine($"The area of trapezoid is equal to {area} ");


        }

    }

    
}
