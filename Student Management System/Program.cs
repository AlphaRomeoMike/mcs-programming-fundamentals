using System;
using System.IO;
using System.Threading;

namespace Student_Management_System
{
    class Program
    {
        static string file = "D:\\sms\\file.txt";
        static string welcome = "Welcome to Student Managememnt System";
        static string seperator = "==========================================";
        static string shortSperator = "---------------------------------------------";
        // Program starts here
        static void Main(string[] args)
        {
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);

            // Infinite loop until exited by pressing zero
            while (true)
            {
                // choices
                Console.WriteLine("Please select your choice");
                Console.WriteLine("1. Add a student");
                Console.WriteLine("2. Get a student");
                Console.WriteLine("3. Get students");
                Console.WriteLine("0. Exit");

                // Input any of the choices
                Console.WriteLine("Please enter the desired choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }
                else if (choice == 1)
                {
                    AddStudent();
                }
                else if (choice == 2)
                {
                    // Search student
                    GetStudent();
                }
                else if (choice == 3)
                {
                    GetAllStudents();
                }
                else
                {
                    // Show error
                    Console.WriteLine("Error: Invalid choice, please try again");
                }
            }
        }

        // Add a student
        static void AddStudent()
        {
            Console.Clear();
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);

            // Comma Seperated Format or CSV format, remember, no spaces
            Console.WriteLine("Please enter the student information in the given format");
            Console.WriteLine("Student Full Name,Student Father Name,Student Email,Student Phone,Class,Section");

            // Brings a specific file, with specific permissions from local disk
            FileStream fs = new FileStream(file, FileMode.Append);

            // Provides a transport layer between a console and a file
            StreamWriter sw = new StreamWriter(fs);

            string student = Console.ReadLine();

            // Writes the actual given data into the file
            sw.WriteLine(student);

            // Add delay to the program
            Console.WriteLine("Working on adding data to the file");
            Thread.Sleep(3000);

            Console.WriteLine("Student added succefully");

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        static void GetStudent()
        {
            Console.Clear();
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);

            Console.WriteLine("Please enter student\'s name, email or father\'s name");

            // Search value to be searched in the file
            string search = Console.ReadLine();

            int count = 0;

            // Read each line in the file
            foreach (string line in File.ReadLines(file))
            {
                // If the line contains the provided result
                if (line.Contains(search) && search != "")
                {
                    // Convert the line (string) to array
                    string[] student = line.Split(",");

                    // Unary increment counter
                    count++;

                    // Print data to console
                    Console.WriteLine($"Student Name: {student[0]}");
                    Console.WriteLine($"Fathers Name: {student[1]}");
                    Console.WriteLine($"Student Mail: {student[2]}");
                    Console.WriteLine($"Student Phone: {student[3]}");
                    Console.WriteLine($"Student Class: {student[4]}");
                    Console.WriteLine($"Student Section: {student[5]}");
                }
                else
                {
                    Console.WriteLine("Please provide valid information");
                }
            }
            Thread.Sleep(3000);
            // Show total count of search results
            Console.WriteLine($"Found {count} results");
            Console.WriteLine(shortSperator);
        }

        static void GetAllStudents()
        {
            Console.Clear();
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);

            int count = 0;

            foreach (string line in File.ReadLines(file))
            {
                string[] student = line.Split(",");

                count++;

                Console.WriteLine($"Student Name: {student[0]}");
                Console.WriteLine($"Fathers Name: {student[1]}");
                Console.WriteLine($"Student Mail: {student[2]}");
                Console.WriteLine($"Student Phone: {student[3]}");
                Console.WriteLine($"Student Class: {student[4]}");
                Console.WriteLine($"Student Section: {student[5]}");
                Console.WriteLine(shortSperator);
            }

            Thread.Sleep(3000);
            Console.WriteLine($"Found {count} results");
            Console.WriteLine(seperator);
        }
    }
}
