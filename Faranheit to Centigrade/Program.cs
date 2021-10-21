using System;

namespace Faranheit_to_Centigrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            float f, c;

            Console.WriteLine("Convert C to F and F to C");
            Console.WriteLine("Please enter 1 if you need to convert Faranheit to Celcius" +
                " or 2 in case of vice versa");

            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Coverting Faranheit to Celcius");
                Console.WriteLine("Please enter a value (faranheit)");
                f = Convert.ToSingle(Console.ReadLine());

                c = (float)((f - 32) * 1.8);
                Console.WriteLine("The value of " + f + " F is " + c + " C");

            }
            else if (x == 2)
            {
                Console.WriteLine("Coverting Celcius to Faranheit");
                Console.WriteLine("Please enter a value (celcius)");
                c = Convert.ToSingle(Console.ReadLine());

                f = (float)((c * 1.8) + 32);
                Console.WriteLine("The value of " + c + "C is " + f + "F");
            }
        }
    }
}
