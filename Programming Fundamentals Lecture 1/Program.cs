using System;

namespace Programming_Fundamentals_Lecture_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float netSalary, grossSalary, tax, providentFund;
            Console.WriteLine("Please enter your gross salary");
            grossSalary = Convert.ToSingle(Console.ReadLine());

            tax = grossSalary * Convert.ToSingle(0.03);
            providentFund = grossSalary * Convert.ToSingle(0.10);

            netSalary = grossSalary - tax + providentFund;

            Console.WriteLine("The tax on salary " + grossSalary + " is " + tax);
            Console.WriteLine("The provident fund on salary " + grossSalary + " is " + providentFund);
            Console.WriteLine("The net salary is = " + netSalary);

        }
    }
}
