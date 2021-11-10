using System;

namespace Degree_To_Radians
{
    class Program
    {
        static void Main(string[] args)
        {
            double formula = 3.1416 / 180;
            Console.WriteLine("Please enter your selected number");
            double degrees = Convert.ToDouble(Console.ReadLine());

            double radians = degrees * formula;

            Console.WriteLine($"{degrees} degrees coverted to radians are {radians}");
        }
    }
}
