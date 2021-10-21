using System;

namespace Student_Information_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 300;
            Console.WriteLine("Student Information System");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Please enter students name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter students address");
            string address = Console.ReadLine();

            Console.WriteLine("Please enter students English marks");
            double english = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter students Maths marks");
            double maths = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter students Science marks");
            double science = Convert.ToDouble(Console.ReadLine());

            double marks = english + maths + science;

            double percentage = (marks / total) * 100;
            Console.WriteLine("========================================");
            Console.WriteLine("English = " + english);
            Console.WriteLine("Maths = " + maths);
            Console.WriteLine("Science = " + science);
            Console.WriteLine("Total Marks = " + marks);
            Console.WriteLine("Percentage " + percentage);
            if (percentage >= 85 && percentage <=100)
            {
                Console.WriteLine("Grade = A*");
            }
            else if (percentage >= 75 && percentage < 85)
            {
                Console.WriteLine("Grade = A");
            }
            else if (percentage >= 65 && percentage < 75)
            {
                Console.WriteLine("Grade = B");
            }
            else if (percentage >= 55 && percentage < 65)
            {
                Console.WriteLine("Grade = C");
            }
            else if (percentage < 55)
            {
                Console.WriteLine("Grade = F");
            }

            Console.WriteLine("========================================");
        }
    }
}
