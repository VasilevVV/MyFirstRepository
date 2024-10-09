using System;

namespace Module6.Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }

    }

    class Circle
    {
        public double radius;

        public double Square()
        {
            return (radius * radius * 3.14);
        }

        public double Length()
        {
            return (2 * 3.14 * radius);
        }
    }

    class Triangle
    {
        public int a;
        public int b;
        public int c;

        public double Square()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / 2;
        }

        public double Perimeter()
        {
            return (a + b + c);
        }
    }

    class Square
    {
        public int side;

        public double SquareCalc()
        {
            return side * side;
        }

        public double Perimeter()
        {
            return side + side + side + side;
        }
    }

}
