using System;

namespace Years_to_Days_and_Weeks
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, days, weeks, months;
            Console.WriteLine("Please enter your age");

            age = Convert.ToInt32(Console.ReadLine());

            if (age > 0)
            {
                days = age * 365;
                weeks = age * 52;
                months = age * 12;

                Console.WriteLine("Your age in days is " + days + " days");
                Console.WriteLine("Your age in weeks is " + weeks + " weeks");
                Console.WriteLine("Your age in months is " + months + " months");
            }
        }
    }
}
