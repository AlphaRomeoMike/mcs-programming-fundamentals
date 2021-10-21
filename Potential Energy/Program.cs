using System;

namespace Potential_Energy
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass, velocity, acceleration = 9.8, pe;

            Console.WriteLine("Calculate Potential Energy");
            Console.WriteLine("Mass (in kilograms)");
            mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Velocity (in m/s)");
            velocity = Convert.ToDouble(Console.ReadLine());

            // Calculation
            pe = mass * velocity * acceleration;

            Console.WriteLine("The potential energy is " + pe + " joules");
            Console.WriteLine("--------------------------------");
        }
    }
}
