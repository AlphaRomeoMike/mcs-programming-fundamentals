using System;
using System.IO;
using System.Threading;

namespace Bill_Management_System
{
    class Program
    {
        static string welcome = "Welcome to Bill Management System";
        static string seperator = "==================================";
        static string shortSeperator = "--------------------------------------";
        static string file = @"D:\bms\file.txt"; //Vrebatim Literal;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(welcome);
                Console.WriteLine(seperator);
                Console.WriteLine("Please select any of the following options:");
                Console.WriteLine("1. Add Bill");
                Console.WriteLine("2. Get All Bills");
                Console.WriteLine("3. Search A Bill By Username");
                Console.WriteLine("4. Search A Bill By Company");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }
                else if (choice == 1)
                {
                    if (AddBill())
                    {
                        Console.Clear();
                        Console.WriteLine("User added successfully");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
                else if (choice == 2)
                {
                    RetrieveBills();
                }
                else if (choice == 3)
                {
                    SearchUserBills();
                }
                else if (choice == 4)
                {
                    SearchBillByType();
                }
            }
        }

        static bool AddBill ()
        {
            bool success;

            Console.Clear();
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);
            Console.WriteLine("Add new bill");
            Console.WriteLine(shortSeperator);
            Console.WriteLine("Please enter the details as mentioned below");
            Console.WriteLine("Name,Email,Phone Number,Bill Type,Amount,Dues");
            Console.WriteLine("Example: Test User,testuser@gmail.com,0900-78601,SSGC,120,0");

            // Starting File system operation
            FileStream fs = new FileStream(file, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string bill = Console.ReadLine();

            sw.WriteLine(bill);

            sw.Close();
            fs.Close();


            return success = true;
        }

        static void RetrieveBills ()
        {
            Console.Clear();
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);

            int counter = 0;
            foreach (string line in File.ReadLines(file))
            {
                string[] bill = line.Split(",");

                Console.WriteLine($"Customer name: {bill[0]}"); // "Customer name: " + bill[0]
                Console.WriteLine($"Customer email: {bill[1]}");
                Console.WriteLine($"Customer number: {bill[2]}");
                Console.WriteLine($"Bill Type: {bill[3]}");
                Console.WriteLine($"Bill Amount: {bill[4]}");
                Console.WriteLine($"Bill Dues: {bill[5]}");
                Console.WriteLine(shortSeperator);
                counter++;
            }
            Console.WriteLine($"{counter} bills retrieved");
            Thread.Sleep(5000);
        }

        static void SearchUserBills ()
        {
            Console.Clear();
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);
            Console.WriteLine("Search a bill by username");
            string name = Console.ReadLine();

            int counter = 0;
            foreach (string line in File.ReadLines(file))
            {
                if (line.Contains(name))
                {
                    string[] bill = line.Split(",");

                    Console.WriteLine($"Customer name: {bill[0]}"); // "Customer name: " + bill[0]
                    Console.WriteLine($"Customer email: {bill[1]}");
                    Console.WriteLine($"Customer number: {bill[2]}");
                    Console.WriteLine($"Bill Type: {bill[3]}");
                    Console.WriteLine($"Bill Amount: {bill[4]}");
                    Console.WriteLine($"Bill Dues: {bill[5]}");
                    Console.WriteLine(shortSeperator);
                    counter++;
                }
            }
            Console.WriteLine($"{counter} bills retrieved");
            Thread.Sleep(5000);
        }

        static void SearchBillByType ()
        {
            Console.Clear();
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);
            Console.WriteLine("Search a bill by bill type/company");
            string type = Console.ReadLine();

            int counter = 0;
            foreach (string line in File.ReadLines(file))
            {
                if (line.Contains(type))
                {
                    string[] bill = line.Split(",");

                    Console.WriteLine($"Customer name: {bill[0]}"); // "Customer name: " + bill[0]
                    Console.WriteLine($"Customer email: {bill[1]}");
                    Console.WriteLine($"Customer number: {bill[2]}");
                    Console.WriteLine($"Bill Type: {bill[3]}");
                    Console.WriteLine($"Bill Amount: {bill[4]}");
                    Console.WriteLine($"Bill Dues: {bill[5]}");
                    Console.WriteLine(shortSeperator);
                    counter++;
                }
            }
            Console.WriteLine($"{counter} bills retrieved");
            Thread.Sleep(5000);
        }
    }
}
