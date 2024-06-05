using System;

namespace lb_03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 3, "B");
            Point C = new Point(4, 0, "C");
            Point D = new Point(4, 3, "D");
        
            Figure figure = new Figure(A, B, C, D);
            Console.WriteLine("Figure: Quadrilateral");
            figure.PerimeterCalculator();
        }
    }
}