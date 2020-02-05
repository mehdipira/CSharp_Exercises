using System;

class CarCollection
{
	static void Main()
	{
		CarDetails[] mycars = new CarDetails[10];
		string make;
		string model;
		int year;
		string colour;
		string rego;

		for(int i = 0; i < mycars.Length; i++)
		{
			Console.WriteLine("Enter details for car {0}: ", i+1);
			Console.Write("Make: ");
			make = Console.ReadLine();
			Console.Write("Model: ");
			model = Console.ReadLine();
			Console.Write("Year: ");
			year = Convert.ToInt32(Console.ReadLine());
			Console.Write("Colour: ");
			colour = Console.ReadLine();
			Console.Write("Registration Number: ");
			rego = Console.ReadLine();

			mycars[i] = new CarDetails(make, model, year, colour, rego);
		}
		
		Console.Clear();
		for(int i = 0; i < mycars.Length; i++)
		{
			mycars[i].PrintDetails();
		}
	}
}