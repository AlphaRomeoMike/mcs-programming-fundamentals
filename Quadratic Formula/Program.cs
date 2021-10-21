using System;

namespace Quadratic_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to generate Quadratic Formula");
            int a, b, c;

            double d, x, y;

            Console.WriteLine("Enter value of \'a\'");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of \'b\'");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of \'c\'");
            c = Convert.ToInt32(Console.ReadLine());

            d = Math.Pow(b, 2) - 4 * a * c;

            if (d == 0)
            {
                Console.WriteLine("Both roots are equal");

                // Since the roots are equal, both roots are equal
                // so we do not need to calculate with +ve root
                x = -b / (2.0 * a);
                y = x;

                Console.WriteLine("First Root = " + x);
                Console.WriteLine("Second Root = " + y);
            }
            else if (d > 0)
            {
                Console.WriteLine("Both roots are real and different");

                // Since the roots are different,
                // so we do need to calculate with +ve and -ve root

                x = (-b + Math.Sqrt(d)) / (2 * a);
                y = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("First Root = " + x);
                Console.WriteLine("Second Root = " + y);
            }
            else
            {
                Console.WriteLine("Roots are imaginary, no solution can be provided");
            }
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
