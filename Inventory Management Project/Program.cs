using System;
using System.IO;

namespace Inventory_Management_Project
{
    class Program
    {
        public static string seperator = "---------------------------------------";
        public static string usersFile = @"D:\ims\users.txt"; // Verbatim Literal
        public static string productsFile = @"D:\ims\products.txt"; // Verbatim Literal
        public static string ordersFile = @"D:\ims\sales.txt"; // Verbatim Literal
        public static string theme;
        public static string welcome = "Welcome to Inventory Management System";
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a theme\n1 for Light Mode\nLeave empty for standard Dark mode");
            string userTheme = Console.ReadLine();
            Theme(userTheme);
            Console.WriteLine(welcome);
            Console.WriteLine(seperator);

            while (true)
            {
                int choice;

                Console.WriteLine("Please select the option you want to perform");
                Console.WriteLine("1. Add a user");
                Console.WriteLine("2. Add a product");
                Console.WriteLine("3. Search a user");
                Console.WriteLine("4. Search a product");
                Console.WriteLine("5. Retrieve all users");
                Console.WriteLine("6. Retrieve all products");


                Console.WriteLine("Please choose your selection or press \"0\" to quit");
                choice = int.Parse(Console.ReadLine());

                // Check for user choice
                if (choice == 1)
                {
                    AddUser();
                }
                else if(choice == 2)
                {
                    AddProduct();
                }
                else if (choice == 3)
                {
                    SearchUser();
                }
                else if (choice == 5)
                {
                    AllUsers();
                }
                else if (choice == 6)
                {
                    AllProducts();
                }
                else if (choice == 0)
                {
                    break;
                }
            }
        }

        static string Theme(string mode)
        {

            if (mode == "1")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                return theme = "Light";
            }
            else if (mode == "2")
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                return theme = "Dark";
            }
            else
            {
                return "";
            }
        }

        static void AddUser ()
        {
            try
            {
                FileStream fs = new FileStream(usersFile, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine(seperator);
                Console.WriteLine("Please enter the following in order seperated by comma (,).");
                Console.WriteLine("Name,Email,Phone (eg. Muhammad Azam Khan,mazamkhan@gmail.com,0900-78601");
                string user = Console.ReadLine();

                sw.WriteLine(user);
                sw.Flush();

                Console.WriteLine("User has been added successfully");

                sw.Close();
                fs.Close();
            }
            catch (FileLoadException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
        }

        static void AddProduct ()
        {
            try
            {
                FileStream fs = new FileStream(productsFile, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine(seperator);
                Console.WriteLine("Please enter the following in order seperated by comma (,).");
                Console.WriteLine("Name,Quantity,Category,Manufacturer,Supplier (eg. TUC Biscuit,200,English Biscuits,Manufacturer,Kashan Ahmed");
                string product = Console.ReadLine();

                sw.WriteLine(product);
                sw.Flush();

                Console.WriteLine("Product has been added successfully");

                sw.Close();
                fs.Close();
            }
            catch (FileLoadException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
        }

        static void SearchUser ()
        {
            try
            {
                FileStream fs = new FileStream(usersFile, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine("Search user");
                Console.WriteLine(seperator);
                Console.WriteLine("Please enter any user's name");
                string user = Console.ReadLine();
                string search = sr.ReadLine();

                int count = 0;

                while (user != null)
                {
                    if (search.Contains(search))
                    {
                        count++;
                        search.Split(',', StringSplitOptions.None);
                        Console.WriteLine($"Name:  {search[0]}");
                        Console.WriteLine($"Email: {search[1]}");
                        Console.WriteLine($"Phone: {search[2]}");

                    }
                }

                Console.WriteLine($"Found {count} results");

                Console.WriteLine("User found");

                sr.Close();
                fs.Close();
            }
            catch (FileLoadException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
        }

        static void AllUsers ()
        {
            try
            {
                FileStream fs = new FileStream(usersFile, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine("List of users details");
                Console.WriteLine(seperator);

                int counter = 0;
                foreach (string lines in File.ReadLines(usersFile))
                {
                    string[] users = lines.Split(",");

                    Console.WriteLine($"User name: {users[0]}");
                    Console.WriteLine($"User mail: {users[1]}");
                    Console.WriteLine($"User phone: {users[2]}");
                    Console.WriteLine("=======================================");
                    counter++;
                }
                Console.WriteLine($"{counter} users have been retrieved successfully");

                sr.Close();
                fs.Close();
            }
            catch (FileLoadException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
        }

        static void AllProducts ()
        {
            try
            {
                FileStream fs = new FileStream(productsFile, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine("List of product details");
                Console.WriteLine(seperator);

                int counter = 0;
                foreach (string line in File.ReadLines(productsFile))
                {
                    string[] product = line.Split(",");
                    Console.WriteLine($"Product Name: {product[0]}");
                    Console.WriteLine($"Product Quantity: {product[1]} boxes");
                    Console.WriteLine($"Product Category: {product[2]}");
                    Console.WriteLine($"Product Manufacturer: {product[3]}");
                    Console.WriteLine($"Product Supplier: {product[4]}");
                    Console.WriteLine("=======================================");
                    counter++;
                }
                Console.WriteLine($"{counter} Products have been retrieved successfully");

                sr.Close();
                fs.Close();
            }
            
            catch (FileLoadException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
        }
    }

}
