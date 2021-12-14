using System;

public class Program
{
	public static string divider = "--------------------------------------------------------------------------";
	public static void Main()
	{
		int choice;
		while (true)
		{
			Console.WriteLine("Please select any one of the following choices");
			Console.WriteLine("1. KE");
			Console.WriteLine("2. PE");
			Console.WriteLine("3. Degrees to Radians");
			Console.WriteLine("4. Student Information System");
			Console.WriteLine("5. Faranheit to Centigrade");
			Console.WriteLine("6. Quit");
			Console.Write("Your choice? ");
			choice = Convert.ToInt32(Console.ReadLine());
			if (choice == 1)
			{
				Console.Clear();
				Console.WriteLine("Calculating Kinetic Energy");
				Console.WriteLine(divider);
				Console.WriteLine("Please enter the mass");
				double mass = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Please enter the velocity");
				double velocity = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("The kinetic energy is " + KineticEnergy(mass, velocity));
				Console.WriteLine(divider);
			}
			else if (choice == 2)
			{
				Console.Clear();
				Console.WriteLine("Calculating Potential Energy");
				Console.WriteLine(divider);
				Console.WriteLine("Please enter the mass");
				double mass = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Please enter the height");
				double height = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("The potential energy is " + PotentialEnergy(mass, height));
				Console.WriteLine(divider);
			}
			else if (choice == 3)
			{
				Console.Clear();
				Console.WriteLine("Calculating Degrees From Radians");
				Console.WriteLine(divider);
				Console.WriteLine("Please enter degrees");
				double degrees = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("The radian are " + DegreeToRadians(degrees) + " rads");
				Console.WriteLine(divider);
			}
			else if (choice == 4)
			{
				Console.Clear();
				Console.WriteLine("Student grading system");
				Console.WriteLine(divider);
				Console.WriteLine("Please enter Student's name");
				string name = Console.ReadLine();
				Console.WriteLine("Please enter Student's father name");
				string father = Console.ReadLine();
				Console.WriteLine("Please enter Student's email");
				string email = Console.ReadLine();
				Console.WriteLine("Please enter Student's Maths marks");
				int maths = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please enter Student's English marks");
				int english = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please enter Student's Science marks");
				int science = Convert.ToInt32(Console.ReadLine());
				SMS(name, father, email, maths, english, science);
			}
		}
	}

	public static double KineticEnergy(double mass, double velocity)
	{
		double velocitySquared = Math.Pow(velocity, 2);
		return 0.5 * mass * velocitySquared;
	}

	public static double PotentialEnergy(double mass, double height)
	{
		return mass * 9.8 * height;
	}

	public static double DegreeToRadians(double degree)
	{
		return degree / (Math.PI * 180);
	}

	public static void SMS(string name, string fathername, string email, int maths, int english, int science)
	{
		Console.Clear();
		if (maths > 100 || maths < 0 || english > 100 || english < 0 || science > 100 || science < 0)
		{
			Console.WriteLine("Please enter valid values");
			return;
		}

		int obtainedMarks = maths + english + science;
		int totalMarks = 300;
		int percentage = obtainedMarks / totalMarks * 100;
		Console.WriteLine(divider);
		Console.WriteLine("Student Name " + name);
		Console.WriteLine("Father's name Name " + fathername);
		Console.WriteLine("===================================");
		Console.WriteLine("English: " + english);
		Console.WriteLine("Mathematic: " + maths);
		Console.WriteLine("Science: " + science);
		Console.WriteLine("Obtained Marks: " + obtainedMarks);
		Console.WriteLine("Total Marks: " + totalMarks);
		Console.WriteLine("Percentage: " + percentage);
		if (percentage >= 80 && percentage <= 100)
		{
			Console.WriteLine("Grade: A");
			Console.WriteLine("Result: Passes");
		}
		else if (percentage >= 70 && percentage < 80)
		{
			Console.WriteLine("Grade: B");
			Console.WriteLine("Result: Passes");
		}
		else if (percentage >= 60 && percentage < 70)
		{
			Console.WriteLine("Grade: C");
			Console.WriteLine("Result: Promoted");
		}
		else if (percentage >= 50 && percentage < 60)
		{
			Console.WriteLine("Grade: D");
			Console.WriteLine("Result: Promoted");
		}
		else if (percentage < 50 && percentage > 100)
		{
			Console.WriteLine("Grade: F");
			Console.WriteLine("Result: Fails");
		}

		Console.WriteLine("===================================");
	}
}
